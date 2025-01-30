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
using NewHIMS.Reports.Bill;
using NewHIMS.Reports.Payment;

namespace NewHIMS.Forms.Receiptions.Bill
{
    public partial class FrmBillingNew : BaseForm.FrmBase //--------------------------done by sami
    {
        public FrmBillingNew()
        {
            InitializeComponent();
        }
        int admissionID = 0;

        private void FrmBillingNew_Load(object sender, EventArgs e)
        {
            RefreshPayment();
        }
        public void RefreshPayment()
        {
            try
            {
                PatientInfo();
                ClearAll();
            }
            catch
            {
                
            }
        }
        private void PatientInfo()
        {
            PayBLL payBLL = new PayBLL();

            DataSet ds = payBLL.PaymentinfoMember();

            lvwPatientInfo.Items.Clear();

            if (ds.Tables[6].Rows.Count > 0)
            {
                FillUpListview(lvwPatientInfo, ds, 6);
            }

            for (int i = 0; i < lvwPatientInfo.Items.Count; i++)
            {
                int I = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[6].Text);

                if (I == 1)
                {
                    lvwPatientInfo.Items[i].ForeColor = Color.Pink;

                }
                int d = Convert.ToInt32(lvwPatientInfo.Items[i].SubItems[4].Text);
                if (d == 1)
                {
                    lvwPatientInfo.Items[i].ForeColor = Color.BlueViolet;
                }
            }

