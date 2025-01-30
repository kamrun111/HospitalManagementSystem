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
    public partial class FrmOTPreCheckList : Form
    {
        public FrmOTPreCheckList()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmOTPreCheckList_Load(object sender, EventArgs e)
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

                DataSet ds = cs.GetDataSet("PreOperativeCheckLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);

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

                grdCheckList.Rows.Clear();

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
                txtName.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text;
                txtPatientCode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;

                DataSet ds = cs.GetDataSet("PreOperativeCheckLoad");

                if (ds.Tables[1].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                    {

                        grdCheckList.Rows.Add();
                        grdCheckList.Rows[i].Cells[1].Value = ds.Tables[1].Rows[i][0].ToString();//item_id
                        grdCheckList.Rows[i].Cells[2].Value = ds.Tables[1].Rows[i][1].ToString();//List
                        grdCheckList.Rows[i].Cells[3].Value = ds.Tables[1].Rows[i][2].ToString();//Status
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

                DataSet ds = cs.GetDataSetWithParameter("@CheckID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text), "PreOperativeChecklistLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        grdCheckList.Rows.Add();
                        grdCheckList.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString(); //OT Checklist Details ID
                        grdCheckList.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();//item_id
                        grdCheckList.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();//List  
                        grdCheckList.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString(); //Status

                    }

                    txtRequisitionNo.Text = ds.Tables[0].Rows[0][4].ToString();

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
                PreOperativeCheckListBO preOperativeCheckListBO = new PreOperativeCheckListBO();
                PreOperativeCheckListBLL preOperativeCheckListBLL = new PreOperativeCheckListBLL();
                List<PreOperativeCheckListDetailsBO> listPreOperativeCheckListDetailsBO = new List<PreOperativeCheckListDetailsBO>();


                preOperativeCheckListBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                preOperativeCheckListBO.requisition_no = txtRequisitionNo.Text;
                preOperativeCheckListBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);

                for (int i = 0; i < grdCheckList.Rows.Count; i++)
                {
                    PreOperativeCheckListDetailsBO preOperativeCheckListDetailsBO = new PreOperativeCheckListDetailsBO();

                    preOperativeCheckListDetailsBO.item_id = Convert.ToInt32(grdCheckList.Rows[i].Cells[1].Value);
                    
                    preOperativeCheckListDetailsBO.status = grdCheckList.Rows[i].Cells[3].Value.ToString();
                    
                    if ((grdCheckList.Rows[i].Cells[0].Value) != "")
                    {
                        preOperativeCheckListDetailsBO.pre_operative_checklist_id = Convert.ToInt32(grdCheckList.Rows[i].Cells[0].Value);
                    }
                    preOperativeCheckListDetailsBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);
                    preOperativeCheckListDetailsBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                    listPreOperativeCheckListDetailsBO.Add(preOperativeCheckListDetailsBO);
                }

                int Result;

                if (btnSave.Text == "Save")
                {
                    Result = preOperativeCheckListBLL.PreOperativeCheckListAdd(preOperativeCheckListBO, listPreOperativeCheckListDetailsBO);

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
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PreOperativeCheckListReport();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@CheckID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }


        
    }
}
