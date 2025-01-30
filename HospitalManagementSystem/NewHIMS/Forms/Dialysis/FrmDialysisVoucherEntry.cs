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
using NewHIMS.Reports.Expenditure;


namespace NewHIMS.Forms.Dialysis
{
    public partial class FrmDialysisVoucherEntry : BaseForm.FrmBase
    {
        public FrmDialysisVoucherEntry()
        {
            InitializeComponent();
        }


        CommonClass cs = new CommonClass();

        private void FrmDialysisVoucherEntry_Load(object sender, EventArgs e)
        {
            try
            {
                GetLoad();
            }
            catch
            {
            }
        }

        private void GetLoad()
        {
            try
            {
                BillBLL billBLL = new BillBLL();
                DataSet ds = billBLL.getexpences();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.PopulateComboBox(cmbexpences, ds, 0, "expencess", "expencess_id");
                }
                grdexpenditure.Rows.Clear();
                txtamount.Text = "";
                txtremarks.Text = "";
                dtpdate.Value = DateTime.Now;
                btnSave.Enabled = true;
                txtCount.Text = "";
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbexpences.SelectedIndex == -1)
                {
                    MessageBox.Show("Select item from list");
                    cmbexpences.Focus();
                    return;
                }
                if (txtamount.Text == "")
                {
                    MessageBox.Show("Please insert amount");
                    txtamount.Focus();
                    return;
                }
                this.grdexpenditure.CellValueChanged -= this.grdexpenditure_CellValueChanged;
                grdexpenditure.Rows.Add();
                grdexpenditure.Rows[grdexpenditure.Rows.Count - 1].Cells[0].Value = dtpdate.Text;
                grdexpenditure.Rows[grdexpenditure.Rows.Count - 1].Cells[1].Value = Convert.ToInt32(cmbexpences.SelectedValue);
                grdexpenditure.Rows[grdexpenditure.Rows.Count - 1].Cells[2].Value = cmbexpences.Text.ToString();
                grdexpenditure.Rows[grdexpenditure.Rows.Count - 1].Cells[3].Value = txtamount.Text.ToString();
                grdexpenditure.Rows[grdexpenditure.Rows.Count - 1].Cells[4].Value = txtremarks.Text.ToString();
                txtamount.Text = "";
                txtremarks.Text = "";
                int count = Convert.ToInt32(grdexpenditure.Rows.Count);
                txtCount.Text = count.ToString();
                adjustGrandTotal();
                this.grdexpenditure.CellValueChanged += this.grdexpenditure_CellValueChanged;



            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdexpenditure.Rows.Count == 0)
                    return;
                if (MessageBox.Show("Do you want to save", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                ExpenditureOrder expenditureOrder = new ExpenditureOrder();
                ExpenditureOrderBLL expenditureOrderBLL = new ExpenditureOrderBLL();
                List<Expenditure> listExpenditure = new List<Expenditure>();

                expenditureOrder.recordate = Convert.ToDateTime(dtpdate.Value);
                expenditureOrder.record_created_by = ApplicatinLauncher._userId;
                for (int i = 0; i < grdexpenditure.Rows.Count; i++)
                {
                    Expenditure expenditure = new Expenditure();
                    expenditure.expencess_id = Convert.ToInt32(grdexpenditure.Rows[i].Cells[1].Value);
                    expenditure.amount = Convert.ToDecimal(grdexpenditure.Rows[i].Cells[3].Value);
                    expenditure.remarks = grdexpenditure.Rows[i].Cells[4].Value.ToString();
                    expenditure.recordate = Convert.ToDateTime(grdexpenditure.Rows[i].Cells[0].Value);
                    expenditure.record_created_by = ApplicatinLauncher._userId;

                    listExpenditure.Add(expenditure);
                }
                int Result = expenditureOrderBLL.ExpenditureOrderInsertDialysis(expenditureOrder, listExpenditure);

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                    Printexpenditure(Result);
                }
            }
            catch
            {
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdexpenditure.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to Delete?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    grdexpenditure.Rows.Remove(grdexpenditure.SelectedRows[0]);
                    int count = Convert.ToInt32(grdexpenditure.Rows.Count);
                    txtCount.Text = count.ToString();
                    adjustGrandTotal();
                }
                else
                    MessageBox.Show("Select item from list");
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                GetLoad();
            }
            catch
            {
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Printexpenditure(int expenditureID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ExpenditureOrdeReportDialysis();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@expenditure_order_id", expenditureID);


                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
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
                MessageBox.Show("Error6");
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
            }
            catch
            {
                MessageBox.Show("Error21");
            }

        }

        private void grdexpenditure_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0) return;


            string msg = "";
            DataGridViewRow row = null;
            row = this.grdexpenditure.Rows[e.RowIndex];
            try
            {
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (valueNumeric < 0)
                {
                    MessageBox.Show("Please Insert Digits Properly");
                    row.Cells[e.ColumnIndex].Value = 0;
                    //return;
                }
                else if (!int.TryParse(valueStr, out valueNumeric))
                {
                    MessageBox.Show("Please Insert Digits Properly");
                    row.Cells[e.ColumnIndex].Value = 0;
                }
                adjustGrandTotal();

            }
            catch
            {
            }
        }

        void adjustGrandTotal()
        {
            try
            {
                double grandTotal = 0;
                for (int i = 0; i < this.grdexpenditure.RowCount; i++)
                {
                    double subTotal = 0.00;
                    double.TryParse(this.grdexpenditure.Rows[i].Cells["amount"].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
                this.txtTotal.Text = grandTotal.ToString("00");
            }
            catch
            {
                //this.txtGrandTotal.Text = "00";
            }
        }

    }
}
