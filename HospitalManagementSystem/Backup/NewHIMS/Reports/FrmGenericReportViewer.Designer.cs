namespace NewHIMS.Reports
{
    partial class FrmGenericReportViewer
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
            this.crvParameter = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvParameter
            // 
            this.crvParameter.ActiveViewIndex = -1;
            this.crvParameter.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.crvParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvParameter.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvParameter.DisplayBackgroundEdge = false;
            this.crvParameter.DisplayGroupTree = false;
            this.crvParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvParameter.Location = new System.Drawing.Point(0, 0);
            this.crvParameter.Name = "crvParameter";
            this.crvParameter.SelectionFormula = "";
            this.crvParameter.ShowGroupTreeButton = false;
            this.crvParameter.ShowRefreshButton = false;
            this.crvParameter.Size = new System.Drawing.Size(815, 684);
            this.crvParameter.TabIndex = 1;
            this.crvParameter.ViewTimeSelectionFormula = "";
            // 
            // FrmGenericReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 684);
            this.Controls.Add(this.crvParameter);
            this.Name = "FrmGenericReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvParameter;


        //private CrystalReportPatientAdmission CrystalReportPatientAdmission1;
    }
}