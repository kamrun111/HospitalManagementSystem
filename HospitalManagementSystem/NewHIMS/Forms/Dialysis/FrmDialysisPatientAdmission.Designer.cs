namespace NewHIMS.Forms.Dialysis
{
    partial class FrmDialysisPatientAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDialysisPatientAdmission));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCaseNo = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lnkNewPatient = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPatientCondition = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAdmissionCode = new System.Windows.Forms.Label();
            this.txtAdmissionCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientCode = new System.Windows.Forms.Label();
            this.txtPatientCode = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.lblGuardianRelation = new System.Windows.Forms.Label();
            this.cmbGuardianRelation = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.lblAgeDd = new System.Windows.Forms.Label();
            this.txtAgeDd = new System.Windows.Forms.TextBox();
            this.lblAgeMm = new System.Windows.Forms.Label();
            this.txtAgeMm = new System.Windows.Forms.TextBox();
            this.lblAgeYy = new System.Windows.Forms.Label();
            this.txtAgeYy = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRefferedDoctors = new System.Windows.Forms.ComboBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lnkSearch = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Salmon;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(283, -113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 27);
            this.btnSearch.TabIndex = 169;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(257, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 168;
            this.label19.Text = "Case No.";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Visible = false;
            // 
            // txtCaseNo
            // 
            this.txtCaseNo.ForeColor = System.Drawing.Color.Gray;
            this.txtCaseNo.Location = new System.Drawing.Point(320, 24);
            this.txtCaseNo.Name = "txtCaseNo";
            this.txtCaseNo.ReadOnly = true;
            this.txtCaseNo.Size = new System.Drawing.Size(37, 20);
            this.txtCaseNo.TabIndex = 167;
            this.txtCaseNo.Tag = "";
            this.txtCaseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCaseNo.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(521, 111);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(266, 22);
            this.dtpDOB.TabIndex = 139;
            this.dtpDOB.Tag = "dob";
            this.dtpDOB.Leave += new System.EventHandler(this.dtpDOB_Leave);
            this.dtpDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDOB_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(139, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 166;
            this.textBox2.Tag = "";
            this.textBox2.Text = "IPD";
            // 
            // lnkNewPatient
            // 
            this.lnkNewPatient.AutoSize = true;
            this.lnkNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNewPatient.Location = new System.Drawing.Point(289, 93);
            this.lnkNewPatient.Name = "lnkNewPatient";
            this.lnkNewPatient.Size = new System.Drawing.Size(94, 20);
            this.lnkNewPatient.TabIndex = 165;
            this.lnkNewPatient.TabStop = true;
            this.lnkNewPatient.Text = "New Patient";
            this.lnkNewPatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewPatient_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(246, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 164;
            this.label12.Text = "Occupation:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOccupation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOccupation.BackColor = System.Drawing.Color.Linen;
            this.cmbOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Location = new System.Drawing.Point(328, 151);
            this.cmbOccupation.MaxLength = 25;
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(76, 24);
            this.cmbOccupation.TabIndex = 135;
            this.cmbOccupation.Tag = "occupation_id";
            this.cmbOccupation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOccupation_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(237, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 163;
            this.label11.Text = "Patient Condition:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPatientCondition
            // 
            this.cmbPatientCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPatientCondition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPatientCondition.BackColor = System.Drawing.Color.Linen;
            this.cmbPatientCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatientCondition.FormattingEnabled = true;
            this.cmbPatientCondition.Location = new System.Drawing.Point(329, 219);
            this.cmbPatientCondition.MaxLength = 25;
            this.cmbPatientCondition.Name = "cmbPatientCondition";
            this.cmbPatientCondition.Size = new System.Drawing.Size(76, 24);
            this.cmbPatientCondition.TabIndex = 145;
            this.cmbPatientCondition.Tag = "patient_condition_id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 162;
            this.label10.Text = "Date Of Birth:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdmissionCode
            // 
            this.lblAdmissionCode.AutoSize = true;
            this.lblAdmissionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdmissionCode.Location = new System.Drawing.Point(46, 70);
            this.lblAdmissionCode.Name = "lblAdmissionCode";
            this.lblAdmissionCode.Size = new System.Drawing.Size(84, 13);
            this.lblAdmissionCode.TabIndex = 161;
            this.lblAdmissionCode.Text = "Admission ID:";
            this.lblAdmissionCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdmissionCode
            // 
            this.txtAdmissionCode.ForeColor = System.Drawing.Color.Gray;
            this.txtAdmissionCode.Location = new System.Drawing.Point(139, 66);
            this.txtAdmissionCode.Name = "txtAdmissionCode";
            this.txtAdmissionCode.ReadOnly = true;
            this.txtAdmissionCode.Size = new System.Drawing.Size(108, 20);
            this.txtAdmissionCode.TabIndex = 160;
            this.txtAdmissionCode.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 159;
            this.label1.Text = "Patient Age:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatientCode
            // 
            this.lblPatientCode.AutoSize = true;
            this.lblPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPatientCode.Location = new System.Drawing.Point(56, 98);
            this.lblPatientCode.Name = "lblPatientCode";
            this.lblPatientCode.Size = new System.Drawing.Size(74, 13);
            this.lblPatientCode.TabIndex = 147;
            this.lblPatientCode.Text = "Hospital ID:";
            this.lblPatientCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPatientCode.Location = new System.Drawing.Point(171, 94);
            this.txtPatientCode.MaxLength = 8;
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.ReadOnly = true;
            this.txtPatientCode.Size = new System.Drawing.Size(76, 20);
            this.txtPatientCode.TabIndex = 130;
            this.txtPatientCode.Tag = "patient_code";
            this.txtPatientCode.Text = "00000001";
            this.txtPatientCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPatientCode_KeyUp);
            this.txtPatientCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientCode_KeyPress);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(42, 125);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(92, 16);
            this.lblPatientName.TabIndex = 146;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(139, 122);
            this.txtPatientName.MaxLength = 100;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(266, 22);
            this.txtPatientName.TabIndex = 131;
            this.txtPatientName.Tag = "patient_name";
            this.txtPatientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientName_KeyPress);
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(30, 188);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(106, 16);
            this.lblGuardianName.TabIndex = 148;
            this.lblGuardianName.Text = "Guardian Name:";
            this.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BackColor = System.Drawing.Color.Linen;
            this.txtGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianName.Location = new System.Drawing.Point(139, 185);
            this.txtGuardianName.MaxLength = 100;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(266, 22);
            this.txtGuardianName.TabIndex = 132;
            this.txtGuardianName.Tag = "guardian_name";
            this.txtGuardianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianName_KeyPress);
            // 
            // lblGuardianRelation
            // 
            this.lblGuardianRelation.AutoSize = true;
            this.lblGuardianRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianRelation.Location = new System.Drawing.Point(15, 222);
            this.lblGuardianRelation.Name = "lblGuardianRelation";
            this.lblGuardianRelation.Size = new System.Drawing.Size(119, 16);
            this.lblGuardianRelation.TabIndex = 149;
            this.lblGuardianRelation.Text = "Guardian Relation:";
            this.lblGuardianRelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGuardianRelation
            // 
            this.cmbGuardianRelation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGuardianRelation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGuardianRelation.BackColor = System.Drawing.Color.Linen;
            this.cmbGuardianRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGuardianRelation.FormattingEnabled = true;
            this.cmbGuardianRelation.Location = new System.Drawing.Point(139, 216);
            this.cmbGuardianRelation.MaxLength = 25;
            this.cmbGuardianRelation.Name = "cmbGuardianRelation";
            this.cmbGuardianRelation.Size = new System.Drawing.Size(97, 24);
            this.cmbGuardianRelation.TabIndex = 133;
            this.cmbGuardianRelation.Tag = "guardian_relation_id";
            this.cmbGuardianRelation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGuardianRelation_KeyPress);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(77, 155);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 150;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.BackColor = System.Drawing.Color.Linen;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(139, 151);
            this.cmbGender.MaxLength = 25;
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(97, 24);
            this.cmbGender.TabIndex = 134;
            this.cmbGender.Tag = "gender_id";
            this.cmbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGender_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(22, 254);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(111, 16);
            this.lblAddress.TabIndex = 151;
            this.lblAddress.Text = "Present Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Linen;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(139, 250);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(266, 34);
            this.txtAddress.TabIndex = 136;
            this.txtAddress.Tag = "address";
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(95, 300);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 16);
            this.lblCity.TabIndex = 152;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.BackColor = System.Drawing.Color.Linen;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(139, 296);
            this.cmbCity.MaxLength = 25;
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(266, 24);
            this.cmbCity.TabIndex = 137;
            this.cmbCity.Tag = "city_id";
            this.cmbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCity_KeyPress);
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.Location = new System.Drawing.Point(408, 78);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(104, 16);
            this.lblCPhone.TabIndex = 153;
            this.lblCPhone.Text = "Phone / Mobile :";
            this.lblCPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCPhone
            // 
            this.txtCPhone.BackColor = System.Drawing.Color.Linen;
            this.txtCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPhone.Location = new System.Drawing.Point(521, 76);
            this.txtCPhone.MaxLength = 100;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(266, 22);
            this.txtCPhone.TabIndex = 138;
            this.txtCPhone.Tag = "c_phone";
            this.txtCPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPhone_KeyPress);
            // 
            // lblAgeDd
            // 
            this.lblAgeDd.AutoSize = true;
            this.lblAgeDd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeDd.Location = new System.Drawing.Point(760, 147);
            this.lblAgeDd.Name = "lblAgeDd";
            this.lblAgeDd.Size = new System.Drawing.Size(28, 15);
            this.lblAgeDd.TabIndex = 154;
            this.lblAgeDd.Text = "Day";
            this.lblAgeDd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeDd
            // 
            this.txtAgeDd.BackColor = System.Drawing.Color.Linen;
            this.txtAgeDd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDd.Location = new System.Drawing.Point(712, 144);
            this.txtAgeDd.MaxLength = 2;
            this.txtAgeDd.Name = "txtAgeDd";
            this.txtAgeDd.Size = new System.Drawing.Size(42, 22);
            this.txtAgeDd.TabIndex = 142;
            this.txtAgeDd.Tag = "";
            this.txtAgeDd.Text = "00";
            // 
            // lblAgeMm
            // 
            this.lblAgeMm.AutoSize = true;
            this.lblAgeMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeMm.Location = new System.Drawing.Point(664, 147);
            this.lblAgeMm.Name = "lblAgeMm";
            this.lblAgeMm.Size = new System.Drawing.Size(42, 15);
            this.lblAgeMm.TabIndex = 155;
            this.lblAgeMm.Text = "Month";
            this.lblAgeMm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeMm
            // 
            this.txtAgeMm.BackColor = System.Drawing.Color.Linen;
            this.txtAgeMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMm.Location = new System.Drawing.Point(619, 144);
            this.txtAgeMm.MaxLength = 2;
            this.txtAgeMm.Name = "txtAgeMm";
            this.txtAgeMm.Size = new System.Drawing.Size(39, 22);
            this.txtAgeMm.TabIndex = 141;
            this.txtAgeMm.Tag = "";
            this.txtAgeMm.Text = "00";
            // 
            // lblAgeYy
            // 
            this.lblAgeYy.AutoSize = true;
            this.lblAgeYy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeYy.Location = new System.Drawing.Point(578, 148);
            this.lblAgeYy.Name = "lblAgeYy";
            this.lblAgeYy.Size = new System.Drawing.Size(32, 15);
            this.lblAgeYy.TabIndex = 156;
            this.lblAgeYy.Text = "Year";
            this.lblAgeYy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeYy
            // 
            this.txtAgeYy.BackColor = System.Drawing.Color.Linen;
            this.txtAgeYy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYy.Location = new System.Drawing.Point(521, 144);
            this.txtAgeYy.MaxLength = 2;
            this.txtAgeYy.Name = "txtAgeYy";
            this.txtAgeYy.Size = new System.Drawing.Size(52, 22);
            this.txtAgeYy.TabIndex = 140;
            this.txtAgeYy.Tag = "";
            this.txtAgeYy.Text = "00";
            this.txtAgeYy.Leave += new System.EventHandler(this.txtAgeYy_Leave);
            this.txtAgeYy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeYy_KeyPress);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(442, 181);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(74, 16);
            this.lblNationality.TabIndex = 157;
            this.lblNationality.Text = "Nationality:";
            this.lblNationality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbNationality
            // 
            this.cmbNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNationality.BackColor = System.Drawing.Color.Linen;
            this.cmbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Location = new System.Drawing.Point(521, 176);
            this.cmbNationality.MaxLength = 25;
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(97, 24);
            this.cmbNationality.TabIndex = 143;
            this.cmbNationality.Tag = "nationality_id";
            this.cmbNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNationality_KeyPress);
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(637, 181);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(61, 16);
            this.lblReligion.TabIndex = 158;
            this.lblReligion.Text = "Religion:";
            this.lblReligion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbReligion
            // 
            this.cmbReligion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReligion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReligion.BackColor = System.Drawing.Color.Linen;
            this.cmbReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Location = new System.Drawing.Point(704, 176);
            this.cmbReligion.MaxLength = 25;
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(83, 24);
            this.cmbReligion.TabIndex = 144;
            this.cmbReligion.Tag = "religion_id";
            this.cmbReligion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbReligion_KeyPress);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightSalmon;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(-2, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(839, 29);
            this.label20.TabIndex = 171;
            this.label20.Text = "Dialysis Patient Admission";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbRefferedDoctors);
            this.groupBox1.Controls.Add(this.lblDeposit);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDeposit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.cmbReligion);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblReligion);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cmbNationality);
            this.groupBox1.Controls.Add(this.txtCaseNo);
            this.groupBox1.Controls.Add(this.lblNationality);
            this.groupBox1.Controls.Add(this.txtAgeYy);
            this.groupBox1.Controls.Add(this.lblAgeYy);
            this.groupBox1.Controls.Add(this.txtAgeMm);
            this.groupBox1.Controls.Add(this.lblAgeMm);
            this.groupBox1.Controls.Add(this.txtAgeDd);
            this.groupBox1.Controls.Add(this.lblAgeDd);
            this.groupBox1.Controls.Add(this.txtCPhone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblCPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 291);
            this.groupBox1.TabIndex = 172;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 175;
            this.label2.Text = "Consultant :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // cmbRefferedDoctors
            // 
            this.cmbRefferedDoctors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRefferedDoctors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefferedDoctors.BackColor = System.Drawing.Color.Linen;
            this.cmbRefferedDoctors.Enabled = false;
            this.cmbRefferedDoctors.FormattingEnabled = true;
            this.cmbRefferedDoctors.Location = new System.Drawing.Point(521, 36);
            this.cmbRefferedDoctors.MaxLength = 25;
            this.cmbRefferedDoctors.Name = "cmbRefferedDoctors";
            this.cmbRefferedDoctors.Size = new System.Drawing.Size(266, 21);
            this.cmbRefferedDoctors.TabIndex = 174;
            this.cmbRefferedDoctors.Tag = "guardian_relation_id";
            this.cmbRefferedDoctors.Visible = false;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(408, 225);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(66, 16);
            this.lblDeposit.TabIndex = 173;
            this.lblDeposit.Text = "Deposit:";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(557, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 172;
            this.label13.Text = "Advance ";
            // 
            // txtDeposit
            // 
            this.txtDeposit.BackColor = System.Drawing.Color.Linen;
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(651, 242);
            this.txtDeposit.MaxLength = 7;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(127, 22);
            this.txtDeposit.TabIndex = 170;
            this.txtDeposit.Tag = "";
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(411, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 44);
            this.label8.TabIndex = 171;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.lnkSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 62);
            this.groupBox3.TabIndex = 173;
            this.groupBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AutoSize = true;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(213, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 28);
            this.btnPrint.TabIndex = 110;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(337, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 28);
            this.btnEdit.TabIndex = 102;
            this.btnEdit.Text = "   Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(704, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "  Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(561, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(411, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lnkSearch
            // 
            this.lnkSearch.AutoSize = true;
            this.lnkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSearch.Location = new System.Drawing.Point(50, 21);
            this.lnkSearch.Name = "lnkSearch";
            this.lnkSearch.Size = new System.Drawing.Size(114, 20);
            this.lnkSearch.TabIndex = 91;
            this.lnkSearch.TabStop = true;
            this.lnkSearch.Text = "Search Patient";
            this.lnkSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSearch_LinkClicked);
            // 
            // FrmDialysisPatientAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(833, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lnkNewPatient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbOccupation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbPatientCondition);
            this.Controls.Add(this.lblAdmissionCode);
            this.Controls.Add(this.txtAdmissionCode);
            this.Controls.Add(this.lblPatientCode);
            this.Controls.Add(this.txtPatientCode);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblGuardianName);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.lblGuardianRelation);
            this.Controls.Add(this.cmbGuardianRelation);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialysisPatientAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialysis Patient Admission";
            this.Load += new System.EventHandler(this.FrmDialysisPatientAdmission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCaseNo;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel lnkNewPatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPatientCondition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAdmissionCode;
        private System.Windows.Forms.TextBox txtAdmissionCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientCode;
        private System.Windows.Forms.TextBox txtPatientCode;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblGuardianRelation;
        private System.Windows.Forms.ComboBox cmbGuardianRelation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Label lblAgeDd;
        private System.Windows.Forms.TextBox txtAgeDd;
        private System.Windows.Forms.Label lblAgeMm;
        private System.Windows.Forms.TextBox txtAgeMm;
        private System.Windows.Forms.Label lblAgeYy;
        private System.Windows.Forms.TextBox txtAgeYy;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRefferedDoctors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.LinkLabel lnkSearch;
    }
}