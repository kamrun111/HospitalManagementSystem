using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using NewHIMS.Reports;
using NewHIMS.Reports.Balance;
using CrystalDecisions.CrystalReports.Engine;

namespace NewHIMS.Forms.Accounts
{
    public partial class FrmChequeReport : BaseForm.FrmBase
    {
        public FrmChequeReport()
        {
            InitializeComponent();
        }
        DateTime From = DateTime.Now;
        DateTime To = DateTime.Now;
        private void FrmChequeReport_Load(object sender, EventArgs e)
        {
            try
            {
                ChequePaymentBLL chequePaymentBLL = new ChequePaymentBLL();
                DataSet dataSet = chequePaymentBLL.BankNameLoad();
                cmbBank.DataSource = dataSet.Tables[0];
                cmbBank.DisplayMember = "bank_name";
                cmbBank.ValueMember = "bank_id";
                cmbBank.SelectedIndex = -1;
                cmbBank.Text = "<Select>";
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                if (rdoUsedChequeList.Checked == true)
                    UsedCheque();
                if (rdoDepositStatement.Checked == true)
                    BankDepositReport();
                
            }
            catch
            {
            }
        }
        void UsedCheque()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new RptUsedCheque();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }


            rptCustomersOrders.SetParameterValue("@bank_id", Convert.ToInt32(cmbBank.SelectedValue));
            rptCustomersOrders.SetParameterValue("@From", From);
            rptCustomersOrders.SetParameterValue("@To", To);
            rptCustomersOrders.SetParameterValue("@flag", 1);


            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            frmGenericReportViewer.Show();
        }


        void BankDepositReport()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            ReportDocument rptCustomersOrders = new BankDepositReport();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }


            rptCustomersOrders.SetParameterValue("@bank_id", Convert.ToInt32(cmbBank.SelectedValue));
            rptCustomersOrders.SetParameterValue("@From", From);
            rptCustomersOrders.SetParameterValue("@To", To);
            rptCustomersOrders.SetParameterValue("@payment_type", "Deposit");


            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            frmGenericReportViewer.Show();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
