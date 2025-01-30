using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports.OPDPatient;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;
using NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund;     


namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    public partial class frmOPDPatientHistory : Form
    {
        public frmOPDPatientHistory()
        {
            InitializeComponent();
        }
        public void populatePatientInfo(string PatientName, string RegID, string Address, string ConsultantName)
        {
            lblPatientName.Text = PatientName;
            lblOPDRegNO.Text = RegID;
            lblAddress.Text = Address;
            //lblPrescriptionID.Text = RescriptionID;
            lblConsultant.Text = ConsultantName;
            this.Show();
        }

        private void frmOPDPatientHistory_Load(object sender, EventArgs e)
        {
            try
            {
                OPDPatientBLL oPDPatientBLL = new OPDPatientBLL();
                DataSet ds = new DataSet();
                ds = oPDPatientBLL.GetOPDHistoryResult(lblOPDRegNO.Text.ToString());
                if (ds.Tables[0].Rows.Count < 1)
                {
                    ds = oPDPatientBLL.GetOPDHistoryHead();
                    
                }
                grdOPDPatientHistory.Rows.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdOPDPatientHistory.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdOPDPatientHistory.Rows.Add();
                        grdOPDPatientHistory.Rows[i].Cells["HistoryTitle"].Value = (ds.Tables[0].Rows[i]["HistoryTitle"].ToString());                                      //admn_id
                        grdOPDPatientHistory.Rows[i].Cells["HistoryResult"].Value = (ds.Tables[0].Rows[i]["HistoryResult"].ToString());                                     //cabin_id

                    }
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
                OPDPatientBLL oPDPatientBLL = new OPDPatientBLL();
                OPDHistoryTable oPDHistoryTable = new OPDHistoryTable();
                oPDPatientBLL.DeleteOPDHistory(lblOPDRegNO.Text.ToString());
                for (int k = 0; k < grdOPDPatientHistory.Rows.Count-1; k++)
                {
                    if (grdOPDPatientHistory.Rows[k].Cells["HistoryTitle"].Value.ToString()!="" && grdOPDPatientHistory.Rows[k].Cells["HistoryResult"].Value.ToString()!= "")
                    {
                    oPDHistoryTable.OPDRegID = lblOPDRegNO.Text.ToString();
                    oPDHistoryTable.HistoryTitle = grdOPDPatientHistory.Rows[k].Cells["HistoryTitle"].Value.ToString();
                    oPDHistoryTable.HistoryResult = grdOPDPatientHistory.Rows[k].Cells["HistoryResult"].Value.ToString();
                    oPDHistoryTable.RecordeCreatedBy = ApplicatinLauncher._userId;
                    oPDPatientBLL.AddOPDPatientHistory(oPDHistoryTable);
                    }
                }
                MessageBox.Show("History Save Successfully");
            }
            catch 
            {
                
                
            }
            
        }
        private void PrintOPDPatientHistory(string RegistrationID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptOPDHistory();
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


                rptCustomersOrders.SetParameterValue("@RegistrationID", RegistrationID);
                rptCustomersOrders.SetParameterValue("@OPDRegistrationID", RegistrationID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();

            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintOPDPatientHistory(lblOPDRegNO.Text.ToString());
        }
    }
}