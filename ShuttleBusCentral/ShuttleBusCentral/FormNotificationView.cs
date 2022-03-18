using System;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormNotificationView : Form
    {
        public FormNotificationView(string title, string description)
        {
            InitializeComponent();
            txtNTitle.Text = title;
            txtDescription.Text = description;
            txtNTitle.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
