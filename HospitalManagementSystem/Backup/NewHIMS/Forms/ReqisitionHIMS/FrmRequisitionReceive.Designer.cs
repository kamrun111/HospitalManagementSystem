namespace NewHIMS.Forms.ReqisitionHIMS
{
    partial class FrmRequisitionReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisitionReceive));
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.cmbRequisitionNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdeliveryby = new System.Windows.Forms.TextBox();
            this.grdRequisitionReceive = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receive_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisition_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRequisitionTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRequisitionNo = new System.Windows.Forms.Label();
            this.grpRequisition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisitionReceive)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRequisition
            // 
            this.grpRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRequisition.Controls.Add(this.cmbRequisitionNo);
            this.grpRequisition.Controls.Add(this.label1);
            this.grpRequisition.Controls.Add(this.txtdeliveryby);
            this.grpRequisition.Controls.Add(this.grdRequisitionReceive);
            this.grpRequisition.Controls.Add(this.lblRequisitionTitle);
            this.grpRequisition.Controls.Add(this.btnRefresh);
            this.grpRequisition.Controls.Add(this.btnSave);
            this.grpRequisition.Controls.Add(this.btnClose);
            this.grpRequisition.Controls.Add(this.lblRequisitionNo);
            this.grpRequisition.Location = new System.Drawing.Point(12, 8);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Size = new System.Drawing.Size(501, 495);
            this.grpRequisition.TabIndex = 1;
            this.grpRequisition.TabStop = false;
            // 
            // cmbRequisitionNo
            // 
            this.cmbRequisitionNo.FormattingEnabled = true;
            this.cmbRequisitionNo.Location = new System.Drawing.Point(124, 90);
            this.cmbRequisitionNo.Name = "cmbRequisitionNo";
            this.cmbRequisitionNo.Size = new System.Drawing.Size(279, 21);
            this.cmbRequisitionNo.TabIndex = 53;
            this.cmbRequisitionNo.SelectedIndexChanged += new System.EventHandler(this.cmbRequisitionNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Delivered  By :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdeliveryby
            // 
            this.txtdeliveryby.Location = new System.Drawing.Point(120, 128);
            this.txtdeliveryby.Name = "txtdeliveryby";
            this.txtdeliveryby.ReadOnly = true;
            this.txtdeliveryby.Size = new System.Drawing.Size(182, 20);
            this.txtdeliveryby.TabIndex = 51;
            // 
            // grdRequisitionReceive
            // 
            this.grdRequisitionReceive.AllowUserToAddRows = false;
            this.grdRequisitionReceive.AllowUserToDeleteRows = false;
            this.grdRequisitionReceive.AllowUserToOrderColumns = true;
            this.grdRequisitionReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRequisitionReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequisitionReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.order_qty,
            this.receive_qty,
            this.requisition_product_id});
            this.grdRequisitionReceive.Location = new System.Drawing.Point(13, 169);
            this.grdRequisitionReceive.Name = "grdRequisitionReceive";
            this.grdRequisitionReceive.Size = new System.Drawing.Size(475, 278);
            this.grdRequisitionReceive.TabIndex = 3;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product.Width = 110;
            // 
            // order_qty
            // 
            this.order_qty.HeaderText = "Order Qty.";
            this.order_qty.Name = "order_qty";
            this.order_qty.ReadOnly = true;
            this.order_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_qty.Width = 110;
            // 
            // receive_qty
            // 
            this.receive_qty.HeaderText = "Receive Qty.";
            this.receive_qty.Name = "receive_qty";
            this.receive_qty.ReadOnly = true;
            this.receive_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receive_qty.Width = 110;
            // 
            // requisition_product_id
            // 
            this.requisition_product_id.HeaderText = "RPID";
            this.requisition_product_id.Name = "requisition_product_id";
            this.requisition_product_id.ReadOnly = true;
            this.requisition_product_id.Visible = false;
            // 
            // lblRequisitionTitle
            // 
            this.lblRequisitionTitle.AutoSize = true;
            this.lblRequisitionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequisitionTitle.Location = new System.Drawing.Point(111, 21);
            this.lblRequisitionTitle.Name = "lblRequisitionTitle";
            this.lblRequisitionTitle.Size = new System.Drawing.Size(274, 31);
            this.lblRequisitionTitle.TabIndex = 31;
            this.lblRequisitionTitle.Text = "Requisition Receive";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(324, 453);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 5;
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
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(235, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(409, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRequisitionNo
            // 
            this.lblRequisitionNo.AutoSize = true;
            this.lblRequisitionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionNo.Location = new System.Drawing.Point(20, 93);
            this.lblRequisitionNo.Name = "lblRequisitionNo";
            this.lblRequisitionNo.Size = new System.Drawing.Size(98, 13);
            this.lblRequisitionNo.TabIndex = 10;
            this.lblRequisitionNo.Text = "Requisition No :";
            this.lblRequisitionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmRequisitionReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 511);
            this.Controls.Add(this.grpRequisition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRequisitionReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisition Receive";
            this.Load += new System.EventHandler(this.FrmRequisitionReceive_Load);
            this.grpRequisition.ResumeLayout(false);
            this.grpRequisition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisitionReceive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequisition;
        private System.Windows.Forms.DataGridView grdRequisitionReceive;
        private System.Windows.Forms.Label lblRequisitionTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRequisitionNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeliveryby;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn receive_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisition_product_id;
        private System.Windows.Forms.ComboBox cmbRequisitionNo;
    }
}