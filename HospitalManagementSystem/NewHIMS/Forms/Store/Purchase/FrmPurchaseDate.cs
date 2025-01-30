using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports;
using NewHIMS.Reports.Purchase;


namespace NewHIMS.Forms.Store
{
    public partial class FrmPurchaseDate : BaseForm.FrmBase
    {
        int SupplierID;
        int Ptype;
        public FrmPurchaseDate(int SupplierID,int Ptype)
        {
            InitializeComponent();
            this.SupplierID = SupplierID;
            this.Ptype = Ptype;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillUpListview(ListView lvw, DataSet ds, int Tableindex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[Tableindex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[Tableindex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvi.SubItems.Add(dataRow[4].ToString());
                        
                        lvw.Items.Add(lvi);
                    }
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
                if (lvwPurchase.SelectedItems.Count > 0)
                {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new purchaseorder1();


                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;
                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@purchaseID", Convert.ToInt32(lvwPurchase.SelectedItems[0].SubItems[4].Text));
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }
            }
            catch
            {
            }

            //try
            //{
            //    if (lvwPurchase.SelectedIndices.Count <= 0)
            //    {
            //        if (Ptype == 0)
            //        {
            //            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            //            ReportDocument rptCustomersOrders = new PurchaseforSupplier();
            //            //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

            //            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            //            {
            //                tliCurrent = tbCurrent.LogOnInfo;
            //                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
            //                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
            //                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
            //                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
            //                tbCurrent.ApplyLogOnInfo(tliCurrent);
            //            }

            //            DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
            //            DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

            //            rptCustomersOrders.SetParameterValue("@From", From);
            //            rptCustomersOrders.SetParameterValue("@To", To);
            //            rptCustomersOrders.SetParameterValue("@supplierID", SupplierID);
            //            rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

            //            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            //            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            //            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            //            frmGenericReportViewer.Show();
            //        }
            //        else
            //        {
            //            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            //            ReportDocument rptCustomersOrders = new ReagentPurchaseforSupplier();
            //            //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

            //            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            //            {
            //                tliCurrent = tbCurrent.LogOnInfo;
            //                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
            //                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
            //                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
            //                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
            //                tbCurrent.ApplyLogOnInfo(tliCurrent);
            //            }

            //            DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
            //            DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

            //            rptCustomersOrders.SetParameterValue("@From", From);
            //            rptCustomersOrders.SetParameterValue("@To", To);
            //            rptCustomersOrders.SetParameterValue("@supplierID", SupplierID);
            //            rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

            //            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            //            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            //            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            //            frmGenericReportViewer.Show();
            //        }
            //    }
            //    else
            //    {
            //        string purchaseID = lvwPurchase.SelectedItems[0].SubItems[4].Text;
            //        if (Ptype == 0)
            //        {
            //            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            //            ReportDocument rptCustomersOrders = new PurchaseList();
            //            //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

            //            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            //            {
            //                tliCurrent = tbCurrent.LogOnInfo;
            //                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
            //                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
            //                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
            //                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
            //                tbCurrent.ApplyLogOnInfo(tliCurrent);
            //            }

            //            rptCustomersOrders.SetParameterValue("@purchaseID", purchaseID);

            //            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
            //            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            //            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            //            frmGenericReportViewer.Show();
            //        }
            //        else
            //        {
            //            //CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
            //            //ReportDocument rptCustomersOrders = new PurchaseList();
            //            ////// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

            //            //foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
            //            //{
            //            //    tliCurrent = tbCurrent.LogOnInfo;
            //            //    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
            //            //    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
            //            //    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
            //            //    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
            //            //    tbCurrent.ApplyLogOnInfo(tliCurrent);
            //            //}

            //            //rptCustomersOrders.SetParameterValue("@Purchase_No", purchaseNo);

            //            //FrmReportView frmGenericReportViewer = new FrmReportView();
            //            //frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
            //            //frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
            //            //frmGenericReportViewer.Show();
            //        }
            //    }
             
            //}
            //catch
            //{
            //}
        }

        private void dtpToDate_Leave(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                PurchaseBLL purchaseBLL = new PurchaseBLL();
                DataSet ds = purchaseBLL.PurchaseListview(From, To);
                //if (ds != null)
                //{
                //    //if (Ptype == 0)
                //    //{
                //    //    FillUpListview(lvwPurchase, ds, 0);
                //    //}
                //    //else
                //    //{
                //        FillUpListview(lvwPurchase, ds, 1);
                //    //}
                //}

                if (ds.Tables[2].Rows.Count > 0)
                {
                    FillUpListview(lvwPurchase, ds, 2);

                }
            }
            catch
            {
            }
        }

        private void InvoicePrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPurchase.SelectedIndices.Count <= 0)
                {
                    if (Ptype == 0)
                    {
                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new PurchaseforSupplier();
                        //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;
                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }

                        DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                        DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                        rptCustomersOrders.SetParameterValue("@From", From);
                        rptCustomersOrders.SetParameterValue("@To", To);
                        rptCustomersOrders.SetParameterValue("@supplierID", SupplierID);
                        rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
                    else
                    {
                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new ReagentPurchaseforSupplier();
                        //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;
                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }

                        DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                        DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                        rptCustomersOrders.SetParameterValue("@From", From);
                        rptCustomersOrders.SetParameterValue("@To", To);
                        rptCustomersOrders.SetParameterValue("@supplierID", SupplierID);
                        rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
                }
                else
                {
                    string purchaseID = lvwPurchase.SelectedItems[0].SubItems[4].Text;
                    if (Ptype == 0)
                    {
                        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        ReportDocument rptCustomersOrders = new PurchaseListDetail();
                        //// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        {
                            tliCurrent = tbCurrent.LogOnInfo;
                            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                            tbCurrent.ApplyLogOnInfo(tliCurrent);
                        }

                        rptCustomersOrders.SetParameterValue("@purchaseID", purchaseID);

                        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        frmGenericReportViewer.Show();
                    }
                    else
                    {
                        //CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                        //ReportDocument rptCustomersOrders = new PurchaseList();
                        ////// rptCustomersOrders.Load(@"..\..\Reports\Sales\Invoice.rpt");

                        //foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                        //{
                        //    tliCurrent = tbCurrent.LogOnInfo;
                        //    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        //    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                        //    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        //    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        //    tbCurrent.ApplyLogOnInfo(tliCurrent);
                        //}

                        //rptCustomersOrders.SetParameterValue("@Purchase_No", purchaseNo);

                        //FrmReportView frmGenericReportViewer = new FrmReportView();
                        //frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                        //frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                        //frmGenericReportViewer.Show();
                    }
                }

            }
            catch
            {
            }
        }
    }
}