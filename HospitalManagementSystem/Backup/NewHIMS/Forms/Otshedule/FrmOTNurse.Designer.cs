namespace NewHIMS.Forms.Otshedule
{
    partial class FrmOTNurse
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGurdianName = new System.Windows.Forms.TextBox();
            this.patient_code = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOperationDate = new System.Windows.Forms.TextBox();
            this.txtcontactNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtOperationName = new System.Windows.Forms.TextBox();
            this.txtAdmissionDate = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientname = new System.Windows.Forms.TextBox();
            this.lvwOTNurse = new System.Windows.Forms.ListView();
            this.cabin_id = new System.Windows.Forms.ColumnHeader();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.hospital_id = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.operation_note_id = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbNature = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb1stASS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb2ndAss = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb3rdAss = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAnesthesia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsurgeon = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOTsubmit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmbOTCabin = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnRTB = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpPatient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(875, 27);
            this.label7.TabIndex = 54;
            this.label7.Text = "OT  Nurse";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPatient
            // 
            this.grpPatient.BackColor = System.Drawing.Color.White;
            this.grpPatient.Controls.Add(this.label10);
            this.grpPatient.Controls.Add(this.txtGurdianName);
            this.grpPatient.Controls.Add(this.patient_code);
            this.grpPatient.Controls.Add(this.label3);
            this.grpPatient.Controls.Add(this.label11);
            this.grpPatient.Controls.Add(this.txtOperationDate);
            this.grpPatient.Controls.Add(this.txtcontactNO);
            this.grpPatient.Controls.Add(this.label1);
            this.grpPatient.Controls.Add(this.txtAge);
            this.grpPatient.Controls.Add(this.txtOperationName);
            this.grpPatient.Controls.Add(this.txtAdmissionDate);
            this.grpPatient.Controls.Add(this.lblPatientName);
            this.grpPatient.Controls.Add(this.txtPatientname);
            this.grpPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatient.Location = new System.Drawing.Point(229, 60);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(536, 126);
            this.grpPatient.TabIndex = 79;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Patient Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Guardian Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGurdianName
            // 
            this.txtGurdianName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGurdianName.Location = new System.Drawing.Point(157, 76);
            this.txtGurdianName.Name = "txtGurdianName";
            this.txtGurdianName.ReadOnly = true;
            this.txtGurdianName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGurdianName.Size = new System.Drawing.Size(152, 20);
            this.txtGurdianName.TabIndex = 89;
            this.txtGurdianName.Tag = "patient";
            // 
            // patient_code
            // 
            this.patient_code.AutoSize = true;
            this.patient_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_code.Location = new System.Drawing.Point(45, 16);
            this.patient_code.Name = "patient_code";
            this.patient_code.Size = new System.Drawing.Size(98, 13);
            this.patient_code.TabIndex = 67;
            this.patient_code.Text = "Operation Name";
            this.patient_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Contact No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Operation Date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOperationDate
            // 
            this.txtOperationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOperationDate.Location = new System.Drawing.Point(163, 32);
            this.txtOperationDate.Name = "txtOperationDate";
            this.txtOperationDate.ReadOnly = true;
            this.txtOperationDate.Size = new System.Drawing.Size(144, 20);
            this.txtOperationDate.TabIndex = 91;
            this.txtOperationDate.Tag = "admission_date";
            // 
            // txtcontactNO
            // 
            this.txtcontactNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcontactNO.Location = new System.Drawing.Point(315, 77);
            this.txtcontactNO.Name = "txtcontactNO";
            this.txtcontactNO.ReadOnly = true;
            this.txtcontactNO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcontactNO.Size = new System.Drawing.Size(142, 20);
            this.txtcontactNO.TabIndex = 87;
            this.txtcontactNO.Tag = "patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Age";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAge.Location = new System.Drawing.Point(314, 32);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAge.Size = new System.Drawing.Size(143, 20);
            this.txtAge.TabIndex = 83;
            this.txtAge.Tag = "cc";
            // 
            // txtOperationName
            // 
            this.txtOperationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOperationName.Location = new System.Drawing.Point(35, 32);
            this.txtOperationName.Name = "txtOperationName";
            this.txtOperationName.ReadOnly = true;
            this.txtOperationName.Size = new System.Drawing.Size(115, 20);
            this.txtOperationName.TabIndex = 77;
            this.txtOperationName.Tag = "patient";
            // 
            // txtAdmissionDate
            // 
            this.txtAdmissionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdmissionDate.Location = new System.Drawing.Point(320, 32);
            this.txtAdmissionDate.Name = "txtAdmissionDate";
            this.txtAdmissionDate.ReadOnly = true;
            this.txtAdmissionDate.Size = new System.Drawing.Size(111, 20);
            this.txtAdmissionDate.TabIndex = 85;
            this.txtAdmissionDate.Tag = "admission_date";
            this.txtAdmissionDate.Visible = false;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(45, 61);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(87, 13);
            this.lblPatientName.TabIndex = 78;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientname
            // 
            this.txtPatientname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPatientname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPatientname.Location = new System.Drawing.Point(36, 76);
            this.txtPatientname.Name = "txtPatientname";
            this.txtPatientname.ReadOnly = true;
            this.txtPatientname.Size = new System.Drawing.Size(115, 20);
            this.txtPatientname.TabIndex = 80;
            this.txtPatientname.Tag = "patient_code";
            // 
            // lvwOTNurse
            // 
            this.lvwOTNurse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwOTNurse.BackColor = System.Drawing.Color.Lavender;
            this.lvwOTNurse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin_id,
            this.cabin,
            this.hospital_id,
            this.admission_id,
            this.operation_note_id});
            this.lvwOTNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOTNurse.FullRowSelect = true;
            this.lvwOTNurse.HideSelection = false;
            this.lvwOTNurse.Location = new System.Drawing.Point(21, 57);
            this.lvwOTNurse.Name = "lvwOTNurse";
            this.lvwOTNurse.Size = new System.Drawing.Size(190, 397);
            this.lvwOTNurse.TabIndex = 80;
            this.lvwOTNurse.UseCompatibleStateImageBehavior = false;
            this.lvwOTNurse.View = System.Windows.Forms.View.Details;
            this.lvwOTNurse.SelectedIndexChanged += new System.EventHandler(this.lvwOTNurse_SelectedIndexChanged);
            this.lvwOTNurse.Click += new System.EventHandler(this.lvwOTNurse_Click);
            // 
            // cabin_id
            // 
            this.cabin_id.Text = "Cabin ID";
            this.cabin_id.Width = 0;
            // 
            // cabin
            // 
            this.cabin.Text = "Cabin";
            this.cabin.Width = 54;
            // 
            // hospital_id
            // 
            this.hospital_id.Text = "Hospital ID";
            this.hospital_id.Width = 130;
            // 
            // admission_id
            // 
            this.admission_id.Text = "AdmissionID";
            this.admission_id.Width = 0;
            // 
            // operation_note_id
            // 
            this.operation_note_id.Text = "OTNoteID";
            this.operation_note_id.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbNature);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb1stASS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb2ndAss);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb3rdAss);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAnesthesia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbsurgeon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(229, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 115);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " OT Doctors";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Anest. Nature";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbNature
            // 
            this.cmbNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Location = new System.Drawing.Point(97, 83);
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(175, 21);
            this.cmbNature.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "1st Assist.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb1stASS
            // 
            this.cmb1stASS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb1stASS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb1stASS.FormattingEnabled = true;
            this.cmb1stASS.Location = new System.Drawing.Point(350, 25);
            this.cmb1stASS.Name = "cmb1stASS";
            this.cmb1stASS.Size = new System.Drawing.Size(175, 21);
            this.cmb1stASS.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "2nd Assist.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb2ndAss
            // 
            this.cmb2ndAss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb2ndAss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb2ndAss.FormattingEnabled = true;
            this.cmb2ndAss.Location = new System.Drawing.Point(350, 53);
            this.cmb2ndAss.Name = "cmb2ndAss";
            this.cmb2ndAss.Size = new System.Drawing.Size(175, 21);
            this.cmb2ndAss.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Anesthesia";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb3rdAss
            // 
            this.cmb3rdAss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb3rdAss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb3rdAss.FormattingEnabled = true;
            this.cmb3rdAss.Location = new System.Drawing.Point(350, 82);
            this.cmb3rdAss.Name = "cmb3rdAss";
            this.cmb3rdAss.Size = new System.Drawing.Size(175, 21);
            this.cmb3rdAss.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "3rd Assist.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAnesthesia
            // 
            this.cmbAnesthesia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAnesthesia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnesthesia.FormattingEnabled = true;
            this.cmbAnesthesia.Location = new System.Drawing.Point(97, 52);
            this.cmbAnesthesia.Name = "cmbAnesthesia";
            this.cmbAnesthesia.Size = new System.Drawing.Size(175, 21);
            this.cmbAnesthesia.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Surgeon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbsurgeon
            // 
            this.cmbsurgeon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbsurgeon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsurgeon.FormattingEnabled = true;
            this.cmbsurgeon.Location = new System.Drawing.Point(97, 22);
            this.cmbsurgeon.Name = "cmbsurgeon";
            this.cmbsurgeon.Size = new System.Drawing.Size(175, 21);
            this.cmbsurgeon.TabIndex = 57;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtOTsubmit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(237, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 0);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Non-Received Patients";
            // 
            // txtOTsubmit
            // 
            this.txtOTsubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOTsubmit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOTsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOTsubmit.Enabled = false;
            this.txtOTsubmit.Location = new System.Drawing.Point(9, 16);
            this.txtOTsubmit.Multiline = true;
            this.txtOTsubmit.Name = "txtOTsubmit";
            this.txtOTsubmit.ReadOnly = true;
            this.txtOTsubmit.Size = new System.Drawing.Size(519, 18);
            this.txtOTsubmit.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(692, -131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 27);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(247, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 24);
            this.linkLabel1.TabIndex = 97;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "OT Medicine";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 100000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 105;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.cmbOTCabin);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDays);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(229, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 79);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Return To Bed";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(330, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(65, 29);
            this.numericUpDown1.TabIndex = 0;
            // 
            // cmbOTCabin
            // 
            this.cmbOTCabin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOTCabin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOTCabin.FormattingEnabled = true;
            this.cmbOTCabin.Location = new System.Drawing.Point(114, 38);
            this.cmbOTCabin.Name = "cmbOTCabin";
            this.cmbOTCabin.Size = new System.Drawing.Size(93, 21);
            this.cmbOTCabin.TabIndex = 69;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "OT Rooom";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(230, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "Additional Hour";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 93;
            this.label12.Text = "Post  OP Day";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(114, 14);
            this.txtDays.MaxLength = 3;
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(41, 20);
            this.txtDays.TabIndex = 33;
            this.txtDays.Text = "1";
            // 
            // btnRTB
            // 
            this.btnRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTB.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnRTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRTB.Location = new System.Drawing.Point(232, 427);
            this.btnRTB.Name = "btnRTB";
            this.btnRTB.Size = new System.Drawing.Size(83, 27);
            this.btnRTB.TabIndex = 104;
            this.btnRTB.Text = "Return";
            this.btnRTB.UseVisualStyleBackColor = true;
            this.btnRTB.Click += new System.EventHandler(this.btnRTB_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(321, 427);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 103;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FrmOTNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(830, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRTB);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwOTNurse);
            this.Controls.Add(this.grpPatient);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOTNurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OT Nurse";
            this.Load += new System.EventHandler(this.FrmOTNurse_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontactNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPatientname;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtOperationName;
        private System.Windows.Forms.ListView lvwOTNurse;
        private System.Windows.Forms.ColumnHeader cabin_id;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader hospital_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb1stASS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb2ndAss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb3rdAss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAnesthesia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsurgeon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label patient_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGurdianName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOperationDate;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader operation_note_id;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbNature;
        private System.Windows.Forms.TextBox txtAdmissionDate;
        private System.Windows.Forms.TextBox txtOTsubmit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbOTCabin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnRTB;
        private System.Windows.Forms.Button btnRefresh;
    }
}