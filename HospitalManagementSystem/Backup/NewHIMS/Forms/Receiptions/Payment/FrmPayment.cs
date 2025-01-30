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
    public partial class FrmPayment : BaseForm.FrmBase
    {   //Shampa 15-12-2008

        private int admissionID;
        private int payID;
        //private int st = 0;
        ////DataSet dss = null;
        //private string UserNam;
        public FrmPayment()
        {
            InitializeComponent();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.SelectedIndex = -1;
                    combo.Text = "<Select>";
            }
            catch
            {
            }
        }

        public void RefreshPayment()
        {
            try
            {
                PayBLL payBLL = new PayBLL();
                DataSet ds = payBLL.PaymentType();
                DataSet dsinfo = payBLL.Paymentinfo();
                PopulateComboBox(cmbPaymentType, ds, 0, "payment_type", "payment_type_id");
                lvwPatientInfo.Items.Clear();
                FillUpListview(lvwPatientInfo, dsinfo);

                for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                {
                    int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[7].Text);
                    if (d == 2)
                        lvwPatientInfo.Items[i].ForeColor = Color.Magenta;
                }

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
                        lvi.SubItems.Add(dataRow[6].ToString());
                        lvi.SubItems.Add(dataRow[7].ToString());
                        

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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshPayment();
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshPayment();
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
                    txtGaurdianName.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text.ToString();
                    txtAdress.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text.ToString();
                    txtPhone.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text.ToString();
                }
                if (txtCustomerName.Text != "")
                    btnSave.Enabled = true;
                admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
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
                if (MessageBox.Show("Do you want to Save?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                int dc = 0;
                Pay pay = new Pay();
                PayBLL payBLL = new PayBLL();
                 
                if (txtTotal.Text != "")
                {
                    if (Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[7].Text) == 2)
                    {
                        DataSet ds = payBLL.DuepaymentAmount(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (Convert.ToInt32(txtTotal.Text) == Convert.ToInt32(ds.Tables[0].Rows[0][0]))
                            {
                                dc = 1;
                            }
                            else if (Convert.ToInt32(txtTotal.Text) == -Convert.ToInt32(ds.Tables[0].Rows[0][0]))
                            {
                                dc = 1;
                            }
                        }
                    }
                    pay.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                    pay.pay_date = Convert.ToDateTime(dtpPaymentDate.Text);
                    pay.amount = Convert.ToDecimal(txtTotal.Text);
                    pay.payment_type_id = Convert.ToInt32(cmbPaymentType.SelectedValue);
                    pay.is_doctors_bill = 0;
                    if (cmbPaymentType.SelectedIndex == 0 || cmbPaymentType.SelectedIndex == 1 || cmbPaymentType.SelectedIndex == 2 || cmbPaymentType.SelectedIndex == 3)
                    {
                        pay.status = 1; //Receive
                    }
                    else
                    {
                        pay.status = 2; //Loan/Refund 
                    }
                    pay.record_created_by = ApplicatinLauncher._userId;

                    payID = payBLL.paymentAdd(pay);
                    pay.pay_id = payID;
                    if (dc == 1)
                    {
                        AdmissionBO admissionBO = new AdmissionBO();
                        AdmissionBLL admissionBLL = new AdmissionBLL();
                        admissionBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                        admissionBO.is_bill_clear = 1;
                        admissionBO.record_modified_by = ApplicatinLauncher._userId;
                        admissionBLL.admissionUpdateforBill(admissionBO);   //admissionUpdateforBill
                    }
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                    MessageBox.Show("Insert amount");

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void NumCheck(KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGaurdianName.Focus();
            }

        }

        private void txtGaurdianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAdress.Focus();
            }
        }

        private void txtAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
            if (e.KeyChar == 13)
            {
                cmbPaymentType.Focus();
            }
        }

        private void cmbPaymentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpPaymentDate.Focus();
            }
        }

        private void dtpPaymentDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTotal.Focus();
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
            if (e.KeyChar == 13)
            {
                btnSave.Focus();
            }
        }

        private void lvwPatientInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTotal.Focus();
            }
        }


        public void PrintInvoice()
        {
            try
            {
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    FrmPaymentDetail frmPaymentDetail = new FrmPaymentDetail(lvwPatientInfo.SelectedItems[0].SubItems[1].Text);
                    frmPaymentDetail.MdiParent = this.MdiParent;
                    frmPaymentDetail.Show();
                }
                else
                {
                    FrmPaymentDetail frmPaymentDetail = new FrmPaymentDetail(null);
                    frmPaymentDetail.MdiParent = this.MdiParent;
                    frmPaymentDetail.Show();
                }
            }
            catch
            {
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //NumCheck(e);
                if (e.KeyChar == 13)
                {
                    ////lvwPatientInfo.Items.Clear();
                    ////FillUpListview(lvwPatientInfo, dsinfo);

                    ////for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                    ////{
                    ////    int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[7].Text);
                    ////    if (d == 2)
                    ////        lvwPatientInfo.Items[i].ForeColor = Color.Magenta;
                    ////}

                    int xx;
                    for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                    {
                        if (Int32.TryParse(txtSearch.Text, out xx))
                        {
                            if (Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[1].Text) == Convert.ToInt32(txtSearch.Text))
                            {
                                lvwPatientInfo.Items[i].BackColor = Color.LightCyan;
                                lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                                lvwPatientInfo.Items[i].Focused = true;
                            }
                            else if (lvwPatientInfo.Items[i].SubItems[0].Text == txtSearch.Text)
                            {
                                lvwPatientInfo.Items[i].BackColor = Color.LightCyan;
                                lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                                lvwPatientInfo.Items[i].Focused = true;
                            }
                        }
                        else
                        {
                            if (lvwPatientInfo.Items[i].SubItems[0].Text == txtSearch.Text)
                            {
                                lvwPatientInfo.Items[i].BackColor = Color.LightCyan;
                                lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                                lvwPatientInfo.Items[i].Focused = true;
                            }
                        }
                        //else
                        //    MessageBox.Show("Patient Not Found");
                    }
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
                FrmDailyPayment frmDailyPayment = new FrmDailyPayment();
                frmDailyPayment.MdiParent = this.MdiParent;
                frmDailyPayment.Show();
            }
            catch
            {
            }
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //PayBLL payBLLL = new PayBLL();
                //int PID = Convert.ToInt32(cmbPaymentType.SelectedValue);
                //DataSet dss = payBLLL.PaymentTypeStatus(PID);
                //st = Convert.ToInt32(dss.Tables[0].Rows[0][0]);
            }
            catch
            {
            }
        }
      
               
    }
}