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
using NewHIMS.Reports.ICU;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.DAL;
using System.Data.SqlClient;


namespace NewHIMS.Forms.ICU
{
    public partial class FrmICUService : Form
    {
        public FrmICUService()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmICUService_Load(object sender, EventArgs e)
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

                OtherItemBLL otherItemBLL = new OtherItemBLL();
                this.cmbOtherItem.SelectedIndexChanged -= this.cmbOtherItem_SelectedIndexChanged;
                PopulateComboBox(cmbOtherItem, otherItemBLL.Getother_items(), 2, "other_item", "other_item_id");

                this.cmbOtherItem.SelectedIndexChanged += new System.EventHandler(this.cmbOtherItem_SelectedIndexChanged);
                txtprice.Text = "";
                otherItemBLL = null;

                DataSet ds = cs.GetDataSet("GetICUPatientInfo");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);
                }


                for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
                {
                    int I = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[8].Text);

                    if (I == 1)
                    {
                        lvwPatientInfo.Items[i].ForeColor = Color.Red;

                    }

                }


                txtDue.Text = "0";
                txtTotalBill.Text = "0";
                txtAdvance.Text = "0";
                txtDiscount.Text = "0";

                txtBedCharge.Text = "";
                txtBill.Text = "";
                txtDoctorBill.Text = "";

                cmbOtherItem.SelectedIndex = -1;

                btnBillSave.Enabled = false;

                lvwPatientOtherItem.Items.Clear();

            }
            catch
            {
            }


        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            if (combo.SelectedIndex > 0)
                combo.SelectedIndex = 0;
        }

        private void cmbOtherItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtherItem.SelectedIndex != -1)
            {
                OtherItemBLL otherItemBLL = new OtherItemBLL();
                DataSet ds = otherItemBLL.getunitrate(Convert.ToInt32(((DataRowView)(cmbOtherItem.SelectedItem)).Row[0].ToString()));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtprice.Text = "";
                    txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
        }

        private void lvwPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbOtherItem.Items.Count > 0)
            {
                this.cmbOtherItem.SelectedIndex = 0;
            }
            this.txtQtyPerUnit.Text = "0";

            if (this.lvwPatientInfo.SelectedItems.Count > 0)
            {

                DataSet ds = cs.GetDataSetWithParameter("@admission_id", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text), "GetPatientOtherItemForICU");
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

                if (ds.Tables[3].Rows.Count > 0)
                {
                    txtDoctorBill.Text = ds.Tables[3].Rows[0][0].ToString();
                }

                if (ds.Tables[5].Rows.Count > 0)
                {
                    txtBedCharge.Text = ds.Tables[5].Rows[0][0].ToString();
                }

                if (txtDue.Text == "0.00")
                {
                    btnBillSave.Enabled = true;
                }

                NetPayable();

            }
            else
            {
                this.btnSave.Enabled = false;
            }
        }

        void NetPayable()
        {
            try
            {
                decimal netpayble = 0;
                if (txtDiscount.Text == "")
                    txtDiscount.Text = "0.00";
                netpayble = Convert.ToDecimal(Convert.ToDecimal(txtDiscount.Text) + Convert.ToDecimal(txtAdvance.Text));
                //txtDue.Text = netpayble.ToString();

                decimal total = 0;

                total = Convert.ToDecimal(Convert.ToDecimal(txtTotalBill.Text) + Convert.ToDecimal(txtBedCharge.Text) + Convert.ToDecimal(txtDoctorBill.Text));

                txtBill.Text = total.ToString();

                txtDue.Text = (total - netpayble).ToString();


                if (txtDue.Text == "0.00")
                {
                    btnBillSave.Enabled = true;
                }

            }
            catch
            {
            }
        }

        private void btnBillSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (lvwPatientOtherItem.Items.Count > 0)
                {
                    if (txtDue.Text == "0.00")
                    {


                        BillICUBLL billICUBLL = new BillICUBLL();
                        BillICUBO billICUBO = new BillICUBO();

                        billICUBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                        billICUBO.record_created_by = ApplicatinLauncher._userId;
                        billICUBO.bill_amount = Convert.ToDecimal(txtBill.Text);
                        billICUBO.paid_amount = Convert.ToDecimal(txtAdvance.Text);
                        billICUBO.discount = Convert.ToDecimal(txtDiscount.Text);
                        billICUBO.net_amount = Convert.ToDecimal(Convert.ToDecimal(txtBill.Text) - Convert.ToDecimal(txtDiscount.Text));
                        billICUBO.patient_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[5].Text);

                        billICUBO.other_service = Convert.ToDecimal(txtTotalBill.Text);
                        billICUBO.doctor_bill = Convert.ToDecimal(txtDoctorBill.Text);
                        billICUBO.cabin_charge = Convert.ToDecimal(txtBedCharge.Text);


                        int Result = billICUBLL.BillICUAdd(billICUBO);


                        MessageBox.Show("Data Save Successfully");


                        if (Result > 0)
                        {
                            UpdateBedStatus(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[6].Text));
                            PrintBillReport(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text));
                            RefreshOtherItem();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please Collect Payment First");
                    }

                }

            }
            catch
            {

            }
        }

        void UpdateBedStatus(int cabinID)
        {
            try
            {
                SqlConnection conn = DbHelper.GetOpenConnection();
                SqlCommand cmd;
                string strSQL = "update bed_no set status=1 where bed_no_id='" + cabinID + "'";
                cmd = new SqlCommand(strSQL, conn);
                cmd.ExecuteNonQuery();
                DbHelper.CloseConnection(conn);
            }
            catch
            {
            }
        }

        public void PrintBillReport(int admissionID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ICUPatientDetailsBill();

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
                rptCustomersOrders.SetParameterValue("@ADID", admissionID);
                rptCustomersOrders.SetParameterValue("@ADMID", admissionID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();


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
                if (this.cmbOtherItem.SelectedValue.ToString() == "-1")
                {

                    MessageBox.Show("Please select an item.");
                    this.cmbOtherItem.Focus();
                    return;
                }
                if (double.Parse(this.txtQtyPerUnit.Text) <= 0)
                {
                    MessageBox.Show("Invalid quantity specified.");
                    this.txtQtyPerUnit.Focus();
                    return;
                }

                PatientOtherItem patientOtherItem = new PatientOtherItem();
                PatientOtherItemBLL patientOtherItemBLL = new PatientOtherItemBLL();


                patientOtherItem.other_item_id = Convert.ToInt32(((DataRowView)(cmbOtherItem.SelectedItem)).Row[0].ToString());
                patientOtherItem.qty_per_unit = Convert.ToDecimal(txtQtyPerUnit.Text);
                patientOtherItem.unit_rate = Convert.ToDecimal(txtprice.Text);
                patientOtherItem.record_created_by = ApplicatinLauncher._userId;
                patientOtherItem.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                patientOtherItemBLL.Addpatient_other_itemICU(patientOtherItem);

                this.lvwPatientInfo_SelectedIndexChanged(null, null);
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvwPatientOtherItem.Items.Clear();
            RefreshOtherItem();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                FrmICUBill frmICUBill = new FrmICUBill();
                frmICUBill.MdiParent = this.MdiParent;
                frmICUBill.Show();
            }
            catch
            {
            }
        }

        private void lvwPatientOtherItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientOtherItem.SelectedItems.Count > 0)
                {
                    if (ApplicatinLauncher._GroupName == "Administrator" || ApplicatinLauncher._GroupName == "Accounts")
                    {

                        btnDelete.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("You have no Permission. Please contact with Accounts Department.");
                        return;
                    }
                }
            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientOtherItem.SelectedItems.Count > 0)
                {

                    Delete();

                }
                else
                {
                    MessageBox.Show("Select A Patient From List");
                }

            }
            catch
            {
            }
        }

        void Delete()
        {
            PatientOtherItem patientOtherItem = new PatientOtherItem();
            PatientOtherItemBLL patientOtherItemBLL = new PatientOtherItemBLL();


            patientOtherItem.patient_other_item_id = Convert.ToInt32(lvwPatientOtherItem.SelectedItems[0].SubItems[3].Text);


            int Result = patientOtherItemBLL.Removepatient_other_item(patientOtherItem);

            if (Result > 0)
            {
                MessageBox.Show("Service Deleted Successfully");
                btnDelete.Visible = false;
            }

           
            RefreshOtherItem();

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                int admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ICUPatientPreviewBill();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                //@getAdmissionId subreport
                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);//PatientDetails
                rptCustomersOrders.SetParameterValue("@AD_ID", admissionID); //CabinDetails
                rptCustomersOrders.SetParameterValue("@ADID", admissionID); //OtherItemDetails
                rptCustomersOrders.SetParameterValue("@ADMID", admissionID); // DoctorBillDetails
                rptCustomersOrders.SetParameterValue("@BedCharge", Convert.ToDecimal(txtBedCharge.Text));
                rptCustomersOrders.SetParameterValue("@DoctorBill", Convert.ToDecimal(txtDoctorBill.Text));
                rptCustomersOrders.SetParameterValue("@Service", Convert.ToDecimal(txtTotalBill.Text));
                rptCustomersOrders.SetParameterValue("@Total", Convert.ToDecimal(txtBill.Text));
                rptCustomersOrders.SetParameterValue("@Advance", Convert.ToDecimal(txtAdvance.Text));
                rptCustomersOrders.SetParameterValue("@Due", Convert.ToDecimal(txtDue.Text));


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
