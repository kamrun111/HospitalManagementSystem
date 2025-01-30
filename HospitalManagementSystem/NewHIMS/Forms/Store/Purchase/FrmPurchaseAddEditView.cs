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
using NewHIMS.Reports.Purchase;

namespace NewHIMS.Forms.Store
{
    public partial class FrmPurchaseAddEditView : BaseForm.FrmBase
    {
        private bool noNeedToContinue = true;
        //int SupplierID;
        int purchaseID;
        int RpurchaseID;
        //bool cont = true;
        public FrmPurchaseAddEditView()
        {
            InitializeComponent();
        }

        private void FrmPurchaseAddEditView_Load(object sender, EventArgs e)
        {
            //RefreshPurchase();
            try
            {

                lblProductType.Enabled = true;
                cmbProductType.Enabled = true;
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                DataSet dstype = requisitionBLL.GetProductType();
                this.cmbProductType.SelectedIndexChanged -= this.cmbProductType_SelectedIndexChanged;
                PopulateComboBox(cmbProductType, dstype, 0, "product_type", "product_type_id");
                cmbSupplier.DataSource = null;
                cmbProductCategory.DataSource = null;
                cmbProduct.DataSource = null;
                grdPurchaseList.Rows.Clear();
                this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);

                //this.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
                if (ApplicatinLauncher._GroupName == "General Store")
                {
                    cmbProductType.SelectedIndex = 0;
                    cmbProductType.Enabled = false;
                }
                else if (ApplicatinLauncher._GroupName == "Pharmacy")
                {
                    cmbProductType.SelectedIndex = 1;
                    cmbProductType.Enabled = false;
                }
                else if (ApplicatinLauncher._GroupName == "Reagent")
                {
                    cmbProductType.SelectedIndex = 2;
                    cmbProductType.Enabled = false;
                }
            }

            catch
            {
            }
        }

