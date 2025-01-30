namespace NewHIMS.Forms.Medicine
{
    partial class FrmMedicineEntry
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
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.cabin_id = new System.Windows.Forms.ColumnHeader();
            this.Patient_id = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.amissiondate = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvwPatientOtherItem = new System.Windows.Forms.ListView();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.patient_medicine_bill_id = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.issuedby = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-2, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(771, 33);
            this.label7.TabIndex = 108;
            this.label7.Text = "IPD Medicine Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPatientInfo);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.groupBox1.Location = new System.Drawing.Point(8, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 440);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admission_id,
            this.cabin,
            this.patient_code,
            this.cabin_id,
            this.Patient_id,
            this.patient_name,
            this.admission_code,
            this.amissiondate,
            this.age});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.GridLines = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(7, 20);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(339, 409);
            this.lvwPatientInfo.TabIndex = 7;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.SelectedIndexChanged += new System.EventHandler(this.lvwPatientInfo_SelectedIndexChanged);
            // 
            // admission_id
            // 
            this.admission_id.Name = "admission_id";
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "Cabin";
            this.cabin.Width = 47;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 78;
            // 
            // cabin_id
            // 
            this.cabin_id.Text = "cabin_id";
            this.cabin_id.Width = 0;
            // 
            // Patient_id
            // 
            this.Patient_id.Text = "patient_id";
            this.Patient_id.Width = 0;
            // 
            // patient_name
            // 
            this.patient_name.Text = "P. Name";
            this.patient_name.Width = 200;
            // 
            // admission_code
            // 
            this.admission_code.Text = "admission_code";
            this.admission_code.Width = 0;
            // 
            // amissiondate
            // 
            this.amissiondate.Text = "amissiondate";
            this.amissiondate.Width = 0;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDate);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.lvwPatientOtherItem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.lblQtyPerUnit);
            this.groupBox3.Location = new System.Drawing.Point(366, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 296);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(286, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "  Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lvwPatientOtherItem
            // 
            this.lvwPatientOtherItem.BackColor = System.Drawing.Color.Silver;
            this.lvwPatientOtherItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.amount,
            this.patient_medicine_bill_id,
            this.issuedby});
            this.lvwPatientOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientOtherItem.FullRowSelect = true;
            this.lvwPatientOtherItem.GridLines = true;
            this.lvwPatientOtherItem.Location = new System.Drawing.Point(7, 87);
            this.lvwPatientOtherItem.Name = "lvwPatientOtherItem";
            this.lvwPatientOtherItem.Size = new System.Drawing.Size(371, 205);
            this.lvwPatientOtherItem.TabIndex = 54;
            this.lvwPatientOtherItem.UseCompatibleStateImageBehavior = false;
            this.lvwPatientOtherItem.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Issue Date";
            this.date.Width = 110;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 93;
            // 
            // patient_medicine_bill_id
            // 
            this.patient_medicine_bill_id.Text = "id";
            this.patient_medicine_bill_id.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Delivery Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Linen;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(140, 54);
            this.txtAmount.MaxLength = 4;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(104, 22);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Tag = "";
            this.txtAmount.Text = "0";
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(17, 57);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(120, 16);
            this.lblQtyPerUnit.TabIndex = 16;
            this.lblQtyPerUnit.Text = "Medicine Amount";
            this.lblQtyPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDiscount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtDue);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtAdvance);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtTotalBill);
            this.groupBox4.Location = new System.Drawing.Point(366, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 90);
            this.groupBox4.TabIndex = 120;
            this.groupBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Discount :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(90, 53);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(91, 20);
            this.txtDiscount.TabIndex = 65;
            this.txtDiscount.Text = "0";
            this.txtDiscount.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Due :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDue
            // 
            this.txtDue.Enabled = false;
            this.txtDue.Location = new System.Drawing.Point(270, 53);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 63;
            this.txtDue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Advance :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Enabled = false;
            this.txtAdvance.Location = new System.Drawing.Point(90, 19);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(91, 20);
            this.txtAdvance.TabIndex = 61;
            this.txtAdvance.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Total Bill :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Location = new System.Drawing.Point(270, 19);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBill.TabIndex = 0;
            this.txtTotalBill.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(366, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 57);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(270, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(69, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(140, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(104, 24);
            this.dtpDate.TabIndex = 147;
            this.dtpDate.Tag = "from_date";
            // 
            // issuedby
            // 
            this.issuedby.Text = "Issued By";
            this.issuedby.Width = 140;
            // 
            // FrmMedicineEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(764, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedicineEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Entry";
            this.Load += new System.EventHandler(this.FrmMedicineEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader cabin_id;
        private System.Windows.Forms.ColumnHeader Patient_id;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader amissiondate;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvwPatientOtherItem;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader patient_medicine_bill_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ColumnHeader issuedby;
    }
}