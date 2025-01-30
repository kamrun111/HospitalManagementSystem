using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmSampleCollectionPathologyListView : BaseForm.FrmBase
    {
        private string _testDept;
        //private string _testItem;
        public FrmSampleCollectionPathologyListView()
        {
            InitializeComponent();
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
                        lvi.SubItems.Add(dataRow["specimen_name"].ToString());
                        lvi.SubItems.Add(dataRow["sample_no"].ToString());
                        lvi.SubItems.Add(dataRow["patient_type"].ToString());
                        lvi.SubItems.Add(dataRow["patient_code"].ToString());
                        lvi.SubItems.Add(dataRow["patient_name"].ToString());
                        lvi.SubItems.Add(dataRow["admission_code"].ToString());
                        lvi.SubItems.Add(dataRow["cabin"].ToString());
                        lvi.SubItems.Add(dataRow["age"].ToString());
                        lvi.SubItems.Add(dataRow["test_item"].ToString());
                        //lvi.SubItems.Add(dataRow["test_group"] + " / " + dataRow["test_item"]);                        lvi.SubItems.Add(dataRow["investigation_test_id"].ToString());
                        lvi.SubItems.Add(dataRow["test_item_id"].ToString());
                        lvi.SubItems.Add(dataRow["specimen_id"].ToString());
                        lvi.SubItems.Add(dataRow["order_date"].ToString());
                                              
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch 
            { 

            }
        }
        private void FillUpListview2(ListView lvw, DataSet ds, int TableIndex)
        {
            try
            {
                lvw.Items.Clear();

                for (int i = 0; i < ds.Tables[TableIndex].Rows.Count; i++)
                {                    DataRow dataRow = ds.Tables[TableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        
                        lvw.Items.Add(lvi);
                    }
                }
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
                DataSet ds = investigationTestBLL.GetSampleCollectionInfo(this._testDept, 0);
                lvwMainList.Items.Clear();
                if (rdoOpd.Checked)
                {
                    FillUpListview(lvwMainList, ds, 0);
                    chkAdmissionID.Enabled = false;
                    chkCabin.Enabled = false;
                    txtAdmissionID.Enabled = false;
                    txtCabin.Enabled = false;
                    txtPatientIDsamplecollected.Enabled = false;
                    txtordernosamplecollected.Enabled = false;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
                else
                {
                    FillUpListview(lvwMainList, ds, 2);
                    chkAdmissionID.Enabled = true;
                    chkCabin.Enabled = true;
                    txtAdmissionID.Enabled = true;
                    txtCabin.Enabled = true;
                }
            }
            catch
            {
            }
        
        }

       public void RefreshContent(string testDept)
       {
           try
           {
              // lblCabinTitle.Text = "Sample Collection (" + testDept + ")";
               this._testDept = testDept;
               ////rdoOpd.Checked = true;
               PopulateList();

               if (lvwMainList.Items.Count < 1)
               {
                   btnStickerPrint.Enabled = false;
                   btnPrintSampleCollected.Enabled = true;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateList();
                txtHospitalID.Text = "";
                txtAdmissionID.Text = "";
                txtCabin.Text = "";
                txtOrder.Text = "";
                txtPatientIDsamplecollected.Text = "";
                txtordernosamplecollected.Text = "";
            }
            catch
            {
            }
        }

        private void btnPrintSampleCollected_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders ;

                rptCustomersOrders = new Reports.Investigation.IpdSampleCollectionInfo();
                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@test_department", this._testDept);
                rptCustomersOrders.SetParameterValue("@sampleCollection", 0);
               

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void lvwMainList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (txtPatientIDsamplecollected.Text == "" && txtordernosamplecollected.Text == "")
                {
                    if (lvwMainList.SelectedItems.Count > 0)
                    {
                        if (MessageBox.Show("Is Sample Collected Properly ?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }


                        InvestigationTest investigationTest = new InvestigationTest();
                        InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                        investigationTest.investigation_test_id = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[10].Text);
                        //investigationTest.record_created_by=0;    \\TODO
                        investigationTest.record_modified_by = ApplicatinLauncher._userId;  
                        int res = investigationTestBLL.Updateinvestigation_test(investigationTest);

                        if (res > 0)
                            lvwMainList.FocusedItem.Remove();
                    }
                }
                else
                    MessageBox.Show("Sample Already Collected");
                
            }
            catch
            {


            }
        }

        private void btnStickerPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ////int _testItemID =Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[7].Text);
                //string _patientId = lvwMainList.SelectedItems[0].SubItems[4].Text;
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders;

                rptCustomersOrders = new Reports.Investigation.rptSampleCollectionSticker();
                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@test_department", this._testDept);
                rptCustomersOrders.SetParameterValue("@sampleCollection", 0);
                //////rptCustomersOrders.SetParameterValue("@test_itemID", _testItemID);
                //////rptCustomersOrders.SetParameterValue("@HospitalID", _patientId);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();

                InvestigationTest investigationTest = new InvestigationTest();
                InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                investigationTest.sticker_printed = 1;
                investigationTest.test_department_id = 2;
                investigationTestBLL.UpdateStickerPrint(investigationTest);

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
        private void FrmSampleCollectionPathologyListView_Load(object sender, EventArgs e)
        {
            rdoOpd.Checked = true;
            PopulateList();
            Status();
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
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtHospitalID.Text), null, "OPD",0);
                    }
                    else
                    {
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtHospitalID.Text), null, "IPD",0);
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
                    DataSet ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtAdmissionID.Text), null, "IPD",0);
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
                    DataSet ds = investigationTestBLL.TestInfoGet(this._testDept, 0, txtCabin.Text, "IPD",0);
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
        private void txtOrder_KeyPress(object sender, KeyPressEventArgs e)
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
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtOrder.Text), null, "OPD",0);
                    }
                    else
                    {
                        ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtOrder.Text), null, "IPD",0);
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 3);
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

        private void lvwMainList_Click(object sender, EventArgs e)
        {
            try
            {
                //ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                //DataSet ds = reAgentItemBLL.ReagentforTest(Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[7].Text));
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    FillUpListview2(lvwReagent, ds, 0);
                //}
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoIpd.Checked == true)
                {
                    if (lvwMainList.SelectedItems.Count > 0)
                    {
                        if (MessageBox.Show("Do you want to Cancel?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                        InvestigationTest investigationTest = new InvestigationTest();
                        InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();


                        investigationTest.investigation_test_id = Convert.ToInt32(lvwMainList.SelectedItems[0].SubItems[10].Text);
                        investigationTest.record_modified_by = ApplicatinLauncher._userId;
                        investigationTestBLL.investigationcancel(investigationTest);
                        MessageBox.Show("Investigation order cancel successfully");
                        PopulateList();
                    }
                }
            }
            catch
            {
            }
        }

        private void txtPatientIDsamplecollected_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtPatientIDsamplecollected.Text), null, "OPD", 1); 
                        
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 0);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                        lvwMainList.Items.Clear();
                    }
                }

            }
            catch
            {
            }
        }

        private void txtordernosamplecollected_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds = investigationTestBLL.TestInfoGet(this._testDept, Convert.ToInt32(txtordernosamplecollected.Text), null, "OPD", 1);
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        FillUpListview(lvwMainList, ds, 3);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Found");
                        lvwMainList.Items.Clear();

                    }
                }

            }
            catch
            {
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == true)
                {
                    txtPatientIDsamplecollected.Enabled = true;
                    txtPatientIDsamplecollected.Focus();
                }
                if (checkBox1.Checked == true)
                {
                    txtordernosamplecollected.Enabled = true;
                    txtordernosamplecollected.Focus();
                }
            }
            catch
            {
            }
        }

       
    }
}