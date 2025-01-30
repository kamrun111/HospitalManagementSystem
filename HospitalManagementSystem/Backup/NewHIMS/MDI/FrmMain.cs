using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NewHIMS.Forms.Receiptions.Patients.Admission;
using NewHIMS.Forms.Receiptions.Patients;
using NewHIMS.Forms.Receiptions.Cabin_Transfer;
using NewHIMS.Forms.Receiptions.Other_Item;
using NewHIMS.Forms.Investigation;
using NewHIMS.Forms.Investigation.Investigation_Item;
using NewHIMS.Forms.Doctor_Station;
using NewHIMS.Forms.Doctor_Station.ConultantList;
using NewHIMS.Forms;
using NewHIMS.Forms.Configuration;
using NewHIMS.Forms.Nurse_Station;
using NewHIMS.Forms.Nurse_Station.Refundmedecine;
using NewHIMS.Forms.Nurse_Station.Medecine_Refund;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;
using NewHIMS.Forms.Nurse_Station.Receive_Medicine;
using NewHIMS.Forms.Outdoor;
using NewHIMS.Forms.Login;
using NewHIMS.Forms.Receiptions.Test_Report_Delivery;
using NewHIMS.Forms.Receiptions.Payment;
using NewHIMS.Forms.Receiptions.Bill;
using NewHIMS.Forms.Receiptions.DoctorsBill;
using NewHIMS.Forms.Otshedule;
using NewHIMS.Forms.ReqisitionHIMS;
using NewHIMS.Forms.Receiptions.Remarks;
using NewHIMS.Forms.OPD_Patient;
using NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Cabin;
using NewHIMS.Forms.PrintForm;
using NewHIMS.Forms.Receiptions.Doctors_Payment;


namespace NewHIMS.MDI
{
    public partial class FrmMain : Form
    {
        public static List<Form> _aliveForm = new List<Form>();
        private static string _userName;
        public static string UserName
        {
            get
            {               
                return _userName;
            }
        }

        public FrmMain(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        //Begin: Added by Md. Tariqul Islam Sarker Dated: 29-Nov-2008
        public void OpenChildForm(NewHIMS.Forms.BaseForm.FrmBase childForm)
        {
            foreach (Form existChildForm in this.MdiChildren)
            {
                if (existChildForm.Name == childForm.Name)
                {
                    childForm.Close();
                    existChildForm.BringToFront();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();            
        }
        //End:  Dated: 29-Nov-2008

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.OpenChildForm(new FrmConfiguration());
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmAdmission());
            }
            catch
            {
            }
        }

