namespace NewHIMS.Forms.Accounts
{
    partial class FrmOtherItemReceive
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbOtherItem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grdOtherItem = new System.Windows.Forms.DataGridView();
            this.other_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grdOtherItemStock = new System.Windows.Forms.DataGridView();
            this.vaccine_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtherItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtherItemStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Unit Price";
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(288, 55);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(78, 20);
            this.txtCharge.TabIndex = 137;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpdate);
            this.groupBox2.Controls.Add(this.cmbOtherItem);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCharge);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Location = new System.Drawing.Point(19, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 132);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 125;
            this.label2.Text = "Purchase Date";
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(123, 92);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(144, 22);
            this.dtpdate.TabIndex = 124;
            // 
            // cmbOtherItem
            // 
            this.cmbOtherItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOtherItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOtherItem.FormattingEnabled = true;
            this.cmbOtherItem.Location = new System.Drawing.Point(123, 18);
            this.cmbOtherItem.Name = "cmbOtherItem";
            this.cmbOtherItem.Size = new System.Drawing.Size(243, 21);
            this.cmbOtherItem.Sorted = true;
            this.cmbOtherItem.TabIndex = 81;
            this.cmbOtherItem.Tag = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 78;
            this.label11.Text = "Purchase Qty";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(371, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 22);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Vaccine Name";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(123, 55);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(69, 20);
            this.txtQty.TabIndex = 136;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(254, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 18);
            this.label16.TabIndex = 86;
            this.label16.Text = "Total Taka";
            // 
            // grdOtherItem
            // 
            this.grdOtherItem.AllowUserToAddRows = false;
            this.grdOtherItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOtherItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.other_item_id,
            this.other_item,
            this.Column2,
            this.Charge,
            this.total});
            this.grdOtherItem.Location = new System.Drawing.Point(20, 183);
            this.grdOtherItem.Name = "grdOtherItem";
            this.grdOtherItem.Size = new System.Drawing.Size(420, 110);
            this.grdOtherItem.TabIndex = 83;
            // 
            // other_item_id
            // 
            this.other_item_id.HeaderText = "other_item_id";
            this.other_item_id.Name = "other_item_id";
            this.other_item_id.Visible = false;
            // 
            // other_item
            // 
            this.other_item.HeaderText = "Item";
            this.other_item.Name = "other_item";
            this.other_item.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = " Qty";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Charge
            // 
            this.Charge.HeaderText = "Unit Price";
            this.Charge.Name = "Charge";
            this.Charge.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Width = 80;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(354, 346);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(91, 20);
            this.txtTotal.TabIndex = 85;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Chocolate;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkViolet;
            this.label14.Location = new System.Drawing.Point(173, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 22);
            this.label14.TabIndex = 84;
            this.label14.Text = "Vaccine Item";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Location = new System.Drawing.Point(18, 22);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(73, 28);
            this.btnrefresh.TabIndex = 87;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(356, 22);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(73, 28);
            this.btnclose.TabIndex = 88;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(261, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 28);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grdOtherItem);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(10, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 415);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnrefresh);
            this.groupBox4.Controls.Add(this.btnclose);
            this.groupBox4.Location = new System.Drawing.Point(9, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 67);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(9, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 165);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Tomato;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(-3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(828, 30);
            this.label15.TabIndex = 90;
            this.label15.Text = "VACCINE STOCK";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdOtherItemStock);
            this.groupBox5.Location = new System.Drawing.Point(484, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 415);
            this.groupBox5.TabIndex = 91;
            this.groupBox5.TabStop = false;
            // 
            // grdOtherItemStock
            // 
            this.grdOtherItemStock.AllowUserToAddRows = false;
            this.grdOtherItemStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOtherItemStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccine_id,
            this.vaccine_name,
            this.qty});
            this.grdOtherItemStock.Location = new System.Drawing.Point(9, 15);
            this.grdOtherItemStock.Name = "grdOtherItemStock";
            this.grdOtherItemStock.Size = new System.Drawing.Size(300, 386);
            this.grdOtherItemStock.TabIndex = 0;
            // 
            // vaccine_id
            // 
            this.vaccine_id.HeaderText = "ID";
            this.vaccine_id.Name = "vaccine_id";
            this.vaccine_id.Width = 35;
            // 
            // vaccine_name
            // 
            this.vaccine_name.HeaderText = "Vaccine Name";
            this.vaccine_name.Name = "vaccine_name";
            this.vaccine_name.Width = 140;
            // 
            // qty
            // 
            this.qty.HeaderText = "Stock";
            this.qty.Name = "qty";
            this.qty.Width = 60;
            // 
            // FrmOtherItemReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(814, 469);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOtherItemReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaccine Stock";
            this.Load += new System.EventHandler(this.FrmOtherItemReceive_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtherItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOtherItemStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOtherItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView grdOtherItem;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn other_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn other_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grdOtherItemStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
    }
}