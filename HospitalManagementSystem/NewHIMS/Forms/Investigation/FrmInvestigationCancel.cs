using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmInvestigationCancel : BaseForm.FrmBase
    {
        public FrmInvestigationCancel()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmInvestigationCancel_Load(object sender, EventArgs e)
        {
            try
            {
                GetPageLoad();
            }
            catch
            {
            }
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("InvestigationCancelDepartment");

                cs.PopulateComboBox(cmbDepartment, ds, 0, "test_department", "test_department_id");

                btnCancel.Enabled = false;
                
                rdoIndoor.Checked = false;
                rdoOutdoor.Checked = false;

                
            }
            catch
            {
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                GetRefresh();
                if (rdoOutdoor.Checked = true && cmbDepartment.SelectedIndex > -1)
                {
                    DataSet ds = cs.GetDataSetWithOneStringOneIntParameter("@order_number", "@dept_id", txtInvestigationNo.Text, Convert.ToInt32(cmbDepartment.SelectedValue), "InvestigationCancelLoadOutdoor");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwInvestigationCancel, ds, 0);
                        txtInvestigationID.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0][9].ToString();
                        txtMobile.Text = ds.Tables[0].Rows[0][10].ToString();
                        txtHospitalID.Text = ds.Tables[0].Rows[0][8].ToString(); ;
                        txtTotal.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtPTType.Text = ds.Tables[0].Rows[0][7].ToString();
                        txtDiscount.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtDate.Text = ds.Tables[0].Rows[0][11].ToString();

                        btnCancel.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("No Data Found");
                    }
                }

                else if (rdoIndoor.Checked = true && cmbDepartment.SelectedIndex > -1)
                {
                    DataSet ds = cs.GetDataSetWithOneStringOneIntParameter("@order_number", "@dept_id", txtInvestigationNo.Text, Convert.ToInt32(cmbDepartment.SelectedValue), "InvestigationCancelLoadOutdoor");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwInvestigationCancel, ds, 0);
                        txtInvestigationID.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0][9].ToString();
                        txtMobile.Text = ds.Tables[0].Rows[0][10].ToString();
                        txtHospitalID.Text = ds.Tables[0].Rows[0][8].ToString(); ;
                        txtTotal.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtPTType.Text = ds.Tables[0].Rows[0][7].ToString();
                        txtDiscount.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtDate.Text = ds.Tables[0].Rows[0][11].ToString();

                        btnCancel.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("No Data Found");
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter Investigation Number And Select Test Department");
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
                GetRefresh();
                cmbDepartment.SelectedIndex = -1;
                txtInvestigationNo.Text = "";
            }
            catch
            {
            }
        }

        void GetRefresh()
        {
            try
            {
                txtDate.Text = "";
                txtDiscount.Text = "";
                txtHospitalID.Text = "";
                txtInvestigationID.Text = "";
                
                txtMobile.Text = "";
                txtPatientName.Text = "";
                txtPTType.Text = "";
                txtTotal.Text = "";
                lvwInvestigationCancel.Items.Clear();
                
                
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if ((ApplicatinLauncher._GroupName == "Administrator") || (ApplicatinLauncher._GroupName == "Accounts") || (ApplicatinLauncher._GroupName == "Front Desk"))
                {

                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    InvestigationTest investigationTest = new InvestigationTest();

                    if (txtInvestigationID.Text == "")
                    {
                        MessageBox.Show("Please Select Any Investigation");
                        return;
                    }

                    if (txtPatientName.Text == "")
                    {
                        MessageBox.Show("Please Select Any Investigation");
                        return;
                    }

                    investigationTest.investigation_id = Convert.ToInt32(txtInvestigationID.Text);
                    investigationTest.test_department_id = Convert.ToInt32(cmbDepartment.SelectedValue);
                    investigationTest.vat = Convert.ToDecimal(txtDiscount.Text);
                    investigationTest.charge = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDiscount.Text));

                    investigationTest.record_modified_by = ApplicatinLauncher._userId;

                    int Result = investigationTestBLL.CancelTest(investigationTest);

                    if (Result > 0)
                    {
                        MessageBox.Show("Test Canceled Successfully");
                        btnCancel.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("You have no Permission to Cancel Investigation");
                    return;
                }
            }
            catch
            {
            }
        }
        
        
    }
}
