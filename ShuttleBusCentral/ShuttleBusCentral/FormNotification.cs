using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormNotification : Form
    {
        private FormMain parentForm = null;
        public FormNotification(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            ReloadNotificationData();
            dgvNotification.Columns["recipient"].Visible = false;
            dgvNotification.Columns["isRead"].Visible = false;
        }

        public void ReloadNotificationData()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM notification where recipient=@provider ORDER BY createdAt DESC";
            MyComd.Parameters.AddWithValue("@provider", Program.providerID);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dgvNotification.DataSource = dTable;
            MyConn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNotification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNotification.CurrentRow;
            string title = row.Cells[2].Value.ToString();
            string description = row.Cells[3].Value.ToString();
            parentForm.openChildForm(new FormNotificationView(title, description));
        }
    }
}
