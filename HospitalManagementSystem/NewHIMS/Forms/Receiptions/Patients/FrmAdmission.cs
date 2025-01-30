using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;
using NewHIMS.Reports;
using NewHIMS.Forms.Doctor_Station;
using NewHIMS.Reports.Admission;
using NewHIMS.Reports.Payment;
using NewHIMS.Forms.Investigation;
using NewHIMS.Forms.Common;

namespace NewHIMS.Forms.Receiptions.Patients.Admission
{
    public partial class FrmAdmission : BaseForm.FrmBase
    {
        private string _nextPatientCode = "";
        private int _paymentID = 0;
        private int AdmissionID = 0;
        private int pamentid = 0;

        public FrmAdmission()
        {
            InitializeComponent();
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

        void PopulateCabinListView(DataSet ds)
        {
            try
            {
                lvwCabin.Items.Clear();
                for (int i = 0; i < ds.Tables[8].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[8].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());

                        lvwCabin.Items.Add(lvi);
                        if (dataRow[2].ToString() == "Free")
                            lvi.ForeColor = Color.Teal;
                        else if (dataRow[2].ToString() == "Occupied")
                            lvi.ForeColor = Color.PowderBlue;
                        else if (dataRow[2].ToString() == "Booked")
                            lvi.ForeColor = Color.Maroon;
                    }
                }
            }
            catch { 
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
                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }


        void ResetRefferedDocContents1()
        {
            txtRefferedDoctors.Text = "";
            txtDC.Text = "";
            txtDegree.Text = "";
            txtAttachment.Text = "";
            txtContactNo.Text = "";
            txtMobile.Text = "";
            textBox1.Text = "";
            //cmbRefferedDoctors.Text = "<Select>";
            cmbDoctorLevel.Text = "<Select>";
            cmbSpecialistIn.Text = "<Select>";
            cmbDesignation.Text = "<Select>";
            cmbDGender.Text = "<Select>";
            cmbDCity.Text = "<Select>";
        }

        void ResetRefferedDocContents()
        {
            txtRefferedDoctors.Text = "";
            txtDC.Text = "";
            txtDegree.Text = "";
            txtAttachment.Text = "";
            txtContactNo.Text = "";
            txtMobile.Text = "";
            textBox1.Text = "";
            cmbRefferedDoctors.Text = "<Select>";
            cmbDoctorLevel.Text = "<Select>";
            cmbSpecialistIn.Text = "<Select>";
            cmbDesignation.Text = "<Select>";
            cmbDGender.Text = "<Select>";
            cmbDCity.Text = "<Select>";
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
            cmbCity.SelectedIndex=0;
            dtpDOB.Text = DateTime.Now.ToString();
            txtAgeYy.Text = "00";
            txtAgeMm.Text = "00";
            txtAgeDd.Text = "00";
            cmbNationality.SelectedIndex = 0;
            cmbPatientCondition.SelectedIndex = 0;
            cmbReligion.SelectedIndex = 0;
            EnablePatientContents(false);
            lvwReffDoctors.Items.Clear();
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
            cmbNationality.Enabled = value;
            cmbPatientCondition.Enabled = value;
            cmbReligion.Enabled = value;
            txtAgeYy.Enabled = value;
            txtAgeMm.Enabled = value;
            txtAgeDd.Enabled=value;
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
                PopulateComboBox(cmbNationality, ds, 4, "nationality", "nationality_id");
                PopulateComboBox(cmbReligion, ds, 5, "religion", "religion_id");
                PopulateComboBox(cmbPatientCondition, ds, 6, "patient_condition", "patient_condition_id");
                PopulateComboBox(cmbRefferedDoctors, ds, 7, "reffDoc", "reffered_doctors_id");
                this.cmbRefferedDoctors.Text = "<Select>";
                PopulateCabinListView(ds);
                PopulateComboBox(cmbDoctorLevel, ds, 9, "doctor_level", "doctor_level_id");
                PopulateComboBox(cmbSpecialistIn, ds, 10, "specialist_in", "specialist_in_id");
                PopulateComboBox(cmbDesignation, ds, 11, "designation", "designation_id");
                PopulateComboBox(cmbDGender, ds, 14, "gender", "gender_id");
                PopulateComboBox(cmbDCity, ds, 15, "city", "city_id");
                ResetPatientContents();
                ResetRefferedDocContents();
                lvwReffDoctors.Items.Clear();
                txtAdmissionCode.Text ="0"+ (Convert.ToInt32(ds.Tables[12].Rows[0][1]) + 1).ToString();
                this._nextPatientCode = (Convert.ToInt32(ds.Tables[13].Rows[0][0]) + 1).ToString("0000000#");
                txtPatientCode.Text = this._nextPatientCode;
                dtpDOB.BackColor = Color.Linen;
                AdmissionID = 0;
                btnSaveRefferedDoctor.Text = "Save";
                btnPrint.Enabled = false;
                //btnSave.Enabled = true;
            }
            catch { 
            }
        }

