namespace ShuttleBusCentral
{
    partial class FormBooking
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnAutoCancel = new System.Windows.Forms.Button();
            this.dtCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.comboBoxPaid = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.dtArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.dtDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.btnClose);
            this.panelChildForm.Controls.Add(this.btnAutoCancel);
            this.panelChildForm.Controls.Add(this.dtCreatedAt);
            this.panelChildForm.Controls.Add(this.lblCreatedAt);
            this.panelChildForm.Controls.Add(this.lblPaid);
            this.panelChildForm.Controls.Add(this.comboBoxPaid);
            this.panelChildForm.Controls.Add(this.lblStatus);
            this.panelChildForm.Controls.Add(this.lblCusID);
            this.panelChildForm.Controls.Add(this.txtCusID);
            this.panelChildForm.Controls.Add(this.dtArrivalDate);
            this.panelChildForm.Controls.Add(this.lblArrivalDate);
            this.panelChildForm.Controls.Add(this.dtDepartureDate);
            this.panelChildForm.Controls.Add(this.btnReset);
            this.panelChildForm.Controls.Add(this.lblDepartureDate);
            this.panelChildForm.Controls.Add(this.comboBoxStatus);
            this.panelChildForm.Controls.Add(this.btnSearch);
            this.panelChildForm.Controls.Add(this.dgvBooking);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(923, 606);
            this.panelChildForm.TabIndex = 4;
            // 
            // btnAutoCancel
            // 
            this.btnAutoCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAutoCancel.Location = new System.Drawing.Point(731, 114);
            this.btnAutoCancel.Name = "btnAutoCancel";
            this.btnAutoCancel.Size = new System.Drawing.Size(128, 23);
            this.btnAutoCancel.TabIndex = 8;
            this.btnAutoCancel.TabStop = false;
            this.btnAutoCancel.Text = "Auto Cancel";
            this.btnAutoCancel.UseVisualStyleBackColor = true;
            this.btnAutoCancel.Click += new System.EventHandler(this.btnAutoCancel_Click);
            // 
            // dtCreatedAt
            // 
            this.dtCreatedAt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtCreatedAt.Checked = false;
            this.dtCreatedAt.CustomFormat = "dd/MM/yyyy";
            this.dtCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatedAt.Location = new System.Drawing.Point(546, 112);
            this.dtCreatedAt.Name = "dtCreatedAt";
            this.dtCreatedAt.ShowCheckBox = true;
            this.dtCreatedAt.Size = new System.Drawing.Size(150, 22);
            this.dtCreatedAt.TabIndex = 5;
            this.dtCreatedAt.Value = new System.DateTime(2020, 11, 3, 0, 0, 0, 0);
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(449, 112);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(75, 17);
            this.lblCreatedAt.TabIndex = 58;
            this.lblCreatedAt.Text = "Created At";
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(449, 73);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(36, 17);
            this.lblPaid.TabIndex = 56;
            this.lblPaid.Text = "Paid";
            // 
            // comboBoxPaid
            // 
            this.comboBoxPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaid.FormattingEnabled = true;
            this.comboBoxPaid.Items.AddRange(new object[] {
            "",
            "TRUE",
            "FALSE"});
            this.comboBoxPaid.Location = new System.Drawing.Point(546, 70);
            this.comboBoxPaid.Name = "comboBoxPaid";
            this.comboBoxPaid.Size = new System.Drawing.Size(149, 24);
            this.comboBoxPaid.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(449, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Status";
            // 
            // lblCusID
            // 
            this.lblCusID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(110, 29);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(68, 17);
            this.lblCusID.TabIndex = 53;
            this.lblCusID.Text = "Customer";
            // 
            // txtCusID
            // 
            this.txtCusID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusID.Location = new System.Drawing.Point(265, 26);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(149, 22);
            this.txtCusID.TabIndex = 0;
            // 
            // dtArrivalDate
            // 
            this.dtArrivalDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtArrivalDate.Checked = false;
            this.dtArrivalDate.CustomFormat = "dd/MM/yyyy";
            this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalDate.Location = new System.Drawing.Point(265, 107);
            this.dtArrivalDate.Name = "dtArrivalDate";
            this.dtArrivalDate.ShowCheckBox = true;
            this.dtArrivalDate.Size = new System.Drawing.Size(150, 22);
            this.dtArrivalDate.TabIndex = 2;
            this.dtArrivalDate.Value = new System.DateTime(2020, 11, 3, 0, 0, 0, 0);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(110, 112);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(82, 17);
            this.lblArrivalDate.TabIndex = 50;
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // dtDepartureDate
            // 
            this.dtDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDepartureDate.Checked = false;
            this.dtDepartureDate.CustomFormat = "dd/MM/yyyy";
            this.dtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepartureDate.Location = new System.Drawing.Point(265, 68);
            this.dtDepartureDate.Name = "dtDepartureDate";
            this.dtDepartureDate.ShowCheckBox = true;
            this.dtDepartureDate.Size = new System.Drawing.Size(150, 22);
            this.dtDepartureDate.TabIndex = 1;
            this.dtDepartureDate.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(757, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(110, 68);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(106, 17);
            this.lblDepartureDate.TabIndex = 13;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "",
            "PENDING",
            "BOOKED BUT NOT PAID",
            "BOOKED",
            "CANCEL"});
            this.comboBoxStatus.Location = new System.Drawing.Point(546, 26);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(149, 24);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(757, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(103, 161);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(50);
            this.dgvBooking.MultiSelect = false;
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(688, 363);
            this.dgvBooking.TabIndex = 1;
            this.dgvBooking.TabStop = false;
            this.dgvBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormBooking
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(923, 606);
            this.Controls.Add(this.panelChildForm);
            this.Name = "FormBooking";
            this.Text = "FormBooking";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtDepartureDate;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.DateTimePicker dtArrivalDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.ComboBox comboBoxPaid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtCreatedAt;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Button btnAutoCancel;
        private System.Windows.Forms.Button btnClose;
    }
}