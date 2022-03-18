using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            customizeDesign();
            check();
        }

        private void customizeDesign()
        {
            panelSubMenuCustomer.Visible = false;
            panelSubMenuProvider.Visible = false;
            panelSubMenuBooking.Visible = false;
            panelSubMenuService.Visible = false;
            panelSubMenuAudit.Visible = false;
            panelSubMenuNotification.Visible = false;
            panelSubMenuAccount.Visible = false;
            panelSubMenuSettings.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuCustomer.Visible)
                panelSubMenuCustomer.Visible = false;
            if (panelSubMenuProvider.Visible)
                panelSubMenuProvider.Visible = false;
            if (panelSubMenuBooking.Visible)
                panelSubMenuBooking.Visible = false;
            if (panelSubMenuService.Visible)
                panelSubMenuService.Visible = false;
            if (panelSubMenuAudit.Visible)
                panelSubMenuAudit.Visible = false;
            if (panelSubMenuNotification.Visible)
                panelSubMenuNotification.Visible = false;
            if (panelSubMenuAccount.Visible)
                panelSubMenuAccount.Visible = false;
            if (panelSubMenuSettings.Visible)
                panelSubMenuSettings.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCustomer);
        }

        private void btnSubMenuCus1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCustomer(this));
        }
        private void btnSubMenuCus2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCusAddEdit(this));
        }


        private Form activeChildForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                if (activeChildForm as FormProviderAddEdit != null && (childForm as FormDriverAddEdit != null || childForm as FormVehicleAddEdit != null))
                {

                }
                else if (activeChildForm as FormBookingAddEdit != null && (childForm as FormCusAddEdit != null))
                {

                }
                else
                {
                    activeChildForm.Close();
                }
            }
            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            childForm.Focus();

        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuProvider);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuBooking);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuService);
        }

        private void btnSubMenuProvider1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProvider(this));
        }

        private void btnSubMenuProvider2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProviderAddEdit(this));
        }

        private void btnSubMenuBooking1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBooking(this));
        }

        private void btnSubMenuBooking2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBookingAddEdit(this));
        }

        private void btnSubMenuService1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormService(this));
        }

        private void btnSubMenuService2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormServiceAddEdit(this));
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAudit);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuNotification);
        }

        private void btnSubMenuAudit1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAudit(this));
        }

        private void buttonSubMenuNotification1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNotification(this));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new FormLogin());
        }
        private void check()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * from settings";
            MySqlDataReader MyReader;
            int permitDayBefore = -1;
            int mileageLimit = -1;
            string lastDateCheck = "";
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
                            permitDayBefore = int.Parse(MyReader.GetFieldValue<string>(MyReader.GetOrdinal("svalue")));
                        }
                        else if (MyReader.GetFieldValue<string>(MyReader.GetOrdinal("skey")) == "mileageLimit")
                        {
                            mileageLimit = int.Parse(MyReader.GetFieldValue<string>(MyReader.GetOrdinal("svalue")));
                        }
                        else if (MyReader.GetFieldValue<string>(MyReader.GetOrdinal("skey")) == "lastDateCheck")
                        {
                            lastDateCheck = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("svalue"));
                        }
                    }
                }
                MyReader.Close();
                DateTime now = DateTime.Now;
                if (DateTime.Compare(Convert.ToDateTime(lastDateCheck), now.Date) < 0)
                {
                    //mileageDayCheck == (int)now.DayOfWeek

                    MySqlCommand AComd = MyConn.CreateCommand();
                    AComd.CommandText = "SELECT plateNo,mileage FROM vehicle WHERE provider=@provider";
                    AComd.Parameters.AddWithValue("@provider", Program.providerID);
                    MySqlDataReader AReader;
                    AReader = AComd.ExecuteReader();
                    if (AReader.HasRows)
                    {
                        while (AReader.Read())
                        {
                            MySqlConnection AConn = new MySqlConnection(Program.Conn);
                            string vehicleNo = AReader.GetFieldValue<string>(AReader.GetOrdinal("plateNo"));
                            int mileage1 = AReader.GetFieldValue<int>(AReader.GetOrdinal("mileage"));

                            MySqlCommand BComd = AConn.CreateCommand();
                            BComd.CommandText = "SELECT mileage FROM service where vehicle=@vehicleNo and type='MILEAGE' ORDER BY endDate DESC LIMIT 0,1";
                            BComd.Parameters.AddWithValue("@vehicleNo", vehicleNo);

                            AConn.Open();
                            MySqlDataReader BReader;
                            BReader = BComd.ExecuteReader();
                            MySqlConnection BConn = new MySqlConnection(Program.Conn);
                            if (BReader.HasRows)
                            {
                                BReader.Read();
                                int mileage2 = BReader.GetFieldValue<int>(AReader.GetOrdinal("mileage"));
                                if ((mileage1 - mileage2) > mileageLimit)
                                {
                                    MySqlCommand CComd = BConn.CreateCommand();
                                    CComd.CommandText = "INSERT INTO notification (recipient,title,description) VALUES (@recipient,@title,@description)";
                                    CComd.Parameters.AddWithValue("@recipient", Program.providerID);
                                    CComd.Parameters.AddWithValue("@title", "Mileage Checking on " + vehicleNo);
                                    CComd.Parameters.AddWithValue("@description", "Mileage exceed by " + Convert.ToString(mileage1 - mileage2));
                                    BConn.Open();
                                    CComd.ExecuteNonQuery();
                                    BConn.Close();

                                }
                            }
                            else
                            {
                                if ((mileage1 - 0) > mileageLimit)
                                {
                                    MySqlCommand CComd = BConn.CreateCommand();
                                    CComd.CommandText = "INSERT INTO notification (recipient,title,description) VALUES (@recipient,@title,@description)";
                                    CComd.Parameters.AddWithValue("@recipient", Program.providerID);
                                    CComd.Parameters.AddWithValue("@title", "Mileage Checking on " + vehicleNo);
                                    CComd.Parameters.AddWithValue("@description", "Mileage exceed by " + Convert.ToString(mileage1 - 0));
                                    BConn.Open();
                                    CComd.ExecuteNonQuery();
                                    BConn.Close();

                                }
                            }
                            BReader.Close();
                            AConn.Close();
                        }
                    }
                    AReader.Close();


                    ///Permit Check
                    AComd.Parameters.Clear();
                    AComd.CommandText = "SELECT plateNo,pExpiryDate FROM vehicle WHERE provider=@provider";
                    AComd.Parameters.AddWithValue("@provider", Program.providerID);
                    AReader = AComd.ExecuteReader();
                    if (AReader.HasRows)
                    {
                        while (AReader.Read())
                        {
                            string vehicleNo = AReader.GetFieldValue<string>(AReader.GetOrdinal("plateNo"));
                            DateTime pExpiryDate = AReader.GetFieldValue<DateTime>(AReader.GetOrdinal("pExpiryDate"));
                            int dayDiff = (pExpiryDate.Date - now.Date).Days;
                            if (dayDiff <= permitDayBefore)
                            {
                                MySqlConnection AConn = new MySqlConnection(Program.Conn);
                                MySqlCommand BComd = AConn.CreateCommand();
                                BComd.CommandText = "INSERT INTO notification (recipient,title,description) VALUES (@recipient,@title,@description)";
                                BComd.Parameters.AddWithValue("@recipient", Program.providerID);
                                BComd.Parameters.AddWithValue("@title", "Permit checking on " + vehicleNo);
                                BComd.Parameters.AddWithValue("@description", dayDiff >= 0 ? "Permit will be expire in " + dayDiff + " days." : "Permit expired,please renew as soon as possible.");
                                AConn.Open();
                                BComd.ExecuteNonQuery();
                                AConn.Close();
                            }
                        }
                    }

                    MyComd.Parameters.Clear();
                    MyComd.CommandText = "UPDATE settings SET lastDateCheck=@today";
                    MyComd.Parameters.AddWithValue("@today", now.ToString("yyyy-MM-dd"));
                    MyComd.ExecuteNonQuery();

                }
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAccount);
        }

        private void btnSubMenuAccount1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAccount(this));
        }

        private void btnSubMenuAccount2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAccountAddEdit(this));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuSettings);
        }

        private void btnSubMenuSettings1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSettings());
        }
    }

}
