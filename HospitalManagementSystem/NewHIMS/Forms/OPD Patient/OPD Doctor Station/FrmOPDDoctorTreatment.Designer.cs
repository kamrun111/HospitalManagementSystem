namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    partial class FrmOPDDoctorTreatment
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
            this.cmbAdvice = new System.Windows.Forms.ComboBox();
            this.btnAdviceAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwAdvice = new System.Windows.Forms.ListView();
            this.SN = new System.Windows.Forms.ColumnHeader();
            this.Advice = new System.Windows.Forms.ColumnHeader();
            this.Medicine = new System.Windows.Forms.GroupBox();
            this.lvwMedicine = new System.Windows.Forms.ListView();
            this.MSN = new System.Windows.Forms.ColumnHeader();
            this.MedicineName = new System.Windows.Forms.ColumnHeader();
            this.DoseQuantity = new System.Windows.Forms.ColumnHeader();
            this.Duration = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtOPDRegNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtConsultant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMedicineAdd = new System.Windows.Forms.Button();
            this.txtDoseQuantity = new System.Windows.Forms.TextBox();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbOTName = new System.Windows.Forms.ComboBox();
            this.txtOTProcedure = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Medicine.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAdvice
            // 
            this.cmbAdvice.FormattingEnabled = true;
            this.cmbAdvice.Location = new System.Drawing.Point(11, 41);
            this.cmbAdvice.Name = "cmbAdvice";
            this.cmbAdvice.Size = new System.Drawing.Size(257, 21);
            this.cmbAdvice.TabIndex = 10;
            // 
            // btnAdviceAdd
            // 
            this.btnAdviceAdd.Location = new System.Drawing.Point(274, 39);
            this.btnAdviceAdd.Name = "btnAdviceAdd";
            this.btnAdviceAdd.Size = new System.Drawing.Size(45, 23);
            this.btnAdviceAdd.TabIndex = 12;
            this.btnAdviceAdd.Text = "Add";
            this.btnAdviceAdd.UseVisualStyleBackColor = true;
            this.btnAdviceAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Advice";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Goldenrod;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-15, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(823, 40);
            this.label11.TabIndex = 27;
            this.label11.Text = "OPD  Medication With OT Note and Advice";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwAdvice);
            this.groupBox1.Controls.Add(this.cmbAdvice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAdviceAdd);
            this.groupBox1.Location = new System.Drawing.Point(455, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 172);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advice";
            // 
            // lvwAdvice
            // 
            this.lvwAdvice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SN,
            this.Advice});
            this.lvwAdvice.FullRowSelect = true;
            this.lvwAdvice.GridLines = true;
            this.lvwAdvice.Location = new System.Drawing.Point(11, 68);
            this.lvwAdvice.Name = "lvwAdvice";
            this.lvwAdvice.Size = new System.Drawing.Size(302, 97);
            this.lvwAdvice.TabIndex = 27;
            this.lvwAdvice.UseCompatibleStateImageBehavior = false;
            this.lvwAdvice.View = System.Windows.Forms.View.Details;
            // 
            // SN
            // 
            this.SN.Text = "SN";
            this.SN.Width = 30;
            // 
            // Advice
            // 
            this.Advice.Text = "Advice";
            this.Advice.Width = 260;
            // 
            // Medicine
            // 
            this.Medicine.Controls.Add(this.lvwMedicine);
            this.Medicine.Location = new System.Drawing.Point(11, 347);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(437, 172);
            this.Medicine.TabIndex = 30;
            this.Medicine.TabStop = false;
            this.Medicine.Text = "Medicine";
            // 
            // lvwMedicine
            // 
            this.lvwMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSN,
            this.MedicineName,
            this.DoseQuantity,
            this.Duration});
            this.lvwMedicine.FullRowSelect = true;
            this.lvwMedicine.GridLines = true;
            this.lvwMedicine.Location = new System.Drawing.Point(6, 16);
            this.lvwMedicine.Name = "lvwMedicine";
            this.lvwMedicine.Size = new System.Drawing.Size(425, 149);
            this.lvwMedicine.TabIndex = 0;
            this.lvwMedicine.UseCompatibleStateImageBehavior = false;
            this.lvwMedicine.View = System.Windows.Forms.View.Details;
            // 
            // MSN
            // 
            this.MSN.Text = "SN";
            this.MSN.Width = 37;
            // 
            // MedicineName
            // 
            this.MedicineName.Text = "Medicine Name";
            this.MedicineName.Width = 183;
            // 
            // DoseQuantity
            // 
            this.DoseQuantity.Text = "Dose Quantity";
            this.DoseQuantity.Width = 112;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 88;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.txtOPDRegNo);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtConsultant);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 142);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Info :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(96, 22);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(287, 20);
            this.txtPatientName.TabIndex = 29;
            // 
            // txtOPDRegNo
            // 
            this.txtOPDRegNo.Location = new System.Drawing.Point(96, 53);
            this.txtOPDRegNo.Name = "txtOPDRegNo";
            this.txtOPDRegNo.Size = new System.Drawing.Size(287, 20);
            this.txtOPDRegNo.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 82);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(287, 20);
            this.txtAddress.TabIndex = 27;
            // 
            // txtConsultant
            // 
            this.txtConsultant.Location = new System.Drawing.Point(96, 111);
            this.txtConsultant.Name = "txtConsultant";
            this.txtConsultant.Size = new System.Drawing.Size(287, 20);
            this.txtConsultant.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Consultant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "OPD Reg. No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Patient Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDuration);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnMedicineAdd);
            this.groupBox3.Controls.Add(this.txtDoseQuantity);
            this.groupBox3.Controls.Add(this.cmbMedicine);
            this.groupBox3.Controls.Add(this.cmbCatagory);
            this.groupBox3.Location = new System.Drawing.Point(12, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 150);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medication";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(84, 106);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(146, 20);
            this.txtDuration.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Duration :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Dose Quantity :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Medicine :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Catagory :";
            // 
            // btnMedicineAdd
            // 
            this.btnMedicineAdd.Location = new System.Drawing.Point(279, 102);
            this.btnMedicineAdd.Name = "btnMedicineAdd";
            this.btnMedicineAdd.Size = new System.Drawing.Size(68, 26);
            this.btnMedicineAdd.TabIndex = 29;
            this.btnMedicineAdd.Text = "Add";
            this.btnMedicineAdd.UseVisualStyleBackColor = true;
            this.btnMedicineAdd.Click += new System.EventHandler(this.btnMedicineAdd_Click);
            // 
            // txtDoseQuantity
            // 
            this.txtDoseQuantity.Location = new System.Drawing.Point(84, 72);
            this.txtDoseQuantity.Multiline = true;
            this.txtDoseQuantity.Name = "txtDoseQuantity";
            this.txtDoseQuantity.Size = new System.Drawing.Size(263, 28);
            this.txtDoseQuantity.TabIndex = 28;
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(84, 45);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(263, 21);
            this.cmbMedicine.TabIndex = 27;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(84, 18);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(121, 21);
            this.cmbCatagory.TabIndex = 26;
            this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbOTName);
            this.groupBox4.Controls.Add(this.txtOTProcedure);
            this.groupBox4.Location = new System.Drawing.Point(431, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 290);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OT Note";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(280, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "OT Name";
            // 
            // cmbOTName
            // 
            this.cmbOTName.FormattingEnabled = true;
            this.cmbOTName.Location = new System.Drawing.Point(15, 41);
            this.cmbOTName.Name = "cmbOTName";
            this.cmbOTName.Size = new System.Drawing.Size(252, 21);
            this.cmbOTName.TabIndex = 30;
            this.cmbOTName.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // txtOTProcedure
            // 
            this.txtOTProcedure.Location = new System.Drawing.Point(15, 74);
            this.txtOTProcedure.MaxLength = 500000;
            this.txtOTProcedure.Multiline = true;
            this.txtOTProcedure.Name = "txtOTProcedure";
            this.txtOTProcedure.Size = new System.Drawing.Size(319, 196);
            this.txtOTProcedure.TabIndex = 29;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPrint);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(11, 519);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(437, 58);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(61, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 32);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 30);
            this.button4.TabIndex = 19;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(14, 23);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(0, 13);
            this.lblPrescriptionID.TabIndex = 35;
            // 
            // FrmOPDDoctorTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 582);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOPDDoctorTreatment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FrmOPDDoctorTreatment";
            this.Load += new System.EventHandler(this.FrmOPDDoctorTreatment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Medicine.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAdvice;
        private System.Windows.Forms.Button btnAdviceAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwAdvice;
        private System.Windows.Forms.ColumnHeader SN;
        private System.Windows.Forms.ColumnHeader Advice;
        private System.Windows.Forms.GroupBox Medicine;
        private System.Windows.Forms.ListView lvwMedicine;
        private System.Windows.Forms.ColumnHeader MSN;
        private System.Windows.Forms.ColumnHeader MedicineName;
        private System.Windows.Forms.ColumnHeader DoseQuantity;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtOPDRegNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtConsultant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMedicineAdd;
        private System.Windows.Forms.TextBox txtDoseQuantity;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOTName;
        private System.Windows.Forms.TextBox txtOTProcedure;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPrescriptionID;
    }
}