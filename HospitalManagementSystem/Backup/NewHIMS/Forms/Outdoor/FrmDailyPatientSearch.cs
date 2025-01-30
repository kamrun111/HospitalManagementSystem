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
using NewHIMS.Reports.OutDoor;

namespace NewHIMS.Forms.Outdoor
{
    public partial class FrmDailyPatientSearch : Form
    {
        public FrmDailyPatientSearch()
        {
            InitializeComponent();
        }

        private void FillUpListview(ListView lvw, DataSet ds, int TableIndex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[TableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[TableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow["patient_id"].ToString());

                        lvi.SubItems.Add(dataRow["patient_code"].ToString());
                        lvi.SubItems.Add(dataRow["patient_name"].ToString());
                        lvi.SubItems.Add(dataRow["record_created_date"].ToString());
                        lvi.SubItems.Add(dataRow["outdoor_booking_id"].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error2");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                
                Outdoor_bookingBLL outdoor_bookingBLL=new Outdoor_bookingBLL();
                DataSet ds = outdoor_bookingBLL.OPDPatientList(From,To);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientOtherItem,ds,0);
                }

            }
            catch
            {
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                lvwPatientOtherItem.Items.Clear();
                
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int BID=Convert.ToInt32(lvwPatientOtherItem.SelectedItems[0].SubItems[4].Text);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OutdoorBooking();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@outdoor_booking_id", BID);

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