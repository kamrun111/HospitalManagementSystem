namespace NewHIMS.Forms.Doctor_Station.Doctor_Visit
{
    partial class FrmPatientResult
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
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.test_element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMainList
            // 
            this.grdMainList.AllowUserToAddRows = false;
            this.grdMainList.AllowUserToDeleteRows = false;
            this.grdMainList.AllowUserToOrderColumns = true;
            this.grdMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test_element,
            this.reference_value,
            this.Result});
            this.grdMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMainList.Location = new System.Drawing.Point(12, 12);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.ReadOnly = true;
            this.grdMainList.RowHeadersWidth = 15;
            this.grdMainList.Size = new System.Drawing.Size(324, 159);
            this.grdMainList.TabIndex = 5;
            // 
            // test_element
            // 
            this.test_element.HeaderText = "Test Element";
            this.test_element.Name = "test_element";
            this.test_element.ReadOnly = true;
            // 
            // reference_value
            // 
            this.reference_value.HeaderText = "Normal Range";
            this.reference_value.Name = "reference_value";
            this.reference_value.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(278, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPatientResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(351, 208);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdMainList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPatientResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Pathology  Result";
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_element;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}