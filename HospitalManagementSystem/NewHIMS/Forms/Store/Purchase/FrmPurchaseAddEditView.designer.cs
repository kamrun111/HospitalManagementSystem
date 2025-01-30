namespace NewHIMS.Forms.Store
{
    partial class FrmPurchaseAddEditView
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
            this.grpPurchase = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grdPurchaseList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiddencoloum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIndentDate = new System.Windows.Forms.DateTimePicker();
            this.txtIndentNo = new System.Windows.Forms.TextBox();
            this.grpPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPurchase
            // 
            this.grpPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPurchase.BackColor = System.Drawing.Color.Transparent;
            this.grpPurchase.Controls.Add(this.txtIndentNo);
            this.grpPurchase.Controls.Add(this.dtpIndentDate);
            this.grpPurchase.Controls.Add(this.label3);
            this.grpPurchase.Controls.Add(this.label2);
            this.grpPurchase.Controls.Add(this.txtCount);
            this.grpPurchase.Controls.Add(this.lblCount);
            this.grpPurchase.Controls.Add(this.btnDelete);
            this.grpPurchase.Controls.Add(this.cmbProduct);
            this.grpPurchase.Controls.Add(this.lblProduct);
            this.grpPurchase.Controls.Add(this.cmbProductType);
            this.grpPurchase.Controls.Add(this.lblProductType);
            this.grpPurchase.Controls.Add(this.btnPrint);
            this.grpPurchase.Controls.Add(this.grdPurchaseList);
            this.grpPurchase.Controls.Add(this.button1);
            this.grpPurchase.Controls.Add(this.txtPurchase);
            this.grpPurchase.Controls.Add(this.label1);
            this.grpPurchase.Controls.Add(this.btnSave);
            this.grpPurchase.Controls.Add(this.btnClose);
            this.grpPurchase.Controls.Add(this.lblOrderDate);
            this.grpPurchase.Controls.Add(this.dtpOrderDate);
            this.grpPurchase.Controls.Add(this.lblSupplier);
            this.grpPurchase.Controls.Add(this.cmbSupplier);
            this.grpPurchase.Location = new System.Drawing.Point(13, 57);
            this.grpPurchase.Name = "grpPurchase";
            this.grpPurchase.Size = new System.Drawing.Size(473, 461);
            this.grpPurchase.TabIndex = 11;
            this.grpPurchase.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.Color.Brown;
            this.txtCount.Location = new System.Drawing.Point(114, 378);
            this.txtCount.MaxLength = 7;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(44, 20);
            this.txtCount.TabIndex = 58;
            this.txtCount.Tag = "purchase";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Brown;
            this.lblCount.Location = new System.Drawing.Point(19, 381);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(94, 13);
            this.lblCount.TabIndex = 57;
            this.lblCount.Text = "No. of Product:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::NewHIMS.Properties.Resources.RemoveSmall;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(208, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 36);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduct.Enabled = false;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(347, 109);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(38, 21);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.Visible = false;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Enabled = false;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(291, 113);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 13);
            this.lblProduct.TabIndex = 52;
            this.lblProduct.Text = "Product:";
            this.lblProduct.Visible = false;
            // 
            // cmbProductType
            // 
            this.cmbProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductType.Enabled = false;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(120, 25);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(141, 21);
            this.cmbProductType.TabIndex = 1;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            this.cmbProductType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductType_KeyDown);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Enabled = false;
            this.lblProductType.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(16, 27);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(94, 16);
            this.lblProductType.TabIndex = 50;
            this.lblProductType.Text = "Product Type :";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(298, 414);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 36);
            this.btnPrint.TabIndex = 49;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grdPurchaseList
            // 
            this.grdPurchaseList.AllowUserToAddRows = false;
            this.grdPurchaseList.AllowUserToDeleteRows = false;
            this.grdPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.order_qty,
            this.product_id});
            this.grdPurchaseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdPurchaseList.Location = new System.Drawing.Point(19, 147);
            this.grdPurchaseList.Name = "grdPurchaseList";
            this.grdPurchaseList.Size = new System.Drawing.Size(431, 223);
            this.grdPurchaseList.TabIndex = 5;
            this.grdPurchaseList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPurchaseList_CellValueChanged);
            this.grdPurchaseList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdPurchaseList_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 36);
            this.button1.TabIndex = 47;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPurchase
            // 
            this.txtPurchase.Enabled = false;
            this.txtPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchase.Location = new System.Drawing.Point(120, 83);
            this.txtPurchase.MaxLength = 7;
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.ReadOnly = true;
            this.txtPurchase.Size = new System.Drawing.Size(141, 20);
            this.txtPurchase.TabIndex = 46;
            this.txtPurchase.Tag = "purchase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Order Code :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(115, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnClose.Location = new System.Drawing.Point(386, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = " Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(24, 115);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(84, 16);
            this.lblOrderDate.TabIndex = 13;
            this.lblOrderDate.Text = " Order Date :";
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(120, 113);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(141, 20);
            this.dtpOrderDate.TabIndex = 10;
            this.dtpOrderDate.Tag = "order_date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(10, 56);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(99, 16);
            this.lblSupplier.TabIndex = 14;
            this.lblSupplier.Text = "Supplier Name :";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Enabled = false;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(120, 54);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(141, 21);
            this.cmbSupplier.TabIndex = 2;
            this.cmbSupplier.Tag = "supplier_id";
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            this.cmbSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSupplier_KeyDown);
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductCategory.Enabled = false;
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(140, 16);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(197, 21);
            this.cmbProductCategory.TabIndex = 3;
            this.cmbProductCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbProductCategory_SelectionChangeCommitted);
            this.cmbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cmbProductCategory_SelectedIndexChanged);
            this.cmbProductCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductCategory_KeyDown);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Enabled = false;
            this.lblProductCategory.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(21, 19);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(113, 16);
            this.lblProductCategory.TabIndex = 54;
            this.lblProductCategory.Text = "Product Category:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdMainList);
            this.groupBox1.Location = new System.Drawing.Point(492, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 408);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Name";
            // 
            // grdMainList
            // 
            this.grdMainList.AllowUserToAddRows = false;
            this.grdMainList.AllowUserToDeleteRows = false;
            this.grdMainList.AllowUserToOrderColumns = true;
            this.grdMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMainList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Stock,
            this.Hiddencoloum});
            this.grdMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMainList.Location = new System.Drawing.Point(11, 20);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.Size = new System.Drawing.Size(416, 374);
            this.grdMainList.TabIndex = 4;
            this.grdMainList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMainList_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 245;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProductCategory);
            this.groupBox2.Controls.Add(this.cmbProductCategory);
            this.groupBox2.Location = new System.Drawing.Point(492, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 44);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(951, 33);
            this.label7.TabIndex = 116;
            this.label7.Text = "Purchase Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(7, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(927, 481);
            this.groupBox3.TabIndex = 117;
            this.groupBox3.TabStop = false;
            // 
            // product
            // 
            this.product.HeaderText = "Description";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product.Width = 265;
            // 
            // order_qty
            // 
            this.order_qty.HeaderText = "Order Qty.";
            this.order_qty.MaxInputLength = 8;
            this.order_qty.Name = "order_qty";
            this.order_qty.Width = 90;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "PID";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Indent No :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Indent Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIndentDate
            // 
            this.dtpIndentDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpIndentDate.Enabled = false;
            this.dtpIndentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIndentDate.Location = new System.Drawing.Point(355, 83);
            this.dtpIndentDate.Name = "dtpIndentDate";
            this.dtpIndentDate.Size = new System.Drawing.Size(99, 20);
            this.dtpIndentDate.TabIndex = 61;
            this.dtpIndentDate.Tag = "order_date";
            // 
            // txtIndentNo
            // 
            this.txtIndentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentNo.Location = new System.Drawing.Point(355, 53);
            this.txtIndentNo.MaxLength = 7;
            this.txtIndentNo.Name = "txtIndentNo";
            this.txtIndentNo.Size = new System.Drawing.Size(99, 20);
            this.txtIndentNo.TabIndex = 62;
            this.txtIndentNo.Tag = "purchase";
            // 
            // FrmPurchaseAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(942, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPurchase);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPurchaseAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.FrmPurchaseAddEditView_Load);
            this.grpPurchase.ResumeLayout(false);
            this.grpPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPurchase;
        private System.Windows.Forms.DataGridView grdPurchaseList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiddencoloum;
        private System.Windows.Forms.DateTimePicker dtpIndentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.TextBox txtIndentNo;
    }
}