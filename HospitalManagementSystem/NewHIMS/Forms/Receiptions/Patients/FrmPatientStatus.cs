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
    public partial class FrmPatientStatus : Form
    {
        public FrmPatientStatus()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmPatientStatus_Load(object sender, EventArgs e)
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
                lvwStatus.Enabled = false;
                btnSave.Enabled = false;
            }
            catch
            {
            }
        }

        void GetRefresh()
        {
            try
            {
                lvwStatus.Items.Clear();
                txtCabin.Text = "";
                txtID.Text = "";
                txtContactNumber.Text = "";
                txtPatientName.Text = "";
                cmbStatus.SelectedIndex = -1;
                btnSave.Text = "Save";
                lvwStatus.Enabled = false;
            }
            catch
            {
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithStringParameter("@AdmissionID", txtAdmissionID.Text, "PatientStatusLoad");

                GetRefresh();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPatientName.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtContactNumber.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCabin.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtID.Text = ds.Tables[0].Rows[0][0].ToString();
                    lvwStatus.Enabled = true;
                    
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwStatus, ds, 1);
                }

            }
            catch
            {
            }
        }

        private void lvwStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwStatus.SelectedItems.Count > 0)
                {
                    cmbStatus.SelectedItem = lvwStatus.SelectedItems[0].SubItems[2].Text;
                    btnSave.Text = "Update";
                    btnSave.Enabled = true;
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
                AdmissionBO admissionBO = new AdmissionBO();
                AdmissionBLL admissionBLL = new AdmissionBLL();

                admissionBO.admission_id = Convert.ToInt32(txtID.Text);
                admissionBO.pt_type = cmbStatus.SelectedItem.ToString();
                admissionBO.record_modified_by = ApplicatinLauncher._userId;

                //if ((btnSave.Text == "Update") && (ApplicatinLauncher._userId == 1) || (ApplicatinLauncher._userId == 7))
                //{
                    int Result = admissionBLL.AdmissionStatusUpdate(admissionBO);

                    if (Result > 0)
                    {
                        MessageBox.Show("Data Updated Successfully");
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong. Please try Again");
                    }

                //}
                //else
                //{
                //    MessageBox.Show("You have no Permission.");
                //}
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
                lvwStatus.Items.Clear();
                btnSave.Enabled = false;
                txtAdmissionID.Text = "";

            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
