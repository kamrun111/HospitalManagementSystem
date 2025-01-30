namespace NewHIMS.Forms.ICU
{
    partial class FrmICUOTInformation
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
            this.label15 = new System.Windows.Forms.Label();
            this.grdPatientOT = new System.Windows.Forms.DataGridView();
            this.ot_information_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admission_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaesthesia_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blood_Transfusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baby_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Others = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpatientcode = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtadmissiondate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcabinNo = new System.Windows.Forms.TextBox();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.txtpatientage = new System.Windows.Forms.TextBox();
            this.txtadmissioncode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpOtDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtOtReg = new System.Windows.Forms.TextBox();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFinishTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtBabyNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnaesthesiaType = new System.Windows.Forms.TextBox();
            this.txtBloodTransfusion = new System.Windows.Forms.TextBox();
            this.txtOTName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientOT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-4, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(970, 30);
            this.label15.TabIndex = 165;
            this.label15.Text = "OT Information (ICU/CCU)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdPatientOT
            // 
            this.grdPatientOT.AllowUserToAddRows = false;
            this.grdPatientOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatientOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ot_information_id,
            this.admission_id,
            this.ot_reg,
            this.ot_name,
            this.ot_date,
            this.start_time,
            this.finish_time,
            this.anaesthesia_type,
            this.Blood_Transfusion,
            this.baby_note,
            this.Others});
            this.grdPatientOT.Location = new System.Drawing.Point(8, 379);
            this.grdPatientOT.Name = "grdPatientOT";
            this.grdPatientOT.Size = new System.Drawing.Size(943, 163);
            this.grdPatientOT.TabIndex = 167;
            this.grdPatientOT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatientOT_CellClick);
            // 
            // ot_information_id
            // 
            this.ot_information_id.HeaderText = "ot_information_id";
            this.ot_information_id.Name = "ot_information_id";
            this.ot_information_id.ReadOnly = true;
            this.ot_information_id.Visible = false;
            // 
            // admission_id
            // 
            this.admission_id.HeaderText = "admission_id";
            this.admission_id.Name = "admission_id";
            this.admission_id.Visible = false;
            // 
            // ot_reg
            // 
            this.ot_reg.HeaderText = "OT Reg";
            this.ot_reg.Name = "ot_reg";
            this.ot_reg.Width = 70;
            // 
            // ot_name
            // 
            this.ot_name.HeaderText = "OT Name";
            this.ot_name.Name = "ot_name";
            this.ot_name.Width = 150;
            // 
            // ot_date
            // 
            this.ot_date.HeaderText = "OT Date";
            this.ot_date.Name = "ot_date";
            this.ot_date.Visible = false;
            // 
            // start_time
            // 
            this.start_time.HeaderText = "Start";
            this.start_time.Name = "start_time";
            this.start_time.Width = 50;
            // 
            // finish_time
            // 
            this.finish_time.HeaderText = "Finish ";
            this.finish_time.Name = "finish_time";
            this.finish_time.Width = 50;
            // 
            // anaesthesia_type
            // 
            this.anaesthesia_type.HeaderText = "Anaesthesia Type";
            this.anaesthesia_type.Name = "anaesthesia_type";
            // 
            // Blood_Transfusion
            // 
            this.Blood_Transfusion.HeaderText = "Blood Transfusion";
            this.Blood_Transfusion.Name = "Blood_Transfusion";
            this.Blood_Transfusion.Width = 230;
            // 
            // baby_note
            // 
            this.baby_note.HeaderText = "Baby Note";
            this.baby_note.Name = "baby_note";
            // 
            // Others
            // 
            this.Others.HeaderText = "Others";
            this.Others.Name = "Others";
            this.Others.Width = 240;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpatientcode);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtadmissiondate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtcabinNo);
            this.groupBox1.Controls.Add(this.txtpatientname);
            this.groupBox1.Controls.Add(this.txtpatientage);
            this.groupBox1.Controls.Add(this.txtadmissioncode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(8, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 91);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 164;
            this.label1.Text = "Hospital ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 165;
            this.label2.Text = "Cabin No";
            // 
            // txtpatientcode
            // 
            this.txtpatientcode.Enabled = false;
            this.txtpatientcode.Location = new System.Drawing.Point(434, 24);
            this.txtpatientcode.Name = "txtpatientcode";
            this.txtpatientcode.Size = new System.Drawing.Size(125, 22);
            this.txtpatientcode.TabIndex = 163;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(584, 27);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(69, 15);
            this.lblage.TabIndex = 160;
            this.lblage.Text = "Patient Age";
            // 
            // txtadmissiondate
            // 
            this.txtadmissiondate.Enabled = false;
            this.txtadmissiondate.Location = new System.Drawing.Point(118, 54);
            this.txtadmissiondate.Name = "txtadmissiondate";
            this.txtadmissiondate.Size = new System.Drawing.Size(215, 22);
            this.txtadmissiondate.TabIndex = 159;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(360, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 158;
            this.label13.Text = "Ad. Reg. ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 161;
            this.label5.Text = "Patient Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 162;
            this.label10.Text = "Admission Date";
            // 
            // txtcabinNo
            // 
            this.txtcabinNo.Enabled = false;
            this.txtcabinNo.Location = new System.Drawing.Point(659, 58);
            this.txtcabinNo.Name = "txtcabinNo";
            this.txtcabinNo.Size = new System.Drawing.Size(215, 22);
            this.txtcabinNo.TabIndex = 155;
            // 
            // txtpatientname
            // 
            this.txtpatientname.Enabled = false;
            this.txtpatientname.Location = new System.Drawing.Point(118, 24);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(215, 22);
            this.txtpatientname.TabIndex = 157;
            // 
            // txtpatientage
            // 
            this.txtpatientage.Enabled = false;
            this.txtpatientage.Location = new System.Drawing.Point(659, 24);
            this.txtpatientage.Name = "txtpatientage";
            this.txtpatientage.Size = new System.Drawing.Size(215, 22);
            this.txtpatientage.TabIndex = 156;
            // 
            // txtadmissioncode
            // 
            this.txtadmissioncode.Enabled = false;
            this.txtadmissioncode.Location = new System.Drawing.Point(434, 54);
            this.txtadmissioncode.Name = "txtadmissioncode";
            this.txtadmissioncode.Size = new System.Drawing.Size(125, 22);
            this.txtadmissioncode.TabIndex = 154;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.dtpOtDate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtOtReg);
            this.groupBox2.Controls.Add(this.txtOthers);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFinishTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtStartTime);
            this.groupBox2.Controls.Add(this.txtBabyNote);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAnaesthesiaType);
            this.groupBox2.Controls.Add(this.txtBloodTransfusion);
            this.groupBox2.Controls.Add(this.txtOTName);
            this.groupBox2.Location = new System.Drawing.Point(8, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 229);
            this.groupBox2.TabIndex = 168;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(735, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 27);
            this.btnClose.TabIndex = 166;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtpOtDate
            // 
            this.dtpOtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOtDate.Location = new System.Drawing.Point(118, 54);
            this.dtpOtDate.Name = "dtpOtDate";
            this.dtpOtDate.Size = new System.Drawing.Size(163, 20);
            this.dtpOtDate.TabIndex = 165;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(59, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 164;
            this.label14.Text = "OT Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 162;
            this.label3.Text = "OT Reg. Number";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(840, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 27);
            this.btnAdd.TabIndex = 163;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtOtReg
            // 
            this.txtOtReg.Enabled = false;
            this.txtOtReg.Location = new System.Drawing.Point(118, 16);
            this.txtOtReg.Name = "txtOtReg";
            this.txtOtReg.Size = new System.Drawing.Size(163, 20);
            this.txtOtReg.TabIndex = 159;
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(376, 107);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(316, 103);
            this.txtOthers.TabIndex = 159;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gold;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(376, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 162;
            this.label12.Text = "Others";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 162;
            this.label6.Text = "OT Name";
            // 
            // txtFinishTime
            // 
            this.txtFinishTime.Location = new System.Drawing.Point(553, 61);
            this.txtFinishTime.Name = "txtFinishTime";
            this.txtFinishTime.Size = new System.Drawing.Size(65, 20);
            this.txtFinishTime.TabIndex = 159;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 162;
            this.label8.Text = "Finish Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(705, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 162;
            this.label11.Text = "Baby Note";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(379, 58);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(65, 20);
            this.txtStartTime.TabIndex = 159;
            // 
            // txtBabyNote
            // 
            this.txtBabyNote.Location = new System.Drawing.Point(703, 107);
            this.txtBabyNote.Multiline = true;
            this.txtBabyNote.Name = "txtBabyNote";
            this.txtBabyNote.Size = new System.Drawing.Size(221, 71);
            this.txtBabyNote.TabIndex = 159;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 162;
            this.label9.Text = "Blood Transfusion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 162;
            this.label7.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 162;
            this.label4.Text = "Anaesthesia Type";
            // 
            // txtAnaesthesiaType
            // 
            this.txtAnaesthesiaType.Location = new System.Drawing.Point(735, 19);
            this.txtAnaesthesiaType.Name = "txtAnaesthesiaType";
            this.txtAnaesthesiaType.Size = new System.Drawing.Size(189, 20);
            this.txtAnaesthesiaType.TabIndex = 159;
            // 
            // txtBloodTransfusion
            // 
            this.txtBloodTransfusion.Location = new System.Drawing.Point(16, 107);
            this.txtBloodTransfusion.Multiline = true;
            this.txtBloodTransfusion.Name = "txtBloodTransfusion";
            this.txtBloodTransfusion.Size = new System.Drawing.Size(349, 103);
            this.txtBloodTransfusion.TabIndex = 159;
            // 
            // txtOTName
            // 
            this.txtOTName.Location = new System.Drawing.Point(376, 18);
            this.txtOTName.Name = "txtOTName";
            this.txtOTName.Size = new System.Drawing.Size(226, 20);
            this.txtOTName.TabIndex = 159;
            // 
            // FrmICUOTInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(959, 558);
            this.Controls.Add(this.grdPatientOT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmICUOTInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICU OT Information";
            this.Load += new System.EventHandler(this.FrmICUOTInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientOT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView grdPatientOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_information_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn anaesthesia_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blood_Transfusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn baby_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Others;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpatientcode;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtadmissiondate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcabinNo;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.TextBox txtpatientage;
        private System.Windows.Forms.TextBox txtadmissioncode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpOtDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOtReg;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFinishTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtBabyNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnaesthesiaType;
        private System.Windows.Forms.TextBox txtBloodTransfusion;
        private System.Windows.Forms.TextBox txtOTName;
    }
}