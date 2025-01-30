using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Nurse_Station.Medecine_Refund
{
    public partial class FrmRefund : BaseForm.FrmBase
    {
        
        private bool noNeedToContinue = true;
        public FrmRefund()
        {
             
            InitializeComponent();
        }

        public void refreshSalesRefund()
        {
            txtPatientCode.Text = "";
            grdSalesRefundedit.Rows.Clear();
        }

       
        public void searchBYadmissionID(string Cabin,string PatientCode,int admissionid,int Userid)//used function
        {
            try
            {
                this.txtPatientCode.Text = PatientCode;
                this.txtCabin.Text = Cabin;
                sales_refundBLL salesrefundBLL = new sales_refundBLL();
                DataSet ds = salesrefundBLL.Salesrefundedit(admissionid,Userid);
                grdSalesRefundedit.Rows.Clear();
                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdSalesRefundedit.Rows.Add();
                        grdSalesRefundedit.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();//sales refund id
                        grdSalesRefundedit.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();//product id
                        grdSalesRefundedit.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();//product
                        grdSalesRefundedit.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();//refund qty
                    }
                }
                else
                {
                    MessageBox.Show("No Data found");
                }
            }
            catch
            { 
            }
        }
  
             
        void refresh()
        {
            //this.txtPatientCode.Text = "";
            //this.txtPatientCode.Text = "";
            grdSalesRefundedit.Enabled = true;
            grdSalesRefundedit.Rows.Clear();
            btnSave.Enabled = true;
            grdSalesRefundedit.Rows.Clear();
        }

        private void grdSalesRefundedit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

                row = this.grdSalesRefundedit.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 4)
                {
                    int refQty = 0;
                    int Oldrefund = 0;

                    int.TryParse(row.Cells["refund_qty"].Value.ToString(), out refQty);
                    int.TryParse(row.Cells["previousrefund"].Value.ToString(), out Oldrefund);
                    if ((valueNumeric == 0 && valueStr != "0"))//|| (valueNumeric == 0 && valueStr != "0"))
                    {
                        msg = "Please provide a valid refund quantity";
                    }
                    else if (refQty > Oldrefund)
                    {
                        //msg = "Invalid refund quantity.";
                        MessageBox.Show("Invalid refund quantity.", "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.Cells["refund_qty"].Value = null;
                        refQty = 0;
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
                if (grdSalesRefundedit.Rows.Count == 0)
                    return;
                List<sales_refund> lstsales_refund = new List<sales_refund>();
                sales_refundBLL lstsales_refundBLL = new sales_refundBLL();

                for (int i = 0; i < grdSalesRefundedit.Rows.Count; i++)
                {
                    sales_refund sales_refund2 = new sales_refund();
                    if (grdSalesRefundedit.Rows[i].Cells[4].Value != null)
                    {
                        sales_refund2.sales_refund_id = Convert.ToInt16(grdSalesRefundedit.Rows[i].Cells[0].Value);
                        sales_refund2.refund_qty = Convert.ToInt16(grdSalesRefundedit.Rows[i].Cells[4].Value);
                        lstsales_refund.Add(sales_refund2);
                    }
                    sales_refund2 = null;

                }

                if (lstsales_refund.Count > 0)
                {
                    lstsales_refundBLL.SalerefundEditupdate(lstsales_refund);
                    MessageBox.Show("Data Saved successfully");
                    grdSalesRefundedit.Rows.Clear();
                }
                btnSave.Enabled = false;
                
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

}