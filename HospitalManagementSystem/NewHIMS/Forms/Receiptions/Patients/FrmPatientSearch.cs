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
using NewHIMS.Reports.Patient;

namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmPatientSearch : BaseForm.FrmBase
    {
        int PatientID = 0;

        public FrmPatientSearch()
        {
            InitializeComponent();
        }

        private void radioByHospitalID_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioByAddress.Checked == true)
                    lblSearchBy.Text = "Address";
                else if (rdoPatientID.Checked == true)
                    lblSearchBy.Text = "Patient ID";
                else if (radioPatientName.Checked == true)
                    lblSearchBy.Text = "Patient Name";
                else
                    lblSearchBy.Text = "Mobile No";
                refreshes();
            }
            catch { 
            }
        }

        private void txtSearchBy_KeyUp(object sender, KeyEventArgs e)
       {
            try{
               
               if (e.KeyData == Keys.Enter)
                {
                    PatientBLL patientBLL = new PatientBLL();
                    DataSet ds = new DataSet(); 
                    if (txtSearchBy.Text != "")
                    {
                        
                        if (lblSearchBy.Text == "Mobile No")
                            ds = patientBLL.OPDGetPtientSearch("@mobile_no", txtSearchBy.Text.ToString(), "OPDSearchByMobileNo",0);
                        else if (lblSearchBy.Text == "Address")
                            ds = patientBLL.OPDGetPtientSearch("@mobile_no", txtSearchBy.Text.ToString(), "OPDSearchByMobileNo", 1);
                        else if (lblSearchBy.Text == "Patient Name")
                            ds = patientBLL.OPDGetPtientSearch("@mobile_no", txtSearchBy.Text.ToString(), "OPDSearchByMobileNo", 2);
                        else if (lblSearchBy.Text == "Patient ID")//patientcode
                            ds = patientBLL.OPDGetPtientSearch("@mobile_no", txtSearchBy.Text.ToString(), "OPDSearchByMobileNo", 3);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            lvwpatientSearch.Items.Clear();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                ListViewItem lvi = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][1].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][3].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][4].ToString());
                                
                                lvwpatientSearch.Items.Add(lvi); 
                            }
                            txtSearchBy.Enabled = false;
                      
                        }
                        
                    }
                }
            }
            catch{
            }
        }

        private void lvwpatientSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwpatientSearch.SelectedItems.Count > 0)
                {
                    PatientID=Convert.ToInt32(lvwpatientSearch.SelectedItems[0].Text);
                    txtName.Text = lvwpatientSearch.SelectedItems[0].SubItems[2].Text.ToString();
                    txtPatientCode.Text = lvwpatientSearch.SelectedItems[0].SubItems[1].Text.ToString();
                }
            }
            catch
            {
            }

        }

        void refreshes()
        {
            txtSearchBy.Text = "";
            txtPatientCode.Text = "";
            txtName.Text = "";
            lvwpatientSearch.Items.Clear();
            txtSearchBy.Enabled = true;
            txtSearchBy.Focus();
            lvwpatientSearch.Columns[3].Text = "Patient Address";
            lvwpatientSearch.Columns[4].Text = "C_Phone";
            
        }
        void radiobuttonrefresh()
        {
            this.rdoInvestigation.CheckedChanged -= this.rdoInvestigation_CheckedChanged;
            rdoInvestigation.Checked = false;
            rdoConsultation.Checked = false;
            rdoServices.Checked = false;
            rdoIDcard.Checked = false;
            this.rdoInvestigation.CheckedChanged += new System.EventHandler(this.rdoInvestigation_CheckedChanged); //new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

     

        private void btnClose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               this.Close();
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                refreshes();
                radiobuttonrefresh();
            }
            catch
            {
                
              
            }
        }

        private void rdoPatientID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioByAddress.Checked == true)
                lblSearchBy.Text = "Address";
            else if (rdoPatientID.Checked == true)
                lblSearchBy.Text = "Patient ID";
            else if (radioPatientName.Checked == true)
                lblSearchBy.Text = "Patient Name";
            else
                lblSearchBy.Text = "Mobile No";
            refreshes();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoInvestigation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPatientCode.Text != "")
                {
                    DataSet ds = null;
                    if (rdoInvestigation.Checked == true)
                    {
                    }
                    else if (rdoConsultation.Checked == true)
                    {
                        ConsultationBLL consultationBLL = new ConsultationBLL();
                        ds = consultationBLL.getconsultation(PatientID);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            lvwpatientSearch.Columns[3].Text = "MR NO";
                            lvwpatientSearch.Columns[4].Text = "Order NO";
                            FillUpListview(lvwpatientSearch, ds);
                        }
                        else
                        {
                            MessageBox.Show("No Data Found");
                            return;
                        }
                    }
                    else if (rdoServices.Checked == true)
                    {

                        OtherserviceBLL otherserviceBLL = new OtherserviceBLL();
                        ds = otherserviceBLL.getservices(Convert.ToInt32(PatientID));
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            lvwpatientSearch.Columns[3].Text = "MR NO";
                            lvwpatientSearch.Columns[4].Text = "Order NO";
                            FillUpListview(lvwpatientSearch, ds);
                        }
                        else
                        {
                            MessageBox.Show("No Data Found");
                            return;
                        }

                    }
                    else if (rdoPatientID.Checked == true)
                    {
                        patientprint(PatientID);
                    }
                    else
                        MessageBox.Show("Select A Option");


                }
                else
                {
                    this.rdoInvestigation.CheckedChanged -= this.rdoInvestigation_CheckedChanged;
                    MessageBox.Show("Select A Patient First");
                    this.rdoInvestigation.CheckedChanged += new System.EventHandler(this.rdoInvestigation_CheckedChanged); //new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
                }
            }
            catch
            {
            }
        }

        void patientprint(int patientID)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;

                ReportDocument rptCustomersOrders = new PatientIDCard(); 

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@PatientID",patientID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void rdoIDcard_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (txtPatientCode.Text == "")
                {
                    MessageBox.Show("Select A Patient First");
                    return;
                }
            }
            catch
            {
            }
        }

        //void PrintInestigationReport(int investigationID)
        //{
        //    try
        //    {
        //        InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
        //        DataSet ds = investigationOrderBLL.OrdernoGet(investigationID);

        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            int OrderId = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
        //            CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
        //            ReportDocument rptCustomersOrders = new InvestigationInvoice();

        //            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
        //            {
        //                tliCurrent = tbCurrent.LogOnInfo;

        //                tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
        //                tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
        //                tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
        //                tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
        //                tbCurrent.ApplyLogOnInfo(tliCurrent);
        //            }

        //            rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
        //            rptCustomersOrders.SetParameterValue("@order_no", OrderId);

        //            FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
        //            frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
        //            frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
        //            frmGenericReportViewer.Show();
        //        }

        //    }
        //    catch
        //    {
        //    }
        //}

        

      

    }

}