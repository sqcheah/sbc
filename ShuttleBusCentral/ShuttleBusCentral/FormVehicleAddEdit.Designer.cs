namespace ShuttleBusCentral
{
    partial class FormVehicleAddEdit
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPermitNo = new System.Windows.Forms.TextBox();
            this.lblPermitNo = new System.Windows.Forms.Label();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.lblPlateNo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtInsuranceNo = new System.Windows.Forms.TextBox();
            this.lblInsuranceNo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtRoadTaxExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtPermitExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtPermitFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblRoadTaxExpiryDate = new System.Windows.Forms.Label();
            this.txtRoadTax = new System.Windows.Forms.TextBox();
            this.lblRoadTax = new System.Windows.Forms.Label();
            this.lblPermitExpiryDate = new System.Windows.Forms.Label();
            this.lblPermitFromDate = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnAddUpdate.Location = new System.Drawing.Point(402, 534);
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
            // txtPermitNo
            // 
            this.txtPermitNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermitNo.Location = new System.Drawing.Point(665, 219);
            this.txtPermitNo.MaxLength = 320;
            this.txtPermitNo.Name = "txtPermitNo";
            this.txtPermitNo.Size = new System.Drawing.Size(150, 22);
            this.txtPermitNo.TabIndex = 5;
            // 
            // lblPermitNo
            // 
            this.lblPermitNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPermitNo.Location = new System.Drawing.Point(475, 219);
            this.lblPermitNo.Name = "lblPermitNo";
            this.lblPermitNo.Size = new System.Drawing.Size(150, 22);
            this.lblPermitNo.TabIndex = 28;
            this.lblPermitNo.Text = "Permit No. :";
            this.lblPermitNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpecification
            // 
            this.txtSpecification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSpecification.Location = new System.Drawing.Point(283, 467);
            this.txtSpecification.MaxLength = 20;
            this.txtSpecification.Multiline = true;
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(532, 48);
            this.txtSpecification.TabIndex = 27;
            // 
            // lblSpecification
            // 
            this.lblSpecification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecification.Location = new System.Drawing.Point(93, 467);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(150, 22);
            this.lblSpecification.TabIndex = 26;
            this.lblSpecification.Text = "Specification :";
            this.lblSpecification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapacity.Location = new System.Drawing.Point(283, 304);
            this.txtCapacity.MaxLength = 12;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(150, 22);
            this.txtCapacity.TabIndex = 2;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCapacity.Location = new System.Drawing.Point(93, 304);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(150, 22);
            this.lblCapacity.TabIndex = 24;
            this.lblCapacity.Text = "Capacity :";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.Location = new System.Drawing.Point(93, 262);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(150, 22);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "Category :";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlateNo.Location = new System.Drawing.Point(283, 219);
            this.txtPlateNo.MaxLength = 20;
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(150, 22);
            this.txtPlateNo.TabIndex = 9;
            // 
            // lblPlateNo
            // 
            this.lblPlateNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlateNo.Location = new System.Drawing.Point(93, 219);
            this.lblPlateNo.Name = "lblPlateNo";
            this.lblPlateNo.Size = new System.Drawing.Size(150, 22);
            this.lblPlateNo.TabIndex = 20;
            this.lblPlateNo.Text = "Plate No. :";
            this.lblPlateNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.comboStatus);
            this.panelMain.Controls.Add(this.txtInsuranceNo);
            this.panelMain.Controls.Add(this.lblInsuranceNo);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Controls.Add(this.dtRoadTaxExpiryDate);
            this.panelMain.Controls.Add(this.dtPermitExpiryDate);
            this.panelMain.Controls.Add(this.dtPermitFromDate);
            this.panelMain.Controls.Add(this.txtMileage);
            this.panelMain.Controls.Add(this.lblMileage);
            this.panelMain.Controls.Add(this.lblRoadTaxExpiryDate);
            this.panelMain.Controls.Add(this.txtRoadTax);
            this.panelMain.Controls.Add(this.lblRoadTax);
            this.panelMain.Controls.Add(this.lblPermitExpiryDate);
            this.panelMain.Controls.Add(this.lblPermitFromDate);
            this.panelMain.Controls.Add(this.comboCategory);
            this.panelMain.Controls.Add(this.lblMessage);
            this.panelMain.Controls.Add(this.btnAddUpdate);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.txtPermitNo);
            this.panelMain.Controls.Add(this.lblPermitNo);
            this.panelMain.Controls.Add(this.txtSpecification);
            this.panelMain.Controls.Add(this.lblSpecification);
            this.panelMain.Controls.Add(this.txtCapacity);
            this.panelMain.Controls.Add(this.lblCapacity);
            this.panelMain.Controls.Add(this.lblCategory);
            this.panelMain.Controls.Add(this.txtPlateNo);
            this.panelMain.Controls.Add(this.lblPlateNo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(923, 606);
            this.panelMain.TabIndex = 2;
            // 
            // txtInsuranceNo
            // 
            this.txtInsuranceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInsuranceNo.Location = new System.Drawing.Point(665, 427);
            this.txtInsuranceNo.MaxLength = 320;
            this.txtInsuranceNo.Name = "txtInsuranceNo";
            this.txtInsuranceNo.Size = new System.Drawing.Size(150, 22);
            this.txtInsuranceNo.TabIndex = 10;
            // 
            // lblInsuranceNo
            // 
            this.lblInsuranceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsuranceNo.Location = new System.Drawing.Point(475, 427);
            this.lblInsuranceNo.Name = "lblInsuranceNo";
            this.lblInsuranceNo.Size = new System.Drawing.Size(150, 22);
            this.lblInsuranceNo.TabIndex = 49;
            this.lblInsuranceNo.Text = "Insurance No. :";
            this.lblInsuranceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.Location = new System.Drawing.Point(93, 386);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 22);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status :";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtRoadTaxExpiryDate
            // 
            this.dtRoadTaxExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtRoadTaxExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.dtRoadTaxExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRoadTaxExpiryDate.Location = new System.Drawing.Point(665, 386);
            this.dtRoadTaxExpiryDate.Name = "dtRoadTaxExpiryDate";
            this.dtRoadTaxExpiryDate.Size = new System.Drawing.Size(150, 22);
            this.dtRoadTaxExpiryDate.TabIndex = 9;
            this.dtRoadTaxExpiryDate.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // dtPermitExpiryDate
            // 
            this.dtPermitExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtPermitExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.dtPermitExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPermitExpiryDate.Location = new System.Drawing.Point(665, 302);
            this.dtPermitExpiryDate.Name = "dtPermitExpiryDate";
            this.dtPermitExpiryDate.Size = new System.Drawing.Size(150, 22);
            this.dtPermitExpiryDate.TabIndex = 7;
            this.dtPermitExpiryDate.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // dtPermitFromDate
            // 
            this.dtPermitFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtPermitFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtPermitFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPermitFromDate.Location = new System.Drawing.Point(665, 260);
            this.dtPermitFromDate.Name = "dtPermitFromDate";
            this.dtPermitFromDate.Size = new System.Drawing.Size(150, 22);
            this.dtPermitFromDate.TabIndex = 6;
            this.dtPermitFromDate.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // txtMileage
            // 
            this.txtMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMileage.Location = new System.Drawing.Point(283, 347);
            this.txtMileage.MaxLength = 20;
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(150, 22);
            this.txtMileage.TabIndex = 3;
            // 
            // lblMileage
            // 
            this.lblMileage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMileage.Location = new System.Drawing.Point(93, 347);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(150, 22);
            this.lblMileage.TabIndex = 42;
            this.lblMileage.Text = "Mileage :";
            this.lblMileage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoadTaxExpiryDate
            // 
            this.lblRoadTaxExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoadTaxExpiryDate.Location = new System.Drawing.Point(475, 386);
            this.lblRoadTaxExpiryDate.Name = "lblRoadTaxExpiryDate";
            this.lblRoadTaxExpiryDate.Size = new System.Drawing.Size(150, 22);
            this.lblRoadTaxExpiryDate.TabIndex = 40;
            this.lblRoadTaxExpiryDate.Text = "RoadTax Expiry Date :";
            this.lblRoadTaxExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRoadTax
            // 
            this.txtRoadTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoadTax.Location = new System.Drawing.Point(665, 347);
            this.txtRoadTax.MaxLength = 320;
            this.txtRoadTax.Name = "txtRoadTax";
            this.txtRoadTax.Size = new System.Drawing.Size(150, 22);
            this.txtRoadTax.TabIndex = 8;
            // 
            // lblRoadTax
            // 
            this.lblRoadTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoadTax.Location = new System.Drawing.Point(475, 347);
            this.lblRoadTax.Name = "lblRoadTax";
            this.lblRoadTax.Size = new System.Drawing.Size(150, 22);
            this.lblRoadTax.TabIndex = 38;
            this.lblRoadTax.Text = "Roadtax No. :";
            this.lblRoadTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPermitExpiryDate
            // 
            this.lblPermitExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPermitExpiryDate.Location = new System.Drawing.Point(475, 304);
            this.lblPermitExpiryDate.Name = "lblPermitExpiryDate";
            this.lblPermitExpiryDate.Size = new System.Drawing.Size(150, 22);
            this.lblPermitExpiryDate.TabIndex = 36;
            this.lblPermitExpiryDate.Text = "Permit Expiry Date :";
            this.lblPermitExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPermitFromDate
            // 
            this.lblPermitFromDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPermitFromDate.Location = new System.Drawing.Point(475, 262);
            this.lblPermitFromDate.Name = "lblPermitFromDate";
            this.lblPermitFromDate.Size = new System.Drawing.Size(150, 22);
            this.lblPermitFromDate.TabIndex = 34;
            this.lblPermitFromDate.Text = "Permit From Date :";
            this.lblPermitFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCategory
            // 
            this.comboCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "School bus",
            "Factory Bus",
            "Express Bus",
            "Mini Bus",
            "Coach",
            "Passenger Van",
            "MPV"});
            this.comboCategory.Location = new System.Drawing.Point(283, 262);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(150, 24);
            this.comboCategory.TabIndex = 1;
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "AVAILABLE",
            "UNAVAILABLE"});
            this.comboStatus.Location = new System.Drawing.Point(283, 386);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(150, 24);
            this.comboStatus.TabIndex = 4;
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
            this.btnClose.TabIndex = 32;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormVehicleAddEdit
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(923, 606);
            this.Controls.Add(this.panelMain);
            this.Name = "FormVehicleAddEdit";
            this.Text = "FormVehicleAddEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPermitNo;
        private System.Windows.Forms.Label lblPermitNo;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtPlateNo;
        protected internal System.Windows.Forms.Label lblPlateNo;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblRoadTaxExpiryDate;
        private System.Windows.Forms.TextBox txtRoadTax;
        private System.Windows.Forms.Label lblRoadTax;
        private System.Windows.Forms.Label lblPermitExpiryDate;
        private System.Windows.Forms.Label lblPermitFromDate;
        private System.Windows.Forms.DateTimePicker dtPermitFromDate;
        private System.Windows.Forms.DateTimePicker dtRoadTaxExpiryDate;
        private System.Windows.Forms.DateTimePicker dtPermitExpiryDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtInsuranceNo;
        private System.Windows.Forms.Label lblInsuranceNo;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnClose;
    }
}