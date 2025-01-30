namespace NewHIMS.Forms.Medicine
{
    partial class FrmMedicinePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicinePayment));
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblDailyPayment = new System.Windows.Forms.LinkLabel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lvlGrandTotal = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.txtGaurdianName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.guardian_name = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.is_discharged = new System.Windows.Forms.ColumnHeader();
            this.station = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(745, 29);
            this.label7.TabIndex = 110;
            this.label7.Text = "Medicine Payment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(7, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 68);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(301, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 34);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(43, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 34);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(631, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(483, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPayment.BackColor = System.Drawing.Color.Silver;
            this.grpPayment.Controls.Add(this.lblDailyPayment);
            this.grpPayment.Controls.Add(this.txtTotal);
            this.grpPayment.Controls.Add(this.lvlGrandTotal);
            this.grpPayment.Controls.Add(this.lblCustomerName);
            this.grpPayment.Controls.Add(this.txtCustomerName);
            this.grpPayment.Controls.Add(this.lblAdress);
            this.grpPayment.Controls.Add(this.txtAdress);
            this.grpPayment.Controls.Add(this.lblPhone);
            this.grpPayment.Controls.Add(this.txtPhone);
            this.grpPayment.Controls.Add(this.lblPaymentDate);
            this.grpPayment.Controls.Add(this.dtpPaymentDate);
            this.grpPayment.Controls.Add(this.lblPaymentType);
            this.grpPayment.Controls.Add(this.cmbPaymentType);
            this.grpPayment.Controls.Add(this.lblGuardianName);
            this.grpPayment.Controls.Add(this.txtGaurdianName);
            this.grpPayment.Location = new System.Drawing.Point(414, 45);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(320, 331);
            this.grpPayment.TabIndex = 117;
            this.grpPayment.TabStop = false;
            // 
            // lblDailyPayment
            // 
            this.lblDailyPayment.AutoSize = true;
            this.lblDailyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyPayment.LinkColor = System.Drawing.Color.Purple;
            this.lblDailyPayment.Location = new System.Drawing.Point(192, 50);
            this.lblDailyPayment.Name = "lblDailyPayment";
            this.lblDailyPayment.Size = new System.Drawing.Size(108, 16);
            this.lblDailyPayment.TabIndex = 11;
            this.lblDailyPayment.TabStop = true;
            this.lblDailyPayment.Text = "Daily Payment";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(123, 267);
            this.txtTotal.MaxLength = 8;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 20);
            this.txtTotal.TabIndex = 35;
            // 
            // lvlGrandTotal
            // 
            this.lvlGrandTotal.AutoSize = true;
            this.lvlGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlGrandTotal.Location = new System.Drawing.Point(57, 270);
            this.lvlGrandTotal.Name = "lvlGrandTotal";
            this.lvlGrandTotal.Size = new System.Drawing.Size(53, 16);
            this.lvlGrandTotal.TabIndex = 34;
            this.lvlGrandTotal.Text = "Amount";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(21, 83);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(89, 16);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Patient Name";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(123, 82);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Tag = "customer_name";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(61, 156);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(51, 16);
            this.lblAdress.TabIndex = 18;
            this.lblAdress.Text = "Adress";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(123, 153);
            this.txtAdress.MaxLength = 200;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(182, 20);
            this.txtAdress.TabIndex = 1;
            this.txtAdress.Tag = "adress";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(63, 192);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 16);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 189);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(182, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Tag = "phone";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.BackColor = System.Drawing.Color.Yellow;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(33, 21);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(84, 15);
            this.lblPaymentDate.TabIndex = 20;
            this.lblPaymentDate.Text = "Payment Date";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPaymentDate.CustomFormat = "dd-MMM-yyyy hh:mm:ss tt";
            this.dtpPaymentDate.Enabled = false;
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(125, 18);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(180, 20);
            this.dtpPaymentDate.TabIndex = 5;
            this.dtpPaymentDate.Tag = "sales_date";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(22, 228);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(96, 16);
            this.lblPaymentType.TabIndex = 22;
            this.lblPaymentType.Text = "Payment Type";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(125, 225);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(180, 21);
            this.cmbPaymentType.TabIndex = 4;
            this.cmbPaymentType.Tag = "payment_type_id";
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(12, 120);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(103, 16);
            this.lblGuardianName.TabIndex = 26;
            this.lblGuardianName.Text = "Guardian Name";
            this.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGaurdianName
            // 
            this.txtGaurdianName.Location = new System.Drawing.Point(123, 117);
            this.txtGaurdianName.MaxLength = 300;
            this.txtGaurdianName.Name = "txtGaurdianName";
            this.txtGaurdianName.ReadOnly = true;
            this.txtGaurdianName.Size = new System.Drawing.Size(182, 20);
            this.txtGaurdianName.TabIndex = 3;
            this.txtGaurdianName.Tag = "remarks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPatientInfo);
            this.groupBox1.Location = new System.Drawing.Point(7, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 331);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Silver;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.patient_code,
            this.admission_id,
            this.patient_name,
            this.guardian_name,
            this.address,
            this.phone,
            this.is_discharged,
            this.station});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(6, 16);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(389, 308);
            this.lvwPatientInfo.TabIndex = 5;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 75;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 104;
            // 
            // admission_id
            // 
            this.admission_id.Name = "admission_id";
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // patient_name
            // 
            this.patient_name.Text = "Patient  Name";
            this.patient_name.Width = 180;
            // 
            // guardian_name
            // 
            this.guardian_name.Text = "GrdName";
            this.guardian_name.Width = 0;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 0;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 0;
            // 
            // is_discharged
            // 
            this.is_discharged.Text = "discharged";
            this.is_discharged.Width = 0;
            // 
            // station
            // 
            this.station.Text = "Station";
            this.station.Width = 0;
            // 
            // FrmMedicinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedicinePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Payment";
            this.Load += new System.EventHandler(this.FrmMedicinePayment_Load);
            this.groupBox2.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.LinkLabel lblDailyPayment;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lvlGrandTotal;
        private System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblAdress;
        public System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox txtGaurdianName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader guardian_name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader is_discharged;
        private System.Windows.Forms.ColumnHeader station;
    }
}