namespace NewHIMS.Forms.Store
{
    partial class FrmSupplierAddEditView
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
            this.grpSupplier = new System.Windows.Forms.GroupBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalSupplier2 = new System.Windows.Forms.Label();
            this.lblTotalSupplier = new System.Windows.Forms.Label();
            this.lvwSupplier = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader51 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lblSupplierFaxNo = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierContactPerson = new System.Windows.Forms.Label();
            this.lblSupplierContactNo = new System.Windows.Forms.Label();
            this.txtSupplierFax = new System.Windows.Forms.TextBox();
            this.txtSupplierContactNo = new System.Windows.Forms.TextBox();
            this.txtSupplierContactPerson = new System.Windows.Forms.TextBox();
            this.txtSupplierAdrress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpSupplier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSupplier
            // 
            this.grpSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSupplier.Controls.Add(this.cmbProductType);
            this.grpSupplier.Controls.Add(this.lblProductType);
            this.grpSupplier.Controls.Add(this.lblTotalSupplier2);
            this.grpSupplier.Controls.Add(this.lblTotalSupplier);
            this.grpSupplier.Controls.Add(this.lvwSupplier);
            this.grpSupplier.Controls.Add(this.lblSupplierFaxNo);
            this.grpSupplier.Controls.Add(this.lblSupplierAddress);
            this.grpSupplier.Controls.Add(this.lblSupplierName);
            this.grpSupplier.Controls.Add(this.lblSupplierContactPerson);
            this.grpSupplier.Controls.Add(this.lblSupplierContactNo);
            this.grpSupplier.Controls.Add(this.txtSupplierFax);
            this.grpSupplier.Controls.Add(this.txtSupplierContactNo);
            this.grpSupplier.Controls.Add(this.txtSupplierContactPerson);
            this.grpSupplier.Controls.Add(this.txtSupplierAdrress);
            this.grpSupplier.Controls.Add(this.txtSupplierName);
            this.grpSupplier.Location = new System.Drawing.Point(12, 58);
            this.grpSupplier.Name = "grpSupplier";
            this.grpSupplier.Size = new System.Drawing.Size(625, 368);
            this.grpSupplier.TabIndex = 11;
            this.grpSupplier.TabStop = false;
            // 
            // cmbProductType
            // 
            this.cmbProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(119, 21);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(105, 21);
            this.cmbProductType.TabIndex = 53;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            this.cmbProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProductType_KeyPress);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(24, 27);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(85, 13);
            this.lblProductType.TabIndex = 52;
            this.lblProductType.Text = "Supplier Type";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(99, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 28);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = " Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(13, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(426, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(533, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTotalSupplier2
            // 
            this.lblTotalSupplier2.BackColor = System.Drawing.Color.Silver;
            this.lblTotalSupplier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier2.ForeColor = System.Drawing.Color.White;
            this.lblTotalSupplier2.Location = new System.Drawing.Point(572, 125);
            this.lblTotalSupplier2.Name = "lblTotalSupplier2";
            this.lblTotalSupplier2.Size = new System.Drawing.Size(37, 20);
            this.lblTotalSupplier2.TabIndex = 38;
            this.lblTotalSupplier2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSupplier
            // 
            this.lblTotalSupplier.AutoSize = true;
            this.lblTotalSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier.Location = new System.Drawing.Point(465, 128);
            this.lblTotalSupplier.Name = "lblTotalSupplier";
            this.lblTotalSupplier.Size = new System.Drawing.Size(106, 16);
            this.lblTotalSupplier.TabIndex = 37;
            this.lblTotalSupplier.Text = "Total Supplier";
            // 
            // lvwSupplier
            // 
            this.lvwSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader51,
            this.columnHeader5});
            this.lvwSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSupplier.FullRowSelect = true;
            this.lvwSupplier.GridLines = true;
            this.lvwSupplier.Location = new System.Drawing.Point(13, 156);
            this.lvwSupplier.Name = "lvwSupplier";
            this.lvwSupplier.Size = new System.Drawing.Size(594, 205);
            this.lvwSupplier.TabIndex = 36;
            this.lvwSupplier.UseCompatibleStateImageBehavior = false;
            this.lvwSupplier.View = System.Windows.Forms.View.Details;
            this.lvwSupplier.Click += new System.EventHandler(this.lvwSupplier_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Supplier ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Person";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact No.";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader51
            // 
            this.columnHeader51.DisplayIndex = 5;
            this.columnHeader51.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 200;
            // 
            // lblSupplierFaxNo
            // 
            this.lblSupplierFaxNo.AutoSize = true;
            this.lblSupplierFaxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierFaxNo.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierFaxNo.Location = new System.Drawing.Point(405, 77);
            this.lblSupplierFaxNo.Name = "lblSupplierFaxNo";
            this.lblSupplierFaxNo.Size = new System.Drawing.Size(51, 13);
            this.lblSupplierFaxNo.TabIndex = 32;
            this.lblSupplierFaxNo.Text = "Fax No.";
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierAddress.Location = new System.Drawing.Point(24, 105);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(52, 13);
            this.lblSupplierAddress.TabIndex = 31;
            this.lblSupplierAddress.Text = "Address";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierName.Location = new System.Drawing.Point(24, 51);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(89, 13);
            this.lblSupplierName.TabIndex = 30;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // lblSupplierContactPerson
            // 
            this.lblSupplierContactPerson.AutoSize = true;
            this.lblSupplierContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierContactPerson.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierContactPerson.Location = new System.Drawing.Point(24, 77);
            this.lblSupplierContactPerson.Name = "lblSupplierContactPerson";
            this.lblSupplierContactPerson.Size = new System.Drawing.Size(94, 13);
            this.lblSupplierContactPerson.TabIndex = 29;
            this.lblSupplierContactPerson.Text = "Contact Person";
            // 
            // lblSupplierContactNo
            // 
            this.lblSupplierContactNo.AutoSize = true;
            this.lblSupplierContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierContactNo.Location = new System.Drawing.Point(379, 51);
            this.lblSupplierContactNo.Name = "lblSupplierContactNo";
            this.lblSupplierContactNo.Size = new System.Drawing.Size(75, 13);
            this.lblSupplierContactNo.TabIndex = 28;
            this.lblSupplierContactNo.Text = "Contact No.";
            // 
            // txtSupplierFax
            // 
            this.txtSupplierFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierFax.Enabled = false;
            this.txtSupplierFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierFax.Location = new System.Drawing.Point(461, 74);
            this.txtSupplierFax.Name = "txtSupplierFax";
            this.txtSupplierFax.Size = new System.Drawing.Size(152, 20);
            this.txtSupplierFax.TabIndex = 26;
            this.txtSupplierFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierFax_KeyPress);
            // 
            // txtSupplierContactNo
            // 
            this.txtSupplierContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierContactNo.Enabled = false;
            this.txtSupplierContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierContactNo.Location = new System.Drawing.Point(461, 48);
            this.txtSupplierContactNo.Name = "txtSupplierContactNo";
            this.txtSupplierContactNo.Size = new System.Drawing.Size(152, 20);
            this.txtSupplierContactNo.TabIndex = 25;
            this.txtSupplierContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierContactNo_KeyPress);
            // 
            // txtSupplierContactPerson
            // 
            this.txtSupplierContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierContactPerson.Enabled = false;
            this.txtSupplierContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierContactPerson.Location = new System.Drawing.Point(119, 74);
            this.txtSupplierContactPerson.Name = "txtSupplierContactPerson";
            this.txtSupplierContactPerson.Size = new System.Drawing.Size(239, 20);
            this.txtSupplierContactPerson.TabIndex = 24;
            this.txtSupplierContactPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierContactPerson_KeyPress);
            // 
            // txtSupplierAdrress
            // 
            this.txtSupplierAdrress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierAdrress.Enabled = false;
            this.txtSupplierAdrress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAdrress.Location = new System.Drawing.Point(119, 100);
            this.txtSupplierAdrress.Multiline = true;
            this.txtSupplierAdrress.Name = "txtSupplierAdrress";
            this.txtSupplierAdrress.Size = new System.Drawing.Size(239, 44);
            this.txtSupplierAdrress.TabIndex = 27;
            this.txtSupplierAdrress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierAdrress_KeyPress);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(119, 48);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(239, 20);
            this.txtSupplierName.TabIndex = 23;
            this.txtSupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierName_KeyPress);
            // 
            // lblSupplierTitle
            // 
            this.lblSupplierTitle.AutoSize = true;
            this.lblSupplierTitle.BackColor = System.Drawing.Color.SandyBrown;
            this.lblSupplierTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierTitle.ForeColor = System.Drawing.Color.White;
            this.lblSupplierTitle.Location = new System.Drawing.Point(249, 13);
            this.lblSupplierTitle.Name = "lblSupplierTitle";
            this.lblSupplierTitle.Size = new System.Drawing.Size(121, 31);
            this.lblSupplierTitle.TabIndex = 48;
            this.lblSupplierTitle.Text = "Supplier";
            this.lblSupplierTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(12, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 55);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // FrmSupplierAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(649, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSupplierTitle);
            this.Controls.Add(this.grpSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSupplierAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.FrmSupplierAddEditView_Load);
            this.grpSupplier.ResumeLayout(false);
            this.grpSupplier.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSupplier;
        private System.Windows.Forms.Label lblTotalSupplier2;
        private System.Windows.Forms.Label lblTotalSupplier;
        private System.Windows.Forms.ListView lvwSupplier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblSupplierFaxNo;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierContactPerson;
        private System.Windows.Forms.Label lblSupplierContactNo;
        private System.Windows.Forms.TextBox txtSupplierFax;
        private System.Windows.Forms.TextBox txtSupplierContactNo;
        private System.Windows.Forms.TextBox txtSupplierContactPerson;
        private System.Windows.Forms.TextBox txtSupplierAdrress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSupplierTitle;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}