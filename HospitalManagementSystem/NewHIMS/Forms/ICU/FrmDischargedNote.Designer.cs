namespace NewHIMS.Forms.ICU
{
    partial class FrmDischargedNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDischargedNote));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpatientcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadmissiondate = new System.Windows.Forms.TextBox();
            this.txtcabinNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txtpatientage = new System.Windows.Forms.TextBox();
            this.txtadmissioncode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.summaryID = new System.Windows.Forms.ColumnHeader();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnDischarged = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTypeRemarks = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDutyDoctorName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txthospital_medication = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtadvice = new System.Windows.Forms.TextBox();
            this.txtmedication = new System.Windows.Forms.TextBox();
            this.txtpresentstatus = new System.Windows.Forms.TextBox();
            this.txtchiefcomplain = new System.Windows.Forms.TextBox();
            this.cmbtreat = new System.Windows.Forms.ComboBox();
            this.txttreatment_procedure = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbtreatment = new System.Windows.Forms.ComboBox();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1003, 29);
            this.label7.TabIndex = 152;
            this.label7.Text = "Patient Discharged (ICU)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(789, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 196;
            this.label2.Text = "Cabin / Bed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 195;
            this.label1.Text = "Hospital ID";
            // 
            // txtpatientcode
            // 
            this.txtpatientcode.Location = new System.Drawing.Point(866, 54);
            this.txtpatientcode.Name = "txtpatientcode";
            this.txtpatientcode.Size = new System.Drawing.Size(98, 20);
            this.txtpatientcode.TabIndex = 194;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 193;
            this.label10.Text = "Admission Date";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(475, 90);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(69, 15);
            this.lblage.TabIndex = 190;
            this.lblage.Text = "Patient Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 192;
            this.label5.Text = "Patient Name";
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Location = new System.Drawing.Point(550, 120);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(215, 20);
            this.txtadmissiondate.TabIndex = 189;
            // 
            // txtcabinNo
            // 
            this.txtcabinNo.Location = new System.Drawing.Point(866, 120);
            this.txtcabinNo.Name = "txtcabinNo";
            this.txtcabinNo.Size = new System.Drawing.Size(98, 20);
            this.txtcabinNo.TabIndex = 185;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(791, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 188;
            this.label13.Text = "Ad. Reg. ID";
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(550, 55);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(215, 20);
            this.txtpatientname.TabIndex = 187;
            // 
            // txtpatientage
            // 
            this.txtpatientage.Location = new System.Drawing.Point(550, 88);
            this.txtpatientage.Name = "txtpatientage";
            this.txtpatientage.Size = new System.Drawing.Size(215, 20);
            this.txtpatientage.TabIndex = 186;
            // 
            // txtadmissioncode
            // 
            this.txtadmissioncode.Location = new System.Drawing.Point(866, 87);
            this.txtadmissioncode.Name = "txtadmissioncode";
            this.txtadmissioncode.Size = new System.Drawing.Size(98, 20);
            this.txtadmissioncode.TabIndex = 184;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(439, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 110);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvwPatientInfo);
            this.groupBox5.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.groupBox5.Location = new System.Drawing.Point(10, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 559);
            this.groupBox5.TabIndex = 183;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Patient Info";
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.age,
            this.summaryID});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(9, 16);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(405, 531);
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
            this.cabin.Width = 80;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 80;
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
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 220;
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
            // summaryID
            // 
            this.summaryID.Text = "summaryID";
            this.summaryID.Width = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnDischarged);
            this.groupBox11.Controls.Add(this.btnpreview);
            this.groupBox11.Controls.Add(this.btnRefresh);
            this.groupBox11.Controls.Add(this.btnClose);
            this.groupBox11.Controls.Add(this.btnSave);
            this.groupBox11.Location = new System.Drawing.Point(438, 543);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(550, 58);
            this.groupBox11.TabIndex = 180;
            this.groupBox11.TabStop = false;
            // 
            // btnDischarged
            // 
            this.btnDischarged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDischarged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDischarged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarged.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnDischarged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDischarged.Location = new System.Drawing.Point(125, 18);
            this.btnDischarged.Name = "btnDischarged";
            this.btnDischarged.Size = new System.Drawing.Size(97, 28);
            this.btnDischarged.TabIndex = 164;
            this.btnDischarged.Text = " Discharge";
            this.btnDischarged.UseVisualStyleBackColor = true;
            this.btnDischarged.Click += new System.EventHandler(this.btnDischarged_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreview.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnpreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpreview.Location = new System.Drawing.Point(24, 19);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(79, 28);
            this.btnpreview.TabIndex = 163;
            this.btnpreview.Text = "Preview";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(248, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 154;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(454, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 155;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(356, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 156;
            this.btnSave.Text = "  Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtTypeRemarks);
            this.groupBox3.Controls.Add(this.cmbType);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtDutyDoctorName);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txthospital_medication);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtadvice);
            this.groupBox3.Controls.Add(this.txtmedication);
            this.groupBox3.Controls.Add(this.txtpresentstatus);
            this.groupBox3.Controls.Add(this.txtchiefcomplain);
            this.groupBox3.Controls.Add(this.cmbtreat);
            this.groupBox3.Controls.Add(this.txttreatment_procedure);
            this.groupBox3.Location = new System.Drawing.Point(438, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 395);
            this.groupBox3.TabIndex = 182;
            this.groupBox3.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label23.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(17, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 16);
            this.label23.TabIndex = 145;
            this.label23.Text = "Type";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(216, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 16);
            this.label22.TabIndex = 144;
            this.label22.Text = "Remarks";
            // 
            // txtTypeRemarks
            // 
            this.txtTypeRemarks.Location = new System.Drawing.Point(286, 21);
            this.txtTypeRemarks.Name = "txtTypeRemarks";
            this.txtTypeRemarks.Size = new System.Drawing.Size(254, 20);
            this.txtTypeRemarks.TabIndex = 143;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "DA",
            "DOR",
            "ER"});
            this.cmbType.Location = new System.Drawing.Point(82, 19);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(92, 21);
            this.cmbType.TabIndex = 142;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.SkyBlue;
            this.label18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 18);
            this.label18.TabIndex = 141;
            this.label18.Text = "Duty Doctor Name";
            // 
            // txtDutyDoctorName
            // 
            this.txtDutyDoctorName.Location = new System.Drawing.Point(181, 342);
            this.txtDutyDoctorName.Multiline = true;
            this.txtDutyDoctorName.Name = "txtDutyDoctorName";
            this.txtDutyDoctorName.Size = new System.Drawing.Size(359, 40);
            this.txtDutyDoctorName.TabIndex = 140;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.SkyBlue;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(115, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 18);
            this.label17.TabIndex = 139;
            this.label17.Text = "Medication At hospital";
            this.label17.Visible = false;
            // 
            // txthospital_medication
            // 
            this.txthospital_medication.Location = new System.Drawing.Point(125, 109);
            this.txthospital_medication.Multiline = true;
            this.txthospital_medication.Name = "txthospital_medication";
            this.txthospital_medication.Size = new System.Drawing.Size(158, 34);
            this.txthospital_medication.TabIndex = 138;
            this.txthospital_medication.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SkyBlue;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 137;
            this.label11.Text = "Treatment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.SkyBlue;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 136;
            this.label12.Text = "Advice";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SkyBlue;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 18);
            this.label14.TabIndex = 135;
            this.label14.Text = "Medication";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SkyBlue;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(285, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 18);
            this.label15.TabIndex = 134;
            this.label15.Text = "Chief Complain/Present Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.SkyBlue;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 18);
            this.label16.TabIndex = 133;
            this.label16.Text = "Refered To";
            // 
            // txtadvice
            // 
            this.txtadvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvice.Location = new System.Drawing.Point(286, 145);
            this.txtadvice.Multiline = true;
            this.txtadvice.Name = "txtadvice";
            this.txtadvice.Size = new System.Drawing.Size(254, 85);
            this.txtadvice.TabIndex = 4;
            // 
            // txtmedication
            // 
            this.txtmedication.Location = new System.Drawing.Point(12, 145);
            this.txtmedication.Multiline = true;
            this.txtmedication.Name = "txtmedication";
            this.txtmedication.Size = new System.Drawing.Size(254, 85);
            this.txtmedication.TabIndex = 3;
            // 
            // txtpresentstatus
            // 
            this.txtpresentstatus.Location = new System.Drawing.Point(286, 78);
            this.txtpresentstatus.Multiline = true;
            this.txtpresentstatus.Name = "txtpresentstatus";
            this.txtpresentstatus.Size = new System.Drawing.Size(254, 32);
            this.txtpresentstatus.TabIndex = 2;
            // 
            // txtchiefcomplain
            // 
            this.txtchiefcomplain.Location = new System.Drawing.Point(12, 78);
            this.txtchiefcomplain.Multiline = true;
            this.txtchiefcomplain.Name = "txtchiefcomplain";
            this.txtchiefcomplain.Size = new System.Drawing.Size(254, 32);
            this.txtchiefcomplain.TabIndex = 1;
            // 
            // cmbtreat
            // 
            this.cmbtreat.FormattingEnabled = true;
            this.cmbtreat.Location = new System.Drawing.Point(155, 236);
            this.cmbtreat.Name = "cmbtreat";
            this.cmbtreat.Size = new System.Drawing.Size(236, 21);
            this.cmbtreat.TabIndex = 132;
            this.cmbtreat.SelectedIndexChanged += new System.EventHandler(this.cmbtreat_SelectedIndexChanged);
            // 
            // txttreatment_procedure
            // 
            this.txttreatment_procedure.Location = new System.Drawing.Point(12, 266);
            this.txttreatment_procedure.Multiline = true;
            this.txttreatment_procedure.Name = "txttreatment_procedure";
            this.txttreatment_procedure.Size = new System.Drawing.Size(528, 67);
            this.txttreatment_procedure.TabIndex = 131;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.cmbtreatment);
            this.groupBox2.Controls.Add(this.txtProcedure);
            this.groupBox2.Location = new System.Drawing.Point(438, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 353);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 137;
            this.label9.Text = "Operation Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 136;
            this.label8.Text = "Advice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 135;
            this.label6.Text = "Medication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 134;
            this.label4.Text = "Present Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 133;
            this.label3.Text = "Chief Complain ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(286, 133);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 71);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 133);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 71);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 66);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 66);
            this.textBox1.TabIndex = 1;
            // 
            // cmbtreatment
            // 
            this.cmbtreatment.FormattingEnabled = true;
            this.cmbtreatment.Location = new System.Drawing.Point(155, 222);
            this.cmbtreatment.Name = "cmbtreatment";
            this.cmbtreatment.Size = new System.Drawing.Size(236, 21);
            this.cmbtreatment.TabIndex = 132;
            // 
            // txtProcedure
            // 
            this.txtProcedure.Location = new System.Drawing.Point(12, 253);
            this.txtProcedure.Multiline = true;
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.Size = new System.Drawing.Size(528, 88);
            this.txtProcedure.TabIndex = 131;
            // 
            // FrmDischargedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(996, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpatientcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtadmissiondate);
            this.Controls.Add(this.txtcabinNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.txtpatientage);
            this.Controls.Add(this.txtadmissioncode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDischargedNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discharged Note";
            this.Load += new System.EventHandler(this.FrmDischargedNote_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpatientcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadmissiondate;
        private System.Windows.Forms.TextBox txtcabinNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.TextBox txtpatientage;
        private System.Windows.Forms.TextBox txtadmissioncode;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ColumnHeader summaryID;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTypeRemarks;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDutyDoctorName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txthospital_medication;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtadvice;
        private System.Windows.Forms.TextBox txtmedication;
        private System.Windows.Forms.TextBox txtpresentstatus;
        private System.Windows.Forms.TextBox txtchiefcomplain;
        private System.Windows.Forms.ComboBox cmbtreat;
        private System.Windows.Forms.TextBox txttreatment_procedure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbtreatment;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Button btnDischarged;
    }
}