        void RefreshPurchase()
        {
            PurchaseBO purchase = new PurchaseBO();
            PurchaseBLL purchaseBLL = new PurchaseBLL();
            DataSet ds = purchaseBLL.GetSupplierName(Convert.ToInt32(cmbProductType.SelectedValue));
            this.cmbSupplier.SelectedIndexChanged -= this.cmbSupplier_SelectedIndexChanged;
            cmbSupplier.DataSource = ds.Tables[0];
            cmbSupplier.DisplayMember = "supplier_name";
            cmbSupplier.ValueMember = "supplier_id";
            cmbSupplier.Text = "<Select>";
            cmbProductCategory.DataSource = null;
            this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
            cmbProduct.DataSource = null;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            grdPurchaseList.Rows.Clear();
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            //grdPurchaseList.Rows.Clear();
            dtpOrderDate.Value = DateTime.Now;
            //this.SupplierID=Convert.ToInt32(cmbSupplier.SelectedValue);
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
                if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (cmbSupplier.Text == "<Select>")
                {
                    MessageBox.Show("Select supplier");
                    cmbSupplier.Focus();
                    return;
                }
                if (txtIndentNo.Text == "")
                {
                    MessageBox.Show("Please Input the Indent Number");
                    txtIndentNo.Focus();
                    return;
                }


                if (cmbProductType.SelectedIndex != 2)
                {
                    PurchaseBLL purchaseBLL = new PurchaseBLL();
                    PurchaseBO purchaseBO = new PurchaseBO();
                    List<PurchaseProduct> lstPurchaseProduct = new List<PurchaseProduct>();
                    purchaseBO.order_date = Convert.ToDateTime(dtpOrderDate.Text);
                    purchaseBO.indent_no = txtIndentNo.Text;
                    purchaseBO.indent_date = Convert.ToDateTime(dtpIndentDate.Text);
                    if (cmbSupplier.SelectedIndex >= 0)
                    {
                        purchaseBO.supplier_id = Convert.ToInt32(this.cmbSupplier.SelectedValue.ToString());
                    }
                    purchaseBO.is_complete = false;
                    purchaseBO.record_created_by = ApplicatinLauncher._userId;
                                        
                    for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
                    {
                        if (grdPurchaseList.Rows[i].Cells[0].Value != null && grdPurchaseList.Rows[i].Cells[1].Value != null)
                        {
                            PurchaseProduct purchaseProduct = new PurchaseProduct();
                            purchaseProduct.purchase_id = purchaseID;

                            if (grdPurchaseList.Rows[i].Cells[1].Value != null)
                                purchaseProduct.order_qty = Convert.ToInt32(grdPurchaseList.Rows[i].Cells[1].Value);
                            if (grdPurchaseList.Rows[i].Cells[2].Value != null)
                                purchaseProduct.product_id = Convert.ToInt32(grdPurchaseList.Rows[i].Cells[2].Value);
                            purchaseProduct.total_received_qty = 0;
                            purchaseProduct.record_created_by = ApplicatinLauncher._userId;
                            lstPurchaseProduct.Add(purchaseProduct);
                        }
                    }
                    if (cmbProductType.SelectedIndex == 0)
                    {
                        purchaseID = purchaseBLL.PurchaseProductInsert(purchaseBO, lstPurchaseProduct, 0);
                    }
                    else if (cmbProductType.SelectedIndex == 1)
                    {
                        purchaseID = purchaseBLL.PurchaseProductInsert(purchaseBO, lstPurchaseProduct, 1);
                    }
                }
                else
                {
                    ReagentPurchaseBLL reagentPurchaseBLL = new ReagentPurchaseBLL();
                    ReagentPurchase reagentPurchase = new ReagentPurchase();
                    List<ReagentPurchaseProduct> lstReagentPurchaseProduct = new List<ReagentPurchaseProduct>();
                    reagentPurchase.order_date = Convert.ToDateTime(dtpOrderDate.Text);
                    if (cmbSupplier.SelectedIndex >= 0)
                    {
                        reagentPurchase.supplier_id = Convert.ToInt32(this.cmbSupplier.SelectedValue.ToString());
                    }
                    reagentPurchase.is_complete = false;
                    reagentPurchase.record_created_by = ApplicatinLauncher._userId;
                    for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
                    {
                        if (grdPurchaseList.Rows[i].Cells[0].Value != null && grdPurchaseList.Rows[i].Cells[1].Value != null)
                        {
                            ReagentPurchaseProduct reagentPurchaseProduct = new ReagentPurchaseProduct();
                            //PurchaseProductBLL purchaseProductBLL = new PurchaseProductBLL();
                            reagentPurchaseProduct.reagent_purchase_id = RpurchaseID;

                            if (grdPurchaseList.Rows[i].Cells[1].Value != null)
                                reagentPurchaseProduct.order_qty = Convert.ToDecimal(grdPurchaseList.Rows[i].Cells[1].Value);
                            if (grdPurchaseList.Rows[i].Cells[2].Value != null)
                                reagentPurchaseProduct.product_id = Convert.ToInt32(grdPurchaseList.Rows[i].Cells[2].Value);
                            reagentPurchaseProduct.total_received_qty = 0;
                            reagentPurchaseProduct.store_id = 0;
                            reagentPurchaseProduct.record_created_by = ApplicatinLauncher._userId;
                            lstReagentPurchaseProduct.Add(reagentPurchaseProduct);
                        }
                    }
                    RpurchaseID = reagentPurchaseBLL.ReagentPurchaseProductInsert(reagentPurchase, lstReagentPurchaseProduct);
                }
                MessageBox.Show("Data Saved Successfully");
                this.btnSave.Enabled = false;
                this.grdPurchaseList.Enabled = false;
                this.cmbSupplier.Enabled = false;
                this.dtpOrderDate.Enabled = false;
                this.button1.Enabled = true;
                grdPurchaseList.Rows.Clear();
                this.PrintpurchaseOrder();

            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbSupplier_SelectedIndexChanged(null, null);
            //RefreshPurchase();
            this.button1.Enabled = false;
            this.btnSave.Enabled = true;
            this.grdPurchaseList.Enabled = true;
            this.cmbSupplier.Enabled = true;
            this.dtpOrderDate.Enabled = true;
            btnDelete.Enabled = false;
            grdMainList.Rows.Clear();
            lblProduct.Enabled = false;
            cmbProduct.SelectedIndex = -1;
            if (grdPurchaseList.Rows.Count > 1)
                button1.Enabled = true;

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdPurchaseList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdPurchaseList.Rows[e.RowIndex];

                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);

