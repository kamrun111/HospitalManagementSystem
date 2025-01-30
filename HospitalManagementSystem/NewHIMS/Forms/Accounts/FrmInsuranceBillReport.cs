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
using NewHIMS.Reports.Bill;
using CrystalDecisions.CrystalReports.Engine;


namespace NewHIMS.Forms.Accounts
{
    public partial class FrmInsuranceBillReport : Form
    {
        public FrmInsuranceBillReport()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmInsuranceBillReport_Load(object sender, EventArgs e)
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
                DataSet ds = cs.GetDataSet("PaymentinfoMember");

                cs.PopulateComboBox(cmbInsuranceCom, ds, 4, "insurance_company_name", "insurance_company_id");

                cmbInsuranceCom.SelectedIndex = -1;

            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, 23, 59, 59);

                int ComID;
                if (cmbInsuranceCom.SelectedIndex == -1)
                {
                    ComID = 0;
                }
                else
                {
                    ComID = Convert.ToInt32(cmbInsuranceCom.SelectedValue);
                }

                if (rdoAsOnReport.Checked == true)
                {
                    PendingBillReport(ComID);
                }
                if (rdoDatewisePaidBill.Checked == true)
                {
                    PaidBillReport(ComID, From, To);
                }
            }
            catch
            {
            }
        }

        void PaidBillReport(int InsComID, DateTime From, DateTime To)  
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new InsuranceBillPaidReportDatewise();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }

            rptCustomersOrders.SetParameterValue("@InsComID", InsComID);
            rptCustomersOrders.SetParameterValue("@From", From);
            rptCustomersOrders.SetParameterValue("@To", To);

            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            frmGenericReportViewer.Show();
        }



        void PendingBillReport(int InsComID)
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new InsuranceBillPendingReport();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }

            rptCustomersOrders.SetParameterValue("@InsComID", InsComID);

            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            frmGenericReportViewer.Show();
        }

    }
}
