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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txteditqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.lvwPatientInfo = new System.Windows.Forms.ListView();
            this.cabin = new System.Windows.Forms.ColumnHeader();
            this.hospital_id = new System.Windows.Forms.ColumnHeader();
            this.admission_id = new System.Windows.Forms.ColumnHeader();
            this.RegistrationID = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOtherItem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwPatientOtherItem = new System.Windows.Forms.ListView();
            this.itemname = new System.Windows.Forms.ColumnHeader();
            this.qty = new System.Windows.Forms.ColumnHeader();
            this.unit_rate = new System.Windows.Forms.ColumnHeader();
            this.patient_other_item_id = new System.Windows.Forms.ColumnHeader();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.lblOtherItem = new System.Windows.Forms.Label();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cachedMedicineDetailinf1 = new NewHIMS.Reports.Admission.CachedMedicineDetailinf();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPatientOtherItem.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatientOtherItem
            // 
            this.grpPatientOtherItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPatientOtherItem.Controls.Add(this.groupBox4);
            this.grpPatientOtherItem.Controls.Add(this.label2);
            this.grpPatientOtherItem.Controls.Add(this.groupBox2);
            this.grpPatientOtherItem.Controls.Add(this.cmbFloor);
            this.grpPatientOtherItem.Controls.Add(this.lvwPatientInfo);
            this.grpPatientOtherItem.Controls.Add(this.label4);
            this.grpPatientOtherItem.Controls.Add(this.cmbOtherItem);
            this.grpPatientOtherItem.Controls.Add(this.groupBox1);
            this.grpPatientOtherItem.Controls.Add(this.groupBox3);
            this.grpPatientOtherItem.Location = new System.Drawing.Point(11, 41);
            this.grpPatientOtherItem.Name = "grpPatientOtherItem";
            this.grpPatientOtherItem.Size = new System.Drawing.Size(831, 485);
            this.grpPatientOtherItem.TabIndex = 11;
            this.grpPatientOtherItem.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtitemname);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txteditqty);
            this.groupBox4.Location = new System.Drawing.Point(326, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 193);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            // 
            // txtitemname
            // 
            this.txtitemname.BackColor = System.Drawing.Color.Linen;
            this.txtitemname.Enabled = false;
            this.txtitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.Location = new System.Drawing.Point(55, 67);
            this.txtitemname.MaxLength = 4;
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(240, 22);
            this.txtitemname.TabIndex = 60;
            this.txtitemname.Tag = "qty_per_unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Item:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::NewHIMS.Properties.Resources.Edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(220, 154);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 28);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Qty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txteditqty
            // 
            this.txteditqty.BackColor = System.Drawing.Color.Linen;
            this.txteditqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditqty.Location = new System.Drawing.Point(55, 99);
            this.txteditqty.MaxLength = 4;
            this.txteditqty.Name = "txteditqty";
            this.txteditqty.Size = new System.Drawing.Size(69, 22);
            this.txteditqty.TabIndex = 60;
            this.txteditqty.Tag = "qty_per_unit";
            this.txteditqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyPerUnit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Other Service";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Location = new System.Drawing.Point(427, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 57);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(126, 18);
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
            this.btnClose.Location = new System.Drawing.Point(299, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "    Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(215, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 28);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbFloor
            // 
            this.cmbFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFloor.BackColor = System.Drawing.Color.Linen;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(65, 15);
            this.cmbFloor.MaxLength = 10;
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(143, 21);
            this.cmbFloor.Sorted = true;
            this.cmbFloor.TabIndex = 51;
            this.cmbFloor.Tag = "floor";
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            this.cmbFloor.Leave += new System.EventHandler(this.cmbFloor_Leave);
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
            this.RegistrationID,
            this.name});
            this.lvwPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientInfo.ForeColor = System.Drawing.Color.Black;
            this.lvwPatientInfo.FullRowSelect = true;
            this.lvwPatientInfo.HideSelection = false;
            this.lvwPatientInfo.Location = new System.Drawing.Point(17, 53);
            this.lvwPatientInfo.Name = "lvwPatientInfo";
            this.lvwPatientInfo.Size = new System.Drawing.Size(392, 406);
            this.lvwPatientInfo.TabIndex = 52;
            this.lvwPatientInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPatientInfo.View = System.Windows.Forms.View.Details;
            this.lvwPatientInfo.SelectedIndexChanged += new System.EventHandler(this.lvwPatientInfo_SelectedIndexChanged);
            // 
            // cabin
            // 
            this.cabin.Text = "Cabin";
            this.cabin.Width = 69;
            // 
            // hospital_id
            // 
            this.hospital_id.Text = "Hospital ID";
            this.hospital_id.Width = 89;
            // 
            // admission_id
            // 
            this.admission_id.Text = "Admission ID";
            this.admission_id.Width = 0;
            // 
            // RegistrationID
            // 
            this.RegistrationID.Text = "RegistrationID";
            this.RegistrationID.Width = 1;
            // 
            // name
            // 
            this.name.Text = "Patient Name";
            this.name.Width = 210;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Floor :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOtherItem
            // 
            this.cmbOtherItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOtherItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOtherItem.BackColor = System.Drawing.Color.Linen;
            this.cmbOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOtherItem.FormattingEnabled = true;
            this.cmbOtherItem.Location = new System.Drawing.Point(528, 52);
            this.cmbOtherItem.MaxLength = 50;
            this.cmbOtherItem.Name = "cmbOtherItem";
            this.cmbOtherItem.Size = new System.Drawing.Size(277, 24);
            this.cmbOtherItem.Sorted = true;
            this.cmbOtherItem.TabIndex = 1;
            this.cmbOtherItem.Tag = "other_item_id";
            this.cmbOtherItem.SelectedIndexChanged += new System.EventHandler(this.cmbOtherItem_SelectedIndexChanged);
            this.cmbOtherItem.Leave += new System.EventHandler(this.cmbOtherItem_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 434);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwPatientOtherItem);
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtQtyPerUnit);
            this.groupBox3.Controls.Add(this.lblOtherItem);
            this.groupBox3.Controls.Add(this.lblQtyPerUnit);
            this.groupBox3.Location = new System.Drawing.Point(427, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 371);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // lvwPatientOtherItem
            // 
            this.lvwPatientOtherItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemname,
            this.qty,
            this.unit_rate,
            this.patient_other_item_id});
            this.lvwPatientOtherItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPatientOtherItem.FullRowSelect = true;
            this.lvwPatientOtherItem.GridLines = true;
            this.lvwPatientOtherItem.Location = new System.Drawing.Point(7, 80);
            this.lvwPatientOtherItem.Name = "lvwPatientOtherItem";
            this.lvwPatientOtherItem.Size = new System.Drawing.Size(371, 285);
            this.lvwPatientOtherItem.TabIndex = 54;
            this.lvwPatientOtherItem.UseCompatibleStateImageBehavior = false;
            this.lvwPatientOtherItem.View = System.Windows.Forms.View.Details;
            this.lvwPatientOtherItem.Click += new System.EventHandler(this.lvwPatientOtherItem_Click);
            // 
            // itemname
            // 
            this.itemname.Text = "Item Name";
            this.itemname.Width = 218;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qty.Width = 61;
            // 
            // unit_rate
            // 
            this.unit_rate.Text = "Unit_Rate";
            this.unit_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unit_rate.Width = 75;
            // 
            // patient_other_item_id
            // 
            this.patient_other_item_id.Text = "id";
            this.patient_other_item_id.Width = 0;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.Linen;
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(268, 51);
            this.txtprice.MaxLength = 4;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(110, 22);
            this.txtprice.TabIndex = 58;
            this.txtprice.Tag = "qty_per_unit";
            this.txtprice.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Unit Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.BackColor = System.Drawing.Color.Linen;
            this.txtQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyPerUnit.Location = new System.Drawing.Point(101, 51);
            this.txtQtyPerUnit.MaxLength = 4;
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(57, 22);
            this.txtQtyPerUnit.TabIndex = 5;
            this.txtQtyPerUnit.Tag = "qty_per_unit";
            this.txtQtyPerUnit.Text = "1";
            this.txtQtyPerUnit.Leave += new System.EventHandler(this.txtQtyPerUnit_Leave);
            this.txtQtyPerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyPerUnit_KeyPress);
            // 
            // lblOtherItem
            // 
            this.lblOtherItem.AutoSize = true;
            this.lblOtherItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherItem.Location = new System.Drawing.Point(9, 20);
            this.lblOtherItem.Name = "lblOtherItem";
            this.lblOtherItem.Size = new System.Drawing.Size(86, 16);
            this.lblOtherItem.TabIndex = 12;
            this.lblOtherItem.Text = "Other Item:";
            this.lblOtherItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(24, 54);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(71, 16);
            this.lblQtyPerUnit.TabIndex = 16;
            this.lblQtyPerUnit.Text = "Quantity:";
            this.lblQtyPerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkKhaki;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(864, 28);
            this.label7.TabIndex = 108;
            this.label7.Text = "Other Services";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Coral;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "Other Service";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPatientOtherItemAddEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(855, 538);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpPatientOtherItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientOtherItemAddEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Other Item";
            this.Load += new System.EventHandler(this.FrmPatientOtherItemAddEditView_Load);
            this.grpPatientOtherItem.ResumeLayout(false);
            this.grpPatientOtherItem.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOtherItem;
        private System.Windows.Forms.ComboBox cmbOtherItem;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.ListView lvwPatientOtherItem;
        private System.Windows.Forms.ColumnHeader itemname;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader RegistrationID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NewHIMS.Reports.Admission.CachedMedicineDetailinf cachedMedicineDetailinf1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txteditqty;
        private System.Windows.Forms.ColumnHeader unit_rate;
        private System.Windows.Forms.ColumnHeader patient_other_item_id;
        private System.Windows.Forms.Label label6;
    }
}