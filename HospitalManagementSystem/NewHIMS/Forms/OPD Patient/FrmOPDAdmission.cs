using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;
using NewHIMS.Reports.OPDPatient;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;

namespace NewHIMS.Forms.OPD_Patient
{
    public partial class FrmOPDAdmission : BaseForm.FrmBase
    {
        private string _nextPatientCode = "";
        //private int _paymentID = 0;
        private string GOPDResistrationID = "";
        //private int pamentid = 0;
        public FrmOPDAdmission()
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


        private void PrintAdmissionInfo(string RegistrationID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptOPDAdmission();
                //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }


                rptCustomersOrders.SetParameterValue("@RegistrationID", RegistrationID);
                //rptCustomersOrders.SetParameterValue("@OPDRegistrationID", RegistrationID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();

            }
            catch
            {
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
            //txtDeposit.Text = "";
            cmbGuardianRelation.Text = "<Select>";
            cmbGender.Text = "<Select>";
            cmbOccupation.Text = "<Select>";
            cmbCity.SelectedIndex = 0;
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
            txtAgeDd.Enabled = value;
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
               // PopulateCabinListView(ds);
                PopulateComboBox(cmbDoctorLevel, ds, 9, "doctor_level", "doctor_level_id");
                PopulateComboBox(cmbSpecialistIn, ds, 10, "specialist_in", "specialist_in_id");
                PopulateComboBox(cmbDesignation, ds, 11, "designation", "designation_id");
                PopulateComboBox(cmbDGender, ds, 14, "gender", "gender_id");
                PopulateComboBox(cmbDCity, ds, 15, "city", "city_id");
                ResetPatientContents();
                ResetRefferedDocContents();
                lvwReffDoctors.Items.Clear();
                //txtAdmissionCode.Text = "0" + (Convert.ToInt32(ds.Tables[12].Rows[0][1]) + 1).ToString();
                //this._nextPatientCode = (Convert.ToInt32(ds.Tables[13].Rows[0][0]) + 1).ToString("0000000#");
                //txtPatientCode.Text = this._nextPatientCode;
                dtpDOB.BackColor = Color.Linen;
                //AdmissionID = 0;
                btnSaveRefferedDoctor.Text = "Save";
                btnPrint.Enabled = false;
                btnSave.Enabled = true;
            }
            catch
            {
            }
        }

        private void FrmOPDAdmission_Load(object sender, EventArgs e)
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
            catch
            {
            }
        }
        Boolean IsMatchReffDoctor(string value)
        {
            try
            {
                for (int i = 0; i < lvwReffDoctors.Items.Count; i++)
                {
                    if (lvwReffDoctors.Items[i].SubItems[1].Text == value)
                        return true;
                }
            }
            catch
            {
            }
            return false;
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
            catch
            {
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
                if (txtRefferedDoctors.Text != "<Select" || txtRefferedDoctors.Text != "")
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

                if (cmbDoctorLevel.Text != "<Select>" && cmbDoctorLevel.Text != "" && cmbDoctorLevel.SelectedIndex != -1)
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
                if (cmbRefferedDoctors.SelectedIndex != -1)
                    reffDoc.reffered_doctors_id = Convert.ToInt16(cmbRefferedDoctors.SelectedValue);
                int res = 0;
                if (btnSaveRefferedDoctor.Text == "Save")
                    res = reffDocBLL.Addreffered_doctors(reffDoc);
                //else
                //    res = reffDocBLL.Updatereffered_doctors(reffDoc);
                if (res > 0)
                    MessageBox.Show("Data Saved Successfully");
                else
                    MessageBox.Show("Data Not Saved");

                DataSet ds = admBLL.GetAdmissionPopulationInfo();
                PopulateComboBox(cmbRefferedDoctors, ds, 7, "reffDoc", "reffered_doctors_id");
                ResetRefferedDocContents();
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
            //txtAdmissionCode.Text = "";
            txtPatientCode.Text = this._nextPatientCode;
            txtPatientCode.Text = " ";
            txtPatientCode.Enabled = false;
            ResetRefferedDocContents();
            //txtDeposit.Enabled = true;
            //btnSaveRefferedDoctor.Text = "Save";
            btnPrint.Enabled = true;
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
        private void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
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
        void InsertPatientRefferedDoc(string admissionID)
        {
            try
            {
                OPDPatientRefDoctor oPDPatientRefDoctor = new OPDPatientRefDoctor();
                OPDPatientRefDoctorBLL oPDPatientRefDoctorBLL = new OPDPatientRefDoctorBLL();

                foreach (ListViewItem lvi in lvwReffDoctors.Items)
                {
                    oPDPatientRefDoctor.RegistrationID = admissionID;
                    oPDPatientRefDoctor.RefDoctorID = Convert.ToInt32(lvi.SubItems[0].Text);
                    oPDPatientRefDoctor.RecordeCreatedBy = ApplicatinLauncher._userId;
                    oPDPatientRefDoctorBLL.OPDPatientRefDoctorADD(oPDPatientRefDoctor);
                   
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
                OPDPatient oPDPatient = new OPDPatient();
                OPDAdmission oPDAdmission = new OPDAdmission();
                OPDAdmissionBLL oPDAdmissionBLL = new OPDAdmissionBLL();
                oPDPatient.PatientName = txtPatientName.Text;
                oPDPatient.GardianName = txtGuardianName.Text;
                oPDPatient.GardianRelationID = Convert.ToInt32(cmbGuardianRelation.SelectedValue);
                oPDPatient.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                oPDPatient.OcupationID = Convert.ToInt32(cmbOccupation.SelectedValue);
                oPDPatient.Address = txtAddress.Text;
                oPDPatient.Phone = txtCPhone.Text;
                oPDPatient.Age = dtpDOB.Value.ToString();
                oPDPatient.NationalityID = Convert.ToInt32(cmbNationality.SelectedValue);
                oPDPatient.ReligionID = Convert.ToInt32(cmbReligion.SelectedValue);
                oPDPatient.RecordeCreatedBy = ApplicatinLauncher._userId;
                oPDAdmission.PatientID = txtPatientCode.Text;
                GOPDResistrationID = oPDAdmissionBLL.OPDadmissionAdd(oPDPatient, oPDAdmission);
                txtAdmissionCode.Text = GOPDResistrationID;
                InsertPatientRefferedDoc(GOPDResistrationID);
                MessageBox.Show("Admission successfull");
            }
            catch 
            {
                
                
            }
            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintAdmissionInfo(txtAdmissionCode.Text.ToString());
        }

    }
}