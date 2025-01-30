namespace NewHIMS.Forms.Receiptions.Patients
{
    partial class FrmPatientSearch
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
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtIPD = new System.Windows.Forms.TextBox();
            this.lblAdmissionID = new System.Windows.Forms.Label();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.lblHospitalID = new System.Windows.Forms.Label();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.grpSearchOption = new System.Windows.Forms.GroupBox();
            this.radioMobileNo = new System.Windows.Forms.RadioButton();
            this.radioPatientName = new System.Windows.Forms.RadioButton();
            this.radioByGrdName = new System.Windows.Forms.RadioButton();
            this.radioByAddress = new System.Windows.Forms.RadioButton();
            this.lvwPatientSRefDoctor = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lvwpatientSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.chkAdmittedPatientOnly = new System.Windows.Forms.CheckBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatientTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPatient.SuspendLayout();
            this.grpSearchOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatient.Controls.Add(this.btnRefresh);
            this.grpPatient.Controls.Add(this.txtIPD);
            this.grpPatient.Controls.Add(this.lblAdmissionID);
            this.grpPatient.Controls.Add(this.txtAdmissionID);
            this.grpPatient.Controls.Add(this.lblHospitalID);
            this.grpPatient.Controls.Add(this.txtHospitalID);
            this.grpPatient.Controls.Add(this.grpSearchOption);
            this.grpPatient.Controls.Add(this.lvwPatientSRefDoctor);
            this.grpPatient.Controls.Add(this.lvwpatientSearch);
            this.grpPatient.Controls.Add(this.chkAdmittedPatientOnly);
            this.grpPatient.Controls.Add(this.lblSearchBy);
            this.grpPatient.Controls.Add(this.txtSearchBy);
            this.grpPatient.Controls.Add(this.label3);
            this.grpPatient.Controls.Add(this.lblPatientTitle);
            this.grpPatient.Controls.Add(this.btnClose);
            this.grpPatient.Controls.Add(this.lblPatientName);
            this.grpPatient.Controls.Add(this.txtPatientName);
            this.grpPatient.Controls.Add(this.lblGuardianName);
            this.grpPatient.Controls.Add(this.txtGuardianName);
            this.grpPatient.Controls.Add(this.lblAddress);
            this.grpPatient.Controls.Add(this.txtAddress);
            this.grpPatient.Controls.Add(this.lblCPhone);
            this.grpPatient.Controls.Add(this.txtCPhone);
            this.grpPatient.Controls.Add(this.label2);
            this.grpPatient.Location = new System.Drawing.Point(12, 12);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(925, 483);
            this.grpPatient.TabIndex = 1;
            this.grpPatient.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(755, 449);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 104;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtIPD
            // 
            this.txtIPD.BackColor = System.Drawing.Color.Linen;
            this.txtIPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPD.Location = new System.Drawing.Point(128, 325);
            this.txtIPD.MaxLength = 255;
            this.txtIPD.Name = "txtIPD";
            this.txtIPD.Size = new System.Drawing.Size(29, 20);
            this.txtIPD.TabIndex = 102;
            this.txtIPD.Tag = "guardian_name";
            this.txtIPD.Text = "IPD";
            this.txtIPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIPD_KeyPress);
            // 
            // lblAdmissionID
            // 
            this.lblAdmissionID.AutoSize = true;
            this.lblAdmissionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionID.Location = new System.Drawing.Point(29, 307);
            this.lblAdmissionID.Name = "lblAdmissionID";
            this.lblAdmissionID.Size = new System.Drawing.Size(80, 13);
            this.lblAdmissionID.TabIndex = 100;
            this.lblAdmissionID.Text = "Admission ID";
            this.lblAdmissionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.BackColor = System.Drawing.Color.Linen;
            this.txtAdmissionID.Location = new System.Drawing.Point(127, 304);
            this.txtAdmissionID.MaxLength = 255;
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(115, 20);
            this.txtAdmissionID.TabIndex = 98;
            this.txtAdmissionID.Tag = "patient_name";
            this.txtAdmissionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionID_KeyPress);
            // 
            // lblHospitalID
            // 
            this.lblHospitalID.AutoSize = true;
            this.lblHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalID.Location = new System.Drawing.Point(29, 328);
            this.lblHospitalID.Name = "lblHospitalID";
            this.lblHospitalID.Size = new System.Drawing.Size(70, 13);
            this.lblHospitalID.TabIndex = 101;
            this.lblHospitalID.Text = "Hospital ID";
            this.lblHospitalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.BackColor = System.Drawing.Color.Linen;
            this.txtHospitalID.Location = new System.Drawing.Point(157, 325);
            this.txtHospitalID.MaxLength = 255;
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(119, 20);
            this.txtHospitalID.TabIndex = 99;
            this.txtHospitalID.Tag = "guardian_name";
            this.txtHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospitalID_KeyPress);
            // 
            // grpSearchOption
            // 
            this.grpSearchOption.Controls.Add(this.radioMobileNo);
            this.grpSearchOption.Controls.Add(this.radioPatientName);
            this.grpSearchOption.Controls.Add(this.radioByGrdName);
            this.grpSearchOption.Controls.Add(this.radioByAddress);
            this.grpSearchOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchOption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpSearchOption.Location = new System.Drawing.Point(33, 164);
            this.grpSearchOption.Name = "grpSearchOption";
            this.grpSearchOption.Size = new System.Drawing.Size(295, 83);
            this.grpSearchOption.TabIndex = 97;
            this.grpSearchOption.TabStop = false;
            this.grpSearchOption.Text = "Search Options";
            // 
            // radioMobileNo
            // 
            this.radioMobileNo.AutoSize = true;
            this.radioMobileNo.Location = new System.Drawing.Point(141, 51);
            this.radioMobileNo.Name = "radioMobileNo";
            this.radioMobileNo.Size = new System.Drawing.Size(104, 17);
            this.radioMobileNo.TabIndex = 98;
            this.radioMobileNo.Text = "By Mobile No.";
            this.radioMobileNo.UseVisualStyleBackColor = true;
            this.radioMobileNo.Click += new System.EventHandler(this.radioByHospitalID_Click);
            // 
            // radioPatientName
            // 
            this.radioPatientName.AutoSize = true;
            this.radioPatientName.Checked = true;
            this.radioPatientName.Location = new System.Drawing.Point(15, 28);
            this.radioPatientName.Name = "radioPatientName";
            this.radioPatientName.Size = new System.Drawing.Size(119, 17);
            this.radioPatientName.TabIndex = 99;
            this.radioPatientName.TabStop = true;
            this.radioPatientName.Text = "By Patient Name";
            this.radioPatientName.UseVisualStyleBackColor = true;
            this.radioPatientName.Click += new System.EventHandler(this.radioByHospitalID_Click);
            // 
            // radioByGrdName
            // 
            this.radioByGrdName.AutoSize = true;
            this.radioByGrdName.Location = new System.Drawing.Point(140, 28);
            this.radioByGrdName.Name = "radioByGrdName";
            this.radioByGrdName.Size = new System.Drawing.Size(130, 17);
            this.radioByGrdName.TabIndex = 100;
            this.radioByGrdName.Text = "By Guardian Name";
            this.radioByGrdName.UseVisualStyleBackColor = true;
            this.radioByGrdName.Click += new System.EventHandler(this.radioByHospitalID_Click);
            // 
            // radioByAddress
            // 
            this.radioByAddress.AutoSize = true;
            this.radioByAddress.Location = new System.Drawing.Point(16, 51);
            this.radioByAddress.Name = "radioByAddress";
            this.radioByAddress.Size = new System.Drawing.Size(88, 17);
            this.radioByAddress.TabIndex = 101;
            this.radioByAddress.Text = "By Address";
            this.radioByAddress.UseVisualStyleBackColor = true;
            this.radioByAddress.Click += new System.EventHandler(this.radioByHospitalID_Click);
            // 
            // lvwPatientSRefDoctor
            // 
            this.lvwPatientSRefDoctor.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientSRefDoctor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lvwPatientSRefDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientSRefDoctor.GridLines = true;
            this.lvwPatientSRefDoctor.Location = new System.Drawing.Point(349, 372);
            this.lvwPatientSRefDoctor.Name = "lvwPatientSRefDoctor";
            this.lvwPatientSRefDoctor.Size = new System.Drawing.Size(304, 101);
            this.lvwPatientSRefDoctor.TabIndex = 96;
            this.lvwPatientSRefDoctor.UseCompatibleStateImageBehavior = false;
            this.lvwPatientSRefDoctor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Reffered Doctors";
            this.columnHeader5.Width = 300;
            // 
            // lvwpatientSearch
            // 
            this.lvwpatientSearch.BackColor = System.Drawing.Color.Linen;
            this.lvwpatientSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader6});
            this.lvwpatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwpatientSearch.FullRowSelect = true;
            this.lvwpatientSearch.GridLines = true;
            this.lvwpatientSearch.Location = new System.Drawing.Point(349, 91);
            this.lvwpatientSearch.Name = "lvwpatientSearch";
            this.lvwpatientSearch.Size = new System.Drawing.Size(570, 281);
            this.lvwpatientSearch.TabIndex = 95;
            this.lvwpatientSearch.UseCompatibleStateImageBehavior = false;
            this.lvwpatientSearch.View = System.Windows.Forms.View.Details;
            this.lvwpatientSearch.Click += new System.EventHandler(this.lvwpatientSearch_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hospital ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Admission ID";
            this.columnHeader9.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patient Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Guardian Name";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "C Phone";
            this.columnHeader10.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cabin";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Received By";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.Width = 0;
            // 
            // chkAdmittedPatientOnly
            // 
            this.chkAdmittedPatientOnly.AutoSize = true;
            this.chkAdmittedPatientOnly.Checked = true;
            this.chkAdmittedPatientOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdmittedPatientOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmittedPatientOnly.Location = new System.Drawing.Point(128, 132);
            this.chkAdmittedPatientOnly.Name = "chkAdmittedPatientOnly";
            this.chkAdmittedPatientOnly.Size = new System.Drawing.Size(148, 17);
            this.chkAdmittedPatientOnly.TabIndex = 93;
            this.chkAdmittedPatientOnly.Text = "Admitted Patient Only";
            this.chkAdmittedPatientOnly.UseVisualStyleBackColor = true;
            this.chkAdmittedPatientOnly.CheckedChanged += new System.EventHandler(this.chkAdmittedPatientOnly_CheckedChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.Navy;
            this.lblSearchBy.Location = new System.Drawing.Point(33, 259);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(83, 13);
            this.lblSearchBy.TabIndex = 68;
            this.lblSearchBy.Text = "Patient Name";
            this.lblSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchBy.Location = new System.Drawing.Point(128, 256);
            this.txtSearchBy.MaxLength = 20;
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(200, 20);
            this.txtSearchBy.TabIndex = 0;
            this.txtSearchBy.Tag = "admission_code";
            this.txtSearchBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBy_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Search Patient";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatientTitle
            // 
            this.lblPatientTitle.AutoSize = true;
            this.lblPatientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientTitle.ForeColor = System.Drawing.Color.White;
            this.lblPatientTitle.Location = new System.Drawing.Point(364, 24);
            this.lblPatientTitle.Name = "lblPatientTitle";
            this.lblPatientTitle.Size = new System.Drawing.Size(206, 31);
            this.lblPatientTitle.TabIndex = 31;
            this.lblPatientTitle.Text = "Patient Search";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(840, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnClose_KeyPress);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(30, 349);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(87, 13);
            this.lblPatientName.TabIndex = 20;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.Linen;
            this.txtPatientName.Location = new System.Drawing.Point(128, 346);
            this.txtPatientName.MaxLength = 255;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 20);
            this.txtPatientName.TabIndex = 2;
            this.txtPatientName.Tag = "patient_name";
            this.txtPatientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientName_KeyPress);
            // 
            // lblGuardianName
            // 
            this.lblGuardianName.AutoSize = true;
            this.lblGuardianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardianName.Location = new System.Drawing.Point(30, 370);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Size = new System.Drawing.Size(98, 13);
            this.lblGuardianName.TabIndex = 21;
            this.lblGuardianName.Text = "Guardian Name:";
            this.lblGuardianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.BackColor = System.Drawing.Color.Linen;
            this.txtGuardianName.Location = new System.Drawing.Point(128, 367);
            this.txtGuardianName.MaxLength = 255;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.Size = new System.Drawing.Size(200, 20);
            this.txtGuardianName.TabIndex = 3;
            this.txtGuardianName.Tag = "guardian_name";
            this.txtGuardianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianName_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 391);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Linen;
            this.txtAddress.Location = new System.Drawing.Point(128, 388);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Tag = "address";
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.Location = new System.Drawing.Point(30, 412);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(59, 13);
            this.lblCPhone.TabIndex = 26;
            this.lblCPhone.Text = "C Phone:";
            this.lblCPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCPhone
            // 
            this.txtCPhone.BackColor = System.Drawing.Color.Linen;
            this.txtCPhone.Location = new System.Drawing.Point(128, 409);
            this.txtCPhone.MaxLength = 15;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(153, 20);
            this.txtCPhone.TabIndex = 5;
            this.txtCPhone.Tag = "c_phone";
            this.txtCPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPhone_KeyPress);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 386);
            this.label2.TabIndex = 45;
            // 
            // FrmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(949, 507);
            this.Controls.Add(this.grpPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPatientSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Search";
            this.Load += new System.EventHandler(this.FrmPatientSearch_Load);
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpSearchOption.ResumeLayout(false);
            this.grpSearchOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.CheckBox chkAdmittedPatientOnly;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPatientTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwpatientSearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvwPatientSRefDoctor;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grpSearchOption;
        private System.Windows.Forms.RadioButton radioMobileNo;
        private System.Windows.Forms.RadioButton radioPatientName;
        private System.Windows.Forms.RadioButton radioByGrdName;
        private System.Windows.Forms.RadioButton radioByAddress;
        private System.Windows.Forms.Label lblAdmissionID;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Label lblHospitalID;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.TextBox txtIPD;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnRefresh;
    }
}