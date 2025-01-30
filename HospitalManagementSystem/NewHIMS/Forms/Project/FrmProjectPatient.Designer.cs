namespace NewHIMS.Forms.Project
{
    partial class FrmProjectPatient
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatientNo = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAgeDd = new System.Windows.Forms.Label();
            this.txtAgeDd = new System.Windows.Forms.TextBox();
            this.lblAgeMm = new System.Windows.Forms.Label();
            this.txtAgeMm = new System.Windows.Forms.TextBox();
            this.lblAgeYy = new System.Windows.Forms.Label();
            this.txtAgeYy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectTerm = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvwProjectPatientList = new System.Windows.Forms.ListView();
            this.PPID = new System.Windows.Forms.ColumnHeader();
            this.P_Reg_No = new System.Windows.Forms.ColumnHeader();
            this.P_NAME = new System.Windows.Forms.ColumnHeader();
            this.F_Name = new System.Windows.Forms.ColumnHeader();
            this.M_Name = new System.Windows.Forms.ColumnHeader();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.mobile = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.DOB = new System.Windows.Forms.ColumnHeader();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(876, 29);
            this.label7.TabIndex = 167;
            this.label7.Text = "Project Patient";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(373, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 454);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(6, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(474, 62);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(374, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(235, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(17, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 32);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtProjectID);
            this.groupBox3.Controls.Add(this.cmbGender);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPatientNo);
            this.groupBox3.Controls.Add(this.lblGender);
            this.groupBox3.Controls.Add(this.dtpDOB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblAgeDd);
            this.groupBox3.Controls.Add(this.txtAgeDd);
            this.groupBox3.Controls.Add(this.lblAgeMm);
            this.groupBox3.Controls.Add(this.txtAgeMm);
            this.groupBox3.Controls.Add(this.lblAgeYy);
            this.groupBox3.Controls.Add(this.txtAgeYy);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtContactNumber);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.txtMotherName);
            this.groupBox3.Controls.Add(this.txtFatherName);
            this.groupBox3.Controls.Add(this.txtPatientName);
            this.groupBox3.Location = new System.Drawing.Point(6, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 323);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(374, 19);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(59, 23);
            this.txtProjectID.TabIndex = 4;
            this.txtProjectID.Visible = false;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(341, 283);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(117, 23);
            this.cmbGender.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Patient Reg. No";
            // 
            // txtPatientNo
            // 
            this.txtPatientNo.Enabled = false;
            this.txtPatientNo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientNo.Location = new System.Drawing.Point(99, 18);
            this.txtPatientNo.Name = "txtPatientNo";
            this.txtPatientNo.Size = new System.Drawing.Size(185, 23);
            this.txtPatientNo.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(288, 287);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 15);
            this.lblGender.TabIndex = 95;
            this.lblGender.Text = "Gender ";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(99, 238);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(114, 23);
            this.dtpDOB.TabIndex = 85;
            this.dtpDOB.Tag = "dob";
            this.dtpDOB.Leave += new System.EventHandler(this.dtpDOB_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 93;
            this.label10.Text = "Date of Birth";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(232, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 92;
            this.label9.Text = "P. Age:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAgeDd
            // 
            this.lblAgeDd.AutoSize = true;
            this.lblAgeDd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeDd.Location = new System.Drawing.Point(445, 243);
            this.lblAgeDd.Name = "lblAgeDd";
            this.lblAgeDd.Size = new System.Drawing.Size(25, 15);
            this.lblAgeDd.TabIndex = 89;
            this.lblAgeDd.Text = "DD";
            this.lblAgeDd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeDd
            // 
            this.txtAgeDd.BackColor = System.Drawing.Color.White;
            this.txtAgeDd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeDd.Location = new System.Drawing.Point(411, 238);
            this.txtAgeDd.MaxLength = 2;
            this.txtAgeDd.Name = "txtAgeDd";
            this.txtAgeDd.Size = new System.Drawing.Size(32, 23);
            this.txtAgeDd.TabIndex = 88;
            this.txtAgeDd.Tag = "age_dd";
            this.txtAgeDd.Text = "00";
            this.txtAgeDd.Leave += new System.EventHandler(this.txtAgeDd_Leave);
            this.txtAgeDd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeDd_KeyPress);
            // 
            // lblAgeMm
            // 
            this.lblAgeMm.AutoSize = true;
            this.lblAgeMm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeMm.Location = new System.Drawing.Point(377, 242);
            this.lblAgeMm.Name = "lblAgeMm";
            this.lblAgeMm.Size = new System.Drawing.Size(29, 15);
            this.lblAgeMm.TabIndex = 90;
            this.lblAgeMm.Text = "MM";
            this.lblAgeMm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeMm
            // 
            this.txtAgeMm.BackColor = System.Drawing.Color.White;
            this.txtAgeMm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeMm.Location = new System.Drawing.Point(341, 238);
            this.txtAgeMm.MaxLength = 2;
            this.txtAgeMm.Name = "txtAgeMm";
            this.txtAgeMm.Size = new System.Drawing.Size(35, 23);
            this.txtAgeMm.TabIndex = 87;
            this.txtAgeMm.Tag = "age_mm";
            this.txtAgeMm.Text = "00";
            this.txtAgeMm.Leave += new System.EventHandler(this.txtAgeMm_Leave);
            this.txtAgeMm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeMm_KeyPress);
            // 
            // lblAgeYy
            // 
            this.lblAgeYy.AutoSize = true;
            this.lblAgeYy.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeYy.Location = new System.Drawing.Point(316, 242);
            this.lblAgeYy.Name = "lblAgeYy";
            this.lblAgeYy.Size = new System.Drawing.Size(21, 15);
            this.lblAgeYy.TabIndex = 91;
            this.lblAgeYy.Text = "YY";
            this.lblAgeYy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeYy
            // 
            this.txtAgeYy.BackColor = System.Drawing.Color.White;
            this.txtAgeYy.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeYy.Location = new System.Drawing.Point(280, 238);
            this.txtAgeYy.MaxLength = 2;
            this.txtAgeYy.Name = "txtAgeYy";
            this.txtAgeYy.Size = new System.Drawing.Size(33, 23);
            this.txtAgeYy.TabIndex = 86;
            this.txtAgeYy.Tag = "age_yy";
            this.txtAgeYy.Text = "00";
            this.txtAgeYy.Leave += new System.EventHandler(this.txtAgeYy_Leave);
            this.txtAgeYy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeYy_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mobile Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mother Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Father Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Name";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(99, 283);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(158, 23);
            this.txtContactNumber.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(99, 183);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(359, 37);
            this.txtAddress.TabIndex = 7;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotherName.Location = new System.Drawing.Point(99, 138);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(359, 23);
            this.txtMotherName.TabIndex = 6;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(99, 96);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(359, 23);
            this.txtFatherName.TabIndex = 5;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(99, 56);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(359, 23);
            this.txtPatientName.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtProjectTerm);
            this.groupBox2.Controls.Add(this.txtProjectName);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Term";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Name";
            // 
            // txtProjectTerm
            // 
            this.txtProjectTerm.Enabled = false;
            this.txtProjectTerm.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectTerm.Location = new System.Drawing.Point(399, 20);
            this.txtProjectTerm.Name = "txtProjectTerm";
            this.txtProjectTerm.Size = new System.Drawing.Size(59, 23);
            this.txtProjectTerm.TabIndex = 1;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Enabled = false;
            this.txtProjectName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Location = new System.Drawing.Point(99, 20);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(185, 23);
            this.txtProjectName.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvwProjectPatientList);
            this.groupBox5.Location = new System.Drawing.Point(12, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 454);
            this.groupBox5.TabIndex = 169;
            this.groupBox5.TabStop = false;
            // 
            // lvwProjectPatientList
            // 
            this.lvwProjectPatientList.BackColor = System.Drawing.Color.Silver;
            this.lvwProjectPatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PPID,
            this.P_Reg_No,
            this.P_NAME,
            this.F_Name,
            this.M_Name,
            this.Address,
            this.mobile,
            this.Gender,
            this.age,
            this.DOB});
            this.lvwProjectPatientList.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProjectPatientList.FullRowSelect = true;
            this.lvwProjectPatientList.GridLines = true;
            this.lvwProjectPatientList.Location = new System.Drawing.Point(6, 16);
            this.lvwProjectPatientList.MultiSelect = false;
            this.lvwProjectPatientList.Name = "lvwProjectPatientList";
            this.lvwProjectPatientList.Size = new System.Drawing.Size(343, 426);
            this.lvwProjectPatientList.TabIndex = 0;
            this.lvwProjectPatientList.UseCompatibleStateImageBehavior = false;
            this.lvwProjectPatientList.View = System.Windows.Forms.View.Details;
            this.lvwProjectPatientList.Click += new System.EventHandler(this.lvwProjectPatientList_Click);
            // 
            // PPID
            // 
            this.PPID.DisplayIndex = 8;
            this.PPID.Text = "PPID";
            this.PPID.Width = 0;
            // 
            // P_Reg_No
            // 
            this.P_Reg_No.DisplayIndex = 0;
            this.P_Reg_No.Text = "Reg No";
            this.P_Reg_No.Width = 65;
            // 
            // P_NAME
            // 
            this.P_NAME.DisplayIndex = 1;
            this.P_NAME.Text = "Patient Name";
            this.P_NAME.Width = 150;
            // 
            // F_Name
            // 
            this.F_Name.DisplayIndex = 2;
            this.F_Name.Text = "Father";
            this.F_Name.Width = 0;
            // 
            // M_Name
            // 
            this.M_Name.DisplayIndex = 3;
            this.M_Name.Text = "Mother";
            this.M_Name.Width = 0;
            // 
            // Address
            // 
            this.Address.DisplayIndex = 4;
            this.Address.Text = "Address";
            this.Address.Width = 0;
            // 
            // mobile
            // 
            this.mobile.DisplayIndex = 5;
            this.mobile.Text = "Mobile";
            this.mobile.Width = 100;
            // 
            // Gender
            // 
            this.Gender.DisplayIndex = 6;
            this.Gender.Text = "Gender";
            this.Gender.Width = 0;
            // 
            // age
            // 
            this.age.DisplayIndex = 7;
            this.age.Text = "Age";
            this.age.Width = 0;
            // 
            // DOB
            // 
            this.DOB.Text = "DOB";
            this.DOB.Width = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(127, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 32);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmProjectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(871, 498);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Patient";
            this.Load += new System.EventHandler(this.FrmProjectPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectTerm;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAgeDd;
        private System.Windows.Forms.TextBox txtAgeDd;
        private System.Windows.Forms.Label lblAgeMm;
        private System.Windows.Forms.TextBox txtAgeMm;
        private System.Windows.Forms.Label lblAgeYy;
        private System.Windows.Forms.TextBox txtAgeYy;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvwProjectPatientList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatientNo;
        private System.Windows.Forms.ColumnHeader P_Reg_No;
        private System.Windows.Forms.ColumnHeader P_NAME;
        private System.Windows.Forms.ColumnHeader F_Name;
        private System.Windows.Forms.ColumnHeader M_Name;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader mobile;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.ColumnHeader PPID;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.Button btnPrint;
    }
}