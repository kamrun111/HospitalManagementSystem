using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Data.Common;
using NewHIMS.Reports;
using NewHIMS.Reports.Certificate;
using CrystalDecisions.CrystalReports.Engine;



namespace NewHIMS.Forms.Receiptions.Certificate
{
    public partial class FrmDeathCertificate : Form
    {
        public FrmDeathCertificate()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmDeathCertificate_Load(object sender, EventArgs e)
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
                DataSet ds = cs.GetDataSet("DeathCertificateLoad");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);

                    for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                    {
                        int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[9].Text);
                        if (d > 0)
                        {
                            lvwPatientInfo.Items[i].ForeColor = Color.Red;
                        }
                    }

                }

                btnSave.Enabled = false;
                btnSave.Text = "Save";
                
               
            }
            catch
            {
            }
        }

        void GetRefresh()
        {
            try
            {
                txtPatientName.Text = "";
                txtHospitalID.Text = "";
                txtAdRegNo.Text = "";
                txtAdDate.Text = "";
                txtAddress.Text = "";
                txtAge.Text = "";
                txtDeathDate.Text = "";
                txtConsultant.Text = "";
                txtGender.Text = "";
                txtGurdianName.Text = "";
                txtClinical.Text = "";
                txtCause.Text = "";
                txtAttDoctor.Text = "";
                txtSignature.Text = "";
                cmbRelation.SelectedIndex = -1;
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
                    GetRefresh();

                    if (lvwPatientInfo.SelectedItems[0].SubItems[9].Text == "0")
                    {
                        GetLoadForSave();
                        btnSave.Enabled = true;
                        btnSave.Text = "Save";
                    }
                    else
                    {
                        GetLoadForUpdate();
                        btnSave.Enabled = true;
                        btnSave.Text = "Update";
                    }
                }
            }
            catch
            {
            }
        }

        void GetLoadForSave()
        {
            try
            {
                txtPatientName.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text;
                txtHospitalID.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                txtGurdianName.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text;
                txtGender.Text = lvwPatientInfo.SelectedItems[0].SubItems[8].Text;
                txtAdRegNo.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text;
                txtAdDate.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;
                txtAge.Text = lvwPatientInfo.SelectedItems[0].SubItems[7].Text;
                txtAddress.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text;

            }
            catch
            {
            }
        }

        void GetLoadForUpdate()
        {
            try
            {
                DataSet ds = cs.GetDataSetWithParameter("@CertificateID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text), "DeathCertificateEditLoad");

                if(ds.Tables[0].Rows.Count>0)
                {
                    txtPatientName.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtHospitalID.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtGurdianName.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtAdRegNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtAdDate.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAge.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][8].ToString();

                    txtConsultant.Text=ds.Tables[0].Rows[0][10].ToString();
                    txtClinical.Text=ds.Tables[0].Rows[0][11].ToString();
                    txtCause.Text=ds.Tables[0].Rows[0][12].ToString();
                    txtDeathDate.Text=ds.Tables[0].Rows[0][13].ToString();
                    txtAttDoctor.Text=ds.Tables[0].Rows[0][14].ToString();
                    txtSignature.Text=ds.Tables[0].Rows[0][15].ToString();
                    cmbRelation.SelectedItem = ds.Tables[0].Rows[0][16].ToString();

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
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DeathCertificateBLL deathCertificateBLL = new DeathCertificateBLL();
                DeathCertificateBO deathCertificateBO = new DeathCertificateBO();

                deathCertificateBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                deathCertificateBO.patient_id = txtHospitalID.Text;
                deathCertificateBO.reg_no = txtAdRegNo.Text;
                deathCertificateBO.patient_name = txtPatientName.Text;
                deathCertificateBO.age=txtAge.Text;
                deathCertificateBO.gender=txtGender.Text;
                deathCertificateBO.gurdian_name=txtGurdianName.Text;
                deathCertificateBO.address=txtAddress.Text;
                deathCertificateBO.admission_date = txtAdDate.Text;
                deathCertificateBO.death_date = txtDeathDate.Text;
                deathCertificateBO.clinical_diagnosis = txtClinical.Text;
                deathCertificateBO.cause_of_death = txtCause.Text;
                deathCertificateBO.consultant = txtConsultant.Text;
                deathCertificateBO.doctor_attending = txtAttDoctor.Text;
                deathCertificateBO.report_created_doctor = txtSignature.Text;
                deathCertificateBO.relation = cmbRelation.SelectedItem.ToString();
                deathCertificateBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);
                deathCertificateBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                if (btnSave.Text == "Save")
                {
                    int Result = deathCertificateBLL.DeathCertificateAdd(deathCertificateBO);

                    if (Result > 0)
                    {
                        btnSave.Enabled = false;
                        MessageBox.Show("Data Saved Successfully");
                    }
                }

                if (btnSave.Text == "Update")
                {
                    deathCertificateBO.death_certificate_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text);

                    int Result = deathCertificateBLL.DeathCertificateUpdate(deathCertificateBO);

                    if (Result > 0)
                    {
                        btnSave.Enabled = false;
                        MessageBox.Show("Data Updated Successfully");
                    }
                }
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    if (lvwPatientInfo.SelectedItems[0].SubItems[9].Text == "0")
                    {
                        MessageBox.Show("No Certificate is Saved, Please Save First");
                    }
                    if (lvwPatientInfo.SelectedItems[0].SubItems[9].Text != "0")
                    {
                        DeathCertificatePrint();
                    }
                }
            }
            catch
            {
            }
        }

        void DeathCertificatePrint()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new DeathCertificate();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }

            rptCustomersOrders.SetParameterValue("@CertificateID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));
            
            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            frmGenericReportViewer.Show();
        }

    }
}
