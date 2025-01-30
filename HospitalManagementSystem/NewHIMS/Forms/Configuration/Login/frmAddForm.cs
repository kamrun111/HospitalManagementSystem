using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
//Bismillahir Rahmanir Rahim
namespace NewHIMS.Forms.Login
{
    public partial class frmAddForm : Form
    {
        int formID = 0;
        
        public frmAddForm()
        {
            InitializeComponent();
        }



        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            //combo.Text = "<Select>";
            if (combo.SelectedIndex > 0)
                combo.SelectedIndex = 0;//why -1
        }

       
        private void frmAddForm_Load(object sender, EventArgs e)
        {
           
            FormBLL formBLL = new FormBLL();
            DataSet ds = formBLL.GetForms();
            PopulateComboBox(cmbFormName, ds, 0, "form", "form_id");
            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormBO formob = new FormBO();
            FormBLL formBLL = new FormBLL();

            formob.form = cmbFormName.Text.ToString();

            formBLL.AddForm(formob);
            DataSet ds = formBLL.GetForms();
            PopulateComboBox(cmbFormName, ds, 0, "form", "form_id");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            FormBO formob = new FormBO();
            FormBLL formBLL = new FormBLL();
            formob.form = cmbFormName.Text.ToString();
            formob.form_id = (formID);
            formBLL.UpdateForm(formob);

            DataSet ds = formBLL.GetForms();
            PopulateComboBox(cmbFormName, ds, 0, "form", "form_id");

            MessageBox.Show("OK");

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormBO formob = new FormBO();
            FormBLL formBLL = new FormBLL();
            formob.form = cmbFormName.Text.ToString();
            formob.form_id = (formID);
            formBLL.RemoveForm(formob);

            DataSet ds = formBLL.GetForms();
            PopulateComboBox(cmbFormName, ds, 0, "form", "form_id");
            MessageBox.Show("OK");
        }

        private void cmbFormName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            formID = Convert.ToInt32(((DataRowView)(cmbFormName.SelectedItem)).Row[0].ToString());
        }

       
    }
}