namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    partial class FrmDoctorsPayment
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
            this.lblage = new System.Windows.Forms.Label();
            this.txtadmissiondate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txtpatientage = new System.Windows.Forms.TextBox();
            this.txtcabinNo = new System.Windows.Forms.TextBox();
            this.txtadmissioncode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.grddoctorspayment = new System.Windows.Forms.DataGridView();
            this.refered_doctors_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctors_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbdocbilltype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpatientcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRefferedDoctors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoctorSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(505, 122);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(69, 15);
            this.lblage.TabIndex = 69;
            this.lblage.Text = "Patient Age";
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Enabled = false;
            this.txtadmissiondate.Location = new System.Drawing.Point(580, 147);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(215, 20);
            this.txtadmissiondate.TabIndex = 68;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(798, 495);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 67;
            this.label16.Text = "Total Taka";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(895, 494);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(822, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 65;
            this.label13.Text = "Ad. Reg. ID";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-6, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1058, 30);
            this.label15.TabIndex = 64;
            this.label15.Text = "DOCTOR\'S BILL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Chocolate;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkViolet;
            this.label14.Location = new System.Drawing.Point(669, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 22);
            this.label14.TabIndex = 63;
            this.label14.Text = "DOCTOR\'S BILL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = " Doctor Name";
            // 
            // txtpatientname
            // 
            this.txtpatientname.Enabled = false;
            this.txtpatientname.Location = new System.Drawing.Point(580, 91);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(215, 20);
            this.txtpatientname.TabIndex = 49;
            // 
            // txtpatientage
            // 
            this.txtpatientage.Enabled = false;
            this.txtpatientage.Location = new System.Drawing.Point(580, 119);
            this.txtpatientage.Name = "txtpatientage";
            this.txtpatientage.Size = new System.Drawing.Size(215, 20);
            this.txtpatientage.TabIndex = 47;
            // 
            // txtcabinNo
            // 
            this.txtcabinNo.Enabled = false;
            this.txtcabinNo.Location = new System.Drawing.Point(896, 147);
            this.txtcabinNo.Name = "txtcabinNo";
            this.txtcabinNo.Size = new System.Drawing.Size(98, 20);
            this.txtcabinNo.TabIndex = 46;
            // 
            // txtadmissioncode
            // 
            this.txtadmissioncode.Enabled = false;
            this.txtadmissioncode.Location = new System.Drawing.Point(896, 118);
            this.txtadmissioncode.Name = "txtadmissioncode";
            this.txtadmissioncode.Size = new System.Drawing.Size(98, 20);
            this.txtadmissioncode.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(469, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 123);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 74;
            this.label10.Text = "Admission Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Patient Name";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Location = new System.Drawing.Point(360, 16);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(83, 28);
            this.btnrefresh.TabIndex = 56;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(450, 16);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 28);
            this.btnclose.TabIndex = 58;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            this.grddoctorspayment.Location = new System.Drawing.Point(6, 11);
            this.grddoctorspayment.Name = "grddoctorspayment";
            this.grddoctorspayment.Size = new System.Drawing.Size(538, 164);
            this.grddoctorspayment.TabIndex = 55;
            this.grddoctorspayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellClick);
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
            // cmbdocbilltype
            // 
            this.cmbdocbilltype.FormattingEnabled = true;
            this.cmbdocbilltype.Location = new System.Drawing.Point(576, 238);
            this.cmbdocbilltype.Name = "cmbdocbilltype";
            this.cmbdocbilltype.Size = new System.Drawing.Size(119, 21);
            this.cmbdocbilltype.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Hospital ID";
            // 
            // txtpatientcode
            // 
            this.txtpatientcode.Enabled = false;
            this.txtpatientcode.Location = new System.Drawing.Point(896, 88);
            this.txtpatientcode.Name = "txtpatientcode";
            this.txtpatientcode.Size = new System.Drawing.Size(98, 20);
            this.txtpatientcode.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cabin No";
            // 
            // cmbRefferedDoctors
            // 
            this.cmbRefferedDoctors.Enabled = false;
            this.cmbRefferedDoctors.FormattingEnabled = true;
            this.cmbRefferedDoctors.Location = new System.Drawing.Point(576, 203);
            this.cmbRefferedDoctors.Name = "cmbRefferedDoctors";
            this.cmbRefferedDoctors.Size = new System.Drawing.Size(310, 21);
            this.cmbRefferedDoctors.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 55);
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
            this.groupBox2.Location = new System.Drawing.Point(470, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 90);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Charge";
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(390, 55);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(78, 20);
            this.txtCharge.TabIndex = 137;
            this.txtCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharge_KeyPress);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(273, 54);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(44, 20);
            this.txtQty.TabIndex = 136;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharge_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grddoctorspayment);
            this.groupBox3.Location = new System.Drawing.Point(16, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 213);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnrefresh);
            this.groupBox4.Controls.Add(this.btnclose);
            this.groupBox4.Location = new System.Drawing.Point(22, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 50);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 131;
            this.label4.Text = "Cabin No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvwPatientInfo);
            this.groupBox5.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.groupBox5.Location = new System.Drawing.Point(16, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 502);
            this.groupBox5.TabIndex = 133;
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
            this.lvwPatientInfo.Location = new System.Drawing.Point(8, 22);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(400, 469);
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
            this.cabin.Width = 83;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(19, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(413, 44);
            this.groupBox6.TabIndex = 134;
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDelete);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox7.Location = new System.Drawing.Point(453, 43);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(578, 547);
            this.groupBox7.TabIndex = 135;
            this.groupBox7.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(488, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 25);
            this.btnDelete.TabIndex = 138;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDoctorsPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1044, 611);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.cmbRefferedDoctors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpatientcode);
            this.Controls.Add(this.cmbdocbilltype);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtadmissiondate);
            this.Controls.Add(this.txtcabinNo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.txtpatientage);
            this.Controls.Add(this.txtadmissioncode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoctorsPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors Payment Details";
            this.Load += new System.EventHandler(this.FrmDoctorsPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtadmissiondate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.TextBox txtpatientage;
        private System.Windows.Forms.TextBox txtcabinNo;
        private System.Windows.Forms.TextBox txtadmissioncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView grddoctorspayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbdocbilltype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpatientcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRefferedDoctors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox7;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn refered_doctors_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctors_bill_id;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDoctorSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}