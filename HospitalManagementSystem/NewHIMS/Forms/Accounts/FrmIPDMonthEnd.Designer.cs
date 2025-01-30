namespace NewHIMS.Forms.Accounts
{
    partial class FrmIPDMonthEnd
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
            this.grdpatientinfo = new System.Windows.Forms.DataGridView();
            this.admission_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discharge_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_distribution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntotalrefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdpatientinfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(760, 33);
            this.label7.TabIndex = 109;
            this.label7.Text = "Monthly Discharged Patient";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdpatientinfo
            // 
            this.grdpatientinfo.AllowUserToAddRows = false;
            this.grdpatientinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdpatientinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admission_id,
            this.patient_id,
            this.bill_id,
            this.patient_code,
            this.patient_name,
            this.discharge_date,
            this.discount,
            this.discount_distribution});
            this.grdpatientinfo.Location = new System.Drawing.Point(26, 127);
            this.grdpatientinfo.Name = "grdpatientinfo";
            this.grdpatientinfo.Size = new System.Drawing.Size(686, 275);
            this.grdpatientinfo.TabIndex = 110;
            // 
            // admission_id
            // 
            this.admission_id.HeaderText = "admission_id";
            this.admission_id.Name = "admission_id";
            this.admission_id.Visible = false;
            // 
            // patient_id
            // 
            this.patient_id.HeaderText = "patient_id";
            this.patient_id.Name = "patient_id";
            this.patient_id.Visible = false;
            // 
            // bill_id
            // 
            this.bill_id.HeaderText = "bill_id";
            this.bill_id.Name = "bill_id";
            this.bill_id.Visible = false;
            // 
            // patient_code
            // 
            this.patient_code.HeaderText = "Hospital ID";
            this.patient_code.Name = "patient_code";
            // 
            // patient_name
            // 
            this.patient_name.HeaderText = "Patient Name";
            this.patient_name.Name = "patient_name";
            this.patient_name.Width = 200;
            // 
            // discharge_date
            // 
            this.discharge_date.HeaderText = "Discharge date";
            this.discharge_date.Name = "discharge_date";
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // discount_distribution
            // 
            this.discount_distribution.HeaderText = "Discount Distribution";
            this.discount_distribution.Name = "discount_distribution";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 309);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // btntotalrefresh
            // 
            this.btntotalrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntotalrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntotalrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotalrefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btntotalrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntotalrefresh.Location = new System.Drawing.Point(14, 19);
            this.btntotalrefresh.Name = "btntotalrefresh";
            this.btntotalrefresh.Size = new System.Drawing.Size(79, 28);
            this.btntotalrefresh.TabIndex = 142;
            this.btntotalrefresh.Text = "Refresh";
            this.btntotalrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntotalrefresh.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(462, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 140;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(612, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 141;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntotalrefresh);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 60);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(294, 69);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(101, 20);
            this.dtpToDate.TabIndex = 147;
            this.dtpToDate.Tag = "To_date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(117, 69);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(102, 20);
            this.dtpFromDate.TabIndex = 146;
            this.dtpFromDate.Tag = "from_date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(249, 24);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(27, 17);
            this.lblToDate.TabIndex = 145;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(67, 70);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(44, 17);
            this.lblFromDate.TabIndex = 144;
            this.lblFromDate.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblToDate);
            this.groupBox3.Location = new System.Drawing.Point(12, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 59);
            this.groupBox3.TabIndex = 148;
            this.groupBox3.TabStop = false;
            // 
            // FrmIPDMonthEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 503);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.grdpatientinfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIPDMonthEnd";
            this.Text = "Monthly Patient";
            ((System.ComponentModel.ISupportInitialize)(this.grdpatientinfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdpatientinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntotalrefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn discharge_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_distribution;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}