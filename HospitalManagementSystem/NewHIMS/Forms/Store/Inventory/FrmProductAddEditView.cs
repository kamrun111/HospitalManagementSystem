using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Store
{
    //Shampa, 20-10-2009
    public partial class FrmProductAddEditView : BaseForm.FrmBase
    {
        string productID;
        string productCategory;
        string productType;
        string productUnit;
        string productPrice;
        string mode;
        string ReOrderLevel;
        string SLNo;

        public FrmProductAddEditView(string mode, string productID, string productCategory, string productType, string productUnit,string productPrice, string ReOrderLevel, string SLNo)   //mode-> add or update
        {
            InitializeComponent();
            this.productID = productID;
            this.productCategory = productCategory;
            this.productType = productType;
            this.productUnit = productUnit;
            this.productPrice = productPrice;
            this.SLNo = SLNo;
            this.ReOrderLevel = ReOrderLevel;
            btnSave.Text = mode;
            RefreshProduct();

         }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.Text = "<Select>";
            if (combo.SelectedIndex > 0)
                combo.SelectedIndex = 0;
        }

        void ShowProduct() 
        {
            try
            {
                ProductBLL proBLL = new ProductBLL();
                ProductBO proBO = proBLL.Getproduct(Convert.ToInt32(this.productID));

                txtProduct.Text = proBO.product.ToString();
                txtGenericName.Text = proBO.generic_name.ToString();
                cmbProductCategory.SelectedIndex = cmbProductCategory.FindString(this.productCategory);
                cmbProductType.SelectedIndex = cmbProductType.FindString(this.productType);
                cmbUnit.SelectedIndex = cmbUnit.FindString(this.productUnit);
                txtDefaultSalesPrice.Text = proBO.default_sales_price.ToString();
                txtSLNo.Text = proBO.consider_level.ToString();
                txtReorderLevel.Text = proBO.re_order_level.ToString();
            }
            catch
            {
            }
        }
        
        void RefreshProduct() 
        {
            try
            {

                ProductBLL productBLL = new ProductBLL();
                DataSet ds = productBLL.GetProductPopulationInfo();
                PopulateComboBox(cmbProductType, ds, 1, "product_type", "product_type_id");
                if (productType == "Drugs")
                {
                    PopulateComboBox(cmbProductType, ds, 1, "product_type", "product_type_id");
                    cmbProductType.SelectedIndex = 0;
                    cmbProductType.SelectedText = productType.ToString();
                }
                else if (productType == "General")
                {
                    cmbProductType.SelectedIndex = 1;
                    cmbProductType.SelectedText = productType.ToString();
                }
                else if (productType == "Reagent")
                {
                    cmbProductType.SelectedIndex = 2;
                    cmbProductType.SelectedText = productType.ToString();
                }
                InventoryBLL inventoryBLL = new InventoryBLL();
                DataSet dscat = inventoryBLL.CategoryforInventory(Convert.ToInt32(cmbProductType.SelectedValue));
                PopulateComboBox(cmbProductCategory, dscat, 0, "product_category", "product_category_id");
                PopulateComboBox(cmbUnit, ds, 2, "unit", "unit_id");

                txtProduct.Text = "";
                txtGenericName.Text = "";
                txtDefaultSalesPrice.Text = "";
                txtReorderLevel.Text = "";
                txtSLNo.Text = "";
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
            RefreshProduct();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Save?","HMS",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }
            
            ProductBO productBO = new ProductBO();
            ProductBLL productBLL = new ProductBLL();
            try
            {
                productBO.product = txtProduct.Text.ToString();
                productBO.generic_name = txtGenericName.Text.ToString();
                if (txtSLNo.Text == "")
                {
                    return;
                    
                }
                else
                    productBO.consider_level = Convert.ToInt32(txtSLNo.Text);

                if (cmbProductCategory.SelectedIndex >= 0)
                    productBO.product_category_id = Convert.ToInt32(cmbProductCategory.SelectedValue);

                if (cmbProductType.SelectedIndex >= 0)
                    productBO.product_type_id = Convert.ToInt32(cmbProductType.SelectedValue);

                if (cmbUnit.SelectedIndex >= 0)
                    productBO.unit_id = Convert.ToInt32(cmbUnit.SelectedValue);

                if (txtDefaultSalesPrice.Text != "")
                    productBO.default_sales_price = Convert.ToDecimal(txtDefaultSalesPrice.Text.ToString());
                else
                    productBO.default_sales_price = 0;
                if (txtReorderLevel.Text != "")
                    productBO.re_order_level = Convert.ToInt32(txtReorderLevel.Text);
                else
                    productBO.re_order_level = 0;

            if (btnSave.Text == "Save")
            {
                productBO.record_created_by = ApplicatinLauncher._userId;
                int result = productBLL.Addproduct(productBO);

                if (result > 0)
                    MessageBox.Show("Data Saved Successfully");
                else
                    MessageBox.Show("Data Save Failed");
            }

            else if (btnSave.Text == "Update")
            {
                productBO.product_id = Convert.ToInt32(this.productID);
                productBO.record_modified_by = ApplicatinLauncher._userId;
                int result = productBLL.UpdateProducts(productBO);

                if (result > 0)
                    MessageBox.Show("Data Updated Successfully");
                else
                    MessageBox.Show("Data Update Failed");

            }
            btnSave.Enabled = false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            this.Enabled = true;
            this.Cursor = Cursors.Default;

        }
        }
        private void FrmProductAddEditView_Load(object sender, EventArgs e)
        {
            RefreshProduct();
            if(this.productID!=null)
                ShowProduct();
        }

        private void txtDefaultSalesPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
            btnSave.Enabled = true;
        }

        private void NumCheck(KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
    }
}