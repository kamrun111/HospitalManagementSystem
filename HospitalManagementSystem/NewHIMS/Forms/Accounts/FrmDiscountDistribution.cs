using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Data.Common;

namespace NewHIMS.Forms.Accounts
{
    public partial class FrmDiscountDistribution : BaseForm.FrmBase
    {
        CommonClass cs = new CommonClass();

        int Path, Xray, USG, ECG,ECO,otherfee,doctorfee;
        private bool noNeedToContinue = true;
        public FrmDiscountDistribution()
        {
            InitializeComponent();
        }

        private void FrmDiscountDistribution_Load(object sender, EventArgs e)
        {
            refresh();

        }
        private void refresh()
        {
            try
            {
                BillBLL billBLL = new BillBLL();
                DataSet ds = billBLL.GetDiscountPatient();
                if (ds.Tables[0].Rows.Count>0)
                {
                    FillUpListview(lvwPatientInfo, ds, 0);
                }
                txtdiscountbalance.Text = "";
                txtGrandTotal.Text = "";
                txtPatientName.Text = "";
                txtpatient_code.Text = "";
                txtadmission_code.Text = "";
                txtdischargedate.Text = "";
                txtdiscount.Text = "";
                txtadmissiondate.Text = "";
                txtGrandTotal.Text = "";
                txtdiscountbalance.Text = "";
                txtcabin_charge.Text = "";
                txtcabin_service_charge.Text = "";
                txtroomrent.Text = "";
                txtservicecharge.Text = "";
                grddoctorbill.Rows.Clear();
                grdinvestigation.Rows.Clear();
                grdotheritem.Rows.Clear();
                textBoxSearchHospitalID.Text = "";
            }
            catch
            {
            }
        }

        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)//gdgdg
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    btnSave.Enabled = true;
                    txtPatientName.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
                    txtpatient_code.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
                    txtadmission_code.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text.ToString();
                    txtadmissiondate.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text.ToString();
                    txtdischargedate.Text = lvwPatientInfo.SelectedItems[0].SubItems[7].Text.ToString();
                    txtdiscount.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text;
                    txtdiscountbalance.Text = "";
                    txtGrandTotal.Text = "";
                    txtcabin_service_charge.Text = "";
                    txtcabin_charge.Text = "";
                    DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
                    DataSet ds=doctorsBillBLL.GetDiscountinfo(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                    grdotheritem.Rows.Clear();
                    grddoctorbill.Rows.Clear();
                    grdinvestigation.Rows.Clear();
                    //if (ds.Tables[0].Rows.Count > 0)
                    //{
                    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    //    {
                    //        grdinvestigation.Rows.Add();
                    //        grdinvestigation.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                    //        grdinvestigation.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                    //        grdinvestigation.Rows[i].Cells[2].Value =Convert.ToInt32(ds.Tables[0].Rows[i][2]);
                    //    }
                    //}

                    if (ds.Tables[5].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[5].Rows.Count; i++)
                        {
                            grdinvestigation.Rows.Add();
                            grdinvestigation.Rows[i].Cells[0].Value = (i+1).ToString();
                            grdinvestigation.Rows[i].Cells[1].Value = ds.Tables[5].Rows[i][0].ToString();
                            grdinvestigation.Rows[i].Cells[2].Value = Convert.ToInt32(ds.Tables[5].Rows[i][1]);
                        }
                    }

