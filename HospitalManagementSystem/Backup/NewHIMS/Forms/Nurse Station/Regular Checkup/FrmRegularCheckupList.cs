using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Nurse_Station;

namespace NewHIMS.Forms.Nurse_Station.Regular_Checkup
{
    public partial class FrmRegularCheckupList : BaseForm.FrmBase
    {
        private string  _cabin;
        private int _asmissionID;
        private string _HospitalID;
        private string _PName;
        private string _userNam = ApplicatinLauncher._userName;
        private FrmNurseStation _objForm;
        public FrmRegularCheckupList()
        {
            InitializeComponent();
        }

        private KeyPressEventArgs KEY;

        private void FrmRegularCheckupList_Load(object sender, EventArgs e)
        {
            //RefreshRegularchekup();
            this.Height = 644;
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


        private void btnSaveCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTemperature.Text == ""
                             || this.txtPulse.Text == ""
                             || this.mskBp.Text == ""
                             || this.txtRespitation.Text == ""
                             || this.txtStool.Text == ""
                             || this.txtWeight.Text == "")
                {
                    MessageBox.Show("All checkup values are empty.");
                    return;
                }

                RegularCheckup regularCheckup = new RegularCheckup();
                RegularCheckupBLL regularCheckupBLL = new RegularCheckupBLL();

                regularCheckup.admission_id = this._asmissionID;
                regularCheckup.temperature = Convert.ToDecimal(txtTemperature.Text);
                regularCheckup.pulse = Convert.ToInt32(txtPulse.Text);
                regularCheckup.bp = mskBp.Text;
                regularCheckup.respitation = Convert.ToInt32(txtRespitation.Text);
                regularCheckup.stool = txtStool.Text;
                regularCheckup.weight = Convert.ToDecimal(txtWeight.Text);
                regularCheckup.checkup_date = Convert.ToDateTime(dtpCheckup_date.Text);
                regularCheckup.record_created_by = ApplicatinLauncher._userId;
                regularCheckupBLL.Addregular_checkup(regularCheckup);
                regularCheckupBLL.GetRegularCheckup(this._asmissionID);
                
