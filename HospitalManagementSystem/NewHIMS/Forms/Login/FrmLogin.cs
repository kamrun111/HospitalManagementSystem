using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.MDI;

namespace NewHIMS.Forms.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtUserName.Focus();
        }
               
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                //DateTime date1 = DateTime.Now;
                //DateTime date2 = DateTime.Parse("12/12/2020");

                //if (date1.Date < date2.Date)
                //{
                    UserBLL userBLL = new UserBLL();

                    if (userBLL.Login(txtUserName.Text.ToString(), txtUserPassword.Text.ToString()))
                    {
                        this.DialogResult = DialogResult.OK;
                        ApplicatinLauncher._userName = txtUserName.Text;
                        DataSet dss = userBLL.UserIDGet(txtUserName.Text.ToString());
                        ApplicatinLauncher._userId = Convert.ToInt32(dss.Tables[0].Rows[0][0]);
                        ApplicatinLauncher._groupID = Convert.ToInt32(dss.Tables[0].Rows[0][1]);
                        ApplicatinLauncher._floorID = Convert.ToInt32(dss.Tables[0].Rows[0][2]);
                        ApplicatinLauncher._floor = Convert.ToString(dss.Tables[0].Rows[0][3]);
                        ApplicatinLauncher._GroupName = Convert.ToString(dss.Tables[0].Rows[0][4]);
                        ApplicatinLauncher._realname = Convert.ToString(dss.Tables[0].Rows[0][5]);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                        txtUserName.Text = "";
                        txtUserPassword.Text = "";
                        txtUserName.Focus();
                    }
                //}
                //else
                //{
                    
                //    MessageBox.Show(
                //        "Your License Has Been Expired.\n Please Immidiately contact with Admin(01727-212131) of ScubeSoftware",
                //        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                //}

            }
            catch
            {
                MessageBox.Show("Login failed");
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtUserPassword.Focus();
            }
        }

        private void txtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnLogin_Click(null, null);
        }

        private void btnCancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Close();
            }
        }
    }
}