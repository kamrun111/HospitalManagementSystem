namespace NewHIMS.Forms.Common
{
    partial class FrmdoctorSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmdoctorSearch));
            this.label7 = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lvwDoctors = new System.Windows.Forms.ListView();
            this.doctor_id = new System.Windows.Forms.ColumnHeader();
            this.doctor_name = new System.Windows.Forms.ColumnHeader();
            this.specialist_in = new System.Windows.Forms.ColumnHeader();
            this.designation = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(659, 30);
            this.label7.TabIndex = 120;
            this.label7.Text = "Doctor Search";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(78, 77);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(102, 17);
            this.lblProductType.TabIndex = 119;
            this.lblProductType.Text = "Doctor Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(35, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 60);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(376, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 33);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(488, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(194, 76);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(256, 20);
            this.txtDoctorName.TabIndex = 117;
            this.txtDoctorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorName_KeyPress);
            // 
            // lvwDoctors
            // 
            this.lvwDoctors.BackColor = System.Drawing.Color.BurlyWood;
            this.lvwDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.doctor_id,
            this.doctor_name,
            this.specialist_in,
            this.designation});
            this.lvwDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoctors.FullRowSelect = true;
            this.lvwDoctors.GridLines = true;
            this.lvwDoctors.Location = new System.Drawing.Point(13, 15);
            this.lvwDoctors.Name = "lvwDoctors";
            this.lvwDoctors.Size = new System.Drawing.Size(566, 374);
            this.lvwDoctors.TabIndex = 118;
            this.lvwDoctors.UseCompatibleStateImageBehavior = false;
            this.lvwDoctors.View = System.Windows.Forms.View.Details;
            this.lvwDoctors.ItemActivate += new System.EventHandler(this.lvwDoctors_ItemActivate);
            // 
            // doctor_id
            // 
            this.doctor_id.Text = "Doctor ID";
            this.doctor_id.Width = 70;
            // 
            // doctor_name
            // 
            this.doctor_name.Text = "Doctor Name";
            this.doctor_name.Width = 470;
            // 
            // specialist_in
            // 
            this.specialist_in.Text = "Specialist ";
            this.specialist_in.Width = 0;
            // 
            // designation
            // 
            this.designation.Text = "Designation";
            this.designation.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwDoctors);
            this.groupBox1.Location = new System.Drawing.Point(29, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 398);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 531);
            this.groupBox3.TabIndex = 123;
            this.groupBox3.TabStop = false;
            // 
            // FrmdoctorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(652, 598);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmdoctorSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Search";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.ListView lvwDoctors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader doctor_id;
        private System.Windows.Forms.ColumnHeader doctor_name;
        private System.Windows.Forms.ColumnHeader specialist_in;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}