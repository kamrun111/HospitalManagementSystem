namespace NewHIMS.Forms.Store
{
    partial class FrmProductAddEditView
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
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtDefaultSalesPrice = new System.Windows.Forms.TextBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblGenericName = new System.Windows.Forms.Label();
            this.txtGenericName = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblDefaultSalesPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSLNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProduct
            // 
            this.grpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProduct.BackColor = System.Drawing.Color.Transparent;
            this.grpProduct.Controls.Add(this.cmbProductType);
            this.grpProduct.Controls.Add(this.lblProductType);
            this.grpProduct.Controls.Add(this.txtDefaultSalesPrice);
            this.grpProduct.Controls.Add(this.lblProductTitle);
            this.grpProduct.Controls.Add(this.lblProduct);
            this.grpProduct.Controls.Add(this.txtProduct);
            this.grpProduct.Controls.Add(this.lblGenericName);
            this.grpProduct.Controls.Add(this.txtGenericName);
            this.grpProduct.Controls.Add(this.lblProductCategory);
            this.grpProduct.Controls.Add(this.cmbProductCategory);
            this.grpProduct.Controls.Add(this.lblUnit);
            this.grpProduct.Controls.Add(this.cmbUnit);
            this.grpProduct.Controls.Add(this.lblDefaultSalesPrice);
            this.grpProduct.Controls.Add(this.groupBox1);
            this.grpProduct.Controls.Add(this.groupBox2);
            this.grpProduct.Location = new System.Drawing.Point(12, 8);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(433, 340);
            this.grpProduct.TabIndex = 1;
            this.grpProduct.TabStop = false;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(217, 181);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(67, 13);
            this.lblReorderLevel.TabIndex = 35;
            this.lblReorderLevel.Text = "Reorder L:";
            this.lblReorderLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(289, 177);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(105, 20);
            this.txtReorderLevel.TabIndex = 34;
            this.txtReorderLevel.Tag = "";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(117, 149);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(96, 21);
            this.cmbProductType.TabIndex = 32;
            this.cmbProductType.Tag = "product_type_id";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(26, 153);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(87, 13);
            this.lblProductType.TabIndex = 33;
            this.lblProductType.Text = "Product Type:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDefaultSalesPrice
            // 
            this.txtDefaultSalesPrice.Location = new System.Drawing.Point(303, 186);
            this.txtDefaultSalesPrice.Name = "txtDefaultSalesPrice";
            this.txtDefaultSalesPrice.Size = new System.Drawing.Size(105, 20);
            this.txtDefaultSalesPrice.TabIndex = 7;
            this.txtDefaultSalesPrice.Tag = "default_sales_price";
            this.txtDefaultSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDefaultSalesPrice_KeyPress);
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductTitle.Location = new System.Drawing.Point(163, 12);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(115, 31);
            this.lblProductTitle.TabIndex = 31;
            this.lblProductTitle.Text = "Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(21, 75);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(91, 13);
            this.lblProduct.TabIndex = 13;
            this.lblProduct.Text = "Product Name:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(117, 71);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(291, 20);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.Tag = "product";
            // 
            // lblGenericName
            // 
            this.lblGenericName.AutoSize = true;
            this.lblGenericName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenericName.Location = new System.Drawing.Point(33, 115);
            this.lblGenericName.Name = "lblGenericName";
            this.lblGenericName.Size = new System.Drawing.Size(78, 13);
            this.lblGenericName.TabIndex = 14;
            this.lblGenericName.Text = "Generic Name:";
            this.lblGenericName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGenericName
            // 
            this.txtGenericName.Location = new System.Drawing.Point(117, 111);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.Size = new System.Drawing.Size(291, 20);
            this.txtGenericName.TabIndex = 1;
            this.txtGenericName.Tag = "generic_name";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(238, 153);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(61, 13);
            this.lblProductCategory.TabIndex = 15;
            this.lblProductCategory.Text = "Category:";
            this.lblProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(303, 149);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(105, 21);
            this.cmbProductCategory.TabIndex = 2;
            this.cmbProductCategory.Tag = "product_category_id";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(31, 190);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(82, 13);
            this.lblUnit.TabIndex = 19;
            this.lblUnit.Text = "Product Unit:";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(117, 186);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(96, 21);
            this.cmbUnit.TabIndex = 6;
            this.cmbUnit.Tag = "unit_id";
            // 
            // lblDefaultSalesPrice
            // 
            this.lblDefaultSalesPrice.AutoSize = true;
            this.lblDefaultSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultSalesPrice.Location = new System.Drawing.Point(219, 190);
            this.lblDefaultSalesPrice.Name = "lblDefaultSalesPrice";
            this.lblDefaultSalesPrice.Size = new System.Drawing.Size(79, 13);
            this.lblDefaultSalesPrice.TabIndex = 20;
            this.lblDefaultSalesPrice.Text = " Sales Price:";
            this.lblDefaultSalesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(14, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 64);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(35, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 9;
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
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(203, 23);
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
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(315, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReorderLevel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSLNo);
            this.groupBox2.Controls.Add(this.txtReorderLevel);
            this.groupBox2.Location = new System.Drawing.Point(14, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 213);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // txtSLNo
            // 
            this.txtSLNo.Location = new System.Drawing.Point(103, 177);
            this.txtSLNo.Name = "txtSLNo";
            this.txtSLNo.Size = new System.Drawing.Size(96, 20);
            this.txtSLNo.TabIndex = 38;
            this.txtSLNo.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Product SL No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmProductAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(457, 360);
            this.Controls.Add(this.grpProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FrmProductAddEditView_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtDefaultSalesPrice;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblGenericName;
        private System.Windows.Forms.TextBox txtGenericName;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblDefaultSalesPrice;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLNo;
    }
}