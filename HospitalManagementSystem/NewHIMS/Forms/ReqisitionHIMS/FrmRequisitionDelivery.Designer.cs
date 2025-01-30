namespace NewHIMS.Forms.ReqisitionHIMS
{
    partial class FrmRequisitionDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisitionDelivery));
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndentby = new System.Windows.Forms.TextBox();
            this.lvwNotReceived = new System.Windows.Forms.ListView();
            this.req_no = new System.Windows.Forms.ColumnHeader();
            this.dept = new System.Windows.Forms.ColumnHeader();
            this.req_id = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.user2 = new System.Windows.Forms.ColumnHeader();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lvwRequisitionDeliveryinfo = new System.Windows.Forms.ListView();
            this.requisition_no = new System.Windows.Forms.ColumnHeader();
            this.department = new System.Windows.Forms.ColumnHeader();
            this.requisition_id = new System.Windows.Forms.ColumnHeader();
            this.user = new System.Windows.Forms.ColumnHeader();
            this.grdRequisitionDelivery = new System.Windows.Forms.DataGridView();
            this.requisition_ptoduction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode_receive_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receive_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpRequisition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisitionDelivery)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRequisition
            // 
            this.grpRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRequisition.BackColor = System.Drawing.Color.Transparent;
            this.grpRequisition.Controls.Add(this.txtCount);
            this.grpRequisition.Controls.Add(this.lblCount);
            this.grpRequisition.Controls.Add(this.label1);
            this.grpRequisition.Controls.Add(this.txtIndentby);
            this.grpRequisition.Controls.Add(this.lvwNotReceived);
            this.grpRequisition.Controls.Add(this.cmbProductType);
            this.grpRequisition.Controls.Add(this.lblProductType);
            this.grpRequisition.Controls.Add(this.lvwRequisitionDeliveryinfo);
            this.grpRequisition.Controls.Add(this.grdRequisitionDelivery);
            this.grpRequisition.Controls.Add(this.groupBox1);
            this.grpRequisition.Controls.Add(this.groupBox2);
            this.grpRequisition.Controls.Add(this.groupBox3);
            this.grpRequisition.Controls.Add(this.groupBox4);
            this.grpRequisition.Controls.Add(this.groupBox5);
            this.grpRequisition.Controls.Add(this.groupBox6);
            this.grpRequisition.Location = new System.Drawing.Point(10, 53);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Size = new System.Drawing.Size(840, 490);
            this.grpRequisition.TabIndex = 11;
            this.grpRequisition.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.Color.Brown;
            this.txtCount.Location = new System.Drawing.Point(735, 385);
            this.txtCount.MaxLength = 7;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(72, 20);
            this.txtCount.TabIndex = 112;
            this.txtCount.Tag = "purchase";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Brown;
            this.lblCount.Location = new System.Drawing.Point(670, 389);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 13);
            this.lblCount.TabIndex = 111;
            this.lblCount.Text = "Total Tk.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Indent By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIndentby
            // 
            this.txtIndentby.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentby.Location = new System.Drawing.Point(419, 384);
            this.txtIndentby.Name = "txtIndentby";
            this.txtIndentby.Size = new System.Drawing.Size(143, 22);
            this.txtIndentby.TabIndex = 51;
            // 
            // lvwNotReceived
            // 
            this.lvwNotReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwNotReceived.BackColor = System.Drawing.Color.Thistle;
            this.lvwNotReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.req_no,
            this.dept,
            this.req_id,
            this.status,
            this.user2});
            this.lvwNotReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNotReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwNotReceived.FullRowSelect = true;
            this.lvwNotReceived.GridLines = true;
            this.lvwNotReceived.HideSelection = false;
            this.lvwNotReceived.Location = new System.Drawing.Point(16, 313);
            this.lvwNotReceived.Name = "lvwNotReceived";
            this.lvwNotReceived.Size = new System.Drawing.Size(297, 101);
            this.lvwNotReceived.TabIndex = 50;
            this.lvwNotReceived.UseCompatibleStateImageBehavior = false;
            this.lvwNotReceived.View = System.Windows.Forms.View.Details;
            this.lvwNotReceived.Click += new System.EventHandler(this.lvwNotReceived_Click);
            // 
            // req_no
            // 
            this.req_no.Text = "Req. No";
            this.req_no.Width = 127;
            // 
            // dept
            // 
            this.dept.Text = "Department";
            this.dept.Width = 148;
            // 
            // req_id
            // 
            this.req_id.Text = "requisitionID";
            this.req_id.Width = 0;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 0;
            // 
            // user2
            // 
            this.user2.Text = "user2";
            this.user2.Width = 0;
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(141, 442);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(121, 21);
            this.cmbProductType.TabIndex = 49;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(66, 446);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(69, 13);
            this.lblProductType.TabIndex = 48;
            this.lblProductType.Text = "Store Type";
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
            this.user});
            this.lvwRequisitionDeliveryinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRequisitionDeliveryinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwRequisitionDeliveryinfo.FullRowSelect = true;
            this.lvwRequisitionDeliveryinfo.GridLines = true;
            this.lvwRequisitionDeliveryinfo.HideSelection = false;
            this.lvwRequisitionDeliveryinfo.Location = new System.Drawing.Point(16, 24);
            this.lvwRequisitionDeliveryinfo.Name = "lvwRequisitionDeliveryinfo";
            this.lvwRequisitionDeliveryinfo.Size = new System.Drawing.Size(297, 269);
            this.lvwRequisitionDeliveryinfo.TabIndex = 1;
            this.lvwRequisitionDeliveryinfo.UseCompatibleStateImageBehavior = false;
            this.lvwRequisitionDeliveryinfo.View = System.Windows.Forms.View.Details;
            this.lvwRequisitionDeliveryinfo.Click += new System.EventHandler(this.lvwRequisitionDeliveryinfo_Click);
            // 
            // requisition_no
            // 
            this.requisition_no.Text = "Requisition No";
            this.requisition_no.Width = 127;
            // 
            // department
            // 
            this.department.Text = "Department";
            this.department.Width = 148;
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
            // grdRequisitionDelivery
            // 
            this.grdRequisitionDelivery.AllowUserToAddRows = false;
            this.grdRequisitionDelivery.AllowUserToDeleteRows = false;
            this.grdRequisitionDelivery.AllowUserToOrderColumns = true;
            this.grdRequisitionDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRequisitionDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdRequisitionDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequisitionDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requisition_ptoduction_id,
            this.barcode_receive_product,
            this.product_id,
            this.Product,
            this.order_qty,
            this.receive_qty,
            this.derived,
            this.delivery_qty,
            this.pre_delivery,
            this.current_stock,
            this.unit_price});
            this.grdRequisitionDelivery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdRequisitionDelivery.EnableHeadersVisualStyles = false;
            this.grdRequisitionDelivery.Location = new System.Drawing.Point(341, 25);
            this.grdRequisitionDelivery.Name = "grdRequisitionDelivery";
            this.grdRequisitionDelivery.RowHeadersVisible = false;
            this.grdRequisitionDelivery.Size = new System.Drawing.Size(478, 334);
            this.grdRequisitionDelivery.TabIndex = 2;
            this.grdRequisitionDelivery.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRequisitionDelivery_CellValueChanged);
            // 
            // requisition_ptoduction_id
            // 
            this.requisition_ptoduction_id.HeaderText = "RequisitionProductionID";
            this.requisition_ptoduction_id.Name = "requisition_ptoduction_id";
            this.requisition_ptoduction_id.ReadOnly = true;
            this.requisition_ptoduction_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.requisition_ptoduction_id.Visible = false;
            // 
            // barcode_receive_product
            // 
            this.barcode_receive_product.HeaderText = "Barcode";
            this.barcode_receive_product.Name = "barcode_receive_product";
            this.barcode_receive_product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.barcode_receive_product.Visible = false;
            this.barcode_receive_product.Width = 5;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "productID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product_id.Visible = false;
            this.product_id.Width = 5;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product.Width = 200;
            // 
            // order_qty
            // 
            this.order_qty.HeaderText = "Order Qty";
            this.order_qty.Name = "order_qty";
            this.order_qty.ReadOnly = true;
            this.order_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_qty.Width = 70;
            // 
            // receive_qty
            // 
            this.receive_qty.HeaderText = "Receive Qty";
            this.receive_qty.Name = "receive_qty";
            this.receive_qty.ReadOnly = true;
            this.receive_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receive_qty.Visible = false;
            this.receive_qty.Width = 70;
            // 
            // derived
            // 
            this.derived.HeaderText = "Pending";
            this.derived.Name = "derived";
            this.derived.ReadOnly = true;
            this.derived.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.derived.Visible = false;
            this.derived.Width = 50;
            // 
            // delivery_qty
            // 
            this.delivery_qty.HeaderText = "Delivery Qty";
            this.delivery_qty.Name = "delivery_qty";
            this.delivery_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delivery_qty.Width = 70;
            // 
            // pre_delivery
            // 
            this.pre_delivery.HeaderText = "PreDelivery";
            this.pre_delivery.Name = "pre_delivery";
            this.pre_delivery.Visible = false;
            this.pre_delivery.Width = 50;
            // 
            // current_stock
            // 
            this.current_stock.HeaderText = "Stock";
            this.current_stock.Name = "current_stock";
            this.current_stock.Width = 50;
            // 
            // unit_price
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.unit_price.DefaultCellStyle = dataGridViewCellStyle1;
            this.unit_price.HeaderText = "u.p.price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(331, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 356);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 291);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 121);
            this.groupBox3.TabIndex = 115;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(331, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 56);
            this.groupBox4.TabIndex = 116;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPrint);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Location = new System.Drawing.Point(331, 422);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(497, 57);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(130, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 31);
            this.btnPrint.TabIndex = 53;
            this.btnPrint.Text = "   Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(281, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 31);
            this.btnSave.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(397, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(6, 422);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 57);
            this.groupBox6.TabIndex = 117;
            this.groupBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-5, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(870, 33);
            this.label7.TabIndex = 108;
            this.label7.Text = "Indent Delivery";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRequisitionDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(862, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpRequisition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRequisitionDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisition Delivery";
            this.Load += new System.EventHandler(this.FrmRequisitionDelivery_Load);
            this.grpRequisition.ResumeLayout(false);
            this.grpRequisition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisitionDelivery)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequisition;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvwRequisitionDeliveryinfo;
        private System.Windows.Forms.ColumnHeader requisition_no;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader requisition_id;
        private System.Windows.Forms.DataGridView grdRequisitionDelivery;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ListView lvwNotReceived;
        private System.Windows.Forms.ColumnHeader req_no;
        private System.Windows.Forms.ColumnHeader dept;
        private System.Windows.Forms.ColumnHeader req_id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndentby;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader user2;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisition_ptoduction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode_receive_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn receive_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn derived;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}