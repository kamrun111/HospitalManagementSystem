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
using NewHIMS.Reports.OTMedecine;
using CrystalDecisions.CrystalReports.Engine;


namespace NewHIMS.Forms.Nurse_Station
{
    public partial class FrmPatientMedicine : Form
    {
        

        public FrmPatientMedicine()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();
            

        private void FrmPatientMedicine_Load(object sender, EventArgs e)
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
                btnSave.Text = "Save";
                btnSave.Enabled = false;

                DataSet ds = cs.GetDataSet("GetIPDInvestigationPopulationInfo");

                if (ds.Tables[5].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 5);

                    for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                    {
                        int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[9].Text);
                        if (d > 0)
                        {
                            lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                        }
                    }

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
                txtName.Text = "";
                txtPatientCode.Text = "";
                txtRequisitionNo.Text = "";

                grdOTInjection.Rows.Clear();

            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                GetRefresh();

                if (lvwPatientInfo.SelectedItems[0].SubItems[9].Text == "0")
                {
                    LoadforSave();
                }

                else
                {
                    LoadforUpdate();
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
                txtName.Text=lvwPatientInfo.SelectedItems[0].SubItems[5].Text;
                txtPatientCode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;

                DataSet ds = cs.GetDataSet("OTMedicineLoad");

                if (ds.Tables[3].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[3].Rows.Count; i++)
                    {
                        
                        grdOTInjection.Rows.Add();
                        grdOTInjection.Rows[i].Cells[1].Value = ds.Tables[3].Rows[i][0].ToString();//product_id
                        grdOTInjection.Rows[i].Cells[2].Value = ds.Tables[3].Rows[i][1].ToString();//product      
                    }
                    btnSave.Enabled = true;
                    btnSave.Text = "Save";
                }
            }
            catch
            {
            }
        }

        void LoadforUpdate()
        {
            try
            {
                txtName.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text;
                txtPatientCode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;

                DataSet ds = cs.GetDataSetWithParameter("@ID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text), "OTPatientMedicineLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        grdOTInjection.Rows.Add();
                        grdOTInjection.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString(); //OT Medicine Details ID
                        grdOTInjection.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();//product_id
                        grdOTInjection.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();//product  
                        grdOTInjection.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString(); //Order Qty
    
                    }

                    //txtRequisitionNo.Text = ds.Tables[0].Rows[0][7].ToString();

                    btnSave.Enabled = true;
                    btnSave.Text = "Update";
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
                PatientOTMedicineBO patientOTMedicineBO = new PatientOTMedicineBO();
                PatientOTMedicineBLL patientOTMedicineBLL = new PatientOTMedicineBLL();
                List<PatientOTMedicineDetailsBO> listPatientOTMedicineDetailsBO = new List<PatientOTMedicineDetailsBO>();


                patientOTMedicineBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                patientOTMedicineBO.requisition_no = txtRequisitionNo.Text;
                patientOTMedicineBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);

                for (int i = 0; i < grdOTInjection.Rows.Count; i++)
                {
                    PatientOTMedicineDetailsBO patientOTMedicineDetailsBO = new PatientOTMedicineDetailsBO();

                    patientOTMedicineDetailsBO.product_id = Convert.ToInt32(grdOTInjection.Rows[i].Cells[1].Value);
                    if ((grdOTInjection.Rows[i].Cells[3].Value) != "")
                    {
                        patientOTMedicineDetailsBO.order_qty = Convert.ToInt32(grdOTInjection.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        patientOTMedicineDetailsBO.order_qty = 0;
                    }
                    if ((grdOTInjection.Rows[i].Cells[0].Value) != "")
                    {
                        patientOTMedicineDetailsBO.patient_ot_medicine_details_id = Convert.ToInt32(grdOTInjection.Rows[i].Cells[0].Value);
                    }
                    patientOTMedicineDetailsBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);
                    patientOTMedicineDetailsBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                    listPatientOTMedicineDetailsBO.Add(patientOTMedicineDetailsBO);
                }

                int Result;

                if (btnSave.Text == "Save")
                {
                    Result = patientOTMedicineBLL.OTMedicineAdd(patientOTMedicineBO, listPatientOTMedicineDetailsBO);

                    if (Result > 0)
                    {
                        btnSave.Enabled = false;
                        MessageBox.Show("Data Saved Successfully");
                        
                    }
                }
                if (btnSave.Text == "Update")
                {
                    //Result = patientOTMedicineBLL.OTMedicineUpdate(listPatientOTMedicineDetailsBO);

                    //if (Result > 0)
                    //{
                    //    btnSave.Enabled = false;
                    //    MessageBox.Show("Data Updated Successfully");
                    //}
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
            }
        }


        void PatientMedicinePrint(int MedicineID)
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new PatientOTMedicineReport();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }

            rptCustomersOrders.SetParameterValue("@MedicineID", MedicineID);

            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            frmGenericReportViewer.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PatientMedicinePrint(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));
            }
            catch
            {
            }
        }
        
    }
}
