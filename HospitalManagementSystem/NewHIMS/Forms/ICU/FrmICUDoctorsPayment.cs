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

namespace NewHIMS.Forms.ICU
{
    public partial class FrmICUDoctorsPayment : Form
    {
        public FrmICUDoctorsPayment()
        {
            InitializeComponent();
        }

        private void FrmICUDoctorsPayment_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshInvestigation();
            }
            catch
            {
            }
        }

        void RefreshInvestigation()
        {
            try
            {
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationBLL.GetIPDInvestigationPopulationInfo();
                if (ds.Tables[7].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientInfo, ds, 7);
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
                btnDelete.Visible = false;
                grddoctorspayment.Rows.Clear();


            }
            catch
            {
            }
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
                txtCharge.Focus();
                return false;
            }
            if (txtQty.Text == "")
            {
                txtQty.Focus();
                return false;
            }

            return true;
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
                    DataSet ds = doctorsBillBLL.GetDoctorBillForPatient_ICU(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grddoctorspayment.Rows.Add();
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                            grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString(); ;
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

        private void grddoctorspayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grddoctorspayment.SelectedRows.Count > 0)
            {
                if (ApplicatinLauncher._GroupName == "Administrator" || ApplicatinLauncher._GroupName == "Accounts")
                {
                    btnAdd.Text = "Update";
                    btnDelete.Visible = true;
                    cmbRefferedDoctors.SelectedValue = Convert.ToInt32(grddoctorspayment.SelectedRows[0].Cells[0].Value);
                    cmbdocbilltype.SelectedValue = Convert.ToInt32(grddoctorspayment.SelectedRows[0].Cells[3].Value);
                    txtQty.Text = grddoctorspayment.SelectedRows[0].Cells[4].Value.ToString();
                    txtCharge.Text = grddoctorspayment.SelectedRows[0].Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("You have no Permission. Please contact with Accounts Department.");
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    if (Validation() == true)
                    {
                        Delete();
                    }
                    adjustGrandTotal();
                }
                else
                    MessageBox.Show("Select A Patient From List");

            }
            catch
            {
            }
        }

        void Delete()
        {
            DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
            DoctorsBillBO doctorsBillBO = new DoctorsBillBO();
            doctorsBillBO.doctors_bill_id = Convert.ToInt32(grddoctorspayment.SelectedRows[0].Cells[6].Value);
            doctorsBillBO.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
            doctorsBillBO.doctorbill_type_id = Convert.ToInt32(cmbdocbilltype.SelectedValue);


            int Result = doctorsBillBLL.DoctorBillDelete_ICU(doctorsBillBO);
            if (Result > 0)
            {
                MessageBox.Show("Doctors Bill Deleted Successfully");
                btnAdd.Text = "Add";
            }

            RefreshInvestigation();

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
            doctorsBillBO.amount = Convert.ToDecimal(txtCharge.Text);
            doctorsBillBO.record_created_by = ApplicatinLauncher._userId;

            listDoctorsBillBO.Add(doctorsBillBO);
            int Result = doctorsBillBLL.doctorsbillADD_ICU(listDoctorsBillBO);
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

            int Result = doctorsBillBLL.DoctorBillUpdate_ICU(doctorsBillBO);
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshInvestigation();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkOTNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvwPatientInfo.SelectedItems.Count > 0)
            {
                FrmICUOTInformation frmICUOTInformation = new FrmICUOTInformation(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                frmICUOTInformation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Patient First");
            }
        }



    }
}
