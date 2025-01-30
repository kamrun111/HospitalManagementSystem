namespace NewHIMS.Forms.OPD_Patient
{
    partial class FrmOPDOT
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
            this.label3 = new System.Windows.Forms.Label();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.opdadmissionid = new System.Windows.Forms.ColumnHeader();
            this.RegID = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.doctor = new System.Windows.Forms.ColumnHeader();
            this.lblOTcharges = new System.Windows.Forms.Label();
            this.btnOt = new System.Windows.Forms.Button();
            this.lblOt = new System.Windows.Forms.Label();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnmedicine = new System.Windows.Forms.Button();
            this.lblInvestigation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpatient = new System.Windows.Forms.TextBox();
            this.txtregID = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(823, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "OPD OT Services";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.opdadmissionid,
            this.RegID,
            this.name,
            this.address,
            this.doctor});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(12, 32);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(202, 374);
            this.lvwPatientInfo.TabIndex = 16;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // opdadmissionid
            // 
            this.opdadmissionid.Text = "opdadmissionid";
            this.opdadmissionid.Width = 0;
            // 
            // RegID
            // 
            this.RegID.Text = "RegID";
            this.RegID.Width = 88;
            // 
            // name
            // 
            this.name.Text = "P.Name";
            this.name.Width = 119;
            // 
            // address
            // 
            this.address.Text = "address";
            // 
            // doctor
            // 
            this.doctor.Text = "doc";
            // 
            // lblOTcharges
            // 
            this.lblOTcharges.AutoSize = true;
            this.lblOTcharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTcharges.Location = new System.Drawing.Point(318, 366);
            this.lblOTcharges.Name = "lblOTcharges";
            this.lblOTcharges.Size = new System.Drawing.Size(72, 13);
            this.lblOTcharges.TabIndex = 94;
            this.lblOTcharges.Text = "Other Items";
            // 
            // btnOt
            // 
            this.btnOt.Location = new System.Drawing.Point(401, 305);
            this.btnOt.Name = "btnOt";
            this.btnOt.Size = new System.Drawing.Size(49, 23);
            this.btnOt.TabIndex = 93;
            this.btnOt.Text = "Details";
            this.btnOt.UseVisualStyleBackColor = true;
            this.btnOt.Click += new System.EventHandler(this.btnOt_Click);
            // 
            // lblOt
            // 
            this.lblOt.AutoSize = true;
            this.lblOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt.Location = new System.Drawing.Point(318, 262);
            this.lblOt.Name = "lblOt";
            this.lblOt.Size = new System.Drawing.Size(66, 15);
            this.lblOt.TabIndex = 92;
            this.lblOt.Text = "Medicine";
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(403, 361);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(49, 23);
            this.btnTreatment.TabIndex = 91;
            this.btnTreatment.Text = "Details";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnmedicine
            // 
            this.btnmedicine.Location = new System.Drawing.Point(401, 254);
            this.btnmedicine.Name = "btnmedicine";
            this.btnmedicine.Size = new System.Drawing.Size(49, 23);
            this.btnmedicine.TabIndex = 90;
            this.btnmedicine.Text = "Details";
            this.btnmedicine.UseVisualStyleBackColor = true;
            this.btnmedicine.Click += new System.EventHandler(this.btnmedicine_Click);
            // 
            // lblInvestigation
            // 
            this.lblInvestigation.AutoSize = true;
            this.lblInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigation.Location = new System.Drawing.Point(314, 305);
            this.lblInvestigation.Name = "lblInvestigation";
            this.lblInvestigation.Size = new System.Drawing.Size(70, 15);
            this.lblInvestigation.TabIndex = 89;
            this.lblInvestigation.Text = "Medicine ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 95;
            this.label1.Text = "Refund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "P. Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "RegAd.ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 98;
            this.label5.Text = "Consultant Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Address :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 100;
            this.button1.Text = "Medicine Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 101;
            this.button2.Text = "Other Item Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtpatient
            // 
            this.txtpatient.Location = new System.Drawing.Point(435, 67);
            this.txtpatient.Name = "txtpatient";
            this.txtpatient.Size = new System.Drawing.Size(200, 20);
            this.txtpatient.TabIndex = 102;
            // 
            // txtregID
            // 
            this.txtregID.Location = new System.Drawing.Point(435, 93);
            this.txtregID.Name = "txtregID";
            this.txtregID.Size = new System.Drawing.Size(200, 20);
            this.txtregID.TabIndex = 103;
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(435, 125);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(200, 20);
            this.txtdoc.TabIndex = 104;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(435, 156);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 20);
            this.txtaddress.TabIndex = 105;
            // 
            // FrmOPDOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.txtregID);
            this.Controls.Add(this.txtpatient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOTcharges);
            this.Controls.Add(this.btnOt);
            this.Controls.Add(this.lblOt);
            this.Controls.Add(this.btnTreatment);
            this.Controls.Add(this.btnmedicine);
            this.Controls.Add(this.lblInvestigation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvwPatientInfo);
            this.Name = "FrmOPDOT";
            this.Text = "OPD  OT Services";
            this.Load += new System.EventHandler(this.FrmOPDOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.Label lblOTcharges;
        private System.Windows.Forms.Button btnOt;
        private System.Windows.Forms.Label lblOt;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnmedicine;
        private System.Windows.Forms.Label lblInvestigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader opdadmissionid;
        private System.Windows.Forms.ColumnHeader RegID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader doctor;
        private System.Windows.Forms.TextBox txtpatient;
        private System.Windows.Forms.TextBox txtregID;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.TextBox txtaddress;
    }
}