namespace NewHIMS.Forms.Otshedule
{
    partial class FrmOtshedule
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
            this.lvwOTshedule = new System.Windows.Forms.ListView();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.CaninNo = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.operation = new System.Windows.Forms.ColumnHeader();
            this.surgenname = new System.Windows.Forms.ColumnHeader();
            this.Anaesthesia = new System.Windows.Forms.ColumnHeader();
            this.Anaesthetic = new System.Windows.Forms.ColumnHeader();
            this.EnteredBy = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOperationName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSurgeon = new System.Windows.Forms.ComboBox();
            this.btnOtbookClose = new System.Windows.Forms.Button();
            this.btnOTbookSave = new System.Windows.Forms.Button();
            this.btnOTbookRefresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpoperationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpoperationTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAnaesiaNature = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbmNameOfAna = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwOTshedule
            // 
            this.lvwOTshedule.BackColor = System.Drawing.Color.CadetBlue;
            this.lvwOTshedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time,
            this.CaninNo,
            this.name,
            this.operation,
            this.surgenname,
            this.Anaesthesia,
            this.Anaesthetic,
            this.EnteredBy});
            this.lvwOTshedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOTshedule.FullRowSelect = true;
            this.lvwOTshedule.GridLines = true;
            this.lvwOTshedule.Location = new System.Drawing.Point(4, 90);
            this.lvwOTshedule.Name = "lvwOTshedule";
            this.lvwOTshedule.Size = new System.Drawing.Size(639, 431);
            this.lvwOTshedule.TabIndex = 51;
            this.lvwOTshedule.UseCompatibleStateImageBehavior = false;
            this.lvwOTshedule.View = System.Windows.Forms.View.Details;
            // 
            // time
            // 
            this.time.Text = "Time";
            // 
            // CaninNo
            // 
            this.CaninNo.Text = "CaninNo";
            // 
            // name
            // 
            this.name.Text = "Patient Name";
            this.name.Width = 100;
            // 
            // operation
            // 
            this.operation.Text = "Operation Name";
            this.operation.Width = 108;
            // 
            // surgenname
            // 
            this.surgenname.Text = "Surgeon";
            this.surgenname.Width = 77;
            // 
            // Anaesthesia
            // 
            this.Anaesthesia.Text = "Anaesthesia";
            this.Anaesthesia.Width = 80;
            // 
            // Anaesthetic
            // 
            this.Anaesthetic.Text = "Anaesthetic";
            this.Anaesthetic.Width = 80;
            // 
            // EnteredBy
            // 
            this.EnteredBy.Text = "Entered By";
            this.EnteredBy.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(766, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "OT Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(968, 27);
            this.label7.TabIndex = 53;
            this.label7.Text = "OT Schedule";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(768, 314);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(768, 386);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 21);
            this.txtAddress.TabIndex = 8;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(768, 350);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(151, 20);
            this.txtContactNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(647, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Contact  No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(647, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(647, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Patient Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOperationName
            // 
            this.cmbOperationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOperationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOperationName.FormattingEnabled = true;
            this.cmbOperationName.Location = new System.Drawing.Point(768, 163);
            this.cmbOperationName.Name = "cmbOperationName";
            this.cmbOperationName.Size = new System.Drawing.Size(151, 21);
            this.cmbOperationName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(647, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Operation Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(647, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Surgeon";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSurgeon
            // 
            this.cmbSurgeon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSurgeon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSurgeon.FormattingEnabled = true;
            this.cmbSurgeon.Location = new System.Drawing.Point(768, 200);
            this.cmbSurgeon.Name = "cmbSurgeon";
            this.cmbSurgeon.Size = new System.Drawing.Size(151, 21);
            this.cmbSurgeon.TabIndex = 3;
            // 
            // btnOtbookClose
            // 
            this.btnOtbookClose.BackColor = System.Drawing.Color.LightBlue;
            this.btnOtbookClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtbookClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtbookClose.Location = new System.Drawing.Point(826, 478);
            this.btnOtbookClose.Name = "btnOtbookClose";
            this.btnOtbookClose.Size = new System.Drawing.Size(79, 26);
            this.btnOtbookClose.TabIndex = 11;
            this.btnOtbookClose.Text = "Close";
            this.btnOtbookClose.UseVisualStyleBackColor = false;
            this.btnOtbookClose.Click += new System.EventHandler(this.btnOtbookClose_Click);
            // 
            // btnOTbookSave
            // 
            this.btnOTbookSave.BackColor = System.Drawing.Color.LightBlue;
            this.btnOTbookSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTbookSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTbookSave.ForeColor = System.Drawing.Color.Black;
            this.btnOTbookSave.Location = new System.Drawing.Point(656, 478);
            this.btnOTbookSave.Name = "btnOTbookSave";
            this.btnOTbookSave.Size = new System.Drawing.Size(79, 26);
            this.btnOTbookSave.TabIndex = 9;
            this.btnOTbookSave.Text = "Save";
            this.btnOTbookSave.UseVisualStyleBackColor = false;
            this.btnOTbookSave.Click += new System.EventHandler(this.btnOTbookSave_Click);
            // 
            // btnOTbookRefresh
            // 
            this.btnOTbookRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnOTbookRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTbookRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTbookRefresh.Location = new System.Drawing.Point(741, 478);
            this.btnOTbookRefresh.Name = "btnOTbookRefresh";
            this.btnOTbookRefresh.Size = new System.Drawing.Size(79, 26);
            this.btnOTbookRefresh.TabIndex = 10;
            this.btnOTbookRefresh.Text = "Refresh";
            this.btnOTbookRefresh.UseVisualStyleBackColor = false;
            this.btnOTbookRefresh.Click += new System.EventHandler(this.btnOTbookRefresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(643, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 16);
            this.label10.TabIndex = 82;
            this.label10.Text = "Expected Operation Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(411, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 26);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpoperationDate
            // 
            this.dtpoperationDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpoperationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpoperationDate.Location = new System.Drawing.Point(821, 94);
            this.dtpoperationDate.Name = "dtpoperationDate";
            this.dtpoperationDate.Size = new System.Drawing.Size(95, 20);
            this.dtpoperationDate.TabIndex = 90;
            this.dtpoperationDate.Tag = "dob";
            // 
            // dtpoperationTime
            // 
            this.dtpoperationTime.CustomFormat = "hh:mm tt";
            this.dtpoperationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpoperationTime.Location = new System.Drawing.Point(821, 120);
            this.dtpoperationTime.Name = "dtpoperationTime";
            this.dtpoperationTime.ShowUpDown = true;
            this.dtpoperationTime.Size = new System.Drawing.Size(95, 20);
            this.dtpoperationTime.TabIndex = 91;
            this.dtpoperationTime.Tag = "dob";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(705, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 92;
            this.label12.Text = "Expected  time";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAnaesiaNature
            // 
            this.cmbAnaesiaNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAnaesiaNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnaesiaNature.FormattingEnabled = true;
            this.cmbAnaesiaNature.Location = new System.Drawing.Point(768, 274);
            this.cmbAnaesiaNature.Name = "cmbAnaesiaNature";
            this.cmbAnaesiaNature.Size = new System.Drawing.Size(151, 21);
            this.cmbAnaesiaNature.TabIndex = 94;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(647, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 16);
            this.label16.TabIndex = 96;
            this.label16.Text = " Anaest. Nature";
            // 
            // cbmNameOfAna
            // 
            this.cbmNameOfAna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbmNameOfAna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmNameOfAna.FormattingEnabled = true;
            this.cbmNameOfAna.Location = new System.Drawing.Point(768, 237);
            this.cbmNameOfAna.Name = "cbmNameOfAna";
            this.cbmNameOfAna.Size = new System.Drawing.Size(151, 21);
            this.cbmNameOfAna.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = " Anaesthesia";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "MM-dd-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(160, 60);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(100, 20);
            this.dtpFromDate.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(111, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "From";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(266, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 100;
            this.label11.Text = "To";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "MM-dd-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(299, 60);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(100, 20);
            this.dtpToDate.TabIndex = 101;
            // 
            // txtroom
            // 
            this.txtroom.Location = new System.Drawing.Point(830, 422);
            this.txtroom.MaxLength = 200;
            this.txtroom.Multiline = true;
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(89, 21);
            this.txtroom.TabIndex = 102;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(698, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 16);
            this.label13.TabIndex = 103;
            this.label13.Text = "Cabin/Room No.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(496, 57);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 26);
            this.btnPrint.TabIndex = 104;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmOtshedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 533);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtroom);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cmbAnaesiaNature);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbmNameOfAna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpoperationTime);
            this.Controls.Add(this.dtpoperationDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOtbookClose);
            this.Controls.Add(this.btnOTbookSave);
            this.Controls.Add(this.btnOTbookRefresh);
            this.Controls.Add(this.cmbSurgeon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbOperationName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwOTshedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOtshedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operation schedule";
            this.Load += new System.EventHandler(this.FrmOtshedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwOTshedule;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader operation;
        private System.Windows.Forms.ColumnHeader surgenname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOperationName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSurgeon;
        private System.Windows.Forms.Button btnOtbookClose;
        private System.Windows.Forms.Button btnOTbookSave;
        private System.Windows.Forms.Button btnOTbookRefresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpoperationDate;
        private System.Windows.Forms.DateTimePicker dtpoperationTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAnaesiaNature;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbmNameOfAna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ColumnHeader CaninNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.ColumnHeader Anaesthesia;
        private System.Windows.Forms.ColumnHeader Anaesthetic;
        private System.Windows.Forms.ColumnHeader EnteredBy;
        private System.Windows.Forms.TextBox txtroom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPrint;
    }
}