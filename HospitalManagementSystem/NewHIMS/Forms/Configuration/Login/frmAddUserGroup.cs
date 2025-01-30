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
    public partial class frmAddUserGroup : Form
    {
        int userGroupID = 0;
        public frmAddUserGroup()
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



     



        private void frmAddUserGroup_Load_1(object sender, EventArgs e)
        {

            UserGroupBLL userBLL = new UserGroupBLL();
            DataSet ds = userBLL.GetUserGroups();
            PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");

        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelet_Click_1(object sender, EventArgs e)
        {
            UserGroup userGroup = new UserGroup();
            UserGroupBLL userGroupBLL = new UserGroupBLL();
            userGroup.user_group = cmbUserGroup.Text.ToString();
            userGroup.user_group_id = (userGroupID);
            userGroupBLL.RemoveUserGroup(userGroup);
            DataSet ds = userGroupBLL.GetUserGroups();
            PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");

            MessageBox.Show("OK");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserGroup userGroup = new UserGroup();
            UserGroupBLL userGroupBLL = new UserGroupBLL();
            userGroup.user_group = cmbUserGroup.Text.ToString();
            userGroup.user_group_id = (userGroupID);
            userGroupBLL.UpdateUserGroup(userGroup);
            DataSet ds = userGroupBLL.GetUserGroups();
            PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");

            MessageBox.Show("OK");
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UserGroup userGroup = new UserGroup();
            UserGroupBLL userGroupBLL = new UserGroupBLL();

            userGroup.user_group = cmbUserGroup.Text.ToString();

            userGroupBLL.AddUserGroup(userGroup);
            DataSet ds = userGroupBLL.GetUserGroups();
            PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");

            MessageBox.Show("OK");
        }

        private void cmbUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            userGroupID = Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString());
        }



       
    }
}