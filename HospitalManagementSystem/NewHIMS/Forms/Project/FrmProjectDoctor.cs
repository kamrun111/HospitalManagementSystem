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
    public partial class FrmProjectDoctor : Form
    {
        public FrmProjectDoctor()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmProjectDoctor_Load(object sender, EventArgs e)
        {
            GetPageLoad();
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("ProjectLoad");

                if (ds.Tables[3].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwDoctorList, ds, 3);
                }
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectGuestDoctorBLL projectGuestDoctorBLL = new ProjectGuestDoctorBLL();
                ProjectGuestDoctorBO projectGuestDoctorBO = new ProjectGuestDoctorBO();

                if (txtProjectDoctor.Text == "")
                {
                    MessageBox.Show("Please Enter Doctor Name");
                    return;
                }
                projectGuestDoctorBO.guest_doctor_name = txtProjectDoctor.Text;

                int Result = 0;

                if (btnSave.Text == "Save")
                {
                    projectGuestDoctorBO.record_created_by = ApplicatinLauncher._userId;
                    Result = projectGuestDoctorBLL.AddProjectDoctor(projectGuestDoctorBO);
                }

                else
                {
                    projectGuestDoctorBO.record_modified_by = ApplicatinLauncher._userId;
                    projectGuestDoctorBO.guest_doctor_id = Convert.ToInt32(lvwDoctorList.SelectedItems[0].SubItems[0].Text);
                    Result = projectGuestDoctorBLL.UpdateProjectDoctor(projectGuestDoctorBO);
                }

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                    lvwDoctorList.Enabled = false;
                }


            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtProjectDoctor.Text = "";
            btnSave.Text = "Save";
            btnSave.Enabled = true;
            lvwDoctorList.Enabled = true;
            GetPageLoad();
        }

        private void lvwDoctorList_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithParameter("@DID", Convert.ToInt32(lvwDoctorList.SelectedItems[0].SubItems[0].Text), "ProjectDoctorLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtProjectDoctor.Text = ds.Tables[0].Rows[0][1].ToString();
                    btnSave.Text = "Update";
                }
            }

            catch
            {
            }
        }

    }
}
