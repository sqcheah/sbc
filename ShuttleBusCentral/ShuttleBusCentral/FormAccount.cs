using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormAccount : Form
    {
        FormMain parentForm = null;
        public FormAccount(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            ReloadAccountData();
            dgvAcc.Columns["provider"].Visible = false;
            dgvAcc.Columns["password"].Visible = false;

        }

        public void ReloadAccountData()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM user_account";
            int searchFieldCount = 0;
            string searchStr = "WHERE ";
            if (!String.IsNullOrEmpty(txtUsername.Text))
            {

                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "LOWER(username) like @username";
                searchFieldCount++;


                MyComd.Parameters.AddWithValue("@username", "%" + txtUsername.Text.ToLower() + "%");
            }
            if (!String.IsNullOrEmpty(comboBoxAccType.Text))
            {

                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "acc_type=@acc_type";
                searchFieldCount++;


                MyComd.Parameters.AddWithValue("@acc_type", comboBoxAccType.Text);
            }
            if (!String.IsNullOrEmpty(comboBoxStatus.Text))
            {

                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "status=@status";
                searchFieldCount++;


                MyComd.Parameters.AddWithValue("@status", comboBoxStatus.Text);
            }
            if (searchFieldCount > 0)
            {
                MyComd.CommandText = "SELECT * FROM user_account " + searchStr;
            }



            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control?view=netframeworkdesktop-4.8
            ///instead of datagridview
            dgvAcc.DataSource = dTable;
            MyConn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadAccountData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            comboBoxStatus.Text = "";
            comboBoxAccType.Text = "";
            ReloadAccountData();
        }

        private void dgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAcc.CurrentRow;

            Account a = new Account();
            a.id = row.Cells[0].Value.ToString();
            a.provider = row.Cells[1].Value.ToString();
            a.username = row.Cells[2].Value.ToString();
            a.password = row.Cells[3].Value.ToString();
            a.acc_type = row.Cells[4].Value.ToString();
            a.date_created = row.Cells[5].Value.ToString();
            a.status = row.Cells[6].Value.ToString();
            parentForm.openChildForm(new FormAccountAddEdit(parentForm, a));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
