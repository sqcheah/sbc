using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ShuttleBusCentral
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            lblMessage.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            string username = this.usernameText.Text;
            string password = this.passwordText.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                ShowMessage("Username or password blank", true);
            }

            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * from user_account WHERE username=@username and acc_type='ADMIN'";
            MyComd.Parameters.AddWithValue("@username", username);

            MySqlDataReader MyReader;
            try
            {
                MyConn.Open();

                MyReader = MyComd.ExecuteReader();
                if (MyReader.HasRows)
                {
                    MyReader.Read();
                    //password at col3
                    //string dbpass = MyReader.GetString(2);
                    //https://stackoverflow.com/questions/28325813/sqldatareader-get-value-by-column-name-not-ordinal-number/42182943
                    string dbpass = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("password"));
                    string passwordhash = BCrypt.Net.BCrypt.HashPassword(password);
                    bool verified = BCrypt.Net.BCrypt.Verify(password, dbpass);

                    if (verified)
                    {
                        ShowMessage("Login success");
                        Program.username = username;
                        Program.userID = MyReader.GetFieldValue<int>(MyReader.GetOrdinal("id"));
                        //Console.WriteLine(Program.userID);
                        Program.SwitchMainForm(new FormMain());


                    }
                    else
                    {
                        ShowMessage("Login fail", true);
                    }
                }
                else
                {

                    ShowMessage("Login fail", true);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
