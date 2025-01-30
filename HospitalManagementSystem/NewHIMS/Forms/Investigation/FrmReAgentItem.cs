using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Investigation;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmReAgentItem : BaseForm.FrmBase
    {
        public FrmReAgentItem()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
            }
        }
        private void PopulateCombobox(ComboBox cmb,DataSet ds,int tableindex,string displaymember,string valuemember)
        {
            cmb.DataSource = ds.Tables[tableindex];
            cmb.DisplayMember = displaymember;
            cmb.ValueMember = valuemember;
            cmb.SelectedIndex = -1;
                cmb.SelectedText="<Select>";
        }
        private void FrmReAgentItem_Load(object sender, EventArgs e)
        {
            try
            {
                InvestigationBLL investigationBLL = new InvestigationBLL();
                DataSet ds = investigationBLL.GetInvestigationPopulationInfo();
                this.cmbDepartment.SelectedIndexChanged -= this.cmbDepartment_SelectedIndexChanged;
                PopulateCombobox(cmbDepartment,ds, 8, "test_department", "test_department_id");
                cmbTestGroup.SelectedText = "<Select>";
                cmbTestGroup.DataSource = null;
                trvTestItem.Nodes.Clear();
                this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
                PopulateCategory();
            }
            catch
            {
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                trvTestItem.Nodes.Clear();
                TestGroupBLL testGroupBLL = new TestGroupBLL();
                int testDeptID = Convert.ToInt32(cmbDepartment.SelectedValue);
                DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.cmbTestGroup.SelectedIndexChanged -=this.cmbTestGroup_SelectedIndexChanged;
                    PopulateCombobox(cmbTestGroup, ds, 0, "test_group", "test_group_id");
                    this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
                }
                else
                {
                    cmbTestGroup.DataSource = null;
                }
            }
            catch
            {
            }
        }

        private void cmbTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                trvTestItem.Nodes.Clear();

                ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                DataSet Dsitem = reAgentItemBLL.GetTestItem(Convert.ToInt32(cmbTestGroup.SelectedValue));
                if (Dsitem.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Dsitem.Tables[0].Rows.Count; i++)
                    {
                        TreeNode newParentNode = this.trvTestItem.Nodes.Add(Dsitem.Tables[0].Rows[i][1].ToString());
                        DataSet Dselement = reAgentItemBLL.GetTestItemElement(Convert.ToInt32(Dsitem.Tables[0].Rows[i][0]));
                        if (Dselement.Tables[0].Rows.Count > 0)
                        {
                            //TreeNode newParentNode = this.trvTestItem.Nodes.Add(Dsitem.Tables[0].Rows[i][1].ToString());
                            for (int j = 0; j < Dselement.Tables[0].Rows.Count; j++)
                            {
                                TreeNode newChildNode = new TreeNode(Dselement.Tables[0].Rows[j][1].ToString());
                                newParentNode.Nodes.Add(newChildNode);
                                //newParentNode.ExpandAll();
                            }
                        }
                    }
                }

            }
            catch
            {
            }
        }

        private void PopulateCategory()
        {
            try
            {
                ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                DataSet DsCat = reAgentItemBLL.ReagentCategory();
                if (DsCat.Tables[0].Rows.Count > 0)
                {
                    this.cmbProductCategory.SelectedIndexChanged -= this.cmbProductCategory_SelectedIndexChanged;
                    cmbProduct.DataSource = null;
                    PopulateCombobox(cmbProductCategory, DsCat, 0, "product_category", "product_category_id");
                    this.cmbProductCategory.SelectedIndexChanged += new System.EventHandler(this.cmbProductCategory_SelectedIndexChanged);

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
                PopulateCategory();
                cmbProductCategory_SelectedIndexChanged(null, null);
                cmbTestGroup_SelectedIndexChanged(null, null);
                grdReAgentItem.Rows.Clear();
            }
            catch
            {
            }
        }

        private void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbProduct.Enabled = true;
                ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                DataSet DsP = reAgentItemBLL.ReagentProduct(Convert.ToInt32(cmbProductCategory.SelectedValue));
                if (DsP.Tables[0].Rows.Count > 0)
                {
                    this.cmbProduct.SelectedIndexChanged -= this.cmbProduct_SelectedIndexChanged;
                    PopulateCombobox(cmbProduct, DsP, 0, "product", "re_agent_product_id");
                    this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
                    trvTestItem.SelectedNode = trvTestItem.SelectedNode;
                }
                else
                    cmbProduct.DataSource = null;
            }
            catch
            {
            }
        }

        private void grdReAgentItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.grdReAgentItem.Rows[e.RowIndex];
                double ValueNumeric= 0;
                this.grdReAgentItem.CellValueChanged -= this.grdReAgentItem_CellValueChanged;
                if (e.ColumnIndex != 4)
                    return;
                if (!(double.TryParse(row.Cells[e.ColumnIndex].Value.ToString(), out ValueNumeric)))
                {
                    MessageBox.Show("Please Provide a valid Quantity");
                    row.Cells[e.ColumnIndex].Value = "";
                    //return;
                }
                this.grdReAgentItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReAgentItem_CellValueChanged);
            }
            catch
            {
            }
        }

        private void cmbProductCategory_Click(object sender, EventArgs e)
        {
            try
            {
                trvTestItem.SelectedNode = trvTestItem.SelectedNode;
                //trvTestItem.SelectedNode.Checked = true;
                //trvTestItem.Enabled = false;
            }
            catch
            {
            }
        }

        private void trvTestItem_Click(object sender, EventArgs e)
        {
            try
            {
                trvTestItem.SelectedNode.BackColor = Color.LightCyan;
                trvTestItem.SelectedNode = trvTestItem.SelectedNode;
                //trvTestItem.SelectedNode.Checked = true;
                trvTestItem.SelectedNode.BackColor = Color.Chocolate;
            }
            catch
            {
            }
        }

        private void cmbProduct_Click(object sender, EventArgs e)
        {
            try
            {
                trvTestItem.SelectedNode = trvTestItem.SelectedNode;
                trvTestItem.SelectedNode.BackColor = Color.Chocolate;
                //trvTestItem.Enabled = false;
            }
            catch
            {
            }
        }

        private void grdReAgentItem_Click(object sender, EventArgs e)
        {
            try
            {
                trvTestItem.SelectedNode = trvTestItem.SelectedNode;
                trvTestItem.SelectedNode.BackColor = Color.Chocolate;
                //trvTestItem.Enabled = false;
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                List<ReAgentItem> lstReAgentItem = new List<ReAgentItem>();
                ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                string test_item = trvTestItem.SelectedNode.Text;
                for (int i = 0; i < grdReAgentItem.Rows.Count - 1; i++)
                {
                    ReAgentItem reAgentItem = new ReAgentItem();

                    reAgentItem.product_id = Convert.ToInt32(grdReAgentItem.Rows[i].Cells["product_id"].Value);
                    reAgentItem.required_qty = Convert.ToDecimal(grdReAgentItem.Rows[i].Cells["required_qty"].Value);
                    reAgentItem.unit_id = Convert.ToInt32(grdReAgentItem.Rows[i].Cells["unit_id"].Value);
                    reAgentItem.record_created_by = ApplicatinLauncher._userId;
                    reAgentItem.record_modified_by = ApplicatinLauncher._userId;
                    lstReAgentItem.Add(reAgentItem);
                }
                reAgentItemBLL.ReAgentItemAdd(lstReAgentItem, test_item);
                MessageBox.Show("Data Saved Successfully");
                btnRefresh_Click(null, null);
            }
            catch
            {
            }
        }

        private void trvTestItem_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                
                ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                string test_item = trvTestItem.SelectedNode.Text;
                DataSet ds = reAgentItemBLL.GetReAgents(test_item);
                grdReAgentItem.Rows.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.grdReAgentItem.CellValueChanged -= this.grdReAgentItem_CellValueChanged;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdReAgentItem.Rows.Add();
                        grdReAgentItem.Rows[i].Cells["product_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["product_id"].ToString());
                        grdReAgentItem.Rows[i].Cells["unit_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["unit_id"].ToString());
                        grdReAgentItem.Rows[i].Cells["product_name"].Value = ds.Tables[0].Rows[i]["product"].ToString();
                        grdReAgentItem.Rows[i].Cells["required_qty"].Value =  Convert.ToDecimal(ds.Tables[0].Rows[i]["required_qty"].ToString());
                        grdReAgentItem.Rows[i].Cells["unit"].Value = ds.Tables[0].Rows[i]["unit"].ToString();

                    }
                    this.grdReAgentItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReAgentItem_CellValueChanged);
                    ds = null;
                    btnSave.Enabled = true;
                    btnPrint.Enabled = true;
                }
                else
                    MessageBox.Show("Re-agent is not configured for this test");
            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Delete?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.btnDelete.Enabled = false;
                    return;

                }
                grdReAgentItem.Rows.Remove(grdReAgentItem.SelectedRows[0]);
                btnDelete.Enabled = false;

            }
            catch
            {
            }
        }

        private void grdReAgentItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter)
                    return;
                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Data Not Found");
                    return;
                }
                //ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                //DataSet Ds = reAgentItemBLL.ReagentProductinfo(Convert.ToInt32(cmbProduct.SelectedValue));
                //if (Ds.Tables[0].Rows.Count > 0)
                //{
                //    this.grdReAgentItem.CellValueChanged -= this.grdReAgentItem_CellValueChanged;
                //    grdReAgentItem.Rows.Add();
                //    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["product_id"].Value = Ds.Tables[0].Rows[0]["product_id"];
                //    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["unit_id"].Value = Ds.Tables[0].Rows[0]["unit_id"];
                //    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["product_name"].Value = Ds.Tables[0].Rows[0]["product"];
                //    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["unit"].Value = Ds.Tables[0].Rows[0]["unit"];
                //    this.grdReAgentItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReAgentItem_CellValueChanged);

                //    btnSave.Enabled = true;
                //}
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string test_item = trvTestItem.SelectedNode.Text;
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new ReAgtentitem();
               
                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@test_item", test_item);
               
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
                btnPrint.Enabled = false;
            }
            catch
            {
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReAgentItemBLL reAgentItemBLL = new ReAgentItemBLL();
                DataSet Ds = reAgentItemBLL.ReagentProductinfo(Convert.ToInt32(cmbProduct.SelectedValue));
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    this.grdReAgentItem.CellValueChanged -= this.grdReAgentItem_CellValueChanged;
                    grdReAgentItem.Rows.Add();
                    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["product_id"].Value = Ds.Tables[0].Rows[0]["re_agent_product_id"];
                    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["unit_id"].Value = Ds.Tables[0].Rows[0]["unit_id"];
                    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["product_name"].Value = Ds.Tables[0].Rows[0]["product"];
                    grdReAgentItem.Rows[grdReAgentItem.Rows.Count - 2].Cells["unit"].Value = Ds.Tables[0].Rows[0]["unit"];
                    this.grdReAgentItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReAgentItem_CellValueChanged);

                    btnSave.Enabled = true;
                }
            }
            catch
            {
            }
        }
    }
}