using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            lblMessage.Visible = false;
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * from settings";

            MySqlDataReader MyReader;
            try
            {
                MyConn.Open();

                MyReader = MyComd.ExecuteReader();
                if (MyReader.HasRows)
                {
                    while (MyReader.Read())
                    {
                        if (MyReader.GetFieldValue<string>(MyReader.GetOrdinal("skey")) == "permitDayBefore")
                        {
                            txtPermitDayBefore.Text = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("svalue"));
                        }
                        else if (MyReader.GetFieldValue<string>(MyReader.GetOrdinal("skey")) == "mileageLimit")
                        {
                            txtMileageLimit.Text = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("svalue"));
                        }
                    }
                }
                MyReader.Close();
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMileageLimit.Enabled = false;
            txtPermitDayBefore.Enabled = false;
            lblTitle.Text = "View Settings";
            btnAddUpdate.Text = "Update";
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

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            if (btnAddUpdate.Text == "Update")
            {
                txtMileageLimit.Enabled = true;
                txtPermitDayBefore.Enabled = true;
                lblTitle.Text = "Update Settings";
                btnAddUpdate.Text = "Save";
                return;
            }


            string mileageLimit = txtMileageLimit.Text;
            string permitDayBefore = txtPermitDayBefore.Text;
            if (String.IsNullOrEmpty(mileageLimit) || String.IsNullOrEmpty(permitDayBefore))
            {
                ShowMessage("Something blank", true);
            }
            if (Regex.Matches(mileageLimit, @"^\d+$").Count == 0)
            {
                ShowMessage("mileageLimit error", true);
                return;
            }
            if (Regex.Matches(permitDayBefore, @"^\d+$").Count == 0)
            {
                ShowMessage("permitDayBefore error", true);
                return;
            }
            permitDayBefore = permitDayBefore.TrimStart('0');
            mileageLimit = mileageLimit.TrimStart('0');
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "UPDATE settings SET svalue=@svalue WHERE skey=@skey";
            MyComd.Parameters.AddWithValue("@skey", "mileageLimit");
            MyComd.Parameters.AddWithValue("@svalue", mileageLimit);
            MyConn.Open();
            MyComd.ExecuteNonQuery();
            MyComd.Parameters.Clear();
            MyComd.Parameters.AddWithValue("@skey", "permitDayBefore");
            MyComd.Parameters.AddWithValue("@svalue", permitDayBefore);
            MyComd.ExecuteNonQuery();
            MyConn.Close();
            ShowMessage("success");
            MessageBox.Show("Record Saved", "Records");
            txtMileageLimit.Enabled = false;
            txtPermitDayBefore.Enabled = false;
            lblTitle.Text = "View Settings";
            btnAddUpdate.Text = "Update";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
