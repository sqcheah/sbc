using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormDriverAddEdit : Form
    {
        Driver driverData = null;
        FormMain parentForm = null;
        FormProviderAddEdit subParentForm = null;
        long providerID = -1;
        public FormDriverAddEdit(FormMain form, FormProviderAddEdit f = null, long pid = -1, Driver d = null)
        {
            parentForm = form;
            driverData = d;
            subParentForm = f;
            InitializeComponent();
            providerID = pid;
            lblMessage.Visible = false;
            if (driverData != null)
            {
                txtName.Text = driverData.name;
                txtIC.Text = driverData.IC;
                txtPhoneNum.Text = driverData.phoneNum;
                txtLicenseNo.Text = driverData.licenseNo;
                txtClass.Text = driverData.dclass;
                comboBoxStatus.Text = driverData.status;
                txtReason.Text = driverData.reason;
                txtName.Enabled = false;
                txtIC.Enabled = false;
                txtPhoneNum.Enabled = false;
                txtLicenseNo.Enabled = false;
                txtClass.Enabled = false;
                comboBoxStatus.Enabled = false;
                txtReason.Enabled = false;
                lblTitle.Text = "View Driver";
                btnAddUpdate.Text = "Update";
            }
            else
            {
                lblTitle.Text = "Add New Driver";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            subParentForm?.ReloadDriverData();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;

            if (btnAddUpdate.Text == "Update")
            {
                txtName.Enabled = true;
                txtIC.Enabled = true;
                txtPhoneNum.Enabled = true;
                txtLicenseNo.Enabled = true;
                txtClass.Enabled = true;
                comboBoxStatus.Enabled = true;
                txtReason.Enabled = true;
                lblTitle.Text = "Update Driver";
                btnAddUpdate.Text = "Save";
                return;
            }

            string name = txtName.Text.Trim();
            string IC = txtIC.Text.Trim();
            string phoneNum = txtPhoneNum.Text.Trim();
            string licenseNo = txtLicenseNo.Text.Trim();
            string dClass = txtClass.Text.Trim();
            string status = comboBoxStatus.Text;
            string reason = txtReason.Text.Trim();


            //https://stackoverflow.com/questions/34298857/check-whether-a-textbox-is-empty-or-not
            if (String.IsNullOrEmpty(phoneNum) || String.IsNullOrEmpty(IC) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(licenseNo) || String.IsNullOrEmpty(dClass) || String.IsNullOrEmpty(status))
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
            if (Regex.Matches(IC, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid IC format", true);
                return;
            }
            if (Regex.Matches(licenseNo, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid licenseNo format", true);
                return;
            }
            if (status == "UNAVAILABLE" && String.IsNullOrEmpty(reason))
            {
                ShowMessage("Reason cannot be empty for status UNAVAILABLE", true);
                return;
            }
            if (status == "FREE")
            {
                reason = null;
                txtReason.Text = "";
            }


            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (driverData != null)
                {

                    string changes = "";
                    MyComd.CommandText = "UPDATE driver SET name=@name,phoneNum=@phoneNum,licenseNo=@licenseNo,class=@dClass,status=@status,reason=@reason where IC=@IC";
                    if (driverData.name != name)
                    {
                        changes = "Changes on name";
                    }
                    if (driverData.phoneNum != phoneNum)
                    {
                        changes = "Changes on phoneNum";
                    }
                    if (driverData.licenseNo != licenseNo)
                    {
                        changes = "Changes on licenseNo";
                    }
                    if (driverData.dclass != dClass)
                    {
                        changes = "Changes on dClass";
                    }
                    if (driverData.status != status)
                    {
                        changes = "Changes on status";
                    }

                }
                else
                {
                    MyComd.CommandText = "INSERT INTO driver (name,IC,phoneNum,licenseNo,class,provider,status,reason) VALUES (@name,@IC,@phoneNum,@licenseNo,@dClass,@provider,@status,@reason);";
                    MyComd.Parameters.AddWithValue("@provider", providerID);
                }
                MyComd.Parameters.AddWithValue("@phoneNum", phoneNum);
                MyComd.Parameters.AddWithValue("@name", name);
                MyComd.Parameters.AddWithValue("@IC", IC);
                MyComd.Parameters.AddWithValue("@licenseNo", licenseNo);
                MyComd.Parameters.AddWithValue("@dClass", dClass);
                MyComd.Parameters.AddWithValue("@status", status);
                MyComd.Parameters.AddWithValue("@reason", reason);
                MyConn.Open();
                MyComd.ExecuteNonQuery();
                MessageBox.Show("Record Saved", "Records");
                txtName.Enabled = false;
                txtIC.Enabled = false;
                txtPhoneNum.Enabled = false;
                txtLicenseNo.Enabled = false;
                txtClass.Enabled = false;
                comboBoxStatus.Enabled = false;
                txtReason.Enabled = false;
                lblTitle.Text = "View Driver";
                btnAddUpdate.Text = "Update";
                if (driverData == null)
                {
                    driverData = new Driver();
                }
                driverData.name = name;
                driverData.IC = IC;
                driverData.phoneNum = phoneNum;
                driverData.licenseNo = licenseNo;
                driverData.dclass = dClass;
                driverData.status = status;
                driverData.reason = reason;

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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
