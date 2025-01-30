using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using NewHIMS.Reports;
using NewHIMS.Reports.OutDoor;

namespace NewHIMS.Forms.Outdoor
{
    public partial class frmOutdoorPatient : BaseForm.FrmBase
    {
        //int RefferedDoctorsID = 0;
        // private String outdoorBookingID = "CON2008082902";
        private int bookingID;
        private DateTime DOB;
        private string Age;
        public frmOutdoorPatient()
        {
            InitializeComponent();
        }


        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.Text = "<Select>";
            if (combo.SelectedIndex >= 0)
                combo.SelectedIndex = -1;//why -1
        }
        private void FillUpListviewDT(ListView lvw, DataSet ds, int tableIndex)// why table index why this not use in other funtion
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

        private void FillUpListview(ListView lvw, DataSet ds)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[0].Rows[i];

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

        private Boolean IsDuplicateListviewItem(ListView lvw, string value)
        {

            for (int i = 0; i < lvw.Items.Count; i++)
            {
                if (lvw.Items[i].Text.ToString() == value)
                {
                    return true;
                }
            }
            return false;

        }


        private Boolean InsertInvestigation()
        {
            for (int i = 0; i < lvwInvestigation.Items.Count; i++)
            {
                OutdoorPatientInvestigation outdoorPatientInvestigation = new OutdoorPatientInvestigation();
                OutdoorPatientInvestigationBLL outdoorPatientInvestigationBLL = new OutdoorPatientInvestigationBLL();
                outdoorPatientInvestigation.outdoor_booking_id = txtBookingSerial.Text.ToString();
                outdoorPatientInvestigation.investigation_name = lvwInvestigation.Items[i].Text;
                outdoorPatientInvestigation.investivation_result = lvwInvestigation.Items[i].SubItems[1].Text.ToString();
                outdoorPatientInvestigation.record_created_by = ApplicatinLauncher._userId;
                outdoorPatientInvestigationBLL.Addoutdoor_patient_investigation(outdoorPatientInvestigation);
                
            }
            return true;
        }


        //- - - - - - - - - - - - --  - - -- -  - - -- - - - - - - - -- - -  - - - -- -  - -- - - - -- - -- - -- -- - -- - 


        private Boolean InsertMedication()
        {

            for (int i = 0; i < lvwMedication.Items.Count; i++)
            {
                OutdoorPatientMedication outdoorPatientMedication = new OutdoorPatientMedication();
                OutdoorPatientMedicationBLL outdoorPatientMedicationBLL = new OutdoorPatientMedicationBLL();
               
                outdoorPatientMedication.outdoor_booking_id = Convert.ToInt32(txtBookingSerial.Text.ToString());
                outdoorPatientMedication.type = lvwMedication.Items[i].Text;
                outdoorPatientMedication.medication_name = (lvwMedication.Items[i].SubItems[1].Text);
                outdoorPatientMedication.dose_qty = (lvwMedication.Items[i].SubItems[2].Text);
                outdoorPatientMedication.intake_method = (lvwMedication.Items[i].SubItems[3].Text);
                outdoorPatientMedication.morning = Convert.ToDecimal(lvwMedication.Items[i].SubItems[4].Text);
                outdoorPatientMedication.noon = Convert.ToDecimal(lvwMedication.Items[i].SubItems[5].Text);
                outdoorPatientMedication.evening = Convert.ToDecimal(lvwMedication.Items[i].SubItems[6].Text);
                outdoorPatientMedication.night = Convert.ToDecimal(lvwMedication.Items[i].SubItems[7].Text);
                outdoorPatientMedication.DDay = Convert.ToInt32(lvwMedication.Items[i].SubItems[8].Text);
                outdoorPatientMedication.record_created_by = ApplicatinLauncher._userId;
                outdoorPatientMedicationBLL.Addoutdoor_patient_medication(outdoorPatientMedication);
                


            }
            return true;

        }


        //- - - - - - - - - - - - --  - - -- -  - - -- - - - - - - - -- - -  - - - -- -  - -- - - - -- - -- - -- -- - -- - 

