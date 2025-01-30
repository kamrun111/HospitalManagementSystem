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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if ((this.txtNewPassword.Text.ToString() == this.txtConfirmNewPassword.Text.ToString()) )
            {
                User user = new User();
                UserBLL userBLL = new UserBLL();
                user.user_name = txtUserName.Text.ToString();
                user.user_password = txtOldPassword.Text.ToString();
                user.user_New_password = txtNewPassword.Text.ToString();

                int result = userBLL.UserPasswordUpdate(user);
                if (result == 1)
                {
                    MessageBox.Show("Your Password Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Again Enter Your Old Password");
                    this.txtOldPassword.Text = "";
                    txtOldPassword.Focus();
                }

            }
            else

                MessageBox.Show("Again Enter Your new Password");
            txtNewPassword.Text = "";
            txtConfirmNewPassword.Text = "";
            txtNewPassword.Focus();
        }

        
    }
}