namespace NewHIMS.Forms.Outdoor
{
    partial class FrmOutdoorBooking
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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.LinkLabel();
            this.grpOtherItem = new System.Windows.Forms.GroupBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.lvwPatientOtherItem = new System.Windows.Forms.ListView();
            this.item_id = new System.Windows.Forms.ColumnHeader();
            this.item_name = new System.Windows.Forms.ColumnHeader();
            this.quentity = new System.Windows.Forms.ColumnHeader();
            this.charge = new System.Windows.Forms.ColumnHeader();
            this.txtcharge = new System.Windows.Forms.TextBox();
            this.grpAmount = new System.Windows.Forms.GroupBox();
            this.lblNetPayable = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtNetPayable = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbOtherItem = new System.Windows.Forms.ComboBox();
            this.lblOtherItem = new System.Windows.Forms.Label();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpOPDPatient = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAgeDd = new System.Windows.Forms.Label();
            this.txtAgeDd = new System.Windows.Forms.TextBox();
            this.lblAgeMm = new System.Windows.Forms.Label();
            this.txtAgeMm = new System.Windows.Forms.TextBox();
            this.lblAgeYy = new System.Windows.Forms.Label();
            this.txtAgeYy = new System.Windows.Forms.TextBox();
            this.btnPatientSave = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtCntactNo = new System.Windows.Forms.TextBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblRequisitionNo = new System.Windows.Forms.Label();
            this.grpDeptConsult = new System.Windows.Forms.GroupBox();
            this.radioPM = new System.Windows.Forms.RadioButton();
            this.radioAM = new System.Windows.Forms.RadioButton();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbConsultant = new System.Windows.Forms.ComboBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRequisitionTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrintSampleCollected = new System.Windows.Forms.Button();
            this.btnPList = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.grpOtherItem.SuspendLayout();
            this.grpAmount.SuspendLayout();
            this.grpOPDPatient.SuspendLayout();
            this.grpDeptConsult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.lblSearch);
            this.grpMain.Controls.Add(this.grpOtherItem);
            this.grpMain.Controls.Add(this.linkLabel1);
            this.grpMain.Controls.Add(this.grpOPDPatient);
            this.grpMain.Controls.Add(this.grpDeptConsult);
            this.grpMain.Controls.Add(this.lblRequisitionTitle);
            this.grpMain.Location = new System.Drawing.Point(25, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(487, 496);
            this.grpMain.TabIndex = 80;
            this.grpMain.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(411, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 17);
            this.lblSearch.TabIndex = 81;
            this.lblSearch.TabStop = true;
            this.lblSearch.Text = "Search";
            this.lblSearch.Visible = false;
            this.lblSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSearch_LinkClicked);
            // 
            // grpOtherItem
            // 
            this.grpOtherItem.Controls.Add(this.txtPid);
            this.grpOtherItem.Controls.Add(this.lvwPatientOtherItem);
            this.grpOtherItem.Controls.Add(this.txtcharge);
            this.grpOtherItem.Controls.Add(this.grpAmount);
            this.grpOtherItem.Controls.Add(this.btnAdd);
            this.grpOtherItem.Controls.Add(this.txtQtyPerUnit);
            this.grpOtherItem.Controls.Add(this.button2);
            this.grpOtherItem.Controls.Add(this.cmbOtherItem);
            this.grpOtherItem.Controls.Add(this.lblOtherItem);
            this.grpOtherItem.Controls.Add(this.lblQtyPerUnit);
            this.grpOtherItem.Enabled = false;
            this.grpOtherItem.Location = new System.Drawing.Point(23, 218);
            this.grpOtherItem.Name = "grpOtherItem";
            this.grpOtherItem.Size = new System.Drawing.Size(443, 272);
            this.grpOtherItem.TabIndex = 85;
            this.grpOtherItem.TabStop = false;
            // 
            // txtPid
            // 
            this.txtPid.BackColor = System.Drawing.Color.Linen;
            this.txtPid.Location = new System.Drawing.Point(380, 252);
            this.txtPid.MaxLength = 2;
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(48, 20);
            this.txtPid.TabIndex = 93;
            this.txtPid.Tag = "qty_per_unit";
            this.txtPid.Visible = false;
            // 
            // lvwPatientOtherItem
            // 
            this.lvwPatientOtherItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.item_name,
            this.quentity,
            this.charge});
            this.lvwPatientOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientOtherItem.GridLines = true;
            this.lvwPatientOtherItem.Location = new System.Drawing.Point(14, 39);
            this.lvwPatientOtherItem.Name = "lvwPatientOtherItem";
            this.lvwPatientOtherItem.Size = new System.Drawing.Size(419, 136);
            this.lvwPatientOtherItem.TabIndex = 90;
            this.lvwPatientOtherItem.UseCompatibleStateImageBehavior = false;
            this.lvwPatientOtherItem.View = System.Windows.Forms.View.Details;
            // 
            // item_id
            // 
            this.item_id.Text = "Item ID";
            this.item_id.Width = 0;
            // 
            // item_name
            // 
            this.item_name.Text = "Item Name";
            this.item_name.Width = 250;
            // 
            // quentity
            // 
            this.quentity.Text = "Qty.";
            this.quentity.Width = 70;
            // 
            // charge
            // 
            this.charge.Text = "Charge";
            this.charge.Width = 90;
            // 
            // txtcharge
            // 
            this.txtcharge.BackColor = System.Drawing.Color.Linen;
            this.txtcharge.Location = new System.Drawing.Point(327, 252);
            this.txtcharge.MaxLength = 2;
            this.txtcharge.Name = "txtcharge";
            this.txtcharge.Size = new System.Drawing.Size(48, 20);
            this.txtcharge.TabIndex = 92;
            this.txtcharge.Tag = "qty_per_unit";
            this.txtcharge.Visible = false;
            // 
            // grpAmount
            // 
            this.grpAmount.Controls.Add(this.lblNetPayable);
            this.grpAmount.Controls.Add(this.lblDiscount);
            this.grpAmount.Controls.Add(this.lblVat);
            this.grpAmount.Controls.Add(this.txtVat);
            this.grpAmount.Controls.Add(this.txtNetPayable);
            this.grpAmount.Controls.Add(this.txtDiscount);
            this.grpAmount.Controls.Add(this.txtAmount);
            this.grpAmount.Controls.Add(this.lblPay);
            this.grpAmount.Location = new System.Drawing.Point(14, 175);
            this.grpAmount.Name = "grpAmount";
            this.grpAmount.Size = new System.Drawing.Size(325, 76);
            this.grpAmount.TabIndex = 17;
            this.grpAmount.TabStop = false;
            // 
            // lblNetPayable
            // 
            this.lblNetPayable.AutoSize = true;
            this.lblNetPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayable.Location = new System.Drawing.Point(162, 43);
            this.lblNetPayable.Name = "lblNetPayable";
            this.lblNetPayable.Size = new System.Drawing.Size(76, 17);
            this.lblNetPayable.TabIndex = 26;
            this.lblNetPayable.Text = "Payable :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(6, 41);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(81, 17);
            this.lblDiscount.TabIndex = 25;
            this.lblDiscount.Text = "Discount :";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(6, 15);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(48, 17);
            this.lblVat.TabIndex = 24;
            this.lblVat.Text = "VAT :";
            // 
            // txtVat
            // 
            this.txtVat.BackColor = System.Drawing.Color.Linen;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(93, 11);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(63, 22);
            this.txtVat.TabIndex = 23;
            this.txtVat.Text = "0";
            // 
            // txtNetPayable
            // 
            this.txtNetPayable.BackColor = System.Drawing.Color.Linen;
            this.txtNetPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPayable.Location = new System.Drawing.Point(242, 41);
            this.txtNetPayable.Name = "txtNetPayable";
            this.txtNetPayable.ReadOnly = true;
            this.txtNetPayable.Size = new System.Drawing.Size(78, 22);
            this.txtNetPayable.TabIndex = 22;
            this.txtNetPayable.Text = "0";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(93, 39);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(63, 22);
            this.txtDiscount.TabIndex = 21;
            this.txtDiscount.Text = "0";
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Linen;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(242, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(77, 22);
            this.txtAmount.TabIndex = 19;
            this.txtAmount.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(162, 12);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(72, 17);
            this.lblPay.TabIndex = 2;
            this.lblPay.Text = "Amount :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(349, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 28);
            this.btnAdd.TabIndex = 91;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.BackColor = System.Drawing.Color.Linen;
            this.txtQtyPerUnit.Location = new System.Drawing.Point(398, 13);
            this.txtQtyPerUnit.MaxLength = 2;
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(34, 20);
            this.txtQtyPerUnit.TabIndex = 87;
            this.txtQtyPerUnit.Tag = "qty_per_unit";
            this.txtQtyPerUnit.Text = "1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(353, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbOtherItem
            // 
            this.cmbOtherItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOtherItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOtherItem.BackColor = System.Drawing.Color.Linen;
            this.cmbOtherItem.FormattingEnabled = true;
            this.cmbOtherItem.Location = new System.Drawing.Point(85, 13);
            this.cmbOtherItem.MaxLength = 50;
            this.cmbOtherItem.Name = "cmbOtherItem";
            this.cmbOtherItem.Size = new System.Drawing.Size(225, 21);
            this.cmbOtherItem.Sorted = true;
            this.cmbOtherItem.TabIndex = 86;
            this.cmbOtherItem.Tag = "other_item_id";
            // 
            // lblOtherItem
            // 
            this.lblOtherItem.AutoSize = true;
            this.lblOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherItem.Location = new System.Drawing.Point(9, 16);
            this.lblOtherItem.Name = "lblOtherItem";
            this.lblOtherItem.Size = new System.Drawing.Size(70, 13);
            this.lblOtherItem.TabIndex = 88;
            this.lblOtherItem.Text = "Other Item:";
            this.lblOtherItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(316, 17);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(80, 13);
            this.lblQtyPerUnit.TabIndex = 89;
            this.lblQtyPerUnit.Text = "Qty Per Unit:";
            this.lblQtyPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(26, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // grpOPDPatient
            // 
            this.grpOPDPatient.Controls.Add(this.label11);
            this.grpOPDPatient.Controls.Add(this.lblAgeDd);
            this.grpOPDPatient.Controls.Add(this.txtAgeDd);
            this.grpOPDPatient.Controls.Add(this.lblAgeMm);
            this.grpOPDPatient.Controls.Add(this.txtAgeMm);
            this.grpOPDPatient.Controls.Add(this.lblAgeYy);
            this.grpOPDPatient.Controls.Add(this.txtAgeYy);
            this.grpOPDPatient.Controls.Add(this.btnPatientSave);
            this.grpOPDPatient.Controls.Add(this.txtAdd);
            this.grpOPDPatient.Controls.Add(this.label10);
            this.grpOPDPatient.Controls.Add(this.label9);
            this.grpOPDPatient.Controls.Add(this.dtpDOB);
            this.grpOPDPatient.Controls.Add(this.label3);
            this.grpOPDPatient.Controls.Add(this.cmbCity);
            this.grpOPDPatient.Controls.Add(this.label2);
            this.grpOPDPatient.Controls.Add(this.label1);
            this.grpOPDPatient.Controls.Add(this.txtPatientName);
            this.grpOPDPatient.Controls.Add(this.lblRoomNo);
            this.grpOPDPatient.Controls.Add(this.txtCntactNo);
            this.grpOPDPatient.Controls.Add(this.txtHospitalID);
            this.grpOPDPatient.Controls.Add(this.lblProductType);
            this.grpOPDPatient.Controls.Add(this.cmbGender);
            this.grpOPDPatient.Controls.Add(this.lblRequisitionNo);
            this.grpOPDPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOPDPatient.Location = new System.Drawing.Point(23, 55);
            this.grpOPDPatient.Name = "grpOPDPatient";
            this.grpOPDPatient.Size = new System.Drawing.Size(443, 157);
            this.grpOPDPatient.TabIndex = 72;
            this.grpOPDPatient.TabStop = false;
            this.grpOPDPatient.Text = "Patient";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "Age:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAgeDd
            // 
            this.lblAgeDd.AutoSize = true;
            this.lblAgeDd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeDd.Location = new System.Drawing.Point(253, 69);
            this.lblAgeDd.Name = "lblAgeDd";
            this.lblAgeDd.Size = new System.Drawing.Size(16, 13);
            this.lblAgeDd.TabIndex = 91;
            this.lblAgeDd.Text = "D";
            this.lblAgeDd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeDd
            // 
            this.txtAgeDd.BackColor = System.Drawing.Color.White;
            this.txtAgeDd.Location = new System.Drawing.Point(216, 65);
            this.txtAgeDd.MaxLength = 2;
            this.txtAgeDd.Name = "txtAgeDd";
            this.txtAgeDd.Size = new System.Drawing.Size(33, 20);
            this.txtAgeDd.TabIndex = 5;
            this.txtAgeDd.Tag = "age_dd";
            this.txtAgeDd.Text = "00";
            this.txtAgeDd.Leave += new System.EventHandler(this.txtAgeDd_Leave);
            this.txtAgeDd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeDd_KeyPress);
            // 
            // lblAgeMm
            // 
            this.lblAgeMm.AutoSize = true;
            this.lblAgeMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeMm.Location = new System.Drawing.Point(192, 68);
            this.lblAgeMm.Name = "lblAgeMm";
            this.lblAgeMm.Size = new System.Drawing.Size(17, 13);
            this.lblAgeMm.TabIndex = 92;
            this.lblAgeMm.Text = "M";
            this.lblAgeMm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeMm
            // 
            this.txtAgeMm.BackColor = System.Drawing.Color.White;
            this.txtAgeMm.Location = new System.Drawing.Point(154, 65);
            this.txtAgeMm.MaxLength = 2;
            this.txtAgeMm.Name = "txtAgeMm";
            this.txtAgeMm.Size = new System.Drawing.Size(33, 20);
            this.txtAgeMm.TabIndex = 4;
            this.txtAgeMm.Tag = "age_mm";
            this.txtAgeMm.Text = "00";
            this.txtAgeMm.Leave += new System.EventHandler(this.txtAgeMm_Leave);
            this.txtAgeMm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeMm_KeyPress);
            // 
            // lblAgeYy
            // 
            this.lblAgeYy.AutoSize = true;
            this.lblAgeYy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeYy.Location = new System.Drawing.Point(135, 68);
            this.lblAgeYy.Name = "lblAgeYy";
            this.lblAgeYy.Size = new System.Drawing.Size(15, 13);
            this.lblAgeYy.TabIndex = 93;
            this.lblAgeYy.Text = "Y";
            this.lblAgeYy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAgeYy
            // 
            this.txtAgeYy.BackColor = System.Drawing.Color.White;
            this.txtAgeYy.Location = new System.Drawing.Point(97, 64);
            this.txtAgeYy.MaxLength = 2;
            this.txtAgeYy.Name = "txtAgeYy";
            this.txtAgeYy.Size = new System.Drawing.Size(33, 20);
            this.txtAgeYy.TabIndex = 3;
            this.txtAgeYy.Tag = "age_yy";
            this.txtAgeYy.Text = "00";
            this.txtAgeYy.Leave += new System.EventHandler(this.txtAgeYy_Leave);
            this.txtAgeYy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgeYy_KeyPress);
            // 
            // btnPatientSave
            // 
            this.btnPatientSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnPatientSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientSave.Location = new System.Drawing.Point(354, 125);
            this.btnPatientSave.Name = "btnPatientSave";
            this.btnPatientSave.Size = new System.Drawing.Size(83, 28);
            this.btnPatientSave.TabIndex = 9;
            this.btnPatientSave.Text = "   Save";
            this.btnPatientSave.UseVisualStyleBackColor = true;
            this.btnPatientSave.Click += new System.EventHandler(this.btnPatientSave_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(95, 120);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(244, 31);
            this.txtAdd.TabIndex = 8;
            this.txtAdd.Tag = "contact_no";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 86;
            this.label10.Text = "OPD";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "City";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(333, 63);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(104, 20);
            this.dtpDOB.TabIndex = 10;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            this.dtpDOB.Leave += new System.EventHandler(this.dtpDOB_Leave);
            this.dtpDOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDOB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.ItemHeight = 13;
            this.cmbCity.Items.AddRange(new object[] {
            "<Select>",
            "Female",
            "Male"});
            this.cmbCity.Location = new System.Drawing.Point(95, 92);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 6;
            this.cmbCity.Tag = "gender_id";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            this.cmbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "DOB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Patient Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(95, 39);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(342, 20);
            this.txtPatientName.TabIndex = 2;
            this.txtPatientName.Tag = "patient_name";
            this.txtPatientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientName_KeyPress);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(225, 95);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(61, 13);
            this.lblRoomNo.TabIndex = 77;
            this.lblRoomNo.Text = "Contact No";
            // 
            // txtCntactNo
            // 
            this.txtCntactNo.Location = new System.Drawing.Point(299, 93);
            this.txtCntactNo.Name = "txtCntactNo";
            this.txtCntactNo.Size = new System.Drawing.Size(138, 20);
            this.txtCntactNo.TabIndex = 7;
            this.txtCntactNo.Tag = "contact_no";
            this.txtCntactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCntactNo_KeyPress);
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalID.Location = new System.Drawing.Point(134, 13);
            this.txtHospitalID.MaxLength = 13;
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.ReadOnly = true;
            this.txtHospitalID.Size = new System.Drawing.Size(91, 20);
            this.txtHospitalID.TabIndex = 0;
            this.txtHospitalID.Tag = "patient_hospital_id";
            this.txtHospitalID.Leave += new System.EventHandler(this.txtHospitalID_Leave);
            this.txtHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospitalID_KeyPress);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(291, 16);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(48, 13);
            this.lblProductType.TabIndex = 75;
            this.lblProductType.Text = "Gender";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "<Select>",
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(353, 13);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(84, 21);
            this.cmbGender.TabIndex = 1;
            this.cmbGender.Tag = "gender_id";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            this.cmbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGender_KeyPress);
            // 
            // lblRequisitionNo
            // 
            this.lblRequisitionNo.AutoSize = true;
            this.lblRequisitionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionNo.Location = new System.Drawing.Point(6, 16);
            this.lblRequisitionNo.Name = "lblRequisitionNo";
            this.lblRequisitionNo.Size = new System.Drawing.Size(70, 13);
            this.lblRequisitionNo.TabIndex = 73;
            this.lblRequisitionNo.Text = "Hospital ID";
            this.lblRequisitionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDeptConsult
            // 
            this.grpDeptConsult.Controls.Add(this.radioPM);
            this.grpDeptConsult.Controls.Add(this.radioAM);
            this.grpDeptConsult.Controls.Add(this.lvwMain);
            this.grpDeptConsult.Controls.Add(this.mskTime);
            this.grpDeptConsult.Controls.Add(this.label6);
            this.grpDeptConsult.Controls.Add(this.cmbConsultant);
            this.grpDeptConsult.Controls.Add(this.txtRoom);
            this.grpDeptConsult.Controls.Add(this.label5);
            this.grpDeptConsult.Controls.Add(this.label4);
            this.grpDeptConsult.Controls.Add(this.cmbDepartment);
            this.grpDeptConsult.Controls.Add(this.dtpDate);
            this.grpDeptConsult.Controls.Add(this.label8);
            this.grpDeptConsult.Controls.Add(this.label7);
            this.grpDeptConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeptConsult.Location = new System.Drawing.Point(23, 316);
            this.grpDeptConsult.Name = "grpDeptConsult";
            this.grpDeptConsult.Size = new System.Drawing.Size(443, 93);
            this.grpDeptConsult.TabIndex = 71;
            this.grpDeptConsult.TabStop = false;
            this.grpDeptConsult.Visible = false;
            // 
            // radioPM
            // 
            this.radioPM.AutoSize = true;
            this.radioPM.Checked = true;
            this.radioPM.Location = new System.Drawing.Point(380, 69);
            this.radioPM.Name = "radioPM";
            this.radioPM.Size = new System.Drawing.Size(43, 17);
            this.radioPM.TabIndex = 13;
            this.radioPM.TabStop = true;
            this.radioPM.Text = "PM";
            this.radioPM.UseVisualStyleBackColor = true;
            // 
            // radioAM
            // 
            this.radioAM.AutoSize = true;
            this.radioAM.Location = new System.Drawing.Point(331, 67);
            this.radioAM.Name = "radioAM";
            this.radioAM.Size = new System.Drawing.Size(43, 17);
            this.radioAM.TabIndex = 12;
            this.radioAM.Text = "AM";
            this.radioAM.UseVisualStyleBackColor = true;
            // 
            // lvwMain
            // 
            this.lvwMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwMain.FullRowSelect = true;
            this.lvwMain.GridLines = true;
            this.lvwMain.Location = new System.Drawing.Point(0, 45);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(443, 48);
            this.lvwMain.TabIndex = 84;
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.View = System.Windows.Forms.View.Details;
            this.lvwMain.Click += new System.EventHandler(this.lvwMain_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL. No.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patient Name";
            this.columnHeader2.Width = 259;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Booking ID";
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(285, 65);
            this.mskTime.Mask = "90:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(40, 20);
            this.mskTime.TabIndex = 11;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            this.mskTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Consultant";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbConsultant
            // 
            this.cmbConsultant.FormattingEnabled = true;
            this.cmbConsultant.Location = new System.Drawing.Point(95, 40);
            this.cmbConsultant.Name = "cmbConsultant";
            this.cmbConsultant.Size = new System.Drawing.Size(136, 21);
            this.cmbConsultant.TabIndex = 8;
            this.cmbConsultant.Tag = "reffered_doctors_id";
            this.cmbConsultant.SelectedIndexChanged += new System.EventHandler(this.cmbConsultant_SelectedIndexChanged);
            this.cmbConsultant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbConsultant_KeyPress);
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(315, 40);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(56, 20);
            this.txtRoom.TabIndex = 9;
            this.txtRoom.Tag = "room_no";
            this.txtRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoom_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Room No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Department";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(95, 15);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(136, 21);
            this.cmbDepartment.TabIndex = 7;
            this.cmbDepartment.Tag = "department_id";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            this.cmbDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDepartment_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(96, 65);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(96, 20);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.Tag = "booking_date";
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.Leave += new System.EventHandler(this.dtpDate_Leave);
            this.dtpDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDate_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequisitionTitle
            // 
            this.lblRequisitionTitle.AutoSize = true;
            this.lblRequisitionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequisitionTitle.Location = new System.Drawing.Point(182, 13);
            this.lblRequisitionTitle.Name = "lblRequisitionTitle";
            this.lblRequisitionTitle.Size = new System.Drawing.Size(127, 31);
            this.lblRequisitionTitle.TabIndex = 31;
            this.lblRequisitionTitle.Text = "Outdoor ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(310, 513);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(221, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "   Save";
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
            this.btnClose.Location = new System.Drawing.Point(401, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintSampleCollected
            // 
            this.btnPrintSampleCollected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintSampleCollected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSampleCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSampleCollected.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrintSampleCollected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintSampleCollected.Location = new System.Drawing.Point(20, 514);
            this.btnPrintSampleCollected.Name = "btnPrintSampleCollected";
            this.btnPrintSampleCollected.Size = new System.Drawing.Size(79, 25);
            this.btnPrintSampleCollected.TabIndex = 18;
            this.btnPrintSampleCollected.Text = "Print";
            this.btnPrintSampleCollected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintSampleCollected.UseVisualStyleBackColor = true;
            this.btnPrintSampleCollected.Visible = false;
            this.btnPrintSampleCollected.Click += new System.EventHandler(this.btnPrintSampleCollected_Click);
            // 
            // btnPList
            // 
            this.btnPList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPList.Location = new System.Drawing.Point(105, 516);
            this.btnPList.Name = "btnPList";
            this.btnPList.Size = new System.Drawing.Size(97, 25);
            this.btnPList.TabIndex = 19;
            this.btnPList.Text = " Print Patient List";
            this.btnPList.UseVisualStyleBackColor = true;
            this.btnPList.Click += new System.EventHandler(this.btnPList_Click);
            // 
            // FrmOutdoorBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(538, 544);
            this.Controls.Add(this.btnPrintSampleCollected);
            this.Controls.Add(this.btnPList);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOutdoorBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outdoor Booking";
            this.Load += new System.EventHandler(this.FrmOutdoorBooking_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpOtherItem.ResumeLayout(false);
            this.grpOtherItem.PerformLayout();
            this.grpAmount.ResumeLayout(false);
            this.grpAmount.PerformLayout();
            this.grpOPDPatient.ResumeLayout(false);
            this.grpOPDPatient.PerformLayout();
            this.grpDeptConsult.ResumeLayout(false);
            this.grpDeptConsult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox grpOPDPatient;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.TextBox txtCntactNo;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblRequisitionNo;
        private System.Windows.Forms.GroupBox grpDeptConsult;
        private System.Windows.Forms.RadioButton radioPM;
        private System.Windows.Forms.RadioButton radioAM;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbConsultant;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRequisitionTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrintSampleCollected;
        private System.Windows.Forms.GroupBox grpAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnPList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grpOtherItem;
        private System.Windows.Forms.TextBox txtQtyPerUnit;
        private System.Windows.Forms.ComboBox cmbOtherItem;
        private System.Windows.Forms.Label lblOtherItem;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.ListView lvwPatientOtherItem;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader quentity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader charge;
        private System.Windows.Forms.TextBox txtcharge;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Button btnPatientSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAgeDd;
        private System.Windows.Forms.TextBox txtAgeDd;
        private System.Windows.Forms.Label lblAgeMm;
        private System.Windows.Forms.TextBox txtAgeMm;
        private System.Windows.Forms.Label lblAgeYy;
        private System.Windows.Forms.TextBox txtAgeYy;
        private System.Windows.Forms.Label lblNetPayable;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtNetPayable;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.LinkLabel lblSearch;
    }
}