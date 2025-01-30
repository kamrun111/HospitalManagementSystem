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
    public partial class FrmOutdoorBooking : BaseForm.FrmBase
    {

        string OBookingDate = "";
        int patientid = 0;
        int outdoor_booking_id = 0;
        

        public FrmOutdoorBooking()
        {
            InitializeComponent();
        }

        void Refesh()
        {
            try
            {
                txtAdd.Text = "";
                txtAmount.Text = "";
                if (linkLabel1.Text != "Old Patient")
                {
                    txtHospitalID.Text = "";
                }
                txtPatientName.Text = "";
                txtCntactNo.Text = "";
                txtRoom.Text = "";
                txtDiscount.Text = "0";
                txtVat.Text = "0";
                txtNetPayable.Text = "0";
                cmbCity.Text = "<Select>";
                cmbConsultant.Text = "<Select>";
                cmbDepartment.Text = "<Select>";
                cmbGender.Text = "<Select>";
                lvwMain.Items.Clear();
                Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                DataSet ds = outdoor_bookingBLL.GetOutdoorPopulationInfo();
                if (ds != null)
                {
                    linkLabel1.Text = "Old Patient";
                    PopulateComboBox(cmbGender, ds, 0, "gender", "gender_id");
                    PopulateComboBox(cmbCity, ds, 1, "city", "city_id");
                    PopulateComboBox(cmbDepartment, ds, 2, "specialist_in", "specialist_in_id");
                    txtHospitalID.Text = (Convert.ToInt32(ds.Tables[3].Rows[0][0]) + 1).ToString("0000000#");
                    txtHospitalID.Enabled = false;
                }
                OtherItemBLL otherItemBLL = new OtherItemBLL();
                DataSet dso = otherItemBLL.Getother_items();
                if (dso.Tables[0].Rows.Count > 0)
                {
                    PopulateComboBox(cmbOtherItem, dso, 0, "other_item", "other_item_id");
                }
            }
            catch 
            {
                
                
            }
            
        }

        void Refesh2()
        {
            try
            {
                txtAdd.Text = "";
                txtAmount.Text = "";
                if (linkLabel1.Text != "Old Patient")
                {
                    txtHospitalID.Text = "";
                }
                txtPatientName.Text = "";
                txtCntactNo.Text = "";
                txtRoom.Text = "";
                cmbCity.Text = "<Select>";
                cmbConsultant.Text = "<Select>";
                cmbDepartment.Text = "<Select>";
                cmbGender.Text = "<Select>";
                lvwMain.Items.Clear();
                Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                DataSet ds = outdoor_bookingBLL.GetOutdoorPopulationInfo();
                if (ds != null)
                {
                    linkLabel1.Text = "New Patient";
                    PopulateComboBox(cmbGender, ds, 0, "gender", "gender_id");
                    PopulateComboBox(cmbCity, ds, 1, "city", "city_id");
                    PopulateComboBox(cmbDepartment, ds, 2, "specialist_in", "specialist_in_id");
                    txtHospitalID.Text = (Convert.ToInt32(ds.Tables[3].Rows[0][0]) + 1).ToString("0000000#");
                    //txtHospitalID.Enabled = false;
                }
                
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
                combo.Text = "<Select>";
                if (combo.SelectedIndex >= 0)
                    combo.SelectedIndex = -1;//why -1
            }
            catch 
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (lvwPatientOtherItem.Items.Count > 0)
                {
                    Outdoor_booking outdoor_booking = new Outdoor_booking();
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();

                    outdoor_booking.outdoor_patient_id = patientid;
                    outdoor_booking.booking_date = Convert.ToString(dtpDate.Value.ToString("MM-dd-yyyy"));
                    outdoor_booking.record_created_by = ApplicatinLauncher._userId;
                    outdoor_booking.amount = Convert.ToDecimal(txtAmount.Text);
                    outdoor_booking.vat = Convert.ToDecimal(txtVat.Text);
                    outdoor_booking.discount = Convert.ToDecimal(txtDiscount.Text);
                    outdoor_booking_id = outdoor_bookingBLL.Addoutdoor_ptient_booking(outdoor_booking);

                    PatientOtherItem patientOtherItem = new PatientOtherItem();
                    PatientOtherItemBLL patientOtherItemBLL = new PatientOtherItemBLL();

                    for (int i = 0; i < lvwPatientOtherItem.Items.Count; i++)
                    {
                        patientOtherItem.other_item_id = Convert.ToInt32(lvwPatientOtherItem.Items[i].SubItems[0].Text);
                        patientOtherItem.qty_per_unit = Convert.ToInt32(lvwPatientOtherItem.Items[i].SubItems[2].Text);
                        patientOtherItem.record_created_by = ApplicatinLauncher._userId;
                        patientOtherItem.patient_id = patientid;
                        patientOtherItemBLL.OtherItemAddforOPD(patientOtherItem);
                    }
                    MessageBox.Show("Data Save Successfully");
                    lvwPatientOtherItem.Items.Clear();
                    txtAmount.Text = "0";
                    txtVat.Text = "0";
                    txtDiscount.Text = "0";
                    txtNetPayable.Text = "0";
                    grpOtherItem.Enabled = false;
                    if (outdoor_booking_id > 0)
                    {
                        PrintOutdoorBookingReport(outdoor_booking_id);
                        //Refresh();
                    }
                    //if (txtPatientName.Text != "" && txtCntactNo.Text != "" && txtAdd.Text != "" && txtRoom.Text != "" && cmbCity.Text != "<Select>" && cmbConsultant.Text != "<Select>" && cmbGender.Text != "<Select>" && mskTime.Text != "_:_")
                    //{


                    //    Patient patient = new Patient();
                    //    Outdoor_booking outdoor_booking = new Outdoor_booking();
                    //    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    //    //patient.patient_code = txtHospitalID.Text.ToString();
                    //    patient.patient_name = txtPatientName.Text.ToString();
                    //    patient.gender_id = Convert.ToInt32(((DataRowView)(cmbGender.SelectedItem)).Row[0].ToString());
                    //    patient.address = txtAdd.Text.ToString();
                    //    patient.city_id = Convert.ToInt32(((DataRowView)(cmbCity.SelectedItem)).Row[0].ToString());
                    //    patient.c_phone = txtCntactNo.Text.ToString();
                    //    patient.dob = Convert.ToDateTime(dtpDOB.Value);
                    //outdoor_booking.reffered_doctors_id = Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString());
                    //outdoor_booking.booking_date = Convert.ToString(dtpDate.Value.ToString("MM-dd-yyyy"));
                    //if (radioAM.Checked == true)
                    //    outdoor_booking.booking_time = mskTime.Text.ToString() + " AM";
                    //else
                    //    outdoor_booking.booking_time = mskTime.Text.ToString() + " PM";
                    //outdoor_booking.room_no = txtRoom.Text.ToString();
                    //outdoor_booking.record_created_by = ApplicatinLauncher._userId;
                    //outdoor_booking.amount = Convert.ToInt32("0");
                    //if (linkLabel1.Text == "Old Patient")
                    //{
                    //    outdoor_booking_id = outdoor_bookingBLL.Addoutdoor_ptient_booking(outdoor_booking, patient);
                    //}
                    //else
                    //{
                    //    patient.patient_code = txtHospitalID.Text.ToString();
                    //    outdoor_booking.outdoor_patient_id = patientid;
                    //    outdoor_booking_id = outdoor_bookingBLL.Addoutdoor_booking(outdoor_booking);
                    //}
                    //    //MessageBox.Show("OK");
                    //    //RefferedDoctorID = Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString());
                    //    OBookingDate = Convert.ToString(dtpDate.Value.ToString("MM-dd-yyyy"));
                    //    DataSet ds = outdoor_bookingBLL.BookingPatientNameGet((Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString())), OBookingDate);
                    //    FillUpListview(lvwMain, ds, 0);
                    //    if (outdoor_booking_id > 0 && (Convert.ToInt32(txtAmount.Text.ToString()))>0)
                    //    {
                    //        PrintOutdoorBookingReport(outdoor_booking_id);
                    //        Refresh();
                    //    }
                    //    else
                    //        MessageBox.Show("Data Save Successfully");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Please Check the booking information");
                    //}
                }

            }
            catch
            {

            }
        }
        void PrintOutdoorBookingReport(int outdoor_booking_id)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OutdoorBooking();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@outdoor_booking_id", outdoor_booking_id);
               
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

                lvwMain.Items.Clear();
                try
                {
                    if (cmbDepartment.SelectedIndex >= 0)
                    {
                        RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
                        DataSet dss = refferedDoctorsBLL.GetSConsultants(Convert.ToInt32(((DataRowView)(cmbDepartment.SelectedItem)).Row[0].ToString()));
                        if (dss != null)
                        {
                            PopulateComboBox(cmbConsultant, dss, 0, "reffered_doctors", "reffered_doctors_id");
                            
                        }
                    }

                  }
                catch
                {


                
                }
           
}


        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)// why table index why this not use in other funtion
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(Convert.ToString(i + 1));
                    //for (int j = 1; j < lvw.Columns.Count; j++)//gdgdg
                    //{
                  

                    lvi.SubItems.Add(dataRow[0].ToString());
                    lvi.SubItems.Add(dataRow[1].ToString());
                    lvi.SubItems.Add(dataRow[3].ToString());
                    //}
                    lvw.Items.Add(lvi);
                }
            }
        }




        private void FrmOutdoorBooking_Load(object sender, EventArgs e)
        {
            try
            {
                Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                DataSet ds = outdoor_bookingBLL.GetOutdoorPopulationInfo();
                if (ds != null)
                {
                    linkLabel1.Text = "Old Patient";
                    PopulateComboBox(cmbGender, ds, 0, "gender", "gender_id");
                    PopulateComboBox(cmbCity, ds, 1, "city", "city_id");
                    PopulateComboBox(cmbDepartment, ds, 2, "specialist_in", "specialist_in_id");
                    txtHospitalID.Text = (Convert.ToInt32(ds.Tables[3].Rows[0][0]) + 1).ToString("0000000#");
                    txtHospitalID.Enabled= false;
                }
                OtherItemBLL otherItemBLL = new OtherItemBLL();
                DataSet dso = otherItemBLL.Getother_items();
                if (dso.Tables[0].Rows.Count > 0)
                {
                    PopulateComboBox(cmbOtherItem, dso, 0, "other_item", "other_item_id");
                }

            }
            catch 
            {
                
              
            }

        }

        private void cmbConsultant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbConsultant.SelectedIndex >= 0)
                {
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    if (cmbConsultant.SelectedIndex > 0)
                    {
                        //RefferedDoctorID = Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString());
                        RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
                        DataSet dss = refferedDoctorsBLL.GetVisitRoom(Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString()));
                        if (dss.Tables[0].Rows[0][0] != null)
                            this.txtAmount.Text = dss.Tables[0].Rows[0][0].ToString();
                        else
                            this.txtAmount.Text = "";
                        if (dss.Tables[0].Rows[0][1] != null)
                            this.txtRoom.Text = dss.Tables[0].Rows[0][1].ToString();
                        else
                            this.txtRoom.Text = "";
                        DataSet ds = outdoor_bookingBLL.BookingPatientNameGet((Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString())), Convert.ToString(dtpDate.Value.ToString("MMM-dd-yyyy")));
                        lvwMain.Items.Clear();
                        FillUpListview(lvwMain, ds, 0);
                    }

                    if (cmbConsultant.Text != "" && cmbConsultant.Text != "<Select>")
                    {
                        //Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                        OBookingDate = Convert.ToString(dtpDate.Value.ToString("MM-dd-yyyy"));
                        DataSet ds = outdoor_bookingBLL.BookingPatientNameGet((Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString())), OBookingDate);
                        FillUpListview(lvwMain, ds, 0);
                    }
                    else
                        lvwMain.Items.Clear();
                }

            }
            catch
            {


            }
            

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GenderID = Convert.ToInt32(((DataRowView)(cmbGender.SelectedItem)).Row[0].ToString());
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           //CityID = Convert.ToInt32(((DataRowView)(cmbCity.SelectedItem)).Row[0].ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refesh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumCheck(KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCntactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
            if (e.KeyChar == 13)
            {
                txtAdd.Focus();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHospitalID_Leave(object sender, EventArgs e)
        {
            try
            {
                    PatientBLL patientBLL = new PatientBLL();
                    DataSet ds = patientBLL.OutdoorPatientInfoGet(txtHospitalID.Text.ToString());
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        txtPatientName.Text = ds.Tables[0].Rows[0][0].ToString();
                        dtpDOB.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3].ToString());
                        txtCntactNo.Text = ds.Tables[0].Rows[0][2].ToString();
                        cmbGender.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtAdd.Text = ds.Tables[0].Rows[0][1].ToString();
                        cmbCity.Text = ds.Tables[0].Rows[0][5].ToString();
                        patientid = Convert.ToInt32(ds.Tables[0].Rows[0][6]);
                    }
                    else
                    {
                        MessageBox.Show("The HospitalID is Invalid");
                        txtHospitalID.Text = "";
                        //txtHospitalID.Focus();
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
                if (linkLabel1.Text == "New Patient")
                {
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    DataSet ds = outdoor_bookingBLL.GetOutdoorPopulationInfo();
                    if (ds != null)
                    {
                        linkLabel1.Text = "Old Patient";
                        Refesh();
                        PopulateComboBox(cmbGender, ds, 0, "gender", "gender_id");
                        PopulateComboBox(cmbCity, ds, 1, "city", "city_id");
                        PopulateComboBox(cmbDepartment, ds, 2, "specialist_in", "specialist_in_id");
                        txtHospitalID.Text = (Convert.ToInt32(ds.Tables[3].Rows[0][0]) + 1).ToString("0000000#");
                        txtHospitalID.Enabled = false;
                    }

                }
                else
                {
                    linkLabel1.Text = "New Patient";
                    txtHospitalID.Text = "";
                    txtHospitalID.Enabled = true;
                    Refesh2();
                }

            }
            catch 
            {
                
             
            }

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpDate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbConsultant.Text != "" && cmbConsultant.Text != "<Select>")
                {
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    OBookingDate = Convert.ToString(dtpDate.Value.ToString("MMM-dd-yyyy"));
                    DataSet ds = outdoor_bookingBLL.BookingPatientNameGet((Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString())), OBookingDate);
                    FillUpListview(lvwMain, ds, 0);
                    if (Convert.ToDateTime(dtpDate.Value) < Convert.ToDateTime(DateTime.Now))
                    {
                        MessageBox.Show("Check the Booking date");
                        return;
                    }
                }
                else
                {
                    lvwMain.Items.Clear();
                    MessageBox.Show("Please select the Consultnt Name");
                    cmbConsultant.Focus();
                }
            }
            catch
            {


            }
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpDOB.Value) > DateTime.Now)
            {
                MessageBox.Show("Check the Barth of date");
                dtpDOB.Focus();
                return;
            }
        }

        private void btnPList_Click(object sender, EventArgs e)
        {

            FrmDailyPatientSearch frmDailyPatientSearch = new FrmDailyPatientSearch();
            frmDailyPatientSearch.MdiParent = this.MdiParent;
            frmDailyPatientSearch.Show();
            //if (cmbConsultant.Text != "" && cmbConsultant.Text != "<Select>")
            //{
            //    try
            //    {
            //        CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
            //        CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
            //        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            //        ReportDocument rptCustomersOrders = new OdPBookingListByDr();
            //        //rptCustomersOrders.Load(@"..\..\Reports\Admission\rptAdmission.rpt");

            //        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            //        {
            //            tliCurrent = tbCurrent.LogOnInfo;

            //            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
            //            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
            //            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
            //            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
            //            tbCurrent.ApplyLogOnInfo(tliCurrent);
            //        }
                    
            //        rptCustomersOrders.SetParameterValue("@reffered_doctors_id", Convert.ToInt32(((DataRowView)(cmbConsultant.SelectedItem)).Row[0].ToString()));
            //        rptCustomersOrders.SetParameterValue("@booking_date", OBookingDate);
            //        rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

            //        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            //        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            //        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            //        frmGenericReportViewer.Show();
            //    }
            //    catch
            //    {
            //    }
            //}
            //else
            //    MessageBox.Show("Please Select the Consultant");
        }

        private void btnPrintSampleCollected_Click(object sender, EventArgs e)
        {
            try
            {
                PrintOutdoorBookingReport((Convert.ToInt32((lvwMain.SelectedItems[0].SubItems[3].Text.ToString()))));
                Refresh();
            }
            catch 
            {
                
                
            }
            
        }

        private void lvwMain_Click(object sender, EventArgs e)
        {
            if (lvwMain.SelectedItems[0].SubItems[2].Text != "")
            {
                try
                {
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    DataSet ds = outdoor_bookingBLL.GetOutDoorPatientInfo(Convert.ToInt32((lvwMain.SelectedItems[0].SubItems[3].Text.ToString())));
                    txtHospitalID.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPatientName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtAdd.Text = ds.Tables[0].Rows[0][2].ToString();
                    cmbGender.Text = ds.Tables[0].Rows[0][3].ToString();
                    cmbCity.Text = ds.Tables[0].Rows[0][12].ToString();
                    cmbConsultant.Text = ds.Tables[0].Rows[0][4].ToString();
                    cmbDepartment.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtRoom.Text = ds.Tables[0].Rows[0][9].ToString();
                    dtpDate.Text = ds.Tables[0].Rows[0][7].ToString();
                    mskTime.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtCntactNo.Text = ds.Tables[0].Rows[0][11].ToString();

                }
                catch 
                {
                    
                   
                }

             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Outdoor_booking outdoor_booking = new Outdoor_booking();
                Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                outdoor_booking.outdoor_booking_id = (Convert.ToInt32((lvwMain.SelectedItems[0].SubItems[3].Text.ToString())));
                outdoor_booking.amount = Convert.ToInt32(txtAmount.Text.ToString());
                outdoor_bookingBLL.OutdoorPaidAmount(outdoor_booking);
                MessageBox.Show("Paid successfully");

            }
            catch 
            {
                
                
            }
            
        }

        private void txtHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbDepartment.Focus();
            }
        }

        private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAgeYy.Focus();
            }
        }

        private void dtpDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave.Focus();
            }
        }

        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatientName.Focus();
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
                txtCntactNo.Focus();
            }
        }

        private void cmbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbConsultant.Focus();
            }
        }

        private void cmbConsultant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtRoom.Focus();
            }
        }

        private void txtRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpDate.Focus();
            }
        }

        private void dtpDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                mskTime.Focus();
            }
        }

        private void mskTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave.Focus();
            }
        }
        Boolean IsMatchTest(string item)
        {

            for (int i = 0; i < lvwPatientOtherItem.Items.Count; i++)
            {
                if (lvwPatientOtherItem.Items[i].SubItems[1].Text == item)

                    return true;
            }
            return false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbOtherItem.SelectedIndex)>0)
                {
                    Outdoor_bookingBLL outdoor_bookingBLL = new Outdoor_bookingBLL();
                    DataSet ds = outdoor_bookingBLL.ItemCharge(Convert.ToInt32(cmbOtherItem.SelectedValue));
                    int chg = (Convert.ToInt32(ds.Tables[0].Rows[0][0])*Convert.ToInt32(txtQtyPerUnit.Text));
                    txtcharge.Text = chg.ToString();
                }

                if (IsMatchTest(cmbOtherItem.Text))
                {
                    MessageBox.Show("Test already exists");
                    return;
                }

                ListViewItem lItem = new ListViewItem(((DataRowView)(cmbOtherItem.SelectedItem)).Row[0].ToString());
                lItem.SubItems.Add(this.cmbOtherItem.Text);
                lItem.SubItems.Add(this.txtQtyPerUnit.Text);
                lItem.SubItems.Add(this.txtcharge.Text);
                this.lvwPatientOtherItem.Items.Add(lItem);

                double total = 0.0;
                for (int i = 0; i < lvwPatientOtherItem.Items.Count; i++)
                {
                    double subTolal;
                    subTolal = Convert.ToDouble(lvwPatientOtherItem.Items[i].SubItems[3].Text);
                    total = total + subTolal;
                }
                double vat = ((total * 2.25) / 100);
                txtVat.Text = vat.ToString();
                int Gtotal = Convert.ToInt32(total + vat+0.01);
                this.txtAmount.Text = Gtotal.ToString("0#.#0");
                double NP = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text);
                txtNetPayable.Text = NP.ToString();
                btnSave.Enabled = true;

            }
            catch
            {
            }
        }

        private void btnPatientSave_Click(object sender, EventArgs e)
        {
            try
            {
                Patient patient = new Patient();
                PatientBLL patientBLL = new PatientBLL();

                //patient.patient_code = txtHospitalID.Text.ToString();
                if (txtPatientName.Text != "")
                {
                    patient.patient_name = txtPatientName.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Please Insert Patient Name");
                    return;
                }
                patient.dob = Convert.ToDateTime(dtpDOB.Value);

                if (cmbGender.SelectedIndex !=-1)
                {
                    patient.gender_id = Convert.ToInt32(((DataRowView)(cmbGender.SelectedItem)).Row[0].ToString());
                }
                else
                {
                    MessageBox.Show("Please Insert Patient's Gender");
                    return;
                }
                if (txtAdd.Text != "")
                {
                    patient.address = txtAdd.Text.ToString();
                }
                if (txtCntactNo.Text != "")
                {
                    patient.c_phone = txtCntactNo.Text.ToString();
                }
                if (cmbCity.SelectedIndex != -1)
                {
                    patient.city_id = Convert.ToInt32(((DataRowView)(cmbCity.SelectedItem)).Row[0].ToString());
                }
                patientid= patientBLL.PatientAddforOPD(patient);
                MessageBox.Show("Sasved Successfully");
                grpOtherItem.Enabled = true;
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

        private void txtAgeDd_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                    cmbCity.Focus();
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

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    double NP = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text);
                    txtNetPayable.Text = NP.ToString();
                }
            }
            catch
            {
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                double NP = Convert.ToDouble(txtAmount.Text) - Convert.ToDouble(txtDiscount.Text);
                txtNetPayable.Text = NP.ToString();
            }
            catch
            {
            }
        }

        public void RefreshOpd()
        {
            txtPatientName.Text = "";
            txtAdd.Text = "";
            txtAgeDd.Text = "";
            txtAgeMm.Text = "";
            txtAgeYy.Text = "";
            txtCntactNo.Text = "";
            cmbCity.Text = "<Select>";
            cmbGender.Text = "<Select>";
            dtpDate.Text = "";
        }
        private void lblSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                txtHospitalID.Text = "";
                
            }
            catch
            {
            }
        }
     }
}