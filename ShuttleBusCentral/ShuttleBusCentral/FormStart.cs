using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShuttleBusCentral
{
    public partial class FormStart : Form
    {
        public FormStart()
        {

            InitializeComponent();
            this.MinimumSize = new Size(800, 500);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            label1.Left = Program.calculateWidth(this, label1);
            startButton.Left = Program.calculateWidth(this, startButton);

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new FormLogin());
        }

    }
}
