using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormAccountAddEdit : Form
    {
        FormMain parentForm = null;
        Account accData = null;
        public FormAccountAddEdit(FormMain form, Account a = null)
        {
            parentForm = form;
            accData = a;
            InitializeComponent();
            lblMessage.Visible = false;
            if (accData != null)
            {
                txtUsername.Text = accData.username;
                comboBoxStatus.Text = accData.status;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                comboBoxStatus.Enabled = false;
                btnAddUpdate.Text = "Update";
                lblTitle.Text = "View Account";
            }
            else
            {

                lblTitle.Text = "Add New Admin Account";
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            if (btnAddUpdate.Text == "Update")
            {
                comboBoxStatus.Enabled = true;
                txtPassword.Enabled = true;
                btnAddUpdate.Text = "Save";

                lblTitle.Text = "Update Account";
                return;
            }

            string password = txtPassword.Text;
            string username = txtUsername.Text;
            string status = comboBoxStatus.Text;
            string passwordStr = "";
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(status))
            {
                ShowMessage("Username or password is blank", true);
                return;
            }
            if (btnAddUpdate.Text == "Add" && String.IsNullOrEmpty(password))
            {
                ShowMessage("Password cannot be blank", true);
                return;
            }

            if (btnAddUpdate.Text == "Save" && !String.IsNullOrEmpty(password))
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Change Password", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    passwordStr += ",password=@password";
                    password = Program.encryptPassword(password);
                }
                else
                {
                    password = "";
                    txtPassword.Text = "";
                    return;
                }

            }

            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (accData != null)
                {

                    string changes = "";
                    MyComd.CommandText = "UPDATE user_account SET status=@status" + passwordStr + " WHERE username=@username;";
                    if (accData.status != status)
                    {
                        changes = "Changes on name";
                    }
                }
                else
                {
                    MyComd.CommandText = "INSERT INTO user_account (username,password,acc_type,status) VALUES (@username,@password,@acc_type,@status)";
                    password = Program.encryptPassword(password);
                    MyComd.Parameters.AddWithValue("@acc_type", "ADMIN");
                }
                MyComd.Parameters.AddWithValue("@username", username);
                MyComd.Parameters.AddWithValue("@password", password);
                MyComd.Parameters.AddWithValue("@status", status);



                MyConn.Open();
                MyComd.ExecuteNonQuery();
                //MyReader = MyComd.ExecuteReader();
                MessageBox.Show("Record Saved", "Records");
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtPassword.Text = "";
                comboBoxStatus.Enabled = false;
                if (accData == null)
                {
                    accData = new Account();
                    accData.acc_type = "ADMIN";
                }
                accData.username = username;
                accData.password = "";
                accData.status = status;

                btnAddUpdate.Text = "Update";
                lblTitle.Text = "View Account";
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
        }
    }
}
