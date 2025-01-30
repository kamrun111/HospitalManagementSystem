namespace NewHIMS.Forms.Investigation
{
    partial class FrmMemberSearch
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
            this.lvwMember = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.mobile = new System.Windows.Forms.ColumnHeader();
            this.image = new System.Windows.Forms.ColumnHeader();
            this.AGE = new System.Windows.Forms.ColumnHeader();
            this.gender = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(-2, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(545, 27);
            this.label7.TabIndex = 101;
            this.label7.Text = "Member / Stuff Search";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMember);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 487);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // lvwMember
            // 
            this.lvwMember.BackColor = System.Drawing.Color.Silver;
            this.lvwMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.mobile,
            this.image,
            this.AGE,
            this.gender,
            this.status});
            this.lvwMember.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMember.FullRowSelect = true;
            this.lvwMember.GridLines = true;
            this.lvwMember.Location = new System.Drawing.Point(10, 119);
            this.lvwMember.MultiSelect = false;
            this.lvwMember.Name = "lvwMember";
            this.lvwMember.Size = new System.Drawing.Size(506, 298);
            this.lvwMember.TabIndex = 106;
            this.lvwMember.UseCompatibleStateImageBehavior = false;
            this.lvwMember.View = System.Windows.Forms.View.Details;
            this.lvwMember.ItemActivate += new System.EventHandler(this.lvwMember_ItemActivate);
            this.lvwMember.Click += new System.EventHandler(this.lvwMember_Click);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 300;
            // 
            // mobile
            // 
            this.mobile.Text = "Mobile";
            this.mobile.Width = 170;
            // 
            // image
            // 
            this.image.Text = "Image";
            this.image.Width = 0;
            // 
            // AGE
            // 
            this.AGE.Text = "AGE";
            this.AGE.Width = 0;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Location = new System.Drawing.Point(7, 420);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(513, 59);
            this.groupBox5.TabIndex = 105;
            this.groupBox5.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(124, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBox1.Location = new System.Drawing.Point(378, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 51);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(125, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 101;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Search Mobile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSearchType);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Member",
            "Dependable",
            "Stuff",
            "Stuff Dependable"});
            this.cmbSearchType.Location = new System.Drawing.Point(125, 19);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(164, 21);
            this.cmbSearchType.TabIndex = 101;
            this.cmbSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchType_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Yellow;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 16);
            this.label17.TabIndex = 100;
            this.label17.Text = "Search Type";
            // 
            // status
            // 
            this.status.Text = "status";
            this.status.Width = 0;
            // 
            // FrmMemberSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(539, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMemberSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Member / Stuff";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader mobile;
        private System.Windows.Forms.ColumnHeader image;
        public System.Windows.Forms.ListView lvwMember;
        private System.Windows.Forms.ColumnHeader AGE;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader status;
    }
}