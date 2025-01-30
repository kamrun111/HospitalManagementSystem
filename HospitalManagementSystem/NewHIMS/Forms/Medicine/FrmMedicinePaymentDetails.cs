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
using NewHIMS.Reports.Payment;


namespace NewHIMS.Forms.Medicine
{
    public partial class FrmMedicinePaymentDetails : Form
    {
        public FrmMedicinePaymentDetails()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        string HospitalID;
        public FrmMedicinePaymentDetails(string HospitalID)
        {
            InitializeComponent();
            this.HospitalID = HospitalID;
        }

        private void FrmMedicinePaymentDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (HospitalID != null)
                {
                    txtHospitalID.Text = HospitalID.ToString();
                    txtHospitalID.ReadOnly = true;
                    btnPrint.Focus();
                }
                else
                {
                    txtHospitalID.ReadOnly = false;
                    txtHospitalID.Focus();
                }
            }
            catch
            {
            }
        }

        public void PopulateInfo()
        {
            try
            {

                DataSet ds = cs.GetDataSetWithStringParameter("@HospitalID", txtHospitalID.Text, "PatientlistforPaymentMedicine");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);
                }
                ds = null;
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            { 
                txtHospitalID.Text = "";
                lvwPatientInfo.Clear();
                
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    PopulateInfo();
                    if (rdoDetails.Checked)
                    {
                        btnPrint.Enabled = true;
                        btnPrint.Focus();
                    }
                }
            }
            catch
            {
            }
        }
    }
}
