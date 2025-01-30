using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;
using NewHIMS.Reports.Admission;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Payment;
using NewHIMS.Reports.Doctor_Station.Discharge;
using NewHIMS.Reports.Bill;
using NewHIMS.Reports.OtherService;
using NewHIMS.Reports.Invoices;
using NewHIMS.Reports.Nurse_Station;
using NewHIMS.Reports.Cabin;
using NewHIMS.Reports.Discharge;
using NewHIMS.Reports.Investigation;

namespace NewHIMS.Forms.PrintForm
{
    public partial class FrmPrintAll : BaseForm.FrmBase
    {
        public FrmPrintAll()
        {
            InitializeComponent();
        }
        private int AdmissionID=0;

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            //combo.Text = "<Select>";
            
        }

        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            try
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
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error3");
            }
        }

        private void txtHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar==13)
                {
                    if (txtHospitalID.Text != "")
                    {
                        int k=1;
                        if (chkAdmittedPatientOnly.Checked == true)
                            k = 0;
                        PatientBLL patientBLL=new PatientBLL();
                        DataSet ds = patientBLL.GetPatientinfo(Convert.ToInt16(txtHospitalID.Text),k);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            FillUpListview(lvwPatientInfo, ds, 0);
                            txtPatientName.Text = ds.Tables[1].Rows[0][0].ToString();
                            txtGuardianName.Text = ds.Tables[1].Rows[0][1].ToString();
                            txtAddress.Text = ds.Tables[1].Rows[0][2].ToString();
                            txtCPhone.Text = ds.Tables[1].Rows[0][3].ToString();
                            txtHospitalID.Enabled = false;
                            chkAdmittedPatientOnly.Enabled = false;
                            
                        }
                        else
                            MessageBox.Show("No Data Found");
                    }
                }

            }
            catch
            { 
            }
            
        }

        private void lnkSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHospitalID.Text = "";
            txtHospitalID.Enabled= true;
            txtHospitalID.ReadOnly = false;
            txtHospitalID.Focus();
            txtPatientName.Text = "";
            txtGuardianName.Text = "";
            txtAddress.Text = "";
            txtCPhone.Text = "";
            chkAdmittedPatientOnly.Enabled = true;
            lvwPatientInfo.Items.Clear();
        }

        private void btnadmissionPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    if (rdoAdmission.Checked == true)
                    {
                        //label5.Text = "Admission Print";
                        PrintAdmissionReport(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text), Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text), 0);

                    }
                    if (rdoDischarge.Checked == true)
                    {
                        discharge("Discharge Reprint", AdmissionID);
                        //if (Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[3].Text)==1)
                        //    PrintDischarge();
                        //else
                        //    MessageBox.Show("No Data Found");
                    }
                    if (rdoBill.Checked == true)
                    {
                     
                        PrintBillSummary(AdmissionID);

                    }
                    if (rdoPament.Checked == true)
                    {
                        if (cmbPayment.Text == "")
                            MessageBox.Show("No Data Found");
                        else
                            PrintInvoice();
                    }
                    if (rdootheritem.Checked == true)
                    {
                        PatienOtherservice();
                    }
                    if (rdodoctorBill.Checked == true)
                    {
                        DoctorsBill();
                    
                    }
                    if (rdoInvoice.Checked == true)
                    {
                        if (cmbInvoice.Text == "")
                            MessageBox.Show("No Data Found");
                        else
                            printIpd();
                    }
                    if (rdoMedicine.Checked == true)
                    {
                        MedicineDetails();

                    }
                    if (rdocabin.Checked == true)
                    {
                        Cabininfo();
                    }

                    if (rdoInvestigationReport.Checked == true)
                        PrintInvestigatonReport(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                }
                else
                    MessageBox.Show("Seleact Hospital ID from the List");
            }
            catch
            {
            }
        }

        private void PrintInvestigatonReport(int admissionID)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;

                ReportDocument rptCustomersOrders = new RptPatientInvestigationReport();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admissionID", admissionID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

       private  void PrintAdmissionReport(int admissionID, int caseNO, int PAYID)
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
       public void Cabininfo()
       {
           try
           {
               CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
               ReportDocument rptCustomersOrders = new CabinTransferePrint();

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

               FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
               frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
               frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
               frmGenericReportViewer.Show();
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
                rptCustomersOrders.SetParameterValue("@payID", Convert.ToInt32(cmbPayment.Text));
                //rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName); 

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }//rptPatienOtherservice.rpt

        public void PatienOtherservice()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptPatienOtherservice();

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
                rptCustomersOrders.SetParameterValue("@case_no", Convert.ToInt16(lvwPatientInfo.SelectedItems[0].Text));
                rptCustomersOrders.SetParameterValue("@GetAdmissionID", AdmissionID); 

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }//rptPat
        private void discharge(string code, int k)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DischargeReport();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@admission_idD", k);
                rptCustomersOrders.SetParameterValue("@dischargeparameter", code);
                rptCustomersOrders.SetParameterValue("@admiss_id", k);
                rptCustomersOrders.SetParameterValue("@admission_id", k);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
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

                {
                  
                    rptCustomersOrders.SetParameterValue("@admission_id", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idRD", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idD", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idM", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idI", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idT", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idot", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@weightadmissionID", this.AdmissionID);
                    rptCustomersOrders.SetParameterValue("@admission_idA", this.AdmissionID);
                  

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

        private void PrintBillSummary(int admissionID)
        {
            try
            {
                txtEquation.Text = "";
                BillBLL billBLL = new BillBLL();
                DataSet dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                if (dsbill.Tables[7].Rows.Count > 0)
                {
                    txtEquation.Text = "( " + Convert.ToDecimal(dsbill.Tables[7].Rows[0][2].ToString()) + " X" + Convert.ToInt32(dsbill.Tables[7].Rows[0][3].ToString());
                    for (int i = 1; i < dsbill.Tables[7].Rows.Count; i++)
                    {
                        txtEquation.Text = txtEquation.Text + " +" + Convert.ToDecimal(dsbill.Tables[7].Rows[i][2].ToString()) + " X" + Convert.ToInt32(dsbill.Tables[7].Rows[i][3].ToString());
                    }
                    txtEquation.Text = txtEquation.Text + " )";
                }
                string eq = txtEquation.Text;
                string sn = txtSerialNo.Text;
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PatientDetailsBill();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);// doctorbill details
                rptCustomersOrders.SetParameterValue("@admission_idOS", admissionID);// Other item
                rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);// detail investigation
                rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);//loan detail 
                rptCustomersOrders.SetParameterValue("@admissionID", admissionID);
                rptCustomersOrders.SetParameterValue("@SerialNO", sn);
                rptCustomersOrders.SetParameterValue("@Eeuation", eq);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
                dsbill = null;
            }
            catch
            {
            }
        }
        private void DoctorsBill()
        {
            try
            {
                //decimal vb = Convert.ToDecimal(txtVistDoctor.Text);
                //decimal ob = Convert.ToDecimal(txtOtDoctor.Text);
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new MoneyReceiptforDoctorsBill();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@DBAdmissionID", AdmissionID);
                rptCustomersOrders.SetParameterValue("@admission_id", AdmissionID);
                rptCustomersOrders.SetParameterValue("@AdmissionID", AdmissionID);
                rptCustomersOrders.SetParameterValue("@getAdmissionId", AdmissionID);
                rptCustomersOrders.SetParameterValue("@Admission_Idget", AdmissionID);
                rptCustomersOrders.SetParameterValue("@cotAdmission_ID", AdmissionID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }
        private void MedicineDetails()
        {
            try
            {
                //decimal vb = Convert.ToDecimal(txtVistDoctor.Text);
                //decimal ob = Convert.ToDecimal(txtOtDoctor.Text);
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new Medicinedetails();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@admissionID", AdmissionID);
                rptCustomersOrders.SetParameterValue("@admission_id", AdmissionID);
                rptCustomersOrders.SetParameterValue("@GetadmissionID", AdmissionID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }


        private void cmbAdmissionList_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnPaymentPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPayment.SelectedIndex != -1)
                {
                    
                    PrintInvoice(Convert.ToInt32(cmbPayment.Text));

                }
            }
            catch
            { }
                
 
        }
        public void PrintInvoice(int payID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new PaymentInvoice2();

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
                rptCustomersOrders.SetParameterValue("@payID", payID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    cmbPayment.DataSource = null;
                    cmbInvoice.DataSource = null;
                    if (chkAdmittedPatientOnly.Checked == true)
                        rdoAdmission.Checked = true;
                    else
                        rdoBill.Checked = true;
                    AdmissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                    PatientBLL patientBLL=new PatientBLL();
                    DataSet da= patientBLL.getallpayment(AdmissionID);
                    if (da.Tables[0].Rows.Count > 0)
                        PopulateComboBox(cmbPayment, da, 0, "pay_id", "admission_id");
                    if (da.Tables[1].Rows.Count > 0)
                        PopulateComboBox(cmbInvoice, da, 1, "invoice_no", "sales_id");
                }
            }
            catch
            {
            }
        }
        private void printIpd()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new Invoice();
                // rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@sales_id", Convert.ToInt16(cmbInvoice.SelectedValue));
                rptCustomersOrders.SetParameterValue("@salesID", Convert.ToInt16(cmbInvoice.SelectedValue));
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

        private void btnInvoicePrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInvoice.Text != "")
                { }

            }
            catch
            {
            }
        }

        private void rdoPament_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwPatientInfo.SelectedItems.Count > 0)
            { 
            
            
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lnkSearch_LinkClicked(null, null);
        }
    }
}