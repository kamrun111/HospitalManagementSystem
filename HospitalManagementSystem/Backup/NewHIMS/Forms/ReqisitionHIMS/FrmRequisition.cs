using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;

namespace NewHIMS.Forms.ReqisitionHIMS
{
    public partial class FrmRequisition : BaseForm.FrmBase
    {
        List<RequisitionProduct> lstRequisitionProduct = new List<RequisitionProduct>();
        DataSet da;
        private bool noNeedToContinue = true;
        int RequisitionID=0;
        public FrmRequisition()
        {
            InitializeComponent();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
            combo.Text = "<Select>";
        } 

        void RefreshRequisition()
        {
            Requisition requisition = new Requisition();
            RequisitionBLL requisitionBLL = new RequisitionBLL();
            DataSet ds = requisitionBLL.GetRequisitionLoad();
            PopulateComboBox(cmbDepartment, ds, 0, "user_group", "user_group_id");
            PopulateComboBox(cmbstoreID, ds, 1, "product_type", "product_type_id");
            grdMainList.Rows.Clear();
            cmbproductCategory.Enabled = false;
            cmbproduct.Enabled = false;
            btnSave.Enabled = true;
            cmbDepartment.Enabled = true;
            dtpRequisitionDate.Enabled = true;
            dtpRequisitionDate.Value = DateTime.Now;
            //if (ApplicatinLauncher._GroupName != "Administrator")
            //{
                cmbDepartment.SelectedValue = ApplicatinLauncher._groupID;
                cmbDepartment.Enabled = false;
            //}
            
        }

        public static DataGridViewRow findFromDataGridView(DataGridView grid, string columnName, string value)
        {
            try
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[columnName].Value.ToString() == value)
                    {
                        return row;
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (grdMainList.Rows.Count == 0)
                    return;
                if (MessageBox.Show("Do you want to Save?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
               
                string Iscomplete = "no";
                Requisition requisition = new Requisition();
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                
                if (cmbDepartment.SelectedIndex!=-1)
                {   
                    requisition.department_id = Convert.ToInt32(this.cmbDepartment.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Select a Department");
                    cmbDepartment.Focus();
                    return;
                }
                if (cmbstoreID.SelectedIndex!=-1)
                {   
                    if(cmbstoreID.Text!="<Select>")
                        requisition.product_type_id=Convert.ToInt32(this.cmbstoreID.SelectedValue.ToString());  
                }
                else
                {
                    MessageBox.Show("Select Item Type");
                    cmbstoreID.Focus();
                    return;
                }
                requisition.requisition_date = Convert.ToDateTime(dtpRequisitionDate.Text);
                requisition.store_id = 1;
                requisition.record_created_by = ApplicatinLauncher._userId;

                for (int i = 0; i < grdMainList.Rows.Count; i++)
                {
                    
                    RequisitionProduct requisitionProduct = new RequisitionProduct();
                    if (grdMainList.Rows[i].Cells[0].Value!= null)
                        requisitionProduct.product_id = Convert.ToInt32(grdMainList.Rows[i].Cells[0].Value);
                    if (grdMainList.Rows[i].Cells[2].Value!= null)
                        requisitionProduct.order_qty = Convert.ToInt32(grdMainList.Rows[i].Cells[2].Value);
                    else
                        requisitionProduct.order_qty = 0;
                    requisitionProduct.refund_qty = 0;
                    requisitionProduct.receive_qty = 0;
                    requisitionProduct.is_complete = Iscomplete;
                    requisitionProduct.delivery_qty = 0;
                    requisitionProduct.store_id = 0;
                    lstRequisitionProduct.Add(requisitionProduct);
                    
                }
                if (cmbstoreID.Text== "Drug")
                    RequisitionID = requisitionBLL.RequisitionProductInsert(requisition, lstRequisitionProduct, 0);
                else
                    RequisitionID = requisitionBLL.RequisitionProductInsert(requisition, lstRequisitionProduct, 1);
                if (RequisitionID > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    this.btnSave.Enabled = false;
                    this.grdMainList.Enabled = false;
                    this.cmbDepartment.Enabled = false;
                    this.cmbDepartment.Enabled = false;
                    this.dtpRequisitionDate.Enabled = false;
                    RefreshRequisition();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRequisition();
        }

        private void FrmRequisition_Load(object sender, EventArgs e)
        {
            RefreshRequisition();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdMainList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdMainList.Rows[e.RowIndex];


                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);



                if (e.ColumnIndex == 2)
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

                    MessageBox.Show(msg, "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }
        }

     

       

        private void cmbstoreID_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                if (cmbstoreID.SelectedIndex != -1)
                {
                    cmbproductCategory.Enabled = true;
                    RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();
                    DataSet dscat = requisitionProductBLL.requisitonProductCategoty(Convert.ToInt32(((DataRowView)cmbstoreID.SelectedItem).Row[1]));
                    PopulateComboBox(cmbproductCategory, dscat, 0, "product_category", "product_category_id");
                    grdMainList.Rows.Clear();
                    cmbproduct.Text = "<Select>";
                    cmbproduct.Enabled = false;
                }

            }
            catch
            {
            }
        }

        private void cmbproductCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbproductCategory.SelectedIndex != -1)
                {
                    da = null;
                    RequisitionBLL requisitionBLL = new RequisitionBLL();
                    da = requisitionBLL.ProductlistforSales(Convert.ToInt32(cmbproductCategory.SelectedValue.ToString()));
                    this.cmbproduct.SelectedIndexChanged -= this.cmbproduct_SelectedIndexChanged;
                    PopulateComboBox(cmbproduct, da, 0, "product", "product_id");
                    this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
                    cmbproduct.Enabled = true;
                }
            }
            catch
            {
            }
        }
       
      
        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartment.SelectedIndex != -1)
                {
                        cmbstoreID.Enabled = true;
                        cmbDepartment.Enabled = false;
                }
            }
            catch
            {
            }

        }


        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbproduct.SelectedIndex != -1)
                {
                    grdMainList.Rows.Add();
                    grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(cmbproduct.SelectedValue);
                    grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[1].Value = cmbproduct.Text;
                    grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[2].Value = 1;
                }
            }
            catch
            {
            }

        }

      

        
           
        


        

    }
}
