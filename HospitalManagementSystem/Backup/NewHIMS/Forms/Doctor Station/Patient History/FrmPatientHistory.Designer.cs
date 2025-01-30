namespace NewHIMS.Forms.Doctor_Station.Patient_History
{
    partial class FrmPatientHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblAdmnCode = new System.Windows.Forms.Label();
            this.lblHID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPCCSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPatientCC = new System.Windows.Forms.DataGridView();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPatientHistoryPanel = new System.Windows.Forms.Panel();
            this.grpBabyHistory = new System.Windows.Forms.GroupBox();
            this.grpGynObstHistory = new System.Windows.Forms.GroupBox();
            this.grpGeneralHistory = new System.Windows.Forms.GroupBox();
            this.trvHistoryItems = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientCC)).BeginInit();
            this.pnlPatientHistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.groupBox1);
            this.grpMain.Controls.Add(this.btnPCCSave);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Controls.Add(this.grdPatientCC);
            this.grpMain.Controls.Add(this.btnPrint);
            this.grpMain.Controls.Add(this.btnRefresh);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.btnClose);
            this.grpMain.Controls.Add(this.pnlPatientHistoryPanel);
            this.grpMain.Controls.Add(this.trvHistoryItems);
            this.grpMain.Location = new System.Drawing.Point(12, 10);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(975, 615);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPName);
            this.groupBox1.Controls.Add(this.lblAdmnCode);
            this.groupBox1.Controls.Add(this.lblHID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 43);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(415, 17);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(66, 15);
            this.lblPName.TabIndex = 5;
            this.lblPName.Text = "- - - - - - -";
            // 
            // lblAdmnCode
            // 
            this.lblAdmnCode.AutoSize = true;
            this.lblAdmnCode.Location = new System.Drawing.Point(280, 17);
            this.lblAdmnCode.Name = "lblAdmnCode";
            this.lblAdmnCode.Size = new System.Drawing.Size(66, 15);
            this.lblAdmnCode.TabIndex = 4;
            this.lblAdmnCode.Text = "- - - - - - -";
            // 
            // lblHID
            // 
            this.lblHID.AutoSize = true;
            this.lblHID.Location = new System.Drawing.Point(93, 17);
            this.lblHID.Name = "lblHID";
            this.lblHID.Size = new System.Drawing.Size(66, 15);
            this.lblHID.TabIndex = 3;
            this.lblHID.Text = "- - - - - - -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(367, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cabin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(164, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Admission Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hospital ID :";
            // 
            // btnPCCSave
            // 
            this.btnPCCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCCSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnPCCSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCCSave.Location = new System.Drawing.Point(825, 188);
            this.btnPCCSave.Name = "btnPCCSave";
            this.btnPCCSave.Size = new System.Drawing.Size(68, 23);
            this.btnPCCSave.TabIndex = 8;
            this.btnPCCSave.Text = "Save";
            this.btnPCCSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPCCSave.UseVisualStyleBackColor = true;
            this.btnPCCSave.Click += new System.EventHandler(this.btnPCCSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient CC";
            // 
            // grdPatientCC
            // 
            this.grdPatientCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatientCC.ColumnHeadersVisible = false;
            this.grdPatientCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl,
            this.cc,
            this.PCCID});
            this.grdPatientCC.EnableHeadersVisualStyles = false;
            this.grdPatientCC.Location = new System.Drawing.Point(309, 79);
            this.grdPatientCC.Name = "grdPatientCC";
            this.grdPatientCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPatientCC.RowHeadersVisible = false;
            this.grdPatientCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdPatientCC.Size = new System.Drawing.Size(584, 103);
            this.grdPatientCC.TabIndex = 6;
            this.grdPatientCC.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatientCC_RowEnter);
            // 
            // sl
            // 
            this.sl.HeaderText = "SL.";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 40;
            // 
            // cc
            // 
            this.cc.HeaderText = "Patient CC";
            this.cc.MaxInputLength = 500;
            this.cc.Name = "cc";
            this.cc.Width = 535;
            // 
            // PCCID
            // 
            this.PCCID.HeaderText = "PCCID";
            this.PCCID.Name = "PCCID";
            this.PCCID.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(356, 581);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(805, 581);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 3;
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
            this.btnSave.Location = new System.Drawing.Point(716, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "   Save";
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
            this.btnClose.Location = new System.Drawing.Point(890, 581);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "    CLose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlPatientHistoryPanel
            // 
            this.pnlPatientHistoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPatientHistoryPanel.AutoScroll = true;
            this.pnlPatientHistoryPanel.Controls.Add(this.grpBabyHistory);
            this.pnlPatientHistoryPanel.Controls.Add(this.grpGynObstHistory);
            this.pnlPatientHistoryPanel.Controls.Add(this.grpGeneralHistory);
            this.pnlPatientHistoryPanel.Location = new System.Drawing.Point(299, 218);
            this.pnlPatientHistoryPanel.Name = "pnlPatientHistoryPanel";
            this.pnlPatientHistoryPanel.Size = new System.Drawing.Size(670, 357);
            this.pnlPatientHistoryPanel.TabIndex = 1;
            // 
            // grpBabyHistory
            // 
            this.grpBabyHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBabyHistory.AutoSize = true;
            this.grpBabyHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBabyHistory.Location = new System.Drawing.Point(10, 87);
            this.grpBabyHistory.Name = "grpBabyHistory";
            this.grpBabyHistory.Size = new System.Drawing.Size(641, 35);
            this.grpBabyHistory.TabIndex = 2;
            this.grpBabyHistory.TabStop = false;
            this.grpBabyHistory.Text = "Baby History";
            // 
            // grpGynObstHistory
            // 
            this.grpGynObstHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGynObstHistory.AutoSize = true;
            this.grpGynObstHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGynObstHistory.Location = new System.Drawing.Point(10, 46);
            this.grpGynObstHistory.Name = "grpGynObstHistory";
            this.grpGynObstHistory.Size = new System.Drawing.Size(641, 36);
            this.grpGynObstHistory.TabIndex = 1;
            this.grpGynObstHistory.TabStop = false;
            this.grpGynObstHistory.Text = "Gynaecological && Obstetrical History";
            // 
            // grpGeneralHistory
            // 
            this.grpGeneralHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneralHistory.AutoSize = true;
            this.grpGeneralHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGeneralHistory.Location = new System.Drawing.Point(10, 3);
            this.grpGeneralHistory.Name = "grpGeneralHistory";
            this.grpGeneralHistory.Size = new System.Drawing.Size(641, 37);
            this.grpGeneralHistory.TabIndex = 0;
            this.grpGeneralHistory.TabStop = false;
            this.grpGeneralHistory.Text = "General History";
            this.toolTip1.SetToolTip(this.grpGeneralHistory, "xczxczx zzxcxzc");
            // 
            // trvHistoryItems
            // 
            this.trvHistoryItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trvHistoryItems.BackColor = System.Drawing.Color.White;
            this.trvHistoryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvHistoryItems.ForeColor = System.Drawing.SystemColors.WindowText;
            this.trvHistoryItems.Location = new System.Drawing.Point(6, 79);
            this.trvHistoryItems.Name = "trvHistoryItems";
            treeNode1.Name = "Node4";
            treeNode1.Text = "H/O Present Illness";
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
            this.trvHistoryItems.Size = new System.Drawing.Size(287, 530);
            this.trvHistoryItems.TabIndex = 0;
            this.trvHistoryItems.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvHistoryItems_NodeMouseDoubleClick);
            this.trvHistoryItems.DoubleClick += new System.EventHandler(this.trvHistoryItems_DoubleClick);
            // 
            // FrmPatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(990, 635);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPatientHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient History";
            this.Load += new System.EventHandler(this.FrmPatientHistory_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientCC)).EndInit();
            this.pnlPatientHistoryPanel.ResumeLayout(false);
            this.pnlPatientHistoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlPatientHistoryPanel;
        private System.Windows.Forms.GroupBox grpBabyHistory;
        private System.Windows.Forms.GroupBox grpGynObstHistory;
        private System.Windows.Forms.GroupBox grpGeneralHistory;
        private System.Windows.Forms.TreeView trvHistoryItems;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPatientCC;
        private System.Windows.Forms.Button btnPCCSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCCID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblAdmnCode;
        private System.Windows.Forms.Label lblHID;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}