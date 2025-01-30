namespace NewHIMS.Forms.Doctor_Station.ConultantList
{
    partial class FrmConsultantList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("H/O Present Illness");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Menstrual History");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("General History", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("L.M.P");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rh (d)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gynaecological & Obstetrical History", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mother\'s Name");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Weight");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Baby History", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblForDoctors = new System.Windows.Forms.Label();
            this.lblForReceiption = new System.Windows.Forms.Label();
            this.lblForNurse = new System.Windows.Forms.Label();
            this.txtForReceiption = new System.Windows.Forms.TextBox();
            this.txtForNurse = new System.Windows.Forms.TextBox();
            this.txtForDoctors = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.trvHistoryItems = new System.Windows.Forms.TreeView();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.lblForDoctors);
            this.grpMain.Controls.Add(this.lblForReceiption);
            this.grpMain.Controls.Add(this.lblForNurse);
            this.grpMain.Controls.Add(this.txtForReceiption);
            this.grpMain.Controls.Add(this.txtForNurse);
            this.grpMain.Controls.Add(this.txtForDoctors);
            this.grpMain.Controls.Add(this.btnRefresh);
            this.grpMain.Controls.Add(this.btnClose);
            this.grpMain.Controls.Add(this.trvHistoryItems);
            this.grpMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(12, 10);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(568, 558);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Consultant List";
            // 
            // lblForDoctors
            // 
            this.lblForDoctors.AutoSize = true;
            this.lblForDoctors.Location = new System.Drawing.Point(404, 16);
            this.lblForDoctors.Name = "lblForDoctors";
            this.lblForDoctors.Size = new System.Drawing.Size(96, 13);
            this.lblForDoctors.TabIndex = 10;
            this.lblForDoctors.Text = "FOR DOCTORS";
            // 
            // lblForReceiption
            // 
            this.lblForReceiption.AutoSize = true;
            this.lblForReceiption.Location = new System.Drawing.Point(404, 16);
            this.lblForReceiption.Name = "lblForReceiption";
            this.lblForReceiption.Size = new System.Drawing.Size(111, 13);
            this.lblForReceiption.TabIndex = 9;
            this.lblForReceiption.Text = "FOR RECEIPTION";
            // 
            // lblForNurse
            // 
            this.lblForNurse.AutoSize = true;
            this.lblForNurse.Location = new System.Drawing.Point(410, 16);
            this.lblForNurse.Name = "lblForNurse";
            this.lblForNurse.Size = new System.Drawing.Size(79, 13);
            this.lblForNurse.TabIndex = 8;
            this.lblForNurse.Text = "FOR NURSE";
            // 
            // txtForReceiption
            // 
            this.txtForReceiption.BackColor = System.Drawing.Color.Linen;
            this.txtForReceiption.Location = new System.Drawing.Point(356, 32);
            this.txtForReceiption.Multiline = true;
            this.txtForReceiption.Name = "txtForReceiption";
            this.txtForReceiption.ReadOnly = true;
            this.txtForReceiption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtForReceiption.Size = new System.Drawing.Size(198, 486);
            this.txtForReceiption.TabIndex = 7;
            // 
            // txtForNurse
            // 
            this.txtForNurse.BackColor = System.Drawing.Color.White;
            this.txtForNurse.Location = new System.Drawing.Point(356, 32);
            this.txtForNurse.Multiline = true;
            this.txtForNurse.Name = "txtForNurse";
            this.txtForNurse.ReadOnly = true;
            this.txtForNurse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtForNurse.Size = new System.Drawing.Size(198, 486);
            this.txtForNurse.TabIndex = 6;
            // 
            // txtForDoctors
            // 
            this.txtForDoctors.BackColor = System.Drawing.Color.White;
            this.txtForDoctors.Location = new System.Drawing.Point(356, 32);
            this.txtForDoctors.Multiline = true;
            this.txtForDoctors.Name = "txtForDoctors";
            this.txtForDoctors.ReadOnly = true;
            this.txtForDoctors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtForDoctors.Size = new System.Drawing.Size(198, 486);
            this.txtForDoctors.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(-44, 524);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(41, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // trvHistoryItems
            // 
            this.trvHistoryItems.BackColor = System.Drawing.Color.Linen;
            this.trvHistoryItems.ForeColor = System.Drawing.SystemColors.WindowText;
            this.trvHistoryItems.Location = new System.Drawing.Point(17, 32);
            this.trvHistoryItems.Name = "trvHistoryItems";
            treeNode1.Checked = true;
            treeNode1.Name = "Node4";
            treeNode1.Text = "H/O Present Illness";
            treeNode2.Checked = true;
            treeNode2.Name = "Node6";
            treeNode2.Text = "Menstrual History";
            treeNode3.Name = "Node0";
            treeNode3.Text = "General History";
            treeNode4.Name = "Node7";
            treeNode4.Text = "L.M.P";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Rh (d)";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Gynaecological & Obstetrical History";
            treeNode7.Name = "Node9";
            treeNode7.Text = "Mother\'s Name";
            treeNode8.Name = "Node10";
            treeNode8.Text = "Weight";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Baby History";
            this.trvHistoryItems.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.trvHistoryItems.Size = new System.Drawing.Size(321, 486);
            this.trvHistoryItems.TabIndex = 0;
            // 
            // FrmConsultantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(592, 578);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultantList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultant List";
            this.Load += new System.EventHandler(this.FrmConsultantList_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblForDoctors;
        private System.Windows.Forms.Label lblForReceiption;
        private System.Windows.Forms.Label lblForNurse;
        private System.Windows.Forms.TextBox txtForReceiption;
        private System.Windows.Forms.TextBox txtForNurse;
        private System.Windows.Forms.TextBox txtForDoctors;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TreeView trvHistoryItems;
    }
}