                if (e.ColumnIndex == 1)
                {
                    if (valueNumeric <= 0)
                    {
                        msg = "Please provide a valid Order quantity";
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (msg != "")
                {

                    MessageBox.Show(msg, "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = "";
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }
        }
        public void PrintpurchaseOrder()
        {
            try
            {
                if (cmbProductType.SelectedIndex != 2)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new purchaseorder1();
                    // rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@purchaseID", purchaseID);
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new ReagentPurchaseOrder();
                    // rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@RpurchaseID", RpurchaseID);
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                purchaseID = 0;
                RpurchaseID = 0;
            }
            catch
            {
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedIndex >= 0)
                {
                    if (cmbProductType.SelectedIndex != 2)
                    {
                        FrmPurchaseDate frmPurchaseDate = new FrmPurchaseDate(Convert.ToInt32(cmbSupplier.SelectedValue), 0); //0-for other product
                        frmPurchaseDate.MdiParent = this.MdiParent;
                        frmPurchaseDate.Show();
                    }
                    else
                    {
                        FrmPurchaseDate frmPurchaseDate = new FrmPurchaseDate(Convert.ToInt32(cmbSupplier.SelectedValue), 1); //1-for Reagent product
                        frmPurchaseDate.MdiParent = this.MdiParent;
                        frmPurchaseDate.Show();
                    }
                }
                else
                {
                    if (cmbProductType.SelectedIndex != 2)
                    {
                        FrmPurchaseDate frmPurchaseDate = new FrmPurchaseDate(0,0);
                        frmPurchaseDate.MdiParent = this.MdiParent;
                        frmPurchaseDate.Show();
                    }
                    else
                    {
                        FrmPurchaseDate frmPurchaseDate = new FrmPurchaseDate(0,1);
                        frmPurchaseDate.MdiParent = this.MdiParent;
                        frmPurchaseDate.Show();
                    }
                }

            }
            catch
            {
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InventoryBLL inventoryBLL = new InventoryBLL();
                PurchaseBO purchase = new PurchaseBO();
                PurchaseBLL purchaseBLL = new PurchaseBLL();
                DataSet ds = purchaseBLL.GetPurchaseLoad();
                grdMainList.Rows.Clear();
                grdPurchaseList.Rows.Clear();
                if (cmbProductType.SelectedIndex == 0)
                {
                    txtPurchase.Text = ds.Tables[1].Rows[0][0].ToString();
                }
                else if (cmbProductType.SelectedIndex == 1)
                {
                    txtPurchase.Text = ds.Tables[0].Rows[0][0].ToString();

                }
                else if (cmbProductType.SelectedIndex == 2)
                {
                    txtPurchase.Text = ds.Tables[4].Rows[0][0].ToString();

                }
                if (this.cmbProductType.SelectedIndex >= 0 && this.cmbProductType.SelectedIndex < 2)
                {
                    lblProductCategory.Enabled = true;
                    cmbProductCategory.Enabled = true;
                    DataSet dscat = purchaseBLL.CategoryforInventory(Convert.ToInt32(((DataRowView)cmbProductType.SelectedItem).Row[0]));

                    //grdInventory.Rows.Clear();
                    this.cmbProductCategory.SelectedIndexChanged -= this.cmbProductCategory_SelectedIndexChanged;
                    this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
                    PopulateComboBox(cmbProductCategory, dscat, 0, "product_category", "product_category_id");
                    cmbProduct.DataSource = null;
                    //grdPurchaseList.Rows.Clear();
                    this.cmbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cmbProductCategory_SelectedIndexChanged);
                    this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
                    dscat = null;
                }
                //else if (this.cmbProductType.SelectedIndex == 2)
                //{
                //    lblProductCategory.Enabled = true;
                //    cmbProductCategory.Enabled = true;
                //    ReagentPurchaseBLL reagentPurchaseBLL = new ReagentPurchaseBLL();
                //    DataSet dscats = reagentPurchaseBLL.CategoryforReagent();

                //    //grdInventory.Rows.Clear();
                //    this.cmbProductCategory.SelectedIndexChanged -= this.cmbProductCategory_SelectedIndexChanged;
                //    this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
                //    PopulateComboBox(cmbProductCategory, dscats, 0, "product_category", "product_category_id");
                //    cmbProduct.DataSource = null;
                //    //grdPurchaseList.Rows.Clear();
                //    this.cmbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cmbProductCategory_SelectedIndexChanged);
                //    this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
                //    dscats = null;
                //}
            }
            catch
            {
            }
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshPurchase();
                cmbSupplier.Enabled = true;
            }