        private void patientSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmPatientSearch());
            }
            catch
            {
            }
        }

        private void cabinTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.OpenChildForm(new FrmCabinTransfer());
        }

        private void patientInvestigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInvestigation1 frmInvestigation1 = new FrmInvestigation1();
                frmInvestigation1.MdiParent = this;
                frmInvestigation1.Show();
                
            }
            catch
            {
            }
        }

        private void issueIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvestigationItemIndent frmInvestigationItemIndent = new FrmInvestigationItemIndent();
            frmInvestigationItemIndent.MdiParent = this;
            frmInvestigationItemIndent.Show();
        }

        private void doctorStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmDoctorStation());
                //FrmDoctorStation frmDoctorStation = new FrmDoctorStation();
                //frmDoctorStation.MdiParent = this;
                //frmDoctorStation.Show();
            }
            catch
            {
            }
        }

        private void pathologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSampleCollectionPathologyListView frmSampleCollectionPathologyListView = new FrmSampleCollectionPathologyListView();
                this.OpenChildForm(frmSampleCollectionPathologyListView);
                frmSampleCollectionPathologyListView.RefreshContent("Pathology");

                //FrmSampleCollectionPathologyListView frmSampleCollectionPathologyListView = new FrmSampleCollectionPathologyListView();
                //frmSampleCollectionPathologyListView.MdiParent = this;
                //frmSampleCollectionPathologyListView.Show();
                //frmSampleCollectionPathologyListView.RefreshContent("Pathology");
            }
            catch
            {
            }
        }

        private void defineItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvestigationItemAddEditView frmInvestigationItemAddEditView = new FrmInvestigationItemAddEditView();
            frmInvestigationItemAddEditView.MdiParent = this;
            frmInvestigationItemAddEditView.Show();
        }

        private void otherServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmPatientOtherItemAddEditView());
            }
            catch
            {
            }
        }
        
        private void consultantListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmConsultantList());
                //FrmConsultantList frmConsultantList = new FrmConsultantList();
                //frmConsultantList.MdiParent = this;
                //frmConsultantList.Show();
            }
            catch
            {
            }
        }

        private void nurseStationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmNurseStation());
        }

        private void outdoorBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmOutdoorBooking());
        }

        private void outdoorPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new frmOutdoorPatient());
        }

        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmUserCreation());
        }

        private void userGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.OpenChildForm(new FrmUserGroupCreation());
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.MdiParent = this;
            frmChangePassword.Show();
        }

        private void requisitionOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmRequisition());
        }

        private void xRayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmSampleCollectionPathologyListView frmSampleCollectionPathologyListView = new FrmSampleCollectionPathologyListView();
                frmSampleCollectionPathologyListView.MdiParent = this;
                frmSampleCollectionPathologyListView.Show();
                frmSampleCollectionPathologyListView.RefreshContent("X-Ray");
            }
            catch
            {
            }

        }

        private void uSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSampleCollectionPathologyListView frmSampleCollectionPathologyListView = new FrmSampleCollectionPathologyListView();
            frmSampleCollectionPathologyListView.MdiParent = this;
            frmSampleCollectionPathologyListView.Show();
            frmSampleCollectionPathologyListView.RefreshContent("USG");
        }

        private void eCGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSampleCollectionPathologyListView frmSampleCollectionPathologyListView = new FrmSampleCollectionPathologyListView();
            frmSampleCollectionPathologyListView.MdiParent = this;
            frmSampleCollectionPathologyListView.Show();
            frmSampleCollectionPathologyListView.RefreshContent("ECG");
        }

        private void pathologyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvestigationTestListView frmInvestigationTestListView = new FrmInvestigationTestListView();
            frmInvestigationTestListView.MdiParent = this;
            frmInvestigationTestListView.Show();
            frmInvestigationTestListView.RefreshContent("Pathology");
        }

        private void xRayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvestigationTestListView frmInvestigationTestListView = new FrmInvestigationTestListView();
            frmInvestigationTestListView.MdiParent = this;
            frmInvestigationTestListView.Show();
            frmInvestigationTestListView.RefreshContent("X-Ray");
        }

        private void uSGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvestigationTestListView frmInvestigationTestListView = new FrmInvestigationTestListView();
            frmInvestigationTestListView.MdiParent = this;
            frmInvestigationTestListView.Show();
            frmInvestigationTestListView.RefreshContent("USG");
        }

        private void eCGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvestigationTestListView frmInvestigationTestListView = new FrmInvestigationTestListView();
            frmInvestigationTestListView.MdiParent = this;
            frmInvestigationTestListView.Show();
            frmInvestigationTestListView.RefreshContent("ECG");
        }

        private void testReportDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmTestReportDelivery());
                //FrmTestReportDelivery frmUserGroup = new FrmTestReportDelivery();
                //frmUserGroup.MdiParent = this;
                //frmUserGroup.Show();
            }
            catch
            {
            }
        }

        private void oTBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmOtshedule());
        }

        private void requisitonReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.OpenChildForm(new FrmRequisitionReceive());
        }

        private void remarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.OpenChildForm(new FrmRemarks());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ////this.StatusLabelLoginName.Text = UserName.ToUpper();
            ////AdviceBLL adviceBLL = new AdviceBLL();
            ////DataSet ds = adviceBLL.LoggTime();
            ////if (ds.Tables[0].Rows.Count > 0)
            ////    this.StatusTextLogedDateTime.Text = ds.Tables[0].Rows[0][0].ToString();
            //////this.StatusTextLogedDateTime.Text = DateTime.Now.ToString("dd MMM, yyyy  hh:mm:ss tt");


            ////FrmConsultantList frmConsultantList = new FrmConsultantList();

            ////frmConsultantList.Show();
            ////frmConsultantList.MdiParent = this;
            //DisableMenuStrip1();           
            //////foreach(ToolStripMenuItem xx in menuStrip1.Items)
            ////////for (int i = 0; i < menuStrip1.Items.Count; i++)
            //////{
            //////    //DisableMenuStrip(menuStrip1.Items[i]);
            //////    DisableMenuStrip(xx);  
            //////}

            //SetMenuPermission();
            //string ss = this.menuStrip1.Items[7].Text ;
             
        }


        private void DisableMenuStrip1()
        {
            //int n=0;
            //foreach (object obj in this.Controls )
            //{
            //    if (obj is ToolStripItem) ++n;
            //    if (obj is ToolStripItem) ++n;
            //}
            //MessageBox.Show(n.ToString());
            //for (int i = 0; i < menuStrip1.Items.Count; i++)
            //{
              //  this.toolsToolStripMenuItem.Enabled = false;
                //menuStrip1.Items[i].Enabled = false;
            //}
        }
        
        private void DisableMenuStrip(ToolStripMenuItem mnustrip)
        {
            /*if(mnustrip.DropDown.Items.Count==0)mnustrip.Enabled = false;
            else
            foreach (ToolStripMenuItem submnustrip in mnustrip.DropDown.Items)            
            {
                DisableMenuStrip(submnustrip);
            }*/
            //////if(mnustrip.Name == m_mnuname)mnustrip.Enabled = false;
            //////else
            //////foreach (ToolStripMenuItem submnustrip in mnustrip.DropDown.Items)            
            //////{
            //////    DisableMenuStrip(submnustrip);
            //////}
            
        }

        private void oTNurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmOTNurse());
                //FrmOTNurse frmOTNurse = new FrmOTNurse();
                //frmOTNurse.MdiParent = this;
                //frmOTNurse.ShowDialog();
            }
            catch
            {
            }
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmPayment());
                //FrmPayment frmPayment = new FrmPayment();
                //frmPayment.MdiParent = this;
                //frmPayment.Show();
            }
            catch { }
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmBill());
                //FrmBill frmBill = new FrmBill();
                //frmBill.MdiParent = this;
                //frmBill.Show();
            }
            catch
            {
            }
        }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRefund frmRefund = new FrmRefund();
            frmRefund.MdiParent = this;
            frmRefund.Show();
        }

        private void doctorsBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDoctorsBill frmDoctorsBill = new FrmDoctorsBill();
            frmDoctorsBill.MdiParent = this;
            frmDoctorsBill.Show();
        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PatientList();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void otherServicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOtherItemSummary frmOtherItemSummary = new FrmOtherItemSummary();
            frmOtherItemSummary.MdiParent = this;
            frmOtherItemSummary.Show();
        }

        private void refundMedecineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmMedecineFerund(1));//1 for nurse station
                //FrmMedecineFerund frmMedecineFerund = new FrmMedecineFerund();
                //frmMedecineFerund.MdiParent = this;
                //frmMedecineFerund.Show();
            }
            catch
            {
            }
        }

        private void patientConsultantListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatientList frmPatientList = new FrmPatientList();
            frmPatientList.MdiParent = this;
            frmPatientList.Show();
        }

        private void reAgentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmPrintAll frmPrintAll = new FrmPrintAll();
                frmPrintAll.MdiParent = this;
                frmPrintAll.Show();
            }
            catch
            {
            }
        }

        private void otherItemIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPatientOtherItemAddEditView frmfatientOtherItemAddEditView = new FrmPatientOtherItemAddEditView();
                frmfatientOtherItemAddEditView.MdiParent = this;
                frmfatientOtherItemAddEditView.Show();
            }
            catch
            {
            }
        }

        private void dailyPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDailyPatientList frmDailyPatientList = new FrmDailyPatientList();
                frmDailyPatientList.MdiParent = this;
                frmDailyPatientList.Show();
            }
            catch
            {
            }
        }

        private void dailyPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDailyPatientList frmDailyPatientList = new FrmDailyPatientList();
                frmDailyPatientList.MdiParent = this;
                frmDailyPatientList.Show();
            }
            catch
            {
            }
        }

        private void medicineRefundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmMedecineFerund(2));//2 for OT station
            }
            catch
            {
            }
        }

        private void medicineReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdischargedmedicinereceive frmdischargedmedicinereceive = new Frmdischargedmedicinereceive();
            //frmdischargedmedicinereceive.MdiParent = this;
            frmdischargedmedicinereceive.ShowDialog();
        }

        private void oTMedicineReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOtMedicineReceive frmOtMedicineReceive = new FrmOtMedicineReceive();
            //frmdischargedmedicinereceive.MdiParent = this;
            frmOtMedicineReceive.ShowDialog();

        }

        private void reAgentItemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmReAgentItem frmReAgentItem = new FrmReAgentItem();
                frmReAgentItem.MdiParent = this;
                frmReAgentItem.Show();
            }
            catch
            {
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvestigationitemADD frmInvestigationitemADD = new FrmInvestigationitemADD();
            frmInvestigationitemADD.ShowDialog();
        }

        private void oPDAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOPDAdmission frmOPDAdmission = new FrmOPDAdmission();
                frmOPDAdmission.ShowDialog();
            }
            catch
            {
            }
        }

        private void oPDBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOPDBill frmOPDBill = new FrmOPDBill();
                frmOPDBill.ShowDialog();
            }
            catch
            {
            }

        }

       

        private void oPDDoctorStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOPDDoctorStation frmOPDDoctorStation = new frmOPDDoctorStation();
                frmOPDDoctorStation.Show();


            }
            catch
            {
            }

        }

        private void oPDPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOPDPayment frmOPDPayment = new FrmOPDPayment();
            frmOPDPayment.Show();
        }

        private void oPDOTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOPDOT frmOPDOT = new FrmOPDOT();
                frmOPDOT.ShowDialog();
            }
            catch
            {
            }
        }

        private void doctorsPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoctorsPayment frmDoctorsPayment = new FrmDoctorsPayment();
                frmDoctorsPayment.Show();
            }
            catch
            {
            }
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDoctor_sPay frmDoctor_sPay = new FrmDoctor_sPay();
                frmDoctor_sPay.Show();
            }
            catch
            {
            }

        }

      
       
    }
}