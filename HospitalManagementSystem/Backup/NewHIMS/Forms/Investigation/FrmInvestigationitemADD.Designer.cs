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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTestItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTestGroup = new System.Windows.Forms.ComboBox();
            this.cmbTestDepartemt = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTestitem = new System.Windows.Forms.ListView();
            this.test_item_id = new System.Windows.Forms.ColumnHeader();
            this.test_item = new System.Windows.Forms.ColumnHeader();
            this.SpecimenID = new System.Windows.Forms.ColumnHeader();
            this.Specimen = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.btnTestItemClose = new System.Windows.Forms.Button();
            this.btnTestItemRefresh = new System.Windows.Forms.Button();
            this.btnTestItem = new System.Windows.Forms.Button();
            this.cmbspecimen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReferance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbTestelement = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpelement = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpelement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartemt
            // 
            this.lblDepartemt.AutoSize = true;
            this.lblDepartemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartemt.Location = new System.Drawing.Point(29, 73);
            this.lblDepartemt.Name = "lblDepartemt";
            this.lblDepartemt.Size = new System.Drawing.Size(76, 13);
            this.lblDepartemt.TabIndex = 33;
            this.lblDepartemt.Text = "Department:";
            this.lblDepartemt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Test Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTestItem
            // 
            this.cmbTestItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestItem.BackColor = System.Drawing.Color.White;
            this.cmbTestItem.FormattingEnabled = true;
            this.cmbTestItem.Location = new System.Drawing.Point(139, 133);
            this.cmbTestItem.Name = "cmbTestItem";
            this.cmbTestItem.Size = new System.Drawing.Size(222, 21);
            this.cmbTestItem.TabIndex = 46;
            this.cmbTestItem.Tag = "";
            this.cmbTestItem.SelectedIndexChanged += new System.EventHandler(this.cmbTestItem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Group:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTestGroup
            // 
            this.cmbTestGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestGroup.BackColor = System.Drawing.Color.White;
            this.cmbTestGroup.FormattingEnabled = true;
            this.cmbTestGroup.Location = new System.Drawing.Point(139, 103);
            this.cmbTestGroup.Name = "cmbTestGroup";
            this.cmbTestGroup.Size = new System.Drawing.Size(222, 21);
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
            this.cmbTestDepartemt.Location = new System.Drawing.Point(139, 73);
            this.cmbTestDepartemt.Name = "cmbTestDepartemt";
            this.cmbTestDepartemt.Size = new System.Drawing.Size(222, 21);
            this.cmbTestDepartemt.TabIndex = 49;
            this.cmbTestDepartemt.Tag = "patient_id";
            this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(270, 119);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(73, 20);
            this.txtprice.TabIndex = 50;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Price :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwTestitem
            // 
            this.lvwTestitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.test_item_id,
            this.test_item,
            this.SpecimenID,
            this.Specimen,
            this.Price});
            this.lvwTestitem.FullRowSelect = true;
            this.lvwTestitem.GridLines = true;
            this.lvwTestitem.Location = new System.Drawing.Point(418, 52);
            this.lvwTestitem.Name = "lvwTestitem";
            this.lvwTestitem.Size = new System.Drawing.Size(335, 252);
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
            this.test_item.Width = 180;
            // 
            // SpecimenID
            // 
            this.SpecimenID.Text = "SpecimenID";
            this.SpecimenID.Width = 0;
            // 
            // Specimen
            // 
            this.Specimen.Text = "Specimen";
            this.Specimen.Width = 80;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 70;
            // 
            // btnTestItemClose
            // 
            this.btnTestItemClose.BackColor = System.Drawing.Color.LightBlue;
            this.btnTestItemClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestItemClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestItemClose.Location = new System.Drawing.Point(622, 316);
            this.btnTestItemClose.Name = "btnTestItemClose";
            this.btnTestItemClose.Size = new System.Drawing.Size(75, 26);
            this.btnTestItemClose.TabIndex = 55;
            this.btnTestItemClose.Text = "Close";
            this.btnTestItemClose.UseVisualStyleBackColor = false;
            this.btnTestItemClose.Click += new System.EventHandler(this.btnTestItemClose_Click);
            // 
            // btnTestItemRefresh
            // 
            this.btnTestItemRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnTestItemRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestItemRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestItemRefresh.Location = new System.Drawing.Point(531, 316);
            this.btnTestItemRefresh.Name = "btnTestItemRefresh";
            this.btnTestItemRefresh.Size = new System.Drawing.Size(75, 26);
            this.btnTestItemRefresh.TabIndex = 54;
            this.btnTestItemRefresh.Text = "Refresh";
            this.btnTestItemRefresh.UseVisualStyleBackColor = false;
            this.btnTestItemRefresh.Click += new System.EventHandler(this.btnTestItemRefresh_Click);
            // 
            // btnTestItem
            // 
            this.btnTestItem.BackColor = System.Drawing.Color.LightBlue;
            this.btnTestItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestItem.Location = new System.Drawing.Point(438, 316);
            this.btnTestItem.Name = "btnTestItem";
            this.btnTestItem.Size = new System.Drawing.Size(75, 26);
            this.btnTestItem.TabIndex = 52;
            this.btnTestItem.Text = "Save";
            this.btnTestItem.UseVisualStyleBackColor = false;
            this.btnTestItem.Click += new System.EventHandler(this.btnTestItem_Click);
            // 
            // cmbspecimen
            // 
            this.cmbspecimen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbspecimen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbspecimen.BackColor = System.Drawing.Color.White;
            this.cmbspecimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbspecimen.FormattingEnabled = true;
            this.cmbspecimen.Location = new System.Drawing.Point(139, 168);
            this.cmbspecimen.Name = "cmbspecimen";
            this.cmbspecimen.Size = new System.Drawing.Size(93, 21);
            this.cmbspecimen.TabIndex = 58;
            this.cmbspecimen.Tag = "patient_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Specimen:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReferance
            // 
            this.txtReferance.Location = new System.Drawing.Point(143, 289);
            this.txtReferance.Name = "txtReferance";
            this.txtReferance.Size = new System.Drawing.Size(218, 20);
            this.txtReferance.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Referance Value :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(143, 315);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(166, 20);
            this.txtunit.TabIndex = 61;
            this.txtunit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Unit :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 189);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbTestelement
            // 
            this.cmbTestelement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTestelement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTestelement.BackColor = System.Drawing.Color.White;
            this.cmbTestelement.FormattingEnabled = true;
            this.cmbTestelement.Location = new System.Drawing.Point(143, 262);
            this.cmbTestelement.Name = "cmbTestelement";
            this.cmbTestelement.Size = new System.Drawing.Size(218, 21);
            this.cmbTestelement.TabIndex = 64;
            this.cmbTestelement.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Test Element :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Investigation Test Name Add";
            // 
            // grpelement
            // 
            this.grpelement.Controls.Add(this.button1);
            this.grpelement.Controls.Add(this.textBox1);
            this.grpelement.Controls.Add(this.label9);
            this.grpelement.Enabled = false;
            this.grpelement.Location = new System.Drawing.Point(12, 247);
            this.grpelement.Name = "grpelement";
            this.grpelement.Size = new System.Drawing.Size(365, 99);
            this.grpelement.TabIndex = 64;
            this.grpelement.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Price :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmInvestigationitemADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(765, 361);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTestelement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReferance);
            this.Controls.Add(this.cmbspecimen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwTestitem);
            this.Controls.Add(this.btnTestItemClose);
            this.Controls.Add(this.btnTestItemRefresh);
            this.Controls.Add(this.btnTestItem);
            this.Controls.Add(this.cmbTestDepartemt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTestItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTestGroup);
            this.Controls.Add(this.lblDepartemt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpelement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmInvestigationitemADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Items ADD";
            this.Load += new System.EventHandler(this.FrmInvestigationitemADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpelement.ResumeLayout(false);
            this.grpelement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartemt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTestItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTestGroup;
        private System.Windows.Forms.ComboBox cmbTestDepartemt;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwTestitem;
        private System.Windows.Forms.ColumnHeader test_item_id;
        private System.Windows.Forms.ColumnHeader test_item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnTestItemClose;
        private System.Windows.Forms.Button btnTestItemRefresh;
        private System.Windows.Forms.Button btnTestItem;
        private System.Windows.Forms.ComboBox cmbspecimen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReferance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Specimen;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbTestelement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpelement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader SpecimenID;
    }
}