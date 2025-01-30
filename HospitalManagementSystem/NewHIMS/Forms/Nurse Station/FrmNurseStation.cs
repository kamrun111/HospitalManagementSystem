using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Nurse_Station.Regular_Checkup;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Nurse_Station;

namespace NewHIMS.Forms.Nurse_Station
{
    public partial class FrmNurseStation : BaseForm.FrmBase
    {
        private int _prescriptionID = 0;
        private int AdmissionID=0;
        private bool noNeedToContinue = true;
        public FrmNurseStation()
        {
            InitializeComponent();
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
                
        public void refreshContent()
        {
            try
            {
                this.tltToolTip.SetToolTip(this.btnSaveCC, "Click to save regular checkup values.");
                this.tltToolTip.SetToolTip(this.lnkShowRC, "Click to see regular checkup list.");

                FloorBLL floorBLL = new FloorBLL();
                DataSet ds = floorBLL.Getfloors();
                cmbFloor.DataSource = ds.Tables[0];
                cmbFloor.DisplayMember = "floor";
                cmbFloor.ValueMember = "floor_id";

                if (this.cmbFloor.Items.Count > 0)
                {
                    if (ApplicatinLauncher._groupID >=53 && ApplicatinLauncher._groupID <=58)   //gTODO
                    {
                        this.cmbFloor.SelectedIndex = this.cmbFloor.FindString(ApplicatinLauncher._floor);
                        this.cmbFloor.Enabled = false;
                    }
                }
                this.lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            }
            catch
            {
            }
        }

        public void loadPatientInformation()
        {
            try
            {
                this.lvwPatientInfo.Items.Clear();

                if (cmbFloor.SelectedIndex >= 0)
                {
                    AdmissionBLL admissionBLL = new AdmissionBLL();
                    DataSet ds = admissionBLL.GetPatientInfoByFloor(this.cmbFloor.Text.ToString());

                    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                        {
                            ListViewItem lItem = new ListViewItem(" "+ds.Tables[0].Rows[r]["cabin"].ToString());
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_code"].ToString());

                            if (ds.Tables[0].Rows[r]["is_first_reqular_checkup_done"].ToString() == "1")
                            {
                                lItem.SubItems.Add("RECEIVED");
                                lItem.ForeColor = Color.Teal;
                            }
                            else
                            {
                                lItem.SubItems.Add("NOT-RECEIVED");
                                lItem.ForeColor = Color.Maroon;
                            }
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_id"].ToString());
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["is_first_reqular_checkup_done"].ToString());
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["cabin_id"].ToString());
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_id"].ToString());
                            lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_name"].ToString());
                            this.lvwPatientInfo.Items.Add(lItem);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void refreshDataShow(int admnID)
        {
            if (admnID != 0)
            {
               PrescriptionBLL prescriptionBLL =new PrescriptionBLL();
               DataSet ds = prescriptionBLL.GetPresIdByAdmbID(admnID);
               if (ds.Tables[0].Rows.Count>0)
               {
                   if (ds.Tables[0].Rows[0][0].ToString() != "")
                       loadMedicine(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()), admnID);
                   else
                   {
                       this.lvwMedicine.Items.Clear();
                       btnSubmitMedicine.Enabled = false;
                   }
               }
               
               loadTreatement(admnID);
            }
            
            if (this.lvwPatientInfo.SelectedItems.Count > 0)
            {
                this.grpMenu.Enabled = true;
            }
            else
            {
                this.grpMenu.Enabled = false;
            }
            this.lnkShowRC.Enabled = this.grpMenu.Enabled;
           
        }


        private void GrpRemarksVisibility()
        {
            if (lvwPatientInfo.SelectedItems[0].ForeColor == Color.Teal)
                grpRCContainer.Visible = true;
            else
                grpRCContainer.Visible = false;
        }
        
        private void loadTreatement(int admnID)
        {
            try
            {
                VisitTreatementBLL visitTreatementBLL = new VisitTreatementBLL();
                DataSet ds = visitTreatementBLL.VisitTreatementGetByAdmnID(admnID);
                this.AdmissionID = admnID;

                grdTreatement.Rows.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdTreatement.CellValueChanged -= this.grdTreatement_CellValueChanged;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdTreatement.Rows.Add();
                            grdTreatement.Rows[i].Cells["t_type"].Value = ds.Tables[0].Rows[i]["treatment_type"].ToString();
                            grdTreatement.Rows[i].Cells["treatement"].Value = ds.Tables[0].Rows[i]["treatement"].ToString();
                            grdTreatement.Rows[i].Cells["dose"].Value = ds.Tables[0].Rows[i]["dose"].ToString();
                            grdTreatement.Rows[i].Cells["qty"].Value = Convert.ToInt16(ds.Tables[0].Rows[i]["quantity"]);
                            grdTreatement.Rows[i].Cells["procedure"].Value = ds.Tables[0].Rows[i]["application_procedure"].ToString();
                            grdTreatement.Rows[i].Cells["VTID"].Value = ds.Tables[0].Rows[i]["visit_treatement_id"].ToString();
                            grdTreatement.Rows[i].Cells["qty_submitted"].Value = ds.Tables[0].Rows[i]["qty_submitted"].ToString();
                        }
                    grdTreatement.CellValueChanged+=new DataGridViewCellEventHandler(grdTreatement_CellValueChanged);
                }
                else
                {
                    grdTreatement.Rows.Clear();
                    btnSubmitTreatement.Enabled = false;
                }
            }           
            catch
            { 
            }
        }
        
        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbFloor.SelectedValue == null || this.cmbFloor.SelectedValue.ToString() == "-1")
                {
                    return;
                }
                this.loadPatientInformation();
                lvwMedicine.Items.Clear();
                grdTreatement.Rows.Clear();
            }
            catch
            {
            }
        }

        private void FrmNurseStation_Load(object sender, EventArgs e)
        {
            try
            {
                //grdTreatement.CellValueChanged -= this.grdTreatement_CellValueChanged;
                refreshContent();
                //this.cmbRequisitionNo.SelectedIndexChanged -= this.cmbRequisitionNo_SelectedIndexChanged;
                //grdTreatement.CellValueChanged +=new DataGridViewCellEventHandler(grdTreatement_CellValueChanged);
            }
            catch
            { 
            
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            try
            {
                VisitMedicineBLL visitMedicineBLL = new VisitMedicineBLL();
                DataSet ds = visitMedicineBLL.GetNewlyPrescribedFloor();

                if(ds.Tables[0].Rows.Count>0)
                     lblNewlyPrescribedFloor.Text=ds.Tables[0].Rows[0][0].ToString();
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    lblNewlyPrescribedFloor.Text += ", " + ds.Tables[0].Rows[i][0].ToString();                    
                }
                this.lblClock.Text = DateTime.Now.ToString();
            }
            catch
            {
            }
        }

        private void loadMedicine(int presID,int admissionID)
        {
            try
            {
                this.lvwMedicine.Items.Clear();
                if (this.lvwPatientInfo.SelectedItems.Count > 0)
                {
                    this.grpMedicine.Visible = true;
                    if (presID != 0)
                    {
                        this._prescriptionID = presID;
                        AdmissionBLL admissionBLL = new AdmissionBLL();
                        DataSet ds = admissionBLL.GetNurseStationPopulationInfo(presID, admissionID);

                        if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                if(Convert.ToInt32(ds.Tables[0].Rows[i]["time_slots"])<=DateTime.Now.Hour)
                                {
                                    ListViewItem lItem = new ListViewItem(ds.Tables[0].Rows[i]["product"].ToString());
                                    lItem.SubItems.Add(ds.Tables[0].Rows[i]["dose_p_quantity"].ToString());
                                    lItem.SubItems.Add(ds.Tables[0].Rows[i]["intake_sys"].ToString());
                                    lItem.SubItems.Add(ds.Tables[0].Rows[i]["time_slots"].ToString());
                                    lItem.SubItems.Add(ds.Tables[0].Rows[i]["visit_medicine_id"].ToString());
                                    this.lvwMedicine.Items.Add(lItem);
                                }
                            }
                        }
                    }
                }
                else
                {
                    this.grpMedicine.Visible = false;
                }
            }
            catch
            {
            }
        }

        private void btnSubmitTreatement_Click(object sender, EventArgs e)
        {
           try
           {
               
               VisitTreatementBLL visitTreatementBLL = new VisitTreatementBLL();
               VisitTreatement visitTreatement = new VisitTreatement();

               if (grdTreatement.SelectedRows.Count > 0)
               {
                   visitTreatement.visit_treatement_id = Convert.ToInt32(grdTreatement.SelectedRows[0].Cells["VTID"].Value);
                   if (grdTreatement.SelectedRows[0].Cells[0].Value.ToString() == "OT")
                   {
                       OperationNote operationNote = new OperationNote();
                       OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                       operationNote.is_submit = 1;
                       operationNote.admission_id=Convert.ToInt16(lvwPatientInfo.SelectedItems[0].SubItems[3].Text);
                       operationNote.record_modified_by = ApplicatinLauncher._userId;
                       operationNoteBLL.OTSubmit(operationNote);
                       

                   }

               }
               else
               {
                   MessageBox.Show("Select a item from treatement");
               }
               if (grdTreatement.SelectedRows[0].Cells[0].Value.ToString() == "OT")
                   visitTreatement.is_submit = 1;
               else
               {
                   if (grdTreatement.SelectedRows[0].Cells[4].Value == null)
                   {
                       MessageBox.Show("Input Qty Correctly.");
                       return;
                   }
                   if (MessageBox.Show("Do You Want to Delete it from list", "", MessageBoxButtons.YesNo) == DialogResult.No)
                       visitTreatement.is_submit = 0;
                   else
                       visitTreatement.is_submit = 1;
               }
               if (grdTreatement.SelectedRows[0].Cells["qty"].Value!=null)
                    visitTreatement.qty_submitted = Convert.ToDecimal(grdTreatement.SelectedRows[0].Cells["qty"].Value);
               visitTreatement.record_modified_by = ApplicatinLauncher._userId;

               int res = visitTreatementBLL.VisitTreatementSubmitSet(visitTreatement);

               if (res > 0)
               {
                   btnSubmitTreatement.Enabled = false;
                   if (grdTreatement.SelectedRows[0].Cells[0].Value.ToString() == "OT")
                        grdTreatement.Rows.Remove(grdTreatement.SelectedRows[0]);
               }
               loadTreatement(AdmissionID);
               btnSubmitTreatement.Enabled = true;
           }
           catch
           {
           }
        }

        private void btnSaveCC_Click(object sender, EventArgs e)
        {
            if (txtRemarks.Text != "")
            {
                AdmissionBO admissionBO = new AdmissionBO();
                AdmissionBLL admissionBLL = new AdmissionBLL();
                
                admissionBO.nurse_remarks = txtRemarks.Text;
                admissionBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text);
                admissionBLL.UpdateAdmissionNurseRemarks(admissionBO);
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Close();
        }

        private void lnkInOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmRegularCheckupList frmRegularCheckupList = new FrmRegularCheckupList();
                ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmRegularCheckupList);
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    frmRegularCheckupList.RefreshRegularchekup(this, lvwPatientInfo.SelectedItems[0].Text, Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text), lvwPatientInfo.SelectedItems[0].SubItems[1].Text,lvwPatientInfo.SelectedItems[0].SubItems[7].Text);
                }
            }
            catch
            {
            }
        }

        private void lnkIndentMedicine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmPatientMedicineIndentListView frmPatientMedicineIndentListView = new FrmPatientMedicineIndentListView();
                ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmPatientMedicineIndentListView);
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    frmPatientMedicineIndentListView.refreshContent(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text), Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[5].Text));
                }
            }
            catch
            {
            }
         }

        private void lnkIndentInvestigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmPatientInvestigationIndentListView frmPatientInvestigationIndentListView = new FrmPatientInvestigationIndentListView();
                ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmPatientInvestigationIndentListView);
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    frmPatientInvestigationIndentListView.RefreshContent(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text), Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[6].Text));
                }
            }
            catch
            {
            }
        }

        private void btnSubmitMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lvwMedicine.SelectedItems.Count > 0)
                {
                    PatientMedicine patientMedicine = new PatientMedicine();
                    PatientMedicineBLL patientMedicineBLL = new PatientMedicineBLL();
                    VisitMedicine visitMedicine = new VisitMedicine();
                    VisitMedicineBLL visitMedicineBLL = new VisitMedicineBLL();

                    visitMedicine.visit_medicine_id = Convert.ToInt32(lvwMedicine.SelectedItems[0].SubItems[4].Text);
                    visitMedicine.is_submit = 1;
                    visitMedicine.record_modified_by = ApplicatinLauncher._userId;
                    visitMedicineBLL.Updatevisit_medicineAfterSubmit(visitMedicine);
                    this.lvwMedicine.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Select a item from medicine");
                }
            }
            catch
            {
            }
        }

        private void lvwMedicine_Click(object sender, EventArgs e)
        {
            if (lvwMedicine.SelectedItems.Count > 0)
            {
                btnSubmitMedicine.Enabled = true;
            }
            else 
            {
                btnSubmitMedicine.Enabled = false;
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    this.refreshDataShow(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text));
                    GrpRemarksVisibility();
                }
                PatientBLL patientBLL = new PatientBLL();
                DataSet ds = patientBLL.PatientInfofordoctor(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblName.Visible = true;
                    lblReferredDoctor.Visible = true;
                    lblRegID.Visible = true;
                    lblPatientName.Text = ds.Tables[0].Rows[0][0].ToString();
                    lblPatinetRegNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    lblPatientDoctor.Text = ds.Tables[0].Rows[0][1].ToString();
                }
            }
            catch
            {
            }
        }

        private void grdTreatement_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdTreatement.Rows[e.RowIndex].Cells["VTID"].Value != null)
                btnSubmitTreatement.Enabled = true;
            else
                btnSubmitTreatement.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvwPatientInfo.SelectedItems.Count > 0)
            {
                PrintMedicineDetails(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text), Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[5].Text));
            }
        }
        private void PrintMedicineDetails(int admnID, int patientID)
        {
           
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                rptPatientMedicineRec rptCustomersOrders = new rptPatientMedicineRec();
                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", admnID);
                rptCustomersOrders.SetParameterValue("@admission_idR", admnID);
                rptCustomersOrders.SetParameterValue("@cabin_id", patientID);

               

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void grdTreatement_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (this.noNeedToContinue == true)
            {

                this.noNeedToContinue = false;
                return;
            }

            string msg = "";
            DataGridViewRow row = null;
            try
            {
                row = this.grdTreatement.Rows[e.RowIndex];


                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);



                if (e.ColumnIndex == 4)
                {

                    if (valueNumeric <= 0)
                    {
                        msg = "Please provide a valid Order quantity";
                    }
                }

            }
            catch
            {
            }
            finally
            {

                if (msg != "")
                {

                    MessageBox.Show(msg, "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    //row.Cells[e.ColumnIndex].Selected = true;
                    
                }
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
            }
            catch
            {
            }
        }

        //if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != ',' && e.KeyChar != '-')
        //            {
        //                e.Handled = true;
        //            }

        

       

       
    }
}