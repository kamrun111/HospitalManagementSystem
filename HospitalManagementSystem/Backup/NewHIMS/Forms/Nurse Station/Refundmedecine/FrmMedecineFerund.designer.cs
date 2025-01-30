namespace NewHIMS.Forms.Nurse_Station.Refundmedecine
{
    partial class FrmMedecineFerund
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
         //</summary>
         //<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.Patient_code = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.c_id = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.grdSalesRefund = new System.Windows.Forms.DataGridView();
            this.admissionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousrefund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkEdit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesRefund)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFloor
            // 
            this.cmbFloor.BackColor = System.Drawing.Color.Linen;
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(71, 10);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(143, 21);
            this.cmbFloor.Sorted = true;
            this.cmbFloor.TabIndex = 1;
            this.cmbFloor.Tag = "floor";
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.Patient_code,
            this.admission_id,
            this.c_id});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(33, 37);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(181, 396);
            this.lvwPatientInfo.TabIndex = 2;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // cabin
            // 
            this.cabin.Text = "Cabin";
            this.cabin.Width = 55;
            // 
            // Patient_code
            // 
            this.Patient_code.Text = "Hospital ID";
            this.Patient_code.Width = 100;
            // 
            // admission_id
            // 
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // c_id
            // 
            this.c_id.Text = "c_id";
            this.c_id.Width = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Floor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdSalesRefund
            // 
            this.grdSalesRefund.AllowUserToAddRows = false;
            this.grdSalesRefund.AllowUserToDeleteRows = false;
            this.grdSalesRefund.AllowUserToOrderColumns = true;
            this.grdSalesRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalesRefund.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdSalesRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalesRefund.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admissionID,
            this.product,
            this.product_id,
            this.sales_qty,
            this.previousrefund,
            this.refund_qty});
            this.grdSalesRefund.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdSalesRefund.Location = new System.Drawing.Point(236, 37);
            this.grdSalesRefund.Name = "grdSalesRefund";
            this.grdSalesRefund.RowHeadersVisible = false;
            this.grdSalesRefund.Size = new System.Drawing.Size(445, 396);
            this.grdSalesRefund.TabIndex = 52;
            this.grdSalesRefund.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSalesRefund_CellValueChanged);
            // 
            // admissionID
            // 
            this.admissionID.HeaderText = "admissionID";
            this.admissionID.Name = "admissionID";
            this.admissionID.ReadOnly = true;
            this.admissionID.Visible = false;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 200;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "PID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product_id.Visible = false;
            this.product_id.Width = 120;
            // 
            // sales_qty
            // 
            this.sales_qty.HeaderText = "Sales Qty";
            this.sales_qty.Name = "sales_qty";
            this.sales_qty.ReadOnly = true;
            this.sales_qty.Width = 90;
            // 
            // previousrefund
            // 
            this.previousrefund.HeaderText = "Already Refund";
            this.previousrefund.Name = "previousrefund";
            this.previousrefund.ReadOnly = true;
            this.previousrefund.Width = 60;
            // 
            // refund_qty
            // 
            this.refund_qty.HeaderText = "Refund Qty.";
            this.refund_qty.Name = "refund_qty";
            this.refund_qty.Width = 80;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(534, 440);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 27);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(457, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 27);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(611, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 27);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkEdit
            // 
            this.lnkEdit.AutoSize = true;
            this.lnkEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEdit.Location = new System.Drawing.Point(232, 440);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(83, 24);
            this.lnkEdit.TabIndex = 56;
            this.lnkEdit.TabStop = true;
            this.lnkEdit.Text = "preview";
            this.lnkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEdit_LinkClicked);
            // 
            // FrmMedecineFerund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 479);
            this.Controls.Add(this.lnkEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdSalesRefund);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwPatientInfo);
            this.Controls.Add(this.cmbFloor);
            this.Name = "FrmMedecineFerund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecine Ferund";
            this.Load += new System.EventHandler(this.FrmMedecineFerund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesRefund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFloor;
        public System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader Patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader c_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdSalesRefund;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousrefund;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund_qty;
        private System.Windows.Forms.LinkLabel lnkEdit;
    }
}