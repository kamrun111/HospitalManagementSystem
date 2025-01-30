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


namespace NewHIMS.Forms.Dialysis
{
    public partial class FrmDialysisMedicineIssue : Form
    {
        public FrmDialysisMedicineIssue()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmDialysisMedicineIssue_Load(object sender, EventArgs e)
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

                DataSet ds = cs.GetDataSet("DialysisMedicineCheckLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);

                    for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                    {
                        int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[5].Text);
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

                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "0")
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
                txtName.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                txtPatientCode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;

                DataSet ds = cs.GetDataSet("DialysisMedicineCheckLoad");

                if (ds.Tables[1].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                    {

                        grdCheckList.Rows.Add();
                        grdCheckList.Rows[i].Cells[1].Value = ds.Tables[1].Rows[i][0].ToString();//item_id
                        grdCheckList.Rows[i].Cells[2].Value = ds.Tables[1].Rows[i][1].ToString();//name
                        grdCheckList.Rows[i].Cells[3].Value = ds.Tables[1].Rows[i][2].ToString();//qty
                        grdCheckList.Rows[i].Cells[4].Value = ds.Tables[1].Rows[i][2].ToString();//issue
                        grdCheckList.Rows[i].Cells[5].Value = "0";
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
                txtName.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                txtPatientCode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;

                DataSet ds = cs.GetDataSetWithParameter("@IssueID", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[5].Text), "DialysisMedicineIssuelistLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        grdCheckList.Rows.Add();
                        grdCheckList.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString(); //issue Details ID
                        grdCheckList.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();//item_id
                        grdCheckList.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();//name  
                        grdCheckList.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString(); //order qty
                        grdCheckList.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4].ToString(); //issue qty
                        grdCheckList.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][5].ToString(); // balance qty

                    }

                    txtRequisitionNo.Text = ds.Tables[1].Rows[0][0].ToString();

                    btnSave.Enabled = true;
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
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialysisMedicineIssueBO dialysisMedicineIssueBO = new DialysisMedicineIssueBO();
                DialysisMedicineIssueBLL dialysisMedicineIssueBLL = new DialysisMedicineIssueBLL();

                List<DialysisMedicineIssueDetailsBO> listDialysisMedicineIssueDetailsBO = new List<DialysisMedicineIssueDetailsBO>();


                dialysisMedicineIssueBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                dialysisMedicineIssueBO.requisition_no = txtRequisitionNo.Text;
                dialysisMedicineIssueBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);

                for (int i = 0; i < grdCheckList.Rows.Count; i++)
                {
                    DialysisMedicineIssueDetailsBO dialysisMedicineIssueDetailsBO = new DialysisMedicineIssueDetailsBO();

                    dialysisMedicineIssueDetailsBO.medicine_id = Convert.ToInt32(grdCheckList.Rows[i].Cells[1].Value);
                    dialysisMedicineIssueDetailsBO.order_qty = Convert.ToDecimal(grdCheckList.Rows[i].Cells[3].Value);
                    dialysisMedicineIssueDetailsBO.issue_qty = Convert.ToDecimal(grdCheckList.Rows[i].Cells[4].Value);
                    dialysisMedicineIssueDetailsBO.balance_qty = Convert.ToDecimal(grdCheckList.Rows[i].Cells[5].Value);

                    if ((grdCheckList.Rows[i].Cells[0].Value) != "")
                    {
                        dialysisMedicineIssueDetailsBO.dialysis_medicine_issue_details_id = Convert.ToInt32(grdCheckList.Rows[i].Cells[0].Value);
                    }
                    dialysisMedicineIssueDetailsBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);
                    dialysisMedicineIssueDetailsBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                    listDialysisMedicineIssueDetailsBO.Add(dialysisMedicineIssueDetailsBO);
                }

                int Result;

                if (btnSave.Text == "Save")
                {
                    Result = dialysisMedicineIssueBLL.DialysisMedicineIssueAdd(dialysisMedicineIssueBO, listDialysisMedicineIssueDetailsBO);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
