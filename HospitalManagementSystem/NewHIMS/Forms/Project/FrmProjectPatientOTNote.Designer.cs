namespace NewHIMS.Forms.Project
{
    partial class FrmProjectPatientOTNote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwPPODoctorList = new System.Windows.Forms.ListView();
            this.Ref_Doctor_Name = new System.Windows.Forms.ColumnHeader();
            this.service_type = new System.Windows.Forms.ColumnHeader();
            this.reff_doctor_id = new System.Windows.Forms.ColumnHeader();
            this.service_type_id = new System.Windows.Forms.ColumnHeader();
            this.PCLID = new System.Windows.Forms.ColumnHeader();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbRefDoctor = new System.Windows.Forms.ComboBox();
            this.cmbdocbilltype = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPOTID = new System.Windows.Forms.TextBox();
            this.txtFinishTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOtDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnaesthesiaType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOtReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOTName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPatientNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(902, 29);
            this.label7.TabIndex = 168;
            this.label7.Text = "Project Patient OT Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvwProjectPatientList);
            this.groupBox5.Location = new System.Drawing.Point(8, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 484);
            this.groupBox5.TabIndex = 170;
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
            this.lvwProjectPatientList.Location = new System.Drawing.Point(6, 11);
            this.lvwProjectPatientList.MultiSelect = false;
            this.lvwProjectPatientList.Name = "lvwProjectPatientList";
            this.lvwProjectPatientList.Size = new System.Drawing.Size(343, 466);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPPODoctorList);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(370, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 484);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            // 
            // lvwPPODoctorList
            // 
            this.lvwPPODoctorList.BackColor = System.Drawing.Color.Silver;
            this.lvwPPODoctorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ref_Doctor_Name,
            this.service_type,
            this.reff_doctor_id,
            this.service_type_id,
            this.PCLID});
            this.lvwPPODoctorList.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPPODoctorList.GridLines = true;
            this.lvwPPODoctorList.Location = new System.Drawing.Point(6, 327);
            this.lvwPPODoctorList.Name = "lvwPPODoctorList";
            this.lvwPPODoctorList.Size = new System.Drawing.Size(507, 97);
            this.lvwPPODoctorList.TabIndex = 158;
            this.lvwPPODoctorList.UseCompatibleStateImageBehavior = false;
            this.lvwPPODoctorList.View = System.Windows.Forms.View.Details;
            this.lvwPPODoctorList.Click += new System.EventHandler(this.lvwPPODoctorList_Click);
            // 
            // Ref_Doctor_Name
            // 
            this.Ref_Doctor_Name.Text = "Doctor Name";
            this.Ref_Doctor_Name.Width = 290;
            // 
            // service_type
            // 
            this.service_type.Text = "Service Type";
            this.service_type.Width = 180;
            // 
            // reff_doctor_id
            // 
            this.reff_doctor_id.Text = "Doctor ID";
            this.reff_doctor_id.Width = 0;
            // 
            // service_type_id
            // 
            this.service_type_id.Text = "Type ID";
            this.service_type_id.Width = 0;
            // 
            // PCLID
            // 
            this.PCLID.Text = "Consultant List ID";
            this.PCLID.Width = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSave);
            this.groupBox6.Controls.Add(this.btnPrint);
            this.groupBox6.Controls.Add(this.btnrefresh);
            this.groupBox6.Controls.Add(this.btnclose);
            this.groupBox6.Location = new System.Drawing.Point(6, 423);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(507, 55);
            this.groupBox6.TabIndex = 157;
            this.groupBox6.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(282, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 169;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(22, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 29);
            this.btnPrint.TabIndex = 168;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Location = new System.Drawing.Point(145, 16);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(83, 28);
            this.btnrefresh.TabIndex = 56;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(411, 15);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 28);
            this.btnclose.TabIndex = 58;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbRefDoctor);
            this.groupBox4.Controls.Add(this.cmbdocbilltype);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(6, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 90);
            this.groupBox4.TabIndex = 156;
            this.groupBox4.TabStop = false;
            // 
            // cmbRefDoctor
            // 
            this.cmbRefDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRefDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefDoctor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRefDoctor.FormattingEnabled = true;
            this.cmbRefDoctor.Location = new System.Drawing.Point(104, 16);
            this.cmbRefDoctor.Name = "cmbRefDoctor";
            this.cmbRefDoctor.Size = new System.Drawing.Size(388, 23);
            this.cmbRefDoctor.TabIndex = 156;
            // 
            // cmbdocbilltype
            // 
            this.cmbdocbilltype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbdocbilltype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdocbilltype.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdocbilltype.FormattingEnabled = true;
            this.cmbdocbilltype.Location = new System.Drawing.Point(104, 53);
            this.cmbdocbilltype.Name = "cmbdocbilltype";
            this.cmbdocbilltype.Size = new System.Drawing.Size(176, 23);
            this.cmbdocbilltype.TabIndex = 155;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 78;
            this.label13.Text = "Service Type";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(341, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 31);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 61;
            this.label15.Text = " Doctor Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPOTID);
            this.groupBox3.Controls.Add(this.txtFinishTime);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtStartTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpOtDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAnaesthesiaType);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtOtReg);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtOTName);
            this.groupBox3.Location = new System.Drawing.Point(6, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 120);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtPOTID
            // 
            this.txtPOTID.Location = new System.Drawing.Point(452, 85);
            this.txtPOTID.Name = "txtPOTID";
            this.txtPOTID.Size = new System.Drawing.Size(40, 20);
            this.txtPOTID.TabIndex = 175;
            this.txtPOTID.Visible = false;
            // 
            // txtFinishTime
            // 
            this.txtFinishTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinishTime.Location = new System.Drawing.Point(329, 84);
            this.txtFinishTime.Name = "txtFinishTime";
            this.txtFinishTime.Size = new System.Drawing.Size(116, 23);
            this.txtFinishTime.TabIndex = 172;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 174;
            this.label2.Text = "Finish Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(104, 84);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(124, 23);
            this.txtStartTime.TabIndex = 171;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 173;
            this.label5.Text = "Start Time";
            // 
            // dtpOtDate
            // 
            this.dtpOtDate.CustomFormat = "dd-MMM-yyy";
            this.dtpOtDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOtDate.Location = new System.Drawing.Point(375, 49);
            this.dtpOtDate.Name = "dtpOtDate";
            this.dtpOtDate.Size = new System.Drawing.Size(117, 23);
            this.dtpOtDate.TabIndex = 170;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(318, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 169;
            this.label14.Text = "OT Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 168;
            this.label4.Text = "Anaes. Type";
            // 
            // txtAnaesthesiaType
            // 
            this.txtAnaesthesiaType.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnaesthesiaType.Location = new System.Drawing.Point(104, 49);
            this.txtAnaesthesiaType.Name = "txtAnaesthesiaType";
            this.txtAnaesthesiaType.Size = new System.Drawing.Size(196, 23);
            this.txtAnaesthesiaType.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 165;
            this.label1.Text = "OT Reg. No";
            // 
            // txtOtReg
            // 
            this.txtOtReg.Enabled = false;
            this.txtOtReg.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtReg.Location = new System.Drawing.Point(104, 16);
            this.txtOtReg.Name = "txtOtReg";
            this.txtOtReg.Size = new System.Drawing.Size(117, 23);
            this.txtOtReg.TabIndex = 164;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 166;
            this.label6.Text = "OT Name";
            // 
            // txtOTName
            // 
            this.txtOTName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTName.Location = new System.Drawing.Point(297, 16);
            this.txtOTName.Name = "txtOTName";
            this.txtOTName.Size = new System.Drawing.Size(197, 23);
            this.txtOTName.TabIndex = 163;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.cmbGender);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtContactNumber);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPatientNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 108);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(320, 15);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(174, 23);
            this.txtAge.TabIndex = 101;
            // 
            // cmbGender
            // 
            this.cmbGender.Enabled = false;
            this.cmbGender.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(379, 79);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(115, 23);
            this.cmbGender.TabIndex = 100;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(326, 83);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 15);
            this.lblGender.TabIndex = 99;
            this.lblGender.Text = "Gender ";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 98;
            this.label8.Text = "Mobile Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Enabled = false;
            this.txtContactNumber.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(104, 79);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(189, 23);
            this.txtContactNumber.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(237, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 95;
            this.label10.Text = "Date of Birth";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Patient Reg. No";
            // 
            // txtPatientNo
            // 
            this.txtPatientNo.Enabled = false;
            this.txtPatientNo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientNo.Location = new System.Drawing.Point(104, 15);
            this.txtPatientNo.Name = "txtPatientNo";
            this.txtPatientNo.Size = new System.Drawing.Size(117, 23);
            this.txtPatientNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(104, 46);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(390, 23);
            this.txtPatientName.TabIndex = 6;
            // 
            // FrmProjectPatientOTNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectPatientOTNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Patient OT Note";
            this.Load += new System.EventHandler(this.FrmProjectPatientOTNote_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvwProjectPatientList;
        private System.Windows.Forms.ColumnHeader PPID;
        private System.Windows.Forms.ColumnHeader P_Reg_No;
        private System.Windows.Forms.ColumnHeader P_NAME;
        private System.Windows.Forms.ColumnHeader F_Name;
        private System.Windows.Forms.ColumnHeader M_Name;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader mobile;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPatientNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOTName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnaesthesiaType;
        private System.Windows.Forms.DateTimePicker dtpOtDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFinishTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbdocbilltype;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbRefDoctor;
        private System.Windows.Forms.ListView lvwPPODoctorList;
        private System.Windows.Forms.ColumnHeader PCLID;
        private System.Windows.Forms.ColumnHeader reff_doctor_id;
        private System.Windows.Forms.ColumnHeader Ref_Doctor_Name;
        private System.Windows.Forms.ColumnHeader service_type;
        private System.Windows.Forms.ColumnHeader service_type_id;
        private System.Windows.Forms.TextBox txtPOTID;
    }
}