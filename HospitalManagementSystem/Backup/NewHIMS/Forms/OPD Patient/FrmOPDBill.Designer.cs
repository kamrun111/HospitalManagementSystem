namespace NewHIMS.Forms.OPD_Patient
{
    partial class FrmOPDBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOPDBill));
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
            this.Pay = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.lvwBill = new System.Windows.Forms.ListView();
            this.Discription = new System.Windows.Forms.ColumnHeader();
            this.TotalCharge = new System.Windows.Forms.ColumnHeader();
            this.lblOTcharges = new System.Windows.Forms.Label();
            this.btnOt = new System.Windows.Forms.Button();
            this.lblOt = new System.Windows.Forms.Label();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnInvestigation = new System.Windows.Forms.Button();
            this.lblInvestigation = new System.Windows.Forms.Label();
            this.lblDoctorsBill = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtNetPayable = new System.Windows.Forms.TextBox();
            this.lblNetPayable = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lvlGrandTotal = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.opdadmission_id,
            this.Pay});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(7, 79);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(241, 290);
            this.lvwPatientInfo.TabIndex = 6;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.SelectedIndexChanged += new System.EventHandler(this.lvwPatientInfo_SelectedIndexChanged);
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
            // Pay
            // 
            this.Pay.Text = "Pay";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(823, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "OPD Bill";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwBill
            // 
            this.lvwBill.BackColor = System.Drawing.Color.Linen;
            this.lvwBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Discription,
            this.TotalCharge});
            this.lvwBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBill.ForeColor = System.Drawing.Color.Black;
            this.lvwBill.FullRowSelect = true;
            this.lvwBill.GridLines = true;
            this.lvwBill.HideSelection = false;
            this.lvwBill.Location = new System.Drawing.Point(15, 18);
            this.lvwBill.Name = "lvwBill";
            this.lvwBill.Size = new System.Drawing.Size(343, 140);
            this.lvwBill.TabIndex = 42;
            this.lvwBill.UseCompatibleStateImageBehavior = false;
            this.lvwBill.View = System.Windows.Forms.View.Details;
            // 
            // Discription
            // 
            this.Discription.Text = "Discription";
            this.Discription.Width = 237;
            // 
            // TotalCharge
            // 
            this.TotalCharge.Text = "Total Charge";
            this.TotalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalCharge.Width = 100;
            // 
            // lblOTcharges
            // 
            this.lblOTcharges.AutoSize = true;
            this.lblOTcharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTcharges.Location = new System.Drawing.Point(69, 78);
            this.lblOTcharges.Name = "lblOTcharges";
            this.lblOTcharges.Size = new System.Drawing.Size(73, 13);
            this.lblOTcharges.TabIndex = 88;
            this.lblOTcharges.Text = "H. Services";
            // 
            // btnOt
            // 
            this.btnOt.Location = new System.Drawing.Point(13, 102);
            this.btnOt.Name = "btnOt";
            this.btnOt.Size = new System.Drawing.Size(49, 23);
            this.btnOt.TabIndex = 87;
            this.btnOt.Text = "Details";
            this.btnOt.UseVisualStyleBackColor = true;
            this.btnOt.Click += new System.EventHandler(this.btnOt_Click);
            // 
            // lblOt
            // 
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt.Location = new System.Drawing.Point(68, 47);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(66, 15);
            this.lblOt.TabIndex = 86;
            this.lblOt.Text = "Medicine";
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(13, 73);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(49, 23);
            this.btnTreatment.TabIndex = 85;
            this.btnTreatment.Text = "Details";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnInvestigation
            // 
            this.btnInvestigation.Location = new System.Drawing.Point(13, 44);
            this.btnInvestigation.Name = "btnInvestigation";
            this.btnInvestigation.Size = new System.Drawing.Size(49, 23);
            this.btnInvestigation.TabIndex = 83;
            this.btnInvestigation.Text = "Details";
            this.btnInvestigation.UseVisualStyleBackColor = true;
            this.btnInvestigation.Click += new System.EventHandler(this.btnInvestigation_Click);
            // 
            // lblInvestigation
            // 
            this.lblInvestigation.AutoSize = true;
            this.lblInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigation.Location = new System.Drawing.Point(71, 107);
            this.lblInvestigation.Name = "lblInvestigation";
            this.lblInvestigation.Size = new System.Drawing.Size(27, 15);
            this.lblInvestigation.TabIndex = 82;
            this.lblInvestigation.Text = "All ";
            // 
            // lblDoctorsBill
            // 
            this.lblDoctorsBill.AutoSize = true;
            this.lblDoctorsBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorsBill.ForeColor = System.Drawing.Color.Turquoise;
            this.lblDoctorsBill.Location = new System.Drawing.Point(94, 46);
            this.lblDoctorsBill.Name = "lblDoctorsBill";
            this.lblDoctorsBill.Size = new System.Drawing.Size(0, 20);
            this.lblDoctorsBill.TabIndex = 143;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(20, 186);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(81, 28);
            this.btnPreview.TabIndex = 134;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(254, 99);
            this.txtdiscount.MaxLength = 8;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(103, 20);
            this.txtdiscount.TabIndex = 133;
            this.txtdiscount.Text = "0.0";
            this.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(102, 98);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 15);
            this.lblDiscount.TabIndex = 132;
            this.lblDiscount.Text = "Discount";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(259, 19);
            this.txtSubTotal.MaxLength = 8;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 131;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSubTotal.Location = new System.Drawing.Point(95, 20);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(73, 17);
            this.lblSubTotal.TabIndex = 130;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(242, 43);
            this.txtPercentage.MaxLength = 4;
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(36, 20);
            this.txtPercentage.TabIndex = 129;
            this.txtPercentage.Text = "2.25";
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(298, 43);
            this.txtVat.MaxLength = 6;
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(60, 20);
            this.txtVat.TabIndex = 128;
            this.txtVat.Text = "0.0";
            this.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(275, 46);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(16, 13);
            this.lblPercentage.TabIndex = 127;
            this.lblPercentage.Text = "%";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(95, 46);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(38, 17);
            this.lblVat.TabIndex = 126;
            this.lblVat.Text = "VAT";
            // 
            // txtNetPayable
            // 
            this.txtNetPayable.Location = new System.Drawing.Point(253, 73);
            this.txtNetPayable.MaxLength = 8;
            this.txtNetPayable.Name = "txtNetPayable";
            this.txtNetPayable.ReadOnly = true;
            this.txtNetPayable.Size = new System.Drawing.Size(103, 20);
            this.txtNetPayable.TabIndex = 125;
            this.txtNetPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNetPayable
            // 
            this.lblNetPayable.AutoSize = true;
            this.lblNetPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNetPayable.Location = new System.Drawing.Point(94, 73);
            this.lblNetPayable.Name = "lblNetPayable";
            this.lblNetPayable.Size = new System.Drawing.Size(96, 17);
            this.lblNetPayable.TabIndex = 124;
            this.lblNetPayable.Text = "Net Payable";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(255, 150);
            this.txtTotal.MaxLength = 8;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 117;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvlGrandTotal
            // 
            this.lvlGrandTotal.AutoSize = true;
            this.lvlGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlGrandTotal.Location = new System.Drawing.Point(95, 156);
            this.lvlGrandTotal.Name = "lvlGrandTotal";
            this.lvlGrandTotal.Size = new System.Drawing.Size(95, 17);
            this.lvlGrandTotal.TabIndex = 116;
            this.lvlGrandTotal.Text = "Grand Total";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(105, 186);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 28);
            this.btnRefresh.TabIndex = 113;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(190, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 28);
            this.btnSave.TabIndex = 112;
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
            this.btnClose.Location = new System.Drawing.Point(279, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 28);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdvance);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.lblDoctorsBill);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtdiscount);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.lvlGrandTotal);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNetPayable);
            this.groupBox1.Controls.Add(this.txtPercentage);
            this.groupBox1.Controls.Add(this.txtNetPayable);
            this.groupBox1.Controls.Add(this.txtVat);
            this.groupBox1.Controls.Add(this.lblVat);
            this.groupBox1.Controls.Add(this.lblPercentage);
            this.groupBox1.Location = new System.Drawing.Point(272, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 227);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Enabled = false;
            this.txtAdvance.Location = new System.Drawing.Point(252, 125);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(106, 20);
            this.txtAdvance.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(102, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 124;
            this.label2.Text = "Advance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRegID);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lvwPatientInfo);
            this.groupBox2.Location = new System.Drawing.Point(8, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 375);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reg ID:";
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(26, 41);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(107, 20);
            this.txtRegID.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwBill);
            this.groupBox3.Location = new System.Drawing.Point(270, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 164);
            this.groupBox3.TabIndex = 146;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInvestigation);
            this.groupBox4.Controls.Add(this.lblInvestigation);
            this.groupBox4.Controls.Add(this.btnTreatment);
            this.groupBox4.Controls.Add(this.lblOt);
            this.groupBox4.Controls.Add(this.lblOTcharges);
            this.groupBox4.Controls.Add(this.btnOt);
            this.groupBox4.Location = new System.Drawing.Point(659, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 162);
            this.groupBox4.TabIndex = 147;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "Other Items";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 148;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOPDBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(817, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOPDBill";
            this.Text = "  OPD  Bill";
            this.Load += new System.EventHandler(this.FrmOPDBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader patient_code;
        //private System.Windows.Forms.ColumnHeader opd_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader is_discharged;
        private System.Windows.Forms.ColumnHeader guardian_name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwBill;
        private System.Windows.Forms.ColumnHeader Discription;
        private System.Windows.Forms.ColumnHeader TotalCharge;
        private System.Windows.Forms.Label lblOTcharges;
        private System.Windows.Forms.Button btnOt;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnInvestigation;
        private System.Windows.Forms.Label lblInvestigation;
        private System.Windows.Forms.Label lblDoctorsBill;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtNetPayable;
        private System.Windows.Forms.Label lblNetPayable;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lvlGrandTotal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader OPDRegistrationFee;
        private System.Windows.Forms.ColumnHeader MedicineBill;
        private System.Windows.Forms.ColumnHeader HospitalService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader opdbill_id;
        private System.Windows.Forms.ColumnHeader opdadmission_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader Pay;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}