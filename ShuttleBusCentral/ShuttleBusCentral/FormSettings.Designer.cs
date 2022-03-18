namespace ShuttleBusCentral
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPermitDayBefore = new System.Windows.Forms.TextBox();
            this.lblPermitDayBefore = new System.Windows.Forms.Label();
            this.txtMileageLimit = new System.Windows.Forms.TextBox();
            this.lblMileageLimit = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblMessage);
            this.panelMain.Controls.Add(this.btnAddUpdate);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.txtPermitDayBefore);
            this.panelMain.Controls.Add(this.lblPermitDayBefore);
            this.panelMain.Controls.Add(this.txtMileageLimit);
            this.panelMain.Controls.Add(this.lblMileageLimit);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(923, 606);
            this.panelMain.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Red;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(0, 100);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(923, 23);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "{MESSAGE}";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddUpdate.Location = new System.Drawing.Point(400, 454);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 31;
            this.btnAddUpdate.TabStop = false;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(923, 100);
            this.panelTitle.TabIndex = 30;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(923, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{Title}";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // txtPermitDayBefore
            // 
            this.txtPermitDayBefore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermitDayBefore.Location = new System.Drawing.Point(470, 292);
            this.txtPermitDayBefore.MaxLength = 200;
            this.txtPermitDayBefore.Name = "txtPermitDayBefore";
            this.txtPermitDayBefore.Size = new System.Drawing.Size(150, 22);
            this.txtPermitDayBefore.TabIndex = 1;
            // 
            // lblPermitDayBefore
            // 
            this.lblPermitDayBefore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPermitDayBefore.Location = new System.Drawing.Point(253, 292);
            this.lblPermitDayBefore.Name = "lblPermitDayBefore";
            this.lblPermitDayBefore.Size = new System.Drawing.Size(178, 22);
            this.lblPermitDayBefore.TabIndex = 22;
            this.lblPermitDayBefore.Text = "Permit Check Day Before :";
            this.lblPermitDayBefore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMileageLimit
            // 
            this.txtMileageLimit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMileageLimit.Location = new System.Drawing.Point(470, 249);
            this.txtMileageLimit.MaxLength = 20;
            this.txtMileageLimit.Name = "txtMileageLimit";
            this.txtMileageLimit.Size = new System.Drawing.Size(150, 22);
            this.txtMileageLimit.TabIndex = 0;
            // 
            // lblMileageLimit
            // 
            this.lblMileageLimit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMileageLimit.Location = new System.Drawing.Point(253, 249);
            this.lblMileageLimit.Name = "lblMileageLimit";
            this.lblMileageLimit.Size = new System.Drawing.Size(150, 22);
            this.lblMileageLimit.TabIndex = 20;
            this.lblMileageLimit.Text = "Mileage Limit :";
            this.lblMileageLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(883, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 33;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(923, 606);
            this.Controls.Add(this.panelMain);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPermitDayBefore;
        private System.Windows.Forms.Label lblPermitDayBefore;
        private System.Windows.Forms.TextBox txtMileageLimit;
        protected internal System.Windows.Forms.Label lblMileageLimit;
        private System.Windows.Forms.Button btnClose;
    }
}