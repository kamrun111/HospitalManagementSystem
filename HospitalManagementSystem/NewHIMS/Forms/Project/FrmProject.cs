using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;


namespace NewHIMS.Forms.Project
{
    public partial class FrmProject : Form
    {
        public FrmProject()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmProject_Load(object sender, EventArgs e)
        {
            GetPageLoad();

        }

        void GetPageLoad()
        {
            try
            {
                cmbProjectName.SelectedIndex = -1;
                txtProjectTerm.Text = "";
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectBLL projectBLL = new ProjectBLL();
                ProjectBO projectBO = new ProjectBO();

                if (cmbProjectName.Text == "")
                {
                    MessageBox.Show("Please Select Project Name");
                    return;
                }

                if (txtProjectTerm.Text == "")
                {
                    MessageBox.Show("Please Enter Project Term");
                    return;
                }

                projectBO.project_name = cmbProjectName.Text;
                projectBO.project_term = txtProjectTerm.Text;
                projectBO.start_date = Convert.ToDateTime(dtpStartDate.Value);
                projectBO.end_date = Convert.ToDateTime(dtpEndDate.Value);
                projectBO.record_created_by = ApplicatinLauncher._userId;

                int Result = projectBLL.AddProject(projectBO);

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                }

            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
                btnSave.Enabled = true;
            }
            catch
            {
            }
        }
    }
}
