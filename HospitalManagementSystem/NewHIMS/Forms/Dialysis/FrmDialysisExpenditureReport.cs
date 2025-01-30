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
using NewHIMS.Reports.Expenditure;
using NewHIMS.Reports.Collection;


namespace NewHIMS.Forms.Dialysis
{
    public partial class FrmDialysisExpenditureReport : BaseForm.FrmBase
    {
        public FrmDialysisExpenditureReport()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                if (chksummaryreport.Checked == true)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new ExpenditureSummary();

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

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }

                if (chkdatewisesreport.Checked == true)
                {
                    //DailyExpenditureDiagnosticReport();
                }

                if (chkMonthlyReport.Checked == true)
                {
                    
                    DateTime From1 = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                    DateTime To1 = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new ReceivedPayment();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@From", From1);
                    rptCustomersOrders.SetParameterValue("@To", To1);
                    rptCustomersOrders.SetParameterValue("@From1", From1);
                    rptCustomersOrders.SetParameterValue("@To1", To1);
                    rptCustomersOrders.SetParameterValue("@From2", From1);
                    rptCustomersOrders.SetParameterValue("@To2", To1);
                    rptCustomersOrders.SetParameterValue("@From4", From1);
                    rptCustomersOrders.SetParameterValue("@To4", To1);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                ExpenditureOrderBLL expenditureOrderBLL = new ExpenditureOrderBLL();
                DataSet ds = expenditureOrderBLL.ExpenditureOrderListDialysis(From, To);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwExpenditure, ds, 0);
                }
                else
                {
                    lvwExpenditure.Items.Clear();
                    MessageBox.Show("No Data Found");
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
                if (lvwExpenditure.SelectedItems.Count > 0)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new ExpenditureOrdeReportDialysis();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;

                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                    DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                    rptCustomersOrders.SetParameterValue("@expenditure_order_id", Convert.ToInt32(lvwExpenditure.SelectedItems[0].Text));


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

        void DailyExpenditureDiagnosticReport()
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DailyExpenditureDiagnostic();

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
    }
}
