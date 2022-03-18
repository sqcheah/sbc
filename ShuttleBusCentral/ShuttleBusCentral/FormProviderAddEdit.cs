using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{

    public partial class FormProviderAddEdit : Form
    {
        FormMain parentForm = null;
        Provider providerData = null;
        public long id = -1;
        public FormProviderAddEdit(FormMain form, Provider p = null)
        {
            providerData = p;
            parentForm = form;
            InitializeComponent();
            lblMessage.Visible = false;
            if (providerData != null)
            {
                txtName.Text = providerData.name;
                txtIC.Text = providerData.IC;
                txtEmail.Text = providerData.email;
                txtPhoneNum.Text = providerData.phoneNum;
                txtCompany.Text = providerData.company;
                txtName.Enabled = false;
                txtIC.Enabled = false;
                txtEmail.Enabled = false;
                txtPhoneNum.Enabled = false;
                txtCompany.Enabled = false;
                lblTitle.Text = "View Provider";
                btnAddUpdate.Text = "Update";
                id = long.Parse(providerData.id);
            }
            else
            {
                lblTitle.Text = "Add New Provider";
                btnAddDriver.Enabled = btnAddVehicle.Enabled = false;
            }

        }

        private void FormProviderAddEdit_Load(object sender, EventArgs e)
        {
            ReloadDriverData();
            dgvDriver.Columns["licenseNo"].Visible = false;
            dgvDriver.Columns["class"].Visible = false;
            dgvDriver.Columns["status"].Visible = false;
            dgvDriver.Columns["reason"].Visible = false;
            dgvDriver.Columns["image"].Visible = false;
            ReloadVehicleData();
            dgvVehicle.Columns["provider"].Visible = false;
            dgvVehicle.Columns["permitNo"].Visible = false;
            dgvVehicle.Columns["PFromDate"].Visible = false;
            dgvVehicle.Columns["PExpiryDate"].Visible = false;
            dgvVehicle.Columns["roadtax"].Visible = false;
            dgvVehicle.Columns["RExpiryDate"].Visible = false;
            dgvVehicle.Columns["mileage"].Visible = false;
            dgvVehicle.Columns["insuranceNo"].Visible = false;
        }



        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            if (btnAddUpdate.Text == "Update")
            {
                txtName.Enabled = true;
                txtIC.Enabled = true;
                txtEmail.Enabled = true;
                txtPhoneNum.Enabled = true;
                txtCompany.Enabled = true;
                lblTitle.Text = "Update Provider";
                btnAddUpdate.Text = "Save";
                return;
            }
            string name = txtName.Text.Trim();
            string IC = txtIC.Text.Trim();
            string phoneNum = txtPhoneNum.Text.Trim();
            string email = txtEmail.Text.Trim();
            string company = txtCompany.Text.Trim();


            //https://stackoverflow.com/questions/34298857/check-whether-a-textbox-is-empty-or-not
            if (String.IsNullOrEmpty(phoneNum) || String.IsNullOrEmpty(IC) || String.IsNullOrEmpty(email))
            {

                ShowMessage("Some required field is blank", true);
                return;
            }
            if (Regex.Matches(phoneNum, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid phone number format", true);
                return;
            }
            phoneNum = phoneNum.TrimStart('0');
            if (Regex.Matches(phoneNum, @"^11[0-9]{8}|1[02-9][0-9]{7}$").Count == 0)
            {
                ShowMessage("Invalid Malaysia phone number format", true);
                return;
            }
            if (Regex.Matches(IC, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid IC format", true);
                return;
            }
            if (Regex.Matches(email, @"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$").Count == 0)
            {
                ShowMessage("Invalid email format", true);
                return;
            }

            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (providerData != null)
                {

                    string changes = "";
                    MyComd.CommandText = "UPDATE provider SET name=@name,IC=@IC,phoneNum=@phoneNum,email=@email,company=@company where id=@id";
                    if (providerData.name != name)
                    {
                        changes = "Changes on name";
                    }
                    if (providerData.IC != IC)
                    {
                        changes = "Changes on IC";
                    }
                    if (providerData.phoneNum != phoneNum)
                    {
                        changes = "Changes on phoneNum";
                    }
                    if (providerData.email != email)
                    {
                        changes = "Changes on email";
                    }
                    MyComd.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    MyComd.CommandText = "INSERT INTO provider (name,IC,phoneNum,email,company) VALUES (@name,@IC,@phoneNum,@email,@company);";
                }
                MyComd.Parameters.AddWithValue("@phoneNum", phoneNum);
                MyComd.Parameters.AddWithValue("@name", name);
                MyComd.Parameters.AddWithValue("@IC", IC);
                MyComd.Parameters.AddWithValue("@email", email);
                MyComd.Parameters.AddWithValue("@company", company);
                MyConn.Open();
                MyComd.ExecuteNonQuery();
                if (providerData == null)
                {
                    btnAddDriver.Enabled = btnAddVehicle.Enabled = true;
                    id = MyComd.LastInsertedId;
                }
                MessageBox.Show("Record Saved", "Records");
                if (btnAddUpdate.Text == "Add")
                {
                    string username = "SBC" + Program.GenerateRandomString(5);

                    string password = Program.GenerateRandomString(10);
                    string passwordhash = Program.encryptPassword(password);
                    MyComd.CommandText = "INSERT INTO user_account (username,password,provider) VALUES (@username,@password,@provider);";
                    MyComd.Parameters.AddWithValue("@username", username);
                    MyComd.Parameters.AddWithValue("@password", passwordhash);
                    MyComd.Parameters.AddWithValue("@provider", id);
                    MyComd.ExecuteNonQuery();
                    MessageBox.Show("Username: " + username + "\nPassword: " + password, "Provider Account");
                }
                if (providerData == null)
                {
                    providerData = new Provider();
                }
                providerData.id = Convert.ToString(id);
                providerData.IC = IC;
                providerData.email = email;
                providerData.phoneNum = phoneNum;
                providerData.company = company;

                txtName.Enabled = false;
                txtIC.Enabled = false;
                txtEmail.Enabled = false;
                txtPhoneNum.Enabled = false;
                txtCompany.Enabled = false;
                lblTitle.Text = "View Provider";
                btnAddUpdate.Text = "Update";
                MyConn.Close();


            }
            catch (Exception ex)
            {
                //????auto id no duplicate
                string msgLower = ex.Message.ToLower();
                if (msgLower.Contains("duplicate"))
                {
                    if (msgLower.Contains("primary"))
                    {
                        MessageBox.Show("Provider already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void ShowMessage(string text, bool error = false)
        {
            if (error)
            {
                lblMessage.BackColor = Color.Red;
            }
            else
            {
                lblMessage.BackColor = Color.Green;
            }
            lblMessage.Visible = true;
            lblMessage.Text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            // https://stackoverflow.com/questions/2395624/how-to-refresh-datagridview-when-closing-child-form
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            parentForm.openChildForm(new FormDriverAddEdit(parentForm, f: this, pid: id));

        }
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            parentForm.openChildForm(new FormVehicleAddEdit(parentForm, f: this, pid: id));


        }
        public void ReloadDriverData()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM driver where provider=@provider";
            MyComd.Parameters.AddWithValue("@provider", id);



            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control?view=netframeworkdesktop-4.8
            ///instead of datagridview
            dgvDriver.DataSource = dTable;
            MyConn.Close();
        }
        public void ReloadVehicleData()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM vehicle where provider=@provider";
            MyComd.Parameters.AddWithValue("@provider", id);



            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control?view=netframeworkdesktop-4.8
            ///instead of datagridview
            dgvVehicle.DataSource = dTable;
            MyConn.Close();
        }

        private void dgvVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvVehicle.CurrentRow;

            Vehicle v = new Vehicle();
            v.plateNo = row.Cells[0].Value.ToString();
            v.provider = row.Cells[1].Value.ToString();
            v.category = row.Cells[2].Value.ToString();
            v.capacity = row.Cells[3].Value.ToString();
            v.specification = row.Cells[4].Value.ToString();
            v.permitNo = row.Cells[5].Value.ToString();
            v.PFromDate = row.Cells[6].Value.ToString();
            v.PExpiryDate = row.Cells[7].Value.ToString();
            v.roadtax = row.Cells[8].Value.ToString();
            v.RExpiryDate = row.Cells[9].Value.ToString();
            v.status = row.Cells[10].Value.ToString();
            v.mileage = row.Cells[11].Value.ToString();
            v.insuranceNo = row.Cells[12].Value.ToString();

            parentForm.openChildForm(new FormVehicleAddEdit(parentForm, v: v));


        }

        private void dgvDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDriver.CurrentRow;

            Driver d = new Driver();
            d.id = row.Cells[0].Value.ToString();
            d.IC = row.Cells[1].Value.ToString();
            d.name = row.Cells[2].Value.ToString();
            d.licenseNo = row.Cells[3].Value.ToString();
            d.dclass = row.Cells[4].Value.ToString();
            d.phoneNum = row.Cells[5].Value.ToString();
            d.provider = row.Cells[6].Value.ToString();
            d.status = row.Cells[7].Value.ToString();
            d.reason = row.Cells[8].Value.ToString();

            parentForm.openChildForm(new FormDriverAddEdit(parentForm, d: d));

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
