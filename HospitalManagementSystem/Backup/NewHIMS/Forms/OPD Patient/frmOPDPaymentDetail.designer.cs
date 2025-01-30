namespace NewHIMS.Forms.OPD_Patient
{
    partial class frmOPDPaymentDetail
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
            this.grpPaymentDetail = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.RegID = new System.Windows.Forms.ColumnHeader();
            this.PatientName = new System.Windows.Forms.ColumnHeader();
            this.InvoiceNo = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.lblRegID = new System.Windows.Forms.Label();
            this.lblPaymentDetailTitle = new System.Windows.Forms.Label();
            this.grpPaymentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaymentDetail
            // 
            this.grpPaymentDetail.Controls.Add(this.btnClose);
            this.grpPaymentDetail.Controls.Add(this.btnRefresh);
            this.grpPaymentDetail.Controls.Add(this.btnPrint);
            this.grpPaymentDetail.Controls.Add(this.lvwPatientInfo);
            this.grpPaymentDetail.Controls.Add(this.txtRegID);
            this.grpPaymentDetail.Controls.Add(this.lblRegID);
            this.grpPaymentDetail.Controls.Add(this.lblPaymentDetailTitle);
            this.grpPaymentDetail.Location = new System.Drawing.Point(6, 12);
            this.grpPaymentDetail.Name = "grpPaymentDetail";
            this.grpPaymentDetail.Size = new System.Drawing.Size(380, 355);
            this.grpPaymentDetail.TabIndex = 1;
            this.grpPaymentDetail.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(233, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(71, 313);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(152, 313);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RegID,
            this.PatientName,
            this.InvoiceNo,
            this.Date});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(10, 106);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(364, 188);
            this.lvwPatientInfo.TabIndex = 8;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            // 
            // RegID
            // 
            this.RegID.Text = "Reg ID";
            // 
            // PatientName
            // 
            this.PatientName.Text = "Patient Name";
            this.PatientName.Width = 112;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Text = "InvoiceNo";
            this.InvoiceNo.Width = 112;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 74;
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(79, 80);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(100, 20);
            this.txtRegID.TabIndex = 7;
            // 
            // lblRegID
            // 
            this.lblRegID.AutoSize = true;
            this.lblRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegID.Location = new System.Drawing.Point(7, 83);
            this.lblRegID.Name = "lblRegID";
            this.lblRegID.Size = new System.Drawing.Size(51, 13);
            this.lblRegID.TabIndex = 6;
            this.lblRegID.Text = "Reg ID:";
            // 
            // lblPaymentDetailTitle
            // 
            this.lblPaymentDetailTitle.AutoSize = true;
            this.lblPaymentDetailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDetailTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPaymentDetailTitle.Location = new System.Drawing.Point(117, 16);
            this.lblPaymentDetailTitle.Name = "lblPaymentDetailTitle";
            this.lblPaymentDetailTitle.Size = new System.Drawing.Size(148, 24);
            this.lblPaymentDetailTitle.TabIndex = 1;
            this.lblPaymentDetailTitle.Text = "Payment Detail";
            // 
            // frmOPDPaymentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 390);
            this.Controls.Add(this.grpPaymentDetail);
            this.Name = "frmOPDPaymentDetail";
            this.Text = "frmOPDPaymentDetail";
            this.Load += new System.EventHandler(this.frmOPDPaymentDetail_Load);
            this.grpPaymentDetail.ResumeLayout(false);
            this.grpPaymentDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaymentDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Label lblRegID;
        private System.Windows.Forms.Label lblPaymentDetailTitle;
        private System.Windows.Forms.ColumnHeader RegID;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader InvoiceNo;
        private System.Windows.Forms.ColumnHeader Date;
    }
}