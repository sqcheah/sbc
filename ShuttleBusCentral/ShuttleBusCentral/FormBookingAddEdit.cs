using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{

    public partial class FormBookingAddEdit : Form
    {

        Booking bookData = null;
        FormMain parentForm = null;
        public FormBookingAddEdit(FormMain form, Booking b = null, Customer c = null)
        {
            bookData = b;
            parentForm = form;
            InitializeComponent();
            lblMessage.Visible = false;
            txtCusName.Enabled = false;
            txtStatus.Enabled = false;

            if (bookData != null)
            {
                txtCusID.Text = bookData.cusID;

                txtPassenger.Text = bookData.passenger;
                txtRemarks.Text = bookData.remarks;
                txtDepartureLocation.Text = bookData.departureLocation;
                dtDepartureDate.Value = Convert.ToDateTime(bookData.departureDate);
                dtDepartureTime.Value = Convert.ToDateTime(bookData.departureTime);
                txtArrivalLocation.Text = bookData.arrivalLocation;
                dtArrivalDate.Value = Convert.ToDateTime(bookData.arrivalDate);
                dtArrivalTime.Value = Convert.ToDateTime(bookData.arrivalTime);
                comboVehicle.Text = bookData.vehicle;
                comboDriver1.Text = bookData.driver1;
                comboDriver2.Text = bookData.driver2;
                checkPublish.Checked = !(bookData.provider == Convert.ToString(Program.providerID));
                checkPaid.Checked = (bookData.paid == "1");
                txtCusID.Enabled = false;
                txtPassenger.Enabled = false;
                txtRemarks.Enabled = false;
                txtDepartureLocation.Enabled = false;
                dtDepartureDate.Enabled = false;
                dtDepartureTime.Enabled = false;
                txtArrivalLocation.Enabled = false;
                dtArrivalDate.Enabled = false;
                dtArrivalTime.Enabled = false;
                comboVehicle.Enabled = false;
                comboDriver1.Enabled = false;
                comboDriver2.Enabled = false;
                checkPublish.Enabled = false;
                btnCheckAvailable.Enabled = false;
                checkPaid.Enabled = false;
                if (bookData.status == "CANCEL")
                {
                    btnCancelBooking.Visible = false;
                }
                lblTitle.Text = "View Booking";
                btnAddUpdate.Text = "Update";
                checkAvailable();
            }
            else
            {
                if (c != null)
                {
                    txtCusID.Text = c.phoneNum;
                    txtCusName.Text = c.name;
                    txtCusID.Enabled = false;

                }
                btnCancelBooking.Visible = false;
                dtDepartureDate.Value = DateTime.Now;
                dtArrivalDate.Value = DateTime.Now;
                lblTitle.Text = "Add New Booking";
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
                if (bookData.status == "CANCEL")
                {
                    MessageBox.Show("Booking already cancelled. Cannot be updated anymore", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                lblTitle.Text = "Update Booking";
                btnAddUpdate.Text = "Save";
                txtPassenger.Enabled = true;
                txtRemarks.Enabled = true;
                txtDepartureLocation.Enabled = true;
                dtDepartureDate.Enabled = true;
                dtDepartureTime.Enabled = true;
                txtArrivalLocation.Enabled = true;
                dtArrivalDate.Enabled = true;
                dtArrivalTime.Enabled = true;
                checkPaid.Enabled = true;

                if (!(checkPublish.Checked && !String.IsNullOrEmpty(bookData.provider)))
                {
                    comboVehicle.Enabled = true;
                    comboDriver1.Enabled = true;
                    comboDriver2.Enabled = true;
                    btnCheckAvailable.Enabled = true;
                    checkPublish.Enabled = true;
                }

                return;
            }

            ///check if empty

            string cusID = txtCusID.Text.Trim();
            //phoneNum.TrimStart('0');
            string departureLocation = txtDepartureLocation.Text.Trim();
            string departureDate = dtDepartureDate.Value.ToString("yyyy-MM-dd");
            string departureTime = dtDepartureTime.Value.ToString("HH:mm");
            string arrivalLocation = txtArrivalLocation.Text.Trim();
            string arrivalDate = dtArrivalDate.Value.ToString("yyyy-MM-dd");
            string arrivalTime = dtArrivalTime.Value.ToString("HH:mm");
            string driver1 = (this.comboDriver1.SelectedItem as ComboBoxItem)?.Value;
            string vehicle = (this.comboVehicle.SelectedItem as ComboBoxItem)?.Value;
            string driver2 = (this.comboDriver2.SelectedItem as ComboBoxItem)?.Value;
            string passenger = txtPassenger.Text.Trim();
            string remarks = txtRemarks.Text.Trim();
            string status = (checkPublish.Checked ? "PENDING" : "BOOKED BUT NOT PAID");
            string paid = (checkPaid.Checked ? "1" : "0");



            //https://stackoverflow.com/questions/34298857/check-whether-a-textbox-is-empty-or-not
            if (String.IsNullOrEmpty(cusID) || String.IsNullOrEmpty(passenger) || String.IsNullOrEmpty(departureLocation) || String.IsNullOrEmpty(arrivalLocation))
            {

                ShowMessage("Something is blank", true);
                return;
            }
            if (Regex.Matches(passenger, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid passenger format", true);
                return;
            }
            if (!checkPublish.Checked && driver1 == driver2)
            {
                ShowMessage("Driver cannot be same", true);
                return;
            }
            if (DateTime.Compare(dtArrivalDate.Value.Date, dtDepartureDate.Value.Date) < 0)
            {
                ShowMessage("Arrival date must be later than departure date", true);
                return;
            }
            if (bookData == null && checkPublish.Checked)
            {
                vehicle = "";
                driver1 = "";
                driver2 = "";
            }
            if (!(vehicle != "" && driver1 != ""))
            {
                vehicle = bookData?.vehicle;
                driver1 = bookData?.driver1;
                driver2 = bookData?.driver2;
            }

            if (status == "BOOKED BUT NOT PAID" & paid == "1")
            {
                status = "BOOKED";
            }
            string changes = "";
            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                if (bookData != null)
                {

                    MyComd.CommandText = "UPDATE booking SET departureLocation=@departureLocation,departureDate=@departureDate,departureTime=@departureTime,arrivalLocation=@arrivalLocation,arrivalDate=@arrivalDate,arrivalTime=@arrivalTime,vehicle=@vehicle,driver1=@driver1,driver2=@driver2,passenger=@passenger,remarks=@remarks,status=@status,paid=@paid where id=@id;";
                    if (bookData.departureLocation != departureLocation)
                    {
                        changes = "Changes on departureLocation from " + bookData.departureLocation + " to " + departureLocation + "\n";
                    }
                    if (bookData.arrivalLocation != arrivalLocation)
                    {
                        changes = "Changes on arrivalLocation from " + bookData.arrivalLocation + " to " + arrivalLocation + "\n";
                    }
                    if (bookData.vehicle != vehicle)
                    {
                        changes = "Changes on vehicle from " + bookData.vehicle + " to " + vehicle + "\n";
                    }
                    if (bookData.driver1 != driver1)
                    {
                        changes = "Changes on driver1 from " + bookData.driver1 + " to " + driver1 + "\n";
                    }
                    if (bookData.driver2 != driver2)
                    {
                        changes = "Changes on driver2  from " + bookData.driver2 + " to " + driver2 + "\n";
                    }
                    if (bookData.departureDate != departureDate)
                    {
                        changes = "Changes on departureDate  from " + bookData.departureDate + " to " + departureDate + "\n";
                    }
                    if (bookData.departureTime != departureTime)
                    {
                        changes = "Changes on departureTime from " + bookData.departureTime + " to " + departureTime + "\n";
                    }
                    if (bookData.arrivalTime != arrivalTime)
                    {
                        changes = "Changes on arrivalTime from " + bookData.arrivalTime + " to " + arrivalTime + "\n";
                    }

                    if (bookData.arrivalDate != arrivalDate)
                    {
                        changes = "Changes on arrivalDate from " + bookData.arrivalDate + " to " + arrivalDate + "\n";
                    }
                    if (bookData.passenger != passenger)
                    {
                        changes = "Changes on passenger from " + bookData.passenger + " to " + passenger + "\n";
                    }
                    if (bookData.remarks != remarks)
                    {
                        changes = "Changes on remarks from " + bookData.remarks + " to " + remarks + "\n";
                    }
                    if (bookData.status != status)
                    {
                        changes = "Changes on status from " + bookData.status + " to " + status + "\n";
                    }
                    MyComd.Parameters.AddWithValue("@id", bookData.id);
                }
                else
                {
                    MyComd.CommandText = "INSERT INTO booking (cusID,departureLocation,departureDate,departureTime,arrivalLocation,arrivalDate,arrivalTime,vehicle,driver1,driver2,passenger,remarks,provider,status,paid) VALUES (@cusID,@departureLocation,@departureDate,@departureTime,@arrivalLocation,@arrivalDate,@arrivalTime,@vehicle,@driver1,@driver2,@passenger,@remarks,@provider,@status,@paid);";
                    MyComd.Parameters.AddWithValue("@cusID", cusID);
                    MyComd.Parameters.AddWithValue("@provider", (checkPublish.Checked ? null : (vehicle == "" ? null : Convert.ToString(Program.providerID))));
                }

                MyComd.Parameters.AddWithValue("@departureLocation", departureLocation);
                MyComd.Parameters.AddWithValue("@departureDate", departureDate);
                MyComd.Parameters.AddWithValue("@departureTime", departureTime);
                MyComd.Parameters.AddWithValue("@arrivalLocation", arrivalLocation);
                MyComd.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                MyComd.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                MyComd.Parameters.AddWithValue("@vehicle", vehicle);
                MyComd.Parameters.AddWithValue("@driver1", driver1);
                MyComd.Parameters.AddWithValue("@driver2", driver2);
                MyComd.Parameters.AddWithValue("@passenger", passenger);
                MyComd.Parameters.AddWithValue("@remarks", remarks);
                MyComd.Parameters.AddWithValue("@status", status);
                MyComd.Parameters.AddWithValue("@paid", paid);


                MyConn.Open();
                MyComd.ExecuteNonQuery();
                long id = MyComd.LastInsertedId;

                txtStatus.Text = status;
                //MyReader = MyComd.ExecuteReader();
                txtPassenger.Enabled = false;
                txtRemarks.Enabled = false;
                txtDepartureLocation.Enabled = false;
                dtDepartureDate.Enabled = false;
                dtDepartureTime.Enabled = false;
                txtArrivalLocation.Enabled = false;
                dtArrivalDate.Enabled = false;
                dtArrivalTime.Enabled = false;
                comboVehicle.Enabled = false;
                comboDriver1.Enabled = false;
                comboDriver2.Enabled = false;
                checkPublish.Enabled = false;
                checkPaid.Enabled = false;
                btnCheckAvailable.Enabled = false;
                btnCancelBooking.Visible = true;

                lblTitle.Text = "View Booking";
                btnAddUpdate.Text = "Update";


                MyComd.CommandText = "INSERT INTO audit(userID,type,description) VALUES (@userID,@type,@description)";
                MyComd.Parameters.AddWithValue("@userID", Program.userID);
                if (bookData != null)
                {
                    if (changes != "")
                    {
                        MyComd.Parameters.AddWithValue("@type", "UPDATE");
                        MyComd.Parameters.AddWithValue("@description", "Changes on booking ID " + bookData.id + "\n" + changes);
                        MyComd.ExecuteNonQuery();
                        if (bookData.provider != "1")
                        {
                            MySqlCommand AComd = MyConn.CreateCommand();
                            AComd.CommandText = "INSERT INTO notification (recipient,title,description) VALUES (@recipient,@title,@description)";
                            AComd.Parameters.AddWithValue("@recipient", bookData.provider);
                            AComd.Parameters.AddWithValue("@title", "Changes on booking ID " + bookData.id);
                            AComd.Parameters.AddWithValue("@description", changes);
                            AComd.ExecuteNonQuery();
                        }
                    }
                }
                else
                {

                    MyComd.Parameters.AddWithValue("@type", "INSERT");
                    MyComd.Parameters.AddWithValue("@description", "New booking ID " + id + " created on customer " + cusID);
                    MyComd.ExecuteNonQuery();
                }

                MessageBox.Show("Record Saved", "Records");
                MyConn.Close();
                if (bookData == null)
                {
                    bookData = new Booking();
                }
                bookData.id = Convert.ToString(id);
                bookData.cusID = cusID;
                bookData.passenger = passenger;
                bookData.remarks = remarks;
                bookData.departureDate = departureDate;
                bookData.departureTime = departureTime;
                bookData.departureLocation = departureLocation;
                bookData.arrivalDate = arrivalDate;
                bookData.arrivalTime = arrivalTime;
                bookData.arrivalLocation = arrivalLocation;
                bookData.status = status;
                bookData.provider = Convert.ToString(Program.providerID);
                bookData.vehicle = vehicle;
                bookData.driver1 = driver1;
                bookData.driver2 = driver2;
                bookData.paid = paid;



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

        private void btnCheckAvailable_Click(object sender, EventArgs e)
        {

            if (lblMessage.Visible)
                lblMessage.Visible = false;

            checkAvailable();

        }

        private void btnViewCus_Click(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            if (String.IsNullOrEmpty(cusID))
            {
                MessageBox.Show("CusID is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.Matches(cusID, @"^\d+$").Count == 0)
            {
                MessageBox.Show("Not a valid cusID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cusID = cusID.TrimStart('0');
            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                MyComd.CommandText = "SELECT * FROM customer WHERE phoneNum=@cusID";
                MyComd.Parameters.AddWithValue("@cusID", cusID);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyComd.ExecuteReader();
                if (MyReader.HasRows)
                {
                    MyReader.Read();
                    Customer c = new Customer();
                    c.bankAcc = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("bankAcc"));
                    c.phoneNum = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("phoneNum"));
                    c.IC = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("IC"));
                    c.name = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("name"));
                    c.email = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("email"));
                    parentForm.openChildForm(new FormCusAddEdit(parentForm, c));
                }
                else
                {
                    DialogResult res = MessageBox.Show("No Customer with cusID " + cusID + "\nDo you want to add new customer?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        parentForm.openChildForm(new FormCusAddEdit(parentForm));
                    }
                }
                MyReader.Close();
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                MyComd.CommandText = "UPDATE booking SET status=@status WHERE id=@id";
                MyComd.Parameters.AddWithValue("@id", bookData.id);
                MyComd.Parameters.AddWithValue("@status", "CANCEL");
                MyConn.Open();
                MyComd.ExecuteNonQuery();
                txtStatus.Text = "CANCEL";
                bookData.status = "CANCEL";
                int dayDiff = (dtDepartureDate.Value.Date - DateTime.Now.Date).Days;
                dayDiff = dayDiff > 0 ? dayDiff : 0;
                if (dayDiff >= 3)
                {
                    MessageBox.Show(dayDiff + " days earlier. 100% Refund", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dayDiff >= 2)
                {
                    MessageBox.Show(dayDiff + " days earlier. 50% Refund", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(dayDiff + " days earlier. No Refund", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                MyConn.Close();
                btnCancelBooking.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkAvailable()
        {
            string startDate = dtDepartureDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtArrivalDate.Value.ToString("yyyy-MM-dd");
            string passenger = txtPassenger.Text.Trim();

            if (Regex.Matches(passenger, @"^\d+$").Count == 0)
            {
                ShowMessage("Invalid passenger format", true);
                return;
            }
            if (DateTime.Compare(dtArrivalDate.Value.Date, dtDepartureDate.Value.Date) < 0)
            {
                ShowMessage("Arrival date must be later then departure date", true);
                return;
            }

            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();

            MySqlDataReader MyReader;
            try
            {
                MyConn.Open();
                MyComd.CommandText = "SELECT * FROM vehicle WHERE provider=@provider AND plateNo NOT IN (SELECT vehicle FROM service WHERE (startDate<@endDate AND endDate>@endDate) OR  (startDate<@startDate AND endDate>@startDate)OR  (startDate>=@startDate AND endDate<=@endDate)) AND plateNo NOT IN (SELECT vehicle FROM booking WHERE (departureDate<@endDate AND arrivalDate>@endDate) OR  (departureDate<@startDate AND arrivalDate>@startDate)OR  (departureDate>=@startDate AND arrivalDate<=@endDate)) AND capacity>=@passenger";
                MyComd.Parameters.AddWithValue("@startDate", startDate);
                MyComd.Parameters.AddWithValue("@endDate", endDate);
                MyComd.Parameters.AddWithValue("@passenger", passenger);

                MyComd.Parameters.AddWithValue("@provider", Program.providerID);

                MyReader = MyComd.ExecuteReader();
                comboVehicle.Items.Clear();
                if (MyReader.HasRows)
                {
                    int idk = 0;

                    while (MyReader.Read())
                    {

                        string plateNo = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("plateNo"));
                        // Console.WriteLine("{0}\t{1}", MyReader.GetFieldValue<string>(MyReader.GetOrdinal("plateNo")),   MyReader.GetString(idk));
                        this.comboVehicle.Items.Add(new ComboBoxItem(plateNo + ',' + MyReader.GetFieldValue<string>(MyReader.GetOrdinal("category")) + ',' + Convert.ToString(MyReader.GetFieldValue<int>(MyReader.GetOrdinal("capacity"))) + " seats" + ',' + MyReader.GetFieldValue<string>(MyReader.GetOrdinal("specification")), plateNo));
                        if (plateNo == bookData?.vehicle)
                        {

                            comboVehicle.SelectedIndex = idk;
                            //comboVehicle.Text = plateNo;
                        }

                        idk++;
                    }
                    if (String.IsNullOrEmpty(comboVehicle.Text))
                    {
                        this.comboVehicle.SelectedIndex = -1;
                    }
                }
                else
                {
                    checkPublish.Checked = true;
                    Console.WriteLine("No vehicle found.");
                }
                MyReader.Close();
                MyComd.Parameters.Clear();
                MyComd.CommandText = "SELECT * FROM driver WHERE provider=@provider AND status='FREE' AND id NOT IN (SELECT driver1 FROM booking WHERE (departureDate<@endDate AND arrivalDate>@endDate) OR  (departureDate<@startDate AND arrivalDate>@startDate)OR  (departureDate>=@startDate AND arrivalDate<=@endDate)) AND id NOT IN (SELECT driver2 FROM booking WHERE (departureDate<@endDate AND arrivalDate>@endDate) OR  (departureDate<@startDate AND arrivalDate>@startDate)OR  (departureDate>=@startDate AND arrivalDate<=@endDate))";
                MyComd.Parameters.AddWithValue("@provider", Program.providerID);
                MyComd.Parameters.AddWithValue("@startDate", startDate);
                MyComd.Parameters.AddWithValue("@endDate", endDate);
                MyComd.Parameters.AddWithValue("@status", "FREE");


                MyReader = MyComd.ExecuteReader();
                comboDriver1.Items.Clear();
                comboDriver2.Items.Clear();
                string driverID = "";
                if (MyReader.HasRows)
                {
                    int idk = 0;
                    while (MyReader.Read())
                    {
                        string driverName = MyReader.GetFieldValue<string>(MyReader.GetOrdinal("name"));
                        driverID = Convert.ToString(MyReader.GetFieldValue<int>(MyReader.GetOrdinal("id")));
                        this.comboDriver1.Items.Add(new ComboBoxItem(driverName, driverID));
                        if (driverID == bookData?.driver1)
                        {
                            comboDriver1.SelectedIndex = idk;
                            //comboDriver1.Text = driverName;
                        }
                        this.comboDriver2.Items.Add(new ComboBoxItem(driverName, driverID));
                        if (driverID == bookData?.driver2)
                        {
                            comboDriver2.SelectedIndex = idk;
                            //comboDriver2.Text = driverName;
                        }
                        idk++;
                    }
                }
                else
                {
                    checkPublish.Checked = true;
                    Console.WriteLine("No driver found.");
                }
                MyReader.Close();
                if (String.IsNullOrEmpty(comboDriver1.Text.Trim()))
                {
                    this.comboDriver1.SelectedIndex = -1;
                }
                if (String.IsNullOrEmpty(comboDriver2.Text.Trim()))
                {
                    this.comboDriver2.SelectedIndex = -1;
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
