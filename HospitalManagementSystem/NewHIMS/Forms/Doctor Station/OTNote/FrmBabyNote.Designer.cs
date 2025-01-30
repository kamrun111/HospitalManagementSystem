namespace NewHIMS.Forms.Doctor_Station.OTNote
{
    partial class FrmBabyNote
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpoperationDate = new System.Windows.Forms.DateTimePicker();
            this.cbmBabySx = new System.Windows.Forms.ComboBox();
            this.dtpoperationTime = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtA_S = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtc_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 24);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "   Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(178, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 24);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtc_a);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dtpoperationDate);
            this.groupBox5.Controls.Add(this.cbmBabySx);
            this.groupBox5.Controls.Add(this.dtpoperationTime);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtWeight);
            this.groupBox5.Controls.Add(this.txtA_S);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(5, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(331, 111);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Baby Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Time";
            // 
            // dtpoperationDate
            // 
            this.dtpoperationDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpoperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpoperationDate.Location = new System.Drawing.Point(57, 24);
            this.dtpoperationDate.Name = "dtpoperationDate";
            this.dtpoperationDate.Size = new System.Drawing.Size(105, 20);
            this.dtpoperationDate.TabIndex = 58;
            this.dtpoperationDate.Tag = "dob";
            // 
            // cbmBabySx
            // 
            this.cbmBabySx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbmBabySx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmBabySx.FormattingEnabled = true;
            this.cbmBabySx.Location = new System.Drawing.Point(222, 75);
            this.cbmBabySx.Name = "cbmBabySx";
            this.cbmBabySx.Size = new System.Drawing.Size(101, 21);
            this.cbmBabySx.TabIndex = 29;
            // 
            // dtpoperationTime
            // 
            this.dtpoperationTime.CustomFormat = "hh:mm tt";
            this.dtpoperationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpoperationTime.Location = new System.Drawing.Point(222, 22);
            this.dtpoperationTime.Name = "dtpoperationTime";
            this.dtpoperationTime.ShowUpDown = true;
            this.dtpoperationTime.Size = new System.Drawing.Size(93, 20);
            this.dtpoperationTime.TabIndex = 57;
            this.dtpoperationTime.Tag = "dob";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(174, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(222, 48);
            this.txtWeight.MaxLength = 150;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(93, 20);
            this.txtWeight.TabIndex = 6;
            // 
            // txtA_S
            // 
            this.txtA_S.Location = new System.Drawing.Point(57, 50);
            this.txtA_S.MaxLength = 150;
            this.txtA_S.Name = "txtA_S";
            this.txtA_S.Size = new System.Drawing.Size(105, 20);
            this.txtA_S.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(170, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Gender";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "A_S";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(1, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(306, 24);
            this.label22.TabIndex = 55;
            this.label22.Text = "Baby Note";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(93, 147);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 24);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtc_a
            // 
            this.txtc_a.Location = new System.Drawing.Point(58, 73);
            this.txtc_a.MaxLength = 150;
            this.txtc_a.Name = "txtc_a";
            this.txtc_a.Size = new System.Drawing.Size(104, 20);
            this.txtc_a.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "C_A";
            // 
            // FrmBabyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(346, 177);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBabyNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baby Note";
            this.Load += new System.EventHandler(this.FrmBabyNote_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbmBabySx;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtA_S;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpoperationDate;
        private System.Windows.Forms.DateTimePicker dtpoperationTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtc_a;
    }
}