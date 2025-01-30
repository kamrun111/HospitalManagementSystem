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
    public partial class FrmUserCreation : BaseForm.FrmBase
    {
        int userGroupID = 0;
        int floorID = 0;
        public FrmUserCreation()
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
        
        




        private void FrmUserCreation_Load(object sender, EventArgs e)
        {
            try
            {
                UserGroupBLL userGroupBLL = new UserGroupBLL();
                FloorBLL floorBLL = new FloorBLL();
                DataSet dss = floorBLL.Getfloors();
                DataSet ds = userGroupBLL.GetUserGroups();
                PopulateComboBox(cmbGroupName, ds, 0, "user_group", "user_group_id");
                PopulateComboBox(cmbFloor, dss, 0, "floor", "floor_id");
            }
            catch 
            {
                
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGroupName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            userGroupID = Convert.ToInt32(((DataRowView)(cmbGroupName.SelectedItem)).Row[0].ToString());
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                UserBLL userBLL = new UserBLL();
                if (txtUserName.Text=="")
                {
                    MessageBox.Show("Type your user name");
                    txtUserName.Focus();
                }
                else
                    
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        UserGroupBLL userGroupBLL = new UserGroupBLL();
                        DataSet ds = userGroupBLL.GetUserGroups();
                        user.user_group_id = (userGroupID);
                        user.floor_id = (floorID);
                        user.user_name = txtUserName.Text.ToString();
                        user.user_password = txtPassword.Text.ToString();
                        userBLL.AddUser(user);
                        MessageBox.Show("User Create Successfully");
                        txtUserName.Text="";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        MessageBox.Show("ReType your Password");
                        txtPassword.Focus();
                    }
            }
            catch 
            {
                MessageBox.Show("User already exist");
            }
        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            floorID = Convert.ToInt32(((DataRowView)(cmbFloor.SelectedItem)).Row[0].ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                UserBLL userBLL = new UserBLL();
                user.user_name = txtUserName.Text;
                user.floor_id = Convert.ToInt32(((DataRowView)(cmbFloor.SelectedItem)).Row[0].ToString());
                user.user_group_id = Convert.ToInt32(((DataRowView)(cmbGroupName.SelectedItem)).Row[0].ToString());
                userBLL.UpdateUser(user);
                MessageBox.Show("User Update Successfully");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

            }
            catch 
            {
                
                
            }
            

        }
    }
}