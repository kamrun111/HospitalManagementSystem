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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.grdlist = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpRequisitionDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblRequisitionDate = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiddencoloum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbproductCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwRequisitionDeliveryinfo = new System.Windows.Forms.ListView();
            this.requisition_no = new System.Windows.Forms.ColumnHeader();
            this.department = new System.Windows.Forms.ColumnHeader();
            this.requisition_id = new System.Windows.Forms.ColumnHeader();
            this.user = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.grpRequisition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRequisition
            // 
            this.grpRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRequisition.Controls.Add(this.btnDelete);
            this.grpRequisition.Controls.Add(this.txtCount);
            this.grpRequisition.Controls.Add(this.lblCount);
            this.grpRequisition.Controls.Add(this.grdlist);
            this.grpRequisition.Controls.Add(this.dtpRequisitionDate);
            this.grpRequisition.Controls.Add(this.btnRefresh);
            this.grpRequisition.Controls.Add(this.btnClose);
            this.grpRequisition.Controls.Add(this.btnSave);
            this.grpRequisition.Controls.Add(this.lblDepartment);
            this.grpRequisition.Controls.Add(this.lblRequisitionDate);
            this.grpRequisition.Controls.Add(this.cmbDepartment);
            this.grpRequisition.Location = new System.Drawing.Point(311, 60);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Size = new System.Drawing.Size(335, 452);
            this.grpRequisition.TabIndex = 1;
            this.grpRequisition.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::NewHIMS.Properties.Resources.RemoveSmall;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(6, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 111;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.Color.Brown;
            this.txtCount.Location = new System.Drawing.Point(113, 363);
            this.txtCount.MaxLength = 7;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(44, 20);
            this.txtCount.TabIndex = 110;
            this.txtCount.Tag = "purchase";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Brown;
            this.lblCount.Location = new System.Drawing.Point(15, 366);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(94, 13);
            this.lblCount.TabIndex = 109;
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
            this.grdlist.Location = new System.Drawing.Point(18, 81);
            this.grdlist.Name = "grdlist";
            this.grdlist.RowHeadersWidth = 21;
            this.grdlist.Size = new System.Drawing.Size(302, 276);
            this.grdlist.TabIndex = 108;
            this.grdlist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdlist_CellValueChanged);
            this.grdlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdlist_RowHeaderMouseClick);
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
            this.o_qty.HeaderText = "Order Qty";
            this.o_qty.MaxInputLength = 1000;
            this.o_qty.Name = "o_qty";
            this.o_qty.Width = 60;
            // 
            // dtpRequisitionDate
            // 
            this.dtpRequisitionDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpRequisitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequisitionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequisitionDate.Location = new System.Drawing.Point(119, 43);
            this.dtpRequisitionDate.Name = "dtpRequisitionDate";
            this.dtpRequisitionDate.Size = new System.Drawing.Size(138, 21);
            this.dtpRequisitionDate.TabIndex = 2;
            this.dtpRequisitionDate.Tag = "requisition_date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(168, 406);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 36);
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
            this.btnClose.Location = new System.Drawing.Point(253, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(82, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(20, 15);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(96, 16);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "Department :";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequisitionDate
            // 
            this.lblRequisitionDate.AutoSize = true;
            this.lblRequisitionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionDate.Location = new System.Drawing.Point(32, 46);
            this.lblRequisitionDate.Name = "lblRequisitionDate";
            this.lblRequisitionDate.Size = new System.Drawing.Size(82, 13);
            this.lblRequisitionDate.TabIndex = 47;
            this.lblRequisitionDate.Text = "Indent Date :";
            this.lblRequisitionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(119, 14);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(138, 21);
            this.cmbDepartment.TabIndex = 0;
            this.cmbDepartment.Tag = "department_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Category Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.grdMainList.Location = new System.Drawing.Point(8, 22);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.Size = new System.Drawing.Size(346, 365);
            this.grdMainList.TabIndex = 3;
            this.grdMainList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMainList_CellValueChanged);
            this.grdMainList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMainList_CellContentClick);
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
            this.Stock.Width = 60;
            // 
            // Hiddencoloum
            // 
            this.Hiddencoloum.HeaderText = "Hiddencoloum";
            this.Hiddencoloum.Name = "Hiddencoloum";
            this.Hiddencoloum.Visible = false;
            this.Hiddencoloum.Width = 5;
            // 
            // cmbproductCategory
            // 
            this.cmbproductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbproductCategory.FormattingEnabled = true;
            this.cmbproductCategory.Location = new System.Drawing.Point(136, 17);
            this.cmbproductCategory.Name = "cmbproductCategory";
            this.cmbproductCategory.Size = new System.Drawing.Size(203, 21);
            this.cmbproductCategory.TabIndex = 48;
            this.cmbproductCategory.Tag = "department_id";
            this.cmbproductCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbproductCategory_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-5, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1047, 33);
            this.label7.TabIndex = 107;
            this.label7.Text = "Indent Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdMainList);
            this.groupBox1.Location = new System.Drawing.Point(654, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 393);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbproductCategory);
            this.groupBox2.Location = new System.Drawing.Point(663, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 44);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            // 
            // lvwRequisitionDeliveryinfo
            // 
            this.lvwRequisitionDeliveryinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwRequisitionDeliveryinfo.BackColor = System.Drawing.Color.Thistle;
            this.lvwRequisitionDeliveryinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.requisition_no,
            this.department,
            this.requisition_id,
            this.user,
            this.Date});
            this.lvwRequisitionDeliveryinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRequisitionDeliveryinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwRequisitionDeliveryinfo.FullRowSelect = true;
            this.lvwRequisitionDeliveryinfo.HideSelection = false;
            this.lvwRequisitionDeliveryinfo.Location = new System.Drawing.Point(18, 66);
            this.lvwRequisitionDeliveryinfo.Name = "lvwRequisitionDeliveryinfo";
            this.lvwRequisitionDeliveryinfo.Size = new System.Drawing.Size(273, 446);
            this.lvwRequisitionDeliveryinfo.TabIndex = 115;
            this.lvwRequisitionDeliveryinfo.UseCompatibleStateImageBehavior = false;
            this.lvwRequisitionDeliveryinfo.View = System.Windows.Forms.View.Details;
            // 
            // requisition_no
            // 
            this.requisition_no.Text = "Requisition No";
            this.requisition_no.Width = 147;
            // 
            // department
            // 
            this.department.Text = "Department";
            this.department.Width = 0;
            // 
            // requisition_id
            // 
            this.requisition_id.Text = "requisitionID";
            this.requisition_id.Width = 0;
            // 
            // user
            // 
            this.user.Text = "user";
            this.user.Width = 0;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1037, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvwRequisitionDeliveryinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpRequisition);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRequisition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisition";
            this.Load += new System.EventHandler(this.FrmRequisition_Load);
            this.grpRequisition.ResumeLayout(false);
            this.grpRequisition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequisition;
        private System.Windows.Forms.DateTimePicker dtpRequisitionDate;
        private System.Windows.Forms.Label lblRequisitionDate;
        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbproductCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiddencoloum;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn o_qty;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvwRequisitionDeliveryinfo;
        private System.Windows.Forms.ColumnHeader requisition_no;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader requisition_id;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button button1;
    }
}