        private void FrmAdmission_Load(object sender, EventArgs e)
        {
            this.cmbRefferedDoctors.SelectedIndexChanged -= this.cmbRefferedDoctors_SelectedIndexChanged;
            RefreshAdmission();
            cmbRefferedDoctors.SelectedIndexChanged += new EventHandler(cmbRefferedDoctors_SelectedIndexChanged);
            this.cmbRefferedDoctors.Text = "<Select>";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRefferedDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                //if (cmbRefferedDoctors.Text == "<Select>")
                //{
                //    MessageBox.Show("Select A Doctor From The List");
                //    cmbRefferedDoctors.Focus();
                //    return;
                //}
                string value;
                if (cmbRefferedDoctors.Text != "" && cmbRefferedDoctors.Text != "<Select>")
                {
                    if (IsMatchReffDoctor(cmbRefferedDoctors.Text) == false)
                    {
                        value = ((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[1].ToString();
                        ListViewItem lvi;
                        lvi = lvwReffDoctors.Items.Add(value);
                        lvi.SubItems.Add(cmbRefferedDoctors.Text.ToString());
                        lvi.SubItems.Add("0");
                    }
                    else
                        MessageBox.Show(cmbRefferedDoctors.Text + " is already exist");
                }
            }
            catch { 
            }
        }


        public Boolean IsMatchReffDoctor(string value)
        {
            try
            {
                for (int i = 0; i < lvwReffDoctors.Items.Count; i++)
                {
                    if (lvwReffDoctors.Items[i].SubItems[1].Text == value)
                        return true;
                }
            }
            catch { 
            }
            return false;
        }
        public Boolean IsMatchReffDoctor(int doctorId)
        {
            try
            {
                if (lvwReffDoctors.Items.Count == 0)
                    return false;
                else
                {
                    for (int i = 0; i < lvwReffDoctors.Items.Count; i++)
                    {
                        if (Convert.ToInt32(lvwReffDoctors.Items[i].SubItems[0].Text) == doctorId)
                            return true;
                    }
                }
            }
            catch
            {
            }
            return false;
        }
        public void LoadDoctorNameInListView(int id, string Name)
        {
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(Name);
            item.SubItems.Add("0");
            lvwReffDoctors.Items.Add(item);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAdmission();
        }

        private void cmbRefferedDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRefferedDoctors.SelectedIndex == -1) return;

