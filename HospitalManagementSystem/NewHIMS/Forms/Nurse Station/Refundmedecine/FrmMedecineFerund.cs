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
using NewHIMS.Forms.Nurse_Station.Medecine_Refund;


namespace NewHIMS.Forms.Nurse_Station.Refundmedecine
{
    public partial class FrmMedecineFerund : BaseForm.FrmBase
    {
        int mode;
        private bool noNeedToContinue = true;
        private int refundID = 0;
        public FrmMedecineFerund(int mode)
        {
            InitializeComponent();
            this.mode = mode;
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

        private void FrmMedecineFerund_Load(object sender, EventArgs e)
        {
            try
            {
                FloorBLL floorBLL = new FloorBLL();
                DataSet ds = floorBLL.Getfloors();
                cmbFloor.DataSource = ds.Tables[0];
                cmbFloor.DisplayMember = "floor";
                cmbFloor.ValueMember = "floor_id";

                if (this.cmbFloor.Items.Count > 0)
                {
                    if (ApplicatinLauncher._groupID >= 53 && ApplicatinLauncher._groupID <= 58)   //gTODO
                    {
                        this.cmbFloor.SelectedIndex = this.cmbFloor.FindString(ApplicatinLauncher._floor);
                        this.cmbFloor.Enabled = false;
                    }
                }
            }
            catch
            { }
        }
        void loadpatiendinfo()
        {
            try
            {
                PatientBLL patientBLL = new PatientBLL();
                DataSet ds = patientBLL.PatientInfofornurse(this.cmbFloor.Text.ToString());
                FillUpListview(lvwPatientInfo, ds);
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
                    if (mode == 1) //mode=1 for Nurse Station & mode=2 for OT Station 
                    {
                        MedecineRefundOrder();
                    }
                    else
                    {
                        OTRefund();
                    }
                }
            }
            catch
            {
            }
        }

        private void OTRefund()
        {
            try
            {
                sales_refundBLL salesrefundBLL = new sales_refundBLL();
                DataSet ds = salesrefundBLL.SalesrefundOrder(Convert.ToInt16(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                grdSalesRefund.Rows.Clear();
                if (ds.Tables[1].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                    {
                        grdSalesRefund.Rows.Add();
                        grdSalesRefund.Rows[i].Cells[0].Value = ds.Tables[1].Rows[i][0].ToString();
                        grdSalesRefund.Rows[i].Cells[1].Value = ds.Tables[1].Rows[i][1].ToString();
                        grdSalesRefund.Rows[i].Cells[2].Value = ds.Tables[1].Rows[i][2].ToString();
                        grdSalesRefund.Rows[i].Cells[3].Value = ds.Tables[1].Rows[i][3].ToString();
                        grdSalesRefund.Rows[i].Cells[4].Value = ds.Tables[1].Rows[i][4].ToString();

                    }
                }
            }
            catch
            {
            }
        }
        void MedecineRefundOrder()
        {
            try
            {
                sales_refundBLL salesrefundBLL= new sales_refundBLL();
                DataSet ds=salesrefundBLL.SalesrefundOrder(Convert.ToInt16(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                grdSalesRefund.Rows.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdSalesRefund.Rows.Add();
                        grdSalesRefund.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                        grdSalesRefund.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                        grdSalesRefund.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                        grdSalesRefund.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();
                        grdSalesRefund.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4].ToString();
                    
                    }
                }
            }
            catch
            {
            }
        
        }
                
        private void grdSalesRefund_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

                row = grdSalesRefund.Rows[e.RowIndex];

                string valuestr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valunumaric = 0;
                double.TryParse(valuestr, out valunumaric);

                if (e.ColumnIndex == 5)
                {
                    int qty = 0;
                    int alreadyrefund = 0;
                    int refundqty = 0;


                    int.TryParse(row.Cells["sales_qty"].Value.ToString(), out qty);
                    int.TryParse(row.Cells["previousrefund"].Value.ToString(), out alreadyrefund);
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
                if(grdSalesRefund.Rows.Count==0)
                    return;
                List<sales_refund> lstsales_refund = new List<sales_refund>();
                sales_refundBLL lstsales_refundBLL = new sales_refundBLL();
                DataSet dss = lstsales_refundBLL.getrefundorderID();
                this.refundID = Convert.ToInt32(dss.Tables[0].Rows[0][0].ToString()) + 1;

                for (int i = 0; i < grdSalesRefund.Rows.Count; i++)
                {
                    sales_refund sales_refund2 = new sales_refund();
                    if (grdSalesRefund.Rows[i].Cells[5].Value !=null)
                    {
                        sales_refund2.admission_id = Convert.ToInt16(grdSalesRefund.Rows[i].Cells[0].Value);
                        sales_refund2.product_id = Convert.ToInt16(grdSalesRefund.Rows[i].Cells[2].Value);
                        sales_refund2.refund_id = refundID;
                        sales_refund2.refund_qty = Convert.ToInt16(grdSalesRefund.Rows[i].Cells[5].Value);
                        sales_refund2.record_created_by = ApplicatinLauncher._userId;
                        lstsales_refund.Add(sales_refund2);   
                    }
                    sales_refund2 = null;
                
                }

                if (lstsales_refund.Count > 0)
                {
                    lstsales_refundBLL.SalesRefundaddBynurse(lstsales_refund);
                    MessageBox.Show("Data Saved successfully");
                }
                //btnSave.Enabled = false;
                grdSalesRefund.Rows.Clear();
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
            refresh();
        }
        void refresh()
        {
            this.grdSalesRefund.Rows.Clear();
            btnSave.Enabled = true;
        
        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbFloor.SelectedValue == null || this.cmbFloor.SelectedValue.ToString() == "-1")
                {
                    return;
                }
                loadpatiendinfo();
                grdSalesRefund.Rows.Clear();
            }
            catch
            { }

        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    grdSalesRefund.Rows.Clear();
                    lnkEdit.Enabled = true;
                    FrmRefund frmrefund = new FrmRefund();
                    frmrefund.searchBYadmissionID(lvwPatientInfo.SelectedItems[0].Text,lvwPatientInfo.SelectedItems[0].SubItems[1].Text, Convert.ToInt16(lvwPatientInfo.SelectedItems[0].SubItems[2].Text), Convert.ToInt32(ApplicatinLauncher._userId));

                    frmrefund.ShowDialog();
                    //((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmrefund);
                
                }
                       
            }
            catch
            {
            }
        }

        



    }
}