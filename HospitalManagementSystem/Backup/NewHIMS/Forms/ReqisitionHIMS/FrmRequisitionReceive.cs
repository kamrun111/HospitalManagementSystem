using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.ReqisitionHIMS
{
    public partial class FrmRequisitionReceive :BaseForm.FrmBase
    {
        
        public FrmRequisitionReceive()
        {
            InitializeComponent();
        }
        int requisitonID = 0;

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
            combo.Text="<Select>";

        }


        void RefreshRequisition()
        {
            try
            {
                this.cmbRequisitionNo.SelectedIndexChanged -= this.cmbRequisitionNo_SelectedIndexChanged;
                Requisition requisiton = new Requisition();
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                DataSet ds = requisitionBLL.requisitionReceiveload(Convert.ToInt16(ApplicatinLauncher._groupID));
                PopulateComboBox(cmbRequisitionNo, ds, 0, "requisition_no", "requisition_id");
                txtdeliveryby.Text = "";
                grdRequisitionReceive.Rows.Clear();
                this.cmbRequisitionNo.SelectedIndexChanged += new EventHandler(this.cmbRequisitionNo_SelectedIndexChanged);
            }
            catch
            {
            }
        }

        private void FrmRequisitionReceive_Load(object sender, EventArgs e)
        {
              RefreshRequisition();
        }



        private void cmbRequisitionNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRequisitionNo.SelectedIndex != -1)
                {
                    this.requisitonID = Convert.ToInt16(cmbRequisitionNo.SelectedValue);
                    RequisitionBLL requisitionBLL = new RequisitionBLL();
                    DataSet ds = requisitionBLL.requisitionReceiveload(Convert.ToInt16(cmbRequisitionNo.SelectedValue));
                    grdRequisitionReceive.Rows.Clear();
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtdeliveryby.Text = ds.Tables[1].Rows[0][4].ToString();
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            grdRequisitionReceive.Rows.Add();
                            grdRequisitionReceive.Rows[grdRequisitionReceive.Rows.Count - 1].Cells[0].Value = ds.Tables[1].Rows[i][0].ToString();
                            grdRequisitionReceive.Rows[grdRequisitionReceive.Rows.Count - 1].Cells[1].Value = ds.Tables[1].Rows[i][1].ToString();
                            grdRequisitionReceive.Rows[grdRequisitionReceive.Rows.Count - 1].Cells[2].Value = ds.Tables[1].Rows[i][2].ToString();
                            grdRequisitionReceive.Rows[grdRequisitionReceive.Rows.Count - 1].Cells[3].Value = ds.Tables[1].Rows[i][3].ToString();
                        }


                    }
                }

            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRequisition();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (grdRequisitionReceive.RowCount == 0)
                return;
            try
            {
                Requisition requisition = new Requisition();
                List<RequisitionProduct> lstrequisitionProduct = new List<RequisitionProduct>();
                RequisitionProductBLL requisitionProductBLL = new RequisitionProductBLL();
                int Result = 0;
                requisition.requisition_id = requisitonID;
                requisition.store_id = 3;
                for (int i = 0; i < grdRequisitionReceive.Rows.Count; i++)
                {

                    if (grdRequisitionReceive.Rows[i].Cells[2].Value!= null)
                    {
                        RequisitionProduct requisitionProduct = new RequisitionProduct();
                        requisitionProduct.receive_qty = Convert.ToInt32(grdRequisitionReceive.Rows[i].Cells[2].Value);
                        requisitionProduct.requisition_product_id = Convert.ToInt32(grdRequisitionReceive.Rows[i].Cells[3].Value);
                        requisitionProduct.record_modified_by= ApplicatinLauncher._userId;
                        lstrequisitionProduct.Add(requisitionProduct);
                    }
                    Result = requisitionProductBLL.requisition_productReceiveUpdate(requisition,lstrequisitionProduct);
                }
                if (Result > 0)
                {
                    MessageBox.Show("Data Saved successfully");
                    RefreshRequisition();
                }
            }
            catch
            {
                MessageBox.Show("data saved fail");
            }
        }
        
       

        }
    }