        private Boolean InsertAdvice()
        {

            for (int i = 0; i < lvwAdvice.Items.Count; i++)
            {
                OutdoorPatientAdvice outdoorPatientAdvice = new OutdoorPatientAdvice();
                OutdoorPatientAdviceBLL outdoorPatientAdviceBLL = new OutdoorPatientAdviceBLL();
                outdoorPatientAdvice.outdoor_booking_id = txtBookingSerial.Text.ToString();
                outdoorPatientAdvice.outdoor_patient_advice = lvwAdvice.Items[i].Text;
                outdoorPatientAdvice.record_created_by = ApplicatinLauncher._userId;
                outdoorPatientAdviceBLL.Addoutdoor_patient_advice(outdoorPatientAdvice);
                
            }
            return true;
        }



        //- - - - - - - - - - - - --  - - -- -  - - -- - - - - - - - -- - -  - - - -- -  - -- - - - -- - -- - -- -- - -- - 



        private Boolean InsertOthersCheckup()
        {
            try
            {

                    OutdoorPatientVisit outdoorPatientVisit = new OutdoorPatientVisit();
                    OutdoorPatientVisitBLL outdoorPatientVisitBLL = new OutdoorPatientVisitBLL();
                    outdoorPatientVisit.outdoor_booking_id = txtBookingSerial.Text.ToString();
                    outdoorPatientVisit.visited_date = DateTime.Now;
                    outdoorPatientVisit.patient_bp = Convert.ToString(txtBP.Text);
                    outdoorPatientVisit.patient_pulse = Convert.ToInt32(txtPulse.Text);
                    outdoorPatientVisit.patient_height = Convert.ToInt32(txtHeight.Text);
                    outdoorPatientVisit.patient_weight = Convert.ToInt32(txtWeight.Text);
                    outdoorPatientVisit.patient_temp = Convert.ToInt32(txtTemp.Text);
                    outdoorPatientVisit.patient_cc = txtCC.Text.ToString();
                    outdoorPatientVisit.patient_primary_diagonosis = txtPrimaryDiagonosis.Text.ToString();
                    outdoorPatientVisit.next_visit_date = Convert.ToDateTime(dtpNextVisitedDate.Text);
                    outdoorPatientVisit.record_created_by = ApplicatinLauncher._userId;
                    outdoorPatientVisitBLL.Addoutdoor_patient_visit(outdoorPatientVisit);
                    bookingID = Convert.ToInt32(txtBookingSerial.Text);
                    return true;
                }

         
            catch 
            {

                return false;
            }

                
        
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookingSerial.Text != "" && txtBP.Text!="" && txtCC.Text!="" && txtHeight.Text!="" && txtPulse.Text!="" && txtTemp.Text!="" && txtPrimaryDiagonosis.Text!="")
                {
                    OutdoorPatientMedicationBLL outdoorPatientMedicationBLL = new OutdoorPatientMedicationBLL();
                    bookingID = Convert.ToInt32(txtBookingSerial.Text);
                    outdoorPatientMedicationBLL.RemoveoutdoorpatientVisit(bookingID);
                    if (InsertInvestigation())
                    {
                        if (InsertMedication())
                        {
                            if (InsertAdvice())
                            {
                                if (InsertOthersCheckup())
                                {
                                    MessageBox.Show("Data Saved Successfully", "HIMS");
                                    PrintOutdoorPatientReport(bookingID, Age);
                                    this.refreshContent();
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Please Enter the Patient information");
            }
            catch 
            {
                
                
            }
           
        }

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            if (cmbTestItems.Text.ToString() != "" && cmbTestItems.Text.ToString() != "<Select>")
            {
                if (cmbResults.Text.ToString() != "" && cmbTestItems.Text.ToString() != "<Select>")
                {

                    cmbTestItems.BackColor = System.Drawing.Color.White;
                    cmbResults.BackColor = System.Drawing.Color.White;

                    if (IsDuplicateListviewItem(lvwInvestigation, cmbTestItems.Text.ToString()))
                    {
                        MessageBox.Show("The Test Items is already exist", "HIMS");
                        goto lab;
                    }
                    ListViewItem lvi;
                    lvi = lvwInvestigation.Items.Add(cmbTestItems.Text.ToString());
                    lvi.SubItems.Add(cmbResults.Text.ToString());

                lab:
                    cmbTestItems.Text = "";
                    cmbResults.Text = "";
                    cmbTestItems.Focus();

                }
                else
                {
                    cmbResults.BackColor = System.Drawing.Color.Bisque;
                    cmbResults.Focus();
                }
            }
            else
            {
                cmbTestItems.BackColor = System.Drawing.Color.Bisque;
                cmbTestItems.Focus();
            }
        }

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            if (cmbType.Text.ToString() != "" && cmbType.Text.ToString() != "<Select>")
            {
                if (cmbMedicineName.Text.ToString() != "" && cmbMedicineName.Text.ToString() != "<Select>")
                {
                 if (txtDoseQty.Text.ToString() != "")
                    {
                    if (cmbIntakeMethod.Text.ToString() != "" && cmbIntakeMethod.Text.ToString() != "<Select>")
                    {
                        if (cmbMorn.Text.ToString() != "")
                        {
                              if (cmbNoon.Text.ToString() != "")
                                {
                                 if (cmbEvening.Text.ToString() != "")
                                    {
                                        if (cmbNight.Text.ToString() != "")
                                        {
                                         if (txtDDay.Text.ToString() != "")
                                            {

                                            cmbMedicineName.BackColor = System.Drawing.Color.White;
                                            txtDoseQty.BackColor = System.Drawing.Color.White;
                                            cmbIntakeMethod.BackColor = System.Drawing.Color.White;
                                            cmbMorn.BackColor = System.Drawing.Color.White;
                                            cmbNight.BackColor = System.Drawing.Color.White;
                                            cmbNoon.BackColor = System.Drawing.Color.White;
                                            cmbEvening.BackColor = System.Drawing.Color.White;
                                            txtDDay.BackColor = System.Drawing.Color.White;


                                            if (IsDuplicateListviewItem(lvwMedication, cmbMedicineName.Text.ToString()))
                                            {
                                                MessageBox.Show("The Medicine Name is already exist", "HIMS");
                                                goto lab;
                                            }

                                            ListViewItem lvi;
                                            lvi = lvwMedication.Items.Add(cmbType.Text.ToString());
                                            lvi.SubItems.Add(cmbMedicineName.Text.ToString());
                                            lvi.SubItems.Add(txtDoseQty.Text.ToString());
                                            lvi.SubItems.Add(cmbIntakeMethod.Text.ToString());
                                            lvi.SubItems.Add(cmbMorn.Text.ToString());
                                            lvi.SubItems.Add(cmbNoon.Text.ToString());
                                            lvi.SubItems.Add(cmbEvening.Text.ToString());
                                            lvi.SubItems.Add(cmbNight.Text.ToString());
                                            lvi.SubItems.Add(txtDDay.Text.ToString());

                                        lab:
                                            cmbMedicineName.Text = "";
                                            txtDoseQty.Text = "";
                                            cmbIntakeMethod.Text = "";
                                            cmbMorn.Text = "";
                                            cmbNoon.Text = "";
                                            cmbEvening.Text = "";
                                            cmbNight.Text = "";
                                            txtDDay.Text = "";
                                            cmbMedicineName.Focus();
                                        }

                                    else
                                    {
                                        txtDDay.BackColor = System.Drawing.Color.Bisque;
                                        txtDDay.Focus();
                                    }

                                }

                                else
                                {
                                    cmbNight.BackColor = System.Drawing.Color.Bisque;
                                    cmbNight.Focus();
                                }
                            }
                            else
                            {
                                cmbEvening.BackColor = System.Drawing.Color.Bisque;
                                cmbEvening.Focus();
                            }
                        }
                            else
                            {
                                cmbNoon.BackColor = System.Drawing.Color.Bisque;
                                cmbNoon.Focus();
                            }
                         }
                        else
                        {
                            cmbMorn.BackColor = System.Drawing.Color.Bisque;
                            cmbMorn.Focus();
                        }
                    }
                    else
                    {
                        cmbIntakeMethod.BackColor = System.Drawing.Color.Bisque;
                        cmbIntakeMethod.Focus();
                    }
                }
                else
                {
                    txtDoseQty.BackColor = System.Drawing.Color.Bisque;
                    txtDoseQty.Focus();
                }
            }
            else
            {
                cmbMedicineName.BackColor = System.Drawing.Color.Bisque;
                cmbMedicineName.Focus();
            }
        }
        else
            {
                cmbType.BackColor = System.Drawing.Color.Bisque;
                cmbType.Focus();
            }
        }

        private void btnAddAdvice_Click(object sender, EventArgs e)
        {
            if (cmbAdvice.Text.ToString() != "" && cmbAdvice.Text.ToString() != "<Select>")
            {
                cmbAdvice.BackColor = System.Drawing.Color.White;

                if (IsDuplicateListviewItem(lvwAdvice, cmbAdvice.Text.ToString()))
                {
                    MessageBox.Show("The Advice is already exist", "HIMS");
                    goto lab;
                }


                ListViewItem lvi;
                lvi = lvwAdvice.Items.Add(cmbAdvice.Text.ToString());

            lab:
                cmbAdvice.Text = "";
                cmbAdvice.Focus();
            }
            else
            {
                cmbAdvice.BackColor = System.Drawing.Color.Bisque;
                cmbAdvice.Focus();
            }
        }
        public void refreshContent()
        {
            lvwAdvice.Items.Clear();
            lvwInvestigation.Items.Clear();
            lvwMedication.Items.Clear();
            lvwVisitedDate.Items.Clear();
            cmbTestItems.Text = "";
            cmbResults.Text = "";
            this.txtPatientName.Text = "";
            txtBookingSerial.Text = "";
            cmbMedicineName.Text = "";
            txtDoseQty.Text = "";
            cmbIntakeMethod.Text = "";
            cmbAdvice.Text = "";
            txtBP.Text = "";
            txtCC.Text = "";
            txtHeight.Text = "";
            txtPulse.Text = "";
            txtWeight.Text = "";
            txtTemp.Text = "";
            txtPrimaryDiagonosis.Text = "";
            txtHospitalID.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshContent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOutdoorPatient_Load(object sender, EventArgs e)
        {
            lvwHospitalID.Items.Clear();
            Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
            TestItemBLL testItemBLL = new TestItemBLL();
            ProductCategoryBLL productCategoryBLL = new ProductCategoryBLL();
            AdviceBLL adviceBLL = new AdviceBLL();
            DataSet dsadvice = adviceBLL.Getadvices();
            DataSet dsInves = testItemBLL.Gettest_items();
            IntakeSysBLL intakeSysBLL = new IntakeSysBLL();
            DataSet daIntk = intakeSysBLL.Getintake_syss();
            cmbMedicineName.Items.Clear();
            if (daIntk != null)
            {
                PopulateComboBox(cmbIntakeMethod, daIntk, 0, "intake_sys", "intake_sys_id");
            }
            DataSet dsss = productCategoryBLL.GetMedicineType();
            if (dsss != null)
            {
                PopulateComboBox(cmbType, dsss, 0, "product_category", "product_category_id");
            }
            DataSet dss = outdoor_bookingBLL.GetOutdoorConsultantAll();
            if (dss != null)
            {
                PopulateComboBox(cmbConsullantlist, dss, 0, "reffered_doctors", "reffered_doctors_id");
            }

            if (dsInves != null)
            {
                PopulateComboBox(cmbTestItems, dsInves, 0, "test_item", "test_item_id");
            }
            if (dsadvice != null)
            {
                PopulateComboBox(cmbAdvice, dsadvice, 0, "advice", "advice_id");
            }
            /*MedicineBLL medicineBLL = new MedicineBLL();
            DataSet ds = medicineBLL.Getmedicines();
            if (ds != null)
            {
                PopulateComboBox(cmbMedicineName, ds, 0, "product.product_id", "product");
            }
            */
            cmbMorn.Items.Add("0");
            cmbMorn.Items.Add("0.5");
            cmbMorn.Items.Add("1");
            cmbMorn.Items.Add("2");
            cmbNoon.Items.Add("0");
            cmbNoon.Items.Add("0.5");
            cmbNoon.Items.Add("1");
            cmbNoon.Items.Add("2");
            cmbEvening.Items.Add("0");
            cmbEvening.Items.Add("0.5");
            cmbEvening.Items.Add("1");
            cmbEvening.Items.Add("2");
            cmbNight.Items.Add("0");
            cmbNight.Items.Add("0.5");
            cmbNight.Items.Add("1");
            cmbNight.Items.Add("2");

        }

        private void FillUpListview2(ListView lvw, DataSet ds)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[0].Rows[i];

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

        private void cmbConsullantlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbConsullantlist.SelectedIndex>0)
                {
                    lvwHospitalID.Items.Clear();
                    string value = "";
                    if (cmbConsullantlist.Text != "<Select>" && cmbConsullantlist.Text != "")
                    {
                        value = ((DataRowView)(cmbConsullantlist.SelectedItem)).Row[0].ToString();
                        Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                        DataSet ds = outdoor_bookingBLL.GetOutdoorConsultantPatient(Convert.ToInt32(value));
                        FillUpListview(lvwHospitalID, ds);
                    }
                }
            }
            catch
            {

            }
        }

        private void lvwHospitalID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwHospitalID_Click(object sender, EventArgs e)
        {
            this.refreshContent();
            if (lvwHospitalID.FocusedItem.Text != "")
            {
                
                if (lvwHospitalID.SelectedItems.Count > 0)
                {
                    
                    Outdoor_booking outdoor_booking = new Outdoor_booking();
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    int PatientCode = Convert.ToInt32(lvwHospitalID.FocusedItem.Text);
                    DataSet ds = outdoor_bookingBLL.GetOutdoorPatientHSN(PatientCode);

                    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        int year = 0;
                        int month = 0;
                        int day = 0;
                        txtBookingSerial.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtHospitalID.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0][3].ToString();
                        DOB = Convert.ToDateTime(ds.Tables[0].Rows[0][5]);
                        CalculateAge(DOB, out year, out month, out day);
                        
                            if ((year <= 0) && (month > 0))
                            {
                                Age = month.ToString() + " Months";
                            }
                            else if ((year <= 0) && (month <= 0))
                            {
                                Age = day.ToString() + " Days";
                            }
                            else 
                            {
                                Age = year.ToString() + " Years";
                            }                   
                        FillUpListview2(lvwVisitedDate, ds);

                    }
                }

            }
        }
        public static int getMonthDays(int mon)
        {
            try
            {
                switch (mon)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        return 31;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:

                        if (DateTime.Now.Year % 4 == 0)
                        {

                            return 29;
                        }
                        return 28;
                }
            }
            catch
            {
            }
            return 28;
        }
        void CalculateAge(DateTime dob, out int years, out int months, out int days)
        {
            years = 0;
            months = 0;
            days = 0;
            try
            {
                //30, 5, 12
                int dtmp = 0; int ytmp = 0;
                DateTime now = DateTime.Now;
                if (dob.Day <= now.Day)
                { days = now.Day - dob.Day; }
                else
                { days = getMonthDays(dob.Month) + now.Day - dob.Day; dtmp = 1; }
                if (dob.Month <= now.Month - dtmp)
                { months = now.Month - dob.Month - dtmp; }
                else
                { months = 12 + now.Month - dob.Month; ytmp = 1; }

                if (dob.Year <= now.Year - ytmp)
                { years = now.Year - dob.Year - ytmp; }
            }
            catch
            {
            }
        }

        private void PrintOutdoorPatientReport(int outdoor_booking_id,string age)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OutDoorPatient();
                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                pdvCustomerName.Value = outdoor_booking_id;
                pvCollection.Add(pdvCustomerName);
                rptCustomersOrders.DataDefinition.ParameterFields[0].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]
                rptCustomersOrders.DataDefinition.ParameterFields[1].ApplyCurrentValues(pvCollection);
                rptCustomersOrders.DataDefinition.ParameterFields[2].ApplyCurrentValues(pvCollection);
                rptCustomersOrders.DataDefinition.ParameterFields[3].ApplyCurrentValues(pvCollection);
                rptCustomersOrders.DataDefinition.ParameterFields[4].ApplyCurrentValues(pvCollection);
                rptCustomersOrders.SetParameterValue("@age",age);
                rptCustomersOrders.SetParameterValue("@UserName",ApplicatinLauncher._userName);
                //rptCustomersOrders.SetParameterValue("@outdoor_booking_id", outdoor_booking_id);
                //rptCustomersOrders.SetParameterValue("@outdoor_booking_id", outdoor_booking_id);
                
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }

        }

        private void lvwVisitedDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwVisitedDate.SelectedItems.Count > 0)
                {
                    if (lvwVisitedDate.SelectedItems[0].SubItems[2].Text != null)
                    {
                        OutdoorPatientMedicationBLL outdoorPatientMedicationBLL = new OutdoorPatientMedicationBLL();
                        OutdoorPatientMedication outdoorPatientMedication = new OutdoorPatientMedication();
                        DataSet ds = outdoorPatientMedicationBLL.GetOutdoorMedicne(Convert.ToInt32(lvwVisitedDate.SelectedItems[0].SubItems[2].Text));
                        FillUpListviewDT(lvwMedication, ds, 0);
                        FillUpListviewDT(lvwInvestigation, ds, 1);
                        txtBP.Text = ds.Tables[3].Rows[0][3].ToString();
                        txtPulse.Text = ds.Tables[3].Rows[0][4].ToString();
                        txtHeight.Text = ds.Tables[3].Rows[0][5].ToString();
                        txtWeight.Text = ds.Tables[3].Rows[0][6].ToString();
                        txtTemp.Text = ds.Tables[3].Rows[0][7].ToString();
                        txtCC.Text = ds.Tables[3].Rows[0][8].ToString();
                        txtPrimaryDiagonosis.Text = ds.Tables[3].Rows[0][9].ToString();
                        FillUpListviewDT(lvwAdvice, ds, 2);
                    }

                }


            }
            catch
            {

            }
        }

        private void btnPrintSampleCollected_Click(object sender, EventArgs e)
        {
            try
            {
                bookingID = Convert.ToInt32(txtBookingSerial.Text);
                if (bookingID > 0)
                {
                    PrintOutdoorPatientReport(bookingID,Age);
                }
                else
                    MessageBox.Show("Data Save Failed", "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {

            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbType.SelectedIndex > 0)
                {

                    if (cmbType.Text != "<Select>" && cmbType.Text != "")
                    {
                        MedicineBLL medicineBLL = new MedicineBLL();
                        DataSet dsss = medicineBLL.Getmedicines(Convert.ToInt32(((DataRowView)(cmbType.SelectedItem)).Row[1].ToString()));
                        if (dsss != null)
                        {
                            PopulateComboBox(cmbMedicineName, dsss, 0, "product.product_id", "product");
                        }
                    }
                    else
                        cmbMedicineName.Items.Clear();
                }
            }
            catch
            {

            }
        }

        private void lvwMedication_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lvwMedication.SelectedItems.Count > 0)
                {
                    lvwMedication.FocusedItem.Remove();
                }
            }
        }

        private void lvwInvestigation_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lvwInvestigation.SelectedItems.Count > 0)
                {
                    lvwInvestigation.FocusedItem.Remove();
                }
            }
        }

        private void lvwAdvice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lvwAdvice.SelectedItems.Count > 0)
                {
                    lvwAdvice.FocusedItem.Remove();
                }
            }
        }
        private void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            
        }

        private void txtPulse_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void txtDoseQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void cmbMorn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar !='.')
            {
                e.Handled = true;
            }
            
        }

        private void cmbNoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void cmbEvening_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void cmbNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dtpNextVisitedDate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtpNextVisitedDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpNextVisitedDate.Value) < DateTime.Now)
            {
                MessageBox.Show("Check the Next visited date");
                return;
            }
         
        }
    }
} 


 



