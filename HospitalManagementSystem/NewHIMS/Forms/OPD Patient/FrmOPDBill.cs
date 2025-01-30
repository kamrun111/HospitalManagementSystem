using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NewHIMS.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;
using NewHIMS.Reports.OPDPatient;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;
using NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund;



namespace NewHIMS.Forms.OPD_Patient
{
    public partial class FrmOPDBill : Form
    {
        public FrmOPDBill()
        {
            InitializeComponent();
        }
        private void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

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

        private void FormRefresh()
        {
            OPDBill oPDBill = new OPDBill();
            OPDBillBLL oPDBillBLL = new OPDBillBLL();
            DataSet ds = new DataSet();
            ds = oPDBillBLL.OPDBillGet();
            lvwBill.Items.Clear();
            txtdiscount.Text = "";
            txtNetPayable.Text = "";
            txtRegID.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtVat.Text = "";
            
            FillUpListview(lvwPatientInfo, ds, 0);
        }

        

        private void FrmOPDBill_Load(object sender, EventArgs e)
        {

            FormRefresh();

        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {

                lvwBill.Items.Clear();
                OPDpatientMedicineIndentBLL opdpatientMedicineIndentBLL = new OPDpatientMedicineIndentBLL();
                DataSet da = opdpatientMedicineIndentBLL.getallcharge(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[11].Text));
                if (da.Tables[0].Rows.Count > 0)
                {
                    OPDBill opdBill = new OPDBill();
                    OPDBillBLL opdBillBLL = new OPDBillBLL();
                    
                    opdBill.MedicineBill = Convert.ToDecimal(da.Tables[0].Rows[0][0]);
                    opdBill.HospitalService = Convert.ToDecimal(da.Tables[0].Rows[0][1]);
                    opdBill.PKID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[10].Text);

                    int k = opdBillBLL.updateOPDBILL(opdBill);
                    
                }
                decimal SubTotal;
                decimal Vat;
                decimal Advance;
                Advance = Convert.ToDecimal(lvwPatientInfo.SelectedItems[0].SubItems[12].Text.ToString());
                txtdiscount.Text = "00";
                decimal NetPayable;
                OPDBillBLL oPDBillBLL = new OPDBillBLL();
                string registrationID = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
                DataSet ds = new DataSet();
                //ds = oPDBillBLL.OPDBillGetByRegID(registrationID);
                ListViewItem lvi;
                lvi = lvwBill.Items.Add("OPD Registration Fee");
                lvi.SubItems.Add(lvwPatientInfo.SelectedItems[0].SubItems[7].Text.ToString());
                lvi = new ListViewItem();
                lvi = lvwBill.Items.Add("Medicine Bill");
                lvi.SubItems.Add(da.Tables[0].Rows[0][0].ToString());
                lvi = new ListViewItem();
                lvi = lvwBill.Items.Add("Hospital Service");
                lvi.SubItems.Add((da.Tables[0].Rows[0][1].ToString()));
                SubTotal = Convert.ToDecimal(lvwPatientInfo.SelectedItems[0].SubItems[7].Text.ToString()) + Convert.ToDecimal(da.Tables[0].Rows[0][0]) + Convert.ToDecimal(da.Tables[0].Rows[0][1]);
                Vat = (SubTotal * Convert.ToDecimal(2.25)) / Convert.ToDecimal(100);
                NetPayable = SubTotal + Vat;
                txtSubTotal.Text = Convert.ToString(SubTotal);
                txtVat.Text = Convert.ToString(Vat);
                txtNetPayable.Text = Convert.ToString(NetPayable);
                txtAdvance.Text = lvwPatientInfo.SelectedItems[0].SubItems[12].Text.ToString();
                txtTotal.Text = Convert.ToString(NetPayable - Advance);
            }
            catch
            {
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
          try
            {
                NumCheck(e);
                
            }
            catch 
            {
                
                
            }
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OPDBill oPDBill = new OPDBill();
                OPDBillBLL oPDBillBLL = new OPDBillBLL();
                oPDBill.Discount = Convert.ToDecimal(txtdiscount.Text.ToString());
                oPDBill.Vat = Convert.ToDecimal(txtVat.Text.ToString());
                oPDBill.RegistrationID = lvwPatientInfo.SelectedItems[0].SubItems[1].Text;
                oPDBill.RecordeCreatedBy = ApplicatinLauncher._userId;
                oPDBillBLL.UpdateOPDPatientBiLL(oPDBill);
                MessageBox.Show("Bill Update Bill");
                
            }
            catch 
            {
                
                
            }
           
        }

        private void lvwPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Medicine(int L)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OPDmedicineBill();
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


                rptCustomersOrders.SetParameterValue("@PKID", L);
                rptCustomersOrders.SetParameterValue("@GetPKID", L);
                rptCustomersOrders.SetParameterValue("@opdPKID", L);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();

            }
            catch
            {
            }
        }

        private void otherservices(int L)
        {
            try
            {
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new OPDotherservices();
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


                    rptCustomersOrders.SetParameterValue("@getPKID", L);
                    rptCustomersOrders.SetParameterValue("@pkid", L);

                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
              
            }
            catch
            {
            }
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                if(lvwPatientInfo.SelectedItems.Count>0)
                otherservices(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[11].Text));
                else
                    MessageBox.Show("Select A Patient");
            }
            catch
            {
            }
        }

        private void btnInvestigation_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                    Medicine(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[11].Text));
                else
                    MessageBox.Show("Select A Patient");
            }
            catch
            {
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvwBill.Items.Clear();
            txtdiscount.Text = "";
            txtNetPayable.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
            txtVat.Text = "";
            OPDBill oPDBill = new OPDBill();
            OPDBillBLL oPDBillBLL = new OPDBillBLL();
            DataSet ds = new DataSet();
            ds = oPDBillBLL.OPDBillGetByRegID(txtRegID.Text);
            FillUpListview(lvwPatientInfo, ds, 0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtNetPayable.Text.ToString()) - (Convert.ToDecimal(txtdiscount.Text.ToString()) + Convert.ToDecimal(txtAdvance.Text.ToString())));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    Frmopdotherservice frmopdotherservice = new Frmopdotherservice();
                    frmopdotherservice.load(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[11].Text.ToString()), lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString());
                    frmopdotherservice.ShowDialog();
                }
                else
                    MessageBox.Show("Select A Patient");

            }
            catch
            {
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void PrintOPDBiLL(string RegistrationID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptOPDBiLL();
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


                rptCustomersOrders.SetParameterValue("@RegistrationID", RegistrationID);
                rptCustomersOrders.SetParameterValue("@OPDRegistrationID", RegistrationID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();

            }
            catch
            {
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnOt_Click(object sender, EventArgs e)
        {
            PrintOPDBiLL(lvwPatientInfo.SelectedItems[0].SubItems[1].Text);

        }


    }
}