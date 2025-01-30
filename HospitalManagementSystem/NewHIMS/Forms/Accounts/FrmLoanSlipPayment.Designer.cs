namespace NewHIMS.Forms.Accounts
{
    partial class FrmLoanSlipPayment
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwSlipinfo = new System.Windows.Forms.ListView();
            this.slip_id = new System.Windows.Forms.ColumnHeader();
            this.slip_no = new System.Windows.Forms.ColumnHeader();
            this.slip_amoun = new System.Windows.Forms.ColumnHeader();
            this.slip_date = new System.Windows.Forms.ColumnHeader();
            this.created_by = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSlipID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwLoanEmployee = new System.Windows.Forms.ListView();
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
            this.label7.Location = new System.Drawing.Point(-4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(730, 34);
            this.label7.TabIndex = 165;
            this.label7.Text = "Loan Slip Payment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 290);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Location = new System.Drawing.Point(257, 221);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 64);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(49, 19);
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
            this.btnClose.Location = new System.Drawing.Point(334, 19);
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
            this.btnSave.Location = new System.Drawing.Point(194, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvwSlipinfo);
            this.groupBox4.Location = new System.Drawing.Point(257, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 121);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lvwSlipinfo
            // 
            this.lvwSlipinfo.BackColor = System.Drawing.Color.Silver;
            this.lvwSlipinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.slip_id,
            this.slip_no,
            this.slip_amoun,
            this.slip_date,
            this.created_by});
            this.lvwSlipinfo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSlipinfo.FullRowSelect = true;
            this.lvwSlipinfo.GridLines = true;
            this.lvwSlipinfo.Location = new System.Drawing.Point(6, 14);
            this.lvwSlipinfo.Name = "lvwSlipinfo";
            this.lvwSlipinfo.Size = new System.Drawing.Size(434, 96);
            this.lvwSlipinfo.TabIndex = 0;
            this.lvwSlipinfo.UseCompatibleStateImageBehavior = false;
            this.lvwSlipinfo.View = System.Windows.Forms.View.Details;
            this.lvwSlipinfo.Click += new System.EventHandler(this.lvwSlipinfo_Click);
            // 
            // slip_id
            // 
            this.slip_id.Text = "ID";
            this.slip_id.Width = 0;
            // 
            // slip_no
            // 
            this.slip_no.Text = "Slip No";
            this.slip_no.Width = 90;
            // 
            // slip_amoun
            // 
            this.slip_amoun.Text = "Amount";
            this.slip_amoun.Width = 90;
            // 
            // slip_date
            // 
            this.slip_date.Text = "Date";
            this.slip_date.Width = 90;
            // 
            // created_by
            // 
            this.created_by.Text = "Payment by";
            this.created_by.Width = 140;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSlipID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBalanceAmount);
            this.groupBox3.Controls.Add(this.txtEmpName);
            this.groupBox3.Controls.Add(this.txtEmpID);
            this.groupBox3.Location = new System.Drawing.Point(257, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 95);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(240, 58);
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
            this.label4.Location = new System.Drawing.Point(333, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Slip ID";
            this.label4.Visible = false;
            // 
            // txtSlipID
            // 
            this.txtSlipID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlipID.Location = new System.Drawing.Point(383, 60);
            this.txtSlipID.Name = "txtSlipID";
            this.txtSlipID.ReadOnly = true;
            this.txtSlipID.Size = new System.Drawing.Size(43, 23);
            this.txtSlipID.TabIndex = 6;
            this.txtSlipID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 22);
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
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Loan Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name";
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.Location = new System.Drawing.Point(134, 56);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(100, 23);
            this.txtBalanceAmount.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(133, 19);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(183, 23);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(383, 19);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(43, 23);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwLoanEmployee);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 278);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lvwLoanEmployee
            // 
            this.lvwLoanEmployee.BackColor = System.Drawing.Color.Silver;
            this.lvwLoanEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.amount});
            this.lvwLoanEmployee.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLoanEmployee.FullRowSelect = true;
            this.lvwLoanEmployee.GridLines = true;
            this.lvwLoanEmployee.Location = new System.Drawing.Point(6, 12);
            this.lvwLoanEmployee.Name = "lvwLoanEmployee";
            this.lvwLoanEmployee.Size = new System.Drawing.Size(233, 255);
            this.lvwLoanEmployee.TabIndex = 0;
            this.lvwLoanEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwLoanEmployee.View = System.Windows.Forms.View.Details;
            this.lvwLoanEmployee.Click += new System.EventHandler(this.lvwLoanEmployee_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 200;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 0;
            // 
            // FrmLoanSlipPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(721, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoanSlipPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Slip Payment";
            this.Load += new System.EventHandler(this.FrmLoanSlipPayment_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvwSlipinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.ListView lvwLoanEmployee;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader slip_id;
        private System.Windows.Forms.ColumnHeader slip_no;
        private System.Windows.Forms.ColumnHeader slip_amoun;
        private System.Windows.Forms.ColumnHeader slip_date;
        private System.Windows.Forms.ColumnHeader created_by;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSlipID;
        private System.Windows.Forms.TextBox txtAmount;
    }
}