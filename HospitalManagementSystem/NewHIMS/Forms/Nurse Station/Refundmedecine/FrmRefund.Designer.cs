namespace NewHIMS.Forms.Nurse_Station.Medecine_Refund
{
    partial class FrmRefund
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
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCabin = new System.Windows.Forms.TextBox();
            this.txtPatientCode = new System.Windows.Forms.TextBox();
            this.grdSalesRefundedit = new System.Windows.Forms.DataGridView();
            this.sales_refund_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousrefund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.grpSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesRefundedit)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSales
            // 
            this.grpSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSales.Controls.Add(this.label1);
            this.grpSales.Controls.Add(this.txtCabin);
            this.grpSales.Controls.Add(this.txtPatientCode);
            this.grpSales.Controls.Add(this.grdSalesRefundedit);
            this.grpSales.Controls.Add(this.btnRefresh);
            this.grpSales.Controls.Add(this.btnSave);
            this.grpSales.Controls.Add(this.btnClose);
            this.grpSales.Controls.Add(this.lblInvoiceNo);
            this.grpSales.Location = new System.Drawing.Point(12, 36);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(442, 434);
            this.grpSales.TabIndex = 2;
            this.grpSales.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cabin No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCabin
            // 
            this.txtCabin.Location = new System.Drawing.Point(87, 14);
            this.txtCabin.Name = "txtCabin";
            this.txtCabin.ReadOnly = true;
            this.txtCabin.Size = new System.Drawing.Size(73, 20);
            this.txtCabin.TabIndex = 33;
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.Location = new System.Drawing.Point(275, 14);
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.ReadOnly = true;
            this.txtPatientCode.Size = new System.Drawing.Size(113, 20);
            this.txtPatientCode.TabIndex = 32;
            // 
            // grdSalesRefundedit
            // 
            this.grdSalesRefundedit.AllowUserToAddRows = false;
            this.grdSalesRefundedit.AllowUserToDeleteRows = false;
            this.grdSalesRefundedit.AllowUserToResizeColumns = false;
            this.grdSalesRefundedit.AllowUserToResizeRows = false;
            this.grdSalesRefundedit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalesRefundedit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalesRefundedit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sales_refund_id,
            this.product_id,
            this.product,
            this.previousrefund,
            this.refund_qty});
            this.grdSalesRefundedit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdSalesRefundedit.Location = new System.Drawing.Point(21, 44);
            this.grdSalesRefundedit.Name = "grdSalesRefundedit";
            this.grdSalesRefundedit.Size = new System.Drawing.Size(406, 351);
            this.grdSalesRefundedit.TabIndex = 7;
            this.grdSalesRefundedit.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSalesRefundedit_CellValueChanged);
            // 
            // sales_refund_id
            // 
            this.sales_refund_id.Frozen = true;
            this.sales_refund_id.HeaderText = "SalesRefundID";
            this.sales_refund_id.Name = "sales_refund_id";
            this.sales_refund_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.Frozen = true;
            this.product_id.HeaderText = "PID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product_id.Visible = false;
            this.product_id.Width = 120;
            // 
            // product
            // 
            this.product.Frozen = true;
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 200;
            // 
            // previousrefund
            // 
            this.previousrefund.Frozen = true;
            this.previousrefund.HeaderText = "Old Refund Qty";
            this.previousrefund.Name = "previousrefund";
            this.previousrefund.ReadOnly = true;
            this.previousrefund.Width = 60;
            // 
            // refund_qty
            // 
            this.refund_qty.Frozen = true;
            this.refund_qty.HeaderText = "Refund Qty.";
            this.refund_qty.Name = "refund_qty";
            this.refund_qty.Width = 80;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(275, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 27);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
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
            this.btnSave.Location = new System.Drawing.Point(352, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 27);
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
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(198, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(195, 18);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(70, 13);
            this.lblInvoiceNo.TabIndex = 21;
            this.lblInvoiceNo.Text = "Hostipal ID";
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSalesTitle.Location = new System.Drawing.Point(147, 1);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(175, 31);
            this.lblSalesTitle.TabIndex = 31;
            this.lblSalesTitle.Text = " Refund Edit";
            this.lblSalesTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 482);
            this.Controls.Add(this.lblSalesTitle);
            this.Controls.Add(this.grpSales);
            this.Name = "FrmRefund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Refund by Nurse";
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesRefundedit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.DataGridView grdSalesRefundedit;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtPatientCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCabin;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_refund_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousrefund;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund_qty;
    }
}