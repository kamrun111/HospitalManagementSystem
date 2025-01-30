using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Login
{
    public partial class frmAddModule : Form
    {
       public frmAddModule()
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


        void refreshContent() {
            UserGroupBLL userGroupBLL = new UserGroupBLL();
            DataSet ds = userGroupBLL.GetUserGroups();
            PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");
        }


        private void frmAddModule_Load(object sender, EventArgs e)
        {
            refreshContent();
        }

             
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelere_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            ModuleBLL moduleBLL = new ModuleBLL();
            
            module.module = cmbModule.Text.ToString();
            module.user_group_id = (Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString()));
            moduleBLL.RemoveModule(module);
            MessageBox.Show("OK");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Module module = new Module();
            ModuleBLL moduleBLL = new ModuleBLL();


            module.module = cmbModule.Text.ToString();
            module.user_group_id = (Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString()));
            module.module_id = (Convert.ToInt32(((DataRowView)(cmbModule.SelectedItem)).Row[0].ToString()));
            moduleBLL.UpdateModule(module);
            MessageBox.Show("OK");

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Module module = new Module();
            ModuleBLL moduleBLL = new ModuleBLL();


            module.module = cmbModule.Text.ToString();
            module.user_group_id = (Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString()));
            moduleBLL.AddModule(module);
            MessageBox.Show("OK");
        }

        private void cmbUserGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UserGroupBLL userGroupBLL = new UserGroupBLL();
            DataSet ds = userGroupBLL.GetModuleByUserGroupID(Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString()));
            PopulateComboBox(cmbModule, ds, 0, "module", "module_id");

        }

        private void cmbModule_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}