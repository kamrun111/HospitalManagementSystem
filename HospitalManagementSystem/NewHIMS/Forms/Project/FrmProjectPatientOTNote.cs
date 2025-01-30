using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Project;
using NewHIMS.Forms.Common;

namespace NewHIMS.Forms.Project
{
    public partial class FrmProjectPatientOTNote : Form
    {
        public FrmProjectPatientOTNote()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmProjectPatientOTNote_Load(object sender, EventArgs e)
        {
            GetPageLoad();
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("ProjectLoad");

                cs.PopulateComboBox(cmbGender, ds, 0, "gender", "gender_id");
                cs.PopulateComboBox(cmbdocbilltype, ds, 4, "type_name", "guest_doctor_type");
                cs.PopulateComboBox(cmbRefDoctor, ds, 3, "guest_doctor_name", "guest_doctor_id");

                if (ds.Tables[2].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwProjectPatientList, ds, 2);
                }

                
            }
            catch
            {
            }
        }

        private void lvwProjectPatientList_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithParameter("@PPID", Convert.ToInt32(lvwProjectPatientList.SelectedItems[0].SubItems[0].Text), "ProjectPatientLoad");
                if (lvwProjectPatientList.SelectedItems.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtPatientNo.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtContactNumber.Text = ds.Tables[0].Rows[0][6].ToString();
                        cmbGender.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0][7]).ToString();
                        txtAge.Text = ds.Tables[0].Rows[0][9].ToString();
                        
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtOtReg.Text = ds.Tables[1].Rows[0][0].ToString();
                        txtOTName.Text = ds.Tables[1].Rows[0][1].ToString();
                        txtAnaesthesiaType.Text = ds.Tables[1].Rows[0][5].ToString();
                        txtStartTime.Text = ds.Tables[1].Rows[0][3].ToString();
                        txtFinishTime.Text = ds.Tables[1].Rows[0][4].ToString();
                        dtpOtDate.Value=Convert.ToDateTime(ds.Tables[1].Rows[0][2]);
                        txtPOTID.Text=Convert.ToInt32(ds.Tables[1].Rows[0][6]).ToString();
                        btnSave.Text = "Update";
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwPPODoctorList, ds, 2);
                    }

                }
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwProjectPatientList.SelectedItems.Count > 0)
                {
                    if (Validation() == true)
                    {
                        if (btnAdd.Text == "Add")
                        {
                            SaveList();
                        }
                        else
                        {
                            UpdateList();
                        }
                        
                    }
                }
                else
                    MessageBox.Show("Select A Patient From List");

            }
            catch
            {
            }
        }

        private bool Validation()
        {
            if (cmbdocbilltype.SelectedIndex == -1 || cmbRefDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Doctor or a Service from List");
                cmbRefDoctor.Focus();
                return false;
            }

            return true;
        }

        void SaveList()
        {
            try
            {
                ProjectOTDoctorListBO projectOTDoctorListBO = new ProjectOTDoctorListBO();
                ProjectOTDoctorListBLL projectOTDoctorListBLL = new ProjectOTDoctorListBLL();

                projectOTDoctorListBO.project_patient_id = Convert.ToInt32(lvwProjectPatientList.SelectedItems[0].SubItems[0].Text);
                projectOTDoctorListBO.ref_doctor_id = Convert.ToInt32(cmbRefDoctor.SelectedValue);
                projectOTDoctorListBO.type_id = Convert.ToInt32(cmbdocbilltype.SelectedValue);
                projectOTDoctorListBO.record_created_by = ApplicatinLauncher._userId;

                int Result = projectOTDoctorListBLL.AddDoctorList(projectOTDoctorListBO);

                ListViewItem lvi;
                lvi = lvwPPODoctorList.Items.Add(cmbRefDoctor.Text.ToString());
                lvi.SubItems.Add(cmbdocbilltype.Text.ToString());
                lvi.SubItems.Add(cmbRefDoctor.SelectedValue.ToString());
                lvi.SubItems.Add(cmbdocbilltype.SelectedValue.ToString());
                lvi.SubItems.Add(Result.ToString());

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    cmbRefDoctor.SelectedIndex = -1;
                    cmbdocbilltype.SelectedIndex = -1;
                }

            }
            catch
            {
            }
        }

        void UpdateList()
        {
            try
            {
                ProjectOTDoctorListBO projectOTDoctorListBO = new ProjectOTDoctorListBO();
                ProjectOTDoctorListBLL projectOTDoctorListBLL = new ProjectOTDoctorListBLL();

                projectOTDoctorListBO.project_ot_doctor_list_id = Convert.ToInt32(lvwPPODoctorList.SelectedItems[0].SubItems[4].Text);
                projectOTDoctorListBO.ref_doctor_id = Convert.ToInt32(cmbRefDoctor.SelectedValue);
                projectOTDoctorListBO.type_id = Convert.ToInt32(cmbdocbilltype.SelectedValue);
                projectOTDoctorListBO.record_modified_by = ApplicatinLauncher._userId;

                int Result = projectOTDoctorListBLL.UpdateDoctorList(projectOTDoctorListBO);

                if (Result > 0)
                {
                    btnAdd.Text = "Add";
                    cmbRefDoctor.SelectedIndex = -1;
                    cmbdocbilltype.SelectedIndex = -1;
                    DataSet ds = cs.GetDataSetWithParameter("@PPID", Convert.ToInt32(lvwProjectPatientList.SelectedItems[0].SubItems[0].Text), "ProjectPatientLoad");
                    cs.FillUpListview(lvwPPODoctorList, ds, 2);
                }
            }
            catch
            {
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnaesthesiaType.Text = "";
                txtOtReg.Text="";
                txtOTName.Text = "";
                dtpOtDate.Value = DateTime.Now;
                txtStartTime.Text = "";
                txtFinishTime.Text = "";
                txtContactNumber.Text = "";
                txtAge.Text = "";
                txtPatientName.Text = "";
                txtPatientNo.Text = "";
                cmbGender.SelectedIndex = -1;
                cmbRefDoctor.SelectedIndex = -1;
                cmbdocbilltype.SelectedIndex = -1;
                btnSave.Enabled = true;
                btnSave.Text = "Save";
                txtPOTID.Text = "";
                lvwPPODoctorList.Items.Clear();
                GetPageLoad();


            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectPatientOTBO projectPatientOTBO = new ProjectPatientOTBO();
                ProjectPatientOTBLL projectPatientOTBLL = new ProjectPatientOTBLL();

                
                projectPatientOTBO.ot_name = txtOTName.Text;
                projectPatientOTBO.anesthia_type = txtAnaesthesiaType.Text;
                projectPatientOTBO.ot_date = Convert.ToDateTime(dtpOtDate.Value);
                projectPatientOTBO.ot_start_time = txtStartTime.Text;
                projectPatientOTBO.ot_finish_time = txtFinishTime.Text;
                projectPatientOTBO.project_patient_id = Convert.ToInt32(lvwProjectPatientList.SelectedItems[0].SubItems[0].Text);

                int Result =0;

                if (btnSave.Text == "Save")
                {
                    projectPatientOTBO.record_created_by = ApplicatinLauncher._userId;
                    Result = projectPatientOTBLL.AddProjectPatientOT(projectPatientOTBO);
                }

                else
                {
                    projectPatientOTBO.project_ot_id = Convert.ToInt32(txtPOTID.Text);
                    projectPatientOTBO.record_modified_by = ApplicatinLauncher._userId;
                    Result = projectPatientOTBLL.UpdateProjectPatientOT(projectPatientOTBO);
                }

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

        private void lvwPPODoctorList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPPODoctorList.Items.Count > 0)
                {
                    if (lvwPPODoctorList.SelectedItems[0].SubItems[4].Text != null)
                    {
                        btnAdd.Text = "Update";
                        cmbdocbilltype.SelectedValue = Convert.ToInt32(lvwPPODoctorList.SelectedItems[0].SubItems[3].Text);
                        cmbRefDoctor.SelectedValue = Convert.ToInt32(lvwPPODoctorList.SelectedItems[0].SubItems[2].Text);

                    }

                }

            }
            catch
            {
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
