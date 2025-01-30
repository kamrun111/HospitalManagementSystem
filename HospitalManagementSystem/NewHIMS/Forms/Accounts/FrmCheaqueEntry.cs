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
    public partial class FrmCheaqueEntry : BaseForm.FrmBase
    {
        public FrmCheaqueEntry()
        {
            InitializeComponent();
        }

        private void FrmCheaqueEntry_Load(object sender, EventArgs e)
        {
            ChequePaymentBLL chequePaymentBLL = new ChequePaymentBLL();
            DataSet dataSet = chequePaymentBLL.BankNameLoad();
            cmbBank.DataSource = dataSet.Tables[0];
            cmbBank.DisplayMember = "bank_name";
            cmbBank.ValueMember = "bank_id";
            cmbBank.SelectedIndex = -1;
            cmbBank.Text = "<Select>";
        

        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBank.SelectedIndex != -1)
                {
                    ChequePaymentBLL ChequePaymentBLL = new ChequePaymentBLL();
                    DataSet ds = ChequePaymentBLL.AccountNoGet(Convert.ToInt32(cmbBank.SelectedValue));
                    cmbAccountNo.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch
            {
            }
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom.Text == "")
                {
                    txtFrom.Focus();
                    return;
                }
                if (txtTo.Text == "")
                {
                    txtTo.Focus();
                    return;
                }
                if (cmbAccountNo.Text == "")
                {
                    cmbAccountNo.Focus();
                    return;
                }
                List<ChequePayment> ListChequePayment = new List<ChequePayment>();
                ChequePaymentBLL ChequePaymentBLL = new ChequePaymentBLL();
                for (int i = Convert.ToInt32(txtFrom.Text); i <= Convert.ToInt32(txtTo.Text); i++)
                {
                    ChequePayment chequePayment = new ChequePayment();
                    chequePayment.bank_id = Convert.ToInt32(cmbBank.SelectedValue);
                    chequePayment.account_no = cmbAccountNo.Text;
                    chequePayment.check_no = i.ToString();
                    chequePayment.flag = 0;
                    chequePayment.record_created_by =ApplicatinLauncher._userId;
                    ListChequePayment.Add(chequePayment);
                }
                int result = ChequePaymentBLL.ChequePaymentAdd(ListChequePayment);
                MessageBox.Show("Data Saved Successfully");
                btnSave.Enabled = false;
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
