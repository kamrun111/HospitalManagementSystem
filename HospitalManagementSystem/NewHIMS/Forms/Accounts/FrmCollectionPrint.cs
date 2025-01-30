using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Collection;
using NewHIMS.Reports.Balance;
using NewHIMS.Reports.Investigation;
using NewHIMS.Reports.OutDoor;

namespace NewHIMS.Forms.Accounts
{
    public partial class FrmCollectionPrint : BaseForm.FrmBase
    {
        public FrmCollectionPrint()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                if (chksummaryreport.Checked == true)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DateWiseCollectionSummary();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }
                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else if ((chkDoctorPaymentReport.Checked == true))
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DateWiseDoctorPaymentBill();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }
                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else if((chkdoctorbillreport.Checked == true))
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DateWisedoctorbill();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }
                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else if ((chkDoctorPaymentBalance.Checked == true))//uuuuuuuuuuu
                {
                    DoctorsPaymentBLL doctorsPaymentBLL = new DoctorsPaymentBLL();
                    DataSet ds = doctorsPaymentBLL.RptDoctorPaymentBalance(From,To);
                    decimal doctorCollection=0, doctorPayment = 0;
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        doctorCollection = Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
                        doctorPayment= Convert.ToDecimal(ds.Tables[1].Rows[0][0]);
                    }
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new RptDoctorPaymentBalance();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@doctorCollection", doctorCollection);
                    rptCustomersOrders.SetParameterValue("@doctorPayment", doctorPayment);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else if ((chkBloodBank.Checked == true))
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new DateWiseBloodBankReport();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }
                    rptCustomersOrders.SetParameterValue("@From", From);
                    rptCustomersOrders.SetParameterValue("@To", To);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
                else
                {
                    
                    ExpenditureOrderBLL expenditureOrderBLL = new ExpenditureOrderBLL();
                    DataSet ds = expenditureOrderBLL.Collection(From, To);
                    decimal Advanced = 0;
                    decimal Pathology = 0;
                    decimal XRay = 0;
                    decimal USG = 0;
                    decimal ECG = 0;
                    decimal OutdoorCollection = 0;
                    decimal Collection = 0;//@from
                    decimal DoctorFee = 0;

                    decimal Vaccine = 0;
                    decimal OutDoor = 0;
                    decimal BloodBank = 0;
                    decimal Ambulance = 0;
                    decimal Biopsy = 0;
                    decimal OutDoorOT = 0;
                    decimal Others = 0;
                    decimal OutDoorDiscount = 0;
                    decimal TubeAndNiddle = 0;


                    Advanced = Convert.ToDecimal(ds.Tables[0].Rows[0][0]) - Convert.ToDecimal(ds.Tables[20].Rows[0][0]);
                    Pathology = Convert.ToDecimal(ds.Tables[1].Rows[0][0]) - Convert.ToDecimal(ds.Tables[8].Rows[0][0]);
                    XRay = Convert.ToDecimal(ds.Tables[2].Rows[0][0]) - Convert.ToDecimal(ds.Tables[9].Rows[0][0]);
                    USG = Convert.ToDecimal(ds.Tables[3].Rows[0][0]) - Convert.ToDecimal(ds.Tables[10].Rows[0][0]);
                    ECG = Convert.ToDecimal(ds.Tables[4].Rows[0][0]) - Convert.ToDecimal(ds.Tables[11].Rows[0][0]);
                    OutdoorCollection = Convert.ToDecimal(ds.Tables[5].Rows[0][0]);
                    TubeAndNiddle = Convert.ToDecimal(ds.Tables[21].Rows[0][0]);
                    DoctorFee = Convert.ToDecimal(ds.Tables[22].Rows[0][0]);

                    Vaccine = Convert.ToDecimal(ds.Tables[12].Rows[0][0]);
                    OutDoor = Convert.ToDecimal(ds.Tables[13].Rows[0][0]);
                    BloodBank = Convert.ToDecimal(ds.Tables[14].Rows[0][0]);
                    Ambulance = Convert.ToDecimal(ds.Tables[15].Rows[0][0]);
                    Biopsy = Convert.ToDecimal(ds.Tables[16].Rows[0][0]);
                    OutDoorOT = Convert.ToDecimal(ds.Tables[18].Rows[0][0]);
                    Others = Convert.ToDecimal(ds.Tables[17].Rows[0][0]);
                    OutDoorDiscount = Convert.ToDecimal(ds.Tables[19].Rows[0][0]);

                    Collection = Advanced + Pathology + XRay + USG + ECG + OutdoorCollection + TubeAndNiddle;

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new Collectionsummary1();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }
                    rptCustomersOrders.SetParameterValue("@from", From);
                    rptCustomersOrders.SetParameterValue("@to", To);

                    rptCustomersOrders.SetParameterValue("@Advanced", Advanced);
                    rptCustomersOrders.SetParameterValue("@Pathology", Pathology);
                    rptCustomersOrders.SetParameterValue("@XRay", XRay);
                    rptCustomersOrders.SetParameterValue("@USG", USG);
                    rptCustomersOrders.SetParameterValue("@ECG", ECG);
                    rptCustomersOrders.SetParameterValue("@OutdoorCollection", OutdoorCollection);
                    rptCustomersOrders.SetParameterValue("@Collection", Collection);//
                    rptCustomersOrders.SetParameterValue("@TubeAndNiddle", TubeAndNiddle);
                    rptCustomersOrders.SetParameterValue("@DoctorFee", DoctorFee);

                    rptCustomersOrders.SetParameterValue("@Vaccine", Vaccine);
                    rptCustomersOrders.SetParameterValue("@OutDoor", OutDoor);
                    rptCustomersOrders.SetParameterValue("@BloodBank", BloodBank);
                    rptCustomersOrders.SetParameterValue("@Ambulance", Ambulance);
                    rptCustomersOrders.SetParameterValue("@Biopsy", Biopsy);
                    rptCustomersOrders.SetParameterValue("@OutDoorOT", OutDoorOT);
                    rptCustomersOrders.SetParameterValue("@Others", Others);
                    rptCustomersOrders.SetParameterValue("@OutDoorDiscount", OutDoorDiscount);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Income = 0;
                decimal Expenditure = 0;
                decimal OtherIncome = 0;
                decimal Balance = 0;
                decimal TotalIncome = 0;
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);
                ExpenditureOrderBLL expenditureOrderBLL = new ExpenditureOrderBLL();
                DataSet ds = expenditureOrderBLL.Balance(From, To);
                if (ds.Tables[0].Rows.Count > 0)
                    Income = Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
                if (ds.Tables[1].Rows.Count > 0)
                    Expenditure = Convert.ToDecimal(ds.Tables[1].Rows[0][0]);
                if (ds.Tables[2].Rows.Count > 0)
                    OtherIncome = Convert.ToDecimal(ds.Tables[2].Rows[0][0]); 
                TotalIncome = Income + OtherIncome;
                Balance = TotalIncome - Expenditure;

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new BalanceNew();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@From", From);//income
                rptCustomersOrders.SetParameterValue("@To", To);//income
                rptCustomersOrders.SetParameterValue("@income", Income);
                rptCustomersOrders.SetParameterValue("@Expenditure", Expenditure);
                rptCustomersOrders.SetParameterValue("@OtherIncome", OtherIncome);
                rptCustomersOrders.SetParameterValue("@TotalIncome", TotalIncome); 
                rptCustomersOrders.SetParameterValue("@Balance", Balance);
                rptCustomersOrders.SetParameterValue("@From1", From);
                rptCustomersOrders.SetParameterValue("@To1", To);
                
                

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
               
            }
            catch
            {
            }
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new BalancePatient();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void btndiscount_Click(object sender, EventArgs e)
        {
            try
            {
                IPDDiscountPatientReport();
                IPDDiscountPatientNewReport();

            }
            catch
            {
            }
        }
            
      void  IPDDiscountPatientReport()
      {
            
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new discount_patient();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();

            }
            catch
            {
            }
        }

      void IPDDiscountPatientNewReport()
      {

          try
          {
              DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
              DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

              CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
              ReportDocument rptCustomersOrders = new discount_patient_new();

              foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
              {
                  tliCurrent = tbCurrent.LogOnInfo;
                  tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                  tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                  tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                  tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                  tbCurrent.ApplyLogOnInfo(tliCurrent);
              }

              rptCustomersOrders.SetParameterValue("@From", From);
              rptCustomersOrders.SetParameterValue("@To", To);

              FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
              frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
              frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
              frmGenericReportViewer.Show();

          }
          catch
          {
          }
      }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new BalancePatientNew();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }


        private void btnDaily_Click(object sender, EventArgs e)
        {
            try
            {
                InvestigationDiscountPercentageReport();
                OutdoorDiscountPercentage();

            }
            catch
            {
            }
        }

        void InvestigationDiscountPercentageReport()
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new InvestigationDiscountPercentageReportUserName(); //BilledPatient

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        void OutdoorDiscountPercentage()
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OutdoorDiscountPercentage();   //BilledPatient

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

      
    }
}
