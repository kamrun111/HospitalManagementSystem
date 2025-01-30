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
using NewHIMS.Reports.Investigation;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmDailyIPDSales : Form
    {
        int DeptID;
        public FrmDailyIPDSales(int DeptID)
        {
            InitializeComponent();
            this.DeptID = DeptID;
        }
        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)//gdgdg
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }

        private void FrmDailyIPDSales_Load(object sender, EventArgs e)
        {
            try
            {
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationBLL.GetInvestigationPopulationInfo();
                cmbTestDepartemt.DataSource = ds.Tables[8];
                cmbTestDepartemt.DisplayMember = "test_department";
                cmbTestDepartemt.ValueMember = "test_department_id";
                cmbTestDepartemt.SelectedValue = DeptID;
            }
            catch
            {
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationBLL.InvestigationList(From, To);
                if (ds.Tables[1].Rows.Count > 0)
                {
                    FillUpListview(lvwInvestigation, ds, 1);
                }
            }
            catch
            {
            }
        }

        private void btnreprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwInvestigation.SelectedItems.Count > 0)
                {
                    PrintInestigationReport(Convert.ToInt32(lvwInvestigation.SelectedItems[0].Text));
                    //PrintInestigationReportNew(Convert.ToInt32(lvwInvestigation.SelectedItems[0].Text));

                }
                else
                    MessageBox.Show("Select An Item From List");
            }
            catch
            {
            }
        }

        void PrintInestigationReport(int investigationID)
        {
            try
            {
                InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                DataSet ds = investigationOrderBLL.OrdernoGet(investigationID);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int OrderId = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new InvestigationInvoiceIPD();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;

                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                    rptCustomersOrders.SetParameterValue("@order_no", OrderId);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }

            }
            catch
            {
            }
        }


        void PrintInestigationReportNew(int investigationID)
        {
            try
            {

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new IPDInvestigationInvoice();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                //rptCustomersOrders.SetParameterValue("@InvestigationID", investigationID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();


            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int DepartmentID = Convert.ToInt32(cmbTestDepartemt.SelectedValue);
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                
                InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                DataSet ds = investigationOrderBLL.OPDinvestigationdiscount(From, To, DepartmentID);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DailyIPDSales();
                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);
                    rptCustomersOrders.SetParameterValue("@DeptID", DepartmentID);
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else
                    MessageBox.Show("No Data Found");
            }
            catch
            {
            }

      }
    }
}
