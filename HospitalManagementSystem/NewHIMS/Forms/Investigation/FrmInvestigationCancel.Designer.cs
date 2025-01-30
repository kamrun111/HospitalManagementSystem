namespace NewHIMS.Forms.Investigation
{
    partial class FrmInvestigationCancel
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lvwInvestigationCancel = new System.Windows.Forms.ListView();
            this.investigation_id = new System.Windows.Forms.ColumnHeader();
            this.order_number = new System.Windows.Forms.ColumnHeader();
            this.total_amount = new System.Windows.Forms.ColumnHeader();
            this.discount = new System.Windows.Forms.ColumnHeader();
            this.dept_id = new System.Windows.Forms.ColumnHeader();
            this.test_item = new System.Windows.Forms.ColumnHeader();
            this.charge = new System.Windows.Forms.ColumnHeader();
            this.pt_type = new System.Windows.Forms.ColumnHeader();
            this.code = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.phone = new System.Windows.Forms.ColumnHeader();
            this.order_date = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvestigationNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInvestigationID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPTType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtHospitalID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoOutdoor = new System.Windows.Forms.RadioButton();
            this.rdoIndoor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(-3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(531, 33);
            this.label7.TabIndex = 144;
            this.label7.Text = "Investigation Cancel";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.lvwInvestigationCancel);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 432);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(209, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 35);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lvwInvestigationCancel
            // 
            this.lvwInvestigationCancel.BackColor = System.Drawing.Color.Silver;
            this.lvwInvestigationCancel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.investigation_id,
            this.order_number,
            this.total_amount,
            this.discount,
            this.dept_id,
            this.test_item,
            this.charge,
            this.pt_type,
            this.code,
            this.name,
            this.phone,
            this.order_date});
            this.lvwInvestigationCancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInvestigationCancel.GridLines = true;
            this.lvwInvestigationCancel.Location = new System.Drawing.Point(6, 261);
            this.lvwInvestigationCancel.Name = "lvwInvestigationCancel";
            this.lvwInvestigationCancel.Size = new System.Drawing.Size(498, 100);
            this.lvwInvestigationCancel.TabIndex = 4;
            this.lvwInvestigationCancel.UseCompatibleStateImageBehavior = false;
            this.lvwInvestigationCancel.View = System.Windows.Forms.View.Details;
            // 
            // investigation_id
            // 
            this.investigation_id.Text = "ID";
            this.investigation_id.Width = 0;
            // 
            // order_number
            // 
            this.order_number.Text = "order";
            this.order_number.Width = 0;
            // 
            // total_amount
            // 
            this.total_amount.Text = "Amount";
            this.total_amount.Width = 0;
            // 
            // discount
            // 
            this.discount.Text = "Discount";
            this.discount.Width = 0;
            // 
            // dept_id
            // 
            this.dept_id.Text = "Dept ID";
            this.dept_id.Width = 0;
            // 
            // test_item
            // 
            this.test_item.Text = "Test  Name";
            this.test_item.Width = 250;
            // 
            // charge
            // 
            this.charge.Text = "Price";
            this.charge.Width = 100;
            // 
            // pt_type
            // 
            this.pt_type.Text = "PT Type";
            this.pt_type.Width = 0;
            // 
            // code
            // 
            this.code.Text = "PT Code";
            this.code.Width = 0;
            // 
            // name
            // 
            this.name.Text = "Pt Name";
            this.name.Width = 0;
            // 
            // phone
            // 
            this.phone.Text = "Mobile";
            this.phone.Width = 0;
            // 
            // order_date
            // 
            this.order_date.Text = "Date";
            this.order_date.Width = 120;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Location = new System.Drawing.Point(6, 364);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(498, 62);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(49, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(386, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(208, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtInvestigationNo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbDepartment);
            this.groupBox3.Location = new System.Drawing.Point(235, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 91);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Investigation No";
            // 
            // txtInvestigationNo
            // 
            this.txtInvestigationNo.Location = new System.Drawing.Point(140, 53);
            this.txtInvestigationNo.Name = "txtInvestigationNo";
            this.txtInvestigationNo.Size = new System.Drawing.Size(115, 20);
            this.txtInvestigationNo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Test Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(140, 16);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(115, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtDiscount);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtInvestigationID);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtPTType);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtMobile);
            this.groupBox4.Controls.Add(this.txtPatientName);
            this.groupBox4.Controls.Add(this.txtHospitalID);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDate);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Location = new System.Drawing.Point(6, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 120);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(244, 51);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(64, 23);
            this.txtDiscount.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(350, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "I. ID";
            // 
            // txtInvestigationID
            // 
            this.txtInvestigationID.Enabled = false;
            this.txtInvestigationID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestigationID.Location = new System.Drawing.Point(386, 51);
            this.txtInvestigationID.Name = "txtInvestigationID";
            this.txtInvestigationID.Size = new System.Drawing.Size(93, 23);
            this.txtInvestigationID.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "PT Type";
            // 
            // txtPTType
            // 
            this.txtPTType.Enabled = false;
            this.txtPTType.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTType.Location = new System.Drawing.Point(244, 18);
            this.txtPTType.Name = "txtPTType";
            this.txtPTType.Size = new System.Drawing.Size(64, 23);
            this.txtPTType.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Hospital ID";
            // 
            // txtMobile
            // 
            this.txtMobile.Enabled = false;
            this.txtMobile.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(386, 82);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(93, 23);
            this.txtMobile.TabIndex = 4;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(92, 83);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(216, 23);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtHospitalID
            // 
            this.txtHospitalID.Enabled = false;
            this.txtHospitalID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalID.Location = new System.Drawing.Point(93, 18);
            this.txtHospitalID.Name = "txtHospitalID";
            this.txtHospitalID.Size = new System.Drawing.Size(75, 23);
            this.txtHospitalID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mobile ";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(386, 18);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(93, 23);
            this.txtDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(92, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 23);
            this.txtTotal.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoOutdoor);
            this.groupBox2.Controls.Add(this.rdoIndoor);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 91);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // rdoOutdoor
            // 
            this.rdoOutdoor.AutoSize = true;
            this.rdoOutdoor.BackColor = System.Drawing.Color.Yellow;
            this.rdoOutdoor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOutdoor.Location = new System.Drawing.Point(19, 54);
            this.rdoOutdoor.Name = "rdoOutdoor";
            this.rdoOutdoor.Size = new System.Drawing.Size(178, 23);
            this.rdoOutdoor.TabIndex = 1;
            this.rdoOutdoor.Text = "Outdoor Investigation";
            this.rdoOutdoor.UseVisualStyleBackColor = false;
            // 
            // rdoIndoor
            // 
            this.rdoIndoor.AutoSize = true;
            this.rdoIndoor.BackColor = System.Drawing.Color.Yellow;
            this.rdoIndoor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIndoor.Location = new System.Drawing.Point(19, 18);
            this.rdoIndoor.Name = "rdoIndoor";
            this.rdoIndoor.Size = new System.Drawing.Size(168, 23);
            this.rdoIndoor.TabIndex = 0;
            this.rdoIndoor.Text = "Indoor Investigation";
            this.rdoIndoor.UseVisualStyleBackColor = false;
            // 
            // FrmInvestigationCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(524, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvestigationCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Cancel";
            this.Load += new System.EventHandler(this.FrmInvestigationCancel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoOutdoor;
        private System.Windows.Forms.RadioButton rdoIndoor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvwInvestigationCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvestigationNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPTType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHospitalID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInvestigationID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ColumnHeader investigation_id;
        private System.Windows.Forms.ColumnHeader order_number;
        private System.Windows.Forms.ColumnHeader total_amount;
        private System.Windows.Forms.ColumnHeader discount;
        private System.Windows.Forms.ColumnHeader dept_id;
        private System.Windows.Forms.ColumnHeader test_item;
        private System.Windows.Forms.ColumnHeader charge;
        private System.Windows.Forms.ColumnHeader pt_type;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader order_date;
    }
}