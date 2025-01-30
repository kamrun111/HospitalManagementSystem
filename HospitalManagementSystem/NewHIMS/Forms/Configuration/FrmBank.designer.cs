namespace NewHIMS.Forms.Configuration
{
    partial class FrmBank
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
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.grpSupplier = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotalSupplier = new System.Windows.Forms.Label();
            this.lvwBank = new System.Windows.Forms.ListView();
            this.bank_id = new System.Windows.Forms.ColumnHeader();
            this.bank_full_name = new System.Windows.Forms.ColumnHeader();
            this.bank_name = new System.Windows.Forms.ColumnHeader();
            this.branch_name = new System.Windows.Forms.ColumnHeader();
            this.branch_address = new System.Windows.Forms.ColumnHeader();
            this.contact_person = new System.Windows.Forms.ColumnHeader();
            this.contact_number = new System.Windows.Forms.ColumnHeader();
            this.account_no = new System.Windows.Forms.ColumnHeader();
            this.interest_rate = new System.Windows.Forms.ColumnHeader();
            this.lblSupplierFaxNo = new System.Windows.Forms.Label();
            this.lblSupplierContactPerson = new System.Windows.Forms.Label();
            this.lblSupplierContactNo = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBranchAddress = new System.Windows.Forms.TextBox();
            this.txtBankFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierAddress.Location = new System.Drawing.Point(14, 132);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(96, 13);
            this.lblSupplierAddress.TabIndex = 31;
            this.lblSupplierAddress.Text = "Branch Address";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierName.Location = new System.Drawing.Point(13, 23);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(96, 13);
            this.lblSupplierName.TabIndex = 30;
            this.lblSupplierName.Text = "Full Bank Name";
            // 
            // grpSupplier
            // 
            this.grpSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSupplier.Controls.Add(this.txtCount);
            this.grpSupplier.Controls.Add(this.label4);
            this.grpSupplier.Controls.Add(this.txtInterestRate);
            this.grpSupplier.Controls.Add(this.label3);
            this.grpSupplier.Controls.Add(this.label2);
            this.grpSupplier.Controls.Add(this.txtAccount);
            this.grpSupplier.Controls.Add(this.label1);
            this.grpSupplier.Controls.Add(this.txtBranchName);
            this.grpSupplier.Controls.Add(this.btnSave);
            this.grpSupplier.Controls.Add(this.btnClose);
            this.grpSupplier.Controls.Add(this.btnRefresh);
            this.grpSupplier.Controls.Add(this.lblTotalSupplier);
            this.grpSupplier.Controls.Add(this.lvwBank);
            this.grpSupplier.Controls.Add(this.lblSupplierFaxNo);
            this.grpSupplier.Controls.Add(this.lblSupplierAddress);
            this.grpSupplier.Controls.Add(this.lblSupplierName);
            this.grpSupplier.Controls.Add(this.lblSupplierContactPerson);
            this.grpSupplier.Controls.Add(this.lblSupplierContactNo);
            this.grpSupplier.Controls.Add(this.txtContactNumber);
            this.grpSupplier.Controls.Add(this.txtContactPerson);
            this.grpSupplier.Controls.Add(this.txtBankName);
            this.grpSupplier.Controls.Add(this.txtBranchAddress);
            this.grpSupplier.Controls.Add(this.txtBankFullName);
            this.grpSupplier.Location = new System.Drawing.Point(19, 46);
            this.grpSupplier.Name = "grpSupplier";
            this.grpSupplier.Size = new System.Drawing.Size(900, 499);
            this.grpSupplier.TabIndex = 49;
            this.grpSupplier.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCount.Enabled = false;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(833, 186);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(46, 20);
            this.txtCount.TabIndex = 143;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(509, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(595, 128);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(284, 20);
            this.txtInterestRate.TabIndex = 8;
            this.txtInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterestRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 140;
            this.label3.Text = "Bank List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(518, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Account no";
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(595, 88);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(284, 20);
            this.txtAccount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Branch Name";
            // 
            // txtBranchName
            // 
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Location = new System.Drawing.Point(115, 91);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(325, 20);
            this.txtBranchName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(704, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(794, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 36);
            this.btnClose.TabIndex = 134;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(29, 445);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 36);
            this.btnRefresh.TabIndex = 133;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTotalSupplier
            // 
            this.lblTotalSupplier.AutoSize = true;
            this.lblTotalSupplier.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSupplier.Location = new System.Drawing.Point(726, 190);
            this.lblTotalSupplier.Name = "lblTotalSupplier";
            this.lblTotalSupplier.Size = new System.Drawing.Size(83, 16);
            this.lblTotalSupplier.TabIndex = 37;
            this.lblTotalSupplier.Text = "Total Bank";
            // 
            // lvwBank
            // 
            this.lvwBank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bank_id,
            this.bank_full_name,
            this.bank_name,
            this.branch_name,
            this.branch_address,
            this.contact_person,
            this.contact_number,
            this.account_no,
            this.interest_rate});
            this.lvwBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBank.FullRowSelect = true;
            this.lvwBank.GridLines = true;
            this.lvwBank.HideSelection = false;
            this.lvwBank.Location = new System.Drawing.Point(22, 229);
            this.lvwBank.Name = "lvwBank";
            this.lvwBank.Size = new System.Drawing.Size(860, 198);
            this.lvwBank.TabIndex = 36;
            this.lvwBank.UseCompatibleStateImageBehavior = false;
            this.lvwBank.View = System.Windows.Forms.View.Details;
            this.lvwBank.Click += new System.EventHandler(this.lvwBank_Click);
            // 
            // bank_id
            // 
            this.bank_id.Text = "Bank ID";
            this.bank_id.Width = 0;
            // 
            // bank_full_name
            // 
            this.bank_full_name.Text = "Bank Full Name";
            this.bank_full_name.Width = 240;
            // 
            // bank_name
            // 
            this.bank_name.Text = "Bank name";
            this.bank_name.Width = 100;
            // 
            // branch_name
            // 
            this.branch_name.Text = "Branch Name";
            this.branch_name.Width = 150;
            // 
            // branch_address
            // 
            this.branch_address.Text = "Branch Address";
            this.branch_address.Width = 150;
            // 
            // contact_person
            // 
            this.contact_person.Text = "Contact Person";
            this.contact_person.Width = 0;
            // 
            // contact_number
            // 
            this.contact_number.Text = "Contact Number";
            this.contact_number.Width = 0;
            // 
            // account_no
            // 
            this.account_no.Text = "Account no";
            this.account_no.Width = 90;
            // 
            // interest_rate
            // 
            this.interest_rate.Text = "Interest Rate";
            this.interest_rate.Width = 90;
            // 
            // lblSupplierFaxNo
            // 
            this.lblSupplierFaxNo.AutoSize = true;
            this.lblSupplierFaxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierFaxNo.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierFaxNo.Location = new System.Drawing.Point(493, 57);
            this.lblSupplierFaxNo.Name = "lblSupplierFaxNo";
            this.lblSupplierFaxNo.Size = new System.Drawing.Size(98, 13);
            this.lblSupplierFaxNo.TabIndex = 32;
            this.lblSupplierFaxNo.Text = "Contact Number";
            // 
            // lblSupplierContactPerson
            // 
            this.lblSupplierContactPerson.AutoSize = true;
            this.lblSupplierContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierContactPerson.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierContactPerson.Location = new System.Drawing.Point(37, 59);
            this.lblSupplierContactPerson.Name = "lblSupplierContactPerson";
            this.lblSupplierContactPerson.Size = new System.Drawing.Size(72, 13);
            this.lblSupplierContactPerson.TabIndex = 29;
            this.lblSupplierContactPerson.Text = "Bank Name";
            // 
            // lblSupplierContactNo
            // 
            this.lblSupplierContactNo.AutoSize = true;
            this.lblSupplierContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblSupplierContactNo.Location = new System.Drawing.Point(496, 22);
            this.lblSupplierContactNo.Name = "lblSupplierContactNo";
            this.lblSupplierContactNo.Size = new System.Drawing.Size(94, 13);
            this.lblSupplierContactNo.TabIndex = 28;
            this.lblSupplierContactNo.Text = "Contact Person";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(595, 54);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(284, 20);
            this.txtContactNumber.TabIndex = 6;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(595, 19);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(284, 20);
            this.txtContactPerson.TabIndex = 5;
            // 
            // txtBankName
            // 
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Location = new System.Drawing.Point(114, 56);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(325, 20);
            this.txtBankName.TabIndex = 2;
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchAddress.Location = new System.Drawing.Point(114, 129);
            this.txtBranchAddress.Multiline = true;
            this.txtBranchAddress.Name = "txtBranchAddress";
            this.txtBranchAddress.Size = new System.Drawing.Size(325, 44);
            this.txtBranchAddress.TabIndex = 4;
            // 
            // txtBankFullName
            // 
            this.txtBankFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankFullName.Location = new System.Drawing.Point(114, 20);
            this.txtBankFullName.Name = "txtBankFullName";
            this.txtBankFullName.Size = new System.Drawing.Size(325, 20);
            this.txtBankFullName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(951, 33);
            this.label7.TabIndex = 118;
            this.label7.Text = "Bank Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(936, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.grpSupplier.ResumeLayout(false);
            this.grpSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.GroupBox grpSupplier;
        private System.Windows.Forms.Label lblTotalSupplier;
        private System.Windows.Forms.Label lblSupplierFaxNo;
        private System.Windows.Forms.Label lblSupplierContactPerson;
        private System.Windows.Forms.Label lblSupplierContactNo;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBranchAddress;
        private System.Windows.Forms.TextBox txtBankFullName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.ListView lvwBank;
        private System.Windows.Forms.ColumnHeader bank_id;
        private System.Windows.Forms.ColumnHeader bank_full_name;
        private System.Windows.Forms.ColumnHeader bank_name;
        private System.Windows.Forms.ColumnHeader branch_name;
        private System.Windows.Forms.ColumnHeader branch_address;
        private System.Windows.Forms.ColumnHeader contact_person;
        private System.Windows.Forms.ColumnHeader contact_number;
        private System.Windows.Forms.ColumnHeader account_no;
        private System.Windows.Forms.ColumnHeader interest_rate;
        private System.Windows.Forms.TextBox txtCount;
    }
}