namespace NewHIMS.Forms.Investigation
{
    partial class FrmInvestigationTestListView
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
            this.grpInvestigationTest = new System.Windows.Forms.GroupBox();
            this.grpPatientType = new System.Windows.Forms.GroupBox();
            this.rdoIpd = new System.Windows.Forms.RadioButton();
            this.rdoOpd = new System.Windows.Forms.RadioButton();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.chkHospitalID = new System.Windows.Forms.CheckBox();
            this.chkAdmissionID = new System.Windows.Forms.CheckBox();
            this.chkCabin = new System.Windows.Forms.CheckBox();
            this.txtCabin = new System.Windows.Forms.TextBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.grpBaby = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAgeDd = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAgeDd = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblAgeMm = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAgeMm = new System.Windows.Forms.TextBox();
            this.lblAgeYy = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtAgeYy = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnPrintSampleCollected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReferenceValue = new System.Windows.Forms.TextBox();
            this.lblRefferengeValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdTest = new System.Windows.Forms.DataGridView();
            this.test_element_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference_values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTestDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTestDepartment = new System.Windows.Forms.Label();
            this.cmbRefferedDoctors = new System.Windows.Forms.ComboBox();
            this.lvwMainList = new System.Windows.Forms.ListView();
            this.order_no = new System.Windows.Forms.ColumnHeader();
            this.p_type = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.test = new System.Windows.Forms.ColumnHeader();
            this.test_item = new System.Windows.Forms.ColumnHeader();
            this.investiogation_test_id = new System.Windows.Forms.ColumnHeader();
            this.investigation_item_id = new System.Windows.Forms.ColumnHeader();
            this.reference_value = new System.Windows.Forms.ColumnHeader();
            this.testReport = new System.Windows.Forms.ColumnHeader();
            this.for_baby = new System.Windows.Forms.ColumnHeader();
            this.specimen = new System.Windows.Forms.ColumnHeader();
            this.page_group_id = new System.Windows.Forms.ColumnHeader();
            this.report_done = new System.Windows.Forms.ColumnHeader();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInvestigationTestTitle = new System.Windows.Forms.Label();
            this.grpInvestigationTest.SuspendLayout();
            this.grpPatientType.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpBaby.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInvestigationTest
            // 
            this.grpInvestigationTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInvestigationTest.BackColor = System.Drawing.Color.LightCyan;
            this.grpInvestigationTest.Controls.Add(this.grpPatientType);
            this.grpInvestigationTest.Controls.Add(this.grpSearch);
            this.grpInvestigationTest.Controls.Add(this.grpBaby);
            this.grpInvestigationTest.Controls.Add(this.btnPrintSampleCollected);
            this.grpInvestigationTest.Controls.Add(this.groupBox1);
            this.grpInvestigationTest.Controls.Add(this.lvwMainList);
            this.grpInvestigationTest.Controls.Add(this.btnRefresh);
            this.grpInvestigationTest.Controls.Add(this.btnClose);
            this.grpInvestigationTest.Controls.Add(this.lblInvestigationTestTitle);
            this.grpInvestigationTest.Location = new System.Drawing.Point(12, 8);
            this.grpInvestigationTest.Name = "grpInvestigationTest";
            this.grpInvestigationTest.Size = new System.Drawing.Size(904, 587);
            this.grpInvestigationTest.TabIndex = 3;
            this.grpInvestigationTest.TabStop = false;
            // 
            // grpPatientType
            // 
            this.grpPatientType.Controls.Add(this.rdoIpd);
            this.grpPatientType.Controls.Add(this.rdoOpd);
            this.grpPatientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientType.Location = new System.Drawing.Point(6, 69);
            this.grpPatientType.Name = "grpPatientType";
            this.grpPatientType.Size = new System.Drawing.Size(892, 42);
            this.grpPatientType.TabIndex = 103;
            this.grpPatientType.TabStop = false;
            this.grpPatientType.Text = "Patient Type";
            // 
            // rdoIpd
            // 
            this.rdoIpd.AutoSize = true;
            this.rdoIpd.Location = new System.Drawing.Point(99, 16);
            this.rdoIpd.Name = "rdoIpd";
            this.rdoIpd.Size = new System.Drawing.Size(90, 17);
            this.rdoIpd.TabIndex = 103;
            this.rdoIpd.TabStop = true;
            this.rdoIpd.Text = "IPD Patient";
            this.rdoIpd.UseVisualStyleBackColor = true;
            this.rdoIpd.CheckedChanged += new System.EventHandler(this.rdoIpd_CheckedChanged);
            // 
            // rdoOpd
            // 
            this.rdoOpd.AutoSize = true;
            this.rdoOpd.Location = new System.Drawing.Point(212, 16);
            this.rdoOpd.Name = "rdoOpd";
            this.rdoOpd.Size = new System.Drawing.Size(95, 17);
            this.rdoOpd.TabIndex = 104;
            this.rdoOpd.TabStop = true;
            this.rdoOpd.Text = "OPD Patient";
            this.rdoOpd.UseVisualStyleBackColor = true;
            this.rdoOpd.CheckedChanged += new System.EventHandler(this.rdoOpd_CheckedChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.chkOrder);
            this.grpSearch.Controls.Add(this.chkHospitalID);
            this.grpSearch.Controls.Add(this.chkAdmissionID);
            this.grpSearch.Controls.Add(this.chkCabin);
            this.grpSearch.Controls.Add(this.txtCabin);
            this.grpSearch.Controls.Add(this.txtHospitalID);
            this.grpSearch.Controls.Add(this.txtAdmissionID);
            this.grpSearch.Controls.Add(this.txtOrder);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(6, 113);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(422, 76);
            this.grpSearch.TabIndex = 100;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Location = new System.Drawing.Point(225, 53);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(74, 17);
            this.chkOrder.TabIndex = 107;
            this.chkOrder.Text = "Order ID";
            this.chkOrder.UseVisualStyleBackColor = true;
            this.chkOrder.CheckedChanged += new System.EventHandler(this.chkOrder_CheckedChanged);
            // 
            // chkHospitalID
            // 
            this.chkHospitalID.AutoSize = true;
            this.chkHospitalID.Location = new System.Drawing.Point(6, 19);
            this.chkHospitalID.Name = "chkHospitalID";
            this.chkHospitalID.Size = new System.Drawing.Size(89, 17);
            this.chkHospitalID.TabIndex = 101;
            this.chkHospitalID.Text = "Hospital ID";
            this.chkHospitalID.UseVisualStyleBackColor = true;
            this.chkHospitalID.CheckedChanged += new System.EventHandler(this.chkHospitalID_CheckedChanged);
            // 
            // chkAdmissionID
            // 
            this.chkAdmissionID.AutoSize = true;
            this.chkAdmissionID.Location = new System.Drawing.Point(6, 51);
            this.chkAdmissionID.Name = "chkAdmissionID";
            this.chkAdmissionID.Size = new System.Drawing.Size(98, 17);
            this.chkAdmissionID.TabIndex = 102;
            this.chkAdmissionID.Text = "Adm-Reg. ID";
            this.chkAdmissionID.UseVisualStyleBackColor = true;
            this.chkAdmissionID.CheckedChanged += new System.EventHandler(this.chkAdmissionID_CheckedChanged);
            // 
            // chkCabin
            // 
            this.chkCabin.AutoSize = true;
            this.chkCabin.Location = new System.Drawing.Point(225, 21);
            this.chkCabin.Name = "chkCabin";
            this.chkCabin.Size = new System.Drawing.Size(78, 17);
            this.chkCabin.TabIndex = 103;
            this.chkCabin.Text = "Cabin No";
            this.chkCabin.UseVisualStyleBackColor = true;
            this.chkCabin.CheckedChanged += new System.EventHandler(this.chkCabin_CheckedChanged);
            // 
            // txtCabin
            // 
            this.txtCabin.Enabled = false;
            this.txtCabin.Location = new System.Drawing.Point(303, 19);
            this.txtCabin.Name = "txtCabin";
            this.txtCabin.Size = new System.Drawing.Size(110, 20);
            this.txtCabin.TabIndex = 106;
            this.txtCabin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCabin_KeyPress);
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Enabled = false;
            this.txtHospitalID.Location = new System.Drawing.Point(104, 18);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(110, 20);
            this.txtHospitalID.TabIndex = 105;
            this.txtHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospitalID_KeyPress);
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Enabled = false;
            this.txtAdmissionID.Location = new System.Drawing.Point(104, 48);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(110, 20);
            this.txtAdmissionID.TabIndex = 104;
            this.txtAdmissionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionID_KeyPress);
            // 
            // txtOrder
            // 
            this.txtOrder.Enabled = false;
            this.txtOrder.Location = new System.Drawing.Point(302, 49);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(110, 20);
            this.txtOrder.TabIndex = 99;
            this.txtOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_KeyPress);
            // 
            // grpBaby
            // 
            this.grpBaby.Controls.Add(this.label2);
            this.grpBaby.Controls.Add(this.dtpDOB);
            this.grpBaby.Controls.Add(this.lblAgeDd);
            this.grpBaby.Controls.Add(this.label10);
            this.grpBaby.Controls.Add(this.txtAgeDd);
            this.grpBaby.Controls.Add(this.txtPatientName);
            this.grpBaby.Controls.Add(this.lblAgeMm);
            this.grpBaby.Controls.Add(this.cmbGender);
            this.grpBaby.Controls.Add(this.txtAgeMm);
            this.grpBaby.Controls.Add(this.lblAgeYy);
            this.grpBaby.Controls.Add(this.lblGender);
            this.grpBaby.Controls.Add(this.txtAgeYy);
            this.grpBaby.Controls.Add(this.lblPatientName);
            this.grpBaby.Enabled = false;
            this.grpBaby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBaby.Location = new System.Drawing.Point(436, 113);
            this.grpBaby.Name = "grpBaby";
            this.grpBaby.Size = new System.Drawing.Size(462, 76);
            this.grpBaby.TabIndex = 43;
            this.grpBaby.TabStop = false;
            this.grpBaby.Text = "Baby Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Age:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(343, 15);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(113, 20);
            this.dtpDOB.TabIndex = 87;
            this.dtpDOB.Tag = "dob";
            this.dtpDOB.Leave += new System.EventHandler(this.dtpDOB_Leave);
            // 
            // lblAgeDd
            // 
            this.lblAgeDd.AutoSize = true;
            this.lblAgeDd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeDd.Location = new System.Drawing.Point(426, 38);
            this.lblAgeDd.Name = "lblAgeDd";
            this.lblAgeDd.Size = new System.Drawing.Size(25, 13);
            this.lblAgeDd.TabIndex = 93;
            this.lblAgeDd.Text = "dd:";
            this.lblAgeDd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "DOB:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeDd
            // 
            this.txtAgeDd.BackColor = System.Drawing.Color.White;
            this.txtAgeDd.Location = new System.Drawing.Point(423, 51);
            this.txtAgeDd.MaxLength = 2;
            this.txtAgeDd.Name = "txtAgeDd";
            this.txtAgeDd.Size = new System.Drawing.Size(33, 20);
            this.txtAgeDd.TabIndex = 90;
            this.txtAgeDd.Tag = "age_dd";
            this.txtAgeDd.Text = "0";
            this.txtAgeDd.Leave += new System.EventHandler(this.txtAgeDd_Leave);
            this.txtAgeDd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeDd_KeyPress);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Location = new System.Drawing.Point(92, 15);
            this.txtPatientName.MaxLength = 100;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(203, 20);
            this.txtPatientName.TabIndex = 85;
            this.txtPatientName.Tag = "patient_name";
            // 
            // lblAgeMm
            // 
            this.lblAgeMm.AutoSize = true;
            this.lblAgeMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeMm.Location = new System.Drawing.Point(390, 38);
            this.lblAgeMm.Name = "lblAgeMm";
            this.lblAgeMm.Size = new System.Drawing.Size(29, 13);
            this.lblAgeMm.TabIndex = 94;
            this.lblAgeMm.Text = "mm:";
            this.lblAgeMm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(92, 50);
            this.cmbGender.MaxLength = 10;
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(77, 21);
            this.cmbGender.Sorted = true;
            this.cmbGender.TabIndex = 86;
            this.cmbGender.Tag = "gender_id";
            // 
            // txtAgeMm
            // 
            this.txtAgeMm.BackColor = System.Drawing.Color.White;
            this.txtAgeMm.Location = new System.Drawing.Point(388, 51);
            this.txtAgeMm.MaxLength = 2;
            this.txtAgeMm.Name = "txtAgeMm";
            this.txtAgeMm.Size = new System.Drawing.Size(33, 20);
            this.txtAgeMm.TabIndex = 89;
            this.txtAgeMm.Tag = "age_mm";
            this.txtAgeMm.Text = "0";
            this.txtAgeMm.Leave += new System.EventHandler(this.txtAgeMm_Leave);
            this.txtAgeMm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeMm_KeyPress);
            // 
            // lblAgeYy
            // 
            this.lblAgeYy.AutoSize = true;
            this.lblAgeYy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeYy.Location = new System.Drawing.Point(354, 36);
            this.lblAgeYy.Name = "lblAgeYy";
            this.lblAgeYy.Size = new System.Drawing.Size(23, 13);
            this.lblAgeYy.TabIndex = 95;
            this.lblAgeYy.Text = "yy:";
            this.lblAgeYy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(4, 54);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 13);
            this.lblGender.TabIndex = 92;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeYy
            // 
            this.txtAgeYy.BackColor = System.Drawing.Color.White;
            this.txtAgeYy.Location = new System.Drawing.Point(351, 51);
            this.txtAgeYy.MaxLength = 2;
            this.txtAgeYy.Name = "txtAgeYy";
            this.txtAgeYy.Size = new System.Drawing.Size(33, 20);
            this.txtAgeYy.TabIndex = 88;
            this.txtAgeYy.Tag = "age_yy";
            this.txtAgeYy.Text = "0";
            this.txtAgeYy.Leave += new System.EventHandler(this.txtAgeYy_Leave);
            this.txtAgeYy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeYy_KeyPress);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(4, 18);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(87, 13);
            this.lblPatientName.TabIndex = 91;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrintSampleCollected
            // 
            this.btnPrintSampleCollected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintSampleCollected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSampleCollected.Enabled = false;
            this.btnPrintSampleCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSampleCollected.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrintSampleCollected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSampleCollected.Location = new System.Drawing.Point(779, 528);
            this.btnPrintSampleCollected.Name = "btnPrintSampleCollected";
            this.btnPrintSampleCollected.Size = new System.Drawing.Size(59, 49);
            this.btnPrintSampleCollected.TabIndex = 42;
            this.btnPrintSampleCollected.Text = "Print";
            this.btnPrintSampleCollected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintSampleCollected.UseVisualStyleBackColor = true;
            this.btnPrintSampleCollected.Click += new System.EventHandler(this.btnPrintSampleCollected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtReferenceValue);
            this.groupBox1.Controls.Add(this.lblRefferengeValue);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.grdTest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTestDetails);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblTestDepartment);
            this.groupBox1.Controls.Add(this.cmbRefferedDoctors);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(434, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 328);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // txtReferenceValue
            // 
            this.txtReferenceValue.Location = new System.Drawing.Point(6, 193);
            this.txtReferenceValue.Multiline = true;
            this.txtReferenceValue.Name = "txtReferenceValue";
            this.txtReferenceValue.ReadOnly = true;
            this.txtReferenceValue.Size = new System.Drawing.Size(450, 65);
            this.txtReferenceValue.TabIndex = 51;
            // 
            // lblRefferengeValue
            // 
            this.lblRefferengeValue.AutoSize = true;
            this.lblRefferengeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefferengeValue.Location = new System.Drawing.Point(6, 172);
            this.lblRefferengeValue.Name = "lblRefferengeValue";
            this.lblRefferengeValue.Size = new System.Drawing.Size(111, 17);
            this.lblRefferengeValue.TabIndex = 50;
            this.lblRefferengeValue.Text = "Normal Range";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(6, 61);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(54, 17);
            this.lblResult.TabIndex = 43;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 104);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(450, 65);
            this.txtResult.TabIndex = 44;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(375, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 28);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdTest
            // 
            this.grdTest.AllowUserToDeleteRows = false;
            this.grdTest.AllowUserToResizeColumns = false;
            this.grdTest.AllowUserToResizeRows = false;
            this.grdTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test_element_id,
            this.test_element,
            this.result,
            this.reference_values});
            this.grdTest.Location = new System.Drawing.Point(5, 85);
            this.grdTest.Name = "grdTest";
            this.grdTest.Size = new System.Drawing.Size(454, 170);
            this.grdTest.TabIndex = 48;
            this.grdTest.Visible = false;
            // 
            // test_element_id
            // 
            this.test_element_id.FillWeight = 30F;
            this.test_element_id.HeaderText = "TestElID";
            this.test_element_id.Name = "test_element_id";
            this.test_element_id.ReadOnly = true;
            this.test_element_id.Visible = false;
            // 
            // test_element
            // 
            this.test_element.HeaderText = "Test Element";
            this.test_element.Name = "test_element";
            this.test_element.ReadOnly = true;
            this.test_element.Width = 160;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.Width = 120;
            // 
            // reference_values
            // 
            this.reference_values.HeaderText = "Normal Range";
            this.reference_values.Name = "reference_values";
            this.reference_values.ReadOnly = true;
            this.reference_values.Width = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Test Details:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestDetails
            // 
            this.lblTestDetails.BackColor = System.Drawing.Color.Silver;
            this.lblTestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDetails.Location = new System.Drawing.Point(102, 42);
            this.lblTestDetails.Name = "lblTestDetails";
            this.lblTestDetails.Size = new System.Drawing.Size(354, 20);
            this.lblTestDetails.TabIndex = 46;
            this.lblTestDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(181, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Test Result";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(286, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTestDepartment
            // 
            this.lblTestDepartment.AutoSize = true;
            this.lblTestDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDepartment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTestDepartment.Location = new System.Drawing.Point(6, 268);
            this.lblTestDepartment.Name = "lblTestDepartment";
            this.lblTestDepartment.Size = new System.Drawing.Size(90, 17);
            this.lblTestDepartment.TabIndex = 18;
            this.lblTestDepartment.Text = "Consultant:";
            this.lblTestDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRefferedDoctors
            // 
            this.cmbRefferedDoctors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefferedDoctors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefferedDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefferedDoctors.FormattingEnabled = true;
            this.cmbRefferedDoctors.Location = new System.Drawing.Point(102, 265);
            this.cmbRefferedDoctors.Name = "cmbRefferedDoctors";
            this.cmbRefferedDoctors.Size = new System.Drawing.Size(351, 21);
            this.cmbRefferedDoctors.TabIndex = 2;
            this.cmbRefferedDoctors.Tag = "reffered_doctors_id";
            // 
            // lvwMainList
            // 
            this.lvwMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMainList.BackColor = System.Drawing.Color.LightCyan;
            this.lvwMainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_no,
            this.p_type,
            this.patient_code,
            this.patient_name,
            this.admission_code,
            this.cabin,
            this.test,
            this.test_item,
            this.investiogation_test_id,
            this.investigation_item_id,
            this.reference_value,
            this.testReport,
            this.for_baby,
            this.specimen,
            this.page_group_id,
            this.report_done});
            this.lvwMainList.ForeColor = System.Drawing.Color.Red;
            this.lvwMainList.FullRowSelect = true;
            this.lvwMainList.GridLines = true;
            this.lvwMainList.HideSelection = false;
            this.lvwMainList.Location = new System.Drawing.Point(6, 188);
            this.lvwMainList.MultiSelect = false;
            this.lvwMainList.Name = "lvwMainList";
            this.lvwMainList.Size = new System.Drawing.Size(422, 322);
            this.lvwMainList.TabIndex = 0;
            this.lvwMainList.UseCompatibleStateImageBehavior = false;
            this.lvwMainList.View = System.Windows.Forms.View.Details;
            this.lvwMainList.Click += new System.EventHandler(this.lvwMainList_Click);
            // 
            // order_no
            // 
            this.order_no.Text = "Order ID";
            // 
            // p_type
            // 
            this.p_type.Text = "P Type";
            this.p_type.Width = 0;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Tag = "";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 76;
            // 
            // patient_name
            // 
            this.patient_name.Name = "patient_name";
            this.patient_name.Tag = "";
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 171;
            // 
            // admission_code
            // 
            this.admission_code.Name = "admission_code";
            this.admission_code.Tag = "";
            this.admission_code.Text = "AdmissionID";
            this.admission_code.Width = 87;
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Tag = "";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 75;
            // 
            // test
            // 
            this.test.Text = "Group/Test";
            this.test.Width = 0;
            // 
            // test_item
            // 
            this.test_item.Text = "Test Item";
            this.test_item.Width = 0;
            // 
            // investiogation_test_id
            // 
            this.investiogation_test_id.Text = "investiogation_test_id";
            this.investiogation_test_id.Width = 0;
            // 
            // investigation_item_id
            // 
            this.investigation_item_id.Text = "IItemID";
            this.investigation_item_id.Width = 0;
            // 
            // reference_value
            // 
            this.reference_value.Text = "Ref. Value";
            this.reference_value.Width = 0;
            // 
            // testReport
            // 
            this.testReport.Text = "testReport";
            this.testReport.Width = 0;
            // 
            // for_baby
            // 
            this.for_baby.Text = "Baby";
            this.for_baby.Width = 0;
            // 
            // specimen
            // 
            this.specimen.Text = "Specimen";
            this.specimen.Width = 0;
            // 
            // page_group_id
            // 
            this.page_group_id.Text = "Page group ID";
            this.page_group_id.Width = 0;
            // 
            // report_done
            // 
            this.report_done.Text = "Report Done";
            this.report_done.Width = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(6, 525);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(846, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 49);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInvestigationTestTitle
            // 
            this.lblInvestigationTestTitle.AutoSize = true;
            this.lblInvestigationTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationTestTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInvestigationTestTitle.Location = new System.Drawing.Point(346, 16);
            this.lblInvestigationTestTitle.Name = "lblInvestigationTestTitle";
            this.lblInvestigationTestTitle.Size = new System.Drawing.Size(168, 31);
            this.lblInvestigationTestTitle.TabIndex = 33;
            this.lblInvestigationTestTitle.Text = "Test Report";
            // 
            // FrmInvestigationTestListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(928, 604);
            this.Controls.Add(this.grpInvestigationTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInvestigationTestListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Test List";
            this.Load += new System.EventHandler(this.FrmInvestigationTestListView_Load);
            this.grpInvestigationTest.ResumeLayout(false);
            this.grpInvestigationTest.PerformLayout();
            this.grpPatientType.ResumeLayout(false);
            this.grpPatientType.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpBaby.ResumeLayout(false);
            this.grpBaby.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvestigationTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTestDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTestDepartment;
        private System.Windows.Forms.ComboBox cmbRefferedDoctors;
        private System.Windows.Forms.ListView lvwMainList;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader test;
        private System.Windows.Forms.ColumnHeader reference_value;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInvestigationTestTitle;
        private System.Windows.Forms.ColumnHeader investiogation_test_id;
        private System.Windows.Forms.ColumnHeader p_type;
        private System.Windows.Forms.Button btnPrintSampleCollected;
        private System.Windows.Forms.ColumnHeader testReport;
        private System.Windows.Forms.DataGridView grdTest;
        private System.Windows.Forms.ColumnHeader investigation_item_id;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader test_item;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblRefferengeValue;
        private System.Windows.Forms.TextBox txtReferenceValue;
        private System.Windows.Forms.GroupBox grpBaby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblAgeDd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAgeDd;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblAgeMm;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAgeMm;
        private System.Windows.Forms.Label lblAgeYy;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtAgeYy;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.ColumnHeader for_baby;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_element_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_element;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference_values;
        private System.Windows.Forms.ColumnHeader specimen;
        private System.Windows.Forms.TextBox txtCabin;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkHospitalID;
        private System.Windows.Forms.CheckBox chkAdmissionID;
        private System.Windows.Forms.CheckBox chkCabin;
        private System.Windows.Forms.GroupBox grpPatientType;
        private System.Windows.Forms.RadioButton rdoIpd;
        private System.Windows.Forms.RadioButton rdoOpd;
        private System.Windows.Forms.ColumnHeader page_group_id;
        private System.Windows.Forms.ColumnHeader report_done;
        private System.Windows.Forms.ColumnHeader order_no;
    }
}