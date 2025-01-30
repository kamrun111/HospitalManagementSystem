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
using NewHIMS.Reports.Admission;
using NewHIMS.Reports.Doctor_Station.Discharge;

namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmDailyPatientList : BaseForm.FrmBase
    {
        public FrmDailyPatientList()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoAdmittedPatient.Checked == true)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DailyAdmission();
                    //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                    DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);
                   
                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DailyDischarged();
                   
                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                    DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);

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

        private void FrmDailyPatientList_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}