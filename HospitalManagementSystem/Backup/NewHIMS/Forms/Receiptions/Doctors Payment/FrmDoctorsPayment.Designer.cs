namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    partial class FrmDoctorsPayment
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
            this.txtrefdoctor = new System.Windows.Forms.TextBox();
            this.btnfinalbill = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtgurdianName = new System.Windows.Forms.TextBox();
            this.txtadmissiondate = new System.Windows.Forms.TextBox();
            this.txtadmissioncode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdischargedate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.grddoctorspayment = new System.Windows.Forms.DataGridView();
            this.refered_doctors_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgery_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reducevisitamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansthesia_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistance_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_details_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.cmbrefdoctor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Ref. Doctor";
            // 
            // txtrefdoctor
            // 
            this.txtrefdoctor.Location = new System.Drawing.Point(85, 151);
            this.txtrefdoctor.Name = "txtrefdoctor";
            this.txtrefdoctor.Size = new System.Drawing.Size(242, 20);
            this.txtrefdoctor.TabIndex = 68;
            // 
            // btnfinalbill
            // 
            this.btnfinalbill.Enabled = false;
            this.btnfinalbill.Location = new System.Drawing.Point(592, 209);
            this.btnfinalbill.Name = "btnfinalbill";
            this.btnfinalbill.Size = new System.Drawing.Size(78, 25);
            this.btnfinalbill.TabIndex = 62;
            this.btnfinalbill.Text = "Final Bill";
            this.btnfinalbill.UseVisualStyleBackColor = true;
            this.btnfinalbill.Click += new System.EventHandler(this.btnfinalbill_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(535, 483);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "Total Taka";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(612, 480);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(92, 20);
            this.txtTotal.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(133, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Ad. Reg. ID";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Goldenrod;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(2, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(720, 30);
            this.label15.TabIndex = 64;
            this.label15.Text = "DOCTOR\'S BILL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkOrange;
            this.label14.Location = new System.Drawing.Point(279, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 20);
            this.label14.TabIndex = 63;
            this.label14.Text = "DOCTOR\'S BILL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = " Doctor";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 60;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(85, 98);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(242, 20);
            this.txtpatientname.TabIndex = 49;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(391, 59);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(302, 22);
            this.txtaddress.TabIndex = 48;
            // 
            // txtgurdianName
            // 
            this.txtgurdianName.Location = new System.Drawing.Point(85, 125);
            this.txtgurdianName.Name = "txtgurdianName";
            this.txtgurdianName.Size = new System.Drawing.Size(242, 20);
            this.txtgurdianName.TabIndex = 47;
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Location = new System.Drawing.Point(503, 89);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(188, 22);
            this.txtadmissiondate.TabIndex = 46;
            // 
            // txtadmissioncode
            // 
            this.txtadmissioncode.Location = new System.Drawing.Point(211, 60);
            this.txtadmissioncode.Name = "txtadmissioncode";
            this.txtadmissioncode.Size = new System.Drawing.Size(151, 20);
            this.txtadmissioncode.TabIndex = 45;
            this.txtadmissioncode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtadmissioncode_KeyUp);
            this.txtadmissioncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadmissioncode_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtdischargedate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtadmissiondate);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(6, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 148);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Discharged Date";
            // 
            // txtdischargedate
            // 
            this.txtdischargedate.Location = new System.Drawing.Point(503, 119);
            this.txtdischargedate.Name = "txtdischargedate";
            this.txtdischargedate.Size = new System.Drawing.Size(188, 22);
            this.txtdischargedate.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Addmission Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "G.Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "P.Name";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(375, 21);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 56;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(344, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(393, 502);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 58;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(312, 502);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 57;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // grddoctorspayment
            // 
            this.grddoctorspayment.AllowUserToAddRows = false;
            this.grddoctorspayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddoctorspayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refered_doctors_id,
            this.Column1,
            this.surgery_charge,
            this.Column2,
            this.visit_charge,
            this.Column4,
            this.reducevisitamount,
            this.ansthesia_charge,
            this.assistance_charge,
            this.total_amount,
            this.payment_details_id});
            this.grddoctorspayment.Location = new System.Drawing.Point(9, 286);
            this.grddoctorspayment.Name = "grddoctorspayment";
            this.grddoctorspayment.Size = new System.Drawing.Size(696, 183);
            this.grddoctorspayment.TabIndex = 55;
            this.grddoctorspayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellValueChanged);
            // 
            // refered_doctors_id
            // 
            this.refered_doctors_id.HeaderText = "refered_doctors_id";
            this.refered_doctors_id.Name = "refered_doctors_id";
            this.refered_doctors_id.ReadOnly = true;
            this.refered_doctors_id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Doctor\'s Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // surgery_charge
            // 
            this.surgery_charge.HeaderText = "Surgery Charge ";
            this.surgery_charge.Name = "surgery_charge";
            this.surgery_charge.Width = 55;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Visit Oty";
            this.Column2.Name = "Column2";
            this.Column2.Width = 45;
            // 
            // visit_charge
            // 
            this.visit_charge.HeaderText = "Total Visit Charge";
            this.visit_charge.Name = "visit_charge";
            this.visit_charge.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Reduce Visit Qty";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // reducevisitamount
            // 
            this.reducevisitamount.HeaderText = "Reduce Visit Amount";
            this.reducevisitamount.Name = "reducevisitamount";
            this.reducevisitamount.Width = 50;
            // 
            // ansthesia_charge
            // 
            this.ansthesia_charge.HeaderText = "Ansthesia Charge";
            this.ansthesia_charge.Name = "ansthesia_charge";
            this.ansthesia_charge.Width = 50;
            // 
            // assistance_charge
            // 
            this.assistance_charge.HeaderText = "Assistance Charge";
            this.assistance_charge.Name = "assistance_charge";
            this.assistance_charge.Width = 50;
            // 
            // total_amount
            // 
            this.total_amount.HeaderText = "Total Amount";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            this.total_amount.Width = 70;
            // 
            // payment_details_id
            // 
            this.payment_details_id.HeaderText = "payment_details_id";
            this.payment_details_id.Name = "payment_details_id";
            this.payment_details_id.ReadOnly = true;
            this.payment_details_id.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "G. Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "P. Name";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(222, 502);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 71;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cmbrefdoctor
            // 
            this.cmbrefdoctor.FormattingEnabled = true;
            this.cmbrefdoctor.Location = new System.Drawing.Point(85, 209);
            this.cmbrefdoctor.Name = "cmbrefdoctor";
            this.cmbrefdoctor.Size = new System.Drawing.Size(242, 21);
            this.cmbrefdoctor.TabIndex = 72;
            // 
            // FrmDoctorsPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 558);
            this.Controls.Add(this.cmbrefdoctor);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtrefdoctor);
            this.Controls.Add(this.btnfinalbill);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.txtgurdianName);
            this.Controls.Add(this.txtadmissioncode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grddoctorspayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoctorsPayment";
            this.Text = "Doctros Payment Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddoctorspayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrefdoctor;
        private System.Windows.Forms.Button btnfinalbill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtgurdianName;
        private System.Windows.Forms.TextBox txtadmissiondate;
        private System.Windows.Forms.TextBox txtadmissioncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView grddoctorspayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdischargedate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmbrefdoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn refered_doctors_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgery_charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn reducevisitamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansthesia_charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistance_charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_details_id;
    }
}