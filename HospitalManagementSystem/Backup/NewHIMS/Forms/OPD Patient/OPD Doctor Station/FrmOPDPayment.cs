using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    public partial class FrmOPDPayment : Form
    {
        public FrmOPDPayment()
        {
            InitializeComponent();
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
        private void FrmOPDPayment_Load(object sender, EventArgs e)
        {
            OPDBill oPDBill = new OPDBill();
            OPDBillBLL oPDBillBLL = new OPDBillBLL();
            DataSet ds = new DataSet();
            ds = oPDBillBLL.OPDBillGet();
            FillUpListview(lvwPatientInfo, ds, 0);
            cmbPaymentType.Items.Add("CASH");
            cmbPaymentType.Items.Add("REFUND");
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OPDBill oPDBill = new OPDBill();
            OPDBillBLL oPDBillBLL = new OPDBillBLL();
            DataSet ds = new DataSet();
            ds = oPDBillBLL.OPDBillGetByRegID(txtRegID.Text);
            FillUpListview(lvwPatientInfo, ds, 0);
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            txtAdress.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text.ToString();
            txtCustomerName.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
            txtGaurdianName.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text.ToString();
            txtPhone.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text.ToString();
            txtRegID.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
            txtTotal.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OPDPayTable oPDPayTable = new OPDPayTable();
            OPDPayTableBLL oPDPayTableBLL = new OPDPayTableBLL();
            
            oPDPayTable.RegistrationID = txtRegID.Text.ToString();
            oPDPayTable.RecordeCreatedBy = ApplicatinLauncher._userId;
            if (cmbPaymentType.Text == "CASH")
            {
                oPDPayTable.PaymentTypeID = 1;
                oPDPayTable.Amount = Convert.ToDecimal(txtTotal.Text.ToString());
            }
            else
            {
                oPDPayTable.PaymentTypeID = 2;
                oPDPayTable.Amount = Convert.ToDecimal(txtTotal.Text.ToString())*(-1);
            }
            oPDPayTable.Time = (DateTime.Now.ToString("hh:mm"));
            oPDPayTableBLL.AddOPDPayTable(oPDPayTable);
            MessageBox.Show("Payment Successfully");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                frmOPDPaymentDetail FrmOPDPaymentDetail = new frmOPDPaymentDetail();
                FrmOPDPaymentDetail.populatedata(txtRegID.Text.ToString());
            }
            catch
            {


            }
        }
    }
}