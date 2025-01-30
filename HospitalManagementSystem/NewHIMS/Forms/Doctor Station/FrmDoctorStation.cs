using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Doctor_Station.Patient_History;
using NewHIMS.Forms.Doctor_Station.Doctor_Visit;
using NewHIMS.Forms.Doctor_Station.ConultantList;
using NewHIMS.Forms.Doctor_Station.OTNote;
using System.Threading;

namespace NewHIMS.Forms.Doctor_Station
{
    public partial class FrmDoctorStation : BaseForm.FrmBase
    {
        public FrmDoctorStation()
        {
            InitializeComponent();
        }

        void RefreshDoctorStation()
        {
            FloorBLL floorBLL = new FloorBLL();
            DataSet ds = floorBLL.Getfloors();
            cmbFloor.DataSource = ds.Tables[0];
            cmbFloor.DisplayMember = "floor";
            cmbFloor.ValueMember = "floor_id";
            if (this.cmbFloor.Items.Count > 1)
            {
                this.cmbFloor.SelectedIndex = 0;
            }
            this.tmr_Tick(null, null);
        }
        
        private void FrmDoctorStation_Load(object sender, EventArgs e)
        {
            RefreshDoctorStation();
        }

        public void refreshCC()
        {
            this.txtPatientCC.Text = "";
            this.grpCCContainer.Visible = false;
        }
        
