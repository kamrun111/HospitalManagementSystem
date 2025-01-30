namespace NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund
{
    partial class Frmopdotherservice
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
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.lblPatientOtherItemTitle = new System.Windows.Forms.Label();
            this.lblOtherItem = new System.Windows.Forms.Label();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.lvwPatientOtherItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.isue_by = new System.Windows.Forms.ColumnHeader();
            this.Issue_Date = new System.Windows.Forms.ColumnHeader();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbotherservices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.BackColor = System.Drawing.Color.Linen;
            this.txtQtyPerUnit.Location = new System.Drawing.Point(408, 66);
            this.txtQtyPerUnit.MaxLength = 2;
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(48, 20);
            this.txtQtyPerUnit.TabIndex = 33;
            this.txtQtyPerUnit.Tag = "qty_per_unit";
            this.txtQtyPerUnit.Text = "1";
            // 
            // lblPatientOtherItemTitle
            // 
            this.lblPatientOtherItemTitle.AutoSize = true;
            this.lblPatientOtherItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientOtherItemTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPatientOtherItemTitle.Location = new System.Drawing.Point(156, 0);
            this.lblPatientOtherItemTitle.Name = "lblPatientOtherItemTitle";
            this.lblPatientOtherItemTitle.Size = new System.Drawing.Size(168, 25);
            this.lblPatientOtherItemTitle.TabIndex = 36;
            this.lblPatientOtherItemTitle.Text = "Other Services";
            // 
            // lblOtherItem
            // 
            this.lblOtherItem.AutoSize = true;
            this.lblOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherItem.Location = new System.Drawing.Point(43, 66);
            this.lblOtherItem.Name = "lblOtherItem";
            this.lblOtherItem.Size = new System.Drawing.Size(70, 13);
            this.lblOtherItem.TabIndex = 34;
            this.lblOtherItem.Text = "Other Item:";
            this.lblOtherItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(368, 69);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(34, 13);
            this.lblQtyPerUnit.TabIndex = 35;
            this.lblQtyPerUnit.Text = "Qty :";
            this.lblQtyPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwPatientOtherItem
            // 
            this.lvwPatientOtherItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.isue_by,
            this.Issue_Date});
            this.lvwPatientOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientOtherItem.GridLines = true;
            this.lvwPatientOtherItem.Location = new System.Drawing.Point(42, 94);
            this.lvwPatientOtherItem.Name = "lvwPatientOtherItem";
            this.lvwPatientOtherItem.Size = new System.Drawing.Size(450, 224);
            this.lvwPatientOtherItem.TabIndex = 58;
            this.lvwPatientOtherItem.UseCompatibleStateImageBehavior = false;
            this.lvwPatientOtherItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 63;
            // 
            // isue_by
            // 
            this.isue_by.Text = "Issue_By";
            this.isue_by.Width = 93;
            // 
            // Issue_Date
            // 
            this.Issue_Date.Text = "Issue_Date";
            this.Issue_Date.Width = 126;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(330, 324);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(241, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "  Issue";
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
            this.btnClose.Location = new System.Drawing.Point(414, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtpatientname
            // 
            this.txtpatientname.BackColor = System.Drawing.Color.Linen;
            this.txtpatientname.Enabled = false;
            this.txtpatientname.Location = new System.Drawing.Point(129, 36);
            this.txtpatientname.MaxLength = 2;
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(214, 20);
            this.txtpatientname.TabIndex = 59;
            this.txtpatientname.Tag = "qty_per_unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "P.Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbotherservices
            // 
            this.cmbotherservices.FormattingEnabled = true;
            this.cmbotherservices.Location = new System.Drawing.Point(129, 65);
            this.cmbotherservices.Name = "cmbotherservices";
            this.cmbotherservices.Size = new System.Drawing.Size(214, 21);
            this.cmbotherservices.TabIndex = 61;
            // 
            // Frmopdotherservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 359);
            this.Controls.Add(this.cmbotherservices);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwPatientOtherItem);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtQtyPerUnit);
            this.Controls.Add(this.lblPatientOtherItemTitle);
            this.Controls.Add(this.lblOtherItem);
            this.Controls.Add(this.lblQtyPerUnit);
            this.Name = "Frmopdotherservice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPD Other Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtyPerUnit;
        private System.Windows.Forms.Label lblPatientOtherItemTitle;
        private System.Windows.Forms.Label lblOtherItem;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.ListView lvwPatientOtherItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader isue_by;
        private System.Windows.Forms.ColumnHeader Issue_Date;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbotherservices;
    }
}