            catch
            {
            }
        }

        private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductType.SelectedIndex != 2)
                {
                    PurchaseBLL purchaseBLL = new PurchaseBLL();
                    if (cmbProductCategory.SelectedIndex >= 0)
                    {
                        lblProduct.Enabled = true;
                        cmbProduct.Enabled = true;
                        DataSet dsproduct = purchaseBLL.productforpurchase(Convert.ToInt32(cmbProductCategory.SelectedValue)); //ProductlistforSales
                        this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
                        PopulateComboBox(cmbProduct, dsproduct, 0, "product", "product_id");
                        this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
                    }
                }
                else
                {
                    PurchaseBLL purchaseBLL = new PurchaseBLL();
                    if (cmbProductCategory.SelectedIndex >= 0)
                    {
                        lblProduct.Enabled = true;
                        cmbProduct.Enabled = true;
                        DataSet dsproduct = purchaseBLL.productforReagentpurchase(Convert.ToInt32(cmbProductCategory.SelectedValue)); //ProductlistforSales
                        this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
                        PopulateComboBox(cmbProduct, dsproduct, 0, "product", "re_agent_product_id");
                        this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
                    }
                }
            }
            catch
            {
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
                {
                    if (Convert.ToInt32(grdPurchaseList.Rows[i].Cells[2].Value) == Convert.ToInt32(cmbProduct.SelectedValue))
                    {
                        MessageBox.Show("Product Already Exists");
                        return;
                    }
                }
                grdPurchaseList.Rows.Add();
                grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 2].Cells[2].Value = Convert.ToInt32(cmbProduct.SelectedValue);
                grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 2].Cells[0].Value = cmbProduct.Text;
                grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 2].Cells[1].Value = 1;
                btnSave.Enabled = true;
                if (grdPurchaseList.Rows.Count > 1)
                    button1.Enabled = true;
                int count = Convert.ToInt32(grdPurchaseList.Rows.Count);
                txtCount.Text = count.ToString();
                if (grdPurchaseList.Rows.Count > 1)
                    button1.Enabled = true;
            }
            catch
            {
            }

        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                if (cmbProduct.SelectedIndex == -1) MessageBox.Show("Data Not Found");
                //for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
                //{
                //    if (Convert.ToInt32(grdPurchaseList.Rows[i].Cells[2].Value) == Convert.ToInt32(cmbProduct.SelectedValue))
                //    {
                //        MessageBox.Show("Product Already Exists");
                //        return;
                //    }
                //}
                //grdPurchaseList.Rows.Add();
                //grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 2].Cells[2].Value = Convert.ToInt32(cmbProduct.SelectedValue);
                //grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 2].Cells[0].Value = cmbProduct.Text;
                //grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 2].Cells[1].Value = 1;
                //btnSave.Enabled = true;
                //int count=Convert.ToInt32(grdPurchaseList.Rows.Count -1);
                //txtCount.Text = count.ToString();
                //if (grdPurchaseList.Rows.Count > 1)
                //    button1.Enabled = true;
            }
            catch
            {
            }
        }

        private void cmbProductCategory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                if (cmbProductCategory.SelectedIndex == -1) MessageBox.Show("Data Not Found");
            }
            catch
            {
            }
        }

        private void cmbProductType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                if (cmbProductType.SelectedIndex == -1) MessageBox.Show("Data Not Found");
            }
            catch
            {
            }
        }

        private void cmbSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                if (cmbSupplier.SelectedIndex == -1) MessageBox.Show("Data Not Found");
            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Delete?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.btnDelete.Enabled = false;
                    return;

                }
                grdPurchaseList.Rows.Remove(grdPurchaseList.SelectedRows[0]);
                btnDelete.Enabled = false;
                int count = Convert.ToInt32(grdPurchaseList.Rows.Count);
                txtCount.Text = count.ToString();
            }
            catch
            {
            }
        }

        private void grdPurchaseList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void cmbProductCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductCategory.SelectedIndex != -1)
                {
                    RequisitionBLL requisitionBLL = new RequisitionBLL();
                    DataSet da = requisitionBLL.ProductlistforSales(Convert.ToInt32(cmbProductCategory.SelectedValue.ToString()));
                    if (da.Tables[0].Rows.Count > 0)
                    {
                        grdMainList.Rows.Clear();
                        for (int i = 0; i < da.Tables[0].Rows.Count; i++)
                        {
                            grdMainList.Rows.Add();
                            grdMainList.Rows[i].Cells[1].Value = da.Tables[0].Rows[i][0].ToString();
                            grdMainList.Rows[i].Cells[2].Value = da.Tables[0].Rows[i][1].ToString();
                            grdMainList.Rows[i].Cells[3].Value = da.Tables[0].Rows[i][2].ToString();

                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void grdMainList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = null;
            row = this.grdMainList.Rows[e.RowIndex];
            try
            {
                string valueStr = (row.Cells[1].Value.ToString() == null ? "" : row.Cells[1].Value.ToString());

                if (e.ColumnIndex == 0)
                {
                    if (grdMainList.Rows[e.RowIndex].Cells[4].Value == null)
                    {
                        if (IsMatchTest(valueStr) == true)
                        {
                            MessageBox.Show("Item already exists");
                            row.Cells[0].Selected = true;
                            return;
                        }
                        grdPurchaseList.Rows.Add();
                        grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 1].Cells[2].Value = grdMainList.Rows[e.RowIndex].Cells[1].Value;
                        grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 1].Cells[0].Value = grdMainList.Rows[e.RowIndex].Cells[2].Value;
                        grdMainList.Rows[e.RowIndex].Cells[4].Value = "F";
                    }
                    else
                    {
                        if (grdMainList.Rows[e.RowIndex].Cells[4].Value.ToString() == "T")
                        {
                            if (IsMatchTest(valueStr) == true)
                            {
                                MessageBox.Show("Item already exists");
                                row.Cells[0].Selected = true;
                                return;
                            }
                            grdPurchaseList.Rows.Add();
                            grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 1].Cells[2].Value = grdMainList.Rows[e.RowIndex].Cells[1].Value;
                            grdPurchaseList.Rows[grdPurchaseList.Rows.Count - 1].Cells[0].Value = grdMainList.Rows[e.RowIndex].Cells[2].Value;

                            grdMainList.Rows[e.RowIndex].Cells[4].Value = "F";
                        }
                        else
                        {
                            for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(grdMainList.Rows[e.RowIndex].Cells[1].Value) == Convert.ToInt32(grdPurchaseList.Rows[i].Cells[2].Value))
                                {
                                    grdPurchaseList.Rows.Remove(grdPurchaseList.Rows[i]);
                                    grdMainList.Rows[e.RowIndex].Cells[4].Value = "T";
                                    return;

                                }
                            }

                        }
                    }
                }
                int count = Convert.ToInt32(grdPurchaseList.Rows.Count);
                txtCount.Text = count.ToString();
            }
            catch
            {
            }
        }

        Boolean IsMatchTest(string dept)
        {
            for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
            {
                if (grdPurchaseList.Rows[i].Cells[2].Value.ToString() == dept)

                    return true;
            }
            return false;
        }
    }
}
















