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
    public partial class FrmInvestigationitemADD :  BaseForm.FrmBase 
    {
        public FrmInvestigationitemADD()
        {
            InitializeComponent();
        }
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                //combo.SelectedIndex = -1;
                //combo.Text = "<Select>";
            }
            catch
            {
            }
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


        private void FrmInvestigationitemADD_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbTestDepartemt.SelectedIndexChanged -= this.cmbTestDepartemt_SelectedIndexChanged;

                TestGroupBLL testGroupBLL = new TestGroupBLL();
                DataSet ds = testGroupBLL.gettestdepartment();
                PopulateComboBox(cmbTestDepartemt, ds, 0, "test_department", "test_department_id");
                PopulateComboBox(cmbspecimen, ds, 1, "specimen_name", "specimen_id");
                this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
                refresh();
            }
            catch
            {
            }
        }

        private void cmbTestDepartemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTestDepartemt.SelectedIndex >= 0)
            {
                TestGroupBLL testGroupBLL = new TestGroupBLL();

                try
                {
                    int testDeptID = Convert.ToInt32(cmbTestDepartemt.SelectedValue);
                    DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");
                        //this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
                        //cmbTestItem.DataSource = null;
                    }
                    else
                    {
                        cmbTestGroup.DataSource = null;
                        cmbTestItem.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    testGroupBLL = null;
                    //ds = null;
                }
            }
        }

        private void cmbTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTestGroup.SelectedIndex >= 0)
            {
                TestItemBLL testItemBLL = new TestItemBLL();

                string strTestGrpID = ((DataRowView)(cmbTestGroup.SelectedItem)).Row[0].ToString();
                int testGrpID = Convert.ToInt32(strTestGrpID);
                DataSet ds = testItemBLL.GetTestItemByTestGrpID(testGrpID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    PopulateComboBox(cmbTestItem, ds, 0, "testItem", "test_item_id");
                }
                else
                {
                    cmbTestItem.DataSource = null;
                }
                testItemBLL = null;
                ds = null;
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
                MessageBox.Show("Input Correctly");
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void btnTestItem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnTestItemRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnTestItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTestItem.Text == "Save")
                {
                    if (cmbTestItem.SelectedIndex == -1 || cmbTestItem.Text!="")
                    {
                        if (MessageBox.Show("Do you want to Save New Item?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;

                        TestItem testItem = new TestItem();
                        TestItemBLL testItemBLL = new TestItemBLL();

                        testItem.test_item = cmbTestItem.Text.ToString();
                        testItem.test_group_id = Convert.ToInt32(cmbTestGroup.SelectedValue);
                        testItem.specimen_id = Convert.ToInt32(cmbspecimen.SelectedValue);
                        //if (txtReferance.Text != "")
                        //    testItem.reference_value = txtReferance.Text.ToString();
                        if (txtprice.Text == "")
                        {
                            MessageBox.Show("Input Price ");
                            return;
                        }
                        else
                            testItem.charge = Convert.ToDecimal(txtprice.Text);
                        testItem.record_created_by = ApplicatinLauncher._userId;

                        testItemBLL.TestitemAdd(testItem);
                        MessageBox.Show("Data Saved Successfully");
                        grpelement.Enabled = true;
                        refresh();
                    }
                }
            }
            catch
            {
            }
        }

        void refresh()
        {
            try
            {
                TestItemBLL testItemBLL = new TestItemBLL();
                DataSet ds = testItemBLL.Testitemsget();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwTestitem,ds);
                }
            }
            catch
            {
            }
        }

        private void lvwTestitem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTestitem.FocusedItem.Text != "")
                {
                    cmbTestItem.SelectedIndex = this.cmbTestItem.FindString(lvwTestitem.SelectedItems[0].SubItems[1].Text.ToString() + lvwTestitem.SelectedItems[0].SubItems[4].Text.ToString());
                    cmbspecimen.SelectedIndex = this.cmbspecimen.FindString(lvwTestitem.SelectedItems[0].SubItems[3].Text.ToString());
                }
            }
            catch
            {
            }
        }

        private void cmbTestItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTestItem.SelectedIndex != -1)
                {

                    TestGroupBLL testGroupBLL = new TestGroupBLL();
                    DataSet ds = testGroupBLL.testelementget(Convert.ToInt32(cmbTestItem.SelectedValue));
                    if(ds.Tables[0].Rows.Count>0)
                        PopulateComboBox(cmbTestelement, ds, 0, "test_element", "test_element_id");
                }
            }
            catch
            {
            }
            
        }

       

     

      

        
        
    }
}