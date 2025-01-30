using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using HIMS.BusinessObjects;
using HIMS.BLL;
using NewHIMS.Reports.Investigation;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmInvestigationTestListView : BaseForm.FrmBase
    {
        private string _testDept;
        private string _testItem;
        
        public FrmInvestigationTestListView()
        {
            InitializeComponent();
        }

        public void  RefreshContent(string testDept)
        {
            try
            {
                lblInvestigationTestTitle.Text = "Test Report (" + testDept + ")";
                this._testDept = testDept;
                ////rdoOpd.Checked = true;
                PopulateList();
                if (this._testDept == "Pathology")
                {
                    grdTest.Visible = true;
                    lblResult.Visible = false;
                    lblRefferengeValue.Visible = false;
                    txtResult.Visible = false;
                    txtReferenceValue.Visible = false;
                }
                else
                {
                    grdTest.Visible = false;
                    lblResult.Visible = true;
                    lblRefferengeValue.Visible = true;
                    txtResult.Visible = true;
                    txtReferenceValue.Visible = true;
                }
                txtHospitalID.Text = "";
                txtAdmissionID.Text = "";
                txtCabin.Text = "";
                txtOrder.Text = "";
                //PopulateList();
            }
            catch
            {
            }
                 
        }
       
        void PopulateList()
        {
            try
            {
                InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationTestBLL.GetSampleCollectionInfo(this._testDept,1);  //SP-->  <SampleCollectionInfoGet>
                DataSet dsg = investigationBLL.GetInvestigationPopulationInfo();
                lvwMainList.Items.Clear();
                if (rdoOpd.Checked)
                {
                    FillUpListview(lvwMainList, ds, 0);
                    chkAdmissionID.Enabled = false;
                    chkCabin.Enabled = false;
                    txtAdmissionID.Enabled = false;
                    txtCabin.Enabled = false;
                }
                else
                {
                    FillUpListview(lvwMainList, ds, 2);
                    chkAdmissionID.Enabled = true;
                    chkCabin.Enabled = true;
                    txtAdmissionID.Enabled = true;
                    txtCabin.Enabled = true;
                }
                //lblTestDetails.Text = lvwMainList.SelectedItems[0].SubItems[5].Text;

                PopulateComboBox(cmbRefferedDoctors, ds, 1, "reffered_doctors", "reffered_doctors_id");
                PopulateComboBox(cmbGender, dsg, 1, "gender", "gender_id");
                for (int i = 0; i < lvwMainList.Items.Count; i++)
                {
                    if (Convert.ToInt32(lvwMainList.Items[i].SubItems[12].Text) == 1)
                    {
                        lvwMainList.Items[i].ForeColor = Color.Blue;
                    }
                }
            }
            catch
            { 
            }
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.SelectedIndex = -1;
                    combo.Text = "<Select>";
            }
            catch
            {
            }
        }

        private void FillUpListview(ListView lvw, DataSet ds,int TableIndex)
        {

            try
            {
                lvw.Items.Clear();

                for (int i = 0; i < ds.Tables[TableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[TableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow["investigation_id"].ToString());
                        lvi.SubItems.Add(dataRow[0].ToString());
                        lvi.SubItems.Add(dataRow[1].ToString());                   
                        lvi.SubItems.Add(dataRow[2].ToString());                    
                        lvi.SubItems.Add(dataRow[3].ToString());                    
                        lvi.SubItems.Add(dataRow[4].ToString());
                        lvi.SubItems.Add(dataRow[5] + " / " + dataRow[6] + "/" + dataRow[14]);       
                        lvi.SubItems.Add(dataRow[6].ToString());
                        lvi.SubItems.Add(dataRow[7].ToString());
                        lvi.SubItems.Add(dataRow[8].ToString());            
                        lvi.SubItems.Add(dataRow[9].ToString());                    
                        lvi.SubItems.Add(dataRow[10].ToString());
                        lvi.SubItems.Add(dataRow[12].ToString());
                        lvi.SubItems.Add(dataRow[14].ToString());
                        lvi.SubItems.Add(dataRow[15].ToString());
                        lvi.SubItems.Add(dataRow[16].ToString());
                       
                        lvw.Items.Add(lvi);                                         
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
        private void lvwMainList_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwMainList.SelectedItems.Count > 0)
                {
                    if (Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[12].Text) == 1)
                    {
                        grpBaby.Enabled = true;
                    }
                    else
                    {
                        grpBaby.Enabled = false;
                    }
                    if (this._testDept == "Pathology")
                    {
                        InvestigationBO investigationBO = new InvestigationBO();
                        InvestigationBLL investigationBLL = new InvestigationBLL();
                        DataSet dselement = investigationBLL.GetTestElement(Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[8].Text));
                        DataSet dselement2 = investigationBLL.GetTestElement2(Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[9].Text));
                        grdTest.Rows.Clear();
                        if (dselement.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < dselement.Tables[0].Rows.Count; i++)
                            {
                                grdTest.Rows.Add();
                                grdTest.Rows[i].Cells["test_element_id"].Value = dselement.Tables[0].Rows[i]["test_element_id"].ToString();
                                grdTest.Rows[i].Cells["test_element"].Value = dselement.Tables[0].Rows[i]["test_element"].ToString();
                                grdTest.Rows[i].Cells["result"].Value = dselement.Tables[0].Rows[i]["result"].ToString();
                                grdTest.Rows[i].Cells["reference_values"].Value = dselement.Tables[0].Rows[i]["reference_value"].ToString();
                            }
                            cmbRefferedDoctors.SelectedValue = Convert.ToInt32(dselement.Tables[1].Rows[0][0].ToString());
                            cmbRefferedDoctors.Text = dselement.Tables[1].Rows[0][1].ToString();
                        }
                        else
                        {
                            for (int i = 0; i < dselement2.Tables[0].Rows.Count; i++)
                            {
                                grdTest.Rows.Add();
                                grdTest.Rows[i].Cells["test_element_id"].Value = dselement2.Tables[0].Rows[i]["test_element_id"].ToString();
                                grdTest.Rows[i].Cells["test_element"].Value = dselement2.Tables[0].Rows[i]["test_element"].ToString();
                                grdTest.Rows[i].Cells["reference_values"].Value = dselement2.Tables[0].Rows[i]["reference_value"].ToString();
                            }
                            cmbRefferedDoctors.SelectedIndex = -1;
                        }
                        for (int i = 0; i < grdTest.Rows.Count - 1; i++)
                        {
                            if (grdTest.Rows[i].Cells[2].Value != null)
                            {
                                btnSave.Enabled = false; ;
                                btnUpdate.Enabled = true;
                                btnPrintSampleCollected.Enabled = true;
                            }
                            else
                            {
                                btnSave.Enabled = true; ;
                                btnUpdate.Enabled = false;
                                btnPrintSampleCollected.Enabled = true;
                            }
                        }

                    }
                    else
                    {
                        if (lvwMainList.SelectedItems[0].SubItems[10].Text != null)
                            txtResult.Text = lvwMainList.SelectedItems[0].SubItems[10].Text.ToString();
                        txtReferenceValue.Text = lvwMainList.SelectedItems[0].SubItems[9].Text.ToString();
                        if (lvwMainList.SelectedItems[0].SubItems[10].Text == "Processing" || lvwMainList.SelectedItems[0].SubItems[10].Text == "")
                        {
                            btnPrintSampleCollected.Enabled = false;
                            btnUpdate.Enabled = false;
                            btnSave.Enabled = true;
                        }
                        else
                        {
                            btnPrintSampleCollected.Enabled = true;
                            btnSave.Enabled = false;
                            btnUpdate.Enabled = true;
                        }
                        //if (txtResult.Text != "")
                        //    btnSave.Enabled = true;

                    }
                    if (lvwMainList.SelectedItems[0].SubItems[6].Text != null)
                        this.lblTestDetails.Text = lvwMainList.SelectedItems[0].SubItems[6].Text.ToString();
                    this._testItem = lvwMainList.SelectedItems[0].SubItems[7].Text.ToString();

                }
                else
                {
                    grpBaby.Enabled = false;
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
                if (this._testDept == "Pathology")
                {
                    for (int j = 0; j < grdTest.Rows.Count - 1; j++)
                    {
                        if (grdTest.Rows[j].Cells["result"].Value == null)
                        {
                            MessageBox.Show("Enter Report Result");
                            return;
                        }
                    }
                }
                else
                {
                    if (txtResult.Text == "" || txtResult.Text == "Processing")
                    {
                        MessageBox.Show("Enter Report Result");
                        txtResult.Text = "";
                        txtResult.Focus();
                        return;
                    }
                }
               
                if (lvwMainList.SelectedItems.Count > 0)
                {
                    InvestigationTest investigationTest = new InvestigationTest();
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    List<TestResult> lstTestResult = new List<TestResult>();
                    TestResultBLL testResultBLL = new TestResultBLL();
                    List<ReagentProduct> lstReagentProduct = new List<ReagentProduct>();
                    ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                    int IItemID = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[9].Text);
                    DataSet ds = reAgentItemBLL.ReagentforInvestigationTest(IItemID);

                    investigationTest.investigation_test_id = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[8].Text);
                    investigationTest.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue.ToString());
                    investigationTest.record_modified_by = ApplicatinLauncher._userId;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ReagentProduct reagentProduct = new ReagentProduct();
                        reagentProduct.re_agent_product_id = Convert.ToInt32(ds.Tables[0].Rows[i]["product_id"]);
                        reagentProduct.current_stock = -Convert.ToDecimal(ds.Tables[0].Rows[i]["required_qty"]);
                        reagentProduct.record_modified_by = ApplicatinLauncher._userId;
                        lstReagentProduct.Add(reagentProduct);
                    }
                    if (this._testDept == "Pathology")
                    {
                        for (int j = 0; j < grdTest.Rows.Count - 1; j++)
                        {
                            TestResult testResult = new TestResult();
                            testResult.investigation_test_id = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[8].Text);
                            testResult.test_element_id = Convert.ToInt32(grdTest.Rows[j].Cells["test_element_id"].Value);
                            testResult.result = grdTest.Rows[j].Cells["result"].Value.ToString();
                            testResult.record_created_by = ApplicatinLauncher._userId;
                            lstTestResult.Add(testResult);
                        }
                        testResultBLL.InsertTestResult(lstTestResult, lstReagentProduct);
                    }
                    else
                    {
                        investigationTest.result = txtResult.Text.ToString();
                    }
                    int res = investigationTestBLL.Updateinvestigation_testAfterReportDone(investigationTest);
                    if (this._testDept != "Pathology")
                    {
                        testResultBLL.UpdateCurrentStock(lstReagentProduct);
                    }
                    MessageBox.Show("Data Saved Successfully");
                    //RefreshContent(this._testDept);
                    grdTest.Rows.Clear();
                    txtResult.Text = "";
                    txtReferenceValue.Text = "";
                    btnPrintSampleCollected.Enabled = true;
                    btnSave.Enabled = false;
                   
                }
            }
            catch
            {
            }
        }
    
        private void btnPrintSampleCollected_Click(object sender, EventArgs e)
        {
            try
            {
                string pCode = lvwMainList.SelectedItems[0].SubItems[2].Text;
                string Specimen = lvwMainList.SelectedItems[0].SubItems[13].Text;
                int PGID =Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[14].Text);
                int OID = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[0].Text);

                if (lvwMainList.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select an item");
                    return;
                }
                else
                {
                    if (this._testDept == "Pathology")
                    {
                        if (grdTest.Rows[0].Cells["result"].Value == null)
                        {
                            MessageBox.Show("Result is Not prepared");
                            return;
                        }
                        if (lvwMainList.SelectedItems[0].SubItems[1].Text == "OPD")
                        {
                            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                            ReportDocument rptCustomersOrders = new InvestigationTestRpt();

                            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                            {
                                tliCurrent = tbCurrent.LogOnInfo;

                                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                                tbCurrent.ApplyLogOnInfo(tliCurrent);
                            }

                            rptCustomersOrders.SetParameterValue("@patient_code", pCode);
                            rptCustomersOrders.SetParameterValue("@test_dept", this._testDept);
                            rptCustomersOrders.SetParameterValue("@Specimen", Specimen);
                            rptCustomersOrders.SetParameterValue("@PGrpupID", PGID);

                            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                            frmGenericReportViewer.Show();
                            //this._testDept = null;
                            //this._testItem = null;
                            //pCode = null;
                        }
                        else
                        {
                            string Name = null;
                            string Gender = null;
                            int y;
                            int m;
                            int d;
                            if (Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[12].Text) == 1)
                            {
                                //if (Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[15].Text) == 1)
                                //{
                                //    MessageBox.Show("Baby Report can't be Re-Printed");
                                //    return;
                                //}
                                if (txtPatientName.Text == "")
                                {
                                    MessageBox.Show("Please write the name of the Baby");
                                    return;
                                }
                                else
                                {
                                    Name = txtPatientName.Text.ToString();
                                }
                                if (txtAgeYy.Text == "0" && txtAgeMm.Text == "0" && txtAgeDd.Text == "0")
                                {
                                    MessageBox.Show("Please Insert Age of the Baby");
                                    return;
                                }
                                else
                                {
                                    y = Convert.ToInt32(txtAgeYy.Text);
                                    m = Convert.ToInt32(txtAgeMm.Text);
                                    d = Convert.ToInt32(txtAgeDd.Text);
                                }
                                if (cmbGender.SelectedIndex==-1)
                                {
                                    MessageBox.Show("Please Gender of the Baby");
                                    return;
                                }
                                else
                                {
                                    Gender = cmbGender.Text.ToString();
                                }
                                string Age = y + " Years " + m + " Months " + d + " Days";
                                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                                ReportDocument rptCustomersOrders = new BabyTestReport();

                                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                                {
                                    tliCurrent = tbCurrent.LogOnInfo;

                                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                                }

                                rptCustomersOrders.SetParameterValue("@patient_code", pCode);
                                rptCustomersOrders.SetParameterValue("@test_dept", this._testDept);
                                rptCustomersOrders.SetParameterValue("@Specimen", Specimen);
                                rptCustomersOrders.SetParameterValue("@PGrpupID", PGID);
                                rptCustomersOrders.SetParameterValue("@Name", Name);
                                rptCustomersOrders.SetParameterValue("@Age", Age);
                                rptCustomersOrders.SetParameterValue("@Gender", Gender);
                                rptCustomersOrders.SetParameterValue("@InvestigationID", OID);


                                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                                frmGenericReportViewer.Show();

                            }
                            else
                            {
                                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                                ReportDocument rptCustomersOrders = new IpdInvestigationTestReport();

                                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                                {
                                    tliCurrent = tbCurrent.LogOnInfo;

                                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                                }

                                rptCustomersOrders.SetParameterValue("@patient_code", pCode);
                                rptCustomersOrders.SetParameterValue("@test_dept", this._testDept);
                                rptCustomersOrders.SetParameterValue("@Specimen", Specimen);
                                rptCustomersOrders.SetParameterValue("@PGrpupID", PGID);
                                rptCustomersOrders.SetParameterValue("@InvestigationID", OID);

                                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                                frmGenericReportViewer.Show();
                                //this._testDept = null;
                                //this._testItem = null;
                                //pCode = null;
                            }

                        }
                    }
                    else
                    {
                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new rptTestReport();

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;

                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }

                        rptCustomersOrders.SetParameterValue("@patient_code", pCode);
                        rptCustomersOrders.SetParameterValue("@test_dept", this._testDept);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                        //this._testDept = null;
                        //this._testItem = null;
                        //pCode = null;
                    }
                    List<InvestigationTest> lstInvestigationTest = new List<InvestigationTest>();
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    for (int i = 0; i < lvwMainList.Items.Count; i++)
                    {
                        InvestigationTest investigationTest = new InvestigationTest();
                        if (lvwMainList.Items[i].SubItems[2].Text == lvwMainList.SelectedItems[0].SubItems[2].Text
                            && lvwMainList.Items[i].SubItems[13].Text == lvwMainList.SelectedItems[0].SubItems[13].Text
                            && Convert.ToInt32(lvwMainList.Items[i].SubItems[14].Text) == Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[14].Text))
                        {
                            investigationTest.investigation_test_id= Convert.ToInt32(lvwMainList.Items[i].SubItems[8].Text);
                            lstInvestigationTest.Add(investigationTest);
                        }
                    }
                    investigationTestBLL.SetInvestigationReportDone(lstInvestigationTest);
                    //RefreshContent(this._testDept);
                    grdTest.Rows.Clear();
                   
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
               // RefreshContent(this._testDept);
                grdTest.Rows.Clear();
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
            }
            catch
            {
            }
        }

        private void FrmInvestigationTestListView_Load(object sender, EventArgs e)
        {
            rdoOpd.Checked = true;
            //PopulateList();
            //Status();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwMainList.SelectedItems.Count > 0)
                {
                    if (this._testDept == "Pathology")
                    {
                        for (int j = 0; j < grdTest.Rows.Count - 1; j++)
                        {
                            if (grdTest.Rows[j].Cells["result"].Value == null)
                            {
                                MessageBox.Show("Enter Report Result");
                                return;
                            }
                        }
                    }
                    InvestigationTest investigationTest = new InvestigationTest();
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    investigationTest.investigation_test_id = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[8].Text);
                    investigationTest.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue.ToString());
                    investigationTest.record_modified_by = ApplicatinLauncher._userId;
                    if (this._testDept == "Pathology")
                    {
                        TestResult testResult = new TestResult();
                        TestResultBLL testResultBLL = new TestResultBLL();
                        for (int j = 0; j < grdTest.Rows.Count - 1; j++)
                        {
                            testResult.test_element_id = Convert.ToInt32(grdTest.Rows[j].Cells["test_element_id"].Value);
                            testResult.result = grdTest.Rows[j].Cells["result"].Value.ToString();
                            testResult.investigation_test_id = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[8].Text);
                            testResult.record_modified_by = ApplicatinLauncher._userId;
                            testResultBLL.test_result_Update(testResult);
                        }
                    }
                    else
                    {
                        investigationTest.result = txtResult.Text.ToString();
                    }
                    int res = investigationTestBLL.Updateinvestigation_testAfterReportDone(investigationTest);

                    MessageBox.Show("Result Updated Successfully");
                    btnUpdate.Enabled = false;
                    grdTest.Rows.Clear();
                    txtResult.Text = "";
                    txtReferenceValue.Text = "";
                    //RefreshContent(this._testDept);
                    
                }
            }
            catch
            {
            }
        }
        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch
            {
            }
        }
        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.CompareTo(this.dtpDOB.Value) > 0)
                {
                    int year = 0;
                    int month = 0;
                    int day = 0;

                    FormHelper.CalculateAge(this.dtpDOB.Value, out year, out month, out day);
                    this.txtAgeYy.Text = year.ToString();
                    this.txtAgeDd.Text = day.ToString();
                    this.txtAgeMm.Text = month.ToString();
                }
                else
                {
                    this.txtAgeYy.Text = "0";
                    this.txtAgeDd.Text = "0";
                    this.txtAgeMm.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void txtAgeYy_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
                    txtAgeMm.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAgeMm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                    txtAgeDd.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAgeMm_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtAgeMm.Text) > 12)
                {
                    MessageBox.Show("Invalid Month");
                    txtAgeMm.Focus();
                    return;
                }
                else
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));

                }
            }
            catch
            {
            }
        }

        private void txtAgeDd_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void txtAgeDd_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtAgeDd.Text) > 31)
                {
                    MessageBox.Show("Invalid Date");
                    txtAgeDd.Focus();
                    return;
                }
                else
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                }
            }
            catch
            {
            }
        }

        private void txtAgeYy_Leave(object sender, EventArgs e)
        {
            try
            {
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void rdoIpd_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
            Status();
        }

        private void rdoOpd_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
            Status();
        }

        private void chkAdmissionID_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAdmissionID.Checked == true)
                {
                    txtHospitalID.Enabled = false;
                    txtAdmissionID.Enabled = true;
                    txtCabin.Enabled = false;
                    txtOrder.Enabled = false;
                    chkHospitalID.Checked = false;
                    chkCabin.Checked = false;
                    chkOrder.Checked = false;
                }
                else
                {
                    txtAdmissionID.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void chkHospitalID_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkHospitalID.Checked == true)
                {
                    txtHospitalID.Enabled = true;
                    txtAdmissionID.Enabled = false;
                    txtCabin.Enabled = false;
                    txtOrder.Enabled = false;
                    chkAdmissionID.Checked = false;
                    chkCabin.Checked = false;
                    chkOrder.Checked = false;
                }
                else
                {
                    txtHospitalID.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void chkCabin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkCabin.Checked == true)
                {
                    txtHospitalID.Enabled = false;
                    txtAdmissionID.Enabled = false;
                    txtCabin.Enabled = true;
                    txtOrder.Enabled = false;
                    chkAdmissionID.Checked = false;
                    chkHospitalID.Checked = false;
                    chkOrder.Checked = false;
                }
                else
                {
                    txtCabin.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void chkOrder_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkOrder.Checked == true)
                {
                    txtHospitalID.Enabled = false;
                    txtAdmissionID.Enabled = false;
                    txtCabin.Enabled = false;
                    txtOrder.Enabled = true;
                    chkHospitalID.Checked = false;
                    chkCabin.Checked = false;
                    chkAdmissionID.Checked = false;
                }
                else
                {
                    txtOrder.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void txtHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds;
                    if (rdoOpd.Checked)
                    {
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtHospitalID.Text), null, "OPD",1);
                    }
                    else
                    {
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtHospitalID.Text), null, "IPD",1);
                    }
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 0);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                }

            }
            catch
            {
            }
        }

        private void txtAdmissionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtAdmissionID.Text), null,"IPD",1);
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 1);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                }

            }
            catch
            {
            }
        }

        private void txtCabin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds = investigationTestBLL.TestInfoGet(this._testDept,0, txtCabin.Text,"IPD",1);
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 2);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                }

            }
            catch
            {
            }
        }
        private void Status()
        {
            try
            {
                chkHospitalID.Checked = false;
                chkAdmissionID.Checked = false;
                chkCabin.Checked = false;
                chkOrder.Checked = false;
                txtHospitalID.Enabled = false;
                txtAdmissionID.Enabled = false;
                txtCabin.Enabled = false;
                txtOrder.Enabled = false;
            }
            catch
            {
            }
        }
        private void txtOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    if (txtOrder.Text != "")
                    {
                        btnPrintSampleCollected.Enabled = true;
                    }
                    else
                    {
                        btnPrintSampleCollected.Enabled = false;
                    }

                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds;
                    if (rdoOpd.Checked)
                    {
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtOrder.Text), null, "OPD",1);
                    }
                    else
                    {
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtOrder.Text), null, "IPD",1);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 3);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                    }
                    for(int i=0;i<lvwMainList.Items.Count;i++)
                    {
                        if (Convert.ToInt32(lvwMainList.Items[i].SubItems[14].Text) == 1)
                        {
                            lvwMainList.Items[i].ForeColor = Color.SeaGreen;
                        }
                        if (Convert.ToInt32(lvwMainList.Items[i].SubItems[11].Text) == 1)
                        {
                            lvwMainList.Items[i].ForeColor = Color.Blue;
                        }
                    }
                }

            }
            catch
            {
            }
        }

    }
}