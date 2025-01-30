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
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Investigation;
using NewHIMS.Forms.Common;


namespace NewHIMS.Forms.Investigation
{
    public partial class FrmInvestigationWithMember : BaseForm.FrmBase
    {
        //private ListViewColumnSorter lvwColumnSorter;
       // private bool noNeedToContinue = true;
        private string _selectedDr = "";
        int PID;
        double price = 0.0;
        DataSet dsTest = null;
        public FrmInvestigationWithMember()
        {
            InitializeComponent();
            //lvwColumnSorter = new ListViewColumnSorter();
            //this.listView1.ListViewItemSorter = lvwColumnSorter;
        }


        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                //if (combo.SelectedIndex > 0)
                //combo.SelectedIndex = -1;
                //combo.Text = "<Select>";
            }
            catch
            {
            }
        }

        void ResetPatientContents()
        {
            try
            {
                txtPatientCode.Text = "";
                txtPatientName.Text = "";
                txtAddress.Text = "";
                txtCPhone.Text = "";
                cmbGender.Text = "<Select>";
                cmbOccupation.Text = "<Select>";
                cmbCity.Text = "<Select>";
                cmbCity.SelectedValue = 44;
                cmbReligion.Text = "<Select>";
                cmbReligion.SelectedValue = 1;
                cmbPatientCondition.Text = "<Select>";
                cmbPatientCondition.SelectedValue = 1;
                cmbTestDepartemt.Text = "<Select>";
                txtPatientCode.ReadOnly = true;
                btnSave.Enabled = true;
                dtpDOB.Text = DateTime.Now.ToString();
                txtAgeDd.Text = "00";
                txtAgeMm.Text = "00";
                txtAgeYy.Text = "00";
                grdInvestigtionTube.Rows.Clear();
                txtToal.Text = "00.00";
                txtTubeTotal.Text = "00.00";
                txtRemarks.Text = "";
                txtSType.Text = "";
                
               
               
                
            }
            catch
            {
            }
        }
        void refreshlistview()
        {
            try
            {
                lvwTest.Items.Clear();
                txtAgeYy.Text = "00";
                txtAgeMm.Text = "00";
                txtAgeDd.Text = "00";
                txtPathology.Text = "00.00";
                txtXray.Text = "00.00";
                txtUsg.Text = "00.00";
                txtEcg.Text = "00.00";
                txtTestTotal.Text = "00.00";
                txtNetPayable.Text = "00.00";
                txtPathology.Enabled = false;
                txtXray.Enabled = false;
                txtUsg.Enabled = false;
                txtEcg.Enabled = false;
                grdtestitems.Rows.Clear();
            }
            catch
            {
            }
        }


        void RefreshInvestigation()
        {
            InvestigationBLL investigationBLL = new InvestigationBLL();
            DataSet ds = investigationBLL.GetInvestigationPopulationInfo();
            try
            {
                PopulateComboBox(cmbGender, ds, 1, "gender", "gender_id");
                PopulateComboBox(cmbOccupation, ds, 2, "occupation", "occupation_id");
                PopulateComboBox(cmbCity, ds, 3, "city", "city_id");
                PopulateComboBox(cmbNationality, ds, 4, "nationality", "nationality_id");
                PopulateComboBox(cmbReligion, ds, 5, "religion", "religion_id");
                PopulateComboBox(cmbPatientCondition, ds, 6, "patient_condition", "patient_condition_id");
                PopulateComboBox(cmbRefferedDoctors, ds, 7, "reffDoc", "reffered_doctors_id");
                this.cmbTestDepartemt.SelectedIndexChanged -= this.cmbTestDepartemt_SelectedIndexChanged;
                PopulateComboBox(cmbTestDepartemt, ds, 8, "test_department", "test_department_id");
                this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
                txtPathology.Enabled = false;
                txtXray.Enabled = false;
                txtUsg.Enabled = false;
                txtEcg.Enabled = false;
                //PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");

                ResetPatientContents();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                investigationBLL = null;
                ds = null;

                //if (this.cmbGender.Items.Count > 1)
                //{
                //    this.cmbGender.SelectedIndex = this.cmbGender.FindString("Female");
                //}
                //if (this.cmbNationality.Items.Count > 1)
                //{
                //    this.cmbNationality.SelectedIndex = 0;
                //}
                //if (this.cmbOccupation.Items.Count > 1)
                //{
                //    this.cmbOccupation.SelectedIndex = this.cmbOccupation.FindString("Pvt.");
                //}
                //if (this.cmbCity.Items.Count > 1)
                //{
                //    this.cmbCity.SelectedIndex = this.cmbCity.FindString("Dhaka");
                //}
                //if (this.cmbReligion.Items.Count > 1)
                //{
                //    this.cmbReligion.SelectedIndex = this.cmbReligion.FindString("Islam");
                //}
                //if (this.cmbPatientCondition.Items.Count > 1)
                //{
                //    this.cmbPatientCondition.SelectedIndex = this.cmbPatientCondition.FindString("Normal");
                //}

            }
        }

        private void FrmInvestigation1_Load(object sender, EventArgs e)
        {
            RefreshInvestigation();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTestDepartemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                grdtestitems.Rows.Clear();
                if (rdoInvestigation.Checked == true)
                {
                    cmbTestGroup.Text = "";
                    TestItemBLL testItemBLL = new TestItemBLL();
                    int testDeptID = Convert.ToInt32(((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString());
                    DataSet ds = testItemBLL.testItemsList(testDeptID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        chkgroup.Checked = false;
                        cmbTestGroup.Enabled = false;
                        grdtestitems.Rows.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells["test_department"].Value = ds.Tables[0].Rows[i]["test_department"].ToString();                                      //admn_id
                            grdtestitems.Rows[i].Cells["test_group"].Value = ds.Tables[0].Rows[i]["test_group"].ToString();                                     //cabin_id
                            grdtestitems.Rows[i].Cells["test_items"].Value = ds.Tables[0].Rows[i]["test_item"].ToString();
                            grdtestitems.Rows[i].Cells["test_charge"].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["charge"].ToString());
                            grdtestitems.Rows[i].Cells["department_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_department_id"].ToString());
                            grdtestitems.Rows[i].Cells["group_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_group_id"].ToString());
                            grdtestitems.Rows[i].Cells["item_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_item_id"].ToString());
                            grdtestitems.Rows[i].Cells["speciman_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["specimen_id"].ToString());
                        }
                        //this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        PopulateComboBox(cmbTestGroup, ds, 1, "test_group", "test_group_id");
                        this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
                    }

                 
                }
                else if (rdoconsultation.Checked == true)
                {
                    RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
                    int testDeptID = Convert.ToInt32(((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString());
                    DataSet ds = refferedDoctorsBLL.getspecilist(testDeptID);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells[2].Value = 0;
                            grdtestitems.Rows[i].Cells[5].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["reffered_doctors_id"].ToString());
                            grdtestitems.Rows[i].Cells[6].Value = 0;
                            grdtestitems.Rows[i].Cells[7].Value = 0;
                            grdtestitems.Rows[i].Cells[8].Value = 0;
                            grdtestitems.Rows[i].Cells[1].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["reffered_doctors_id"].ToString());                                      //admn_id
                            grdtestitems.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i]["reffered_doctors"].ToString();
                            grdtestitems.Rows[i].Cells[4].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["visit_charge"].ToString());

                        }
                    }
                }
                else
                {
                    cmbTestGroup.DataSource = null;
                    cmbTestItem.DataSource = null;
                }

            }
            catch
            {
            }

            //privious
            //if (cmbTestDepartemt.SelectedIndex >= 0)
            //{
            //    TestGroupBLL testGroupBLL = new TestGroupBLL();

            //    try
            //    {
            // int testDeptID = Convert.ToInt32(((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString());
            // DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);

            //        if (ds.Tables[0].Rows.Count > 0)
            //        {
            //            //this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
            //            PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");
            //            //this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
            //            //cmbTestItem.DataSource = null;
            //        }
            //        else
            //        {
            //            cmbTestGroup.DataSource = null;
            //            cmbTestItem.DataSource = null;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //    finally
            //    {
            //        testGroupBLL = null;
            //        //ds = null;
            //    }
            //}
            //previous end
        }

        private void cmbTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbTestGroup.SelectedIndex >= 0)
                {
                    TestItemBLL testItemBLL = new TestItemBLL();
                    //int groupID = Convert.ToInt32(((DataRowView)(cmbTestGroup.SelectedItem)).Row[0].ToString());
                    DataSet ds = testItemBLL.testlist(Convert.ToInt32(this.cmbTestDepartemt.SelectedValue.ToString()), Convert.ToInt32(this.cmbTestGroup.SelectedValue.ToString()));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        chkgroup.Checked = false;
                        cmbTestGroup.Enabled = false;
                        grdtestitems.Rows.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells["test_department"].Value = ds.Tables[0].Rows[i]["test_department"].ToString();                                      //admn_id
                            grdtestitems.Rows[i].Cells["test_group"].Value = ds.Tables[0].Rows[i]["test_group"].ToString();                                     //cabin_id
                            grdtestitems.Rows[i].Cells["test_items"].Value = ds.Tables[0].Rows[i]["test_item"].ToString();
                            grdtestitems.Rows[i].Cells["test_charge"].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["charge"].ToString());
                            grdtestitems.Rows[i].Cells["department_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_department_id"].ToString());
                            grdtestitems.Rows[i].Cells["group_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_group_id"].ToString());
                            grdtestitems.Rows[i].Cells["item_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_item_id"].ToString());
                            grdtestitems.Rows[i].Cells["speciman_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["specimen_id"].ToString());
                        }
                        //this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);

                    }

                }

            }
            catch
            {
            }
            //if (cmbTestGroup.SelectedIndex >= 0)
            //{
            //    TestItemBLL testItemBLL = new TestItemBLL();

            //    string strTestGrpID = ((DataRowView)(cmbTestGroup.SelectedItem)).Row[0].ToString();
            //    int testGrpID = Convert.ToInt32(strTestGrpID);
            //    DataSet ds = testItemBLL.GetTestItemByTestGrpID(testGrpID);

            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        PopulateComboBox(cmbTestItem, ds, 0, "testItem", "test_item_id");
            //    }
            //    else
            //    {
            //        cmbTestItem.DataSource = null;
            //    }
            //    testItemBLL = null;
            //    ds = null;
            //}
        }
        private void InvestigationBack()
        {
            try
            {
                InvestigationBack investigationBack = new InvestigationBack();
                InvestigationBackBLL investigationBackBLL = new InvestigationBackBLL();

                if (lvwTest.Items.Count > 0)
                {
                    for (int i = 0; i < lvwTest.Items.Count; i++)
                    {
                        investigationBack.department = lvwTest.Items[i].SubItems[0].Text;
                        investigationBack.groups = lvwTest.Items[i].SubItems[1].Text;
                        investigationBack.test_item = lvwTest.Items[i].SubItems[2].Text;
                        investigationBack.charge = Convert.ToDecimal(lvwTest.Items[i].SubItems[3].Text);
                        investigationBack.d_id = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                        investigationBack.g_id = Convert.ToInt32(lvwTest.Items[i].SubItems[5].Text);
                        investigationBack.t_id = Convert.ToInt32(lvwTest.Items[i].SubItems[6].Text);
                        investigationBack.reedoc_id = Convert.ToInt32(lvwTest.Items[i].SubItems[8].Text);
                        investigationBack.reffered_by = lvwTest.Items[i].SubItems[7].Text;
                        if (lvwTest.Items[i].SubItems[9].Text != "")
                            investigationBack.specimen_id = Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text);
                        else
                            investigationBack.specimen_id = 0;

                        investigationBackBLL.investigationBackAdd(investigationBack);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            try
            {
                ////string[] tempAr = this.cmbTestItem.Text.Split(']');

                ////if (lvwTest.Items.Count > 0)
                ////{
                ////    if (this._selectedDr != cmbRefferedDoctors.Text)
                ////    {
                ////        MessageBox.Show(this._selectedDr + " is already selected");
                ////        return;
                ////    }
                ////}

                //////if (cmbRefferedDoctors.Text == "" ||
                //////    cmbTestDepartemt.Text == "" ||
                //////    cmbTestGroup.Text == "" ||
                //////    cmbTestItem.Text == ""
                //////    )
                //////{
                //////    MessageBox.Show("Select Investigation Info Properly");
                //////    return;
                //////}

                //////if (IsMatchTest(cmbTestDepartemt.Text, cmbTestGroup.Text, tempAr[0].Trim() + ']', tempAr[tempAr.Length - 1].Trim(), cmbRefferedDoctors.Text) == true)
                //////{
                //////    MessageBox.Show("Test already exists");
                //////    return;
                //////}

                ////if (Convert.ToInt32(cmbTestDepartemt.SelectedValue) == 2)
                ////{
                ////    InvestigationBLL investigationBLL = new InvestigationBLL();
                ////    DataSet dssp = investigationBLL.spSearch(Convert.ToInt32(cmbTestItem.SelectedValue));
                ////    int s = Convert.ToInt32(dssp.Tables[0].Rows[0][0]);
                ////    txtsp.Text = s.ToString();
                ////}

                ////ListViewItem lvi = new ListViewItem(this.cmbTestDepartemt.Text);
                ////lvi.SubItems.Add(cmbTestGroup.Text);
                ////lvi.SubItems.Add(tempAr[0].Trim() + ']');
                ////lvi.SubItems.Add(tempAr[tempAr.Length - 1].Trim());
                ////lvi.SubItems.Add(((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString());
                ////lvi.SubItems.Add(((DataRowView)(cmbTestGroup.SelectedItem)).Row[0].ToString());
                ////lvi.SubItems.Add(((DataRowView)(cmbTestItem.SelectedItem)).Row[0].ToString());
                //////lvi.SubItems.Add(((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[0].ToString());
                ////lvi.SubItems.Add(cmbRefferedDoctors.Text);
                ////lvi.SubItems.Add(cmbRefferedDoctors.SelectedValue.ToString());
                ////lvi.SubItems.Add(txtsp.Text);
                ////txtsp.Text = "";

                ////this._selectedDr = cmbRefferedDoctors.Text;

                ////lvwTest.Items.Add(lvi);
                ////InvestigationBack();
                ////InvestigationBackBLL investigationBackBLL = new InvestigationBackBLL();
                ////DataSet dss = investigationBackBLL.InvestigationListPopulate();
                ////if (dss.Tables[0].Rows.Count > 0)
                ////{
                ////    FillUpListview1(lvwTest, dss);
                ////}

                double total = 0.0;
                for (int i = 0; i < lvwTest.Items.Count; i++)
                {
                    double subTolal;
                    subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                    total = total + subTolal;
                }
                double vat = ((total * 2.25) / 100);
                int Gtotal = Convert.ToInt32(total + vat);
                this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                NP = NP + Convert.ToDouble(txtTubeTotal.Text);
                this.txtNetPayable.Text = NP.ToString("0#.#0");
                this.lvwTest.Refresh();

                if (this.lvwTest.Items.Count > 0)
                {
                    this.btnSave.Enabled = true;
                }
                if (cmbTestDepartemt.Text == "Pathology")
                {
                    txtPathology.Enabled = true;
                    //txtXray.Enabled = false;
                    //txtUsg.Enabled = false;
                    //txtEcg.Enabled = false;

                }
                else if (cmbTestDepartemt.Text == "X-Ray")
                {
                    //txtPathology.Enabled = false;
                    txtXray.Enabled = true;
                    //txtUsg.Enabled = false;
                    //txtEcg.Enabled = false;
                }
                else if (cmbTestDepartemt.Text == "USG")
                {
                    //txtPathology.Enabled = false;
                    //txtXray.Enabled = false;
                    txtUsg.Enabled = true;
                    //txtEcg.Enabled = false;
                }
                else if (cmbTestDepartemt.Text == "ECG")
                {
                    //txtPathology.Enabled = false;
                    //txtXray.Enabled = false;
                    //txtUsg.Enabled = false;
                    txtEcg.Enabled = true;
                }
                else
                {
                    txtPathology.Enabled = false;
                    txtXray.Enabled = false;
                    txtUsg.Enabled = false;
                    txtEcg.Enabled = false;
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
                if (DateTime.Now.CompareTo(this.dtpDOB.Value) > 0)
                {
                    int year = 0;
                    int month = 0;
                    int day = 0;

                    FormHelper.CalculateAge(this.dtpDOB.Value, out year, out month, out day);
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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
  
                string value;
                Patient patient = new Patient();
                

                if (txtPatientName.Text == "")
                {
                    MessageBox.Show("Input a Patient Name");
                    txtPatientName.Focus();
                    return;
                }
                if (cmbGender.Text == "<Select>" || cmbGender.Text == "")
                {
                    MessageBox.Show("Select Patient's Gender");
                    cmbGender.Focus();
                    return;
                }
                if (Convert.ToDateTime(dtpDOB.Text) > DateTime.Now)
                {
                    MessageBox.Show("Input a valid DOB");
                    dtpDOB.Focus();
                    return;
                }

                if (lvwTest.Items.Count < 0)
                {
                    MessageBox.Show("Select a Test");
                    return;
                }
       
                patient.patient_type = "OPD";
                if (txtPatientName.Text != "")
                    patient.patient_name = txtPatientName.Text.ToString();
                else
                {
                    MessageBox.Show("Input a Patient Name");
                    txtPatientName.Focus();
                    return;
                }

                if (cmbGender.Text != "<Select>" && cmbGender.Text != "")
                {
                    value = ((DataRowView)(cmbGender.SelectedItem)).Row[0].ToString();
                    patient.gender_id = Convert.ToInt32(value);
                }
                else
                {
                    MessageBox.Show("Select Patient's Gender");
                    cmbGender.Focus();
                    return;
                }
                if (cmbOccupation.Text != "<Select>" && cmbOccupation.Text != "")
                {
                    value = ((DataRowView)(cmbOccupation.SelectedItem)).Row[0].ToString();
                    patient.occupation_id = Convert.ToInt32(value);
                }

                if (txtAddress.Text != "")
                    patient.address = txtAddress.Text.ToString();

                if (txtCPhone.Text != "")
                {
                    patient.c_phone = txtCPhone.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Input Patient's Mobile Number");
                    txtCPhone.Focus();
                    return;
                }

                if (Convert.ToDateTime(dtpDOB.Text) < DateTime.Now)
                    patient.dob = Convert.ToDateTime(dtpDOB.Text);
                else
                {
                    MessageBox.Show("Input a valid DOB");
                    dtpDOB.Focus();
                    return;
                }

                if (cmbNationality.Text != "<Select>" && cmbNationality.Text != "")
                {
                    value = ((DataRowView)(cmbNationality.SelectedItem)).Row[0].ToString();
                    patient.nationality_id = Convert.ToInt32(value);
                }


                if (cmbReligion.Text != "<Select>" && cmbReligion.Text != "")
                {
                    value = ((DataRowView)(cmbReligion.SelectedItem)).Row[0].ToString();
                    patient.religion_id = Convert.ToInt32(value);
                }

                if (cmbCity.Text != "<Select>" && cmbCity.Text != "")
                {
                    value = ((DataRowView)(cmbCity.SelectedItem)).Row[0].ToString();
                    patient.city_id = Convert.ToInt32(value);
                }

                if (cmbPatientCondition.Text != "<Select>" && cmbPatientCondition.Text != "")
                {
                    value = ((DataRowView)(cmbPatientCondition.SelectedItem)).Row[0].ToString();
                    patient.patient_condition_id = Convert.ToInt32(value);
                }
                if (txtPatientCode.Text != "")
                {
                    patient.patient_code = txtPatientCode.Text.ToString();
                    patient.record_modified_by = ApplicatinLauncher._userId;
                }
                if (cmbRefferedDoctors.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select a Doctor From List");
                    return;
                }

                if (txtSType.Text != "")
                {
                    AutoDiscount();
                }

                ///////////////////////////
                if (rdoInvestigation.Checked == true)
                {
                    decimal path=0, xray=0, usg=0, ecg=0;
                    for (int m = 0; m < lvwTest.Items.Count; m++)
                    {
                        if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                        {
                            path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//xray
                        {
                            xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//usg
                        {
                            usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ecg
                        {
                            ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else
                        {
                            
                        }
                    }

                    InvestigationBO investigationBO = new InvestigationBO();
                    InvestigationBLL investigationBLL = new InvestigationBLL();

                    SampleBLL sampleBLL = new SampleBLL();
                    //if (dsTest != null)
                    //{
                    //    int flag = 0;
                    //    for (int i = 0; i < lvwTest.Items.Count; i++)
                    //    {
                    //        for (int j = 0; j < dsTest.Tables[0].Rows.Count; j++)
                    //        {
                    //            if (lvwTest.Items[i].SubItems[2].Text == dsTest.Tables[0].Rows[j][2].ToString())
                    //                flag = 1;
                    //        }
                    //    }
                    //    if (flag == 1)
                    //    {
                    //        MessageBox.Show("Test Items are Exists");
                    //        return;
                    //    }
                    //}

                    if (cmbRefferedDoctors.SelectedIndex != -1)
                    {
                        investigationBO.invest_ref_doctor_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue.ToString());
                    }
                    patient.record_created_by = ApplicatinLauncher._userId;
                    investigationBO.record_created_by = ApplicatinLauncher._userId;
                    investigationBO.total_amount = Convert.ToDecimal(txtNetPayable.Text);
                    investigationBO.total_tube_amount = Convert.ToDecimal(txtTubeTotal.Text);
                    investigationBO.discount = (Convert.ToDecimal(txtPathology.Text) + Convert.ToDecimal(txtXray.Text) + Convert.ToDecimal(txtUsg.Text) + Convert.ToDecimal(txtEcg.Text));

                    investigationBO.remarks = txtRemarks.Text;
                    
                    int investigationID = 0;

                    if (txtPatientCode.Text == "")
                        
                        investigationID = investigationBLL.Addinvestigations(patient, investigationBO);
                    else
                    {
                        patient.patient_code = txtPatientCode.Text.ToString();
                        investigationID = investigationBLL.Investigationsupdate(patient, investigationBO);
                    }
                    if (investigationID > 0)
                    {
                        InvestigationOrder investigationOrder = new InvestigationOrder();
                        InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                        InvestigtionTubeBO investigtionTubeBO = new InvestigtionTubeBO();
                        InvestigtionTubeBLL investigtionTubeBLL = new InvestigtionTubeBLL();

                         for (int i = 0; i < grdInvestigtionTube.Rows.Count; i++)
                        {
                            investigtionTubeBO.investigation_id = investigationID;
                            investigtionTubeBO.test_tube_id = Convert.ToInt32(grdInvestigtionTube.Rows[i].Cells[0].Value);
                            investigtionTubeBO.qty = Convert.ToInt32(grdInvestigtionTube.Rows[i].Cells[2].Value);
                            investigtionTubeBO.price = Convert.ToDecimal(grdInvestigtionTube.Rows[i].Cells[3].Value);
                            investigtionTubeBLL.InvestigationTubeAdd(investigtionTubeBO);
                     
                        }

                        int SampleID = 0;
                        int SID = 0;
                        int OrderID = 0;
                        int DID = 0;
                        
                        for (int i = 0; i < lvwTest.Items.Count; i++)
                        {
                            if(DID==Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text))
                      goto next;
                            string DeptID = "0" + (lvwTest.Items[i].SubItems[4].Text);
                            investigationOrder.investigation_id = investigationID;
                             if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 2)
                             {
                                 investigationOrder.discount = Convert.ToDecimal(txtPathology.Text);
                                 investigationOrder.total_amount = path;//path
                             }
                             else if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 1)
                             {
                                 investigationOrder.discount = Convert.ToDecimal(txtXray.Text);
                                 investigationOrder.total_amount = xray;//xray
                             }
                             else if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 3)
                             {
                                 investigationOrder.discount = Convert.ToDecimal(txtUsg.Text);
                                 investigationOrder.total_amount = usg;//usg
                             }
                             else if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 4)
                             {
                                 investigationOrder.discount = Convert.ToDecimal(txtEcg.Text);
                                 investigationOrder.total_amount = ecg;//ecg
                             }
                             else
                             {
                                 investigationOrder.discount = 0;
                             }
                             investigationOrder.record_created_by = ApplicatinLauncher._userId;
                             investigationOrder.test_department_id = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);

                             OrderID = investigationOrderBLL.investigation_orderAdd(investigationOrder, DeptID);
                        next:
                             DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                             if (DID == 2)
                             {
                                 while (DID == 2)
                                 {
                                     if (SID != Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text))
                                     {
                                         Sample sample = new Sample();
                                         int SpecimenID = Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text);
                                         sample.investigation_id = investigationID;
                                         sample.record_created_by = ApplicatinLauncher._userId;
                                         SampleID = sampleBLL.sampleAdd(sample, SpecimenID);
                                     }
                                     SaveInvestigation(investigationID, OrderID, SampleID, i);

                                     SID = Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text);
                                     if (i == lvwTest.Items.Count - 1)
                                     {
                                         DID = 0;
                                         MessageBox.Show("Data Saved Successfully");
                                         btnSave.Enabled = false;
                                         PrintInestigationReport(investigationID);
                                         //PrintInestigationReportNew(investigationID);
                                         //PrintInestigationReportforTube(investigationID);
                                         //lvwTest.Items.Clear();
                                         txtTestTotal.Text = "";
                                         return;
                                     }
                                     if (Convert.ToInt32(lvwTest.Items[i + 1].SubItems[9].Text) != SID)
                                     {
                                         if (DID == Convert.ToInt32(lvwTest.Items[i + 1].SubItems[4].Text))
                                         {
                                             DID = Convert.ToInt32(lvwTest.Items[i + 1].SubItems[4].Text);
                                             i++;
                                         }
                                         else
                                             DID = Convert.ToInt32(lvwTest.Items[i + 1].SubItems[4].Text);
                                     }
                                     else
                                     {
                                         DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);

                                         i++;
                                     }
                                 }
                                 DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);

                             }
                             else
                             {
                                 SaveInvestigation(investigationID, OrderID, 0, i);
                                 DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                             }
                        }
                  
                        MessageBox.Show("Data Saved Successfully");
                        btnSave.Enabled = false;
                        PrintInestigationReport(investigationID);
                        //PrintInestigationReportNew(investigationID);
                        //PrintInestigationReportforTube(investigationID);
                        txtTestTotal.Text = "";
                    }
                    else
                        MessageBox.Show("Data Save Failed", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rdoconsultation.Checked == true)
                {
                    int Result = 0;
                    List<ConsultationBO> lstConsultation = new List<ConsultationBO>();
                    PatientConsultantBO patientConsultantBO = new PatientConsultantBO();
                    PatientConsultantBLL patientConsultantBLL = new PatientConsultantBLL();

                    patientConsultantBO.total = Convert.ToDecimal(txtTestTotal.Text);
                    patientConsultantBO.record_created_by = ApplicatinLauncher._userId;
                    for (int i = 0; i < lvwTest.Items.Count; i++)
                    {

                        ConsultationBO consultationBO = new ConsultationBO();
                        consultationBO.reffered_doctors_id = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                        consultationBO.visit_charge = Convert.ToDecimal(lvwTest.Items[i].SubItems[3].Text);

                        lstConsultation.Add(consultationBO);

                    }
                    if (txtPatientCode.Text == "")
                        Result = patientConsultantBLL.patientconsultationADD(patient, patientConsultantBO, lstConsultation);
                    else
                        Result = patientConsultantBLL.patientconsultationUpdate(patient, patientConsultantBO, lstConsultation);
                     MessageBox.Show("Data Saved Successfully");
                     btnSave.Enabled = false;




                }
                else
                {
                    int Result = 0;
                    List<OtherServiceListBO> lstOtherServiceListBO = new List<OtherServiceListBO>();
                    OtherserviceBO otherserviceBO = new OtherserviceBO();
                    OtherserviceBLL otherserviceBLL = new OtherserviceBLL();

                    otherserviceBO.total=Convert.ToDecimal(txtTestTotal.Text);
                    otherserviceBO.t_vat = Convert.ToDecimal(txtNetPayable.Text) - Convert.ToDecimal(txtTestTotal.Text);

                    otherserviceBO.record_created_by = ApplicatinLauncher._userId;
                    for (int i = 0; i < lvwTest.Items.Count; i++)
                    {

                        OtherServiceListBO otherServiceListBO = new OtherServiceListBO();
                        otherServiceListBO.other_item_id = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                        otherServiceListBO.charge = Convert.ToDecimal(lvwTest.Items[i].SubItems[3].Text);
                        
                        lstOtherServiceListBO.Add(otherServiceListBO);

                    }
                    if (txtPatientCode.Text == "")
                        Result = otherserviceBLL.patientserviceADD(patient, otherserviceBO, lstOtherServiceListBO);
                    else
                    {
                        Result = otherserviceBLL.patientupdateADD(patient, otherserviceBO, lstOtherServiceListBO);
                    }
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void SaveInvestigation(int investigationID, int OrderID, int SampleID, int i)
        {
            InvestigationTest investigationTest = new InvestigationTest();
            InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();

            int visitinvestigationID = 0;

            investigationTest.investigation_id = investigationID;
            investigationTest.test_department_id = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
            investigationTest.test_group_id = Convert.ToInt32(lvwTest.Items[i].SubItems[5].Text);
            investigationTest.test_item_id = Convert.ToInt32(lvwTest.Items[i].SubItems[6].Text);
            investigationTest.order_no = OrderID;
            if (SampleID != 0)
            {
                investigationTest.sample_serial_no = SampleID;
            }
            investigationTest.charge = Convert.ToDecimal(lvwTest.Items[i].SubItems[3].Text);
            investigationTest.result = "Processing";
            investigationTest.reffered_doctors_id = 0;
            investigationTest.report_done = 0;
            investigationTest.delivered = 0;
            investigationTest.user_id = 0;
            investigationTest.for_baby = 0;
            investigationTest.sample_collected = 0;
            //if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 2)
            //{
            //    investigationTest.sample_collected = 0;
            //}
            //else
            //{
            //    investigationTest.sample_collected = 1;
            //}
            investigationTest.record_created_by = ApplicatinLauncher._userId;

            investigationTestBLL.Addinvestigation_test(investigationTest, visitinvestigationID);
        }
        Boolean IsMatchTest(string dept, string item)
        {

            for (int i = 0; i < lvwTest.Items.Count; i++)
            {
                if (lvwTest.Items[i].SubItems[0].Text == dept &&
                    lvwTest.Items[i].SubItems[2].Text == item
                    //lvwTest.Items[i].SubItems[1].Text == grp &&
                    //lvwTest.Items[i].SubItems[3].Text == charge &&
                    //lvwTest.Items[i].SubItems[8].Text == reffdoc
                    )

                    return true;
            }
            return false;

        }
        private void FillUpListview(ListView lvw, DataSet ds)
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
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvi.SubItems.Add(dataRow[4].ToString());
                        lvi.SubItems.Add(dataRow[5].ToString());
                        lvi.SubItems.Add(dataRow[6].ToString());
                        lvi.SubItems.Add(dataRow[7].ToString());
                        lvi.SubItems.Add(dataRow[8].ToString());
                        lvi.SubItems.Add(dataRow[11].ToString());
                        lvi.SubItems.Add(dataRow[9].ToString());
                        lvi.SubItems.Add(dataRow[10].ToString());

                        lvw.Items.Add(lvi);
                    }
                }
                //admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2]);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //private void FillUpListview1(ListView lvw, DataSet ds)
        //{
        //    try
        //    {
        //        lvw.Items.Clear();
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            DataRow dataRow = ds.Tables[0].Rows[i];

        //            if (dataRow.RowState != DataRowState.Deleted)
        //            {
        //                ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

        //                lvw.Items.Add(lvi);
        //            }
        //        }
        //        //admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2]);
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error");
        //    }
        //}
        private void FillUpListview1(ListView lvw, DataSet ds)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[0].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[1].ToString());

                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvi.SubItems.Add(dataRow[4].ToString());
                        lvi.SubItems.Add(dataRow[5].ToString());
                        lvi.SubItems.Add(dataRow[6].ToString());
                        lvi.SubItems.Add(dataRow[7].ToString());
                        lvi.SubItems.Add(dataRow[9].ToString());
                        lvi.SubItems.Add(dataRow[8].ToString());
                        lvi.SubItems.Add(dataRow[10].ToString());

                        lvw.Items.Add(lvi);
                    }
                }
                //admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2]);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void btnRemoveTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTest.SelectedItems.Count > 0)
                {
                    string Dept = lvwTest.SelectedItems[0].SubItems[0].Text;
                    int flag = 0;
                    double total1 = double.Parse(this.txtTestTotal.Text);

                    total1 -= double.Parse(this.lvwTest.SelectedItems[0].SubItems[3].Text);
                    this.txtTestTotal.Text = total1.ToString("0#.#0");
                    lvwTest.Items.Remove(lvwTest.FocusedItem);
                    double total = 0.0;
                    for (int i = 0; i < lvwTest.Items.Count; i++)
                    {
                        double subTolal;
                        subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                        total = total + subTolal;
                    }
                    double vat = ((total * 2.25) / 100);
                    int Gtotal = Convert.ToInt32(total + vat);
                    this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                    if (txtPathology.Text == "")
                    {
                        txtPathology.Text = "00.00";
                    }
                    else if (txtXray.Text == "")
                    {
                        txtXray.Text = "00.00";
                    }
                    else if (txtUsg.Text == "")
                    {
                        txtUsg.Text = "00.00";
                    }
                    else if (txtEcg.Text == "")
                    {
                        txtEcg.Text = "00.00";
                    }
                    double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                    this.txtNetPayable.Text = NP.ToString("0#.#0");
                    txtToal.Text = (NP + Convert.ToDouble(txtTubeTotal.Text)).ToString("0#.#0");

                    //this.lvwTest.Refresh();
                    if (lvwTest.Items.Count > 0)
                    {
                        for (int i = 0; i < lvwTest.Items.Count; i++)
                        {
                            if (Dept == lvwTest.Items[i].SubItems[0].Text)
                            {
                                flag = 1;
                                break;
                            }
                            else
                            {
                                flag = 2;
                            }
                        }
                        if (flag != 1)
                        {
                            if (Dept == "Pathology")
                            {
                                txtPathology.Text = "00.00";
                                txtPathology.Enabled = false;
                                txtPathology_Leave(null, null);
                            }
                            else if (Dept == "X-Ray")
                            {
                                txtXray.Text = "00.00";
                                txtXray.Enabled = false;
                                txtXray_Leave(null, null);
                            }
                            else if (Dept == "USG")
                            {
                                txtUsg.Text = "00.00";
                                txtUsg.Enabled = false;
                                txtUsg_Leave(null, null);
                            }
                            else if (Dept == "ECG")
                            {
                                txtEcg.Text = "00.00";
                                txtEcg.Enabled = false;
                                txtEcg_Leave(null, null);
                            }
                        }
                    }
                    else
                    {
                        txtPathology.Text = "00.00";
                        txtXray.Text = "00.00";
                        txtUsg.Text = "00.00";
                        txtEcg.Text = "00.00";
                        txtNetPayable.Text = "00.00";
                        txtPathology.Enabled = false;
                        txtXray.Enabled = false;
                        txtUsg.Enabled = false;
                        txtEcg.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("No Item Selected");

                if (this.lvwTest.Items.Count == 0)
                {
                    this.btnSave.Enabled = false;
                    this.cmbTestDepartemt.Focus();
                }
            }
            catch
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtPatientCode.Text = "";
                //txtPatientName.Text = "";
                //cmbGender.Text = "";
                //cmbOccupation.Text = "";
                //txtCPhone.Text = "";
                //txtAddress.Text = "";
                txtAgeDd.Text = "00";
                txtAgeMm.Text = "00";
                txtAgeYy.Text = "00";
                //cmbCity.Text = "";
                //cmbOccupation.Text = "";
                //cmbNationality.Text = "";
                //cmbReligion.Text = "";
                //RefreshInvestigation();
                ResetPatientContents();
                txtPatientCode.ReadOnly = false;
                txtPatientCode.Focus();
                btnNew.Enabled = true;
            }
            catch
            {
            }
        }
        void PrintInestigationReportNew(int investigationID)
        {
            try
            {
            
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new InvestigationInvoiceNew();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;

                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                    rptCustomersOrders.SetParameterValue("@InvestigationID", investigationID);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                

            }
            catch
            {
            }
        }

        void PrintInestigationReport(int investigationID)
        {
            try
            {
                InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                DataSet ds = investigationOrderBLL.OrdernoGet(investigationID);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int OrderId = Convert.ToInt32(ds.Tables[0].Rows[i][0]);

                    if (Convert.ToInt32(ds.Tables[0].Rows[i][1]) == 2)
                    {
                        PrintPathologyInestigationReport(investigationID, OrderId);
                    }
                    else
                    {
                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new InvestigationInvoice();

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;

                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }

                        rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                        rptCustomersOrders.SetParameterValue("@order_no", OrderId);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
                }

            }
            catch
            {
            }
        }
        void PrintPathologyInestigationReport(int investigationID, int order_no)
        {
            try
            {
                InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                DataSet ds = investigationOrderBLL.OrdernoGet(investigationID);

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new InvestigationInvoicePathology();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;

                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                    rptCustomersOrders.SetParameterValue("@order_no", order_no);
                    rptCustomersOrders.SetParameterValue("@InvestigationID", investigationID);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                    
                

            }
            catch
            {
            }
        }
        void PrintInestigationReportforTube(int investigationID)
        {
            try
            {
                
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new InvestigationInvoiceforTube();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;

                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                    //rptCustomersOrders.SetParameterValue("@order_no", OrderId);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }

            
            catch
            {
            }
        }


        private void cmbRefferedDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRefferedDoctors.SelectedIndex > 0)
                {
                    if (this._selectedDr == "")
                    {
                        if (cmbRefferedDoctors.Text.ToString() != "")
                        {
                            this._selectedDr = cmbRefferedDoctors.Text.ToString();
                        }
                    }
                }
            }
            catch
            {
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
                        OccupationBLL occupationBLL = new OccupationBLL();
                        NationalityBLL nationalityBLL = new NationalityBLL();
                        ReligionBLL religionBLL = new ReligionBLL();
                        PatientConditionBLL patientConditionBLL = new PatientConditionBLL();
                        InvestigationBLL investigationBLL = new InvestigationBLL();

                        patient = patientBLL.patientInfo(txtPatientCode.Text);
                        if (patient.patient_name == null && patient.address == null)
                        {
                            MessageBox.Show("No Patient found");
                            txtPatientCode.Text = "";
                            btnPrint.Enabled = false;
                            return;
                        }
                        if (patient.patient_id != 0)
                            PID = Convert.ToInt32(patient.patient_id);
                        if (patient.patient_code != null)
                            txtPatientCode.Text = patient.patient_code.ToString();
                        if (patient.patient_name != null)
                            txtPatientName.Text = patient.patient_name.ToString();
                        if (patient.gender_id != null)
                            if (genderBLL.Getgender(Convert.ToInt32(patient.gender_id)).gender != null)
                                cmbGender.Text = genderBLL.Getgender(Convert.ToInt32(patient.gender_id)).gender.ToString();
                        if (patient.occupation_id != null)
                            if (occupationBLL.Getoccupation(Convert.ToInt32(patient.occupation_id)).occupation != null)
                                cmbOccupation.Text = occupationBLL.Getoccupation(Convert.ToInt32(patient.occupation_id)).occupation.ToString();
                        if (patient.address != null)
                            txtAddress.Text = patient.address;
                        if (patient.city_id != null)
                            if (cityBLL.Getcity(Convert.ToInt32(patient.city_id)).city != null)
                                cmbCity.Text = cityBLL.Getcity(Convert.ToInt32(patient.city_id)).city.ToString();
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
                        txtPatientCode.ReadOnly = true;
                        //txtPatientName.Focus();
                        btnSave.Enabled = true;
                        btnNew.Enabled = true;
                       // btnPrint.Enabled = true;
                        dsTest = investigationBLL.InvestigationSearch(PID);
                        //if (dsTest != null)
                        //{
                        //    FillUpListview(lvwTest, dsTest);
                        //    cmbRefferedDoctors.SelectedValue = dsTest.Tables[0].Rows[0][7].ToString();
                        //    cmbRefferedDoctors.SelectedText = dsTest.Tables[0].Rows[0][8].ToString();
                        //    btnCancel.Enabled = true;
                        //    double total = 0.0;
                        //    for (int i = 0; i < lvwTest.Items.Count; i++)
                        //    {
                        //        double subTolal;
                        //        subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                        //        total = total + subTolal;
                        //    }
                        //    double vat = ((total * 2.25) / 100);
                        //    int Gtotal = Convert.ToInt32(total + vat);
                        //    this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                       
                        //}

                    }

                }
            }
            catch
            {
            }
        }
        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch
            {
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


        private void txtPatientCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {

                    //txtPatientName.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbGender.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbOccupation.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbOccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtAddress.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbCity.Focus();
                }
            }
            catch
            {
            }

        }

        private void cmbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    txtCPhone.Focus();
                }
            }
            catch
            {
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

        private void cmbNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbReligion.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbReligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbPatientCondition.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbPatientCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbRefferedDoctors.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbRefferedDoctors_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbTestDepartemt.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbTestGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbTestItem.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbTestDepartemt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cmbTestGroup.Focus();
                }
            }
            catch
            {
            }
        }

        private void cmbTestItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    btnSaveTest.Focus();
                }
            }
            catch
            {
            }
        }

        private void btnSaveTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    //btnRemoveTest.Focus();
                }
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtPatientCode.Text = "";
                txtPatientName.Text = "";
                cmbGender.Text = "";
                cmbOccupation.Text = "";
                txtCPhone.Text = "";
                txtAddress.Text = "";
                txtAgeDd.Text = "00";
                txtAgeMm.Text = "00";
                txtAgeYy.Text = "00";
                cmbCity.Text = "";
                cmbPatientCondition.Text = "";
                cmbNationality.Text = "";
                cmbReligion.Text = "";
                txtPatientCode.Text = "";
                txtPatientCode.ReadOnly = true;
                txtPatientName.Focus();
                //RefreshInvestigation();
                btnNew.Enabled = true;
                ResetPatientContents();
                
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
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
                    txtAgeMm.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAgeMm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                    txtAgeDd.Focus();
                }
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
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                    cmbNationality.Focus();
                }
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
                    txtAgeDd.Focus();
                    return;
                }
                else
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
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
                    txtAgeMm.Focus();
                    return;
                }
                else
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));

                }
            }
            catch
            {
            }
        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (cmbGender.SelectedIndex == -1 && cmbGender.Text != "<Select>")
                //{
                //    MessageBox.Show("Data Not found");
                //    cmbGender.Focus();
                //    cmbGender.Text = "";
                //    return;
                //}
            }
            catch
            {
            }
        }

        private void cmbOccupation_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (cmbOccupation.SelectedIndex == -1 && cmbGender.Text != "<Select>")
                //{
                //    MessageBox.Show("Data Not found");
                //    //cmbOccupation.Text = "";
                //    cmbOccupation.Focus();
                //}
            }
            catch
            {
            }
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (cmbCity.SelectedIndex == -1 && cmbGender.Text != "<Select>")
                //{
                //    MessageBox.Show("Data Not found");
                //    //cmbCity.Text = "";
                //    cmbCity.Focus();
                //}
            }
            catch
            {
            }
        }

        private void cmbNationality_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (cmbNationality.SelectedIndex == -1 && cmbGender.Text != "<Select>")
                //{
                //    MessageBox.Show("Data Not found");
                //    //cmbNationality.Text = "";
                //    cmbNationality.Focus();
                //}
            }
            catch
            {
            }
        }

        private void cmbReligion_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (cmbReligion.SelectedIndex == -1 && cmbGender.Text != "<Select>")
                //{
                //    MessageBox.Show("Data Not found");
                //    //cmbReligion.Text = "";
                //}
            }
            catch
            {
            }
        }

        private void cmbPatientCondition_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (cmbPatientCondition.SelectedIndex == -1 && cmbGender.Text != "<Select>")
                //{
                //    MessageBox.Show("Data Not found");
                //    //cmbPatientCondition.Text = "";
                //    cmbPatientCondition.Focus();
                //}
            }
            catch
            {
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
        private void RefundMoneyPrint()
        {
            try
            {
                int investigationID = Convert.ToInt32(lvwTest.SelectedItems[0].SubItems[10].Text);
                int DeptID = Convert.ToInt32(lvwTest.SelectedItems[0].SubItems[4].Text);
                //InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                //DataSet ds= investigationOrderBLL.OrdernoGet(investigationID);

                //for (int i = 0; i < lvwTest.Items.Count; i++)
                //{
                //if (DeptID == Convert.ToInt32(lvwTest.Items[i].SubItems[10].Text))
                //{
                //int OrderId = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new InvestigationCancelation();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                rptCustomersOrders.SetParameterValue("@test_department_id", DeptID);
                rptCustomersOrders.SetParameterValue("@investigationId", investigationID);
                rptCustomersOrders.SetParameterValue("@test_departmentID", DeptID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
                //}
                //}
            }
            catch
            {
            }
        }

        

        private void lvwTest_Click(object sender, EventArgs e)
        {
            try
            {

                if (lvwTest.SelectedItems.Count > 0)
                {
                    //price = Convert.ToDouble(lvwTest.SelectedItems[0].SubItems[3].Text);
                    //txtTestTotal.Text = price.ToString();
                    //price = 0.0;

                }
            }
            catch
            {
            }
        }

        private void txtAgeYy_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int investigationID = Convert.ToInt32(lvwTest.Items[0].SubItems[10].Text);
                PrintInestigationReport(investigationID);
            }
            catch
            {
            }
        }

        private void lblDailySales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (cmbTestDepartemt.SelectedIndex >= 0)
                {
                    FrmDailySales frmDailySales = new FrmDailySales(Convert.ToInt32(cmbTestDepartemt.SelectedValue));
                    frmDailySales.MdiParent = this.MdiParent;
                    frmDailySales.Show();
                }
                else
                {
                    FrmDailySales frmDailySales = new FrmDailySales(-1);
                    frmDailySales.MdiParent = this.MdiParent;
                    frmDailySales.Show();
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
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void cmbTestItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InvestigationBLL investigationBLL = new InvestigationBLL();
            //DataSet dssp = investigationBLL.spSearch(Convert.ToInt32(cmbTestItem.SelectedValue));
            //int s =Convert.ToInt32( dssp.Tables[0].Rows[0][0]);
            //txtsp.Text = s.ToString();
        }

        private void txtPathology_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (txtPathology.Text == "")
                    {
                        txtPathology.Text = "00.00";
                    }
                    else if (txtXray.Text == "")
                    {
                        txtXray.Text = "00.00";
                    }
                    else if (txtUsg.Text == "")
                    {
                        txtUsg.Text = "00.00";
                    }
                    else if (txtEcg.Text == "")
                    {
                        txtEcg.Text = "00.00";
                    }
                    GetNetPayable();
                    //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                    //this.txtNetPayable.Text = NP.ToString("0#.#0");

                }
            }
            catch
            {
            }

        }

        private void txtXray_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (txtPathology.Text == "")
                    {
                        txtPathology.Text = "00.00";
                    }
                    else if (txtXray.Text == "")
                    {
                        txtXray.Text = "00.00";
                    }
                    else if (txtUsg.Text == "")
                    {
                        txtUsg.Text = "00.00";
                    }
                    else if (txtEcg.Text == "")
                    {
                        txtEcg.Text = "00.00";
                    }
                    GetNetPayable();
                    //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                    //this.txtNetPayable.Text = NP.ToString("0#.#0");

                }
            }
            catch
            {
            }
        }

        private void txtUsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (txtPathology.Text == "")
                    {
                        txtPathology.Text = "00.00";
                    }
                    else if (txtXray.Text == "")
                    {
                        txtXray.Text = "00.00";
                    }
                    else if (txtUsg.Text == "")
                    {
                        txtUsg.Text = "00.00";
                    }
                    else if (txtEcg.Text == "")
                    {
                        txtEcg.Text = "00.00";
                    }
                    GetNetPayable();
                    //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                    //this.txtNetPayable.Text = NP.ToString("0#.#0");

                }
            }
            catch
            {
            }
        }

        private void txtEcg_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (txtPathology.Text == "")
                    {
                        txtPathology.Text = "00.00";
                    }
                    else if (txtXray.Text == "")
                    {
                        txtXray.Text = "00.00";
                    }
                    else if (txtUsg.Text == "")
                    {
                        txtUsg.Text = "00.00";
                    }
                    else if (txtEcg.Text == "")
                    {
                        txtEcg.Text = "00.00";
                    }
                    GetNetPayable();
                    //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                    //this.txtNetPayable.Text = NP.ToString("0#.#0");
                }
            }
            catch
            {
            }
        }

        public void txtPathology_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPathology.Text == "")
                { 
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
                //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                //this.txtNetPayable.Text = NP.ToString("0#.#0");
            }
            catch
            {
            }

        }

        private void txtXray_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
                //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                //this.txtNetPayable.Text = NP.ToString("0#.#0");
            }
            catch
            {
            }

        }

        private void txtUsg_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
                //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                //this.txtNetPayable.Text = NP.ToString("0#.#0");

            }
            catch
            {
            }

        }

        private void txtEcg_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
                //double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                //this.txtNetPayable.Text = NP.ToString("0#.#0");


            }
            catch
            {
            }

        }
        private void GetNetPayable()
        {
            try
            {
                double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                this.txtNetPayable.Text = NP.ToString("0#.#0");

                txtToal.Text = (NP + Convert.ToDouble(txtTubeTotal.Text)).ToString("0#.#0");

            }
            catch
            {
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmDoctor_sNameEntry frmDoctor_sNameEntry = new FrmDoctor_sNameEntry();
                frmDoctor_sNameEntry.Show();

            }
            catch
            {
            }
        }


        private void chkgroup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkgroup.Checked == true)
                    cmbTestGroup.Enabled = true;
                else
                {
                    cmbTestGroup.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void grdtestitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            string msg = "";
            DataGridViewRow row = null;
            row = this.grdtestitems.Rows[e.RowIndex];
            try
            {
                    string valueStr = (row.Cells[3].Value.ToString() == null ? "" : row.Cells[3].Value.ToString());

                    if (e.ColumnIndex == 0)
                    {
                        ////////////////////////////////////////////////add///////////////////////


                        if (grdtestitems.Rows[e.RowIndex].Cells[9].Value == null)//add
                        {
                            if (IsMatchTest(cmbTestDepartemt.Text, valueStr) == true)
                            {
                                MessageBox.Show("Test already exists");
                                row.Cells[0].Selected = true;
                                //row.Cells[0].
                                return;
                            }
                            ListViewItem lvi = new ListViewItem(this.cmbTestDepartemt.Text);//department
                            lvi.SubItems.Add(row.Cells[2].Value.ToString());//group
                            lvi.SubItems.Add(row.Cells[3].Value.ToString());//testitems
                            lvi.SubItems.Add(row.Cells[4].Value.ToString());//charge
                            lvi.SubItems.Add(row.Cells[5].Value.ToString());//department_id
                            lvi.SubItems.Add(row.Cells[6].Value.ToString());//group_id
                            lvi.SubItems.Add(row.Cells[7].Value.ToString());//testitems_id
                            lvi.SubItems.Add(((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[0].ToString());//refdoctor
                            lvi.SubItems.Add(cmbRefferedDoctors.SelectedValue.ToString());//refdoc id
                            lvi.SubItems.Add(row.Cells[8].Value.ToString());//speciman id
                            lvwTest.Items.Add(lvi);//
                            this._selectedDr = cmbRefferedDoctors.Text;
                            grdtestitems.Rows[e.RowIndex].Cells[9].Value = "F";//add
                            if (rdoconsultation.Checked == true)
                                goto next;

                            ////////////////////////////////////
                            if (Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[5].Value) == 2)//if department= pathology
                            {
                                if (Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[8].Value) == 1)//if speciman=blood
                                {
                                    int n = 0;
                                    for (int m = 0; m < grdInvestigtionTube.Rows.Count; m++)
                                    {
                                        if (grdInvestigtionTube.Rows.Count == 0)
                                            addproduct(Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[8].Value));
                                        if (grdInvestigtionTube.Rows.Count>0)
                                        {
                                            n = 1;
                                        }
                                    }
                                    if (n != 1)
                                    {
                                        addproduct(Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[8].Value));
                                    }
                             

                                }
                                else//if speciman !=blood
                                {
                                    if (Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[8].Value) > 1)
                                    {
                                        //int z = 0;
                                        //for (int j = 0; j < lvwtestproduct.Items.Count; j++)
                                        //{
                                        //    if (Convert.ToInt32(lvwtestproduct.Items[j].SubItems[3].Text) == Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[8].Value))
                                        //        z = 1;

                                        //}
                                        //if (z == 0)
                                        //{
                                        //    addproduct(Convert.ToInt32(grdtestitems.Rows[e.RowIndex].Cells[8].Value));
                                        //}

                                    }
                                }
                            }

                            double total = 0.0;
                            for (int i = 0; i < lvwTest.Items.Count; i++)
                            {
                                double subTolal;
                                subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                                total = total + subTolal;
                            }
                            //double vat = ((total * 2.25) / 100);
                            //int Gtotal = Convert.ToInt32(total + vat);
                            int Gtotal = Convert.ToInt32(total);
                            this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                            if (txtPathology.Text == "")
                            {
                                txtPathology.Text = "00.00";
                            }
                            else if (txtXray.Text == "")
                            {
                                txtXray.Text = "00.00";
                            }
                            else if (txtUsg.Text == "")
                            {
                                txtUsg.Text = "00.00";
                            }
                            else if (txtEcg.Text == "")
                            {
                                txtEcg.Text = "00.00";
                            }
                            double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology .Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                            this.txtNetPayable.Text = NP.ToString("0#.#0");
                            this.lvwTest.Refresh();

                            if (this.lvwTest.Items.Count > 0)
                            {
                                this.btnSave.Enabled = true;
                            }
                            if (cmbTestDepartemt.Text == "Pathology")
                            {
                                txtPathology.Enabled = true;
                                txtPathPercentage.Enabled = true;
                            }
                            else if (cmbTestDepartemt.Text == "X-Ray")
                            {
                                txtXray.Enabled = true;
                                txtXrayPercentage.Enabled = true;
                            }
                            else if (cmbTestDepartemt.Text == "USG")
                            {
                                txtUsg.Enabled = true;
                                txtUSGPercentage.Enabled = true;
                            }
                            else if (cmbTestDepartemt.Text == "ECG")
                            {
                                txtEcg.Enabled = true;
                                txtECGPercentage.Enabled = true;
                            }
                            else
                            {
                                txtPathology.Enabled = false;
                                txtPathPercentage.Enabled = false;
                                txtXray.Enabled = false;
                                txtXrayPercentage.Enabled = false;
                                txtUsg.Enabled = false;
                                txtUSGPercentage.Enabled = false;
                                txtEcg.Enabled = false;
                                txtECGPercentage.Enabled = false;
                            }
                            

                        }
                        /////////////////////end of add/////////////////////////////////////////////
                        else
                        {
                            if (grdtestitems.Rows[e.RowIndex].Cells[9].Value.ToString() == "T")//readd
                            {
                                if (IsMatchTest(cmbTestDepartemt.Text, valueStr) == true)
                                {
                                    MessageBox.Show("Test already exists");
                                    row.Cells[0].Selected = true;
                                    return;
                                }
                                ListViewItem lvi = new ListViewItem(this.cmbTestDepartemt.Text);//department
                                lvi.SubItems.Add(row.Cells[2].Value.ToString());//group
                                lvi.SubItems.Add(row.Cells[3].Value.ToString());//testitems
                                lvi.SubItems.Add(row.Cells[4].Value.ToString());//charge
                                lvi.SubItems.Add(row.Cells[5].Value.ToString());//department_id
                                lvi.SubItems.Add(row.Cells[6].Value.ToString());//group_id
                                lvi.SubItems.Add(row.Cells[7].Value.ToString());//testitems_id
                                lvi.SubItems.Add(((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[0].ToString());
                                lvi.SubItems.Add(cmbRefferedDoctors.SelectedValue.ToString());
                                lvi.SubItems.Add(row.Cells[8].Value.ToString());
                                lvwTest.Items.Add(lvi);
                                this._selectedDr = cmbRefferedDoctors.Text;
                                grdtestitems.Rows[e.RowIndex].Cells[9].Value = "F";//add
                            }
                            else//remove
                            {
                                //for (int i = 0; i < lvwTest.Items.Count; i++)
                                //{
                                //    if (lvwTest.Items[i].SubItems[0].Text == dept)
                                //    {


                                //        return true;
                                //    }
                                //}
                                lvwTest.Items.Remove(lvwTest.FindItemWithText(grdtestitems.Rows[e.RowIndex].Cells[1].Value.ToString()));//MessageBox.Show("False");
                                grdtestitems.Rows[e.RowIndex].Cells[9].Value = "T";

                                string Dept=grdtestitems.Rows[e.RowIndex].Cells[1].Value.ToString();

                                //string Dept = lvwTest.SelectedItems[0].SubItems[0].Text;
                                int flag = 0;
                                double total1 = double.Parse(this.txtTestTotal.Text);

                                total1 -= double.Parse(grdtestitems.Rows[e.RowIndex].Cells[4].Value.ToString());
                                this.txtTestTotal.Text = total1.ToString("0#.#0");
                                //lvwTest.Items.Remove(lvwTest.FocusedItem);
                                double total = 0.0;
                                for (int i = 0; i < lvwTest.Items.Count; i++)
                                {
                                    double subTolal;
                                    subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                                    total = total + subTolal;
                                }
                                //double vat = ((total * 2.25) / 100);
                                //int Gtotal = Convert.ToInt32(total + vat);
                                int Gtotal = Convert.ToInt32(total);
                                this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                                if (txtPathology.Text == "")
                                {
                                    txtPathology.Text = "00.00";
                                }
                                else if (txtXray.Text == "")
                                {
                                    txtXray.Text = "00.00";
                                }
                                else if (txtUsg.Text == "")
                                {
                                    txtUsg.Text = "00.00";
                                }
                                else if (txtEcg.Text == "")
                                {
                                    txtEcg.Text = "00.00";
                                }
                                double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                                NP = NP + Convert.ToDouble(txtTubeTotal.Text);
                                this.txtNetPayable.Text = NP.ToString("0#.#0");
                                //this.lvwTest.Refresh();
                                if (lvwTest.Items.Count > 0)
                                {
                                    for (int i = 0; i < lvwTest.Items.Count; i++)
                                    {
                                        if (Dept == lvwTest.Items[i].SubItems[0].Text)
                                        {
                                            flag = 1;
                                            break;
                                        }
                                        else
                                        {
                                            flag = 2;
                                        }
                                    }
                                    if (flag != 1)
                                    {
                                        if (Dept == "Pathology")
                                        {
                                            txtPathology.Text = "00.00";
                                            txtPathology.Enabled = false;
                                            txtPathPercentage.Enabled = false;
                                            txtPathology_Leave(null, null);
                                        }
                                        else if (Dept == "X-Ray")
                                        {
                                            txtXray.Text = "00.00";
                                            txtXray.Enabled = false;
                                            txtXrayPercentage.Enabled = false;
                                            txtXray_Leave(null, null);
                                        }
                                        else if (Dept == "USG")
                                        {
                                            txtUsg.Text = "00.00";
                                            txtUsg.Enabled = false;
                                            txtUSGPercentage.Enabled = false;
                                            txtUsg_Leave(null, null);
                                        }
                                        else if (Dept == "ECG")
                                        {
                                            txtEcg.Text = "00.00";
                                            txtEcg.Enabled = false;
                                            txtECGPercentage.Enabled = false;
                                            txtEcg_Leave(null, null);
                                        }
                                    }
                                }
                                else
                                {
                                    txtPathology.Text = "00.00";
                                    txtXray.Text = "00.00";
                                    txtUsg.Text = "00.00";
                                    txtEcg.Text = "00.00";
                                    txtNetPayable.Text = "00.00";
                                    txtPathology.Enabled = false;
                                    txtPathPercentage.Enabled = false;
                                    txtXray.Enabled = false;
                                    txtXrayPercentage.Enabled = false;
                                    txtUsg.Enabled = false;
                                    txtUSGPercentage.Enabled = false;
                                    txtEcg.Enabled = false;
                                    txtECGPercentage.Enabled = false;
                                }
                            }
                        }
                    next:
                        double grandtotal = 0.0;
                        for (int i = 0; i < lvwTest.Items.Count; i++)
                        {
                            double subTolal;
                            subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                            grandtotal = grandtotal + subTolal;
                        }
                       // double vat = ((total * 2.25) / 100);
                        //int Gtotal = Convert.ToInt32(total + vat);
                        
                        this.txtTestTotal.Text = grandtotal.ToString("0#.#0");
                        txtToal.Text = (grandtotal + Convert.ToDouble(txtTubeTotal.Text)).ToString("0#.#0");
                    
                    }

            }
            catch
            {
                
            }
            finally
            {

                if (msg != "")
                {
                    MessageBox.Show(msg, "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[e.ColumnIndex].Value = "";
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }

        }
        private void addproduct(int r)
        {
            try
            {
                TestTubeBLL testTubeBLL = new TestTubeBLL();
                DataSet ds = testTubeBLL.TestTubeLod(r);
                double total = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdInvestigtionTube.Rows.Add();
                        grdInvestigtionTube.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                        grdInvestigtionTube.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                        grdInvestigtionTube.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                        grdInvestigtionTube.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();
                        grdInvestigtionTube.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4].ToString();
                        grdInvestigtionTube.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][5].ToString();
                        total = total+(Convert.ToDouble(ds.Tables[0].Rows[i][2]) * Convert.ToDouble(ds.Tables[0].Rows[i][3]));
                    }
                }
                txtTubeTotal.Text = total.ToString("0#.#0");
            }
            catch
            {
            }
        }

        private void rdoconsultation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoconsultation.Checked == true)
                {
                    cmbTestDepartemt.DataSource = null;
                    lvwTest.Columns[1].Text = "ID";
                    txtTestTotal.Text = "00.00";
                    txtNetPayable.Text = "00.00";
                    lvwTest.Items.Clear();
                    grpTest.Text = "Consultant List";
                    cmbRefferedDoctors.Enabled = false;
                    ResetPatientContents();
                    RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
                    DataSet ds = refferedDoctorsBLL.getconsultant();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdtestitems.Rows.Clear();
                        grdtestitems.Columns["test_items"].HeaderText = "Consultant Name";
                        grptestitems.Text = "Comsultation";
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells[2].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["reffered_doctors_id"].ToString());
                            grdtestitems.Rows[i].Cells[5].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["reffered_doctors_id"].ToString());
                            grdtestitems.Rows[i].Cells[6].Value = 0;
                            grdtestitems.Rows[i].Cells[7].Value = 0;
                            grdtestitems.Rows[i].Cells[8].Value = 0;
                            grdtestitems.Rows[i].Cells[1].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["reffered_doctors_id"].ToString());                                      //admn_id
                            grdtestitems.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i]["reffered_doctors"].ToString();
                            grdtestitems.Rows[i].Cells[4].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["visit_charge"].ToString());
                         
                        }
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        this.cmbTestDepartemt.SelectedIndexChanged -= this.cmbTestDepartemt_SelectedIndexChanged;
                        PopulateComboBox(cmbTestDepartemt, ds, 1, "specialist_in", "specialist_in_id");
                        this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
                       
                    }
                    
                }
                else if (rdohealthcare.Checked == true)
                {
                    cmbTestDepartemt.DataSource = null;
                    txtTestTotal.Text = "00.00";
                    txtNetPayable.Text = "00.00";
                    lvwTest.Items.Clear();
                    grpTest.Text = "Service List";
                    cmbRefferedDoctors.Enabled = false;
                    ResetPatientContents();
                    OtherItemBLL otherItemBLL = new OtherItemBLL();
                    DataSet ds = otherItemBLL.getotheritems();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdtestitems.Rows.Clear();
                        grdtestitems.Columns["test_items"].HeaderText = "Services";
                        grptestitems.Text = "Health Services";
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells[2].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["other_item_id"].ToString());
                            grdtestitems.Rows[i].Cells[5].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["other_item_id"].ToString());
                            grdtestitems.Rows[i].Cells[6].Value = 0;
                            grdtestitems.Rows[i].Cells[7].Value = 0;
                            grdtestitems.Rows[i].Cells[8].Value = 0;
                            grdtestitems.Rows[i].Cells[1].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["other_item_id"].ToString());                                      //admn_id
                            grdtestitems.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i]["other_item"].ToString();
                            grdtestitems.Rows[i].Cells[4].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["unit_rate"].ToString());

                        }
                    }
                }
                else
                {
                    lvwTest.Columns[1].Text = "Group";
                    txtTestTotal.Text = "00.00";
                    txtNetPayable.Text = "00.00";
                    lvwTest.Items.Clear();
                    grdtestitems.Rows.Clear();
                    grpTest.Text = "Test";
                    grptestitems.Text = "Test Items";
                    grdtestitems.Columns["test_items"].HeaderText = "Test Name";
                    cmbRefferedDoctors.Enabled = true;
                    RefreshInvestigation();

                }
            }
            catch
            {
            }

        }
        void access()
        {
            try
            {
                grpTest.Enabled = false;
                cmbTestDepartemt.Enabled = false;
                cmbTestGroup.Enabled = false;
            }
            catch
            {
            }
        }

        private void btnfresh_Click(object sender, EventArgs e)
        {
            try
            {
                ResetPatientContents();
            }
            catch
            {
            }
        }

        private void btntotalrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                grdtestitems.Rows.Clear();
                lvwTest.Items.Clear();
                ResetPatientContents();
                active();
            }
            catch
            {
            }
        }
        void active()
        {
            try
            {
                txtTestTotal.Text = "00.00";
                txtNetPayable.Text = "00.00";
                txtPathology.Text = "00.00";
                txtPathology.Enabled = false;
                txtPathPercentage.Enabled = false;
                txtXray.Text = "00.00";
                txtXray.Enabled = false;
                txtXrayPercentage.Enabled = false;
                txtUsg.Text = "00.00";
                txtUsg.Enabled = false;
                txtUSGPercentage.Enabled = false;
                txtEcg.Text = "00.00";
                txtEcg.Enabled = false;
                txtECGPercentage.Enabled = false;
                txtTubeTotal.Text="00.00";
            }
            catch
            {
            }
        }

        private void btnDoctorSearch_Click(object sender, EventArgs e)
        {
            FrmdoctorSearch oFrmdoctorSearch = new FrmdoctorSearch(null,null,null,null,this,null);
            oFrmdoctorSearch.ShowDialog();
        }
        public void LoadDoctorName(int id)
        {
            cmbRefferedDoctors.SelectedValue = id;
        }

        private void grdInvestigtionTube_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                DataGridViewRow row = null;
                row = this.grdInvestigtionTube.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                int valueNumeric = 0;
                int.TryParse(valueStr, out valueNumeric);
                if (valueNumeric <= 0)
                {
                    row.Cells["Qty"].Value =1;
                }
                GetTubeTotal();
            }

            catch
            {
            }
        }
        private void GetTubeTotal()
        {
            double total = 0;
            for (int i = 0; i < grdInvestigtionTube.Rows.Count; i++)
            {

                total = total + (Convert.ToDouble(grdInvestigtionTube.Rows[i].Cells[2].Value) * Convert.ToDouble(grdInvestigtionTube.Rows[i].Cells[3].Value));
            }
            txtTubeTotal.Text = total.ToString("0#.#0");
            double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
            NP = NP + Convert.ToDouble(txtTubeTotal.Text);
            this.txtToal.Text = NP.ToString("0#.#0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMemberSearch frmMemberSearch = new FrmMemberSearch (this,null);
            frmMemberSearch.ShowDialog();
        }

        private void txtInvestigationSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtInvestigationSearch.Text != "")
                {
                    InvestigationTestBLL oInvestigationTestBLL = new InvestigationTestBLL();
                    DataSet ds = oInvestigationTestBLL.SearchTest(txtInvestigationSearch.Text);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdtestitems.Rows.Clear();

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells["test_department"].Value = ds.Tables[0].Rows[i]["test_department"].ToString();                                      //admn_id
                            grdtestitems.Rows[i].Cells["test_group"].Value = ds.Tables[0].Rows[i]["test_group"].ToString();                                     //cabin_id
                            grdtestitems.Rows[i].Cells["test_items"].Value = ds.Tables[0].Rows[i]["test_item"].ToString();
                            grdtestitems.Rows[i].Cells["test_charge"].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["charge"].ToString());
                            grdtestitems.Rows[i].Cells["department_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_department_id"].ToString());
                            grdtestitems.Rows[i].Cells["group_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_group_id"].ToString());
                            grdtestitems.Rows[i].Cells["item_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_item_id"].ToString());
                            grdtestitems.Rows[i].Cells["speciman_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["specimen_id"].ToString());
                        }
                    }

                }
            }
            catch
            {
            }
        }

        public void LoadMemberName(string SType, string  name, string mobile, string AGE, int ID)
        {
            try
            {
                txtSType.Text = SType;
                txtPatientName.Text = name;
                txtCPhone.Text = mobile;
                txtAgeYy.Text = AGE;
                cmbGender.SelectedValue = ID;
                txtAddress.Text = "Rangpur";
                cmbOccupation.SelectedValue = 6;
                txtRemarks.Text = SType;
                Age();



            }
            catch
            {
            }

        }

        void AutoDiscount()
        {
            try
            {
                if (rdoInvestigation.Checked == true && txtSType.Text=="Stuff")
                {
                    int rate = 75;
                    decimal path = 0, xray = 0, usg = 0, ecg = 0;
                    for (int m = 0; m < lvwTest.Items.Count; m++)
                    {
                        if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                        {
                            path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//xray
                        {
                            xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//usg
                        {
                            usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ecg
                        {
                            ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else
                        {
                            
                        }
                      }

                        
                        txtPathology.Text = Convert.ToDecimal((path * rate)/100).ToString();
                        if (txtPathology.Text != "")
                        {
                            Path_discount_cal();
                        }
                        txtXray.Text = Convert.ToDecimal((xray* rate)/100).ToString();
                        if (txtXray.Text != "")
                        {
                            Xray_discount_cal();
                        }
                        txtUsg.Text = Convert.ToDecimal((usg * rate) / 100).ToString();
                        if (txtUsg.Text != "")
                        {
                            Usg_discount_cal();
                        }
                        txtEcg.Text = Convert.ToDecimal((ecg * rate) / 100).ToString();
                        if (txtEcg.Text != "")
                        {
                            Ecg_discount_cal();
                        }

                    }

                if (rdoInvestigation.Checked == true && txtSType.Text == "Member")
                {
                    int rate = 75;
                    decimal path = 0, xray = 0, usg = 0, ecg = 0;
                    for (int m = 0; m < lvwTest.Items.Count; m++)
                    {
                        if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                        {
                            path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//xray
                        {
                            xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//usg
                        {
                            usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ecg
                        {
                            ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else
                        {

                        }
                    }


                    txtPathology.Text = Convert.ToDecimal((path * rate) / 100).ToString();
                    if (txtPathology.Text != "")
                    {
                        Path_discount_cal();
                    }
                    txtXray.Text = Convert.ToDecimal((xray * rate) / 100).ToString();
                    if (txtXray.Text != "")
                    {
                        Xray_discount_cal();
                    }
                    txtUsg.Text = Convert.ToDecimal((usg * rate) / 100).ToString();
                    if (txtUsg.Text != "")
                    {
                        Usg_discount_cal();
                    }
                    txtEcg.Text = Convert.ToDecimal((ecg * rate) / 100).ToString();
                    if (txtEcg.Text != "")
                    {
                        Ecg_discount_cal();
                    }

                }

                if (rdoInvestigation.Checked == true && txtSType.Text == "Dependable")
                {
                    int rate = 50;
                    decimal path = 0, xray = 0, usg = 0, ecg = 0;
                    for (int m = 0; m < lvwTest.Items.Count; m++)
                    {
                        if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                        {
                            path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//xray
                        {
                            xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//usg
                        {
                            usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ecg
                        {
                            ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else
                        {

                        }
                    }


                    txtPathology.Text = Convert.ToDecimal((path * rate) / 100).ToString();
                    if (txtPathology.Text != "")
                    {
                        Path_discount_cal();
                    }
                    txtXray.Text = Convert.ToDecimal((xray * rate) / 100).ToString();
                    if (txtXray.Text != "")
                    {
                        Xray_discount_cal();
                    }
                    txtUsg.Text = Convert.ToDecimal((usg * rate) / 100).ToString();
                    if (txtUsg.Text != "")
                    {
                        Usg_discount_cal();
                    }
                    txtEcg.Text = Convert.ToDecimal((ecg * rate) / 100).ToString();
                    if (txtEcg.Text != "")
                    {
                        Ecg_discount_cal();
                    }

                }

                if (rdoInvestigation.Checked == true && txtSType.Text == "Stuff Dependable")
                {
                    int rate = 50;
                    decimal path = 0, xray = 0, usg = 0, ecg = 0;
                    for (int m = 0; m < lvwTest.Items.Count; m++)
                    {
                        if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                        {
                            path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//xray
                        {
                            xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//usg
                        {
                            usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ecg
                        {
                            ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else
                        {

                        }
                    }


                    txtPathology.Text = Convert.ToDecimal((path * rate) / 100).ToString();
                    if (txtPathology.Text != "")
                    {
                        Path_discount_cal();
                    }
                    txtXray.Text = Convert.ToDecimal((xray * rate) / 100).ToString();
                    if (txtXray.Text != "")
                    {
                        Xray_discount_cal();
                    }
                    txtUsg.Text = Convert.ToDecimal((usg * rate) / 100).ToString();
                    if (txtUsg.Text != "")
                    {
                        Usg_discount_cal();
                    }
                    txtEcg.Text = Convert.ToDecimal((ecg * rate) / 100).ToString();
                    if (txtEcg.Text != "")
                    {
                        Ecg_discount_cal();
                    }

                }

                  
               }

            catch
            {
            }
        }

        private void btnAutoDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSType.Text != "")
                {
                    AutoDiscount();
                }
                else
                {
                    MessageBox.Show("Not Available for Other Pathents");
                    return;
                }
            }
            catch
            {
            }
        }

        void Path_discount_cal()
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
            }
            catch
            {
            }
        }

        void Xray_discount_cal()
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
            }
            catch
            {
            }
        }

        void Usg_discount_cal()
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
            }
            catch
            {
            }
        }

        void Ecg_discount_cal()
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
            }
            catch
            {
            }
        }

        void Age()
        {
            try
            {
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
            }
            catch
            {
            }
        }


        void DiscountPercentagePathology()
        {
            try
            {
                decimal path = 0, PathDiscount = 0;
                for (int m = 0; m < lvwTest.Items.Count; m++)
                {
                    if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                    {
                        path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                    }

                    else
                    {

                    }
                }

                PathDiscount = (Convert.ToDecimal(txtPathPercentage.Text) * path) / 100;

                this.txtPathology.Text = PathDiscount.ToString();//"0#.#0"

            }
            catch
            {
            }
        }

        void DiscountPercentageXRay()
        {
            try
            {
                decimal xray = 0, XrayDiscount = 0;
                for (int m = 0; m < lvwTest.Items.Count; m++)
                {
                    if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//X-ray
                    {
                        xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                    }

                    else
                    {

                    }
                }

                XrayDiscount = (Convert.ToDecimal(txtXrayPercentage.Text) * xray) / 100;

                this.txtXray.Text = XrayDiscount.ToString();//"0#.#0"

            }
            catch
            {
            }
        }

        void DiscountPercentageUsg()
        {
            try
            {
                decimal usg = 0, UsgDiscount = 0;
                for (int m = 0; m < lvwTest.Items.Count; m++)
                {
                    if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//USG
                    {
                        usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                    }

                    else
                    {

                    }
                }

                UsgDiscount = (Convert.ToDecimal(txtUSGPercentage.Text) * usg) / 100;

                this.txtUsg.Text = UsgDiscount.ToString();//"0#.#0"

            }
            catch
            {
            }
        }

        void DiscountPercentageEcg()
        {
            try
            {
                decimal ecg = 0, EcgDiscount = 0;
                for (int m = 0; m < lvwTest.Items.Count; m++)
                {
                    if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ECG
                    {
                        ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                    }

                    else
                    {

                    }
                }

                EcgDiscount = (Convert.ToDecimal(txtECGPercentage.Text) * ecg) / 100;

                this.txtEcg.Text = EcgDiscount.ToString();//"0#.#0"

            }
            catch
            {
            }
        }


        void CalculateAdvance()
        {
            try
            {
                if (txtPathology.Text == "")
                {
                    txtPathology.Text = "00.00";
                }
                else if (txtXray.Text == "")
                {
                    txtXray.Text = "00.00";
                }
                else if (txtUsg.Text == "")
                {
                    txtUsg.Text = "00.00";
                }
                else if (txtEcg.Text == "")
                {
                    txtEcg.Text = "00.00";
                }
                GetNetPayable();
            }
            catch
            {
            }
        }

        private void txtPathPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DiscountPercentagePathology();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtPathPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                DiscountPercentagePathology();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtXrayPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DiscountPercentageXRay();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtXrayPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                DiscountPercentageXRay();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtUSGPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                DiscountPercentageUsg();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtUSGPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DiscountPercentageUsg();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtECGPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DiscountPercentageEcg();
                CalculateAdvance();
            }
            catch
            {
            }
        }

        private void txtECGPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                DiscountPercentageEcg();
                CalculateAdvance();
            }
            catch
            {
            }
        }

    }
}

    