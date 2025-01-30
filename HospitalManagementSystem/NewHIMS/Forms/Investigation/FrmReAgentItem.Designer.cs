namespace NewHIMS.Forms.Investigation
{
    partial class FrmReAgentItem
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
            this.lblReAgentItemTitle = new System.Windows.Forms.Label();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTestGroup = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grdReAgentItem = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.required_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trvTestItem = new System.Windows.Forms.TreeView();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReAgentItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReAgentItemTitle
            // 
            this.lblReAgentItemTitle.AutoSize = true;
            this.lblReAgentItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReAgentItemTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblReAgentItemTitle.Location = new System.Drawing.Point(253, 27);
            this.lblReAgentItemTitle.Name = "lblReAgentItemTitle";
            this.lblReAgentItemTitle.Size = new System.Drawing.Size(202, 31);
            this.lblReAgentItemTitle.TabIndex = 32;
            this.lblReAgentItemTitle.Text = "Re-Agent Item";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.lblProduct);
            this.grpMain.Controls.Add(this.cmbProduct);
            this.grpMain.Controls.Add(this.lblProductCategory);
            this.grpMain.Controls.Add(this.cmbProductCategory);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.cmbTestGroup);
            this.grpMain.Controls.Add(this.btnDelete);
            this.grpMain.Controls.Add(this.btnPrint);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.btnRefresh);
            this.grpMain.Controls.Add(this.btnClose);
            this.grpMain.Controls.Add(this.grdReAgentItem);
            this.grpMain.Controls.Add(this.trvTestItem);
            this.grpMain.Controls.Add(this.lblDepartment);
            this.grpMain.Controls.Add(this.cmbDepartment);
            this.grpMain.Controls.Add(this.lblReAgentItemTitle);
            this.grpMain.Location = new System.Drawing.Point(8, 1);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(684, 607);
            this.grpMain.TabIndex = 33;
            this.grpMain.TabStop = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(377, 185);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(39, 13);
            this.lblProduct.TabIndex = 48;
            this.lblProduct.Text = "Name";
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduct.Enabled = false;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(463, 182);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(213, 21);
            this.cmbProduct.TabIndex = 47;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            this.cmbProduct.Click += new System.EventHandler(this.cmbProduct_Click);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(377, 158);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(57, 13);
            this.lblProductCategory.TabIndex = 46;
            this.lblProductCategory.Text = "Category";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(463, 155);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(213, 21);
            this.cmbProductCategory.TabIndex = 45;
            this.cmbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cmbProductCategory_SelectedIndexChanged);
            this.cmbProductCategory.Click += new System.EventHandler(this.cmbProductCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Group";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTestGroup
            // 
            this.cmbTestGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTestGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestGroup.BackColor = System.Drawing.Color.White;
            this.cmbTestGroup.FormattingEnabled = true;
            this.cmbTestGroup.Location = new System.Drawing.Point(463, 111);
            this.cmbTestGroup.Name = "cmbTestGroup";
            this.cmbTestGroup.Size = new System.Drawing.Size(213, 21);
            this.cmbTestGroup.TabIndex = 43;
            this.cmbTestGroup.Tag = "patient_id";
            this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::NewHIMS.Properties.Resources.RemoveSmall;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(364, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(285, 554);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(443, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(522, 554);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(601, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdReAgentItem
            // 
            this.grdReAgentItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReAgentItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.unit_id,
            this.product_name,
            this.required_qty,
            this.unit});
            this.grdReAgentItem.Location = new System.Drawing.Point(291, 215);
            this.grdReAgentItem.Name = "grdReAgentItem";
            this.grdReAgentItem.Size = new System.Drawing.Size(385, 303);
            this.grdReAgentItem.TabIndex = 37;
            this.grdReAgentItem.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdReAgentItem_RowHeaderMouseClick);
            this.grdReAgentItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReAgentItem_CellValueChanged);
            this.grdReAgentItem.Click += new System.EventHandler(this.grdReAgentItem_Click);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product ID";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // unit_id
            // 
            this.unit_id.HeaderText = "Unit ID";
            this.unit_id.Name = "unit_id";
            this.unit_id.Visible = false;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Re-Agent Item";
            this.product_name.Name = "product_name";
            this.product_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product_name.Width = 200;
            // 
            // required_qty
            // 
            this.required_qty.HeaderText = "Required Qty";
            this.required_qty.Name = "required_qty";
            this.required_qty.Width = 80;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit.Width = 60;
            // 
            // trvTestItem
            // 
            this.trvTestItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.trvTestItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvTestItem.Location = new System.Drawing.Point(6, 84);
            this.trvTestItem.Name = "trvTestItem";
            this.trvTestItem.Size = new System.Drawing.Size(274, 517);
            this.trvTestItem.TabIndex = 36;
            this.trvTestItem.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvTestItem_NodeMouseClick);
            this.trvTestItem.Click += new System.EventHandler(this.trvTestItem_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(377, 85);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 15);
            this.lblDepartment.TabIndex = 35;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.BackColor = System.Drawing.Color.White;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(463, 84);
            this.cmbDepartment.MaxLength = 25;
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(213, 21);
            this.cmbDepartment.TabIndex = 34;
            this.cmbDepartment.Tag = "occupation_id";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // FrmReAgentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(701, 619);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReAgentItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReAgentItem";
            this.Load += new System.EventHandler(this.FrmReAgentItem_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReAgentItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReAgentItemTitle;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TreeView trvTestItem;
        private System.Windows.Forms.DataGridView grdReAgentItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTestGroup;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn required_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}