namespace NewHIMS.Forms.Doctor_Station.Doctor_Visit
{
    partial class FrmDischarge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDischarge));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdMainList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose_p_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intake_sys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medecine_indication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMainList
            // 
            this.grdMainList.AllowUserToAddRows = false;
            this.grdMainList.AllowUserToDeleteRows = false;
            this.grdMainList.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.grdMainList, "grdMainList");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMainList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product,
            this.dose_p_qty,
            this.intake_sys,
            this.Medecine_indication});
            this.grdMainList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMainList.Name = "grdMainList";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = global::NewHIMS.Properties.Resources.SaveSmall;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Image = global::NewHIMS.Properties.Resources.CloseSmall;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // product_id
            // 
            resources.ApplyResources(this.product_id, "product_id");
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // product
            // 
            resources.ApplyResources(this.product, "product");
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dose_p_qty
            // 
            resources.ApplyResources(this.dose_p_qty, "dose_p_qty");
            this.dose_p_qty.Name = "dose_p_qty";
            this.dose_p_qty.ReadOnly = true;
            // 
            // intake_sys
            // 
            resources.ApplyResources(this.intake_sys, "intake_sys");
            this.intake_sys.Name = "intake_sys";
            this.intake_sys.ReadOnly = true;
            // 
            // Medecine_indication
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medecine_indication.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Medecine_indication, "Medecine_indication");
            this.Medecine_indication.Name = "Medecine_indication";
            // 
            // FrmDischarge
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdMainList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDischarge";
            this.Load += new System.EventHandler(this.FrmDischarge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMainList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMainList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose_p_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn intake_sys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medecine_indication;
        ///////////////////////////////////////////////////////////


    }
}