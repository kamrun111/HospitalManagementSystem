using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Data.Common;
using NewHIMS.Reports;
using CrystalDecisions.CrystalReports.Engine;


namespace NewHIMS.Forms.Accounts
{
    public partial class FrmInsuranceBillPayment : Form
    {
        public FrmInsuranceBillPayment()
        {
            InitializeComponent();
        }


        CommonClass cs = new CommonClass();

        private void FrmInsuranceBillPayment_Load(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
            }
            catch
            {
            }
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("PaymentinfoMember");

                lvwInsuranceCompany.Items.Clear();

                if (ds.Tables[5].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwInsuranceCompany, ds, 5);

                }

                btnSave.Enabled = false;
            }
            catch
            {
            }
        }

        private void lvwInsuranceCompany_Click(object sender, EventArgs e)
        {
            try
            {
                GetRefresh();

                if (lvwInsuranceCompany.SelectedItems.Count > 0)
                {
                    txtComID.Text = lvwInsuranceCompany.SelectedItems[0].SubItems[0].Text;
                    txtComName.Text = lvwInsuranceCompany.SelectedItems[0].SubItems[1].Text;
                    txtBalanceAmount.Text = lvwInsuranceCompany.SelectedItems[0].SubItems[2].Text;

                    DataSet ds = cs.GetDataSetWithParameter("@AdID", Convert.ToInt32(lvwInsuranceCompany.SelectedItems[0].SubItems[0].Text), "InsuranceBillLoad");

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwBillinfo, ds, 2);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InsurancePaymentBLL insurancePaymentBLL = new InsurancePaymentBLL();
                InsurancePaymentBO insurancePaymentBO = new InsurancePaymentBO();

                insurancePaymentBO.insurance_payment_id = Convert.ToInt32(txtBillID.Text);
                insurancePaymentBO.insurance_company_id = Convert.ToInt32(txtComID.Text);
                insurancePaymentBO.amount = Convert.ToDecimal(txtAmount.Text);
                insurancePaymentBO.payment_type = txtRemarks.Text;
                insurancePaymentBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                int Result = insurancePaymentBLL.InsuranceBillPayment(insurancePaymentBO);

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;

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
                GetRefresh();
                GetPageLoad();
            }
            catch
            {
            }
        }

        void GetRefresh()
        {
            try
            {
                txtComID.Text = "";
                txtComName.Text = "";
                txtBillID.Text = "";
                txtBalanceAmount.Text = "";
                txtAmount.Text = "";
                txtRemarks.Text = "";
                lvwBillinfo.Items.Clear();
            }
            catch
            {
            }
        }

        private void lvwBillinfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwBillinfo.SelectedItems.Count > 0)
                {
                    txtBillID.Text = lvwBillinfo.SelectedItems[0].SubItems[0].Text;
                    txtAmount.Text = lvwBillinfo.SelectedItems[0].SubItems[3].Text;

                    if (txtBillID.Text != "" && txtComID.Text != "")
                    {
                        btnSave.Enabled = true;
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


    }
}
