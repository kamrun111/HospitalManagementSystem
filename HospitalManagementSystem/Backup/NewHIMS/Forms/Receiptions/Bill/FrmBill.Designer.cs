namespace NewHIMS.Forms.Receiptions.Bill
{
    partial class FrmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBill));
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.is_discharged = new System.Windows.Forms.ColumnHeader();
            this.guardian_name = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.grpBill = new System.Windows.Forms.GroupBox();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblRefund = new System.Windows.Forms.Label();
            this.txtRefund = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.lblLoan = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.lblCabinCharge = new System.Windows.Forms.Label();
            this.txtCabinCharge = new System.Windows.Forms.TextBox();
            this.lblAditionalCharge = new System.Windows.Forms.Label();
            this.txtAditionalCharge = new System.Windows.Forms.TextBox();
            this.txtDTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPayableAmount = new System.Windows.Forms.Label();
            this.grdDoctorsBill = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redeuced_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reduced_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultant_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_visit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDoctorsBill = new System.Windows.Forms.Label();
            this.txtDoctorsBill = new System.Windows.Forms.TextBox();
            this.txtDoctorParcentage = new System.Windows.Forms.TextBox();
            this.txtDoctorVat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVatforDoctor = new System.Windows.Forms.Label();
            this.txtOtDoctor = new System.Windows.Forms.TextBox();
            this.txtVistDoctor = new System.Windows.Forms.TextBox();
            this.btnvisit = new System.Windows.Forms.Button();
            this.lblOtDoctor = new System.Windows.Forms.Label();
            this.lblSaleMedicine = new System.Windows.Forms.Label();
            this.lblRefundMedicine = new System.Windows.Forms.Label();
            this.txtSaleMedicine = new System.Windows.Forms.TextBox();
            this.txtRefundMedicine = new System.Windows.Forms.TextBox();
            this.lblPostOperative = new System.Windows.Forms.Label();
            this.lblOTcharges = new System.Windows.Forms.Label();
            this.txtOtcharge = new System.Windows.Forms.TextBox();
            this.txtPostOperative = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtAdmissionFee = new System.Windows.Forms.TextBox();
            this.lblAdmissionFee = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtNetPayable = new System.Windows.Forms.TextBox();
            this.lblNetPayable = new System.Windows.Forms.Label();
            this.lvwBill = new System.Windows.Forms.ListView();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.item = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.unit_charge = new System.Windows.Forms.ColumnHeader();
            this.total_charge = new System.Windows.Forms.ColumnHeader();
            this.d_id = new System.Windows.Forms.ColumnHeader();
            this.g_id = new System.Windows.Forms.ColumnHeader();
            this.t_id = new System.Windows.Forms.ColumnHeader();
            this.reedoc_id = new System.Windows.Forms.ColumnHeader();
            this.reffered_by = new System.Windows.Forms.ColumnHeader();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lvwAdvance = new System.Windows.Forms.ListView();
            this.ams = new System.Windows.Forms.ColumnHeader();
            this.receipt_no = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.advance = new System.Windows.Forms.ColumnHeader();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnRoomRent = new System.Windows.Forms.Button();
            this.txtRoomRent = new System.Windows.Forms.TextBox();
            this.lblRoomRent = new System.Windows.Forms.Label();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.btnOtherServices = new System.Windows.Forms.Button();
            this.txtOtherServices = new System.Windows.Forms.TextBox();
            this.lblOtherServices = new System.Windows.Forms.Label();
            this.btnOt = new System.Windows.Forms.Button();
            this.txtOt = new System.Windows.Forms.TextBox();
            this.lblOt = new System.Windows.Forms.Label();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.btnInvestigation = new System.Windows.Forms.Button();
            this.txtInvestigation = new System.Windows.Forms.TextBox();
            this.lblInvestigation = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lvlGrandTotal = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvwDue = new System.Windows.Forms.ListView();
            this.cabins = new System.Windows.Forms.ColumnHeader();
            this.patient_codes = new System.Windows.Forms.ColumnHeader();
            this.admission_ids = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lblDue = new System.Windows.Forms.Label();
            this.grpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctorsBill)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.patient_code,
            this.admission_id,
            this.patient_name,
            this.is_discharged,
            this.guardian_name,
            this.address,
            this.phone});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(1, 34);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(234, 410);
            this.lvwPatientInfo.TabIndex = 5;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwPatientInfo_KeyPress);
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 47;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 78;
            // 
            // admission_id
            // 
            this.admission_id.Name = "admission_id";
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // patient_name
            // 
            this.patient_name.Text = "P. Name";
            this.patient_name.Width = 103;
            // 
            // is_discharged
            // 
            this.is_discharged.Text = "Discharge";
            this.is_discharged.Width = 0;
            // 
            // guardian_name
            // 
            this.guardian_name.Text = "GrdName";
            this.guardian_name.Width = 0;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 0;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 0;
            // 
            // grpBill
            // 
            this.grpBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBill.Controls.Add(this.txtEquation);
            this.grpBill.Controls.Add(this.btnPrint);
            this.grpBill.Controls.Add(this.txtRemarks);
            this.grpBill.Controls.Add(this.lblRemarks);
            this.grpBill.Controls.Add(this.txtSerialNo);
            this.grpBill.Controls.Add(this.lblRefund);
            this.grpBill.Controls.Add(this.txtRefund);
            this.grpBill.Controls.Add(this.btnRefund);
            this.grpBill.Controls.Add(this.btnLoan);
            this.grpBill.Controls.Add(this.lblLoan);
            this.grpBill.Controls.Add(this.txtLoan);
            this.grpBill.Controls.Add(this.lblCabinCharge);
            this.grpBill.Controls.Add(this.txtCabinCharge);
            this.grpBill.Controls.Add(this.lblAditionalCharge);
            this.grpBill.Controls.Add(this.txtAditionalCharge);
            this.grpBill.Controls.Add(this.txtDTotal);
            this.grpBill.Controls.Add(this.label1);
            this.grpBill.Controls.Add(this.lblPayableAmount);
            this.grpBill.Controls.Add(this.grdDoctorsBill);
            this.grpBill.Controls.Add(this.lblDoctorsBill);
            this.grpBill.Controls.Add(this.txtDoctorsBill);
            this.grpBill.Controls.Add(this.txtDoctorParcentage);
            this.grpBill.Controls.Add(this.txtDoctorVat);
            this.grpBill.Controls.Add(this.label2);
            this.grpBill.Controls.Add(this.lblVatforDoctor);
            this.grpBill.Controls.Add(this.txtOtDoctor);
            this.grpBill.Controls.Add(this.txtVistDoctor);
            this.grpBill.Controls.Add(this.btnvisit);
            this.grpBill.Controls.Add(this.lblOtDoctor);
            this.grpBill.Controls.Add(this.lblSaleMedicine);
            this.grpBill.Controls.Add(this.lblRefundMedicine);
            this.grpBill.Controls.Add(this.txtSaleMedicine);
            this.grpBill.Controls.Add(this.txtRefundMedicine);
            this.grpBill.Controls.Add(this.lblPostOperative);
            this.grpBill.Controls.Add(this.lblOTcharges);
            this.grpBill.Controls.Add(this.txtOtcharge);
            this.grpBill.Controls.Add(this.txtPostOperative);
            this.grpBill.Controls.Add(this.btnPreview);
            this.grpBill.Controls.Add(this.txtAdmissionFee);
            this.grpBill.Controls.Add(this.lblAdmissionFee);
            this.grpBill.Controls.Add(this.txtdiscount);
            this.grpBill.Controls.Add(this.lblDiscount);
            this.grpBill.Controls.Add(this.txtSubTotal);
            this.grpBill.Controls.Add(this.lblSubTotal);
            this.grpBill.Controls.Add(this.txtPercentage);
            this.grpBill.Controls.Add(this.txtVat);
            this.grpBill.Controls.Add(this.lblPercentage);
            this.grpBill.Controls.Add(this.lblVat);
            this.grpBill.Controls.Add(this.txtNetPayable);
            this.grpBill.Controls.Add(this.lblNetPayable);
            this.grpBill.Controls.Add(this.lvwBill);
            this.grpBill.Controls.Add(this.btnAdvance);
            this.grpBill.Controls.Add(this.txtAdvance);
            this.grpBill.Controls.Add(this.lblAdvance);
            this.grpBill.Controls.Add(this.lvwAdvance);
            this.grpBill.Controls.Add(this.btnDoctor);
            this.grpBill.Controls.Add(this.txtDoctor);
            this.grpBill.Controls.Add(this.lblDoctor);
            this.grpBill.Controls.Add(this.btnRoomRent);
            this.grpBill.Controls.Add(this.txtRoomRent);
            this.grpBill.Controls.Add(this.lblRoomRent);
            this.grpBill.Controls.Add(this.btnMedicine);
            this.grpBill.Controls.Add(this.txtMedicine);
            this.grpBill.Controls.Add(this.btnOtherServices);
            this.grpBill.Controls.Add(this.txtOtherServices);
            this.grpBill.Controls.Add(this.lblOtherServices);
            this.grpBill.Controls.Add(this.btnOt);
            this.grpBill.Controls.Add(this.txtOt);
            this.grpBill.Controls.Add(this.lblOt);
            this.grpBill.Controls.Add(this.btnTreatment);
            this.grpBill.Controls.Add(this.txtTreatment);
            this.grpBill.Controls.Add(this.lblTreatment);
            this.grpBill.Controls.Add(this.lblMedicine);
            this.grpBill.Controls.Add(this.btnInvestigation);
            this.grpBill.Controls.Add(this.txtInvestigation);
            this.grpBill.Controls.Add(this.lblInvestigation);
            this.grpBill.Controls.Add(this.txtTotal);
            this.grpBill.Controls.Add(this.lvlGrandTotal);
            this.grpBill.Controls.Add(this.lblBillTitle);
            this.grpBill.Controls.Add(this.btnRefresh);
            this.grpBill.Controls.Add(this.btnSave);
            this.grpBill.Controls.Add(this.btnClose);
            this.grpBill.Location = new System.Drawing.Point(241, 2);
            this.grpBill.Name = "grpBill";
            this.grpBill.Size = new System.Drawing.Size(755, 633);
            this.grpBill.TabIndex = 6;
            this.grpBill.TabStop = false;
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(6, 423);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(412, 20);
            this.txtEquation.TabIndex = 113;
            this.txtEquation.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(340, 599);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 28);
            this.btnPrint.TabIndex = 112;
            this.btnPrint.Text = "Re-Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(530, 283);
            this.txtRemarks.MaxLength = 240;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(219, 92);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.Visible = false;
            this.txtRemarks.Leave += new System.EventHandler(this.txtRemarks_Leave);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.White;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRemarks.Location = new System.Drawing.Point(531, 270);
            this.lblRemarks.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(56, 13);
            this.lblRemarks.TabIndex = 12;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(648, 399);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(103, 20);
            this.txtSerialNo.TabIndex = 11;
            this.txtSerialNo.Visible = false;
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.Location = new System.Drawing.Point(487, 422);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(53, 15);
            this.lblRefund.TabIndex = 111;
            this.lblRefund.Text = "Refund";
            // 
            // txtRefund
            // 
            this.txtRefund.Location = new System.Drawing.Point(649, 421);
            this.txtRefund.MaxLength = 8;
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.ReadOnly = true;
            this.txtRefund.Size = new System.Drawing.Size(101, 20);
            this.txtRefund.TabIndex = 110;
            this.txtRefund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(430, 189);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(49, 23);
            this.btnRefund.TabIndex = 109;
            this.btnRefund.Text = "Details";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(429, 259);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(49, 23);
            this.btnLoan.TabIndex = 108;
            this.btnLoan.Text = "Details";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(487, 262);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(39, 15);
            this.lblLoan.TabIndex = 107;
            this.lblLoan.Text = "Loan";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(690, 261);
            this.txtLoan.MaxLength = 8;
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.ReadOnly = true;
            this.txtLoan.Size = new System.Drawing.Size(60, 20);
            this.txtLoan.TabIndex = 106;
            this.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCabinCharge
            // 
            this.lblCabinCharge.AutoSize = true;
            this.lblCabinCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinCharge.Location = new System.Drawing.Point(510, 223);
            this.lblCabinCharge.Name = "lblCabinCharge";
            this.lblCabinCharge.Size = new System.Drawing.Size(83, 13);
            this.lblCabinCharge.TabIndex = 105;
            this.lblCabinCharge.Text = "Cabin Charge";
            // 
            // txtCabinCharge
            // 
            this.txtCabinCharge.Location = new System.Drawing.Point(689, 217);
            this.txtCabinCharge.MaxLength = 8;
            this.txtCabinCharge.Name = "txtCabinCharge";
            this.txtCabinCharge.ReadOnly = true;
            this.txtCabinCharge.Size = new System.Drawing.Size(60, 20);
            this.txtCabinCharge.TabIndex = 104;
            this.txtCabinCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAditionalCharge
            // 
            this.lblAditionalCharge.AutoSize = true;
            this.lblAditionalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAditionalCharge.Location = new System.Drawing.Point(508, 117);
            this.lblAditionalCharge.Name = "lblAditionalCharge";
            this.lblAditionalCharge.Size = new System.Drawing.Size(100, 13);
            this.lblAditionalCharge.TabIndex = 103;
            this.lblAditionalCharge.Text = "Aditional Charge";
            // 
            // txtAditionalCharge
            // 
            this.txtAditionalCharge.Location = new System.Drawing.Point(633, 117);
            this.txtAditionalCharge.MaxLength = 8;
            this.txtAditionalCharge.Name = "txtAditionalCharge";
            this.txtAditionalCharge.ReadOnly = true;
            this.txtAditionalCharge.Size = new System.Drawing.Size(54, 20);
            this.txtAditionalCharge.TabIndex = 102;
            this.txtAditionalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDTotal
            // 
            this.txtDTotal.Location = new System.Drawing.Point(689, 570);
            this.txtDTotal.MaxLength = 8;
            this.txtDTotal.Name = "txtDTotal";
            this.txtDTotal.ReadOnly = true;
            this.txtDTotal.Size = new System.Drawing.Size(60, 20);
            this.txtDTotal.TabIndex = 101;
            this.txtDTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(487, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Payable Amount";
            // 
            // lblPayableAmount
            // 
            this.lblPayableAmount.AutoSize = true;
            this.lblPayableAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayableAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPayableAmount.Location = new System.Drawing.Point(486, 549);
            this.lblPayableAmount.Name = "lblPayableAmount";
            this.lblPayableAmount.Size = new System.Drawing.Size(104, 17);
            this.lblPayableAmount.TabIndex = 99;
            this.lblPayableAmount.Text = "Total Amount";
            // 
            // grdDoctorsBill
            // 
            this.grdDoctorsBill.AllowUserToDeleteRows = false;
            this.grdDoctorsBill.AllowUserToOrderColumns = true;
            this.grdDoctorsBill.AllowUserToResizeColumns = false;
            this.grdDoctorsBill.AllowUserToResizeRows = false;
            this.grdDoctorsBill.BackgroundColor = System.Drawing.Color.Linen;
            this.grdDoctorsBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDoctorsBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoctorsBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.charge,
            this.qty,
            this.totalcharge,
            this.redeuced_qty,
            this.reduced_amount,
            this.payable,
            this.consultant_id,
            this.is_visit});
            this.grdDoctorsBill.GridColor = System.Drawing.Color.Linen;
            this.grdDoctorsBill.Location = new System.Drawing.Point(6, 449);
            this.grdDoctorsBill.Name = "grdDoctorsBill";
            this.grdDoctorsBill.RowHeadersVisible = false;
            this.grdDoctorsBill.Size = new System.Drawing.Size(412, 145);
            this.grdDoctorsBill.TabIndex = 98;
            this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
            // 
            // name
            // 
            this.name.HeaderText = "Doctor\'s Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 110;
            // 
            // charge
            // 
            this.charge.HeaderText = "Charge";
            this.charge.Name = "charge";
            this.charge.ReadOnly = true;
            this.charge.Width = 48;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 40;
            // 
            // totalcharge
            // 
            this.totalcharge.HeaderText = "Total Charge";
            this.totalcharge.Name = "totalcharge";
            this.totalcharge.ReadOnly = true;
            this.totalcharge.Width = 50;
            // 
            // redeuced_qty
            // 
            this.redeuced_qty.HeaderText = "R.QTY";
            this.redeuced_qty.Name = "redeuced_qty";
            this.redeuced_qty.Width = 50;
            // 
            // reduced_amount
            // 
            this.reduced_amount.HeaderText = "R.Amount";
            this.reduced_amount.Name = "reduced_amount";
            this.reduced_amount.Width = 60;
            // 
            // payable
            // 
            this.payable.HeaderText = "Payable Amount";
            this.payable.Name = "payable";
            this.payable.ReadOnly = true;
            this.payable.Width = 70;
            // 
            // consultant_id
            // 
            this.consultant_id.HeaderText = "DoctorsID";
            this.consultant_id.Name = "consultant_id";
            this.consultant_id.Visible = false;
            // 
            // is_visit
            // 
            this.is_visit.HeaderText = "Visit";
            this.is_visit.Name = "is_visit";
            this.is_visit.Visible = false;
            // 
            // lblDoctorsBill
            // 
            this.lblDoctorsBill.AutoSize = true;
            this.lblDoctorsBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorsBill.ForeColor = System.Drawing.Color.Turquoise;
            this.lblDoctorsBill.Location = new System.Drawing.Point(484, 463);
            this.lblDoctorsBill.Name = "lblDoctorsBill";
            this.lblDoctorsBill.Size = new System.Drawing.Size(105, 20);
            this.lblDoctorsBill.TabIndex = 97;
            this.lblDoctorsBill.Text = "Doctor\'s Bill";
            // 
            // txtDoctorsBill
            // 
            this.txtDoctorsBill.Location = new System.Drawing.Point(690, 548);
            this.txtDoctorsBill.MaxLength = 8;
            this.txtDoctorsBill.Name = "txtDoctorsBill";
            this.txtDoctorsBill.ReadOnly = true;
            this.txtDoctorsBill.Size = new System.Drawing.Size(60, 20);
            this.txtDoctorsBill.TabIndex = 96;
            this.txtDoctorsBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDoctorParcentage
            // 
            this.txtDoctorParcentage.Location = new System.Drawing.Point(638, 525);
            this.txtDoctorParcentage.MaxLength = 4;
            this.txtDoctorParcentage.Name = "txtDoctorParcentage";
            this.txtDoctorParcentage.Size = new System.Drawing.Size(36, 20);
            this.txtDoctorParcentage.TabIndex = 95;
            this.txtDoctorParcentage.Text = "4.5";
            this.txtDoctorParcentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDoctorParcentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorParcentage_KeyPress);
            // 
            // txtDoctorVat
            // 
            this.txtDoctorVat.Location = new System.Drawing.Point(690, 525);
            this.txtDoctorVat.MaxLength = 6;
            this.txtDoctorVat.Name = "txtDoctorVat";
            this.txtDoctorVat.ReadOnly = true;
            this.txtDoctorVat.Size = new System.Drawing.Size(60, 20);
            this.txtDoctorVat.TabIndex = 94;
            this.txtDoctorVat.Text = "0.0";
            this.txtDoctorVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "%";
            // 
            // lblVatforDoctor
            // 
            this.lblVatforDoctor.AutoSize = true;
            this.lblVatforDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatforDoctor.Location = new System.Drawing.Point(486, 525);
            this.lblVatforDoctor.Name = "lblVatforDoctor";
            this.lblVatforDoctor.Size = new System.Drawing.Size(38, 17);
            this.lblVatforDoctor.TabIndex = 92;
            this.lblVatforDoctor.Text = "VAT";
            // 
            // txtOtDoctor
            // 
            this.txtOtDoctor.Location = new System.Drawing.Point(633, 482);
            this.txtOtDoctor.MaxLength = 8;
            this.txtOtDoctor.Name = "txtOtDoctor";
            this.txtOtDoctor.ReadOnly = true;
            this.txtOtDoctor.Size = new System.Drawing.Size(56, 20);
            this.txtOtDoctor.TabIndex = 91;
            this.txtOtDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVistDoctor
            // 
            this.txtVistDoctor.Location = new System.Drawing.Point(633, 503);
            this.txtVistDoctor.MaxLength = 8;
            this.txtVistDoctor.Name = "txtVistDoctor";
            this.txtVistDoctor.ReadOnly = true;
            this.txtVistDoctor.Size = new System.Drawing.Size(57, 20);
            this.txtVistDoctor.TabIndex = 90;
            this.txtVistDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnvisit
            // 
            this.btnvisit.Location = new System.Drawing.Point(430, 502);
            this.btnvisit.Name = "btnvisit";
            this.btnvisit.Size = new System.Drawing.Size(49, 26);
            this.btnvisit.TabIndex = 89;
            this.btnvisit.Text = "Details";
            this.btnvisit.UseVisualStyleBackColor = true;
            this.btnvisit.Visible = false;
            this.btnvisit.Click += new System.EventHandler(this.btnvisit_Click);
            // 
            // lblOtDoctor
            // 
            this.lblOtDoctor.AutoSize = true;
            this.lblOtDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtDoctor.Location = new System.Drawing.Point(508, 485);
            this.lblOtDoctor.Name = "lblOtDoctor";
            this.lblOtDoctor.Size = new System.Drawing.Size(96, 13);
            this.lblOtDoctor.TabIndex = 87;
            this.lblOtDoctor.Text = "OT Doctor\'s Bill";
            // 
            // lblSaleMedicine
            // 
            this.lblSaleMedicine.AutoSize = true;
            this.lblSaleMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleMedicine.Location = new System.Drawing.Point(508, 174);
            this.lblSaleMedicine.Name = "lblSaleMedicine";
            this.lblSaleMedicine.Size = new System.Drawing.Size(87, 13);
            this.lblSaleMedicine.TabIndex = 86;
            this.lblSaleMedicine.Text = "Medicine Sale";
            // 
            // lblRefundMedicine
            // 
            this.lblRefundMedicine.AutoSize = true;
            this.lblRefundMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundMedicine.Location = new System.Drawing.Point(508, 192);
            this.lblRefundMedicine.Name = "lblRefundMedicine";
            this.lblRefundMedicine.Size = new System.Drawing.Size(103, 13);
            this.lblRefundMedicine.TabIndex = 85;
            this.lblRefundMedicine.Text = "Medicine Refund";
            // 
            // txtSaleMedicine
            // 
            this.txtSaleMedicine.Location = new System.Drawing.Point(637, 171);
            this.txtSaleMedicine.MaxLength = 8;
            this.txtSaleMedicine.Name = "txtSaleMedicine";
            this.txtSaleMedicine.ReadOnly = true;
            this.txtSaleMedicine.Size = new System.Drawing.Size(54, 20);
            this.txtSaleMedicine.TabIndex = 84;
            this.txtSaleMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRefundMedicine
            // 
            this.txtRefundMedicine.Location = new System.Drawing.Point(637, 191);
            this.txtRefundMedicine.MaxLength = 8;
            this.txtRefundMedicine.Name = "txtRefundMedicine";
            this.txtRefundMedicine.ReadOnly = true;
            this.txtRefundMedicine.Size = new System.Drawing.Size(54, 20);
            this.txtRefundMedicine.TabIndex = 83;
            this.txtRefundMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPostOperative
            // 
            this.lblPostOperative.AutoSize = true;
            this.lblPostOperative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOperative.Location = new System.Drawing.Point(500, 241);
            this.lblPostOperative.Name = "lblPostOperative";
            this.lblPostOperative.Size = new System.Drawing.Size(135, 13);
            this.lblPostOperative.TabIndex = 82;
            this.lblPostOperative.Text = "Post Operative Charge";
            // 
            // lblOTcharges
            // 
            this.lblOTcharges.AutoSize = true;
            this.lblOTcharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTcharges.Location = new System.Drawing.Point(508, 101);
            this.lblOTcharges.Name = "lblOTcharges";
            this.lblOTcharges.Size = new System.Drawing.Size(68, 13);
            this.lblOTcharges.TabIndex = 81;
            this.lblOTcharges.Text = "OT Charge";
            // 
            // txtOtcharge
            // 
            this.txtOtcharge.Location = new System.Drawing.Point(633, 97);
            this.txtOtcharge.MaxLength = 8;
            this.txtOtcharge.Name = "txtOtcharge";
            this.txtOtcharge.ReadOnly = true;
            this.txtOtcharge.Size = new System.Drawing.Size(54, 20);
            this.txtOtcharge.TabIndex = 80;
            this.txtOtcharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPostOperative
            // 
            this.txtPostOperative.Location = new System.Drawing.Point(689, 238);
            this.txtPostOperative.MaxLength = 8;
            this.txtPostOperative.Name = "txtPostOperative";
            this.txtPostOperative.ReadOnly = true;
            this.txtPostOperative.Size = new System.Drawing.Size(60, 20);
            this.txtPostOperative.TabIndex = 79;
            this.txtPostOperative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(425, 599);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 28);
            this.btnPreview.TabIndex = 78;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtAdmissionFee
            // 
            this.txtAdmissionFee.Location = new System.Drawing.Point(690, 284);
            this.txtAdmissionFee.MaxLength = 8;
            this.txtAdmissionFee.Name = "txtAdmissionFee";
            this.txtAdmissionFee.Size = new System.Drawing.Size(60, 20);
            this.txtAdmissionFee.TabIndex = 77;
            this.txtAdmissionFee.Text = "200.00";
            this.txtAdmissionFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdmissionFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissionFee_KeyPress);
            // 
            // lblAdmissionFee
            // 
            this.lblAdmissionFee.AutoSize = true;
            this.lblAdmissionFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionFee.Location = new System.Drawing.Point(486, 285);
            this.lblAdmissionFee.Name = "lblAdmissionFee";
            this.lblAdmissionFee.Size = new System.Drawing.Size(101, 15);
            this.lblAdmissionFee.TabIndex = 76;
            this.lblAdmissionFee.Text = "Admission Fee";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(648, 377);
            this.txtdiscount.MaxLength = 8;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(101, 20);
            this.txtdiscount.TabIndex = 73;
            this.txtdiscount.Text = "0.0";
            this.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(486, 378);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 15);
            this.lblDiscount.TabIndex = 72;
            this.lblDiscount.Text = "Discount";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(650, 307);
            this.txtSubTotal.MaxLength = 8;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 71;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSubTotal.Location = new System.Drawing.Point(486, 308);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(73, 17);
            this.lblSubTotal.TabIndex = 70;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(633, 331);
            this.txtPercentage.MaxLength = 4;
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(36, 20);
            this.txtPercentage.TabIndex = 69;
            this.txtPercentage.Text = "2.25";
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentage_KeyPress);
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(689, 331);
            this.txtVat.MaxLength = 6;
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(60, 20);
            this.txtVat.TabIndex = 68;
            this.txtVat.Text = "0.0";
            this.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(666, 334);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(16, 13);
            this.lblPercentage.TabIndex = 67;
            this.lblPercentage.Text = "%";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(486, 334);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(38, 17);
            this.lblVat.TabIndex = 66;
            this.lblVat.Text = "VAT";
            // 
            // txtNetPayable
            // 
            this.txtNetPayable.Location = new System.Drawing.Point(649, 443);
            this.txtNetPayable.MaxLength = 8;
            this.txtNetPayable.Name = "txtNetPayable";
            this.txtNetPayable.ReadOnly = true;
            this.txtNetPayable.Size = new System.Drawing.Size(101, 20);
            this.txtNetPayable.TabIndex = 65;
            this.txtNetPayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNetPayable
            // 
            this.lblNetPayable.AutoSize = true;
            this.lblNetPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNetPayable.Location = new System.Drawing.Point(486, 444);
            this.lblNetPayable.Name = "lblNetPayable";
            this.lblNetPayable.Size = new System.Drawing.Size(96, 17);
            this.lblNetPayable.TabIndex = 64;
            this.lblNetPayable.Text = "Net Payable";
            // 
            // lvwBill
            // 
            this.lvwBill.BackColor = System.Drawing.Color.Linen;
            this.lvwBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amount,
            this.item,
            this.quantity,
            this.unit_charge,
            this.total_charge,
            this.d_id,
            this.g_id,
            this.t_id,
            this.reedoc_id,
            this.reffered_by});
            this.lvwBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBill.ForeColor = System.Drawing.Color.Black;
            this.lvwBill.FullRowSelect = true;
            this.lvwBill.HideSelection = false;
            this.lvwBill.Location = new System.Drawing.Point(6, 47);
            this.lvwBill.Name = "lvwBill";
            this.lvwBill.Size = new System.Drawing.Size(412, 235);
            this.lvwBill.TabIndex = 41;
            this.lvwBill.UseCompatibleStateImageBehavior = false;
            this.lvwBill.View = System.Windows.Forms.View.Details;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 0;
            // 
            // item
            // 
            this.item.Text = "Description";
            this.item.Width = 160;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Width = 63;
            // 
            // unit_charge
            // 
            this.unit_charge.Text = "Unit Charge";
            this.unit_charge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unit_charge.Width = 87;
            // 
            // total_charge
            // 
            this.total_charge.Text = "Total Charge";
            this.total_charge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total_charge.Width = 90;
            // 
            // d_id
            // 
            this.d_id.Text = "d_id";
            this.d_id.Width = 0;
            // 
            // g_id
            // 
            this.g_id.Text = "Group ID";
            this.g_id.Width = 0;
            // 
            // t_id
            // 
            this.t_id.Text = "Test ID";
            this.t_id.Width = 0;
            // 
            // reedoc_id
            // 
            this.reedoc_id.Width = 4;
            // 
            // reffered_by
            // 
            this.reffered_by.Text = "Reffered by";
            this.reffered_by.Width = 0;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(430, 398);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(49, 23);
            this.btnAdvance.TabIndex = 63;
            this.btnAdvance.Text = "Details";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click_1);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(649, 399);
            this.txtAdvance.MaxLength = 8;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(101, 20);
            this.txtAdvance.TabIndex = 62;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(487, 400);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(60, 15);
            this.lblAdvance.TabIndex = 61;
            this.lblAdvance.Text = "Advance";
            // 
            // lvwAdvance
            // 
            this.lvwAdvance.BackColor = System.Drawing.Color.Linen;
            this.lvwAdvance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ams,
            this.receipt_no,
            this.date,
            this.advance});
            this.lvwAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAdvance.ForeColor = System.Drawing.Color.Black;
            this.lvwAdvance.FullRowSelect = true;
            this.lvwAdvance.HideSelection = false;
            this.lvwAdvance.Location = new System.Drawing.Point(6, 316);
            this.lvwAdvance.Name = "lvwAdvance";
            this.lvwAdvance.Size = new System.Drawing.Size(412, 104);
            this.lvwAdvance.TabIndex = 60;
            this.lvwAdvance.UseCompatibleStateImageBehavior = false;
            this.lvwAdvance.View = System.Windows.Forms.View.Details;
            // 
            // ams
            // 
            this.ams.Text = "amounts";
            this.ams.Width = 0;
            // 
            // receipt_no
            // 
            this.receipt_no.Text = "Receipt No";
            this.receipt_no.Width = 117;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 199;
            // 
            // advance
            // 
            this.advance.Text = "Amount";
            this.advance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.advance.Width = 86;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(430, 477);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(49, 26);
            this.btnDoctor.TabIndex = 59;
            this.btnDoctor.Text = "Details";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Visible = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(690, 503);
            this.txtDoctor.MaxLength = 8;
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(60, 20);
            this.txtDoctor.TabIndex = 58;
            this.txtDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(508, 506);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(103, 13);
            this.lblDoctor.TabIndex = 57;
            this.lblDoctor.Text = "Visit Doctor\'s Bill";
            // 
            // btnRoomRent
            // 
            this.btnRoomRent.Location = new System.Drawing.Point(430, 217);
            this.btnRoomRent.Name = "btnRoomRent";
            this.btnRoomRent.Size = new System.Drawing.Size(49, 23);
            this.btnRoomRent.TabIndex = 56;
            this.btnRoomRent.Text = "Details";
            this.btnRoomRent.UseVisualStyleBackColor = true;
            this.btnRoomRent.Click += new System.EventHandler(this.btnRoomRent_Click);
            // 
            // txtRoomRent
            // 
            this.txtRoomRent.Location = new System.Drawing.Point(690, 238);
            this.txtRoomRent.MaxLength = 8;
            this.txtRoomRent.Name = "txtRoomRent";
            this.txtRoomRent.ReadOnly = true;
            this.txtRoomRent.Size = new System.Drawing.Size(60, 20);
            this.txtRoomRent.TabIndex = 55;
            this.txtRoomRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRoomRent.Visible = false;
            // 
            // lblRoomRent
            // 
            this.lblRoomRent.AutoSize = true;
            this.lblRoomRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRent.Location = new System.Drawing.Point(486, 206);
            this.lblRoomRent.Name = "lblRoomRent";
            this.lblRoomRent.Size = new System.Drawing.Size(79, 15);
            this.lblRoomRent.TabIndex = 54;
            this.lblRoomRent.Text = "Room Rent";
            // 
            // btnMedicine
            // 
            this.btnMedicine.Location = new System.Drawing.Point(430, 166);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(49, 23);
            this.btnMedicine.TabIndex = 53;
            this.btnMedicine.Text = "Details";
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(689, 191);
            this.txtMedicine.MaxLength = 8;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.ReadOnly = true;
            this.txtMedicine.Size = new System.Drawing.Size(60, 20);
            this.txtMedicine.TabIndex = 52;
            this.txtMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOtherServices
            // 
            this.btnOtherServices.Location = new System.Drawing.Point(430, 132);
            this.btnOtherServices.Name = "btnOtherServices";
            this.btnOtherServices.Size = new System.Drawing.Size(49, 23);
            this.btnOtherServices.TabIndex = 51;
            this.btnOtherServices.Text = "Details";
            this.btnOtherServices.UseVisualStyleBackColor = true;
            this.btnOtherServices.Click += new System.EventHandler(this.btnOtherServices_Click);
            // 
            // txtOtherServices
            // 
            this.txtOtherServices.Location = new System.Drawing.Point(689, 139);
            this.txtOtherServices.MaxLength = 8;
            this.txtOtherServices.Name = "txtOtherServices";
            this.txtOtherServices.ReadOnly = true;
            this.txtOtherServices.Size = new System.Drawing.Size(60, 20);
            this.txtOtherServices.TabIndex = 50;
            this.txtOtherServices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOtherServices
            // 
            this.lblOtherServices.AutoSize = true;
            this.lblOtherServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherServices.Location = new System.Drawing.Point(484, 136);
            this.lblOtherServices.Name = "lblOtherServices";
            this.lblOtherServices.Size = new System.Drawing.Size(100, 15);
            this.lblOtherServices.TabIndex = 49;
            this.lblOtherServices.Text = "Other Services";
            // 
            // btnOt
            // 
            this.btnOt.Location = new System.Drawing.Point(430, 90);
            this.btnOt.Name = "btnOt";
            this.btnOt.Size = new System.Drawing.Size(49, 23);
            this.btnOt.TabIndex = 48;
            this.btnOt.Text = "Details";
            this.btnOt.UseVisualStyleBackColor = true;
            this.btnOt.Click += new System.EventHandler(this.btnOt_Click);
            // 
            // txtOt
            // 
            this.txtOt.Location = new System.Drawing.Point(689, 116);
            this.txtOt.MaxLength = 8;
            this.txtOt.Name = "txtOt";
            this.txtOt.ReadOnly = true;
            this.txtOt.Size = new System.Drawing.Size(60, 20);
            this.txtOt.TabIndex = 47;
            this.txtOt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOt
            // 
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt.Location = new System.Drawing.Point(486, 90);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(25, 15);
            this.lblOt.TabIndex = 46;
            this.lblOt.Text = "OT";
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(430, 67);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(49, 23);
            this.btnTreatment.TabIndex = 45;
            this.btnTreatment.Text = "Details";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(688, 69);
            this.txtTreatment.MaxLength = 8;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.ReadOnly = true;
            this.txtTreatment.Size = new System.Drawing.Size(60, 20);
            this.txtTreatment.TabIndex = 44;
            this.txtTreatment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(484, 67);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(72, 15);
            this.lblTreatment.TabIndex = 43;
            this.lblTreatment.Text = "Treatment";
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(486, 158);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(66, 15);
            this.lblMedicine.TabIndex = 42;
            this.lblMedicine.Text = "Medicine";
            // 
            // btnInvestigation
            // 
            this.btnInvestigation.Location = new System.Drawing.Point(430, 44);
            this.btnInvestigation.Name = "btnInvestigation";
            this.btnInvestigation.Size = new System.Drawing.Size(49, 23);
            this.btnInvestigation.TabIndex = 40;
            this.btnInvestigation.Text = "Details";
            this.btnInvestigation.UseVisualStyleBackColor = true;
            this.btnInvestigation.Click += new System.EventHandler(this.btnInvestigation_Click);
            // 
            // txtInvestigation
            // 
            this.txtInvestigation.Location = new System.Drawing.Point(687, 46);
            this.txtInvestigation.MaxLength = 8;
            this.txtInvestigation.Name = "txtInvestigation";
            this.txtInvestigation.ReadOnly = true;
            this.txtInvestigation.Size = new System.Drawing.Size(60, 20);
            this.txtInvestigation.TabIndex = 39;
            this.txtInvestigation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInvestigation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvestigation_KeyPress);
            // 
            // lblInvestigation
            // 
            this.lblInvestigation.AutoSize = true;
            this.lblInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigation.Location = new System.Drawing.Point(484, 44);
            this.lblInvestigation.Name = "lblInvestigation";
            this.lblInvestigation.Size = new System.Drawing.Size(88, 15);
            this.lblInvestigation.TabIndex = 37;
            this.lblInvestigation.Text = "Investigation";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(650, 354);
            this.txtTotal.MaxLength = 8;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvlGrandTotal
            // 
            this.lvlGrandTotal.AutoSize = true;
            this.lvlGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlGrandTotal.Location = new System.Drawing.Point(486, 355);
            this.lvlGrandTotal.Name = "lvlGrandTotal";
            this.lvlGrandTotal.Size = new System.Drawing.Size(95, 17);
            this.lvlGrandTotal.TabIndex = 34;
            this.lvlGrandTotal.Text = "Grand Total";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblBillTitle.Location = new System.Drawing.Point(353, 8);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(54, 31);
            this.lblBillTitle.TabIndex = 31;
            this.lblBillTitle.Text = "Bill";
            this.lblBillTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(506, 599);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(587, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(672, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(0, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Hospital ID/Cabin";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lvwDue
            // 
            this.lvwDue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDue.BackColor = System.Drawing.Color.Linen;
            this.lvwDue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabins,
            this.patient_codes,
            this.admission_ids,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwDue.FullRowSelect = true;
            this.lvwDue.HideSelection = false;
            this.lvwDue.Location = new System.Drawing.Point(1, 463);
            this.lvwDue.Name = "lvwDue";
            this.lvwDue.Size = new System.Drawing.Size(234, 171);
            this.lvwDue.TabIndex = 9;
            this.lvwDue.UseCompatibleStateImageBehavior = false;
            this.lvwDue.View = System.Windows.Forms.View.Details;
            this.lvwDue.Click += new System.EventHandler(this.lvwDue_Click);
            // 
            // cabins
            // 
            this.cabins.Name = "cabins";
            this.cabins.Text = "Cabin";
            this.cabins.Width = 47;
            // 
            // patient_codes
            // 
            this.patient_codes.Name = "patient_codes";
            this.patient_codes.Text = "Hospital ID";
            this.patient_codes.Width = 78;
            // 
            // admission_ids
            // 
            this.admission_ids.Name = "admission_ids";
            this.admission_ids.Text = "Admission ID";
            this.admission_ids.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "P. Name";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Discharge";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "GrdName";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Address";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Phone";
            this.columnHeader8.Width = 0;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblDue.Location = new System.Drawing.Point(4, 447);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(80, 13);
            this.lblDue.TabIndex = 10;
            this.lblDue.Text = "Due Patients";
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1001, 647);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lvwDue);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grpBill);
            this.Controls.Add(this.lvwPatientInfo);
            this.MaximizeBox = false;
            this.Name = "FrmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            this.grpBill.ResumeLayout(false);
            this.grpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctorsBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader guardian_name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.GroupBox grpBill;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lvlGrandTotal;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInvestigation;
        private System.Windows.Forms.Button btnInvestigation;
        private System.Windows.Forms.TextBox txtInvestigation;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.ListView lvwBill;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader unit_charge;
        private System.Windows.Forms.ColumnHeader total_charge;
        private System.Windows.Forms.ColumnHeader d_id;
        private System.Windows.Forms.ColumnHeader g_id;
        private System.Windows.Forms.ColumnHeader t_id;
        private System.Windows.Forms.ColumnHeader reedoc_id;
        private System.Windows.Forms.ColumnHeader reffered_by;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Button btnOtherServices;
        private System.Windows.Forms.TextBox txtOtherServices;
        private System.Windows.Forms.Label lblOtherServices;
        private System.Windows.Forms.Button btnOt;
        private System.Windows.Forms.TextBox txtOt;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Button btnRoomRent;
        private System.Windows.Forms.TextBox txtRoomRent;
        private System.Windows.Forms.Label lblRoomRent;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtNetPayable;
        private System.Windows.Forms.Label lblNetPayable;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.ListView lvwAdvance;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader advance;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtAdmissionFee;
        private System.Windows.Forms.Label lblAdmissionFee;
        private System.Windows.Forms.ColumnHeader receipt_no;
        private System.Windows.Forms.ColumnHeader ams;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtOtcharge;
        private System.Windows.Forms.TextBox txtPostOperative;
        private System.Windows.Forms.TextBox txtSaleMedicine;
        private System.Windows.Forms.TextBox txtRefundMedicine;
        private System.Windows.Forms.Label lblPostOperative;
        private System.Windows.Forms.Label lblOTcharges;
        private System.Windows.Forms.Label lblSaleMedicine;
        private System.Windows.Forms.Label lblRefundMedicine;
        private System.Windows.Forms.TextBox txtOtDoctor;
        private System.Windows.Forms.TextBox txtVistDoctor;
        private System.Windows.Forms.Button btnvisit;
        private System.Windows.Forms.Label lblOtDoctor;
        private System.Windows.Forms.Label lblDoctorsBill;
        private System.Windows.Forms.TextBox txtDoctorsBill;
        private System.Windows.Forms.TextBox txtDoctorParcentage;
        private System.Windows.Forms.TextBox txtDoctorVat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVatforDoctor;
        private System.Windows.Forms.DataGridView grdDoctorsBill;
        private System.Windows.Forms.Label lblPayableAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDTotal;
        private System.Windows.Forms.ColumnHeader is_discharged;
        private System.Windows.Forms.Label lblAditionalCharge;
        private System.Windows.Forms.TextBox txtAditionalCharge;
        private System.Windows.Forms.Label lblCabinCharge;
        private System.Windows.Forms.TextBox txtCabinCharge;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lvwDue;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.ColumnHeader cabins;
        private System.Windows.Forms.ColumnHeader patient_codes;
        private System.Windows.Forms.ColumnHeader admission_ids;
        private System.Windows.Forms.TextBox txtRefund;
        private System.Windows.Forms.Label lblRefund;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn redeuced_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn reduced_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payable;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultant_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_visit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtEquation;
    }
}