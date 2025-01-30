namespace NewHIMS.Forms.Investigation
{
    partial class FrmDailyIPDSales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTestDepartemt = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lvwInvestigation = new System.Windows.Forms.ListView();
            this.Investigation_id = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnreprint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDepartemt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(-5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(651, 33);
            this.label7.TabIndex = 144;
            this.label7.Text = "Daily IPD Sales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTestDepartemt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lvwInvestigation);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblDepartemt);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 418);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // cmbTestDepartemt
            // 
            this.cmbTestDepartemt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTestDepartemt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestDepartemt.BackColor = System.Drawing.Color.White;
            this.cmbTestDepartemt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestDepartemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestDepartemt.FormattingEnabled = true;
            this.cmbTestDepartemt.Location = new System.Drawing.Point(152, 18);
            this.cmbTestDepartemt.Name = "cmbTestDepartemt";
            this.cmbTestDepartemt.Size = new System.Drawing.Size(167, 24);
            this.cmbTestDepartemt.TabIndex = 146;
            this.cmbTestDepartemt.Tag = "patient_id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFromDate);
            this.groupBox3.Controls.Add(this.dtpToDate);
            this.groupBox3.Controls.Add(this.lblFromDate);
            this.groupBox3.Controls.Add(this.lblToDate);
            this.groupBox3.Controls.Add(this.btnsubmit);
            this.groupBox3.Location = new System.Drawing.Point(10, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 60);
            this.groupBox3.TabIndex = 142;
            this.groupBox3.TabStop = false;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(92, 23);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(112, 24);
            this.dtpFromDate.TabIndex = 34;
            this.dtpFromDate.Tag = "from_date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(291, 23);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(112, 24);
            this.dtpToDate.TabIndex = 35;
            this.dtpToDate.Tag = "To_date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(30, 23);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(54, 22);
            this.lblFromDate.TabIndex = 30;
            this.lblFromDate.Text = "From";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(249, 23);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(32, 22);
            this.lblToDate.TabIndex = 31;
            this.lblToDate.Text = "To";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsubmit.Location = new System.Drawing.Point(449, 19);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(80, 32);
            this.btnsubmit.TabIndex = 141;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lvwInvestigation
            // 
            this.lvwInvestigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Investigation_id,
            this.patient_code,
            this.date});
            this.lvwInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInvestigation.FullRowSelect = true;
            this.lvwInvestigation.GridLines = true;
            this.lvwInvestigation.Location = new System.Drawing.Point(16, 120);
            this.lvwInvestigation.Name = "lvwInvestigation";
            this.lvwInvestigation.ShowItemToolTips = true;
            this.lvwInvestigation.Size = new System.Drawing.Size(588, 221);
            this.lvwInvestigation.TabIndex = 140;
            this.lvwInvestigation.UseCompatibleStateImageBehavior = false;
            this.lvwInvestigation.View = System.Windows.Forms.View.Details;
            // 
            // Investigation_id
            // 
            this.Investigation_id.Text = "Order No";
            this.Investigation_id.Width = 130;
            // 
            // patient_code
            // 
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 150;
            // 
            // date
            // 
            this.date.Text = "Order Date";
            this.date.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnreprint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(10, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 59);
            this.groupBox2.TabIndex = 141;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(349, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 34);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Print";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnreprint
            // 
            this.btnreprint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnreprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnreprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreprint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnreprint.Location = new System.Drawing.Point(34, 16);
            this.btnreprint.Name = "btnreprint";
            this.btnreprint.Size = new System.Drawing.Size(87, 34);
            this.btnreprint.TabIndex = 142;
            this.btnreprint.Text = "Re Print";
            this.btnreprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreprint.UseVisualStyleBackColor = true;
            this.btnreprint.Click += new System.EventHandler(this.btnreprint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(497, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 34);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDepartemt
            // 
            this.lblDepartemt.AutoSize = true;
            this.lblDepartemt.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartemt.Location = new System.Drawing.Point(32, 18);
            this.lblDepartemt.Name = "lblDepartemt";
            this.lblDepartemt.Size = new System.Drawing.Size(114, 22);
            this.lblDepartemt.TabIndex = 38;
            this.lblDepartemt.Text = "Department:";
            this.lblDepartemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(10, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 238);
            this.groupBox4.TabIndex = 143;
            this.groupBox4.TabStop = false;
            // 
            // FrmDailyIPDSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(641, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDailyIPDSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily IPD Sales";
            this.Load += new System.EventHandler(this.FrmDailyIPDSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ListView lvwInvestigation;
        private System.Windows.Forms.ColumnHeader Investigation_id;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnreprint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDepartemt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTestDepartemt;
    }
}