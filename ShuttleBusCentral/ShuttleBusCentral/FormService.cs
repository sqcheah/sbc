using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormService : Form
    {
        private FormMain parentForm = null;
        public FormService(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            ReloadServiceData();
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now;
            dgvService.Columns["mileage"].Visible = false;
        }
        public void ReloadServiceData()
        {
            int searchFieldCount = 0;
            string searchStr = "WHERE ";
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM service ORDER BY startDate DESC";
            if (!String.IsNullOrEmpty(comboBoxType.Text))
            {

                MyComd.Parameters.AddWithValue("@vehicle", "%" + comboBoxType.Text.ToUpper() + "%");

                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "vehicle LIKE @vehicle";
                searchFieldCount++;
            }

            if (!String.IsNullOrEmpty(comboBoxType.Text))
            {

                MyComd.Parameters.AddWithValue("@type", comboBoxType.Text);

                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "type=@type";
                searchFieldCount++;
            }
            if (dtStartDate.Checked)
            {
                MyComd.Parameters.AddWithValue("@startDate", dtStartDate.Value.ToString("yyyy-MM-dd"));
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "startDate>=@startDate";
                searchFieldCount++;
            }
            if (dtEndDate.Checked)
            {
                MyComd.Parameters.AddWithValue("@endDate", dtEndDate.Value.ToString("yyyy-MM-dd"));
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "endDate<=@endDate";
                searchFieldCount++;
            }
            if (searchFieldCount > 0)
            {
                MyComd.CommandText = "SELECT * FROM service " + searchStr;
                Console.WriteLine(searchStr);
            }


            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvService.DataSource = dTable;
            MyConn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadServiceData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVehicle.Text = "";
            comboBoxType.Text = "";

            dtStartDate.Checked = false;
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Checked = false;
            dtEndDate.Value = DateTime.Now;
            ReloadServiceData();
        }

        private void dgvService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvService.CurrentRow;

            Service s = new Service();
            s.id = row.Cells[0].Value.ToString();
            s.vehicle = row.Cells[1].Value.ToString();
            s.reason = row.Cells[2].Value.ToString();
            s.description = row.Cells[3].Value.ToString();
            s.startDate = row.Cells[4].Value.ToString();
            s.endDate = row.Cells[5].Value.ToString();
            s.type = row.Cells[6].Value.ToString();
            s.mileage = row.Cells[7].Value.ToString();
            parentForm.openChildForm(new FormServiceAddEdit(parentForm, s));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
