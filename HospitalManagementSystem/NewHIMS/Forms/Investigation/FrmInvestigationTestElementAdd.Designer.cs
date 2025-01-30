namespace NewHIMS.Forms.Investigation
{
    partial class FrmInvestigationTestElementAdd
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
            this.label10 = new System.Windows.Forms.Label();
            this.listViewTestElement = new System.Windows.Forms.ListView();
            this.test_element_id = new System.Windows.Forms.ColumnHeader();
            this.test_element = new System.Windows.Forms.ColumnHeader();
            this.test_id = new System.Windows.Forms.ColumnHeader();
            this.reference_value = new System.Windows.Forms.ColumnHeader();
            this.testName = new System.Windows.Forms.ColumnHeader();
            this.role_no = new System.Windows.Forms.ColumnHeader();
            this.grpelement = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serialtextBox = new System.Windows.Forms.TextBox();
            this.testElementTextBox = new System.Windows.Forms.TextBox();
            this.ReferanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.grpelement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCoral;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(616, 33);
            this.label10.TabIndex = 102;
            this.label10.Text = "Test Element Add";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewTestElement
            // 
            this.listViewTestElement.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewTestElement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.test_element_id,
            this.test_element,
            this.test_id,
            this.reference_value,
            this.testName,
            this.role_no});
            this.listViewTestElement.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTestElement.FullRowSelect = true;
            this.listViewTestElement.GridLines = true;
            this.listViewTestElement.HideSelection = false;
            this.listViewTestElement.Location = new System.Drawing.Point(35, 266);
            this.listViewTestElement.Name = "listViewTestElement";
            this.listViewTestElement.Size = new System.Drawing.Size(540, 260);
            this.listViewTestElement.TabIndex = 106;
            this.listViewTestElement.UseCompatibleStateImageBehavior = false;
            this.listViewTestElement.View = System.Windows.Forms.View.Details;
            this.listViewTestElement.Click += new System.EventHandler(this.listViewTestElement_Click);
            // 
            // test_element_id
            // 
            this.test_element_id.Text = "test_element_id";
            this.test_element_id.Width = 0;
            // 
            // test_element
            // 
            this.test_element.Text = "Test Element";
            this.test_element.Width = 260;
            // 
            // test_id
            // 
            this.test_id.Text = "test_item_id";
            this.test_id.Width = 0;
            // 
            // reference_value
            // 
            this.reference_value.Text = "Reference Value";
            this.reference_value.Width = 180;
            // 
            // testName
            // 
            this.testName.Text = "Test Name";
            this.testName.Width = 0;
            // 
            // role_no
            // 
            this.role_no.Text = "Serial";
            this.role_no.Width = 70;
            // 
            // grpelement
            // 
            this.grpelement.Controls.Add(this.label3);
            this.grpelement.Controls.Add(this.saveButton);
            this.grpelement.Controls.Add(this.label6);
            this.grpelement.Controls.Add(this.label5);
            this.grpelement.Controls.Add(this.serialtextBox);
            this.grpelement.Controls.Add(this.testElementTextBox);
            this.grpelement.Controls.Add(this.ReferanceTextBox);
            this.grpelement.Location = new System.Drawing.Point(23, 99);
            this.grpelement.Name = "grpelement";
            this.grpelement.Size = new System.Drawing.Size(564, 148);
            this.grpelement.TabIndex = 105;
            this.grpelement.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Serial No:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(227, 95);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 35);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Test Element:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ref. Value :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialtextBox
            // 
            this.serialtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialtextBox.Location = new System.Drawing.Point(132, 95);
            this.serialtextBox.Name = "serialtextBox";
            this.serialtextBox.Size = new System.Drawing.Size(73, 22);
            this.serialtextBox.TabIndex = 3;
            this.serialtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoleNo_KeyPress);
            // 
            // testElementTextBox
            // 
            this.testElementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testElementTextBox.Location = new System.Drawing.Point(132, 23);
            this.testElementTextBox.Name = "testElementTextBox";
            this.testElementTextBox.Size = new System.Drawing.Size(398, 22);
            this.testElementTextBox.TabIndex = 1;
            // 
            // ReferanceTextBox
            // 
            this.ReferanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferanceTextBox.Location = new System.Drawing.Point(132, 59);
            this.ReferanceTextBox.Name = "ReferanceTextBox";
            this.ReferanceTextBox.Size = new System.Drawing.Size(398, 22);
            this.ReferanceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Test Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Enabled = false;
            this.textBoxTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestName.Location = new System.Drawing.Point(151, 71);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(402, 22);
            this.textBoxTestName.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 501);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(11, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 286);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(358, 554);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(88, 29);
            this.refreshButton.TabIndex = 64;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(465, 554);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 29);
            this.closeButton.TabIndex = 108;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FrmInvestigationTestElementAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(608, 590);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTestName);
            this.Controls.Add(this.listViewTestElement);
            this.Controls.Add(this.grpelement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvestigationTestElementAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investigation Test Item and Element Add";
            this.grpelement.ResumeLayout(false);
            this.grpelement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewTestElement;
        private System.Windows.Forms.ColumnHeader test_element_id;
        private System.Windows.Forms.ColumnHeader test_element;
        private System.Windows.Forms.ColumnHeader test_id;
        private System.Windows.Forms.ColumnHeader reference_value;
        private System.Windows.Forms.ColumnHeader testName;
        private System.Windows.Forms.ColumnHeader role_no;
        private System.Windows.Forms.GroupBox grpelement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serialtextBox;
        private System.Windows.Forms.TextBox testElementTextBox;
        private System.Windows.Forms.TextBox ReferanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button closeButton;
    }
}