            lvwDue.Items.Clear();
            if (ds.Tables[7].Rows.Count > 0)
            {
                FillUpListview(lvwDue, ds, 7);
            }
        }
        private void FillUpListview(ListView lvw, DataSet ds, int TableIndex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[TableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[TableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lItem = new ListViewItem(dataRow["cabin"].ToString());
                        //ListViewItem lItem = new ListViewItem(" " + ds.Tables[0].Rows[r]["cabin"].ToString());

                        lItem.SubItems.Add(dataRow["patient_code"].ToString());
                        lItem.SubItems.Add(dataRow["admission_id"].ToString());
                        lItem.SubItems.Add(dataRow["patient_name"].ToString());
                        lItem.SubItems.Add(dataRow["is_discharged"].ToString());
                        lItem.SubItems.Add(dataRow["pt_type"].ToString());
                        lItem.SubItems.Add(dataRow["insurance_type"].ToString());
                        lvw.Items.Add(lItem);
                    }
                }
            }
            catch
            {
            }
        }

        public void ClearAll()
        {
            txtadmissionfee.Text = "";
            txtcabincharge.Text = "";
            txtservicecharge.Text = "";
            txtothercharge.Text = "";
            txtloan.Text = "";
            txtinvestigation.Text = "";
            txtdoctorbill.Text = "";
            txtgrandtotal.Text = "";
            txtadvance.Text = "";
            txtrefund.Text = "";
            txtdiscount.Text = "";
            txtNetPayable.Text = "";
            txtRemarks.Text = "";
            btnSave.Text = "Save";
            txtXray.Text = "0.00";
            txtPathology.Text = "0.00";
            txtUsg.Text = "0.00";
            txtEcg.Text = "0.00";
            txtEco.Text = "0.00";
            txtdiscount.Enabled = true;
            txtRemarks.Visible = false;
            lblRemarks.Visible = false;
            chkdiscount.Checked = false;
            btnSave.Enabled = true;
            lvwPatientInfo.Enabled = true;
            lvwDue.Enabled = true;
            textBoxSearchHospitalID.Text = "";
            btndiscount.Enabled = true;
            txtBloodBank.Text = "";
            txtDuration.Text = "";
            //btnAutoDiscount.Enabled = false;
            
           

        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            chkdiscount.Checked = false;
            txtdiscount.Enabled = true;
            btnAutoDiscount.Enabled = true;
            patientlist(lvwPatientInfo);
        }
        void patientlist(ListView lvw)
        {
            try
            {
                ClearAll();
                BillBLL billBLL = new BillBLL();
                DataSet ds = billBLL.populatePatientbill(Convert.ToInt32(lvw.SelectedItems[0].SubItems[2].Text));

                txtadmissionfee.Text = "500.00";

                //investigation
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtinvestigation.Text = ds.Tables[0].Rows[0][0].ToString();
                }

                //doctor bill
                if (ds.Tables[1].Rows.Count > 0)
                {
                    txtdoctorbill.Text = ds.Tables[1].Rows[0][0].ToString();
                }

                //Cabin Charge
                decimal roomrent = 0;
                if (ds.Tables[2].Rows.Count > 0)
                {
                    roomrent = Math.Round(Convert.ToDecimal(ds.Tables[2].Rows[0][0]), 2);
                    txtcabincharge.Text = roomrent.ToString();
                }
                //Cabin service Charge

                if (ds.Tables[3].Rows.Count > 0)
                {
                    decimal roomcharge = Math.Round(Convert.ToDecimal(ds.Tables[3].Rows[0][0]), 2);
                    txtservicecharge.Text = roomcharge.ToString();
                }
                //Other service 

                if (ds.Tables[4].Rows.Count > 0)
                {
                    txtothercharge.Text = ds.Tables[4].Rows[0][0].ToString();
                }

                //Blood Bank

                if (ds.Tables[14].Rows.Count > 0)
                {
                    txtBloodBank.Text = ds.Tables[14].Rows[0][0].ToString();
                }

                //Biopcy 

                if (ds.Tables[15].Rows.Count > 0)
                {
                    txtBiopcy.Text = ds.Tables[15].Rows[0][0].ToString();
                }

                //C Arm 

                if (ds.Tables[16].Rows.Count > 0)
                {
                    txtCArm.Text = ds.Tables[16].Rows[0][0].ToString();
                }

                //OT 

                if (ds.Tables[17].Rows.Count > 0)
                {
                    txtOT.Text = ds.Tables[17].Rows[0][0].ToString();
                }

                //Anastheia

                if (ds.Tables[18].Rows.Count > 0)
                {
                    txtAnestia.Text = ds.Tables[18].Rows[0][0].ToString();
                }

                //GHH Consultation

                if (ds.Tables[19].Rows.Count > 0)
                {
                    txtGhh.Text = ds.Tables[19].Rows[0][0].ToString();
                }

                //Hospital Other Charge

                if (ds.Tables[20].Rows.Count > 0)
                {
                    txtHospital.Text = ds.Tables[20].Rows[0][0].ToString();
                }

                //Post Operative Charge

                if (ds.Tables[21].Rows.Count > 0)
                {
                    txtPostOperative.Text = ds.Tables[21].Rows[0][0].ToString();
                }

                //Stay Duration

                if (ds.Tables[22].Rows.Count > 0)
                {
                    txtDuration.Text = ds.Tables[22].Rows[0][0].ToString();
                }

                //Loan

                if (ds.Tables[5].Rows.Count > 0)
                {
                    txtloan.Text = ds.Tables[5].Rows[0][0].ToString();
                }

                //Advance

                if (ds.Tables[6].Rows.Count > 0)
                {
                    txtadvance.Text = ds.Tables[6].Rows[0][0].ToString();
                }
                //refund
                if (ds.Tables[7].Rows.Count > 0)
                {
                    txtrefund.Text = ds.Tables[7].Rows[0][0].ToString();
                }
                //discount
                if (ds.Tables[8].Rows.Count > 0)
                {
                    txtdiscount.Text = ds.Tables[8].Rows[0][0].ToString();
                    if (ds.Tables[8].Rows[0][1].ToString() != null)
                    {
                        txtRemarks.Text = ds.Tables[8].Rows[0][1].ToString();
                    }
                    else
                        txtRemarks.Text = "";
                }
                if (ds.Tables[9].Rows.Count > 0)
                {
                    txtSerialNo.Text = "( " + ds.Tables[9].Rows[0]["receipt_no"].ToString();
                    for (int i = 1; i < ds.Tables[9].Rows.Count; i++)
                    {
                        txtSerialNo.Text = txtSerialNo.Text + ", " + ds.Tables[9].Rows[i]["receipt_no"].ToString();
                    }
                    txtSerialNo.Text = txtSerialNo.Text + " )";
                }
                if (ds.Tables[10].Rows.Count > 0)//xray
                    txtXray.Text = ds.Tables[10].Rows[0][2].ToString();
                if (ds.Tables[11].Rows.Count > 0)//pathology
                    txtPathology.Text = ds.Tables[11].Rows[0][2].ToString();
                if (ds.Tables[12].Rows.Count > 0)//UCG
                    txtUsg.Text = ds.Tables[12].Rows[0][2].ToString();
                if (ds.Tables[13].Rows.Count > 0)//ECG
                    txtEcg.Text = ds.Tables[13].Rows[0][2].ToString();
                if (ds.Tables[23].Rows.Count > 0)//ECO
                    txtEco.Text = ds.Tables[23].Rows[0][2].ToString();

                
                admissionID = Convert.ToInt32(lvw.SelectedItems[0].SubItems[2].Text);
                Calculategrandtotal();
                btnSave.Enabled = true;


            }
            catch
            {
            }
        }

        void Calculategrandtotal()
        {
            try
            {
                decimal GT =0;
                if (txtadmissionfee.Text != "" || txtcabincharge.Text != "" || txtservicecharge.Text != "" || txtothercharge.Text != "" || txtloan.Text != "" || txtinvestigation.Text != "" || txtdoctorbill.Text != "")
                {
                    GT = Convert.ToDecimal(txtadmissionfee.Text) + Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text) + Convert.ToDecimal(txtloan.Text) + Convert.ToDecimal(txtinvestigation.Text) + Convert.ToDecimal(txtdoctorbill.Text)+ Convert.ToDecimal(txtothercharge.Text);
                }
                txtgrandtotal.Text = GT.ToString();
                NetPayable();
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
                if (txtdiscount.Text == "" )
                    txtdiscount.Text = "0.00";
                netpayble =Convert.ToDecimal(Convert.ToDecimal(txtgrandtotal.Text)- Convert.ToDecimal(txtdiscount.Text)) - Convert.ToDecimal(txtadvance.Text) +Convert.ToDecimal(txtrefund.Text);
                txtNetPayable.Text = netpayble.ToString();

            }
            catch
            {
            }
        }
        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error6");
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    this.NetPayable();

                }
            }
            catch
            {
                MessageBox.Show("Error21");
            }

        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            this.NetPayable();
        }

        private void chkdiscount_Click(object sender, EventArgs e)
        {
            if (chkdiscount.Checked == true)
            {
                lblRemarks.Visible = true;
                txtRemarks.Visible = true;
            }
            else
            {
                lblRemarks.Visible = false;
                txtRemarks.Visible = false ;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PatientInfo();
            ClearAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                 
                if (lvwPatientInfo.SelectedItems.Count > 0 && Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text) == 0)
                {
                    MessageBox.Show("Patient is not discharged");
                    return;
                }

                if (lvwPatientInfo.SelectedItems.Count > 0 && lvwPatientInfo.SelectedItems[0].SubItems[5].Text != "Others")
                {
                    MessageBox.Show("Discount will be Auto Generated");
                    PatientTypeAutoDiscount();
                }

                if (MessageBox.Show("Do you want to Save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
        
                if (lvwPatientInfo.SelectedItems.Count == 0 && lvwDue.SelectedItems.Count > 0 && (Convert.ToDecimal(txtNetPayable.Text) > 0))
                {
                    MessageBox.Show("Please Pay the Amount First");
                    return;
                }
                if (lvwPatientInfo.SelectedItems.Count == 0 && lvwDue.SelectedItems.Count > 0 && (Convert.ToDecimal(txtNetPayable.Text) < 0))
                {
                    MessageBox.Show("Please Refund the Amount First");
                    return;
                }
                decimal value = Convert.ToDecimal(txtdiscount.Text);
                int k = Convert.ToInt32(value);
                if (k>0 && txtRemarks.Text == "")
                {
                    MessageBox.Show("Please Write Remarks");
                    txtRemarks.Visible = true;
                    lblRemarks.Visible = true;
                    txtRemarks.Focus();
                    return;
                }
                BillBO billBO = new BillBO();
                BillBLL billBLL = new BillBLL();
                AdmissionBO admissionBO = new AdmissionBO();
                InpatientAccount  inpatientAccount=new InpatientAccount();
             
                if (txtNetPayable.Text != "")
                {
                    if (txtinvestigation.Text != "")
                        billBO.investigation_fee =Convert.ToDecimal(txtinvestigation.Text);
                    billBO.treatment_fee =0;
                    billBO.ot_fee = 0;
                    billBO.post_operative_fee = 0;
                    billBO.medicine_fee = 0;
                    billBO.admission_fee = Convert.ToDecimal(txtadmissionfee.Text);
                    inpatientAccount.admission_fee = Convert.ToDecimal(txtadmissionfee.Text);
                    inpatientAccount.Pathology = Convert.ToDecimal(txtPathology.Text);
                    inpatientAccount.X_Ray = Convert.ToDecimal(txtXray.Text);
                    inpatientAccount.USG = Convert.ToDecimal(txtUsg.Text);
                    inpatientAccount.ECG = Convert.ToDecimal(txtEcg.Text);
                    inpatientAccount.ECO = Convert.ToDecimal(txtEco.Text);
                    if (txtothercharge.Text != "")
                    {
                        billBO.other_fee = Convert.ToDecimal(txtothercharge.Text);
                        inpatientAccount.other_fee = Convert.ToDecimal(txtothercharge.Text);
                    }
                    if (txtcabincharge.Text != "")
                    {
                        billBO.room_rent = Convert.ToDecimal(txtcabincharge.Text);
                        inpatientAccount.room_rent = Convert.ToDecimal(txtcabincharge.Text);
                    }
                    if (txtservicecharge.Text != "")//cabin service charge
                    {
                        billBO.cabin_service_charge = Convert.ToDecimal(txtservicecharge.Text);
                        inpatientAccount.cabin_service_charge = Convert.ToDecimal(txtservicecharge.Text);
                    }
                    if (txtdoctorbill.Text != "")//doctorsfee
                    {
                        billBO.doctors_fee = Convert.ToDecimal(txtdoctorbill.Text);
                        inpatientAccount.doctors_fee = Convert.ToDecimal(txtdoctorbill.Text);
                    }
                    if (txtloan.Text != "")
                        billBO.loan = Convert.ToDecimal(txtloan.Text);                   
                    admissionBO.record_modified_by = ApplicatinLauncher._userId;
                    if(txtRemarks.Text!="")
                    billBO.remarks = txtRemarks.Text;
                    billBO.paid_amount = Convert.ToDecimal(txtNetPayable.Text);
                    billBO.record_created_by = ApplicatinLauncher._userId;
                    billBO.record_modified_by = ApplicatinLauncher._userId;
                    inpatientAccount.record_created_by = ApplicatinLauncher._userId;
                    if (Convert.ToDecimal(txtdiscount.Text) > 0)
                    {
                        billBO.discount = Convert.ToDecimal(txtdiscount.Text);
                        admissionBO.is_biscount_clear = 1;
                    }
                    else
                        admissionBO.is_biscount_clear = 0;
                    int result = 0;
                    if (btnSave.Text == "Save")
                    {
                        if (lvwPatientInfo.SelectedItems.Count > 0)
                            admissionID = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                        admissionBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                        billBO.admission_id = admissionID;
                        inpatientAccount.admission_id = admissionID;
                        if (lvwPatientInfo.SelectedItems.Count > 0 && txtNetPayable.Text !="0.00")
                            admissionBO.is_bill_clear = 2;//Payment Due
                        else
                            admissionBO.is_bill_clear = 1;//Payment clear
                        if (txtNetPayable.Text == "0.00" && k==0) // nodiscount no due
                        {
                            inpatientAccount.is_done_by_account = 1;
                            result = billBLL.NewBillaccount(billBO, admissionBO, inpatientAccount);// no discount 
                        }
                        else
                        {
                            inpatientAccount.is_done_by_account = 0;
                            result = billBLL.NewBillAdd(billBO, admissionBO, inpatientAccount);// discount
                        }
                    }
                    else
                    {
                        if (lvwDue.SelectedItems.Count > 0)
                            admissionID = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                        inpatientAccount.admission_id = admissionID;
                        admissionBO.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                        billBO.admission_id = admissionID;
                        admissionBO.is_bill_clear = 1;//Payment clear
                        if (k > 0)
                        {
                            inpatientAccount.is_done_by_account = 0;
                            billBLL.NewBillUpdate(billBO, admissionBO);//discount
                        }
                        else
                        {
                            inpatientAccount.is_done_by_account = 1;
                            billBLL.NewBillaccountUpdate(billBO, admissionBO, inpatientAccount);// no discount
                        }
                    }
                    MessageBox.Show("Data Saved Successfully");
                    lvwPatientInfo.Enabled = false;
                    lvwDue.Enabled = false;
                    PrintBillSummary(admissionID);
                    btnSave.Enabled = false;
                }
            }
            catch
            {
            }
        }
        void PrintBillSummary(int admissionID)
        {
            try
            {
                txtEquation.Text = "";
                BillBLL billBLL = new BillBLL();
                 //DataSet  dsbill = billBLL.InvestigationBill(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                DataSet dsbill = billBLL.InvestigationBill(admissionID);
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

        private void lvwDue_Click(object sender, EventArgs e)
        {
            try
            {
                patientlist(lvwDue);
                btnSave.Text = "Receive";
                if (ApplicatinLauncher._GroupName == "Administrator" || ApplicatinLauncher._GroupName == "Accounts")
                    txtdiscount.Enabled = true;
                else
                    txtdiscount.Enabled = false;
                if (txtNetPayable.Text == "0.00")
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
            }
            catch
            {
            }
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            try
            {

                if (lvwPatientInfo.SelectedItems.Count > 0 && Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text) == 0)
                {
                    if (MessageBox.Show("Do you want to Discharge the Patient?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    AdmissionBLL admissionBLL = new AdmissionBLL();
                    admissionBLL.SetDischargeInfo(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].SubItems[2].Text), this.lvwPatientInfo.SelectedItems[0].Text, ApplicatinLauncher._userId);
                    RefreshPayment();

                }
                else
                    return;
            }
            catch
            {
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //PrintPreview(admissionID);
            PrintPreviewNew(admissionID);
            if (Convert.ToDecimal(txtinvestigation.Text) > 0)
            {
                PrintPreviewNew1(admissionID);
            }
        }
        void PrintPreview(int admissionID)
        {
            try
            {
                txtEquation.Text = "";
                
                BillBLL billBLL = new BillBLL();
                DataSet ds = billBLL.IPDPayDetails(admissionID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtEquation.Text = " = " + ds.Tables[0].Rows[0][0].ToString() + " ( " + ds.Tables[0].Rows[0][1].ToString();
                    for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                    {
                        txtEquation.Text = txtEquation.Text + " ) " + " + " + ds.Tables[0].Rows[i][0].ToString() + " ( " + ds.Tables[0].Rows[i][1].ToString();
                    }
                    txtEquation.Text = txtEquation.Text + " ) ";
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    txtCabin.Text = " = " + " ( " + ds.Tables[1].Rows[0][2].ToString() + " X" + ds.Tables[1].Rows[0][5].ToString();
                    for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                    {
                        txtCabin.Text = txtCabin.Text + " + " + ds.Tables[1].Rows[i][2].ToString() + " X" + ds.Tables[1].Rows[i][5].ToString();
                    }
                    txtCabin.Text = txtCabin.Text + " )";
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    txtService.Text = " = " + " ( " + ds.Tables[2].Rows[0][2].ToString() + " X" + ds.Tables[2].Rows[0][5].ToString();
                    for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                    {
                        txtService.Text = txtService.Text + " + " + ds.Tables[2].Rows[i][2].ToString() + " X" + ds.Tables[2].Rows[i][5].ToString();
                    }
                    txtService.Text = txtService.Text + " )";
                }

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new NewBillPreview();

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
                rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details
                rptCustomersOrders.SetParameterValue("@admission_idOS", admissionID);//other service
                rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);//doctorbill
                rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);//loan
                //rptCustomersOrders.SetParameterValue("@admission_idBB", admissionID);//BloodBank
                //

                rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                rptCustomersOrders.SetParameterValue("@Admissionfee", Convert.ToDecimal(txtadmissionfee.Text));
                rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                rptCustomersOrders.SetParameterValue("@Cabin_charge", Convert.ToDecimal(txtcabincharge.Text));
                rptCustomersOrders.SetParameterValue("@ServiceCharge", Convert.ToDecimal(txtservicecharge.Text));
                rptCustomersOrders.SetParameterValue("@othercharge", Convert.ToDecimal(txtothercharge.Text));
                rptCustomersOrders.SetParameterValue("@doctorbill", Convert.ToDecimal(txtdoctorbill.Text));
                rptCustomersOrders.SetParameterValue("@grandtotal", Convert.ToDecimal(txtgrandtotal.Text));
                rptCustomersOrders.SetParameterValue("@loan", Convert.ToDecimal(txtloan.Text));
                rptCustomersOrders.SetParameterValue("@advancd", Convert.ToDecimal(txtadvance.Text));
                rptCustomersOrders.SetParameterValue("@refund", Convert.ToDecimal(txtrefund.Text));
                rptCustomersOrders.SetParameterValue("@NetPayable", Convert.ToDecimal(txtNetPayable.Text));
                rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                rptCustomersOrders.SetParameterValue("@PayDetails", txtEquation.Text);
                rptCustomersOrders.SetParameterValue("@CabinDetails", txtCabin.Text);
                rptCustomersOrders.SetParameterValue("@ServiceDetails", txtService.Text);
                
                

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        void PrintPreviewNew(int admissionID)
        {
            try
            {
                if (Convert.ToDecimal(txtadvance.Text) > (Convert.ToDecimal(txtinvestigation.Text)+Convert.ToDecimal(txtadmissionfee.Text)) && Convert.ToDecimal(txtrefund.Text) > 0)
                {

                    txtEquation.Text = "";

                    BillBLL billBLL = new BillBLL();
                    DataSet ds = billBLL.IPDPayDetails(admissionID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEquation.Text = " = " + ds.Tables[0].Rows[0][0].ToString() + " ( " + ds.Tables[0].Rows[0][1].ToString();
                        for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                        {
                            txtEquation.Text = txtEquation.Text + " ) " + " + " + ds.Tables[0].Rows[i][0].ToString() + " ( " + ds.Tables[0].Rows[i][1].ToString();
                        }
                        txtEquation.Text = txtEquation.Text + " ) ";
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtCabin.Text = " = " + " ( " + ds.Tables[1].Rows[0][2].ToString() + " X" + ds.Tables[1].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtCabin.Text = txtCabin.Text + " + " + ds.Tables[1].Rows[i][2].ToString() + " X" + ds.Tables[1].Rows[i][5].ToString();
                        }
                        txtCabin.Text = txtCabin.Text + " )";
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        txtService.Text = " = " + " ( " + ds.Tables[2].Rows[0][2].ToString() + " X" + ds.Tables[2].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtService.Text = txtService.Text + " + " + ds.Tables[2].Rows[i][2].ToString() + " X" + ds.Tables[2].Rows[i][5].ToString();
                        }
                        txtService.Text = txtService.Text + " )";
                    }

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new NewBillPreviewDetails1();

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
                    //rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details
                    rptCustomersOrders.SetParameterValue("@admission_idOSNew", admissionID);//other service (7)
                    rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);//doctorbill
                    rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);//loan
                    rptCustomersOrders.SetParameterValue("@admission_idBB", admissionID);//BloodBank
                    rptCustomersOrders.SetParameterValue("@admission_idOT", admissionID);//OT
                    //

                    rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                    rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                    rptCustomersOrders.SetParameterValue("@Admissionfee", Convert.ToDecimal(txtadmissionfee.Text));
                    rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@Cabin_charge", Convert.ToDecimal(txtcabincharge.Text));
                    rptCustomersOrders.SetParameterValue("@ServiceCharge", Convert.ToDecimal(txtservicecharge.Text));
                    rptCustomersOrders.SetParameterValue("@othercharge", Convert.ToDecimal(txtHospital.Text));
                    rptCustomersOrders.SetParameterValue("@doctorbill", Convert.ToDecimal(txtdoctorbill.Text));
                    rptCustomersOrders.SetParameterValue("@grandtotal", (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtinvestigation.Text)));
                    rptCustomersOrders.SetParameterValue("@loan", Convert.ToDecimal(txtloan.Text));
                    rptCustomersOrders.SetParameterValue("@advancd", (Convert.ToDecimal(txtadvance.Text) - Convert.ToDecimal(txtinvestigation.Text)));
                    rptCustomersOrders.SetParameterValue("@refund", Convert.ToDecimal(txtrefund.Text));
                    rptCustomersOrders.SetParameterValue("@NetPayable", ((Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtinvestigation.Text)) - (Convert.ToDecimal(txtadvance.Text) - Convert.ToDecimal(txtinvestigation.Text))) - Convert.ToDecimal(txtrefund.Text)-Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                    rptCustomersOrders.SetParameterValue("@OT", Convert.ToDecimal(txtOT.Text));
                    rptCustomersOrders.SetParameterValue("@BloodBank", Convert.ToDecimal(txtBloodBank.Text));
                    rptCustomersOrders.SetParameterValue("@CArm", Convert.ToDecimal(txtCArm.Text));
                    rptCustomersOrders.SetParameterValue("@Biopcy", Convert.ToDecimal(txtBiopcy.Text));
                    rptCustomersOrders.SetParameterValue("@Ghh", Convert.ToDecimal(txtGhh.Text));
                    rptCustomersOrders.SetParameterValue("@Anestia", Convert.ToDecimal(txtAnestia.Text));
                    rptCustomersOrders.SetParameterValue("@PayDetails", txtEquation.Text);
                    rptCustomersOrders.SetParameterValue("@CabinDetails", txtCabin.Text);
                    rptCustomersOrders.SetParameterValue("@ServiceDetails", txtService.Text);
                    rptCustomersOrders.SetParameterValue("@PostOperative", Convert.ToDecimal(txtPostOperative.Text));
                    rptCustomersOrders.SetParameterValue("@Discount", Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@InvestigationDue", Convert.ToDecimal(txtinvestigation.Text) - Convert.ToDecimal(txtinvestigation.Text));


                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }

                else if (Convert.ToDecimal(txtadvance.Text) <= (Convert.ToDecimal(txtinvestigation.Text) + Convert.ToDecimal(txtadmissionfee.Text)) && Convert.ToDecimal(txtrefund.Text) > 0)
                {

                    txtEquation.Text = "";

                    BillBLL billBLL = new BillBLL();
                    DataSet ds = billBLL.IPDPayDetails(admissionID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEquation.Text = " = " + ds.Tables[0].Rows[0][0].ToString() + " ( " + ds.Tables[0].Rows[0][1].ToString();
                        for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                        {
                            txtEquation.Text = txtEquation.Text + " ) " + " + " + ds.Tables[0].Rows[i][0].ToString() + " ( " + ds.Tables[0].Rows[i][1].ToString();
                        }
                        txtEquation.Text = txtEquation.Text + " ) ";
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtCabin.Text = " = " + " ( " + ds.Tables[1].Rows[0][2].ToString() + " X" + ds.Tables[1].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtCabin.Text = txtCabin.Text + " + " + ds.Tables[1].Rows[i][2].ToString() + " X" + ds.Tables[1].Rows[i][5].ToString();
                        }
                        txtCabin.Text = txtCabin.Text + " )";
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        txtService.Text = " = " + " ( " + ds.Tables[2].Rows[0][2].ToString() + " X" + ds.Tables[2].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtService.Text = txtService.Text + " + " + ds.Tables[2].Rows[i][2].ToString() + " X" + ds.Tables[2].Rows[i][5].ToString();
                        }
                        txtService.Text = txtService.Text + " )";
                    }

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new NewBillPreviewDetails1();

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
                    //rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details
                    rptCustomersOrders.SetParameterValue("@admission_idOSNew", admissionID);//other service (7)
                    rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);//doctorbill
                    rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);//loan
                    rptCustomersOrders.SetParameterValue("@admission_idBB", admissionID);//BloodBank
                    rptCustomersOrders.SetParameterValue("@admission_idOT", admissionID);//OT
                    //

                    rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                    rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                    rptCustomersOrders.SetParameterValue("@Admissionfee", Convert.ToDecimal(txtadmissionfee.Text));
                    rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@Cabin_charge", Convert.ToDecimal(txtcabincharge.Text));
                    rptCustomersOrders.SetParameterValue("@ServiceCharge", Convert.ToDecimal(txtservicecharge.Text));
                    rptCustomersOrders.SetParameterValue("@othercharge", Convert.ToDecimal(txtHospital.Text));
                    rptCustomersOrders.SetParameterValue("@doctorbill", Convert.ToDecimal(txtdoctorbill.Text));
                    rptCustomersOrders.SetParameterValue("@grandtotal", (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtinvestigation.Text)));
                    rptCustomersOrders.SetParameterValue("@loan", Convert.ToDecimal(txtloan.Text));
                    rptCustomersOrders.SetParameterValue("@advancd", Convert.ToDecimal(txtadvance.Text));
                    rptCustomersOrders.SetParameterValue("@refund", Convert.ToDecimal(txtrefund.Text));
                    rptCustomersOrders.SetParameterValue("@NetPayable", (Convert.ToDecimal(txtgrandtotal.Text) - (Convert.ToDecimal(txtadvance.Text) - Convert.ToDecimal(txtrefund.Text)))-Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                    rptCustomersOrders.SetParameterValue("@OT", Convert.ToDecimal(txtOT.Text));
                    rptCustomersOrders.SetParameterValue("@BloodBank", Convert.ToDecimal(txtBloodBank.Text));
                    rptCustomersOrders.SetParameterValue("@CArm", Convert.ToDecimal(txtCArm.Text));
                    rptCustomersOrders.SetParameterValue("@Biopcy", Convert.ToDecimal(txtBiopcy.Text));
                    rptCustomersOrders.SetParameterValue("@Ghh", Convert.ToDecimal(txtGhh.Text));
                    rptCustomersOrders.SetParameterValue("@Anestia", Convert.ToDecimal(txtAnestia.Text));
                    rptCustomersOrders.SetParameterValue("@PayDetails", txtEquation.Text);
                    rptCustomersOrders.SetParameterValue("@CabinDetails", txtCabin.Text);
                    rptCustomersOrders.SetParameterValue("@ServiceDetails", txtService.Text);
                    rptCustomersOrders.SetParameterValue("@PostOperative", Convert.ToDecimal(txtPostOperative.Text));
                    rptCustomersOrders.SetParameterValue("@Discount", Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@InvestigationDue", Convert.ToDecimal(txtinvestigation.Text));


                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                
                }

                else if (Convert.ToDecimal(txtadvance.Text) > (Convert.ToDecimal(txtinvestigation.Text)+Convert.ToDecimal(txtadmissionfee.Text)) & Convert.ToDecimal(txtrefund.Text) == 0)
                {

                    txtEquation.Text = "";

                    BillBLL billBLL = new BillBLL();
                    DataSet ds = billBLL.IPDPayDetails(admissionID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEquation.Text = " = " + ds.Tables[0].Rows[0][0].ToString() + " ( " + ds.Tables[0].Rows[0][1].ToString();
                        for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                        {
                            txtEquation.Text = txtEquation.Text + " ) " + " + " + ds.Tables[0].Rows[i][0].ToString() + " ( " + ds.Tables[0].Rows[i][1].ToString();
                        }
                        txtEquation.Text = txtEquation.Text + " ) ";
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtCabin.Text = " = " + " ( " + ds.Tables[1].Rows[0][2].ToString() + " X" + ds.Tables[1].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtCabin.Text = txtCabin.Text + " + " + ds.Tables[1].Rows[i][2].ToString() + " X" + ds.Tables[1].Rows[i][5].ToString();
                        }
                        txtCabin.Text = txtCabin.Text + " )";
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        txtService.Text = " = " + " ( " + ds.Tables[2].Rows[0][2].ToString() + " X" + ds.Tables[2].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtService.Text = txtService.Text + " + " + ds.Tables[2].Rows[i][2].ToString() + " X" + ds.Tables[2].Rows[i][5].ToString();
                        }
                        txtService.Text = txtService.Text + " )";
                    }

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new NewBillPreviewDetails4();

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
                    //rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details
                    rptCustomersOrders.SetParameterValue("@admission_idOSNew", admissionID);//other service (7)
                    rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);//doctorbill
                    rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);//loan
                    rptCustomersOrders.SetParameterValue("@admission_idBB", admissionID);//BloodBank
                    rptCustomersOrders.SetParameterValue("@admission_idOT", admissionID);//OT
                    //

                    rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                    rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                    rptCustomersOrders.SetParameterValue("@Admissionfee", Convert.ToDecimal(txtadmissionfee.Text));
                    rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@Cabin_charge", Convert.ToDecimal(txtcabincharge.Text));
                    rptCustomersOrders.SetParameterValue("@ServiceCharge", Convert.ToDecimal(txtservicecharge.Text));
                    rptCustomersOrders.SetParameterValue("@othercharge", Convert.ToDecimal(txtHospital.Text));
                    rptCustomersOrders.SetParameterValue("@doctorbill", Convert.ToDecimal(txtdoctorbill.Text));
                    rptCustomersOrders.SetParameterValue("@grandtotal", (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtinvestigation.Text)));
                    rptCustomersOrders.SetParameterValue("@loan", Convert.ToDecimal(txtloan.Text));
                    rptCustomersOrders.SetParameterValue("@advancd", (Convert.ToDecimal(txtadvance.Text) - Convert.ToDecimal(txtinvestigation.Text)));
                    rptCustomersOrders.SetParameterValue("@refund", Convert.ToDecimal(txtrefund.Text));
                    rptCustomersOrders.SetParameterValue("@NetPayable", ((Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtinvestigation.Text)) - (Convert.ToDecimal(txtadvance.Text) - Convert.ToDecimal(txtinvestigation.Text))) - Convert.ToDecimal(txtrefund.Text)-Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                    rptCustomersOrders.SetParameterValue("@OT", Convert.ToDecimal(txtOT.Text));
                    rptCustomersOrders.SetParameterValue("@BloodBank", Convert.ToDecimal(txtBloodBank.Text));
                    rptCustomersOrders.SetParameterValue("@CArm", Convert.ToDecimal(txtCArm.Text));
                    rptCustomersOrders.SetParameterValue("@Biopcy", Convert.ToDecimal(txtBiopcy.Text));
                    rptCustomersOrders.SetParameterValue("@Ghh", Convert.ToDecimal(txtGhh.Text));
                    rptCustomersOrders.SetParameterValue("@Anestia", Convert.ToDecimal(txtAnestia.Text));
                    rptCustomersOrders.SetParameterValue("@PayDetails", txtEquation.Text);
                    rptCustomersOrders.SetParameterValue("@CabinDetails", txtCabin.Text);
                    rptCustomersOrders.SetParameterValue("@ServiceDetails", txtService.Text);
                    rptCustomersOrders.SetParameterValue("@PostOperative", Convert.ToDecimal(txtPostOperative.Text));
                    rptCustomersOrders.SetParameterValue("@Discount", Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@InvestigationDue", Convert.ToDecimal(txtinvestigation.Text) - Convert.ToDecimal(txtinvestigation.Text));


                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }

                else if (Convert.ToDecimal(txtadvance.Text) <= (Convert.ToDecimal(txtinvestigation.Text)+Convert.ToDecimal(txtadmissionfee.Text)) && Convert.ToDecimal(txtrefund.Text) == 0)
                {

                    txtEquation.Text = "";

                    BillBLL billBLL = new BillBLL();
                    DataSet ds = billBLL.IPDPayDetails(admissionID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEquation.Text = " = " + ds.Tables[0].Rows[0][0].ToString() + " ( " + ds.Tables[0].Rows[0][1].ToString();
                        for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                        {
                            txtEquation.Text = txtEquation.Text + " ) " + " + " + ds.Tables[0].Rows[i][0].ToString() + " ( " + ds.Tables[0].Rows[i][1].ToString();
                        }
                        txtEquation.Text = txtEquation.Text + " ) ";
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        txtCabin.Text = " = " + " ( " + ds.Tables[1].Rows[0][2].ToString() + " X" + ds.Tables[1].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtCabin.Text = txtCabin.Text + " + " + ds.Tables[1].Rows[i][2].ToString() + " X" + ds.Tables[1].Rows[i][5].ToString();
                        }
                        txtCabin.Text = txtCabin.Text + " )";
                    }

                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        txtService.Text = " = " + " ( " + ds.Tables[2].Rows[0][2].ToString() + " X" + ds.Tables[2].Rows[0][5].ToString();
                        for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                        {
                            txtService.Text = txtService.Text + " + " + ds.Tables[2].Rows[i][2].ToString() + " X" + ds.Tables[2].Rows[i][5].ToString();
                        }
                        txtService.Text = txtService.Text + " )";
                    }

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new NewBillPreviewDetails4();

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
                    //rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details
                    rptCustomersOrders.SetParameterValue("@admission_idOSNew", admissionID);//other service (7)
                    rptCustomersOrders.SetParameterValue("@getAdmissionId", admissionID);//doctorbill
                    rptCustomersOrders.SetParameterValue("@admission_idL", admissionID);//loan
                    rptCustomersOrders.SetParameterValue("@admission_idBB", admissionID);//BloodBank
                    rptCustomersOrders.SetParameterValue("@admission_idOT", admissionID);//OT
                    //

                    rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                    rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                    rptCustomersOrders.SetParameterValue("@Admissionfee", Convert.ToDecimal(txtadmissionfee.Text));
                    rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@Cabin_charge", Convert.ToDecimal(txtcabincharge.Text));
                    rptCustomersOrders.SetParameterValue("@ServiceCharge", Convert.ToDecimal(txtservicecharge.Text));
                    rptCustomersOrders.SetParameterValue("@othercharge", Convert.ToDecimal(txtHospital.Text));
                    rptCustomersOrders.SetParameterValue("@doctorbill", Convert.ToDecimal(txtdoctorbill.Text));
                    rptCustomersOrders.SetParameterValue("@grandtotal", (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(txtinvestigation.Text)));
                    rptCustomersOrders.SetParameterValue("@loan", Convert.ToDecimal(txtloan.Text));
                    rptCustomersOrders.SetParameterValue("@advancd", Convert.ToDecimal(txtadvance.Text));
                    rptCustomersOrders.SetParameterValue("@refund", Convert.ToDecimal(txtrefund.Text));
                    rptCustomersOrders.SetParameterValue("@NetPayable", (Convert.ToDecimal(txtgrandtotal.Text) - (Convert.ToDecimal(txtadvance.Text) - Convert.ToDecimal(txtrefund.Text)))-Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                    rptCustomersOrders.SetParameterValue("@OT", Convert.ToDecimal(txtOT.Text));
                    rptCustomersOrders.SetParameterValue("@BloodBank", Convert.ToDecimal(txtBloodBank.Text));
                    rptCustomersOrders.SetParameterValue("@CArm", Convert.ToDecimal(txtCArm.Text));
                    rptCustomersOrders.SetParameterValue("@Biopcy", Convert.ToDecimal(txtBiopcy.Text));
                    rptCustomersOrders.SetParameterValue("@Ghh", Convert.ToDecimal(txtGhh.Text));
                    rptCustomersOrders.SetParameterValue("@Anestia", Convert.ToDecimal(txtAnestia.Text));
                    rptCustomersOrders.SetParameterValue("@PayDetails", txtEquation.Text);
                    rptCustomersOrders.SetParameterValue("@CabinDetails", txtCabin.Text);
                    rptCustomersOrders.SetParameterValue("@ServiceDetails", txtService.Text);
                    rptCustomersOrders.SetParameterValue("@PostOperative", Convert.ToDecimal(txtPostOperative.Text));
                    rptCustomersOrders.SetParameterValue("@Discount", Convert.ToDecimal(txtdiscount.Text));
                    rptCustomersOrders.SetParameterValue("@InvestigationDue", Convert.ToDecimal(txtinvestigation.Text));


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

        void PrintPreviewNew1(int admissionID)
        {
            try
            {
                if (Convert.ToDecimal(txtadvance.Text) > (Convert.ToDecimal(txtinvestigation.Text) + Convert.ToDecimal(txtadmissionfee.Text)))
                {

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new NewBillPreviewDetails2();

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
                    rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details

                    rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                    rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                    rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@grandtotal", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@NetPayable", Convert.ToDecimal(txtinvestigation.Text));
                    rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);
                    
                    FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                    frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                    frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                    frmGenericReportViewer.Show();
                }

                if (Convert.ToDecimal(txtadvance.Text) <= (Convert.ToDecimal(txtinvestigation.Text)+Convert.ToDecimal(txtadmissionfee.Text)))
                {

                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new NewBillPreviewDetails3();

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
                    rptCustomersOrders.SetParameterValue("@admission_idI", admissionID);//investigatioon details
                    
                    rptCustomersOrders.SetParameterValue("@admission_id", admissionID);
                    rptCustomersOrders.SetParameterValue("@adm_id", admissionID); // OT Information
                    rptCustomersOrders.SetParameterValue("@investigationfee", Convert.ToDecimal(txtinvestigation.Text));
                   
                    rptCustomersOrders.SetParameterValue("@grandtotal", Convert.ToDecimal(txtinvestigation.Text));
                    
                    rptCustomersOrders.SetParameterValue("@NetPayable", Convert.ToDecimal(txtinvestigation.Text));
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
        }

        private void textBoxSearchHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    PatientBLL oPatientBLL = new PatientBLL();
                    DataSet ds = oPatientBLL.PatientHospatalIdSearch(Convert.ToInt32(textBoxSearchHospitalID.Text));
                    if (ds.Tables[2].Rows.Count > 0)
                    {
                        lvwPatientInfo.Items.Clear();
                        FillUpListview(lvwPatientInfo, ds, 2);
                    }
                    else
                        MessageBox.Show("No Data Found");
                    

                }
            }
            catch
            {
                MessageBox.Show("Error21");
            }

        }

        private void btndiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApplicatinLauncher._GroupName == "Administrator" || ApplicatinLauncher._GroupName == "Accounts")
                {
                    if (lvwDue.SelectedItems.Count > 0)
                    {
                        decimal value = Convert.ToDecimal(txtdiscount.Text);
                        int k = Convert.ToInt32(value);
                        if (k > 0 && txtRemarks.Text == "")
                        {
                            MessageBox.Show("Please Write Remarks");
                            txtRemarks.Visible = true;
                            lblRemarks.Visible = true;
                            txtRemarks.Focus();
                            return;
                        }
                        BillBO billBO = new BillBO();
                        BillBLL billBLL = new BillBLL();
                        billBO.admission_id = Convert.ToInt32(lvwDue.SelectedItems[0].SubItems[2].Text);
                        billBO.discount = Convert.ToDecimal(txtdiscount.Text);
                        billBO.remarks = txtRemarks.Text;
                        billBO.record_modified_by = ApplicatinLauncher._userId;

                        int result = billBLL.DiscountBillUpdate(billBO);
                        MessageBox.Show("Discount done successfully");
                        btndiscount.Enabled = false;


                    }
                    else
                    {
                        MessageBox.Show("You need administrator permission");
                    }
                }
            }
            catch
            {
            }
        }

        private void btnAutoDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                PatientTypeAutoDiscount();
            }
            catch
            {
            }
        }

        void PatientTypeAutoDiscount()
        {
            try
            {
                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "Member")
                {
                    decimal ADT=0;
                    decimal CabinDiscount=0;
                    decimal InvestigationDiscount=0;
                    int rate = 75;
                    if ((txtcabincharge.Text != "") && (txtservicecharge.Text!=""))
                    {
                        if (Convert.ToDecimal(txtDuration.Text) > 0)
                        {

                            decimal C = (2000 * Convert.ToDecimal(txtDuration.Text));
                            if (C >= (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text));
                            }
                            else if (C < (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = C;
                            }
                        }

                        if (Convert.ToDecimal(txtDuration.Text) == 0)
                        {

                            CabinDiscount = 2000;

                        }

                    }
                    if (txtinvestigation.Text != "")
                    {
                        InvestigationDiscount = ((Convert.ToDecimal(txtinvestigation.Text)) * rate)/100;
                    }


                    ADT = CabinDiscount + InvestigationDiscount + Convert.ToDecimal(txtothercharge.Text);
                    
                    //txtdiscount.Text = Convert.ToDecimal((ADT * rate) / 100).ToString();
                    txtdiscount.Text = ADT.ToString();
                    chkdiscount.Checked = true;
                    checkbox();
                    txtRemarks.Text = "Member Discount";
                    NetPayable();
                }

                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "Officer")
                {
                    decimal ADT = 0;
                    decimal CabinDiscount = 0;
                    decimal InvestigationDiscount = 0;
                    int rate = 75;
                    if ((txtcabincharge.Text != "") && (txtservicecharge.Text != ""))
                    {
                        if (Convert.ToDecimal(txtDuration.Text) > 0)
                        {

                            decimal C = (2000 * Convert.ToDecimal(txtDuration.Text));
                            if (C >= (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text));
                            }
                            else if (C < (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = C;
                            }
                        }

                        if (Convert.ToDecimal(txtDuration.Text) == 0)
                        {

                            CabinDiscount = 2000;

                        }

                    }
                    if (txtinvestigation.Text != "")
                    {
                        InvestigationDiscount = ((Convert.ToDecimal(txtinvestigation.Text)) * rate) / 100;
                    }


                    ADT = CabinDiscount + InvestigationDiscount + Convert.ToDecimal(txtothercharge.Text);

                    //txtdiscount.Text = Convert.ToDecimal((ADT * rate) / 100).ToString();
                    txtdiscount.Text = ADT.ToString();
                    chkdiscount.Checked = true;
                    checkbox();
                    txtRemarks.Text = "Stuff Discount";
                    NetPayable();
                }

                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "Stuff")
                {
                    decimal ADT = 0;
                    decimal CabinDiscount = 0;
                    decimal InvestigationDiscount = 0;
                    int rate = 75;
                    if ((txtcabincharge.Text != "") && (txtservicecharge.Text != ""))
                    {
                        if (Convert.ToDecimal(txtDuration.Text) > 0)
                        {

                            decimal C = (600 * Convert.ToDecimal(txtDuration.Text));
                            if (C >= (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text));
                            }
                            else if (C < (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = C;
                            }
                        }

                        if (Convert.ToDecimal(txtDuration.Text) == 0)
                        {

                            CabinDiscount = 600;

                        }

                    }
                    if (txtinvestigation.Text != "")
                    {
                        InvestigationDiscount = ((Convert.ToDecimal(txtinvestigation.Text)) * rate) / 100;
                    }


                    ADT = CabinDiscount + InvestigationDiscount + Convert.ToDecimal(txtothercharge.Text);

                    //txtdiscount.Text = Convert.ToDecimal((ADT * rate) / 100).ToString();
                    txtdiscount.Text = ADT.ToString();
                    chkdiscount.Checked = true;
                    checkbox();
                    txtRemarks.Text = "Stuff Discount";
                    NetPayable();
                }


                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "Dependable")
                {
                    decimal ADT = 0;
                    decimal CabinDiscount = 0;
                    decimal HospitalDiscount = 0;
                    decimal InvestigationDiscount = 0;
                    int rate = 50;
                    if ((txtcabincharge.Text != "") && (txtservicecharge.Text != ""))
                    {
                        if (Convert.ToDecimal(txtDuration.Text) > 0)
                        {

                            decimal C = (1000 * Convert.ToDecimal(txtDuration.Text));
                            if (C >= (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text));
                            }
                            else if (C < (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = C;
                            }
                        }

                        if (Convert.ToDecimal(txtDuration.Text) == 0)
                        {

                            CabinDiscount = 1000;

                        }

                    }

                    if (txtinvestigation.Text != "")
                    {
                        InvestigationDiscount = ((Convert.ToDecimal(txtinvestigation.Text)) * rate) / 100;
                    }

                    if (txtothercharge.Text != "")
                    {
                        HospitalDiscount = ((Convert.ToDecimal(txtothercharge.Text)) * rate) / 100;
                    }


                    ADT = CabinDiscount + InvestigationDiscount + HospitalDiscount;
                    
                    //txtdiscount.Text = Convert.ToDecimal((ADT * rate) / 100).ToString();
                    txtdiscount.Text = ADT.ToString();
                    chkdiscount.Checked = true;
                    checkbox();
                    txtRemarks.Text = "Dependable Discount";
                    NetPayable();
                }

                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "Officer Dependable")
                {
                    decimal ADT = 0;
                    decimal CabinDiscount = 0;
                    decimal HospitalDiscount = 0;
                    decimal InvestigationDiscount = 0;
                    int rate = 50;
                    if ((txtcabincharge.Text != "") && (txtservicecharge.Text != ""))
                    {
                        if (Convert.ToDecimal(txtDuration.Text) > 0)
                        {

                            decimal C = (1000 * Convert.ToDecimal(txtDuration.Text));
                            if (C >= (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text));
                            }
                            else if (C < (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = C;
                            }
                        }

                        if (Convert.ToDecimal(txtDuration.Text) == 0)
                        {

                            CabinDiscount = 1000;

                        }

                    }
                    if (txtinvestigation.Text != "")
                    {
                        InvestigationDiscount = ((Convert.ToDecimal(txtinvestigation.Text)) * rate) / 100;
                    }

                    if (txtothercharge.Text != "")
                    {
                        HospitalDiscount = ((Convert.ToDecimal(txtothercharge.Text)) * rate) / 100;
                    }


                    ADT = CabinDiscount + InvestigationDiscount + HospitalDiscount;

                    //txtdiscount.Text = Convert.ToDecimal((ADT * rate) / 100).ToString();
                    txtdiscount.Text = ADT.ToString();
                    chkdiscount.Checked = true;
                    checkbox();
                    txtRemarks.Text = "Stuff Dependable Discount";
                    NetPayable();
                }

                if (lvwPatientInfo.SelectedItems[0].SubItems[5].Text == "Stuff Dependable")
                {
                    decimal ADT = 0;
                    decimal CabinDiscount = 0;
                    decimal HospitalDiscount = 0;
                    decimal InvestigationDiscount = 0;
                    int rate = 50;
                    if ((txtcabincharge.Text != "") && (txtservicecharge.Text != ""))
                    {
                        if (Convert.ToDecimal(txtDuration.Text) > 0)
                        {

                            decimal C = (300 * Convert.ToDecimal(txtDuration.Text));
                            if (C >= (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text));
                            }
                            else if (C < (Convert.ToDecimal(txtcabincharge.Text) + Convert.ToDecimal(txtservicecharge.Text)))
                            {
                                CabinDiscount = C;
                            }
                        }

                        if (Convert.ToDecimal(txtDuration.Text) == 0)
                        {

                            CabinDiscount = 300;

                        }

                    }
                    if (txtinvestigation.Text != "")
                    {
                        InvestigationDiscount = ((Convert.ToDecimal(txtinvestigation.Text)) * rate) / 100;
                    }

                    if (txtothercharge.Text != "")
                    {
                        HospitalDiscount = ((Convert.ToDecimal(txtothercharge.Text)) * rate) / 100;
                    }


                    ADT = CabinDiscount + InvestigationDiscount + HospitalDiscount;

                    //txtdiscount.Text = Convert.ToDecimal((ADT * rate) / 100).ToString();
                    txtdiscount.Text = ADT.ToString();
                    chkdiscount.Checked = true;
                    checkbox();
                    txtRemarks.Text = "Stuff Dependable Discount";
                    NetPayable();
                }

            }
            catch
            {
            }
        }

        void checkbox()
        {
            try
            {
                if (chkdiscount.Checked == true)
                {
                    lblRemarks.Visible = true;
                    txtRemarks.Visible = true;
                }
            }
            catch
            {
            }
        }

       
    }
}
