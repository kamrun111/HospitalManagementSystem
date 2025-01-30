namespace NewHIMS.Forms.Store
{
    partial class FrmReceiveAddEditView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpReceive = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lvlGrandTotal = new System.Windows.Forms.Label();
            this.btnWithPurchase = new System.Windows.Forms.Button();
            this.btnWithoutPurchase = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grdReceiveList = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_received_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receive_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_purchase_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_Saved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.default_sales_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lvwPurchaseOrder = new System.Windows.Forms.ListView();
            this.purchase_id = new System.Windows.Forms.ColumnHeader();
            this.purchase = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.grpReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceiveList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReceive
            // 
            this.grpReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReceive.BackColor = System.Drawing.Color.Transparent;
            this.grpReceive.Controls.Add(this.txtCount);
            this.grpReceive.Controls.Add(this.lblCount);
            this.grpReceive.Controls.Add(this.txtTotal);
            this.grpReceive.Controls.Add(this.lvlGrandTotal);
            this.grpReceive.Controls.Add(this.btnWithPurchase);
            this.grpReceive.Controls.Add(this.btnWithoutPurchase);
            this.grpReceive.Controls.Add(this.btnPrint);
            this.grpReceive.Controls.Add(this.grdReceiveList);
            this.grpReceive.Controls.Add(this.btnRefresh);
            this.grpReceive.Controls.Add(this.btnSave);
            this.grpReceive.Controls.Add(this.btnClose);
            this.grpReceive.Controls.Add(this.lblInvoiceNo);
            this.grpReceive.Controls.Add(this.txtInvoiceNo);
            this.grpReceive.Controls.Add(this.lblInvoiceDate);
            this.grpReceive.Controls.Add(this.dtpInvoiceDate);
            this.grpReceive.Controls.Add(this.lblReceivedDate);
            this.grpReceive.Controls.Add(this.dtpReceivedDate);
            this.grpReceive.Location = new System.Drawing.Point(301, 49);
            this.grpReceive.Name = "grpReceive";
            this.grpReceive.Size = new System.Drawing.Size(571, 451);
            this.grpReceive.TabIndex = 1;
            this.grpReceive.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.ForeColor = System.Drawing.Color.Brown;
            this.txtCount.Location = new System.Drawing.Point(143, 356);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(59, 20);
            this.txtCount.TabIndex = 59;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Brown;
            this.lblCount.Location = new System.Drawing.Point(10, 359);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(123, 13);
            this.lblCount.TabIndex = 58;
            this.lblCount.Text = "Total No. of Product";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(472, 356);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(82, 20);
            this.txtTotal.TabIndex = 39;
            // 
            // lvlGrandTotal
            // 
            this.lvlGrandTotal.AutoSize = true;
            this.lvlGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlGrandTotal.Location = new System.Drawing.Point(392, 361);
            this.lvlGrandTotal.Name = "lvlGrandTotal";
            this.lvlGrandTotal.Size = new System.Drawing.Size(74, 13);
            this.lvlGrandTotal.TabIndex = 38;
            this.lvlGrandTotal.Text = "Grand Total";
            // 
            // btnWithPurchase
            // 
            this.btnWithPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWithPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithPurchase.Location = new System.Drawing.Point(-224, -32);
            this.btnWithPurchase.Name = "btnWithPurchase";
            this.btnWithPurchase.Size = new System.Drawing.Size(75, 28);
            this.btnWithPurchase.TabIndex = 37;
            this.btnWithPurchase.Text = "Purchase";
            this.btnWithPurchase.UseVisualStyleBackColor = true;
            // 
            // btnWithoutPurchase
            // 
            this.btnWithoutPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWithoutPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithoutPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithoutPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithoutPurchase.Location = new System.Drawing.Point(-143, -32);
            this.btnWithoutPurchase.Name = "btnWithoutPurchase";
            this.btnWithoutPurchase.Size = new System.Drawing.Size(126, 28);
            this.btnWithoutPurchase.TabIndex = 36;
            this.btnWithoutPurchase.Text = "Without Purchase";
            this.btnWithoutPurchase.UseVisualStyleBackColor = true;
            this.btnWithoutPurchase.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(397, 403);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 34);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grdReceiveList
            // 
            this.grdReceiveList.AllowUserToAddRows = false;
            this.grdReceiveList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReceiveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceiveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product,
            this.order_qty,
            this.total_received_qty,
            this.receive_qty,
            this.free_qty,
            this.unit_purchase_price,
            this.unit_cost,
            this.batch_no,
            this.exp_date,
            this.barcode,
            this.is_Saved,
            this.purchase_product_id,
            this.product_type_id,
            this.total_quantity,
            this.product_category_id,
            this.default_sales_price});
            this.grdReceiveList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdReceiveList.Location = new System.Drawing.Point(11, 87);
            this.grdReceiveList.Name = "grdReceiveList";
            this.grdReceiveList.Size = new System.Drawing.Size(543, 256);
            this.grdReceiveList.TabIndex = 4;
            this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "PID";
            this.product_id.Name = "product_id";
            this.product_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product_id.Visible = false;
            // 
            // product
            // 
            this.product.HeaderText = "Description";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product.Width = 163;
            // 
            // order_qty
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.order_qty.DefaultCellStyle = dataGridViewCellStyle10;
            this.order_qty.HeaderText = "Order Qty.";
            this.order_qty.MaxInputLength = 10;
            this.order_qty.Name = "order_qty";
            this.order_qty.ReadOnly = true;
            this.order_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_qty.Width = 40;
            // 
            // total_received_qty
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_received_qty.DefaultCellStyle = dataGridViewCellStyle11;
            this.total_received_qty.HeaderText = "Already Rec.";
            this.total_received_qty.Name = "total_received_qty";
            this.total_received_qty.ReadOnly = true;
            this.total_received_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_received_qty.Width = 50;
            // 
            // receive_qty
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.receive_qty.DefaultCellStyle = dataGridViewCellStyle12;
            this.receive_qty.HeaderText = "Receive Qty.";
            this.receive_qty.MaxInputLength = 10;
            this.receive_qty.Name = "receive_qty";
            this.receive_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receive_qty.Width = 50;
            // 
            // free_qty
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.free_qty.DefaultCellStyle = dataGridViewCellStyle13;
            this.free_qty.HeaderText = "Free Qty.";
            this.free_qty.Name = "free_qty";
            this.free_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.free_qty.Visible = false;
            this.free_qty.Width = 5;
            // 
            // unit_purchase_price
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unit_purchase_price.DefaultCellStyle = dataGridViewCellStyle14;
            this.unit_purchase_price.HeaderText = "Total Purchase Price";
            this.unit_purchase_price.MaxInputLength = 10;
            this.unit_purchase_price.Name = "unit_purchase_price";
            this.unit_purchase_price.ReadOnly = true;
            this.unit_purchase_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unit_purchase_price.Width = 60;
            // 
            // unit_cost
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unit_cost.DefaultCellStyle = dataGridViewCellStyle15;
            this.unit_cost.HeaderText = "Unit Cost";
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unit_cost.Width = 50;
            // 
            // batch_no
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.batch_no.DefaultCellStyle = dataGridViewCellStyle16;
            this.batch_no.HeaderText = "Batch No.";
            this.batch_no.Name = "batch_no";
            this.batch_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.batch_no.Visible = false;
            this.batch_no.Width = 5;
            // 
            // exp_date
            // 
            this.exp_date.HeaderText = "Exp. Date (dd-mm-yyyy)";
            this.exp_date.Name = "exp_date";
            this.exp_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exp_date.Visible = false;
            this.exp_date.Width = 5;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.Visible = false;
            this.barcode.Width = 90;
            // 
            // is_Saved
            // 
            this.is_Saved.HeaderText = "ISVED";
            this.is_Saved.Name = "is_Saved";
            this.is_Saved.Visible = false;
            // 
            // purchase_product_id
            // 
            this.purchase_product_id.HeaderText = "PPID";
            this.purchase_product_id.Name = "purchase_product_id";
            this.purchase_product_id.Visible = false;
            // 
            // product_type_id
            // 
            this.product_type_id.HeaderText = "PTI";
            this.product_type_id.Name = "product_type_id";
            this.product_type_id.Visible = false;
            // 
            // total_quantity
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_quantity.DefaultCellStyle = dataGridViewCellStyle17;
            this.total_quantity.HeaderText = "Total Received Qty";
            this.total_quantity.Name = "total_quantity";
            this.total_quantity.ReadOnly = true;
            this.total_quantity.Width = 80;
            // 
            // product_category_id
            // 
            this.product_category_id.HeaderText = "PCID";
            this.product_category_id.Name = "product_category_id";
            this.product_category_id.Visible = false;
            // 
            // default_sales_price
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.default_sales_price.DefaultCellStyle = dataGridViewCellStyle18;
            this.default_sales_price.HeaderText = "Sales Price";
            this.default_sales_price.MaxInputLength = 10;
            this.default_sales_price.Name = "default_sales_price";
            this.default_sales_price.Visible = false;
            this.default_sales_price.Width = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(28, 403);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 34);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(115, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(486, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "  Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(15, 57);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(73, 13);
            this.lblInvoiceNo.TabIndex = 16;
            this.lblInvoiceNo.Text = "Invoice No:";
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(105, 54);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(178, 20);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.Tag = "invoice_no";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceDate.Location = new System.Drawing.Point(15, 23);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(84, 13);
            this.lblInvoiceDate.TabIndex = 17;
            this.lblInvoiceDate.Text = "Invoice Date:";
            this.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(105, 17);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(122, 20);
            this.dtpInvoiceDate.TabIndex = 3;
            this.dtpInvoiceDate.Tag = "invoice_date";
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedDate.Location = new System.Drawing.Point(233, 23);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(96, 13);
            this.lblReceivedDate.TabIndex = 18;
            this.lblReceivedDate.Text = "Received Date:";
            this.lblReceivedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpReceivedDate.Enabled = false;
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceivedDate.Location = new System.Drawing.Point(335, 17);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(122, 20);
            this.dtpReceivedDate.TabIndex = 1;
            this.dtpReceivedDate.Tag = "received_date";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(890, 33);
            this.label7.TabIndex = 108;
            this.label7.Text = "Purchase Received";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwPurchaseOrder
            // 
            this.lvwPurchaseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPurchaseOrder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvwPurchaseOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchase_id,
            this.purchase,
            this.date,
            this.User});
            this.lvwPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPurchaseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPurchaseOrder.FullRowSelect = true;
            this.lvwPurchaseOrder.GridLines = true;
            this.lvwPurchaseOrder.HideSelection = false;
            this.lvwPurchaseOrder.Location = new System.Drawing.Point(15, 58);
            this.lvwPurchaseOrder.Name = "lvwPurchaseOrder";
            this.lvwPurchaseOrder.Size = new System.Drawing.Size(274, 432);
            this.lvwPurchaseOrder.TabIndex = 109;
            this.lvwPurchaseOrder.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrder.View = System.Windows.Forms.View.Details;
            this.lvwPurchaseOrder.Click += new System.EventHandler(this.lvwPurchaseOrder_Click);
            // 
            // purchase_id
            // 
            this.purchase_id.Text = "order_id";
            this.purchase_id.Width = 0;
            // 
            // purchase
            // 
            this.purchase.Text = "Order No";
            this.purchase.Width = 150;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 100;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 0;
            // 
            // FrmReceiveAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.lvwPurchaseOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpReceive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReceiveAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive";
            this.Load += new System.EventHandler(this.FrmReceiveAddEditView_Load);
            this.grpReceive.ResumeLayout(false);
            this.grpReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceiveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReceive;
        private System.Windows.Forms.DataGridView grdReceiveList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnWithPurchase;
        private System.Windows.Forms.Button btnWithoutPurchase;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lvlGrandTotal;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvwPurchaseOrder;
        private System.Windows.Forms.ColumnHeader purchase_id;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_received_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn receive_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn free_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_purchase_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_Saved;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn default_sales_price;
    }
}