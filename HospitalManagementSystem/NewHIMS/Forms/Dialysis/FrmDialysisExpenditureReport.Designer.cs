namespace NewHIMS.Forms.Dialysis
{
    partial class FrmDialysisExpenditureReport
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkdatewisesreport = new System.Windows.Forms.CheckBox();
            this.chksummaryreport = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lvwExpenditure = new System.Windows.Forms.ListView();
            this.expenditure_order_id = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.expenditure_no = new System.Windows.Forms.ColumnHeader();
            this.record_created_by = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnreprint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkMonthlyReport = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 33);
            this.label7.TabIndex = 147;
            this.label7.Text = "Expenditure Report";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(8, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 473);
            this.groupBox4.TabIndex = 148;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.chkdatewisesreport);
            this.groupBox3.Controls.Add(this.chksummaryreport);
            this.groupBox3.Controls.Add(this.dtpToDate);
            this.groupBox3.Controls.Add(this.dtpFromDate);
            this.groupBox3.Controls.Add(this.lblToDate);
            this.groupBox3.Controls.Add(this.lblFromDate);
            this.groupBox3.Controls.Add(this.lvwExpenditure);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 405);
            this.groupBox3.TabIndex = 136;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 136;
            this.label9.Text = "Report";
            // 
            // chkdatewisesreport
            // 
            this.chkdatewisesreport.AutoSize = true;
            this.chkdatewisesreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdatewisesreport.Location = new System.Drawing.Point(25, 92);
            this.chkdatewisesreport.Name = "chkdatewisesreport";
            this.chkdatewisesreport.Size = new System.Drawing.Size(181, 17);
            this.chkdatewisesreport.TabIndex = 144;
            this.chkdatewisesreport.Text = "Date Wise Summary Report";
            this.chkdatewisesreport.UseVisualStyleBackColor = true;
            // 
            // chksummaryreport
            // 
            this.chksummaryreport.AutoSize = true;
            this.chksummaryreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksummaryreport.Location = new System.Drawing.Point(25, 67);
            this.chksummaryreport.Name = "chksummaryreport";
            this.chksummaryreport.Size = new System.Drawing.Size(118, 17);
            this.chksummaryreport.TabIndex = 143;
            this.chksummaryreport.Text = "Summary Report";
            this.chksummaryreport.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(201, 20);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(105, 21);
            this.dtpToDate.TabIndex = 142;
            this.dtpToDate.Tag = "To_date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(57, 20);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(102, 21);
            this.dtpFromDate.TabIndex = 141;
            this.dtpFromDate.Tag = "from_date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(166, 22);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(27, 17);
            this.lblToDate.TabIndex = 140;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(8, 23);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(44, 17);
            this.lblFromDate.TabIndex = 139;
            this.lblFromDate.Text = "From";
            // 
            // lvwExpenditure
            // 
            this.lvwExpenditure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenditure_order_id,
            this.time,
            this.expenditure_no,
            this.record_created_by});
            this.lvwExpenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwExpenditure.FullRowSelect = true;
            this.lvwExpenditure.GridLines = true;
            this.lvwExpenditure.Location = new System.Drawing.Point(11, 189);
            this.lvwExpenditure.Name = "lvwExpenditure";
            this.lvwExpenditure.ShowItemToolTips = true;
            this.lvwExpenditure.Size = new System.Drawing.Size(403, 209);
            this.lvwExpenditure.TabIndex = 138;
            this.lvwExpenditure.UseCompatibleStateImageBehavior = false;
            this.lvwExpenditure.View = System.Windows.Forms.View.Details;
            // 
            // expenditure_order_id
            // 
            this.expenditure_order_id.Text = "expenditure_order_id";
            this.expenditure_order_id.Width = 0;
            // 
            // time
            // 
            this.time.Text = "Expenditure No";
            this.time.Width = 140;
            // 
            // expenditure_no
            // 
            this.expenditure_no.Text = "Done By";
            this.expenditure_no.Width = 100;
            // 
            // record_created_by
            // 
            this.record_created_by.Text = "Date & Time";
            this.record_created_by.Width = 140;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.Location = new System.Drawing.Point(331, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 137;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMonthlyReport);
            this.groupBox1.Location = new System.Drawing.Point(11, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 96);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnreprint);
            this.groupBox5.Controls.Add(this.btnPrint);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Location = new System.Drawing.Point(7, 411);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 54);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // btnreprint
            // 
            this.btnreprint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnreprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnreprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreprint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnreprint.Location = new System.Drawing.Point(15, 16);
            this.btnreprint.Name = "btnreprint";
            this.btnreprint.Size = new System.Drawing.Size(75, 28);
            this.btnreprint.TabIndex = 140;
            this.btnreprint.Text = "Re Print";
            this.btnreprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreprint.UseVisualStyleBackColor = true;
            this.btnreprint.Click += new System.EventHandler(this.btnreprint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrint.Location = new System.Drawing.Point(211, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 139;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(328, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 138;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkMonthlyReport
            // 
            this.chkMonthlyReport.AutoSize = true;
            this.chkMonthlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonthlyReport.Location = new System.Drawing.Point(14, 69);
            this.chkMonthlyReport.Name = "chkMonthlyReport";
            this.chkMonthlyReport.Size = new System.Drawing.Size(112, 17);
            this.chkMonthlyReport.TabIndex = 146;
            this.chkMonthlyReport.Text = "Monthly Report";
            this.chkMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // FrmDialysisExpenditureReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(453, 522);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialysisExpenditureReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialysis Expenditure Report";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnreprint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkdatewisesreport;
        private System.Windows.Forms.CheckBox chksummaryreport;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.ListView lvwExpenditure;
        private System.Windows.Forms.ColumnHeader expenditure_order_id;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader expenditure_no;
        private System.Windows.Forms.ColumnHeader record_created_by;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMonthlyReport;
    }
}