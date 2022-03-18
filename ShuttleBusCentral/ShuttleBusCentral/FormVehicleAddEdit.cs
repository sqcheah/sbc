using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormVehicleAddEdit : Form
    {
        Vehicle vehicleData = null;
        FormMain parentForm = null;
        FormProviderAddEdit subParentForm = null;
        long providerID = -1;
        public FormVehicleAddEdit(FormMain form, FormProviderAddEdit f = null, long pid = -1, Vehicle v = null)
        {
            parentForm = form;
            vehicleData = v;
            providerID = pid;
            subParentForm = f;
            InitializeComponent();
            lblMessage.Visible = false;
            if (vehicleData != null)
            {
                txtPlateNo.Text = vehicleData.plateNo;
                txtPlateNo.Enabled = false;
                comboCategory.SelectedItem = vehicleData.category;
                txtCapacity.Text = vehicleData.capacity;
                txtSpecification.Text = vehicleData.specification;
                txtMileage.Text = vehicleData.mileage;
                txtPermitNo.Text = vehicleData.permitNo;
                dtPermitFromDate.Value = Convert.ToDateTime(vehicleData.PFromDate);
                dtPermitExpiryDate.Value = Convert.ToDateTime(vehicleData.PExpiryDate);
                txtRoadTax.Text = vehicleData.roadtax;
                dtRoadTaxExpiryDate.Value = Convert.ToDateTime(vehicleData.RExpiryDate);
                comboStatus.Text = vehicleData.status;

                comboCategory.Enabled = false;
                txtCapacity.Enabled = false;
                txtSpecification.Enabled = false;
                txtMileage.Enabled = false;
                txtPermitNo.Enabled = false;
                dtPermitFromDate.Enabled = false;
                dtPermitExpiryDate.Enabled = false;
                txtRoadTax.Enabled = false;
                dtRoadTaxExpiryDate.Enabled = false;
                comboStatus.Enabled = false;
                txtInsuranceNo.Enabled = false;

                lblTitle.Text = "View Vehicle";
                btnAddUpdate.Text = "Update";
                return;

            }
            else
            {

            http://net-informations.com/q/faq/combovalue.html
                lblTitle.Text = "Add New Vehicle";
                dtPermitFromDate.Value = DateTime.Now;
                dtPermitExpiryDate.Value = DateTime.Now;
                dtRoadTaxExpiryDate.Value = DateTime.Now;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            subParentForm?.ReloadVehicleData();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lblMessage.Visible)
                lblMessage.Visible = false;
            if (btnAddUpdate.Text == "Update")
            {
                comboCategory.Enabled = true;
                txtCapacity.Enabled = true;
                txtSpecification.Enabled = true;
                txtMileage.Enabled = true;
                txtPermitNo.Enabled = true;
                dtPermitFromDate.Enabled = true;
                dtPermitExpiryDate.Enabled = true;
                txtRoadTax.Enabled = true;
                dtRoadTaxExpiryDate.Enabled = true;
                comboStatus.Enabled = true;
                txtInsuranceNo.Enabled = true;

                lblTitle.Text = "Update Vehicle";
                btnAddUpdate.Text = "Save";
                return;
            }

            string plateNo = txtPlateNo.Text.Trim();
            string category = comboCategory.Text.Trim();
            string capacity = txtCapacity.Text.Trim();
            string specification = txtSpecification.Text.Trim();
            string permitNo = txtPermitNo.Text.Trim();
            string PFromDate = dtPermitFromDate.Value.ToString("yyyy-MM-dd");
            string PExpiryDate = dtPermitExpiryDate.Value.ToString("yyyy-MM-dd");
            string RExpiryDate = dtPermitExpiryDate.Value.ToString("yyyy-MM-dd");
            string roadtax = txtRoadTax.Text.Trim();
            string mileage = txtMileage.Text.Trim();
            string status = comboStatus.Text.Trim();
            string insuranceNo = txtInsuranceNo.Text.Trim();


            //https://stackoverflow.com/questions/34298857/check-whether-a-textbox-is-empty-or-not
            if (String.IsNullOrEmpty(plateNo) || String.IsNullOrEmpty(category) || String.IsNullOrEmpty(capacity) || String.IsNullOrEmpty(status))
            {

                ShowMessage("Some required field is blank", true);
                return;
            }
            if (Regex.Matches(capacity, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid capacity format", true);
                return;
            }

            if (permitNo != "" && Regex.Matches(permitNo, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid permitNo format", true);
                return;
            }
            if (roadtax != "" && Regex.Matches(roadtax, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid roadtax format", true);
                return;
            }
            if (mileage != "" && Regex.Matches(mileage, @"^\d+[.]{0,1}\d*$").Count == 0)
            {
                ShowMessage("Invalid mileage format", true);
                return;
            }
            if (DateTime.Compare(dtPermitExpiryDate.Value.Date, dtPermitFromDate.Value.Date) < 0)
            {
                ShowMessage("Expiry date must be later than from date", true);
                return;
            }

            if (String.IsNullOrEmpty(status))
            {
                status = null;
            }
            plateNo = plateNo.ToUpper();
            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (vehicleData != null)
                {
                    if (vehicleData.provider != Convert.ToString(Program.providerID))
                    {
                        if (roadtax == "")
                        {
                            roadtax = null;
                        }
                        if (permitNo == "")
                        {
                            permitNo = null;
                        }
                        if (insuranceNo == "")
                        {
                            insuranceNo = null;
                        }
                        if (mileage == "")
                        {
                            mileage = null;
                        }
                    }
                    string changes = "";
                    MyComd.CommandText = "UPDATE vehicle SET category=@category,capacity=@capacity,specification=@specification,permitNo=@permitNo,PFromDate=@PFromDate,PExpiryDate=@PExpiryDate,RExpiryDate=@RExpiryDate,roadtax=@roadtax,mileage=@mileage,insuranceNo=@insuranceNo where plateNo=@plateNo";
                    if (vehicleData.specification != specification)
                    {
                        changes = "Changes on specification";
                    }
                    if (vehicleData.roadtax != roadtax)
                    {
                        changes = "Changes on roadtax";
                    }
                    if (vehicleData.permitNo != permitNo)
                    {
                        changes = "Changes on permitNo";
                    }
                    if (vehicleData.capacity != capacity)
                    {
                        changes = "Changes on capacity";
                    }
                    if (vehicleData.category != category)
                    {
                        changes = "Changes on category";
                    }
                    if (vehicleData.insuranceNo != insuranceNo)
                    {
                        changes = "Changes on insuranceNo";
                    }


                }
                else
                {
                    MyComd.CommandText = "INSERT INTO vehicle (plateNo,category,capacity,specification,permitNo,PFromDate,PExpiryDate,RExpiryDate,roadtax,mileage,status,provider,insuranceNo) VALUES (@plateNo,@category,@capacity,@specification,@permitNo,@PFromDate,@PExpiryDate,@RExpiryDate,@roadtax,@mileage,@status,@provider,@insuranceNo);";
                    MyComd.Parameters.AddWithValue("@provider", providerID);
                }
                MyComd.Parameters.AddWithValue("@plateNo", plateNo);
                MyComd.Parameters.AddWithValue("@category", category);
                MyComd.Parameters.AddWithValue("@capacity", capacity);
                MyComd.Parameters.AddWithValue("@specification", specification);
                MyComd.Parameters.AddWithValue("@permitNo", permitNo);
                MyComd.Parameters.AddWithValue("@PFromDate", PFromDate);
                MyComd.Parameters.AddWithValue("@PExpiryDate", PExpiryDate);
                MyComd.Parameters.AddWithValue("@RExpiryDate", RExpiryDate);
                MyComd.Parameters.AddWithValue("@roadtax", roadtax);
                MyComd.Parameters.AddWithValue("@mileage", mileage);
                MyComd.Parameters.AddWithValue("@status", status);
                MyComd.Parameters.AddWithValue("@insuranceNo", insuranceNo);

                MyConn.Open();
                MyComd.ExecuteNonQuery();
                MessageBox.Show("Record Saved", "Records");
                txtPlateNo.Enabled = false;
                comboCategory.Enabled = false;
                txtCapacity.Enabled = false;
                txtSpecification.Enabled = false;
                txtMileage.Enabled = false;
                txtPermitNo.Enabled = false;
                dtPermitFromDate.Enabled = false;
                dtPermitExpiryDate.Enabled = false;
                txtRoadTax.Enabled = false;
                dtRoadTaxExpiryDate.Enabled = false;
                comboStatus.Enabled = false;
                txtInsuranceNo.Enabled = false;

                lblTitle.Text = "View Vehicle";
                btnAddUpdate.Text = "Update";
                if (vehicleData == null)
                {
                    vehicleData = new Vehicle();
                }
                vehicleData.plateNo = plateNo;
                vehicleData.category = category;
                vehicleData.capacity = capacity;
                vehicleData.specification = specification;
                vehicleData.mileage = mileage;
                vehicleData.permitNo = permitNo;
                vehicleData.PFromDate = PFromDate;
                vehicleData.PExpiryDate = PExpiryDate;
                vehicleData.roadtax = roadtax;
                vehicleData.RExpiryDate = RExpiryDate;
                vehicleData.status = status;
                vehicleData.insuranceNo = insuranceNo;
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
    }
}
