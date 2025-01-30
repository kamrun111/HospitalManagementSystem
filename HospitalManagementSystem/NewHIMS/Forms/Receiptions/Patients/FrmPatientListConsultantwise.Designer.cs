namespace NewHIMS.Forms.Receiptions.Patients
{
    partial class FrmPatientListConsultantwise
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lvwConsultantInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.patient_code = new System.Windows.Forms.ColumnHeader();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lvwConsultantInfo);
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Location = new System.Drawing.Point(8, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 64);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(297, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(82, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "     Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lvwConsultantInfo
            // 
            this.lvwConsultantInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwConsultantInfo.BackColor = System.Drawing.Color.Tan;
            this.lvwConsultantInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.patient_code});
            this.lvwConsultantInfo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwConsultantInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwConsultantInfo.FullRowSelect = true;
            this.lvwConsultantInfo.GridLines = true;
            this.lvwConsultantInfo.HideSelection = false;
            this.lvwConsultantInfo.Location = new System.Drawing.Point(8, 15);
            this.lvwConsultantInfo.Name = "lvwConsultantInfo";
            this.lvwConsultantInfo.Size = new System.Drawing.Size(451, 373);
            this.lvwConsultantInfo.TabIndex = 34;
            this.lvwConsultantInfo.UseCompatibleStateImageBehavior = false;
            this.lvwConsultantInfo.View = System.Windows.Forms.View.Details;
            this.lvwConsultantInfo.Click += new System.EventHandler(this.lvwConsultantInfo_Click);
            // 
            // cabin
            // 
            this.cabin.Name = "cabin";
            this.cabin.Text = "ConsultantID";
            this.cabin.Width = 0;
            // 
            // patient_code
            // 
            this.patient_code.Name = "patient_code";
            this.patient_code.Text = "Consultant Name";
            this.patient_code.Width = 420;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-2, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(486, 30);
            this.label15.TabIndex = 145;
            this.label15.Text = "Consultant List ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPatientListConsultantwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(481, 518);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientListConsultantwise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.FrmPatientListConsultantwise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwConsultantInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader patient_code;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
    }
}