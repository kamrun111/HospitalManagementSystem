namespace NewHIMS.Forms.Accounts
{
    partial class FrmInsuranceBillPayment
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
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwBillinfo = new System.Windows.Forms.ListView();
            this.bill_id = new System.Windows.Forms.ColumnHeader();
            this.patient_no = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.bill_amoun = new System.Windows.Forms.ColumnHeader();
            this.assign_date = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.txtComID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwInsuranceCompany = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(785, 34);
            this.label7.TabIndex = 166;
            this.label7.Text = "Insurance Bill Payment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 326);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(326, 230);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(428, 23);
            this.txtRemarks.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remarks";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(257, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(503, 58);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(49, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(391, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(223, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvwBillinfo);
            this.groupBox4.Location = new System.Drawing.Point(257, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 121);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lvwBillinfo
            // 
            this.lvwBillinfo.BackColor = System.Drawing.Color.Silver;
            this.lvwBillinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bill_id,
            this.patient_no,
            this.patient_name,
            this.bill_amoun,
            this.assign_date});
            this.lvwBillinfo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBillinfo.FullRowSelect = true;
            this.lvwBillinfo.GridLines = true;
            this.lvwBillinfo.Location = new System.Drawing.Point(6, 14);
            this.lvwBillinfo.MultiSelect = false;
            this.lvwBillinfo.Name = "lvwBillinfo";
            this.lvwBillinfo.Size = new System.Drawing.Size(491, 96);
            this.lvwBillinfo.TabIndex = 0;
            this.lvwBillinfo.UseCompatibleStateImageBehavior = false;
            this.lvwBillinfo.View = System.Windows.Forms.View.Details;
            this.lvwBillinfo.Click += new System.EventHandler(this.lvwBillinfo_Click);
            // 
            // bill_id
            // 
            this.bill_id.Text = "ID";
            this.bill_id.Width = 0;
            // 
            // patient_no
            // 
            this.patient_no.Text = "Hospital ID";
            this.patient_no.Width = 85;
            // 
            // patient_name
            // 
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 200;
            // 
            // bill_amoun
            // 
            this.bill_amoun.Text = "Amount";
            this.bill_amoun.Width = 90;
            // 
            // assign_date
            // 
            this.assign_date.Text = "Date";
            this.assign_date.Width = 90;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBillID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBalanceAmount);
            this.groupBox3.Controls.Add(this.txtComName);
            this.groupBox3.Controls.Add(this.txtComID);
            this.groupBox3.Location = new System.Drawing.Point(257, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 95);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(282, 58);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(87, 20);
            this.txtAmount.TabIndex = 8;
            this.txtAmount.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bill ID";
            this.label4.Visible = false;
            // 
            // txtBillID
            // 
            this.txtBillID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.Location = new System.Drawing.Point(438, 60);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(43, 23);
            this.txtBillID.TabIndex = 6;
            this.txtBillID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Pending Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insurance Company";
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.Location = new System.Drawing.Point(149, 56);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(119, 23);
            this.txtBalanceAmount.TabIndex = 2;
            // 
            // txtComName
            // 
            this.txtComName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComName.Location = new System.Drawing.Point(148, 19);
            this.txtComName.Name = "txtComName";
            this.txtComName.ReadOnly = true;
            this.txtComName.Size = new System.Drawing.Size(230, 23);
            this.txtComName.TabIndex = 1;
            // 
            // txtComID
            // 
            this.txtComID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComID.Location = new System.Drawing.Point(438, 19);
            this.txtComID.Name = "txtComID";
            this.txtComID.ReadOnly = true;
            this.txtComID.Size = new System.Drawing.Size(43, 23);
            this.txtComID.TabIndex = 0;
            this.txtComID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwInsuranceCompany);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 311);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lvwInsuranceCompany
            // 
            this.lvwInsuranceCompany.BackColor = System.Drawing.Color.Silver;
            this.lvwInsuranceCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.amount});
            this.lvwInsuranceCompany.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInsuranceCompany.FullRowSelect = true;
            this.lvwInsuranceCompany.GridLines = true;
            this.lvwInsuranceCompany.Location = new System.Drawing.Point(6, 12);
            this.lvwInsuranceCompany.Name = "lvwInsuranceCompany";
            this.lvwInsuranceCompany.Size = new System.Drawing.Size(233, 293);
            this.lvwInsuranceCompany.TabIndex = 0;
            this.lvwInsuranceCompany.UseCompatibleStateImageBehavior = false;
            this.lvwInsuranceCompany.View = System.Windows.Forms.View.Details;
            this.lvwInsuranceCompany.Click += new System.EventHandler(this.lvwInsuranceCompany_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // name
            // 
            this.name.Text = "Insurance Company";
            this.name.Width = 200;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 0;
            // 
            // FrmInsuranceBillPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(776, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInsuranceBillPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insurance Bill Payment";
            this.Load += new System.EventHandler(this.FrmInsuranceBillPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvwBillinfo;
        private System.Windows.Forms.ColumnHeader bill_id;
        private System.Windows.Forms.ColumnHeader patient_no;
        private System.Windows.Forms.ColumnHeader bill_amoun;
        private System.Windows.Forms.ColumnHeader assign_date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.TextBox txtComID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwInsuranceCompany;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label5;
    }
}