namespace NewHIMS.Forms.Investigation.Investigation_Item
{
    partial class FrmInvestigationItemAddEditView
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
            this.grpInvestigationItem = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.test_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.test_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.use_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblInvestigationItemTitle = new System.Windows.Forms.Label();
            this.lblInvestigationItem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbInvesItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.re_order_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.considering_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvestigationItem = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblReOrderLevel = new System.Windows.Forms.Label();
            this.txtReOrderLevel = new System.Windows.Forms.TextBox();
            this.lblConsideringLevel = new System.Windows.Forms.Label();
            this.txtConsideringLevel = new System.Windows.Forms.TextBox();
            this.grpInvestigationItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInvestigationItem
            // 
            this.grpInvestigationItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInvestigationItem.Controls.Add(this.button2);
            this.grpInvestigationItem.Controls.Add(this.button1);
            this.grpInvestigationItem.Controls.Add(this.grdMainList);
            this.grpInvestigationItem.Controls.Add(this.btnRemove);
            this.grpInvestigationItem.Controls.Add(this.btnEdit);
            this.grpInvestigationItem.Controls.Add(this.lblInvestigationItemTitle);
            this.grpInvestigationItem.Controls.Add(this.lblInvestigationItem);
            this.grpInvestigationItem.Controls.Add(this.dataGridView1);
            this.grpInvestigationItem.Controls.Add(this.txtInvestigationItem);
            this.grpInvestigationItem.Controls.Add(this.lblUnit);
            this.grpInvestigationItem.Controls.Add(this.cmbUnit);
            this.grpInvestigationItem.Controls.Add(this.lblReOrderLevel);
            this.grpInvestigationItem.Controls.Add(this.txtReOrderLevel);
            this.grpInvestigationItem.Controls.Add(this.lblConsideringLevel);
            this.grpInvestigationItem.Controls.Add(this.txtConsideringLevel);
            this.grpInvestigationItem.Location = new System.Drawing.Point(12, 12);
            this.grpInvestigationItem.Name = "grpInvestigationItem";
            this.grpInvestigationItem.Size = new System.Drawing.Size(566, 453);
            this.grpInvestigationItem.TabIndex = 11;
            this.grpInvestigationItem.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(484, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 41);
            this.button2.TabIndex = 45;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(419, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grdMainList
            // 
            this.grdMainList.AllowUserToAddRows = false;
            this.grdMainList.AllowUserToDeleteRows = false;
            this.grdMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test_item_id,
            this.opt,
            this.test_item,
            this.use_amount});
            this.grdMainList.Location = new System.Drawing.Point(276, 92);
            this.grdMainList.Name = "grdMainList";
            this.grdMainList.Size = new System.Drawing.Size(273, 120);
            this.grdMainList.TabIndex = 44;
            // 
            // test_item_id
            // 
            this.test_item_id.HeaderText = "Test ID";
            this.test_item_id.Name = "test_item_id";
            this.test_item_id.Visible = false;
            this.test_item_id.Width = 120;
            // 
            // opt
            // 
            this.opt.HeaderText = "...";
            this.opt.Name = "opt";
            this.opt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.opt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.opt.Width = 20;
            // 
            // test_item
            // 
            this.test_item.HeaderText = "Test Name";
            this.test_item.Name = "test_item";
            this.test_item.ReadOnly = true;
            this.test_item.Width = 120;
            // 
            // use_amount
            // 
            this.use_amount.HeaderText = "Usage Qty.";
            this.use_amount.Name = "use_amount";
            this.use_amount.Width = 120;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.Location = new System.Drawing.Point(354, 406);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 41);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "Delete";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(289, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 41);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Save";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblInvestigationItemTitle
            // 
            this.lblInvestigationItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationItemTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInvestigationItemTitle.Location = new System.Drawing.Point(144, 16);
            this.lblInvestigationItemTitle.Name = "lblInvestigationItemTitle";
            this.lblInvestigationItemTitle.Size = new System.Drawing.Size(257, 34);
            this.lblInvestigationItemTitle.TabIndex = 31;
            this.lblInvestigationItemTitle.Text = "Investgation Items";
            this.lblInvestigationItemTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInvestigationItem
            // 
            this.lblInvestigationItem.AutoSize = true;
            this.lblInvestigationItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestigationItem.Location = new System.Drawing.Point(16, 95);
            this.lblInvestigationItem.Name = "lblInvestigationItem";
            this.lblInvestigationItem.Size = new System.Drawing.Size(35, 13);
            this.lblInvestigationItem.TabIndex = 9;
            this.lblInvestigationItem.Text = "Item:";
            this.lblInvestigationItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbInvesItem,
            this.unit,
            this.re_order_level,
            this.considering_level});
            this.dataGridView1.Location = new System.Drawing.Point(19, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 182);
            this.dataGridView1.TabIndex = 40;
            // 
            // cmbInvesItem
            // 
            this.cmbInvesItem.HeaderText = "Investigation Item";
            this.cmbInvesItem.Name = "cmbInvesItem";
            this.cmbInvesItem.ReadOnly = true;
            this.cmbInvesItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbInvesItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbInvesItem.Width = 120;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 120;
            // 
            // re_order_level
            // 
            this.re_order_level.HeaderText = "Re Order Level";
            this.re_order_level.Name = "re_order_level";
            this.re_order_level.ReadOnly = true;
            this.re_order_level.Width = 120;
            // 
            // considering_level
            // 
            this.considering_level.HeaderText = "Considering Level";
            this.considering_level.Name = "considering_level";
            this.considering_level.ReadOnly = true;
            this.considering_level.Width = 120;
            // 
            // txtInvestigationItem
            // 
            this.txtInvestigationItem.Location = new System.Drawing.Point(57, 92);
            this.txtInvestigationItem.Name = "txtInvestigationItem";
            this.txtInvestigationItem.Size = new System.Drawing.Size(204, 20);
            this.txtInvestigationItem.TabIndex = 0;
            this.txtInvestigationItem.Tag = "investigation_item";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(16, 117);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(34, 13);
            this.lblUnit.TabIndex = 10;
            this.lblUnit.Text = "Unit:";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(57, 114);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(204, 21);
            this.cmbUnit.TabIndex = 1;
            this.cmbUnit.Tag = "unit_id";
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReOrderLevel.Location = new System.Drawing.Point(16, 141);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(97, 13);
            this.lblReOrderLevel.TabIndex = 11;
            this.lblReOrderLevel.Text = "Re-Order Level:";
            this.lblReOrderLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Location = new System.Drawing.Point(119, 138);
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(75, 20);
            this.txtReOrderLevel.TabIndex = 2;
            this.txtReOrderLevel.Tag = "re_order_level";
            // 
            // lblConsideringLevel
            // 
            this.lblConsideringLevel.AutoSize = true;
            this.lblConsideringLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsideringLevel.Location = new System.Drawing.Point(16, 163);
            this.lblConsideringLevel.Name = "lblConsideringLevel";
            this.lblConsideringLevel.Size = new System.Drawing.Size(133, 13);
            this.lblConsideringLevel.TabIndex = 12;
            this.lblConsideringLevel.Text = "Considering Level (%):";
            this.lblConsideringLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConsideringLevel
            // 
            this.txtConsideringLevel.Location = new System.Drawing.Point(150, 160);
            this.txtConsideringLevel.Name = "txtConsideringLevel";
            this.txtConsideringLevel.Size = new System.Drawing.Size(44, 20);
            this.txtConsideringLevel.TabIndex = 3;
            this.txtConsideringLevel.Tag = "considering_level";
            this.txtConsideringLevel.Text = "100";
            // 
            // FrmInvestigationItemAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 477);
            this.Controls.Add(this.grpInvestigationItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInvestigationItemAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Item";
            this.grpInvestigationItem.ResumeLayout(false);
            this.grpInvestigationItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvestigationItem;
        private System.Windows.Forms.Label lblInvestigationItemTitle;
        private System.Windows.Forms.Label lblInvestigationItem;
        private System.Windows.Forms.TextBox txtInvestigationItem;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblReOrderLevel;
        private System.Windows.Forms.TextBox txtReOrderLevel;
        private System.Windows.Forms.Label lblConsideringLevel;
        private System.Windows.Forms.TextBox txtConsideringLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_item_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn opt;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn use_amount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbInvesItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn re_order_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn considering_level;
    }
}