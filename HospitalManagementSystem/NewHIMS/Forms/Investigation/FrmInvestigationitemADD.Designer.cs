namespace NewHIMS.Forms.Investigation
{
    partial class FrmInvestigationitemADD
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
            this.lblDepartemt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTestGroup = new System.Windows.Forms.ComboBox();
            this.cmbTestDepartemt = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lvwTestitem = new System.Windows.Forms.ListView();
            this.test_item_id = new System.Windows.Forms.ColumnHeader();
            this.test_item = new System.Windows.Forms.ColumnHeader();
            this.SpecimenID = new System.Windows.Forms.ColumnHeader();
            this.Specimen = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.test_group_id = new System.Windows.Forms.ColumnHeader();
            this.role_no = new System.Windows.Forms.ColumnHeader();
            this.btnTestItemClose = new System.Windows.Forms.Button();
            this.btnTestItemRefresh = new System.Windows.Forms.Button();
            this.cmbspecimen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lnkTestElement = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartemt
            // 
            this.lblDepartemt.AutoSize = true;
            this.lblDepartemt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartemt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDepartemt.Location = new System.Drawing.Point(32, 99);
            this.lblDepartemt.Name = "lblDepartemt";
            this.lblDepartemt.Size = new System.Drawing.Size(98, 19);
            this.lblDepartemt.TabIndex = 33;
            this.lblDepartemt.Text = "Department:";
            this.lblDepartemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Group:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTestGroup
            // 
            this.cmbTestGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestGroup.BackColor = System.Drawing.Color.White;
            this.cmbTestGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTestGroup.FormattingEnabled = true;
            this.cmbTestGroup.Location = new System.Drawing.Point(100, 24);
            this.cmbTestGroup.Name = "cmbTestGroup";
            this.cmbTestGroup.Size = new System.Drawing.Size(238, 21);
            this.cmbTestGroup.TabIndex = 45;
            this.cmbTestGroup.Tag = "patient_id";
            this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
            // 
            // cmbTestDepartemt
            // 
            this.cmbTestDepartemt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestDepartemt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestDepartemt.BackColor = System.Drawing.Color.White;
            this.cmbTestDepartemt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestDepartemt.FormattingEnabled = true;
            this.cmbTestDepartemt.Location = new System.Drawing.Point(136, 99);
            this.cmbTestDepartemt.Name = "cmbTestDepartemt";
            this.cmbTestDepartemt.Size = new System.Drawing.Size(222, 21);
            this.cmbTestDepartemt.TabIndex = 49;
            this.cmbTestDepartemt.Tag = "patient_id";
            this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(265, 117);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(73, 22);
            this.txtprice.TabIndex = 50;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // lvwTestitem
            // 
            this.lvwTestitem.BackColor = System.Drawing.SystemColors.Info;
            this.lvwTestitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.test_item_id,
            this.test_item,
            this.SpecimenID,
            this.Specimen,
            this.Price,
            this.test_group_id,
            this.role_no});
            this.lvwTestitem.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTestitem.FullRowSelect = true;
            this.lvwTestitem.GridLines = true;
            this.lvwTestitem.HideSelection = false;
            this.lvwTestitem.Location = new System.Drawing.Point(414, 69);
            this.lvwTestitem.Name = "lvwTestitem";
            this.lvwTestitem.Size = new System.Drawing.Size(520, 444);
            this.lvwTestitem.TabIndex = 56;
            this.lvwTestitem.UseCompatibleStateImageBehavior = false;
            this.lvwTestitem.View = System.Windows.Forms.View.Details;
            this.lvwTestitem.Click += new System.EventHandler(this.lvwTestitem_Click);
            // 
            // test_item_id
            // 
            this.test_item_id.Text = "test_item_id";
            this.test_item_id.Width = 0;
            // 
            // test_item
            // 
            this.test_item.Text = "Test Item";
            this.test_item.Width = 275;
            // 
            // SpecimenID
            // 
            this.SpecimenID.Text = "SpecimenID";
            this.SpecimenID.Width = 0;
            // 
            // Specimen
            // 
            this.Specimen.Text = "Specimen";
            this.Specimen.Width = 90;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 73;
            // 
            // test_group_id
            // 
            this.test_group_id.Text = "test_group_id";
            this.test_group_id.Width = 0;
            // 
            // role_no
            // 
            this.role_no.Text = "Serial";
            this.role_no.Width = 50;
            // 
            // btnTestItemClose
            // 
            this.btnTestItemClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTestItemClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestItemClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestItemClose.Location = new System.Drawing.Point(807, 490);
            this.btnTestItemClose.Name = "btnTestItemClose";
            this.btnTestItemClose.Size = new System.Drawing.Size(75, 26);
            this.btnTestItemClose.TabIndex = 55;
            this.btnTestItemClose.Text = "Close";
            this.btnTestItemClose.UseVisualStyleBackColor = false;
            this.btnTestItemClose.Click += new System.EventHandler(this.btnTestItemClose_Click);
            // 
            // btnTestItemRefresh
            // 
            this.btnTestItemRefresh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTestItemRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestItemRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestItemRefresh.Location = new System.Drawing.Point(679, 490);
            this.btnTestItemRefresh.Name = "btnTestItemRefresh";
            this.btnTestItemRefresh.Size = new System.Drawing.Size(75, 26);
            this.btnTestItemRefresh.TabIndex = 54;
            this.btnTestItemRefresh.Text = "Refresh";
            this.btnTestItemRefresh.UseVisualStyleBackColor = false;
            this.btnTestItemRefresh.Click += new System.EventHandler(this.btnTestItemRefresh_Click);
            // 
            // cmbspecimen
            // 
            this.cmbspecimen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbspecimen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbspecimen.BackColor = System.Drawing.Color.White;
            this.cmbspecimen.FormattingEnabled = true;
            this.cmbspecimen.Location = new System.Drawing.Point(100, 116);
            this.cmbspecimen.Name = "cmbspecimen";
            this.cmbspecimen.Size = new System.Drawing.Size(93, 22);
            this.cmbspecimen.TabIndex = 58;
            this.cmbspecimen.Tag = "patient_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Specimen:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTestName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxSerialNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.cmbspecimen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTestGroup);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 211);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Add";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestName.Location = new System.Drawing.Point(100, 68);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(238, 22);
            this.textBoxTestName.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(10, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Serial  No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(5, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 104;
            this.label8.Text = "Test Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerialNo.Location = new System.Drawing.Point(100, 162);
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(73, 22);
            this.textBoxSerialNo.TabIndex = 106;
            this.textBoxSerialNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(210, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Price :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(297, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lnkTestElement
            // 
            this.lnkTestElement.AutoSize = true;
            this.lnkTestElement.Enabled = false;
            this.lnkTestElement.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTestElement.Location = new System.Drawing.Point(125, 458);
            this.lnkTestElement.Name = "lnkTestElement";
            this.lnkTestElement.Size = new System.Drawing.Size(157, 29);
            this.lnkTestElement.TabIndex = 105;
            this.lnkTestElement.TabStop = true;
            this.lnkTestElement.Text = "Test Element";
            this.lnkTestElement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIndentMedicine_LinkClicked);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCoral;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(974, 33);
            this.label10.TabIndex = 106;
            this.label10.Text = "Test Name Add";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(405, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 466);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(16, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 466);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(10, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 83);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnTestItemClose);
            this.groupBox7.Controls.Add(this.btnTestItemRefresh);
            this.groupBox7.Location = new System.Drawing.Point(7, 45);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(946, 532);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // FrmInvestigationitemADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(965, 587);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lnkTestElement);
            this.Controls.Add(this.lvwTestitem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDepartemt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTestDepartemt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvestigationitemADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Items ADD";
            this.Load += new System.EventHandler(this.FrmInvestigationitemADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartemt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTestGroup;
        private System.Windows.Forms.ComboBox cmbTestDepartemt;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.ListView lvwTestitem;
        private System.Windows.Forms.ColumnHeader test_item_id;
        private System.Windows.Forms.ColumnHeader test_item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnTestItemClose;
        private System.Windows.Forms.Button btnTestItemRefresh;
        private System.Windows.Forms.ComboBox cmbspecimen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Specimen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader SpecimenID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.ColumnHeader test_group_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkTestElement;
        private System.Windows.Forms.ColumnHeader role_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSerialNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}