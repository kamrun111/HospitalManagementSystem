using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.DoctorsPayment;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    public partial class FrmDoctorsBillPayment : BaseForm.FrmBase
    {
        public FrmDoctorsBillPayment()
        {
            InitializeComponent();
        }

        private void FrmDoctorsBillPayment_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch
            {
            }
        }
        private void load()
        {
            DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
            DataSet ds = doctorsBillBLL.getdoctors();
            if (ds.Tables[0].Rows.Count > 0)
                FillUpListview(lvwDoctorInfo, ds, 0);
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
        private void FillUpListview1(ListView lvw, DataSet ds, int tableIndex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                if (lvwDoctorInfo.SelectedItems.Count > 0)
                {
                    DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
                    DataSet ds = doctorsBillBLL.getdoctodsbill(From, To, Convert.ToInt32(lvwDoctorInfo.SelectedItems[0].Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            this.grddoctorspayment.CellValueChanged -= this.grddoctorspayment_CellValueChanged;
                            grddoctorspayment.Rows.Add();
                            grddoctorspayment.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0];
                            grddoctorspayment.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1];
                            grddoctorspayment.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2];
                            grddoctorspayment.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3];
                            grddoctorspayment.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4];
                            grddoctorspayment.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][5];
                            grddoctorspayment.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][5];//actual amount
                            grddoctorspayment.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][6];
                            grddoctorspayment.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][7];
                            grddoctorspayment.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i][8];
                            this.grddoctorspayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellValueChanged);

                        }
                        adjustGrandTotal();
                        int count = Convert.ToInt32(grddoctorspayment.Rows.Count);
                        txtCount.Text = count.ToString();

                    }
                    else
                        MessageBox.Show("No data found");
                    

                }
                else
                {
                    MessageBox.Show("Select a doctor from list");
                    return;
                }
            }
            catch
            {
            }
        }

        private void grddoctorspayment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0) return;
           

            string msg = "";
            DataGridViewRow row = null;
            row = this.grddoctorspayment.Rows[e.RowIndex];
            try
            {
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (valueNumeric < 0)
                {
                    MessageBox.Show("Please Insert Digits Properly");
                    row.Cells[e.ColumnIndex].Value = 0;
                    //return;
                }
                else if (!int.TryParse(valueStr, out valueNumeric))
                {
                    MessageBox.Show("Please Insert Digits Properly");
                    row.Cells[e.ColumnIndex].Value = 0;
                }
                adjustGrandTotal();

            }
            catch
            {
            }
        }
        void adjustGrandTotal()
        {
            try
            {
                double grandTotal = 0;
                for (int i = 0; i < this.grddoctorspayment.RowCount; i++)
                {
                    double subTotal = 0.00;
                    double.TryParse(this.grddoctorspayment.Rows[i].Cells["paid_amount"].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
                this.txtTotal.Text = grandTotal.ToString("00");
                int count = Convert.ToInt32(grddoctorspayment.Rows.Count);
                txtCount.Text = count.ToString();
            }
            catch
            {
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            load();
            refresh();
        }
        private void refresh()
        {
            grddoctorspayment.Rows.Clear();
            txtCount.Text = "";
            txtTotal.Text = "";
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            btnsave.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwDoctorInfo.SelectedItems.Count > 0)
                {
                    if (grddoctorspayment.Rows.Count == 0)
                        return;
                    if (MessageBox.Show("Do You Want To Save Now?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                    DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                    DoctorsPayment doctorsPayment = new DoctorsPayment();
                    DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();
                    List<DoctorsPaymentDetails> listDoctorsPaymentDetails = new List<DoctorsPaymentDetails>();
                    List<DoctorsBillBO> listDoctorsBillBO = new List<DoctorsBillBO>();

                    doctorsPayment.record_created_by = ApplicatinLauncher._userId;
                    doctorsPayment.reffered_doctors_id = Convert.ToInt32(lvwDoctorInfo.SelectedItems[0].Text);
                    doctorsPayment.start_date = From;
                    doctorsPayment.end_date = To;
                    doctorsPayment.grand_total = Convert.ToDecimal(txtTotal.Text);
                    for (int i = 0; i < grddoctorspayment.Rows.Count; i++)
                    {
                        DoctorsPaymentDetails doctorsPaymentDetails = new DoctorsPaymentDetails();
                        doctorsPaymentDetails.doctors_bill_id = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[7].Value);
                        doctorsPaymentDetails.qty = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[4].Value);
                        doctorsPaymentDetails.total_amount = Convert.ToDecimal(grddoctorspayment.Rows[i].Cells[6].Value);
                        doctorsPaymentDetails.bill_submit_date = Convert.ToDateTime(grddoctorspayment.Rows[i].Cells[8].Value);
                        if(grddoctorspayment.Rows[i].Cells[9].Value!=DBNull.Value)
                        doctorsPaymentDetails.ot_date = Convert.ToDateTime(grddoctorspayment.Rows[i].Cells[9].Value);
    
                        doctorsPaymentDetails.record_created_by = ApplicatinLauncher._userId;
                        listDoctorsPaymentDetails.Add(doctorsPaymentDetails);

                        DoctorsBillBO doctorsBillBO = new DoctorsBillBO();
                        doctorsBillBO.doctors_bill_id = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[7].Value);
                        listDoctorsBillBO.Add(doctorsBillBO);
                    }
                    int result = doctorsPaymentBLL.doctorpaymentInsert(doctorsPayment, listDoctorsPaymentDetails, listDoctorsBillBO);
                    if (result > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                        PrintDocpaymentno(result);
                        btnsave.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(" Select a patient from list");
                    lvwDoctorInfo.Focus();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwDoctorInfo.SelectedItems.Count > 0)
                {
                    FrmDoctorsPaymentPrint frmDoctorsPaymentPrint = new FrmDoctorsPaymentPrint(Convert.ToInt32(lvwDoctorInfo.SelectedItems[0].Text));
                    frmDoctorsPaymentPrint.MdiParent = this.MdiParent;
                    frmDoctorsPaymentPrint.Show();
                }
                else
                {
                    FrmDoctorsPaymentPrint frmDoctorsPaymentPrint = new FrmDoctorsPaymentPrint(0);
                    frmDoctorsPaymentPrint.MdiParent = this.MdiParent;
                    frmDoctorsPaymentPrint.Show();
                }
            }
            catch
            {
            }
        }

        private void txtDoctorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtDoctorName.Text != "")
                {
                    RefferedDoctorsBLL oRefferedDoctorsBLL = new RefferedDoctorsBLL();
                    DataSet ds = oRefferedDoctorsBLL.DoctorSepecific(txtDoctorName.Text);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lvwDoctorInfo.Items.Clear();
                        FillUpListview1(lvwDoctorInfo, ds, 0);
                    }

                }
            }
            catch
            {
            }
        }
         
    }
}
