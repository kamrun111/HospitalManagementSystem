namespace NewHIMS.Forms.Accounts
{
    partial class FrmDiscountDistribution
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
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.admissiondate = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.pdiscount = new System.Windows.Forms.ColumnHeader();
            this.discount_date = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdischargedate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadmission_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadmissiondate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpatient_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtservicecharge = new System.Windows.Forms.TextBox();
            this.txtroomrent = new System.Windows.Forms.TextBox();
            this.txtcabin_service_charge = new System.Windows.Forms.TextBox();
            this.txtcabin_charge = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdiscountbalance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grddoctorbill = new System.Windows.Forms.DataGridView();
            this.doctors_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdotheritem = new System.Windows.Forms.DataGridView();
            this.patient_other_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdinvestigation = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchHospitalID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Investigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdotheritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdinvestigation)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1165, 32);
            this.label7.TabIndex = 111;
            this.label7.Text = "Discount Distribution";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admission_id,
            this.patient_code,
            this.patient_name,
            this.admission_code,
            this.admissiondate,
            this.age,
            this.pdiscount,
            this.discount_date});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(18, 96);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(297, 459);
            this.lvwPatientInfo.TabIndex = 112;
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
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 75;
            // 
            // patient_name
            // 
            this.patient_name.Text = "P. Name";
            this.patient_name.Width = 198;
            // 
            // admission_code
            // 
            this.admission_code.Text = "admission_code";
            this.admission_code.Width = 0;
            // 
            // admissiondate
            // 
            this.admissiondate.Text = "admissiondate";
            this.admissiondate.Width = 0;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 0;
            // 
            // pdiscount
            // 
            this.pdiscount.Text = "pdiscount";
            this.pdiscount.Width = 0;
            // 
            // discount_date
            // 
            this.discount_date.Text = "discount_date";
            this.discount_date.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 484);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtdiscount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdischargedate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtadmission_code);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtadmissiondate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtpatient_code);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Location = new System.Drawing.Point(327, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 135);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 133;
            this.label6.Text = "Total Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(602, 92);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(178, 22);
            this.txtdiscount.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 131;
            this.label5.Text = "Discharged Date";
            // 
            // txtdischargedate
            // 
            this.txtdischargedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdischargedate.Location = new System.Drawing.Point(602, 57);
            this.txtdischargedate.Name = "txtdischargedate";
            this.txtdischargedate.Size = new System.Drawing.Size(178, 22);
            this.txtdischargedate.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 129;
            this.label3.Text = "Ad. Reg. ID";
            // 
            // txtadmission_code
            // 
            this.txtadmission_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission_code.Location = new System.Drawing.Point(172, 96);
            this.txtadmission_code.Name = "txtadmission_code";
            this.txtadmission_code.Size = new System.Drawing.Size(244, 22);
            this.txtadmission_code.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 127;
            this.label2.Text = "Admission Date";
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmissiondate.Location = new System.Drawing.Point(602, 23);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(178, 22);
            this.txtadmissiondate.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "Hospital ID";
            // 
            // txtpatient_code
            // 
            this.txtpatient_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatient_code.Location = new System.Drawing.Point(170, 64);
            this.txtpatient_code.Name = "txtpatient_code";
            this.txtpatient_code.Size = new System.Drawing.Size(246, 22);
            this.txtpatient_code.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(170, 26);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(246, 22);
            this.txtPatientName.TabIndex = 122;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtservicecharge);
            this.groupBox3.Controls.Add(this.txtroomrent);
            this.groupBox3.Controls.Add(this.txtcabin_service_charge);
            this.groupBox3.Controls.Add(this.txtcabin_charge);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtdiscountbalance);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtGrandTotal);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.grddoctorbill);
            this.groupBox3.Controls.Add(this.grdotheritem);
            this.groupBox3.Controls.Add(this.grdinvestigation);
            this.groupBox3.Location = new System.Drawing.Point(327, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(811, 317);
            this.groupBox3.TabIndex = 115;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(592, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 18);
            this.label12.TabIndex = 154;
            this.label12.Text = "Discount Balance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(309, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 16);
            this.label17.TabIndex = 153;
            this.label17.Text = "Discount :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(268, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 16);
            this.label18.TabIndex = 152;
            this.label18.Text = "Service Charge :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(45, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 151;
            this.label16.Text = "Discount :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 18);
            this.label15.TabIndex = 150;
            this.label15.Text = "Cabin Service Charge";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(60, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 18);
            this.label14.TabIndex = 149;
            this.label14.Text = "Cabin Charge";
            // 
            // txtservicecharge
            // 
            this.txtservicecharge.Enabled = false;
            this.txtservicecharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservicecharge.ForeColor = System.Drawing.Color.Brown;
            this.txtservicecharge.Location = new System.Drawing.Point(380, 238);
            this.txtservicecharge.MaxLength = 7;
            this.txtservicecharge.Name = "txtservicecharge";
            this.txtservicecharge.ReadOnly = true;
            this.txtservicecharge.Size = new System.Drawing.Size(113, 20);
            this.txtservicecharge.TabIndex = 148;
            this.txtservicecharge.Tag = "purchase";
            // 
            // txtroomrent
            // 
            this.txtroomrent.Enabled = false;
            this.txtroomrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomrent.ForeColor = System.Drawing.Color.Brown;
            this.txtroomrent.Location = new System.Drawing.Point(116, 238);
            this.txtroomrent.MaxLength = 7;
            this.txtroomrent.Name = "txtroomrent";
            this.txtroomrent.ReadOnly = true;
            this.txtroomrent.Size = new System.Drawing.Size(113, 20);
            this.txtroomrent.TabIndex = 147;
            this.txtroomrent.Tag = "purchase";
            // 
            // txtcabin_service_charge
            // 
            this.txtcabin_service_charge.Location = new System.Drawing.Point(380, 278);
            this.txtcabin_service_charge.Name = "txtcabin_service_charge";
            this.txtcabin_service_charge.Size = new System.Drawing.Size(113, 20);
            this.txtcabin_service_charge.TabIndex = 146;
            this.txtcabin_service_charge.Leave += new System.EventHandler(this.txtcabin_charge_Leave);
            this.txtcabin_service_charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcabin_charge_KeyPress);
            // 
            // txtcabin_charge
            // 
            this.txtcabin_charge.Location = new System.Drawing.Point(116, 278);
            this.txtcabin_charge.Name = "txtcabin_charge";
            this.txtcabin_charge.Size = new System.Drawing.Size(113, 20);
            this.txtcabin_charge.TabIndex = 145;
            this.txtcabin_charge.Leave += new System.EventHandler(this.txtcabin_charge_Leave);
            this.txtcabin_charge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcabin_charge_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(15, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 144;
            this.label13.Text = "Cabin Charge :";
            // 
            // txtdiscountbalance
            // 
            this.txtdiscountbalance.Enabled = false;
            this.txtdiscountbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscountbalance.ForeColor = System.Drawing.Color.Brown;
            this.txtdiscountbalance.Location = new System.Drawing.Point(679, 278);
            this.txtdiscountbalance.MaxLength = 7;
            this.txtdiscountbalance.Multiline = true;
            this.txtdiscountbalance.Name = "txtdiscountbalance";
            this.txtdiscountbalance.ReadOnly = true;
            this.txtdiscountbalance.Size = new System.Drawing.Size(121, 20);
            this.txtdiscountbalance.TabIndex = 140;
            this.txtdiscountbalance.Tag = "purchase";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(544, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 16);
            this.label11.TabIndex = 139;
            this.label11.Text = "Discount Balance";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.Brown;
            this.txtGrandTotal.Location = new System.Drawing.Point(679, 239);
            this.txtGrandTotal.MaxLength = 7;
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(121, 21);
            this.txtGrandTotal.TabIndex = 138;
            this.txtGrandTotal.Tag = "purchase";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(562, 242);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(112, 16);
            this.lblCount.TabIndex = 137;
            this.lblCount.Text = "Total Discount.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(575, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 18);
            this.label10.TabIndex = 136;
            this.label10.Text = "Doctor\'s Bill";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 18);
            this.label9.TabIndex = 135;
            this.label9.Text = "Other Service";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 134;
            this.label8.Text = "Investigation";
            // 
            // grddoctorbill
            // 
            this.grddoctorbill.AllowUserToAddRows = false;
            this.grddoctorbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddoctorbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctors_bill_id,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.grddoctorbill.Location = new System.Drawing.Point(508, 39);
            this.grddoctorbill.Name = "grddoctorbill";
            this.grddoctorbill.Size = new System.Drawing.Size(295, 164);
            this.grddoctorbill.TabIndex = 2;
            this.grddoctorbill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorbill_CellValueChanged);
            // 
            // doctors_bill_id
            // 
            this.doctors_bill_id.HeaderText = "doctors_bill_id";
            this.doctors_bill_id.Name = "doctors_bill_id";
            this.doctors_bill_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // grdotheritem
            // 
            this.grdotheritem.AllowUserToAddRows = false;
            this.grdotheritem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdotheritem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_other_item_id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.grdotheritem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdotheritem.Location = new System.Drawing.Point(254, 39);
            this.grdotheritem.Name = "grdotheritem";
            this.grdotheritem.Size = new System.Drawing.Size(244, 164);
            this.grdotheritem.TabIndex = 1;
            this.grdotheritem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdotheritem_CellValueChanged);
            // 
            // patient_other_item_id
            // 
            this.patient_other_item_id.HeaderText = "patient_other_item_id";
            this.patient_other_item_id.Name = "patient_other_item_id";
            this.patient_other_item_id.Visible = false;
            this.patient_other_item_id.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // grdinvestigation
            // 
            this.grdinvestigation.AllowUserToAddRows = false;
            this.grdinvestigation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdinvestigation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department_id,
            this.Investigation,
            this.T_Amount,
            this.Discount});
            this.grdinvestigation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdinvestigation.Location = new System.Drawing.Point(9, 39);
            this.grdinvestigation.Name = "grdinvestigation";
            this.grdinvestigation.Size = new System.Drawing.Size(234, 164);
            this.grdinvestigation.TabIndex = 0;
            this.grdinvestigation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdinvestigation_CellValueChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(883, 525);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(79, 28);
            this.btnrefresh.TabIndex = 139;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(968, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 137;
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
            this.btnClose.Location = new System.Drawing.Point(1053, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 138;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(328, 503);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 58);
            this.groupBox4.TabIndex = 140;
            this.groupBox4.TabStop = false;
            // 
            // textBoxSearchHospitalID
            // 
            this.textBoxSearchHospitalID.Location = new System.Drawing.Point(138, 51);
            this.textBoxSearchHospitalID.Name = "textBoxSearchHospitalID";
            this.textBoxSearchHospitalID.Size = new System.Drawing.Size(117, 20);
            this.textBoxSearchHospitalID.TabIndex = 142;
            this.textBoxSearchHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchHospitalID_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(39, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 16);
            this.label19.TabIndex = 141;
            this.label19.Text = "Hospital ID :";
            // 
            // department_id
            // 
            this.department_id.HeaderText = "department_id";
            this.department_id.Name = "department_id";
            this.department_id.Visible = false;
            // 
            // Investigation
            // 
            this.Investigation.HeaderText = "Investigation";
            this.Investigation.Name = "Investigation";
            this.Investigation.Width = 70;
            // 
            // T_Amount
            // 
            this.T_Amount.HeaderText = "Amount";
            this.T_Amount.Name = "T_Amount";
            this.T_Amount.Width = 50;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Width = 60;
            // 
            // FrmDiscountDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1150, 573);
            this.Controls.Add(this.textBoxSearchHospitalID);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvwPatientInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiscountDistribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount  Distribution";
            this.Load += new System.EventHandler(this.FrmDiscountDistribution_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdotheritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdinvestigation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpatient_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdischargedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadmission_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadmissiondate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdinvestigation;
        private System.Windows.Forms.DataGridView grdotheritem;
        private System.Windows.Forms.DataGridView grddoctorbill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader admissiondate;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader pdiscount;
        private System.Windows.Forms.ColumnHeader discount_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctors_bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_other_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtdiscountbalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcabin_service_charge;
        private System.Windows.Forms.TextBox txtcabin_charge;
        private System.Windows.Forms.TextBox txtservicecharge;
        private System.Windows.Forms.TextBox txtroomrent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSearchHospitalID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Investigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}