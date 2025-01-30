namespace NewHIMS.Forms.Store.Inventory
{
    partial class FrmItemAddLoss
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbproductCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiddencoloum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpRequisitionDate = new System.Windows.Forms.DateTimePicker();
            this.lblRequisitionDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(699, 35);
            this.label7.TabIndex = 109;
            this.label7.Text = "Item Adjustment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbproductCategory);
            this.groupBox2.Location = new System.Drawing.Point(360, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 44);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Category Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbproductCategory
            // 
            this.cmbproductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbproductCategory.FormattingEnabled = true;
            this.cmbproductCategory.Location = new System.Drawing.Point(130, 17);
            this.cmbproductCategory.Name = "cmbproductCategory";
            this.cmbproductCategory.Size = new System.Drawing.Size(164, 21);
            this.cmbproductCategory.TabIndex = 48;
            this.cmbproductCategory.Tag = "department_id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdMainList);
            this.groupBox1.Location = new System.Drawing.Point(360, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 390);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
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
            this.product_id,
            this.product,
            this.Stock,
            this.Hiddencoloum});
            this.grdMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMainList.Location = new System.Drawing.Point(13, 19);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.Size = new System.Drawing.Size(288, 362);
            this.grdMainList.TabIndex = 3;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 50;
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
            this.product.Width = 180;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 5;
            // 
            // Hiddencoloum
            // 
            this.Hiddencoloum.HeaderText = "Hiddencoloum";
            this.Hiddencoloum.Name = "Hiddencoloum";
            this.Hiddencoloum.Visible = false;
            this.Hiddencoloum.Width = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::NewHIMS.Properties.Resources.RemoveSmall;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(24, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 28);
            this.btnDelete.TabIndex = 123;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.Color.Brown;
            this.txtCount.Location = new System.Drawing.Point(116, 425);
            this.txtCount.MaxLength = 7;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(44, 20);
            this.txtCount.TabIndex = 122;
            this.txtCount.Tag = "purchase";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Brown;
            this.lblCount.Location = new System.Drawing.Point(19, 428);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(94, 13);
            this.lblCount.TabIndex = 121;
            this.lblCount.Text = "No. of Product:";
            // 
            // grdlist
            // 
            this.grdlist.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdlist.ColumnHeadersHeight = 21;
            this.grdlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.Item_Name,
            this.o_qty});
            this.grdlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdlist.Location = new System.Drawing.Point(28, 109);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 21;
            this.grdlist.Size = new System.Drawing.Size(302, 310);
            this.grdlist.TabIndex = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(186, 461);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 118;
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
            this.btnClose.Location = new System.Drawing.Point(271, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 28);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(100, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtpRequisitionDate
            // 
            this.dtpRequisitionDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpRequisitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequisitionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequisitionDate.Location = new System.Drawing.Point(69, 72);
            this.dtpRequisitionDate.Name = "dtpRequisitionDate";
            this.dtpRequisitionDate.Size = new System.Drawing.Size(138, 21);
            this.dtpRequisitionDate.TabIndex = 124;
            this.dtpRequisitionDate.Tag = "requisition_date";
            // 
            // lblRequisitionDate
            // 
            this.lblRequisitionDate.AutoSize = true;
            this.lblRequisitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionDate.Location = new System.Drawing.Point(25, 75);
            this.lblRequisitionDate.Name = "lblRequisitionDate";
            this.lblRequisitionDate.Size = new System.Drawing.Size(38, 13);
            this.lblRequisitionDate.TabIndex = 125;
            this.lblRequisitionDate.Text = "Date:";
            this.lblRequisitionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 441);
            this.groupBox3.TabIndex = 126;
            this.groupBox3.TabStop = false;
            // 
            // P_ID
            // 
            this.P_ID.HeaderText = "P_ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Product";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 200;
            // 
            // o_qty
            // 
            this.o_qty.HeaderText = "Qty";
            this.o_qty.MaxInputLength = 1000;
            this.o_qty.Name = "o_qty";
            this.o_qty.Width = 60;
            // 
            // FrmItemAddLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 507);
            this.Controls.Add(this.dtpRequisitionDate);
            this.Controls.Add(this.lblRequisitionDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.grdlist);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmItemAddLoss";
            this.Text = "FrmItemAddLoss";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbproductCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiddencoloum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpRequisitionDate;
        private System.Windows.Forms.Label lblRequisitionDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_qty;
    }
}