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
using NewHIMS.Reports.Doctors_Payment;
using HIMS.BLL;
using HIMS.BusinessObjects;


namespace NewHIMS.Forms.Receiptions.Doctors_Payment
{
    public partial class FrmDoctorsPayment : Form
    {
        public FrmDoctorsPayment()
        {
            InitializeComponent();
        }
        int Flag = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grddoctorspayment.Rows.Count; i++)
                {
                    if (Convert.ToInt32(grddoctorspayment.Rows[i].Cells[0].Value) == Convert.ToInt32(cmbrefdoctor.SelectedValue))
                    {
                        MessageBox.Show("Doctor Name Already Exists");
                        return;
                    }
                }
                grddoctorspayment.Rows.Add();
                this.grddoctorspayment.CellValueChanged -= this.grddoctorspayment_CellValueChanged;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[0].Value = Convert.ToInt32(cmbrefdoctor.SelectedValue);
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[1].Value = cmbrefdoctor.Text;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[2].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[3].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[4].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[5].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[6].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[7].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[8].Value = 0;
                grddoctorspayment.Rows[grddoctorspayment.Rows.Count - 1].Cells[9].Value = 0;
                this.grddoctorspayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellValueChanged);

            }
            catch
            {
            }
        }

        private void grddoctorspayment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == 0) return;
            if (e.ColumnIndex == 1) return;

            //string msg = "";
            DataGridViewRow row = null;
            row = this.grddoctorspayment.Rows[e.RowIndex];
            try
            {
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (valueNumeric < 0)
                {
                    MessageBox.Show("Please Insert Digits Properly");
                    row.Cells[e.ColumnIndex].Value = 0;
                    //return;
                }
                else if (!int.TryParse(valueStr, out valueNumeric))
                {
                    MessageBox.Show("Please Insert Digits Properly");
                    row.Cells[e.ColumnIndex].Value = 0;
                }

                this.calculateTotalPrice(row, e);
            }
            catch
            {
            }
        }
        void calculateTotalPrice(DataGridViewRow row, DataGridViewCellEventArgs e)
        {
            try
            {
                this.grddoctorspayment.CellValueChanged -= this.grddoctorspayment_CellValueChanged;
                int totalprice = 0;
                int surgeryCharge = 0;
                int visitcharge = 0;
                int reduceCharge = 0;
                int ansthesiaCharge = 0;
                int assistanceCharge = 0;

                if (row.Cells["surgery_charge"].Value != null)
                    int.TryParse(row.Cells["surgery_charge"].Value.ToString(), out surgeryCharge);
                if (row.Cells["visit_charge"].Value != null)
                    int.TryParse(row.Cells["visit_charge"].Value.ToString(), out visitcharge);
                if (row.Cells["reducevisitamount"].Value != null)
                    int.TryParse(row.Cells["reducevisitamount"].Value.ToString(), out reduceCharge);
                if (row.Cells["ansthesia_charge"].Value != null)
                    int.TryParse(row.Cells["ansthesia_charge"].Value.ToString(), out ansthesiaCharge);
                if (row.Cells["assistance_charge"].Value != null)
                    int.TryParse(row.Cells["assistance_charge"].Value.ToString(), out assistanceCharge);

                totalprice = surgeryCharge + visitcharge - reduceCharge + ansthesiaCharge + assistanceCharge;
                row.Cells["total_amount"].Value = totalprice.ToString("0#.#0");
                adjustGrandTotal();
                this.grddoctorspayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellValueChanged);
              }
            catch
            {
            }
        }
        void adjustGrandTotal()
        {
            try
            {
                double grandTotal = 0;
                for (int i = 0; i < this.grddoctorspayment.RowCount; i++)
                {
                    double subTotal = 0.00;
                    double.TryParse(this.grddoctorspayment.Rows[i].Cells["total_amount"].Value.ToString(), out subTotal);
                    grandTotal += subTotal;
                }
               this.txtTotal.Text = grandTotal.ToString("00");
            }
            catch
            {
                //this.txtGrandTotal.Text = "00";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grddoctorspayment.Rows.Count == 0)
                    return;
                if (MessageBox.Show("Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                int Result = 0;
                if (btnsave.Text == "Save")
                {
                    DoctorsPayment doctorsPayment = new DoctorsPayment();
                    DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();
                    List<DoctorsPaymentDetails> listDoctorsPaymentDetails = new List<DoctorsPaymentDetails>();

                    doctorsPayment.admission_code= Convert.ToInt32(txtadmissioncode.Text);
                    doctorsPayment.grand_total = Convert.ToDecimal(txtTotal.Text);
                    doctorsPayment.record_created_by = ApplicatinLauncher._userId;

                    for (int i = 0; i < grddoctorspayment.Rows.Count; i++)
                    {
                        if (grddoctorspayment.Rows[i].Cells["total_amount"] != null)
                        {
                            DoctorsPaymentDetails doctorsPaymentDetails = new DoctorsPaymentDetails();
                            doctorsPaymentDetails.reffered_doctors_id = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[0].Value);
                            doctorsPaymentDetails.surgery_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[2].Value);
                            doctorsPaymentDetails.visit_qty = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[3].Value);
                            doctorsPaymentDetails.visit_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[4].Value);
                            doctorsPaymentDetails.reducevisit_qty = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[5].Value);
                            doctorsPaymentDetails.reducevisit_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[6].Value);
                            doctorsPaymentDetails.anestheia_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[7].Value);
                            doctorsPaymentDetails.assistance_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[8].Value);
                            doctorsPaymentDetails.total_amount = Convert.ToDecimal(grddoctorspayment.Rows[i].Cells["total_amount"].Value);
                            doctorsPaymentDetails.record_created_by = ApplicatinLauncher._userId;

                            listDoctorsPaymentDetails.Add(doctorsPaymentDetails);
                        }
                    }
                    Result = doctorsPaymentBLL.doctorspaymentAdd(doctorsPayment, listDoctorsPaymentDetails);

                }
                else
                {
                    DoctorsPayment doctorsPayment = new DoctorsPayment();
                    DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();
                    List<DoctorsPaymentDetails> listDoctorsPaymentDetails = new List<DoctorsPaymentDetails>();

                    doctorsPayment.admission_code = Convert.ToInt32(txtadmissioncode.Text);
                    doctorsPayment.grand_total = Convert.ToDecimal(txtTotal.Text);
                    doctorsPayment.record_modified_by = ApplicatinLauncher._userId;
                    
                    for (int i = 0; i < grddoctorspayment.Rows.Count; i++)
                    {
                        DoctorsPaymentDetails doctorsPaymentDetails = new DoctorsPaymentDetails();
                        doctorsPaymentDetails.doctors_payment_details_id = Convert.ToInt32(grddoctorspayment.Rows[i].Cells["payment_details_id"].Value);
                        doctorsPaymentDetails.surgery_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[2].Value);
                        doctorsPaymentDetails.visit_qty = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[3].Value);
                        doctorsPaymentDetails.visit_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[4].Value);
                        doctorsPaymentDetails.reducevisit_qty = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[5].Value);
                        doctorsPaymentDetails.reducevisit_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[6].Value);
                        doctorsPaymentDetails.anestheia_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[7].Value);
                        doctorsPaymentDetails.assistance_charge = Convert.ToInt32(grddoctorspayment.Rows[i].Cells[8].Value);
                        doctorsPaymentDetails.total_amount = Convert.ToDecimal(grddoctorspayment.Rows[i].Cells["total_amount"].Value);
                        doctorsPaymentDetails.record_modified_by = ApplicatinLauncher._userId;

                        listDoctorsPaymentDetails.Add(doctorsPaymentDetails);
                        //doctorsPaymentDetails = null;
                    }
                    Result = doctorsPaymentBLL.doctorpaymentUpdate(doctorsPayment,listDoctorsPaymentDetails);
                    //Result = doctorsPaymentBLL.doctorpaymentUpdate(doctorsPayment, listDoctorsPaymentDetails);
                }
                if (Result > 0)
                {
                    MessageBox.Show("Doctors Bill Saved Successfully");
                    btnsave.Enabled = false;
                    cmbrefdoctor.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Delete?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                grddoctorspayment.Rows.Remove(grddoctorspayment.SelectedRows[0]);
                adjustGrandTotal();
            }
            catch
            {
            }
        }

        private void btnfinalbill_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorsPayment doctorsPayment = new DoctorsPayment();
                DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();

                doctorsPayment.admission_code=Convert.ToInt32(txtadmissioncode.Text);
                doctorsPayment.grand_total = Convert.ToDecimal(txtTotal.Text);
                doctorsPayment.record_modified_by = ApplicatinLauncher._userId;

                int k = doctorsPaymentBLL.doctorspaymentmodify(doctorsPayment);
                if (k > 0)
                {
                    MessageBox.Show("final save completed");
                    btnfinalbill.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtCaseNo.Text != "")
                //{
                //    PrintAdmissionReport(AdmissionID, Convert.ToInt16(txtCaseNo.Text), pamentid);
                //    btnPrint.Enabled = false;
                //}
            }
            catch
            {
            }
           
        }

        private void txtadmissioncode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            catch
            {
            }
        }

        private void txtadmissioncode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (txtadmissioncode.Text == " ")
                    {
                        MessageBox.Show("Input Data Correctly");
                        txtadmissioncode.Focus();
                        return;
                    }
                    if (txtadmissioncode.Enabled == false)
                        return;
                    DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();
                    DataSet ds = doctorsPaymentBLL.SearchPatient(Convert.ToInt32(txtadmissioncode.Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtadmissioncode.Enabled = false;
                        txtpatientname.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtgurdianName.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtaddress.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtadmissiondate.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtdischargedate.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtrefdoctor.Text = ds.Tables[0].Rows[0][6].ToString();

                        cmbrefdoctor.DataSource = ds.Tables[1];
                        cmbrefdoctor.DisplayMember = "reffered_doctors";
                        cmbrefdoctor.ValueMember = "reffered_doctors_id";
                        cmbrefdoctor.SelectedIndex = -1;
                        cmbrefdoctor.Text = "<Select>";
                        btnAdd.Enabled = true;

                        if (ds.Tables[2].Rows.Count > 0)
                        {
                            btnAdd.Enabled = false;
                            txtTotal.Text = ds.Tables[2].Rows[0][10].ToString();//grand total
                            Flag = Convert.ToInt32(ds.Tables[2].Rows[0][11].ToString());// if flag 1  data saved if 2 final saved had been done
                            if (Flag == 1)
                            {
                                btnsave.Text = "Update";
                                btnfinalbill.Enabled = true;
                                //btnAdd.Enabled = false;
                            }
                            if (Flag == 2 || Flag == 3)
                            {
                                btnsave.Enabled = false;
                                //btnAdd.Enabled = false;
                                btnfinalbill.Enabled = false;
                            }
                            for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                            {
                                this.grddoctorspayment.CellValueChanged -= this.grddoctorspayment_CellValueChanged;
                                grddoctorspayment.Rows.Add();
                                grddoctorspayment.Rows[i].Cells[1].Value = ds.Tables[2].Rows[i][0].ToString();//doc_name
                                grddoctorspayment.Rows[i].Cells[2].Value = ds.Tables[2].Rows[i][1].ToString();//surgery-charge
                                grddoctorspayment.Rows[i].Cells[3].Value = ds.Tables[2].Rows[i][2].ToString();//visit qty
                                grddoctorspayment.Rows[i].Cells[4].Value = ds.Tables[2].Rows[i][3].ToString();//visit charge
                                grddoctorspayment.Rows[i].Cells[5].Value = ds.Tables[2].Rows[i][4].ToString();//reduce visit qty
                                grddoctorspayment.Rows[i].Cells[6].Value = ds.Tables[2].Rows[i][5].ToString();//reduce visit charge
                                grddoctorspayment.Rows[i].Cells[7].Value = ds.Tables[2].Rows[i][6].ToString();//anesthesia charge
                                grddoctorspayment.Rows[i].Cells[8].Value = ds.Tables[2].Rows[i][7].ToString();//assistancey charge
                                grddoctorspayment.Rows[i].Cells[9].Value = ds.Tables[2].Rows[i][8].ToString();//total amount
                                grddoctorspayment.Rows[i].Cells[10].Value = ds.Tables[2].Rows[i][9].ToString();//doctor_payment_id
                                this.grddoctorspayment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoctorspayment_CellValueChanged);

                            }
                            
                        }

                    }
                    else
                        MessageBox.Show("No Data found");
                
                }
            }
            catch
            {
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            try
            {
                txtadmissioncode.Text = "";
                txtadmissioncode.Enabled = true;
                txtadmissiondate.Text = "";
                txtdischargedate.Text = "";
                txtgurdianName.Text = "";
                txtpatientname.Text = "";
                txtrefdoctor.Text = "";
                txtTotal.Text = "";
                txtaddress.Text = "";
                btnAdd.Enabled = false;
                grddoctorspayment.Rows.Clear();
                txtadmissioncode.Focus();
                btnsave.Text = "Save";
                btnsave.Enabled = true;
                btnfinalbill.Enabled = false;
                cmbrefdoctor.Text = "<Select>";
            }
            catch
            {
            }
        }

        void PrintdoctorsBill(int admissioncode)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;

                ReportDocument rptCustomersOrders = new rptdoctorspayment();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_code", admissioncode);


                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

      
    }
}