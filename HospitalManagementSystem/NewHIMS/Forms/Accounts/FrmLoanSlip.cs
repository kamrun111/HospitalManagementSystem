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
    public partial class FrmLoanSlip : BaseForm.FrmBase
    {
        public FrmLoanSlip()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmLoanSlip_Load(object sender, EventArgs e)
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
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.PopulateComboBox(cmbEmployee, ds, 0, "loan_employee_name", "loan_employee_id");

                }

                btnSave.Enabled = true;
                txtLoanAmount.Text = "";
                txtLoanRemarks.Text = "";
                txtBalanceAmount.Text = "";
                cmbEmployee.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployee.SelectedIndex > -1)
                {
                    DataSet ds = cs.GetDataSetWithParameter("@EmpID", Convert.ToInt32(cmbEmployee.SelectedValue), "LoanAmountLoad");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtBalanceAmount.Text = ds.Tables[0].Rows[0][2].ToString();
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
                LoanSlipBLL loanSlipBLL = new LoanSlipBLL();
                LoanSlipBO loanSlipBO = new LoanSlipBO();

                loanSlipBO.loan_employee_id = Convert.ToInt32(cmbEmployee.SelectedValue);
                loanSlipBO.loan_slip_amount = Convert.ToDecimal(txtLoanAmount.Text);
                loanSlipBO.loan_slip_date = Convert.ToDateTime(dtpLoanDate.Text);
                loanSlipBO.loan_slip_remarks = txtLoanRemarks.Text;
                loanSlipBO.record_created_by = Convert.ToInt32(ApplicatinLauncher._userId);

                int Result = loanSlipBLL.AddLoanSlip(loanSlipBO);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cmbEmployee.SelectedIndex = -1;
                txtBalanceAmount.Text = "";
                txtLoanAmount.Text = "";
                txtLoanRemarks.Text = "";
                //dtpLoanDate.Value = DateTime.Now.ToString();
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
