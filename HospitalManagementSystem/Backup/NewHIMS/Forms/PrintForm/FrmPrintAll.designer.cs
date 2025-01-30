namespace NewHIMS.Forms.PrintForm
{
    partial class FrmPrintAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintAll));
            this.lblHospitalID = new System.Windows.Forms.Label();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.chkAdmittedPatientOnly = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInvoice = new System.Windows.Forms.ComboBox();
            this.btnadmissionPrint = new System.Windows.Forms.Button();
            this.lnkSearch = new System.Windows.Forms.LinkLabel();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.case_id = new System.Windows.Forms.ColumnHeader();
            this.admissionCode = new System.Windows.Forms.ColumnHeader();
            this.admissionid = new System.Windows.Forms.ColumnHeader();
            this.is_discharge = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInvestigation = new System.Windows.Forms.ComboBox();
            this.rdoInvestigation = new System.Windows.Forms.RadioButton();
            this.rdoAdmission = new System.Windows.Forms.RadioButton();
            this.rdoPrescription = new System.Windows.Forms.RadioButton();
            this.rdoPament = new System.Windows.Forms.RadioButton();
            this.rdoInvoice = new System.Windows.Forms.RadioButton();
            this.rdoDischarge = new System.Windows.Forms.RadioButton();
            this.rdoBill = new System.Windows.Forms.RadioButton();
            this.rdootheritem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoMedicine = new System.Windows.Forms.RadioButton();
            this.rdodoctorBill = new System.Windows.Forms.RadioButton();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHospitalID
            // 
            this.lblHospitalID.AutoSize = true;
            this.lblHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalID.Location = new System.Drawing.Point(20, 22);
            this.lblHospitalID.Name = "lblHospitalID";
            this.lblHospitalID.Size = new System.Drawing.Size(78, 13);
            this.lblHospitalID.TabIndex = 129;
            this.lblHospitalID.Text = "Hospital ID :";
            this.lblHospitalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.BackColor = System.Drawing.Color.Linen;
            this.txtHospitalID.Location = new System.Drawing.Point(118, 19);
            this.txtHospitalID.MaxLength = 255;
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.ReadOnly = true;
            this.txtHospitalID.Size = new System.Drawing.Size(119, 20);
            this.txtHospitalID.TabIndex = 12;
            this.txtHospitalID.Tag = "guardian_name";
            this.txtHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospitalID_KeyPress);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(20, 58);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(87, 13);
            this.lblPatientName.TabIndex = 124;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.Location = new System.Drawing.Point(118, 55);
            this.txtPatientName.MaxLength = 255;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(335, 20);
            this.txtPatientName.TabIndex = 120;
            this.txtPatientName.Tag = "patient_name";
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(20, 79);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(98, 13);
            this.lblGuardianName.TabIndex = 125;
            this.lblGuardianName.Text = "Guardian Name:";
            this.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BackColor = System.Drawing.Color.Linen;
            this.txtGuardianName.Location = new System.Drawing.Point(118, 76);
            this.txtGuardianName.MaxLength = 255;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.ReadOnly = true;
            this.txtGuardianName.Size = new System.Drawing.Size(335, 20);
            this.txtGuardianName.TabIndex = 121;
            this.txtGuardianName.Tag = "guardian_name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 100);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 126;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Linen;
            this.txtAddress.Location = new System.Drawing.Point(118, 97);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(335, 20);
            this.txtAddress.TabIndex = 122;
            this.txtAddress.Tag = "address";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.Location = new System.Drawing.Point(20, 121);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(59, 13);
            this.lblCPhone.TabIndex = 127;
            this.lblCPhone.Text = "C Phone:";
            this.lblCPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCPhone
            // 
            this.txtCPhone.BackColor = System.Drawing.Color.Linen;
            this.txtCPhone.Location = new System.Drawing.Point(118, 118);
            this.txtCPhone.MaxLength = 15;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.ReadOnly = true;
            this.txtCPhone.Size = new System.Drawing.Size(335, 20);
            this.txtCPhone.TabIndex = 123;
            this.txtCPhone.Tag = "c_phone";
            // 
            // chkAdmittedPatientOnly
            // 
            this.chkAdmittedPatientOnly.AutoSize = true;
            this.chkAdmittedPatientOnly.Checked = true;
            this.chkAdmittedPatientOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdmittedPatientOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmittedPatientOnly.Location = new System.Drawing.Point(305, 22);
            this.chkAdmittedPatientOnly.Name = "chkAdmittedPatientOnly";
            this.chkAdmittedPatientOnly.Size = new System.Drawing.Size(148, 17);
            this.chkAdmittedPatientOnly.TabIndex = 134;
            this.chkAdmittedPatientOnly.Text = "Admitted Patient Only";
            this.chkAdmittedPatientOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAdmittedPatientOnly);
            this.groupBox1.Controls.Add(this.txtCPhone);
            this.groupBox1.Controls.Add(this.lblCPhone);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtGuardianName);
            this.groupBox1.Controls.Add(this.lblGuardianName);
            this.groupBox1.Controls.Add(this.lblHospitalID);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.txtHospitalID);
            this.groupBox1.Controls.Add(this.lblPatientName);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 152);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Search";
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(228, 336);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(126, 21);
            this.cmbPayment.TabIndex = 136;
            this.cmbPayment.Tag = "department_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "Payment List :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Invocices  List :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbInvoice
            // 
            this.cmbInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoice.FormattingEnabled = true;
            this.cmbInvoice.Location = new System.Drawing.Point(358, 336);
            this.cmbInvoice.Name = "cmbInvoice";
            this.cmbInvoice.Size = new System.Drawing.Size(126, 21);
            this.cmbInvoice.TabIndex = 138;
            this.cmbInvoice.Tag = "department_id";
            // 
            // btnadmissionPrint
            // 
            this.btnadmissionPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadmissionPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmissionPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmissionPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnadmissionPrint.Image")));
            this.btnadmissionPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmissionPrint.Location = new System.Drawing.Point(334, 410);
            this.btnadmissionPrint.Name = "btnadmissionPrint";
            this.btnadmissionPrint.Size = new System.Drawing.Size(72, 28);
            this.btnadmissionPrint.TabIndex = 140;
            this.btnadmissionPrint.Text = "Print";
            this.btnadmissionPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadmissionPrint.UseVisualStyleBackColor = true;
            this.btnadmissionPrint.Click += new System.EventHandler(this.btnadmissionPrint_Click);
            // 
            // lnkSearch
            // 
            this.lnkSearch.AutoSize = true;
            this.lnkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSearch.Location = new System.Drawing.Point(16, 9);
            this.lnkSearch.Name = "lnkSearch";
            this.lnkSearch.Size = new System.Drawing.Size(57, 16);
            this.lnkSearch.TabIndex = 1;
            this.lnkSearch.TabStop = true;
            this.lnkSearch.Text = "Search";
            this.lnkSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSearch_LinkClicked);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.case_id,
            this.admissionCode,
            this.admissionid,
            this.is_discharge});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(13, 190);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(209, 248);
            this.lvwPatientInfo.TabIndex = 146;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // case_id
            // 
            this.case_id.Text = "Case No";
            this.case_id.Width = 80;
            // 
            // admissionCode
            // 
            this.admissionCode.Text = "Registration ID";
            this.admissionCode.Width = 120;
            // 
            // admissionid
            // 
            this.admissionid.Text = "admissionid";
            this.admissionid.Width = 0;
            // 
            // is_discharge
            // 
            this.is_discharge.Text = "is_discharge";
            this.is_discharge.Width = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 147;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 149;
            this.label6.Text = "Investigation List :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // cmbInvestigation
            // 
            this.cmbInvestigation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvestigation.FormattingEnabled = true;
            this.cmbInvestigation.Location = new System.Drawing.Point(228, 380);
            this.cmbInvestigation.Name = "cmbInvestigation";
            this.cmbInvestigation.Size = new System.Drawing.Size(126, 21);
            this.cmbInvestigation.TabIndex = 148;
            this.cmbInvestigation.Tag = "department_id";
            this.cmbInvestigation.Visible = false;
            // 
            // rdoInvestigation
            // 
            this.rdoInvestigation.AutoSize = true;
            this.rdoInvestigation.Location = new System.Drawing.Point(364, 384);
            this.rdoInvestigation.Name = "rdoInvestigation";
            this.rdoInvestigation.Size = new System.Drawing.Size(85, 17);
            this.rdoInvestigation.TabIndex = 151;
            this.rdoInvestigation.Text = "Investigation";
            this.rdoInvestigation.UseVisualStyleBackColor = true;
            this.rdoInvestigation.Visible = false;
            // 
            // rdoAdmission
            // 
            this.rdoAdmission.AutoSize = true;
            this.rdoAdmission.Location = new System.Drawing.Point(38, 19);
            this.rdoAdmission.Name = "rdoAdmission";
            this.rdoAdmission.Size = new System.Drawing.Size(72, 17);
            this.rdoAdmission.TabIndex = 152;
            this.rdoAdmission.Text = "Admission";
            this.rdoAdmission.UseVisualStyleBackColor = true;
            // 
            // rdoPrescription
            // 
            this.rdoPrescription.AutoSize = true;
            this.rdoPrescription.Location = new System.Drawing.Point(364, 361);
            this.rdoPrescription.Name = "rdoPrescription";
            this.rdoPrescription.Size = new System.Drawing.Size(80, 17);
            this.rdoPrescription.TabIndex = 153;
            this.rdoPrescription.Text = "Prescription";
            this.rdoPrescription.UseVisualStyleBackColor = true;
            this.rdoPrescription.Visible = false;
            // 
            // rdoPament
            // 
            this.rdoPament.AutoSize = true;
            this.rdoPament.Location = new System.Drawing.Point(38, 44);
            this.rdoPament.Name = "rdoPament";
            this.rdoPament.Size = new System.Drawing.Size(66, 17);
            this.rdoPament.TabIndex = 154;
            this.rdoPament.Text = "Payment";
            this.rdoPament.UseVisualStyleBackColor = true;
            this.rdoPament.CheckedChanged += new System.EventHandler(this.rdoPament_CheckedChanged);
            // 
            // rdoInvoice
            // 
            this.rdoInvoice.AutoSize = true;
            this.rdoInvoice.Location = new System.Drawing.Point(136, 19);
            this.rdoInvoice.Name = "rdoInvoice";
            this.rdoInvoice.Size = new System.Drawing.Size(65, 17);
            this.rdoInvoice.TabIndex = 155;
            this.rdoInvoice.Text = "Invoices";
            this.rdoInvoice.UseVisualStyleBackColor = true;
            // 
            // rdoDischarge
            // 
            this.rdoDischarge.AutoSize = true;
            this.rdoDischarge.Location = new System.Drawing.Point(136, 44);
            this.rdoDischarge.Name = "rdoDischarge";
            this.rdoDischarge.Size = new System.Drawing.Size(73, 17);
            this.rdoDischarge.TabIndex = 156;
            this.rdoDischarge.Text = "Discharge";
            this.rdoDischarge.UseVisualStyleBackColor = true;
            // 
            // rdoBill
            // 
            this.rdoBill.AutoSize = true;
            this.rdoBill.Location = new System.Drawing.Point(38, 67);
            this.rdoBill.Name = "rdoBill";
            this.rdoBill.Size = new System.Drawing.Size(38, 17);
            this.rdoBill.TabIndex = 157;
            this.rdoBill.Text = "Bill";
            this.rdoBill.UseVisualStyleBackColor = true;
            // 
            // rdootheritem
            // 
            this.rdootheritem.AutoSize = true;
            this.rdootheritem.Location = new System.Drawing.Point(38, 90);
            this.rdootheritem.Name = "rdootheritem";
            this.rdootheritem.Size = new System.Drawing.Size(74, 17);
            this.rdootheritem.TabIndex = 158;
            this.rdootheritem.Text = "Other Item";
            this.rdootheritem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMedicine);
            this.groupBox2.Controls.Add(this.rdodoctorBill);
            this.groupBox2.Controls.Add(this.rdoAdmission);
            this.groupBox2.Controls.Add(this.rdoPament);
            this.groupBox2.Controls.Add(this.rdootheritem);
            this.groupBox2.Controls.Add(this.rdoInvoice);
            this.groupBox2.Controls.Add(this.rdoDischarge);
            this.groupBox2.Controls.Add(this.rdoBill);
            this.groupBox2.Location = new System.Drawing.Point(228, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 118);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Report";
            // 
            // rdoMedicine
            // 
            this.rdoMedicine.AutoSize = true;
            this.rdoMedicine.Location = new System.Drawing.Point(136, 95);
            this.rdoMedicine.Name = "rdoMedicine";
            this.rdoMedicine.Size = new System.Drawing.Size(103, 17);
            this.rdoMedicine.TabIndex = 160;
            this.rdoMedicine.Text = "Medicine Details";
            this.rdoMedicine.UseVisualStyleBackColor = true;
            // 
            // rdodoctorBill
            // 
            this.rdodoctorBill.AutoSize = true;
            this.rdodoctorBill.Location = new System.Drawing.Point(136, 69);
            this.rdodoctorBill.Name = "rdodoctorBill";
            this.rdodoctorBill.Size = new System.Drawing.Size(80, 17);
            this.rdodoctorBill.TabIndex = 159;
            this.rdodoctorBill.Text = "Doctor\'s Bill";
            this.rdodoctorBill.UseVisualStyleBackColor = true;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BackColor = System.Drawing.Color.Linen;
            this.txtSerialNo.Location = new System.Drawing.Point(437, 9);
            this.txtSerialNo.MaxLength = 255;
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(29, 20);
            this.txtSerialNo.TabIndex = 135;
            this.txtSerialNo.Tag = "guardian_name";
            this.txtSerialNo.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(412, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 28);
            this.btnClose.TabIndex = 154;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(256, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 28);
            this.btnRefresh.TabIndex = 155;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(358, 337);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(108, 20);
            this.txtEquation.TabIndex = 156;
            this.txtEquation.Visible = false;
            // 
            // FrmPrintAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbInvestigation);
            this.Controls.Add(this.rdoInvestigation);
            this.Controls.Add(this.rdoPrescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvwPatientInfo);
            this.Controls.Add(this.lnkSearch);
            this.Controls.Add(this.btnadmissionPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmPrintAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint For Patient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHospitalID;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.CheckBox chkAdmittedPatientOnly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInvoice;
        private System.Windows.Forms.Button btnadmissionPrint;
        private System.Windows.Forms.LinkLabel lnkSearch;
        public System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader admissionCode;
        private System.Windows.Forms.ColumnHeader case_id;
        private System.Windows.Forms.ColumnHeader admissionid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInvestigation;
        private System.Windows.Forms.RadioButton rdoInvestigation;
        private System.Windows.Forms.RadioButton rdoAdmission;
        private System.Windows.Forms.RadioButton rdoPrescription;
        private System.Windows.Forms.RadioButton rdoPament;
        private System.Windows.Forms.RadioButton rdoInvoice;
        private System.Windows.Forms.RadioButton rdoDischarge;
        private System.Windows.Forms.RadioButton rdoBill;
        private System.Windows.Forms.RadioButton rdootheritem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.RadioButton rdodoctorBill;
        private System.Windows.Forms.ColumnHeader is_discharge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.RadioButton rdoMedicine;

    }
}