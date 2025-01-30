namespace NewHIMS.Forms.Medicine
{
    partial class FrmMedicinePaymentDetails
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
            this.label15 = new System.Windows.Forms.Label();
            this.grpPaymentDetail = new System.Windows.Forms.GroupBox();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.pay_date = new System.Windows.Forms.ColumnHeader();
            this.pay_id = new System.Windows.Forms.ColumnHeader();
            this.invoice_no = new System.Windows.Forms.ColumnHeader();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.lblHospitalID = new System.Windows.Forms.Label();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoMoneyReceipt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpPaymentDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(395, 30);
            this.label15.TabIndex = 68;
            this.label15.Text = "PATIENT\'S PAYMENT RE-PRINT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPaymentDetail
            // 
            this.grpPaymentDetail.Controls.Add(this.lvwPatientInfo);
            this.grpPaymentDetail.Controls.Add(this.txtHospitalID);
            this.grpPaymentDetail.Controls.Add(this.lblHospitalID);
            this.grpPaymentDetail.Controls.Add(this.rdoDetails);
            this.grpPaymentDetail.Controls.Add(this.rdoMoneyReceipt);
            this.grpPaymentDetail.Location = new System.Drawing.Point(9, 45);
            this.grpPaymentDetail.Name = "grpPaymentDetail";
            this.grpPaymentDetail.Size = new System.Drawing.Size(374, 223);
            this.grpPaymentDetail.TabIndex = 69;
            this.grpPaymentDetail.TabStop = false;
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Silver;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.patient_code,
            this.admission_id,
            this.pay_date,
            this.pay_id,
            this.invoice_no});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(11, 49);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(352, 165);
            this.lvwPatientInfo.TabIndex = 9;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 100;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 0;
            // 
            // admission_id
            // 
            this.admission_id.Name = "admission_id";
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // pay_date
            // 
            this.pay_date.Text = "Payment Date";
            this.pay_date.Width = 107;
            // 
            // pay_id
            // 
            this.pay_id.Text = "pay_id";
            this.pay_id.Width = 0;
            // 
            // invoice_no
            // 
            this.invoice_no.Text = "Receipt No";
            this.invoice_no.Width = 101;
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Location = new System.Drawing.Point(79, 18);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(100, 20);
            this.txtHospitalID.TabIndex = 7;
            this.txtHospitalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHospitalID_KeyPress);
            // 
            // lblHospitalID
            // 
            this.lblHospitalID.AutoSize = true;
            this.lblHospitalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalID.Location = new System.Drawing.Point(7, 21);
            this.lblHospitalID.Name = "lblHospitalID";
            this.lblHospitalID.Size = new System.Drawing.Size(66, 13);
            this.lblHospitalID.TabIndex = 6;
            this.lblHospitalID.Text = "HospitalID";
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDetails.Location = new System.Drawing.Point(299, 19);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(64, 17);
            this.rdoDetails.TabIndex = 5;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "Details";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.Visible = false;
            // 
            // rdoMoneyReceipt
            // 
            this.rdoMoneyReceipt.AutoSize = true;
            this.rdoMoneyReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMoneyReceipt.Location = new System.Drawing.Point(223, 19);
            this.rdoMoneyReceipt.Name = "rdoMoneyReceipt";
            this.rdoMoneyReceipt.Size = new System.Drawing.Size(69, 17);
            this.rdoMoneyReceipt.TabIndex = 4;
            this.rdoMoneyReceipt.TabStop = true;
            this.rdoMoneyReceipt.Text = "Receipt";
            this.rdoMoneyReceipt.UseVisualStyleBackColor = true;
            this.rdoMoneyReceipt.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(9, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 57);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(264, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(168, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 32);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(68, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 32);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmMedicinePaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(393, 331);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPaymentDetail);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedicinePaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Payment Details";
            this.Load += new System.EventHandler(this.FrmMedicinePaymentDetails_Load);
            this.grpPaymentDetail.ResumeLayout(false);
            this.grpPaymentDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpPaymentDetail;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.Label lblHospitalID;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoMoneyReceipt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader pay_date;
        private System.Windows.Forms.ColumnHeader pay_id;
        private System.Windows.Forms.ColumnHeader invoice_no;
    }
}