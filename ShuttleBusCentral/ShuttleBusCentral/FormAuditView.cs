using System;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormAuditView : Form
    {
        public FormAuditView(string user, string type, string description)
        {
            InitializeComponent();
            txtUser.Text = user;
            txtType.Text = type;
            txtDescription.Text = description;
            txtUser.Enabled = false;
            txtType.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
