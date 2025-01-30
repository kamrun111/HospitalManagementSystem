namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    partial class frmOPDDoctorStation
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
            this.lvwPatientList = new System.Windows.Forms.ListView();
            this.RegID = new System.Windows.Forms.ColumnHeader();
            this.PName = new System.Windows.Forms.ColumnHeader();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.PrescriptionID = new System.Windows.Forms.ColumnHeader();
            this.CC = new System.Windows.Forms.ColumnHeader();
            this.CF = new System.Windows.Forms.ColumnHeader();
            this.IsDischarged = new System.Windows.Forms.ColumnHeader();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblRegADID = new System.Windows.Forms.Label();
            this.lblConsultantName = new System.Windows.Forms.Label();
            this.lblPAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwPatientList
            // 
            this.lvwPatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RegID,
            this.PName,
            this.Address,
            this.PrescriptionID,
            this.CC,
            this.CF,
            this.IsDischarged});
            this.lvwPatientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientList.FullRowSelect = true;
            this.lvwPatientList.GridLines = true;
            this.lvwPatientList.Location = new System.Drawing.Point(11, 137);
            this.lvwPatientList.Name = "lvwPatientList";
            this.lvwPatientList.Size = new System.Drawing.Size(173, 380);
            this.lvwPatientList.TabIndex = 0;
            this.lvwPatientList.UseCompatibleStateImageBehavior = false;
            this.lvwPatientList.View = System.Windows.Forms.View.Details;
            this.lvwPatientList.Click += new System.EventHandler(this.lvwPatientList_Click);
            // 
            // RegID
            // 
            this.RegID.Text = "Reg: ID";
            // 
            // PName
            // 
            this.PName.Text = "Name";
            this.PName.Width = 104;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.Text = "PrescriptionID";
            // 
            // CC
            // 
            this.CC.Text = "CC";
            // 
            // CF
            // 
            this.CF.Text = "CF";
            // 
            // IsDischarged
            // 
            this.IsDischarged.Text = "IsDischarged";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(212, 282);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(362, 65);
            this.txtCC.TabIndex = 1;
            this.txtCC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient\'s Chief Complain :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-136, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(823, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "OPD Doctor Station";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Patient List :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(404, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 103;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 102;
            this.label5.Text = "Consultant Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 101;
            this.label4.Text = "RegAd.ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Patient Name :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Magenta;
            this.linkLabel1.Location = new System.Drawing.Point(179, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 16);
            this.linkLabel1.TabIndex = 104;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "OPD Patient Treatment";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(212, 400);
            this.txtPF.Multiline = true;
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(362, 60);
            this.txtPF.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 106;
            this.label8.Text = "Patient\'s Diagnosis :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 107;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 108;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Magenta;
            this.linkLabel2.Location = new System.Drawing.Point(22, 55);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(136, 16);
            this.linkLabel2.TabIndex = 109;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "OPD Patient\'s History";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Magenta;
            this.linkLabel3.Location = new System.Drawing.Point(350, 55);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(140, 16);
            this.linkLabel3.TabIndex = 110;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Previous OPD Patient ";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(313, 139);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 13);
            this.lblPatientName.TabIndex = 111;
            // 
            // lblRegADID
            // 
            this.lblRegADID.AutoSize = true;
            this.lblRegADID.Location = new System.Drawing.Point(285, 163);
            this.lblRegADID.Name = "lblRegADID";
            this.lblRegADID.Size = new System.Drawing.Size(0, 13);
            this.lblRegADID.TabIndex = 112;
            // 
            // lblConsultantName
            // 
            this.lblConsultantName.AutoSize = true;
            this.lblConsultantName.Location = new System.Drawing.Point(335, 195);
            this.lblConsultantName.Name = "lblConsultantName";
            this.lblConsultantName.Size = new System.Drawing.Size(0, 13);
            this.lblConsultantName.TabIndex = 113;
            // 
            // lblPAddress
            // 
            this.lblPAddress.AutoSize = true;
            this.lblPAddress.Location = new System.Drawing.Point(285, 220);
            this.lblPAddress.Name = "lblPAddress";
            this.lblPAddress.Size = new System.Drawing.Size(0, 13);
            this.lblPAddress.TabIndex = 114;
            // 
            // frmOPDDoctorStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 530);
            this.Controls.Add(this.lblPAddress);
            this.Controls.Add(this.lblConsultantName);
            this.Controls.Add(this.lblRegADID);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lvwPatientList);
            this.Name = "frmOPDDoctorStation";
            this.Text = "OPDDoctorStation";
            this.Load += new System.EventHandler(this.FrmOPDDoctorStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPatientList;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ColumnHeader RegID;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader PrescriptionID;
        private System.Windows.Forms.ColumnHeader CC;
        private System.Windows.Forms.ColumnHeader CF;
        private System.Windows.Forms.ColumnHeader IsDischarged;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblRegADID;
        private System.Windows.Forms.Label lblConsultantName;
        private System.Windows.Forms.Label lblPAddress;
    }
}