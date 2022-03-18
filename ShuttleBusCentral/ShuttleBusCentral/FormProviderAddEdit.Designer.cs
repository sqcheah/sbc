namespace ShuttleBusCentral
{
    partial class FormProviderAddEdit
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.lblIC = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.lblTitle.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(923, 606);
            this.panelMain.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblVehicle);
            this.panelRight.Controls.Add(this.btnAddVehicle);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.btnAddDriver);
            this.panelRight.Controls.Add(this.dgvDriver);
            this.panelRight.Controls.Add(this.dgvVehicle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(424, 100);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(499, 506);
            this.panelRight.TabIndex = 40;
            // 
            // lblVehicle
            // 
            this.lblVehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVehicle.Location = new System.Drawing.Point(9, 46);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(150, 22);
            this.lblVehicle.TabIndex = 46;
            this.lblVehicle.Text = "Vehicle List";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddVehicle.Location = new System.Drawing.Point(373, 45);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnAddVehicle.TabIndex = 45;
            this.btnAddVehicle.TabStop = false;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Driver List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddDriver.Location = new System.Drawing.Point(373, 271);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(75, 23);
            this.btnAddDriver.TabIndex = 42;
            this.btnAddDriver.TabStop = false;
            this.btnAddDriver.Text = "Add";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.AllowUserToDeleteRows = false;
            this.dgvDriver.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(12, 318);
            this.dgvDriver.MultiSelect = false;
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.ReadOnly = true;
            this.dgvDriver.RowHeadersWidth = 51;
            this.dgvDriver.RowTemplate.Height = 24;
            this.dgvDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriver.Size = new System.Drawing.Size(460, 150);
            this.dgvDriver.TabIndex = 40;
            this.dgvDriver.TabStop = false;
            this.dgvDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriver_CellDoubleClick);
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToDeleteRows = false;
            this.dgvVehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(12, 85);
            this.dgvVehicle.MultiSelect = false;
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowHeadersWidth = 51;
            this.dgvVehicle.RowTemplate.Height = 24;
            this.dgvVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicle.Size = new System.Drawing.Size(460, 150);
            this.dgvVehicle.TabIndex = 39;
            this.dgvVehicle.TabStop = false;
            this.dgvVehicle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellDoubleClick);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.txtCompany);
            this.panelLeft.Controls.Add(this.lblCompany);
            this.panelLeft.Controls.Add(this.lblMessage);
            this.panelLeft.Controls.Add(this.btnAddUpdate);
            this.panelLeft.Controls.Add(this.txtEmail);
            this.panelLeft.Controls.Add(this.lblEmail);
            this.panelLeft.Controls.Add(this.txtPhoneNum);
            this.panelLeft.Controls.Add(this.lblPhoneNum);
            this.panelLeft.Controls.Add(this.txtIC);
            this.panelLeft.Controls.Add(this.lblIC);
            this.panelLeft.Controls.Add(this.txtName);
            this.panelLeft.Controls.Add(this.lblName);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(424, 506);
            this.panelLeft.TabIndex = 39;
            // 
            // txtCompany
            // 
            this.txtCompany.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCompany.Location = new System.Drawing.Point(233, 318);
            this.txtCompany.MaxLength = 320;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(150, 22);
            this.txtCompany.TabIndex = 4;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompany.Location = new System.Drawing.Point(43, 318);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(150, 22);
            this.lblCompany.TabIndex = 43;
            this.lblCompany.Text = "Company :";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Red;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(424, 23);
            this.lblMessage.TabIndex = 42;
            this.lblMessage.Text = "{MESSAGE}";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUpdate.Location = new System.Drawing.Point(151, 419);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 41;
            this.btnAddUpdate.TabStop = false;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtEmail.Location = new System.Drawing.Point(233, 272);
            this.txtEmail.MaxLength = 320;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.Location = new System.Drawing.Point(43, 272);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(150, 22);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPhoneNum.Location = new System.Drawing.Point(233, 229);
            this.txtPhoneNum.MaxLength = 20;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(150, 22);
            this.txtPhoneNum.TabIndex = 2;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhoneNum.Location = new System.Drawing.Point(43, 229);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(150, 22);
            this.lblPhoneNum.TabIndex = 37;
            this.lblPhoneNum.Text = "Phone Number :";
            this.lblPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIC
            // 
            this.txtIC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtIC.Location = new System.Drawing.Point(233, 186);
            this.txtIC.MaxLength = 12;
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(150, 22);
            this.txtIC.TabIndex = 1;
            // 
            // lblIC
            // 
            this.lblIC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIC.Location = new System.Drawing.Point(43, 186);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(150, 22);
            this.lblIC.TabIndex = 35;
            this.lblIC.Text = "IC No. :";
            this.lblIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Location = new System.Drawing.Point(233, 144);
            this.txtName.MaxLength = 200;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.Location = new System.Drawing.Point(43, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 22);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // FormProviderAddEdit
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(923, 606);
            this.Controls.Add(this.panelMain);
            this.Name = "FormProviderAddEdit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormProviderAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        protected internal System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnClose;
    }
}