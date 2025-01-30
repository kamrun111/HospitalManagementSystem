using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports;
using NewHIMS.Reports.Ot;



namespace NewHIMS.Forms.Doctor_Station.OTNote
{
    public partial class FrmOperationNote :BaseForm.FrmBase
    {
        public FrmOperationNote()
        {
            InitializeComponent();
        }

        
        private string patientCode = "";
        private string admissionID = "";
        private string cabinNumber = "";
        private string admissionCode = "";
        private int  babynoteID;
        private int CabinID;
        //private bool babyupdate = false;
        //private int BID;

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.Text = "<Select>";
        }


        //Hospital ID=patientCode    //RegID= admissionCode

     
        public void OtNote(string admissionID, string patientCode, string cabinNumber,string admissionCode,int CabinID)
        {

            try
            {
                
                this.admissionID = admissionID;
                this.patientCode = patientCode;
                this.admissionCode = admissionCode;
                this.cabinNumber = cabinNumber;
                this.CabinID = CabinID;
                txtPatientHospID.Text = this.patientCode;
                txtPatientRegID.Text = this.admissionCode;
                txtCabinNo.Text = this.cabinNumber;

                OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                DataSet ds = operationNoteBLL.GetOTNoteInfo(Convert.ToInt32(admissionID));
                txtPatientName.Text = ds.Tables[0].Rows[0][0].ToString();

                if (ds.Tables[1].Rows.Count>0)
                    txtRefferedDoctor.Text = ds.Tables[1].Rows[0][0].ToString();// reffered doc
                for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                {
                    txtRefferedDoctor.Text = txtRefferedDoctor.Text + "\r\n" + ds.Tables[1].Rows[i][0].ToString();
                }

                txtPatientAge.Text = ds.Tables[2].Rows[0][0].ToString();

                PopulateComboBox(cbmNameOfSurgeon, ds, 3, "reffered_doctors", "reffered_doctors_id");// surgen
                if (ds.Tables[4].Rows.Count > 0)
                {
                    cbmNameOfSurgeon.SelectedIndex  = -1;
                    if (this.cbmNameOfSurgeon.Items.Count > 0)
                    {
                         //if(cbmNameOfSurgeon.Text!="<Select>")
                        this.cbmNameOfSurgeon.SelectedIndex = this.cbmNameOfSurgeon.FindString((ds.Tables[4].Rows[0][0].ToString()));
                    }
                }
                PopulateComboBox(cbm1stAsst, ds, 5, "reffered_doctors", "reffered_doctors_id");//1st Ass

                if (ds.Tables[6].Rows.Count > 0)
                {
                    cbm1stAsst.SelectedIndex = -1;
                    {
                        //if (cbm1stAsst.Text != "<Select>")
                        this.cbm1stAsst.SelectedIndex = this.cbm1stAsst.FindString((ds.Tables[6].Rows[0][0].ToString()));
                    }
                }
                PopulateComboBox(cbm2ndAsst, ds, 7, "reffered_doctors", "reffered_doctors_id");//2nd ass
                if (ds.Tables[8].Rows.Count > 0)
                {
                    if (this.cbm2ndAsst.Items.Count > 0)
                    {
                        cbm2ndAsst.SelectedIndex = -1;
                        this.cbm2ndAsst.SelectedIndex = this.cbm2ndAsst.FindString((ds.Tables[8].Rows[0][0].ToString()));

                    }
                }
                PopulateComboBox(cbm3rdAsst, ds, 9, "reffered_doctors", "reffered_doctors_id");//3rd ass
                if (ds.Tables[10].Rows.Count > 0)
                {

                    if (this.cbm3rdAsst.Items.Count > 0)
                    {
                        cbm3rdAsst.SelectedIndex = -1;
                            this.cbm3rdAsst.SelectedIndex = this.cbm3rdAsst.FindString((ds.Tables[10].Rows[0][0].ToString()));

                    }
                }
                PopulateComboBox(cbmNameOfAna, ds, 11, "reffered_doctors", "reffered_doctors_id");
                if (ds.Tables[12].Rows.Count > 0)
                {

                    if (this.cbmNameOfAna.Items.Count > 0)
                    {
                        cbmNameOfAna.SelectedIndex = -1;
                        this.cbmNameOfAna.SelectedIndex = this.cbmNameOfAna.FindString((ds.Tables[12].Rows[0][0].ToString()));
                    }
                }
                PopulateComboBox(cbmOperationName, ds, 13, "treatement", "treatement_id");//operation

                if (ds.Tables[14].Rows.Count > 0)
                {
                    if (this.cbmOperationName.Items.Count > 0)
                    {
                        cbmOperationName.SelectedIndex = -1;
                        this.cbmOperationName.SelectedIndex = this.cbmOperationName.FindString((ds.Tables[14].Rows[0][0].ToString()));
                        txtProcedure.Text = ds.Tables[14].Rows[0][1].ToString();
                    }
                }
                PopulateComboBox(cmbAnaesiaNature, ds, 15, "anaesthesia_nature", "anaesthesia_id");
                if (ds.Tables[16].Rows.Count > 0)//to show anaesthesia_nature
                {
                    if (cmbAnaesiaNature.Items.Count > 0)
                    {
                        cmbAnaesiaNature.SelectedIndex = -1;
                        this.cmbAnaesiaNature.SelectedIndex = this.cmbAnaesiaNature.FindString((ds.Tables[16].Rows[0][0].ToString()));
                    }

                }
                if (ds.Tables[17].Rows[0][0] != null)
                {
                    dtpoperationDate.Text = ds.Tables[17].Rows[0][0].ToString();
                    dtpoperationTime.Text = ds.Tables[17].Rows[0][0].ToString();
                }
                if (ds.Tables[17].Rows[0][1] != null)
                    txtIndication.Text=ds.Tables[17].Rows[0][1].ToString();
                if (ds.Tables[17].Rows[0][2] != null)
                    txtInsion.Text = ds.Tables[17].Rows[0][2].ToString();
                if(ds.Tables[17].Rows[0][3] != null)
                    txtProcedure.Text = ds.Tables[17].Rows[0][3].ToString();
                if(ds.Tables[17].Rows[0][4] != null)
                    txtremarks.Text = ds.Tables[17].Rows[0][4].ToString();
                if (ds.Tables[17].Rows[0][5] != null)
                {
                    txtAmount.Text = ds.Tables[17].Rows[0][5].ToString();
                    ckbgroupPay.Checked = true;
                }
                if(txtAmount.Text=="0.00")
                    ckbgroupPay.Checked = false;
                else
                    ckbgroupPay.Checked = true;

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void FrmOperationNote_Load(object sender, EventArgs e)
        {
            this.Height = 360; //369;// 364; //373;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button6.Text == "\\/")
            {
                this.Height =  580;//575;
                button6.Text = "/\\";
                button11.Text = "\\/";
                this.btnSave.Enabled = true;
            }
            else
            {
                this.Height = 360; //369;// 364; //373;
                button6.Text = "\\/";
                //this.btnSave.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "\\/")
            {
                this.Height = 693;
                button11.Text = "/\\";
            }
            else
            {
                this.Height =  580;//575;
                button11.Text = "\\/";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               OperationNoteUpdate();
            }
            catch
            {
                MessageBox.Show("data already exist");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        void OperationNoteUpdate()
        {
            try
            {
                if (ckbgroupPay.Checked == true)
                {
                    if (txtAmount.Text == "")
                    {
                        MessageBox.Show("Input Amount");
                        txtAmount.Focus();
                        return;
                    }
                }
                OperationNote operationNote = new OperationNote();
                OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                operationNote.admission_id = Convert.ToInt32(admissionID);
                operationNote.cabin_id = CabinID;
                operationNote.operation_date= Convert.ToDateTime(this.dtpoperationDate.Value.ToString("dd-MMM-yyyy") + " " + this.dtpoperationTime.Value.ToString("hh:mm tt"));
                operationNote.operation_id = Convert.ToInt32(cbmOperationName.SelectedValue.ToString());//operation id
                if(txtIndication.Text!="")
                operationNote.indication = txtIndication.Text.ToString();
                if (txtInsion.Text != "")
                operationNote.incision = txtInsion.Text.ToString();
                if(txtProcedure.Text!="")
                operationNote.procedures = txtProcedure.Text.ToString();
                if(txtremarks.Text!="")
                operationNote.Remarks = txtremarks.Text.ToString();
                operationNote.surgeon_name = Convert.ToInt32(this.cbmNameOfSurgeon.SelectedValue.ToString());//surgeon id
                if (cbm1stAsst.Text != "<Select>")
                    operationNote.first_asst = Convert.ToInt32(this.cbm1stAsst.SelectedValue.ToString());//1st ass
                if (cbm2ndAsst.Text != "<Select>")
                    operationNote.second_asst = Convert.ToInt32(this.cbm2ndAsst.SelectedValue.ToString());//2nd ass
                if (cbm3rdAsst.Text != "<Select>")
                    operationNote.third_asst = Convert.ToInt32(this.cbm3rdAsst.SelectedValue.ToString());//3rd ASS
                if (cbmNameOfAna.Text != "<Select>")
                    operationNote.anaesthesia_id = Convert.ToInt32(this.cbmNameOfAna.SelectedValue.ToString());//anaestheis doc
                if (cmbAnaesiaNature.Text != "<Select>")
                    operationNote.anaesthesia_nature_id = Convert.ToInt32(this.cmbAnaesiaNature.SelectedValue.ToString());//anaestheis nature
                if (ckbgroupPay.Checked == true)
                    operationNote.GroupPay = 1;
                if (txtAmount.Text != "")
                    operationNote.amount = Convert.ToDecimal(txtAmount.Text);
                operationNote.record_modified_by = ApplicatinLauncher._userId;
                babynoteID = operationNoteBLL.OperationBabyNoteUpdate(operationNote);
                MessageBox.Show("Data Saved Successfully");
                btnSave.Enabled = false;        
            }
            catch
            {
                MessageBox.Show("Data Saved Failed");
            }
        
        }
        private void RefreshOperationNote()
        {
            ckbgroupPay.Checked = false;
            OtNote(admissionID, patientCode, cabinNumber, admissionCode, CabinID);
            btnSave.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOperationNote();
        }

        private void ckbgroupPay_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbgroupPay.Checked == true)
                txtAmount.Enabled = true;
            else
            {
                txtAmount.Enabled = false;
                ckbgroupPay.Checked = false;
            }
        }


        //void printOT(int AdmissionID)
        //{
        //    try
        //    {
        //        CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
        //        CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
        //        CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
        //        ReportDocument rptCustomersOrders = new CrystalReportOT1();

        //        foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
        //        {
        //            tliCurrent = tbCurrent.LogOnInfo;
        //            tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
        //            tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
        //            tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
        //            tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
        //            tbCurrent.ApplyLogOnInfo(tliCurrent);
        //        }

        //        pdvCustomerName.Value = AdmissionID;
        //        pvCollection.Add(pdvCustomerName);
        //        rptCustomersOrders.DataDefinition.ParameterFields[0].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]
        //        //rptCustomersOrders.DataDefinition.ParameterFields[1].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]

        //        FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
        //        frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
        //        frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
        //        frmGenericReportViewer.Show();
        //    }
        //    catch
        //    {
        //    }
        //}

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want To print With  Baby Note?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    PrintReport();
                    btnPrint.Enabled = false;
                }
                else
                {
                    PrintReportBabyNote();
                    btnPrint.Enabled = false;
                }
                ////printOT(Convert.ToInt32(admissionID));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void PrintReport()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new CrystalReportOT1();
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



                rptCustomersOrders.SetParameterValue("@getAdmissinID", admissionID);
                rptCustomersOrders.SetParameterValue("@AdmissinID", admissionID);




                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        public void PrintReportBabyNote()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new CrystalReportBAbynote();
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


                rptCustomersOrders.SetParameterValue("@getAdmissinID", admissionID);
                rptCustomersOrders.SetParameterValue("@AdmissinID", admissionID);


                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void lnlBabyNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmBabyNote frmBabyNote = new FrmBabyNote();
                frmBabyNote.Show();
                frmBabyNote.BabyNoteON(admissionID);
            }
            catch
            {
            }
        }

        private void lnkBabyNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //if (cbmOperationName.Text == "L.U.C.S")
                //{
                FrmBabyNote frmBabyNote = new FrmBabyNote();
                //((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmBabyNote);
                //frmBabyNote.Show();
                frmBabyNote.BabyNoteON(this.admissionID);
                frmBabyNote.ShowDialog();
                //}
            }
            catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmOperationName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbmOperationName.SelectedIndex > 0)
                {
                    OperationNoteBLL OperationNoteBLL = new OperationNoteBLL();
                    DataSet ds=OperationNoteBLL.getprocedureforOT(Convert.ToInt16(this.cbmOperationName.SelectedValue.ToString()));
                    if (ds.Tables[0].Rows.Count > 0)
                        txtProcedure.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }
            catch
            {
            }
        }

        //private void cbmOperationName_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    if(txtProcedure.Text!="" || txtProcedure.Text!=null)


        //}
    }
}
    
