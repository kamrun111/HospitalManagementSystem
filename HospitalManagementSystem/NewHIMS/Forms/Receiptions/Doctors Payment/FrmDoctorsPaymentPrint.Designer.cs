namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    partial class FrmDoctorsPaymentPrint
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
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwDoctorInfo = new System.Windows.Forms.ListView();
            this.doctor_payment_id = new System.Windows.Forms.ColumnHeader();
            this.doctor_payment_no = new System.Windows.Forms.ColumnHeader();
            this.start_date = new System.Windows.Forms.ColumnHeader();
            this.end_date = new System.Windows.Forms.ColumnHeader();
            this.record_created_date = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-8, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(520, 30);
            this.label15.TabIndex = 65;
            this.label15.Text = "DOCTOR\'S PAYMENT RE-PRINT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwDoctorInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 335);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // lvwDoctorInfo
            // 
            this.lvwDoctorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDoctorInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwDoctorInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.doctor_payment_id,
            this.doctor_payment_no,
            this.start_date,
            this.end_date,
            this.record_created_date});
            this.lvwDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwDoctorInfo.FullRowSelect = true;
            this.lvwDoctorInfo.HideSelection = false;
            this.lvwDoctorInfo.Location = new System.Drawing.Point(8, 17);
            this.lvwDoctorInfo.Name = "lvwDoctorInfo";
            this.lvwDoctorInfo.Size = new System.Drawing.Size(464, 310);
            this.lvwDoctorInfo.TabIndex = 9;
            this.lvwDoctorInfo.UseCompatibleStateImageBehavior = false;
            this.lvwDoctorInfo.View = System.Windows.Forms.View.Details;
            // 
            // doctor_payment_id
            // 
            this.doctor_payment_id.Text = "doctor_payment_id";
            this.doctor_payment_id.Width = 0;
            // 
            // doctor_payment_no
            // 
            this.doctor_payment_no.Text = "payment No";
            this.doctor_payment_no.Width = 134;
            // 
            // start_date
            // 
            this.start_date.Text = "Start Date";
            this.start_date.Width = 102;
            // 
            // end_date
            // 
            this.end_date.Text = "End  Date";
            this.end_date.Width = 100;
            // 
            // record_created_date
            // 
            this.record_created_date.Text = "Submit Date";
            this.record_created_date.Width = 109;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 72);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(388, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 36);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(208, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 36);
            this.btnRefresh.TabIndex = 69;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(299, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 36);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmDoctorsPaymentPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(509, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoctorsPaymentPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsPaymentPrint";
            this.Load += new System.EventHandler(this.FrmDoctorsPaymentPrint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwDoctorInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ColumnHeader doctor_payment_id;
        private System.Windows.Forms.ColumnHeader doctor_payment_no;
        private System.Windows.Forms.ColumnHeader start_date;
        private System.Windows.Forms.ColumnHeader end_date;
        private System.Windows.Forms.ColumnHeader record_created_date;
    }
}