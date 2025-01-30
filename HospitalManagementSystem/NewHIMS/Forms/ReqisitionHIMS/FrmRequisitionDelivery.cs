using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports;
using NewHIMS.Reports.Requisition;
using NewHIMS.Forms.ReqisitionHIMS;
using CrystalDecisions.CrystalReports.Engine;

namespace NewHIMS.Forms.ReqisitionHIMS
{
    public partial class FrmRequisitionDelivery : BaseForm.FrmBase
    {
        private bool noNeedToContinue = true;
        private int RequitionID = 0;
        public FrmRequisitionDelivery()
        {
            InitializeComponent();
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
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error3");
            }
        }

        private void FillUpListview2(ListView lvw, DataSet ds, int tableIndex)
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
                        lvi.SubItems.Add("N/R");
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error3");
            }
        }
        void RefreshRequisitionProduct()
        {
            try
            {
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                DataSet dstype = requisitionBLL.GetProductType();
                this.cmbProductType.SelectedIndexChanged -= this.cmbProductType_SelectedIndexChanged;
                grdRequisitionDelivery.Rows.Clear();
                PopulateComboBox(cmbProductType, dstype, 0, "product_type", "product_type_id");
                this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            }
            catch
            {
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

        private void FrmRequisitionDelivery_Load(object sender, EventArgs e)
        {
            try
            {
                this.grdRequisitionDelivery.CellValueChanged -= this.grdRequisitionDelivery_CellValueChanged;
                RefreshRequisitionProduct();
                cmbProductType.SelectedIndex = 0;
                cmbProductType.Enabled = false;
                ListViewPopulate();
                this.grdRequisitionDelivery.CellValueChanged += new DataGridViewCellEventHandler(grdRequisitionDelivery_CellValueChanged);
            }
            catch
            {
            }
        }




        void calculateLeftInHand(DataGridViewRow row)
        {
            try
            {
                int orderQty = 0;
                int receiveQty = 0;
                if (row.Cells["order_qty"].Value != null)
                    int.TryParse(row.Cells["order_qty"].Value.ToString(), out orderQty);
                if (row.Cells["pre_delivery"].Value != null)
                    int.TryParse(row.Cells["pre_delivery"].Value.ToString(), out receiveQty);
                double price = (orderQty - receiveQty);
                this.noNeedToContinue = true;
                row.Cells["derived"].Value = price.ToString();
                return;
            }
            catch
            {
            }
        }
        public void PopulateGrid()
        {
            try
            {
                //this.grdRequisitionDelivery.CellValueChanged -= this.grdRequisitionDelivery_CellValueChanged;
                RequisitionProduct requisitionProduct = new RequisitionProduct();
                RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();
                grdRequisitionDelivery.Rows.Clear();
                DataSet ds = requisitionProductBLL.GetrequisitionproductsForDelivery(Convert.ToInt32(lvwRequisitionDeliveryinfo.SelectedItems[0].SubItems[2].Text));

                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    txtIndentby.Text = lvwRequisitionDeliveryinfo.SelectedItems[0].SubItems[3].Text.ToString();
                    this.noNeedToContinue = true;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {


                        grdRequisitionDelivery.Rows.Add();
                        grdRequisitionDelivery.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][5].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i][6].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][3].ToString();//order qty
                        //this.grdRequisitionDelivery.CellValueChanged += new DataGridViewCellEventHandler(grdRequisitionDelivery_CellValueChanged);

                        grdRequisitionDelivery.Rows[i].Cells["delivery_qty"].Value = ds.Tables[0].Rows[i][3].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][4].ToString();
                        grdRequisitionDelivery.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i][7].ToString();

                        //grdRequisitionDelivery.Rows[i].Cells[6].Value = 0;

                    }
                    this.noNeedToContinue = false;
                }
                //this.grdRequisitionDelivery.CellValueChanged += new DataGridViewCellEventHandler(grdRequisitionDelivery_CellValueChanged);
            }
            catch
            {
            }
        }
        private void lvwRequisitionDeliveryinfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwRequisitionDeliveryinfo.SelectedItems.Count > 0)
                {
                    PopulateGrid();
                }
            }
            catch
            {


            }
        }

        private void grdRequisitionDelivery_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.noNeedToContinue == true)
            {

                this.noNeedToContinue = false;
                return;
            }

            string msg = "";
            DataGridViewRow row = null;
            try
            {
                row = this.grdRequisitionDelivery.Rows[e.RowIndex];



                this.calculateLeftInHand(grdRequisitionDelivery.Rows[e.RowIndex]);

                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 7)
                {

                    int pendingQty = 0;
                    int deliveryQty = 0;
                    int stock = 0;

                    int.TryParse(row.Cells["derived"].Value.ToString(), out pendingQty);
                    int.TryParse(row.Cells["delivery_qty"].Value.ToString(), out deliveryQty);
                    int.TryParse(row.Cells["current_stock"].Value.ToString(), out stock);


                    if (valueNumeric <= 0)
                    {
                        MessageBox.Show("Please provide a valid delivery quantity");
                        row.Cells["delivery_qty"].Value = 0;
                        //msg = "Please provide a valid delivery quantity";
                    }
                    else if (deliveryQty > stock)
                    {
                        MessageBox.Show("Delivery quantity is more than the current stock");
                        //msg = "Delivery quantity is more than the current stock";
                        row.Cells["delivery_qty"].Value = 0;

                    }
                    else if (deliveryQty > pendingQty)

                        msg = "Delivery quantity is more than peding quantity.";
                }

            }
            catch
            {
            }
            finally
            {

                if (msg != "")
                {

                    MessageBox.Show(msg, "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdRequisitionDelivery.Rows.Count == 0)
                    return;

                if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                int Result = 0;
                if (lvwRequisitionDeliveryinfo.SelectedItems.Count > 0)
                {

                    List<RequisitionProduct> lstrequisitionProduct = new List<RequisitionProduct>();
                    List<ProductBO> lstproductBO = new List<ProductBO>();
                    RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();

                    Requisition requisition = new Requisition();
                    requisition.requisition_id = Convert.ToInt32(lvwRequisitionDeliveryinfo.SelectedItems[0].SubItems[2].Text);
                    RequitionID = Convert.ToInt32(lvwRequisitionDeliveryinfo.SelectedItems[0].SubItems[2].Text);
                    requisition.record_modified_by = ApplicatinLauncher._userId;
                    requisition.store_id = 2;
                    for (int i = 0; i < grdRequisitionDelivery.Rows.Count; i++)
                    {
                        if (grdRequisitionDelivery.Rows[i].Cells[7].Value != "")
                        {
                            ProductBO productBO = new ProductBO();
                            RequisitionProduct requisitionProduct = new RequisitionProduct();
                            requisitionProduct.requisition_product_id = Convert.ToInt32(grdRequisitionDelivery.Rows[i].Cells[0].Value);
                            requisitionProduct.delivery_qty = Convert.ToInt32(grdRequisitionDelivery.Rows[i].Cells[7].Value) + Convert.ToInt32(grdRequisitionDelivery.Rows[i].Cells[8].Value);
                            requisitionProduct.unit_price = Convert.ToDecimal(grdRequisitionDelivery.Rows[i].Cells[10].Value);
                            lstrequisitionProduct.Add(requisitionProduct);

                            productBO.product_id = Convert.ToInt32(grdRequisitionDelivery.Rows[i].Cells[2].Value);
                            productBO.current_stock = -Convert.ToInt32(grdRequisitionDelivery.Rows[i].Cells[7].Value);
                            lstproductBO.Add(productBO);
                        }

                    }
                    Result = requisitionProductBLL.requisitionListUpdate(requisition, lstrequisitionProduct, lstproductBO);
                    if (Result > 0)
                    {
                        MessageBox.Show("Data Saved successfully");
                        btnSave.Enabled = false;
                        grdRequisitionDelivery.Enabled = false;
                        lvwRequisitionDeliveryinfo.Enabled = false;
                        grdRequisitionDelivery.Rows.Clear();
                        refresh();
                        printrequisition(RequitionID);
                    }

                }
                else
                    MessageBox.Show("You can't save");
                return;


            }
            catch
            {
                MessageBox.Show("Data Saved Failed");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {
            ListViewPopulate();
            grdRequisitionDelivery.Rows.Clear();
            btnSave.Enabled = true;
            grdRequisitionDelivery.Enabled = true;
            lvwRequisitionDeliveryinfo.Enabled = true;
            grdRequisitionDelivery.Rows.Clear();
            txtIndentby.Text = "";
        }

        public void ListViewPopulate()
        {
            try
            {
                RequisitionProduct requisitionProduct = new RequisitionProduct();
                RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();
                DataSet ds = requisitionProductBLL.GetrequisitionproductDelivery();
                lvwRequisitionDeliveryinfo.Items.Clear();
                if (cmbProductType.SelectedIndex == 0)
                {
                    FillUpListview(lvwRequisitionDeliveryinfo, ds, 0);
                    FillUpListview2(lvwNotReceived, ds, 2);
                }
                else if (cmbProductType.SelectedIndex == 1)
                {
                    FillUpListview(lvwRequisitionDeliveryinfo, ds, 1);
                    FillUpListview2(lvwNotReceived, ds, 3);
                }

            }
            catch
            {
            }
        }
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwNotReceived_Click(object sender, EventArgs e)
        {

        }

        public void printrequisition(int ID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptrequisitionDelivery();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                //DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                rptCustomersOrders.SetParameterValue("@requisition", ID);


                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmRequisitionPrint frmRequisitionPrint = new FrmRequisitionPrint();
            frmRequisitionPrint.Show();
        }



    }



}

 
       
    

