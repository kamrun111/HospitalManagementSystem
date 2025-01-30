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
            this.rdoInvestigationReport = new System.Windows.Forms.RadioButton();
            this.rdoAdmission = new System.Windows.Forms.RadioButton();
            this.rdoPrescription = new System.Windows.Forms.RadioButton();
            this.rdoPament = new System.Windows.Forms.RadioButton();
            this.rdoInvoice = new System.Windows.Forms.RadioButton();
            this.rdoDischarge = new System.Windows.Forms.RadioButton();
            this.rdoBill = new System.Windows.Forms.RadioButton();
            this.rdootheritem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdocabin = new System.Windows.Forms.RadioButton();
            this.rdoMedicine = new System.Windows.Forms.RadioButton();
            this.rdodoctorBill = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHospitalID
            // 
            this.lblHospitalID.AutoSize = true;
            this.lblHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalID.Location = new System.Drawing.Point(32, 22);
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
            this.lblPatientName.Location = new System.Drawing.Point(23, 51);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(87, 13);
            this.lblPatientName.TabIndex = 124;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.Location = new System.Drawing.Point(118, 48);
            this.txtPatientName.MaxLength = 255;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(276, 20);
            this.txtPatientName.TabIndex = 120;
            this.txtPatientName.Tag = "patient_name";
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(12, 81);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(98, 13);
            this.lblGuardianName.TabIndex = 125;
            this.lblGuardianName.Text = "Guardian Name:";
            this.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BackColor = System.Drawing.Color.Linen;
            this.txtGuardianName.Location = new System.Drawing.Point(118, 78);
            this.txtGuardianName.MaxLength = 255;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.ReadOnly = true;
            this.txtGuardianName.Size = new System.Drawing.Size(276, 20);
            this.txtGuardianName.TabIndex = 121;
            this.txtGuardianName.Tag = "guardian_name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(54, 109);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 126;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Linen;
            this.txtAddress.Location = new System.Drawing.Point(118, 106);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(276, 20);
            this.txtAddress.TabIndex = 122;
            this.txtAddress.Tag = "address";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.Location = new System.Drawing.Point(51, 138);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(59, 13);
            this.lblCPhone.TabIndex = 127;
            this.lblCPhone.Text = "C Phone:";
            this.lblCPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCPhone
            // 
            this.txtCPhone.BackColor = System.Drawing.Color.Linen;
            this.txtCPhone.Location = new System.Drawing.Point(118, 135);
            this.txtCPhone.MaxLength = 15;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.ReadOnly = true;
            this.txtCPhone.Size = new System.Drawing.Size(276, 20);
            this.txtCPhone.TabIndex = 123;
            this.txtCPhone.Tag = "c_phone";
            // 
            // chkAdmittedPatientOnly
            // 
            this.chkAdmittedPatientOnly.AutoSize = true;
            this.chkAdmittedPatientOnly.Checked = true;
            this.chkAdmittedPatientOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdmittedPatientOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmittedPatientOnly.Location = new System.Drawing.Point(250, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 168);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Search";
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(115, 405);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(104, 21);
            this.cmbPayment.TabIndex = 136;
            this.cmbPayment.Tag = "department_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 408);
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
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Invocices  List :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // cmbInvoice
            // 
            this.cmbInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoice.FormattingEnabled = true;
            this.cmbInvoice.Location = new System.Drawing.Point(14, 22);
            this.cmbInvoice.Name = "cmbInvoice";
            this.cmbInvoice.Size = new System.Drawing.Size(60, 21);
            this.cmbInvoice.TabIndex = 138;
            this.cmbInvoice.Tag = "department_id";
            this.cmbInvoice.Visible = false;
            // 
            // btnadmissionPrint
            // 
            this.btnadmissionPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadmissionPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmissionPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmissionPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnadmissionPrint.Image")));
            this.btnadmissionPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmissionPrint.Location = new System.Drawing.Point(258, 444);
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
            this.lnkSearch.Location = new System.Drawing.Point(31, 57);
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
            this.lvwPatientInfo.Location = new System.Drawing.Point(33, 273);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(209, 161);
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
            this.label6.Location = new System.Drawing.Point(217, 413);
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
            this.cmbInvestigation.Location = new System.Drawing.Point(361, 408);
            this.cmbInvestigation.Name = "cmbInvestigation";
            this.cmbInvestigation.Size = new System.Drawing.Size(68, 21);
            this.cmbInvestigation.TabIndex = 148;
            this.cmbInvestigation.Tag = "department_id";
            this.cmbInvestigation.Visible = false;
            // 
            // rdoInvestigationReport
            // 
            this.rdoInvestigationReport.AutoSize = true;
            this.rdoInvestigationReport.Location = new System.Drawing.Point(24, 175);
            this.rdoInvestigationReport.Name = "rdoInvestigationReport";
            this.rdoInvestigationReport.Size = new System.Drawing.Size(85, 17);
            this.rdoInvestigationReport.TabIndex = 151;
            this.rdoInvestigationReport.Text = "Investigation";
            this.rdoInvestigationReport.UseVisualStyleBackColor = true;
            this.rdoInvestigationReport.Visible = false;
            // 
            // rdoAdmission
            // 
            this.rdoAdmission.AutoSize = true;
            this.rdoAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmission.Location = new System.Drawing.Point(23, 26);
            this.rdoAdmission.Name = "rdoAdmission";
            this.rdoAdmission.Size = new System.Drawing.Size(89, 20);
            this.rdoAdmission.TabIndex = 152;
            this.rdoAdmission.Text = "Admission";
            this.rdoAdmission.UseVisualStyleBackColor = true;
            // 
            // rdoPrescription
            // 
            this.rdoPrescription.AutoSize = true;
            this.rdoPrescription.Location = new System.Drawing.Point(115, 6);
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
            this.rdoPament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPament.Location = new System.Drawing.Point(23, 51);
            this.rdoPament.Name = "rdoPament";
            this.rdoPament.Size = new System.Drawing.Size(79, 20);
            this.rdoPament.TabIndex = 154;
            this.rdoPament.Text = "Payment";
            this.rdoPament.UseVisualStyleBackColor = true;
            this.rdoPament.CheckedChanged += new System.EventHandler(this.rdoPament_CheckedChanged);
            // 
            // rdoInvoice
            // 
            this.rdoInvoice.AutoSize = true;
            this.rdoInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInvoice.Location = new System.Drawing.Point(117, 19);
            this.rdoInvoice.Name = "rdoInvoice";
            this.rdoInvoice.Size = new System.Drawing.Size(76, 20);
            this.rdoInvoice.TabIndex = 155;
            this.rdoInvoice.Text = "Invoices";
            this.rdoInvoice.UseVisualStyleBackColor = true;
            this.rdoInvoice.Visible = false;
            // 
            // rdoDischarge
            // 
            this.rdoDischarge.AutoSize = true;
            this.rdoDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDischarge.Location = new System.Drawing.Point(23, 149);
            this.rdoDischarge.Name = "rdoDischarge";
            this.rdoDischarge.Size = new System.Drawing.Size(88, 20);
            this.rdoDischarge.TabIndex = 156;
            this.rdoDischarge.Text = "Discharge";
            this.rdoDischarge.UseVisualStyleBackColor = true;
            // 
            // rdoBill
            // 
            this.rdoBill.AutoSize = true;
            this.rdoBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBill.Location = new System.Drawing.Point(23, 74);
            this.rdoBill.Name = "rdoBill";
            this.rdoBill.Size = new System.Drawing.Size(44, 20);
            this.rdoBill.TabIndex = 157;
            this.rdoBill.Text = "Bill";
            this.rdoBill.UseVisualStyleBackColor = true;
            // 
            // rdootheritem
            // 
            this.rdootheritem.AutoSize = true;
            this.rdootheritem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdootheritem.Location = new System.Drawing.Point(23, 97);
            this.rdootheritem.Name = "rdootheritem";
            this.rdootheritem.Size = new System.Drawing.Size(86, 20);
            this.rdootheritem.TabIndex = 158;
            this.rdootheritem.Text = "Other Item";
            this.rdootheritem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdocabin);
            this.groupBox2.Controls.Add(this.rdoMedicine);
            this.groupBox2.Controls.Add(this.rdoInvestigationReport);
            this.groupBox2.Controls.Add(this.rdodoctorBill);
            this.groupBox2.Controls.Add(this.rdoAdmission);
            this.groupBox2.Controls.Add(this.rdoPament);
            this.groupBox2.Controls.Add(this.rdootheritem);
            this.groupBox2.Controls.Add(this.rdoInvoice);
            this.groupBox2.Controls.Add(this.rdoDischarge);
            this.groupBox2.Controls.Add(this.rdoBill);
            this.groupBox2.Location = new System.Drawing.Point(255, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 202);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Report";
            // 
            // rdocabin
            // 
            this.rdocabin.AutoSize = true;
            this.rdocabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdocabin.Location = new System.Drawing.Point(23, 123);
            this.rdocabin.Name = "rdocabin";
            this.rdocabin.Size = new System.Drawing.Size(106, 20);
            this.rdocabin.TabIndex = 161;
            this.rdocabin.Text = "Cabin Details";
            this.rdocabin.UseVisualStyleBackColor = true;
            // 
            // rdoMedicine
            // 
            this.rdoMedicine.AutoSize = true;
            this.rdoMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedicine.Location = new System.Drawing.Point(82, 68);
            this.rdoMedicine.Name = "rdoMedicine";
            this.rdoMedicine.Size = new System.Drawing.Size(126, 20);
            this.rdoMedicine.TabIndex = 160;
            this.rdoMedicine.Text = "Medicine Details";
            this.rdoMedicine.UseVisualStyleBackColor = true;
            this.rdoMedicine.Visible = false;
            // 
            // rdodoctorBill
            // 
            this.rdodoctorBill.AutoSize = true;
            this.rdodoctorBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdodoctorBill.Location = new System.Drawing.Point(111, 94);
            this.rdodoctorBill.Name = "rdodoctorBill";
            this.rdodoctorBill.Size = new System.Drawing.Size(97, 20);
            this.rdodoctorBill.TabIndex = 159;
            this.rdodoctorBill.Text = "Doctor\'s Bill";
            this.rdodoctorBill.UseVisualStyleBackColor = true;
            this.rdodoctorBill.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(336, 444);
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
            this.btnRefresh.Location = new System.Drawing.Point(180, 444);
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
            this.txtEquation.Location = new System.Drawing.Point(24, 437);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(108, 20);
            this.txtEquation.TabIndex = 156;
            this.txtEquation.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Linen;
            this.textBox1.Location = new System.Drawing.Point(240, 49);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 164;
            this.textBox1.Tag = "guardian_name";
            this.textBox1.Visible = false;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.BackColor = System.Drawing.Color.Linen;
            this.txtSerialNo.Location = new System.Drawing.Point(320, 50);
            this.txtSerialNo.MaxLength = 255;
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(29, 20);
            this.txtSerialNo.TabIndex = 163;
            this.txtSerialNo.Tag = "guardian_name";
            this.txtSerialNo.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-2, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(465, 29);
            this.label7.TabIndex = 165;
            this.label7.Text = "Patient\'s All Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbPayment);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.txtEquation);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbInvestigation);
            this.groupBox3.Controls.Add(this.btnadmissionPrint);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(9, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 495);
            this.groupBox3.TabIndex = 135;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(16, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 184);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Patient";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.cmbInvoice);
            this.groupBox5.Controls.Add(this.rdoPrescription);
            this.groupBox5.Location = new System.Drawing.Point(16, 424);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 62);
            this.groupBox5.TabIndex = 162;
            this.groupBox5.TabStop = false;
            // 
            // FrmPrintAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(460, 546);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvwPatientInfo);
            this.Controls.Add(this.lnkSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint For Patient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdoInvestigationReport;
        private System.Windows.Forms.RadioButton rdoAdmission;
        private System.Windows.Forms.RadioButton rdoPrescription;
        private System.Windows.Forms.RadioButton rdoPament;
        private System.Windows.Forms.RadioButton rdoInvoice;
        private System.Windows.Forms.RadioButton rdoDischarge;
        private System.Windows.Forms.RadioButton rdoBill;
        private System.Windows.Forms.RadioButton rdootheritem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdodoctorBill;
        private System.Windows.Forms.ColumnHeader is_discharge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.RadioButton rdoMedicine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.RadioButton rdocabin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;

    }
}