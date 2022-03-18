using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShuttleBusCentral
{

    public partial class FormServiceAddEdit : Form
    {
        Service serviceData = null;
        FormMain parentForm = null;
        public FormServiceAddEdit(FormMain form, Service s = null)
        {
            serviceData = s;
            parentForm = form;
            InitializeComponent();
            lblMessage.Visible = false;
            if (serviceData != null)
            {
                txtVehicle.Text = serviceData.vehicle;
                txtVehicle.Enabled = false;
                txtReason.Text = serviceData.reason;
                txtDescription.Text = serviceData.description;
                dtStartDate.Value = Convert.ToDateTime(serviceData.startDate);
                dtEndDate.Value = Convert.ToDateTime(serviceData.endDate);
                comboType.Text = serviceData.type;
                txtMileage.Text = serviceData.mileage;
                txtReason.Enabled = false;
                txtDescription.Enabled = false;
                dtStartDate.Enabled = false;
                dtEndDate.Enabled = false;
                comboType.Enabled = false;
                txtMileage.Enabled = false;
                lblTitle.Text = "View Service";
                btnAddUpdate.Text = "Update";

            }
            else
            {

            http://net-informations.com/q/faq/combovalue.html
                lblTitle.Text = "Add New Service";
                dtStartDate.Value = DateTime.Now;
                dtEndDate.Value = DateTime.Now;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            if (btnAddUpdate.Text == "Update")
            {
                txtReason.Enabled = true;
                txtDescription.Enabled = true;
                dtStartDate.Enabled = true;
                dtEndDate.Enabled = true;
                comboType.Enabled = true;
                txtMileage.Enabled = true;
                lblTitle.Text = "Update Service";
                btnAddUpdate.Text = "Save";
                return;
            }

            string vehicle = txtVehicle.Text.Trim();
            string reason = txtReason.Text.Trim();
            string description = txtDescription.Text.Trim();

            string startDate = dtStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtEndDate.Value.ToString("yyyy-MM-dd");

            string type = comboType.Text;
            string mileage = txtMileage.Text.Trim();



            //https://stackoverflow.com/questions/34298857/check-whether-a-textbox-is-empty-or-not
            if (String.IsNullOrEmpty(vehicle) || String.IsNullOrEmpty(reason) || String.IsNullOrEmpty(type))
            {

                ShowMessage("Some required field is blank", true);
                return;
            }
            if (type == "MILEAGE" && String.IsNullOrEmpty(mileage))
            {
                ShowMessage("Mileage cannot be empty", true);
                return;
            }
            if (mileage == "")
            {
                mileage = null;
            }

            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (serviceData != null)
                {

                    string changes = "";
                    MyComd.CommandText = "UPDATE service SET reason=@reason,description=@description,startDate=@startDate,endDate=@endDate,type=@type,mileage=@mileage where id=@id";
                    if (serviceData.reason != reason)
                    {
                        changes = "Changes on reason";
                    }
                    if (serviceData.description != description)
                    {
                        changes = "Changes on description";
                    }
                    if (serviceData.startDate != startDate)
                    {
                        changes = "Changes on startDate";
                    }
                    if (serviceData.endDate != endDate)
                    {
                        changes = "Changes on endDate";
                    }
                    if (serviceData.type != type)
                    {
                        changes = "Changes on type";
                    }
                    if (serviceData.mileage != mileage)
                    {
                        changes = "Changes on mileage";
                    }

                    MyComd.Parameters.AddWithValue("@id", serviceData.id);
                }
                else
                {
                    MyComd.CommandText = "INSERT INTO service (vehicle,reason,description,startDate,endDate,type,mileage) VALUES (@vehicle,@reason,@description,@startDate,@endDate,@type,@mileage);";
                    MyComd.Parameters.AddWithValue("@vehicle", vehicle);
                }
                MyComd.Parameters.AddWithValue("@reason", reason);
                MyComd.Parameters.AddWithValue("@description", description);
                MyComd.Parameters.AddWithValue("@startDate", startDate);
                MyComd.Parameters.AddWithValue("@endDate", endDate);
                MyComd.Parameters.AddWithValue("@type", type);
                MyComd.Parameters.AddWithValue("@mileage", mileage);

                MyConn.Open();
                MyComd.ExecuteNonQuery();
                MessageBox.Show("Record Saved", "Records");
                txtReason.Enabled = false;
                txtDescription.Enabled = false;
                dtStartDate.Enabled = false;
                dtEndDate.Enabled = false;
                comboType.Enabled = false;
                txtMileage.Enabled = false;
                lblTitle.Text = "View Service";
                btnAddUpdate.Text = "Update";
                if (serviceData == null)
                {
                    serviceData = new Service();
                }
                serviceData.vehicle = vehicle;
                serviceData.reason = reason;
                serviceData.description = description;
                serviceData.startDate = startDate;
                serviceData.endDate = endDate;
                serviceData.type = type;
                serviceData.mileage = mileage;
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
