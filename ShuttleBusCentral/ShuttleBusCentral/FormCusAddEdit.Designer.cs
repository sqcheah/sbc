namespace ShuttleBusCentral
{
    partial class FormCusAddEdit
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBankAcc = new System.Windows.Forms.TextBox();
            this.lblBankAcc = new System.Windows.Forms.Label();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.lblIC = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(492, 365);
            this.txtEmail.MaxLength = 320;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.Location = new System.Drawing.Point(275, 365);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 22);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBankAcc
            // 
            this.txtBankAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBankAcc.Location = new System.Drawing.Point(492, 322);
            this.txtBankAcc.MaxLength = 20;
            this.txtBankAcc.Name = "txtBankAcc";
            this.txtBankAcc.Size = new System.Drawing.Size(150, 22);
            this.txtBankAcc.TabIndex = 3;
            // 
            // lblBankAcc
            // 
            this.lblBankAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBankAcc.Location = new System.Drawing.Point(275, 322);
            this.lblBankAcc.Name = "lblBankAcc";
            this.lblBankAcc.Size = new System.Drawing.Size(150, 22);
            this.lblBankAcc.TabIndex = 26;
            this.lblBankAcc.Text = "Bank Account No. :";
            this.lblBankAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIC
            // 
            this.txtIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIC.Location = new System.Drawing.Point(492, 279);
            this.txtIC.MaxLength = 12;
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(150, 22);
            this.txtIC.TabIndex = 2;
            // 
            // lblIC
            // 
            this.lblIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIC.Location = new System.Drawing.Point(275, 279);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(150, 22);
            this.lblIC.TabIndex = 24;
            this.lblIC.Text = "IC No. :";
            this.lblIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(492, 237);
            this.txtName.MaxLength = 200;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Location = new System.Drawing.Point(275, 237);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 22);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNum.Location = new System.Drawing.Point(492, 194);
            this.txtPhoneNum.MaxLength = 20;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(150, 22);
            this.txtPhoneNum.TabIndex = 0;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNum.Location = new System.Drawing.Point(275, 194);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(150, 22);
            this.lblPhoneNum.TabIndex = 20;
            this.lblPhoneNum.Text = "Phone Number :";
            this.lblPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnAddBooking);
            this.panelMain.Controls.Add(this.lblMessage);
            this.panelMain.Controls.Add(this.btnAddUpdate);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.txtBankAcc);
            this.panelMain.Controls.Add(this.lblBankAcc);
            this.panelMain.Controls.Add(this.txtIC);
            this.panelMain.Controls.Add(this.lblIC);
            this.panelMain.Controls.Add(this.txtName);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.txtPhoneNum);
            this.panelMain.Controls.Add(this.lblPhoneNum);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(923, 606);
            this.panelMain.TabIndex = 1;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBooking.Location = new System.Drawing.Point(384, 505);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(106, 32);
            this.btnAddBooking.TabIndex = 33;
            this.btnAddBooking.TabStop = false;
            this.btnAddBooking.Text = "Add  Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FormCusAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 606);
            this.Controls.Add(this.panelMain);
            this.Name = "FormCusAddEdit";
            this.Text = "CusAddEdit";
            this.panelTitle.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBankAcc;
        private System.Windows.Forms.Label lblBankAcc;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        protected internal System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnClose;
    }
}