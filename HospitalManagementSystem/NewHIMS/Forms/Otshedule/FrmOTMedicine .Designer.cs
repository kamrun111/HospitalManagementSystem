namespace NewHIMS.Forms.Otshedule
{
    partial class FrmOTMedicine
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCabin = new System.Windows.Forms.TextBox();
            this.txtOTRequisitionNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkOTMReceive = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdSurgical = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grdOtheritem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grdOTInjection = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_delivered2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_received2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_delivered3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_received3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientmedicientindentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSurgical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtheritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOTInjection)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(643, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 27);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(732, 541);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 27);
            this.btnRefresh.TabIndex = 104;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(821, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 27);
            this.btnClose.TabIndex = 105;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1051, 25);
            this.label7.TabIndex = 112;
            this.label7.Text = "OT  Medicine";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(142, 37);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(70, 13);
            this.lblPatientName.TabIndex = 113;
            this.lblPatientName.Text = "Hospital ID";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPatientCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPatientCode.Location = new System.Drawing.Point(139, 53);
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.ReadOnly = true;
            this.txtPatientCode.Size = new System.Drawing.Size(83, 20);
            this.txtPatientCode.TabIndex = 114;
            this.txtPatientCode.Tag = "patient_code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Cabin No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCabin
            // 
            this.txtCabin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCabin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCabin.Location = new System.Drawing.Point(239, 53);
            this.txtCabin.Name = "txtCabin";
            this.txtCabin.ReadOnly = true;
            this.txtCabin.Size = new System.Drawing.Size(83, 20);
            this.txtCabin.TabIndex = 116;
            this.txtCabin.Tag = "patient_code";
            // 
            // txtOTRequisitionNO
            // 
            this.txtOTRequisitionNO.BackColor = System.Drawing.Color.White;
            this.txtOTRequisitionNO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOTRequisitionNO.Location = new System.Drawing.Point(349, 53);
            this.txtOTRequisitionNO.MaxLength = 11;
            this.txtOTRequisitionNO.Name = "txtOTRequisitionNO";
            this.txtOTRequisitionNO.Size = new System.Drawing.Size(83, 20);
            this.txtOTRequisitionNO.TabIndex = 124;
            this.txtOTRequisitionNO.Tag = "patient_code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 125;
            this.label5.Text = " Requisiton No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkOTMReceive
            // 
            this.lnkOTMReceive.AutoSize = true;
            this.lnkOTMReceive.Enabled = false;
            this.lnkOTMReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOTMReceive.Location = new System.Drawing.Point(698, 29);
            this.lnkOTMReceive.Name = "lnkOTMReceive";
            this.lnkOTMReceive.Size = new System.Drawing.Size(121, 24);
            this.lnkOTMReceive.TabIndex = 126;
            this.lnkOTMReceive.TabStop = true;
            this.lnkOTMReceive.Text = "OT Receive";
            this.lnkOTMReceive.Click += new System.EventHandler(this.lnkOTMReceive_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "Patient Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(31, 53);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(83, 20);
            this.txtName.TabIndex = 134;
            this.txtName.Tag = "patient_code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(612, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 140;
            this.label3.Text = "Surgical";
            // 
            // grdSurgical
            // 
            this.grdSurgical.AllowUserToAddRows = false;
            this.grdSurgical.AllowUserToDeleteRows = false;
            this.grdSurgical.AllowUserToResizeColumns = false;
            this.grdSurgical.AllowUserToResizeRows = false;
            this.grdSurgical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSurgical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSurgical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Column2,
            this.quantity_delivered3,
            this.quantity_received3});
            this.grdSurgical.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdSurgical.Location = new System.Drawing.Point(618, 98);
            this.grdSurgical.Name = "grdSurgical";
            this.grdSurgical.RowHeadersVisible = false;
            this.grdSurgical.Size = new System.Drawing.Size(296, 437);
            this.grdSurgical.TabIndex = 139;
            this.grdSurgical.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSurgical_CellValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(311, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "Other Items";
            // 
            // grdOtheritem
            // 
            this.grdOtheritem.AllowUserToAddRows = false;
            this.grdOtheritem.AllowUserToDeleteRows = false;
            this.grdOtheritem.AllowUserToResizeColumns = false;
            this.grdOtheritem.AllowUserToResizeRows = false;
            this.grdOtheritem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOtheritem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOtheritem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.quantity_delivered2,
            this.quantity_received2});
            this.grdOtheritem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdOtheritem.Location = new System.Drawing.Point(309, 98);
            this.grdOtheritem.Name = "grdOtheritem";
            this.grdOtheritem.RowHeadersVisible = false;
            this.grdOtheritem.Size = new System.Drawing.Size(303, 437);
            this.grdOtheritem.TabIndex = 137;
            this.grdOtheritem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOtheritem_CellValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 136;
            this.label1.Text = "Injection/Infusion";
            // 
            // grdOTInjection
            // 
            this.grdOTInjection.AllowDrop = true;
            this.grdOTInjection.AllowUserToAddRows = false;
            this.grdOTInjection.AllowUserToDeleteRows = false;
            this.grdOTInjection.AllowUserToResizeColumns = false;
            this.grdOTInjection.AllowUserToResizeRows = false;
            this.grdOTInjection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOTInjection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdOTInjection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOTInjection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL_No,
            this.product_id,
            this.Product_name,
            this.order_qty,
            this.patientmedicientindentID,
            this.quantity_delivered,
            this.quantity_received});
            this.grdOTInjection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdOTInjection.Location = new System.Drawing.Point(8, 98);
            this.grdOTInjection.Name = "grdOTInjection";
            this.grdOTInjection.RowHeadersVisible = false;
            this.grdOTInjection.Size = new System.Drawing.Size(295, 437);
            this.grdOTInjection.TabIndex = 135;
            this.grdOTInjection.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOTInjection_CellValueChanged_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(15, 566);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 27);
            this.btnPrint.TabIndex = 141;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "SL No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Order Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 35;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "PMIID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // quantity_delivered2
            // 
            this.quantity_delivered2.Frozen = true;
            this.quantity_delivered2.HeaderText = "Delivery Qty";
            this.quantity_delivered2.Name = "quantity_delivered2";
            this.quantity_delivered2.ReadOnly = true;
            this.quantity_delivered2.Visible = false;
            this.quantity_delivered2.Width = 35;
            // 
            // quantity_received2
            // 
            this.quantity_received2.Frozen = true;
            this.quantity_received2.HeaderText = "Receive Qty";
            this.quantity_received2.Name = "quantity_received2";
            this.quantity_received2.ReadOnly = true;
            this.quantity_received2.Visible = false;
            this.quantity_received2.Width = 35;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "SL No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Order Qty";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 35;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "PIMD";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // quantity_delivered3
            // 
            this.quantity_delivered3.Frozen = true;
            this.quantity_delivered3.HeaderText = "Delivery Qty";
            this.quantity_delivered3.Name = "quantity_delivered3";
            this.quantity_delivered3.ReadOnly = true;
            this.quantity_delivered3.Visible = false;
            this.quantity_delivered3.Width = 35;
            // 
            // quantity_received3
            // 
            this.quantity_received3.Frozen = true;
            this.quantity_received3.HeaderText = "Receive Qty";
            this.quantity_received3.Name = "quantity_received3";
            this.quantity_received3.ReadOnly = true;
            this.quantity_received3.Visible = false;
            this.quantity_received3.Width = 35;
            // 
            // SL_No
            // 
            this.SL_No.Frozen = true;
            this.SL_No.HeaderText = "SL No";
            this.SL_No.Name = "SL_No";
            this.SL_No.ReadOnly = true;
            this.SL_No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SL_No.Visible = false;
            this.SL_No.Width = 30;
            // 
            // product_id
            // 
            this.product_id.Frozen = true;
            this.product_id.HeaderText = "ProductID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // Product_name
            // 
            this.Product_name.Frozen = true;
            this.Product_name.HeaderText = "Description";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Width = 200;
            // 
            // order_qty
            // 
            this.order_qty.Frozen = true;
            this.order_qty.HeaderText = "Order Qty";
            this.order_qty.Name = "order_qty";
            this.order_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_qty.Width = 35;
            // 
            // patientmedicientindentID
            // 
            this.patientmedicientindentID.Frozen = true;
            this.patientmedicientindentID.HeaderText = "PMIID";
            this.patientmedicientindentID.Name = "patientmedicientindentID";
            this.patientmedicientindentID.ReadOnly = true;
            this.patientmedicientindentID.Visible = false;
            this.patientmedicientindentID.Width = 5;
            // 
            // quantity_delivered
            // 
            this.quantity_delivered.Frozen = true;
            this.quantity_delivered.HeaderText = "Delivery Qty";
            this.quantity_delivered.Name = "quantity_delivered";
            this.quantity_delivered.ReadOnly = true;
            this.quantity_delivered.Visible = false;
            this.quantity_delivered.Width = 35;
            // 
            // quantity_received
            // 
            this.quantity_received.Frozen = true;
            this.quantity_received.HeaderText = "Receive Qty";
            this.quantity_received.Name = "quantity_received";
            this.quantity_received.ReadOnly = true;
            this.quantity_received.Visible = false;
            this.quantity_received.Width = 35;
            // 
            // FrmOTMedicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(922, 605);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdSurgical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdOtheritem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdOTInjection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lnkOTMReceive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOTRequisitionNO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCabin);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOTMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OT Medicine List";
            this.Load += new System.EventHandler(this.FrmOTMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSurgical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtheritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOTInjection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCabin;
        private System.Windows.Forms.TextBox txtOTRequisitionNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkOTMReceive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdSurgical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdOtheritem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdOTInjection;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_delivered3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_received3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_delivered2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_received2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientmedicientindentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_received;

    }
}