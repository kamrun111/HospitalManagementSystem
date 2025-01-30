namespace NewHIMS.Forms.Receiptions.Patients
{
    partial class FrmPatientSearch
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
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoIDcard = new System.Windows.Forms.RadioButton();
            this.rdoServices = new System.Windows.Forms.RadioButton();
            this.rdoConsultation = new System.Windows.Forms.RadioButton();
            this.rdoInvestigation = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpSearchOption = new System.Windows.Forms.GroupBox();
            this.rdoPatientID = new System.Windows.Forms.RadioButton();
            this.radioMobileNo = new System.Windows.Forms.RadioButton();
            this.radioPatientName = new System.Windows.Forms.RadioButton();
            this.radioByAddress = new System.Windows.Forms.RadioButton();
            this.lvwpatientSearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPatient.SuspendLayout();
            this.grpSearchOption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpPatient.Controls.Add(this.label1);
            this.grpPatient.Controls.Add(this.txtName);
            this.grpPatient.Controls.Add(this.rdoIDcard);
            this.grpPatient.Controls.Add(this.rdoServices);
            this.grpPatient.Controls.Add(this.rdoConsultation);
            this.grpPatient.Controls.Add(this.rdoInvestigation);
            this.grpPatient.Controls.Add(this.btnPrint);
            this.grpPatient.Controls.Add(this.btnRefresh);
            this.grpPatient.Controls.Add(this.grpSearchOption);
            this.grpPatient.Controls.Add(this.lvwpatientSearch);
            this.grpPatient.Controls.Add(this.lblSearchBy);
            this.grpPatient.Controls.Add(this.txtSearchBy);
            this.grpPatient.Controls.Add(this.btnClose);
            this.grpPatient.Controls.Add(this.groupBox1);
            this.grpPatient.Controls.Add(this.groupBox2);
            this.grpPatient.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatient.ForeColor = System.Drawing.Color.Black;
            this.grpPatient.Location = new System.Drawing.Point(12, 50);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(925, 550);
            this.grpPatient.TabIndex = 1;
            this.grpPatient.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(44, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 115;
            this.label1.Text = "Patient ID";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(116, 289);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 23);
            this.txtName.TabIndex = 113;
            this.txtName.Tag = "admission_code";
            // 
            // rdoIDcard
            // 
            this.rdoIDcard.AutoSize = true;
            this.rdoIDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIDcard.ForeColor = System.Drawing.Color.OrangeRed;
            this.rdoIDcard.Location = new System.Drawing.Point(42, 460);
            this.rdoIDcard.Name = "rdoIDcard";
            this.rdoIDcard.Size = new System.Drawing.Size(166, 28);
            this.rdoIDcard.TabIndex = 112;
            this.rdoIDcard.Text = "Patient ID Card";
            this.rdoIDcard.UseVisualStyleBackColor = true;
            this.rdoIDcard.MouseEnter += new System.EventHandler(this.rdoIDcard_MouseEnter);
            this.rdoIDcard.CheckedChanged += new System.EventHandler(this.rdoInvestigation_CheckedChanged);
            // 
            // rdoServices
            // 
            this.rdoServices.AutoSize = true;
            this.rdoServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoServices.ForeColor = System.Drawing.Color.OrangeRed;
            this.rdoServices.Location = new System.Drawing.Point(42, 430);
            this.rdoServices.Name = "rdoServices";
            this.rdoServices.Size = new System.Drawing.Size(174, 28);
            this.rdoServices.TabIndex = 111;
            this.rdoServices.Text = "Health Services";
            this.rdoServices.UseVisualStyleBackColor = true;
            this.rdoServices.MouseEnter += new System.EventHandler(this.rdoIDcard_MouseEnter);
            this.rdoServices.CheckedChanged += new System.EventHandler(this.rdoInvestigation_CheckedChanged);
            // 
            // rdoConsultation
            // 
            this.rdoConsultation.AutoSize = true;
            this.rdoConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoConsultation.ForeColor = System.Drawing.Color.OrangeRed;
            this.rdoConsultation.Location = new System.Drawing.Point(42, 400);
            this.rdoConsultation.Name = "rdoConsultation";
            this.rdoConsultation.Size = new System.Drawing.Size(143, 28);
            this.rdoConsultation.TabIndex = 110;
            this.rdoConsultation.Text = "Consultation";
            this.rdoConsultation.UseVisualStyleBackColor = true;
            this.rdoConsultation.MouseEnter += new System.EventHandler(this.rdoIDcard_MouseEnter);
            this.rdoConsultation.CheckedChanged += new System.EventHandler(this.rdoInvestigation_CheckedChanged);
            // 
            // rdoInvestigation
            // 
            this.rdoInvestigation.AutoSize = true;
            this.rdoInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInvestigation.ForeColor = System.Drawing.Color.OrangeRed;
            this.rdoInvestigation.Location = new System.Drawing.Point(42, 370);
            this.rdoInvestigation.Name = "rdoInvestigation";
            this.rdoInvestigation.Size = new System.Drawing.Size(144, 28);
            this.rdoInvestigation.TabIndex = 103;
            this.rdoInvestigation.Text = "Investigation";
            this.rdoInvestigation.UseVisualStyleBackColor = true;
            this.rdoInvestigation.MouseEnter += new System.EventHandler(this.rdoIDcard_MouseEnter);
            this.rdoInvestigation.CheckedChanged += new System.EventHandler(this.rdoInvestigation_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(614, 515);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 28);
            this.btnPrint.TabIndex = 109;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(711, 515);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 104;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpSearchOption
            // 
            this.grpSearchOption.Controls.Add(this.rdoPatientID);
            this.grpSearchOption.Controls.Add(this.radioMobileNo);
            this.grpSearchOption.Controls.Add(this.radioPatientName);
            this.grpSearchOption.Controls.Add(this.radioByAddress);
            this.grpSearchOption.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchOption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpSearchOption.Location = new System.Drawing.Point(33, 22);
            this.grpSearchOption.Name = "grpSearchOption";
            this.grpSearchOption.Size = new System.Drawing.Size(238, 138);
            this.grpSearchOption.TabIndex = 97;
            this.grpSearchOption.TabStop = false;
            this.grpSearchOption.Text = "Search Options";
            // 
            // rdoPatientID
            // 
            this.rdoPatientID.AutoSize = true;
            this.rdoPatientID.Checked = true;
            this.rdoPatientID.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPatientID.Location = new System.Drawing.Point(33, 31);
            this.rdoPatientID.Name = "rdoPatientID";
            this.rdoPatientID.Size = new System.Drawing.Size(124, 23);
            this.rdoPatientID.TabIndex = 102;
            this.rdoPatientID.TabStop = true;
            this.rdoPatientID.Text = "By Patient ID.";
            this.rdoPatientID.UseVisualStyleBackColor = true;
            this.rdoPatientID.CheckedChanged += new System.EventHandler(this.rdoPatientID_CheckedChanged);
            // 
            // radioMobileNo
            // 
            this.radioMobileNo.AutoSize = true;
            this.radioMobileNo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMobileNo.Location = new System.Drawing.Point(33, 80);
            this.radioMobileNo.Name = "radioMobileNo";
            this.radioMobileNo.Size = new System.Drawing.Size(132, 23);
            this.radioMobileNo.TabIndex = 98;
            this.radioMobileNo.Text = "By Mobile No.";
            this.radioMobileNo.UseVisualStyleBackColor = true;
            this.radioMobileNo.Click += new System.EventHandler(this.radioByHospitalID_Click);
            this.radioMobileNo.CheckedChanged += new System.EventHandler(this.rdoPatientID_CheckedChanged);
            // 
            // radioPatientName
            // 
            this.radioPatientName.AutoSize = true;
            this.radioPatientName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPatientName.Location = new System.Drawing.Point(33, 56);
            this.radioPatientName.Name = "radioPatientName";
            this.radioPatientName.Size = new System.Drawing.Size(145, 23);
            this.radioPatientName.TabIndex = 99;
            this.radioPatientName.Text = "By Patient Name";
            this.radioPatientName.UseVisualStyleBackColor = true;
            this.radioPatientName.Click += new System.EventHandler(this.radioByHospitalID_Click);
            this.radioPatientName.CheckedChanged += new System.EventHandler(this.rdoPatientID_CheckedChanged);
            // 
            // radioByAddress
            // 
            this.radioByAddress.AutoSize = true;
            this.radioByAddress.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioByAddress.Location = new System.Drawing.Point(33, 103);
            this.radioByAddress.Name = "radioByAddress";
            this.radioByAddress.Size = new System.Drawing.Size(102, 23);
            this.radioByAddress.TabIndex = 101;
            this.radioByAddress.Text = "By Address";
            this.radioByAddress.UseVisualStyleBackColor = true;
            this.radioByAddress.Click += new System.EventHandler(this.radioByHospitalID_Click);
            this.radioByAddress.CheckedChanged += new System.EventHandler(this.rdoPatientID_CheckedChanged);
            // 
            // lvwpatientSearch
            // 
            this.lvwpatientSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lvwpatientSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwpatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwpatientSearch.FullRowSelect = true;
            this.lvwpatientSearch.GridLines = true;
            this.lvwpatientSearch.Location = new System.Drawing.Point(307, 35);
            this.lvwpatientSearch.Name = "lvwpatientSearch";
            this.lvwpatientSearch.Size = new System.Drawing.Size(609, 466);
            this.lvwpatientSearch.TabIndex = 95;
            this.lvwpatientSearch.UseCompatibleStateImageBehavior = false;
            this.lvwpatientSearch.View = System.Windows.Forms.View.Details;
            this.lvwpatientSearch.Click += new System.EventHandler(this.lvwpatientSearch_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patient ID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Patient Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Patient Address";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 220;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "C_Phone";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.Navy;
            this.lblSearchBy.Location = new System.Drawing.Point(46, 170);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(89, 19);
            this.lblSearchBy.TabIndex = 68;
            this.lblSearchBy.Text = "Patient ID";
            this.lblSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchBy.Location = new System.Drawing.Point(49, 192);
            this.txtSearchBy.MaxLength = 20;
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(202, 20);
            this.txtSearchBy.TabIndex = 0;
            this.txtSearchBy.Tag = "admission_code";
            this.txtSearchBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBy_KeyUp);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(806, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnClose_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPatientCode);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(33, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 97);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 116;
            this.label3.Text = "P Name";
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.Enabled = false;
            this.txtPatientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPatientCode.Location = new System.Drawing.Point(83, 26);
            this.txtPatientCode.MaxLength = 20;
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.Size = new System.Drawing.Size(143, 22);
            this.txtPatientCode.TabIndex = 114;
            this.txtPatientCode.Tag = "admission_code";
            this.txtPatientCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(33, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 149);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Item";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(956, 33);
            this.label7.TabIndex = 105;
            this.label7.Text = "Patient Search";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(949, 614);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Search";
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpSearchOption.ResumeLayout(false);
            this.grpSearchOption.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvwpatientSearch;
        private System.Windows.Forms.GroupBox grpSearchOption;
        private System.Windows.Forms.RadioButton radioMobileNo;
        private System.Windows.Forms.RadioButton radioPatientName;
        private System.Windows.Forms.RadioButton radioByAddress;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rdoPatientID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rdoIDcard;
        private System.Windows.Forms.RadioButton rdoServices;
        private System.Windows.Forms.RadioButton rdoConsultation;
        private System.Windows.Forms.RadioButton rdoInvestigation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}