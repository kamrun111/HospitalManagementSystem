using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Store;
using NewHIMS.Reports;
using NewHIMS.Reports.Receive;

namespace NewHIMS.Forms.Store
{       //Shampa, 30-10-2008

    public partial class FrmReceiveAddEditView : BaseForm.FrmBase
      {
         
         private bool withoutPurchase = true;
         //private DataSet ds;
         private DataSet dspid=null;
         int receiveID;
         int RreceiveID;
         int k=0;
         public FrmReceiveAddEditView()
          {
            InitializeComponent();
            
          }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.SelectedIndex = -1;
                combo.Text = "<Select>";
            }
            catch
            {
            }
        }
        //public void ProductTypePopulate()
        //{
        //    try
        //    {
        //        RequisitionBLL requisitionBLL = new RequisitionBLL();
        //        DataSet dstype = requisitionBLL.GetProductType();
        //        this.cmbProductType.SelectedIndexChanged -= this.cmbProductType_SelectedIndexChanged;
        //        PopulateComboBox(cmbProductType, dstype, 0, "product_type", "product_type_id");
        //        this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);

        //        if (ApplicatinLauncher._GroupName == "General Store")
        //        {
        //            cmbProductType.SelectedIndex = 0;
        //            cmbProductType.Enabled = false;
        //        }
        //        else if (ApplicatinLauncher._GroupName == "Pharmacy")
        //        {
        //            cmbProductType.SelectedIndex = 1;
        //            cmbProductType.Enabled = false;
        //        }
        //        else if (ApplicatinLauncher._GroupName == "Reagent")
        //        {
        //            cmbProductType.SelectedIndex = 2;
        //            cmbProductType.Enabled = false;
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        public void refreshReceive()
        {
            try
            {
                PurchaseBLL purchaseBLL = new PurchaseBLL();
                DataSet da = purchaseBLL.GetReviewpurchase();
                if (da.Tables[0].Rows.Count > 0)
                    FillUpListview(lvwPurchaseOrder, da, 0);
               
                txtInvoiceNo.Text = "";
                txtTotal.Text = "";
                if (this.grdReceiveList.RowCount > 0)
                {
                    this.txtInvoiceNo.Enabled = true;
                    this.dtpInvoiceDate.Enabled = true;
                    this.dtpReceivedDate.Enabled = true;
                    this.btnSave.Enabled = true;
                    this.btnWithoutPurchase.Enabled = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                //if (cmbProductType.SelectedIndex != 2)
                ////{
                    ReceiveBLL receiveBLL = new ReceiveBLL();
                    List<ReceiveProduct> lstReceiveProduct = new List<ReceiveProduct>();
                    List<PurchaseProduct> lstPurchaseProduct = new List<PurchaseProduct>();
                    List<InventoryBO> lstInventoryBO = new List<InventoryBO>();
                    List<ProductBO> lstProductBO = new List<ProductBO>();

                    ReceiveBO receiveBO = new ReceiveBO();

                    receiveBO.received_date = Convert.ToDateTime(dtpReceivedDate.Text);
                    //if (withoutPurchase == false)
                    //{
                        receiveBO.invoice_date = Convert.ToDateTime(dtpInvoiceDate.Text);
                        if (txtInvoiceNo.Text == "")
                        {
                            MessageBox.Show("Insert Invoice No");
                            txtInvoiceNo.Focus();
                            return;

                        }
                        else
                        {
                            receiveBO.invoice_no = this.txtInvoiceNo.Text;
                        }
                        receiveBO.purchase_id = Convert.ToInt32(lvwPurchaseOrder.SelectedItems[0].Text);
                    receiveBO.record_created_by = ApplicatinLauncher._userId;


                    for (int m = 0; m < grdReceiveList.Rows.Count; m++)
                    {
                        ReceiveProduct receiveProduct = new ReceiveProduct();
                        PurchaseProduct purchaseProduct = new PurchaseProduct();
                        InventoryBO inventoryBO = new InventoryBO();
                        ProductBO productBO = new ProductBO();
                        string s = null;
                        if (grdReceiveList.Rows[m].Cells["exp_date"].Value != null)
                        {
                            string valueStr = grdReceiveList.Rows[m].Cells["exp_date"].Value.ToString();
                            string[] dateParts = valueStr.Trim().Split('-');
                            if (dateParts.Length == 3)
                            {
                                DateTime valueDate = new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[1]), int.Parse(dateParts[0]));
                                s = valueDate.ToString("MM-dd-yyyy");
                            }
                        }
                        if (grdReceiveList.Rows[m].Cells["receive_qty"].Value != null)
                        {
                            if (grdReceiveList.Rows[m].Cells["product_id"].Value != null)
                                receiveProduct.product_id = Convert.ToInt32(grdReceiveList.Rows[m].Cells["product_id"].Value);
                            receiveProduct.receive_qty = Convert.ToInt32(grdReceiveList.Rows[m].Cells["receive_qty"].Value);
                            if (grdReceiveList.Rows[m].Cells["free_qty"].Value != null)
                                receiveProduct.free_qty = Convert.ToInt32(grdReceiveList.Rows[m].Cells["free_qty"].Value);
                            if (grdReceiveList.Rows[m].Cells["unit_purchase_price"].Value != null)
                                receiveProduct.unit_purchase_price = Convert.ToDecimal(grdReceiveList.Rows[m].Cells["unit_purchase_price"].Value);
                            if (grdReceiveList.Rows[m].Cells["unit_cost"].Value != null)
                                receiveProduct.unit_cost = Convert.ToDecimal(grdReceiveList.Rows[m].Cells["unit_cost"].Value);
                            if (grdReceiveList.Rows[m].Cells["batch_no"].Value != null)
                                receiveProduct.batch_no = grdReceiveList.Rows[m].Cells["batch_no"].Value.ToString();
                            if (grdReceiveList.Rows[m].Cells["exp_date"].Value != null)
                                receiveProduct.exp_date = Convert.ToDateTime(s.ToString());
                            if (withoutPurchase == false)
                            {
                                receiveProduct.store_id = 0;
                            }
                            else
                            {
                                receiveProduct.store_id = 1;
                            }
                            receiveProduct.refund_qty = 0;
                            receiveProduct.record_created_by = ApplicatinLauncher._userId;

                            lstReceiveProduct.Add(receiveProduct);

                           
                          
                            purchaseProduct.purchase_product_id = Convert.ToInt32(grdReceiveList.Rows[m].Cells["purchase_product_id"].Value);
                            purchaseProduct.total_received_qty = Convert.ToInt32(grdReceiveList.Rows[m].Cells["total_received_qty"].Value) + Convert.ToInt32(grdReceiveList.Rows[m].Cells["receive_qty"].Value);
                            purchaseProduct.record_modified_by = ApplicatinLauncher._userId; ;

                            lstPurchaseProduct.Add(purchaseProduct);
                  

                            productBO.product_id = Convert.ToInt32(grdReceiveList.Rows[m].Cells["product_id"].Value);
                            productBO.default_sales_price = Convert.ToDecimal(grdReceiveList.Rows[m].Cells["default_sales_price"].Value);
                            productBO.current_stock = Convert.ToInt32(grdReceiveList.Rows[m].Cells["receive_qty"].Value) + Convert.ToInt32(grdReceiveList.Rows[m].Cells["free_qty"].Value);
                            productBO.record_modified_by = ApplicatinLauncher._userId;
                            productBO.unit_purchase_price = Convert.ToDecimal(grdReceiveList.Rows[m].Cells["unit_cost"].Value);


                            lstProductBO.Add(productBO);

                        }
                    }

                    receiveID = receiveBLL.ReceiveProductInsert(receiveBO, lstReceiveProduct, lstPurchaseProduct, lstInventoryBO, lstProductBO);
         
             
                 MessageBox.Show("Data Saved Successfully");
                 this.btnSave.Enabled = false;
                 this.btnPrint.Enabled = true;
                 grdReceiveList.Rows.Clear();
                 refreshReceive();
                 txtInvoiceNo.Text = "";
                 PrintReceive();
                              
            }

            catch
            {
                MessageBox.Show("ERROR");
            }
        }
        void stateCheck()
        {
            try
            {
                if (withoutPurchase == true)
                {
                    txtInvoiceNo.Enabled = false;
                    this.btnWithPurchase.Enabled = true;
                    this.dtpReceivedDate.Enabled = true;
                  
                    grdReceiveList.Rows.Add();
                    grdReceiveList.Rows[0].Cells[3].Value = 0;
                    grdReceiveList.Rows[0].Cells[5].Value = 0;
                    grdReceiveList.Rows[0].Cells[1].ReadOnly = false;
                    grdReceiveList.Rows[0].Cells[2].ReadOnly = false;
                    grdReceiveList.Rows[0].Cells[3].ReadOnly = false;
                   
                    if (grdReceiveList.Rows.Count > 0)
                    {
                        btnSave.Enabled = true;
                    }
                }
                else
                {
                    
                    grdReceiveList.Rows[0].Cells[1].ReadOnly = true;
                    grdReceiveList.Rows[0].Cells[2].ReadOnly = true;
                    grdReceiveList.Rows[0].Cells[3].ReadOnly = true;
                }
            }
            catch
            {
            }
        }
          
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshReceive();
            grdReceiveList.Rows.Clear();
        }
        
        private void grdReceiveList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
           {
            if (e.RowIndex == -1) return;


			string msg = "";
			DataGridViewRow row = null;
                                   
            try
             {
                   row = this.grdReceiveList.Rows[e.RowIndex];
                   string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                   double valueNumeric = 0;
                   double.TryParse(valueStr, out valueNumeric);

                   if (e.ColumnIndex == 4 )
                     {
                             int orderQty = 0;
                             int totalyRecQty = 0;

                             int.TryParse(row.Cells["order_qty"].Value.ToString(), out orderQty);
                             int.TryParse(row.Cells["total_received_qty"].Value.ToString(), out totalyRecQty);
                             if (valueNumeric <= 0)
                             {
                                 msg = "Please provide a valid number";
                             }
                             else if ((totalyRecQty + valueNumeric) > orderQty)
                             {
                                 msg = "Total received quantity is more than ordered quantity.";
                             }
                             this.calculateUnitCost(row);
                             this.adjustGrandTotal();
                     }
                    else if (e.ColumnIndex == 5)
                       {
                           if (!double.TryParse(valueStr, out valueNumeric))
                           {
                               msg = "Please provide a valid free quantity";
                               row.Cells["free_qty"].Value = 0;
                               return;
                           }
                         
                       }
                       else if (e.ColumnIndex == 6 )
                        {
                            if (valueNumeric <= 0)
                            {
                                msg = "Please provide a valid price";
                            }
                           this.calculateUnitCost(row);
                           this.adjustGrandTotal();
                         }
                       else if (e.ColumnIndex == 9)
                         {
                             msg = "Please provide a valid expire date.";
                             string[] dateParts = valueStr.Trim().Split('-');
                             if (dateParts.Length == 3)
                               {
                                 DateTime valueDate = new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[1]), int.Parse(dateParts[0]));
                                 this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;
                                 row.Cells[e.ColumnIndex].Value = valueDate.ToString("dd-MM-yyyy");
                                 msg = "";
                                 this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);
                               }
                          }
            
                          if (e.ColumnIndex == 7)
                          {
                              if (valueNumeric <= 0)
                              {
                                  msg = "Please provide a valid price";
                              }
                            
                              this.calculateUnitCost(row);
                              this.adjustGrandTotal();
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
                           this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;
                           row.Cells[e.ColumnIndex].Value = null;
                           row.Cells[e.ColumnIndex].Selected = true;
                           this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);
                         }
                    }
        }
                 
        private void calculateUnitCost(DataGridViewRow row)
			{
				try
                {
                        int receiveQty = 0;
                        int totalyRecQty = 0;
                        int freeQty = 0;
                        int alreadyreceiveQty = 0;
                        int totalQty = 0;
                        double unitPurchasePrice = 0.00;

                        if (row.Cells["receive_qty"].Value.ToString() != null || row.Cells["receive_qty"].Value.ToString() != "")
                            int.TryParse(row.Cells["receive_qty"].Value.ToString(), out receiveQty);
                        else
                            row.Cells["receive_qty"].Value = 0;
                        int.TryParse(row.Cells["total_received_qty"].Value.ToString(), out alreadyreceiveQty);
                        if (row.Cells["free_qty"].Value.ToString() != null)
                            int.TryParse(row.Cells["free_qty"].Value.ToString(), out freeQty);
                        else
                            row.Cells["free_qty"].Value = 0;

                        if (row.Cells["unit_cost"].Value.ToString() != null || row.Cells["receive_qty"].Value.ToString() != "")
                            double.TryParse(row.Cells["unit_cost"].Value.ToString(), out unitPurchasePrice);
                        else
                            row.Cells["unit_cost"].Value = 0;

                        alreadyreceiveQty = alreadyreceiveQty + receiveQty;
                        totalyRecQty += receiveQty + freeQty;
                        //double price = (unitPurchasePrice / (double)totalyRecQty);
                        double price = (unitPurchasePrice*totalyRecQty);
                        totalQty = receiveQty + freeQty;
                        this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;
                        //row.Cells["unit_cost"].Value = price.ToString("0#.#0");
                        row.Cells["unit_purchase_price"].Value = price.ToString("0#.#0");
                        row.Cells["total_quantity"].Value = totalQty;
                        this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);
                        //adjustGrandTotal();
                        return;
                    //else
                    //{
                    //    double receiveQty = 0;
                    //    double totalyRecQty = 0;
                    //    double freeQty = 0;
                    //    double alreadyreceiveQty = 0;
                    //    double totalQty = 0;
                    //    double unitPurchasePrice = 0.00;

                    //    if (row.Cells["receive_qty"].Value.ToString() != "" ||row.Cells["receive_qty"].Value.ToString()!=null) 
                    //        double.TryParse(row.Cells["receive_qty"].Value.ToString(), out receiveQty);
                    //    else
                    //        row.Cells["receive_qty"].Value = 0;
                    //    double.TryParse(row.Cells["total_received_qty"].Value.ToString(), out alreadyreceiveQty);
                    //    if (row.Cells["free_qty"].Value.ToString() != "")
                    //        double.TryParse(row.Cells["free_qty"].Value.ToString(), out freeQty);
                    //    else
                    //        row.Cells["free_qty"].Value = 0;

                    //    if (row.Cells["unit_purchase_price"].Value.ToString() != "")
                    //        double.TryParse(row.Cells["unit_purchase_price"].Value.ToString(), out unitPurchasePrice);
                    //    else
                    //        row.Cells["unit_purchase_price"].Value = 0;

                    //    alreadyreceiveQty = alreadyreceiveQty + receiveQty;
                    //    totalyRecQty += receiveQty + freeQty;
                    //    double price = (unitPurchasePrice / (double)totalyRecQty);
                    //    totalQty = receiveQty + freeQty;
                    //    this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;
                    //    row.Cells["unit_cost"].Value = price.ToString("0#.#0");
                    //    row.Cells["total_quantity"].Value = totalQty;
                    //    this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);
                    //    //adjustGrandTotal();
                    //    return;
                    //}
			 }
			 catch
               {
			   }
	         row.Cells["unit_cost"].Value = "0.00";
	  }
      void adjustGrandTotal()
      {
            try
            {
               int grandTotal = 0;
               double Total = 0.00;
               this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;
                for (int i = 0; i < this.grdReceiveList.RowCount ; i++)
                {
                    double subTotal = 0.00;
                    if (grdReceiveList.Rows[i].Cells["unit_purchase_price"].Value != null)
                    {
                        double.TryParse(this.grdReceiveList.Rows[i].Cells["unit_purchase_price"].Value.ToString(), out subTotal);
                        Total += (subTotal);
                        grandTotal = Convert.ToInt32(Total);
                    }
                
                }
                this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);

                this.txtTotal.Text = grandTotal.ToString("00");
            }
            catch
            {
                this.txtTotal.Text = "0.00";
            }
      }

      //private void cmbPurchase_SelectedIndexChanged(object sender, EventArgs e)
      //  {
      //      try
      //      {
      //          if (this.cmbPurchase.SelectedIndex>=0)
      //          {
      //              ReceiveProductBLL receiveProductBLL = new ReceiveProductBLL();
      //              DataSet ds = receiveProductBLL.GetReceiveLoad(Convert.ToInt32(cmbPurchase.SelectedValue)); // GetReceiveLoad   

      //              grdReceiveList.Rows.Clear();
      //              if (cmbProductType.SelectedIndex != 2)
      //              {
      //                  if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
      //                  {

      //                      this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;

      //                      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      //                      {
      //                          grdReceiveList.Rows.Add();
      //                          grdReceiveList.Rows[i].Cells["product_id"].Value = ds.Tables[0].Rows[i]["product_id"].ToString();
      //                          grdReceiveList.Rows[i].Cells["product"].Value = ds.Tables[0].Rows[i]["product"].ToString();
      //                          grdReceiveList.Rows[i].Cells["order_qty"].Value = ds.Tables[0].Rows[i]["order_qty"].ToString();
      //                          grdReceiveList.Rows[i].Cells["total_received_qty"].Value = ds.Tables[0].Rows[i]["total_received_qty"].ToString();
      //                          grdReceiveList.Rows[i].Cells["purchase_product_id"].Value = ds.Tables[0].Rows[i]["purchase_product_id"].ToString();
      //                          grdReceiveList.Rows[i].Cells["default_sales_price"].Value = ds.Tables[0].Rows[i]["default_sales_price"].ToString();
      //                          grdReceiveList.Rows[i].Cells["free_qty"].Value = 0;
      //                          grdReceiveList.Rows[i].Cells["unit_cost"].Value = ds.Tables[0].Rows[i]["unit_purchase_price"].ToString();

      //                      }

      //                      this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);

      //                  }
      //              }
      //              else
      //              {
      //                  if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
      //                  {

      //                      this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;

      //                      for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
      //                      {
      //                          grdReceiveList.Rows.Add();
      //                          grdReceiveList.Rows[i].Cells["product_id"].Value = ds.Tables[1].Rows[i]["product_id"].ToString();
      //                          grdReceiveList.Rows[i].Cells["product"].Value = ds.Tables[1].Rows[i]["product"].ToString();
      //                          grdReceiveList.Rows[i].Cells["order_qty"].Value = ds.Tables[1].Rows[i]["order_qty"].ToString();
      //                          grdReceiveList.Rows[i].Cells["total_received_qty"].Value = ds.Tables[1].Rows[i]["total_received_qty"].ToString();
      //                          grdReceiveList.Rows[i].Cells["purchase_product_id"].Value = ds.Tables[1].Rows[i]["reagent_purchase_product_id"].ToString();
      //                          //grdReceiveList.Rows[i].Cells["default_sales_price"].Value = ds.Tables[1].Rows[i]["default_sales_price"].ToString();
      //                          grdReceiveList.Rows[i].Cells["free_qty"].Value = 0.0;
      //                      }

      //                      this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);

      //                  }
      //              }
      //              int Count = Convert.ToInt32(grdReceiveList.Rows.Count);
      //              txtCount.Text = Count.ToString();

      //              if (this.grdReceiveList.RowCount > 0)
      //              {
      //                  this.txtInvoiceNo.Enabled = true;
      //                  this.dtpInvoiceDate.Enabled = true;
      //                  this.dtpReceivedDate.Enabled = true;
      //                  this.btnSave.Enabled = true;
      //              }
      //          }
      //          else
      //          {
      //              this.grdReceiveList.Rows.Clear();
      //              this.txtInvoiceNo.Enabled = false;
      //              this.dtpInvoiceDate.Enabled = false;
      //              this.dtpReceivedDate.Enabled = false;
      //              this.btnSave.Enabled = false;
      //          }
      //      }
      //      catch
      //      {
      //      }
      //  }

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

        private void FrmReceiveAddEditView_Load(object sender, EventArgs e)
        {

            try
            {
                refreshReceive();
                txtInvoiceNo.Text = "";              
            }
            catch
            {
            }
           
        }

        public void PrintReceive()
        {
            try
            {
                    CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                    CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new ReceiveList();
                    //rptCustomersOrders.Load(@"..\..\Reports\Receive\ReceiveList.rpt");

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    pdvCustomerName.Value = receiveID;
                    pvCollection.Add(pdvCustomerName);
                    rptCustomersOrders.DataDefinition.ParameterFields[0].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
               
            
                receiveID = 0;
                RreceiveID = 0;
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReceiveDate frmReceiveDate = new FrmReceiveDate();
                //frmReceiveDate.MdiParent = this.MdiParent;
                frmReceiveDate.ShowDialog();
            }
            catch
            {
            }
        }
 

        private void lvwPurchaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPurchaseOrder.SelectedItems.Count > 0)
                {
                    ReceiveProductBLL receiveProductBLL = new ReceiveProductBLL();
                    DataSet ds = receiveProductBLL.GetReceiveLoad(Convert.ToInt32(lvwPurchaseOrder.SelectedItems[0].Text)); // GetReceiveLoad   

                    grdReceiveList.Rows.Clear();
                    //if (cmbProductType.SelectedIndex != 2)
                    //{
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            this.grdReceiveList.CellValueChanged -= this.grdReceiveList_CellValueChanged;

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                grdReceiveList.Rows.Add();
                                grdReceiveList.Rows[i].Cells["product_id"].Value = ds.Tables[0].Rows[i]["product_id"].ToString();
                                grdReceiveList.Rows[i].Cells["product"].Value = ds.Tables[0].Rows[i]["product"].ToString();
                                grdReceiveList.Rows[i].Cells["order_qty"].Value = ds.Tables[0].Rows[i]["order_qty"].ToString();
                                grdReceiveList.Rows[i].Cells["total_received_qty"].Value = ds.Tables[0].Rows[i]["total_received_qty"].ToString();
                                grdReceiveList.Rows[i].Cells["purchase_product_id"].Value = ds.Tables[0].Rows[i]["purchase_product_id"].ToString();
                                grdReceiveList.Rows[i].Cells["default_sales_price"].Value = ds.Tables[0].Rows[i]["default_sales_price"].ToString();
                                grdReceiveList.Rows[i].Cells["free_qty"].Value = 0;
                                grdReceiveList.Rows[i].Cells["unit_cost"].Value = ds.Tables[0].Rows[i]["unit_purchase_price"].ToString();

                            }

                            this.grdReceiveList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceiveList_CellValueChanged);

                        }

                    int Count = Convert.ToInt32(grdReceiveList.Rows.Count);
                    txtCount.Text = Count.ToString();

                    if (this.grdReceiveList.RowCount > 0)
                    {
                        this.txtInvoiceNo.Enabled = true;
                        this.dtpInvoiceDate.Enabled = true;
                        this.dtpReceivedDate.Enabled = true;
                        this.btnSave.Enabled = true;
                    }
                }
                else
                {
                    this.grdReceiveList.Rows.Clear();
                    this.txtInvoiceNo.Enabled = false;
                    this.dtpInvoiceDate.Enabled = false;
                    this.dtpReceivedDate.Enabled = false;
                    this.btnSave.Enabled = false;
                }
            }
            catch
            {
            }
        }

           
        }
    }
