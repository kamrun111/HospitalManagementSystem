using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Bill;
using NewHIMS.Reports.Payment;

namespace NewHIMS.Forms.Receiptions.Bill
{
    public partial class FrmBill : BaseForm.FrmBase
    {   //Shampa 24-12-2008

        //private bool noNeedToContinue = true;
        private DataSet dsbill = null;
        private DataSet dsbill1 = null;
        private DataSet ds = null;
        int admissionID=0 ;
        int payID;
        //int db1 = 0;
        //int db2 = 0;
        private ListViewItem lvi;
        public FrmBill()
        {
            InitializeComponent();
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshPayment(); 
            }
            catch
            {
                MessageBox.Show("Error1");
            }
        }

        private void FillUpListview1(ListView lvw, DataSet ds,int TableIndex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[TableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[TableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        lvi = new ListViewItem(dataRow["cabin"].ToString());

                        lvi.SubItems.Add(dataRow["patient_code"].ToString());
                        lvi.SubItems.Add(dataRow["admission_id"].ToString());
                        lvi.SubItems.Add(dataRow["patient_name"].ToString());
                        lvi.SubItems.Add(dataRow["is_discharged"].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error2");
            }
        }

        private void FillUpListview2(ListView lvw, DataSet ds, int tableIndex)
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
                        decimal p = Math.Round(Convert.ToDecimal(dataRow[3]), 2);
                        lvi.SubItems.Add(p.ToString());
                        decimal k =Math.Round((Convert.ToDecimal(dataRow[2]) * Convert.ToDecimal(dataRow[3])),2);
                        lvi.SubItems.Add(k.ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error3");
            }
        }
        private void FillUpListview3(ListView lvw, DataSet ds)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[0].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());
                        //lvi.SubItems.Add(dataRow[3].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error4");
            }
        }


        private void FillUpListview4(ListView lvw, DataSet ds)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[0].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                        lvi.SubItems.Add(dataRow["receipt_no"].ToString());
                        lvi.SubItems.Add(dataRow["date"].ToString());
                        lvi.SubItems.Add(dataRow["advance"].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error2");
            }
        }
        public void ClearAll()
        {
            lvwBill.Items.Clear();
            lvwAdvance.Items.Clear();
            txtInvestigation.Text = "";
            txtTreatment.Text = "";
            txtOt.Text = "";
            txtOtherServices.Text = "";
            txtMedicine.Text = "";
            txtRoomRent.Text = "";
            txtDoctor.Text = "";
            txtTotal.Text = "";
            txtAdmissionFee.Text = "200.00";
            txtAdvance.Text = "";
            txtdiscount.Text = "0.00";
            txtNetPayable.Text = "";
            txtPercentage.Text = "2.25";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtVat.Text = "";
            txtDoctorParcentage.Text = "4.5";
            txtCabinCharge.Text = "";
            txtAditionalCharge.Text = "";
            txtDoctorsBill.Text = "";
            txtDoctorVat.Text = "";
            txtDTotal.Text = "";
            txtOtcharge.Text = "";
            txtOtDoctor.Text = "";
            txtPostOperative.Text = "";
            txtRefundMedicine.Text = "";
            txtVistDoctor.Text = "";
            txtSaleMedicine.Text = "";
            txtLoan.Text = "";
            txtSearch.Text = "";
            txtRemarks.Text = "";
            grdDoctorsBill.Rows.Clear();
            EnableButton();
            admissionID = 0;
            ds = null;
            //dsbill = null;
            dsbill1 = null;
            //db1 = 0;
            //db2 = 0;
                
        }
        public void EnableButton()
        {
            try
            {
                btnAdvance.Enabled = true;
                btnInvestigation.Enabled = true;
                btnTreatment.Enabled = true;
                btnOt.Enabled = true;
                btnDoctor.Enabled = true;
                btnRoomRent.Enabled = true;
                btnOtherServices.Enabled = true;
                btnMedicine.Enabled = true;
                btnAdvance.Enabled = true;
                btnLoan.Enabled = true;
                btnvisit.Enabled = true;
                btnRefund.Enabled = true;
            }
            catch
            {
            }
        }
        private void PatientInfo()
        {
            PayBLL payBLL = new PayBLL();
            DataSet ds = payBLL.Paymentinfo();
            lvwPatientInfo.Items.Clear();
            //lvwDue.Items.Clear();
            if (ds.Tables[0].Rows.Count > 0)
            {
                FillUpListview1(lvwPatientInfo, ds, 2);
            }
            for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
            {
                int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[4].Text);
                if (d == 1)
                    lvwPatientInfo.Items[i].ForeColor = Color.BlueViolet;
            }
        }
        private void DueInfo()
        {
            PayBLL payBLL = new PayBLL();
            DataSet ds = payBLL.Paymentinfo();
            //lvwPatientInfo.Items.Clear();
            lvwDue.Items.Clear();
            if (ds.Tables[1].Rows.Count > 0)
            {
                FillUpListview1(lvwDue, ds, 1);
            }
        }
        public void RefreshPayment()
        {
            try
            {
                //PayBLL payBLL = new PayBLL();
                //DataSet ds = payBLL.Paymentinfo();
                //lvwPatientInfo.Items.Clear();
                //lvwDue.Items.Clear();
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    FillUpListview1(lvwPatientInfo, ds, 2);
                //}
                //if (ds.Tables[1].Rows.Count > 0)
                //{
                //    FillUpListview1(lvwDue, ds, 1);
                //}
                PatientInfo();
                DueInfo();
                //for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                //{
                //    int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[4].Text);
                //    if(d==1)
                //        lvwPatientInfo.Items[i].ForeColor=Color.BlueViolet;
                //}
                txtRemarks.Visible = false;
                lblRemarks.Visible = false;
                ClearAll();
            }
            catch
            {
                MessageBox.Show("Error5");
            }
        }

        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error6");
            }
        }

        public void CalculateOTNMedicine()
        {
            try
            {
                if (txtOtcharge.Text != "" || txtAditionalCharge.Text != "")
                {
                    decimal Ot = Convert.ToDecimal(txtOtcharge.Text) + Convert.ToDecimal(txtAditionalCharge.Text);
                    this.txtOt.Text = Ot.ToString();
                }

                if (txtSaleMedicine.Text != "" || txtRefundMedicine.Text != "")
                {
                    decimal med = Convert.ToDecimal(txtSaleMedicine.Text) - Convert.ToDecimal(txtRefundMedicine.Text);
                    this.txtMedicine.Text = med.ToString();
                }
                if (txtCabinCharge.Text != "" || txtPostOperative.Text != "")
                {
                    decimal RR = Convert.ToDecimal(txtCabinCharge.Text) + Convert.ToDecimal(txtPostOperative.Text);
                    this.txtRoomRent.Text = RR.ToString();
                }
                CalculateSubTotal();
            }
            catch
            {
            }
        }
        public void CalculateSubTotal()
        {
            try
            {
                decimal STotal = 0;
                if ( txtInvestigation.Text != "" || txtTreatment.Text != "" || txtOt.Text != "" || txtOtherServices.Text != "" || txtMedicine.Text != "" || txtAdmissionFee.Text != "" ||txtRoomRent.Text !="" ||txtLoan.Text !="")
                {
                    STotal =  Convert.ToDecimal(txtInvestigation.Text) + Convert.ToDecimal(txtTreatment.Text) + Convert.ToDecimal(txtOt.Text) + Convert.ToDecimal(txtOtherServices.Text) + Convert.ToDecimal(txtMedicine.Text)+ Convert.ToDecimal(txtAdmissionFee.Text) + Convert.ToDecimal(txtRoomRent.Text) + Convert.ToDecimal(txtLoan.Text);
                    this.txtSubTotal.Text = STotal.ToString();
                }
                CalculateGrandTotal();
            }
            catch
            {
                MessageBox.Show("Error7");
            }
        }
        public void CalculateGrandTotal()
        {
            try
            {
                //int x=0;
                decimal k = 0;
                decimal vat = 0;
                if (txtPercentage.Text != "" && txtSubTotal.Text != "")
                {
                    k = Convert.ToDecimal(txtPercentage.Text) * Convert.ToDecimal(txtSubTotal.Text);
                    vat =Math.Round(( k / 100),2);
                    this.txtVat.Text = vat.ToString();
                }
                decimal GTotal = Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtVat.Text);
                this.txtTotal.Text = GTotal.ToString();
                //if (txtVat.Text == "")
                //    txtVat.Text =x.ToString();
                //else if (txtdiscount.Text == "")
                //    txtdiscount.Text = x.ToString();
                if (txtTotal.Text != "" || txtVat.Text !="" || txtdiscount.Text != "" || txtAdvance.Text != "")
                {
                    int NPayable = Convert.ToInt32(((Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtdiscount.Text)) - Convert.ToDecimal(txtAdvance.Text))+ Convert.ToDecimal(txtRefund.Text));
                    this.txtNetPayable.Text = NPayable.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Vat and Discount could not be null");
            }
        }

        public void CalculateReducedBill(DataGridViewRow row)
        {
            try
            {
                this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                decimal Chrg = 0;
                int QTY = 0;
                decimal Tchrg = 0;
                if (row.Cells["charge"].Value != null)
                    decimal.TryParse(row.Cells["charge"].Value.ToString(), out Chrg);
                if (row.Cells["redeuced_qty"].Value != null)
                    int.TryParse(row.Cells["redeuced_qty"].Value.ToString(), out QTY);
                decimal Amount = Chrg * QTY;
                row.Cells["reduced_amount"].Value = Amount.ToString();
                if (row.Cells["totalcharge"].Value != null)
                    decimal.TryParse(row.Cells["totalcharge"].Value.ToString(), out Tchrg);
                decimal Payable = Tchrg - Amount;
                row.Cells["payable"].Value = Payable.ToString();
                PyableAmount();
                this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
            }
            catch
            {
            }
        }
        public void CalculateReducedBillAmount(DataGridViewRow row)
        {
            try
            {
                this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                decimal Tchrg = 0;
                decimal Amount=0;
                decimal.TryParse(row.Cells["reduced_amount"].Value.ToString(),out Amount);
                if (row.Cells["totalcharge"].Value != null)
                    decimal.TryParse(row.Cells["totalcharge"].Value.ToString(), out Tchrg);
                decimal Payable = Tchrg - Amount;
                row.Cells["payable"].Value = Payable.ToString();
                PyableAmount();
                this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
            }
            catch
            {
            }
        }

        public void PyableAmount()
        {

            decimal gTotal = 0;
            int Total = 0;
            int f = 0;
            decimal gvat=Convert.ToDecimal(txtDoctorVat.Text);
            for (int i = 0; i < this.grdDoctorsBill.RowCount -1; i++)
            {
                double sTotal = 0.00;
                if (grdDoctorsBill.Rows[i].Cells["payable"].Value != null)
                {
                    double.TryParse(this.grdDoctorsBill.Rows[i].Cells["payable"].Value.ToString(), out sTotal);
                    f = 1;
                }
                else
                {
                    grdDoctorsBill.Rows[i].Cells["payable"].Value = 0;
                    sTotal = 0;
                }
                gTotal += Convert.ToDecimal(sTotal);
            }
            //int pa = Convert.ToInt32(txtDoctorsBill.Text);
            //int dTotal = pa - gTotal;
            gTotal += Convert.ToDecimal(gvat);
            Total = Convert.ToInt32(gTotal);
            if (f != 0)
                this.txtDTotal.Text = Total.ToString("0#.#0");
            else
                this.txtDTotal.Text = (Convert.ToInt32(txtDoctorsBill.Text)).ToString();
        }
        public void DoctorsSubtotal()
        {
            try
            {
                if (txtOtDoctor.Text != "" || txtVistDoctor.Text != "")
                {
                    decimal tdb = Convert.ToDecimal(txtOtDoctor.Text) + Convert.ToDecimal(txtVistDoctor.Text);
                    this.txtDoctor.Text = tdb.ToString();
                }
                CalculateDoctorsBill();
            }
            catch
            {
            }
        }
        public void CalculateDoctorsBill()
        {
            try
            {
                decimal DbVat = 0;
                decimal TotalVat=0;
                if (txtDoctorParcentage.Text != "")
                {
                    DbVat = Convert.ToDecimal(txtDoctorParcentage.Text) * Convert.ToDecimal(txtDoctor.Text);
                    TotalVat =Math.Round((DbVat / 100),2);
                    this.txtDoctorVat.Text = TotalVat.ToString();
                }
                if (txtDoctor.Text != "" || txtDoctorVat.Text != "")
                {
                    int DGT= Convert.ToInt32(Convert.ToDecimal(txtDoctor.Text) + Convert.ToDecimal(txtDoctorVat.Text));
                    this.txtDoctorsBill.Text = DGT.ToString();
                }
                PyableAmount();

            }
            catch
            {
            }
        }

        private void btnOt_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                lvwBill.Items.Clear();
                FillUpListview2(lvwBill, ds, 3);
                EnableButton();
                btnOt.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error9");
            }

        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                //lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                lvwBill.Items.Clear();
                FillUpListview2(lvwBill, ds, 1);
                EnableButton();
                btnTreatment.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error10");
            }
        }
        private void OTgridPopulate()
        {
            try
            {
                BillBLL billBLL = new BillBLL();
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        grdDoctorsBill.Rows.Clear();
                        //noNeedToContinue = true;
                        this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                        for (int i = 0; i < ds.Tables[6].Rows.Count; i++)
                        {
                            grdDoctorsBill.Rows.Add();
                            grdDoctorsBill.Rows[i].Cells["name"].Value = ds.Tables[6].Rows[i]["item"].ToString();
                            grdDoctorsBill.Rows[i].Cells["charge"].Value = ds.Tables[6].Rows[i]["charge"].ToString();
                            grdDoctorsBill.Rows[i].Cells["qty"].Value = ds.Tables[6].Rows[i]["qty"].ToString();
                            grdDoctorsBill.Rows[i].Cells["totalcharge"].Value = Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["charge"].Value) * Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["qty"].Value);
                            grdDoctorsBill.Rows[i].Cells["consultant_id"].Value = ds.Tables[6].Rows[i]["consultant_id"].ToString();
                            grdDoctorsBill.Rows[i].Cells["is_visit"].Value = 0;

                            this.CalculateReducedBill(grdDoctorsBill.Rows[i]);
                        }
                        this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
                        //noNeedToContinue = false;
                    }
                }
                else if(lvwDue.SelectedItems.Count > 0)
                {
                    ds = billBLL.InvestigationBill(Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text));
                    if (ds.Tables[6].Rows.Count > 0)
                    {
                        grdDoctorsBill.Rows.Clear();
                        //noNeedToContinue = true;
                        this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                        for (int i = 0; i < ds.Tables[11].Rows.Count; i++)
                        {
                            grdDoctorsBill.Rows.Add();
                            grdDoctorsBill.Rows[i].Cells["name"].Value = ds.Tables[11].Rows[i]["item"].ToString();
                            grdDoctorsBill.Rows[i].Cells["charge"].Value = ds.Tables[11].Rows[i]["charge"].ToString();
                            grdDoctorsBill.Rows[i].Cells["qty"].Value = 1;
                            grdDoctorsBill.Rows[i].Cells["totalcharge"].Value = Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["charge"].Value) * Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["qty"].Value);
                            grdDoctorsBill.Rows[i].Cells["consultant_id"].Value = ds.Tables[11].Rows[i]["consultant_id"].ToString();
                            grdDoctorsBill.Rows[i].Cells["reduced_amount"].Value = ds.Tables[11].Rows[i]["discount"].ToString();
                            grdDoctorsBill.Rows[i].Cells["payable"].Value = ds.Tables[11].Rows[i]["amount"].ToString();
                            grdDoctorsBill.Rows[i].Cells["is_visit"].Value = 0;

                            //this.CalculateReducedBill(grdDoctorsBill.Rows[i]);
                        }
                        this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
                        //noNeedToContinue = false;
                    }
                }
                
            }
            catch
            {
            }
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    BillBLL billBLL = new BillBLL();
            //    if (lvwPatientInfo.SelectedItems.Count > 0)
            //    {
            //        ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
            //    }
            //    else if(lvwDue.SelectedItems.Count > 0)
            //    {
            //        ds = billBLL.InvestigationBill(Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text));
            //    }
            //    if (ds.Tables[5].Rows.Count > 0)
            //    {
            //        grdDoctorsBill.Rows.Clear();
            //        noNeedToContinue = true;
            //        for (int i = 0; i < ds.Tables[6].Rows.Count; i++)
            //        {
            //            grdDoctorsBill.Rows.Add();
            //            grdDoctorsBill.Rows[i].Cells["name"].Value = ds.Tables[6].Rows[i]["item"].ToString();
            //            grdDoctorsBill.Rows[i].Cells["charge"].Value = ds.Tables[6].Rows[i]["charge"].ToString();
            //            grdDoctorsBill.Rows[i].Cells["qty"].Value = ds.Tables[6].Rows[i]["qty"].ToString();
            //            grdDoctorsBill.Rows[i].Cells["totalcharge"].Value = Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["charge"].Value) * Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["qty"].Value);
            //            grdDoctorsBill.Rows[i].Cells["consultant_id"].Value = ds.Tables[6].Rows[i]["consultant_id"].ToString();

            //            this.CalculateReducedBill(grdDoctorsBill.Rows[i]);
            //        }
            //        noNeedToContinue = false;
            //    }
            //    db1 = 1;
            //    btnDoctor.Enabled = false;
            //    btnvisit.Enabled = true;
            //}
            //catch
            //{
            //}
        }

        private void btnInvestigation_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                lvwBill.Items.Clear();
                FillUpListview2(lvwBill, ds, 0);
                EnableButton();
                btnInvestigation.Enabled = false;
                ds = null;
                //dsbill = null;
            }
            catch
            {
                MessageBox.Show("Error11");
            }
        }
       
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshPayment();
               
            }
            catch
            {
                MessageBox.Show("Error12");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {
                MessageBox.Show("Error13");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (lvwPatientInfo.SelectedItems.Count > 0 && Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text) == 0)
                {
                    MessageBox.Show("Patient is not discharged");
                    return;
                }
                if (txtdiscount.Text != "0.00" && txtRemarks.Text == "")
                {
                    MessageBox.Show("Please Write Remarks");
                    txtRemarks.Visible = true;
                    lblRemarks.Visible = true;
                    return;
                }
                if (lvwPatientInfo.SelectedItems.Count == 0 && lvwDue.SelectedItems.Count > 0 && (Convert.ToDecimal(txtNetPayable.Text) > 0))
                {
                    MessageBox.Show("Please Pay the Amount First");
                    return;
                }
                if (lvwPatientInfo.SelectedItems.Count == 0 && lvwDue.SelectedItems.Count > 0 && (Convert.ToDecimal(txtNetPayable.Text) < 0))
                {
                    MessageBox.Show("Please Refund the Amount First");
                    return;
                }

                BillBO billBO = new BillBO();
                BillBLL billBLL = new BillBLL();
                AdmissionBO admissionBO = new AdmissionBO();
                Pay pay = new Pay();

                List<DoctorsBillBO> lstDoctorsBillBO = new List<DoctorsBillBO>();

                if (txtNetPayable.Text != "")
                {
                    if (lvwPatientInfo.SelectedItems.Count > 0)
                        billBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                    else if (lvwDue.SelectedItems[0].SubItems[2] != null)
                        billBO.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);

                    if (txtInvestigation.Text != "")
                        billBO.investigation_fee = Math.Round(Convert.ToDecimal(txtInvestigation.Text), 2);

                    if (txtTreatment.Text != "")
                        billBO.treatment_fee = Math.Round(Convert.ToDecimal(txtTreatment.Text), 2);

                    if (txtOt.Text != "")
                        billBO.ot_fee = Convert.ToDecimal(txtOt.Text);

                    if (txtOtherServices.Text != "")
                        billBO.other_fee = Math.Round(Convert.ToDecimal(txtOtherServices.Text), 2);

                    if (txtMedicine.Text != "")
                        billBO.medicine_fee = Math.Round(Convert.ToDecimal(txtMedicine.Text), 2);

                    if (txtRoomRent.Text != "")
                        billBO.room_rent = Math.Round(Convert.ToDecimal(txtCabinCharge.Text), 2);

                    if (txtPostOperative.Text != "")
                        billBO.post_operative_fee = Math.Round(Convert.ToDecimal(txtPostOperative.Text), 2);

                    if (txtDoctor.Text != "")
                        billBO.doctors_fee = Math.Round(Convert.ToDecimal(txtDTotal.Text), 2);

                    if (txtAdmissionFee.Text != "0.0")
                        billBO.admission_fee = Math.Round(Convert.ToDecimal(txtAdmissionFee.Text), 2);
                    else
                    {
                        MessageBox.Show("Insert Admission Fee");
                        txtAdmissionFee.Focus();
                        return;
                    }

                    if (txtVat.Text != "")
                        billBO.vat = Math.Round(Convert.ToDecimal(txtVat.Text), 2);
                    else
                    {
                        MessageBox.Show("Insert Vat");
                        txtPercentage.Focus();
                        return;
                    }

                    if (txtLoan.Text != "")
                        billBO.loan = Math.Round(Convert.ToDecimal(txtLoan.Text), 2);

                    if (txtdiscount.Text != "0.00")
                        billBO.discount = Math.Round(Convert.ToDecimal(txtdiscount.Text), 2);
                    billBO.remarks = txtRemarks.Text;
                    billBO.paid_amount = Convert.ToInt32(txtNetPayable.Text);
                    billBO.record_created_by = ApplicatinLauncher._userId;
                    billBO.record_modified_by = ApplicatinLauncher._userId;
                    //billBLL.BillAdd(billBO); //BillAdd
                    if (lvwPatientInfo.SelectedItems.Count > 0)
                        admissionBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                    else if (lvwDue.SelectedItems[0].SubItems[2] != null)
                        admissionBO.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                    if (lvwPatientInfo.SelectedItems.Count > 0 && (Convert.ToDecimal(txtNetPayable.Text) != 0))
                    {
                        admissionBO.is_bill_clear = 2;//Payment Due
                    }
                    else if (lvwDue.SelectedItems.Count > 0)
                    {
                        admissionBO.is_bill_clear = 1;//Payment clear
                    }
                    else
                    {
                        admissionBO.is_bill_clear = 1;//Payment clear
                    }
                    admissionBO.record_modified_by = ApplicatinLauncher._userId;
                    //admissionBLL.admissionUpdateforBill(admissionBO);   //admissionUpdateforBill
                    if (grdDoctorsBill.Rows.Count > 1)
                    {
                        for (int i = 0; i < grdDoctorsBill.Rows.Count - 1; i++)
                        {
                            DoctorsBillBO doctorsBillBO = new DoctorsBillBO();

                            if (lvwPatientInfo.SelectedItems.Count > 0)
                                doctorsBillBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                            else if (lvwDue.SelectedItems[0].SubItems[2] != null)
                                doctorsBillBO.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                            if (grdDoctorsBill.Rows[i].Cells["consultant_id"].Value != null)
                                doctorsBillBO.reffered_doctors_id = Convert.ToInt32(grdDoctorsBill.Rows[i].Cells["consultant_id"].Value);
                            if (grdDoctorsBill.Rows[i].Cells["payable"].Value != null)
                                doctorsBillBO.amount = Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["payable"].Value);
                            if (grdDoctorsBill.Rows[i].Cells["reduced_amount"].Value != null)
                                doctorsBillBO.discount = Convert.ToDecimal(grdDoctorsBill.Rows[i].Cells["reduced_amount"].Value);
                            if (grdDoctorsBill.Rows[i].Cells["is_visit"].Value != null)
                                doctorsBillBO.is_visit = Convert.ToInt32(grdDoctorsBill.Rows[i].Cells["is_visit"].Value);
                            doctorsBillBO.vat = Convert.ToDecimal(txtDoctorVat.Text);
                            doctorsBillBO.record_created_by = ApplicatinLauncher._userId;

                            lstDoctorsBillBO.Add(doctorsBillBO);
                            //doctorsBillBO = null;

                        }
                        // billBLL.BillInsert(billBO, admissionBO, lstDoctorsBillBO);
                    }
                    if (lvwPatientInfo.SelectedItems.Count > 0)
                        pay.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                    else if (lvwDue.SelectedItems[0].SubItems[2] != null)
                        pay.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                    pay.pay_date = Convert.ToDateTime(DateTime.Now);
                    pay.amount = Convert.ToDecimal(txtDTotal.Text);

                    if (lvwPatientInfo.SelectedItems.Count > 0)
                    {
                        pay.payment_type_id = 10; //cash
                    }
                    else if (lvwDue.SelectedItems.Count > 0)
                    {
                        pay.payment_type_id = 10; //Cash
                    }
                    pay.status = 1; //Receive
                    pay.is_doctors_bill = 1;
                    pay.record_created_by = ApplicatinLauncher._userId;
                    pay.record_modified_by = ApplicatinLauncher._userId;
                    if (lvwPatientInfo.SelectedItems.Count > 0)
                    {
                        payID = billBLL.BillInsert(billBO, admissionBO, lstDoctorsBillBO, pay);
                    }
                    else if (lvwDue.SelectedItems.Count > 0)
                    {
                        pay.pay_id = Convert.ToInt32(dsbill1.Tables[2].Rows[0][0]);
                        billBLL.BillUpdate(billBO, admissionBO, lstDoctorsBillBO, pay);
                    }
                    else
                    {
                        MessageBox.Show("Please Select an Item");
                    }

                    MessageBox.Show("Data Saved Successfully");
                    PrintBillSummary(admissionID);
                    //PrintPayment(payID);
                    DoctorsBill(admissionID);

                    RefreshPayment();
                }
                else
                {
                    RefreshPayment();
                }
            }
            catch
            {
                RefreshPayment();
                MessageBox.Show("Error14: Failed");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error15");
            }
            
        }

        private void txtInvestigation_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void txtPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13 && txtPercentage.Text != "")
                {
                    this.CalculateGrandTotal();
                    txtdiscount.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error16");
            }
        }
        private void PopulateData(ListView lvw)
        {
            try
            {
                ClearAll();

                //investigation

                BillBLL billBLL = new BillBLL();
                dsbill1 = billBLL.InvestigationBill1(Convert.ToInt32(lvw.SelectedItems[0].SubItems[2].Text));
                if (dsbill1.Tables[0].Rows.Count > 0)
                {
                    decimal amount =Math.Round(Convert.ToDecimal(dsbill1.Tables[0].Rows[0][0].ToString()),2);
                    txtInvestigation.Text = amount.ToString();
                }

                //Advance

                if (dsbill1.Tables[1].Rows.Count > 0)
                {
                    decimal advance = Math.Round(Convert.ToDecimal(dsbill1.Tables[1].Rows[0][0].ToString()),2);

                    txtAdvance.Text = advance.ToString();
                }
                lvwBill.Items.Clear();
                lvwAdvance.Items.Clear();

                //Treatement

                DataSet dsamount = billBLL.BillAmount(Convert.ToInt32(lvw.SelectedItems[0].SubItems[2].Text));
                decimal res = 0;
                if (dsamount.Tables[0].Rows.Count > 0)
                {
                    res = Math.Round(Convert.ToDecimal(dsamount.Tables[0].Rows[0][0]),2);
                    //for (int i = 0; i < dsamount.Tables[0].Rows.Count; i++)
                    //{
                    //    res += Convert.ToDecimal(dsamount.Tables[0].Rows[i][0].ToString());
                    //}
                    txtTreatment.Text = res.ToString();
                }

                //Medicine Sales 
                decimal m = 0;
                if (dsamount.Tables[1].Rows.Count > 0)
                {
                    m = Math.Round(Convert.ToDecimal(dsamount.Tables[1].Rows[0][0]),2);
                    txtSaleMedicine.Text = m.ToString();
                }

                //Medicine Refund
                decimal r = 0;
                if (dsamount.Tables[6].Rows.Count > 0)
                {
                    r = Math.Round(Convert.ToDecimal(dsamount.Tables[6].Rows[0][0]),2);
                    txtRefundMedicine.Text = r.ToString();
                }

                //OT
                decimal ot = 0;
                if (dsamount.Tables[2].Rows.Count > 0)
                {
                    ot = Math.Round(Convert.ToDecimal(dsamount.Tables[2].Rows[0][0]),2);
                    txtOtcharge.Text = ot.ToString();
                }

                //Other Services
                decimal os = 0;
                if (dsamount.Tables[3].Rows.Count > 0)
                {
                    os = Math.Round(Convert.ToDecimal(dsamount.Tables[3].Rows[0][0]),2);
                    txtOtherServices.Text = os.ToString();
                }

                //Doctor's Bill for Visit
                decimal db = 0;
                if (dsamount.Tables[4].Rows.Count > 0)
                {
                    db = Math.Round(Convert.ToDecimal(dsamount.Tables[4].Rows[0][0]),2);
                    txtVistDoctor.Text = db.ToString();
                }

                //Doctor's Bill for OT
                decimal dbot = 0;
                if (dsamount.Tables[7].Rows.Count > 0)
                {
                    dbot = Math.Round(Convert.ToDecimal(dsamount.Tables[7].Rows[0][0]),2);
                    txtOtDoctor.Text = dbot.ToString();
                }
                //Cabin Charge

                decimal rr = 0;
                if (dsamount.Tables[5].Rows.Count > 0)
                {
                    rr = Math.Round(Convert.ToDecimal(dsamount.Tables[5].Rows[0][0]),2);
                    txtCabinCharge.Text = rr.ToString();
                }

                //post operative charge

                decimal pc = 0;
                if (dsamount.Tables[8].Rows.Count > 0)
                {
                    pc =Math.Round( Convert.ToDecimal(dsamount.Tables[8].Rows[0][0]),2);
                    txtPostOperative.Text = pc.ToString();
                }

                //Additional Charge

                decimal ac = 0;
                if (dsamount.Tables[9].Rows.Count > 0)
                {
                    ac = Math.Round(Convert.ToDecimal(dsamount.Tables[9].Rows[0][0]),2);
                    txtAditionalCharge.Text = ac.ToString();
                }

                //Loan
                decimal ln = 0;
                if (dsamount.Tables[10].Rows.Count > 0)
                {
                    ln = Math.Round(Convert.ToDecimal(dsamount.Tables[10].Rows[0][0]),2);
                    txtLoan.Text = ln.ToString();
                }
                //Refund
                decimal rf = 0;
                if (dsamount.Tables[11].Rows.Count > 0)
                {
                    rf = Math.Round(Convert.ToDecimal(dsamount.Tables[11].Rows[0][0]), 2);
                    txtRefund.Text = rf.ToString();
                }
                //Discount
                decimal d = 0;
                if(dsamount.Tables[12].Rows.Count>0)
                {
                    d=Math.Round(Convert.ToDecimal(dsamount.Tables[12].Rows[0][0]),2);
                    txtdiscount.Text = d.ToString();
                    if (dsamount.Tables[12].Rows[0][1].ToString() != null)
                    {
                        //string r = dsamount.Tables[12].Rows[0][1].ToString();
                        txtRemarks.Text = dsamount.Tables[12].Rows[0][1].ToString();
                    }
                    else
                        txtRemarks.Text = "";
                }
                //if (txtInvestigation.Text != "" || txtTreatment.Text != "" || txtOt.Text != "" || txtMedicine.Text != "" || txtOtherServices.Text != "" || txtRoomRent.Text != "" || txtAdmissionFee.Text != "")
                //{
                //    this.CalculateSubTotal();
                //}
                DataSet dss = billBLL.advance(Convert.ToInt32(lvw.SelectedItems[0].SubItems[2].Text));
                if (dss.Tables[0].Rows.Count > 0)
                {
                    txtSerialNo.Text = "( " + dss.Tables[0].Rows[0]["receipt_no"].ToString();
                    for (int i = 1; i < dss.Tables[0].Rows.Count; i++)
                    {
                        txtSerialNo.Text =txtSerialNo.Text+", "+ dss.Tables[0].Rows[i]["receipt_no"].ToString();
                    }
                    txtSerialNo.Text = txtSerialNo.Text + " )";
                }
                admissionID = Convert.ToInt32(lvw.SelectedItems[0].SubItems[2].Text);
                this.CalculateOTNMedicine();
                if (txtNetPayable.Text != "")
                    btnSave.Enabled = true;
                DoctorsSubtotal();
                OTgridPopulate();
                VisitGridPopulate();
            }

            catch
            {
            }
        }
        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DueInfo();
                if (lvwPatientInfo.SelectedItems.Count >0)
                {
                    PopulateData(lvwPatientInfo);
                    //txtAdmissionFee.ReadOnly = false;
                    //txtPercentage.ReadOnly = false;
                    txtdiscount.ReadOnly = false;
                    //txtDoctorParcentage.ReadOnly = false;
                    grdDoctorsBill.Columns["redeuced_qty"].ReadOnly = false;
                    grdDoctorsBill.Columns["reduced_amount"].ReadOnly = false;
                    //grdDoctorsBill.Columns["reduced_amount"].ReadOnly = true;
                }
                 else
                    MessageBox.Show("Data is not selected");
            }
            catch
            {
               // MessageBox.Show("Error17: Data is not avilable ");
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[2].Rows.Count > 0)
                {
                    FillUpListview2(lvwBill, dsbill, 2);
                }
                EnableButton();
                btnMedicine.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error19");
            }
        }

        private void btnOtherServices_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[4].Rows.Count > 0)
                {
                    FillUpListview2(lvwBill, dsbill, 4);
                }
                EnableButton();
                btnOtherServices.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error20");
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    this.CalculateGrandTotal();
                    //txtDoctorParcentage.Focus();
                    if (txtdiscount.Text != "0.00" || txtdiscount.Text !="")
                    {
                        lblRemarks.Visible = true;
                        txtRemarks.Visible = true;
                        //txtRemarks.Focus();
                    }
                    else
                    {
                        lblRemarks.Visible = false;
                        txtRemarks.Visible = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error21");
            }
        }

        private void txtAdmissionFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    this.CalculateSubTotal();
                    txtPercentage.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error22");
            }
        }

        private void btnAdvance_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    BillBLL billBLL = new BillBLL();
                    DataSet dsad = billBLL.advance(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                    if (dsad.Tables[0].Rows.Count > 0)
                    {
                        lvwAdvance.Items.Clear();
                        FillUpListview4(lvwAdvance, dsad);
                    }
                    btnAdvance.Enabled = false;
                }
                else
                    MessageBox.Show("Data is not selected");
            }
            catch
            {
                MessageBox.Show("Error18");
            }
        }

        private void lvwPatientInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    txtAdmissionFee.Focus();
            }
            catch
            {
            }
        }

        private void btnRoomRent_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[7].Rows.Count > 0)
                {
                    FillUpListview2(lvwBill, dsbill, 7);
                }
                EnableButton();
                btnRoomRent.Enabled = false;
                //txtEquation.Text = "";
                //if (lvwBill.Items.Count > 0)
                //{
                //    txtEquation.Text = "( " + Convert.ToDecimal(lvwBill.Items[0].SubItems[2].Text) + " X" + Convert.ToInt32(lvwBill.Items[0].SubItems[3].Text);
                //    for (int i = 1; i < lvwBill.Items.Count; i++)
                //    {
                //        txtEquation.Text = txtEquation.Text + " +" + Convert.ToDecimal(lvwBill.Items[i].SubItems[2].Text) + " X" + Convert.ToInt32(lvwBill.Items[i].SubItems[3].Text);
                //    }
                //    txtEquation.Text = txtEquation.Text + " )";
                //}
            }
            catch
            {
            }
        }

        void PrintBillSummary(int admissionID)
        {
            try
            {
                txtEquation.Text = "";
                BillBLL billBLL = new BillBLL();
                dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[7].Rows.Count > 0)
                {
                    txtEquation.Text = "( " + Convert.ToDecimal(dsbill.Tables[7].Rows[0][2].ToString()) + " X" + Convert.ToInt32(dsbill.Tables[7].Rows[0][3].ToString());
                    for (int i = 1; i < dsbill.Tables[7].Rows.Count; i++)
                    {
                        txtEquation.Text = txtEquation.Text + " +" + Convert.ToDecimal(dsbill.Tables[7].Rows[i][2].ToString()) + " X" + Convert.ToInt32(dsbill.Tables[7].Rows[i][3].ToString());
                    }
                    txtEquation.Text = txtEquation.Text + " )";
                }
                string eq = txtEquation.Text;
                string sn = txtSerialNo.Text;
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PatientDetailsBill();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idO", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idP", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idOS", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idT", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);
                rptCustomersOrders.SetParameterValue("@admissionID", admissionID);
                rptCustomersOrders.SetParameterValue("@SerialNO", sn);
                rptCustomersOrders.SetParameterValue("@Eeuation", eq);
                            
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
                dsbill = null;
            }
            catch
            {
            }
        }
        void DoctorsBill(int admissionID)
        {
            try
            {
                //decimal vb = Convert.ToDecimal(txtVistDoctor.Text);
                //decimal ob = Convert.ToDecimal(txtOtDoctor.Text);
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new MoneyReceiptforDoctorsBill();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@DBAdmissionID", admissionID);
                rptCustomersOrders.SetParameterValue("@PayID", payID);
                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@AdmissionID", admissionID);
                rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);
                rptCustomersOrders.SetParameterValue("@Admission_Idget", admissionID);
                rptCustomersOrders.SetParameterValue("@cotAdmission_ID", admissionID);
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
        void PrintPreview(int admissionID)
        {
            try
            {
                decimal investamount = Convert.ToDecimal(txtInvestigation.Text);
                decimal treatamount = Convert.ToDecimal(txtTreatment.Text);
                decimal Otamount = Convert.ToDecimal(txtOt.Text);
                decimal Otheramount = Convert.ToDecimal(txtOtherServices.Text);
                decimal Medamount = Convert.ToDecimal(txtMedicine.Text);
                decimal roomrent = Convert.ToDecimal(txtRoomRent.Text);
                decimal lnamount = Convert.ToDecimal(txtLoan.Text);
                decimal adfee = Convert.ToDecimal(txtAdmissionFee.Text);
                decimal vt = Convert.ToDecimal(txtVat.Text);
                decimal adv = Convert.ToDecimal(txtAdvance.Text);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new BillPreview();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admissionID", admissionID);
                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("Invamount", investamount);
                rptCustomersOrders.SetParameterValue("TrtAmount", treatamount);
                rptCustomersOrders.SetParameterValue("Otamount", Otamount);
                rptCustomersOrders.SetParameterValue("Otheramount", Otheramount);
                rptCustomersOrders.SetParameterValue("Medamount", Medamount);
                rptCustomersOrders.SetParameterValue("RoomRent", roomrent);
                rptCustomersOrders.SetParameterValue("Lnamount", lnamount);
                rptCustomersOrders.SetParameterValue("AddFee", adfee);
                rptCustomersOrders.SetParameterValue("Vat", vt);
                rptCustomersOrders.SetParameterValue("AdvAmount", adv);
                rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }
        void PrintPayment(int payID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PaymentInvoice();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@payID", payID);
                rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName); 
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.ShowDialog();
            }
            catch
            {
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreview(admissionID);
            }
            catch
            {
            }
        }

        private void txtDoctorParcentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13 && txtDoctorParcentage.Text != "")
                {
                    this.CalculateDoctorsBill();
                    btnSave.Focus();
                }
            }
            catch
            {
            }
        }
        private void VisitGridPopulate()
        {
            try
            {
                //grdDoctorsBill.Rows.Clear();
                BillBLL billBLL = new BillBLL();
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        //grdDoctorsBill.Rows.Clear();
                        //noNeedToContinue = true;
                        this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                        for (int i = 0; i < ds.Tables[5].Rows.Count; i++)
                        {
                            grdDoctorsBill.Rows.Add();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["name"].Value = ds.Tables[5].Rows[i]["item"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["charge"].Value = ds.Tables[5].Rows[i]["unit_charge"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["qty"].Value = ds.Tables[5].Rows[i]["qty"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["totalcharge"].Value = Convert.ToDecimal(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["charge"].Value) * Convert.ToDecimal(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["qty"].Value);
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["consultant_id"].Value = ds.Tables[5].Rows[i]["consultant_id"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["is_visit"].Value = 1;
                            this.CalculateReducedBill(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2]);
                        }
                        this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
                    }
                }
                else if (lvwDue.SelectedItems.Count > 0)
                {
                    ds = billBLL.InvestigationBill(Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text));
                    if (ds.Tables[10].Rows.Count > 0)
                    {
                        //grdDoctorsBill.Rows.Clear();
                        //noNeedToContinue = true;
                        this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                        for (int i = 0; i < ds.Tables[5].Rows.Count; i++)
                        {
                            grdDoctorsBill.Rows.Add();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["name"].Value = ds.Tables[10].Rows[i]["reffered_doctors"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["charge"].Value = ds.Tables[10].Rows[i]["visit_amount"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["qty"].Value = ds.Tables[10].Rows[i]["qty"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["totalcharge"].Value = Convert.ToDecimal(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["charge"].Value) * Convert.ToDecimal(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["qty"].Value);
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["consultant_id"].Value = ds.Tables[10].Rows[i]["consultant_id"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["reduced_amount"].Value = ds.Tables[10].Rows[i]["discount"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["payable"].Value = ds.Tables[10].Rows[i]["paid"].ToString();
                            grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["is_visit"].Value = 1;
                           //this.CalculateReducedBill(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2]);
                        }
                        this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
                        //noNeedToContinue = false; 
                    }
                }
                
            }
            catch
            {
            }
        }
        private void btnvisit_Click(object sender, EventArgs e)
        {
            try
            {
                grdDoctorsBill.Rows.Clear();
                BillBLL billBLL = new BillBLL();
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    ds = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                }
                else if (lvwDue.SelectedItems.Count > 0)
                {
                    ds = billBLL.InvestigationBill(Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text));
                }
                if (ds.Tables[5].Rows.Count > 0)
                {
                    //grdDoctorsBill.Rows.Clear();
                    //noNeedToContinue = true;
                    this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;

                    for (int i = 0; i < ds.Tables[5].Rows.Count; i++)
                    {
                        grdDoctorsBill.Rows.Add();
                        grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["name"].Value = ds.Tables[5].Rows[i]["item"].ToString();
                        grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["charge"].Value = ds.Tables[5].Rows[i]["unit_charge"].ToString();
                        grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["qty"].Value = ds.Tables[5].Rows[i]["qty"].ToString();
                        grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["totalcharge"].Value = Convert.ToDecimal(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["charge"].Value) * Convert.ToDecimal(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["qty"].Value);
                        grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2].Cells["consultant_id"].Value = ds.Tables[5].Rows[i]["consultant_id"].ToString();
                        this.CalculateReducedBill(grdDoctorsBill.Rows[grdDoctorsBill.Rows.Count - 2]);                        
                    }
                    this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
                    //noNeedToContinue = false; 
                }
                //db2 = 1;
                btnvisit.Enabled = false;
                btnDoctor.Enabled = true;
            }
            catch
            {
            }
        }

        private void grdDoctorsBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row =null;
            string msg = "";
            try
            {
                //if (noNeedToContinue) return;
                //if (e.ColumnIndex != 4) return;
                //DataGridViewRow row = null;
                //string msg = "";
                row = this.grdDoctorsBill.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int Qty;
                decimal ramount;
                decimal amount;
                decimal.TryParse(row.Cells["totalcharge"].Value.ToString(), out amount);
                decimal.TryParse(row.Cells["reduced_amount"].Value.ToString(), out ramount);
                int.TryParse(row.Cells["qty"].Value.ToString(), out Qty);
                if (e.ColumnIndex == 4)
                {
                    if (!Int32.TryParse(valueStr, out valueNumeric))
                        msg = "Pleas provide a valid quantity";
                    else if (valueNumeric < 0)
                        msg = "Pleas provide a valid quantity";
                    else if (valueNumeric > Qty)
                        msg = "Reduced qunatity is more than the real quantity";
                    else
                        this.CalculateReducedBill(row);
                }
                if (e.ColumnIndex == 5)
                {
                    if (!decimal.TryParse(row.Cells["reduced_amount"].Value.ToString(), out ramount))
                        msg = "Pleas provide a valid quantity";
                    else if (ramount<0)
                        msg = "Pleas provide a valid Amount";
                    else if (ramount > amount)
                        msg = "Reduced amount is more than the real amount";
                    else
                        this.CalculateReducedBillAmount(row);
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
                    this.grdDoctorsBill.CellValueChanged -= this.grdDoctorsBill_CellValueChanged;
                    row.Cells[e.ColumnIndex].Value = "0";
                    row.Cells[e.ColumnIndex].Selected = true;
                    this.grdDoctorsBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDoctorsBill_CellValueChanged);
                }
            }        
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[8].Rows.Count > 0)
                {
                    FillUpListview2(lvwBill, dsbill, 8);
                }
                EnableButton();
                btnLoan.Enabled = false;
            }
            catch
            {
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            try
            {
                lvwBill.Items.Clear();
                BillBLL billBLL = new BillBLL();
                dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[9].Rows.Count > 0)
                {
                    FillUpListview2(lvwBill, dsbill, 9);
                }
                EnableButton();
                btnRefund.Enabled = false;
            }
            catch
            {
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //NumCheck(e);
                if (e.KeyChar == 13)
                {
                    PatientInfo();
                    DueInfo();
                    int xx;
                    for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                    {
                        if (Int32.TryParse(txtSearch.Text, out xx))
                        {
                            if (Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[1].Text) == Convert.ToInt32(txtSearch.Text))
                            {
                                lvwPatientInfo.Items[i].BackColor = Color.LightCyan;
                                lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                                lvwPatientInfo.Items[i].Focused = true;
                            }
                            else if (lvwPatientInfo.Items[i].SubItems[0].Text == txtSearch.Text)
                            {
                                lvwPatientInfo.Items[i].BackColor = Color.LightCyan;
                                lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                                lvwPatientInfo.Items[i].Focused = true;
                            }
                        }
                        else 
                        {
                            if (lvwPatientInfo.Items[i].SubItems[0].Text == txtSearch.Text)
                            {
                                lvwPatientInfo.Items[i].BackColor = Color.LightCyan;
                                lvwPatientInfo.Items[i].ForeColor = Color.Blue;
                                lvwPatientInfo.Items[i].Focused = true;
                            }
                        }
                        //else
                        //    MessageBox.Show("Patient Not Found");
                    }
                    for (int i = 0; i < lvwDue.Items.Count; i++)
                    {
                        if (Int32.TryParse(txtSearch.Text, out xx))
                        {
                            if (Convert.ToInt32(lvwDue.Items[i].SubItems[1].Text) == Convert.ToInt32(txtSearch.Text))
                            {
                                lvwDue.Items[i].BackColor = Color.LightCyan;
                                lvwDue.Items[i].ForeColor = Color.Blue;
                                lvwDue.Items[i].Focused = true;
                            }
                            else if (lvwDue.Items[i].SubItems[0].Text == txtSearch.Text)
                            {
                                lvwDue.Items[i].BackColor = Color.LightCyan;
                                lvwDue.Items[i].ForeColor = Color.Blue;
                                lvwDue.Items[i].Focused = true;
                            }
                        }
                        else
                        {
                            if (lvwDue.Items[i].SubItems[0].Text == txtSearch.Text)
                            {
                                lvwDue.Items[i].BackColor = Color.LightCyan;
                                lvwDue.Items[i].ForeColor = Color.Blue;
                                lvwDue.Items[i].Focused = true;
                            }
                        }
                        //else
                        //    MessageBox.Show("Patient Not Found");
                    }

                }
            }
            catch
            {
            }
        }

        private void lvwDue_Click(object sender, EventArgs e)
        {
            try
            {
                PatientInfo();
                if (lvwDue.SelectedItems.Count > 0)
                {
                    PopulateData(lvwDue);
                    btnAdvance.Enabled = false;
                    btnInvestigation.Enabled = false;
                    btnTreatment.Enabled = false;
                    btnOt.Enabled = false;
                    btnRoomRent.Enabled = false;
                    btnMedicine.Enabled = false;
                    btnLoan.Enabled = false;
                    btnRefund.Enabled = false;
                    btnOtherServices.Enabled = false;
                    txtAdmissionFee.ReadOnly = true;
                    txtPercentage.ReadOnly = true;
                    txtdiscount.ReadOnly = true;
                    txtDoctorParcentage.ReadOnly = true;
                    grdDoctorsBill.Columns["redeuced_qty"].ReadOnly = true;
                    grdDoctorsBill.Columns["reduced_amount"].ReadOnly = true;
                    //grdDoctorsBill.Columns["reduced_amount"].ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Data is not Selected");
                }
            }
            catch
            {
            }
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                this.CalculateGrandTotal();
                //txtDoctorParcentage.Focus();
                if (txtdiscount.Text != "0.00")
                {
                    lblRemarks.Visible = true;
                    txtRemarks.Visible = true;
                    this.txtRemarks.Leave -= this.txtRemarks_Leave;
                    //txtRemarks.Focus();
                    this.txtRemarks.Leave += new System.EventHandler(this.txtRemarks_Leave);
                }
                else
                {
                    lblRemarks.Visible = false;
                    txtRemarks.Visible = false;
                }
            }
            catch
            {
            }
        }

        private void txtRemarks_Leave(object sender, EventArgs e)
        {
            try
            {
                txtRemarks.Visible = false;
                lblRemarks.Visible = false;
            }
            catch
            {
            }
        }
       
    }
}