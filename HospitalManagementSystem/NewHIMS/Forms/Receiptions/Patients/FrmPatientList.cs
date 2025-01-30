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
using NewHIMS.Reports.Doctor_Station;

namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmPatientList : Form
    {
        public FrmPatientList()
        {
            InitializeComponent();
        }

        private void FillUpListview(ListView lvw, DataSet ds,int TableIndex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[TableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[TableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
                //admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2]);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void ConsultantList()
        {
            try
            {
                RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
                DataSet dsConsultant = refferedDoctorsBLL.GetConsultantAll();
                FillUpListview(lvwConsultantInfo, dsConsultant,0);

            }
            catch
            {
            }
        }

        private void FrmPatientList_Load(object sender, EventArgs e)
        {
            ConsultantList();
        }

        private void lvwConsultantInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultantInfo.SelectedItems.Count > 0)
                    btnPrint.Enabled = true;
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new Patinet_ConsultantList();
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
                int CID = Convert.ToInt32(lvwConsultantInfo.SelectedItems[0].SubItems[0].Text);

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);
                rptCustomersOrders.SetParameterValue("@reffered_doctors_id", CID);
                rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

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