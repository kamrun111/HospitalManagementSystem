namespace NewHIMS.Forms.Otshedule
{
    partial class FrmOtMedicineReceive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.OrderID = new System.Windows.Forms.ColumnHeader();
            this.Indendby = new System.Windows.Forms.ColumnHeader();
            this.indentdate = new System.Windows.Forms.ColumnHeader();
            this.deliveredby = new System.Windows.Forms.ColumnHeader();
            this.deliverydate = new System.Windows.Forms.ColumnHeader();
            this.patientname = new System.Windows.Forms.ColumnHeader();
            this.patientCode = new System.Windows.Forms.ColumnHeader();
            this.AdmissionCode = new System.Windows.Forms.ColumnHeader();
            this.grdMedicineIndent = new System.Windows.Forms.DataGridView();
            this.admission_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_ordered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivered_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIndent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.txtDeliveredBy = new System.Windows.Forms.TextBox();
            this.lblDeliveredBy = new System.Windows.Forms.Label();
            this.txtadmissioncode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineIndent)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.Indendby,
            this.indentdate,
            this.deliveredby,
            this.deliverydate,
            this.patientname,
            this.patientCode,
            this.AdmissionCode});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(12, 44);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(341, 408);
            this.lvwPatientInfo.TabIndex = 132;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.Width = 0;
            // 
            // Indendby
            // 
            this.Indendby.Text = "Indent  BY";
            this.Indendby.Width = 100;
            // 
            // indentdate
            // 
            this.indentdate.DisplayIndex = 4;
            this.indentdate.Text = "Indent Date";
            this.indentdate.Width = 150;
            // 
            // deliveredby
            // 
            this.deliveredby.DisplayIndex = 2;
            this.deliveredby.Text = "deliveredby";
            this.deliveredby.Width = 0;
            // 
            // deliverydate
            // 
            this.deliverydate.DisplayIndex = 3;
            this.deliverydate.Text = "Delivery Date";
            this.deliverydate.Width = 0;
            // 
            // patientname
            // 
            this.patientname.Text = "Patient Name";
            this.patientname.Width = 0;
            // 
            // patientCode
            // 
            this.patientCode.Text = "Hospital ID";
            this.patientCode.Width = 85;
            // 
            // AdmissionCode
            // 
            this.AdmissionCode.Text = "Admission Reg ID";
            this.AdmissionCode.Width = 0;
            // 
            // grdMedicineIndent
            // 
            this.grdMedicineIndent.AllowUserToAddRows = false;
            this.grdMedicineIndent.AllowUserToDeleteRows = false;
            this.grdMedicineIndent.AllowUserToOrderColumns = true;
            this.grdMedicineIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMedicineIndent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicineIndent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admission_id,
            this.cabin_id,
            this.product_id,
            this.medicine,
            this.quantity_ordered,
            this.quantity_delivered,
            this.quantity_received,
            this.PMIID,
            this.delivered_by,
            this.Stock});
            this.grdMedicineIndent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMedicineIndent.Location = new System.Drawing.Point(359, 44);
            this.grdMedicineIndent.Name = "grdMedicineIndent";
            this.grdMedicineIndent.RowHeadersVisible = false;
            this.grdMedicineIndent.Size = new System.Drawing.Size(443, 408);
            this.grdMedicineIndent.TabIndex = 133;
            // 
            // admission_id
            // 
            this.admission_id.HeaderText = "AID";
            this.admission_id.Name = "admission_id";
            this.admission_id.Visible = false;
            // 
            // cabin_id
            // 
            this.cabin_id.HeaderText = "CID";
            this.cabin_id.Name = "cabin_id";
            this.cabin_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "PRID";
            this.product_id.Name = "product_id";
            this.product_id.Visible = false;
            // 
            // medicine
            // 
            this.medicine.HeaderText = "Medicine";
            this.medicine.Name = "medicine";
            this.medicine.ReadOnly = true;
            this.medicine.Width = 210;
            // 
            // quantity_ordered
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.quantity_ordered.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantity_ordered.HeaderText = "Order Qty.";
            this.quantity_ordered.MaxInputLength = 5;
            this.quantity_ordered.Name = "quantity_ordered";
            this.quantity_ordered.Width = 50;
            // 
            // quantity_delivered
            // 
            this.quantity_delivered.HeaderText = "Delivery Qty.";
            this.quantity_delivered.MaxInputLength = 5;
            this.quantity_delivered.Name = "quantity_delivered";
            this.quantity_delivered.ReadOnly = true;
            this.quantity_delivered.Width = 50;
            // 
            // quantity_received
            // 
            this.quantity_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity_received.HeaderText = "Received Qty.";
            this.quantity_received.MaxInputLength = 5;
            this.quantity_received.Name = "quantity_received";
            this.quantity_received.ReadOnly = true;
            // 
            // PMIID
            // 
            this.PMIID.HeaderText = "PMIID";
            this.PMIID.Name = "PMIID";
            this.PMIID.Visible = false;
            // 
            // delivered_by
            // 
            this.delivered_by.HeaderText = "DeliveredBy";
            this.delivered_by.Name = "delivered_by";
            this.delivered_by.Visible = false;
            this.delivered_by.Width = 5;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 5;
            // 
            // btnIndent
            // 
            this.btnIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIndent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndent.Enabled = false;
            this.btnIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndent.Image = global::NewHIMS.Properties.Resources.Save;
            this.btnIndent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndent.Location = new System.Drawing.Point(615, 464);
            this.btnIndent.Name = "btnIndent";
            this.btnIndent.Size = new System.Drawing.Size(62, 52);
            this.btnIndent.TabIndex = 139;
            this.btnIndent.Text = "Receive";
            this.btnIndent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIndent.UseVisualStyleBackColor = true;
            this.btnIndent.Click += new System.EventHandler(this.btnIndent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(683, 464);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 140;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(748, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 52);
            this.btnClose.TabIndex = 141;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(115, 493);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(186, 20);
            this.txtDeliveryDate.TabIndex = 145;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(21, 493);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(92, 13);
            this.lblDeliveryDate.TabIndex = 144;
            this.lblDeliveryDate.Text = "Delivered Date";
            // 
            // txtDeliveredBy
            // 
            this.txtDeliveredBy.Location = new System.Drawing.Point(115, 460);
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.ReadOnly = true;
            this.txtDeliveredBy.Size = new System.Drawing.Size(186, 20);
            this.txtDeliveredBy.TabIndex = 143;
            // 
            // lblDeliveredBy
            // 
            this.lblDeliveredBy.AutoSize = true;
            this.lblDeliveredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveredBy.Location = new System.Drawing.Point(32, 464);
            this.lblDeliveredBy.Name = "lblDeliveredBy";
            this.lblDeliveredBy.Size = new System.Drawing.Size(79, 13);
            this.lblDeliveredBy.TabIndex = 142;
            this.lblDeliveredBy.Text = "Delivered By";
            // 
            // txtadmissioncode
            // 
            this.txtadmissioncode.Location = new System.Drawing.Point(479, 13);
            this.txtadmissioncode.Name = "txtadmissioncode";
            this.txtadmissioncode.ReadOnly = true;
            this.txtadmissioncode.Size = new System.Drawing.Size(130, 20);
            this.txtadmissioncode.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 148;
            this.label1.Text = "Admission Reg ID";
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(73, 12);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.ReadOnly = true;
            this.txtpatientname.Size = new System.Drawing.Size(277, 20);
            this.txtpatientname.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "P. Name";
            // 
            // FrmOtMedicineReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 522);
            this.Controls.Add(this.txtadmissioncode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.txtDeliveredBy);
            this.Controls.Add(this.lblDeliveredBy);
            this.Controls.Add(this.btnIndent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdMedicineIndent);
            this.Controls.Add(this.lvwPatientInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOtMedicineReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OT Medicine Receive";
            this.Load += new System.EventHandler(this.FrmOtMedicineReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineIndent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader Indendby;
        private System.Windows.Forms.ColumnHeader indentdate;
        private System.Windows.Forms.ColumnHeader deliveredby;
        private System.Windows.Forms.ColumnHeader deliverydate;
        public System.Windows.Forms.DataGridView grdMedicineIndent;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_ordered;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivered_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button btnIndent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader patientname;
        private System.Windows.Forms.ColumnHeader patientCode;
        private System.Windows.Forms.ColumnHeader AdmissionCode;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.TextBox txtDeliveredBy;
        private System.Windows.Forms.Label lblDeliveredBy;
        private System.Windows.Forms.TextBox txtadmissioncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.Label label2;
    }
}