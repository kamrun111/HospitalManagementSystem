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
using NewHIMS.Reports.Inventory;

namespace NewHIMS.Forms.Store
{
    public partial class FrmProductListView : BaseForm.FrmBase
    {   //Shampa, 25-10-2008
        
        public FrmProductListView()
        {
            InitializeComponent();

        }

        private void FillUpListview(ListView lvw, DataSet ds)
        {
            try
            {
                lvw.Items.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[0].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow["product_id"].ToString());
                        //for (int j = 1; j < lvw.Columns.Count; j++)
                        //{
                        //lvi.SubItems.Add(dataRow[].ToString());
                        lvi.SubItems.Add(dataRow["product_category"].ToString());
                        lvi.SubItems.Add(dataRow["product"].ToString());
                        lvi.SubItems.Add(dataRow["generic_name"].ToString());
                        lvi.SubItems.Add(dataRow["current_stock"].ToString());
                        lvi.SubItems.Add(dataRow["default_sales_price"].ToString());
                        lvi.SubItems.Add(dataRow["product_type"].ToString());
                        lvi.SubItems.Add(dataRow["unit"].ToString());
                        lvi.SubItems.Add(dataRow["re_order_level"].ToString());
                        lvi.SubItems.Add(dataRow["consider_level"].ToString());
                        //}
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
            }
        }
        
        
        void RefreshProduct()
        {
            try
            {
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                DataSet dstype = requisitionBLL.GetProductType();
                ProductBLL productBLL = new ProductBLL();
                DataSet DsCat = productBLL.GetProductCategory();

                this.cmbProductType.SelectedIndexChanged -= this.cmbProductType_SelectedIndexChanged;
                PopulateComboBox(cmbProductType, dstype, 0, "product_type", "product_type_id");
                dstype = null;
                this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
                this.cmbCategory.SelectedIndexChanged -= this.cmbCategory_SelectedIndexChanged;
                PopulateComboBox(cmbCategory, DsCat, 0, "product_category", "product_category_id");
               this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);

                
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //RefreshProduct();
                listView();
                //this.Cursor = Cursors.AppStarting;
                this.Enabled = false;
                this.Enabled = true;
                this.Cursor = Cursors.Default;
                txtProduct.Text = "";
                cmbCategory.Text = "<Select>";
            }
            catch
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Delete?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                ProductBLL productBLL = new ProductBLL();
                int Remproduct = Convert.ToInt32(lvwProduct.FocusedItem.Text);
                productBLL.Removeproduct(Remproduct);
                MessageBox.Show(" data deleted successfully", "HMS");
                //RefreshProduct();
                cmbProductType.SelectedIndex = cmbProductType.SelectedIndex;
                listView();
            }
            catch
            {
            }
        }


       

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProductAddEditView addEditForm = new FrmProductAddEditView("Save", null, null, lvwProduct.Items[0].SubItems[6].Text.ToString(), null, null,null,null);
                addEditForm.MdiParent = this.MdiParent;
                addEditForm.Show();
            }
            catch
            {
            }
            
        }

        private void FrmProductListView_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshProduct();
                if (ApplicatinLauncher._GroupName != "Administrator" )
                {
                    //btnEdit.Visible = true;
                    btnRemove.Visible = false;
                    //btnPrint.Visible = false;
                }
                if (ApplicatinLauncher._GroupName == "General Store")
                {
                    cmbProductType.SelectedIndex = 0;
                    cmbProductType.Enabled = false;
                    lblProductType.Enabled = false;
                    //lvwProduct.Columns[3].Width = 0;
                }
                else if (ApplicatinLauncher._GroupName == "Pharmacy")
                {
                    cmbProductType.SelectedIndex = 1;
                    cmbProductType.Enabled = false;
                    lblProductType.Enabled = false;
                }
                //allproduct();
            }
            catch
            {
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwProduct.SelectedItems.Count > 0)
                {
                    FrmProductAddEditView addEditForm = new FrmProductAddEditView("Update", lvwProduct.SelectedItems[0].SubItems[0].Text.ToString(), lvwProduct.SelectedItems[0].SubItems[1].Text.ToString(), lvwProduct.SelectedItems[0].SubItems[6].Text.ToString(), lvwProduct.SelectedItems[0].SubItems[7].Text.ToString(),lvwProduct.SelectedItems[0].SubItems[5].Text.ToString(),lvwProduct.SelectedItems[0].SubItems[8].Text.ToString(),lvwProduct.SelectedItems[0].SubItems[9].Text.ToString());
                    addEditForm.MdiParent = this.MdiParent;
                    addEditForm.Show();
                }
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwProduct.SelectedItems.Count > 0)
                {
                    PrintData(Convert.ToInt32(lvwProduct.FocusedItem.Text));
                }
                else
                {
                    PrintProductList();
                }
            }
            catch
            {
            }
           
        }
        
        private void PrintProductList()
        {
            try
            {

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ProductView();
                //rptCustomersOrders.Load(@"..\..\Reports\Product\ProductView.rpt");

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@product_typeID", Convert.ToInt32(cmbProductType.SelectedValue));
                //rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }
        
        private void PrintData(int productID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ProductList();
                //rptCustomersOrders.Load(@"..\..\Reports\Product\ProductList.rpt");

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@product_id",productID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        public void listView()
        {
            try
            {
                ProductBLL productBLL = new ProductBLL();
                DataSet ds = productBLL.GetProductList(Convert.ToInt32(cmbProductType.SelectedValue));
                FillUpListview(lvwProduct, ds);
                lblTotalSupplier2.Text = lvwProduct.Items.Count.ToString();
                productBLL = null;
                ds = null;
            }
            catch
            {
            }
        }
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listView();
                if (cmbProductType.SelectedIndex == 0)
                    lvwProduct.Columns[3].Width = 0;
                else
                    lvwProduct.Columns[3].Width = 155;
            }
            catch
            {
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtProduct.Text = "";
                ProductBLL productBLL = new ProductBLL();
                if (rdoAllproduct.Checked == true)
                {

                    if (cmbCategory.SelectedIndex!= -1)
                    {
                        //lblProduct.Enabled = true;
                        //cmbProduct.Enabled = true;
                        //DataSet dsproduct = productBLL.ProductlistforSales(Convert.ToInt32(cmbCategory.SelectedValue.ToString())); //ProductlistforSales
                        ////grdMainList.Rows.Clear();
                        ////this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
                        ////PopulateComboBox(cmbProduct, dsproduct, 0, "product", "product_id");
                        ////this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
                        //cmbProduct.Enabled = true;

                        DataSet dsc = productBLL.ProductListforCategory(Convert.ToInt32(cmbCategory.SelectedValue.ToString()));
                        if (dsc.Tables[0].Rows.Count > 0)
                        {
                            FillUpListview(lvwProduct, dsc);
                            productBLL = null;
                            dsc = null;
                        }
                    }
                }
                if (rdoReorderlevel.Checked == true)
                {
                    DataSet ds = productBLL.reorderSearchproduct(Convert.ToInt32(cmbCategory.SelectedValue));
                    FillUpListview(lvwProduct, ds);
                    lblTotalSupplier2.Text = lvwProduct.Items.Count.ToString();
                    productBLL = null;
                    ds = null;

                }
            }
            catch
            {
            }
        }
     
        void allproduct()
        {
            try
            {
                cmbProductType.SelectedIndex = cmbProductType.SelectedIndex;
                listView();
                this.Cursor = Cursors.AppStarting;
                this.Enabled = false;
                this.Enabled = true;
                this.Cursor = Cursors.Default;
                lblTotalSupplier2.Text = lvwProduct.Items.Count.ToString();
            }
            catch
            {
            }
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (e.KeyChar == Keys.Enter)
                //{
                if (rdoReorderlevel.Checked == true)
                {
                    ProductBLL productBLL = new ProductBLL();
                    DataSet ds = productBLL.Searchproduct(Convert.ToInt32(cmbCategory.SelectedValue.ToString()), txtProduct.Text);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        FillUpListview(lvwProduct, ds);
                        ds = null;
                    }
                   
                }
                if (rdoAllproduct.Checked == true)
                {
                    ProductBLL productBLL = new ProductBLL();
                    DataSet da = productBLL.AllProductList(Convert.ToInt32(cmbCategory.SelectedValue.ToString()), txtProduct.Text);
                    if (da.Tables[0].Rows.Count > 0)
                    {
                        FillUpListview(lvwProduct, da);
                        da = null;
                    }
                }
              
                //}
            }
            catch
            {
            }
        }

        private void rdoReorderlevel_Click(object sender, EventArgs e)
        {
            try
            {
                txtProduct.Text = "";
                cmbCategory.Text = "<Select>";
                if (cmbProductType.Text != "Select")
                {
                    ProductBLL productBLL = new ProductBLL();
                    DataSet dk = productBLL.reorderproduct(Convert.ToInt32(cmbProductType.SelectedValue.ToString()));
                    if (dk.Tables[0].Rows.Count == 0)
                        MessageBox.Show("No Data Found");
                    else
                    {
                        FillUpListview(lvwProduct, dk);
                        lblTotalSupplier2.Text = lvwProduct.Items.Count.ToString();
                    }
                }
            }
            catch
            {
            }

        }

       

        private void rdoAllproduct_Click(object sender, EventArgs e)
        {
            txtProduct.Text = "";
            cmbCategory.Text = "<Select>";
            allproduct();
            
        }        

        
    }
}