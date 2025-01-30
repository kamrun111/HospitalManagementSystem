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
using NewHIMS.Reports.Discharge;
using NewHIMS.Reports;

namespace NewHIMS.Forms.Receiptions
{
    public partial class FrmDischarge : BaseForm.FrmBase
    {
        public FrmDischarge()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        int admissionID = 0;

        private void Discharge_Load(object sender, EventArgs e)
        {
            RefreshInvestigation();
        }
        void RefreshInvestigation()
        {
            try
            {
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationBLL.GetIPDInvestigationPopulationInfoMember();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientInfo, ds, 0);
                }
                if (ds.Tables[4].Rows.Count > 0)
                    PopulateComboBox(cmbtreat, ds, 4, "treatement", "treatement_id");
                txtpatientname.Text = "";
                txtpatientage.Text = "";
                txtadmissiondate.Text = "";
                txtpatientcode.Text = "";
                txtadmissioncode.Text = "";//rehID
                txtcabinNo.Text = "";
                txtchiefcomplain.Text = "";
                txtpresentstatus.Text = "";
                txthospital_medication.Text="";
                txtmedication.Text = "";
                txtadvice.Text = "";
                txttreatment_procedure.Text = "";
                cmbtreat.Text = "";
                btnSave.Text = "Save";
                txtDutyDoctorName.Text = "";
                lvwPatientInfo.Enabled = true;
                btnSave.Enabled = true;
                btnDischarge.Enabled = true;
                txtTypeRemarks.Text = "";
                cmbType.SelectedIndex = -1;
                
               
            }
            catch
            {
            }
        }
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
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
                    txtchiefcomplain.Text = "";
                    txtpresentstatus.Text = "";
                    txthospital_medication.Text = "";
                    txtmedication.Text = "";
                    txtadvice.Text = "";
                    cmbtreat.Text = "";
                    txttreatment_procedure.Text ="";

                    txtpatientname.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text.ToString();
                    txtpatientage.Text = lvwPatientInfo.SelectedItems[0].SubItems[8].Text.ToString();
                    txtadmissiondate.Text = lvwPatientInfo.SelectedItems[0].SubItems[7].Text.ToString();
                    txtpatientcode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
                    txtadmissioncode.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text.ToString();
                    txtcabinNo.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
                    //Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text)
                    if (lvwPatientInfo.SelectedItems[0].SubItems[9].Text == "")
                        btnSave.Text = "Save";
                    else
                    {
                        btnSave.Text = "Update";
                        AdmissionBLL admissionBLL = new AdmissionBLL();
                        DataSet ds = admissionBLL.getcasesummaryID(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txtchiefcomplain.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtpresentstatus.Text = ds.Tables[0].Rows[0][1].ToString();
                            txthospital_medication.Text = ds.Tables[0].Rows[0][2].ToString();
                            txtmedication.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtadvice.Text = ds.Tables[0].Rows[0][4].ToString();
                            cmbtreat.Text=ds.Tables[0].Rows[0][5].ToString();
                            txttreatment_procedure.Text = ds.Tables[0].Rows[0][6].ToString();
                            txtDutyDoctorName.Text = ds.Tables[0].Rows[0][7].ToString();
                            cmbType.SelectedText = ds.Tables[0].Rows[0][8].ToString();
                            txtTypeRemarks.Text = ds.Tables[0].Rows[0][9].ToString();
                        }
                    }

                    patientlist(lvwPatientInfo);
                    patientlistMedicine(lvwPatientInfo);
                }
            }
            catch
            {
            }
        }

        void patientlistMedicine(ListView lvw)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithParameter("@admission_id", Convert.ToInt32(lvw.SelectedItems[0].SubItems[0].Text), "GetPatientIssuedMedicine");

                if (ds.Tables[1].Rows.Count > 0)
                {
                    txtMedicineBill.Text = ds.Tables[1].Rows[0][0].ToString();
                }
                else
                {
                    txtMedicineBill.Text="0";
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    txtMedicinePayment.Text = ds.Tables[2].Rows[0][0].ToString();
                }
                else
                {
                    txtMedicinePayment.Text="0";
                }

                NetPayableMedicine();
            }
            catch
            {
            }
        }

        void NetPayableMedicine()
        {
            try
            {
                decimal netpayble = 0;
                
                netpayble = Convert.ToDecimal(Convert.ToDecimal(txtMedicineBill.Text) - Convert.ToDecimal(txtMedicinePayment.Text));
                txtMedicineDue.Text = netpayble.ToString();

            }
            catch
            {
            }
        }

        void patientlist(ListView lvw)
        {
            try
            {
                ClearAll();
                BillBLL billBLL = new BillBLL();
                DataSet ds = billBLL.populatePatientbill(Convert.ToInt32(lvw.SelectedItems[0].SubItems[0].Text));

                txtadmissionfee.Text = "500.00";

                //investigation
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtinvestigation.Text = ds.Tables[0].Rows[0][0].ToString();
                }

                //doctor bill
                if (ds.Tables[1].Rows.Count > 0)
                {
                    txtdoctorbill.Text = ds.Tables[1].Rows[0][0].ToString();
                }

                //Cabin Charge
                decimal roomrent = 0;
                if (ds.Tables[2].Rows.Count > 0)
                {
                    roomrent = Math.Round(Convert.ToDecimal(ds.Tables[2].Rows[0][0]), 2);
                    txtcabincharge.Text = roomrent.ToString();
                }
                //Cabin service Charge

                if (ds.Tables[3].Rows.Count > 0)
                {
                    decimal roomcharge = Math.Round(Convert.ToDecimal(ds.Tables[3].Rows[0][0]), 2);
                    txtservicecharge.Text = roomcharge.ToString();
                }
                //Other service 

                if (ds.Tables[4].Rows.Count > 0)
                {
                    txtothercharge.Text = ds.Tables[4].Rows[0][0].ToString();
                }

                //Loan

                if (ds.Tables[5].Rows.Count > 0)
                {
                    txtloan.Text = ds.Tables[5].Rows[0][0].ToString();
                }

                //Advance

                if (ds.Tables[6].Rows.Count > 0)
                {
                    txtadvance.Text = ds.Tables[6].Rows[0][0].ToString();
                }
                //refund
                if (ds.Tables[7].Rows.Count > 0)
                {
                    txtrefund.Text = ds.Tables[7].Rows[0][0].ToString();
                }
                //discount
                if (ds.Tables[8].Rows.Count > 0)
                {
                    txtdiscount.Text = ds.Tables[8].Rows[0][0].ToString();
                    //if (ds.Tables[8].Rows[0][1].ToString() != null)
                    //{
                    //    txtRemarks.Text = ds.Tables[8].Rows[0][1].ToString();
                    //}
                    //else
                    //    txtRemarks.Text = "";
                }
                //if (ds.Tables[9].Rows.Count > 0)
                //{
                //    txtSerialNo.Text = "( " + ds.Tables[9].Rows[0]["receipt_no"].ToString();
                //    for (int i = 1; i < ds.Tables[9].Rows.Count; i++)
                //    {
                //        txtSerialNo.Text = txtSerialNo.Text + ", " + ds.Tables[9].Rows[i]["receipt_no"].ToString();
                //    }
                //    txtSerialNo.Text = txtSerialNo.Text + " )";
                //}
                if (ds.Tables[10].Rows.Count > 0)//xray
                    txtXray.Text = ds.Tables[10].Rows[0][2].ToString();
                if (ds.Tables[11].Rows.Count > 0)//pathology
                    txtPathology.Text = ds.Tables[11].Rows[0][2].ToString();
                if (ds.Tables[12].Rows.Count > 0)//UCG
                    txtUsg.Text = ds.Tables[12].Rows[0][2].ToString();
                if (ds.Tables[13].Rows.Count > 0)//ECG
                    txtEcg.Text = ds.Tables[13].Rows[0][2].ToString();

                admissionID = Convert.ToInt32(lvw.SelectedItems[0].SubItems[0].Text);
                Calculategrandtotal();
                btnSave.Enabled = true;


            }
            catch
            {
            }
        }

        void Calculategrandtotal()
        {
            try
            {
                decimal GT = 0;
                if (txtadmissionfee.Text != "" || txtcabincharge.Text != "" || txtservicecharge.Text != "" || txtothercharge.Text != "" || txtloan.Text != "" || txtinvestigation.Text != "" || txtdoctorbill.Text != "")
                {
                    GT = Convert.ToDecimal(txtadmissionfee.Text) + Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text) + Convert.ToDecimal(txtloan.Text) + Convert.ToDecimal(txtinvestigation.Text) + Convert.ToDecimal(txtdoctorbill.Text) + Convert.ToDecimal(txtothercharge.Text);
                }
                txtgrandtotal.Text = GT.ToString();
                NetPayable();
            }
            catch
            {
            }
        }

        void NetPayable()
        {
            try
            {
                decimal netpayble = 0;
                if (txtdiscount.Text == "")
                    txtdiscount.Text = "0.00";
                netpayble = Convert.ToDecimal(Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtdiscount.Text)) - Convert.ToDecimal(txtadvance.Text) + Convert.ToDecimal(txtrefund.Text);
                txtNetPayable.Text = netpayble.ToString();

            }
            catch
            {
            }
        }

        public void ClearAll()
        {
            txtadmissionfee.Text = "";
            txtcabincharge.Text = "";
            txtservicecharge.Text = "";
            txtothercharge.Text = "";
            txtloan.Text = "";
            txtinvestigation.Text = "";
            txtdoctorbill.Text = "";
            txtgrandtotal.Text = "";
            txtadvance.Text = "";
            txtrefund.Text = "";
            txtdiscount.Text = "";
            txtNetPayable.Text = "";
            txtXray.Text = "0.00";
            txtPathology.Text = "0.00";
            txtUsg.Text = "0.00";
            txtEcg.Text = "0.00";
            //if (ApplicatinLauncher._GroupName == "Administrator" || ApplicatinLauncher._GroupName == "Accounts")
            //{
            //    txtdiscount.Enabled = true;
            //}
            //else
            //{
            //    txtdiscount.Enabled = false;
            //}
            txtMedicineBill.Text = "";
            txtMedicineDue.Text = "";
            txtMedicinePayment.Text = "";

        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0 ) // && lvwPatientInfo.SelectedItems[0].SubItems[10].Text == "Others")
                {

                    if (lvwPatientInfo.SelectedItems.Count > 0 && (Convert.ToDecimal(txtNetPayable.Text) == 0) && (Convert.ToDecimal(txtMedicineDue.Text) == 0))
                    {
                        if (MessageBox.Show("Do you want to Discharge the Patient?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                        AdmissionBLL admissionBLL = new AdmissionBLL();
                        admissionBLL.SetDischargeInfo(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text), this.lvwPatientInfo.SelectedItems[0].SubItems[1].Text, ApplicatinLauncher._userId);
                        MessageBox.Show("Patient Discharged Successfully");
                        discharge("Discharge", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                        RefreshInvestigation();
                        ClearAll();

                    }

                    else
                    {
                        MessageBox.Show("Please Pay the Amount First");
                        return;
                    }

                }

                //else if (lvwPatientInfo.SelectedItems.Count > 0 && lvwPatientInfo.SelectedItems[0].SubItems[10].Text != "Others")
                //{

                //    if (MessageBox.Show("Do you want to Discharge the Patient?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                //    {
                //        return;
                //    }
                //    AdmissionBLL admissionBLL = new AdmissionBLL();
                //    admissionBLL.SetDischargeInfo(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text), this.lvwPatientInfo.SelectedItems[0].SubItems[1].Text, ApplicatinLauncher._userId);
                //    MessageBox.Show("Patient Discharged Successfully");
                //    discharge("Discharge", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                //    RefreshInvestigation();
                //    ClearAll();
                //}

                else
                {
                    MessageBox.Show("Select a Patient From List");
                    return;
                }
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInvestigation();
            ClearAll();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please Select a Patient from List");
                    return;
                }
                int result = 0;
                CaseSummary caseSummary = new CaseSummary();
                AdmissionBO admissionBO = new AdmissionBO();
                AdmissionBLL admissionBLL = new AdmissionBLL();
                CaseSummaryBLL caseSummaryBLL = new CaseSummaryBLL(); 
                admissionBO.admission_id = Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text);
                if (txtchiefcomplain.Text != "")
                    caseSummary.chiefcomplain = txtchiefcomplain.Text.ToString();
                if (txtpresentstatus.Text != "")
                    caseSummary.present_status = txtpresentstatus.Text.ToString();
                if (txtmedication.Text != "")
                    caseSummary.medication = txtmedication.Text.ToString();
                if (txthospital_medication.Text != "")
                    caseSummary.hospital_medication = txthospital_medication.Text.ToString();
                if (txtadvice.Text != "")
                    caseSummary.advice = txtadvice.Text.ToString();
                if (cmbtreat.Text != "")
                    caseSummary.treatment = cmbtreat.Text.ToString();
                if (txttreatment_procedure.Text != "")
                    caseSummary.treatment_procedure = txttreatment_procedure.Text.ToString();
                if (txtTypeRemarks.Text != "")
                {
                    caseSummary.dis_type_remarks = txtTypeRemarks.Text;
                }
                if (cmbType.SelectedItem != "")
                {
                    caseSummary.dis_type = cmbType.SelectedItem.ToString();
                }

                caseSummary.duty_doctor_name = txtDutyDoctorName.Text;
                caseSummary.record_created_by = ApplicatinLauncher._userId;
                caseSummary.record_modified_by = ApplicatinLauncher._userId;
                if (btnSave.Text == "Save")
                    result = caseSummaryBLL.AddCaseSummary(caseSummary, admissionBO);
                else
                {
                    caseSummary.CaseSummaryID = Convert.ToInt32(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));
                    result = caseSummaryBLL.CaseSummaryUpdate(caseSummary);
                }
                if (result > 0)
                    MessageBox.Show("Data Saved Successfully");
                btnSave.Enabled = false;
                btnDischarge.Enabled = false;
                lvwPatientInfo.Enabled = false;
                discharge("Discharge Preview", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
            }
            catch
            {
            }

        }

        private void cmbtreat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OperationNoteBLL OperationNoteBLL = new OperationNoteBLL();
                int procID = Convert.ToInt32(((DataRowView)(cmbtreat.SelectedItem)).Row[0].ToString());
                DataSet ds = OperationNoteBLL.getprocedureforOT(procID);
                txtProcedure.Text = "";
                if (ds.Tables[0].Rows.Count > 0)
                    txttreatment_procedure.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
            }

        }

        private void discharge(string code,int k)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DischargeReport();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@admission_idD", k);
                rptCustomersOrders.SetParameterValue("@dischargeparameter", code);//@adm_id
                rptCustomersOrders.SetParameterValue("@admiss_id", k);
                rptCustomersOrders.SetParameterValue("@admission_id", k);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            try
            {
                if(lvwPatientInfo.SelectedItems.Count>0)
                    discharge("Discharge Preview", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                else
                    MessageBox.Show("Select A Patient From List");
            }
            catch
            {
            }
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            this.NetPayable();
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    this.NetPayable();

                }
            }
            catch
            {
                MessageBox.Show("Error21");
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

        
   

        
    }
}
