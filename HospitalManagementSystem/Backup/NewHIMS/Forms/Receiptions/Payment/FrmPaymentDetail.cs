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
using NewHIMS.Reports.Payment;

namespace NewHIMS.Forms.Receiptions.Payment
{
    public partial class FrmPaymentDetail : Form
    {
        string HospitalID;
        public FrmPaymentDetail(string HospitalID)
        {
            InitializeComponent();
            this.HospitalID = HospitalID;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtHospitalID.Text = "";
                lvwPatientInfo.Clear();
            }
            catch
            {
            }
        }
        private void FillUpListview(ListView lvw, DataSet ds)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[0].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvi.SubItems.Add(dataRow[4].ToString());
                        lvi.SubItems.Add(dataRow[5].ToString());

                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void FrmPaymentDetail_Load(object sender, EventArgs e)
        {
            try
            {
                if (HospitalID != null)
                {
                    txtHospitalID.Text = HospitalID.ToString();
                    txtHospitalID.ReadOnly = true;
                    btnPrint.Focus();
                }
                else
                {
                    txtHospitalID.ReadOnly = false;
                    txtHospitalID.Focus();
                }
            }
            catch
            {
            }
        }
        public void PopulateInfo()
        {
            try
            {
                PayBLL pay = new PayBLL();
                DataSet ds = pay.PatientlistforPayment(txtHospitalID.Text);
                FillUpListview(lvwPatientInfo,ds);
                ds = null;
            }
            catch
            {
            }
        }
        private void rdoMoneyReceipt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtHospitalID.Text != "")
                {
                    PopulateInfo();
                    if (rdoMoneyReceipt.Checked)
                    {
                        lvwPatientInfo.Enabled = true;
                    }

                    else
                    {
                        lvwPatientInfo.Enabled = false;
                        btnPrint.Enabled = true;
                        btnPrint.Focus();
                    }
                }
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.Items.Count > 0)
                {
                    if (rdoMoneyReceipt.Checked)
                    {
                        int admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                        int payID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text);

                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new PaymentInvoice();

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;

                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }

                        rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                        rptCustomersOrders.SetParameterValue("@payID", payID);
                        ////rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
                    else
                    {
                        int admissionID = Convert.ToInt32(lvwPatientInfo.Items[0].SubItems[2].Text);
                        int payID = Convert.ToInt32(lvwPatientInfo.Items[0].SubItems[4].Text);
                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new DetailPayment();

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;

                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }
                        rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                        rptCustomersOrders.SetParameterValue("@admissionID", admissionID);
                        //rptCustomersOrders.SetParameterValue("@payID", payID);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            catch
            {
            }
        }

        private void txtHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    PopulateInfo();
                    if (rdoDetails.Checked)
                    {
                        btnPrint.Enabled = true;
                        btnPrint.Focus();
                    }
                }
            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;
            btnPrint.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}