                if (cmbRefferedDoctors.SelectedItem != null)
                {
                    RefferedDoctors reffDoc = new RefferedDoctors();
                    RefferedDoctorsDAL reffDocDAL = new RefferedDoctorsDAL();
                    DoctorLevelBLL docLevelBLL = new DoctorLevelBLL();
                    SpecialistInBLL specialistInBLL = new SpecialistInBLL();
                    DesignationBLL designationBLL = new DesignationBLL();
                    GenderBLL genderBLL = new GenderBLL();
                    CityBLL cityBLL = new CityBLL();

                    ResetRefferedDocContents1();
                    string strDocID = ((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[1].ToString();
                    reffDoc = reffDocDAL.Getreffered_doctors(Convert.ToInt32(strDocID));

                    if (reffDoc.reffered_doctors != null)
                    {
                        txtRefferedDoctors.Text = reffDoc.reffered_doctors.ToString();
                        btnSaveRefferedDoctor.Enabled = false;
                    }
                    if (reffDoc.d_c != null)
                        txtDC.Text = reffDoc.d_c.ToString();

                    if (reffDoc.degree != null)
                        txtDegree.Text = reffDoc.degree.ToString();

                    if (reffDoc.doctor_level_id != null)
                        if (docLevelBLL.Getdoctor_level(Convert.ToInt32(reffDoc.doctor_level_id)).doctor_level != null)
                            cmbDoctorLevel.Text = docLevelBLL.Getdoctor_level(Convert.ToInt32(reffDoc.doctor_level_id)).doctor_level.ToString();

                    if (reffDoc.specialist_in_id != null)
                        if (specialistInBLL.Getspecialist_in(Convert.ToInt32(reffDoc.specialist_in_id)).specialist_in != null)
                            cmbSpecialistIn.Text = specialistInBLL.Getspecialist_in(Convert.ToInt32(reffDoc.specialist_in_id)).specialist_in.ToString();

                    if (reffDoc.designation_id != null)
                        if (designationBLL.Getdesignation(Convert.ToInt32(reffDoc.designation_id)).designation != null)
                            cmbDesignation.Text = designationBLL.Getdesignation(Convert.ToInt32(reffDoc.designation_id)).designation.ToString();
                    if (reffDoc.gender_id != null)
                        if (genderBLL.Getgender(Convert.ToInt32(reffDoc.gender_id)).gender != null)
                            cmbDGender.Text = genderBLL.Getgender(Convert.ToInt32(reffDoc.gender_id)).gender.ToString();

                    if (reffDoc.attachment != null)
                        txtAttachment.Text = reffDoc.attachment.ToString();

                    if (reffDoc.contact_no != null)
                        txtContactNo.Text = reffDoc.contact_no.ToString();

                    if (reffDoc.mobile != null)
                        txtMobile.Text = reffDoc.mobile.ToString();

                    if (reffDoc.address != null)
                        textBox1.Text = reffDoc.address.ToString();

                    if (reffDoc.city_id != null)
                    {
                        //int CityId = 0;
                        int CityId = Convert.ToInt16(reffDoc.city_id);
                        cmbDCity.SelectedValue = CityId;
                        //if (cityBLL.Getcity(Convert.ToInt32(reffDoc.city_id)).city != null)
                        //    cmbDCity.Text = cityBLL.Getcity(Convert.ToInt32(reffDoc.city_id)).city.ToString();
                    }
                    //btnSaveRefferedDoctor.Text = "Update";
                }
            }
            catch { 
            }
        }

        private void btnSaveRefferedDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                AdmissionBLL admBLL = new AdmissionBLL();
                RefferedDoctors reffDoc = new RefferedDoctors();
                RefferedDoctorsBLL reffDocBLL = new RefferedDoctorsBLL();

                string value;
                if (txtRefferedDoctors.Text != "<Select" || txtRefferedDoctors.Text!="")
                {
                    reffDoc.reffered_doctors = txtRefferedDoctors.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Input a Reffered Doctor");
                    txtRefferedDoctors.Focus();
                    return;
                }

                if (txtDC.Text != "")
                {
                    reffDoc.d_c = txtDC.Text.ToString();
                }

                if (txtDegree.Text != "")
                {
                    reffDoc.degree = txtDegree.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Input Doctor's Degree");
                    txtDegree.Focus();
                    return;
                }

                if (cmbDoctorLevel.Text != "<Select>" && cmbDoctorLevel.Text != "" && cmbDoctorLevel.SelectedIndex!=-1)
                {
                    value = ((DataRowView)(cmbDoctorLevel.SelectedItem)).Row[0].ToString();
                    reffDoc.doctor_level_id = Convert.ToInt32(value);
                }
                else
                {
                    MessageBox.Show("Input Doctor's Level");
                    cmbDoctorLevel.Focus();
                    return;
                }

                if (cmbSpecialistIn.Text != "<Select>" && cmbSpecialistIn.Text != "" && cmbSpecialistIn.SelectedIndex != -1)
                {
                    value = ((DataRowView)(cmbSpecialistIn.SelectedItem)).Row[0].ToString();
                    reffDoc.specialist_in_id = Convert.ToInt32(value);
                }
                else
                {
                    MessageBox.Show("Input Doctor's Specialist In");
                    cmbSpecialistIn.Focus();
                    return;
                }

                if (cmbDesignation.Text != "<Select>" && cmbDesignation.Text != "" && cmbDesignation.SelectedIndex != -1)
                {
                    value = ((DataRowView)(cmbDesignation.SelectedItem)).Row[0].ToString();
                    reffDoc.designation_id = Convert.ToInt32(value);
                }
                else
                {
                    MessageBox.Show("Input Doctor's Designation");
                    cmbDesignation.Focus();
                    return;
                }

