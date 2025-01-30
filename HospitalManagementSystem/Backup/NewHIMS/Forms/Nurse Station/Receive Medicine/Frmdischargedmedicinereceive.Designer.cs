namespace NewHIMS.Forms.Nurse_Station.Receive_Medicine
{
    partial class Frmdischargedmedicinereceive
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
            this.indentdate = new System.Windows.Forms.ColumnHeader();
            this.deliveredby = new System.Windows.Forms.ColumnHeader();
            this.deliverydate = new System.Windows.Forms.ColumnHeader();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDeliveredBy = new System.Windows.Forms.TextBox();
            this.lblDeliveredBy = new System.Windows.Forms.Label();
            this.btnIndent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPatientMedicineIndentTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineIndent)).BeginInit();
            this.SuspendLayout();
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
            this.grdMedicineIndent.Location = new System.Drawing.Point(285, 37);
            this.grdMedicineIndent.Name = "grdMedicineIndent";
            this.grdMedicineIndent.RowHeadersVisible = false;
            this.grdMedicineIndent.Size = new System.Drawing.Size(443, 323);
            this.grdMedicineIndent.TabIndex = 130;
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
            this.lvwPatientInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Indendby,
            this.indentdate,
            this.deliveredby,
            this.deliverydate});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(7, 37);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(259, 323);
            this.lvwPatientInfo.TabIndex = 131;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 0;
            // 
            // Indendby
            // 
            this.Indendby.Text = "Indent  BY";
            this.Indendby.Width = 100;
            // 
            // indentdate
            // 
            this.indentdate.DisplayIndex = 4;
            this.indentdate.Text = "Indent Date";
            this.indentdate.Width = 150;
            // 
            // deliveredby
            // 
            this.deliveredby.DisplayIndex = 2;
            this.deliveredby.Text = "deliveredby";
            this.deliveredby.Width = 0;
            // 
            // deliverydate
            // 
            this.deliverydate.DisplayIndex = 3;
            this.deliverydate.Text = "Delivery Date";
            this.deliverydate.Width = 0;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(228, 404);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(186, 20);
            this.txtDeliveryDate.TabIndex = 138;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(145, 404);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(78, 13);
            this.lblDeliveryDate.TabIndex = 137;
            this.lblDeliveryDate.Text = "Delivered Date";
            // 
            // txtDeliveredBy
            // 
            this.txtDeliveredBy.Location = new System.Drawing.Point(228, 371);
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.ReadOnly = true;
            this.txtDeliveredBy.Size = new System.Drawing.Size(186, 20);
            this.txtDeliveredBy.TabIndex = 136;
            // 
            // lblDeliveredBy
            // 
            this.lblDeliveredBy.AutoSize = true;
            this.lblDeliveredBy.Location = new System.Drawing.Point(145, 378);
            this.lblDeliveredBy.Name = "lblDeliveredBy";
            this.lblDeliveredBy.Size = new System.Drawing.Size(67, 13);
            this.lblDeliveredBy.TabIndex = 135;
            this.lblDeliveredBy.Text = "Delivered By";
            // 
            // btnIndent
            // 
            this.btnIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIndent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndent.Enabled = false;
            this.btnIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndent.Image = global::NewHIMS.Properties.Resources.Save;
            this.btnIndent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndent.Location = new System.Drawing.Point(540, 372);
            this.btnIndent.Name = "btnIndent";
            this.btnIndent.Size = new System.Drawing.Size(62, 52);
            this.btnIndent.TabIndex = 132;
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
            this.btnRefresh.Location = new System.Drawing.Point(608, 372);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 133;
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
            this.btnClose.Location = new System.Drawing.Point(673, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.TabIndex = 134;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPatientMedicineIndentTitle
            // 
            this.lblPatientMedicineIndentTitle.AutoSize = true;
            this.lblPatientMedicineIndentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientMedicineIndentTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPatientMedicineIndentTitle.Location = new System.Drawing.Point(294, 3);
            this.lblPatientMedicineIndentTitle.Name = "lblPatientMedicineIndentTitle";
            this.lblPatientMedicineIndentTitle.Size = new System.Drawing.Size(222, 29);
            this.lblPatientMedicineIndentTitle.TabIndex = 139;
            this.lblPatientMedicineIndentTitle.Text = "Medicine Receive";
            // 
            // Frmdischargedmedicinereceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 438);
            this.Controls.Add(this.lblPatientMedicineIndentTitle);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.txtDeliveredBy);
            this.Controls.Add(this.lblDeliveredBy);
            this.Controls.Add(this.btnIndent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdMedicineIndent);
            this.Controls.Add(this.lvwPatientInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmdischargedmedicinereceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discharge Patient Medicine Receive";
            this.Load += new System.EventHandler(this.Frmdischargedmedicinereceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineIndent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdMedicineIndent;
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
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Indendby;
        private System.Windows.Forms.ColumnHeader deliveredby;
        private System.Windows.Forms.ColumnHeader deliverydate;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.TextBox txtDeliveredBy;
        private System.Windows.Forms.Label lblDeliveredBy;
        private System.Windows.Forms.Button btnIndent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPatientMedicineIndentTitle;
        private System.Windows.Forms.ColumnHeader indentdate;
    }
}