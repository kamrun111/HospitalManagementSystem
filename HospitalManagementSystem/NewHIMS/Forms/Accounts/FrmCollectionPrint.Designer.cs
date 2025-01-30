namespace NewHIMS.Forms.Accounts
{
    partial class FrmCollectionPrint
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
            this.label9 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnpatient = new System.Windows.Forms.Button();
            this.btnbalance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBloodBank = new System.Windows.Forms.CheckBox();
            this.chkDoctorPaymentBalance = new System.Windows.Forms.CheckBox();
            this.chkDoctorPaymentReport = new System.Windows.Forms.CheckBox();
            this.chkdoctorbillreport = new System.Windows.Forms.CheckBox();
            this.chksummaryreport = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndiscount = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 143;
            this.label9.Text = "Accounts Report";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(265, 20);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(104, 24);
            this.dtpToDate.TabIndex = 147;
            this.dtpToDate.Tag = "To_date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(90, 20);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(104, 24);
            this.dtpFromDate.TabIndex = 146;
            this.dtpFromDate.Tag = "from_date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(214, 21);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(35, 24);
            this.lblToDate.TabIndex = 145;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(18, 21);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 24);
            this.lblFromDate.TabIndex = 144;
            this.lblFromDate.Text = "From";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrint.Location = new System.Drawing.Point(151, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 39);
            this.btnPrint.TabIndex = 149;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(282, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 39);
            this.btnClose.TabIndex = 148;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnNew);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnPrint);
            this.groupBox5.Location = new System.Drawing.Point(23, 460);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 68);
            this.groupBox5.TabIndex = 152;
            this.groupBox5.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNew.Location = new System.Drawing.Point(13, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(119, 39);
            this.btnNew.TabIndex = 157;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnDaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDaily.Location = new System.Drawing.Point(354, 178);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(53, 39);
            this.btnDaily.TabIndex = 158;
            this.btnDaily.Text = "Daily";
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnpatient
            // 
            this.btnpatient.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnpatient.Location = new System.Drawing.Point(151, 19);
            this.btnpatient.Name = "btnpatient";
            this.btnpatient.Size = new System.Drawing.Size(119, 39);
            this.btnpatient.TabIndex = 151;
            this.btnpatient.Text = "Patient";
            this.btnpatient.UseVisualStyleBackColor = true;
            this.btnpatient.Click += new System.EventHandler(this.btnpatient_Click);
            // 
            // btnbalance
            // 
            this.btnbalance.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnbalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbalance.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnbalance.Location = new System.Drawing.Point(14, 19);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(118, 39);
            this.btnbalance.TabIndex = 150;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = true;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDaily);
            this.groupBox1.Controls.Add(this.chkBloodBank);
            this.groupBox1.Controls.Add(this.chkDoctorPaymentBalance);
            this.groupBox1.Controls.Add(this.chkDoctorPaymentReport);
            this.groupBox1.Controls.Add(this.chkdoctorbillreport);
            this.groupBox1.Controls.Add(this.chksummaryreport);
            this.groupBox1.Location = new System.Drawing.Point(23, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 228);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            // 
            // chkBloodBank
            // 
            this.chkBloodBank.AutoSize = true;
            this.chkBloodBank.BackColor = System.Drawing.Color.Yellow;
            this.chkBloodBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBloodBank.Location = new System.Drawing.Point(22, 193);
            this.chkBloodBank.Name = "chkBloodBank";
            this.chkBloodBank.Size = new System.Drawing.Size(294, 24);
            this.chkBloodBank.TabIndex = 157;
            this.chkBloodBank.Text = " Date Wise Report of Blood Bank";
            this.chkBloodBank.UseVisualStyleBackColor = false;
            // 
            // chkDoctorPaymentBalance
            // 
            this.chkDoctorPaymentBalance.AutoSize = true;
            this.chkDoctorPaymentBalance.BackColor = System.Drawing.Color.Yellow;
            this.chkDoctorPaymentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDoctorPaymentBalance.Location = new System.Drawing.Point(22, 153);
            this.chkDoctorPaymentBalance.Name = "chkDoctorPaymentBalance";
            this.chkDoctorPaymentBalance.Size = new System.Drawing.Size(316, 24);
            this.chkDoctorPaymentBalance.TabIndex = 157;
            this.chkDoctorPaymentBalance.Text = "Balance Report of Doctors Payment";
            this.chkDoctorPaymentBalance.UseVisualStyleBackColor = false;
            // 
            // chkDoctorPaymentReport
            // 
            this.chkDoctorPaymentReport.AutoSize = true;
            this.chkDoctorPaymentReport.BackColor = System.Drawing.Color.Yellow;
            this.chkDoctorPaymentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDoctorPaymentReport.Location = new System.Drawing.Point(22, 68);
            this.chkDoctorPaymentReport.Name = "chkDoctorPaymentReport";
            this.chkDoctorPaymentReport.Size = new System.Drawing.Size(304, 24);
            this.chkDoctorPaymentReport.TabIndex = 156;
            this.chkDoctorPaymentReport.Text = "Date Wise Doctor Payment Report";
            this.chkDoctorPaymentReport.UseVisualStyleBackColor = false;
            // 
            // chkdoctorbillreport
            // 
            this.chkdoctorbillreport.AutoSize = true;
            this.chkdoctorbillreport.BackColor = System.Drawing.Color.Yellow;
            this.chkdoctorbillreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdoctorbillreport.Location = new System.Drawing.Point(22, 25);
            this.chkdoctorbillreport.Name = "chkdoctorbillreport";
            this.chkdoctorbillreport.Size = new System.Drawing.Size(259, 24);
            this.chkdoctorbillreport.TabIndex = 155;
            this.chkdoctorbillreport.Text = "Date Wise Doctor Bill Report";
            this.chkdoctorbillreport.UseVisualStyleBackColor = false;
            // 
            // chksummaryreport
            // 
            this.chksummaryreport.AutoSize = true;
            this.chksummaryreport.BackColor = System.Drawing.Color.Yellow;
            this.chksummaryreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksummaryreport.Location = new System.Drawing.Point(22, 111);
            this.chksummaryreport.Name = "chksummaryreport";
            this.chksummaryreport.Size = new System.Drawing.Size(250, 24);
            this.chksummaryreport.TabIndex = 154;
            this.chksummaryreport.Text = "Date Wise Summary Report";
            this.chksummaryreport.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.lblFromDate);
            this.groupBox2.Controls.Add(this.lblToDate);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Location = new System.Drawing.Point(23, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 61);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            // 
            // btndiscount
            // 
            this.btndiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiscount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndiscount.Location = new System.Drawing.Point(289, 19);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(118, 39);
            this.btndiscount.TabIndex = 156;
            this.btndiscount.Text = "P-Discount";
            this.btndiscount.UseVisualStyleBackColor = true;
            this.btndiscount.Click += new System.EventHandler(this.btndiscount_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btndiscount);
            this.groupBox3.Controls.Add(this.btnpatient);
            this.groupBox3.Controls.Add(this.btnbalance);
            this.groupBox3.Location = new System.Drawing.Point(23, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 74);
            this.groupBox3.TabIndex = 155;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(480, 29);
            this.label7.TabIndex = 156;
            this.label7.Text = "Report";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 489);
            this.groupBox4.TabIndex = 157;
            this.groupBox4.TabStop = false;
            // 
            // FrmCollectionPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(473, 549);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCollectionPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection Report";
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chksummaryreport;
        private System.Windows.Forms.CheckBox chkdoctorbillreport;
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Button btnpatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndiscount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDoctorPaymentReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkDoctorPaymentBalance;
        private System.Windows.Forms.CheckBox chkBloodBank;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDaily;

    }
}