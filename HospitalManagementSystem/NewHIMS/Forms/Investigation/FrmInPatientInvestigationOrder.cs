using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using HIMS.BusinessObjects;
using HIMS.BLL;
using System.Windows.Forms;
using NewHIMS.Reports.Investigation;
using NewHIMS.Reports;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Forms.Common;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmInPatientInvestigationOrder : BaseForm.FrmBase
    {
        public FrmInPatientInvestigationOrder()
        {
            InitializeComponent();
        }

        private void FrmInPatientInvestigationOrder_Load(object sender, EventArgs e)
        {
            RefreshInvestigation();

        }
        void RefreshInvestigation()
        {
            InvestigationBLL investigationBLL = new InvestigationBLL();
            DataSet ds = investigationBLL.GetIPDInvestigationPopulationInfo();
            try
            {
                FillUpListview(lvwPatientInfo, ds, 0);
                PopulateComboBox(cmbRefferedDoctors, ds, 1, "reffDoc", "reffered_doctors_id");
                cmbRefferedDoctors.SelectedIndex = -1;
                cmbRefferedDoctors.Text = "<Select>";
                this.cmbTestDepartemt.SelectedIndexChanged -= this.cmbTestDepartemt_SelectedIndexChanged;
                PopulateComboBox(cmbTestDepartemt, ds, 2, "test_department", "test_department_id");
                this.cmbTestDepartemt.SelectedIndexChanged += new System.EventHandler(this.cmbTestDepartemt_SelectedIndexChanged);
                txtPathology.Enabled = false;
                txtXray.Enabled = false;
                txtUsg.Enabled = false;
                txtEcg.Enabled = false;
                txtCabinNo.Text = "";
                txtPName.Text = "";
                lvwTest.Items.Clear();
                grdtestitems.Rows.Clear();
                btnSave.Enabled = false;
                txtTestTotal.Text = "";
                //PopulateComboBox(cmbTestGroup, ds, 0, "test_group", "test_group_id");

                //ResetPatientContents();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                //if (combo.SelectedIndex > 0)
                //combo.SelectedIndex = -1;
                //combo.Text = "<Select>";
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
        Boolean IsMatchTest(string dept, string item)
        {

            for (int i = 0; i < lvwTest.Items.Count; i++)
            {
                if (lvwTest.Items[i].SubItems[0].Text == dept && lvwTest.Items[i].SubItems[2].Text == item )
                    return true;
            }
            return false;

        }

        private void cmbTestDepartemt_KeyPress(object sender, KeyPressEventArgs e)
        {
           try
            {
                if (e.KeyChar == 13)
                {
                    cmbTestGroup.Focus();
                }
            }
            catch
            {
            }  
        
        }

        private void cmbTestDepartemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                    grdtestitems.Rows.Clear();
                    cmbTestGroup.Text = "";
                    TestItemBLL testItemBLL = new TestItemBLL();
                    int testDeptID = Convert.ToInt32(((DataRowView)(cmbTestDepartemt.SelectedItem)).Row[0].ToString());
                    DataSet ds = testItemBLL.testItemsList(testDeptID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        chkgroup.Checked = false;
                        cmbTestGroup.Enabled = false;
                        grdtestitems.Rows.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells["test_department"].Value = ds.Tables[0].Rows[i]["test_department"].ToString();                                      //admn_id
                            grdtestitems.Rows[i].Cells["test_group"].Value = ds.Tables[0].Rows[i]["test_group"].ToString();                                     //cabin_id
                            grdtestitems.Rows[i].Cells["test_items"].Value = ds.Tables[0].Rows[i]["test_item"].ToString();
                            grdtestitems.Rows[i].Cells["test_charge"].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["charge"].ToString());
                            grdtestitems.Rows[i].Cells["department_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_department_id"].ToString());
                            grdtestitems.Rows[i].Cells["group_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_group_id"].ToString());
                            grdtestitems.Rows[i].Cells["item_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_item_id"].ToString());
                            grdtestitems.Rows[i].Cells["speciman_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["specimen_id"].ToString());
                        }
                        //this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);

                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        PopulateComboBox(cmbTestGroup, ds, 1, "test_group", "test_group_id");
                        this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
                    }

            }
            catch
            {
            }
        }

        private void chkgroup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkgroup.Checked == true)
                    cmbTestGroup.Enabled = true;
                else
                {
                    cmbTestGroup.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void chkgroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    if (e.KeyChar == 13)
            //    {
            //        cmbTestItem.Focus();
            //    }
            //}
            //catch
            //{
            //}
        }

        private void cmbTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbTestGroup.SelectedIndex >= 0)
                {
                    TestItemBLL testItemBLL = new TestItemBLL();
                    //int groupID = Convert.ToInt32(((DataRowView)(cmbTestGroup.SelectedItem)).Row[0].ToString());
                    DataSet ds = testItemBLL.testlist(Convert.ToInt32(this.cmbTestDepartemt.SelectedValue.ToString()), Convert.ToInt32(this.cmbTestGroup.SelectedValue.ToString()));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.cmbTestGroup.SelectedIndexChanged -= this.cmbTestGroup_SelectedIndexChanged;
                        chkgroup.Checked = false;
                        cmbTestGroup.Enabled = false;
                        grdtestitems.Rows.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdtestitems.Rows.Add();
                            grdtestitems.Rows[i].Cells["test_department"].Value = ds.Tables[0].Rows[i]["test_department"].ToString();                                      //admn_id
                            grdtestitems.Rows[i].Cells["test_group"].Value = ds.Tables[0].Rows[i]["test_group"].ToString();                                     //cabin_id
                            grdtestitems.Rows[i].Cells["test_items"].Value = ds.Tables[0].Rows[i]["test_item"].ToString();
                            grdtestitems.Rows[i].Cells["test_charge"].Value = Convert.ToDecimal(ds.Tables[0].Rows[i]["charge"].ToString());
                            grdtestitems.Rows[i].Cells["department_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_department_id"].ToString());
                            grdtestitems.Rows[i].Cells["group_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_group_id"].ToString());
                            grdtestitems.Rows[i].Cells["item_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_item_id"].ToString());
                            grdtestitems.Rows[i].Cells["speciman_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["specimen_id"].ToString());
                        }
                        //this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);

                    }

                }

            }
            catch
            {
            }
        }

        private void grdtestitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            string msg = "";
            DataGridViewRow row = null;
            row = this.grdtestitems.Rows[e.RowIndex];
            try
            {
                string valueStr = (row.Cells[3].Value.ToString() == null ? "" : row.Cells[3].Value.ToString());

                if (e.ColumnIndex == 0)
                {

                    if (grdtestitems.Rows[e.RowIndex].Cells[9].Value == null)//add
                    {
                        if (IsMatchTest(cmbTestDepartemt.Text, valueStr) == true)
                        {
                            MessageBox.Show("Test already exists");
                            row.Cells[0].Selected = true;
                            //row.Cells[0].
                            return;
                        }
                        ListViewItem lvi = new ListViewItem(this.cmbTestDepartemt.Text);//department
                        lvi.SubItems.Add(row.Cells[2].Value.ToString());//group
                        lvi.SubItems.Add(row.Cells[3].Value.ToString());//testitems
                        lvi.SubItems.Add(row.Cells[4].Value.ToString());//charge
                        lvi.SubItems.Add(row.Cells[5].Value.ToString());//department_id
                        lvi.SubItems.Add(row.Cells[6].Value.ToString());//group_id
                        lvi.SubItems.Add(row.Cells[7].Value.ToString());//testitems_id
                        lvi.SubItems.Add(((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[0].ToString());//refdoctor
                        lvi.SubItems.Add(cmbRefferedDoctors.SelectedValue.ToString());//refdoc id
                        lvi.SubItems.Add(row.Cells[8].Value.ToString());//speciman id
                        lvwTest.Items.Add(lvi);//
                        grdtestitems.Rows[e.RowIndex].Cells[9].Value = "F";//add
                        //if (rdoconsultation.Checked == true)
                        //    goto next;

                        ////////////////////////////////////

                        double total = 0.0;
                        for (int i = 0; i < lvwTest.Items.Count; i++)
                        {
                            double subTolal;
                            subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                            total = total + subTolal;
                        }
                        //double vat = ((total * 2.25) / 100);
                        //int Gtotal = Convert.ToInt32(total + vat);
                        int Gtotal = Convert.ToInt32(total);
                        this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                        if (txtPathology.Text == "")
                        {
                            txtPathology.Text = "00.00";
                        }
                        else if (txtXray.Text == "")
                        {
                            txtXray.Text = "00.00";
                        }
                        else if (txtUsg.Text == "")
                        {
                            txtUsg.Text = "00.00";
                        }
                        else if (txtEcg.Text == "")
                        {
                            txtEcg.Text = "00.00";
                        }
                        double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                        this.txtNetPayable.Text = NP.ToString("0#.#0");
                        this.lvwTest.Refresh();

                        if (this.lvwTest.Items.Count > 0)
                        {
                            this.btnSave.Enabled = true;
                        }
                        if (cmbTestDepartemt.Text == "Pathology")
                        {
                            txtPathology.Enabled = true;
                            //txtXray.Enabled = false;
                            //txtUsg.Enabled = false;
                            //txtEcg.Enabled = false;

                        }
                        else if (cmbTestDepartemt.Text == "X-Ray")
                        {
                            //txtPathology.Enabled = false;
                            txtXray.Enabled = true;
                            //txtUsg.Enabled = false;
                            //txtEcg.Enabled = false;
                        }
                        else if (cmbTestDepartemt.Text == "USG")
                        {
                            //txtPathology.Enabled = false;
                            //txtXray.Enabled = false;
                            txtUsg.Enabled = true;
                            //txtEcg.Enabled = false;
                        }
                        else if (cmbTestDepartemt.Text == "ECG")
                        {
                            //txtPathology.Enabled = false;
                            //txtXray.Enabled = false;
                            //txtUsg.Enabled = false;
                            txtEcg.Enabled = true;
                        }
                        else
                        {
                            txtPathology.Enabled = false;
                            txtXray.Enabled = false;
                            txtUsg.Enabled = false;
                            txtEcg.Enabled = false;
                        }
                        ////////////////////////////////////////////////

                    }
                    else
                    {
                        if (grdtestitems.Rows[e.RowIndex].Cells[9].Value.ToString() == "T")//readd
                        {
                            if (IsMatchTest(cmbTestDepartemt.Text, valueStr) == true)
                            {
                                MessageBox.Show("Test already exists");
                                row.Cells[0].Selected = true;
                                //Convert.ToBoolean(grdDoctorsBill.Rows[i].Cells["is_paid"].Value)== true
                                //Convert.ToBoolean(grdtestitems.Rows[e.RowIndex].Cells[0].Value) == false;
                                //row.Cells[0].
                                return;
                            }
                            ListViewItem lvi = new ListViewItem(this.cmbTestDepartemt.Text);//department
                            lvi.SubItems.Add(row.Cells[2].Value.ToString());//group
                            lvi.SubItems.Add(row.Cells[3].Value.ToString());//testitems
                            lvi.SubItems.Add(row.Cells[4].Value.ToString());//charge
                            lvi.SubItems.Add(row.Cells[5].Value.ToString());//department_id
                            lvi.SubItems.Add(row.Cells[6].Value.ToString());//group_id
                            lvi.SubItems.Add(row.Cells[7].Value.ToString());//testitems_id
                            lvi.SubItems.Add(((DataRowView)(cmbRefferedDoctors.SelectedItem)).Row[0].ToString());
                            lvi.SubItems.Add(cmbRefferedDoctors.SelectedValue.ToString());
                            lvi.SubItems.Add(row.Cells[8].Value.ToString());
                            lvwTest.Items.Add(lvi);
                            //this._selectedDr = cmbRefferedDoctors.Text;
                            grdtestitems.Rows[e.RowIndex].Cells[9].Value = "F";//add
                        }
                        else//remove
                        {
                            //for (int i = 0; i < lvwTest.Items.Count; i++)
                            //{
                            //    if (lvwTest.Items[i].SubItems[0].Text == dept)
                            //    {


                            //        return true;
                            //    }
                            //}
                            lvwTest.Items.Remove(lvwTest.FindItemWithText(grdtestitems.Rows[e.RowIndex].Cells[1].Value.ToString()));//MessageBox.Show("False");
                            grdtestitems.Rows[e.RowIndex].Cells[9].Value = "T";

                            string Dept = grdtestitems.Rows[e.RowIndex].Cells[1].Value.ToString();

                            //string Dept = lvwTest.SelectedItems[0].SubItems[0].Text;
                            int flag = 0;
                            double total1 = double.Parse(this.txtTestTotal.Text);

                            total1 -= double.Parse(grdtestitems.Rows[e.RowIndex].Cells[4].Value.ToString());
                            this.txtTestTotal.Text = total1.ToString("0#.#0");
                            //lvwTest.Items.Remove(lvwTest.FocusedItem);
                            double total = 0.0;
                            for (int i = 0; i < lvwTest.Items.Count; i++)
                            {
                                double subTolal;
                                subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                                total = total + subTolal;
                            }
                            //double vat = ((total * 2.25) / 100);
                            //int Gtotal = Convert.ToInt32(total + vat);
                            int Gtotal = Convert.ToInt32(total);
                            this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                            if (txtPathology.Text == "")
                            {
                                txtPathology.Text = "00.00";
                            }
                            else if (txtXray.Text == "")
                            {
                                txtXray.Text = "00.00";
                            }
                            else if (txtUsg.Text == "")
                            {
                                txtUsg.Text = "00.00";
                            }
                            else if (txtEcg.Text == "")
                            {
                                txtEcg.Text = "00.00";
                            }
                            double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                            this.txtNetPayable.Text = NP.ToString("0#.#0");
                            //this.lvwTest.Refresh();
                            if (lvwTest.Items.Count > 0)
                            {
                                for (int i = 0; i < lvwTest.Items.Count; i++)
                                {
                                    if (Dept == lvwTest.Items[i].SubItems[0].Text)
                                    {
                                        flag = 1;
                                        break;
                                    }
                                    else
                                    {
                                        flag = 2;
                                    }
                                }
                                if (flag != 1)
                                {
                                    if (Dept == "Pathology")
                                    {
                                        txtPathology.Text = "00.00";
                                        txtPathology.Enabled = false;
                                    }
                                    else if (Dept == "X-Ray")
                                    {
                                        txtXray.Text = "00.00";
                                        txtXray.Enabled = false;
                                    }
                                    else if (Dept == "USG")
                                    {
                                        txtUsg.Text = "00.00";
                                        txtUsg.Enabled = false;
                                    }
                                    else if (Dept == "ECG")
                                    {
                                        txtEcg.Text = "00.00";
                                        txtEcg.Enabled = false;
                                    }
                                }
                            }
                            else
                            {
                                txtPathology.Text = "00.00";
                                txtXray.Text = "00.00";
                                txtUsg.Text = "00.00";
                                txtEcg.Text = "00.00";
                                txtNetPayable.Text = "00.00";
                                txtPathology.Enabled = false;
                                txtXray.Enabled = false;
                                txtUsg.Enabled = false;
                                txtEcg.Enabled = false;
                            }
                        }
                    }
                next:
                    double grandtotal = 0.0;
                    for (int i = 0; i < lvwTest.Items.Count; i++)
                    {
                        double subTolal;
                        subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                        grandtotal = grandtotal + subTolal;
                    }
                    // double vat = ((total * 2.25) / 100);
                    //int Gtotal = Convert.ToInt32(total + vat);
                    this.txtTestTotal.Text = grandtotal.ToString("0#.#0");

                }

            }
            catch
            {
                //MessageBox.Show("Error");
            }
            finally
            {

                if (msg != "")
                {
                    MessageBox.Show(msg, "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[e.ColumnIndex].Value = "";
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            if (lvwPatientInfo.SelectedItems.Count > 0)
            {
                txtCabinNo.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
                txtPName.Text = lvwPatientInfo.SelectedItems[0].SubItems[5].Text.ToString();
            }
        }

        private void btnRemoveTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTest.SelectedItems.Count > 0)
                {
                    string Dept = lvwTest.SelectedItems[0].SubItems[0].Text;
                    int flag = 0;
                    double total1 = double.Parse(this.txtTestTotal.Text);

                    total1 -= double.Parse(this.lvwTest.SelectedItems[0].SubItems[3].Text);
                    this.txtTestTotal.Text = total1.ToString("0#.#0");
                    lvwTest.Items.Remove(lvwTest.FocusedItem);
                    double total = 0.0;
                    for (int i = 0; i < lvwTest.Items.Count; i++)
                    {
                        double subTolal;
                        subTolal = Convert.ToDouble(lvwTest.Items[i].SubItems[3].Text);
                        total = total + subTolal;
                    }
                    //double vat = ((total * 2.25) / 100);
                    //int Gtotal = Convert.ToInt32(total + vat);
                    int Gtotal = Convert.ToInt32(total);
                    this.txtTestTotal.Text = Gtotal.ToString("0#.#0");
                    if (txtPathology.Text == "")
                    {
                        txtPathology.Text = "00.00";
                    }
                    else if (txtXray.Text == "")
                    {
                        txtXray.Text = "00.00";
                    }
                    else if (txtUsg.Text == "")
                    {
                        txtUsg.Text = "00.00";
                    }
                    else if (txtEcg.Text == "")
                    {
                        txtEcg.Text = "00.00";
                    }
                    double NP = Convert.ToDouble(txtTestTotal.Text) - (Convert.ToDouble(txtPathology.Text) + Convert.ToDouble(txtXray.Text) + Convert.ToDouble(txtUsg.Text) + Convert.ToDouble(txtEcg.Text));
                    this.txtNetPayable.Text = NP.ToString("0#.#0");
                    //this.lvwTest.Refresh();
                    if (lvwTest.Items.Count > 0)
                    {
                        for (int i = 0; i < lvwTest.Items.Count; i++)
                        {
                            if (Dept == lvwTest.Items[i].SubItems[0].Text)
                            {
                                flag = 1;
                                break;
                            }
                            else
                            {
                                flag = 2;
                            }
                        }
                        if (flag != 1)
                        {
                            if (Dept == "Pathology")
                            {
                                txtPathology.Text = "00.00";
                                txtPathology.Enabled = false;
                            }
                            else if (Dept == "X-Ray")
                            {
                                txtXray.Text = "00.00";
                                txtXray.Enabled = false;
                            }
                            else if (Dept == "USG")
                            {
                                txtUsg.Text = "00.00";
                                txtUsg.Enabled = false;
                            }
                            else if (Dept == "ECG")
                            {
                                txtEcg.Text = "00.00";
                                txtEcg.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        txtPathology.Text = "00.00";
                        txtXray.Text = "00.00";
                        txtUsg.Text = "00.00";
                        txtEcg.Text = "00.00";
                        txtNetPayable.Text = "00.00";
                        txtPathology.Enabled = false;
                        txtXray.Enabled = false;
                        txtUsg.Enabled = false;
                        txtEcg.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("No Item Selected");

                if (this.lvwTest.Items.Count == 0)
                {
                    this.btnSave.Enabled = false;
                    this.cmbTestDepartemt.Focus();
                }
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTest.Items.Count > 0)
                {
                    if (MessageBox.Show(" Do you want to save?", "HMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    decimal path = 0, xray = 0, usg = 0, ecg = 0;
                    for (int m = 0; m < lvwTest.Items.Count; m++)
                    {
                        if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 2)//path
                        {
                            path += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 1)//xray
                        {
                            xray += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 3)//usg
                        {
                            usg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else if (Convert.ToInt32(lvwTest.Items[m].SubItems[4].Text) == 4)//ecg
                        {
                            ecg += Convert.ToDecimal(lvwTest.Items[m].SubItems[3].Text);
                        }
                        else
                        {

                        }
                    }

                    InvestigationBO investigationBO = new InvestigationBO();
                    InvestigationBLL investigationBLL = new InvestigationBLL();
                    SampleBLL sampleBLL = new SampleBLL();

                    investigationBO.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);
                    investigationBO.patient_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text);
                    investigationBO.order_date = DateTime.Now;
                    investigationBO.record_created_by = ApplicatinLauncher._userId;
                    investigationBO.invest_ref_doctor_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);

                    int invesID = investigationBLL.Addinvestigation(investigationBO);
                    if (invesID > 0)
                    {
                        InvestigationOrder investigationOrder = new InvestigationOrder();
                        InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();

                        if (lvwTest.Items.Count > 0)
                        {
                            int DID = 0;
                            int OrderID = 0;
                            int SampleID = 0;
                            int SID = 0;
                            for (int i = 0; i < lvwTest.Items.Count; i++)
                            {

                                
                                if (DID == Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text))
                                    goto next;
                                string DeptID = "0" + (lvwTest.Items[i].SubItems[4].Text);
                                investigationOrder.investigation_id = invesID;
                                if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 2)
                                {
                                    investigationOrder.discount = 0;
                                    investigationOrder.total_amount = path;//path
                                }
                                else if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 1)
                                {
                                    investigationOrder.discount = 0;
                                    investigationOrder.total_amount = xray;//xray
                                }
                                else if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 3)
                                {
                                    investigationOrder.discount = 0;
                                    investigationOrder.total_amount = usg;//usg
                                }
                                else if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 4)
                                {
                                    investigationOrder.discount = 0;
                                    investigationOrder.total_amount = ecg;//ecg
                                }
                                else
                                {
                                    investigationOrder.discount = 0;
                                }
                                investigationOrder.record_created_by = ApplicatinLauncher._userId;
                                investigationOrder.test_department_id = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);

                                OrderID = investigationOrderBLL.investigation_orderAdd(investigationOrder, DeptID);
                            next:
                                DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                                if (DID == 2)
                                {
                                   
                                    while (DID == 2)
                                    {
                                        //int SampleID = 0;
                                        if (SID != Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text) && Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text) != 0)
                                        {
                                            Sample sample = new Sample();
                                            int SpecimenID = Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text);
                                            sample.investigation_id = invesID;
                                            sample.record_created_by = ApplicatinLauncher._userId;
                                            SampleID = sampleBLL.sampleAdd(sample, SpecimenID);
                                        }
                                        SaveInvestigations(invesID, OrderID,SampleID, i);

                                        SID = Convert.ToInt32(lvwTest.Items[i].SubItems[9].Text);
                                        if (i == lvwTest.Items.Count - 1)
                                        {
                                            DID = 0;
                                            MessageBox.Show("Data Saved Successfully");
                                            btnSave.Enabled = false;
                                            //PrintInestigationReport(invesID);
                                            PrintInestigationReportIPD(invesID);
                                            return;
                                        }
                                        if (Convert.ToInt32(lvwTest.Items[i + 1].SubItems[9].Text) != SID)
                                        {
                                            if (DID == Convert.ToInt32(lvwTest.Items[i + 1].SubItems[4].Text))
                                            {
                                                DID = Convert.ToInt32(lvwTest.Items[i + 1].SubItems[4].Text);
                                                i++;
                                            }
                                            else
                                                DID = Convert.ToInt32(lvwTest.Items[i + 1].SubItems[4].Text);
                                        }
                                        else
                                        {
                                            DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                                            i++;
                                        }
                                    }
                                    DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                                }
                                else
                                {
                                    SaveInvestigations(invesID, OrderID, 0, i);
                                    DID = Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text);
                                }
                            }
                        }
                        MessageBox.Show("Data Saved Successfully");
                        btnSave.Enabled = false;
                        PrintInestigationReport(invesID);
                        //PrintInestigationReportIPD(invesID);
                    }
                }
                else
                    MessageBox.Show("No item is selected");
                        

            }
            catch
            {
            }
        }

        private void SaveInvestigations(int invesID, int OrderID, int SampleID, int i)
        {
            try
            {
                InvestigationTest investigationTest = new InvestigationTest();
                InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();

                investigationTest.investigation_id = invesID;
                investigationTest.order_no = OrderID;
                investigationTest.test_department_id = (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text));
                investigationTest.test_group_id = (Convert.ToInt32(lvwTest.Items[i].SubItems[5].Text));
                investigationTest.test_item_id = (Convert.ToInt32(lvwTest.Items[i].SubItems[6].Text));
                if (SampleID != 0)
                {
                    investigationTest.sample_serial_no = SampleID;
                }
                investigationTest.charge = Convert.ToInt32(lvwTest.Items[i].SubItems[3].Text);
                investigationTest.result = "Processing";
                investigationTest.reffered_doctors_id = Convert.ToInt32(cmbRefferedDoctors.SelectedValue);
                //investigationTest.delivery_date=;
                investigationTest.report_done = 0;
                investigationTest.delivered = 0;
                investigationTest.user_id = 0;
                investigationTest.for_baby = 0;
                //investigationTest.actual_delivery_date=;
                if (Convert.ToInt32(lvwTest.Items[i].SubItems[4].Text) == 2)
                {
                    investigationTest.sample_collected = 1;
                }
                else
                {
                    investigationTest.sample_collected = 1;
                }
                //investigationTest.sample_collection_date=;
                investigationTest.record_created_by = ApplicatinLauncher._userId;

                investigationTestBLL.Addinvestigation_test(investigationTest, 0);
                
            }
            catch
            {
            }
        }


        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            RefreshInvestigation();
        }

        void PrintInestigationReport(int investigationID)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new IPDInvestigationInvoice();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();


            }
            catch
            {
            }
        }

        void PrintInestigationReportIPD(int investigationID)
        {
            try
            {
                InvestigationOrderBLL investigationOrderBLL = new InvestigationOrderBLL();
                DataSet ds = investigationOrderBLL.OrdernoGet(investigationID);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int OrderId = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                    CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                    ReportDocument rptCustomersOrders = new InvestigationInvoiceIPD();//InvestigationInvoice

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                    {
                        tliCurrent = tbCurrent.LogOnInfo;

                        tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                        tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                        tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                        tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                        tbCurrent.ApplyLogOnInfo(tliCurrent);
                    }

                    rptCustomersOrders.SetParameterValue("@investigation_id", investigationID);
                    rptCustomersOrders.SetParameterValue("@order_no", OrderId);

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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDailyIPDSales frmDailyIPDSales = new FrmDailyIPDSales(Convert.ToInt32(cmbTestDepartemt.SelectedValue));
                frmDailyIPDSales.MdiParent = this.MdiParent;
                frmDailyIPDSales.Show();
            }
            catch
            {
            }
        }
       
    }
}
