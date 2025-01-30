using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace NewHIMS.Forms.BaseForm
{
    public partial class FrmBase : Form
    {
        public int UserID;
        public FrmBase()
        {
            InitializeComponent();
        }
        
        
               
        public new void Show()
        {   
            //MessageBox.Show("Thanks " + MDI.FrmMain.UserName + "For Open This form");
            //MessageBox.Show(base.Name);
            //base.Show();  
            try
            {
                PermittedForm permittedForm = new PermittedForm();
                PermittedFormBLL permittedFormBLL = new PermittedFormBLL();
                string form = base.Name;
                string user_name = MDI.FrmMain.UserName;
                permittedFormBLL.GetFormPermission(form, user_name);
               
                DataSet ds = permittedFormBLL.GetFormPermission(form, user_name);
                                   
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                { 
                    UserID=Convert.ToInt32(ds.Tables[0].Rows[0][4]);
                    sbyte view = Convert.ToSByte(ds.Tables[0].Rows[0][3].ToString());
                    if (view == 1)
                    {
                        base.Show();
                        base.Text =base.Text+ " --- Hospital Management System ";
                        ApplicatinLauncher._Insert = Convert.ToSByte(ds.Tables[0].Rows[0][0].ToString());
                        ApplicatinLauncher._edit = Convert.ToSByte(ds.Tables[0].Rows[0][1].ToString());
                        ApplicatinLauncher._Delete = Convert.ToSByte(ds.Tables[0].Rows[0][2].ToString());
                    }
                }
                else
                    MessageBox.Show("You have no permission");
            }

            catch
            {
               
            }
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}