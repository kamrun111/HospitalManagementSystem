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
    public partial class FrmLoanSlipPayment : BaseForm.FrmBase
    {
        public FrmLoanSlipPayment()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmLoanSlipPayment_Load(object sender, EventArgs e)
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
                DataSet ds = cs.GetDataSet("LoanSlipLoad");

                lvwLoanEmployee.Items.Clear();

                if (ds.Tables[1].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwLoanEmployee, ds, 1);

                }
                
                btnSave.Enabled = false;
                
            }
            catch
            {
            }
        }

        private void lvwLoanEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (lvwLoanEmployee.SelectedItems.Count > 0)
                {
                    txtEmpID.Text = lvwLoanEmployee.SelectedItems[0].SubItems[0].Text;
                    txtEmpName.Text = lvwLoanEmployee.SelectedItems[0].SubItems[1].Text;
                    txtBalanceAmount.Text = lvwLoanEmployee.SelectedItems[0].SubItems[2].Text;
                    

                    DataSet ds = cs.GetDataSetWithParameter("@EmpID", Convert.ToInt32(lvwLoanEmployee.SelectedItems[0].SubItems[0].Text), "LoanSlipLoadwithEmpID");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwSlipinfo, ds, 0);
                    }
                }
                
            }
            catch
            {
            }
        }

        private void lvwSlipinfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (lvwSlipinfo.SelectedItems.Count > 0)
                {
                    txtSlipID.Text = lvwSlipinfo.SelectedItems[0].SubItems[0].Text;
                    txtAmount.Text = lvwSlipinfo.SelectedItems[0].SubItems[2].Text;

                    if (txtSlipID.Text != "" && txtEmpID.Text != "")
                    {
                        btnSave.Enabled = true;
                    }
                                        
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
                txtEmpID.Text = "";
                txtEmpName.Text = "";
                txtAmount.Text = "";
                txtBalanceAmount.Text = "";
                txtSlipID.Text = "";
                lvwSlipinfo.Items.Clear();
                lvwLoanEmployee.Items.Clear();
                GetPageLoad();
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                LoanSlipBLL loanSlipBLL = new LoanSlipBLL();
                LoanSlipBO loanSlipBO = new LoanSlipBO();

                loanSlipBO.loan_employee_id = Convert.ToInt32(txtEmpID.Text);
                loanSlipBO.loan_slip_amount = Convert.ToDecimal(txtAmount.Text);
                loanSlipBO.loan_slip_id = Convert.ToInt32(txtSlipID.Text);
                loanSlipBO.record_modified_by = Convert.ToInt32(ApplicatinLauncher._userId);

                int Result = loanSlipBLL.LoanSlipPayment(loanSlipBO);

                if (Result > 0)
                {
                    btnSave.Enabled = false;
                    MessageBox.Show("Data Saved Successfully");


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
