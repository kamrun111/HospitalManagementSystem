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

namespace NewHIMS.Forms.Accounts
{
    public partial class FrmExpenditurePrint : BaseForm.FrmBase
    {
        public FrmExpenditurePrint()
        {
            InitializeComponent();
        }


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
                else if (chkdatewisesreport.Checked == true)
                {
                    DailyExpenditureNewReport();
                    DailyExpenditureOfficeReport();
                    DailyExpenditureDiagnosticReport();
                }
                else
                {

                    if (chkCollection.Checked == true)
                    {
                        ExpenditureOrderBLL expenditureOrderBLL = new ExpenditureOrderBLL();
                        DataSet ds = expenditureOrderBLL.Collection(From, To);
                        decimal Advanced = 0;
                        decimal Pathology = 0;
                        decimal XRay = 0;
                        decimal USG = 0;
                        decimal ECG = 0;
                        decimal Outdoor = 0;
                        decimal Collection = 0;
                        decimal Expenditure = 0;
                        decimal Balance = 0;

                        Advanced = Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
                        Pathology = Convert.ToDecimal(ds.Tables[1].Rows[0][0]);
                        XRay = Convert.ToDecimal(ds.Tables[2].Rows[0][0]);
                        USG = Convert.ToDecimal(ds.Tables[3].Rows[0][0]);
                        ECG = Convert.ToDecimal(ds.Tables[4].Rows[0][0]);
                        Outdoor = Convert.ToDecimal(ds.Tables[5].Rows[0][0]);

                        Expenditure = Convert.ToDecimal(ds.Tables[6].Rows[0][0]);

                        Collection = (Advanced + Pathology + XRay + USG + ECG + Outdoor)-Convert.ToDecimal(ds.Tables[7].Rows[0][0]);
                        Balance = Collection - Expenditure;

                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new CollectionAccounts();

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;
                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }
                        rptCustomersOrders.SetParameterValue("@from", From);
                        rptCustomersOrders.SetParameterValue("@to", To);
                        rptCustomersOrders.SetParameterValue("@Collection", Collection);
                        rptCustomersOrders.SetParameterValue("@Expencess", Expenditure);
                        rptCustomersOrders.SetParameterValue("@Balance", Balance);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
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
                DataSet ds = expenditureOrderBLL.ExpenditureOrderList(From, To);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwExpenditure, ds, 0);
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


        private void chkdatewisesreport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdatewisesreport.Checked == true)
            {
                chksummaryreport.Checked = false;
                chkCollection.Checked = false;
            }
          

        }

        private void chksummaryreport_CheckedChanged(object sender, EventArgs e)
        {
            if (chksummaryreport.Checked == true)
            {
                chkdatewisesreport.Checked = false;
                chkCollection.Checked = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkCollection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCollection.Checked == true)
            {
                chksummaryreport.Checked = false;
                chkdatewisesreport.Checked = false;
            }
        }

        private void btnreprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwExpenditure.SelectedItems.Count > 0)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new ExpenditureOrderpt();

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

        void DailyExpenditureNewReport()
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DailyExpenditureNew();

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

        void DailyExpenditureOfficeReport()
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DailyExpenditureOffice();

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
    }
}
