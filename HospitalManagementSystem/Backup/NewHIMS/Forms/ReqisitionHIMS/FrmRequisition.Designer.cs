namespace NewHIMS.Forms.ReqisitionHIMS
{
    partial class FrmRequisition
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
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbproductCategory = new System.Windows.Forms.ComboBox();
            this.dtpRequisitionDate = new System.Windows.Forms.DateTimePicker();
            this.lblRequisitionDate = new System.Windows.Forms.Label();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbstoreID = new System.Windows.Forms.ComboBox();
            this.lblRequisitionTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRequisitionNo = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpRequisition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRequisition
            // 
            this.grpRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRequisition.Controls.Add(this.cmbproduct);
            this.grpRequisition.Controls.Add(this.label1);
            this.grpRequisition.Controls.Add(this.cmbproductCategory);
            this.grpRequisition.Controls.Add(this.dtpRequisitionDate);
            this.grpRequisition.Controls.Add(this.lblRequisitionDate);
            this.grpRequisition.Controls.Add(this.grdMainList);
            this.grpRequisition.Controls.Add(this.lblProductType);
            this.grpRequisition.Controls.Add(this.cmbstoreID);
            this.grpRequisition.Controls.Add(this.lblRequisitionTitle);
            this.grpRequisition.Controls.Add(this.btnRefresh);
            this.grpRequisition.Controls.Add(this.btnClose);
            this.grpRequisition.Controls.Add(this.lblRequisitionNo);
            this.grpRequisition.Controls.Add(this.lblDepartment);
            this.grpRequisition.Controls.Add(this.cmbDepartment);
            this.grpRequisition.Controls.Add(this.btnSave);
            this.grpRequisition.Location = new System.Drawing.Point(12, 8);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Size = new System.Drawing.Size(501, 495);
            this.grpRequisition.TabIndex = 1;
            this.grpRequisition.TabStop = false;
            // 
            // cmbproduct
            // 
            this.cmbproduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbproduct.Enabled = false;
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(135, 175);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(195, 21);
            this.cmbproduct.TabIndex = 51;
            this.cmbproduct.Tag = "department_id";
            this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Category Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbproductCategory
            // 
            this.cmbproductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbproductCategory.Enabled = false;
            this.cmbproductCategory.FormattingEnabled = true;
            this.cmbproductCategory.Location = new System.Drawing.Point(135, 147);
            this.cmbproductCategory.Name = "cmbproductCategory";
            this.cmbproductCategory.Size = new System.Drawing.Size(130, 21);
            this.cmbproductCategory.TabIndex = 48;
            this.cmbproductCategory.Tag = "department_id";
            this.cmbproductCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbproductCategory_SelectionChangeCommitted);
            // 
            // dtpRequisitionDate
            // 
            this.dtpRequisitionDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpRequisitionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequisitionDate.Location = new System.Drawing.Point(386, 172);
            this.dtpRequisitionDate.Name = "dtpRequisitionDate";
            this.dtpRequisitionDate.Size = new System.Drawing.Size(102, 20);
            this.dtpRequisitionDate.TabIndex = 2;
            this.dtpRequisitionDate.Tag = "requisition_date";
            // 
            // lblRequisitionDate
            // 
            this.lblRequisitionDate.AutoSize = true;
            this.lblRequisitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionDate.Location = new System.Drawing.Point(341, 176);
            this.lblRequisitionDate.Name = "lblRequisitionDate";
            this.lblRequisitionDate.Size = new System.Drawing.Size(38, 13);
            this.lblRequisitionDate.TabIndex = 47;
            this.lblRequisitionDate.Text = "Date:";
            this.lblRequisitionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdMainList
            // 
            this.grdMainList.AllowUserToAddRows = false;
            this.grdMainList.AllowUserToDeleteRows = false;
            this.grdMainList.AllowUserToOrderColumns = true;
            this.grdMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product,
            this.order_qty});
            this.grdMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMainList.Location = new System.Drawing.Point(13, 204);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.Size = new System.Drawing.Size(475, 243);
            this.grdMainList.TabIndex = 3;
            this.grdMainList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMainList_CellValueChanged);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Product_id";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product.Width = 320;
            // 
            // order_qty
            // 
            this.order_qty.HeaderText = "Order Qty.";
            this.order_qty.Name = "order_qty";
            this.order_qty.Width = 80;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(18, 123);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(89, 16);
            this.lblProductType.TabIndex = 45;
            this.lblProductType.Text = "Store Type:";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbstoreID
            // 
            this.cmbstoreID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbstoreID.FormattingEnabled = true;
            this.cmbstoreID.Location = new System.Drawing.Point(135, 120);
            this.cmbstoreID.Name = "cmbstoreID";
            this.cmbstoreID.Size = new System.Drawing.Size(130, 21);
            this.cmbstoreID.TabIndex = 1;
            this.cmbstoreID.Tag = "product_type_id";
            this.cmbstoreID.SelectionChangeCommitted += new System.EventHandler(this.cmbstoreID_SelectionChangeCommitted);
            // 
            // lblRequisitionTitle
            // 
            this.lblRequisitionTitle.AutoSize = true;
            this.lblRequisitionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequisitionTitle.Location = new System.Drawing.Point(141, 30);
            this.lblRequisitionTitle.Name = "lblRequisitionTitle";
            this.lblRequisitionTitle.Size = new System.Drawing.Size(242, 31);
            this.lblRequisitionTitle.TabIndex = 31;
            this.lblRequisitionTitle.Text = "Requisition Order";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
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
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
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
            this.lblRequisitionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionNo.Location = new System.Drawing.Point(18, 176);
            this.lblRequisitionNo.Name = "lblRequisitionNo";
            this.lblRequisitionNo.Size = new System.Drawing.Size(65, 16);
            this.lblRequisitionNo.TabIndex = 10;
            this.lblRequisitionNo.Text = "Product:";
            this.lblRequisitionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(18, 96);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(92, 16);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(135, 93);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(130, 21);
            this.cmbDepartment.TabIndex = 0;
            this.cmbDepartment.Tag = "department_id";
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(235, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 511);
            this.Controls.Add(this.grpRequisition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRequisition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisition";
            this.Load += new System.EventHandler(this.FrmRequisition_Load);
            this.grpRequisition.ResumeLayout(false);
            this.grpRequisition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequisition;
        private System.Windows.Forms.DateTimePicker dtpRequisitionDate;
        private System.Windows.Forms.Label lblRequisitionDate;
        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbstoreID;
        private System.Windows.Forms.Label lblRequisitionTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRequisitionNo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbproductCategory;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
    }
}