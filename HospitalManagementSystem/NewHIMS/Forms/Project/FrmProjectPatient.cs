using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BusinessObjects;
using HIMS.BLL;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Project;

namespace NewHIMS.Forms.Project
{
    public partial class FrmProjectPatient : Form
    {
        public FrmProjectPatient()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmProjectPatient_Load(object sender, EventArgs e)
        {
            GetPageLoad();
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("ProjectLoad");
                
                cs.PopulateComboBox(cmbGender, ds, 0, "gender", "gender_id");

                if (ds.Tables[1].Rows.Count > 0)
                {
                    txtProjectName.Text = ds.Tables[1].Rows[0][1].ToString();
                    txtProjectTerm.Text = ds.Tables[1].Rows[0][2].ToString();
                    txtProjectID.Text = Convert.ToInt32(ds.Tables[1].Rows[0][0]).ToString();
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwProjectPatientList, ds, 2);
                }

            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
                txtPatientNo.Text = "";
                txtPatientName.Text = "";
                txtFatherName.Text = "";
                txtMotherName.Text = "";
                txtAddress.Text = "";
                txtContactNumber.Text = "";
                txtAgeDd.Text = "00";
                txtAgeMm.Text = "00";
                txtAgeYy.Text = "00";
                cmbGender.SelectedIndex = -1;
                dtpDOB.Value = DateTime.Now;
                btnSave.Enabled = true;
                btnSave.Text = "Save";
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectPatientBLL projectPatientBLL = new ProjectPatientBLL();
                ProjectPatientBO projectPatientBO = new ProjectPatientBO();

                if (txtPatientName.Text == "")
                {
                    MessageBox.Show("Please Enter Pathient Name");
                    return;
                }
                projectPatientBO.patient_name = txtPatientName.Text;

                if (txtFatherName.Text == "")
                {
                    MessageBox.Show("Please Enter Patient's Father Name");
                    return;
                }
                projectPatientBO.patient_father_name = txtFatherName.Text;

                if (txtMotherName.Text == "")
                {
                    MessageBox.Show("Please Enter Patient's Mother Name");
                    return;
                }
                projectPatientBO.patient_mother_name = txtMotherName.Text;

                if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please Enter Patient Address");
                    return;
                }
                projectPatientBO.patient_address = txtAddress.Text;

                if (txtContactNumber.Text == "")
                {
                    MessageBox.Show("Please Enter Contact Number");
                    return;
                }
                projectPatientBO.contact_number = txtContactNumber.Text;

                if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Patient Gender");
                    return;
                }
                projectPatientBO.gender_id = Convert.ToInt32(cmbGender.SelectedValue);
                projectPatientBO.dob = Convert.ToDateTime(dtpDOB.Value);
                
                int Result = 0;

                if (btnSave.Text == "Save")
                {
                    projectPatientBO.project_term = txtProjectTerm.Text;
                    projectPatientBO.project_id = Convert.ToInt32(txtProjectID.Text);
                    projectPatientBO.record_created_by = ApplicatinLauncher._userId;
                    Result = projectPatientBLL.AddProjectPatient(projectPatientBO);
                }

                else
                {
                    projectPatientBO.project_patient_id = Convert.ToInt32(lvwProjectPatientList.SelectedItems[0].SubItems[0].Text);
                    projectPatientBO.record_modified_by = ApplicatinLauncher._userId;
                    Result = projectPatientBLL.UpdateProjectPatient(projectPatientBO);
                }

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;

                }

            }
            catch
            {
            }
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.CompareTo(this.dtpDOB.Value) > 0)
                {
                    int year = 0;
                    int month = 0;
                    int day = 0;

                    FormHelper.CalculateAge(this.dtpDOB.Value, out year, out month, out day);
                    this.txtAgeYy.Text = year.ToString();
                    this.txtAgeDd.Text = day.ToString();
                    this.txtAgeMm.Text = month.ToString();
                }
                else
                {
                    this.txtAgeYy.Text = "0";
                    this.txtAgeDd.Text = "0";
                    this.txtAgeMm.Text = "0";
                }
            }
            catch
            {
            }
        }

        private void txtAgeYy_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
                    txtAgeMm.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAgeMm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                    txtAgeDd.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAgeDd_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                NumCheck(e);
                if (e.KeyChar == 13)
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                    //cmbNationality.Focus();
                }
            }
            catch
            {
            }
        }

        private void txtAgeYy_Leave(object sender, EventArgs e)
        {
            try
            {
                dtpDOB.Value = FormHelper.calculateDOB(int.Parse(txtAgeYy.Text), int.Parse(txtAgeMm.Text), int.Parse(txtAgeDd.Text));
            }
            catch
            {
            }
        }

        private void txtAgeMm_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtAgeMm.Text) > 12)
                {
                    MessageBox.Show("Invalid Month");
                    txtAgeMm.Focus();
                    return;
                }
                else
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));

                }
            }
            catch
            {
            }
        }

        private void txtAgeDd_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(this.txtAgeDd.Text) > 31)
                {
                    MessageBox.Show("Invalid Date");
                    txtAgeDd.Focus();
                    return;
                }
                else
                {
                    dtpDOB.Value = FormHelper.calculateDOB(int.Parse(this.txtAgeYy.Text), int.Parse(this.txtAgeMm.Text), int.Parse(this.txtAgeDd.Text));
                }
            }
            catch
            {
            }
        }

        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch
            {
            }
        }

        private void lvwProjectPatientList_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithParameter("@PPID", Convert.ToInt32(lvwProjectPatientList.SelectedItems[0].SubItems[0].Text), "ProjectPatientLoad");
                if (lvwProjectPatientList.SelectedItems.Count > 0)
                {
                    if(ds.Tables[0].Rows.Count>0)
                    {
                        txtPatientNo.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtFatherName.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtMotherName.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtContactNumber.Text = ds.Tables[0].Rows[0][6].ToString();
                        cmbGender.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0][7]).ToString();
                        dtpDOB.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][8].ToString());
                        btnSave.Text = "Update";
                    }
                    
                }
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                //DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ProjectPatientList();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //rptCustomersOrders.SetParameterValue("@From", From);
                //rptCustomersOrders.SetParameterValue("@To", To);

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
