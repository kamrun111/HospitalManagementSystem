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
    public partial class FrmInvestigationTestElementAdd : BaseForm.FrmBase
    {
        public FrmInvestigationTestElementAdd()
        {
            InitializeComponent();
        }
        public int testItemID = 0;

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

        public void  RefreshContaint(int testItemId,string testname)
        {
            try
            {
                testItemID = testItemId;
                textBoxTestName.Text = testname;
                TestElementBLL testElementBLL = new TestElementBLL();
                DataSet ds = testElementBLL.get_TestElement(testItemID);
                if (ds.Tables[0].Rows.Count > 0)
                    FillUpListview(listViewTestElement, ds, 0);
            }
            catch
            {
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

        private void listViewTestElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTestElement.SelectedItems.Count > 0)
                {
                    testElementTextBox.Text = listViewTestElement.SelectedItems[0].SubItems[1].Text.ToString();
                    ReferanceTextBox.Text = listViewTestElement.SelectedItems[0].SubItems[3].Text.ToString();
                    serialtextBox.Text = listViewTestElement.SelectedItems[0].SubItems[5].Text.ToString();
                    saveButton.Text = "Update";
                }
            }
            catch
            {
            }
        }



        private void textBoxRoleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                TestElement oTestElement = new TestElement();
                TestElementBLL oTestElementBLL = new TestElementBLL();
                oTestElement.test_item_id = testItemID;
                oTestElement.test_element = testElementTextBox.Text;
                oTestElement.reference_value = ReferanceTextBox.Text;
                if (serialtextBox.Text == "")
                    oTestElement.serial_no = 1;
                else
                    oTestElement.serial_no = Convert.ToInt32(serialtextBox.Text);
                if (saveButton.Text == "Save")
                {                  
                    oTestElement.record_created_by = ApplicatinLauncher._userId;
                    oTestElementBLL.test_element_add(oTestElement);
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                {
                    oTestElement.test_element_id = Convert.ToInt32(listViewTestElement.SelectedItems[0].Text);
                    oTestElement.record_modified_by = ApplicatinLauncher._userId;
                    oTestElementBLL.test_element_update(oTestElement);
                    MessageBox.Show("Data Update Successfully");
                }
                refresh();
                RefreshContaint(testItemID, textBoxTestName.Text);
            }
            catch
            {
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
            RefreshContaint(testItemID, textBoxTestName.Text);
        }
       void refresh()
        {
            testElementTextBox.Text = "";
            ReferanceTextBox.Text="";
            serialtextBox.Text = "";
            saveButton.Text="Save";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
