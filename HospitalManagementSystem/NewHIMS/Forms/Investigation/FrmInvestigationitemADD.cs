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
            }
            catch
            {
            }
        }
        void newPopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.Text = "<Select>";
                combo.SelectedValue = -1;

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
        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)//gdgdg
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
                newPopulateComboBox(cmbspecimen, ds, 1, "specimen_name", "specimen_id");
                this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
                refresh();
            }
            catch
            {
            }
        }

        private void cmbTestDepartemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTestDepartemt.SelectedIndex >= 0)
                {
                    TestGroupBLL testGroupBLL = new TestGroupBLL();
                    int testDeptID = Convert.ToInt32(cmbTestDepartemt.SelectedValue);
                    DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");
                    }
                    else
                    {
                        cmbTestGroup.DataSource = null;
                    }

                    if (ds.Tables[1].Rows.Count > 0)
                        FillUpListview(lvwTestitem, ds, 1);
                }
            }
            catch
            {
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

     

        private void btnTestItemRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnTestItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TestItem testItem = new TestItem();
                TestItemBLL testItemBLL = new TestItemBLL();
                if (textBoxTestName.Text != "")
                    testItem.test_item = textBoxTestName.Text.ToString();
                else
                {
                    MessageBox.Show("Input Test Name Properly");
                    textBoxTestName.Focus();
                    return;
                }
                if (txtprice.Text == "")
                {
                    MessageBox.Show("Input Price ");
                    txtprice.Focus();
                    return;
                }
                else
                    testItem.charge = Convert.ToDecimal(txtprice.Text);
                testItem.test_group_id = Convert.ToInt32(cmbTestGroup.SelectedValue);
                if(cmbspecimen.SelectedIndex!=-1)
                    testItem.specimen_id = Convert.ToInt32(cmbspecimen.SelectedValue);
               
                if (btnAdd.Text == "Save")
                {
                        if (MessageBox.Show("Do you want to Save New Item?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                        if (textBoxSerialNo.Text != "")
                            testItem.serial_no = Convert.ToInt32(textBoxSerialNo.Text);
                        else
                            testItem.serial_no = 0;
                        if(cmbTestDepartemt.SelectedValue.ToString()=="2")
                        testItem.record_created_by = ApplicatinLauncher._userId;
                        testItemBLL.TestitemAdd(testItem);
                        MessageBox.Show("Data Saved Successfully");                    
                }
                else                     //update
                {
                    if (textBoxSerialNo.Text != "")
                        testItem.serial_no = Convert.ToInt32(textBoxSerialNo.Text);
                    testItem.test_item_id = Convert.ToInt32(lvwTestitem.SelectedItems[0].Text);
                    testItem.record_modified_by = ApplicatinLauncher._userId;
                    testItemBLL.Updatetest_item(testItem);
                    MessageBox.Show("Data Updated Successfully");
                }
                refresh();
            }
            catch
            {
            }
        }

        void refresh()
        {
            try
            {
                btnAdd.Text = "Save";
                txtprice.Text = string.Empty;
                textBoxTestName.Text = string.Empty;
                TestGroupBLL testGroupBLL = new TestGroupBLL();
                int testDeptID = Convert.ToInt32(cmbTestDepartemt.SelectedValue);
                DataSet ds = testGroupBLL.GetTestGroupsByTestDeptID(testDeptID);
                if (ds.Tables[1].Rows.Count > 0)
                    FillUpListview(lvwTestitem, ds, 1);
                lnkTestElement.Enabled = false;


                //for all test without departmentwise -----------------------------

                //TestItemBLL testItemBLL = new TestItemBLL();
                //DataSet ds = testItemBLL.Testitemsget();
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    FillUpListview(lvwTestitem,ds);
                //}
            }
            catch
            {
            }
        }

        private void lvwTestitem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTestitem.SelectedItems.Count > 0)
                {
                    btnAdd.Text = "Update";
                    textBoxTestName.Text = lvwTestitem.SelectedItems[0].SubItems[1].Text.ToString();
                    txtprice.Text = lvwTestitem.SelectedItems[0].SubItems[4].Text.ToString();
                    textBoxSerialNo.Text = lvwTestitem.SelectedItems[0].SubItems[6].Text.ToString();
                    cmbspecimen.SelectedIndex = this.cmbspecimen.FindString(lvwTestitem.SelectedItems[0].SubItems[3].Text.ToString());
                    lnkTestElement.Enabled = true;

                                      
                }

            }
            catch
            {
            }
        }

        private void lnkIndentMedicine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (lvwTestitem.SelectedItems.Count > 0)
                {
                    FrmInvestigationTestElementAdd frmInvestigationTestElementAdd = new FrmInvestigationTestElementAdd();
                    frmInvestigationTestElementAdd.RefreshContaint(Convert.ToInt32(lvwTestitem.SelectedItems[0].Text), lvwTestitem.SelectedItems[0].SubItems[1].Text.ToString());
                    frmInvestigationTestElementAdd.ShowDialog();
                    lnkTestElement.Enabled = false;
                }
                else
                    MessageBox.Show("Select Item From List");
            }
            catch
            {
            }
        }



        private void textBoxSerialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }
      
    }
}