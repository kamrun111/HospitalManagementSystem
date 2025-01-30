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
using NewHIMS.Reports.ICU;
using NewHIMS.Reports;


namespace NewHIMS.Forms.ICU
{
    public partial class FrmDischargedNote : Form
    {

        CommonClass cs = new CommonClass();

        int admissionID = 0;


        public FrmDischargedNote()
        {
            InitializeComponent();
        }

        private void FrmDischargedNote_Load(object sender, EventArgs e)
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
                if (ds.Tables[8].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientInfo, ds, 8);
                }
                if (ds.Tables[4].Rows.Count > 0)
                {
                    PopulateComboBox(cmbtreat, ds, 4, "treatement", "treatement_id");
                }

                txtpatientname.Text = "";
                txtpatientage.Text = "";
                txtadmissiondate.Text = "";
                txtpatientcode.Text = "";
                txtadmissioncode.Text = "";//rehID
                txtcabinNo.Text = "";
                txtchiefcomplain.Text = "";
                txtpresentstatus.Text = "";
                txthospital_medication.Text = "";
                txtmedication.Text = "";
                txtadvice.Text = "";
                txttreatment_procedure.Text = "";
                cmbtreat.Text = "";
                btnSave.Text = "Save";
                txtDutyDoctorName.Text = "";
                lvwPatientInfo.Enabled = true;
                btnSave.Enabled = true;
                btnDischarged.Enabled = true;
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
                    txttreatment_procedure.Text = "";

                    btnDischarged.Enabled = true;

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
                        DataSet ds = admissionBLL.getcasesummaryID_ICU(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txtchiefcomplain.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtpresentstatus.Text = ds.Tables[0].Rows[0][1].ToString();
                            txthospital_medication.Text = ds.Tables[0].Rows[0][2].ToString();
                            txtmedication.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtadvice.Text = ds.Tables[0].Rows[0][4].ToString();
                            cmbtreat.Text = ds.Tables[0].Rows[0][5].ToString();
                            txttreatment_procedure.Text = ds.Tables[0].Rows[0][6].ToString();
                            txtDutyDoctorName.Text = ds.Tables[0].Rows[0][7].ToString();
                            cmbType.SelectedText = ds.Tables[0].Rows[0][8].ToString();
                            txtTypeRemarks.Text = ds.Tables[0].Rows[0][9].ToString();
                        }
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
                    result = caseSummaryBLL.AddCaseSummaryICU(caseSummary, admissionBO);
                else
                {
                    caseSummary.CaseSummaryID = Convert.ToInt32(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[9].Text));
                    result = caseSummaryBLL.CaseSummaryUpdateICU(caseSummary);
                }
                if (result > 0)
                    MessageBox.Show("Data Saved Successfully");
                btnSave.Enabled = false;
                //btnDischarge.Enabled = false;
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

        private void btnpreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    discharge("Discharge Preview", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                }
                else
                {
                    MessageBox.Show("Select A Patient From List");
                }
            }
            catch
            {
            }
        }


        private void discharge(string code, int k)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DischargeReportICU();

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
                //rptCustomersOrders.SetParameterValue("@admission_id", k);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshInvestigation();
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDischarged_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {

                    if (MessageBox.Show("Do you want to Discharge the Patient?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    AdmissionBLL admissionBLL = new AdmissionBLL();
                    admissionBLL.SetDischargeInfoICU(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text), this.lvwPatientInfo.SelectedItems[0].SubItems[1].Text, ApplicatinLauncher._userId);
                    MessageBox.Show("Patient Discharged Successfully");
                    discharge("Discharge", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                    RefreshInvestigation();
                    //ClearAll();
                }

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

    }
}
