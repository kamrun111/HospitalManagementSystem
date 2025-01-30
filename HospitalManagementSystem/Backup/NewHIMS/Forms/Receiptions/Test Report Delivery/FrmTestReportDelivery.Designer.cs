namespace NewHIMS.Forms.Receiptions.Test_Report_Delivery
{
    partial class FrmTestReportDelivery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMainList = new System.Windows.Forms.ListView();
            this.investiogation_test_id = new System.Windows.Forms.ColumnHeader();
            this.test_name = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPAddress = new System.Windows.Forms.TextBox();
            this.txtPContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.p_name = new System.Windows.Forms.ColumnHeader();
            this.p_address = new System.Windows.Forms.ColumnHeader();
            this.p_contact = new System.Windows.Forms.ColumnHeader();
            this.ITID = new System.Windows.Forms.ColumnHeader();
            this.lblInvestigationTestTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMainList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.txtPAddress);
            this.groupBox1.Controls.Add(this.txtPContact);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDelivery);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lvwPatientInfo);
            this.groupBox1.Controls.Add(this.lblInvestigationTestTitle);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lvwMainList
            // 
            this.lvwMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMainList.BackColor = System.Drawing.Color.Silver;
            this.lvwMainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.test_name,
            this.investiogation_test_id});
            this.lvwMainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMainList.ForeColor = System.Drawing.Color.Red;
            this.lvwMainList.FullRowSelect = true;
            this.lvwMainList.GridLines = true;
            this.lvwMainList.HideSelection = false;
            this.lvwMainList.Location = new System.Drawing.Point(256, 177);
            this.lvwMainList.MultiSelect = false;
            this.lvwMainList.Name = "lvwMainList";
            this.lvwMainList.Size = new System.Drawing.Size(205, 184);
            this.lvwMainList.TabIndex = 63;
            this.lvwMainList.UseCompatibleStateImageBehavior = false;
            this.lvwMainList.View = System.Windows.Forms.View.Details;
            // 
            // investiogation_test_id
            // 
            this.investiogation_test_id.Text = "investiogation_test_id";
            this.investiogation_test_id.Width = 0;
            // 
            // test_name
            // 
            this.test_name.Text = "Test Name";
            this.test_name.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Contact No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "Address ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(346, 77);
            this.txtPatientName.MaxLength = 255;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(154, 21);
            this.txtPatientName.TabIndex = 59;
            // 
            // txtPAddress
            // 
            this.txtPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAddress.Location = new System.Drawing.Point(346, 99);
            this.txtPAddress.MaxLength = 300;
            this.txtPAddress.Multiline = true;
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.Size = new System.Drawing.Size(154, 37);
            this.txtPAddress.TabIndex = 58;
            // 
            // txtPContact
            // 
            this.txtPContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPContact.Location = new System.Drawing.Point(346, 137);
            this.txtPContact.MaxLength = 15;
            this.txtPContact.Name = "txtPContact";
            this.txtPContact.Size = new System.Drawing.Size(154, 21);
            this.txtPContact.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Delivered By ";
            // 
            // txtDelivery
            // 
            this.txtDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelivery.Location = new System.Drawing.Point(355, 371);
            this.txtDelivery.MaxLength = 100;
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(107, 22);
            this.txtDelivery.TabIndex = 55;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(293, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Deliver";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(382, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.patient_code,
            this.p_name,
            this.p_address,
            this.p_contact,
            this.ITID});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(31, 74);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(176, 287);
            this.lvwPatientInfo.TabIndex = 52;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.Click += new System.EventHandler(this.lvwPatientInfo_Click);
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "Cabin";
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Hospital ID";
            this.patient_code.Width = 110;
            // 
            // p_name
            // 
            this.p_name.Text = "p_name";
            this.p_name.Width = 0;
            // 
            // p_address
            // 
            this.p_address.Text = "p_address";
            this.p_address.Width = 0;
            // 
            // p_contact
            // 
            this.p_contact.Text = "p_contact";
            this.p_contact.Width = 0;
            // 
            // ITID
            // 
            this.ITID.Text = "ITID";
            this.ITID.Width = 0;
            // 
            // lblInvestigationTestTitle
            // 
            this.lblInvestigationTestTitle.AutoSize = true;
            this.lblInvestigationTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationTestTitle.ForeColor = System.Drawing.Color.White;
            this.lblInvestigationTestTitle.Location = new System.Drawing.Point(123, 10);
            this.lblInvestigationTestTitle.Name = "lblInvestigationTestTitle";
            this.lblInvestigationTestTitle.Size = new System.Drawing.Size(283, 31);
            this.lblInvestigationTestTitle.TabIndex = 51;
            this.lblInvestigationTestTitle.Text = "Test Report Delivery";
            // 
            // FrmTestReportDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(566, 479);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTestReportDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Report Delivery";
            this.Load += new System.EventHandler(this.FrmTestReportDelivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMainList;
        private System.Windows.Forms.ColumnHeader investiogation_test_id;
        private System.Windows.Forms.ColumnHeader test_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPAddress;
        private System.Windows.Forms.TextBox txtPContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.ColumnHeader p_name;
        private System.Windows.Forms.ColumnHeader p_address;
        private System.Windows.Forms.ColumnHeader p_contact;
        private System.Windows.Forms.ColumnHeader ITID;
        private System.Windows.Forms.Label lblInvestigationTestTitle;

    }
}