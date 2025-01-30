using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmPatientRefDoctor : Form
    {
        public FrmPatientRefDoctor()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();
        

        private void FrmPatientRefDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
                
            }
            catch
            {
            }
        }

        void GetPageLoad()
        {
            try
            {
                DataSet dt = cs.GetDataSet("GetAdmissionPopulationInfo");
                cs.PopulateComboBox(cmbRefDoctor, dt, 7, "reffDoc", "reffered_doctors_id");
                lvwRefDoctorList.Enabled = false;
                btnSave.Enabled = false;
            }
            catch
            {
            }
        }

        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithStringParameter("@AdmissionID", txtAdmissionID.Text, "PatientReffDoctorLoad");

                GetRefresh();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview (lvwRefDoctorList, ds, 0);
                    txtPatientName.Text=ds.Tables[0].Rows[0][3].ToString();
                    txtContactNumber.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCabin.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtID.Text = ds.Tables[0].Rows[0][10].ToString();
                    lvwRefDoctorList.Enabled = true;
                    btnSave.Enabled = true;
                }
                
            }
            catch
            {
            }
        }

        void GetRefresh()
        {
            try
            {
                lvwRefDoctorList.Items.Clear();
                txtCabin.Text = "";
                txtContactNumber.Text = "";
                txtPatientName.Text = "";
                cmbRefDoctor.SelectedIndex = -1;
                btnSave.Text = "Save";
                lvwRefDoctorList.Enabled = false;
            }
            catch
            {
            }
        }

        private void lvwRefDoctorList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwRefDoctorList.SelectedItems.Count > 0)
                {
                    cmbRefDoctor.SelectedValue = lvwRefDoctorList.SelectedItems[0].SubItems[9].Text;
                    btnSave.Text = "Update";
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
                GetRefresh();
                GetPageLoad();
                txtAdmissionID.Text = "";
                btnSave.Enabled = false;

            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PatientRefferedDoctors patientRefferedDoctors = new PatientRefferedDoctors();
                PatientRefferedDoctorsBLL patientRefferedDoctorsBLL = new PatientRefferedDoctorsBLL();

                patientRefferedDoctors.admission_id = Convert.ToInt32(txtID.Text);
                patientRefferedDoctors.reffered_doctors_id = Convert.ToInt32(cmbRefDoctor.SelectedValue);
                
                if (btnSave.Text == "Update")
                {
                    patientRefferedDoctors.record_modified_by = ApplicatinLauncher._userId;
                    patientRefferedDoctors.patient_reffered_doctors_id = Convert.ToInt32(lvwRefDoctorList.SelectedItems[0].SubItems[0].Text);

                    int Result = patientRefferedDoctorsBLL.ReffDoctorUpdate(patientRefferedDoctors);

                    if (Result > 0)
                    {
                        MessageBox.Show("Data Updated Successfully");
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong. Please try Again");
                    }

                }

                if (btnSave.Text == "Save")
                {
                    patientRefferedDoctors.record_created_by = ApplicatinLauncher._userId;

                    int Result = patientRefferedDoctorsBLL.ReffDoctorAdd(patientRefferedDoctors);

                    if (Result > 0)
                    {
                        MessageBox.Show("Data Saved Successfully");
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong. Please try Again");
                    }
                }

            }
            catch
            {
            }
        }
    }
}
