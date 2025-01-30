namespace NewHIMS.Forms.Receiptions.DoctorsBill
{
    partial class FrmDoctorsBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.lvwDoctrsBill = new System.Windows.Forms.ListView();
            this.admission_code = new System.Windows.Forms.ColumnHeader();
            this.Cabin = new System.Windows.Forms.ColumnHeader();
            this.doctors_payment_id = new System.Windows.Forms.ColumnHeader();
            this.grdDoctorsBill = new System.Windows.Forms.DataGridView();
            this.doctor_payment_details_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reffered_doctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRequisitionTitle = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpRequisition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctorsBill)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRequisition
            // 
            this.grpRequisition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRequisition.Controls.Add(this.btnPrint);
            this.grpRequisition.Controls.Add(this.lvwDoctrsBill);
            this.grpRequisition.Controls.Add(this.grdDoctorsBill);
            this.grpRequisition.Controls.Add(this.btnClose);
            this.grpRequisition.Controls.Add(this.btnRefresh);
            this.grpRequisition.Controls.Add(this.btnSave);
            this.grpRequisition.Location = new System.Drawing.Point(29, 42);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Size = new System.Drawing.Size(567, 393);
            this.grpRequisition.TabIndex = 12;
            this.grpRequisition.TabStop = false;
            // 
            // lvwDoctrsBill
            // 
            this.lvwDoctrsBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDoctrsBill.BackColor = System.Drawing.Color.Linen;
            this.lvwDoctrsBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admission_code,
            this.Cabin,
            this.doctors_payment_id});
            this.lvwDoctrsBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDoctrsBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvwDoctrsBill.FullRowSelect = true;
            this.lvwDoctrsBill.HideSelection = false;
            this.lvwDoctrsBill.Location = new System.Drawing.Point(25, 28);
            this.lvwDoctrsBill.Name = "lvwDoctrsBill";
            this.lvwDoctrsBill.Size = new System.Drawing.Size(205, 350);
            this.lvwDoctrsBill.TabIndex = 1;
            this.lvwDoctrsBill.UseCompatibleStateImageBehavior = false;
            this.lvwDoctrsBill.View = System.Windows.Forms.View.Details;
            this.lvwDoctrsBill.Click += new System.EventHandler(this.lvwDoctrsBill_Click);
            // 
            // admission_code
            // 
            this.admission_code.Text = "Reg ID";
            this.admission_code.Width = 98;
            // 
            // Cabin
            // 
            this.Cabin.Text = "Cabin";
            this.Cabin.Width = 100;
            // 
            // doctors_payment_id
            // 
            this.doctors_payment_id.Text = "R";
            this.doctors_payment_id.Width = 0;
            // 
            // grdDoctorsBill
            // 
            this.grdDoctorsBill.AllowUserToAddRows = false;
            this.grdDoctorsBill.AllowUserToDeleteRows = false;
            this.grdDoctorsBill.AllowUserToResizeRows = false;
            this.grdDoctorsBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDoctorsBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDoctorsBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoctorsBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctor_payment_details_id,
            this.reffered_doctors,
            this.amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDoctorsBill.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDoctorsBill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdDoctorsBill.Location = new System.Drawing.Point(259, 28);
            this.grdDoctorsBill.Name = "grdDoctorsBill";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDoctorsBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDoctorsBill.Size = new System.Drawing.Size(275, 286);
            this.grdDoctorsBill.TabIndex = 2;
            this.grdDoctorsBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellClick);
            this.grdDoctorsBill.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellEnter);
            // 
            // doctor_payment_details_id
            // 
            this.doctor_payment_details_id.Frozen = true;
            this.doctor_payment_details_id.HeaderText = "doctor_payment_details_id";
            this.doctor_payment_details_id.Name = "doctor_payment_details_id";
            this.doctor_payment_details_id.ReadOnly = true;
            this.doctor_payment_details_id.Visible = false;
            // 
            // reffered_doctors
            // 
            this.reffered_doctors.Frozen = true;
            this.reffered_doctors.HeaderText = "Doctor Name";
            this.reffered_doctors.Name = "reffered_doctors";
            this.reffered_doctors.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.Frozen = true;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::NewHIMS.Properties.Resources.RefreshSmall;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(331, 336);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.BackgroundImage = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(405, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "   Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(479, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRequisitionTitle
            // 
            this.lblRequisitionTitle.AutoSize = true;
            this.lblRequisitionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitionTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRequisitionTitle.Location = new System.Drawing.Point(248, 9);
            this.lblRequisitionTitle.Name = "lblRequisitionTitle";
            this.lblRequisitionTitle.Size = new System.Drawing.Size(164, 31);
            this.lblRequisitionTitle.TabIndex = 31;
            this.lblRequisitionTitle.Text = "Doctors Bill";
            this.lblRequisitionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrint.BackgroundImage = global::NewHIMS.Properties.Resources.PrintPreviewSmall;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(257, 336);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 28);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmDoctorsBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(608, 477);
            this.Controls.Add(this.grpRequisition);
            this.Controls.Add(this.lblRequisitionTitle);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorsBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsBill";
            this.Load += new System.EventHandler(this.FrmDoctorsBill_Load);
            this.grpRequisition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoctorsBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequisition;
        private System.Windows.Forms.ListView lvwDoctrsBill;
        private System.Windows.Forms.ColumnHeader doctors_payment_id;
        private System.Windows.Forms.DataGridView grdDoctorsBill;
        private System.Windows.Forms.Label lblRequisitionTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader Cabin;
        private System.Windows.Forms.ColumnHeader admission_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_payment_details_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reffered_doctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button btnPrint;
    }
}