        private void loadPatientInformation()
        {
            string value="";
            try
            {
                this.refreshCC();
                this.lvwPatientInfo.Items.Clear();
               
                if (cmbFloor.Text != "<Select>" && cmbFloor.Text != "")
                    value = ((DataRowView)(cmbFloor.SelectedItem)).Row[0].ToString();

                AdmissionBLL admissionBLL=new AdmissionBLL();
                DataSet ds = admissionBLL.GetDoctorStationPopulationInfo(Convert.ToInt32(value));
               
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                    {
                        ListViewItem lItem = new ListViewItem(ds.Tables[0].Rows[r]["patient_id"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["cabin"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_code"].ToString());
                        if (ds.Tables[0].Rows[r]["is_cc_written"].ToString() != "1")
                        {
                                lItem.SubItems.Add("NOT-RECEIVED");
                                lItem.ForeColor = Color.Maroon;
                        }
                        else
                        {
                            if (ds.Tables[0].Rows[r]["is_history_written"].ToString() == "1")
                                {
                                    lItem.SubItems.Add("HISTORY-WRITTEN");
                                    lItem.ForeColor = Color.DodgerBlue;
                                }
                                else
                                {
                                    lItem.SubItems.Add("RECEIVED");
                                    lItem.ForeColor = Color.PowderBlue;
                                }
                           }
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_id"].ToString());	//4
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_code"].ToString());	//5
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_date"].ToString());	//6
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["remarks"].ToString());			//7
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["cabin_id"].ToString());		//8
                            this.lvwPatientInfo.Items.Add(lItem);
                     }
                }
                this.tmr_Tick(this.lvwPatientInfo, null);
            }
            catch
            {
            }
        }
   
        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbfloorload(this);
            }
            catch
            {
            }
        }
        public void cmbfloorload(FrmDoctorStation objForm)
        {
            this.grpRemarksContainer.Visible = false;
            this.grpCCContainer.Visible = false;
            this.loadPatientInformation();
        
        }


        private void lvwPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPatientInfo.SelectedItems.Count > 0)
            {
                this.timer1.Enabled = false;
                OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                DataSet ds=operationNoteBLL.OTlink(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text));
                if (ds.Tables[0].Rows.Count > 0)
                    lnkOTNote.Enabled = true;
                else
                    lnkOTNote.Enabled = false;
                string status = this.lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                this.grpRemarksContainer.Visible = false;
                this.grpCCContainer.Visible = false;
                //if (lvwPatientInfo.se != Color.PowderBlue)
                //{
                //    lnkHistory.Enabled = false;
                //    lnkVisit.Enabled = false;
                //    lnkOverPhone.Enabled = false;
                //    lnkDischarge.Enabled = false;
                //}
                if (status == "NOT-RECEIVED")
                {

                    
                    this.grpCCContainer.Visible = true;
                }
                else
                {
                    this.grpRemarksContainer.Visible = true;
                    this.txtRemarks.Text = this.lvwPatientInfo.SelectedItems[0].SubItems[7].Text;
                    this.grpMenu.Enabled = true;
                    if (status == "HISTORY-WRITTEN")
                    {
                        //this.lnkSpecMessage.Visible = true;
                    }
                }
            }
            else
            {
                this.grpMenu.Enabled = false;

                this.grpRemarksContainer.Visible = false;
                this.grpCCContainer.Visible = false;
                this.lnkSpecMessage.Visible = false;
            }
            this.timer1.Enabled = true;
        }

        private void btnSaveRemarks_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwPatientInfo.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Please re-select patient.");
                    return;
                }

                AdmissionBO admission = new AdmissionBO();
                AdmissionBLL admissionBLL = new AdmissionBLL();

                admission.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text);
                admission.remarks = txtRemarks.Text.ToString();
                admission.record_modified_by = ApplicatinLauncher._userId;
                admissionBLL.UpdateAdmissionRemarks(admission);
                loadPatientInformation();
            }
            catch
            {
            }
        }

        private void btnSaveCC_Click(object sender, EventArgs e)
        {
            try
            {
                int AdmissionID = 0;
                if (this.lvwPatientInfo.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Please re-select patient.");
                    return;
                }
                if (this.txtPatientCC.Text == "")
                {
                    MessageBox.Show("Please write a valid cc.");
                    return;
                }
                else
                {
                    PatientCC patientCC=new PatientCC();
                    PatientCCBLL patientCCBLL = new PatientCCBLL();
                    int res = 0;

                    patientCC.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text);
                    AdmissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text);
                    patientCC.cc = txtPatientCC.Text;
                    patientCC.patient_cc_id = 0;
                    patientCC.record_created_by=ApplicatinLauncher._userId;
                    res=patientCCBLL.Addpatient_cc(patientCC);

                    if (res > 0)
                    {
                        MessageBox.Show("CC Writen successfully");
                        this.cmbFloor_SelectedIndexChanged(null, null);
                        this.refreshCC();
                        this.tmr_Tick(null, null);
                        for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                        { 
                            if(Convert.ToInt16(lvwPatientInfo.Items[i].SubItems[4].Text)==AdmissionID)
                            {
                                lvwPatientInfo.Items[i].Selected= true;
                            }
                        
                        
                        
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                AdmissionBLL admissionBLL = new AdmissionBLL();
                this.lblNonReceivedPatientCabins.Text = "";
                DataSet ds = admissionBLL.GetAllNonReceivedPatientCabin();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.lblNonReceivedPatientCabins.Text = ds.Tables[0].Rows[0][0].ToString();
                    for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                    {
                        this.lblNonReceivedPatientCabins.Text += ", " + ds.Tables[0].Rows[i][0].ToString();
                    }
                }
              
                
            }
            catch
            {
            }
        }

        private void lnkHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    FrmPatientHistory frmPatientHistory = new FrmPatientHistory();
                    ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmPatientHistory);
                    string Cabin = lvwPatientInfo.SelectedItems[0].SubItems[1].Text;
                    string HID = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;
                    string AID = lvwPatientInfo.SelectedItems[0].SubItems[5].Text;
                    frmPatientHistory.refreshContent(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].SubItems[4].Text), Cabin, HID, AID);
                }
            }
            catch
            { 
            }
        }

        private void lnkVisit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.lvwPatientInfo.SelectedItems.Count < 1)
                    return;
                FrmDoctorVisit frmDoctorVisit = new FrmDoctorVisit();
                ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmDoctorVisit);
                frmDoctorVisit.refreshContent(this,VisitMode.VISIT, this.lvwPatientInfo.SelectedItems[0].SubItems[4].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[5].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[6].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[2].Text, Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].SubItems[8].Text));
            }
            catch
            {
            }
        }

        void cccheck()
        {
            try
            {
                if (this.lvwPatientInfo.SelectedItems.Count < 1)
                    return;
                if (this.lvwPatientInfo.SelectedItems[0].ForeColor == Color.Maroon)
                    MessageBox.Show("Write CC First");
            }
            catch
            {
            }
        }

        private void lnkOverPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.lvwPatientInfo.SelectedItems.Count < 1)
                    return;
                FrmDoctorVisit frmDoctorVisit = new FrmDoctorVisit();
                ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmDoctorVisit);
                frmDoctorVisit.refreshContent(this,VisitMode.OVERPHONE, this.lvwPatientInfo.SelectedItems[0].SubItems[4].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[5].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[6].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[2].Text, Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].SubItems[8].Text));
            }
            catch
            {
            }
        }

        private void lnkOTNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    FrmOperationNote frmOperationNote = new FrmOperationNote();
                    ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmOperationNote);
                    frmOperationNote.OtNote(lvwPatientInfo.SelectedItems[0].SubItems[4].Text, lvwPatientInfo.SelectedItems[0].SubItems[2].Text, lvwPatientInfo.SelectedItems[0].SubItems[1].Text, lvwPatientInfo.SelectedItems[0].SubItems[5].Text, Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].SubItems[8].Text));
                }
            }
            catch
            {
            }
        }


        private void lnkDischarge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (this.lvwPatientInfo.SelectedItems.Count < 1)
                    return;
                FrmDoctorVisit frmDoctorVisit = new FrmDoctorVisit();
                ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmDoctorVisit);
                frmDoctorVisit.refreshContent(this,VisitMode.DISCHARGE, this.lvwPatientInfo.SelectedItems[0].SubItems[4].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[5].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[6].Text, this.lvwPatientInfo.SelectedItems[0].SubItems[2].Text, Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].SubItems[8].Text));
            }
            catch
            {
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cmbfloorload(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                    timer1.Enabled = false;
                lvwPatientInfo.Items.Clear();
                AdmissionBLL admissionBLL = new AdmissionBLL();
                DataSet ds = admissionBLL.GetDoctorStationPopulationInfo(Convert.ToInt16(cmbFloor.SelectedValue));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                    {
                        ListViewItem lItem = new ListViewItem(ds.Tables[0].Rows[r]["patient_id"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["cabin"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_code"].ToString());
                        if (ds.Tables[0].Rows[r]["is_cc_written"].ToString() != "1")
                        {
                            lItem.SubItems.Add("NOT-RECEIVED");
                            lItem.ForeColor = Color.Maroon;
                        }
                        else
                        {
                            if (ds.Tables[0].Rows[r]["is_history_written"].ToString() == "1")
                            {
                                lItem.SubItems.Add("HISTORY-WRITTEN");
                                lItem.ForeColor = Color.DodgerBlue;
                            }
                            else
                            {
                                lItem.SubItems.Add("RECEIVED");
                                lItem.ForeColor = Color.PowderBlue;
                            }
                        }
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_id"].ToString());	//4
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_code"].ToString());	//5
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_date"].ToString());	//6
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["remarks"].ToString());			//7
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["cabin_id"].ToString());		//8
                        this.lvwPatientInfo.Items.Add(lItem);
                    }
                }
            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                PatientBLL patientBLL = new PatientBLL();
                DataSet ds = patientBLL.PatientInfofordoctor(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblName.Visible = true;
                    lblReferredDoctor.Visible = true;
                    lblRegID.Visible = true;
                    lblPatientName.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblPatinetRegNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    lblPatientDoctor.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblDate.Text = ds.Tables[0].Rows[0][3].ToString();
                }
            }
            catch
            {
            }
        }

        private void cmbFloor_Click(object sender, EventArgs e)
        {
            try
            {
                lblName.Visible = false;
                lblReferredDoctor.Visible = false;
                lblRegID.Visible = false;
                lblPatientName.Text = "";
                lblPatinetRegNo.Text = "";
                lblPatientDoctor.Text = "";
                lblDate.Text = "";
            }
            catch
            {
            }
        }

           
       
     }
}