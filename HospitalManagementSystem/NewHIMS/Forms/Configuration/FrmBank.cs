using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Configuration
{
    public partial class FrmBank : BaseForm.FrmBase
    {
        public FrmBank()
        {
            InitializeComponent();
        }
        private void NumCheck(KeyPressEventArgs e)
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
                if (txtBankFullName.Text == "")
                {
                    txtBankFullName.Focus();
                    return;
                }
                if (txtBankName.Text == "")
                {
                    txtBankName.Focus();
                    return;
                }
                Bank bank = new Bank();
                BankBLL bankBLL = new BankBLL();

                bank.full_bank_name = txtBankFullName.Text;
                bank.bank_name = txtBankName.Text;
                bank.branch_name = txtBranchName.Text;
                bank.branch_address = txtBranchAddress.Text;
                bank.contact_person = txtContactPerson.Text;
                bank.contact_number = txtContactNumber.Text;
                bank.account_no = txtAccount.Text;
                bank.record_created_by = ApplicatinLauncher._userId;
                if (txtInterestRate.Text != "")
                    bank.interest_rate = Convert.ToDecimal(txtInterestRate.Text);
                else
                    bank.interest_rate = 0;
                int result = 0;

                if (btnSave.Text == "Save")
                {
                    result = bankBLL.BankAdd(bank);
                }
                else
                {
                    if (ApplicatinLauncher._GroupName == "Accounts" || ApplicatinLauncher._GroupName == "Administrator")
                    {
                        bank.bank_id = Convert.ToInt32(lvwBank.SelectedItems[0].Text);
                        bank.record_modified_by = ApplicatinLauncher._userId;
                        result = bankBLL.BankUpdate(bank);
                    }
                    else
                    {
                        MessageBox.Show("You have no permission");
                        return;
                    }
                }
                if (result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void txtInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetRefresh();
        }
        void GetRefresh()
        {
            txtBankFullName.Text="";
            txtBankName.Text="";
            txtBranchName.Text="";
            txtBranchAddress.Text="";
            txtContactPerson.Text="";
            txtContactNumber.Text="";
            txtInterestRate.Text = "";
            txtAccount.Text="";
            btnSave.Text = "Save";
            btnSave.Enabled = true;
            BankBLL bankBLL= new BankBLL();
            DataSet ds = bankBLL.BankLoad();
            if (ds.Tables[0].Rows.Count > 0)
                FillUpListview(lvwBank, ds, 0);
            txtCount.Text = ds.Tables[1].Rows[0][0].ToString();
        }
        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
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
                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvi.SubItems.Add(dataRow[4].ToString());
                        lvi.SubItems.Add(dataRow[5].ToString());
                        lvi.SubItems.Add(dataRow[6].ToString());
                        lvi.SubItems.Add(dataRow[7].ToString());
                        lvi.SubItems.Add(dataRow[8].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                
            }
        }

        private void FrmBank_Load(object sender, EventArgs e)
        {
            GetRefresh();
        }

        private void lvwBank_Click(object sender, EventArgs e)
        {
            if (lvwBank.SelectedItems.Count > 0)
            {
                btnSave.Text = "Update";
                txtBankFullName.Text = lvwBank.SelectedItems[0].SubItems[1].Text;
                txtBankName.Text = lvwBank.SelectedItems[0].SubItems[2].Text;
                txtBranchName.Text = lvwBank.SelectedItems[0].SubItems[3].Text;
                txtBranchAddress.Text = lvwBank.SelectedItems[0].SubItems[4].Text;
                txtContactPerson.Text = lvwBank.SelectedItems[0].SubItems[5].Text;
                txtContactNumber.Text = lvwBank.SelectedItems[0].SubItems[6].Text;
                txtAccount.Text = lvwBank.SelectedItems[0].SubItems[7].Text;
                txtInterestRate.Text = lvwBank.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
