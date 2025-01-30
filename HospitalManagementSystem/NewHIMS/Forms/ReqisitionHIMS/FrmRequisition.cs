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
            grdMainList.Rows.Clear();
            cmbproductCategory.Enabled = true;
            btnSave.Enabled = true;
            dtpRequisitionDate.Enabled = true;
            dtpRequisitionDate.Value = DateTime.Now;
            cmbDepartment.SelectedValue = ApplicatinLauncher._groupID;
            cmbDepartment.Enabled = false;
            grdlist.Enabled = true;
            grdlist.Rows.Clear();
            txtCount.Text = "";
            
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

                if (grdlist.Rows.Count == 0)
                    return;
                if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
               
                string Iscomplete = "no";
                Requisition requisition = new Requisition();
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                List<RequisitionProduct> lstRequisitionProduct = new List<RequisitionProduct>();

                
                if (cmbDepartment.SelectedIndex!=-1)
                {
                    requisition.department_id = ApplicatinLauncher._groupID;
                }
                else
                {
                    MessageBox.Show("Select a Department");
                    cmbDepartment.Focus();
                    return;
                }
                        requisition.product_type_id = 1; 
               
                requisition.requisition_date = Convert.ToDateTime(dtpRequisitionDate.Text);
                requisition.store_id = 1;
                requisition.record_created_by = ApplicatinLauncher._userId;

                for (int i = 0; i < grdlist.Rows.Count; i++)
                {
                    
                    RequisitionProduct requisitionProduct = new RequisitionProduct();
                    if (grdlist.Rows[i].Cells[0].Value != null)
                        requisitionProduct.product_id = Convert.ToInt32(grdlist.Rows[i].Cells[0].Value);
                    if (grdlist.Rows[i].Cells[2].Value != null)
                        requisitionProduct.order_qty = Convert.ToInt32(grdlist.Rows[i].Cells[2].Value);
                    else
                    {
                        MessageBox.Show("Input Order Qty Properly");
                       
                        return;
                    }
                    requisitionProduct.refund_qty = 0;
                    requisitionProduct.receive_qty = 0;
                    requisitionProduct.is_complete = Iscomplete;
                    requisitionProduct.delivery_qty = 0;
                    requisitionProduct.store_id = 0;
                    lstRequisitionProduct.Add(requisitionProduct);
                    
                }
                RequisitionID = requisitionBLL.RequisitionProductInsert(requisition, lstRequisitionProduct, 0);
                lstRequisitionProduct = null;
                if (RequisitionID > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    this.btnSave.Enabled = false;
                    this.grdlist.Enabled = false;
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
            try
            {
                cmbproductCategory.Enabled = true;
                RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();
                DataSet dscat = requisitionProductBLL.requisitonProductCategoty(1);
                PopulateComboBox(cmbproductCategory, dscat, 0, "product_category", "product_category_id");
                grdMainList.Rows.Clear();
                RefreshRequisition();
            }
            catch
            {
            }
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

                    MessageBox.Show(msg, "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmbproductCategory.Enabled = true;
                    RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();
                    DataSet dscat = requisitionProductBLL.requisitonProductCategoty(1);
                    PopulateComboBox(cmbproductCategory, dscat, 0, "product_category", "product_category_id");
                    grdMainList.Rows.Clear();

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
                    if (da.Tables[0].Rows.Count > 0)
                    {
                        grdMainList.Rows.Clear();
                        this.grdMainList.CellValueChanged -= this.grdMainList_CellValueChanged;
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
                            MessageBox.Show("Item Already Exists");
                            row.Cells[0].Selected = true;
                            return;
                        }
                        grdlist.Rows.Add();
                        grdlist.Rows[grdlist.Rows.Count-1].Cells[0].Value = grdMainList.Rows[e.RowIndex].Cells[1].Value;
                        grdlist.Rows[grdlist.Rows.Count - 1].Cells[1].Value = grdMainList.Rows[e.RowIndex].Cells[2].Value;
                        grdMainList.Rows[e.RowIndex].Cells[4].Value = "F";
                    }
                    else
                    {
                        if (grdMainList.Rows[e.RowIndex].Cells[4].Value.ToString() == "T")
                        {
                            if (IsMatchTest(valueStr) == true)
                            {
                                MessageBox.Show("Item Already Exists");
                                row.Cells[0].Selected = true;
                                return;
                            }
                            grdlist.Rows.Add();
                            grdlist.Rows[grdlist.Rows.Count - 1].Cells[0].Value = grdMainList.Rows[e.RowIndex].Cells[1].Value;
                            grdlist.Rows[grdlist.Rows.Count - 1].Cells[1].Value = grdMainList.Rows[e.RowIndex].Cells[2].Value;

                            grdMainList.Rows[e.RowIndex].Cells[4].Value = "F";
                        }
                        else
                        {
                            for (int i = 0; i < grdlist.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(grdMainList.Rows[e.RowIndex].Cells[1].Value) == Convert.ToInt32(grdlist.Rows[i].Cells[0].Value))
                                {
                                    grdlist.Rows.Remove(grdlist.Rows[i]);
                                    grdMainList.Rows[e.RowIndex].Cells[4].Value = "T";
                                    return;

                                }
                            }

                        }
                    }
                }
                int count = Convert.ToInt32(grdlist.Rows.Count);
                txtCount.Text = count.ToString();
            }
            catch
            {
            }

        }
        Boolean IsMatchTest(string dept)
        {
            for (int i = 0; i < grdlist.Rows.Count; i++)
            {
                if (grdlist.Rows[i].Cells[0].Value.ToString()== dept)

                    return true;
            }
            return false;
        }

        private void grdlist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdlist.Rows[e.RowIndex];


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

                    MessageBox.Show(msg, "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
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
                grdlist.Rows.Remove(grdlist.SelectedRows[0]);
                btnDelete.Enabled = false;
                int count = Convert.ToInt32(grdlist.Rows.Count);
                txtCount.Text = count.ToString();
            }
            catch
            {
            }
        }

        private void grdlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmtest test = new frmtest();
            test.ShowDialog();
        }
        

    }
}
