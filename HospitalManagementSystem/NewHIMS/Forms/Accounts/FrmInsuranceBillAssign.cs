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
using NewHIMS.Reports.Bill;
using NewHIMS.Reports.Payment;


namespace NewHIMS.Forms.Accounts
{
    public partial class FrmInsuranceBillAssign : Form
    {
        public FrmInsuranceBillAssign()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmInsuranceBillAssign_Load(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
                btnAssign.Enabled = false;
                btnAssign.Text = "Assign";
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

                lvwDue.Items.Clear();

                cs.PopulateComboBox(cmbCompany, ds, 4, "insurance_company_name", "insurance_company_id");

                if(ds.Tables[3].Rows.Count>0)
                {
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwDue, ds, 3);

                        for (int i = 0; i < lvwDue.Items.Count; i++)
                        {
                            int d = Convert.ToInt32(lvwDue.Items[i].SubItems[11].Text);
                            if (d == 1)
                                lvwDue.Items[i].ForeColor = Color.BlueViolet;
                        }

                    }

                }
            }
            catch
            {
            }
        }

        private void lvwDue_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwDue.SelectedItems.Count > 0)
                {

                    if (lvwDue.SelectedItems[0].SubItems[11].Text == "0")
                    {
                        LoadforSave();
                        btnAssign.Text = "Assign";
                        btnAssign.Enabled = true;
                    }

                    else
                    {
                        LoadforUpdate();
                        btnAssign.Text = "Update";
                        btnAssign.Enabled = false;
                    }
                }

            }
            catch
            {
            }
        }

        void LoadforSave()
        {
            try
            {
                txtName.Text = lvwDue.SelectedItems[0].SubItems[3].Text;
                txtMobile.Text = lvwDue.SelectedItems[0].SubItems[6].Text;
                txtAd_date.Text = lvwDue.SelectedItems[0].SubItems[9].Text;
                txtDis_date.Text = lvwDue.SelectedItems[0].SubItems[10].Text;


                DataSet ds = cs.GetDataSetWithParameter("@AdID", Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text), "InsuranceBillLoad");

                if(ds.Tables[0].Rows.Count>0)
                {
                    txtBill.Text=ds.Tables[0].Rows[0][1].ToString();
                    txtDiscount.Text=ds.Tables[0].Rows[0][2].ToString();
                    txtAmount.Text=ds.Tables[0].Rows[0][3].ToString();
                }

            }
            catch
            {
            }
        }

        void LoadforUpdate()
        {
            try
            {
                txtName.Text = lvwDue.SelectedItems[0].SubItems[3].Text;
                txtMobile.Text = lvwDue.SelectedItems[0].SubItems[6].Text;
                txtAd_date.Text = lvwDue.SelectedItems[0].SubItems[9].Text;
                txtDis_date.Text = lvwDue.SelectedItems[0].SubItems[10].Text;


                DataSet ds = cs.GetDataSetWithParameter("@AdID", Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[11].Text), "InsuranceBillLoad");

                if (ds.Tables[1].Rows.Count > 0)
                {
                   
                    txtAmount.Text = ds.Tables[1].Rows[0][4].ToString();
                    cmbCompany.SelectedValue = Convert.ToInt32(ds.Tables[1].Rows[0][5]).ToString();
                }

            }
            catch
            {
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                InsurancePaymentBLL insurancePaymentBLL = new InsurancePaymentBLL();
                InsurancePaymentBO insurancePaymentBO = new InsurancePaymentBO();

                insurancePaymentBO.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                insurancePaymentBO.insurance_company_id = Convert.ToInt32(cmbCompany.SelectedValue);
                insurancePaymentBO.amount = Convert.ToDecimal(txtAmount.Text);
                insurancePaymentBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);

                int Result = insurancePaymentBLL.InsurancePaymentAssign(insurancePaymentBO);

                if (Result > 0)
                {
                    MessageBox.Show("Bill Assigned Successfully.");
                    btnAssign.Enabled = false;
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
                txtName.Text = "";
                txtMobile.Text = "";
                txtAd_date.Text = "";
                txtDis_date.Text = "";
                txtBill.Text = "";
                txtAmount.Text = "";
                txtDiscount.Text = "";

                cmbCompany.SelectedIndex = -1;

                GetPageLoad();


            }
            catch
            {
            }
        }

    }
}
