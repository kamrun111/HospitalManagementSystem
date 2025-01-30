namespace NewHIMS.Forms.Outdoor
{
    partial class frmOutdoorPatient
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
            this.dtpNextVisitedDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnPrintSampleCollected = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDDay = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbNight = new System.Windows.Forms.ComboBox();
            this.cmbEvening = new System.Windows.Forms.ComboBox();
            this.cmbNoon = new System.Windows.Forms.ComboBox();
            this.cmbMorn = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbIntakeMethod = new System.Windows.Forms.ComboBox();
            this.txtDoseQty = new System.Windows.Forms.TextBox();
            this.lvwMedication = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.btnAddMedication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMedicineName = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvwAdvice = new System.Windows.Forms.ListView();
            this.advice = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.grpInvestigation = new System.Windows.Forms.GroupBox();
            this.lvwInvestigation = new System.Windows.Forms.ListView();
            this.btnAddInvestigation = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbResults = new System.Windows.Forms.ComboBox();
            this.lblDepartemt = new System.Windows.Forms.Label();
            this.cmbTestItems = new System.Windows.Forms.ComboBox();
            this.btnAddAdvice = new System.Windows.Forms.Button();
            this.cmbAdvice = new System.Windows.Forms.ComboBox();
            this.grpAdvice = new System.Windows.Forms.GroupBox();
            this.VisitedDate = new System.Windows.Forms.ColumnHeader();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrimaryDiagonosis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwVisitedDate = new System.Windows.Forms.ListView();
            this.ConsultantName = new System.Windows.Forms.ColumnHeader();
            this.BookingID = new System.Windows.Forms.ColumnHeader();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.txtBP = new System.Windows.Forms.MaskedTextBox();
            this.cmbConsullantlist = new System.Windows.Forms.ComboBox();
            this.lvwHospitalID = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpOPDPatient = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookingSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.lblRequisitionNo = new System.Windows.Forms.Label();
            this.lblRequisitionTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpInvestigation.SuspendLayout();
            this.grpAdvice.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.grpOPDPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNextVisitedDate
            // 
            this.dtpNextVisitedDate.CustomFormat = "dd-mm-yyyy";
            this.dtpNextVisitedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextVisitedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextVisitedDate.Location = new System.Drawing.Point(11, 21);
            this.dtpNextVisitedDate.Name = "dtpNextVisitedDate";
            this.dtpNextVisitedDate.Size = new System.Drawing.Size(114, 22);
            this.dtpNextVisitedDate.TabIndex = 26;
            this.dtpNextVisitedDate.Leave += new System.EventHandler(this.dtpNextVisitedDate_Leave);
            this.dtpNextVisitedDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNextVisitedDate_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNextVisitedDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 55);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Next Visited Date";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Noon";
            this.columnHeader9.Width = 65;
            // 
            // btnPrintSampleCollected
            // 
            this.btnPrintSampleCollected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintSampleCollected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSampleCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSampleCollected.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrintSampleCollected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSampleCollected.Location = new System.Drawing.Point(564, 563);
            this.btnPrintSampleCollected.Name = "btnPrintSampleCollected";
            this.btnPrintSampleCollected.Size = new System.Drawing.Size(86, 28);
            this.btnPrintSampleCollected.TabIndex = 30;
            this.btnPrintSampleCollected.Text = "Print";
            this.btnPrintSampleCollected.UseVisualStyleBackColor = true;
            this.btnPrintSampleCollected.Click += new System.EventHandler(this.btnPrintSampleCollected_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Intake Method";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDDay);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cmbNight);
            this.groupBox1.Controls.Add(this.cmbEvening);
            this.groupBox1.Controls.Add(this.cmbNoon);
            this.groupBox1.Controls.Add(this.cmbMorn);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbIntakeMethod);
            this.groupBox1.Controls.Add(this.txtDoseQty);
            this.groupBox1.Controls.Add(this.lvwMedication);
            this.groupBox1.Controls.Add(this.btnAddMedication);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbMedicineName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(206, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 184);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medication";
            // 
            // txtDDay
            // 
            this.txtDDay.Location = new System.Drawing.Point(602, 29);
            this.txtDDay.Name = "txtDDay";
            this.txtDDay.Size = new System.Drawing.Size(51, 20);
            this.txtDDay.TabIndex = 19;
            this.txtDDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDay_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(611, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "D.Day";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Morning";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(450, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Noon";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(496, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Evening";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(555, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Night";
            // 
            // cmbNight
            // 
            this.cmbNight.FormattingEnabled = true;
            this.cmbNight.ItemHeight = 13;
            this.cmbNight.Location = new System.Drawing.Point(553, 28);
            this.cmbNight.Name = "cmbNight";
            this.cmbNight.Size = new System.Drawing.Size(43, 21);
            this.cmbNight.TabIndex = 18;
            this.cmbNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNight_KeyPress);
            // 
            // cmbEvening
            // 
            this.cmbEvening.FormattingEnabled = true;
            this.cmbEvening.ItemHeight = 13;
            this.cmbEvening.Location = new System.Drawing.Point(499, 28);
            this.cmbEvening.Name = "cmbEvening";
            this.cmbEvening.Size = new System.Drawing.Size(48, 21);
            this.cmbEvening.TabIndex = 17;
            this.cmbEvening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEvening_KeyPress);
            // 
            // cmbNoon
            // 
            this.cmbNoon.FormattingEnabled = true;
            this.cmbNoon.ItemHeight = 13;
            this.cmbNoon.Location = new System.Drawing.Point(447, 29);
            this.cmbNoon.Name = "cmbNoon";
            this.cmbNoon.Size = new System.Drawing.Size(46, 21);
            this.cmbNoon.TabIndex = 16;
            this.cmbNoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNoon_KeyPress);
            // 
            // cmbMorn
            // 
            this.cmbMorn.FormattingEnabled = true;
            this.cmbMorn.ItemHeight = 13;
            this.cmbMorn.Location = new System.Drawing.Point(392, 29);
            this.cmbMorn.Name = "cmbMorn";
            this.cmbMorn.Size = new System.Drawing.Size(49, 21);
            this.cmbMorn.TabIndex = 15;
            this.cmbMorn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMorn_KeyPress);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(22, 13);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(35, 13);
            this.Type.TabIndex = 5;
            this.Type.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 13;
            this.cmbType.Location = new System.Drawing.Point(9, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(71, 21);
            this.cmbType.TabIndex = 11;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbIntakeMethod
            // 
            this.cmbIntakeMethod.BackColor = System.Drawing.Color.White;
            this.cmbIntakeMethod.FormattingEnabled = true;
            this.cmbIntakeMethod.ItemHeight = 13;
            this.cmbIntakeMethod.Location = new System.Drawing.Point(294, 29);
            this.cmbIntakeMethod.Name = "cmbIntakeMethod";
            this.cmbIntakeMethod.Size = new System.Drawing.Size(92, 21);
            this.cmbIntakeMethod.TabIndex = 14;
            this.cmbIntakeMethod.Tag = "patient_id";
            // 
            // txtDoseQty
            // 
            this.txtDoseQty.Location = new System.Drawing.Point(230, 31);
            this.txtDoseQty.Name = "txtDoseQty";
            this.txtDoseQty.Size = new System.Drawing.Size(58, 20);
            this.txtDoseQty.TabIndex = 13;
            this.txtDoseQty.Tag = "patient_name";
            this.txtDoseQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoseQty_KeyPress);
            // 
            // lvwMedication
            // 
            this.lvwMedication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMedication.BackColor = System.Drawing.Color.White;
            this.lvwMedication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12});
            this.lvwMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMedication.ForeColor = System.Drawing.Color.Black;
            this.lvwMedication.FullRowSelect = true;
            this.lvwMedication.GridLines = true;
            this.lvwMedication.HideSelection = false;
            this.lvwMedication.Location = new System.Drawing.Point(9, 60);
            this.lvwMedication.Name = "lvwMedication";
            this.lvwMedication.Size = new System.Drawing.Size(699, 117);
            this.lvwMedication.TabIndex = 4;
            this.lvwMedication.UseCompatibleStateImageBehavior = false;
            this.lvwMedication.View = System.Windows.Forms.View.Details;
            this.lvwMedication.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lvwMedication_PreviewKeyDown);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Type";
            this.columnHeader10.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Medicine Name";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dose Qty";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Intake Method";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Morning";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Evening";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Night";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "D.Day";
            this.columnHeader12.Width = 65;
            // 
            // btnAddMedication
            // 
            this.btnAddMedication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedication.Location = new System.Drawing.Point(660, 28);
            this.btnAddMedication.Name = "btnAddMedication";
            this.btnAddMedication.Size = new System.Drawing.Size(48, 24);
            this.btnAddMedication.TabIndex = 20;
            this.btnAddMedication.Text = "Add";
            this.btnAddMedication.UseVisualStyleBackColor = true;
            this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Medicine Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(229, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Dose Qty";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMedicineName
            // 
            this.cmbMedicineName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMedicineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedicineName.BackColor = System.Drawing.Color.White;
            this.cmbMedicineName.FormattingEnabled = true;
            this.cmbMedicineName.ItemHeight = 13;
            this.cmbMedicineName.Location = new System.Drawing.Point(83, 30);
            this.cmbMedicineName.Name = "cmbMedicineName";
            this.cmbMedicineName.Size = new System.Drawing.Size(141, 21);
            this.cmbMedicineName.TabIndex = 12;
            this.cmbMedicineName.Tag = "patient_id";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(846, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvwAdvice
            // 
            this.lvwAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwAdvice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.advice});
            this.lvwAdvice.FullRowSelect = true;
            this.lvwAdvice.GridLines = true;
            this.lvwAdvice.HideSelection = false;
            this.lvwAdvice.Location = new System.Drawing.Point(7, 40);
            this.lvwAdvice.MultiSelect = false;
            this.lvwAdvice.Name = "lvwAdvice";
            this.lvwAdvice.Size = new System.Drawing.Size(340, 74);
            this.lvwAdvice.TabIndex = 2;
            this.lvwAdvice.UseCompatibleStateImageBehavior = false;
            this.lvwAdvice.View = System.Windows.Forms.View.Details;
            this.lvwAdvice.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lvwAdvice_PreviewKeyDown);
            // 
            // advice
            // 
            this.advice.Name = "advice";
            this.advice.Text = "Advise";
            this.advice.Width = 351;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Name";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Result";
            this.columnHeader4.Width = 200;
            // 
            // grpInvestigation
            // 
            this.grpInvestigation.Controls.Add(this.lvwInvestigation);
            this.grpInvestigation.Controls.Add(this.btnAddInvestigation);
            this.grpInvestigation.Controls.Add(this.label13);
            this.grpInvestigation.Controls.Add(this.cmbResults);
            this.grpInvestigation.Controls.Add(this.lblDepartemt);
            this.grpInvestigation.Controls.Add(this.cmbTestItems);
            this.grpInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvestigation.Location = new System.Drawing.Point(220, 429);
            this.grpInvestigation.Name = "grpInvestigation";
            this.grpInvestigation.Size = new System.Drawing.Size(336, 167);
            this.grpInvestigation.TabIndex = 100;
            this.grpInvestigation.TabStop = false;
            this.grpInvestigation.Text = "Investigation";
            // 
            // lvwInvestigation
            // 
            this.lvwInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInvestigation.BackColor = System.Drawing.Color.White;
            this.lvwInvestigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvwInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInvestigation.ForeColor = System.Drawing.Color.Black;
            this.lvwInvestigation.FullRowSelect = true;
            this.lvwInvestigation.GridLines = true;
            this.lvwInvestigation.HideSelection = false;
            this.lvwInvestigation.Location = new System.Drawing.Point(6, 57);
            this.lvwInvestigation.Name = "lvwInvestigation";
            this.lvwInvestigation.Size = new System.Drawing.Size(324, 104);
            this.lvwInvestigation.TabIndex = 4;
            this.lvwInvestigation.UseCompatibleStateImageBehavior = false;
            this.lvwInvestigation.View = System.Windows.Forms.View.Details;
            this.lvwInvestigation.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lvwInvestigation_PreviewKeyDown);
            // 
            // btnAddInvestigation
            // 
            this.btnAddInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInvestigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvestigation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInvestigation.Location = new System.Drawing.Point(267, 29);
            this.btnAddInvestigation.Name = "btnAddInvestigation";
            this.btnAddInvestigation.Size = new System.Drawing.Size(63, 24);
            this.btnAddInvestigation.TabIndex = 23;
            this.btnAddInvestigation.Text = "Add";
            this.btnAddInvestigation.UseVisualStyleBackColor = true;
            this.btnAddInvestigation.Click += new System.EventHandler(this.btnAddInvestigation_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Test Items:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbResults
            // 
            this.cmbResults.BackColor = System.Drawing.Color.White;
            this.cmbResults.FormattingEnabled = true;
            this.cmbResults.ItemHeight = 13;
            this.cmbResults.Location = new System.Drawing.Point(148, 31);
            this.cmbResults.Name = "cmbResults";
            this.cmbResults.Size = new System.Drawing.Size(117, 21);
            this.cmbResults.TabIndex = 22;
            this.cmbResults.Tag = "patient_id";
            // 
            // lblDepartemt
            // 
            this.lblDepartemt.AutoSize = true;
            this.lblDepartemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartemt.Location = new System.Drawing.Point(161, 17);
            this.lblDepartemt.Name = "lblDepartemt";
            this.lblDepartemt.Size = new System.Drawing.Size(49, 13);
            this.lblDepartemt.TabIndex = 49;
            this.lblDepartemt.Text = "Results";
            this.lblDepartemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTestItems
            // 
            this.cmbTestItems.BackColor = System.Drawing.Color.White;
            this.cmbTestItems.FormattingEnabled = true;
            this.cmbTestItems.ItemHeight = 13;
            this.cmbTestItems.Location = new System.Drawing.Point(7, 32);
            this.cmbTestItems.Name = "cmbTestItems";
            this.cmbTestItems.Size = new System.Drawing.Size(125, 21);
            this.cmbTestItems.TabIndex = 21;
            this.cmbTestItems.Tag = "patient_id";
            // 
            // btnAddAdvice
            // 
            this.btnAddAdvice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdvice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdvice.Location = new System.Drawing.Point(266, 12);
            this.btnAddAdvice.Name = "btnAddAdvice";
            this.btnAddAdvice.Size = new System.Drawing.Size(58, 23);
            this.btnAddAdvice.TabIndex = 25;
            this.btnAddAdvice.Text = "Add";
            this.btnAddAdvice.UseVisualStyleBackColor = true;
            this.btnAddAdvice.Click += new System.EventHandler(this.btnAddAdvice_Click);
            // 
            // cmbAdvice
            // 
            this.cmbAdvice.FormattingEnabled = true;
            this.cmbAdvice.ItemHeight = 13;
            this.cmbAdvice.Location = new System.Drawing.Point(8, 14);
            this.cmbAdvice.Name = "cmbAdvice";
            this.cmbAdvice.Size = new System.Drawing.Size(252, 21);
            this.cmbAdvice.TabIndex = 24;
            this.cmbAdvice.Tag = "advice_id";
            // 
            // grpAdvice
            // 
            this.grpAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAdvice.Controls.Add(this.btnAddAdvice);
            this.grpAdvice.Controls.Add(this.cmbAdvice);
            this.grpAdvice.Controls.Add(this.lvwAdvice);
            this.grpAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdvice.Location = new System.Drawing.Point(562, 432);
            this.grpAdvice.Name = "grpAdvice";
            this.grpAdvice.Size = new System.Drawing.Size(360, 120);
            this.grpAdvice.TabIndex = 101;
            this.grpAdvice.TabStop = false;
            this.grpAdvice.Text = "Advice";
            // 
            // VisitedDate
            // 
            this.VisitedDate.Text = "Visited Date";
            this.VisitedDate.Width = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(678, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 15);
            this.label12.TabIndex = 87;
            this.label12.Text = "Primary Diagonosis";
            // 
            // txtPrimaryDiagonosis
            // 
            this.txtPrimaryDiagonosis.Location = new System.Drawing.Point(681, 197);
            this.txtPrimaryDiagonosis.Multiline = true;
            this.txtPrimaryDiagonosis.Name = "txtPrimaryDiagonosis";
            this.txtPrimaryDiagonosis.Size = new System.Drawing.Size(241, 40);
            this.txtPrimaryDiagonosis.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(679, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 85;
            this.label11.Text = "C.C.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 77;
            this.label7.Text = "Pulse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 75;
            this.label5.Text = "Temp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "B.P.";
            // 
            // lvwVisitedDate
            // 
            this.lvwVisitedDate.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwVisitedDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VisitedDate,
            this.ConsultantName,
            this.BookingID});
            this.lvwVisitedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVisitedDate.FullRowSelect = true;
            this.lvwVisitedDate.GridLines = true;
            this.lvwVisitedDate.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwVisitedDate.HideSelection = false;
            this.lvwVisitedDate.Location = new System.Drawing.Point(203, 120);
            this.lvwVisitedDate.Name = "lvwVisitedDate";
            this.lvwVisitedDate.Scrollable = false;
            this.lvwVisitedDate.Size = new System.Drawing.Size(331, 117);
            this.lvwVisitedDate.TabIndex = 3;
            this.lvwVisitedDate.UseCompatibleStateImageBehavior = false;
            this.lvwVisitedDate.View = System.Windows.Forms.View.Details;
            this.lvwVisitedDate.Click += new System.EventHandler(this.lvwVisitedDate_Click);
            // 
            // ConsultantName
            // 
            this.ConsultantName.Text = "Consultant Name";
            this.ConsultantName.Width = 150;
            // 
            // BookingID
            // 
            this.BookingID.Text = "BookingID";
            this.BookingID.Width = 65;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(681, 128);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(241, 43);
            this.txtCC.TabIndex = 9;
            // 
            // txtPulse
            // 
            this.txtPulse.Location = new System.Drawing.Point(599, 145);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(71, 20);
            this.txtPulse.TabIndex = 5;
            this.txtPulse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPulse_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(599, 169);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(71, 20);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.txtBP);
            this.grpMain.Controls.Add(this.cmbConsullantlist);
            this.grpMain.Controls.Add(this.lvwHospitalID);
            this.grpMain.Controls.Add(this.btnPrintSampleCollected);
            this.grpMain.Controls.Add(this.grpAdvice);
            this.grpMain.Controls.Add(this.groupBox2);
            this.grpMain.Controls.Add(this.groupBox1);
            this.grpMain.Controls.Add(this.grpInvestigation);
            this.grpMain.Controls.Add(this.label12);
            this.grpMain.Controls.Add(this.txtPrimaryDiagonosis);
            this.grpMain.Controls.Add(this.label11);
            this.grpMain.Controls.Add(this.txtCC);
            this.grpMain.Controls.Add(this.txtPulse);
            this.grpMain.Controls.Add(this.txtHeight);
            this.grpMain.Controls.Add(this.txtWeight);
            this.grpMain.Controls.Add(this.txtTemp);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.label7);
            this.grpMain.Controls.Add(this.label6);
            this.grpMain.Controls.Add(this.label5);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Controls.Add(this.lvwVisitedDate);
            this.grpMain.Controls.Add(this.grpOPDPatient);
            this.grpMain.Controls.Add(this.lblRequisitionTitle);
            this.grpMain.Controls.Add(this.btnRefresh);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.btnClose);
            this.grpMain.Location = new System.Drawing.Point(12, 11);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(933, 597);
            this.grpMain.TabIndex = 500;
            this.grpMain.TabStop = false;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(599, 120);
            this.txtBP.Mask = "000/000";
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(71, 20);
            this.txtBP.TabIndex = 4;
            // 
            // cmbConsullantlist
            // 
            this.cmbConsullantlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConsullantlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConsullantlist.FormattingEnabled = true;
            this.cmbConsullantlist.Location = new System.Drawing.Point(13, 73);
            this.cmbConsullantlist.Name = "cmbConsullantlist";
            this.cmbConsullantlist.Size = new System.Drawing.Size(186, 21);
            this.cmbConsullantlist.TabIndex = 0;
            this.cmbConsullantlist.SelectedIndexChanged += new System.EventHandler(this.cmbConsullantlist_SelectedIndexChanged);
            // 
            // lvwHospitalID
            // 
            this.lvwHospitalID.BackColor = System.Drawing.Color.SeaShell;
            this.lvwHospitalID.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11});
            this.lvwHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHospitalID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lvwHospitalID.Location = new System.Drawing.Point(11, 109);
            this.lvwHospitalID.Name = "lvwHospitalID";
            this.lvwHospitalID.Size = new System.Drawing.Size(186, 405);
            this.lvwHospitalID.TabIndex = 1;
            this.lvwHospitalID.UseCompatibleStateImageBehavior = false;
            this.lvwHospitalID.View = System.Windows.Forms.View.Details;
            this.lvwHospitalID.SelectedIndexChanged += new System.EventHandler(this.lvwHospitalID_SelectedIndexChanged);
            this.lvwHospitalID.Click += new System.EventHandler(this.lvwHospitalID_Click);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Hospital ID";
            this.columnHeader11.Width = 175;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(599, 192);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(71, 20);
            this.txtWeight.TabIndex = 7;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(599, 216);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(71, 20);
            this.txtTemp.TabIndex = 8;
            this.txtTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(540, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 78;
            this.label8.Text = "Weight";
            // 
            // grpOPDPatient
            // 
            this.grpOPDPatient.Controls.Add(this.label3);
            this.grpOPDPatient.Controls.Add(this.txtBookingSerial);
            this.grpOPDPatient.Controls.Add(this.label1);
            this.grpOPDPatient.Controls.Add(this.txtPatientName);
            this.grpOPDPatient.Controls.Add(this.txtHospitalID);
            this.grpOPDPatient.Controls.Add(this.lblRequisitionNo);
            this.grpOPDPatient.Location = new System.Drawing.Point(220, 63);
            this.grpOPDPatient.Name = "grpOPDPatient";
            this.grpOPDPatient.Size = new System.Drawing.Size(708, 43);
            this.grpOPDPatient.TabIndex = 150;
            this.grpOPDPatient.TabStop = false;
            this.grpOPDPatient.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Booking Serial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBookingSerial
            // 
            this.txtBookingSerial.Location = new System.Drawing.Point(330, 15);
            this.txtBookingSerial.Name = "txtBookingSerial";
            this.txtBookingSerial.ReadOnly = true;
            this.txtBookingSerial.Size = new System.Drawing.Size(130, 20);
            this.txtBookingSerial.TabIndex = 80;
            this.txtBookingSerial.Tag = "patient_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Patient Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(572, 15);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(130, 20);
            this.txtPatientName.TabIndex = 78;
            this.txtPatientName.Tag = "patient_name";
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalID.Location = new System.Drawing.Point(82, 15);
            this.txtHospitalID.MaxLength = 13;
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(130, 20);
            this.txtHospitalID.TabIndex = 2;
            this.txtHospitalID.Tag = "patient_hospital_id";
            // 
            // lblRequisitionNo
            // 
            this.lblRequisitionNo.AutoSize = true;
            this.lblRequisitionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionNo.Location = new System.Drawing.Point(6, 18);
            this.lblRequisitionNo.Name = "lblRequisitionNo";
            this.lblRequisitionNo.Size = new System.Drawing.Size(70, 13);
            this.lblRequisitionNo.TabIndex = 73;
            this.lblRequisitionNo.Text = "Hospital ID";
            this.lblRequisitionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequisitionTitle
            // 
            this.lblRequisitionTitle.AutoSize = true;
            this.lblRequisitionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequisitionTitle.Location = new System.Drawing.Point(340, 16);
            this.lblRequisitionTitle.Name = "lblRequisitionTitle";
            this.lblRequisitionTitle.Size = new System.Drawing.Size(219, 31);
            this.lblRequisitionTitle.TabIndex = 31;
            this.lblRequisitionTitle.Text = "Outdoor Patient";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(761, 563);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(672, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmOutdoorPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(957, 619);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOutdoorPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outdoor Patient";
            this.Load += new System.EventHandler(this.frmOutdoorPatient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpInvestigation.ResumeLayout(false);
            this.grpInvestigation.PerformLayout();
            this.grpAdvice.ResumeLayout(false);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpOPDPatient.ResumeLayout(false);
            this.grpOPDPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNextVisitedDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnPrintSampleCollected;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbIntakeMethod;
        private System.Windows.Forms.TextBox txtDoseQty;
        private System.Windows.Forms.ListView lvwMedication;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnAddMedication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMedicineName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvwAdvice;
        private System.Windows.Forms.ColumnHeader advice;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grpInvestigation;
        private System.Windows.Forms.ListView lvwInvestigation;
        private System.Windows.Forms.Button btnAddInvestigation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbResults;
        private System.Windows.Forms.Label lblDepartemt;
        private System.Windows.Forms.ComboBox cmbTestItems;
        private System.Windows.Forms.Button btnAddAdvice;
        private System.Windows.Forms.ComboBox cmbAdvice;
        private System.Windows.Forms.GroupBox grpAdvice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrimaryDiagonosis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwVisitedDate;
        private System.Windows.Forms.ColumnHeader ConsultantName;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtPulse;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpOPDPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.Label lblRequisitionNo;
        private System.Windows.Forms.Label lblRequisitionTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cmbConsullantlist;
        private System.Windows.Forms.ListView lvwHospitalID;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.MaskedTextBox txtBP;
        private System.Windows.Forms.ColumnHeader BookingID;
        private System.Windows.Forms.ColumnHeader VisitedDate;
        private System.Windows.Forms.ComboBox cmbNight;
        private System.Windows.Forms.ComboBox cmbEvening;
        private System.Windows.Forms.ComboBox cmbNoon;
        private System.Windows.Forms.ComboBox cmbMorn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDDay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}