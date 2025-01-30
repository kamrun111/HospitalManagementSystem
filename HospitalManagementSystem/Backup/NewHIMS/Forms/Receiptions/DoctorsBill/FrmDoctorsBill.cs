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
using NewHIMS.Reports.Doctors_Payment;


namespace NewHIMS.Forms.Receiptions.DoctorsBill
{
    public partial class FrmDoctorsBill : Form
    {
        public FrmDoctorsBill()
        {
            InitializeComponent();
        }

        private void FrmDoctorsBill_Load(object sender, EventArgs e)
        {
            RefreshPage();
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


        void RefreshPage()
        {
            DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
            DataSet ds = doctorsBillBLL.DoctorsBillLoad();
            FillUpListview(lvwDoctrsBill,ds,0);
         
            
          
        }

        private void lvwDoctrsBill_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (lvwDoctrsBill.SelectedItems.Count > 0)

                {
                    DoctorsPaymentDetailsBLL doctorsPaymentDetailsBLL = new DoctorsPaymentDetailsBLL();
                    DataSet ds = doctorsPaymentDetailsBLL.getdoctorpaymentbill(Convert.ToInt32(lvwDoctrsBill.SelectedItems[0].SubItems[2].Text));
                    grdDoctorsBill.Rows.Clear();
                    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdDoctorsBill.Rows.Add();
                            grdDoctorsBill.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                            grdDoctorsBill.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                            grdDoctorsBill.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                        }
                    }
                   
                }
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
         
            grdDoctorsBill.Rows.Clear();
            RefreshDocBill();
        }

        void RefreshDocBill()
        {
            
            grdDoctorsBill.Rows.Clear();
            RefreshPage();
            btnSave.Enabled = true;
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdDoctorsBill.RowCount == 0)
                    return;
                if (MessageBox.Show("Do you want to Save?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                DoctorsPayment doctorsPayment = new DoctorsPayment();
                List<DoctorsPaymentDetails> listDoctorsPaymentDetails = new List<DoctorsPaymentDetails>();
                DoctorsPaymentDetailsBLL doctorsPaymentDetailsBLL = new DoctorsPaymentDetailsBLL();
                int Result = 0;
                if (lvwDoctrsBill.SelectedItems.Count > 0)
                {
                    doctorsPayment.admission_code = Convert.ToInt32(lvwDoctrsBill.SelectedItems[0].Text);
                    doctorsPayment.record_modified_by = ApplicatinLauncher._userId;

                    for (int i = 0; i < grdDoctorsBill.Rows.Count; i++)
                    {
                        DoctorsPaymentDetails doctorsPaymentDetails = new DoctorsPaymentDetails();
                        doctorsPaymentDetails.doctors_payment_details_id = Convert.ToInt32(grdDoctorsBill.Rows[i].Cells[0].Value);
                        doctorsPaymentDetails.record_modified_by = ApplicatinLauncher._userId;
                        listDoctorsPaymentDetails.Add(doctorsPaymentDetails);

                    }
                    Result = doctorsPaymentDetailsBLL.doctorsBillpayment(doctorsPayment, listDoctorsPaymentDetails);

                }
                //DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
                //List<DoctorsBillBO> doctorsBillBOup = new List<DoctorsBillBO>();
                //for (int i = 0; i < grdDoctorsBill.RowCount; i++)
                //{
                //  DoctorsBillBO doctorsBillBO = new DoctorsBillBO();
                //  if (Convert.ToBoolean(grdDoctorsBill.Rows[i].Cells["is_paid"].Value)== true && grdDoctorsBill.Rows[i].Cells[0].Value !=null)
                //  {
                //      doctorsBillBO.is_paid = 1;
                //      doctorsBillBO.doctors_bill_id = Convert.ToInt32(grdDoctorsBill.Rows[i].Cells["doctors_bill_id"].Value);
                //      doctorsBillBOup.Add(doctorsBillBO);
                //      doctorsBillBO = null;
                //  }
                //}
                //int result = doctorsBillBLL.DoctorsBillUpdate(doctorsBillBOup);

                if (Result > 0)
                 {
                     MessageBox.Show("Data Saved Successfully");
                     btnSave.Enabled = false;
                     PrintdoctorsBill(Convert.ToInt32(lvwDoctrsBill.SelectedItems[0].Text));
                     grdDoctorsBill.Rows.Clear();
                     RefreshDocBill();
                 }

            }
            catch
            {
                MessageBox.Show("Data Saved Failed");
            }
        }

        private void grdDoctorsBill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (lvwDoctrsBill.SelectedItems.Count > 0)
                grdDoctorsBill.Enabled = true;
            else
                grdDoctorsBill.Enabled = false;
             
        }

        private void grdDoctorsBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < grdDoctorsBill.Rows.Count - 1; i++)
            //{
            //    if (grdDoctorsBill.Rows[i].Cells[0].Value== null )
            //       Convert.ToBoolean(grdDoctorsBill.Rows[i].Cells[5].Value)= false;
           
            
            //}
        }
        void PrintdoctorsBill(int admissioncode)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;

                ReportDocument rptCustomersOrders = new rptdoctorspayment();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_code", admissioncode);

                
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
            try
            {
                FrmDoctorsPaymentPrint frmDoctorsPaymentPrint = new FrmDoctorsPaymentPrint();
                frmDoctorsPaymentPrint.ShowDialog();
                                
            }
            catch
            {
            }
        }



    }
}