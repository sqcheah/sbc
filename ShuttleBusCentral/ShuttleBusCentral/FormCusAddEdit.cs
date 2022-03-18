using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormCusAddEdit : Form
    {

        Customer cusData = null;
        FormMain parentForm = null;
        public FormCusAddEdit(FormMain form, Customer c = null)
        {
            cusData = c;
            parentForm = form;
            InitializeComponent();
            lblMessage.Visible = false;
            btnAddBooking.Visible = false;
            if (cusData != null)
            {
                txtPhoneNum.Text = cusData.phoneNum;
                txtPhoneNum.Enabled = false;
                txtName.Text = cusData.name;
                txtIC.Text = cusData.IC;
                txtEmail.Text = cusData.email;
                txtBankAcc.Text = cusData.bankAcc;
                txtName.Enabled = false;
                txtIC.Enabled = false;
                txtEmail.Enabled = false;
                txtBankAcc.Enabled = false;
                btnAddBooking.Visible = true;
                lblTitle.Text = "View Customer";
                btnAddUpdate.Text = "Update";

            }
            else
            {
                lblTitle.Text = "Add New Customer";
            }

        }

        private void btnAddUpdate_Click(object sender, System.EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            if (btnAddUpdate.Text == "Update")
            {
                txtName.Enabled = true;
                txtIC.Enabled = true;
                txtEmail.Enabled = true;
                txtBankAcc.Enabled = true;
                btnAddUpdate.Text = "Save";
                lblTitle.Text = "Update Customer";
                return;
            }

            string phoneNum = txtPhoneNum.Text.Trim();
            string name = txtName.Text.Trim();
            string IC = txtIC.Text.Trim();
            string email = txtEmail.Text.Trim();
            string bankAcc = txtBankAcc.Text.Trim();


            //https://stackoverflow.com/questions/34298857/check-whether-a-textbox-is-empty-or-not
            if (String.IsNullOrEmpty(phoneNum) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(IC) || String.IsNullOrEmpty(email))
            {

                ShowMessage("Something required field is blank", true);
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
            if (IC.Length != 12)
            {
                ShowMessage("Inavlid IC lengthm should be 12", true);
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
            if (!String.IsNullOrEmpty(bankAcc))
            {
                if (Regex.Matches(bankAcc, @"^\d+$").Count == 0)
                {
                    ShowMessage("Invalid bank account format", true);
                    return;
                }
            }
            else
            {
                bankAcc = null;
            }


            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (cusData != null)
                {

                    string changes = "";
                    MyComd.CommandText = "UPDATE customer SET name=@name,IC=@IC,bankAcc=@bankAcc,email=@email where phoneNum=@phoneNum;";
                    if (cusData.name != name)
                    {
                        changes = "Changes on name";
                    }
                    if (cusData.IC != IC)
                    {
                        changes = "Changes on IC";
                    }
                    if (cusData.bankAcc != bankAcc)
                    {
                        changes = "Changes on bankAcc";
                    }
                    if (cusData.email != email)
                    {
                        changes = "Changes on email";
                    }
                }
                else
                {
                    MyComd.CommandText = "INSERT INTO customer (phoneNum,name,IC,bankAcc,email) VALUES (@phoneNum,@name,@IC,@bankAcc,@email);";
                }
                MyComd.Parameters.AddWithValue("@phoneNum", phoneNum);
                MyComd.Parameters.AddWithValue("@name", name);
                MyComd.Parameters.AddWithValue("@IC", IC);
                MyComd.Parameters.AddWithValue("@bankAcc", bankAcc);
                MyComd.Parameters.AddWithValue("@email", email);

                MyConn.Open();
                MyComd.ExecuteNonQuery();
                //MyReader = MyComd.ExecuteReader();
                MessageBox.Show("Record Saved", "Records");
                txtName.Enabled = false;
                txtIC.Enabled = false;
                txtEmail.Enabled = false;
                txtBankAcc.Enabled = false;
                txtPhoneNum.Enabled = false;
                btnAddUpdate.Text = "Update";
                lblTitle.Text = "View Customer";

                if (cusData == null)
                {
                    cusData = new Customer();
                }
                cusData.name = name;
                cusData.IC = IC;
                cusData.email = email;
                cusData.bankAcc = bankAcc;
                cusData.phoneNum = phoneNum;
                MyConn.Close();

            }
            catch (Exception ex)
            {
                string msgLower = ex.Message.ToLower();
                if (msgLower.Contains("duplicate"))
                {
                    if (msgLower.Contains("primary"))
                    {
                        MessageBox.Show("Phone Number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            FormBookingAddEdit formBooking = new FormBookingAddEdit(parentForm, c: cusData);
            parentForm.openChildForm(formBooking);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