                MessageBox.Show("Data Saved Successfully");
                btnSaveCC.Enabled = false;
                this._objForm.lvwPatientInfo.SelectedItems[0].ForeColor = Color.Teal;
                RefreshRegularchekup(_objForm, _cabin, _asmissionID, _HospitalID, _PName);
            }
            catch { 
            }

        }

        private void NumCheck(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            KEY = e;
       }


        public void RefreshRegularchekup(FrmNurseStation objForm,string cabin,int admissionID,string HospitalID,string patientname)
        {
            try
            {
                this._objForm = objForm;
                this._cabin = cabin;
                this._asmissionID = admissionID;
                this._HospitalID = HospitalID;
                this._PName = patientname;
                this.label7.Text = this._cabin.ToString();
                //this.label8.Text = this._asmissionID.ToString();
                this.label8.Text = this._HospitalID.ToString();
                this.label12.Text = _PName;
                RegularCheckupBLL regularCheckupBLL = new RegularCheckupBLL();
                DataSet ds = regularCheckupBLL.GetRegularCheckup(this._asmissionID);
                lvwMainListCC.Items.Clear();
                FillUpListview(lvwMainListCC, ds);
                LoadMainList();
                regularCheckupBLL = null;
                ds = null;
            }
            catch { 
            }
        }


        private void txtTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                //if(string.Compare()
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                IntakeOuttake intakeOuttake = new IntakeOuttake();
                IntakeOuttakeBLL intakeOuttakeBLL = new IntakeOuttakeBLL();

                intakeOuttake.admission_id = this._asmissionID;
                intakeOuttake.in_date_time = Convert.ToDateTime(dtpInDateTime.Text);
                if (txtInOral.Text != "")
                    if (rbtOralMouth.Checked == true)
                        intakeOuttake.in_oral = -(Convert.ToDecimal(txtInOral.Text));
                    else
                        intakeOuttake.in_oral = (Convert.ToDecimal(txtInOral.Text));

                if (txtInParenteral.Text != "")
                    if (rbtParenInfusion.Checked == true)
                        intakeOuttake.in_parenteral = -(Convert.ToDecimal(txtInParenteral.Text));
                    else
                        intakeOuttake.in_parenteral = Convert.ToDecimal(txtInParenteral.Text);

                if (txtInUrinaryBladderWash.Text != "")
                    intakeOuttake.in_urinary_bladder_wash = Convert.ToDecimal(txtInUrinaryBladderWash.Text);

                if (txtInTotal.Text != "")
                    intakeOuttake.in_total = Convert.ToDecimal(txtInTotal.Text);

                if (txtOutNasogastric.Text != "")
                    if (rbtSuction.Checked == true)
                        intakeOuttake.out_nasogastric = -(Convert.ToDecimal(txtOutNasogastric.Text));
                    else
                        intakeOuttake.out_nasogastric = Convert.ToDecimal(txtOutNasogastric.Text);
                
                if (txtOutDrainageTube.Text != "")
                    if (rbtDrainage.Checked == true)
                        intakeOuttake.out_drainage_tube = -(Convert.ToDecimal(txtOutDrainageTube.Text));
                    else
                        intakeOuttake.out_drainage_tube = Convert.ToDecimal(txtOutDrainageTube.Text);


                if (txtOutUrine.Text != "")
                    if (rbtVolume.Checked == true)
                        intakeOuttake.out_urine = -(Convert.ToDecimal(txtOutUrine.Text));
                    else
                        intakeOuttake.out_urine = Convert.ToDecimal(txtOutUrine.Text);

                if (txtOutStool.Text != "")
                    intakeOuttake.out_stool = Convert.ToDecimal(txtOutStool.Text);
                if (txtTTube.Text != "")
                    intakeOuttake.out_t_tube = Convert.ToDecimal(txtTTube.Text);
                if (txtInvisibleLoss.Text != "")
                    intakeOuttake.invisible_loss = Convert.ToDecimal(txtInvisibleLoss.Text);
                if (txtOutTotal.Text != "")
                    intakeOuttake.out_total = Convert.ToDecimal(txtOutTotal.Text);
                if (txtBalance.Text != "")
                    intakeOuttake.balance = Convert.ToDecimal(txtBalance.Text);
                intakeOuttake.record_created_by = ApplicatinLauncher._userId;

                intakeOuttakeBLL.Addintake_outtake(intakeOuttake);
                MessageBox.Show("Data Saved Successfully");
                btnSave.Enabled = false;
                LoadMainList();
                

            }
            catch { 
            }
        }

        void LoadMainList()
        {
            try
            {
                IntakeOuttakeBLL intakeOuttakeBLL = new IntakeOuttakeBLL();
                DataSet ds = intakeOuttakeBLL.GetIntakeOutTake(_asmissionID);
                //FillUpListview(lvwMainList, ds);

                lvwMainList.Items.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                    if (Convert.ToInt32(ds.Tables[0].Rows[i][1]) < 0)
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][1]) * (-1) + "(Mouth)");
                    else
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][1]) + "(Ryles tubes)");
                    
                    if (Convert.ToInt32(ds.Tables[0].Rows[i][2]) < 0)
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][2]) * (-1) + "(Infusion)");
                    else
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][2]) + "(Transfution)");

                    lvi.SubItems.Add(ds.Tables[0].Rows[i][3].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][4].ToString());

                    if (Convert.ToInt32(ds.Tables[0].Rows[i][5]) < 0)
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][5]) * (-1) + "(Suction)");
                    else
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][5]) + "(Vomitus)");

                    if (Convert.ToInt32(ds.Tables[0].Rows[i][6]) < 0)
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][6]) * (-1) + "(Drinage)");
                    else
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][6]) + "(Nephostomy)");

                    if (Convert.ToInt32(ds.Tables[0].Rows[i][5]) < 0)
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][7]) * (-1) + "(Volume)");
                    else
                        lvi.SubItems.Add(Convert.ToInt32(ds.Tables[0].Rows[i][7]) + "(Time)");

                    lvi.SubItems.Add(ds.Tables[0].Rows[i][8].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][9].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][10].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][11].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][12].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i][13].ToString());
                                       
                    lvwMainList.Items.Add(lvi);

                }
            }
            catch
            {
            }


        }

        private void CalculateInTotal()
        {
            try
            {
                if (KEY.KeyChar != 8)
                {
                    long TOTAL = Convert.ToInt64(txtInOral.Text) + Convert.ToInt64(txtInParenteral.Text) + Convert.ToInt64(txtInUrinaryBladderWash.Text);
                    txtInTotal.Text = TOTAL.ToString();
                    txtBalance.Text = Convert.ToString(Convert.ToInt64(txtInTotal.Text) - Convert.ToInt64(txtOutTotal.Text));
                }
            }
            catch
            { }
        }


        private void CalculateOutTotal()
        {
            try
            {
                if (KEY.KeyChar != 8)
                {
                    long TOTAL = (Convert.ToInt64(txtOutNasogastric.Text) + Convert.ToInt64(txtOutDrainageTube.Text) + Convert.ToInt64(txtOutUrine.Text) + Convert.ToInt64(txtOutStool.Text) + Convert.ToInt64(txtInvisibleLoss.Text) + Convert.ToInt64(txtTTube.Text));
                    txtOutTotal.Text = TOTAL.ToString();
                    txtBalance.Text = Convert.ToString(Convert.ToInt64(txtInTotal.Text) - Convert.ToInt64(txtOutTotal.Text));
                }
            }
            catch
            { }
        }

        private void txtInOral_Leave(object sender, EventArgs e)
        {
            CalculateInTotal();
        }

        private void txtOutNasogastric_Leave(object sender, EventArgs e)
        {
            CalculateOutTotal();
        }

        private void txtInOral_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void txtOutNasogastric_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInOral_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void btnRefreshCC_Click(object sender, EventArgs e)
        {
            txtPulse.Text = "";
            txtTemperature.Text = "";
            mskBp.Text = "";
            txtRespitation.Text = "";
            txtStool.Text = "";
            txtWeight.Text = "";
            btnSaveCC.Enabled = true;
                
        }

        public void PrintRegularCheckup()
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new regularcheckup();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                pdvCustomerName.Value = _asmissionID;
                pdvCustomerName.Value = _asmissionID;
                //pdvCustomerName.Value = _userNam;
                pvCollection.Add(pdvCustomerName);
                rptCustomersOrders.DataDefinition.ParameterFields[0].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]
                rptCustomersOrders.DataDefinition.ParameterFields[1].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]
                //rptCustomersOrders.DataDefinition.ParameterFields[2].ApplyCurrentValues(pvCollection); // [ IF ANY PARAMETER ]

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        public void PrintIntakeOutput()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new IntakeOutput();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", _asmissionID);
                rptCustomersOrders.SetParameterValue("@admissionid", _asmissionID);
                rptCustomersOrders.SetParameterValue("@UserName", ApplicatinLauncher._userName);

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
            PrintRegularCheckup();
        }

        private void btnprintintake_Click(object sender, EventArgs e)
        {
            PrintIntakeOutput();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtInOral.Text = "0";
            txtInParenteral.Text = "0";
            txtInUrinaryBladderWash.Text = "0";
            txtInTotal.Text = "0";
            txtOutNasogastric.Text = "0";
            txtOutDrainageTube.Text = "0";
            txtOutUrine.Text = "0";
            txtOutStool.Text = "0";
            txtTTube.Text = "0";
            txtInvisibleLoss.Text = "0";
            txtOutTotal.Text = "0";
            txtBalance.Text = "0";
            LoadMainList();
            btnSave.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}