using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Bill;
using NewHIMS.Reports.Payment;


namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmInsurancePatient : Form
    {

        CommonClass cs = new CommonClass();

        public FrmInsurancePatient()
        {
            InitializeComponent();
        }

        private void FrmInsurancePatient_Load(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
                btnAssign.Enabled = false;
                btnAssign.Text = "Assign";
            }
            catch
            {
            }
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("PaymentinfoMember");

                lvwPatientInfo.Items.Clear();

                if (ds.Tables[6].Rows.Count > 0)
                {
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwPatientInfo, ds, 6);

                        for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                        {
                            int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[9].Text);
                            if (d == 1)
                                lvwPatientInfo.Items[i].ForeColor = Color.BlueViolet;
                        }

                    }

                }
            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {

                    cmbCompany.ResetText();

                    if (lvwPatientInfo.SelectedItems[0].SubItems[9].Text == "0")
                    {
                        LoadforSave();
                        btnAssign.Text = "Assign";
                        btnAssign.Enabled = true;
                        cmbCompany.SelectedText ="General Patient";
                    }

                    else
                    {
                        LoadforSave();
                        btnAssign.Text = "Update";
                        btnAssign.Enabled = false;
                        cmbCompany.SelectedText ="Insurance Patient";
                    }
                }

            }
            catch
            {
            }
        }

        void LoadforSave()
        {
            try
            {
                txtName.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                txtMobile.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text;
                txtPType.Text = lvwPatientInfo.SelectedItems[0].SubItems[8].Text;
                txtGurdian.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text;
                txtAddress.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text;


            }
            catch
            {
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
             try
            {
                AdmissionBLL admissionBLL = new AdmissionBLL();
                AdmissionBO admissionBO = new AdmissionBO();

                admissionBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                if (cmbCompany.Text == "General Patient")
                {
                    admissionBO.insurance_type = 1;
                }
                else
                {
                    MessageBox.Show("Patient Already Assigned");
                    return;
                }
                admissionBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                int Result = admissionBLL.InsuranceUpdate(admissionBO);

                if (Result > 0)
                {
                    MessageBox.Show("Patient Assigned Successfully.");
                    btnAssign.Enabled = false;
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
                btnAssign.Enabled = false;
                btnAssign.Text = "Assign";

            }
            catch
            {
            }
        }
        



    }
}
