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
    public partial class FrmOthersIncome : BaseForm.FrmBase
    {
        public FrmOthersIncome()
        {
            InitializeComponent();
        }


        void GetLoad()
        {
            try
            {
                OtherIncomeBLL otherIncomeBLL = new OtherIncomeBLL();
                DataSet ds = otherIncomeBLL.IncomeHeadLoad();  //getotherincome
                if (ds.Tables[0].Rows.Count > 0)
                {
                    PopulateComboBox(cmbOthersIncome, ds, 0, "income", "income_head_id");
                   
                }

                FillUpListview(lvwOthersIncome, ds, 1);
                btnSave.Enabled = true;
                txtamount.Text = "";
                txtremarks.Text = "";

            }
            catch
            {
            }
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
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error3");
            }
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOthersIncome.SelectedIndex == -1)
                    return;
                if (txtamount.Text == "")
                {
                    txtamount.Focus();
                    return;
                }
                OtherIncomeBO otherIncomeBO = new OtherIncomeBO();
                OtherIncomeBLL otherIncomeBLL = new OtherIncomeBLL();
                otherIncomeBO.income_head_id = Convert.ToInt32(cmbOthersIncome.SelectedValue);
                otherIncomeBO.amount = Convert.ToDecimal(txtamount.Text);
                otherIncomeBO.date = Convert.ToDateTime(dtpdate.Value);
                otherIncomeBO.remarks = txtremarks.Text;
                otherIncomeBO.record_created_by = ApplicatinLauncher._userId;
                int result = otherIncomeBLL.OtherIncomeAdd(otherIncomeBO);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOthersIncome_Load(object sender, EventArgs e)
        {
            try
            {
                GetLoad();
            }
            catch
            {
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        public void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetLoad();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmOthersIncomePrint frmOthersIncomePrint = new FrmOthersIncomePrint();
            frmOthersIncomePrint.ShowDialog();
        }

 
    }
}
