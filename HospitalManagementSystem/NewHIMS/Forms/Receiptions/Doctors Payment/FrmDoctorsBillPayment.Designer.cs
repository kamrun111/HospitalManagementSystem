namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    partial class FrmDoctorsBillPayment
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
            this.lvwDoctorInfo = new System.Windows.Forms.ListView();
            this.reffered_doc_id = new System.Windows.Forms.ColumnHeader();
            this.reffered_doc = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grddoctorspayment = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.admission_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctors_bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDoctorInfo
            // 
            this.lvwDoctorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDoctorInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.lvwDoctorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwDoctorInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reffered_doc_id,
            this.reffered_doc});
            this.lvwDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwDoctorInfo.FullRowSelect = true;
            this.lvwDoctorInfo.GridLines = true;
            this.lvwDoctorInfo.HideSelection = false;
            this.lvwDoctorInfo.Location = new System.Drawing.Point(9, 16);
            this.lvwDoctorInfo.Name = "lvwDoctorInfo";
            this.lvwDoctorInfo.Size = new System.Drawing.Size(379, 430);
            this.lvwDoctorInfo.TabIndex = 8;
            this.lvwDoctorInfo.UseCompatibleStateImageBehavior = false;
            this.lvwDoctorInfo.View = System.Windows.Forms.View.Details;
            // 
            // reffered_doc_id
            // 
            this.reffered_doc_id.Text = "reffered_doc_id";
            this.reffered_doc_id.Width = 0;
            // 
            // reffered_doc
            // 
            this.reffered_doc.Text = "Doctor Name";
            this.reffered_doc.Width = 340;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvwDoctorInfo);
            this.groupBox5.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.groupBox5.Location = new System.Drawing.Point(12, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(398, 455);
            this.groupBox5.TabIndex = 134;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctor Info";
            // 
            // grddoctorspayment
            // 
            this.grddoctorspayment.AllowUserToAddRows = false;
            this.grddoctorspayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddoctorspayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admission_id,
            this.patient_code,
            this.bill_type_id,
            this.bill_type,
            this.Qty,
            this.amount,
            this.paid_amount,
            this.doctors_bill_id,
            this.Date,
            this.ot_date});
            this.grddoctorspayment.Location = new System.Drawing.Point(7, 19);
            this.grddoctorspayment.Name = "grddoctorspayment";
            this.grddoctorspayment.Size = new System.Drawing.Size(538, 344);
            this.grddoctorspayment.TabIndex = 55;
            this.grddoctorspayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCount);
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.grddoctorspayment);
            this.groupBox3.Location = new System.Drawing.Point(420, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 403);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.Color.Brown;
            this.txtCount.Location = new System.Drawing.Point(92, 369);
            this.txtCount.MaxLength = 7;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(44, 20);
            this.txtCount.TabIndex = 136;
            this.txtCount.Tag = "purchase";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Brown;
            this.lblCount.Location = new System.Drawing.Point(16, 372);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(70, 13);
            this.lblCount.TabIndex = 135;
            this.lblCount.Text = "No. of List:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(227, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 69;
            this.label16.Text = "Total Taka";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(324, 371);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 68;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnprint);
            this.groupBox4.Controls.Add(this.btnrefresh);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.btnclose);
            this.groupBox4.Location = new System.Drawing.Point(420, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 53);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(23, 16);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(83, 28);
            this.btnprint.TabIndex = 60;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(149, 16);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(83, 28);
            this.btnrefresh.TabIndex = 56;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(286, 16);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(83, 28);
            this.btnsave.TabIndex = 57;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(405, 16);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 28);
            this.btnclose.TabIndex = 58;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(273, 25);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(96, 20);
            this.dtpToDate.TabIndex = 39;
            this.dtpToDate.Tag = "To_date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(111, 25);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(91, 20);
            this.dtpFromDate.TabIndex = 38;
            this.dtpFromDate.Tag = "from_date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(240, 26);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(27, 17);
            this.lblToDate.TabIndex = 37;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(61, 26);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(44, 17);
            this.lblFromDate.TabIndex = 36;
            this.lblFromDate.Text = "From";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 28);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Location = new System.Drawing.Point(420, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 59);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDoctorName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 59);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(153, 25);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(232, 20);
            this.txtDoctorName.TabIndex = 140;
            this.txtDoctorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "Consultant\'s Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-4, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(990, 30);
            this.label15.TabIndex = 137;
            this.label15.Text = "DOCTORS PAYMENTS";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // admission_id
            // 
            this.admission_id.Frozen = true;
            this.admission_id.HeaderText = "admission_id";
            this.admission_id.Name = "admission_id";
            this.admission_id.Visible = false;
            // 
            // patient_code
            // 
            this.patient_code.Frozen = true;
            this.patient_code.HeaderText = "Hospital ID";
            this.patient_code.Name = "patient_code";
            this.patient_code.Width = 90;
            // 
            // bill_type_id
            // 
            this.bill_type_id.Frozen = true;
            this.bill_type_id.HeaderText = "bill_type_id";
            this.bill_type_id.Name = "bill_type_id";
            this.bill_type_id.Visible = false;
            // 
            // bill_type
            // 
            this.bill_type.Frozen = true;
            this.bill_type.HeaderText = "Type";
            this.bill_type.Name = "bill_type";
            // 
            // Qty
            // 
            this.Qty.Frozen = true;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 40;
            // 
            // amount
            // 
            this.amount.Frozen = true;
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.Visible = false;
            this.amount.Width = 85;
            // 
            // paid_amount
            // 
            this.paid_amount.Frozen = true;
            this.paid_amount.HeaderText = "Amount";
            this.paid_amount.Name = "paid_amount";
            this.paid_amount.Width = 80;
            // 
            // doctors_bill_id
            // 
            this.doctors_bill_id.HeaderText = "doctors_bill_id";
            this.doctors_bill_id.Name = "doctors_bill_id";
            this.doctors_bill_id.Visible = false;
            this.doctors_bill_id.Width = 40;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 80;
            // 
            // ot_date
            // 
            this.ot_date.HeaderText = "OT Date";
            this.ot_date.Name = "ot_date";
            this.ot_date.Width = 80;
            // 
            // FrmDoctorsBillPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(983, 566);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoctorsBillPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Payment Submit";
            this.Load += new System.EventHandler(this.FrmDoctorsBillPayment_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDoctorInfo;
        private System.Windows.Forms.ColumnHeader reffered_doc_id;
        private System.Windows.Forms.ColumnHeader reffered_doc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grddoctorspayment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctors_bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_date;
    }
}