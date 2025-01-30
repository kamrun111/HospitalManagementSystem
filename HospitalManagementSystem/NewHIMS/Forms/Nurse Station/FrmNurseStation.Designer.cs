namespace NewHIMS.Forms.Nurse_Station
{
    partial class FrmNurseStation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPatientDoctor = new System.Windows.Forms.Label();
            this.lblPatinetRegNo = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReferredDoctor = new System.Windows.Forms.Label();
            this.lblRegID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNewlyPrescribedFloor = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.grpTreatement = new System.Windows.Forms.GroupBox();
            this.grdTreatement = new System.Windows.Forms.DataGridView();
            this.t_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_submitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmitTreatement = new System.Windows.Forms.Button();
            this.grpMedicine = new System.Windows.Forms.GroupBox();
            this.lvwMedicine = new System.Windows.Forms.ListView();
            this.medicine = new System.Windows.Forms.ColumnHeader();
            this.dose_p_quantity = new System.Windows.Forms.ColumnHeader();
            this.intake_sys = new System.Windows.Forms.ColumnHeader();
            this.time_slots = new System.Windows.Forms.ColumnHeader();
            this.visit_medicine_id = new System.Windows.Forms.ColumnHeader();
            this.admission_id2 = new System.Windows.Forms.ColumnHeader();
            this.newID = new System.Windows.Forms.ColumnHeader();
            this.btnSubmitMedicine = new System.Windows.Forms.Button();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.hospital_id = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.is_first_reqular_checkup_done = new System.Windows.Forms.ColumnHeader();
            this.c_id = new System.Windows.Forms.ColumnHeader();
            this.patient_id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.grpRCContainer = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblPulse = new System.Windows.Forms.Label();
            this.mskBp = new System.Windows.Forms.MaskedTextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.lblBpUpper = new System.Windows.Forms.Label();
            this.lblRespitation = new System.Windows.Forms.Label();
            this.txtRespitation = new System.Windows.Forms.TextBox();
            this.lblStool = new System.Windows.Forms.Label();
            this.txtStool = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnSaveCC = new System.Windows.Forms.Button();
            this.lnkShowRC = new System.Windows.Forms.LinkLabel();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.lnkInOut = new System.Windows.Forms.LinkLabel();
            this.lnkIndentMedicine = new System.Windows.Forms.LinkLabel();
            this.lnkIndentInvestigation = new System.Windows.Forms.LinkLabel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tltToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpTreatement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTreatement)).BeginInit();
            this.grpMedicine.SuspendLayout();
            this.grpRCContainer.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblPatientDoctor);
            this.groupBox1.Controls.Add(this.lblPatinetRegNo);
            this.groupBox1.Controls.Add(this.lblPatientName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblReferredDoctor);
            this.groupBox1.Controls.Add(this.lblRegID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.grpTreatement);
            this.groupBox1.Controls.Add(this.grpMedicine);
            this.groupBox1.Controls.Add(this.cmbFloor);
            this.groupBox1.Controls.Add(this.lvwPatientInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grpRCContainer);
            this.groupBox1.Location = new System.Drawing.Point(11, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 488);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // lblPatientDoctor
            // 
            this.lblPatientDoctor.AutoSize = true;
            this.lblPatientDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientDoctor.Location = new System.Drawing.Point(444, 43);
            this.lblPatientDoctor.Name = "lblPatientDoctor";
            this.lblPatientDoctor.Size = new System.Drawing.Size(0, 15);
            this.lblPatientDoctor.TabIndex = 118;
            // 
            // lblPatinetRegNo
            // 
            this.lblPatinetRegNo.AutoSize = true;
            this.lblPatinetRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatinetRegNo.Location = new System.Drawing.Point(286, 43);
            this.lblPatinetRegNo.Name = "lblPatinetRegNo";
            this.lblPatinetRegNo.Size = new System.Drawing.Size(0, 15);
            this.lblPatinetRegNo.TabIndex = 117;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(288, 16);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 15);
            this.lblPatientName.TabIndex = 116;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(203, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 113;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblReferredDoctor
            // 
            this.lblReferredDoctor.AutoSize = true;
            this.lblReferredDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferredDoctor.Location = new System.Drawing.Point(373, 43);
            this.lblReferredDoctor.Name = "lblReferredDoctor";
            this.lblReferredDoctor.Size = new System.Drawing.Size(79, 15);
            this.lblReferredDoctor.TabIndex = 114;
            this.lblReferredDoctor.Text = "Consultant:";
            this.lblReferredDoctor.Visible = false;
            // 
            // lblRegID
            // 
            this.lblRegID.AutoSize = true;
            this.lblRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegID.Location = new System.Drawing.Point(203, 43);
            this.lblRegID.Name = "lblRegID";
            this.lblRegID.Size = new System.Drawing.Size(87, 15);
            this.lblRegID.TabIndex = 115;
            this.lblRegID.Text = "Adm.Reg.ID:";
            this.lblRegID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblNewlyPrescribedFloor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(191, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 5);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Newly Prescribed Patient";
            // 
            // lblNewlyPrescribedFloor
            // 
            this.lblNewlyPrescribedFloor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNewlyPrescribedFloor.Location = new System.Drawing.Point(10, 17);
            this.lblNewlyPrescribedFloor.Name = "lblNewlyPrescribedFloor";
            this.lblNewlyPrescribedFloor.Size = new System.Drawing.Size(284, 31);
            this.lblNewlyPrescribedFloor.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Teal;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(94, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 9);
            this.label15.TabIndex = 103;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Maroon;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 9);
            this.label13.TabIndex = 101;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Non-Received";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(103, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = "Received";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpTreatement
            // 
            this.grpTreatement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTreatement.Controls.Add(this.grdTreatement);
            this.grpTreatement.Controls.Add(this.btnSubmitTreatement);
            this.grpTreatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTreatement.Location = new System.Drawing.Point(191, 314);
            this.grpTreatement.Name = "grpTreatement";
            this.grpTreatement.Size = new System.Drawing.Size(540, 146);
            this.grpTreatement.TabIndex = 4;
            this.grpTreatement.TabStop = false;
            this.grpTreatement.Text = "Patient Treatement";
            // 
            // grdTreatement
            // 
            this.grdTreatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTreatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_type,
            this.treatement,
            this.dose,
            this.qty_submitted,
            this.qty,
            this.procedure,
            this.VTID});
            this.grdTreatement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdTreatement.Location = new System.Drawing.Point(9, 19);
            this.grdTreatement.Name = "grdTreatement";
            this.grdTreatement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdTreatement.Size = new System.Drawing.Size(518, 93);
            this.grdTreatement.TabIndex = 2;
            this.grdTreatement.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTreatement_RowHeaderMouseClick);
            this.grdTreatement.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTreatement_CellValueChanged);
            // 
            // t_type
            // 
            this.t_type.HeaderText = "T.Type";
            this.t_type.MaxInputLength = 10;
            this.t_type.Name = "t_type";
            this.t_type.ReadOnly = true;
            this.t_type.Width = 60;
            // 
            // treatement
            // 
            this.treatement.HeaderText = "Treatement";
            this.treatement.MaxInputLength = 100;
            this.treatement.Name = "treatement";
            this.treatement.ReadOnly = true;
            // 
            // dose
            // 
            this.dose.HeaderText = "Dose";
            this.dose.MaxInputLength = 20;
            this.dose.Name = "dose";
            this.dose.ReadOnly = true;
            this.dose.Visible = false;
            this.dose.Width = 5;
            // 
            // qty_submitted
            // 
            this.qty_submitted.HeaderText = "Submit";
            this.qty_submitted.Name = "qty_submitted";
            this.qty_submitted.ReadOnly = true;
            this.qty_submitted.Width = 50;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.MaxInputLength = 10;
            this.qty.Name = "qty";
            this.qty.Width = 80;
            // 
            // procedure
            // 
            this.procedure.HeaderText = "Procedure";
            this.procedure.MaxInputLength = 200;
            this.procedure.Name = "procedure";
            this.procedure.ReadOnly = true;
            this.procedure.Width = 230;
            // 
            // VTID
            // 
            this.VTID.HeaderText = "VTID";
            this.VTID.Name = "VTID";
            this.VTID.ReadOnly = true;
            this.VTID.Visible = false;
            // 
            // btnSubmitTreatement
            // 
            this.btnSubmitTreatement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitTreatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitTreatement.Enabled = false;
            this.btnSubmitTreatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTreatement.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSubmitTreatement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitTreatement.Location = new System.Drawing.Point(457, 118);
            this.btnSubmitTreatement.Name = "btnSubmitTreatement";
            this.btnSubmitTreatement.Size = new System.Drawing.Size(70, 24);
            this.btnSubmitTreatement.TabIndex = 1;
            this.btnSubmitTreatement.Text = "Submit";
            this.btnSubmitTreatement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmitTreatement.UseVisualStyleBackColor = true;
            this.btnSubmitTreatement.Click += new System.EventHandler(this.btnSubmitTreatement_Click);
            // 
            // grpMedicine
            // 
            this.grpMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMedicine.Controls.Add(this.lvwMedicine);
            this.grpMedicine.Controls.Add(this.btnSubmitMedicine);
            this.grpMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMedicine.Location = new System.Drawing.Point(191, 126);
            this.grpMedicine.Name = "grpMedicine";
            this.grpMedicine.Size = new System.Drawing.Size(540, 177);
            this.grpMedicine.TabIndex = 3;
            this.grpMedicine.TabStop = false;
            this.grpMedicine.Text = "Patient Medicine";
            // 
            // lvwMedicine
            // 
            this.lvwMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicine,
            this.dose_p_quantity,
            this.intake_sys,
            this.time_slots,
            this.visit_medicine_id,
            this.admission_id2,
            this.newID});
            this.lvwMedicine.FullRowSelect = true;
            this.lvwMedicine.GridLines = true;
            this.lvwMedicine.HideSelection = false;
            this.lvwMedicine.Location = new System.Drawing.Point(9, 17);
            this.lvwMedicine.MultiSelect = false;
            this.lvwMedicine.Name = "lvwMedicine";
            this.lvwMedicine.Size = new System.Drawing.Size(518, 129);
            this.lvwMedicine.TabIndex = 0;
            this.lvwMedicine.UseCompatibleStateImageBehavior = false;
            this.lvwMedicine.View = System.Windows.Forms.View.Details;
            this.lvwMedicine.Click += new System.EventHandler(this.lvwMedicine_Click);
            // 
            // medicine
            // 
            this.medicine.Name = "medicine";
            this.medicine.Tag = "";
            this.medicine.Text = "Medicine";
            this.medicine.Width = 215;
            // 
            // dose_p_quantity
            // 
            this.dose_p_quantity.Name = "dose_p_quantity";
            this.dose_p_quantity.Tag = "";
            this.dose_p_quantity.Text = "Qnty/Dose";
            this.dose_p_quantity.Width = 80;
            // 
            // intake_sys
            // 
            this.intake_sys.Name = "intake_sys";
            this.intake_sys.Tag = "";
            this.intake_sys.Text = "Intake Indication";
            this.intake_sys.Width = 115;
            // 
            // time_slots
            // 
            this.time_slots.Name = "time_slots";
            this.time_slots.Text = "Time";
            this.time_slots.Width = 80;
            // 
            // visit_medicine_id
            // 
            this.visit_medicine_id.Name = "visit_medicine_id";
            this.visit_medicine_id.Text = "ID";
            this.visit_medicine_id.Width = 0;
            // 
            // admission_id2
            // 
            this.admission_id2.Text = "ID";
            this.admission_id2.Width = 0;
            // 
            // newID
            // 
            this.newID.Text = "newID";
            this.newID.Width = 0;
            // 
            // btnSubmitMedicine
            // 
            this.btnSubmitMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitMedicine.Enabled = false;
            this.btnSubmitMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitMedicine.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSubmitMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitMedicine.Location = new System.Drawing.Point(457, 149);
            this.btnSubmitMedicine.Name = "btnSubmitMedicine";
            this.btnSubmitMedicine.Size = new System.Drawing.Size(70, 23);
            this.btnSubmitMedicine.TabIndex = 1;
            this.btnSubmitMedicine.Text = "Submit";
            this.btnSubmitMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmitMedicine.UseVisualStyleBackColor = true;
            this.btnSubmitMedicine.Click += new System.EventHandler(this.btnSubmitMedicine_Click);
            // 
            // cmbFloor
            // 
            this.cmbFloor.BackColor = System.Drawing.Color.Linen;
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(42, 23);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(143, 21);
            this.cmbFloor.Sorted = true;
            this.cmbFloor.TabIndex = 0;
            this.cmbFloor.Tag = "floor";
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            this.cmbFloor.Click += new System.EventHandler(this.cmbFloor_Click);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.hospital_id,
            this.status,
            this.admission_id,
            this.is_first_reqular_checkup_done,
            this.c_id,
            this.patient_id,
            this.name});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.PowderBlue;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(6, 82);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(179, 392);
            this.lvwPatientInfo.TabIndex = 1;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // cabin
            // 
            this.cabin.Text = "Cabin";
            this.cabin.Width = 55;
            // 
            // hospital_id
            // 
            this.hospital_id.Text = "Hospital ID";
            this.hospital_id.Width = 100;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 0;
            // 
            // admission_id
            // 
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // is_first_reqular_checkup_done
            // 
            this.is_first_reqular_checkup_done.Text = "Flag1";
            this.is_first_reqular_checkup_done.Width = 0;
            // 
            // c_id
            // 
            this.c_id.Text = "c_id";
            this.c_id.Width = 0;
            // 
            // patient_id
            // 
            this.patient_id.Text = "patient_id";
            this.patient_id.Width = 0;
            // 
            // name
            // 
            this.name.Text = "P.name";
            this.name.Width = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Floor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRCContainer
            // 
            this.grpRCContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRCContainer.Controls.Add(this.txtRemarks);
            this.grpRCContainer.Controls.Add(this.lblPulse);
            this.grpRCContainer.Controls.Add(this.mskBp);
            this.grpRCContainer.Controls.Add(this.lblTemperature);
            this.grpRCContainer.Controls.Add(this.txtTemperature);
            this.grpRCContainer.Controls.Add(this.txtPulse);
            this.grpRCContainer.Controls.Add(this.lblBpUpper);
            this.grpRCContainer.Controls.Add(this.lblRespitation);
            this.grpRCContainer.Controls.Add(this.txtRespitation);
            this.grpRCContainer.Controls.Add(this.lblStool);
            this.grpRCContainer.Controls.Add(this.txtStool);
            this.grpRCContainer.Controls.Add(this.lblWeight);
            this.grpRCContainer.Controls.Add(this.txtWeight);
            this.grpRCContainer.Controls.Add(this.btnSaveCC);
            this.grpRCContainer.Controls.Add(this.lnkShowRC);
            this.grpRCContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRCContainer.Location = new System.Drawing.Point(191, 64);
            this.grpRCContainer.Name = "grpRCContainer";
            this.grpRCContainer.Size = new System.Drawing.Size(540, 60);
            this.grpRCContainer.TabIndex = 2;
            this.grpRCContainer.TabStop = false;
            this.grpRCContainer.Text = "Remarks";
            this.grpRCContainer.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(9, 18);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(442, 33);
            this.txtRemarks.TabIndex = 43;
            // 
            // lblPulse
            // 
            this.lblPulse.AutoSize = true;
            this.lblPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPulse.Location = new System.Drawing.Point(58, 16);
            this.lblPulse.Name = "lblPulse";
            this.lblPulse.Size = new System.Drawing.Size(42, 13);
            this.lblPulse.TabIndex = 37;
            this.lblPulse.Text = "Pulse:";
            this.lblPulse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mskBp
            // 
            this.mskBp.Location = new System.Drawing.Point(105, 31);
            this.mskBp.Mask = "000/00";
            this.mskBp.Name = "mskBp";
            this.mskBp.PromptChar = '.';
            this.mskBp.Size = new System.Drawing.Size(51, 20);
            this.mskBp.TabIndex = 2;
            this.mskBp.Tag = "bp";
            this.mskBp.Text = "12080";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(6, 16);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(57, 13);
            this.lblTemperature.TabIndex = 36;
            this.lblTemperature.Text = "Temp(F):";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(9, 31);
            this.txtTemperature.MaxLength = 3;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(50, 20);
            this.txtTemperature.TabIndex = 0;
            this.txtTemperature.Tag = "temperature";
            // 
            // txtPulse
            // 
            this.txtPulse.Location = new System.Drawing.Point(61, 31);
            this.txtPulse.MaxLength = 3;
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(42, 20);
            this.txtPulse.TabIndex = 1;
            this.txtPulse.Tag = "pulse";
            // 
            // lblBpUpper
            // 
            this.lblBpUpper.AutoSize = true;
            this.lblBpUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpUpper.Location = new System.Drawing.Point(101, 16);
            this.lblBpUpper.Name = "lblBpUpper";
            this.lblBpUpper.Size = new System.Drawing.Size(27, 13);
            this.lblBpUpper.TabIndex = 38;
            this.lblBpUpper.Text = "BP:";
            this.lblBpUpper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRespitation
            // 
            this.lblRespitation.AutoSize = true;
            this.lblRespitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespitation.Location = new System.Drawing.Point(155, 16);
            this.lblRespitation.Name = "lblRespitation";
            this.lblRespitation.Size = new System.Drawing.Size(44, 13);
            this.lblRespitation.TabIndex = 40;
            this.lblRespitation.Text = "Resp.:";
            this.lblRespitation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRespitation
            // 
            this.txtRespitation.Location = new System.Drawing.Point(158, 31);
            this.txtRespitation.Name = "txtRespitation";
            this.txtRespitation.Size = new System.Drawing.Size(42, 20);
            this.txtRespitation.TabIndex = 3;
            this.txtRespitation.Tag = "respitation";
            this.txtRespitation.Text = "00";
            // 
            // lblStool
            // 
            this.lblStool.AutoSize = true;
            this.lblStool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStool.Location = new System.Drawing.Point(199, 16);
            this.lblStool.Name = "lblStool";
            this.lblStool.Size = new System.Drawing.Size(40, 13);
            this.lblStool.TabIndex = 41;
            this.lblStool.Text = "Stool:";
            this.lblStool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStool
            // 
            this.txtStool.Location = new System.Drawing.Point(202, 31);
            this.txtStool.Name = "txtStool";
            this.txtStool.Size = new System.Drawing.Size(42, 20);
            this.txtStool.TabIndex = 4;
            this.txtStool.Tag = "stool";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(243, 16);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(51, 13);
            this.lblWeight.TabIndex = 42;
            this.lblWeight.Text = "Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(246, 31);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(58, 20);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.Tag = "weight";
            // 
            // btnSaveCC
            // 
            this.btnSaveCC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCC.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSaveCC.Location = new System.Drawing.Point(473, 18);
            this.btnSaveCC.Name = "btnSaveCC";
            this.btnSaveCC.Size = new System.Drawing.Size(53, 35);
            this.btnSaveCC.TabIndex = 6;
            this.btnSaveCC.UseVisualStyleBackColor = true;
            this.btnSaveCC.Click += new System.EventHandler(this.btnSaveCC_Click);
            // 
            // lnkShowRC
            // 
            this.lnkShowRC.AutoSize = true;
            this.lnkShowRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowRC.Location = new System.Drawing.Point(490, 38);
            this.lnkShowRC.Name = "lnkShowRC";
            this.lnkShowRC.Size = new System.Drawing.Size(23, 13);
            this.lnkShowRC.TabIndex = 7;
            this.lnkShowRC.TabStop = true;
            this.lnkShowRC.Text = "List";
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.linkLabel1);
            this.grpMenu.Controls.Add(this.lblClock);
            this.grpMenu.Controls.Add(this.lnkClose);
            this.grpMenu.Controls.Add(this.lnkInOut);
            this.grpMenu.Controls.Add(this.lnkIndentMedicine);
            this.grpMenu.Controls.Add(this.lnkIndentInvestigation);
            this.grpMenu.Enabled = false;
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(11, 11);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(739, 63);
            this.grpMenu.TabIndex = 57;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(390, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 18);
            this.linkLabel1.TabIndex = 58;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Medcine details";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(521, 31);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(210, 22);
            this.lblClock.TabIndex = 59;
            this.lblClock.Text = "00/00/0000 00:00:00  am";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.Location = new System.Drawing.Point(698, 13);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(38, 13);
            this.lnkClose.TabIndex = 57;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Close";
            this.lnkClose.Visible = false;
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // lnkInOut
            // 
            this.lnkInOut.AutoSize = true;
            this.lnkInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkInOut.Location = new System.Drawing.Point(281, 32);
            this.lnkInOut.Name = "lnkInOut";
            this.lnkInOut.Size = new System.Drawing.Size(109, 18);
            this.lnkInOut.TabIndex = 56;
            this.lnkInOut.TabStop = true;
            this.lnkInOut.Text = "Intake-Output";
            this.lnkInOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInOut_LinkClicked);
            // 
            // lnkIndentMedicine
            // 
            this.lnkIndentMedicine.AutoSize = true;
            this.lnkIndentMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIndentMedicine.Location = new System.Drawing.Point(6, 32);
            this.lnkIndentMedicine.Name = "lnkIndentMedicine";
            this.lnkIndentMedicine.Size = new System.Drawing.Size(121, 18);
            this.lnkIndentMedicine.TabIndex = 55;
            this.lnkIndentMedicine.TabStop = true;
            this.lnkIndentMedicine.Text = "Medcine Indent";
            this.lnkIndentMedicine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIndentMedicine_LinkClicked);
            // 
            // lnkIndentInvestigation
            // 
            this.lnkIndentInvestigation.AutoSize = true;
            this.lnkIndentInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIndentInvestigation.Location = new System.Drawing.Point(129, 32);
            this.lnkIndentInvestigation.Name = "lnkIndentInvestigation";
            this.lnkIndentInvestigation.Size = new System.Drawing.Size(152, 18);
            this.lnkIndentInvestigation.TabIndex = 54;
            this.lnkIndentInvestigation.TabStop = true;
            this.lnkIndentInvestigation.Text = "Investigation Indent";
            this.lnkIndentInvestigation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIndentInvestigation_LinkClicked);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // FrmNurseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNurseStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse Station";
            this.Load += new System.EventHandler(this.FrmNurseStation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpTreatement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTreatement)).EndInit();
            this.grpMedicine.ResumeLayout(false);
            this.grpRCContainer.ResumeLayout(false);
            this.grpRCContainer.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpTreatement;
        private System.Windows.Forms.Button btnSubmitTreatement;
        private System.Windows.Forms.GroupBox grpMedicine;
        private System.Windows.Forms.ListView lvwMedicine;
        private System.Windows.Forms.ColumnHeader medicine;
        private System.Windows.Forms.ColumnHeader dose_p_quantity;
        private System.Windows.Forms.ColumnHeader intake_sys;
        private System.Windows.Forms.ColumnHeader time_slots;
        private System.Windows.Forms.ColumnHeader visit_medicine_id;
        private System.Windows.Forms.ColumnHeader admission_id2;
        private System.Windows.Forms.Button btnSubmitMedicine;
        private System.Windows.Forms.GroupBox grpRCContainer;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblPulse;
        private System.Windows.Forms.MaskedTextBox mskBp;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtPulse;
        private System.Windows.Forms.Label lblBpUpper;
        private System.Windows.Forms.Label lblRespitation;
        private System.Windows.Forms.TextBox txtRespitation;
        private System.Windows.Forms.Label lblStool;
        private System.Windows.Forms.TextBox txtStool;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnSaveCC;
        private System.Windows.Forms.LinkLabel lnkShowRC;
        private System.Windows.Forms.ComboBox cmbFloor;
        public System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader hospital_id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader is_first_reqular_checkup_done;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.LinkLabel lnkInOut;
        private System.Windows.Forms.LinkLabel lnkIndentMedicine;
        private System.Windows.Forms.LinkLabel lnkIndentInvestigation;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ToolTip tltToolTip;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblNewlyPrescribedFloor;
        private System.Windows.Forms.ColumnHeader newID;
        private System.Windows.Forms.ColumnHeader c_id;
        private System.Windows.Forms.ColumnHeader patient_id;
        private System.Windows.Forms.DataGridView grdTreatement;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_submitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label lblPatientDoctor;
        private System.Windows.Forms.Label lblPatinetRegNo;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReferredDoctor;
        private System.Windows.Forms.Label lblRegID;
    }
}