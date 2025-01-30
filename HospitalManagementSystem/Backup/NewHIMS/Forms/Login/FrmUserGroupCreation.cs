using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NewHIMS.Forms.Login;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Login
{
    public partial class FrmUserGroupCreation : BaseForm.FrmBase
    {
        private bool flag;

        public FrmUserGroupCreation()
        {
            InitializeComponent();
            flag = true;
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            //combo.Text = "<Select>";
            if (combo.SelectedIndex > 0)
            {
                combo.SelectedIndex = 0;//why -1
            }

        }

        private void PopulateGrid(DataTable dt)
        {
            dataGridView1.Rows.Clear();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
               
            }
        }
        
        private void FrmUserGroup_Load(object sender, EventArgs e)
        {
            UserGroupBLL userGroupBLL = new UserGroupBLL();
            DataSet ds = userGroupBLL.GetUserGroups();
            PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");
            PopulateGrid(ds.Tables[1]);
            cmbUserGroup.Text = "<Select>";
            btnSave.Text = "Save";
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {

            frmAddForm AddForm = new frmAddForm();

            AddForm.ShowDialog();


        }

        /*private void cmbUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserGroupBLL userGroupBLL = new UserGroupBLL();
            DataSet ds = userGroupBLL.GetModuleByUserGroupID(Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString()));
            if (ds.Tables[0].Rows.Count > 0)
                PopulateComboBox(cmbModuleName, ds, 0, "module", "module_id");
            else
            {
                cmbModuleName.DataSource = null;
                //cmbModuleName.Items.Clear();
            }
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                flag = false;
                if (cmbUserGroup.Text.ToString() == "" || cmbUserGroup.Text == "<Select>")
                {
                    MessageBox.Show("Select User Group");
                    return;
                }
                UserGroup userGroup = new UserGroup();
                PermittedForm permittedForm = new PermittedForm();
                UserGroupBLL userGroupBLL = new UserGroupBLL();
                userGroup.user_group = cmbUserGroup.Text.ToString();
                userGroupBLL.AddUserGroup(userGroup);
                DataSet ds = userGroupBLL.GetUserGroups();
                PopulateComboBox(cmbUserGroup, ds, 0, "user_group", "user_group_id");
                cmbUserGroup.SelectedIndex = cmbUserGroup.FindString(userGroup.user_group);
                flag = true;
                PermittedFormBLL permittedFormBLL = new PermittedFormBLL();
                permittedFormBLL.RemoveUserPermittedForm((Convert.ToInt32(cmbUserGroup.SelectedValue)));

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[1].Value) == true)
                    {
                        permittedForm.user_group_id = Convert.ToInt32(cmbUserGroup.SelectedValue);
                       
                        permittedForm.form_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) == true)
                            permittedForm.insert_permission = 1;
                        else
                            permittedForm.insert_permission = 0;

                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == true)
                            permittedForm.edit_permission = 1;
                        else
                            permittedForm.edit_permission = 0;

                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value) == true)
                            permittedForm.delete_permission = 1;
                        else
                            permittedForm.delete_permission = 0;

                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value) == true)
                            permittedForm.view_permission = 1;
                        else
                            permittedForm.view_permission = 0;

                        permittedFormBLL.AddUserPermittedForm(permittedForm);
                    }
                }
                MessageBox.Show("Successfully");

            }
            catch 
            {
               
                
            }
    
        }

        private void SelectGridCheckBox()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = true;
                dataGridView1.Rows[i].Cells[3].Value = true;
                dataGridView1.Rows[i].Cells[4].Value = true;
                dataGridView1.Rows[i].Cells[5].Value = true;
                dataGridView1.Rows[i].Cells[6].Value = true;
            }
        }

        private void ClearGridCheckBox()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = false;
                dataGridView1.Rows[i].Cells[3].Value = false;
                dataGridView1.Rows[i].Cells[4].Value = false;
                dataGridView1.Rows[i].Cells[5].Value = false;
                dataGridView1.Rows[i].Cells[6].Value = false;
            }
        }

        private void cmbUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1 || flag==false) return;
            if (cmbUserGroup.SelectedIndex>=0)
            {
                PermittedForm permittedForm = new PermittedForm();
               
                PermittedFormBLL permittedFormBLL = new PermittedFormBLL();
                DataSet ds = permittedFormBLL.GetPermittedForm(Convert.ToInt32(((DataRowView)(cmbUserGroup.SelectedItem)).Row[0].ToString())); //SP-> [GetFormByModuleID]



               ClearGridCheckBox();
               btnSave.Text = "Update";
               linkLabel1.Text = "DeSelectAll";
                   
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                        {
                            if (dataGridView1.Rows[j].Cells[0].Value.ToString() == ds.Tables[0].Rows[i][0].ToString())
                            {
                                dataGridView1.Rows[j].Cells[1].Value = true;
                                dataGridView1.Rows[j].Cells[3].Value = Convert.ToBoolean(ds.Tables[0].Rows[i][1]);
                                dataGridView1.Rows[j].Cells[4].Value = Convert.ToBoolean(ds.Tables[0].Rows[i][2]);
                                dataGridView1.Rows[j].Cells[5].Value = Convert.ToBoolean(ds.Tables[0].Rows[i][3]);
                                dataGridView1.Rows[j].Cells[6].Value = Convert.ToBoolean(ds.Tables[0].Rows[i][4]);
                            }
                        }
                      }

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "SelectAll")
            {
                SelectGridCheckBox();
                linkLabel1.Text = "DeSelectAll";
            }
            else
            {
                ClearGridCheckBox();
                linkLabel1.Text = "SelectAll";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUserGroup_Leave(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(cmbUserGroup.SelectedValue)) <= 1)
            {
                btnSave.Text = "Save";
                ClearGridCheckBox();
                linkLabel1.Text = "SelectAll";

            }
        }
    }
}