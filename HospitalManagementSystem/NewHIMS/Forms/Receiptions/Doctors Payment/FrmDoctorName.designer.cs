namespace NewHIMS.Forms.Receiptions.DoctorsBill
{
    partial class FrmDoctorName
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
            this.lblDoctorrName = new System.Windows.Forms.Label();
            this.grpSupplier = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalSupplier = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotalSupplier2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwDoctorInfo = new System.Windows.Forms.ListView();
            this.reffered_doc_id = new System.Windows.Forms.ColumnHeader();
            this.reffered_doctor = new System.Windows.Forms.ColumnHeader();
            this.specialist_in = new System.Windows.Forms.ColumnHeader();
            this.designation = new System.Windows.Forms.ColumnHeader();
            this.degree = new System.Windows.Forms.ColumnHeader();
            this.contact = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbspecilist_in = new System.Windows.Forms.ComboBox();
            this.txtdoctorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSupplier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoctorrName
            // 
            this.lblDoctorrName.AutoSize = true;
            this.lblDoctorrName.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorrName.ForeColor = System.Drawing.Color.Black;
            this.lblDoctorrName.Location = new System.Drawing.Point(48, 21);
            this.lblDoctorrName.Name = "lblDoctorrName";
            this.lblDoctorrName.Size = new System.Drawing.Size(107, 19);
            this.lblDoctorrName.TabIndex = 30;
            this.lblDoctorrName.Text = "Doctor Name";
            // 
            // grpSupplier
            // 
            this.grpSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSupplier.Controls.Add(this.btnClose);
            this.grpSupplier.Controls.Add(this.groupBox1);
            this.grpSupplier.Controls.Add(this.groupBox2);
            this.grpSupplier.Controls.Add(this.groupBox3);
            this.grpSupplier.Location = new System.Drawing.Point(12, 48);
            this.grpSupplier.Name = "grpSupplier";
            this.grpSupplier.Size = new System.Drawing.Size(823, 609);
            this.grpSupplier.TabIndex = 49;
            this.grpSupplier.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(716, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalSupplier
            // 
            this.lblTotalSupplier.AutoSize = true;
            this.lblTotalSupplier.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier.Location = new System.Drawing.Point(19, 20);
            this.lblTotalSupplier.Name = "lblTotalSupplier";
            this.lblTotalSupplier.Size = new System.Drawing.Size(95, 19);
            this.lblTotalSupplier.TabIndex = 37;
            this.lblTotalSupplier.Text = "Total Count";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblTotalSupplier);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblTotalSupplier2);
            this.groupBox1.Location = new System.Drawing.Point(13, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 53);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(591, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(487, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalSupplier2
            // 
            this.lblTotalSupplier2.BackColor = System.Drawing.Color.Silver;
            this.lblTotalSupplier2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier2.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSupplier2.Location = new System.Drawing.Point(126, 16);
            this.lblTotalSupplier2.Name = "lblTotalSupplier2";
            this.lblTotalSupplier2.Size = new System.Drawing.Size(78, 28);
            this.lblTotalSupplier2.TabIndex = 38;
            this.lblTotalSupplier2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwDoctorInfo);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 383);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            // 
            // lvwDoctorInfo
            // 
            this.lvwDoctorInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reffered_doc_id,
            this.reffered_doctor,
            this.specialist_in,
            this.designation,
            this.degree,
            this.contact});
            this.lvwDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoctorInfo.FullRowSelect = true;
            this.lvwDoctorInfo.GridLines = true;
            this.lvwDoctorInfo.Location = new System.Drawing.Point(15, 14);
            this.lvwDoctorInfo.Name = "lvwDoctorInfo";
            this.lvwDoctorInfo.Size = new System.Drawing.Size(777, 363);
            this.lvwDoctorInfo.TabIndex = 36;
            this.lvwDoctorInfo.UseCompatibleStateImageBehavior = false;
            this.lvwDoctorInfo.View = System.Windows.Forms.View.Details;
            this.lvwDoctorInfo.Click += new System.EventHandler(this.lvwDoctorInfo_Click);
            // 
            // reffered_doc_id
            // 
            this.reffered_doc_id.Text = "ID";
            this.reffered_doc_id.Width = 65;
            // 
            // reffered_doctor
            // 
            this.reffered_doctor.Text = "Doctor Name";
            this.reffered_doctor.Width = 530;
            // 
            // specialist_in
            // 
            this.specialist_in.Text = "Specialist In";
            this.specialist_in.Width = 150;
            // 
            // designation
            // 
            this.designation.Text = "Designation";
            this.designation.Width = 0;
            // 
            // degree
            // 
            this.degree.Text = "Degree";
            this.degree.Width = 0;
            // 
            // contact
            // 
            this.contact.Text = "Contact No.";
            this.contact.Width = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNameSearch);
            this.groupBox3.Controls.Add(this.lblProductType);
            this.groupBox3.Controls.Add(this.cmbspecilist_in);
            this.groupBox3.Controls.Add(this.txtdoctorName);
            this.groupBox3.Controls.Add(this.lblDoctorrName);
            this.groupBox3.Location = new System.Drawing.Point(13, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 132);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.Black;
            this.lblProductType.Location = new System.Drawing.Point(66, 59);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(89, 19);
            this.lblProductType.TabIndex = 52;
            this.lblProductType.Text = "Specialist In";
            // 
            // cmbspecilist_in
            // 
            this.cmbspecilist_in.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbspecilist_in.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbspecilist_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbspecilist_in.FormattingEnabled = true;
            this.cmbspecilist_in.Location = new System.Drawing.Point(161, 57);
            this.cmbspecilist_in.Name = "cmbspecilist_in";
            this.cmbspecilist_in.Size = new System.Drawing.Size(293, 24);
            this.cmbspecilist_in.TabIndex = 53;
            // 
            // txtdoctorName
            // 
            this.txtdoctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoctorName.Location = new System.Drawing.Point(161, 19);
            this.txtdoctorName.Name = "txtdoctorName";
            this.txtdoctorName.Size = new System.Drawing.Size(595, 22);
            this.txtdoctorName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(-8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(863, 33);
            this.label7.TabIndex = 144;
            this.label7.Text = "Doctors List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(161, 96);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(293, 21);
            this.txtNameSearch.TabIndex = 54;
            this.txtNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Search Name";
            // 
            // FrmDoctorName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(847, 669);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpSupplier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoctorName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors  List";
            this.Load += new System.EventHandler(this.FrmDoctorName_Load);
            this.grpSupplier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorrName;
        private System.Windows.Forms.GroupBox grpSupplier;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalSupplier2;
        private System.Windows.Forms.Label lblTotalSupplier;
        private System.Windows.Forms.ListView lvwDoctorInfo;
        private System.Windows.Forms.TextBox txtdoctorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader reffered_doc_id;
        private System.Windows.Forms.ColumnHeader reffered_doctor;
        private System.Windows.Forms.ColumnHeader specialist_in;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader degree;
        private System.Windows.Forms.ColumnHeader contact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbspecilist_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;

    }
}