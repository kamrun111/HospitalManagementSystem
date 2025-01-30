namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    partial class FrmOPDPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOPDPayment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.is_discharged = new System.Windows.Forms.ColumnHeader();
            this.guardian_name = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.OPDRegistrationFee = new System.Windows.Forms.ColumnHeader();
            this.MedicineBill = new System.Windows.Forms.ColumnHeader();
            this.HospitalService = new System.Windows.Forms.ColumnHeader();
            this.opdbill_id = new System.Windows.Forms.ColumnHeader();
            this.opdadmission_id = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRegID);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lvwPatientInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reg ID:";
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(32, 35);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(107, 20);
            this.txtRegID.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(145, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patient_code,
            this.admission_id,
            this.patient_name,
            this.is_discharged,
            this.guardian_name,
            this.address,
            this.phone,
            this.OPDRegistrationFee,
            this.MedicineBill,
            this.HospitalService,
            this.opdbill_id,
            this.opdadmission_id});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(13, 73);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(204, 290);
            this.lvwPatientInfo.TabIndex = 10;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "OPDPID";
            this.patient_code.Width = 0;
            // 
            // admission_id
            // 
            this.admission_id.Name = "admission_id";
            this.admission_id.Text = "Reg ID";
            this.admission_id.Width = 90;
            // 
            // patient_name
            // 
            this.patient_name.Text = "P. Name";
            this.patient_name.Width = 140;
            // 
            // is_discharged
            // 
            this.is_discharged.Text = "Discharge";
            this.is_discharged.Width = 0;
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
            // OPDRegistrationFee
            // 
            this.OPDRegistrationFee.Text = "OPD Registration Fee";
            // 
            // MedicineBill
            // 
            this.MedicineBill.Text = "Medicine Bill";
            // 
            // HospitalService
            // 
            this.HospitalService.Text = "Hospital Service";
            // 
            // opdbill_id
            // 
            this.opdbill_id.Text = "opdbill_id";
            this.opdbill_id.Width = 0;
            // 
            // opdadmission_id
            // 
            this.opdadmission_id.Text = "opdadmission_id";
            this.opdadmission_id.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.lvlGrandTotal);
            this.groupBox2.Controls.Add(this.lblCustomerName);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.lblAdress);
            this.groupBox2.Controls.Add(this.txtAdress);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.lblPaymentDate);
            this.groupBox2.Controls.Add(this.dtpPaymentDate);
            this.groupBox2.Controls.Add(this.lblPaymentType);
            this.groupBox2.Controls.Add(this.cmbPaymentType);
            this.groupBox2.Controls.Add(this.lblGuardianName);
            this.groupBox2.Controls.Add(this.txtGaurdianName);
            this.groupBox2.Location = new System.Drawing.Point(250, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(132, 224);
            this.txtTotal.MaxLength = 8;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 49;
            // 
            // lvlGrandTotal
            // 
            this.lvlGrandTotal.AutoSize = true;
            this.lvlGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlGrandTotal.Location = new System.Drawing.Point(31, 227);
            this.lvlGrandTotal.Name = "lvlGrandTotal";
            this.lvlGrandTotal.Size = new System.Drawing.Size(49, 13);
            this.lvlGrandTotal.TabIndex = 48;
            this.lvlGrandTotal.Text = "Amount";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(29, 93);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerName.TabIndex = 42;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(132, 93);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerName.TabIndex = 36;
            this.txtCustomerName.Tag = "customer_name";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(29, 142);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 13);
            this.lblAdress.TabIndex = 43;
            this.lblAdress.Text = "Adress";
            this.lblAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(132, 145);
            this.txtAdress.MaxLength = 200;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(162, 20);
            this.txtAdress.TabIndex = 37;
            this.txtAdress.Tag = "adress";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(29, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 44;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 171);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(116, 20);
            this.txtPhone.TabIndex = 38;
            this.txtPhone.Tag = "phone";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(31, 46);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(86, 13);
            this.lblPaymentDate.TabIndex = 45;
            this.lblPaymentDate.Text = "Payment Date";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPaymentDate.CustomFormat = "dd-MMM-yyyy hh:mm:ss tt";
            this.dtpPaymentDate.Enabled = false;
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(132, 42);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(116, 20);
            this.dtpPaymentDate.TabIndex = 41;
            this.dtpPaymentDate.Tag = "sales_date";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(29, 200);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentType.TabIndex = 46;
            this.lblPaymentType.Text = "Payment Type";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(132, 197);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(127, 21);
            this.cmbPaymentType.TabIndex = 40;
            this.cmbPaymentType.Tag = "payment_type_id";
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(29, 118);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(94, 13);
            this.lblGuardianName.TabIndex = 47;
            this.lblGuardianName.Text = "Guardian Name";
            this.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGaurdianName
            // 
            this.txtGaurdianName.Location = new System.Drawing.Point(132, 119);
            this.txtGaurdianName.MaxLength = 300;
            this.txtGaurdianName.Name = "txtGaurdianName";
            this.txtGaurdianName.ReadOnly = true;
            this.txtGaurdianName.Size = new System.Drawing.Size(162, 20);
            this.txtGaurdianName.TabIndex = 39;
            this.txtGaurdianName.Tag = "remarks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Location = new System.Drawing.Point(250, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(162, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 28);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(10, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 28);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(89, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 28);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(237, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 28);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmOPDPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOPDPayment";
            this.Text = "FrmOPDPayment";
            this.Load += new System.EventHandler(this.FrmOPDPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader is_discharged;
        private System.Windows.Forms.ColumnHeader guardian_name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader OPDRegistrationFee;
        private System.Windows.Forms.ColumnHeader MedicineBill;
        private System.Windows.Forms.ColumnHeader HospitalService;
        private System.Windows.Forms.ColumnHeader opdbill_id;
        private System.Windows.Forms.ColumnHeader opdadmission_id;
    }
}