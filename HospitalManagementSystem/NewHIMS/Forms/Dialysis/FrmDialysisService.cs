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
using NewHIMS.Reports.OutDoor;
using CrystalDecisions.CrystalReports.Engine;



namespace NewHIMS.Forms.Dialysis
{
    public partial class FrmDialysisService : Form
    {
        public FrmDialysisService()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmDialysisService_Load(object sender, EventArgs e)
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
                PopulateComboBox(cmbOtherItem, otherItemBLL.Getother_items(), 1, "other_item", "other_item_id");

                this.cmbOtherItem.SelectedIndexChanged += new System.EventHandler(this.cmbOtherItem_SelectedIndexChanged);
                txtprice.Text = "";
                otherItemBLL = null;

                DataSet ds = cs.GetDataSet("GetDialysisPatientInfo");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwPatientInfo, ds, 0);
                }

                txtDue.Text = "0";
                txtTotalBill.Text = "0";
                txtAdvance.Text = "0";
                txtDiscount.Text = "0";

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

                DataSet ds = cs.GetDataSetWithParameter("@admission_id", Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text), "GetPatientOtherItemForDialysis");
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
                netpayble = Convert.ToDecimal(Convert.ToDecimal(txtTotalBill.Text) - Convert.ToDecimal(txtDiscount.Text)) - Convert.ToDecimal(txtAdvance.Text);
                txtDue.Text = netpayble.ToString();

                if (txtDue.Text == "0.00")
                {
                    btnBillSave.Enabled = true;
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
                patientOtherItemBLL.Addpatient_other_itemDialysis(patientOtherItem);

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

        private void NumCheck(KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtQtyPerUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void txtQtyPerUnit_Leave(object sender, EventArgs e)
        {
            if (txtQtyPerUnit.Text == "")
                txtQtyPerUnit.Text = "1";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            NetPayable();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            NetPayable();
        }

        private void btnBillSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (lvwPatientOtherItem.Items.Count > 0)
                {
                    if (txtDue.Text == "0.00")
                    {

                       
                        BillDialysisBLL billDialysisBLL = new BillDialysisBLL();
                        BillDialysisBO billDialysisBO = new BillDialysisBO();

                        billDialysisBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text);
                        billDialysisBO.record_created_by = ApplicatinLauncher._userId;
                        billDialysisBO.bill_amount = Convert.ToDecimal(txtTotalBill.Text);
                        billDialysisBO.paid_amount = Convert.ToDecimal(txtAdvance.Text);
                        billDialysisBO.discount = Convert.ToDecimal(txtDiscount.Text);
                        billDialysisBO.net_amount = Convert.ToDecimal(Convert.ToDecimal(txtTotalBill.Text) - Convert.ToDecimal(txtDiscount.Text));
                        billDialysisBO.patient_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[5].Text);
                        
                        int Result = billDialysisBLL.BillDialysisAdd(billDialysisBO);


                        MessageBox.Show("Data Save Successfully");
                                           
                        
                        if (Result > 0)
                        {
                            PrintBillReport(Result);
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

        public void PrintBillReport(int Result)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new DialysisPatientBill();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@bill_dialysis_id", Result);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
                

            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmDialysisBill frmDialysisBill = new FrmDialysisBill();
            frmDialysisBill.MdiParent = this.MdiParent;
            frmDialysisBill.Show();
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
                ReportDocument rptCustomersOrders = new DialysisPreviewPatientBill();

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
                rptCustomersOrders.SetParameterValue("@ADID", admissionID); //OtherItemDetails
                
                rptCustomersOrders.SetParameterValue("@Total", Convert.ToDecimal(txtTotalBill.Text));
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
