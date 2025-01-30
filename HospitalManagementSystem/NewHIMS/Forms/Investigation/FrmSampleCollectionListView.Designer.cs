namespace NewHIMS.Forms.Investigation
{
    partial class FrmSampleCollectionPathologyListView
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
            this.grpCabin = new System.Windows.Forms.GroupBox();
            this.groupsamplecollected = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtPatientIDsamplecollected = new System.Windows.Forms.TextBox();
            this.txtordernosamplecollected = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReprint = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.chkHospitalID = new System.Windows.Forms.CheckBox();
            this.chkAdmissionID = new System.Windows.Forms.CheckBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.chkCabin = new System.Windows.Forms.CheckBox();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.txtCabin = new System.Windows.Forms.TextBox();
            this.grpPatientType = new System.Windows.Forms.GroupBox();
            this.rdoIpd = new System.Windows.Forms.RadioButton();
            this.rdoOpd = new System.Windows.Forms.RadioButton();
            this.btnStickerPrint = new System.Windows.Forms.Button();
            this.btnPrintSampleCollected = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvwMainList = new System.Windows.Forms.ListView();
            this.order_no = new System.Windows.Forms.ColumnHeader();
            this.specimen = new System.Windows.Forms.ColumnHeader();
            this.sample_no = new System.Windows.Forms.ColumnHeader();
            this.p_type = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.test = new System.Windows.Forms.ColumnHeader();
            this.investigationTestID = new System.Windows.Forms.ColumnHeader();
            this.test_item_id = new System.Windows.Forms.ColumnHeader();
            this.specimen_id = new System.Windows.Forms.ColumnHeader();
            this.order_date = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.grpCabin.SuspendLayout();
            this.groupsamplecollected.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpPatientType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCabin
            // 
            this.grpCabin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCabin.Controls.Add(this.groupsamplecollected);
            this.grpCabin.Controls.Add(this.btnCancel);
            this.grpCabin.Controls.Add(this.btnReprint);
            this.grpCabin.Controls.Add(this.grpSearch);
            this.grpCabin.Controls.Add(this.grpPatientType);
            this.grpCabin.Controls.Add(this.btnStickerPrint);
            this.grpCabin.Controls.Add(this.btnPrintSampleCollected);
            this.grpCabin.Controls.Add(this.btnRefresh);
            this.grpCabin.Controls.Add(this.btnClose);
            this.grpCabin.Controls.Add(this.lvwMainList);
            this.grpCabin.Location = new System.Drawing.Point(12, 51);
            this.grpCabin.Name = "grpCabin";
            this.grpCabin.Size = new System.Drawing.Size(842, 532);
            this.grpCabin.TabIndex = 3;
            this.grpCabin.TabStop = false;
            // 
            // groupsamplecollected
            // 
            this.groupsamplecollected.Controls.Add(this.checkBox1);
            this.groupsamplecollected.Controls.Add(this.checkBox2);
            this.groupsamplecollected.Controls.Add(this.txtPatientIDsamplecollected);
            this.groupsamplecollected.Controls.Add(this.txtordernosamplecollected);
            this.groupsamplecollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsamplecollected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupsamplecollected.Location = new System.Drawing.Point(551, 19);
            this.groupsamplecollected.Name = "groupsamplecollected";
            this.groupsamplecollected.Size = new System.Drawing.Size(261, 79);
            this.groupsamplecollected.TabIndex = 108;
            this.groupsamplecollected.TabStop = false;
            this.groupsamplecollected.Text = "Sample Collected";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(12, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 20);
            this.checkBox1.TabIndex = 107;
            this.checkBox1.Text = "Order No";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(12, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 20);
            this.checkBox2.TabIndex = 101;
            this.checkBox2.Text = "Patient ID";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtPatientIDsamplecollected
            // 
            this.txtPatientIDsamplecollected.Enabled = false;
            this.txtPatientIDsamplecollected.Location = new System.Drawing.Point(103, 19);
            this.txtPatientIDsamplecollected.Name = "txtPatientIDsamplecollected";
            this.txtPatientIDsamplecollected.Size = new System.Drawing.Size(110, 20);
            this.txtPatientIDsamplecollected.TabIndex = 105;
            this.txtPatientIDsamplecollected.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientIDsamplecollected_KeyPress);
            // 
            // txtordernosamplecollected
            // 
            this.txtordernosamplecollected.Enabled = false;
            this.txtordernosamplecollected.Location = new System.Drawing.Point(103, 49);
            this.txtordernosamplecollected.Name = "txtordernosamplecollected";
            this.txtordernosamplecollected.Size = new System.Drawing.Size(110, 20);
            this.txtordernosamplecollected.TabIndex = 99;
            this.txtordernosamplecollected.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtordernosamplecollected_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::NewHIMS.Properties.Resources.RemoveSmall;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(641, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 49);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnReprint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReprint.Location = new System.Drawing.Point(167, 467);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(85, 52);
            this.btnReprint.TabIndex = 105;
            this.btnReprint.Text = "Sticker Re-Print";
            this.btnReprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReprint.UseVisualStyleBackColor = true;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.chkOrder);
            this.grpSearch.Controls.Add(this.chkHospitalID);
            this.grpSearch.Controls.Add(this.chkAdmissionID);
            this.grpSearch.Controls.Add(this.txtHospitalID);
            this.grpSearch.Controls.Add(this.txtOrder);
            this.grpSearch.Controls.Add(this.chkCabin);
            this.grpSearch.Controls.Add(this.txtAdmissionID);
            this.grpSearch.Controls.Add(this.txtCabin);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpSearch.Location = new System.Drawing.Point(24, 19);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(228, 79);
            this.grpSearch.TabIndex = 104;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrder.ForeColor = System.Drawing.Color.Black;
            this.chkOrder.Location = new System.Drawing.Point(14, 52);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(84, 20);
            this.chkOrder.TabIndex = 107;
            this.chkOrder.Text = "Order No";
            this.chkOrder.UseVisualStyleBackColor = true;
            this.chkOrder.CheckedChanged += new System.EventHandler(this.chkOrder_CheckedChanged);
            // 
            // chkHospitalID
            // 
            this.chkHospitalID.AutoSize = true;
            this.chkHospitalID.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHospitalID.ForeColor = System.Drawing.Color.Black;
            this.chkHospitalID.Location = new System.Drawing.Point(14, 22);
            this.chkHospitalID.Name = "chkHospitalID";
            this.chkHospitalID.Size = new System.Drawing.Size(81, 20);
            this.chkHospitalID.TabIndex = 101;
            this.chkHospitalID.Text = "Patient ID";
            this.chkHospitalID.UseVisualStyleBackColor = true;
            this.chkHospitalID.CheckedChanged += new System.EventHandler(this.chkHospitalID_CheckedChanged);
            // 
            // chkAdmissionID
            // 
            this.chkAdmissionID.AutoSize = true;
            this.chkAdmissionID.Location = new System.Drawing.Point(278, 49);
            this.chkAdmissionID.Name = "chkAdmissionID";
            this.chkAdmissionID.Size = new System.Drawing.Size(98, 17);
            this.chkAdmissionID.TabIndex = 102;
            this.chkAdmissionID.Text = "Adm-Reg. ID";
            this.chkAdmissionID.UseVisualStyleBackColor = true;
            this.chkAdmissionID.Visible = false;
            this.chkAdmissionID.CheckedChanged += new System.EventHandler(this.chkAdmissionID_CheckedChanged);
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Enabled = false;
            this.txtHospitalID.Location = new System.Drawing.Point(105, 20);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(110, 20);
            this.txtHospitalID.TabIndex = 105;
            this.txtHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospitalID_KeyPress);
            // 
            // txtOrder
            // 
            this.txtOrder.Enabled = false;
            this.txtOrder.Location = new System.Drawing.Point(105, 50);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(110, 20);
            this.txtOrder.TabIndex = 99;
            this.txtOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_KeyPress);
            // 
            // chkCabin
            // 
            this.chkCabin.AutoSize = true;
            this.chkCabin.Location = new System.Drawing.Point(285, 22);
            this.chkCabin.Name = "chkCabin";
            this.chkCabin.Size = new System.Drawing.Size(78, 17);
            this.chkCabin.TabIndex = 103;
            this.chkCabin.Text = "Cabin No";
            this.chkCabin.UseVisualStyleBackColor = true;
            this.chkCabin.Visible = false;
            this.chkCabin.CheckedChanged += new System.EventHandler(this.chkCabin_CheckedChanged);
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Enabled = false;
            this.txtAdmissionID.Location = new System.Drawing.Point(390, 45);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(110, 20);
            this.txtAdmissionID.TabIndex = 104;
            this.txtAdmissionID.Visible = false;
            this.txtAdmissionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionID_KeyPress);
            // 
            // txtCabin
            // 
            this.txtCabin.Enabled = false;
            this.txtCabin.Location = new System.Drawing.Point(378, 19);
            this.txtCabin.Name = "txtCabin";
            this.txtCabin.Size = new System.Drawing.Size(110, 20);
            this.txtCabin.TabIndex = 106;
            this.txtCabin.Visible = false;
            this.txtCabin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCabin_KeyPress);
            // 
            // grpPatientType
            // 
            this.grpPatientType.Controls.Add(this.rdoIpd);
            this.grpPatientType.Controls.Add(this.rdoOpd);
            this.grpPatientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientType.Location = new System.Drawing.Point(286, 34);
            this.grpPatientType.Name = "grpPatientType";
            this.grpPatientType.Size = new System.Drawing.Size(216, 50);
            this.grpPatientType.TabIndex = 102;
            this.grpPatientType.TabStop = false;
            this.grpPatientType.Text = "Patient Type";
            // 
            // rdoIpd
            // 
            this.rdoIpd.AutoSize = true;
            this.rdoIpd.Location = new System.Drawing.Point(17, 22);
            this.rdoIpd.Name = "rdoIpd";
            this.rdoIpd.Size = new System.Drawing.Size(90, 17);
            this.rdoIpd.TabIndex = 103;
            this.rdoIpd.TabStop = true;
            this.rdoIpd.Text = "IPD Patient";
            this.rdoIpd.UseVisualStyleBackColor = true;
            this.rdoIpd.CheckedChanged += new System.EventHandler(this.rdoIpd_CheckedChanged);
            // 
            // rdoOpd
            // 
            this.rdoOpd.AutoSize = true;
            this.rdoOpd.Location = new System.Drawing.Point(114, 22);
            this.rdoOpd.Name = "rdoOpd";
            this.rdoOpd.Size = new System.Drawing.Size(95, 17);
            this.rdoOpd.TabIndex = 104;
            this.rdoOpd.TabStop = true;
            this.rdoOpd.Text = "OPD Patient";
            this.rdoOpd.UseVisualStyleBackColor = true;
            this.rdoOpd.CheckedChanged += new System.EventHandler(this.rdoOpd_CheckedChanged);
            // 
            // btnStickerPrint
            // 
            this.btnStickerPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStickerPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStickerPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStickerPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnStickerPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStickerPrint.Location = new System.Drawing.Point(76, 467);
            this.btnStickerPrint.Name = "btnStickerPrint";
            this.btnStickerPrint.Size = new System.Drawing.Size(85, 52);
            this.btnStickerPrint.TabIndex = 35;
            this.btnStickerPrint.Text = "Sticker Print";
            this.btnStickerPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStickerPrint.UseVisualStyleBackColor = true;
            this.btnStickerPrint.Click += new System.EventHandler(this.btnStickerPrint_Click);
            // 
            // btnPrintSampleCollected
            // 
            this.btnPrintSampleCollected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintSampleCollected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSampleCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSampleCollected.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrintSampleCollected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSampleCollected.Location = new System.Drawing.Point(703, 470);
            this.btnPrintSampleCollected.Name = "btnPrintSampleCollected";
            this.btnPrintSampleCollected.Size = new System.Drawing.Size(59, 49);
            this.btnPrintSampleCollected.TabIndex = 34;
            this.btnPrintSampleCollected.Text = "Print";
            this.btnPrintSampleCollected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintSampleCollected.UseVisualStyleBackColor = true;
            this.btnPrintSampleCollected.Click += new System.EventHandler(this.btnPrintSampleCollected_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(12, 467);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(768, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvwMainList
            // 
            this.lvwMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMainList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lvwMainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_no,
            this.specimen,
            this.sample_no,
            this.p_type,
            this.patient_code,
            this.patient_name,
            this.admission_code,
            this.cabin,
            this.age,
            this.test,
            this.investigationTestID,
            this.test_item_id,
            this.specimen_id,
            this.order_date});
            this.lvwMainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMainList.ForeColor = System.Drawing.Color.Black;
            this.lvwMainList.FullRowSelect = true;
            this.lvwMainList.GridLines = true;
            this.lvwMainList.HideSelection = false;
            this.lvwMainList.Location = new System.Drawing.Point(18, 113);
            this.lvwMainList.Name = "lvwMainList";
            this.lvwMainList.Size = new System.Drawing.Size(800, 347);
            this.lvwMainList.TabIndex = 0;
            this.lvwMainList.UseCompatibleStateImageBehavior = false;
            this.lvwMainList.View = System.Windows.Forms.View.Details;
            this.lvwMainList.DoubleClick += new System.EventHandler(this.lvwMainList_DoubleClick);
            this.lvwMainList.Click += new System.EventHandler(this.lvwMainList_Click);
            // 
            // order_no
            // 
            this.order_no.Text = "Order No";
            this.order_no.Width = 63;
            // 
            // specimen
            // 
            this.specimen.Text = "Specimen";
            this.specimen.Width = 0;
            // 
            // sample_no
            // 
            this.sample_no.Text = "Sample ID";
            this.sample_no.Width = 70;
            // 
            // p_type
            // 
            this.p_type.Text = "Patient Type";
            this.p_type.Width = 0;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Tag = "";
            this.patient_code.Text = "Patient ID";
            this.patient_code.Width = 80;
            // 
            // patient_name
            // 
            this.patient_name.Name = "patient_name";
            this.patient_name.Tag = "";
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 194;
            // 
            // admission_code
            // 
            this.admission_code.Name = "admission_code";
            this.admission_code.Tag = "";
            this.admission_code.Text = "Admission Code";
            this.admission_code.Width = 0;
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Tag = "";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 0;
            // 
            // age
            // 
            this.age.Text = "Patient Age";
            this.age.Width = 0;
            // 
            // test
            // 
            this.test.Text = "Test";
            this.test.Width = 184;
            // 
            // investigationTestID
            // 
            this.investigationTestID.Text = "investigationTestID";
            this.investigationTestID.Width = 0;
            // 
            // test_item_id
            // 
            this.test_item_id.Text = "Test ItemID";
            this.test_item_id.Width = 0;
            // 
            // specimen_id
            // 
            this.specimen_id.Text = "SpecimenID";
            this.specimen_id.Width = 0;
            // 
            // order_date
            // 
            this.order_date.Text = "Order Date & Time";
            this.order_date.Width = 188;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(-9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(875, 33);
            this.label7.TabIndex = 106;
            this.label7.Text = "Sample Collection";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSampleCollectionPathologyListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(866, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpCabin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSampleCollectionPathologyListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Collection Statistics";
            this.Load += new System.EventHandler(this.FrmSampleCollectionPathologyListView_Load);
            this.grpCabin.ResumeLayout(false);
            this.groupsamplecollected.ResumeLayout(false);
            this.groupsamplecollected.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpPatientType.ResumeLayout(false);
            this.grpPatientType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCabin;
        private System.Windows.Forms.Button btnPrintSampleCollected;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvwMainList;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader test;
        private System.Windows.Forms.ColumnHeader p_type;
        private System.Windows.Forms.ColumnHeader investigationTestID;
        private System.Windows.Forms.Button btnStickerPrint;
        private System.Windows.Forms.ColumnHeader test_item_id;
        private System.Windows.Forms.ColumnHeader specimen_id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.GroupBox grpPatientType;
        private System.Windows.Forms.RadioButton rdoIpd;
        private System.Windows.Forms.RadioButton rdoOpd;
        private System.Windows.Forms.ColumnHeader specimen;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkHospitalID;
        private System.Windows.Forms.CheckBox chkAdmissionID;
        private System.Windows.Forms.CheckBox chkCabin;
        private System.Windows.Forms.TextBox txtCabin;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.ColumnHeader order_no;
        private System.Windows.Forms.ColumnHeader sample_no;
        private System.Windows.Forms.ColumnHeader order_date;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupsamplecollected;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtPatientIDsamplecollected;
        private System.Windows.Forms.TextBox txtordernosamplecollected;
    }
}