                    if (ds.Tables[1].Rows.Count > 0 )
                    {
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            grdotheritem.Rows.Add();
                            grdotheritem.Rows[i].Cells[0].Value = ds.Tables[1].Rows[i][0].ToString();
                            grdotheritem.Rows[i].Cells[1].Value = ds.Tables[1].Rows[i][1].ToString();
                            grdotheritem.Rows[i].Cells[2].Value = Convert.ToInt32(ds.Tables[1].Rows[i][2]);
                        }
                    }
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                        {
                            grddoctorbill.Rows.Add();
                            grddoctorbill.Rows[i].Cells[0].Value = ds.Tables[2].Rows[i][0].ToString();
                            grddoctorbill.Rows[i].Cells[1].Value = ds.Tables[2].Rows[i][1].ToString();
                            grddoctorbill.Rows[i].Cells[2].Value = Convert.ToInt32(ds.Tables[2].Rows[i][2]);
                        }
                    }
                    if (ds.Tables[3].Rows.Count > 0)
                    {
                        Path =Convert.ToInt32(ds.Tables[3].Rows[0][0]);
                        Xray = Convert.ToInt32(ds.Tables[3].Rows[0][1]);
                        USG  = Convert.ToInt32(ds.Tables[3].Rows[0][2]);
                        ECG = Convert.ToInt32(ds.Tables[3].Rows[0][3]);
                        ECO = Convert.ToInt32(ds.Tables[3].Rows[0][6]);
                        otherfee  = Convert.ToInt32(ds.Tables[3].Rows[0][4]);
                        doctorfee  = Convert.ToInt32(ds.Tables[3].Rows[0][5]);
                    }
                    if(ds.Tables[4].Rows.Count>0)
                    {
                        txtroomrent.Text = ds.Tables[4].Rows[0][0].ToString();
                        txtservicecharge.Text = ds.Tables[4].Rows[0][1].ToString();
                    }
                    
                }
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    if (txtdiscountbalance.Text != "00.00")
                    {
                        MessageBox.Show("Adjust patient discount properly");
                        return;
                    }
                    if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    List<InvestigationOrder> listinvestigationOrder = new List<InvestigationOrder>();
                    List<PatientOtherItem> listpatientOtherItem = new List<PatientOtherItem>();
                    List<DoctorsBillBO> listDoctorsBillBO = new List<DoctorsBillBO>();
                    DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
                    AdmissionBO admissionBO = new AdmissionBO();
                    InpatientAccount inpatientAccount = new InpatientAccount();
                    admissionBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);
                    admissionBO.is_biscount_clear = 2;
                    inpatientAccount.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);
                    inpatientAccount.is_done_by_account = 1;
                    inpatientAccount.record_created_by = ApplicatinLauncher._userId;
                    for (int i = 0; i < grdinvestigation.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[3].Value) > 1) 
                        {
                            InvestigationOrder investigationOrder = new InvestigationOrder();
                            investigationOrder.discount = Convert.ToDecimal(grdinvestigation.Rows[i].Cells[3].Value);
                            investigationOrder.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);
                            investigationOrder.record_created_date = Convert.ToDateTime(lvwPatientInfo.SelectedItems[0].SubItems[7].Text);
                            if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value) > 4)
                            {
                                investigationOrder.test_department_id = 4;
                            }
                            else
                            {
                                investigationOrder.test_department_id = Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value);
                            }
                            if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value) == 1)
                                Xray = Xray - Convert.ToInt32(grdinvestigation.Rows[i].Cells[3].Value);
                            if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value) == 2)
                                Path = Path - Convert.ToInt32(grdinvestigation.Rows[i].Cells[3].Value);
                            if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value) == 3)
                                USG = USG - Convert.ToInt32(grdinvestigation.Rows[i].Cells[3].Value);
                            if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value) == 4)
                                ECG = ECG - Convert.ToInt32(grdinvestigation.Rows[i].Cells[3].Value);
                            if (Convert.ToInt32(grdinvestigation.Rows[i].Cells[0].Value) == 5)
                                ECO = ECO - Convert.ToInt32(grdinvestigation.Rows[i].Cells[3].Value);
                            listinvestigationOrder.Add(investigationOrder);
                        }

                    }
                    for (int j = 0; j < grdotheritem.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(grdotheritem.Rows[j].Cells[3].Value) > 1)
                        {
                            PatientOtherItem patientOtherItem = new PatientOtherItem();
                            patientOtherItem.discount = Convert.ToDecimal(grdotheritem.Rows[j].Cells[3].Value);
                            patientOtherItem.record_created_date = Convert.ToDateTime(lvwPatientInfo.SelectedItems[0].SubItems[7].Text);
                            patientOtherItem.patient_other_item_id= Convert.ToInt32(grdotheritem.Rows[j].Cells[0].Value);
                            otherfee = otherfee - Convert.ToInt32(grdotheritem.Rows[j].Cells[3].Value);
                            listpatientOtherItem.Add(patientOtherItem);
                        }

                    }
                    for (int k = 0; k < grddoctorbill.Rows.Count; k++)
                    {
                        if (Convert.ToInt32(grddoctorbill.Rows[k].Cells[3].Value) > 1)
                        {
                            DoctorsBillBO doctorsBillBO = new DoctorsBillBO();
                            doctorsBillBO.discount = Convert.ToDecimal(grddoctorbill.Rows[k].Cells[3].Value);
                            doctorsBillBO.record_created_date = Convert.ToDateTime(lvwPatientInfo.SelectedItems[0].SubItems[7].Text);
                            doctorsBillBO.doctors_bill_id = Convert.ToInt32(grddoctorbill.Rows[k].Cells[0].Value);
                            doctorsBillBO.record_modified_by = ApplicatinLauncher._userId;
                            doctorfee = doctorfee - Convert.ToInt32(grddoctorbill.Rows[k].Cells[3].Value);
                            listDoctorsBillBO.Add(doctorsBillBO);

                        }

                    }
                    inpatientAccount.Pathology = Path;
                    inpatientAccount.X_Ray = Xray;
                    inpatientAccount.USG = USG;
                    inpatientAccount.ECG = ECG;
                    inpatientAccount.ECO = ECO;
                    inpatientAccount.other_fee = otherfee;
                    inpatientAccount.doctors_fee = doctorfee;
                    inpatientAccount.record_created_by = ApplicatinLauncher._userId;
                    inpatientAccount.is_done_by_account = 1;
                    inpatientAccount.room_rent = Convert.ToDecimal(txtcabin_charge.Text);
                    inpatientAccount.cabin_service_charge = Convert.ToDecimal(txtcabin_service_charge.Text);

                    int Result = doctorsBillBLL.PatientDiscount(listinvestigationOrder, listpatientOtherItem, listDoctorsBillBO, admissionBO,inpatientAccount);
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                }
                else
                    MessageBox.Show("Select a patient from list");
            }
            catch
            {
            }
        }

        private void grdinvestigation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdinvestigation.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 3)
                {

                    int amount = 0;
                    int discount = 0;

                    int.TryParse(row.Cells[2].Value.ToString(), out amount);
                    int.TryParse(row.Cells[3].Value.ToString(), out discount);

                    if (valueNumeric <= 0)
                    {
                        msg = "Please insert properly";
                       
                        
                    }
                    else if (discount > amount)
                    {
                        MessageBox.Show("Discount is more than Amount");
                        row.Cells[3].Value = 0;

                    }
                    this.adjustGrandTotal();
               
                }
            }
            catch
            {
            }
            finally
            {

                if (msg != "")
                {
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
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

        private void adjustGrandTotal()
        {
            try
            {
                if (txtcabin_charge.Text == "")
                    txtcabin_charge.Text = "0.00";
                if (txtcabin_service_charge.Text == "")
                    txtcabin_service_charge.Text = "0.00";

                double grandTotal = 0.00;
                for (int i = 0; i < this.grdinvestigation.RowCount; i++)
                {
                    double subTotal = 0.00;
                    if (grdinvestigation.Rows[i].Cells[3].Value != null)
                        double.TryParse(this.grdinvestigation.Rows[i].Cells[3].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
                for (int j = 0; j < this.grdotheritem.RowCount; j++)
                {
                    double subTotal = 0.00;
                    if (grdotheritem.Rows[j].Cells[3].Value != null)
                        double.TryParse(this.grdotheritem.Rows[j].Cells[3].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
                for (int k = 0; k < this.grddoctorbill.RowCount; k++)
                {
                    double subTotal = 0.00;
                    if (grddoctorbill.Rows[k].Cells[3].Value != null)
                        double.TryParse(this.grddoctorbill.Rows[k].Cells[3].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
                this.txtGrandTotal.Text = grandTotal.ToString("0#.#0");
                if (txtdiscount.Text == "")
                    txtdiscount.Text = "0.00";
                decimal roominfo=Convert.ToDecimal(txtGrandTotal.Text)+Convert.ToDecimal(txtcabin_charge.Text)+Convert.ToDecimal(txtcabin_service_charge.Text);
                txtGrandTotal.Text=roominfo.ToString("0#.#0");
                decimal netdiscount = Convert.ToDecimal(txtdiscount.Text) - Convert.ToDecimal(txtGrandTotal.Text);
                txtdiscountbalance.Text = netdiscount.ToString("0#.#0");
                
            }
            catch
            {

                this.txtGrandTotal.Text = "0.00";
            }
        }

        private void grdotheritem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdotheritem.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 3)
                {

                    int amount = 0;
                    int discount = 0;

                    int.TryParse(row.Cells[2].Value.ToString(), out amount);
                    int.TryParse(row.Cells[3].Value.ToString(), out discount);

                    if (valueNumeric <= 0)
                    {
                        msg = "Please insert properly";
                    }
                    else if (discount > amount)
                    {
                        MessageBox.Show("Discount is more than Amount");
                        row.Cells[3].Value = 0;
                    }
                    this.adjustGrandTotal();

                }
            }
            catch
            {
            }
            finally
            {

                if (msg != "")
                {
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }

        }

        private void grddoctorbill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grddoctorbill.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 3)
                {

                    int amount = 0;
                    int discount = 0;

                    int.TryParse(row.Cells[2].Value.ToString(), out amount);
                    int.TryParse(row.Cells[3].Value.ToString(), out discount);

                    if (valueNumeric <= 0)
                    {
                        msg = "Please insert properly";
                    }
                    else if (discount > amount)
                    {
                        MessageBox.Show("Discount is more than Amount");
                        row.Cells[3].Value = 0;
                    }
                    this.adjustGrandTotal();

                }
            }
            catch
            {
            }
            finally
            {

                if (msg != "")
                {
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtcabin_charge_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    this.adjustGrandTotal();

                }
            }
            catch
            {
                MessageBox.Show("Error21");
            }
        }

        private void txtcabin_charge_Leave(object sender, EventArgs e)
        {
            adjustGrandTotal();
        }

        private void textBoxSearchHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    PatientBLL oPatientBLL = new PatientBLL();
                    DataSet ds = oPatientBLL.HospitalIDSearchDiscountPatient(Convert.ToInt32(textBoxSearchHospitalID.Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lvwPatientInfo.Items.Clear();
                        FillUpListview(lvwPatientInfo, ds, 0);
                    }
                    else
                        MessageBox.Show("No Data Found");


                }
            }
            catch
            {
                MessageBox.Show("Error21");
            }
        }


       
        
    }
}