                if (cmbDGender.Text != "<Select>" && cmbDGender.Text != "" && cmbDGender.SelectedIndex != -1)
                {
                    value = ((DataRowView)(cmbDGender.SelectedItem)).Row[0].ToString();
                    reffDoc.gender_id = Convert.ToInt32(value);
                }
                else
                {
                    MessageBox.Show("Input Doctor's Gender");
                    cmbDGender.Focus();
                    return;
                }


                if (txtAttachment.Text != "")
                    reffDoc.attachment = txtAttachment.Text.ToString();

                if (txtContactNo.Text != "")
                    reffDoc.contact_no = txtContactNo.Text.ToString();
                else
                {
                    MessageBox.Show("Input Doctor's Contact No");
                    txtContactNo.Focus();
                    return;
                }

                if (txtMobile.Text != "")
                    reffDoc.mobile = txtMobile.Text.ToString();


                if (textBox1.Text != "")
                    reffDoc.address = textBox1.Text.ToString();

                if (cmbDCity.Text != "<Select>" && cmbDCity.Text != "" && cmbDCity.SelectedIndex != -1)
                {
                    value = ((DataRowView)(cmbDCity.SelectedItem)).Row[0].ToString();
                    reffDoc.city_id = Convert.ToInt32(value);
                }
                reffDoc.record_created_by = ApplicatinLauncher._userId;
                if(cmbRefferedDoctors.SelectedIndex!=-1)
                    reffDoc.reffered_doctors_id = Convert.ToInt16(cmbRefferedDoctors.SelectedValue);
                int res=0;
                if (btnSaveRefferedDoctor.Text == "Save")
                    res = reffDocBLL.Addreffered_doctors(reffDoc);
                //else
                //    res = reffDocBLL.Updatereffered_doctors(reffDoc);
                if(res>0)
                    MessageBox.Show("Data Saved Successfully");
                else
                    MessageBox.Show("Data Not Saved");

