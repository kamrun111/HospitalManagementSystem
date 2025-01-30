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
using NewHIMS.Forms.Receiptions;
using NewHIMS.Forms.Receiptions.Payment;


namespace NewHIMS.Forms.Dialysis
{
    public partial class FrmDialysisPayment : Form
    {
        public FrmDialysisPayment()
        {
            InitializeComponent();
        }

        private int admissionID;
        private int payID;

        CommonClass cs = new CommonClass();

        private void FrmDialysisPayment_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshPayment();
            }
            catch
            {
            }
            
        }

        public void RefreshPayment()
        {
            try
            {
                
                DataSet ds = cs.GetDataSet("PaymentType");
                cs.PopulateComboBox(cmbPaymentType, ds, 0, "payment_type", "payment_type_id");

                lvwPatientInfo.Items.Clear();

                DataSet dt = cs.GetDataSet("GetDialysisPatientInfo");
                cs.FillUpListview(lvwPatientInfo, dt, 1);
                

                this.cmbPaymentType.SelectedIndex = 0;
                txtCustomerName.Text = "";
                txtGaurdianName.Text = "";
                txtAdress.Text = "";
                txtPhone.Text = "";
                txtTotal.Text = "";
                txtSearch.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    txtCustomerName.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text.ToString();
                    txtGaurdianName.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text.ToString();
                    txtAdress.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text.ToString();
                    txtPhone.Text = lvwPatientInfo.SelectedItems[0].SubItems[7].Text.ToString();
                }
                if (txtCustomerName.Text != "")
                    btnSave.Enabled = true;
                admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                //UserNam = ApplicatinLauncher._userName;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (cmbPaymentType.Text == "REFUND")
                {
                    if (ApplicatinLauncher._GroupName == "Administrator") //|| ApplicatinLauncher._GroupName == "Accounts")
                        cmbPaymentType.Enabled = true;
                    else
                    {
                        MessageBox.Show("You Don't Have Permission For Refund");
                        return;
                    }
                }
                int dc = 0;
                Pay pay = new Pay();
                PayBLL payBLL = new PayBLL();

                if (txtTotal.Text != "")
                {

                    pay.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                    pay.pay_date = Convert.ToDateTime(dtpPaymentDate.Text);
                    pay.amount = Convert.ToDecimal(txtTotal.Text);
                    pay.payment_type_id = Convert.ToInt32(cmbPaymentType.SelectedValue);

                    if (cmbPaymentType.SelectedIndex == 0 || cmbPaymentType.SelectedIndex == 1 || cmbPaymentType.SelectedIndex == 2 || cmbPaymentType.SelectedIndex == 3)
                    {
                        pay.status = 1; //Receive
                    }
                    else
                    {
                        pay.status = 2; //Loan/Refund 
                    }
                    pay.record_created_by = ApplicatinLauncher._userId;

                    payID = payBLL.paymentAddDialysis(pay);

                    pay.pay_id = payID;
                    
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Insert amount");
                }

                PayBLL payBLLL = new PayBLL();
                int PID = Convert.ToInt32(cmbPaymentType.SelectedValue);
                DataSet dss = payBLLL.PaymentTypeStatus(PID);
                int st = Convert.ToInt32(dss.Tables[0].Rows[0][0]);
                if (st != 3)
                {
                    PrintInvoice();
                }
                RefreshPayment();
                st = 0;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void PrintInvoice()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DialysisPaymentInvoice();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@payID", payID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
                payID = 0;

            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPayment();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    FrmDialysisPaymentDetails frmDialysisPaymentDetails = new FrmDialysisPaymentDetails(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                    frmDialysisPaymentDetails.MdiParent = this.MdiParent;
                    frmDialysisPaymentDetails.Show();
                }
                else
                {
                    FrmDialysisPaymentDetails frmDialysisPaymentDetails = new FrmDialysisPaymentDetails(null);
                    frmDialysisPaymentDetails.MdiParent = this.MdiParent;
                    frmDialysisPaymentDetails.Show();
                }
            }
            catch
            {
            }
        }

        private void lblDailyPayment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DailyPaymentDialysis dailyPaymentDialysis = new DailyPaymentDialysis();
                dailyPaymentDialysis.MdiParent = this.MdiParent;
                dailyPaymentDialysis.Show();
            }
            catch
            {
            }
        }

    }
}
