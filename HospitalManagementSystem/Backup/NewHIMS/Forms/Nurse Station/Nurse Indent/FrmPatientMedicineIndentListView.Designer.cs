namespace NewHIMS.Forms.Nurse_Station.Nurse_Indent
{
    partial class FrmPatientMedicineIndentListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPatientMedicineIndent = new System.Windows.Forms.GroupBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDeliveredBy = new System.Windows.Forms.TextBox();
            this.lblDeliveredBy = new System.Windows.Forms.Label();
            this.btnOtherItemIndent = new System.Windows.Forms.Button();
            this.btnIndent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPatientMedicineIndentTitle = new System.Windows.Forms.Label();
            this.grdMedicineIndent = new System.Windows.Forms.DataGridView();
            this.admission_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivered_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.OrderID = new System.Windows.Forms.ColumnHeader();
            this.Indendby = new System.Windows.Forms.ColumnHeader();
            this.deliveredby = new System.Windows.Forms.ColumnHeader();
            this.deliverydate = new System.Windows.Forms.ColumnHeader();
            this.txtpatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_name = new System.Windows.Forms.ColumnHeader();
            this.grpPatientMedicineIndent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineIndent)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPatientMedicineIndent
            // 
            this.grpPatientMedicineIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientMedicineIndent.Controls.Add(this.txtpatientName);
            this.grpPatientMedicineIndent.Controls.Add(this.label1);
            this.grpPatientMedicineIndent.Controls.Add(this.txtDeliveryDate);
            this.grpPatientMedicineIndent.Controls.Add(this.lblDeliveryDate);
            this.grpPatientMedicineIndent.Controls.Add(this.txtDeliveredBy);
            this.grpPatientMedicineIndent.Controls.Add(this.lblDeliveredBy);
            this.grpPatientMedicineIndent.Controls.Add(this.btnOtherItemIndent);
            this.grpPatientMedicineIndent.Controls.Add(this.btnIndent);
            this.grpPatientMedicineIndent.Controls.Add(this.btnRefresh);
            this.grpPatientMedicineIndent.Controls.Add(this.btnClose);
            this.grpPatientMedicineIndent.Controls.Add(this.lblPatientMedicineIndentTitle);
            this.grpPatientMedicineIndent.Controls.Add(this.grdMedicineIndent);
            this.grpPatientMedicineIndent.Controls.Add(this.lvwPatientInfo);
            this.grpPatientMedicineIndent.Location = new System.Drawing.Point(12, 8);
            this.grpPatientMedicineIndent.Name = "grpPatientMedicineIndent";
            this.grpPatientMedicineIndent.Size = new System.Drawing.Size(675, 426);
            this.grpPatientMedicineIndent.TabIndex = 1;
            this.grpPatientMedicineIndent.TabStop = false;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(234, 393);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(186, 20);
            this.txtDeliveryDate.TabIndex = 131;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(151, 393);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(78, 13);
            this.lblDeliveryDate.TabIndex = 130;
            this.lblDeliveryDate.Text = "Delivered Date";
            // 
            // txtDeliveredBy
            // 
            this.txtDeliveredBy.Location = new System.Drawing.Point(234, 360);
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.ReadOnly = true;
            this.txtDeliveredBy.Size = new System.Drawing.Size(186, 20);
            this.txtDeliveredBy.TabIndex = 36;
            // 
            // lblDeliveredBy
            // 
            this.lblDeliveredBy.AutoSize = true;
            this.lblDeliveredBy.Location = new System.Drawing.Point(151, 363);
            this.lblDeliveredBy.Name = "lblDeliveredBy";
            this.lblDeliveredBy.Size = new System.Drawing.Size(67, 13);
            this.lblDeliveredBy.TabIndex = 35;
            this.lblDeliveredBy.Text = "Delivered By";
            // 
            // btnOtherItemIndent
            // 
            this.btnOtherItemIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtherItemIndent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherItemIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherItemIndent.Image = global::NewHIMS.Properties.Resources._30px_Nuvola_apps_kdmconfig;
            this.btnOtherItemIndent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtherItemIndent.Location = new System.Drawing.Point(5, 367);
            this.btnOtherItemIndent.Name = "btnOtherItemIndent";
            this.btnOtherItemIndent.Size = new System.Drawing.Size(130, 47);
            this.btnOtherItemIndent.TabIndex = 34;
            this.btnOtherItemIndent.Text = "Medicine Indent";
            this.btnOtherItemIndent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOtherItemIndent.UseVisualStyleBackColor = true;
            this.btnOtherItemIndent.Click += new System.EventHandler(this.btnOtherItemIndent_Click);
            // 
            // btnIndent
            // 
            this.btnIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIndent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndent.Enabled = false;
            this.btnIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndent.Image = global::NewHIMS.Properties.Resources.Save;
            this.btnIndent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndent.Location = new System.Drawing.Point(483, 358);
            this.btnIndent.Name = "btnIndent";
            this.btnIndent.Size = new System.Drawing.Size(62, 52);
            this.btnIndent.TabIndex = 1;
            this.btnIndent.Text = "Receive";
            this.btnIndent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIndent.UseVisualStyleBackColor = true;
            this.btnIndent.Click += new System.EventHandler(this.btnIndent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(551, 358);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(616, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPatientMedicineIndentTitle
            // 
            this.lblPatientMedicineIndentTitle.AutoSize = true;
            this.lblPatientMedicineIndentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientMedicineIndentTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPatientMedicineIndentTitle.Location = new System.Drawing.Point(6, -7);
            this.lblPatientMedicineIndentTitle.Name = "lblPatientMedicineIndentTitle";
            this.lblPatientMedicineIndentTitle.Size = new System.Drawing.Size(244, 31);
            this.lblPatientMedicineIndentTitle.TabIndex = 33;
            this.lblPatientMedicineIndentTitle.Text = "Medicine Receive";
            // 
            // grdMedicineIndent
            // 
            this.grdMedicineIndent.AllowUserToAddRows = false;
            this.grdMedicineIndent.AllowUserToDeleteRows = false;
            this.grdMedicineIndent.AllowUserToOrderColumns = true;
            this.grdMedicineIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMedicineIndent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicineIndent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admission_id,
            this.cabin_id,
            this.product_id,
            this.medicine,
            this.quantity_ordered,
            this.quantity_delivered,
            this.quantity_received,
            this.PMIID,
            this.delivered_by,
            this.Stock});
            this.grdMedicineIndent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMedicineIndent.Location = new System.Drawing.Point(253, 56);
            this.grdMedicineIndent.Name = "grdMedicineIndent";
            this.grdMedicineIndent.RowHeadersVisible = false;
            this.grdMedicineIndent.Size = new System.Drawing.Size(416, 289);
            this.grdMedicineIndent.TabIndex = 0;
            this.grdMedicineIndent.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMedicineIndent_CellValueChanged);
            // 
            // admission_id
            // 
            this.admission_id.HeaderText = "AID";
            this.admission_id.Name = "admission_id";
            this.admission_id.Visible = false;
            // 
            // cabin_id
            // 
            this.cabin_id.HeaderText = "CID";
            this.cabin_id.Name = "cabin_id";
            this.cabin_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "PRID";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // medicine
            // 
            this.medicine.HeaderText = "Medicine";
            this.medicine.Name = "medicine";
            this.medicine.ReadOnly = true;
            this.medicine.Width = 210;
            // 
            // quantity_ordered
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.quantity_ordered.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity_ordered.HeaderText = "Order Qty.";
            this.quantity_ordered.MaxInputLength = 5;
            this.quantity_ordered.Name = "quantity_ordered";
            this.quantity_ordered.Width = 50;
            // 
            // quantity_delivered
            // 
            this.quantity_delivered.HeaderText = "Delivery Qty.";
            this.quantity_delivered.MaxInputLength = 5;
            this.quantity_delivered.Name = "quantity_delivered";
            this.quantity_delivered.ReadOnly = true;
            this.quantity_delivered.Width = 50;
            // 
            // quantity_received
            // 
            this.quantity_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity_received.HeaderText = "Received Qty.";
            this.quantity_received.MaxInputLength = 5;
            this.quantity_received.Name = "quantity_received";
            this.quantity_received.ReadOnly = true;
            // 
            // PMIID
            // 
            this.PMIID.HeaderText = "PMIID";
            this.PMIID.Name = "PMIID";
            this.PMIID.Visible = false;
            // 
            // delivered_by
            // 
            this.delivered_by.HeaderText = "DeliveredBy";
            this.delivered_by.Name = "delivered_by";
            this.delivered_by.Visible = false;
            this.delivered_by.Width = 5;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 5;
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.LightCyan;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Indendby,
            this.deliveredby,
            this.deliverydate,
            this.p_name});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(6, 56);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(239, 289);
            this.lvwPatientInfo.TabIndex = 129;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // OrderID
            // 
            this.OrderID.Text = "Indent ID";
            this.OrderID.Width = 76;
            // 
            // Indendby
            // 
            this.Indendby.Text = "Indent  BY";
            this.Indendby.Width = 159;
            // 
            // deliveredby
            // 
            this.deliveredby.Text = "deliveredby";
            this.deliveredby.Width = 0;
            // 
            // deliverydate
            // 
            this.deliverydate.Text = "Delivery Date";
            this.deliverydate.Width = 0;
            // 
            // txtpatientName
            // 
            this.txtpatientName.Location = new System.Drawing.Point(406, 25);
            this.txtpatientName.Name = "txtpatientName";
            this.txtpatientName.ReadOnly = true;
            this.txtpatientName.Size = new System.Drawing.Size(186, 20);
            this.txtpatientName.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 132;
            this.label1.Text = "P.Name";
            // 
            // p_name
            // 
            this.p_name.Text = "p.name";
            this.p_name.Width = 0;
            // 
            // FrmPatientMedicineIndentListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 443);
            this.Controls.Add(this.grpPatientMedicineIndent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPatientMedicineIndentListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
                "                                                                                " +
                "                              ";
            this.Load += new System.EventHandler(this.FrmPatientMedicineIndentListView_Load);
            this.grpPatientMedicineIndent.ResumeLayout(false);
            this.grpPatientMedicineIndent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineIndent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatientMedicineIndent;
        private System.Windows.Forms.Button btnIndent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPatientMedicineIndentTitle;
        private System.Windows.Forms.Button btnOtherItemIndent;
        public System.Windows.Forms.DataGridView grdMedicineIndent;
        private System.Windows.Forms.TextBox txtDeliveredBy;
        private System.Windows.Forms.Label lblDeliveredBy;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Indendby;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_ordered;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivered_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.ColumnHeader deliveredby;
        private System.Windows.Forms.ColumnHeader deliverydate;
        private System.Windows.Forms.TextBox txtpatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader p_name;

    }
}