                DataSet ds = admBLL.GetAdmissionPopulationInfo();
                PopulateComboBox(cmbRefferedDoctors, ds, 7, "reffDoc", "reffered_doctors_id");
                ResetRefferedDocContents();
                grpRefferedDoctors.Visible = false;
                cmbRefferedDoctors.Visible = true;
            }
            catch
            {
            }
        }

        private void lnkNewPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSave.Enabled = true;
            ResetPatientContents();
            EnablePatientContents(true);
            txtPatientCode.Text = this._nextPatientCode;
            txtPatientCode.Text = "";
            txtPatientCode.Enabled = false;
            ResetRefferedDocContents();
            txtDeposit.Enabled = true;
            //btnSaveRefferedDoctor.Text = "Save";
            btnPrint.Enabled = false;
            
        }

        private void lnkSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPatientCode.Text = "";
            txtPatientCode.Enabled = true;
            ResetPatientContents();
            txtPatientCode.Focus();
            txtPatientCode.ReadOnly = false;
            ResetRefferedDocContents();
            //btnSaveRefferedDoctor.Text = "Save";
            btnPrint.Enabled = true;

        }

        private void txtPatientCode_KeyUp(object sender, KeyEventArgs e)
        {
             try{
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
                        DataSet dss = admissionBLL.Isdiacharge(Convert.ToInt16(txtPatientCode.Text));
                        if (dss.Tables[1].Rows.Count > 0)
                        {
                            FillUpListview(lvwReffDoctors, dss, 1);
                            //if (Convert.ToInt16(dss.Tables[0].Rows[0][0]) == 0)
                            //    btnSave.Enabled = false;


                        }
                        patient = patientBLL.IPDpatientGet(txtPatientCode.Text);

                        if (patient.patient_name == null && patient.guardian_name == null && patient.address == null)
                        {
                            MessageBox.Show("No Patient found");
                            lvwReffDoctors.Items.Clear();
                            FocusOutCabinList();
                            txtPatientCode.Text = "";
                            txtPatientCode.Focus();
                            return;
                        }

                        txtPatientCode.Text = Convert.ToInt32(patient.patient_code).ToString("0000000#");
                        if (patient.patient_name != null)
                        {
                            txtPatientName.Text = patient.patient_name.ToString();
                            btnEdit.Enabled = true;
                        }
                        else
                            btnEdit.Enabled = false;

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

                        if (patient.nationality_id != null)
                            if (nationalityBLL.Getnationality(Convert.ToInt32(patient.nationality_id)).nationality != null)
                                cmbNationality.Text = nationalityBLL.Getnationality(Convert.ToInt32(patient.nationality_id)).nationality.ToString();

                        if (patient.religion_id != null)
                            if (religionBLL.Getreligion(Convert.ToInt32(patient.religion_id)).religion != null)
                                cmbReligion.Text = religionBLL.Getreligion(Convert.ToInt32(patient.religion_id)).religion.ToString();

                        if (patient.patient_condition_id != null)
                            if (patientConditionBLL.Getpatient_condition(Convert.ToInt32(patient.patient_condition_id)).patient_condition != null)
                                cmbPatientCondition.Text = patientConditionBLL.Getpatient_condition(Convert.ToInt32(patient.patient_condition_id)).patient_condition.ToString();

                        //AdmissionBLL admissionBLL = new AdmissionBLL();
                        txtCaseNo.Text = ((DataSet)admissionBLL.AdmissionCaseNoGet(txtPatientCode.Text)).Tables[0].Rows[0][0].ToString();
                        EnablePatientContents(true);
                        txtPatientCode.ReadOnly = true;
                        if (dss.Tables[0].Rows.Count > 0)
                        {

                            if ((Convert.ToInt16(dss.Tables[0].Rows[0][0]) == 1 && (Convert.ToInt16(dss.Tables[0].Rows[0][4])==1)))
                                btnSave.Enabled = true;
                            else
                                btnSave.Enabled = false;
                            this.AdmissionID=Convert.ToInt16(dss.Tables[0].Rows[0][1]);
                            if (Convert.ToInt16(dss.Tables[0].Rows[0][2]) != 0)//to select refered doc
                            {
                                this.cmbRefferedDoctors.SelectedIndexChanged -= this.cmbRefferedDoctors_SelectedIndexChanged;
                                cmbRefferedDoctors.SelectedIndex = -1;
                                cmbRefferedDoctors.SelectedValue=(Convert.ToInt16(dss.Tables[0].Rows[0][2]));
                                cmbRefferedDoctors.SelectedIndexChanged+=new EventHandler(cmbRefferedDoctors_SelectedIndexChanged);
                            }
                            this.pamentid=Convert.ToInt16(dss.Tables[0].Rows[0][3]);
                            txtDeposit.Text = dss.Tables[0].Rows[0][3].ToString();
                            cmbRefferedDoctors.Focus();
                            if (btnSave.Enabled == false)
                            {
                                txtDeposit.Enabled = false;
                            }
                            else
                                txtDeposit.Text = "";


                        }
                        btnPrint.Enabled = true;
                        if (btnSave.Enabled == true)
                        {
                            txtDeposit.Enabled = true;
                            lvwReffDoctors.Items.Clear();
                        }
                        //btnSave.Enabled = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try{
                int cabinID = 0;
                int patientID = 0;
                int admissionID = 0;
                int paymentID=0;
                string GRID="";
                string CityID = "";
                string OccupID = "";
                string NationID = "";
                string RelID = "";
                string GenderID = "";
                string PConID = "";

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

                if (cmbNationality.Text != "<Select>" && cmbNationality.Text != "")
                {
                    NationID = cmbNationality.Text;
                }


                if (cmbReligion.Text != "<Select>" && cmbReligion.Text != "")
                {
                    RelID = cmbReligion.Text;
                }

                if (cmbCity.Text != "<Select>" && cmbCity.Text != "")
                {
                    CityID = cmbCity.Text;
                }
                else
                {
                    MessageBox.Show("Select Patient's City");
                    cmbCity.Focus();
                    return;
                }

                if (cmbPatientCondition.Text != "<Select>" && cmbPatientCondition.Text != "")
                {
                    PConID = cmbPatientCondition.Text;
                }
                admission.admission_date = DateTime.Now;

                if (lvwReffDoctors.Items.Count < 1)
                {
                    MessageBox.Show("Select Reffered Doctor(s)");
                    cmbRefferedDoctors.Focus();
                    return;
                }
                 
                if (lvwCabin.SelectedItems.Count > 0)
                {
                    if (lvwCabin.SelectedItems[0].SubItems[2].Text != null)
                    {
                        if (lvwCabin.SelectedItems[0].SubItems[2].Text != "Free")
                        {
                            MessageBox.Show("Select a Free Cabin");
                            lvwCabin.Focus();
                            return;
                        }
                        else
                        {
                            admission.cabin_id = Convert.ToInt32(lvwCabin.FocusedItem.Text);
                            cabinID = Convert.ToInt32(lvwCabin.FocusedItem.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a Cabin");
                    lvwCabin.Focus();
                    return;
                }

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
                admission.is_bill_clear = 0;
                admission.is_discharged = 0;
                admission.is_cc_written = 0;
                admission.is_history_written = 0;
                admission.is_first_reqular_checkup_done = 0;
                admission.remarks = "";
                admission.nurse_remarks = "";
                admission.record_created_by = ApplicatinLauncher._userId;
                 
                DataSet dsPID=patientBLL.GetPtientSearch("@patient_code", txtPatientCode.Text.ToString(), "GetPatientSearchByHospitalID",0);

                if (dsPID.Tables[1].Rows.Count > 0)
                {
                    patientID = Convert.ToInt32(dsPID.Tables[1].Rows[0][0]);
                    patient.patient_id = patientID;
                    patient.patient_code = txtPatientCode.Text;
                    patient.record_modified_by = ApplicatinLauncher._userId;
                    patientBLL.Updatepatient(patient, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID);   //sp->  <patientUpdate>
                    admission.patient_id = patientID;
                    //Pay pay=new Pay();
                    //pay.amount=Convert.ToDecimal(txtDeposit.Text);
                    //pay.record_created_by= ApplicatinLauncher._userId;
                    if(txtDeposit.Text!="")
                        admissionID= admissionBLL.Addadmission(admission,out paymentID,1);
                    else
                        admissionID = admissionBLL.Addadmission(admission, out paymentID,0);

                    //if(txtDeposit.Text!="")
                    //admissionID = admissionBLL.newadmissionAdd(admission, pay);
                    
                    this._paymentID = paymentID;
                }
                else 
                {
                    if(txtDeposit.Text!="")
                        admissionID = patientBLL.AddPatientAdmission(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID,1);
                    else
                        admissionID = patientBLL.AddPatientAdmission(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, 0);

                    this._paymentID = paymentID;
                }

                if (admissionID > 0)
                {
                    btnSave.Enabled = false;
                    InsertPatientRefferedDoc(admissionID);
                    MessageBox.Show("Data Saved Successfully");
                    //UpdateCabinStatus(cabinID);

                    if (txtCaseNo.Text == "")
                    {
                        PrintAdmissionReport(admissionID, 0, _paymentID);
                        if (txtDeposit.Text != "")
                        {
                            AdmissionID = admissionID;
                            PrintInvoice();
                        }
                    }
                    else
                    {
                        PrintAdmissionReport(admissionID, Convert.ToInt32(txtCaseNo.Text)+1, _paymentID);
                        if (txtDeposit.Text != "")
                        {
                            AdmissionID = admissionID;
                            PrintInvoice();
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

        void UpdateCabinStatus(int cabinID)
        {
            try{
                SqlConnection conn = DbHelper.GetOpenConnection();
                SqlCommand cmd;
                string strSQL = "update cabin set cabin_status_id=3 where cabin_id='" + cabinID + "'";
                cmd = new SqlCommand(strSQL, conn);
                cmd.ExecuteNonQuery();
                DbHelper.CloseConnection(conn);
            }
            catch
            {
            }
        }

        void InsertPatientRefferedDoc(int admissionID)
        {
             try{
                PatientRefferedDoctors patientReffDoc = new PatientRefferedDoctors();
                PatientRefferedDoctorsBLL patientReffDocBLL = new PatientRefferedDoctorsBLL();

                foreach (ListViewItem lvi in lvwReffDoctors.Items)
                {
                    patientReffDoc.admission_id = admissionID;
                    patientReffDoc.reffered_doctors_id = Convert.ToInt32(lvi.SubItems[0].Text);
                    patientReffDocBLL.Addpatient_reffered_doctors(patientReffDoc);
                }
            }
            catch
            {
            }
        }

        void PrintAdmissionReport(int admissionID, int caseNO,int PAYID)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                
                ReportDocument rptCustomersOrders = new rptAdmission();

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

                if (caseNO == 0)
                    rptCustomersOrders.SetParameterValue("@case_no", 1);
                else
                    rptCustomersOrders.SetParameterValue("@case_no", caseNO);
                                rptCustomersOrders.SetParameterValue("@adm_id", admissionID);

                                rptCustomersOrders.SetParameterValue("@paymentID", PAYID.ToString("00000#"));

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void btnRemoveRefferedDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwReffDoctors.SelectedItems.Count > 0)
                {
                    if ( btnSave.Enabled == true)
                        lvwReffDoctors.Items.Remove(lvwReffDoctors.FocusedItem);
                    else
                    {
                        PatientRefferedDoctors patientRefferedDoctors = new PatientRefferedDoctors();
                        PatientRefferedDoctorsBLL PatientRefferedDoctorsBLL = new PatientRefferedDoctorsBLL();
                        patientRefferedDoctors.patient_reffered_doctors_id=Convert.ToInt32(lvwReffDoctors.SelectedItems[0].SubItems[2].Text);
                        patientRefferedDoctors.record_modified_by = ApplicatinLauncher._userId;
                        PatientRefferedDoctorsBLL.patientreferredDocupdate(patientRefferedDoctors);
                        lvwReffDoctors.Items.Remove(lvwReffDoctors.FocusedItem);
                    
                    }
                }

                else
                    MessageBox.Show("No Item Selected");
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


        private void txtCPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPatientCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatientName.Focus();
            }
        }

        private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGuardianName.Focus();
            }
       }

        private void txtGuardianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbGuardianRelation.Focus();
            }
        }

        private void cmbGuardianRelation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbGender.Focus();
            }
        }

        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbOccupation.Focus();
            }
        }

        private void cmbOccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbCity.Focus();
            }
        }

        private void cmbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPhone.Focus();
            }
        }

        private void mskDOB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                cmbNationality.Focus();
            }
        }

        private void cmbNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbReligion.Focus();
            }
        }

        private void cmbReligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbPatientCondition.Focus();
            }
        }

        private void cmbPatientCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbRefferedDoctors.Focus();
            }
        }

        private void cmbRefferedDoctors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (cmbRefferedDoctors.SelectedIndex == -1 && cmbRefferedDoctors.Text != "")
                {
                    ResetRefferedDocContents();
                    txtRefferedDoctors.Text = cmbRefferedDoctors.Text;
                    txtRefferedDoctors.Focus();
                }
                else
                    ResetRefferedDocContents();
            }
        }

        private void lvwCabin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDeposit.Focus();
            }
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void btnSave_Enter(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
        }

        private void txtRefferedDoctors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDC.Focus();
            }
        }

        private void txtDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDegree.Focus();
            }
        }

        private void txtDegree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbDoctorLevel.Focus();
            }
        }

        private void cmbDoctorLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbSpecialistIn.Focus();
            }
        }

        private void cmbSpecialistIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbDesignation.Focus();
            }
        }

        private void cmbDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbDGender.Focus();
            }
        }

        private void cmbDGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAttachment.Focus();
            }
        }

        private void txtAttachment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtContactNo.Focus();
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbDCity.Focus();
            }
        }

        

        private void btnSaveRefferedDoctor_Enter(object sender, EventArgs e)
        {
           btnSaveRefferedDoctor_Click(null, null);
           //btnSave.Focus();      
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == 13)
                {
                    txtMobile.Focus();
                }
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

        private void dtpDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbNationality.Focus();
                }
            }
            catch
            {
            }
        }

        private void FocusOutCabinList()
        {
            try
            {
                for (int i = 0; i < lvwCabin.Items.Count; i++)
                {
                    if (lvwCabin.Items[i].Selected==true)
                    {
                        lvwCabin.Items[i].Selected = false; 
                    }
                }
            }
            catch
            { 
            }
        }

        private void txtAgeYy_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void txtAgeMm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtAgeMm.Text.ToString()) > 12)
                    return;
                NumCheck(e);
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void txtAgeDd_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }


        private void txtAgeDd_Leave(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(this.txtAgeDd.Text) > 31)
                {
                    MessageBox.Show("Invalid Date");
                    txtAgeDd.Text = "00";
                    txtAgeDd.Focus();
                    return;
                }
            }
            catch
            {
            }
        }

        private void txtAgeMm_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtAgeMm.Text) > 12)
                {
                    MessageBox.Show("Invalid Month");
                    txtAgeMm.Text = "00";
                    txtAgeMm.Focus();

                    return;
                }
            }
            catch
            {
            }
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwCabin.SelectedItems.Count > 0)
                {
                    MessageBox.Show("Cabin can not be changed");
                    return;
                }
              
                Patient patient = new Patient();
                PatientBLL patientBLL = new PatientBLL();
                patient.patient_code = txtPatientCode.Text.ToString();
                patient.patient_name = txtPatientName.Text.ToString();
                patient.guardian_name = txtGuardianName.Text.ToString();
                patient.guardian_relation_id = Convert.ToInt32(cmbGuardianRelation.SelectedValue);
                patient.gender_id = Convert.ToInt32(cmbGender.SelectedValue);
                patient.occupation_id = Convert.ToInt32(cmbOccupation.SelectedValue);
                patient.address = txtAddress.Text.ToString();
                patient.city_id = Convert.ToInt32(cmbCity.SelectedValue);
                patient.c_phone = txtCPhone.Text.ToString();
                patient.dob = Convert.ToDateTime(dtpDOB.Text);
                patient.nationality_id = Convert.ToInt32(cmbNationality.SelectedValue);
                patient.religion_id = Convert.ToInt32(cmbReligion.SelectedValue);
                patient.patient_condition_id = Convert.ToInt32(cmbPatientCondition.SelectedValue);
                patient.record_modified_by = ApplicatinLauncher._userId;
                
                patientBLL.UpdatePatientSearch(patient);  //UpdatePatientSearch
                if (lvwReffDoctors.Items.Count > 0)
                {
                    List<PatientRefferedDoctors> lstpatientRefferedDoctors = new List<PatientRefferedDoctors>();
                    PatientRefferedDoctorsBLL patientRefferedDoctorsBLL = new PatientRefferedDoctorsBLL();
                    for (int i = 0; i < lvwReffDoctors.Items.Count; i++)
                    {
                        //if (Convert.ToInt32(lvwReffDoctors.Items[i].SubItems[2].Text) == 0)
                        //{
                            PatientRefferedDoctors patientRefferedDoctors = new PatientRefferedDoctors();
                            patientRefferedDoctors.reffered_doctors_id = Convert.ToInt32(lvwReffDoctors.Items[i].SubItems[0].Text);
                            patientRefferedDoctors.admission_id = AdmissionID;
                            patientRefferedDoctors.record_created_by = ApplicatinLauncher._userId;
                            lstpatientRefferedDoctors.Add(patientRefferedDoctors);
                        //}
                    }
                    patientRefferedDoctorsBLL.RefDocDelte(AdmissionID);
                    patientRefferedDoctorsBLL.addrefferedDoc(lstpatientRefferedDoctors);

                }
                else
                {
                    PatientRefferedDoctorsBLL patientRefferedDoctorsBLL = new PatientRefferedDoctorsBLL();
                    patientRefferedDoctorsBLL.RefDocDelte(AdmissionID);
                }
              
                MessageBox.Show("Data Updated Successfully");

            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCaseNo.Text != "")
                {
                    PrintAdmissionReport(AdmissionID, Convert.ToInt16(txtCaseNo.Text), pamentid);
                    btnPrint.Enabled = false;
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
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text),int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void txtAgeMm_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtAgeMm.Text.ToString()) > 12)
                    return;
                
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
            }
            catch
            {
            }
        }
        public void PrintInvoice()
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

                rptCustomersOrders.SetParameterValue("@admission_id", AdmissionID);
                rptCustomersOrders.SetParameterValue("@payID", _paymentID);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                grpRefferedDoctors.Visible = true;
                cmbRefferedDoctors.Visible = false;
                newRefferedDocContents();
                
            }
            catch
            {
            }
        }
        void newRefferedDocContents()
        {
            txtRefferedDoctors.Text = "";
            txtDC.Text = "";
            txtDegree.Text = "";
            txtAttachment.Text = "";
            txtContactNo.Text = "";
            txtMobile.Text = "";
            textBox1.Text = "";
            cmbDoctorLevel.Text = "<Select>";
            cmbSpecialistIn.Text = "<Select>";
            cmbDesignation.Text = "<Select>";
            cmbDGender.Text = "<Select>";
            cmbDCity.Text = "<Select>";
            btnSaveRefferedDoctor.Text = "Save";
            btnSaveRefferedDoctor.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            grpRefferedDoctors.Visible = false;
            cmbRefferedDoctors.Visible = true;
        }

        private void btnDoctorSearch_Click(object sender, EventArgs e)
        {
            FrmdoctorSearch oFrmdoctorSearch = new FrmdoctorSearch(this, null,null,null,null,null);
            oFrmdoctorSearch.ShowDialog();
        }

      
        
        

        

       
        
       
       
        
       
    }
}