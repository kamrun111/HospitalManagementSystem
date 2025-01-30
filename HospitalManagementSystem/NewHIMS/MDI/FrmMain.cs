using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NewHIMS.Forms.Receiptions.Patients.Admission;
using NewHIMS.Forms.Receiptions;
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
using NewHIMS.Forms.Accounts;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Cabin;
using NewHIMS.Forms.PrintForm;
using NewHIMS.Forms.Receiptions.Doctors_Payment;
using NewHIMS.Forms.Store;
using NewHIMS.Forms.Store.Purchase;
using NewHIMS.Forms.Store.Inventory;
using NewHIMS.Forms.Project;
using NewHIMS.Forms.Receiptions.Certificate;
using NewHIMS.Forms.Dialysis;
using NewHIMS.Forms.Medicine;
using NewHIMS.Forms.ICU;


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
                //this.OpenChildForm(new FrmConfiguration());
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //this.OpenChildForm(new FrmAdmission());
                this.OpenChildForm(new FrmAdmissionMember());
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
                //FrmInvestigation1 frmInvestigation1 = new FrmInvestigation1();
                //frmInvestigation1.MdiParent = this;
                //frmInvestigation1.Show();

                FrmInvestigationWithMember frmInvestigationWithMember = new FrmInvestigationWithMember();
                frmInvestigationWithMember.MdiParent = this;
                frmInvestigationWithMember.Show();
                
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
            this.StatusLabelLoginName.Text = UserName.ToUpper();
            ////AdviceBLL adviceBLL = new AdviceBLL();
            ////DataSet ds = adviceBLL.LoggTime();
            ////if (ds.Tables[0].Rows.Count > 0)
            ////    this.StatusTextLogedDateTime.Text = ds.Tables[0].Rows[0][0].ToString();
            this.StatusTextLogedDateTime.Text = DateTime.Now.ToString("dd MMM, yyyy  hh:mm:ss tt");


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
                //frmReAgentItem.MdiParent = this;
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

        private void tesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTestReportDelivery frmTestReportDelivery = new FrmTestReportDelivery();
               // frmTestReportDelivery.MdiChildren = this;
                frmTestReportDelivery.Show();
                //    FrmReAgentItem frmReAgentItem = new FrmReAgentItem();
                //frmReAgentItem.MdiParent = this;
                //frmReAgentItem.Show();
            }
            catch
            {
            }
        }

        private void patientSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmPatientSearch());
            }
            catch
            {
            }
        }

        private void requisitionDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmRequisitionDelivery());
            }
            catch
            {
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenChildForm(new FrmPurchaseAddEditView());
            }
            catch
            {
            }
        }

        private void purchaseReceivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPurchaseOrderReview frmPurchaseOrderReview = new FrmPurchaseOrderReview();
                frmPurchaseOrderReview.Show();
            }
            catch
            {
            }

        }

        private void indentDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReceiveAddEditView frmReceiveAddEditView = new FrmReceiveAddEditView();
                frmReceiveAddEditView.Show();
            }
            catch
            {
            }
        }

        private void iPDInvestigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInPatientInvestigationOrder frmInPatientInvestigationOrder = new FrmInPatientInvestigationOrder();
                frmInPatientInvestigationOrder.MdiParent = this;
                frmInPatientInvestigationOrder.Show();
            }
            catch
            {
            }
        }

        private void patientBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmBillingNew());
            //FrmBillingNew frmBillingNew = new FrmBillingNew();
            //frmBillingNew.MdiParent = this;
            //frmBillingNew.Show();

        }

        private void adjustDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmDiscountDistribution());
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmDailyExpenditure());

        }

        private void paymentToolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void patientBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmBillingNew());
           
        }

        private void doctorsPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void printAllToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void dischargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDischarge frmDischarge = new FrmDischarge();
            frmDischarge.MdiParent = this;
            frmDischarge.Show();

        }

        private void printExpenditureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpenditurePrint frmExpenditurePrint= new FrmExpenditurePrint();
            frmExpenditurePrint.MdiParent = this;
            frmExpenditurePrint.Show();
        }

        private void collectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FrmCollectionPrint());
        }

        private void doctorPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoctorsBillPayment frmDoctorsBillPayment = new FrmDoctorsBillPayment();
            frmDoctorsBillPayment.MdiParent = this;
            frmDoctorsBillPayment.Show();

        }

        private void collectionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDailyCollection frmDailyCollection = new FrmDailyCollection();
            frmDailyCollection.MdiParent = this;
            frmDailyCollection.Show();
        }

        private void doctorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoctorName frmDoctorName = new FrmDoctorName();
            frmDoctorName.MdiParent = this;
            frmDoctorName.Show();
        }

        private void carExpenditureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogBook frmLogBook = new FrmLogBook();
            frmLogBook.MdiParent = this;
            frmLogBook.Show();
        }

        private void otherItemReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOtherItemReceive frmOtherItemReceive = new FrmOtherItemReceive();
            frmOtherItemReceive.MdiParent = this;
            frmOtherItemReceive.Show();
        }

        private void oTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.OpenChildForm(new FrmOTForNurse());
        }

        private void itemAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductListView frmProductListView = new FrmProductListView();
            frmProductListView.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplierAddEditView frmSupplierAddEditView = new FrmSupplierAddEditView();
            frmSupplierAddEditView.Show();
        }

        private void dataBaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDBBackup frmDBBackup = new FrmDBBackup();
            frmDBBackup.Show();
        }

        private void otherIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOthersIncome frmOthersIncome = new FrmOthersIncome();
            frmOthersIncome.Show();

        }

        private void productLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductLedger frmProductLedger = new FrmProductLedger();
            frmProductLedger.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProject frmProject = new FrmProject();
            frmProject.Show();
        }

        private void projectPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjectPatient frmProjectPatient = new FrmProjectPatient();
            frmProjectPatient.Show();
        }

        private void projectOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjectPatientOTNote FrmProjectPatientOTNote = new FrmProjectPatientOTNote();
            FrmProjectPatientOTNote.Show();
        }

        private void projectDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjectDoctor frmProjectDoctor = new FrmProjectDoctor();
            frmProjectDoctor.Show();
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatientListConsultantwise frmPatientListConsultantwise = new FrmPatientListConsultantwise();
            frmPatientListConsultantwise.Show();
        }

        private void investigationCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvestigationCancel frmInvestigationCancel = new FrmInvestigationCancel();
            frmInvestigationCancel.Show();
        }

        private void investigationCancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInvestigationCancel frmInvestigationCancel = new FrmInvestigationCancel();
            frmInvestigationCancel.Show();
        }

        private void refDoctorChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatientRefDoctor frmPatientRefDoctor = new FrmPatientRefDoctor();
            frmPatientRefDoctor.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMemberList frmMemberList = new FrmMemberList();
            frmMemberList.Show();
        }

        private void patientStatusChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatientStatus frmPatientStatus = new FrmPatientStatus();
            frmPatientStatus.Show();
        }

        private void loanSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoanSlip frmLoanSlip = new FrmLoanSlip();
            frmLoanSlip.Show();
        }

        private void loanSlipPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoanSlipPayment frmLoanSlipPayment = new FrmLoanSlipPayment();
            frmLoanSlipPayment.Show();
        }

        private void chequeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheaqueEntry frmCheaqueEntry = new FrmCheaqueEntry();
            frmCheaqueEntry.Show();
        }

        private void chequePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChequePayment frmChequePayment = new FrmChequePayment();
            frmChequePayment.Show();
        }

        private void chequeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChequeReport frmChequeReport = new FrmChequeReport();
            frmChequeReport.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBank frmBank = new FrmBank();
            frmBank.Show();
        }

        private void deathCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeathCertificate frmDeathCertificate = new FrmDeathCertificate();
            frmDeathCertificate.Show();
        }

        private void birthCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBirthCertificate frmBirthCertificate = new FrmBirthCertificate();
            frmBirthCertificate.Show();
        }

        private void iPDOPDPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHospitalPatientList frmHospitalPatientList = new FrmHospitalPatientList();
            frmHospitalPatientList.Show();
        }

        private void insuranceBillAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsuranceBillAssign frmInsuranceBillAssign = new FrmInsuranceBillAssign();
            frmInsuranceBillAssign.Show();
        }

        private void insuranceBillPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsuranceBillPayment frmInsuranceBillPayment = new FrmInsuranceBillPayment();
            frmInsuranceBillPayment.Show();
        }

        private void oTMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatientMedicine frmPatientMedicine = new FrmPatientMedicine();
            frmPatientMedicine.Show();
            
        }

        private void insuranceBillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsuranceBillReport frmInsuranceBillReport = new FrmInsuranceBillReport();
            frmInsuranceBillReport.Show();
        }

        private void preOperativeCheckListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOTPreCheckList frmOTPreCheckList = new FrmOTPreCheckList();
            frmOTPreCheckList.Show();
        }

        private void insurancePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsurancePatient frmInsurancePatient = new FrmInsurancePatient();
            frmInsurancePatient.Show();
        }

        private void loanSlipReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoanSlipReport frmLoanSlipReport = new FrmLoanSlipReport();
            frmLoanSlipReport.Show();
        }

        private void admissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDialysisPatientAdmission frmDialysisPatientAdmission = new FrmDialysisPatientAdmission();  
            frmDialysisPatientAdmission.Show();
        }

        private void patientBillToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDialysisService frmDialysisService = new FrmDialysisService();
            frmDialysisService.Show();
        }

        private void paymentToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmDialysisPayment frmDialysisPayment = new FrmDialysisPayment();
            frmDialysisPayment.Show();
        }

        private void medicineIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicineEntry frmMedicineEntry = new FrmMedicineEntry();
            frmMedicineEntry.Show();
        }

        private void medicinePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicinePayment frmMedicinePayment = new FrmMedicinePayment();
            frmMedicinePayment.Show();
        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDialysisVoucherEntry frmDialysisVoucherEntry = new FrmDialysisVoucherEntry();
            frmDialysisVoucherEntry.Show();
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDialysisExpenditureReport frmDialysisExpenditureReport = new FrmDialysisExpenditureReport();
            frmDialysisExpenditureReport.Show();
        }

        private void medicineAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDialysisMedicineAdd frmDialysisMedicineAdd = new FrmDialysisMedicineAdd();
            frmDialysisMedicineAdd.Show();
        }

        private void medicineIssueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDialysisMedicineIssue frmDialysisMedicineIssue = new FrmDialysisMedicineIssue();
            frmDialysisMedicineIssue.Show();
        }

        private void iCUAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmICUAdmission frmICUAdmission = new FrmICUAdmission();
            frmICUAdmission.Show();
        }

        private void iCUBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmICUService frmICUService = new FrmICUService();
            frmICUService.Show();
        }

        private void iCUAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmICUAdmission frmICUAdmission = new FrmICUAdmission();
            frmICUAdmission.Show();
        }

        private void iCUBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmICUService frmICUService = new FrmICUService();
            frmICUService.Show();
        }

        private void cCUNICUBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCCUService frmCCUService = new FrmCCUService();
            frmCCUService.Show();
        }

        private void iCUPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmICUPayment frmICUPayment = new FrmICUPayment();
            frmICUPayment.Show();
        }

        private void doctorBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmICUDoctorsPayment frmICUDoctorsPayment = new FrmICUDoctorsPayment();
            frmICUDoctorsPayment.Show();
        }

        private void dischargedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDischargedNote frmDischargedNote = new FrmDischargedNote();
            frmDischargedNote.Show();
        }

        private void bedTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICUCabinTransfer iCUCabinTransfer = new ICUCabinTransfer();
            iCUCabinTransfer.Show();
        }

        
       
    }
}