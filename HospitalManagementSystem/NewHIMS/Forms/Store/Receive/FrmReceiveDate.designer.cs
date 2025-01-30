namespace NewHIMS.Forms.Store
{
    partial class FrmReceiveDate
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
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InvoicePrint = new System.Windows.Forms.Button();
            this.lvwReceived = new System.Windows.Forms.ListView();
            this.purchase = new System.Windows.Forms.ColumnHeader();
            this.admissionid = new System.Windows.Forms.ColumnHeader();
            this.patientcode = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.purchase_id = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(320, 30);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(82, 20);
            this.dtpToDate.TabIndex = 14;
            this.dtpToDate.Tag = "To_date";
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(109, 30);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(82, 20);
            this.dtpFromDate.TabIndex = 13;
            this.dtpFromDate.Tag = "from_date";
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(274, 31);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(27, 17);
            this.lblToDate.TabIndex = 10;
            this.lblToDate.Text = "To";
            this.lblToDate.Click += new System.EventHandler(this.lblToDate_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(61, 73);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(44, 17);
            this.lblFromDate.TabIndex = 9;
            this.lblFromDate.Text = "From";
            this.lblFromDate.Click += new System.EventHandler(this.lblFromDate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(366, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Print";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(503, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 31);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(647, 26);
            this.label7.TabIndex = 111;
            this.label7.Text = "Received List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 68);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.Location = new System.Drawing.Point(491, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 27);
            this.btnAdd.TabIndex = 115;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InvoicePrint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(12, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 67);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // InvoicePrint
            // 
            this.InvoicePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicePrint.Image = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.InvoicePrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InvoicePrint.Location = new System.Drawing.Point(41, 19);
            this.InvoicePrint.Name = "InvoicePrint";
            this.InvoicePrint.Size = new System.Drawing.Size(80, 31);
            this.InvoicePrint.TabIndex = 13;
            this.InvoicePrint.Text = "Invoice";
            this.InvoicePrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InvoicePrint.UseVisualStyleBackColor = true;
            this.InvoicePrint.Click += new System.EventHandler(this.InvoicePrint_Click);
            // 
            // lvwReceived
            // 
            this.lvwReceived.BackColor = System.Drawing.Color.Thistle;
            this.lvwReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchase,
            this.admissionid,
            this.patientcode,
            this.date,
            this.purchase_id});
            this.lvwReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwReceived.FullRowSelect = true;
            this.lvwReceived.GridLines = true;
            this.lvwReceived.HideSelection = false;
            this.lvwReceived.Location = new System.Drawing.Point(12, 122);
            this.lvwReceived.Name = "lvwReceived";
            this.lvwReceived.Size = new System.Drawing.Size(607, 279);
            this.lvwReceived.TabIndex = 114;
            this.lvwReceived.UseCompatibleStateImageBehavior = false;
            this.lvwReceived.View = System.Windows.Forms.View.Details;
            // 
            // purchase
            // 
            this.purchase.Text = "Order No";
            this.purchase.Width = 122;
            // 
            // admissionid
            // 
            this.admissionid.Name = "admissionid";
            this.admissionid.Text = "Invoice No";
            this.admissionid.Width = 119;
            // 
            // patientcode
            // 
            this.patientcode.Name = "patientcode";
            this.patientcode.Text = "Supplier Name";
            this.patientcode.Width = 201;
            // 
            // date
            // 
            this.date.Text = "Received Date";
            this.date.Width = 139;
            // 
            // purchase_id
            // 
            this.purchase_id.Text = "PurchaseID";
            this.purchase_id.Width = 0;
            // 
            // FrmReceiveDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(630, 486);
            this.Controls.Add(this.lvwReceived);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceiveDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiveDate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwReceived;
        private System.Windows.Forms.ColumnHeader purchase;
        private System.Windows.Forms.ColumnHeader admissionid;
        private System.Windows.Forms.ColumnHeader patientcode;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader purchase_id;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button InvoicePrint;
    }
}