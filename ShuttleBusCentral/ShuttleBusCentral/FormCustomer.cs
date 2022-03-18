using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormCustomer : Form
    {

        private FormMain parentForm = null;
        public FormCustomer(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            ReloadCusData();


        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            parentForm.openChildForm(new FormCusAddEdit(parentForm));
        }


        public void ReloadCusData()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM customer";
            string searchTxt = txtPhoneNum.Text.Trim();
            int searchFieldCount = 0;
            string searchStr = "WHERE ";
            if (searchTxt.Length > 0)
            {
                if (Regex.Matches(searchTxt, @"^\d+$").Count == 0)
                {
                    errorProvider1.SetError(txtPhoneNum, "Not a number");
                    //https://stackoverflow.com/questions/4143428/is-there-a-way-to-force-a-tooltip-to-show

                    return;
                }
                errorProvider1.Clear();
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "phoneNum like @phoneNum";
                searchFieldCount++;


                MyComd.Parameters.AddWithValue("@phoneNum", "%" + searchTxt + "%");
            }
            if (searchFieldCount > 0)
            {
                MyComd.CommandText = "SELECT * FROM customer " + searchStr;
            }



            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control?view=netframeworkdesktop-4.8
            ///instead of datagridview
            dgvCus.DataSource = dTable;
            MyConn.Close();
        }




        private void dataGridViewCus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCus.CurrentRow;

            Customer c = new Customer();
            c.phoneNum = row.Cells[0].Value.ToString();
            c.name = row.Cells[1].Value.ToString();
            c.IC = row.Cells[2].Value.ToString();
            c.email = row.Cells[3].Value.ToString();
            c.bankAcc = row.Cells[4].Value.ToString();
            parentForm.openChildForm(new FormCusAddEdit(parentForm, c));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadCusData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPhoneNum.Text = "";
            ReloadCusData();
        }
    }
}
