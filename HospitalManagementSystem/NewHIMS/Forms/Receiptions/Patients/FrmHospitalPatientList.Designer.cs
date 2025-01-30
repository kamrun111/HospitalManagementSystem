namespace NewHIMS.Forms.Receiptions.Patients
{
    partial class FrmHospitalPatientList
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
            this.lvwpatientList = new System.Windows.Forms.ListView();
            this.patient_id = new System.Windows.Forms.ColumnHeader();
            this.Hospital_id = new System.Windows.Forms.ColumnHeader();
            this.AdRegNo = new System.Windows.Forms.ColumnHeader();
            this.Patient_type = new System.Windows.Forms.ColumnHeader();
            this.patient_name = new System.Windows.Forms.ColumnHeader();
            this.Mobile = new System.Windows.Forms.ColumnHeader();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rdoIPD = new System.Windows.Forms.RadioButton();
            this.rdoOPD = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(963, 33);
            this.label7.TabIndex = 106;
            this.label7.Text = "Patient List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwpatientList);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 357);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            // 
            // lvwpatientList
            // 
            this.lvwpatientList.BackColor = System.Drawing.Color.Silver;
            this.lvwpatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patient_id,
            this.Hospital_id,
            this.AdRegNo,
            this.Patient_type,
            this.patient_name,
            this.Mobile,
            this.Address});
            this.lvwpatientList.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwpatientList.FullRowSelect = true;
            this.lvwpatientList.GridLines = true;
            this.lvwpatientList.Location = new System.Drawing.Point(9, 14);
            this.lvwpatientList.Name = "lvwpatientList";
            this.lvwpatientList.Size = new System.Drawing.Size(906, 334);
            this.lvwpatientList.TabIndex = 96;
            this.lvwpatientList.UseCompatibleStateImageBehavior = false;
            this.lvwpatientList.View = System.Windows.Forms.View.Details;
            // 
            // patient_id
            // 
            this.patient_id.Text = "ID";
            this.patient_id.Width = 0;
            // 
            // Hospital_id
            // 
            this.Hospital_id.Text = "Hospital ID";
            this.Hospital_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hospital_id.Width = 80;
            // 
            // AdRegNo
            // 
            this.AdRegNo.Text = "Reg No";
            this.AdRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdRegNo.Width = 80;
            // 
            // Patient_type
            // 
            this.Patient_type.Text = "Pt Type";
            this.Patient_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Patient_type.Width = 70;
            // 
            // patient_name
            // 
            this.patient_name.Text = "Patient Name";
            this.patient_name.Width = 250;
            // 
            // Mobile
            // 
            this.Mobile.Text = "Mobile No";
            this.Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mobile.Width = 120;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.rdoIPD);
            this.groupBox2.Controls.Add(this.rdoOPD);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 67);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoad.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(785, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rdoIPD
            // 
            this.rdoIPD.AutoSize = true;
            this.rdoIPD.BackColor = System.Drawing.Color.Yellow;
            this.rdoIPD.Checked = true;
            this.rdoIPD.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIPD.Location = new System.Drawing.Point(636, 27);
            this.rdoIPD.Name = "rdoIPD";
            this.rdoIPD.Size = new System.Drawing.Size(84, 18);
            this.rdoIPD.TabIndex = 1;
            this.rdoIPD.TabStop = true;
            this.rdoIPD.Text = "IPD Patient";
            this.rdoIPD.UseVisualStyleBackColor = false;
            // 
            // rdoOPD
            // 
            this.rdoOPD.AutoSize = true;
            this.rdoOPD.BackColor = System.Drawing.Color.Yellow;
            this.rdoOPD.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOPD.Location = new System.Drawing.Point(517, 27);
            this.rdoOPD.Name = "rdoOPD";
            this.rdoOPD.Size = new System.Drawing.Size(88, 18);
            this.rdoOPD.TabIndex = 0;
            this.rdoOPD.Text = "OPD Patient";
            this.rdoOPD.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(12, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(924, 67);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(732, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(39, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(158, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Name / Mobile";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(342, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmHospitalPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(947, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHospitalPatientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Patient List";
            this.Load += new System.EventHandler(this.FrmHospitalPatientList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwpatientList;
        private System.Windows.Forms.ColumnHeader patient_id;
        private System.Windows.Forms.ColumnHeader Hospital_id;
        private System.Windows.Forms.ColumnHeader Patient_type;
        private System.Windows.Forms.ColumnHeader patient_name;
        private System.Windows.Forms.ColumnHeader Mobile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader AdRegNo;
        private System.Windows.Forms.RadioButton rdoIPD;
        private System.Windows.Forms.RadioButton rdoOPD;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}