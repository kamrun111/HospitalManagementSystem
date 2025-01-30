using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Dialysis;
using NewHIMS.Reports.Admission;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Payment;
using NewHIMS.Reports.ICU;
using System.Data.SqlClient;
using HIMS.DAL;



namespace NewHIMS.Forms.ICU
{
    public partial class FrmICUAdmission : Form
    {

        private string _nextPatientCode = "";
        private int _paymentID = 0;
        private int AdmissionID = 0;
        private int pamentid = 0;

        CommonClass cs = new CommonClass();


        public FrmICUAdmission()
        {
            InitializeComponent();
        }

        private void FrmICUAdmission_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshAdmission();
            }
            catch
            {
            }
        }


        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                //combo.SelectedIndex = -1;
                //combo.Text = "<Select>";
            }
            catch
            {
            }
        }

        void RefreshAdmission()
        {
            try
            {
                AdmissionBLL admissionBLL = new AdmissionBLL();
                DataSet ds = admissionBLL.GetAdmissionPopulationInfo();
                PopulateComboBox(cmbGuardianRelation, ds, 0, "guardian_relation", "guardian_relation_id");
                PopulateComboBox(cmbGender, ds, 1, "gender", "gender_id");
                PopulateComboBox(cmbOccupation, ds, 2, "occupation", "occupation_id");
                PopulateComboBox(cmbCity, ds, 3, "city", "city_id");
                PopulateComboBox(cmbBedNo, ds, 16, "bed_no", "bed_no_id");
                PopulateComboBox(cmbReligion, ds, 5, "religion", "religion_id");
                PopulateComboBox(cmbAdmissionType, ds, 17, "admission_type", "admission_type_id");
                PopulateComboBox(cmbRefferedDoctors, ds, 7, "reffDoc", "reffered_doctors_id");
                this.cmbRefferedDoctors.Text = "<Select>";
                this.cmbAdmissionType.Text = "<Select>";
                this.cmbBedNo.Text = "<Select>";

                ResetPatientContents();
                //ResetRefferedDocContents();

                txtAdmissionCode.Text = "0" + (Convert.ToInt32(ds.Tables[12].Rows[0][1]) + 1).ToString();
                this._nextPatientCode = (Convert.ToInt32(ds.Tables[13].Rows[0][0]) + 1).ToString("0000000#");
                txtPatientCode.Text = this._nextPatientCode;
                dtpDOB.BackColor = Color.Linen;
                AdmissionID = 0;

                //btnPrint.Enabled = false;
                //btnSave.Enabled = true;
            }
            catch
            {
            }
        }

        void ResetPatientContents()
        {
            txtCaseNo.Text = "";
            txtPatientName.Text = "";
            txtGuardianName.Text = "";
            txtAddress.Text = "";
            txtCPhone.Text = "";
            txtDeposit.Text = "";
            cmbGuardianRelation.Text = "<Select>";
            cmbGender.Text = "<Select>";
            cmbOccupation.Text = "<Select>";
            cmbCity.SelectedIndex = 0;
            dtpDOB.Text = DateTime.Now.ToString();
            txtAgeYy.Text = "00";
            txtAgeMm.Text = "00";
            txtAgeDd.Text = "00";
            cmbBedNo.Text = "<Select>";
            cmbAdmissionType.Text = "<Select>";
            cmbReligion.SelectedIndex = 0;
            //EnablePatientContents(false);

        }

        void EnablePatientContents(Boolean value)
        {
            txtPatientName.Enabled = value;
            txtGuardianName.Enabled = value;
            cmbGuardianRelation.Enabled = value;
            cmbGender.Enabled = value;
            cmbOccupation.Enabled = value;
            cmbCity.Enabled = value;
            txtAddress.Enabled = value;
            txtCPhone.Enabled = value;
            dtpDOB.Enabled = value;
            cmbBedNo.Enabled = value;
            cmbAdmissionType.Enabled = value;
            cmbReligion.Enabled = value;
            txtAgeYy.Enabled = value;
            txtAgeMm.Enabled = value;
            txtAgeDd.Enabled = value;
        }

        private void lnkNewPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                btnSave.Enabled = true;
                ResetPatientContents();
                EnablePatientContents(true);
                txtPatientCode.Text = this._nextPatientCode;
                txtPatientCode.Text = "";
                txtPatientCode.Enabled = false;
                //ResetRefferedDocContents();
                txtDeposit.Enabled = true;
                //btnSaveRefferedDoctor.Text = "Save";
                btnPrint.Enabled = false;
            }
            catch
            {
            }
        }

        private void lnkSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                txtPatientCode.Text = "";
                txtPatientCode.Enabled = true;
                ResetPatientContents();
                txtPatientCode.Focus();
                txtPatientCode.ReadOnly = false;
                //ResetRefferedDocContents();
                //btnSaveRefferedDoctor.Text = "Save";
                btnPrint.Enabled = true;
            }
            catch
            {
            }
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime now = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy"));
                if (now.CompareTo(Convert.ToDateTime(this.dtpDOB.Text)) > 0)
                {
                    int year = 0;
                    int month = 0;
                    int day = 0;

                    FormHelper.CalculateAge(Convert.ToDateTime(this.dtpDOB.Text), out year, out month, out day);
                    this.txtAgeYy.Text = year.ToString();
                    this.txtAgeDd.Text = day.ToString();
                    this.txtAgeMm.Text = month.ToString();
                }
                else
                {
                    this.txtAgeYy.Text = "0";
                    this.txtAgeDd.Text = "0";
                    this.txtAgeMm.Text = "0";
                }
            }
            catch
            {
                dtpDOB.BackColor = Color.Magenta;
            }
        }

        private void txtCPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == 13)
                {
                    dtpDOB.Focus();
                }
            }
            catch
            {
            }
        }

        private void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPatientCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (txtPatientCode.Text != "")
                    {
                        Patient patient = new Patient();
                        PatientBLL patientBLL = new PatientBLL();
                        GenderBLL genderBLL = new GenderBLL();
                        CityBLL cityBLL = new CityBLL();
                        GuardianRelationBLL gRelationBLL = new GuardianRelationBLL();
                        OccupationBLL occupationBLL = new OccupationBLL();
                        NationalityBLL nationalityBLL = new NationalityBLL();
                        ReligionBLL religionBLL = new ReligionBLL();
                        PatientConditionBLL patientConditionBLL = new PatientConditionBLL();
                        AdmissionBLL admissionBLL = new AdmissionBLL();

                        patient = patientBLL.IPDpatientGet(txtPatientCode.Text);


                        if (patient.patient_name == null && patient.guardian_name == null && patient.address == null)
                        {
                            MessageBox.Show("No Patient found");
                            txtPatientCode.Text = "";
                            txtPatientCode.Focus();
                            return;
                        }

                        txtPatientCode.Text = Convert.ToInt32(patient.patient_code).ToString("0000000#");

                        if (patient.patient_name != null)
                        {
                            txtPatientName.Text = patient.patient_name.ToString();

                        }

                        if (patient.guardian_name != null)
                            txtGuardianName.Text = patient.guardian_name;

                        if (patient.guardian_relation_id != null)
                            if (gRelationBLL.Getguardian_relation(Convert.ToInt32(patient.guardian_relation_id)).guardian_relation != null)
                                cmbGuardianRelation.Text = gRelationBLL.Getguardian_relation(Convert.ToInt32(patient.guardian_relation_id)).guardian_relation.ToString();

                        if (patient.gender_id != null)
                            if (genderBLL.Getgender(Convert.ToInt32(patient.gender_id)).gender != null)
                                cmbGender.Text = genderBLL.Getgender(Convert.ToInt32(patient.gender_id)).gender.ToString();

                        if (patient.occupation_id != null)
                            if (occupationBLL.Getoccupation(Convert.ToInt32(patient.occupation_id)).occupation != null)
                                cmbOccupation.Text = occupationBLL.Getoccupation(Convert.ToInt32(patient.occupation_id)).occupation.ToString();

                        if (patient.address != null)
                            txtAddress.Text = patient.address;

                        if (patient.city_id != null)
                        {
                            ////int CityId = Convert.ToInt16(patient.city_id);
                            ////cmbCity.SelectedValue = CityId;
                            if (cityBLL.Getcity(Convert.ToInt32(patient.city_id)).city != null)
                                cmbCity.Text = cityBLL.Getcity(Convert.ToInt32(patient.city_id)).city.ToString();
                        }

                        if (patient.c_phone != null)
                            txtCPhone.Text = patient.c_phone.ToString();

                        if (patient.dob != null)
                            dtpDOB.Text = patient.dob.ToString();
                        dtpDOB_Leave(null, null);

                        //if (patient.nationality_id != null)
                        //    if (nationalityBLL.Getnationality(Convert.ToInt32(patient.nationality_id)).nationality != null)
                        //        cmbNationality.Text = nationalityBLL.Getnationality(Convert.ToInt32(patient.nationality_id)).nationality.ToString();

                        if (patient.religion_id != null)
                            if (religionBLL.Getreligion(Convert.ToInt32(patient.religion_id)).religion != null)
                                cmbReligion.Text = religionBLL.Getreligion(Convert.ToInt32(patient.religion_id)).religion.ToString();

                        //if (patient.patient_condition_id != null)
                        //    if (patientConditionBLL.Getpatient_condition(Convert.ToInt32(patient.patient_condition_id)).patient_condition != null)
                        //        cmbPatientCondition.Text = patientConditionBLL.Getpatient_condition(Convert.ToInt32(patient.patient_condition_id)).patient_condition.ToString();

                        //AdmissionBLL admissionBLL = new AdmissionBLL();
                        //txtCaseNo.Text = ((DataSet)admissionBLL.AdmissionCaseNoGet(txtPatientCode.Text)).Tables[0].Rows[0][0].ToString();
                        //EnablePatientContents(true);
                        //txtPatientCode.ReadOnly = true;
                        btnSave.Enabled = true;

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

                int patientID = 0;
                int admissionID = 0;
                int paymentID = 0;
                string GRID = "";
                int gurdian_relation = 0;
                string CityID = "";
                int city_id = 0;
                string OccupID = "";
                int occupation_id = 0;
                string NationID = "";
                int nationality_id = 0;
                string RelID = "";
                int religion_id = 0;
                string GenderID = "";
                int gender_id = 0;
                string PConID = "";
                int patient_condition = 0;

                Patient patient = new Patient();
                AdmissionBO admission = new AdmissionBO();
                AdmissionBLL admissionBLL = new AdmissionBLL();
                PatientBLL patientBLL = new PatientBLL();

                patient.patient_type = "IPD";
                if (txtPatientName.Text != "")
                    patient.patient_name = txtPatientName.Text.ToString();
                else
                {
                    MessageBox.Show("Input a Patient Name");
                    txtPatientName.Focus();
                    return;
                }

                if (txtGuardianName.Text != "")
                {
                    patient.guardian_name = txtGuardianName.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Select Guardian Name");
                    txtGuardianName.Focus();
                    return;
                }
                if (cmbGuardianRelation.Text != "<Select>" && cmbGuardianRelation.Text != "")
                {
                    GRID = cmbGuardianRelation.Text;
                    gurdian_relation = Convert.ToInt32(cmbGuardianRelation.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Select Guardian Relation");
                    cmbGuardianRelation.Focus();
                    return;
                }

                if (cmbGender.Text != "<Select>" && cmbGender.Text != "")
                {
                    GenderID = cmbGender.Text;
                    gender_id = Convert.ToInt32(cmbGender.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Select Patient's Gender");
                    cmbGender.Focus();
                    return;
                }
                if (cmbOccupation.Text != "<Select>" && cmbOccupation.Text != "")
                {
                    OccupID = cmbOccupation.Text;
                    occupation_id = Convert.ToInt32(cmbOccupation.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Select Patient's Occupation");
                    cmbOccupation.Focus();
                    return;
                }
                if (txtAddress.Text != "")
                {
                    patient.address = txtAddress.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Input Address");
                    txtAddress.Focus();
                    return;
                }

                if (txtCPhone.Text != "")
                {
                    patient.c_phone = txtCPhone.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Input Cell Phone");
                    txtCPhone.Focus();
                    return;
                }

                if (Convert.ToDateTime(dtpDOB.Text) > DateTime.Now)
                {
                    MessageBox.Show("Input a valid DOB");
                    dtpDOB.Focus();
                    return;
                }

                patient.dob = Convert.ToDateTime(dtpDOB.Text);
                NationID = "Bangladeshi";
                nationality_id = 1;
               
                if (cmbReligion.Text != "<Select>" && cmbReligion.Text != "")
                {
                    RelID = cmbReligion.Text;
                    religion_id = Convert.ToInt32(cmbReligion.SelectedValue);
                }
                

                if (cmbCity.Text != "<Select>" && cmbCity.Text != "")
                {
                    CityID = cmbCity.Text;
                    city_id = Convert.ToInt32(cmbCity.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Select Patient's City");
                    cmbCity.Focus();
                    return;
                }

                if (Convert.ToInt32(cmbBedNo.SelectedValue)<=0)
                {
                    MessageBox.Show("Please Select Cabin from List");
                    return;
                }
                

                PConID = "Normal";
                patient_condition = 1;


                admission.admission_date = DateTime.Now;

                

                if (txtDeposit.Text != "")
                {
                    admission.deposit = Convert.ToInt32(txtDeposit.Text);
                }
                else
                {
                    if (MessageBox.Show("Do you want to save without any deposit", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        txtDeposit.Focus();
                        return;
                    }
                    else
                    {
                        admission.deposit = 0;
                    }
                }
                admission.cabin_id = Convert.ToInt32(cmbBedNo.SelectedValue);
                admission.is_bill_clear = 0;
                admission.is_biscount_clear = Convert.ToInt32(cmbAdmissionType.SelectedValue);
                admission.record_created_by = ApplicatinLauncher._userId;

                DataSet dsPID = patientBLL.GetPtientSearch("@patient_code", txtPatientCode.Text.ToString(), "GetPatientSearchByHospitalID", 0);

                if (dsPID.Tables[1].Rows.Count > 0)
                {
                    patientID = Convert.ToInt32(dsPID.Tables[1].Rows[0][0]);
                    patient.patient_id = patientID;
                    patient.patient_code = txtPatientCode.Text;
                    patient.record_modified_by = ApplicatinLauncher._userId;
                    patientBLL.UpdatePatientForDialysis(patient, gurdian_relation, city_id, occupation_id, nationality_id, religion_id, gender_id, patient_condition);   //sp->  <patientUpdate>
                    admission.patient_id = patientID;
                    //Pay pay=new Pay();
                    //pay.amount=Convert.ToDecimal(txtDeposit.Text);
                    //pay.record_created_by= ApplicatinLauncher._userId;
                    if (txtDeposit.Text != "")
                        admissionID = admissionBLL.AddadmissionICU(admission, out paymentID, 1);
                    else
                        admissionID = admissionBLL.AddadmissionICU(admission, out paymentID, 0);

                    //if(txtDeposit.Text!="")
                    //admissionID = admissionBLL.newadmissionAdd(admission, pay);

                    this._paymentID = paymentID;
                }
                else
                {
                    if (txtDeposit.Text != "")
                        admissionID = patientBLL.AddPatientAdmissionForICU(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, 1);
                    else
                        admissionID = patientBLL.AddPatientAdmissionForICU(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, 0);

                    this._paymentID = paymentID;
                }

                if (admissionID > 0)
                {
                    btnSave.Enabled = false;
                    InsertPatientRefferedDoc(admissionID);
                    MessageBox.Show("Data Saved Successfully");
                    //UpdateCabinStatus(Convert.ToInt32(cmbBedNo.SelectedValue));
                    

                    if (txtCaseNo.Text == "")
                    {
                        PrintAdmissionReport(admissionID);
                        if (txtDeposit.Text != "")
                        {
                            AdmissionID = admissionID;
                            PrintInvoice(paymentID);
                        }
                    }
                    else
                    {
                        PrintAdmissionReport(admissionID);
                        if (txtDeposit.Text != "")
                        {
                            AdmissionID = admissionID;
                            PrintInvoice(paymentID);
                        }
                    }

                    RefreshAdmission();
                }
                else
                    MessageBox.Show("Data Save Failed", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
            }
        }

        //void UpdateCabinStatus(int cabinID)
        //{
        //    try
        //    {
        //        SqlConnection conn = DbHelper.GetOpenConnection();
        //        SqlCommand cmd;
        //        string strSQL = "update bed_no set status=3 where bed_no_id='" + cabinID + "'";
        //        cmd = new SqlCommand(strSQL, conn);
        //        cmd.ExecuteNonQuery();
        //        DbHelper.CloseConnection(conn);
        //    }
        //    catch
        //    {
        //    }
        //}

        void InsertPatientRefferedDoc(int admissionID)
        {
            try
            {
                PatientRefferedDoctors patientReffDoc = new PatientRefferedDoctors();
                PatientRefferedDoctorsBLL patientReffDocBLL = new PatientRefferedDoctorsBLL();

                patientReffDoc.admission_id = admissionID;
                patientReffDoc.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
                patientReffDocBLL.Addpatient_reffered_doctors_icu(patientReffDoc);
                
            }
            catch
            {
            }
        }

        public void PrintInvoice(int paymentID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ICUPaymentInvoice();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //rptCustomersOrders.SetParameterValue("@admission_id", AdmissionID);
                rptCustomersOrders.SetParameterValue("@payID", paymentID);
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

        void PrintAdmissionReport(int admissionID)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;

                ReportDocument rptCustomersOrders = new rptAdmissionICU();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@adm_id", admissionID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void cmbAdmissionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdmissionType.SelectedIndex > -1)
                {
                    cmbBedNo.DataSource=null;

                    DataSet ds = cs.GetDataSetWithParameter("@ID", Convert.ToInt32(cmbAdmissionType.SelectedValue), "BedNoTypeWise");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cs.PopulateComboBox(cmbBedNo, ds, 0, "bed_no", "bed_no_id");
                    }
                }
                
            }
            catch
            {
            }
        }

        private void txtAgeYy_Leave(object sender, EventArgs e)
        {
            try
            {
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void txtAgeYy_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
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
            RefreshAdmission();
        }




    }
}
