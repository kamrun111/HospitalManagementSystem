namespace NewHIMS.Forms.Store.Purchase
{
    partial class FrmPurchaseOrderReview
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
            this.lvwPurchaseOrder = new System.Windows.Forms.ListView();
            this.purchase_id = new System.Windows.Forms.ColumnHeader();
            this.purchase = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_O_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiddencoloum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndentby = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPurchaseOrder
            // 
            this.lvwPurchaseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPurchaseOrder.BackColor = System.Drawing.Color.Thistle;
            this.lvwPurchaseOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchase_id,
            this.purchase,
            this.date,
            this.User});
            this.lvwPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPurchaseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPurchaseOrder.FullRowSelect = true;
            this.lvwPurchaseOrder.HideSelection = false;
            this.lvwPurchaseOrder.Location = new System.Drawing.Point(8, 19);
            this.lvwPurchaseOrder.Name = "lvwPurchaseOrder";
            this.lvwPurchaseOrder.Size = new System.Drawing.Size(245, 360);
            this.lvwPurchaseOrder.TabIndex = 2;
            this.lvwPurchaseOrder.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrder.View = System.Windows.Forms.View.Details;
            // 
            // purchase_id
            // 
            this.purchase_id.Text = "order_id";
            this.purchase_id.Width = 0;
            // 
            // purchase
            // 
            this.purchase.Text = "Order No";
            this.purchase.Width = 130;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 90;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 0;
            // 
            // grdMainList
            // 
            this.grdMainList.AllowUserToAddRows = false;
            this.grdMainList.AllowUserToDeleteRows = false;
            this.grdMainList.AllowUserToOrderColumns = true;
            this.grdMainList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product,
            this.O_Qty,
            this.R_Qty,
            this.P_O_qty,
            this.P_Date,
            this.Stock,
            this.Hiddencoloum});
            this.grdMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMainList.Location = new System.Drawing.Point(283, 82);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.Size = new System.Drawing.Size(634, 356);
            this.grdMainList.TabIndex = 4;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product_id";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            this.product_id.Width = 5;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product.Width = 200;
            // 
            // O_Qty
            // 
            this.O_Qty.HeaderText = "O_Qty";
            this.O_Qty.Name = "O_Qty";
            this.O_Qty.Width = 60;
            // 
            // R_Qty
            // 
            this.R_Qty.HeaderText = "R_Qty";
            this.R_Qty.Name = "R_Qty";
            this.R_Qty.Width = 70;
            // 
            // P_O_qty
            // 
            this.P_O_qty.HeaderText = "P_P_Oty";
            this.P_O_qty.Name = "P_O_qty";
            this.P_O_qty.Width = 60;
            // 
            // P_Date
            // 
            this.P_Date.HeaderText = "P_P_Date";
            this.P_Date.Name = "P_Date";
            this.P_Date.Width = 120;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 60;
            // 
            // Hiddencoloum
            // 
            this.Hiddencoloum.HeaderText = "Hiddencoloum";
            this.Hiddencoloum.Name = "Hiddencoloum";
            this.Hiddencoloum.Visible = false;
            this.Hiddencoloum.Width = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(949, 36);
            this.label7.TabIndex = 108;
            this.label7.Text = "Purchase Order Review";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPurchaseOrder);
            this.groupBox1.Location = new System.Drawing.Point(8, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 385);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(275, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 385);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(751, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 112;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(836, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 113;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(662, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Indent By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIndentby
            // 
            this.txtIndentby.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentby.Location = new System.Drawing.Point(337, 462);
            this.txtIndentby.Name = "txtIndentby";
            this.txtIndentby.Size = new System.Drawing.Size(113, 22);
            this.txtIndentby.TabIndex = 114;
            // 
            // FrmPurchaseOrderReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndentby);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdMainList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPurchaseOrderReview";
            this.Text = "PurchaseOrderReview";
            this.Load += new System.EventHandler(this.FrmPurchaseOrderReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPurchaseOrder;
        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndentby;
        private System.Windows.Forms.ColumnHeader purchase_id;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_O_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiddencoloum;
    }
}