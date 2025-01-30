namespace NewHIMS.Forms.Store
{
    partial class FrmProductListView
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
            this.components = new System.ComponentModel.Container();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.rdoReorderlevel = new System.Windows.Forms.RadioButton();
            this.rdoAllproduct = new System.Windows.Forms.RadioButton();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblTotalSupplier2 = new System.Windows.Forms.Label();
            this.lblTotalSupplier = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lvwProduct = new System.Windows.Forms.ListView();
            this.product_id = new System.Windows.Forms.ColumnHeader();
            this.category = new System.Windows.Forms.ColumnHeader();
            this.Product = new System.Windows.Forms.ColumnHeader();
            this.Generic = new System.Windows.Forms.ColumnHeader();
            this.current_stock = new System.Windows.Forms.ColumnHeader();
            this.Default_Sales_Price = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.unit = new System.Windows.Forms.ColumnHeader();
            this.reorderlevel = new System.Windows.Forms.ColumnHeader();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.unitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consider_level = new System.Windows.Forms.ColumnHeader();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProduct
            // 
            this.grpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProduct.BackColor = System.Drawing.Color.Transparent;
            this.grpProduct.Controls.Add(this.rdoReorderlevel);
            this.grpProduct.Controls.Add(this.rdoAllproduct);
            this.grpProduct.Controls.Add(this.txtProduct);
            this.grpProduct.Controls.Add(this.lblTotalSupplier2);
            this.grpProduct.Controls.Add(this.lblTotalSupplier);
            this.grpProduct.Controls.Add(this.lblProduct);
            this.grpProduct.Controls.Add(this.lblCategory);
            this.grpProduct.Controls.Add(this.cmbCategory);
            this.grpProduct.Controls.Add(this.cmbProductType);
            this.grpProduct.Controls.Add(this.lblProductType);
            this.grpProduct.Controls.Add(this.btnPrint);
            this.grpProduct.Controls.Add(this.lvwProduct);
            this.grpProduct.Controls.Add(this.btnRefresh);
            this.grpProduct.Controls.Add(this.btnClose);
            this.grpProduct.Controls.Add(this.btnRemove);
            this.grpProduct.Controls.Add(this.btnEdit);
            this.grpProduct.Controls.Add(this.btnNew);
            this.grpProduct.Controls.Add(this.lblProductTitle);
            this.grpProduct.Location = new System.Drawing.Point(12, 8);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(836, 552);
            this.grpProduct.TabIndex = 3;
            this.grpProduct.TabStop = false;
            // 
            // rdoReorderlevel
            // 
            this.rdoReorderlevel.AutoSize = true;
            this.rdoReorderlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoReorderlevel.Location = new System.Drawing.Point(685, 27);
            this.rdoReorderlevel.Name = "rdoReorderlevel";
            this.rdoReorderlevel.Size = new System.Drawing.Size(131, 20);
            this.rdoReorderlevel.TabIndex = 60;
            this.rdoReorderlevel.Text = "Re Order Level";
            this.rdoReorderlevel.UseVisualStyleBackColor = true;
            this.rdoReorderlevel.Click += new System.EventHandler(this.rdoReorderlevel_Click);
            // 
            // rdoAllproduct
            // 
            this.rdoAllproduct.AutoSize = true;
            this.rdoAllproduct.Checked = true;
            this.rdoAllproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAllproduct.Location = new System.Drawing.Point(567, 27);
            this.rdoAllproduct.Name = "rdoAllproduct";
            this.rdoAllproduct.Size = new System.Drawing.Size(101, 20);
            this.rdoAllproduct.TabIndex = 59;
            this.rdoAllproduct.TabStop = true;
            this.rdoAllproduct.Text = "All Product";
            this.rdoAllproduct.UseVisualStyleBackColor = true;
            this.rdoAllproduct.Click += new System.EventHandler(this.rdoAllproduct_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(601, 69);
            this.txtProduct.MaxLength = 20;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(186, 20);
            this.txtProduct.TabIndex = 58;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            // 
            // lblTotalSupplier2
            // 
            this.lblTotalSupplier2.BackColor = System.Drawing.Color.Silver;
            this.lblTotalSupplier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier2.ForeColor = System.Drawing.Color.White;
            this.lblTotalSupplier2.Location = new System.Drawing.Point(476, 506);
            this.lblTotalSupplier2.Name = "lblTotalSupplier2";
            this.lblTotalSupplier2.Size = new System.Drawing.Size(77, 20);
            this.lblTotalSupplier2.TabIndex = 57;
            this.lblTotalSupplier2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSupplier
            // 
            this.lblTotalSupplier.AutoSize = true;
            this.lblTotalSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier.Location = new System.Drawing.Point(358, 506);
            this.lblTotalSupplier.Name = "lblTotalSupplier";
            this.lblTotalSupplier.Size = new System.Drawing.Size(113, 16);
            this.lblTotalSupplier.TabIndex = 56;
            this.lblTotalSupplier.Text = "Total  Products";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(531, 70);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 17);
            this.lblProduct.TabIndex = 53;
            this.lblProduct.Text = "Product";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(219, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(134, 17);
            this.lblCategory.TabIndex = 52;
            this.lblCategory.Text = "Product Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(361, 69);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(152, 21);
            this.cmbCategory.TabIndex = 50;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(115, 69);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(100, 21);
            this.cmbProductType.TabIndex = 49;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(9, 70);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(105, 17);
            this.lblProductType.TabIndex = 48;
            this.lblProductType.Text = "Product Type";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(708, 490);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 52);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvwProduct
            // 
            this.lvwProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product_id,
            this.category,
            this.Product,
            this.Generic,
            this.current_stock,
            this.Default_Sales_Price,
            this.Type,
            this.unit,
            this.reorderlevel,
            this.consider_level});
            this.lvwProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProduct.FullRowSelect = true;
            this.lvwProduct.GridLines = true;
            this.lvwProduct.Location = new System.Drawing.Point(12, 104);
            this.lvwProduct.Name = "lvwProduct";
            this.lvwProduct.Size = new System.Drawing.Size(825, 380);
            this.lvwProduct.TabIndex = 40;
            this.lvwProduct.UseCompatibleStateImageBehavior = false;
            this.lvwProduct.View = System.Windows.Forms.View.Details;
            // 
            // product_id
            // 
            this.product_id.Text = "P_ID";
            this.product_id.Width = 70;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 72;
            // 
            // Product
            // 
            this.Product.Text = "Product Name";
            this.Product.Width = 251;
            // 
            // Generic
            // 
            this.Generic.Text = "Generic Name";
            // 
            // current_stock
            // 
            this.current_stock.Text = "C_Stock";
            this.current_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.current_stock.Width = 70;
            // 
            // Default_Sales_Price
            // 
            this.Default_Sales_Price.Text = " Sales Price";
            this.Default_Sales_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Default_Sales_Price.Width = 93;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 0;
            // 
            // unit
            // 
            this.unit.Text = "Unit";
            this.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unit.Width = 0;
            // 
            // reorderlevel
            // 
            this.reorderlevel.Text = "Re Order Level";
            this.reorderlevel.Width = 108;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(182, 490);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 39;
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
            this.btnClose.Location = new System.Drawing.Point(773, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::NewHIMS.Properties.Resources.Remove;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.Location = new System.Drawing.Point(124, 490);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(52, 52);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "Delete";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::NewHIMS.Properties.Resources.Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(68, 490);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 52);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::NewHIMS.Properties.Resources.Save;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(12, 490);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(52, 52);
            this.btnNew.TabIndex = 34;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductTitle.Location = new System.Drawing.Point(355, 16);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(115, 31);
            this.lblProductTitle.TabIndex = 33;
            this.lblProductTitle.Text = "Product";
            this.lblProductTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // consider_level
            // 
            this.consider_level.Text = "SL No";
            // 
            // FrmProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(860, 569);
            this.Controls.Add(this.grpProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProductListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmProductListView_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblProductTitle;
       // private POS.NewHIMSDataSet3TableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource1;
        private System.Windows.Forms.ListView lvwProduct;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Generic;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader unit;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Default_Sales_Price;
        private System.Windows.Forms.ColumnHeader product_id;
        private System.Windows.Forms.ColumnHeader current_stock;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ColumnHeader reorderlevel;
        private System.Windows.Forms.Label lblTotalSupplier2;
        private System.Windows.Forms.Label lblTotalSupplier;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.RadioButton rdoReorderlevel;
        private System.Windows.Forms.RadioButton rdoAllproduct;
        private System.Windows.Forms.ColumnHeader consider_level;
    }
}