using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormProvider : Form
    {
        private FormMain parentForm = null;
        public FormProvider(FormMain form)
        {
            parentForm = form;
            InitializeComponent();
            ReloadProviderData();
            dgvProvider.Columns["image"].Visible = false;

        }

        public void ReloadProviderData()
        {
            MySqlConnection MyConn = new MySqlConnection(Program.Conn);
            MySqlCommand MyComd = MyConn.CreateCommand();
            MyComd.CommandText = "SELECT * FROM provider";

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyComd;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control?view=netframeworkdesktop-4.8
            ///instead of datagridview
            dgvProvider.DataSource = dTable;
            MyConn.Close();
        }


        private void dataGridViewProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProvider.CurrentRow;

            Provider p = new Provider();
            p.id = row.Cells[0].Value.ToString();
            p.company = row.Cells[1].Value.ToString();
            p.name = row.Cells[2].Value.ToString();
            p.IC = row.Cells[3].Value.ToString();
            p.phoneNum = row.Cells[4].Value.ToString();
            p.email = row.Cells[5].Value.ToString();
            p.image = row.Cells[6].Value.ToString();

            parentForm.openChildForm(new FormProviderAddEdit(parentForm, p));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProviderAddEdit form = new FormProviderAddEdit(parentForm);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
