namespace NewHIMS.Forms.Investigation
{
    partial class FrmDoctor_sPay
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcomissionperson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.grdpercentage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtTotaltaka = new System.Windows.Forms.TextBox();
            this.rdoconsultant = new System.Windows.Forms.RadioButton();
            this.rdosales = new System.Windows.Forms.RadioButton();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdpercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-14, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(821, 27);
            this.label7.TabIndex = 55;
            this.label7.Text = "Payment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbcomissionperson
            // 
            this.cmbcomissionperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcomissionperson.FormattingEnabled = true;
            this.cmbcomissionperson.Location = new System.Drawing.Point(152, 83);
            this.cmbcomissionperson.Name = "cmbcomissionperson";
            this.cmbcomissionperson.Size = new System.Drawing.Size(448, 24);
            this.cmbcomissionperson.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Doctor\'s Name";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(638, 456);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(103, 20);
            this.txtpaid.TabIndex = 62;
            // 
            // grdpercentage
            // 
            this.grdpercentage.AllowUserToAddRows = false;
            this.grdpercentage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdpercentage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MRnumber,
            this.patient_id,
            this.Patient_name,
            this.Column3,
            this.Column4});
            this.grdpercentage.Location = new System.Drawing.Point(12, 174);
            this.grdpercentage.Name = "grdpercentage";
            this.grdpercentage.Size = new System.Drawing.Size(729, 267);
            this.grdpercentage.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SL No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // MRnumber
            // 
            this.MRnumber.HeaderText = "MR Number";
            this.MRnumber.Name = "MRnumber";
            this.MRnumber.ReadOnly = true;
            // 
            // patient_id
            // 
            this.patient_id.HeaderText = "Patient ID";
            this.patient_id.Name = "patient_id";
            this.patient_id.ReadOnly = true;
            // 
            // Patient_name
            // 
            this.Patient_name.HeaderText = "Patient Name";
            this.Patient_name.Name = "Patient_name";
            this.Patient_name.ReadOnly = true;
            this.Patient_name.Width = 220;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Payable";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Paid";
            this.Column4.Name = "Column4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Total Tk.";
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(71, 493);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(75, 20);
            this.txtpercentage.TabIndex = 65;
            this.txtpercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpercentage_KeyPress);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(621, 505);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(118, 20);
            this.txtPayment.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Payment %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Payment";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(456, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.Text = "Submit";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 73;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 567);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 74;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(407, 567);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 75;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtTotaltaka
            // 
            this.txtTotaltaka.Location = new System.Drawing.Point(523, 456);
            this.txtTotaltaka.Name = "txtTotaltaka";
            this.txtTotaltaka.Size = new System.Drawing.Size(103, 20);
            this.txtTotaltaka.TabIndex = 76;
            // 
            // rdoconsultant
            // 
            this.rdoconsultant.AutoSize = true;
            this.rdoconsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoconsultant.Location = new System.Drawing.Point(16, 44);
            this.rdoconsultant.Name = "rdoconsultant";
            this.rdoconsultant.Size = new System.Drawing.Size(98, 20);
            this.rdoconsultant.TabIndex = 77;
            this.rdoconsultant.Text = "Consultant";
            this.rdoconsultant.UseVisualStyleBackColor = true;
            this.rdoconsultant.CheckedChanged += new System.EventHandler(this.rdoconsultant_CheckedChanged);
            // 
            // rdosales
            // 
            this.rdosales.AutoSize = true;
            this.rdosales.Checked = true;
            this.rdosales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosales.Location = new System.Drawing.Point(131, 44);
            this.rdosales.Name = "rdosales";
            this.rdosales.Size = new System.Drawing.Size(66, 20);
            this.rdosales.TabIndex = 78;
            this.rdosales.TabStop = true;
            this.rdosales.Text = "Sales";
            this.rdosales.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "MM-dd-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(337, 128);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(100, 20);
            this.dtpToDate.TabIndex = 105;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(304, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 104;
            this.label11.Text = "To";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(149, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "MM-dd-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(198, 128);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(100, 20);
            this.dtpFromDate.TabIndex = 102;
            // 
            // FrmDoctor_sPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(802, 602);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.rdosales);
            this.Controls.Add(this.rdoconsultant);
            this.Controls.Add(this.txtTotaltaka);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdpercentage);
            this.Controls.Add(this.txtpaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbcomissionperson);
            this.Controls.Add(this.label7);
            this.Name = "FrmDoctor_sPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAY";
            this.Load += new System.EventHandler(this.FrmDoctor_sPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdpercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcomissionperson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.DataGridView grdpercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtTotaltaka;
        private System.Windows.Forms.RadioButton rdoconsultant;
        private System.Windows.Forms.RadioButton rdosales;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}