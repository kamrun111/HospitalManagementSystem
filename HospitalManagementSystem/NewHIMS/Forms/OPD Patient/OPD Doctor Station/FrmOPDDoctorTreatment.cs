using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BusinessObjects;
using HIMS.BLL;
using NewHIMS.Reports.OPDPatient;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;

namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    public partial class FrmOPDDoctorTreatment : Form
    {
        public string PrescriptionID;
        public FrmOPDDoctorTreatment()
        {
            InitializeComponent();
        }
        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem((i+1).ToString());
                    for (int j = 0; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);

                }
            }
        }
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            if (combo.SelectedIndex >= 0)
                combo.SelectedIndex =-1;
        }
        public void populatePatientInfo(string PatientName, string RegID, string Address, string RescriptionID, string ConsultantName)
        {
            txtPatientName.Text = PatientName;
            txtOPDRegNo.Text = RegID;
            txtAddress.Text = Address;
            lblPrescriptionID.Text = RescriptionID;
            txtConsultant.Text = ConsultantName;
            this.Show();
        }

        private void FrmOPDDoctorTreatment_Load(object sender, EventArgs e)
        {
            try
            {
                AdviceBLL adviceBLL = new AdviceBLL();
                DataSet dsadvice = adviceBLL.Getadvices();
                OPDPatientBLL oPDPatientBLL=new OPDPatientBLL();
                OPDPrescriptionBLL oPDPrescriptionBLL = new OPDPrescriptionBLL();
                DataSet ds = new DataSet();
                DataSet dspre = new DataSet();
                DataSet dss = new DataSet();
                dspre = oPDPrescriptionBLL.GetOPDPrescriptionInfo(Convert.ToInt32(lblPrescriptionID.Text));
                ds=oPDPatientBLL.GetOPDCategory();
                dss = oPDPrescriptionBLL.treatment_procedureGetAll();
               
                if (dsadvice != null)
                {
                    PopulateComboBox(cmbAdvice, dsadvice, 0, "advice", "advice_id");
                }
                if (dss != null)
                {
                    PopulateComboBox(cmbOTName, dss, 0, "treatement", "treatement_id");
                }
                this.cmbCatagory.SelectedIndexChanged -= this.cmbCatagory_SelectedIndexChanged;
                PopulateComboBox(cmbCatagory, ds, 0, "product_category", "product_category_id");
                cmbCatagory.Text = "<Select>";
                this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
                if (dspre != null)
                {
                    if (dspre.Tables[0].Rows.Count > 0)
                    {
                        cmbOTName.Text = dspre.Tables[0].Rows[0][0].ToString();
                        txtOTProcedure.Text = dspre.Tables[0].Rows[0][1].ToString();

                        FillUpListview(lvwMedicine, dspre, 1);
                        FillUpListview(lvwAdvice, dspre, 2);
                    }

                }
            }
            catch 
            {
                
               
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lvwAdvice.Items.Count;
                ListViewItem lvi = new ListViewItem(Convert.ToString(i + 1));
                lvi.SubItems.Add(cmbAdvice.Text.ToString());
                lvwAdvice.Items.Add(lvi);
            }
            catch 
            {
                
               
            }
        }

        private void btnMedicineAdd_Click(object sender, EventArgs e)
        {
            try 
	        {
                int j=lvwMedicine.Items.Count;
                ListViewItem lvi1 = new ListViewItem(Convert.ToString(j+1));
                lvi1.SubItems.Add(Convert.ToString(cmbCatagory.Text + "-" + cmbMedicine.Text));
                lvi1.SubItems.Add(txtDoseQuantity.Text);
                lvi1.SubItems.Add(txtDuration.Text);
                lvwMedicine.Items.Add(lvi1);
	        }
	        catch 
	        {
		
		
	        }
            
        }

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatagory.SelectedIndex != -1)
            {
                RequisitionBLL requisitionBLL = new RequisitionBLL();
                int i = Convert.ToInt32(cmbCatagory.SelectedValue.ToString());
                DataSet ds = requisitionBLL.Productlist(Convert.ToInt32(cmbCatagory.SelectedValue.ToString()));
                PopulateComboBox(cmbMedicine, ds, 1, "product", "product_id");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbOTName.SelectedIndex > 0)
                {
                    OperationNoteBLL OperationNoteBLL = new OperationNoteBLL();
                    DataSet ds = OperationNoteBLL.getprocedureforOT(Convert.ToInt16(this.cmbOTName.SelectedValue.ToString()));
                    if (ds.Tables[0].Rows.Count > 0)
                        txtOTProcedure.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtOTProcedure.Text!="")
                {
                OPDMedication oPDMedication = new OPDMedication();
                OPDAdvice oPDAdvice = new OPDAdvice();
                OPDOTTreatmentProcedure oPDOTTreatmentProcedure = new OPDOTTreatmentProcedure();
                OPDPrescriptionBLL oPDPrescriptionBLL = new OPDPrescriptionBLL();
                oPDOTTreatmentProcedure.OTTreatmentProcedure = txtOTProcedure.Text.ToString();
                oPDOTTreatmentProcedure.PrescriptionID = Convert.ToInt32(lblPrescriptionID.Text);
                oPDOTTreatmentProcedure.OTName = cmbOTName.Text.ToString();
                oPDOTTreatmentProcedure.RecordeCreatedBy = ApplicatinLauncher._userId;
                oPDPrescriptionBLL.AddOPDOTTreatmentProcedure(oPDOTTreatmentProcedure);
                oPDPrescriptionBLL.DeleteOPDMedication(Convert.ToInt32(lblPrescriptionID.Text));
                oPDPrescriptionBLL.DeleteOPDAdvice(Convert.ToInt32(lblPrescriptionID.Text));
                for (int i = 0; i < lvwMedicine.Items.Count; i++)
                {
                    oPDMedication.MedicineName = cmbMedicine.Text;
                    oPDMedication.PrescriptionID = Convert.ToInt32(lblPrescriptionID.Text);
                    oPDMedication.DoseQuantity = (lvwMedicine.Items[i].SubItems[2].Text);
                    oPDMedication.Duration = (lvwMedicine.Items[i].SubItems[3].Text);
                    oPDPrescriptionBLL.AddOPDMedication(oPDMedication);
                }
                for (int j = 0; j < lvwAdvice.Items.Count; j++)
                {
                    oPDAdvice.Advice = (lvwAdvice.Items[j].SubItems[1].Text);
                    oPDAdvice.PrescriptionID = Convert.ToInt32(lblPrescriptionID.Text);
                    oPDAdvice.RecordeCreatedBy = ApplicatinLauncher._userId;
                    oPDPrescriptionBLL.AddOPDAdvice(oPDAdvice);
                }
                MessageBox.Show("Data Save Successfully");
                }
                else
                {
                    MessageBox.Show("Please Fillup OT Treatment Procedure");
                }
            }
            catch 
            {
                
               
            }
           
        }
        private void PrintPresription(string RegistrationID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new rptOPDPrescription();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPresription(txtOPDRegNo.Text.ToString());
        }
    }
}