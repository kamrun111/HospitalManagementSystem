namespace NewHIMS.Forms.Receiptions.Patients
{
    partial class FrmPatientRefDoctor
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRefDoctor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwRefDoctorList = new System.Windows.Forms.ListView();
            this.patient_reffered_doctors_id = new System.Windows.Forms.ColumnHeader();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.admission_date = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.c_phone = new System.Windows.Forms.ColumnHeader();
            this.reffered_doctors = new System.Windows.Forms.ColumnHeader();
            this.is_cancel = new System.Windows.Forms.ColumnHeader();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.reffered_doctors_id = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCabin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(-3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(463, 31);
            this.label7.TabIndex = 145;
            this.label7.Text = "Patient Ref. Doctor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbRefDoctor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.txtAdmissionID);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 341);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reff. Doctor";
            // 
            // cmbRefDoctor
            // 
            this.cmbRefDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRefDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefDoctor.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRefDoctor.FormattingEnabled = true;
            this.cmbRefDoctor.Location = new System.Drawing.Point(113, 138);
            this.cmbRefDoctor.Name = "cmbRefDoctor";
            this.cmbRefDoctor.Size = new System.Drawing.Size(320, 22);
            this.cmbRefDoctor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admission ID";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoad.Location = new System.Drawing.Point(255, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 25);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmissionID.Location = new System.Drawing.Point(113, 15);
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.Size = new System.Drawing.Size(116, 23);
            this.txtAdmissionID.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(6, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 56);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(317, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(173, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(26, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwRefDoctorList);
            this.groupBox3.Location = new System.Drawing.Point(6, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 114);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lvwRefDoctorList
            // 
            this.lvwRefDoctorList.BackColor = System.Drawing.Color.Silver;
            this.lvwRefDoctorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patient_reffered_doctors_id,
            this.admission_code,
            this.admission_date,
            this.patient_name,
            this.c_phone,
            this.reffered_doctors,
            this.is_cancel,
            this.cabin,
            this.patient_code,
            this.reffered_doctors_id,
            this.admission_id});
            this.lvwRefDoctorList.FullRowSelect = true;
            this.lvwRefDoctorList.GridLines = true;
            this.lvwRefDoctorList.HideSelection = false;
            this.lvwRefDoctorList.Location = new System.Drawing.Point(6, 15);
            this.lvwRefDoctorList.MultiSelect = false;
            this.lvwRefDoctorList.Name = "lvwRefDoctorList";
            this.lvwRefDoctorList.Size = new System.Drawing.Size(421, 89);
            this.lvwRefDoctorList.TabIndex = 0;
            this.lvwRefDoctorList.UseCompatibleStateImageBehavior = false;
            this.lvwRefDoctorList.View = System.Windows.Forms.View.Details;
            this.lvwRefDoctorList.Click += new System.EventHandler(this.lvwRefDoctorList_Click);
            // 
            // patient_reffered_doctors_id
            // 
            this.patient_reffered_doctors_id.Text = "ID";
            this.patient_reffered_doctors_id.Width = 0;
            // 
            // admission_code
            // 
            this.admission_code.Text = "Admission ID";
            this.admission_code.Width = 90;
            // 
            // admission_date
            // 
            this.admission_date.Text = "Admission Date";
            this.admission_date.Width = 0;
            // 
            // patient_name
            // 
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 0;
            // 
            // c_phone
            // 
            this.c_phone.Text = "Phone";
            this.c_phone.Width = 0;
            // 
            // reffered_doctors
            // 
            this.reffered_doctors.Text = "Doctor";
            this.reffered_doctors.Width = 250;
            // 
            // is_cancel
            // 
            this.is_cancel.Text = "Status";
            this.is_cancel.Width = 0;
            // 
            // cabin
            // 
            this.cabin.Text = "Cabin";
            this.cabin.Width = 0;
            // 
            // patient_code
            // 
            this.patient_code.Text = "Patient ID";
            this.patient_code.Width = 0;
            // 
            // reffered_doctors_id
            // 
            this.reffered_doctors_id.Text = "Doctor ID";
            this.reffered_doctors_id.Width = 0;
            // 
            // admission_id
            // 
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCabin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtContactNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Location = new System.Drawing.Point(6, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cabin No";
            // 
            // txtCabin
            // 
            this.txtCabin.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabin.Location = new System.Drawing.Point(311, 51);
            this.txtCabin.Name = "txtCabin";
            this.txtCabin.Size = new System.Drawing.Size(116, 22);
            this.txtCabin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(107, 51);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(116, 22);
            this.txtContactNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(107, 16);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(320, 22);
            this.txtPatientName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(361, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(68, 23);
            this.txtID.TabIndex = 7;
            this.txtID.Visible = false;
            // 
            // FrmPatientRefDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(457, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientRefDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Ref. Doctor";
            this.Load += new System.EventHandler(this.FrmPatientRefDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvwRefDoctorList;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCabin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRefDoctor;
        private System.Windows.Forms.ColumnHeader patient_reffered_doctors_id;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.ColumnHeader admission_date;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader c_phone;
        private System.Windows.Forms.ColumnHeader reffered_doctors;
        private System.Windows.Forms.ColumnHeader is_cancel;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader reffered_doctors_id;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.TextBox txtID;
    }
}