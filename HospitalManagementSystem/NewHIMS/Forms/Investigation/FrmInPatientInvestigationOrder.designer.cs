namespace NewHIMS.Forms.Investigation
{
    partial class FrmInPatientInvestigationOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.cabin_id = new System.Windows.Forms.ColumnHeader();
            this.Patient_id = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.amissiondate = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkgroup = new System.Windows.Forms.CheckBox();
            this.lblDepartemt = new System.Windows.Forms.Label();
            this.cmbTestDepartemt = new System.Windows.Forms.ComboBox();
            this.cmbTestGroup = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grptestitems = new System.Windows.Forms.GroupBox();
            this.grdtestitems = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.test_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciman_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hidecoloum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.grpTest = new System.Windows.Forms.GroupBox();
            this.lblNetPayable = new System.Windows.Forms.Label();
            this.txtNetPayable = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtPathology = new System.Windows.Forms.TextBox();
            this.txtXray = new System.Windows.Forms.TextBox();
            this.txtUsg = new System.Windows.Forms.TextBox();
            this.txtEcg = new System.Windows.Forms.TextBox();
            this.lblPathology = new System.Windows.Forms.Label();
            this.lblXray = new System.Windows.Forms.Label();
            this.lblUsg = new System.Windows.Forms.Label();
            this.lblEcg = new System.Windows.Forms.Label();
            this.lblTestDepartment = new System.Windows.Forms.Label();
            this.cmbRefferedDoctors = new System.Windows.Forms.ComboBox();
            this.btnRemoveTest = new System.Windows.Forms.Button();
            this.txtTestTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTest = new System.Windows.Forms.ListView();
            this.department = new System.Windows.Forms.ColumnHeader();
            this.group = new System.Windows.Forms.ColumnHeader();
            this.test_item = new System.Windows.Forms.ColumnHeader();
            this.charge = new System.Windows.Forms.ColumnHeader();
            this.d_id = new System.Windows.Forms.ColumnHeader();
            this.g_id = new System.Windows.Forms.ColumnHeader();
            this.t_id = new System.Windows.Forms.ColumnHeader();
            this.reffered_by = new System.Windows.Forms.ColumnHeader();
            this.reedoc_id = new System.Windows.Forms.ColumnHeader();
            this.specimen_id = new System.Windows.Forms.ColumnHeader();
            this.investigation_id = new System.Windows.Forms.ColumnHeader();
            this.sample_collected = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCabinNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grptestitems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdtestitems)).BeginInit();
            this.grpTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admission_id,
            this.cabin,
            this.patient_code,
            this.cabin_id,
            this.Patient_id,
            this.patient_name,
            this.admission_code,
            this.amissiondate,
            this.age});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(12, 119);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(339, 409);
            this.lvwPatientInfo.TabIndex = 6;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // admission_id
            // 
            this.admission_id.Name = "admission_id";
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 47;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 78;
            // 
            // cabin_id
            // 
            this.cabin_id.Text = "cabin_id";
            this.cabin_id.Width = 0;
            // 
            // Patient_id
            // 
            this.Patient_id.Text = "patient_id";
            this.Patient_id.Width = 0;
            // 
            // patient_name
            // 
            this.patient_name.Text = "P. Name";
            this.patient_name.Width = 200;
            // 
            // admission_code
            // 
            this.admission_code.Text = "admission_code";
            this.admission_code.Width = 0;
            // 
            // amissiondate
            // 
            this.amissiondate.Text = "amissiondate";
            this.amissiondate.Width = 0;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1178, 29);
            this.label7.TabIndex = 107;
            this.label7.Text = "IPD Investigation Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 111;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "Cabin No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 112;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // chkgroup
            // 
            this.chkgroup.AutoSize = true;
            this.chkgroup.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgroup.Location = new System.Drawing.Point(965, 59);
            this.chkgroup.Name = "chkgroup";
            this.chkgroup.Size = new System.Drawing.Size(74, 23);
            this.chkgroup.TabIndex = 116;
            this.chkgroup.Text = "Group";
            this.chkgroup.UseVisualStyleBackColor = true;
            this.chkgroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkgroup_KeyPress);
            this.chkgroup.CheckedChanged += new System.EventHandler(this.chkgroup_CheckedChanged);
            // 
            // lblDepartemt
            // 
            this.lblDepartemt.AutoSize = true;
            this.lblDepartemt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartemt.Location = new System.Drawing.Point(12, 16);
            this.lblDepartemt.Name = "lblDepartemt";
            this.lblDepartemt.Size = new System.Drawing.Size(98, 19);
            this.lblDepartemt.TabIndex = 115;
            this.lblDepartemt.Text = "Department:";
            this.lblDepartemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTestDepartemt
            // 
            this.cmbTestDepartemt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestDepartemt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestDepartemt.BackColor = System.Drawing.Color.White;
            this.cmbTestDepartemt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestDepartemt.FormattingEnabled = true;
            this.cmbTestDepartemt.Location = new System.Drawing.Point(831, 59);
            this.cmbTestDepartemt.Name = "cmbTestDepartemt";
            this.cmbTestDepartemt.Size = new System.Drawing.Size(122, 21);
            this.cmbTestDepartemt.TabIndex = 113;
            this.cmbTestDepartemt.Tag = "patient_id";
            this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
            this.cmbTestDepartemt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTestDepartemt_KeyPress);
            // 
            // cmbTestGroup
            // 
            this.cmbTestGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestGroup.BackColor = System.Drawing.Color.White;
            this.cmbTestGroup.Enabled = false;
            this.cmbTestGroup.FormattingEnabled = true;
            this.cmbTestGroup.Location = new System.Drawing.Point(1040, 61);
            this.cmbTestGroup.Name = "cmbTestGroup";
            this.cmbTestGroup.Size = new System.Drawing.Size(101, 21);
            this.cmbTestGroup.TabIndex = 114;
            this.cmbTestGroup.Tag = "patient_id";
            this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDepartemt);
            this.groupBox2.Location = new System.Drawing.Point(715, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 44);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            // 
            // grptestitems
            // 
            this.grptestitems.Controls.Add(this.grdtestitems);
            this.grptestitems.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptestitems.ForeColor = System.Drawing.Color.Black;
            this.grptestitems.Location = new System.Drawing.Point(715, 95);
            this.grptestitems.Name = "grptestitems";
            this.grptestitems.Size = new System.Drawing.Size(436, 441);
            this.grptestitems.TabIndex = 123;
            this.grptestitems.TabStop = false;
            this.grptestitems.Text = "Test Items";
            // 
            // grdtestitems
            // 
            this.grdtestitems.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdtestitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdtestitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtestitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.test_department,
            this.test_group,
            this.test_items,
            this.test_charge,
            this.department_id,
            this.group_id,
            this.item_id,
            this.speciman_id,
            this.hidecoloum});
            this.grdtestitems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdtestitems.Location = new System.Drawing.Point(7, 19);
            this.grdtestitems.Name = "grdtestitems";
            this.grdtestitems.Size = new System.Drawing.Size(418, 411);
            this.grdtestitems.TabIndex = 0;
            this.grdtestitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdtestitems_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Select";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 47;
            // 
            // test_department
            // 
            this.test_department.HeaderText = "test_department";
            this.test_department.Name = "test_department";
            this.test_department.ReadOnly = true;
            this.test_department.Visible = false;
            // 
            // test_group
            // 
            this.test_group.HeaderText = "test_group";
            this.test_group.Name = "test_group";
            this.test_group.ReadOnly = true;
            this.test_group.Visible = false;
            // 
            // test_items
            // 
            this.test_items.HeaderText = "Test Name";
            this.test_items.Name = "test_items";
            this.test_items.ReadOnly = true;
            this.test_items.Width = 253;
            // 
            // test_charge
            // 
            this.test_charge.HeaderText = "Charge";
            this.test_charge.Name = "test_charge";
            this.test_charge.Width = 56;
            // 
            // department_id
            // 
            this.department_id.HeaderText = "department_id";
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            this.department_id.Visible = false;
            // 
            // group_id
            // 
            this.group_id.HeaderText = "group_id";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.Visible = false;
            // 
            // item_id
            // 
            this.item_id.HeaderText = "item_id";
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            this.item_id.Visible = false;
            // 
            // speciman_id
            // 
            this.speciman_id.HeaderText = "speciman_id";
            this.speciman_id.Name = "speciman_id";
            this.speciman_id.ReadOnly = true;
            this.speciman_id.Visible = false;
            // 
            // hidecoloum
            // 
            this.hidecoloum.HeaderText = "hidecoloum";
            this.hidecoloum.Name = "hidecoloum";
            this.hidecoloum.ReadOnly = true;
            this.hidecoloum.Visible = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(903, 542);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(79, 28);
            this.btnrefresh.TabIndex = 121;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click_1);
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.lblNetPayable);
            this.grpTest.Controls.Add(this.txtNetPayable);
            this.grpTest.Controls.Add(this.lblDiscount);
            this.grpTest.Controls.Add(this.txtPathology);
            this.grpTest.Controls.Add(this.txtXray);
            this.grpTest.Controls.Add(this.txtUsg);
            this.grpTest.Controls.Add(this.txtEcg);
            this.grpTest.Controls.Add(this.lblPathology);
            this.grpTest.Controls.Add(this.lblXray);
            this.grpTest.Controls.Add(this.lblUsg);
            this.grpTest.Controls.Add(this.lblEcg);
            this.grpTest.Controls.Add(this.lblTestDepartment);
            this.grpTest.Controls.Add(this.cmbRefferedDoctors);
            this.grpTest.Controls.Add(this.btnRemoveTest);
            this.grpTest.Controls.Add(this.txtTestTotal);
            this.grpTest.Controls.Add(this.label1);
            this.grpTest.Controls.Add(this.lvwTest);
            this.grpTest.Controls.Add(this.groupBox3);
            this.grpTest.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTest.ForeColor = System.Drawing.Color.Red;
            this.grpTest.Location = new System.Drawing.Point(363, 94);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(346, 442);
            this.grpTest.TabIndex = 120;
            this.grpTest.TabStop = false;
            // 
            // lblNetPayable
            // 
            this.lblNetPayable.AutoSize = true;
            this.lblNetPayable.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayable.ForeColor = System.Drawing.Color.Tomato;
            this.lblNetPayable.Location = new System.Drawing.Point(6, 399);
            this.lblNetPayable.Name = "lblNetPayable";
            this.lblNetPayable.Size = new System.Drawing.Size(111, 19);
            this.lblNetPayable.TabIndex = 60;
            this.lblNetPayable.Text = "Net Payable:";
            this.lblNetPayable.Visible = false;
            // 
            // txtNetPayable
            // 
            this.txtNetPayable.BackColor = System.Drawing.Color.White;
            this.txtNetPayable.Location = new System.Drawing.Point(119, 397);
            this.txtNetPayable.Name = "txtNetPayable";
            this.txtNetPayable.ReadOnly = true;
            this.txtNetPayable.Size = new System.Drawing.Size(94, 23);
            this.txtNetPayable.TabIndex = 59;
            this.txtNetPayable.Text = "00.00";
            this.txtNetPayable.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.Location = new System.Drawing.Point(4, 375);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 15);
            this.lblDiscount.TabIndex = 58;
            this.lblDiscount.Text = "Discount:";
            this.lblDiscount.Visible = false;
            // 
            // txtPathology
            // 
            this.txtPathology.Enabled = false;
            this.txtPathology.Location = new System.Drawing.Point(74, 370);
            this.txtPathology.Name = "txtPathology";
            this.txtPathology.Size = new System.Drawing.Size(60, 23);
            this.txtPathology.TabIndex = 57;
            this.txtPathology.Text = "00.00";
            this.txtPathology.Visible = false;
            // 
            // txtXray
            // 
            this.txtXray.Enabled = false;
            this.txtXray.Location = new System.Drawing.Point(144, 370);
            this.txtXray.Name = "txtXray";
            this.txtXray.Size = new System.Drawing.Size(60, 23);
            this.txtXray.TabIndex = 56;
            this.txtXray.Text = "00.00";
            this.txtXray.Visible = false;
            // 
            // txtUsg
            // 
            this.txtUsg.Enabled = false;
            this.txtUsg.Location = new System.Drawing.Point(208, 369);
            this.txtUsg.Name = "txtUsg";
            this.txtUsg.Size = new System.Drawing.Size(60, 23);
            this.txtUsg.TabIndex = 55;
            this.txtUsg.Text = "00.00";
            this.txtUsg.Visible = false;
            // 
            // txtEcg
            // 
            this.txtEcg.Enabled = false;
            this.txtEcg.Location = new System.Drawing.Point(278, 369);
            this.txtEcg.Name = "txtEcg";
            this.txtEcg.Size = new System.Drawing.Size(60, 23);
            this.txtEcg.TabIndex = 54;
            this.txtEcg.Text = "00.00";
            this.txtEcg.Visible = false;
            // 
            // lblPathology
            // 
            this.lblPathology.AutoSize = true;
            this.lblPathology.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathology.ForeColor = System.Drawing.Color.Black;
            this.lblPathology.Location = new System.Drawing.Point(71, 352);
            this.lblPathology.Name = "lblPathology";
            this.lblPathology.Size = new System.Drawing.Size(61, 15);
            this.lblPathology.TabIndex = 53;
            this.lblPathology.Text = "Pathology";
            this.lblPathology.Visible = false;
            // 
            // lblXray
            // 
            this.lblXray.AutoSize = true;
            this.lblXray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXray.ForeColor = System.Drawing.Color.Black;
            this.lblXray.Location = new System.Drawing.Point(152, 352);
            this.lblXray.Name = "lblXray";
            this.lblXray.Size = new System.Drawing.Size(42, 15);
            this.lblXray.TabIndex = 52;
            this.lblXray.Text = "X-RAY";
            this.lblXray.Visible = false;
            // 
            // lblUsg
            // 
            this.lblUsg.AutoSize = true;
            this.lblUsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsg.ForeColor = System.Drawing.Color.Black;
            this.lblUsg.Location = new System.Drawing.Point(217, 351);
            this.lblUsg.Name = "lblUsg";
            this.lblUsg.Size = new System.Drawing.Size(33, 15);
            this.lblUsg.TabIndex = 51;
            this.lblUsg.Text = "USG";
            this.lblUsg.Visible = false;
            // 
            // lblEcg
            // 
            this.lblEcg.AutoSize = true;
            this.lblEcg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcg.ForeColor = System.Drawing.Color.Black;
            this.lblEcg.Location = new System.Drawing.Point(289, 351);
            this.lblEcg.Name = "lblEcg";
            this.lblEcg.Size = new System.Drawing.Size(32, 15);
            this.lblEcg.TabIndex = 50;
            this.lblEcg.Text = "ECG";
            this.lblEcg.Visible = false;
            // 
            // lblTestDepartment
            // 
            this.lblTestDepartment.AutoSize = true;
            this.lblTestDepartment.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblTestDepartment.Location = new System.Drawing.Point(10, 30);
            this.lblTestDepartment.Name = "lblTestDepartment";
            this.lblTestDepartment.Size = new System.Drawing.Size(83, 18);
            this.lblTestDepartment.TabIndex = 49;
            this.lblTestDepartment.Tag = "reffered_doctors_id";
            this.lblTestDepartment.Text = "Refered by:";
            this.lblTestDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRefferedDoctors
            // 
            this.cmbRefferedDoctors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRefferedDoctors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefferedDoctors.BackColor = System.Drawing.Color.White;
            this.cmbRefferedDoctors.FormattingEnabled = true;
            this.cmbRefferedDoctors.Location = new System.Drawing.Point(94, 28);
            this.cmbRefferedDoctors.Name = "cmbRefferedDoctors";
            this.cmbRefferedDoctors.Size = new System.Drawing.Size(238, 24);
            this.cmbRefferedDoctors.TabIndex = 0;
            this.cmbRefferedDoctors.Tag = "reffered_doctors_id";
            // 
            // btnRemoveTest
            // 
            this.btnRemoveTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTest.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveTest.Image = global::NewHIMS.Properties.Resources.RemoveSmall;
            this.btnRemoveTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTest.Location = new System.Drawing.Point(257, 403);
            this.btnRemoveTest.Name = "btnRemoveTest";
            this.btnRemoveTest.Size = new System.Drawing.Size(83, 28);
            this.btnRemoveTest.TabIndex = 5;
            this.btnRemoveTest.Text = "   Remove";
            this.btnRemoveTest.UseVisualStyleBackColor = true;
            this.btnRemoveTest.Click += new System.EventHandler(this.btnRemoveTest_Click);
            // 
            // txtTestTotal
            // 
            this.txtTestTotal.BackColor = System.Drawing.Color.White;
            this.txtTestTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtTestTotal.Location = new System.Drawing.Point(254, 326);
            this.txtTestTotal.Name = "txtTestTotal";
            this.txtTestTotal.ReadOnly = true;
            this.txtTestTotal.Size = new System.Drawing.Size(86, 23);
            this.txtTestTotal.TabIndex = 47;
            this.txtTestTotal.Tag = "";
            this.txtTestTotal.Text = "00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(199, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwTest
            // 
            this.lvwTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvwTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.department,
            this.group,
            this.test_item,
            this.charge,
            this.d_id,
            this.g_id,
            this.t_id,
            this.reffered_by,
            this.reedoc_id,
            this.specimen_id,
            this.investigation_id,
            this.sample_collected});
            this.lvwTest.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTest.ForeColor = System.Drawing.Color.Black;
            this.lvwTest.FullRowSelect = true;
            this.lvwTest.GridLines = true;
            this.lvwTest.HideSelection = false;
            this.lvwTest.Location = new System.Drawing.Point(10, 63);
            this.lvwTest.Name = "lvwTest";
            this.lvwTest.Size = new System.Drawing.Size(328, 248);
            this.lvwTest.TabIndex = 4;
            this.lvwTest.UseCompatibleStateImageBehavior = false;
            this.lvwTest.View = System.Windows.Forms.View.Details;
            // 
            // department
            // 
            this.department.Text = "Department";
            this.department.Width = 0;
            // 
            // group
            // 
            this.group.Text = "Group";
            this.group.Width = 70;
            // 
            // test_item
            // 
            this.test_item.Text = "Name";
            this.test_item.Width = 175;
            // 
            // charge
            // 
            this.charge.DisplayIndex = 4;
            this.charge.Text = "Charge";
            this.charge.Width = 75;
            // 
            // d_id
            // 
            this.d_id.DisplayIndex = 5;
            this.d_id.Text = "d_id";
            this.d_id.Width = 0;
            // 
            // g_id
            // 
            this.g_id.DisplayIndex = 6;
            this.g_id.Text = "Group ID";
            this.g_id.Width = 0;
            // 
            // t_id
            // 
            this.t_id.DisplayIndex = 7;
            this.t_id.Text = "Test ID";
            this.t_id.Width = 0;
            // 
            // reffered_by
            // 
            this.reffered_by.DisplayIndex = 3;
            this.reffered_by.Text = "Refered by";
            this.reffered_by.Width = 0;
            // 
            // reedoc_id
            // 
            this.reedoc_id.Text = "refdocID";
            this.reedoc_id.Width = 0;
            // 
            // specimen_id
            // 
            this.specimen_id.Text = "specimenID";
            this.specimen_id.Width = 0;
            // 
            // investigation_id
            // 
            this.investigation_id.Text = "i_id";
            this.investigation_id.Width = 0;
            // 
            // sample_collected
            // 
            this.sample_collected.Text = "Sample Collected";
            this.sample_collected.Width = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 44);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(988, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1073, 542);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.groupBox1.Location = new System.Drawing.Point(5, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 440);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(5, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 44);
            this.groupBox4.TabIndex = 125;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // txtPName
            // 
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPName.Enabled = false;
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPName.Location = new System.Drawing.Point(452, 75);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(198, 22);
            this.txtPName.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 127;
            this.label2.Text = "P.Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "Cabin No.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCabinNo
            // 
            this.txtCabinNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCabinNo.Enabled = false;
            this.txtCabinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCabinNo.Location = new System.Drawing.Point(453, 49);
            this.txtCabinNo.Name = "txtCabinNo";
            this.txtCabinNo.Size = new System.Drawing.Size(84, 22);
            this.txtCabinNo.TabIndex = 128;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(47, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 27);
            this.button1.TabIndex = 131;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInPatientInvestigationOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1162, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCabinNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.grptestitems);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkgroup);
            this.Controls.Add(this.cmbTestDepartemt);
            this.Controls.Add(this.cmbTestGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvwPatientInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInPatientInvestigationOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPD Investigation Order";
            this.Load += new System.EventHandler(this.FrmInPatientInvestigationOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grptestitems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdtestitems)).EndInit();
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkgroup;
        private System.Windows.Forms.Label lblDepartemt;
        private System.Windows.Forms.ComboBox cmbTestDepartemt;
        private System.Windows.Forms.ComboBox cmbTestGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grptestitems;
        private System.Windows.Forms.DataGridView grdtestitems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciman_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hidecoloum;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox grpTest;
        private System.Windows.Forms.Label lblNetPayable;
        private System.Windows.Forms.TextBox txtNetPayable;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtPathology;
        private System.Windows.Forms.TextBox txtXray;
        private System.Windows.Forms.TextBox txtUsg;
        private System.Windows.Forms.TextBox txtEcg;
        private System.Windows.Forms.Label lblPathology;
        private System.Windows.Forms.Label lblXray;
        private System.Windows.Forms.Label lblUsg;
        private System.Windows.Forms.Label lblEcg;
        private System.Windows.Forms.Label lblTestDepartment;
        private System.Windows.Forms.ComboBox cmbRefferedDoctors;
        private System.Windows.Forms.Button btnRemoveTest;
        private System.Windows.Forms.TextBox txtTestTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwTest;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader group;
        private System.Windows.Forms.ColumnHeader test_item;
        private System.Windows.Forms.ColumnHeader charge;
        private System.Windows.Forms.ColumnHeader d_id;
        private System.Windows.Forms.ColumnHeader g_id;
        private System.Windows.Forms.ColumnHeader t_id;
        private System.Windows.Forms.ColumnHeader reffered_by;
        private System.Windows.Forms.ColumnHeader reedoc_id;
        private System.Windows.Forms.ColumnHeader specimen_id;
        private System.Windows.Forms.ColumnHeader investigation_id;
        private System.Windows.Forms.ColumnHeader sample_collected;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader cabin_id;
        private System.Windows.Forms.ColumnHeader Patient_id;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCabinNo;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader amissiondate;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.Button button1;
    }
}