using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormAudit : Form
    {
        private FormMain parentForm = null;
        public FormAudit(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            ReloadAuditData();
        }

        public void ReloadAuditData()
        {
            int searchFieldCount = 0;
            string searchStr = "WHERE ";
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT audit.id,audit.timestamp,user_account.username,audit.type,audit.description FROM audit JOIN user_account ON audit.userID=user_account.id ORDER BY timestamp DESC";
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
            if (!String.IsNullOrEmpty(txtUsername.Text))
            {
                MyComd.Parameters.AddWithValue("@username", txtUsername.Text);
                if (searchFieldCount != 0)
                {
                    searchStr += " AND ";
                }
                searchStr += "username=@username";
                searchFieldCount++;
            }
            if (searchFieldCount > 0)
            {
                MyComd.CommandText = "SELECT audit.id,audit.timestamp,user_account.username,audit.type,audit.description FROM audit JOIN user_account ON audit.userID=user_account.id " + searchStr + " ORDER BY timestamp DESC";
            }

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvAudit.DataSource = dTable;
            MyConn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadAuditData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBoxType.Text = "";
            txtUsername.Text = "";
            ReloadAuditData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAudit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAudit.CurrentRow;
            string user = row.Cells[2].Value.ToString();
            string type = row.Cells[3].Value.ToString();
            string description = row.Cells[4].Value.ToString();
            parentForm.openChildForm(new FormAuditView(user, type, description));
        }
    }
}
