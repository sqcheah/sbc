using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormBooking : Form
    {
        private FormMain parentForm = null;
        public FormBooking(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            dtDepartureDate.Value = DateTime.Now;
            dtArrivalDate.Value = DateTime.Now;
            dtCreatedAt.Value = DateTime.Now;

        }

        private void FormBooking_Load(object sender, EventArgs e)
        {

            ReloadBookingData();
            dgvBooking.Columns["passenger"].Visible = false;
            dgvBooking.Columns["remarks"].Visible = false;
            dgvBooking.Columns["provider"].Visible = false;
            dgvBooking.Columns["vehicle"].Visible = false;
            dgvBooking.Columns["driver1"].Visible = false;
            dgvBooking.Columns["driver2"].Visible = false;
            dgvBooking.Columns["paid"].Visible = false;



        }
        public void ReloadBookingData()
        {
            int searchFieldCount = 0;
            string searchStr = "WHERE ";
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM booking";
            string searchTxt = txtCusID.Text.Trim();
            if (!String.IsNullOrEmpty(searchTxt))
            {

                if (Regex.Matches(searchTxt, @"^\d+$").Count == 0)
                {
                    errorProvider1.SetError(txtCusID, "Not a number");
                    //https://stackoverflow.com/questions/4143428/is-there-a-way-to-force-a-tooltip-to-show

                    return;
                }
                errorProvider1.Clear();
                searchTxt = searchTxt.TrimStart('0');

                MyComd.Parameters.AddWithValue("@cusID", "%" + searchTxt + "%");
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "cusID LIKE @cusID";
                searchFieldCount++;
            }
            if (!String.IsNullOrEmpty(comboBoxStatus.Text))
            {
                MyComd.Parameters.AddWithValue("@status", comboBoxStatus.Text);
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "status=@status";
                searchFieldCount++;
            }
            if (!String.IsNullOrEmpty(comboBoxPaid.Text))
            {
                if (comboBoxPaid.Text == "TRUE")
                {
                    MyComd.Parameters.AddWithValue("@paid", 1);
                }
                else
                {
                    MyComd.Parameters.AddWithValue("@paid", 0);
                }
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "paid=@paid";
                searchFieldCount++;
            }
            if (dtDepartureDate.Checked)
            {
                MyComd.Parameters.AddWithValue("@departureDate", dtDepartureDate.Value.ToString("yyyy-MM-dd"));
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "departureDate>=@departureDate";
                searchFieldCount++;
            }
            if (dtArrivalDate.Checked)
            {
                MyComd.Parameters.AddWithValue("@arrivalDate", dtArrivalDate.Value.ToString("yyyy-MM-dd"));
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "arrivalDate<=@arrivalDate";
                searchFieldCount++;
            }
            if (dtCreatedAt.Checked)
            {
                MyComd.Parameters.AddWithValue("@createdAt", dtCreatedAt.Value.ToString("yyyy-MM-dd"));
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "createdAt>=@createdAt";
                searchFieldCount++;
            }
            if (searchFieldCount > 0)
            {
                MyComd.CommandText = "SELECT * FROM booking " + searchStr;
                Console.WriteLine(searchStr);
            }



            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);

            dgvBooking.DataSource = dTable;
            MyConn.Close();
        }


        private void btnAddCus_Click(object sender, EventArgs e)
        {
            parentForm.openChildForm(new FormBookingAddEdit(parentForm));
        }

        private void dgvBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBooking.CurrentRow;

            Booking b = new Booking();
            b.id = row.Cells[0].Value.ToString();
            b.cusID = row.Cells[1].Value.ToString();
            b.passenger = row.Cells[2].Value.ToString();
            b.remarks = row.Cells[3].Value.ToString();
            b.departureDate = row.Cells[4].Value.ToString();
            b.departureTime = row.Cells[5].Value.ToString();
            b.departureLocation = row.Cells[6].Value.ToString();
            b.arrivalDate = row.Cells[7].Value.ToString();
            b.arrivalTime = row.Cells[8].Value.ToString();
            b.arrivalLocation = row.Cells[9].Value.ToString();
            b.createdAt = row.Cells[10].Value.ToString();
            b.status = row.Cells[11].Value.ToString();
            b.provider = row.Cells[12].Value.ToString();
            b.vehicle = row.Cells[13].Value.ToString();
            b.driver1 = row.Cells[14].Value.ToString();
            b.driver2 = row.Cells[15].Value.ToString();
            b.paid = row.Cells[16].Value.ToString();

            parentForm.openChildForm(new FormBookingAddEdit(parentForm, b));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadBookingData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCusID.Text = "";
            comboBoxStatus.Text = "";
            comboBoxPaid.Text = "";
            dtDepartureDate.Checked = false;
            dtDepartureDate.Value = DateTime.Now;
            dtArrivalDate.Checked = false;
            dtArrivalDate.Value = DateTime.Now;
            ReloadBookingData();
        }

        private void btnAutoCancel_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(Program.Conn);
                MySqlCommand MyComd = MyConn.CreateCommand();
                MyComd.CommandText = "UPDATE booking SET status='CANCEL' WHERE id IN (SELECT id FROM booking where datediff(CURRENT_DATE,date(createdAt))>=1 AND (paid=0 OR status='PENDING') ANDdatediff(date(departureDate),CURRENT_DATE)<=1)";
                MySqlDataReader MyReader;

                MyConn.Open();
                MyReader = MyComd.ExecuteReader();

                MyConn.Close();
                MessageBox.Show("Done checking, " + MyReader.RecordsAffected + " booking records affected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
