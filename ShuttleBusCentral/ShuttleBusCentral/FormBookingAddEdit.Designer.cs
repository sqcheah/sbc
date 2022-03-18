namespace ShuttleBusCentral
{
    partial class FormBookingAddEdit
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
            this.lblCusName = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.txtDepartureLocation = new System.Windows.Forms.TextBox();
            this.lblArrivalLocation = new System.Windows.Forms.Label();
            this.txtArrivalLocation = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblDriver1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblDriver2 = new System.Windows.Forms.Label();
            this.dtDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.dtArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.btnCheckAvailable = new System.Windows.Forms.Button();
            this.comboVehicle = new System.Windows.Forms.ComboBox();
            this.comboDriver1 = new System.Windows.Forms.ComboBox();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnViewCus = new System.Windows.Forms.Button();
            this.checkPaid = new System.Windows.Forms.CheckBox();
            this.checkPublish = new System.Windows.Forms.CheckBox();
            this.comboDriver2 = new System.Windows.Forms.ComboBox();
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
            // lblCusName
            // 
            this.lblCusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusName.Location = new System.Drawing.Point(91, 200);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(150, 22);
            this.lblCusName.TabIndex = 20;
            this.lblCusName.Text = "Customer Name:";
            this.lblCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusName.Location = new System.Drawing.Point(281, 200);
            this.txtCusName.MaxLength = 20;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(150, 22);
            this.txtCusName.TabIndex = 1;
            // 
            // lblDepartureLocation
            // 
            this.lblDepartureLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartureLocation.Location = new System.Drawing.Point(91, 243);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(150, 22);
            this.lblDepartureLocation.TabIndex = 22;
            this.lblDepartureLocation.Text = "Departure Location:";
            this.lblDepartureLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDepartureLocation
            // 
            this.txtDepartureLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepartureLocation.Location = new System.Drawing.Point(281, 243);
            this.txtDepartureLocation.MaxLength = 200;
            this.txtDepartureLocation.Name = "txtDepartureLocation";
            this.txtDepartureLocation.Size = new System.Drawing.Size(150, 22);
            this.txtDepartureLocation.TabIndex = 2;
            // 
            // lblArrivalLocation
            // 
            this.lblArrivalLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrivalLocation.Location = new System.Drawing.Point(91, 365);
            this.lblArrivalLocation.Name = "lblArrivalLocation";
            this.lblArrivalLocation.Size = new System.Drawing.Size(150, 22);
            this.lblArrivalLocation.TabIndex = 24;
            this.lblArrivalLocation.Text = "Arrival Location :";
            this.lblArrivalLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArrivalLocation
            // 
            this.txtArrivalLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArrivalLocation.Location = new System.Drawing.Point(281, 365);
            this.txtArrivalLocation.MaxLength = 12;
            this.txtArrivalLocation.Name = "txtArrivalLocation";
            this.txtArrivalLocation.Size = new System.Drawing.Size(150, 22);
            this.txtArrivalLocation.TabIndex = 5;
            // 
            // lblVehicle
            // 
            this.lblVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVehicle.Location = new System.Drawing.Point(465, 200);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(103, 22);
            this.lblVehicle.TabIndex = 26;
            this.lblVehicle.Text = "Vehicle :";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDriver1
            // 
            this.lblDriver1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDriver1.Location = new System.Drawing.Point(465, 243);
            this.lblDriver1.Name = "lblDriver1";
            this.lblDriver1.Size = new System.Drawing.Size(103, 22);
            this.lblDriver1.TabIndex = 28;
            this.lblDriver1.Text = "Driver 1:";
            this.lblDriver1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnAddUpdate
            // 
            this.btnAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddUpdate.Location = new System.Drawing.Point(379, 557);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 31;
            this.btnAddUpdate.TabStop = false;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
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
            // dtDepartureTime
            // 
            this.dtDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDepartureTime.CustomFormat = "HH:mm";
            this.dtDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepartureTime.Location = new System.Drawing.Point(281, 322);
            this.dtDepartureTime.Name = "dtDepartureTime";
            this.dtDepartureTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDepartureTime.ShowUpDown = true;
            this.dtDepartureTime.Size = new System.Drawing.Size(150, 22);
            this.dtDepartureTime.TabIndex = 4;
            this.dtDepartureTime.Value = new System.DateTime(2020, 10, 20, 0, 0, 0, 0);
            // 
            // lblDriver2
            // 
            this.lblDriver2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDriver2.Location = new System.Drawing.Point(465, 283);
            this.lblDriver2.Name = "lblDriver2";
            this.lblDriver2.Size = new System.Drawing.Size(103, 22);
            this.lblDriver2.TabIndex = 46;
            this.lblDriver2.Text = "Driver 2:";
            this.lblDriver2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtDepartureDate
            // 
            this.dtDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDepartureDate.CustomFormat = "dd/MM/yyyy";
            this.dtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepartureDate.Location = new System.Drawing.Point(281, 283);
            this.dtDepartureDate.Name = "dtDepartureDate";
            this.dtDepartureDate.Size = new System.Drawing.Size(150, 22);
            this.dtDepartureDate.TabIndex = 3;
            this.dtDepartureDate.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartureDate.Location = new System.Drawing.Point(91, 285);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(150, 22);
            this.lblDepartureDate.TabIndex = 49;
            this.lblDepartureDate.Text = "Departure Date:";
            this.lblDepartureDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartureTime.Location = new System.Drawing.Point(91, 322);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(150, 22);
            this.lblDepartureTime.TabIndex = 50;
            this.lblDepartureTime.Text = "Departure Time:";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtArrivalTime.CustomFormat = "HH:mm";
            this.dtArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalTime.Location = new System.Drawing.Point(281, 446);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtArrivalTime.ShowUpDown = true;
            this.dtArrivalTime.Size = new System.Drawing.Size(150, 22);
            this.dtArrivalTime.TabIndex = 7;
            this.dtArrivalTime.Value = new System.DateTime(2020, 10, 20, 0, 0, 0, 0);
            // 
            // dtArrivalDate
            // 
            this.dtArrivalDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtArrivalDate.CustomFormat = "dd/MM/yyyy";
            this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalDate.Location = new System.Drawing.Point(281, 407);
            this.dtArrivalDate.Name = "dtArrivalDate";
            this.dtArrivalDate.Size = new System.Drawing.Size(150, 22);
            this.dtArrivalDate.TabIndex = 6;
            this.dtArrivalDate.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrivalDate.Location = new System.Drawing.Point(91, 409);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(150, 22);
            this.lblArrivalDate.TabIndex = 53;
            this.lblArrivalDate.Text = "Arrival Date:";
            this.lblArrivalDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArrivalTime.Location = new System.Drawing.Point(91, 446);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(150, 22);
            this.lblArrivalTime.TabIndex = 54;
            this.lblArrivalTime.Text = "Arrival Time:";
            this.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCusID
            // 
            this.lblCusID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusID.Location = new System.Drawing.Point(91, 157);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(150, 22);
            this.lblCusID.TabIndex = 55;
            this.lblCusID.Text = "Customer :";
            this.lblCusID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCusID
            // 
            this.txtCusID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusID.Location = new System.Drawing.Point(281, 157);
            this.txtCusID.MaxLength = 20;
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(150, 22);
            this.txtCusID.TabIndex = 0;
            // 
            // btnCheckAvailable
            // 
            this.btnCheckAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckAvailable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCheckAvailable.Location = new System.Drawing.Point(582, 156);
            this.btnCheckAvailable.Name = "btnCheckAvailable";
            this.btnCheckAvailable.Size = new System.Drawing.Size(253, 23);
            this.btnCheckAvailable.TabIndex = 57;
            this.btnCheckAvailable.TabStop = false;
            this.btnCheckAvailable.Text = "Check Available Bus";
            this.btnCheckAvailable.UseVisualStyleBackColor = true;
            this.btnCheckAvailable.Click += new System.EventHandler(this.btnCheckAvailable_Click);
            // 
            // comboVehicle
            // 
            this.comboVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicle.FormattingEnabled = true;
            this.comboVehicle.Location = new System.Drawing.Point(582, 200);
            this.comboVehicle.Name = "comboVehicle";
            this.comboVehicle.Size = new System.Drawing.Size(253, 24);
            this.comboVehicle.TabIndex = 9;
            // 
            // comboDriver1
            // 
            this.comboDriver1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDriver1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDriver1.FormattingEnabled = true;
            this.comboDriver1.Location = new System.Drawing.Point(582, 243);
            this.comboDriver1.Name = "comboDriver1";
            this.comboDriver1.Size = new System.Drawing.Size(253, 24);
            this.comboDriver1.TabIndex = 10;
            // 
            // lblPassenger
            // 
            this.lblPassenger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassenger.Location = new System.Drawing.Point(465, 446);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(150, 22);
            this.lblPassenger.TabIndex = 60;
            this.lblPassenger.Text = "Passenger:";
            this.lblPassenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassenger
            // 
            this.txtPassenger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassenger.Location = new System.Drawing.Point(663, 448);
            this.txtPassenger.MaxLength = 320;
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.Size = new System.Drawing.Size(150, 22);
            this.txtPassenger.TabIndex = 15;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemarks.Location = new System.Drawing.Point(91, 487);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(150, 22);
            this.lblRemarks.TabIndex = 62;
            this.lblRemarks.Text = "Remarks :";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRemarks.Location = new System.Drawing.Point(281, 487);
            this.txtRemarks.MaxLength = 20;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(532, 48);
            this.txtRemarks.TabIndex = 8;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtStatus);
            this.panelMain.Controls.Add(this.lblStatus);
            this.panelMain.Controls.Add(this.btnCancelBooking);
            this.panelMain.Controls.Add(this.btnViewCus);
            this.panelMain.Controls.Add(this.checkPaid);
            this.panelMain.Controls.Add(this.checkPublish);
            this.panelMain.Controls.Add(this.comboDriver2);
            this.panelMain.Controls.Add(this.txtRemarks);
            this.panelMain.Controls.Add(this.lblRemarks);
            this.panelMain.Controls.Add(this.txtPassenger);
            this.panelMain.Controls.Add(this.lblPassenger);
            this.panelMain.Controls.Add(this.comboDriver1);
            this.panelMain.Controls.Add(this.comboVehicle);
            this.panelMain.Controls.Add(this.btnCheckAvailable);
            this.panelMain.Controls.Add(this.txtCusID);
            this.panelMain.Controls.Add(this.lblCusID);
            this.panelMain.Controls.Add(this.lblArrivalTime);
            this.panelMain.Controls.Add(this.lblArrivalDate);
            this.panelMain.Controls.Add(this.dtArrivalDate);
            this.panelMain.Controls.Add(this.dtArrivalTime);
            this.panelMain.Controls.Add(this.lblDepartureTime);
            this.panelMain.Controls.Add(this.lblDepartureDate);
            this.panelMain.Controls.Add(this.dtDepartureDate);
            this.panelMain.Controls.Add(this.lblDriver2);
            this.panelMain.Controls.Add(this.dtDepartureTime);
            this.panelMain.Controls.Add(this.lblMessage);
            this.panelMain.Controls.Add(this.btnAddUpdate);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.lblDriver1);
            this.panelMain.Controls.Add(this.lblVehicle);
            this.panelMain.Controls.Add(this.txtArrivalLocation);
            this.panelMain.Controls.Add(this.lblArrivalLocation);
            this.panelMain.Controls.Add(this.txtDepartureLocation);
            this.panelMain.Controls.Add(this.lblDepartureLocation);
            this.panelMain.Controls.Add(this.txtCusName);
            this.panelMain.Controls.Add(this.lblCusName);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(923, 606);
            this.panelMain.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatus.Location = new System.Drawing.Point(663, 365);
            this.txtStatus.MaxLength = 320;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(150, 22);
            this.txtStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.Location = new System.Drawing.Point(465, 363);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 22);
            this.lblStatus.TabIndex = 69;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelBooking.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelBooking.Location = new System.Drawing.Point(493, 557);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(162, 23);
            this.btnCancelBooking.TabIndex = 68;
            this.btnCancelBooking.TabStop = false;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnViewCus
            // 
            this.btnViewCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewCus.Location = new System.Drawing.Point(448, 156);
            this.btnViewCus.Name = "btnViewCus";
            this.btnViewCus.Size = new System.Drawing.Size(106, 23);
            this.btnViewCus.TabIndex = 67;
            this.btnViewCus.TabStop = false;
            this.btnViewCus.Text = "View Cus";
            this.btnViewCus.UseVisualStyleBackColor = true;
            this.btnViewCus.Click += new System.EventHandler(this.btnViewCus_Click);
            // 
            // checkPaid
            // 
            this.checkPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkPaid.AutoSize = true;
            this.checkPaid.Location = new System.Drawing.Point(468, 407);
            this.checkPaid.Name = "checkPaid";
            this.checkPaid.Size = new System.Drawing.Size(58, 21);
            this.checkPaid.TabIndex = 14;
            this.checkPaid.Text = "Paid";
            this.checkPaid.UseVisualStyleBackColor = true;
            // 
            // checkPublish
            // 
            this.checkPublish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkPublish.AutoSize = true;
            this.checkPublish.Location = new System.Drawing.Point(468, 324);
            this.checkPublish.Name = "checkPublish";
            this.checkPublish.Size = new System.Drawing.Size(204, 21);
            this.checkPublish.TabIndex = 12;
            this.checkPublish.Text = "Publish to External Provider";
            this.checkPublish.UseVisualStyleBackColor = true;
            // 
            // comboDriver2
            // 
            this.comboDriver2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDriver2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDriver2.FormattingEnabled = true;
            this.comboDriver2.Location = new System.Drawing.Point(582, 283);
            this.comboDriver2.Name = "comboDriver2";
            this.comboDriver2.Size = new System.Drawing.Size(253, 24);
            this.comboDriver2.TabIndex = 11;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // FormBookingAddEdit
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(923, 606);
            this.Controls.Add(this.panelMain);
            this.Name = "FormBookingAddEdit";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboDriver2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.ComboBox comboDriver1;
        private System.Windows.Forms.ComboBox comboVehicle;
        private System.Windows.Forms.Button btnCheckAvailable;
        private System.Windows.Forms.TextBox txtCusID;
        protected internal System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.DateTimePicker dtArrivalDate;
        private System.Windows.Forms.DateTimePicker dtArrivalTime;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker dtDepartureDate;
        private System.Windows.Forms.Label lblDriver2;
        private System.Windows.Forms.DateTimePicker dtDepartureTime;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDriver1;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtArrivalLocation;
        private System.Windows.Forms.Label lblArrivalLocation;
        private System.Windows.Forms.TextBox txtDepartureLocation;
        private System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.TextBox txtCusName;
        protected internal System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.CheckBox checkPublish;
        private System.Windows.Forms.CheckBox checkPaid;
        private System.Windows.Forms.Button btnViewCus;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
    }
}