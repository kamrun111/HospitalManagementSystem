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
    public partial class FrmBirthCertificate : Form
    {
        public FrmBirthCertificate()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmBirthCertificate_Load(object sender, EventArgs e)
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
                DataSet ds = cs.GetDataSet("BirthCertificateLoad");
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
                txtReligion.Text = "";
                txtAddress.Text = "";
                txtWeight.Text = "";
                txtBaby.Text = "";
                txtConsultant.Text = "";
                txtGender.Text = "";
                txtFatherName.Text = "";
                txtIdentification.Text = "";
                txtDeliveryDate.Text = "";
                txtPlace.Text = "";
                
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
                txtFatherName.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text;
                //txtGender.Text = lvwPatientInfo.SelectedItems[0].SubItems[8].Text;
                txtAdRegNo.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text;
                //txtAdDate.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;
                //txtWeight.Text = lvwPatientInfo.SelectedItems[0].SubItems[7].Text;
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
                DataSet ds = cs.GetDataSetWithParameter("@CertificateID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text), "BirthCertificateEditLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPatientName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtHospitalID.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtFatherName.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtAdRegNo.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtReligion.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtWeight.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();

                    txtConsultant.Text = ds.Tables[0].Rows[0][11].ToString();
                    txtIdentification.Text = ds.Tables[0].Rows[0][13].ToString();
                    txtBaby.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtDeliveryDate.Text = ds.Tables[0].Rows[0][12].ToString();
                    txtPlace.Text = ds.Tables[0].Rows[0][14].ToString();

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
                BirthCertificateBLL birthCertificateBLL = new BirthCertificateBLL();
                BirthCertificateBO birthCertificateBO = new BirthCertificateBO();

                birthCertificateBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                birthCertificateBO.patient_id = txtHospitalID.Text;
                birthCertificateBO.reg_no = txtAdRegNo.Text;
                birthCertificateBO.mother_name = txtPatientName.Text;
                birthCertificateBO.weight = txtWeight.Text;
                birthCertificateBO.gender = txtGender.Text;
                birthCertificateBO.father_name = txtFatherName.Text;
                birthCertificateBO.address = txtAddress.Text;
                birthCertificateBO.delivery_date = txtDeliveryDate.Text;
                birthCertificateBO.baby_name = txtBaby.Text;
                birthCertificateBO.identification_mark = txtIdentification.Text;
                birthCertificateBO.religion = txtReligion.Text;
                birthCertificateBO.consultant = txtConsultant.Text;
                birthCertificateBO.birth_place = txtPlace.Text;
                
                birthCertificateBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);
                birthCertificateBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                if (btnSave.Text == "Save")
                {
                    int Result = birthCertificateBLL.BirthCertificateAdd(birthCertificateBO);

                    if (Result > 0)
                    {
                        btnSave.Enabled = false;
                        MessageBox.Show("Data Saved Successfully");
                    }
                }

                if (btnSave.Text == "Update")
                {
                    birthCertificateBO.birth_certificate_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text);

                    int Result = birthCertificateBLL.BirthCertificateUpdate(birthCertificateBO);

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
                        BirthCertificatePrint();
                    }
                }
            }
            catch
            {
            }
        }


        void BirthCertificatePrint()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new BirthCertificate();

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
