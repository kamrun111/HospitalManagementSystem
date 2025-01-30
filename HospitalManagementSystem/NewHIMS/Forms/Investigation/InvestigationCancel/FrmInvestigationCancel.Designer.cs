namespace NewHIMS.Forms.Investigation.InvestigationCancel
{
    partial class FrmInvestigationCancel
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
            this.lblPatientCode = new System.Windows.Forms.Label();
            this.txtPatientType = new System.Windows.Forms.TextBox();
            this.txtPatientCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPatientCode
            // 
            this.lblPatientCode.AutoSize = true;
            this.lblPatientCode.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPatientCode.Location = new System.Drawing.Point(12, 9);
            this.lblPatientCode.Name = "lblPatientCode";
            this.lblPatientCode.Size = new System.Drawing.Size(84, 19);
            this.lblPatientCode.TabIndex = 96;
            this.lblPatientCode.Text = "Patient ID:";
            this.lblPatientCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPatientType
            // 
            this.txtPatientType.BackColor = System.Drawing.Color.MistyRose;
            this.txtPatientType.ForeColor = System.Drawing.Color.Firebrick;
            this.txtPatientType.Location = new System.Drawing.Point(102, 10);
            this.txtPatientType.Name = "txtPatientType";
            this.txtPatientType.ReadOnly = true;
            this.txtPatientType.Size = new System.Drawing.Size(30, 20);
            this.txtPatientType.TabIndex = 97;
            this.txtPatientType.Tag = "";
            this.txtPatientType.Text = "OPD";
            // 
            // txtPatientCode
            // 
            this.txtPatientCode.BackColor = System.Drawing.Color.White;
            this.txtPatientCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPatientCode.Location = new System.Drawing.Point(138, 10);
            this.txtPatientCode.MaxLength = 8;
            this.txtPatientCode.Name = "txtPatientCode";
            this.txtPatientCode.ReadOnly = true;
            this.txtPatientCode.Size = new System.Drawing.Size(77, 20);
            this.txtPatientCode.TabIndex = 95;
            this.txtPatientCode.Tag = "patient_code";
            // 
            // FrmInvestigationCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 473);
            this.Controls.Add(this.lblPatientCode);
            this.Controls.Add(this.txtPatientType);
            this.Controls.Add(this.txtPatientCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvestigationCancel";
            this.Text = "Investigation    Cancel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientCode;
        private System.Windows.Forms.TextBox txtPatientType;
        private System.Windows.Forms.TextBox txtPatientCode;
    }
}