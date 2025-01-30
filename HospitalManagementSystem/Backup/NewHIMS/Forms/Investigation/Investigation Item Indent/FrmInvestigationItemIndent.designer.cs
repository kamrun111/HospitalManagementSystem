namespace NewHIMS.Forms.Investigation
{
    partial class FrmInvestigationItemIndent
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
            this.lblInvestigationItemIndentTitle = new System.Windows.Forms.Label();
            this.lblInvestigationItem = new System.Windows.Forms.Label();
            this.cmbInvestigationItem = new System.Windows.Forms.ComboBox();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.lblReceiveQty = new System.Windows.Forms.Label();
            this.txtReceiveQty = new System.Windows.Forms.TextBox();
            this.lblDeliveryQty = new System.Windows.Forms.Label();
            this.txtDeliveryQty = new System.Windows.Forms.TextBox();
            this.lblRefundQty = new System.Windows.Forms.Label();
            this.txtRefundQty = new System.Windows.Forms.TextBox();
            this.lblOrderQty = new System.Windows.Forms.Label();
            this.lvwInvestigationItemIndent = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInvestigationItemIndentTitle
            // 
            this.lblInvestigationItemIndentTitle.AutoSize = true;
            this.lblInvestigationItemIndentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationItemIndentTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInvestigationItemIndentTitle.Location = new System.Drawing.Point(186, 14);
            this.lblInvestigationItemIndentTitle.Name = "lblInvestigationItemIndentTitle";
            this.lblInvestigationItemIndentTitle.Size = new System.Drawing.Size(96, 31);
            this.lblInvestigationItemIndentTitle.TabIndex = 55;
            this.lblInvestigationItemIndentTitle.Text = "Indent";
            // 
            // lblInvestigationItem
            // 
            this.lblInvestigationItem.AutoSize = true;
            this.lblInvestigationItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationItem.Location = new System.Drawing.Point(29, 67);
            this.lblInvestigationItem.Name = "lblInvestigationItem";
            this.lblInvestigationItem.Size = new System.Drawing.Size(112, 13);
            this.lblInvestigationItem.TabIndex = 49;
            this.lblInvestigationItem.Text = "Investigation Item:";
            this.lblInvestigationItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbInvestigationItem
            // 
            this.cmbInvestigationItem.FormattingEnabled = true;
            this.cmbInvestigationItem.Location = new System.Drawing.Point(143, 64);
            this.cmbInvestigationItem.Name = "cmbInvestigationItem";
            this.cmbInvestigationItem.Size = new System.Drawing.Size(227, 21);
            this.cmbInvestigationItem.TabIndex = 44;
            this.cmbInvestigationItem.Tag = "investigation_item_id";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(143, 91);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(70, 20);
            this.txtOrderQty.TabIndex = 45;
            this.txtOrderQty.Tag = "order_qty";
            this.txtOrderQty.Text = "0";
            this.txtOrderQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderQty_KeyPress);
            // 
            // lblReceiveQty
            // 
            this.lblReceiveQty.AutoSize = true;
            this.lblReceiveQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveQty.Location = new System.Drawing.Point(219, 94);
            this.lblReceiveQty.Name = "lblReceiveQty";
            this.lblReceiveQty.Size = new System.Drawing.Size(81, 13);
            this.lblReceiveQty.TabIndex = 50;
            this.lblReceiveQty.Text = "Receive Qty:";
            this.lblReceiveQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReceiveQty
            // 
            this.txtReceiveQty.Location = new System.Drawing.Point(300, 91);
            this.txtReceiveQty.Name = "txtReceiveQty";
            this.txtReceiveQty.Size = new System.Drawing.Size(70, 20);
            this.txtReceiveQty.TabIndex = 46;
            this.txtReceiveQty.Tag = "receive_qty";
            this.txtReceiveQty.Text = "0";
            this.txtReceiveQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderQty_KeyPress);
            // 
            // lblDeliveryQty
            // 
            this.lblDeliveryQty.AutoSize = true;
            this.lblDeliveryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryQty.Location = new System.Drawing.Point(29, 119);
            this.lblDeliveryQty.Name = "lblDeliveryQty";
            this.lblDeliveryQty.Size = new System.Drawing.Size(80, 13);
            this.lblDeliveryQty.TabIndex = 51;
            this.lblDeliveryQty.Text = "Delivery Qty:";
            this.lblDeliveryQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDeliveryQty
            // 
            this.txtDeliveryQty.Location = new System.Drawing.Point(143, 116);
            this.txtDeliveryQty.Name = "txtDeliveryQty";
            this.txtDeliveryQty.Size = new System.Drawing.Size(70, 20);
            this.txtDeliveryQty.TabIndex = 47;
            this.txtDeliveryQty.Tag = "delivery_qty";
            this.txtDeliveryQty.Text = "0";
            this.txtDeliveryQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderQty_KeyPress);
            // 
            // lblRefundQty
            // 
            this.lblRefundQty.AutoSize = true;
            this.lblRefundQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundQty.Location = new System.Drawing.Point(219, 119);
            this.lblRefundQty.Name = "lblRefundQty";
            this.lblRefundQty.Size = new System.Drawing.Size(75, 13);
            this.lblRefundQty.TabIndex = 52;
            this.lblRefundQty.Text = "Refund Qty:";
            this.lblRefundQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRefundQty
            // 
            this.txtRefundQty.Location = new System.Drawing.Point(300, 116);
            this.txtRefundQty.Name = "txtRefundQty";
            this.txtRefundQty.Size = new System.Drawing.Size(70, 20);
            this.txtRefundQty.TabIndex = 48;
            this.txtRefundQty.Tag = "refund_qty";
            this.txtRefundQty.Text = "0";
            this.txtRefundQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderQty_KeyPress);
            // 
            // lblOrderQty
            // 
            this.lblOrderQty.AutoSize = true;
            this.lblOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderQty.Location = new System.Drawing.Point(29, 94);
            this.lblOrderQty.Name = "lblOrderQty";
            this.lblOrderQty.Size = new System.Drawing.Size(65, 13);
            this.lblOrderQty.TabIndex = 60;
            this.lblOrderQty.Text = "Order Qty:";
            this.lblOrderQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwInvestigationItemIndent
            // 
            this.lvwInvestigationItemIndent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwInvestigationItemIndent.GridLines = true;
            this.lvwInvestigationItemIndent.Location = new System.Drawing.Point(32, 154);
            this.lvwInvestigationItemIndent.Name = "lvwInvestigationItemIndent";
            this.lvwInvestigationItemIndent.Size = new System.Drawing.Size(500, 177);
            this.lvwInvestigationItemIndent.TabIndex = 61;
            this.lvwInvestigationItemIndent.UseCompatibleStateImageBehavior = false;
            this.lvwInvestigationItemIndent.View = System.Windows.Forms.View.Details;
            this.lvwInvestigationItemIndent.SelectedIndexChanged += new System.EventHandler(this.lvwInvestigationItemIndent_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Investigation Item";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Qty";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Receive Qty";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Delivery Qty";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Refund Qty";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Indent Date";
            this.columnHeader6.Width = 190;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(302, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(383, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 64;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(468, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 28);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmInvestigationItemIndent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 385);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvwInvestigationItemIndent);
            this.Controls.Add(this.lblOrderQty);
            this.Controls.Add(this.lblInvestigationItemIndentTitle);
            this.Controls.Add(this.lblInvestigationItem);
            this.Controls.Add(this.cmbInvestigationItem);
            this.Controls.Add(this.txtOrderQty);
            this.Controls.Add(this.lblReceiveQty);
            this.Controls.Add(this.txtReceiveQty);
            this.Controls.Add(this.lblDeliveryQty);
            this.Controls.Add(this.txtDeliveryQty);
            this.Controls.Add(this.lblRefundQty);
            this.Controls.Add(this.txtRefundQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInvestigationItemIndent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Item";
            this.Load += new System.EventHandler(this.FrmInvetigationItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestigationItemIndentTitle;
        private System.Windows.Forms.Label lblInvestigationItem;
        private System.Windows.Forms.ComboBox cmbInvestigationItem;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label lblReceiveQty;
        private System.Windows.Forms.TextBox txtReceiveQty;
        private System.Windows.Forms.Label lblDeliveryQty;
        private System.Windows.Forms.TextBox txtDeliveryQty;
        private System.Windows.Forms.Label lblRefundQty;
        private System.Windows.Forms.TextBox txtRefundQty;
        private System.Windows.Forms.Label lblOrderQty;
        private System.Windows.Forms.ListView lvwInvestigationItemIndent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}