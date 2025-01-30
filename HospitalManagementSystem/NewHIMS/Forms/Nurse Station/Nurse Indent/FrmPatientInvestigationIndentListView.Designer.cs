namespace NewHIMS.Forms.Nurse_Station.Nurse_Indent
{
    partial class FrmPatientInvestigationIndentListView
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
            this.components = new System.ComponentModel.Container();
            this.grpPatientMedicineIndent = new System.Windows.Forms.GroupBox();
            this.btnDoneByPatient = new System.Windows.Forms.Button();
            this.lvwInvestigation = new System.Windows.Forms.ListView();
            this.test_item = new System.Windows.Forms.ColumnHeader();
            this.test_group = new System.Windows.Forms.ColumnHeader();
            this.test_department = new System.Windows.Forms.ColumnHeader();
            this.test_item_id = new System.Windows.Forms.ColumnHeader();
            this.test_group_id = new System.Windows.Forms.ColumnHeader();
            this.test_department_id = new System.Windows.Forms.ColumnHeader();
            this.consultant_id = new System.Windows.Forms.ColumnHeader();
            this.test_item_charge = new System.Windows.Forms.ColumnHeader();
            this.visit_investigation_id = new System.Windows.Forms.ColumnHeader();
            this.specimen_id = new System.Windows.Forms.ColumnHeader();
            this.baby_test = new System.Windows.Forms.ColumnHeader();
            this.btnIndent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPatientMedicineIndentTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpPatientMedicineIndent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatientMedicineIndent
            // 
            this.grpPatientMedicineIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientMedicineIndent.Controls.Add(this.btnDoneByPatient);
            this.grpPatientMedicineIndent.Controls.Add(this.lvwInvestigation);
            this.grpPatientMedicineIndent.Controls.Add(this.btnIndent);
            this.grpPatientMedicineIndent.Controls.Add(this.btnRefresh);
            this.grpPatientMedicineIndent.Controls.Add(this.btnClose);
            this.grpPatientMedicineIndent.Controls.Add(this.lblPatientMedicineIndentTitle);
            this.grpPatientMedicineIndent.Location = new System.Drawing.Point(12, 9);
            this.grpPatientMedicineIndent.Name = "grpPatientMedicineIndent";
            this.grpPatientMedicineIndent.Size = new System.Drawing.Size(415, 313);
            this.grpPatientMedicineIndent.TabIndex = 2;
            this.grpPatientMedicineIndent.TabStop = false;
            // 
            // btnDoneByPatient
            // 
            this.btnDoneByPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoneByPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoneByPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneByPatient.Image = global::NewHIMS.Properties.Resources.Save;
            this.btnDoneByPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoneByPatient.Location = new System.Drawing.Point(8, 251);
            this.btnDoneByPatient.Name = "btnDoneByPatient";
            this.btnDoneByPatient.Size = new System.Drawing.Size(107, 52);
            this.btnDoneByPatient.TabIndex = 34;
            this.btnDoneByPatient.Text = "Done By Patient";
            this.btnDoneByPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoneByPatient.UseVisualStyleBackColor = true;
            this.btnDoneByPatient.Click += new System.EventHandler(this.btnDoneByPatient_Click);
            // 
            // lvwInvestigation
            // 
            this.lvwInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInvestigation.BackColor = System.Drawing.Color.White;
            this.lvwInvestigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.test_item,
            this.test_group,
            this.test_department,
            this.test_item_id,
            this.test_group_id,
            this.test_department_id,
            this.consultant_id,
            this.test_item_charge,
            this.visit_investigation_id,
            this.specimen_id,
            this.baby_test});
            this.lvwInvestigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInvestigation.ForeColor = System.Drawing.Color.Black;
            this.lvwInvestigation.FullRowSelect = true;
            this.lvwInvestigation.GridLines = true;
            this.lvwInvestigation.HideSelection = false;
            this.lvwInvestigation.Location = new System.Drawing.Point(8, 77);
            this.lvwInvestigation.Name = "lvwInvestigation";
            this.lvwInvestigation.Size = new System.Drawing.Size(398, 165);
            this.lvwInvestigation.TabIndex = 0;
            this.lvwInvestigation.UseCompatibleStateImageBehavior = false;
            this.lvwInvestigation.View = System.Windows.Forms.View.Details;
            // 
            // test_item
            // 
            this.test_item.Name = "test_item";
            this.test_item.Text = "Test Item";
            this.test_item.Width = 160;
            // 
            // test_group
            // 
            this.test_group.Name = "test_group";
            this.test_group.Text = "Group";
            this.test_group.Width = 115;
            // 
            // test_department
            // 
            this.test_department.Name = "test_department";
            this.test_department.Text = "Department";
            this.test_department.Width = 90;
            // 
            // test_item_id
            // 
            this.test_item_id.Name = "test_item_id";
            this.test_item_id.Text = "TID";
            this.test_item_id.Width = 0;
            // 
            // test_group_id
            // 
            this.test_group_id.Name = "test_group_id";
            this.test_group_id.Text = "GID";
            this.test_group_id.Width = 0;
            // 
            // test_department_id
            // 
            this.test_department_id.Name = "test_department_id";
            this.test_department_id.Text = "DID";
            this.test_department_id.Width = 0;
            // 
            // consultant_id
            // 
            this.consultant_id.Name = "consultant_id";
            this.consultant_id.Text = "CID";
            this.consultant_id.Width = 0;
            // 
            // test_item_charge
            // 
            this.test_item_charge.Text = "test_item_charge";
            this.test_item_charge.Width = 0;
            // 
            // visit_investigation_id
            // 
            this.visit_investigation_id.Text = "visit_investigation_id";
            this.visit_investigation_id.Width = 0;
            // 
            // specimen_id
            // 
            this.specimen_id.Text = "SpecimenID";
            this.specimen_id.Width = 0;
            // 
            // baby_test
            // 
            this.baby_test.Text = "Baby Test";
            this.baby_test.Width = 0;
            // 
            // btnIndent
            // 
            this.btnIndent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIndent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndent.Enabled = false;
            this.btnIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndent.Image = global::NewHIMS.Properties.Resources.Save;
            this.btnIndent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndent.Location = new System.Drawing.Point(220, 251);
            this.btnIndent.Name = "btnIndent";
            this.btnIndent.Size = new System.Drawing.Size(59, 52);
            this.btnIndent.TabIndex = 1;
            this.btnIndent.Text = "Indent";
            this.btnIndent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIndent.UseVisualStyleBackColor = true;
            this.btnIndent.Click += new System.EventHandler(this.btnIndent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(285, 251);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 52);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.Close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(350, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 52);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPatientMedicineIndentTitle
            // 
            this.lblPatientMedicineIndentTitle.AutoSize = true;
            this.lblPatientMedicineIndentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientMedicineIndentTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPatientMedicineIndentTitle.Location = new System.Drawing.Point(72, 27);
            this.lblPatientMedicineIndentTitle.Name = "lblPatientMedicineIndentTitle";
            this.lblPatientMedicineIndentTitle.Size = new System.Drawing.Size(271, 31);
            this.lblPatientMedicineIndentTitle.TabIndex = 33;
            this.lblPatientMedicineIndentTitle.Text = "Investigation Indent";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "oiyfiowyao";
            // 
            // FrmPatientInvestigationIndentListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 330);
            this.Controls.Add(this.grpPatientMedicineIndent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPatientInvestigationIndentListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Indent";
            this.Load += new System.EventHandler(this.FrmPatientInvestigationIndentListView_Load);
            this.grpPatientMedicineIndent.ResumeLayout(false);
            this.grpPatientMedicineIndent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatientMedicineIndent;
        private System.Windows.Forms.Button btnDoneByPatient;
        private System.Windows.Forms.ListView lvwInvestigation;
        private System.Windows.Forms.ColumnHeader test_item;
        private System.Windows.Forms.ColumnHeader test_group;
        private System.Windows.Forms.ColumnHeader test_department;
        private System.Windows.Forms.ColumnHeader test_item_id;
        private System.Windows.Forms.ColumnHeader test_group_id;
        private System.Windows.Forms.ColumnHeader test_department_id;
        private System.Windows.Forms.ColumnHeader consultant_id;
        private System.Windows.Forms.Button btnIndent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPatientMedicineIndentTitle;
        private System.Windows.Forms.ColumnHeader test_item_charge;
        private System.Windows.Forms.ColumnHeader visit_investigation_id;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader specimen_id;
        private System.Windows.Forms.ColumnHeader baby_test;
    }
}