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


namespace NewHIMS.Forms.Accounts
{
    public partial class FrmOtherItemReceive : BaseForm.FrmBase
    {
        public FrmOtherItemReceive()
        {
            InitializeComponent();
        }

        private void FrmOtherItemReceive_Load(object sender, EventArgs e)
        {
            GetLoad();

        }
        void GetLoad()
        {
            try
            {
                OtherItemReceiveBLL otherItemReceiveBLL = new OtherItemReceiveBLL();
                DataSet ds = otherItemReceiveBLL.OtherItemReceiveLoad();
                txtTotal.Text = "";
                grdOtherItem.Rows.Clear();
                txtCharge.Text = "";
                txtQty.Text = "";
                grdOtherItemStock.Rows.Clear();
                btnSave.Enabled = true;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbOtherItem.DataSource = ds.Tables[0];
                    cmbOtherItem.ValueMember = "other_item_id";
                    cmbOtherItem.DisplayMember = "other_item";
                    cmbOtherItem.SelectedIndex = -1;
                    cmbOtherItem.Text = "<Select>";

                    for (int i = 0; i <ds.Tables[0].Rows.Count; i++)
                    {
                        grdOtherItemStock.Rows.Add();
                        grdOtherItemStock.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0];
                        grdOtherItemStock.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1];
                        grdOtherItemStock.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2];
                    }
                }
   
            }
            catch
            {
            }
        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GetLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                grdOtherItem.Rows.Add();
                grdOtherItem.Rows[grdOtherItem.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(cmbOtherItem.SelectedValue);
                grdOtherItem.Rows[grdOtherItem.Rows.Count - 1].Cells[1].Value = cmbOtherItem.Text;
                grdOtherItem.Rows[grdOtherItem.Rows.Count - 1].Cells[2].Value = txtQty.Text;
                grdOtherItem.Rows[grdOtherItem.Rows.Count - 1].Cells[3].Value = txtCharge.Text;
                grdOtherItem.Rows[grdOtherItem.Rows.Count - 1].Cells[4].Value = Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtCharge.Text);
                CalculateTotal();
            }
            catch
            {
            }
         
        }
        void CalculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < grdOtherItem.Rows.Count; i++)
            {
                total = total +Convert.ToDecimal(grdOtherItem.Rows[i].Cells[4].Value);

            }
            txtTotal.Text = total.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OtherItemReceive otherItemReceive = new OtherItemReceive();
                List<OtherItemReceiveDetails> ListOtherItemReceiveDetails = new List<OtherItemReceiveDetails>();
                List<OtherItem> ListOtherItem= new List<OtherItem>();
                
                OtherItemReceiveBLL otherItemReceiveBLL = new OtherItemReceiveBLL();

                otherItemReceive.purchase_date = Convert.ToDateTime(dtpdate.Value);
                otherItemReceive.total_amount = Convert.ToDecimal(txtTotal.Text);
                otherItemReceive.record_created_by = ApplicatinLauncher._userId;

                for (int i = 0; i < grdOtherItem.Rows.Count; i++)
                {
                    OtherItemReceiveDetails otherItemReceiveDetails = new OtherItemReceiveDetails();
                    otherItemReceiveDetails.other_item_id = Convert.ToInt32(grdOtherItem.Rows[i].Cells[0].Value);
                    otherItemReceiveDetails.qty = Convert.ToInt32(grdOtherItem.Rows[i].Cells[2].Value);
                    otherItemReceiveDetails.unit_price = Convert.ToDecimal(grdOtherItem.Rows[i].Cells[3].Value);
                    otherItemReceiveDetails.record_created_by =ApplicatinLauncher._userId;
                    ListOtherItemReceiveDetails.Add(otherItemReceiveDetails);

                    OtherItem otherItem = new OtherItem();
                    otherItem.other_item_id = Convert.ToInt32(grdOtherItem.Rows[i].Cells[0].Value);
                    otherItem.stock = Convert.ToInt32(grdOtherItem.Rows[i].Cells[2].Value);
                    ListOtherItem.Add(otherItem);
                }
                int result = otherItemReceiveBLL.OtherItemReceiveAdd(otherItemReceive, ListOtherItemReceiveDetails, ListOtherItem);
                if (result > 0)
                {
                    MessageBox.Show("Data Saved Succssfully");
                    btnSave.Enabled = false;
                }
            }
            catch
            {
            }
        }
    }
}
