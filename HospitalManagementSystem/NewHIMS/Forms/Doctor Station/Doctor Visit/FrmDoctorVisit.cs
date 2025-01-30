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
using NewHIMS.Reports.Doctor_Station.Doctor_Visit;
using NewHIMS.Reports.Doctor_Station.Discharge;


namespace NewHIMS.Forms.Doctor_Station.Doctor_Visit
{
    public enum VisitMode { VISIT, OVERPHONE, DISCHARGE };
    
    public partial class FrmDoctorVisit : BaseForm.FrmBase
    {
        private VisitMode _currentVisitMode = VisitMode.VISIT;
        private string _prescriptionID = "";
        private string _admissionID = "";
        private string _admissionCode = "";
        private string _admissionDate = "";
        private string _hospitalID = "";
        private int _cabinID = 0;
        private int surgeonID = 0;
        private string _prescriptiondate = "";
        private string _Usersurname = "";
        private int productID = 0;
        private int DischargeID = 0;
        private decimal Visitamout = 0;
        
        private DateTime todate = DateTime.Now;
        private FrmDoctorStation _objForm;
        
        public FrmDoctorVisit()
        {
            InitializeComponent();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            if(combo.SelectedIndex >0)
                combo.SelectedIndex = 0;
        }

        private void FillUpListview1(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();
            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

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
                    lvi.SubItems.Add(dataRow[9].ToString());
                    lvi.SubItems.Add(dataRow[10].ToString());
                    lvi.SubItems.Add(dataRow[11].ToString());

                    lvw.Items.Add(lvi);
                }
            }

        }
        private void FillUpListview2(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();
            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                    lvi.SubItems.Add(dataRow[1].ToString());
                    lvi.SubItems.Add(dataRow[2].ToString());
                    lvi.SubItems.Add(dataRow[3].ToString());
                    lvi.SubItems.Add(dataRow[4].ToString());
                    lvi.SubItems.Add(dataRow[5].ToString());
                    lvi.SubItems.Add(dataRow[6].ToString());
                    
                    lvw.Items.Add(lvi);
                }
            }

        }
        private void FillUpListview3(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();
            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                    lvi.SubItems.Add(dataRow[1].ToString());
                    lvi.SubItems.Add(dataRow[2].ToString());
                    
                    lvw.Items.Add(lvi);
                }
            }

        }
        //private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        //{
        //    lvw.Items.Clear();

        //    for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
        //    {
        //        DataRow dataRow = ds.Tables[tableIndex].Rows[i];

        //        if (dataRow.RowState != DataRowState.Deleted)
        //        {
        //            ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
        //            //for (int j = 1; j < ds.Tables[tableIndex].Rows.Count; j++)
        //            //{
        //                lvi.SubItems.Add(dataRow[i].ToString());
        //            //}
        //            lvw.Items.Add(lvi);
        //        }
        //    }
        //}

        public void refreshContent(FrmDoctorStation objFrom,VisitMode visitMode, string admissionId, string admissionCode, string admissionDate, string hospitalID, int cabinID)
        {
            try
            {
                
                this._objForm = objFrom;
                this.lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                this._currentVisitMode = visitMode;
                this._admissionID = admissionId;
                this._admissionCode = admissionCode;
                this._admissionDate = admissionDate;
                this._hospitalID = hospitalID;
                this._cabinID = cabinID;

                this.btnDischarge.Visible = false;
                if (visitMode == VisitMode.VISIT)
                {
                    this.lblTitle.Text = "VISIT";
                }
                else if (visitMode == VisitMode.DISCHARGE)
                {
                    this.lblTitle.Text = "DISCHARGE";
                    this.grpInvestigation.Visible = false;
                    this.grpCaseSummary.Visible = true;
                    //this.lvwInvestigation.Visible = false;
                    //this.txtPreCaseSummary.Visible = true;
                    //this.txtAftCaseSummary.Visible = true;
                    linkLabel1.Visible = true;
                    this.grpTreatement.Visible = false;
                    this.grpPatient.Width = this.grpMedicine.Width;
                    this.grpAdvice.Top = 200;
                    this.grpAdvice.Height = 250;
                    this.btnDischarge.Visible = true;
                    btnPrint.Visible = false;
                }
                else if (visitMode == VisitMode.OVERPHONE)
                {
                    this.lblTitle.Text = "OVER PHONE";
                }

                AdmissionBLL admissionBLL = new AdmissionBLL();
                DataSet ds = admissionBLL.GetDoctorVisitPopulationInfo(Convert.ToInt32( admissionId));
                txtAdmissionCode.Text = this._admissionCode.ToString();
                //txtPatientCode.Text = this._admissionCode.ToString();
                txtPatientCode.Text = this._hospitalID.ToString();
                txtPatientName.Text = ds.Tables[0].Rows[0][0].ToString();

                txtCC.Text = ds.Tables[1].Rows[0][0].ToString();
                
                for(int i=1;i<ds.Tables[1].Rows.Count;i++){
                    txtCC.Text = txtCC.Text + "\r\n" + ds.Tables[1].Rows[i][0].ToString();
                }

                if (ds.Tables[2].Rows.Count>0)
                {
                    txtRefferedDoctors.Text = ds.Tables[2].Rows[0][0].ToString();
                    surgeonID = Convert.ToInt16( ds.Tables[2].Rows[0][1].ToString());
                    for (int i = 1; i < ds.Tables[2].Rows.Count; i++)
                    {
                        txtRefferedDoctors.Text = txtRefferedDoctors.Text + "\r\n" + ds.Tables[2].Rows[i][0].ToString();
                    }
                }
                
                txtAdmissionDate.Text = admissionDate.ToString();
                PopulateComboBox(cmbConsultant, ds, 3, "reffDoc", "reffered_doctors_id");
                if (ds.Tables[2].Rows.Count>0)
                    cmbConsultant.SelectedIndex = cmbConsultant.FindString(ds.Tables[2].Rows[0][0].ToString());
                this.cmbproductcategory.SelectedIndexChanged -= this.cmbproductcategory_SelectedIndexChanged;
                PopulateComboBox(cmbproductcategory, ds, 4, "product_category", "product_category_id");
                cmbproductcategory.SelectedIndex = -1;
                cmbproductcategory.Text = "<Select>";
                this.cmbproductcategory.SelectedIndexChanged += new System.EventHandler(this.cmbproductcategory_SelectedIndexChanged);
                //PopulateComboBox(cmbMedicine, ds, 4, "product", "product_id");
                PopulateComboBox(cmbDosePQuantity, ds, 5, "dose_p_quantity", "dose_p_quantity_id");
                PopulateComboBox(cmbIntakeIndication, ds, 7, "implication_way", "implication_way_id");
                PopulateComboBox(cmbIntakeSys, ds, 6, "intake_sys", "intake_sys_id");
                PopulateComboBox(cmbTiming, ds, 8, "medicine_timing", "medicine_timing_id");
                PopulateComboBox(cmbTestDepartemt, ds, 9, "test_department", "test_department_id");
                this.cmbTreatement.SelectedIndexChanged -= this.cmbTreatement_SelectedIndexChanged;
                PopulateComboBox(cmbTreatement, ds, 10, "treatement", "treatement_id");
                this.cmbTreatement.SelectedIndexChanged+=new EventHandler(cmbTreatement_SelectedIndexChanged);
                PopulateComboBox(cmbAdvice, ds, 11, "advice", "advice_id");
                FillUpMedicineListview(ds);
                FillUpListview1(lvwInvestigation,ds,13);
                FillUpListview2(lvwTreatement, ds, 14);
                FillUpListview3(lvwAdvice, ds, 15);
                cmbTiming.SelectedIndex = cmbTiming.FindString("6 Hourly");
                
                this.dtpPrescriptionDate.Focus();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        private void FillUpMedicineListview(DataSet ds)
        {
            try
            {
                lvwMedicine.Items.Clear();
                
                if (ds.Tables[12].Rows.Count < 1) return;
               
                string strValue = ds.Tables[12].Rows[0][1].ToString();//visit medicine
                string strIDs = "";
                int i;
                for (i = 0; i <ds.Tables[12].Rows.Count; i++)
                {
                    string kk = ds.Tables[12].Rows[i][1].ToString();
                    if (ds.Tables[12].Rows[i][1].ToString() == strValue)
                    {
                        strIDs = strIDs + "," + ds.Tables[12].Rows[i][0].ToString(); 
                    }
                    else
                    {
                        ListViewItem lvi = new ListViewItem(strIDs);
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][1].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][2].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][3].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][4].ToString());
                        if (MergeTimeSlot(ds.Tables[12].Rows[i - 1][3].ToString()) != "")
                            lvi.SubItems.Add(MergeTimeSlot(ds.Tables[12].Rows[i - 1][3].ToString()));
                        else
                            lvi.SubItems.Add("");
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][6].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][7].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][8].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][9].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][10].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][11].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][12].ToString());
                        lvi.SubItems.Add(ds.Tables[12].Rows[i - 1][13].ToString());

                        lvwMedicine.Items.Add(lvi);

                        strValue = ds.Tables[12].Rows[i][1].ToString();
                        strIDs = "";
                        strIDs = strIDs + "," + ds.Tables[12].Rows[i][0].ToString();
                    }
                }
                ListViewItem lvi2 = new ListViewItem(strIDs);
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][1].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][2].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][3].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][4].ToString());
                if (MergeTimeSlot(ds.Tables[12].Rows[i-1][3].ToString()) != "")
                    lvi2.SubItems.Add(MergeTimeSlot(ds.Tables[12].Rows[i - 1][3].ToString()));
                else
                    lvi2.SubItems.Add("");
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][6].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][7].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][8].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][9].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][10].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][11].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][12].ToString());
                lvi2.SubItems.Add(ds.Tables[12].Rows[i - 1][13].ToString());

                lvwMedicine.Items.Add(lvi2);
            }
            catch
            { 
            }
        }

        private string MergeTimeSlot(string strDose)
        {
            switch (strDose)
            {
                case "1":
                        return "06";
                case "2":
                    return "06+18";
                case "3":
                    return "06+14+22";
                case "4":
                    return "06+12+18+24";
                case "5":
                    return "06+10+14+18+22";
                case "7":
                    return "06+9+12+15+18+21+24";
                case "10":
                    return "06+08+10+12+14+16+18+20+22+24";
                case "19":
                    return "06+07+08+09+10+11+12+13+14+15+16+17+18+19+20+21+22+23+24";
                default:
                    return "";
            }
        }

        private void refreshSaveButton()
        {
            if ((this.lvwMedicine.Items.Count > 0
               || this.lvwInvestigation.Items.Count > 0
               || this.lvwTreatement.Items.Count > 0
               || this.lvwAdvice.Items.Count > 0) 
               && cmbConsultant.Enabled==false
               )
            {
                this.btnSave.Enabled = true;
            }
            else
            {
                this.btnSave.Enabled = false;
            }
        }

        private void btnAddTreatement_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTreatementApplicationProc.Visible == true)
                {
                    if (txtTreatmentType.Text == "OT")
                    {
                        if (IsMatchTreatementType(txtTreatmentType.Text.ToString()) == true)
                        {
                            MessageBox.Show("You Cant Select Another Operation");
                            cmbTreatement.Focus();
                            return;
                        }
                    }
                    //if (IsMatchTreatement(cmbTreatement.Text.ToString()) == false)
                    //{
                    ListViewItem lItem = new ListViewItem(this.cmbTreatement.Text);
                    lItem.SubItems.Add(this.txtTreatementDose.Text);
                    lItem.SubItems.Add(this.txtTreatementQuantity.Text);
                    lItem.SubItems.Add(this.txtTreatementApplicationProc.Text);
                    lItem.SubItems.Add(this.cmbTreatement.SelectedValue.ToString());
                    lItem.SubItems.Add("0");
                    lItem.SubItems.Add(this.txtTreatmentType.Text.ToString());
                    this.lvwTreatement.Items.Add(lItem);

                    this.txtTreatementDose.Text = "";
                    this.txtTreatementQuantity.Text = "";
                    this.txtTreatementApplicationProc.Text = "";
                    this.cmbTreatement.Focus();
                    txtTreatementApplicationProc.Visible = false;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("This Treatement already exits");
                    //    cmbTreatement.Focus();
                    //    return;
                    //}
                    this.lvwTreatement.Refresh();
                    this.refreshSaveButton();
                }
            }
            catch
            { 
            }
        }

        Boolean IsMatchInvestigation(string item, string grp, string dept)
        {
            for (int i = 0; i < lvwInvestigation.Items.Count; i++)
            {
                if (lvwInvestigation.Items[i].SubItems[0].Text == item &&
                    lvwInvestigation.Items[i].SubItems[1].Text == grp &&
                    lvwInvestigation.Items[i].SubItems[2].Text == dept &&
                    lvwInvestigation.Items[i].SubItems[2].Font.Strikeout==false
                 )
                    return true;
            }
            return false;
        }

        //Boolean IsMatchTreatement(string treatement)
        //{
        //    for (int i = 0; i < lvwTreatement.Items.Count; i++)
        //    {
        //        if (lvwTreatement.Items[i].Text == treatement)
        //                return true;
        //    }
        //    return false;
        //}

        Boolean IsMatchTreatementType(string treatement)//sami
        {
            for (int i = 0; i < lvwTreatement.Items.Count; i++)
            {
                if (lvwTreatement.Items[i].SubItems[6].Text == treatement)
                    return true;
            }
            return false;
        }

        //Boolean IsMatchMedication(string dept, string grp, string item, string charge, string reffdoc)
        //{
        //    for (int i = 0; i < lvwMedicine.Items.Count; i++)
        //    {
        //        if (lvwMedicine.Items[i].SubItems[0].Text == dept &&
        //            lvwMedicine.Items[i].SubItems[1].Text == grp &&
        //            lvwMedicine.Items[i].SubItems[2].Text == item &&
        //            lvwMedicine.Items[i].SubItems[3].Text == charge &&
        //            lvwMedicine.Items[i].SubItems[8].Text == reffdoc
        //         )
        //            return true;
        //    }
        //    return false;
        //}

        Boolean IsMatchAdvice(string advice) {
            for (int i = 0; i < lvwAdvice.Items.Count; i++)
            {
                if (lvwAdvice.Items[i].Text == advice)
                    return true;
            }
            return false;
        }

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbTestDepartemt.Text == "" ||cmbTestGroup.Text == "" ||cmbTestItem.Text == "")
                    
                {
                    MessageBox.Show("Select Investigation Info Properly");
                    return;
                }
                else

                {
                    //if (IsMatchInvestigation(cmbTestItem.Text.ToString(), cmbTestGroup.Text.ToString(), cmbTestDepartemt.Text.ToString()) == false)
                    //{
                    ListViewItem lItem = new ListViewItem(this.cmbTestItem.Text);
                    lItem.SubItems.Add(this.cmbTestGroup.Text);
                    lItem.SubItems.Add(this.cmbTestDepartemt.Text);
                    lItem.SubItems.Add("Processing");
                    lItem.SubItems.Add("0");
                    lItem.SubItems.Add(this.cmbTestDepartemt.SelectedValue.ToString());
                    lItem.SubItems.Add(this.cmbTestGroup.SelectedValue.ToString());
                    lItem.SubItems.Add(this.cmbTestItem.SelectedValue.ToString());
                    lItem.SubItems.Add("0");
                    if (checkBox2.Checked == true)
                        lItem.SubItems.Add("1");
                    else
                        lItem.SubItems.Add("0");
                    lItem.SubItems.Add("0");
                    lItem.SubItems.Add(dtpInvestigationDate.Text);
                    this.lvwInvestigation.Items.Add(lItem);
                    this.cmbTestDepartemt.Focus();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("This Investigation already exists","HIMS");
                    //}
                }

                this.checkBox2.Checked = false;
                this.lvwInvestigation.Refresh();
                this.refreshSaveButton();
            }
            catch
            {
            }
        }

        private void btnAddAdvice_Click(object sender, EventArgs e)
        {
            if(cmbAdvice.SelectedIndex==-1)
            {
                    DosePerQuantity dosePerQuantity = new DosePerQuantity();
                    DosePreQuantityBLL dosePreQuantityBLL = new DosePreQuantityBLL();
                    DataSet ds = dosePreQuantityBLL.DoseQuantity();
                    int f = 0;
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            if (cmbAdvice.Text == ds.Tables[1].Rows[i][0].ToString())
                            {
                                f = 1;
                                break;
                            }
                        }
                        if (f == 0)
                        {
                            if (txtAdviceType.Text == "")
                            {
                                MessageBox.Show("Please Insert Advice Type");
                                lblAdviceType.Visible = true;
                                txtAdviceType.Visible = true;
                                txtAdviceType.Focus();
                                return;
                            }
                            else
                            {
                                AdviceBLL adviceBLL = new AdviceBLL();
                                Advice advice = new Advice();
                                advice.advice = cmbAdvice.Text;
                                advice.advice_type = txtAdviceType.Text;
                                adviceBLL.AdviceAddFromDr(advice);
                                DataSet ds1 = adviceBLL.Getadvices();
                                PopulateComboBox(cmbAdvice, ds1, 0, "advice", "advice_id");
                                cmbAdvice.SelectedIndex = cmbAdvice.FindString(advice.advice);
                            }
                        }
                    }
            }
         
            if (cmbAdvice.SelectedValue != null)
            {
                
                if (IsMatchAdvice(cmbAdvice.Text) == false)
                {
                    ListViewItem lItem = new ListViewItem(this.cmbAdvice.Text);
                    lItem.SubItems.Add(this.cmbAdvice.SelectedValue.ToString());
                    lItem.SubItems.Add("0");
                    this.lvwAdvice.Items.Add(lItem);
                    this.cmbAdvice.Focus();
                }
                else
                {
                    MessageBox.Show("Advice already exist");
                    cmbAdvice.Focus();
                    return;
                }
            }
            else {
                MessageBox.Show("Select or write an advice");
                cmbAdvice.Focus();
                return;
            }
            this.lvwAdvice.Refresh();
            this.refreshSaveButton();
        }


        private void MedicationRemoval_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    string deleteField = "";
                    switch (((Control)sender).Name)
                    {
                        case "lvwInvestigation":
                            if (lvwInvestigation.SelectedItems[0].SubItems[10].Text.ToString() != "1")
                                deleteField = "visit_investigation_id";
                            break;
                        case "lvwTreatement":

                            if (lvwTreatement.SelectedItems[0].SubItems[6].Text.ToString() != "OT")
                                //if (lvwTreatement.Items[0].SubItems[6].Text.ToString() != "OT")
                                deleteField = "visit_treatement_id";
                            break;
                        case "lvwAdvice":

                            deleteField = "visit_advice_id";
                            break;
                        case "lvwMedicine":

                            deleteField = "visit_medicine_id";
                            break;
                    }
                    if (deleteField != "")
                    {
                        ListView lView = (ListView)sender;
                        if (lView.SelectedItems.Count > 0)
                        {
                            lView.SelectedItems[0].Font = new Font(lView.SelectedItems[0].Font, FontStyle.Strikeout);
                        }
                        lView.Refresh();
                    }
                }
            }
            catch
            { }
        }
        
        private bool createPrescription()
        {
            try
            {
                if (this.cmbConsultant.SelectedValue.ToString() == "-1")
                {
                    MessageBox.Show("Please select a consultant.");
                    this.cmbConsultant.Focus();
                    return false;
                }
                Prescription prescription = new Prescription();
                PrescriptionBLL prescriptionBLL = new PrescriptionBLL();
                RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();

                prescription.admission_id = Convert.ToInt32(_admissionID);
                prescription.consultant_id = Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[1].ToString());
                prescription.prescription_date = Convert.ToDateTime(this.dtpPrescriptionDate.Value.ToString("dd-MMM-yyyy") + " " + this.dtpPrescriptionTime.Value.ToString("hh:mm:ss tt"));
                
                btnSave.Enabled = true;
                
                decimal visitAmount=Convert.ToDecimal((refferedDoctorsBLL.Getreffered_doctors(Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[1].ToString()))).visit_charge);
                Visitamout = visitAmount;
                if (this._currentVisitMode == VisitMode.VISIT)
                {
                    prescription.visit_amount = 0;
                   //prescription.visit_amount=visitAmount;
                }
                else if (this._currentVisitMode == VisitMode.DISCHARGE)
                {
                    btnDischarge.Enabled = true;
                    checkBox1.Visible = true;
                    //btnSave.Enabled = true;

                }
                else
                {
                    prescription.visit_amount = 0;
                }
                prescription.record_created_by = ApplicatinLauncher._userId;
                int id = prescriptionBLL.Addprescription(prescription);
                
                if (id > 0)
                {
                    this._prescriptionID = id.ToString();
                    this.dtpPrescriptionDate.Enabled = false;
                    this.dtpPrescriptionTime.Enabled = false;
                    this.cmbConsultant.Enabled = false;
                    this.btnClose.Enabled = false;
                    this.btnCreatePrescription.Enabled = false;

                    this.grpMedicine.Enabled = true;
                    this.grpInvestigation.Enabled = true;
                    this.grpTreatement.Enabled = true;
                    this.grpAdvice.Enabled = true;
                    return true;
                }
                else
                {
                    this._prescriptionID = "0";
                    this.btnClose.Enabled = false;
                }
            }
            catch
            {
            }
            finally
            {
                //this.refreshSaveButton();
            }
            return false;
        }

        private void reSelectTimeSlot(int time)
        {
            try
            {
                int duration = 6 + time;
                foreach (Control ctrl in this.grpTimeSlot.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        ((CheckBox)ctrl).Checked = false;
                    }
                }
                this.chkTimeSlot6.Checked = true;
                while (duration <= 24)
                {
                    foreach (Control ctrl in this.grpTimeSlot.Controls)
                    {
                        if (ctrl is CheckBox && int.Parse(ctrl.Text) == duration)
                        {
                            ((CheckBox)ctrl).Checked = true;
                        }
                    }
                    duration += time;
                }
            }
            catch
            {
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            try
            {
                this.lblClock.Text = DateTime.Now.ToString();
            }
            catch
            {
            }			
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbConsultant.Enabled == true)
                {
                    if (this.createPrescription() == false)
                    {
                        return;
                    }
                }
                else
                {
                    Prescription prescription = new Prescription();
                    if (this._currentVisitMode == VisitMode.VISIT || checkBox1.Checked == true)
                    {

                        PrescriptionBLL prescriptionBLL = new PrescriptionBLL();
                        prescription.visit_amount = Visitamout;
                        prescription.prescription_id = Convert.ToInt32(_prescriptionID);
                        prescriptionBLL.AdjustdoctorVisit(prescription);
                    }

                    if (this.lvwMedicine.Items.Count > 0)
                    {
                        InsertVisitMedicineFromListView();
                    }

                    if (this.lvwInvestigation.Items.Count > 0)
                    {
                        InsertVisitInvestigationFromListView();
                    }

                    if (this.lvwTreatement.Items.Count > 0)
                    {
                        InsertVisitTreatementFromListView();
                    }

                    if (this.lvwAdvice.Items.Count > 0)
                    {
                        InsertVisitAdviceFromListView();
                    }
                    this.btnSave.Enabled = false;
                    this.btnClose.Enabled = true;
                    this.btnCreatePrescription.Enabled = false;
                    this.cmbConsultant.Enabled = true;
                    this.dtpPrescriptionDate.Enabled = true;
                    this.dtpPrescriptionTime.Enabled = true;
                    if (this._currentVisitMode == VisitMode.DISCHARGE)
                    {
                        this.btnDischarge.Enabled = true;
                    }
                    else
                    {
                        this._Usersurname = ApplicatinLauncher._realname;
                        PrintDoctorVisit();
                        //reprint();
                    }
                    MessageBox.Show("Data Saved Successfully");
                }
            }
            catch 
            { 
            }
        }

        private void btnCreatePrescription_Click(object sender, EventArgs e)
        {
            createPrescription();
        }

        private void cmbTestDepartemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //ToolTip toolTip1 = new ToolTip();
                //toolTip1.AutoPopDelay = 0;
                //toolTip1.InitialDelay = 0;
                //toolTip1.ReshowDelay = 0;
                //toolTip1.ShowAlways = true;
                //toolTip1.SetToolTip(this.cmbTestDepartemt, cmbTestDepartemt.Items[comboBox1.SelectedIndex].ToString());

                //if (cmbTestDepartemt.SelectedItem.ToString().Length > 2)
                //{
                //    toolTip1.SetToolTip(cmbTestDepartemt, cmbTestDepartemt.SelectedText.ToString());
                //    //toolTip1.SetToolTip(cmbTestDepartem, cmbTestDepartem.SelectedItem.ToString());
                //}
                  
            }
            catch
            { }
            
            
            
            
            //try
            //{
            //    if (cmbTestDepartemt.SelectedIndex >= 0)
            //    {
            //        cmbTestGroup.DataSource = null;
            //        cmbTestGroup.Items.Clear();
            //        cmbTestItem.DataSource = null;
            //        cmbTestItem.Items.Clear();
            //        TestGroupBLL testGroupBLL = new TestGroupBLL();

            //        string strTestGrpID = ((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString();
            //        int testDeptID = Convert.ToInt32(strTestGrpID);
            //        DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);
            //        PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");
            //        testGroupBLL = null;
            //        ds = null;
            //    }
            //}
            //catch
            //{
            //}
        }

        private void cmbTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbTestGroup.SelectedIndex >= 0)
                {
                    TestItemBLL testItemBLL = new TestItemBLL();

                    string strTestGrpID = ((DataRowView)(cmbTestGroup.SelectedItem)).Row[0].ToString();
                    int testGrpID = Convert.ToInt32(strTestGrpID);
                    DataSet ds = testItemBLL.GetTestItemByTestGrpID(testGrpID);
                    PopulateComboBox(cmbTestItem, ds, 0, "testItem", "test_item_id");
                    testItemBLL = null;
                    ds = null;
                }
            }
            catch
            {
            }
        }

        private void cmbTiming_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MedicineTiming medicineTiming = new MedicineTiming();
                MedicineTimingBLL medicineTimingBLL = new MedicineTimingBLL();
                                 
                int time =Convert.ToInt32(medicineTimingBLL.Getmedicine_timing(Convert.ToInt32(((DataRowView)(cmbTiming.SelectedItem)).Row[0].ToString())).medicine_timing_value);
                this.reSelectTimeSlot(time);
            }
            catch
            {
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbproductcategory.SelectedIndex == -1)
                    return;
             
                if (isVisitItemExists(this.lvwMedicine, this.cmbMedicine.Text) == true)
                {
                    MessageBox.Show("Medicine already exists.");
                    this.cmbMedicine.Focus();
                    return;
                }
               
                if (cmbMedicine.SelectedIndex == -1)
                {
                    if (MessageBox.Show(" Medecine Does'nt Exist.Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    else
                    {
                        //ProductBLL productBLL = new ProductBLL();
                        //ProductBO product = new ProductBO();
                        //product.product = cmbMedicine.Text.ToString();
                        //product.product_category_id = Convert.ToInt16(cmbproductcategory.SelectedValue.ToString());
                        //product.record_created_by = ApplicatinLauncher._userId;
                        //productID=productBLL.newproductAdd(product);
                        //productrefresh();
                        //cmbMedicine.SelectedValue = productID;
                        //cmbMedicine.Focus();
                        PriscriptionProduct priscriptionProduct = new PriscriptionProduct();
                        PrescriptionProductBLL prescriptionProductBLL = new PrescriptionProductBLL();

                        priscriptionProduct.product = cmbMedicine.Text.ToString();
                        priscriptionProduct.product_category_id = Convert.ToInt16(cmbproductcategory.SelectedValue.ToString());
                        priscriptionProduct.record_created_by = ApplicatinLauncher._userId;
                        productID = prescriptionProductBLL.newprescriptionproductAdd(priscriptionProduct);
                        RequisitionBLL requisitionBLL = new RequisitionBLL();
                        DataSet ds = requisitionBLL.Productlist(Convert.ToInt32(cmbproductcategory.SelectedValue.ToString()));
                        PopulateComboBox(cmbMedicine, ds, 1, "product", "product_id");
                        cmbMedicine.SelectedValue = productID;

                    }
                }
                if (cmbDosePQuantity.SelectedIndex == -1)
                {
                    DosePerQuantity dosePerQuantity = new DosePerQuantity();
                    DosePreQuantityBLL dosePreQuantityBLL = new DosePreQuantityBLL();
                    DataSet ds = dosePreQuantityBLL.DoseQuantity();
                    int f = 0;
                    int did = 0;
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (cmbDosePQuantity.Text == ds.Tables[0].Rows[i][0].ToString())
                            {
                                f = 1;
                                did = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                                break;
                            }
                        }
                        if (f == 0)
                        {
                            if (MessageBox.Show(" Dose per Quentity Does'nt Exist.Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
                                dosePerQuantity.dose_p_quantity = cmbDosePQuantity.Text;
                                dosePerQuantity.record_created_by = ApplicatinLauncher._userId;
                                int DosePerQtyID = dosePreQuantityBLL.newDossQtyAdd(dosePerQuantity);
                                AdmissionBLL admissionBLL = new AdmissionBLL();
                                DataSet dsd = admissionBLL.GetDoctorVisitPopulationInfo(Convert.ToInt32(this._admissionID));
                                PopulateComboBox(cmbDosePQuantity, dsd, 5, "dose_p_quantity", "dose_p_quantity_id");
                                cmbDosePQuantity.SelectedValue = DosePerQtyID;
                                cmbDosePQuantity.Focus();
                            }

                        }
                        else
                        {
                            cmbDosePQuantity.SelectedValue = did;
                            cmbDosePQuantity.Text = cmbDosePQuantity.Text;
                        }

                    }
                }
                string[] tmSlot = sortStrArray(getSelectedTimeSlots(this.grpMedicine.Controls), true);
                ListViewItem lItem = new ListViewItem("0");
                lItem.SubItems.Add(this.cmbMedicine.Text);
                lItem.SubItems.Add(this.cmbDosePQuantity.Text);
                lItem.SubItems.Add(tmSlot.Length.ToString());
                lItem.SubItems.Add(this.cmbIntakeSys.Text);
                lItem.SubItems.Add(string.Join("+", tmSlot));
                lItem.SubItems.Add(this.cmbMedicine.SelectedValue.ToString());
                lItem.SubItems.Add(this.cmbDosePQuantity.SelectedValue.ToString());
                lItem.SubItems.Add(this.cmbIntakeSys.SelectedValue.ToString());
                lItem.SubItems.Add(this.cmbIntakeIndication.Text);
                lItem.SubItems.Add(this.cmbIntakeIndication.SelectedValue.ToString());
                lItem.SubItems.Add(this.cmbConsultant.SelectedValue.ToString());
                lItem.SubItems.Add("Me");
                lItem.SubItems.Add(Convert.ToString((DateTime.Now).ToString("dd/MM/yyyy")));
                this.lvwMedicine.Items.Add(lItem);
                this.cmbMedicine.Focus();
            }
            catch
            {
            }
            this.lvwMedicine.Refresh();
            this.refreshSaveButton();
        }

        public static string[] sortStrArray(string[] ar, bool isNumericCompare)
        {
            string[] sortedAr = ar;
            try
            {
                for (int i = 1; i < sortedAr.Length; i++)
                {
                    string value = sortedAr[i];
                    int j = i;

                    if (isNumericCompare == true)
                    {
                        while (j > 0 && int.Parse(sortedAr[j - 1]) > int.Parse(value))
                        {
                            sortedAr[j] = sortedAr[j - 1];
                            j--;
                        }
                    }
                    sortedAr[j] = value;
                }
            }
            catch
            {
            }
            return sortedAr;
        }

        public static string[] getSelectedTimeSlots(Control.ControlCollection controls)
        {
            try
            {
                if (controls != null && controls.Count > 0)
                {
                    Control[] timeSlotCtrls = controls.Find("grpTimeSlot", false);
                    if (timeSlotCtrls != null && timeSlotCtrls.Length > 0)
                    {
                        GroupBox grpTimeSlot = (GroupBox)timeSlotCtrls[0];
                        string temp = "";
                        foreach (Control ctrl in grpTimeSlot.Controls)
                        {
                            if (ctrl is CheckBox && ctrl.Name.StartsWith("chkTimeSlot"))
                            {
                                if (((CheckBox)ctrl).Checked == true)
                                {
                                    temp += (temp == "") ? ctrl.Text : "+" + ctrl.Text;
                                }
                            }
                        }
                        if (temp != "")
                        {
                            return temp.Split('+');
                        }
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        public static bool isVisitItemExists(ListView lvwList, string key)
        {
            try
            {
                foreach (ListViewItem lItem in lvwList.Items)
                {
                    if (lItem.SubItems[1].Text == key)
                    {
                        return true;
                    }
                }
            }
            catch
            {
            }
            return false;
        }


        void InsertVisitMedicineFromListView() 
        {
            try
            {
                VisitMedicine visitMedicine = new VisitMedicine();
                VisitMedicineBLL visitMedicineBLL = new VisitMedicineBLL();

                foreach (ListViewItem lvi in lvwMedicine.Items)
                {
                    if ((lvi.Font.Strikeout == true && lvi.Text == "0")) continue;

                    if (_prescriptionID != "")
                        visitMedicine.visit_prescription_id = Convert.ToInt32(_prescriptionID);
                    else
                        visitMedicine.visit_prescription_id = 0;

                    visitMedicine.medicine_id = Convert.ToInt32(lvi.SubItems[6].Text);
                    visitMedicine.dose_p_quantity_id = Convert.ToInt32(lvi.SubItems[7].Text);
                    visitMedicine.intake_sys_id = Convert.ToInt32(lvi.SubItems[8].Text);
                    visitMedicine.medication_date = Convert.ToDateTime(dtpPrescriptionDate.Text);
                    visitMedicine.dose_count = Convert.ToInt32(lvi.SubItems[3].Text);
                    visitMedicine.is_submit = 0;

                    visitMedicine.indent_given_once = 0;
                    visitMedicine.implication_way_id = Convert.ToInt32(lvi.SubItems[10].Text);
                    visitMedicine.medicine_timing_id = 0;


                    String[] arrTSlots = lvi.SubItems[5].Text.ToString().Split('+');
                    String[] arrVMIDs = lvi.Text.ToString().Split(',');

                    for (int j = 0; j < arrTSlots.Length; j++)
                    {
                        string pd = Convert.ToString((lvi.SubItems[13].Text));
                        string cd = Convert.ToString((DateTime.Now).ToString("dd/MM/yyyy"));
                        if (lvi.Font.Strikeout == true)
                        {
                            visitMedicine.is_continue = 0;
                            visitMedicine.visit_medicine_id = Convert.ToInt32(arrVMIDs[j + 1]);
                            visitMedicine.record_modified_by = ApplicatinLauncher._userId;
                            visitMedicineBLL.SetMedicineIsContinue(visitMedicine);
                            lvi.Remove();
                        }
                        else if (lvi.Font.Strikeout == false && (lvi.SubItems[12].Text.ToString()) == "Me")
                        {
                            visitMedicine.time_slots = arrTSlots[j];
                            visitMedicine.is_continue = 1;
                            visitMedicine.consultant_id = Convert.ToInt32(lvi.SubItems[11].Text.ToString());
                            visitMedicine.record_created_by = ApplicatinLauncher._userId;
                            visitMedicine.record_modified_by = 0;
                            visitMedicineBLL.Addvisit_medicine(visitMedicine);
                        }

                        else if (lvi.Font.Strikeout == false && (cd != pd))
                        {
                            visitMedicine.is_continue = 0;
                            visitMedicine.visit_medicine_id = Convert.ToInt32(arrVMIDs[j + 1]);
                            visitMedicine.record_modified_by = ApplicatinLauncher._userId;
                            visitMedicineBLL.SetMedicineIsContinue(visitMedicine);
                            visitMedicine.time_slots = arrTSlots[j];
                            visitMedicine.is_continue = 1;
                            visitMedicine.consultant_id = Convert.ToInt32(lvi.SubItems[11].Text.ToString());
                            visitMedicine.record_created_by = ApplicatinLauncher._userId;
                            visitMedicine.record_modified_by = 0;
                            //visitMedicine.record_created_date =lvi.SubItems[13].Text.ToString();
                            visitMedicineBLL.Addvisit_medicine(visitMedicine);
                            //visitMedicineBLL.visit_premedicineAdd(visitMedicine);
                        }
                    }
                }
            }
            catch
            {
            }
               
        }



        void InsertVisitInvestigationFromListView(){

            try
            {
                VisitInvestigation visitInvestigation = new VisitInvestigation();
                VisitInvestigationBLL visitInvestigationBLL = new VisitInvestigationBLL();

                foreach (ListViewItem lvi in lvwInvestigation.Items)
                {
                    if (lvi.Font.Strikeout == true && lvi.SubItems[4].Text == "0") continue;
                    
                    if (lvi.SubItems[0].Font.Strikeout == false && lvi.SubItems[4].Text == "0")
                    {
                        visitInvestigation.visit_prescription_id = Convert.ToInt32(_prescriptionID);
                        visitInvestigation.test_department_id = Convert.ToInt32(lvi.SubItems[5].Text);
                        visitInvestigation.test_group_id = Convert.ToInt32(lvi.SubItems[6].Text);
                        visitInvestigation.test_item_id = Convert.ToInt32(lvi.SubItems[7].Text);
                        visitInvestigation.indent_given = 0;
                        visitInvestigation.baby_test = Convert.ToInt32(lvi.SubItems[9].Text);
                        visitInvestigation.investigation_date = Convert.ToDateTime(lvi.SubItems[11].Text);
                        visitInvestigation.record_created_by = ApplicatinLauncher._userId;
                        visitInvestigation.record_modified_by = 0;

                        visitInvestigationBLL.Addvisit_investigation(visitInvestigation);
                    }
                    if (lvi.SubItems[0].Font.Strikeout == true)
                    {
                        visitInvestigation.visit_investigation_id = Convert.ToInt32(lvi.SubItems[4].Text);
                        visitInvestigation.record_modified_by = ApplicatinLauncher._userId;
                        visitInvestigationBLL.visitinvetigationcancel(visitInvestigation);
                    }
                }
            }
            catch
            { 
            }
        }

        
        
        void InsertVisitTreatementFromListView(){

            try
            {
                VisitTreatement visitTreatement = new VisitTreatement();
                VisitTreatementBLL visitTreatementBLL = new VisitTreatementBLL();

                foreach (ListViewItem lvi in lvwTreatement.Items)
                {
                    if (lvi.Font.Strikeout == true && lvi.SubItems[5].Text == "0") continue;
                                        
                    if (lvi.SubItems[0].Font.Strikeout == false && lvi.SubItems[5].Text == "0")
                    {
                        visitTreatement.visit_prescription_id = Convert.ToInt32(_prescriptionID);
                        if (lvi.SubItems[4].Text!="")
                            visitTreatement.treatement_id = Convert.ToInt32(lvi.SubItems[4].Text);
                        if (lvi.SubItems[1].Text != "")
                            visitTreatement.dose = lvi.SubItems[1].Text.ToString();
                        if (lvi.SubItems[2].Text != "")
                            visitTreatement.quantity = Convert.ToDecimal(lvi.SubItems[2].Text);
                        if (lvi.SubItems[3].Text != "")
                            visitTreatement.application_procedure = lvi.SubItems[3].Text.ToString();
                        visitTreatement.record_created_by = ApplicatinLauncher._userId;
                        visitTreatement.record_modified_by = 0;

                        visitTreatementBLL.Addvisit_treatement(visitTreatement);
                        if (lvi.SubItems[6].Text != "General" && lvi.SubItems[5].Text=="0")
                        {
                            OperationNote operationNote = new OperationNote();
                            OperationNoteBLL operationNoteBLL = new OperationNoteBLL();

                            operationNote.admission_id = Convert.ToInt16(_admissionID);
                            operationNote.operation_id = Convert.ToInt32(lvi.SubItems[4].Text);
                            operationNote.surgeon_name = surgeonID;
                            operationNote.is_submit = 0;
                            operationNote.cabin_id = _cabinID;

                            operationNote.record_created_by = ApplicatinLauncher._userId;
                            operationNoteBLL.DoctotOTDeclare(operationNote);
                        }

                        
                        
                    }
                    if (lvi.SubItems[0].Font.Strikeout == true && lvi.SubItems[5].Text != "0")
                    {
                        visitTreatement.record_modified_by = ApplicatinLauncher._userId;
                        visitTreatement.visit_treatement_id= Convert.ToInt32(lvi.SubItems[5].Text);
                        visitTreatementBLL.visit_doctortreatement(visitTreatement);
                    
                    
                    
                    }
                }
            }
            catch
            { 
            }
        }


        void InsertVisitAdviceFromListView()
        {
            try
            {

                VisitAdvice visitAdvice = new VisitAdvice();
                VisitAdviceBLL visitAdviceBLL = new VisitAdviceBLL();

                foreach (ListViewItem lvi in lvwAdvice.Items)
                {
                    
                    if (lvi.Font.Strikeout == true && lvi.SubItems[2].Text == "0") continue;

                    //if (lvi.SubItems[0].Font.Strikeout == false)
                    if (lvi.SubItems[0].Font.Strikeout == false && lvi.SubItems[2].Text == "0")
                    {
                        
                            visitAdvice.visit_prescription_id = Convert.ToInt32(_prescriptionID);
                            if (lvi.SubItems[1].Text != "")
                                visitAdvice.advice_id = Convert.ToInt32(lvi.SubItems[1].Text);
                            visitAdvice.record_created_by = ApplicatinLauncher._userId;
                            visitAdvice.record_modified_by = 0;
                            visitAdviceBLL.Addvisit_advice(visitAdvice);
                        
                    }
                    if (lvi.Font.Strikeout == true && lvi.SubItems[2].Text !="0")
                    {
                        visitAdvice.visit_advice_id = Convert.ToInt32(lvi.SubItems[2].Text);
                        visitAdvice.record_modified_by = ApplicatinLauncher._userId;
                        visitAdviceBLL.visit_docadviceUpdate(visitAdvice);
                    
                    
                    }
                }
            }
            catch
            { 
            }
        }

        private void FrmDoctorVisit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.btnSave.Enabled == true || this.btnClose.Enabled == false)
            {
                if (MessageBox.Show("Changes are not saved yet. Do you want to close without save?", "Not Saved ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want To Discharge Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                     return;
                }
                AdmissionBLL admissionBLL = new AdmissionBLL();
                CaseSummary casesummary = new CaseSummary();
                casesummary.PreCaseSummary = txtPreCaseSummary.Text.ToString();
                casesummary.AftCaseSummary = txtAfterCaseSummary.Text.ToString();
                admissionBLL.SetPatientDischargeInfo(Convert.ToInt32(this._admissionID),this._cabinID,ApplicatinLauncher._userId,casesummary);
                PrescriptionBLL prescriptionBLL = new PrescriptionBLL();
                DataSet ds = prescriptionBLL.GetPresIdByAdmbID(Convert.ToInt32(this._admissionID));
                this._prescriptionID = ds.Tables[0].Rows[0][0].ToString();
                PrintDischarge();
                admissionBLL = null;
                btnDischarge.Enabled = false;
                this._objForm.cmbfloorload(_objForm);
                btnCreatePrescription.Enabled = false;
                btnSave.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void PrintDoctorVisit()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptDoctorVisit();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                if (this._prescriptionID != "")
                {
                    rptCustomersOrders.SetParameterValue("@admission_id", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idRD", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idM", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idMI", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idI", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idT", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idA", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idAD", this._admissionID);
                    rptCustomersOrders.SetParameterValue("prescriptionDate", this._prescriptiondate);
                    //rptCustomersOrders.SetParameterValue("@userName", _Usersurname);
                    rptCustomersOrders.SetParameterValue("@weightadmissionID", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@userName", ApplicatinLauncher._realname);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
            }
            catch
            {
            }  
        }

        private void PrintDischarge()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptDischarge();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //if (this._prescriptionID != "")
                    
                {
                    //rptCustomersOrders.SetParameterValue("@admission_id", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idRD", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idD", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idI", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idT", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idM", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idot", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@admission_idA", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@userName", ApplicatinLauncher._userName);
                    rptCustomersOrders.SetParameterValue("@admission_id", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idRD", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idD", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idM", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idI", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idT", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idot", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@weightadmissionID", this._admissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idA", this._admissionID);
                    //rptCustomersOrders.SetParameterValue("@userName", ApplicatinLauncher._userName);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
            }
            catch
            {
            }
        }

        

        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrescriptionBLL prescriptionBLL = new PrescriptionBLL();
            DataSet ds = prescriptionBLL.GetPresIdByAdmbID(Convert.ToInt32(this._admissionID));
            this._prescriptionID = ds.Tables[0].Rows[0][0].ToString();
            this._prescriptiondate = ds.Tables[0].Rows[0][1].ToString();
            this._Usersurname = ds.Tables[0].Rows[0][2].ToString();
            PrintDoctorVisit();
        }

        

        private void cmbTreatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTreatement.SelectedIndex >= 0)
                {
                    txtTreatementApplicationProc.Text = "";
                    txtTreatmentType.Text = "";
                    txtTreatementApplicationProc.Visible = true;
                    TreatementBLL treatementBLL = new TreatementBLL();
                    DataSet ds = treatementBLL.OTDeclare(Convert.ToInt16(cmbTreatement.SelectedValue.ToString()));
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        txtTreatementApplicationProc.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtTreatmentType.Text = ds.Tables[0].Rows[0][1].ToString();
                        
                    }
                }

            }
            catch
            {
            }
        }
        public void DischargeFlag(FrmDoctorVisit objForm)
        {
            this.DischargeID = 1;

        }
        private void cmbproductcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbproductcategory.SelectedIndex != -1)
                {
                    productrefresh();
                }
            }
            catch
            {
            }
        }

        void productrefresh()
        {
            cmbMedicine.Enabled = true;
            RequisitionBLL requisitionBLL = new RequisitionBLL();
            DataSet ds = requisitionBLL.Productlist(Convert.ToInt32(cmbproductcategory.SelectedValue.ToString()));
            PopulateComboBox(cmbMedicine, ds, 1, "product", "product_id");
        
        }

        private void FrmDoctorVisit_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (_currentVisitMode == VisitMode.DISCHARGE)
                {
                    FrmDoctorStation frmDoctorStation = new FrmDoctorStation();
                    
                }
            }
            catch
            {
            }
        }

        private void cmbTestDepartemt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbTestDepartemt.SelectedIndex >= 0)
                {
                    cmbTestGroup.DataSource = null;
                    cmbTestGroup.Items.Clear();
                    cmbTestItem.DataSource = null;
                    cmbTestItem.Items.Clear();
                    TestGroupBLL testGroupBLL = new TestGroupBLL();

                    string strTestGrpID = ((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString();
                    int testDeptID = Convert.ToInt32(strTestGrpID);
                    DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);
                    PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");
                    testGroupBLL = null;
                    ds = null;
                    
                }
            }
            catch
            {
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (DischargeID == 0)
                {
                    FrmDischarge frmDischarge = new FrmDischarge();
                    frmDischarge.discharcgeMedecine(this, Convert.ToInt16(_admissionID));
                    frmDischarge.ShowDialog();
                    tmrClock_Tick(null, null);
                    
  
                }
               else
                  MessageBox.Show("You Already Saved Data");
                
               
            }
            catch
            {
            }
        }

        private void lvwInvestigation_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwInvestigation.SelectedItems[0].SubItems[2].Text.ToString()== "Pathology" && lvwInvestigation.SelectedItems[0].SubItems[8].Text.ToString()!="0")
                {
                    FrmPatientResult frmPatientResult = new FrmPatientResult();
                    frmPatientResult.PatientResult(Convert.ToInt16(lvwInvestigation.SelectedItems[0].SubItems[8].Text));
                    frmPatientResult.ShowDialog();
                    tmrClock_Tick(null, null);

                }
            }
            catch
            {
            }
        }

        private void btnProcedureclose_Click(object sender, EventArgs e)
        {
            txtTreatementApplicationProc.Visible = false;
        }

        private void cmbAdvice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdvice.SelectedIndex == -1)
                {
                    lblAdviceType.Visible = true;
                    txtAdviceType.Visible = true;
                }
                else
                {
                    lblAdviceType.Visible = false;
                    txtAdviceType.Visible = false;
                }
            }
            catch
            {
            }
        }

        private void cmbIntakeIndication_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lvwMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                int VMID = Convert.ToInt32(lvwMedicine.SelectedItems[0].SubItems[0].Text);
                VisitMedicineBLL visitMedicineBLL = new VisitMedicineBLL();
                DataSet ds = visitMedicineBLL.MedicineDetailsForDoctor(VMID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    PopulateComboBox(cmbMedicine, ds, 0, "product", "product_id");
                }
                if (ds.Tables[1].Rows.Count > 0)
                {
                    PopulateComboBox(cmbDosePQuantity, ds, 1, "dose_p_quantity", "dose_p_quantity_id");
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    PopulateComboBox(cmbIntakeSys, ds, 2, "intake_sys", "intake_sys_id");
                }

            }
            catch
            {
            }
        }

       
        
    }
}