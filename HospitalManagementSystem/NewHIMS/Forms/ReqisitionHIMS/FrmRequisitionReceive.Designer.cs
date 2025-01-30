namespace NewHIMS.Forms.ReqisitionHIMS
{
    partial class FrmRequisitionReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisitionReceive));
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.lvwRequisitionDeliveryinfo = new System.Windows.Forms.ListView();
            this.requisition_no = new System.Windows.Forms.ColumnHeader();
            this.department = new System.Windows.Forms.ColumnHeader();
            this.requisition_id = new System.Windows.Forms.ColumnHeader();
            this.user = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.cmbRequisitionNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdeliveryby = new System.Windows.Forms.TextBox();
            this.grdRequisitionReceive = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receive_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisition_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRequisitionNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpRequisition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisitionReceive)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRequisition
            // 
            this.grpRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRequisition.Controls.Add(this.lvwRequisitionDeliveryinfo);
            this.grpRequisition.Controls.Add(this.cmbRequisitionNo);
            this.grpRequisition.Controls.Add(this.label1);
            this.grpRequisition.Controls.Add(this.txtdeliveryby);
            this.grpRequisition.Controls.Add(this.grdRequisitionReceive);
            this.grpRequisition.Controls.Add(this.lblRequisitionNo);
            this.grpRequisition.Controls.Add(this.groupBox1);
            this.grpRequisition.Controls.Add(this.groupBox2);
            this.grpRequisition.Controls.Add(this.groupBox3);
            this.grpRequisition.Location = new System.Drawing.Point(15, 46);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Size = new System.Drawing.Size(703, 437);
            this.grpRequisition.TabIndex = 1;
            this.grpRequisition.TabStop = false;
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
            this.lvwRequisitionDeliveryinfo.GridLines = true;
            this.lvwRequisitionDeliveryinfo.HideSelection = false;
            this.lvwRequisitionDeliveryinfo.Location = new System.Drawing.Point(14, 16);
            this.lvwRequisitionDeliveryinfo.Name = "lvwRequisitionDeliveryinfo";
            this.lvwRequisitionDeliveryinfo.Size = new System.Drawing.Size(270, 413);
            this.lvwRequisitionDeliveryinfo.TabIndex = 116;
            this.lvwRequisitionDeliveryinfo.UseCompatibleStateImageBehavior = false;
            this.lvwRequisitionDeliveryinfo.View = System.Windows.Forms.View.Details;
            // 
            // requisition_no
            // 
            this.requisition_no.Text = "Requisition No";
            this.requisition_no.Width = 127;
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
            this.Date.Width = 120;
            // 
            // cmbRequisitionNo
            // 
            this.cmbRequisitionNo.FormattingEnabled = true;
            this.cmbRequisitionNo.Location = new System.Drawing.Point(436, 27);
            this.cmbRequisitionNo.Name = "cmbRequisitionNo";
            this.cmbRequisitionNo.Size = new System.Drawing.Size(178, 21);
            this.cmbRequisitionNo.TabIndex = 53;
            this.cmbRequisitionNo.SelectedIndexChanged += new System.EventHandler(this.cmbRequisitionNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Delivered  By :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdeliveryby
            // 
            this.txtdeliveryby.Location = new System.Drawing.Point(436, 62);
            this.txtdeliveryby.Name = "txtdeliveryby";
            this.txtdeliveryby.ReadOnly = true;
            this.txtdeliveryby.Size = new System.Drawing.Size(178, 20);
            this.txtdeliveryby.TabIndex = 51;
            // 
            // grdRequisitionReceive
            // 
            this.grdRequisitionReceive.AllowUserToAddRows = false;
            this.grdRequisitionReceive.AllowUserToDeleteRows = false;
            this.grdRequisitionReceive.AllowUserToOrderColumns = true;
            this.grdRequisitionReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRequisitionReceive.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdRequisitionReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequisitionReceive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.order_qty,
            this.receive_qty,
            this.requisition_product_id});
            this.grdRequisitionReceive.Location = new System.Drawing.Point(296, 109);
            this.grdRequisitionReceive.Name = "grdRequisitionReceive";
            this.grdRequisitionReceive.Size = new System.Drawing.Size(389, 247);
            this.grdRequisitionReceive.TabIndex = 3;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.product.Width = 200;
            // 
            // order_qty
            // 
            this.order_qty.HeaderText = "Order Qty.";
            this.order_qty.Name = "order_qty";
            this.order_qty.ReadOnly = true;
            this.order_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.order_qty.Width = 60;
            // 
            // receive_qty
            // 
            this.receive_qty.HeaderText = "Receive Qty.";
            this.receive_qty.Name = "receive_qty";
            this.receive_qty.ReadOnly = true;
            this.receive_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receive_qty.Width = 60;
            // 
            // requisition_product_id
            // 
            this.requisition_product_id.HeaderText = "RPID";
            this.requisition_product_id.Name = "requisition_product_id";
            this.requisition_product_id.ReadOnly = true;
            this.requisition_product_id.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(22, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 36);
            this.btnRefresh.TabIndex = 5;
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
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(160, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(287, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRequisitionNo
            // 
            this.lblRequisitionNo.AutoSize = true;
            this.lblRequisitionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionNo.Location = new System.Drawing.Point(332, 30);
            this.lblRequisitionNo.Name = "lblRequisitionNo";
            this.lblRequisitionNo.Size = new System.Drawing.Size(98, 13);
            this.lblRequisitionNo.TabIndex = 10;
            this.lblRequisitionNo.Text = "Requisition No :";
            this.lblRequisitionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(290, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 87);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(290, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 271);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(763, 33);
            this.label7.TabIndex = 108;
            this.label7.Text = "Requsition Received";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Location = new System.Drawing.Point(290, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 65);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            // 
            // FrmRequisitionReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(727, 493);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpRequisition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRequisitionReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisition Receive";
            this.Load += new System.EventHandler(this.FrmRequisitionReceive_Load);
            this.grpRequisition.ResumeLayout(false);
            this.grpRequisition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequisitionReceive)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequisition;
        private System.Windows.Forms.DataGridView grdRequisitionReceive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRequisitionNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeliveryby;
        private System.Windows.Forms.ComboBox cmbRequisitionNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn receive_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisition_product_id;
        private System.Windows.Forms.ListView lvwRequisitionDeliveryinfo;
        private System.Windows.Forms.ColumnHeader requisition_no;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader requisition_id;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}