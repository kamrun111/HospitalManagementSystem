namespace NewHIMS.Forms.Receiptions.Other_Item
{
    partial class FrmPatientOtherItemAddEditView
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
            this.grpPatientOtherItem = new System.Windows.Forms.GroupBox();
            this.lvwPatientOtherItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.hospital_id = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.RegistrationID = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatientOtherItemTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOtherItem = new System.Windows.Forms.Label();
            this.cmbOtherItem = new System.Windows.Forms.ComboBox();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.grpPatientOtherItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatientOtherItem
            // 
            this.grpPatientOtherItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientOtherItem.Controls.Add(this.lvwPatientOtherItem);
            this.grpPatientOtherItem.Controls.Add(this.txtQtyPerUnit);
            this.grpPatientOtherItem.Controls.Add(this.cmbFloor);
            this.grpPatientOtherItem.Controls.Add(this.lvwPatientInfo);
            this.grpPatientOtherItem.Controls.Add(this.label4);
            this.grpPatientOtherItem.Controls.Add(this.lblPatientOtherItemTitle);
            this.grpPatientOtherItem.Controls.Add(this.btnRefresh);
            this.grpPatientOtherItem.Controls.Add(this.btnSave);
            this.grpPatientOtherItem.Controls.Add(this.btnClose);
            this.grpPatientOtherItem.Controls.Add(this.lblOtherItem);
            this.grpPatientOtherItem.Controls.Add(this.cmbOtherItem);
            this.grpPatientOtherItem.Controls.Add(this.lblQtyPerUnit);
            this.grpPatientOtherItem.Location = new System.Drawing.Point(12, 8);
            this.grpPatientOtherItem.Name = "grpPatientOtherItem";
            this.grpPatientOtherItem.Size = new System.Drawing.Size(526, 509);
            this.grpPatientOtherItem.TabIndex = 11;
            this.grpPatientOtherItem.TabStop = false;
            // 
            // lvwPatientOtherItem
            // 
            this.lvwPatientOtherItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwPatientOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientOtherItem.GridLines = true;
            this.lvwPatientOtherItem.Location = new System.Drawing.Point(214, 118);
            this.lvwPatientOtherItem.Name = "lvwPatientOtherItem";
            this.lvwPatientOtherItem.Size = new System.Drawing.Size(297, 350);
            this.lvwPatientOtherItem.TabIndex = 54;
            this.lvwPatientOtherItem.UseCompatibleStateImageBehavior = false;
            this.lvwPatientOtherItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 90;
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.BackColor = System.Drawing.Color.Linen;
            this.txtQtyPerUnit.Location = new System.Drawing.Point(297, 92);
            this.txtQtyPerUnit.MaxLength = 4;
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(85, 20);
            this.txtQtyPerUnit.TabIndex = 5;
            this.txtQtyPerUnit.Tag = "qty_per_unit";
            this.txtQtyPerUnit.Text = "1";
            this.txtQtyPerUnit.Leave += new System.EventHandler(this.txtQtyPerUnit_Leave);
            this.txtQtyPerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyPerUnit_KeyPress);
            // 
            // cmbFloor
            // 
            this.cmbFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFloor.BackColor = System.Drawing.Color.Linen;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(42, 68);
            this.cmbFloor.MaxLength = 10;
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(143, 21);
            this.cmbFloor.Sorted = true;
            this.cmbFloor.TabIndex = 51;
            this.cmbFloor.Tag = "floor";
            this.cmbFloor.Leave += new System.EventHandler(this.cmbFloor_Leave);
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // lvwPatientInfo
            // 
            this.lvwPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPatientInfo.BackColor = System.Drawing.Color.Linen;
            this.lvwPatientInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabin,
            this.hospital_id,
            this.admission_id,
            this.RegistrationID});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(6, 94);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(179, 408);
            this.lvwPatientInfo.TabIndex = 52;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.SelectedIndexChanged += new System.EventHandler(this.lvwPatientInfo_SelectedIndexChanged);
            // 
            // cabin
            // 
            this.cabin.Text = "Cabin";
            this.cabin.Width = 50;
            // 
            // hospital_id
            // 
            this.hospital_id.Text = "Hospital ID";
            this.hospital_id.Width = 0;
            // 
            // admission_id
            // 
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // RegistrationID
            // 
            this.RegistrationID.Text = "RegistrationID";
            this.RegistrationID.Width = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Floor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatientOtherItemTitle
            // 
            this.lblPatientOtherItemTitle.AutoSize = true;
            this.lblPatientOtherItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientOtherItemTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPatientOtherItemTitle.Location = new System.Drawing.Point(140, 12);
            this.lblPatientOtherItemTitle.Name = "lblPatientOtherItemTitle";
            this.lblPatientOtherItemTitle.Size = new System.Drawing.Size(208, 31);
            this.lblPatientOtherItemTitle.TabIndex = 31;
            this.lblPatientOtherItemTitle.Text = "Other Services";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(349, 474);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(260, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 29;
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
            this.btnClose.Location = new System.Drawing.Point(433, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOtherItem
            // 
            this.lblOtherItem.AutoSize = true;
            this.lblOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherItem.Location = new System.Drawing.Point(211, 71);
            this.lblOtherItem.Name = "lblOtherItem";
            this.lblOtherItem.Size = new System.Drawing.Size(70, 13);
            this.lblOtherItem.TabIndex = 12;
            this.lblOtherItem.Text = "Other Item:";
            this.lblOtherItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOtherItem
            // 
            this.cmbOtherItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOtherItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOtherItem.BackColor = System.Drawing.Color.Linen;
            this.cmbOtherItem.FormattingEnabled = true;
            this.cmbOtherItem.Location = new System.Drawing.Point(297, 68);
            this.cmbOtherItem.MaxLength = 50;
            this.cmbOtherItem.Name = "cmbOtherItem";
            this.cmbOtherItem.Size = new System.Drawing.Size(214, 21);
            this.cmbOtherItem.Sorted = true;
            this.cmbOtherItem.TabIndex = 1;
            this.cmbOtherItem.Tag = "other_item_id";
            this.cmbOtherItem.Leave += new System.EventHandler(this.cmbOtherItem_Leave);
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(211, 95);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(80, 13);
            this.lblQtyPerUnit.TabIndex = 16;
            this.lblQtyPerUnit.Text = "Qty Per Unit:";
            this.lblQtyPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPatientOtherItemAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(550, 525);
            this.Controls.Add(this.grpPatientOtherItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPatientOtherItemAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Other Item";
            this.Load += new System.EventHandler(this.FrmPatientOtherItemAddEditView_Load);
            this.grpPatientOtherItem.ResumeLayout(false);
            this.grpPatientOtherItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatientOtherItem;
        private System.Windows.Forms.TextBox txtQtyPerUnit;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.ListView lvwPatientInfo;
        private System.Windows.Forms.ColumnHeader cabin;
        private System.Windows.Forms.ColumnHeader hospital_id;
        private System.Windows.Forms.ColumnHeader admission_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPatientOtherItemTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOtherItem;
        private System.Windows.Forms.ComboBox cmbOtherItem;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.ListView lvwPatientOtherItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader RegistrationID;
    }
}