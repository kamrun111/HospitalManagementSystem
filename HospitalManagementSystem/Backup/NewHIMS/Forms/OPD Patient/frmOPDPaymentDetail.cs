using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports.OPDPatient;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;

namespace NewHIMS.Forms.OPD_Patient
{
    public partial class frmOPDPaymentDetail : Form
    {
        public frmOPDPaymentDetail()
        {
            InitializeComponent();
        }
        public void populatedata(string RegID)
        {
            txtRegID.Text = RegID;
            this.Show();
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
                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {

                        lvi.SubItems.Add(dataRow[j].ToString());

                    }
                    lvw.Items.Add(lvi);

                }
            }
        }
        private void frmOPDPaymentDetail_Load(object sender, EventArgs e)
        {
            OPDPatientBLL oPDPatientBLL = new OPDPatientBLL();
            DataSet ds = new DataSet();
            ds=oPDPatientBLL.GetPaymentInvoiceNoList(txtRegID.Text.ToString());
            FillUpListview(lvwPatientInfo, ds, 0);
        }
        private void PrintOPDPatientPaymentInvoie(string RegistrationID, string InvoiceID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptOPDPatientPaymentInvoie();
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


                rptCustomersOrders.SetParameterValue("@PaymentInvoiceNo", InvoiceID);
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
            if (lvwPatientInfo.SelectedItems.Count > 0)
            {
                string RegID = lvwPatientInfo.SelectedItems[0].SubItems[0].Text.ToString();
                string InvoiceID = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
                PrintOPDPatientPaymentInvoie(RegID, InvoiceID);

            }
            else
            {
                MessageBox.Show("SELECT A PATIENT");
            }
        }
    }
}