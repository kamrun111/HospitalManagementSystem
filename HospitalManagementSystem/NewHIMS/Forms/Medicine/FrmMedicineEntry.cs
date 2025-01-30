using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports.Payment;
using NewHIMS.Reports;
using NewHIMS.Reports.OutDoor;
using CrystalDecisions.CrystalReports.Engine;

namespace NewHIMS.Forms.Medicine
{
    public partial class FrmMedicineEntry : BaseForm.FrmBase
    {
        public FrmMedicineEntry()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmMedicineEntry_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshOtherItem();
            }
            catch
            {
            }
        }

        void RefreshOtherItem()
        {
            try
            {

                DataSet ds = cs.GetDataSet("GetIPDInvestigationPopulationInfo");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);
                }

                txtDue.Text = "0";
                txtTotalBill.Text = "0";
                txtAdvance.Text = "0";
                txtDiscount.Text = "0";

            }
            catch
            {
            }

        }

        private void lvwPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtAmount.Text = "0";

                if (this.lvwPatientInfo.SelectedItems.Count > 0)
                {

                    DataSet ds = cs.GetDataSetWithParameter("@admission_id", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text), "GetPatientIssuedMedicine");
                    cs.FillUpListview(lvwPatientOtherItem, ds, 0);
                    this.btnSave.Enabled = true;

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtTotalBill.Text = ds.Tables[1].Rows[0][0].ToString();
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        txtAdvance.Text = ds.Tables[2].Rows[0][0].ToString();
                    }

                    NetPayable();

                }
                
            }
            catch
            {
            }
        }

        void NetPayable()
        {
            try
            {
                decimal netpayble = 0;
                if (txtDiscount.Text == "")
                    txtDiscount.Text = "0.00";
                netpayble = Convert.ToDecimal(Convert.ToDecimal(txtTotalBill.Text) - Convert.ToDecimal(txtDiscount.Text)) - Convert.ToDecimal(txtAdvance.Text);
                txtDue.Text = netpayble.ToString();

                

            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.lvwPatientInfo.SelectedItems.Count == 0)
                {

                    MessageBox.Show("Please select patient first.");
                    this.lvwPatientInfo.Focus();
                    return;
                }
                
                if (double.Parse(this.txtAmount.Text) <= 0)
                {
                    MessageBox.Show("Invalid Amount.");
                    this.txtAmount.Focus();
                    return;
                }

                MedicineIssueBO medicineIssueBO = new MedicineIssueBO();
                MedicineIssueBLL medicineIssueBLL = new MedicineIssueBLL();

                medicineIssueBO.issue_date = Convert.ToDateTime(dtpDate.Value);
                medicineIssueBO.amount = Convert.ToDecimal(txtAmount.Text);
                medicineIssueBO.record_created_by = ApplicatinLauncher._userId;
                medicineIssueBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);

                medicineIssueBLL.MedicineIssueAdd(medicineIssueBO);

                this.lvwPatientInfo_SelectedIndexChanged(null, null);
            }
            catch
            {
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshOtherItem();
            }
            catch
            {
            }
        }




    }
}
