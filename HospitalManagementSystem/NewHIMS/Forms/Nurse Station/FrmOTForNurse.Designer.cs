namespace NewHIMS.Forms.Nurse_Station
{
    partial class FrmOTForNurse
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grddoctorspayment = new System.Windows.Forms.DataGridView();
            this.refered_doctors_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctors_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRefferedDoctors = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpatientcode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lnkOTNote = new System.Windows.Forms.LinkLabel();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.cmbdocbilltype = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtadmissiondate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcabinNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDoctorSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txtpatientage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtadmissioncode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lnkOTMedicine = new System.Windows.Forms.LinkLabel();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 156;
            this.label4.Text = "Cabin No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvwPatientInfo);
            this.groupBox5.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.groupBox5.Location = new System.Drawing.Point(12, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 458);
            this.groupBox5.TabIndex = 158;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Patient Info";
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.LightSalmon;
            this.lvwPatientInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.lvwPatientInfo.Location = new System.Drawing.Point(7, 18);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(399, 429);
            this.lvwPatientInfo.TabIndex = 7;
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
            this.cabin.Width = 75;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 82;
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
            this.patient_name.Width = 222;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 152;
            this.label1.Text = "Hospital ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grddoctorspayment);
            this.groupBox3.Location = new System.Drawing.Point(16, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 192);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // grddoctorspayment
            // 
            this.grddoctorspayment.AllowUserToAddRows = false;
            this.grddoctorspayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddoctorspayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refered_doctors_id,
            this.Column1,
            this.Type,
            this.bill_type_id,
            this.Column2,
            this.Charge,
            this.doctors_bill_id});
            this.grddoctorspayment.Location = new System.Drawing.Point(6, 19);
            this.grddoctorspayment.Name = "grddoctorspayment";
            this.grddoctorspayment.Size = new System.Drawing.Size(538, 134);
            this.grddoctorspayment.TabIndex = 55;
            // 
            // refered_doctors_id
            // 
            this.refered_doctors_id.HeaderText = "refered_doctors_id";
            this.refered_doctors_id.Name = "refered_doctors_id";
            this.refered_doctors_id.ReadOnly = true;
            this.refered_doctors_id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Doctor Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // Type
            // 
            this.Type.HeaderText = "type";
            this.Type.Name = "Type";
            // 
            // bill_type_id
            // 
            this.bill_type_id.HeaderText = "bill_type_id";
            this.bill_type_id.Name = "bill_type_id";
            this.bill_type_id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = " Qty";
            this.Column2.Name = "Column2";
            this.Column2.Width = 45;
            // 
            // Charge
            // 
            this.Charge.HeaderText = "Charge";
            this.Charge.Name = "Charge";
            // 
            // doctors_bill_id
            // 
            this.doctors_bill_id.HeaderText = "doctors_bill_id";
            this.doctors_bill_id.Name = "doctors_bill_id";
            this.doctors_bill_id.Visible = false;
            // 
            // cmbRefferedDoctors
            // 
            this.cmbRefferedDoctors.Enabled = false;
            this.cmbRefferedDoctors.FormattingEnabled = true;
            this.cmbRefferedDoctors.Location = new System.Drawing.Point(558, 201);
            this.cmbRefferedDoctors.Name = "cmbRefferedDoctors";
            this.cmbRefferedDoctors.Size = new System.Drawing.Size(310, 21);
            this.cmbRefferedDoctors.TabIndex = 154;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Charge";
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(390, 54);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(78, 20);
            this.txtCharge.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(814, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 153;
            this.label2.Text = "Cabin No";
            // 
            // txtpatientcode
            // 
            this.txtpatientcode.Enabled = false;
            this.txtpatientcode.Location = new System.Drawing.Point(878, 79);
            this.txtpatientcode.Name = "txtpatientcode";
            this.txtpatientcode.Size = new System.Drawing.Size(98, 20);
            this.txtpatientcode.TabIndex = 151;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lnkOTMedicine);
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnrefresh);
            this.groupBox4.Controls.Add(this.lnkOTNote);
            this.groupBox4.Controls.Add(this.btnclose);
            this.groupBox4.Location = new System.Drawing.Point(17, 448);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 50);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(300, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 29);
            this.btnPrint.TabIndex = 168;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lnkOTNote
            // 
            this.lnkOTNote.AutoSize = true;
            this.lnkOTNote.BackColor = System.Drawing.Color.Gold;
            this.lnkOTNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOTNote.Location = new System.Drawing.Point(14, 16);
            this.lnkOTNote.Name = "lnkOTNote";
            this.lnkOTNote.Size = new System.Drawing.Size(89, 24);
            this.lnkOTNote.TabIndex = 138;
            this.lnkOTNote.TabStop = true;
            this.lnkOTNote.Text = "OT Note";
            this.lnkOTNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOTNote_LinkClicked);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Location = new System.Drawing.Point(390, 16);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(67, 28);
            this.btnrefresh.TabIndex = 56;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(476, 16);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(67, 28);
            this.btnclose.TabIndex = 58;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cmbdocbilltype
            // 
            this.cmbdocbilltype.FormattingEnabled = true;
            this.cmbdocbilltype.Location = new System.Drawing.Point(558, 237);
            this.cmbdocbilltype.Name = "cmbdocbilltype";
            this.cmbdocbilltype.Size = new System.Drawing.Size(119, 21);
            this.cmbdocbilltype.TabIndex = 149;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(273, 54);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(44, 20);
            this.txtQty.TabIndex = 136;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(12, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(413, 44);
            this.groupBox6.TabIndex = 159;
            this.groupBox6.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 131;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(487, 116);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(69, 15);
            this.lblage.TabIndex = 146;
            this.lblage.Text = "Patient Age";
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Enabled = false;
            this.txtadmissiondate.Location = new System.Drawing.Point(562, 144);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(215, 20);
            this.txtadmissiondate.TabIndex = 145;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(780, 464);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 144;
            this.label16.Text = "Total Taka";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(877, 463);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 143;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(804, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 142;
            this.label13.Text = "Ad. Reg. ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 148;
            this.label5.Text = "Patient Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 150;
            this.label10.Text = "Admission Date";
            // 
            // txtcabinNo
            // 
            this.txtcabinNo.Enabled = false;
            this.txtcabinNo.Location = new System.Drawing.Point(878, 144);
            this.txtcabinNo.Name = "txtcabinNo";
            this.txtcabinNo.Size = new System.Drawing.Size(98, 20);
            this.txtcabinNo.TabIndex = 137;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 78;
            this.label11.Text = "Qty";
            // 
            // btnDoctorSearch
            // 
            this.btnDoctorSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorSearch.Location = new System.Drawing.Point(435, 14);
            this.btnDoctorSearch.Name = "btnDoctorSearch";
            this.btnDoctorSearch.Size = new System.Drawing.Size(103, 27);
            this.btnDoctorSearch.TabIndex = 136;
            this.btnDoctorSearch.Text = "Doctor Search";
            this.btnDoctorSearch.UseVisualStyleBackColor = true;
            this.btnDoctorSearch.Click += new System.EventHandler(this.btnDoctorSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Chocolate;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkViolet;
            this.label14.Location = new System.Drawing.Point(651, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 22);
            this.label14.TabIndex = 140;
            this.label14.Text = "DOCTOR\'S LIST";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(488, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 25);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtpatientname
            // 
            this.txtpatientname.Enabled = false;
            this.txtpatientname.Location = new System.Drawing.Point(562, 82);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(215, 20);
            this.txtpatientname.TabIndex = 139;
            // 
            // txtpatientage
            // 
            this.txtpatientage.Enabled = false;
            this.txtpatientage.Location = new System.Drawing.Point(562, 113);
            this.txtpatientage.Name = "txtpatientage";
            this.txtpatientage.Size = new System.Drawing.Size(215, 20);
            this.txtpatientage.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = " Doctor Name";
            // 
            // txtadmissioncode
            // 
            this.txtadmissioncode.Enabled = false;
            this.txtadmissioncode.Location = new System.Drawing.Point(878, 112);
            this.txtadmissioncode.Name = "txtadmissioncode";
            this.txtadmissioncode.Size = new System.Drawing.Size(98, 20);
            this.txtadmissioncode.TabIndex = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(451, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 123);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-2, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1033, 30);
            this.label15.TabIndex = 141;
            this.label15.Text = "DOCTOR\'S BILL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Bill Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoctorSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCharge);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Location = new System.Drawing.Point(452, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 90);
            this.groupBox2.TabIndex = 155;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox7.Location = new System.Drawing.Point(435, 49);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(578, 509);
            this.groupBox7.TabIndex = 160;
            this.groupBox7.TabStop = false;
            // 
            // lnkOTMedicine
            // 
            this.lnkOTMedicine.AutoSize = true;
            this.lnkOTMedicine.BackColor = System.Drawing.Color.Gold;
            this.lnkOTMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOTMedicine.Location = new System.Drawing.Point(124, 16);
            this.lnkOTMedicine.Name = "lnkOTMedicine";
            this.lnkOTMedicine.Size = new System.Drawing.Size(131, 24);
            this.lnkOTMedicine.TabIndex = 169;
            this.lnkOTMedicine.TabStop = true;
            this.lnkOTMedicine.Text = "OT Medicine";
            this.lnkOTMedicine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOTMedicine_LinkClicked);
            // 
            // FrmOTForNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 570);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRefferedDoctors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpatientcode);
            this.Controls.Add(this.cmbdocbilltype);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtadmissiondate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcabinNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.txtpatientage);
            this.Controls.Add(this.txtadmissioncode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOTForNurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OT Nurse";
            this.Load += new System.EventHandler(this.FrmOTNurse_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader cabin_id;
        private System.Windows.Forms.ColumnHeader Patient_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader amissiondate;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grddoctorspayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn refered_doctors_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctors_bill_id;
        private System.Windows.Forms.ComboBox cmbRefferedDoctors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpatientcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbdocbilltype;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtadmissiondate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcabinNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDoctorSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.TextBox txtpatientage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtadmissioncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.LinkLabel lnkOTNote;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.LinkLabel lnkOTMedicine;
    }
}