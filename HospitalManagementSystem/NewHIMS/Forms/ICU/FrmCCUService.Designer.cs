namespace NewHIMS.Forms.ICU
{
    partial class FrmCCUService
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
            this.grpPatientOtherItem = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDoctorBill = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBedCharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBillSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.admission_date = new System.Windows.Forms.ColumnHeader();
            this.patient_id = new System.Windows.Forms.ColumnHeader();
            this.cabin_id = new System.Windows.Forms.ColumnHeader();
            this.bed_no = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOtherItem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvwPatientOtherItem = new System.Windows.Forms.ListView();
            this.itemname = new System.Windows.Forms.ColumnHeader();
            this.qty = new System.Windows.Forms.ColumnHeader();
            this.unit_rate = new System.Windows.Forms.ColumnHeader();
            this.patient_other_item_id = new System.Windows.Forms.ColumnHeader();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.lblOtherItem = new System.Windows.Forms.Label();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.discharged = new System.Windows.Forms.ColumnHeader();
            this.grpPatientOtherItem.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkKhaki;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(932, 30);
            this.label7.TabIndex = 111;
            this.label7.Text = "CCU/NICU Services";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPatientOtherItem
            // 
            this.grpPatientOtherItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientOtherItem.Controls.Add(this.btnDelete);
            this.grpPatientOtherItem.Controls.Add(this.groupBox4);
            this.grpPatientOtherItem.Controls.Add(this.label2);
            this.grpPatientOtherItem.Controls.Add(this.groupBox2);
            this.grpPatientOtherItem.Controls.Add(this.lvwPatientInfo);
            this.grpPatientOtherItem.Controls.Add(this.label4);
            this.grpPatientOtherItem.Controls.Add(this.cmbOtherItem);
            this.grpPatientOtherItem.Controls.Add(this.groupBox1);
            this.grpPatientOtherItem.Controls.Add(this.groupBox3);
            this.grpPatientOtherItem.Location = new System.Drawing.Point(8, 44);
            this.grpPatientOtherItem.Name = "grpPatientOtherItem";
            this.grpPatientOtherItem.Size = new System.Drawing.Size(914, 492);
            this.grpPatientOtherItem.TabIndex = 112;
            this.grpPatientOtherItem.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(840, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 23);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtBill);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtDoctorBill);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtBedCharge);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDiscount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtDue);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAdvance);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtTotalBill);
            this.groupBox4.Location = new System.Drawing.Point(513, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 146);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Total Bill :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(270, 87);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(100, 20);
            this.txtBill.TabIndex = 71;
            this.txtBill.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Doctor  :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoctorBill
            // 
            this.txtDoctorBill.Enabled = false;
            this.txtDoctorBill.Location = new System.Drawing.Point(270, 52);
            this.txtDoctorBill.Name = "txtDoctorBill";
            this.txtDoctorBill.ReadOnly = true;
            this.txtDoctorBill.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorBill.TabIndex = 69;
            this.txtDoctorBill.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Bed  :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBedCharge
            // 
            this.txtBedCharge.Enabled = false;
            this.txtBedCharge.Location = new System.Drawing.Point(90, 53);
            this.txtBedCharge.Name = "txtBedCharge";
            this.txtBedCharge.ReadOnly = true;
            this.txtBedCharge.Size = new System.Drawing.Size(91, 20);
            this.txtBedCharge.TabIndex = 67;
            this.txtBedCharge.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Discount :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(90, 118);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(91, 20);
            this.txtDiscount.TabIndex = 65;
            this.txtDiscount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Due :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDue
            // 
            this.txtDue.Enabled = false;
            this.txtDue.Location = new System.Drawing.Point(270, 118);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 63;
            this.txtDue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Advance :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Enabled = false;
            this.txtAdvance.Location = new System.Drawing.Point(90, 87);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(91, 20);
            this.txtAdvance.TabIndex = 61;
            this.txtAdvance.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Service :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Location = new System.Drawing.Point(270, 18);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBill.TabIndex = 0;
            this.txtTotalBill.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "CCU/NICU Service";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnBillSave);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(9, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 57);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Enabled = false;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(477, 19);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 28);
            this.btnPreview.TabIndex = 62;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(311, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 28);
            this.btnPrint.TabIndex = 61;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBillSave
            // 
            this.btnBillSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBillSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnBillSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillSave.Location = new System.Drawing.Point(623, 18);
            this.btnBillSave.Name = "btnBillSave";
            this.btnBillSave.Size = new System.Drawing.Size(83, 28);
            this.btnBillSave.TabIndex = 60;
            this.btnBillSave.Text = "Save";
            this.btnBillSave.UseVisualStyleBackColor = true;
            this.btnBillSave.Click += new System.EventHandler(this.btnBillSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(803, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(129, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Silver;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admission_id,
            this.admission_code,
            this.patient_code,
            this.patient_name,
            this.admission_date,
            this.patient_id,
            this.cabin_id,
            this.bed_no,
            this.discharged});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(17, 53);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(484, 369);
            this.lvwPatientInfo.TabIndex = 52;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.SelectedIndexChanged += new System.EventHandler(this.lvwPatientInfo_SelectedIndexChanged);
            // 
            // admission_id
            // 
            this.admission_id.Text = "Ad ID";
            this.admission_id.Width = 0;
            // 
            // admission_code
            // 
            this.admission_code.Text = "Admission ID";
            this.admission_code.Width = 90;
            // 
            // patient_code
            // 
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 89;
            // 
            // patient_name
            // 
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 180;
            // 
            // admission_date
            // 
            this.admission_date.Text = "Ad Date";
            this.admission_date.Width = 0;
            // 
            // patient_id
            // 
            this.patient_id.Text = "PID";
            this.patient_id.Width = 0;
            // 
            // cabin_id
            // 
            this.cabin_id.Text = "CabinID";
            this.cabin_id.Width = 0;
            // 
            // bed_no
            // 
            this.bed_no.Text = "Bed Number";
            this.bed_no.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(144, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Patient List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOtherItem
            // 
            this.cmbOtherItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOtherItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOtherItem.BackColor = System.Drawing.Color.Linen;
            this.cmbOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOtherItem.FormattingEnabled = true;
            this.cmbOtherItem.Location = new System.Drawing.Point(631, 52);
            this.cmbOtherItem.MaxLength = 50;
            this.cmbOtherItem.Name = "cmbOtherItem";
            this.cmbOtherItem.Size = new System.Drawing.Size(259, 24);
            this.cmbOtherItem.Sorted = true;
            this.cmbOtherItem.TabIndex = 1;
            this.cmbOtherItem.Tag = "other_item_id";
            this.cmbOtherItem.SelectedIndexChanged += new System.EventHandler(this.cmbOtherItem_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 392);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.lvwPatientOtherItem);
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtQtyPerUnit);
            this.groupBox3.Controls.Add(this.lblOtherItem);
            this.groupBox3.Controls.Add(this.lblQtyPerUnit);
            this.groupBox3.Location = new System.Drawing.Point(513, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 246);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(312, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 28);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "  Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lvwPatientOtherItem
            // 
            this.lvwPatientOtherItem.BackColor = System.Drawing.Color.Silver;
            this.lvwPatientOtherItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemname,
            this.qty,
            this.unit_rate,
            this.patient_other_item_id});
            this.lvwPatientOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientOtherItem.FullRowSelect = true;
            this.lvwPatientOtherItem.GridLines = true;
            this.lvwPatientOtherItem.Location = new System.Drawing.Point(7, 89);
            this.lvwPatientOtherItem.Name = "lvwPatientOtherItem";
            this.lvwPatientOtherItem.Size = new System.Drawing.Size(371, 150);
            this.lvwPatientOtherItem.TabIndex = 54;
            this.lvwPatientOtherItem.UseCompatibleStateImageBehavior = false;
            this.lvwPatientOtherItem.View = System.Windows.Forms.View.Details;
            this.lvwPatientOtherItem.Click += new System.EventHandler(this.lvwPatientOtherItem_Click);
            // 
            // itemname
            // 
            this.itemname.Text = "Item Name";
            this.itemname.Width = 218;
            // 
            // qty
            // 
            this.qty.Text = "Qty";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty.Width = 61;
            // 
            // unit_rate
            // 
            this.unit_rate.Text = "Rate";
            this.unit_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unit_rate.Width = 75;
            // 
            // patient_other_item_id
            // 
            this.patient_other_item_id.Text = "id";
            this.patient_other_item_id.Width = 0;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.Linen;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(119, 54);
            this.txtprice.MaxLength = 4;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(53, 22);
            this.txtprice.TabIndex = 58;
            this.txtprice.Tag = "qty_per_unit";
            this.txtprice.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Unit Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.BackColor = System.Drawing.Color.Linen;
            this.txtQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyPerUnit.Location = new System.Drawing.Point(230, 54);
            this.txtQtyPerUnit.MaxLength = 4;
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(53, 22);
            this.txtQtyPerUnit.TabIndex = 5;
            this.txtQtyPerUnit.Tag = "qty_per_unit";
            this.txtQtyPerUnit.Text = "1";
            // 
            // lblOtherItem
            // 
            this.lblOtherItem.AutoSize = true;
            this.lblOtherItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherItem.Location = new System.Drawing.Point(9, 20);
            this.lblOtherItem.Name = "lblOtherItem";
            this.lblOtherItem.Size = new System.Drawing.Size(104, 16);
            this.lblOtherItem.TabIndex = 12;
            this.lblOtherItem.Text = "Service Name:";
            this.lblOtherItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(188, 57);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(38, 16);
            this.lblQtyPerUnit.TabIndex = 16;
            this.lblQtyPerUnit.Text = "Qty:";
            this.lblQtyPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discharged
            // 
            this.discharged.Text = "Remarks";
            this.discharged.Width = 0;
            // 
            // FrmCCUService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(926, 540);
            this.Controls.Add(this.grpPatientOtherItem);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCCUService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCU Service";
            this.Load += new System.EventHandler(this.FrmCCUService_Load);
            this.grpPatientOtherItem.ResumeLayout(false);
            this.grpPatientOtherItem.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPatientOtherItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBillSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader admission_date;
        private System.Windows.Forms.ColumnHeader patient_id;
        private System.Windows.Forms.ColumnHeader cabin_id;
        private System.Windows.Forms.ColumnHeader bed_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOtherItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvwPatientOtherItem;
        private System.Windows.Forms.ColumnHeader itemname;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader unit_rate;
        private System.Windows.Forms.ColumnHeader patient_other_item_id;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtyPerUnit;
        private System.Windows.Forms.Label lblOtherItem;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDoctorBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBedCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ColumnHeader discharged;
    }
}