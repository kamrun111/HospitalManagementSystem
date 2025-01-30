using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using NewHIMS.Reports.LoanSlip;
using CrystalDecisions.CrystalReports.Engine;


namespace NewHIMS.Forms.Accounts
{
    public partial class FrmLoanSlipReport : Form
    {
        public FrmLoanSlipReport()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmLoanSlipReport_Load(object sender, EventArgs e)
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
                DataSet ds = cs.GetDataSet("LoanSlipLoad");

                cs.PopulateComboBox(cmbEmployee, ds, 0, "loan_employee_name", "loan_employee_id");
                cs.PopulateComboBox(cmbSlipNo, ds, 2, "loan_slip_no", "loan_slip_id");

                cmbEmployee.SelectedIndex = -1;
                cmbSlipNo.SelectedIndex = -1;

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

                int EmpID;
                if (cmbEmployee.SelectedIndex == -1)
                {
                    EmpID = 0;
                }
                else
                {
                    EmpID = Convert.ToInt32(cmbEmployee.SelectedValue);
                }

                if (rdoAsOnPendingSlip.Checked == true)
                {
                    PendingLoanReport(EmpID);
                }
                if (rdoLoanSlip.Checked == true)
                {
                    PrintLoanSlip(Convert.ToInt32(cmbSlipNo.SelectedValue));
                }
                if (rdoDatewiseLoan.Checked == true)
                {
                    DatewiseLoanReport(EmpID, From, To);
                }
            }
            catch
            {
            }
        }

        void PendingLoanReport(int EmpID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PendingLoanSlipReport();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@EmpID", EmpID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }

            catch
            {
            }

        }

        void PrintLoanSlip(int SlipID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new LoanSlipPrint();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@SlipID", SlipID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }

            catch
            {
            }

        }


        void DatewiseLoanReport(int EmpID, DateTime From, DateTime To )
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new LoanSlipReportDatewise();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@EmpID", EmpID);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cmbEmployee.SelectedIndex = 1;
                cmbSlipNo.SelectedIndex = -1;

            }
            catch
            {
            }
        }

        
    }
}
