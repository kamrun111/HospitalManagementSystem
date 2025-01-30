using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BusinessObjects;
using HIMS.BLL;

namespace NewHIMS.Forms.Store
{
    public partial class FrmSupplierAddEditView : BaseForm.FrmBase
    {
        public FrmSupplierAddEditView()
        {
            InitializeComponent();
        }

        void refreshSupplier()
        {
            txtSupplierName.Text = "";
            txtSupplierContactPerson.Text = "";
            txtSupplierContactNo.Text = "";
            txtSupplierFax.Text = "";
            txtSupplierAdrress.Text = "";
        }
        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        this.Cursor = Cursors.AppStarting;
        //        this.Enabled = false;
                
        //        Supplier supplier = new Supplier();
        //        SupplierBLL supplierBLL = new SupplierBLL();

        //        supplier.supplier_name = txtSupplierName.Text.ToString();
        //        supplier.contact_person = txtSupplierContactPerson.Text.ToString();
        //        if (txtSupplierContactNo.Text != "")
        //            supplier.contact_no = txtSupplierContactNo.Text.ToString();


        //        supplier.fax_no = txtSupplierFax.Text.ToString();
        //        supplier.address = txtSupplierAdrress.Text.ToString();
        //        int result = supplierBLL.Addsupplier(supplier);

        //        if (result > 0)
        //            MessageBox.Show("Data Saved Successfully");
        //        else
        //            MessageBox.Show("Data Save Failed");
        //    }
        //    catch
        //    {
        //    }
        //    this.Enabled = true;
        //    this.Cursor = Cursors.Default;
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshSupplier();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NumCheck(KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar !=32 && e.KeyChar !='/')
            {
                e.Handled = true;
            }
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            SupplierBLL supplierBLL = new SupplierBLL();
            try
            {
                supplier.supplier_name = txtSupplierName.Text.ToString();
                supplier.contact_person = txtSupplierContactPerson.Text.ToString();
                supplier.contact_no = txtSupplierContactNo.Text.ToString();
                supplier.fax_no = txtSupplierFax.Text.ToString();
                supplier.address = txtSupplierAdrress.Text.ToString();
                int ProductTypeID=supplier.supplier_type = Convert.ToInt32(cmbProductType.SelectedValue);
                DataSet ds = null;
                if (btnSave.Text == "Save")
                {
                    ds = supplierBLL.AddSupplierAndGetAll(supplier);
                    MessageBox.Show("Data Saved Successfully", "HMS");
                    RefreshSupplier();

                }
                else      // FOR UPDATE
                {
                    supplier.supplier_id = Convert.ToInt32(lvwSupplier.FocusedItem.Text);

                    ds = supplierBLL.UpdateSupplier(supplier, ProductTypeID);
                    MessageBox.Show("Data Updated Successfully", "HMS");
                    RefreshSupplier();
                    btnSave.Text = "Save";

                }
                FillUpListview(this.lvwSupplier, ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                supplier = null;
                supplierBLL = null;
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshSupplier();
        }

        void RefreshSupplier()
        {
          
            txtSupplierName.Text = "";
            txtSupplierContactPerson.Text = "";
            txtSupplierContactNo.Text = "";
            txtSupplierFax.Text = "";
            txtSupplierAdrress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            lvwSupplier.Items.Clear();
            SupplierBLL supplierBLL = new SupplierBLL();
            DataSet ds = supplierBLL.Getsuppliers(Convert.ToInt32(cmbProductType.SelectedValue));
            FillUpListview(lvwSupplier, ds);
            lblTotalSupplier2.Text = lvwSupplier.Items.Count.ToString();
            supplierBLL = null;
            ds = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwSupplier.FocusedItem.Text != "")
            {
                SupplierBLL supplierBLL = new SupplierBLL();
                int supplierID = Convert.ToInt32(lvwSupplier.FocusedItem.Text);
                supplierBLL.Removesupplier(supplierID);
                btnDelete.Enabled = false;
                RefreshSupplier();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwSupplier_Click(object sender, EventArgs e)
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            Supplier supplier = new Supplier();

            int supplierID = Convert.ToInt32(lvwSupplier.FocusedItem.Text);

            supplier = supplierBLL.Getsupplier(supplierID);

            if (supplier.supplier_name != null)
                txtSupplierName.Text = supplier.supplier_name.ToString();
            else
                txtSupplierName.Text = "";

            if (supplier.contact_person == null)
                txtSupplierName.Text = "";
            else
                txtSupplierContactPerson.Text = supplier.contact_person.ToString();

            if (supplier.contact_no == null)
                txtSupplierContactNo.Text = "";
            else
                txtSupplierContactNo.Text = supplier.contact_no.ToString();

            if (supplier.fax_no == null)
                txtSupplierFax.Text = "";
            else
                txtSupplierFax.Text = supplier.fax_no.ToString();

            if (supplier.address == null)
                txtSupplierAdrress.Text = "";
            else
                txtSupplierAdrress.Text = supplier.address.ToString();

            btnDelete.Enabled = true;
            btnSave.Text = "Update";
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
        private void FrmSupplierAddEditView_Load(object sender, EventArgs e)
        {
            //RefreshSupplier();
            InventoryBLL inventoryBLL = new InventoryBLL();
            DataSet dstype = inventoryBLL.GetProductType();
            this.cmbProductType.SelectedIndexChanged -= this.cmbProductType_SelectedIndexChanged;
            PopulateComboBox(cmbProductType, dstype, 0, "product_type", "product_type_id");
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
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
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSupplierName.Enabled = true;
                txtSupplierContactPerson.Enabled = true;
                txtSupplierAdrress.Enabled = true;
                txtSupplierContactNo.Enabled = true;
                txtSupplierFax.Enabled = true;
                RefreshSupplier();
            }
            catch
            {
            }
        }

        private void txtSupplierContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    txtSupplierFax.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbProductType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSupplierName.Focus();
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    txtSupplierContactPerson.Focus();
            }
            catch
            {
            }

        }

        private void txtSupplierContactPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    txtSupplierAdrress.Focus();
            }
            catch
            {
            }
        }

        private void txtSupplierAdrress_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    txtSupplierContactNo.Focus();
            }
            catch
            {
            }
        }

        private void txtSupplierFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    btnSave.Focus();
                }
            }
            catch
            {
            }
        }

        
    }
}