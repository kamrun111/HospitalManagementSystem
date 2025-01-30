using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.DoctorsPayment;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Common;

namespace NewHIMS.Forms.Nurse_Station
{
    public partial class FrmOTForNurse : BaseForm.FrmBase
    {
        public FrmOTForNurse()
        {
            InitializeComponent();
        }

        private void FrmOTNurse_Load(object sender, EventArgs e)
        {
            GetLoad();
        }
        void GetLoad()
        {
            try
            {
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationBLL.GetIPDInvestigationPopulationInfo();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientInfo, ds, 0);
                    PopulateComboBox(cmbRefferedDoctors, ds, 1, "reffDoc", "reffered_doctors_id");
                    PopulateComboBox(cmbdocbilltype, ds, 3, "bill_type", "doctorbill_type_id");
                }
                txtpatientname.Text = "";
                txtpatientage.Text = "";
                txtadmissiondate.Text = "";
                txtpatientcode.Text = "";
                txtadmissioncode.Text = "";//rehID
                txtcabinNo.Text = "";
                txtTotal.Text = "";
                txtQty.Text = "";
                txtCharge.Text = "";
                btnAdd.Text = "Add";
                grddoctorspayment.Rows.Clear();
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
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.SelectedIndex = -1;
                combo.Text = "<Select>";
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
                    txtCharge.Text = "";
                    txtQty.Text = "";
                    btnAdd.Text = "Add";
                    cmbRefferedDoctors.SelectedIndex = -1;
                    cmbdocbilltype.SelectedIndex = -1;
                    txtpatientname.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text.ToString();
                    txtpatientage.Text = lvwPatientInfo.SelectedItems[0].SubItems[8].Text.ToString();
                    txtadmissiondate.Text = lvwPatientInfo.SelectedItems[0].SubItems[7].Text.ToString();
                    txtpatientcode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
                    txtadmissioncode.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text.ToString();
                    txtcabinNo.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
                    grddoctorspayment.Rows.Clear();
                    DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
                    DataSet ds = doctorsBillBLL.GetDoctorBillForPatient(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grddoctorspayment.Rows.Add();
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString(); 
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[3].Value = Convert.ToInt32(ds.Tables[0].Rows[i][3]);
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[4].Value = Convert.ToDecimal(ds.Tables[0].Rows[i][4]);
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[5].Value = Convert.ToDecimal(ds.Tables[0].Rows[i][5]);
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[6].Value = Convert.ToInt32(ds.Tables[0].Rows[i][6]);

                        }
                    }
                    adjustGrandTotal();
                }
            }
            catch
            {
            }
        }

        private void btnDoctorSearch_Click(object sender, EventArgs e)
        {
            FrmdoctorSearch oFrmdoctorSearch = new FrmdoctorSearch(null, null, null, this, null, null);
            oFrmdoctorSearch.ShowDialog();
        }
        public void LoadDoctorName(int id)
        {
            cmbRefferedDoctors.SelectedValue = id;
        }

        private bool Validation()
        {
            if (cmbdocbilltype.SelectedIndex == -1 || cmbRefferedDoctors.SelectedIndex == -1)
            {
                MessageBox.Show("Select a item from list");
                cmbRefferedDoctors.Focus();
                return false;
            }
            if (txtCharge.Text == "")
            {
                txtCharge.Text = "0";
                return true;
            }
            if (txtQty.Text == "")
            {
                txtQty.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    if (Validation() == true)
                    {
                        if (btnAdd.Text == "Add")
                        {
                            Save();
                        }
                        else
                        {
                            Update();
                        }
                        adjustGrandTotal();
                    }
                }
                else
                    MessageBox.Show("Select A Patient From List");

            }
            catch
            {
            }

        }


        void Save()
        {
            for (int i = 0; i < grddoctorspayment.Rows.Count; i++)
            {
                if (Convert.ToInt32(grddoctorspayment.Rows[i].Cells[0].Value) == Convert.ToInt32(cmbRefferedDoctors.SelectedValue)
                    && (grddoctorspayment.Rows[i].Cells[2].Value.ToString() == cmbdocbilltype.Text.ToString()))
                {
                    MessageBox.Show("Doctor name and bill type already Exists");
                    cmbRefferedDoctors.Focus();
                    return;
                }
            }
            DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
            List<DoctorsBillBO> listDoctorsBillBO = new List<DoctorsBillBO>();
            DoctorsBillBO doctorsBillBO = new DoctorsBillBO();
            doctorsBillBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);
            doctorsBillBO.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
            doctorsBillBO.doctorbill_type_id = Convert.ToInt32(cmbdocbilltype.SelectedValue);
            doctorsBillBO.qty = Convert.ToInt32(txtQty.Text);
            if (txtCharge.Text != "")
                doctorsBillBO.amount = Convert.ToDecimal(txtCharge.Text);
            else
                doctorsBillBO.amount = 0;
            doctorsBillBO.record_created_by = ApplicatinLauncher._userId;

            listDoctorsBillBO.Add(doctorsBillBO);
            int Result = doctorsBillBLL.doctorsbillADD(listDoctorsBillBO);
            if (Result > 0)
            {
                MessageBox.Show("Doctors Bill Saved Successfully");
            }
            grddoctorspayment.Rows.Add();
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[1].Value = cmbRefferedDoctors.Text;
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[2].Value = cmbdocbilltype.Text;
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[3].Value = Convert.ToInt32(cmbdocbilltype.SelectedValue);
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[4].Value = Convert.ToInt32(txtQty.Text);
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[5].Value = Convert.ToDecimal(txtCharge.Text);
            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[6].Value = Result;

        }
        void Update()
        {
            DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
            DoctorsBillBO doctorsBillBO = new DoctorsBillBO();
            doctorsBillBO.doctors_bill_id = Convert.ToInt32(grddoctorspayment.SelectedRows[0].Cells[6].Value);
            doctorsBillBO.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
            doctorsBillBO.doctorbill_type_id = Convert.ToInt32(cmbdocbilltype.SelectedValue);
            doctorsBillBO.qty = Convert.ToInt32(txtQty.Text);
            doctorsBillBO.amount = Convert.ToDecimal(txtCharge.Text);

            int Result = doctorsBillBLL.DoctorBillUpdate(doctorsBillBO);
            if (Result > 0)
            {
                MessageBox.Show("Doctors Bill Update Successfully");
                btnAdd.Text = "Add";
            }
            grddoctorspayment.SelectedRows[0].Cells[0].Value = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
            grddoctorspayment.SelectedRows[0].Cells[1].Value = cmbRefferedDoctors.Text.ToString();
            grddoctorspayment.SelectedRows[0].Cells[2].Value = cmbdocbilltype.Text;
            grddoctorspayment.SelectedRows[0].Cells[3].Value = Convert.ToInt32(cmbdocbilltype.SelectedValue);
            grddoctorspayment.SelectedRows[0].Cells[4].Value = Convert.ToInt32(txtQty.Text);
            grddoctorspayment.SelectedRows[0].Cells[5].Value = Convert.ToDecimal(txtCharge.Text);
        }



        void adjustGrandTotal()
        {
            try
            {
                double grandTotal = 0;
                for (int i = 0; i < this.grddoctorspayment.RowCount; i++)
                {
                    double subTotal = 0.00;
                    double.TryParse(this.grddoctorspayment.Rows[i].Cells["Charge"].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
                this.txtTotal.Text = grandTotal.ToString("00");
            }
            catch
            {
                this.txtTotal.Text = "00";
            }
        }

        private void lnkOTNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvwPatientInfo.SelectedItems.Count > 0)
            {
                FrmOTInformation frmOTInformation = new FrmOTInformation(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                frmOTInformation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Patient First");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmOTPrint frmOTPrint = new FrmOTPrint();
            frmOTPrint.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GetLoad();
        }

        private void lnkOTMedicine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (lvwPatientInfo.SelectedItems.Count > 0)
            //{
            //    FrmPatientMedicine frmPatientMedicine = new FrmPatientMedicine(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
            //    frmPatientMedicine.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Please Select Patient First");
            //}
        }

    }
}
