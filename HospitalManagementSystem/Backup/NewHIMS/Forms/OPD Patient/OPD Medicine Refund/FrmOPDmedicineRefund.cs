using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund;

namespace NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund
{
    public partial class FrmOPDmedicineRefund : BaseForm.FrmBase
    {

        //private bool noNeedToContinue = true ;
        private int PKID = 0;
        public FrmOPDmedicineRefund()
        {
            InitializeComponent();

        }

        private void FillUpListview(ListView lvw, DataSet ds)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[0].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }

        public void opdSales(int opdadmissionID)
        {
            try
            {
                this.PKID = opdadmissionID;
                OPDSalesRefundBLL opdSalesRefundBLL = new OPDSalesRefundBLL();
                DataSet ds = opdSalesRefundBLL.opdgetmedicinerefund(PKID);
                grdSalesRefund.Rows.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lvwPatientInfo.Items.Clear();
                    FillUpListview(lvwPatientInfo, ds);
                }
            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    OPDSalesRefundBLL opdSalesRefundBLL = new OPDSalesRefundBLL();
                    DataSet ds = opdSalesRefundBLL.getopdsales(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                    grdSalesRefund.Rows.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        this.grdSalesRefund.CellValueChanged -= this.grdSalesRefund_CellValueChanged;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdSalesRefund.Rows.Add();
                            grdSalesRefund.Rows[i].Cells["product_id"].Value = ds.Tables[0].Rows[i][0].ToString();
                            grdSalesRefund.Rows[i].Cells["product"].Value = ds.Tables[0].Rows[i][1].ToString();
                            grdSalesRefund.Rows[i].Cells["sales_qty"].Value = ds.Tables[0].Rows[i][2].ToString();
                            grdSalesRefund.Rows[i].Cells["previousrefund"].Value = ds.Tables[0].Rows[i][3].ToString();
                            grdSalesRefund.Rows[i].Cells["unit_price"].Value = ds.Tables[0].Rows[i][4].ToString();//
                            //grdSalesRefund.Rows[i].Cells["refund_qty"].Value = null;
                            //MessageBox.Show(" "+(grdSalesRefund.Rows[i].Cells["refund_qty"].Value));
                        }
                        this.grdSalesRefund.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSalesRefund_CellValueChanged);
                        btnSave.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Select Item From The List");
            }
            catch
            {
            }
        }

        private void grdSalesRefund_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //if (this.noNeedToContinue == true)
            //{

            //    this.noNeedToContinue = false;
            //    return;
            //}
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex != 4)
                return;
            string msg = "";
            DataGridViewRow row = null;
            row =this.grdSalesRefund.Rows[e.RowIndex];
            //if(row.Cells["refund_qty"].Value!="" ||row.Cells["refund_qty"].Value!=null)

            try
            {

                string valuestr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valunumaric = 0;
                double.TryParse(valuestr, out valunumaric);

                if (e.ColumnIndex == 4)
                {
                    int qty = 0;
                    int alreadyrefund = 0;
                    int refundqty = 0;

                   
                    int.TryParse(row.Cells["sales_qty"].Value.ToString(), out qty);
                    int.TryParse(row.Cells["previousrefund"].Value.ToString(), out alreadyrefund);
                    if(valuestr.ToString()!="")
                    int.TryParse(row.Cells["refund_qty"].Value.ToString(), out refundqty);

                    if (valunumaric <= 0)
                    {
                        msg = "Please provide a valid refund quantity";
                    }
                    else if (refundqty > (qty - alreadyrefund))
                    {
                        MessageBox.Show("Invalid refund quantity.", "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.Cells["refund_qty"].Value = null;
                        refundqty = 0;
                    }

                }
            }
            catch
            {
                //row.Cells["refund_qty"].Value = null;
                MessageBox.Show(msg, "HIMS");
            }
            finally
            {
                if (msg != "")
                {
                    MessageBox.Show(msg, "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.grdSalesRefund.CellValueChanged -= this.grdSalesRefund_CellValueChanged;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                    this.grdSalesRefund.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSalesRefund_CellValueChanged);

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdSalesRefund.Rows.Count == 0)
                    return;
                if (MessageBox.Show("Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                int result = 0;
                OPdSalesRefund opdSalesRefund = new OPdSalesRefund();
                OPDSalesRefundBLL opdSalesRefundBLL = new OPDSalesRefundBLL();
                List<OPDSalesRefundProduct> listopdSalesRefundProduct = new List<OPDSalesRefundProduct>();

                opdSalesRefund.PKID = PKID;
                opdSalesRefund.opd_sales_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);
                opdSalesRefund.refund_by = ApplicatinLauncher._userId;
                for (int i = 0; i < grdSalesRefund.Rows.Count; i++)
                {
                    if (grdSalesRefund.Rows[i].Cells["refund_qty"].Value!=null)// ||(Convert.ToInt32(grdSalesRefund.Rows[i].Cells[4].Value)!=0))
                    {
                        OPDSalesRefundProduct opdSalesRefundProduct = new OPDSalesRefundProduct();
                        opdSalesRefundProduct.product_id = Convert.ToInt32(grdSalesRefund.Rows[i].Cells["product_id"].Value);
                        opdSalesRefundProduct.refund_qty = Convert.ToInt32(grdSalesRefund.Rows[i].Cells["refund_qty"].Value);
                        opdSalesRefundProduct.unit_price = Convert.ToDecimal(grdSalesRefund.Rows[i].Cells["unit_price"].Value);
                        opdSalesRefundProduct.record_created_by = ApplicatinLauncher._userId;
                        listopdSalesRefundProduct.Add(opdSalesRefundProduct);
                        opdSalesRefundProduct = null;
                    }
                }
                if(listopdSalesRefundProduct.Count>0)
                result = opdSalesRefundBLL.OPDmedicinerefund(opdSalesRefund, listopdSalesRefundProduct);
                if (result > 0)
                {
                    MessageBox.Show("Data Saved successfully");
                    btnSave.Enabled = false;
                    grdSalesRefund.Rows.Clear();
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
              opdSales(PKID);
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