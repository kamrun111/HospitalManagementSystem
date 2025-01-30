namespace NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund
{
    partial class FrmOPDmedicineRefund
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grdSalesRefund = new System.Windows.Forms.DataGridView();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.opdsales_id = new System.Windows.Forms.ColumnHeader();
            this.indent_by = new System.Windows.Forms.ColumnHeader();
            this.indent_date = new System.Windows.Forms.ColumnHeader();
            this.lblPatientMedicineIndentTitle = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousrefund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesRefund)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(524, 326);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 27);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(447, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 27);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(601, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 27);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdSalesRefund
            // 
            this.grdSalesRefund.AllowUserToAddRows = false;
            this.grdSalesRefund.AllowUserToDeleteRows = false;
            this.grdSalesRefund.AllowUserToOrderColumns = true;
            this.grdSalesRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalesRefund.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdSalesRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalesRefund.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product,
            this.sales_qty,
            this.previousrefund,
            this.refund_qty,
            this.unit_price});
            this.grdSalesRefund.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdSalesRefund.Location = new System.Drawing.Point(261, 27);
            this.grdSalesRefund.Name = "grdSalesRefund";
            this.grdSalesRefund.RowHeadersVisible = false;
            this.grdSalesRefund.Size = new System.Drawing.Size(411, 293);
            this.grdSalesRefund.TabIndex = 57;
            this.grdSalesRefund.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSalesRefund_CellValueChanged);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.opdsales_id,
            this.indent_by,
            this.indent_date});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(12, 27);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(243, 293);
            this.lvwPatientInfo.TabIndex = 56;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // opdsales_id
            // 
            this.opdsales_id.Text = "opdsales_id";
            this.opdsales_id.Width = 0;
            // 
            // indent_by
            // 
            this.indent_by.Text = "indent_by";
            this.indent_by.Width = 86;
            // 
            // indent_date
            // 
            this.indent_date.Text = "indent_date";
            this.indent_date.Width = 102;
            // 
            // lblPatientMedicineIndentTitle
            // 
            this.lblPatientMedicineIndentTitle.AutoSize = true;
            this.lblPatientMedicineIndentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientMedicineIndentTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPatientMedicineIndentTitle.Location = new System.Drawing.Point(291, 0);
            this.lblPatientMedicineIndentTitle.Name = "lblPatientMedicineIndentTitle";
            this.lblPatientMedicineIndentTitle.Size = new System.Drawing.Size(218, 24);
            this.lblPatientMedicineIndentTitle.TabIndex = 140;
            this.lblPatientMedicineIndentTitle.Text = "OPD Medicine Refund";
            // 
            // product_id
            // 
            this.product_id.HeaderText = "PID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product_id.Visible = false;
            this.product_id.Width = 120;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 200;
            // 
            // sales_qty
            // 
            this.sales_qty.HeaderText = "Sales Qty";
            this.sales_qty.Name = "sales_qty";
            this.sales_qty.ReadOnly = true;
            this.sales_qty.Width = 90;
            // 
            // previousrefund
            // 
            this.previousrefund.HeaderText = "Already Refund";
            this.previousrefund.Name = "previousrefund";
            this.previousrefund.ReadOnly = true;
            this.previousrefund.Width = 60;
            // 
            // refund_qty
            // 
            this.refund_qty.HeaderText = "Refund Qty";
            this.refund_qty.Name = "refund_qty";
            this.refund_qty.Width = 55;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "unit_price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Visible = false;
            // 
            // FrmOPDmedicineRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(684, 365);
            this.Controls.Add(this.lblPatientMedicineIndentTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdSalesRefund);
            this.Controls.Add(this.lvwPatientInfo);
            this.Name = "FrmOPDmedicineRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OPD Medicine Refund";
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesRefund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdSalesRefund;
        public System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader opdsales_id;
        private System.Windows.Forms.ColumnHeader indent_by;
        private System.Windows.Forms.ColumnHeader indent_date;
        private System.Windows.Forms.Label lblPatientMedicineIndentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousrefund;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;

    }
}