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
using NewHIMS.Reports.DoctorsPayment;


namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    public partial class FrmDoctorsPaymentPrint : Form
    {
        int DoctorID = 0;
        public FrmDoctorsPaymentPrint(int doctorID)
        {
            InitializeComponent();
            this.DoctorID = doctorID;
        }

        private void FrmDoctorsPaymentPrint_Load(object sender, System.EventArgs e)
        {
            load();

        }
        private void load()
        {
            try
            {
                DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();
                DataSet ds = doctorsPaymentBLL.getDoctorPaymentNo(DoctorID);
                if (ds.Tables[0].Rows.Count > 0)
                    FillUpListview(lvwDoctorInfo, ds, 0);
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

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (lvwDoctorInfo.SelectedItems.Count > 0)
                    PrintDocpaymentno(Convert.ToInt32(lvwDoctorInfo.SelectedItems[0].Text));
                else
                {
                    MessageBox.Show("Select item from list");
                    return;
                }
            }
            catch
            {
            }

        }
        public void PrintDocpaymentno(int doctorPaymentID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new Docpaymentno();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@doctors_payment_id", doctorPaymentID);

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
