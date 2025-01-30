using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Accounts
{
    public partial class FrmChequePayment : BaseForm.FrmBase
    {
        public FrmChequePayment()
        {
            InitializeComponent();
        }

        private void FrmChequePayment_Load(object sender, EventArgs e)
        {
            ChequePaymentBLL chequePaymentBLL = new ChequePaymentBLL();
            DataSet dataSet = chequePaymentBLL.BankNameLoad();
            PopulateComboBox(cmbBank, dataSet, 0, "bank_name", "bank_id");


        }
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.DataSource = ds.Tables[tableIndex];
                combo.SelectedIndex = -1;
                combo.Text = "<Select>";
            }
            catch
            {
            }
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex != -1)
            {
                ChequePaymentBLL ChequePaymentBLL = new ChequePaymentBLL();
                DataSet ds = ChequePaymentBLL.AccountNoGet(Convert.ToInt32(cmbBank.SelectedValue));
                cmbAccountNo.Text = ds.Tables[0].Rows[0][0].ToString();
                PopulateComboBox(cmbChequeNo, ds, 1, "check_no", "cheque_payment_id");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BankTransationBLL bankTransationBLL = new BankTransationBLL();
                if (txtPaidAmount.Text == "")
                {
                    txtPaidAmount.Focus();
                    return;
                }
                ChequePayment chequePayment = new ChequePayment();
                BankTransation bankTransation = new BankTransation();
                Bank bank = new Bank();

                chequePayment.cheque_payment_id = Convert.ToInt32(cmbChequeNo.SelectedValue);
                chequePayment.issue_date = Convert.ToDateTime(dtpIssueDate.Value);
                chequePayment.payment_date = Convert.ToDateTime(dtpPaymenDate.Value);
                chequePayment.paid_amount= Convert.ToDecimal(txtPaidAmount.Text);
                chequePayment.party_name = txtParyName.Text;
                chequePayment.remarks = txtRemarks.Text;
                if (cmbType.Text == "Withdrow")
                    chequePayment.flag = 1;
                else
                    chequePayment.flag = 0;
                chequePayment.record_created_by = ApplicatinLauncher._userId;

                bankTransation.payment_type = cmbType.Text;
                bankTransation.bank_id = Convert.ToInt32(cmbBank.SelectedValue);
                bankTransation.account_no = cmbAccountNo.Text;
                if (cmbType.Text == "Withdrow")
                    bankTransation.check_no= cmbChequeNo.Text;
                else
                     bankTransation.check_no = "";
                bankTransation.party_name = txtParyName.Text;
                bankTransation.amount =Convert.ToDecimal(txtPaidAmount.Text);
                bankTransation.issue_date = Convert.ToDateTime(dtpIssueDate.Value);
                bankTransation.payment_date = Convert.ToDateTime(dtpPaymenDate.Value);
                bankTransation.remarks = txtRemarks.Text;
                bankTransation.record_created_by = ApplicatinLauncher._userId;

                bank.bank_id = Convert.ToInt32(cmbBank.SelectedValue);
                if(cmbType.Text == "Withdrow")
                    bank.balance =- Convert.ToDecimal(txtPaidAmount.Text);
                else
                    bank.balance = Convert.ToDecimal(txtPaidAmount.Text);

                int result = bankTransationBLL.BankTransationDetails(chequePayment, bankTransation, bank);
                MessageBox.Show("Data Saved successfully");
                btnSave.Enabled = false;
            }
            catch
            {
            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
                {
                    e.Handled = true;
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
            btnSave.Enabled = true;
            cmbBank.Text = "<Select>";
            cmbAccountNo.DataSource = null;
            cmbChequeNo.Text = "";
            dtpIssueDate.Value = DateTime.Now;
            dtpPaymenDate.Value = DateTime.Now;
            txtPaidAmount.Text="";
            txtParyName.Text="";
             txtRemarks.Text="";
             cmbAccountNo.Text = "";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbType.Text == "Withdrow")
                    cmbChequeNo.Enabled = true;
                else
                    cmbChequeNo.Enabled = false;

            }
            catch
            {
            }
        }
    }
}
