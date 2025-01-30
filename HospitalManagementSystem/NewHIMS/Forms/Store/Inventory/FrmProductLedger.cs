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
using NewHIMS.Forms.Store;
using NewHIMS.Reports;
using NewHIMS.Reports.Inventory;
using NewHIMS.Reports.Receive;


namespace NewHIMS.Forms.Store.Inventory
{
    public partial class FrmProductLedger : Form
    {
        public FrmProductLedger()
        {
            InitializeComponent();
        }


        private void FrmProductLedger_Load(object sender, EventArgs e)
        {
            try
            {
                
                ProductBLL productBLL = new ProductBLL();
                DataSet ds = productBLL.GetProductforLedger();

                PopulateComboBox(cmbProduct, ds, 0, "product", "product_id");

                DataSet da = productBLL.GetProductCategory();
                PopulateComboBox(cmbCategory, da, 1, "product_category", "product_category_id");
                
            }
            catch
            {
            }

        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.DataSource = ds.Tables[tableIndex];
                combo.SelectedIndex = -1;
                combo.Text = "<Select>";
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            rdoCategory.Checked = false;
            rdoProduct.Checked = false;
            rdoProductList.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int ProductID = 0;
                int CategoryID = 0;

                if (rdoProduct.Checked == true)
                {

                    if (cmbProduct.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Select Item First");
                        return;
                    }

                    else
                    {
                        ProductID = Convert.ToInt32(cmbProduct.SelectedValue);
                        
                    }

                    PrintProductLedger(ProductID);

                }

                else if (rdoCategory.Checked == true)
                {

                    if (cmbCategory.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Select Category First");
                        return;
                    }

                    else
                    {
                        CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
                        
                    }

                    PrintCategoryListStock(CategoryID);
                }

                else if (rdoProductList.Checked == true)
                {

                    PrintProductListStock();
                }

                else
                {
                    MessageBox.Show("Please select any option.");
                    return;
                }

            }
            catch
            {
            }
        }

        void PrintProductLedger(int product_id)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ProductLedger();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@product_id", @product_id);
                

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        void PrintCategoryListStock(int Category_id)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ProductStock();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@CategoryID", @Category_id);


                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        void PrintProductListStock()
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ProductListStock();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                //rptCustomersOrders.SetParameterValue("@CategoryID", @Category_id);


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
