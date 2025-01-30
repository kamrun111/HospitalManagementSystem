using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Receiptions.Other_Item
{
    public partial class FrmPatientOtherItemAddEditView : BaseForm.FrmBase
    {
        public FrmPatientOtherItemAddEditView()
        {
            InitializeComponent();
        }



        void RefreshOtherItem() {
 
            FloorBLL floorBLL = new FloorBLL();
            OtherItemBLL otherItemBLL = new OtherItemBLL();
            PopulateComboBox(cmbFloor,floorBLL.Getfloors(),0,"floor","floor_id");
            this.cmbOtherItem.SelectedIndexChanged -= this.cmbOtherItem_SelectedIndexChanged;
            PopulateComboBox(cmbOtherItem, otherItemBLL.Getother_items(), 0, "other_item", "other_item_id");
            //cmbOtherItem.SelectedIndex = -1;
            //cmbOtherItem.Text = "<Select>";
            this.cmbOtherItem.SelectedIndexChanged += new System.EventHandler(this.cmbOtherItem_SelectedIndexChanged);
            txtprice.Text = "";
            floorBLL = null;
            otherItemBLL = null;
            groupBox4.Visible = false;

           
           
         }

        private void FrmPatientOtherItemAddEditView_Load(object sender, EventArgs e)
        {
            RefreshOtherItem();
        }


        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            if (combo.SelectedIndex > 0)
                combo.SelectedIndex = 0;
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
                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }
        
        
        
        
        public void loadPatientInformation()
        {
            string value = "";
            try
            {

               this.lvwPatientInfo.Items.Clear();


                if (cmbFloor.Text != "<Select>" && cmbFloor.Text != "")
                    value = ((DataRowView)(cmbFloor.SelectedItem)).Row[0].ToString();


                AdmissionBLL admissionBLL = new AdmissionBLL();
                DataSet ds = admissionBLL.GetDoctorStationPopulationInfo(Convert.ToInt32(value));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                    {
                        ListViewItem lItem = new ListViewItem(ds.Tables[0].Rows[r]["cabin"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_code"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_id"].ToString());//admission_id
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["admission_code"].ToString());
                        lItem.SubItems.Add(ds.Tables[0].Rows[r]["patient_name"].ToString());
                       
                        this.lvwPatientInfo.Items.Add(lItem);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadPatientInformation();
        }

        private void lvwPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (this.cmbOtherItem.Items.Count > 0)
            {
                this.cmbOtherItem.SelectedIndex = 0;
            }
            this.txtQtyPerUnit.Text = "0";
            if (this.lvwPatientInfo.SelectedItems.Count > 0)
            {
                PatientOtherItemBLL patientOtherItemBLL = new PatientOtherItemBLL();
                DataSet ds=patientOtherItemBLL.GetPatientOtherItemByAdmnID(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text));
                FillUpListview(lvwPatientOtherItem, ds, 0);
                this.btnSave.Enabled = true;
            }
            else
            {
                this.btnSave.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.lvwPatientInfo.SelectedItems.Count == 0)
                {

                    MessageBox.Show("Please select patient first.");
                    this.lvwPatientInfo.Focus();
                    return;
                }
                if (this.cmbOtherItem.SelectedValue.ToString() == "-1")
                {

                    MessageBox.Show("Please select an item.");
                    this.cmbOtherItem.Focus();
                    return;
                }
                if (double.Parse(this.txtQtyPerUnit.Text) <= 0)
                {
                    MessageBox.Show("Invalid quantity specified.");
                    this.txtQtyPerUnit.Focus();
                    return;
                }
                //this.Cursor = Cursors.AppStarting;
                //this.Enabled = false;
                PatientOtherItem patientOtherItem = new PatientOtherItem();
                PatientOtherItemBLL patientOtherItemBLL = new PatientOtherItemBLL();

                
                patientOtherItem.other_item_id = Convert.ToInt32(((DataRowView)(cmbOtherItem.SelectedItem)).Row[0].ToString());
                patientOtherItem.qty_per_unit = Convert.ToDecimal(txtQtyPerUnit.Text);
                patientOtherItem.unit_rate = Convert.ToDecimal(txtprice.Text);
                patientOtherItem.record_created_by = ApplicatinLauncher._userId;
                patientOtherItem.admission_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[2].Text);
                patientOtherItemBLL.Addpatient_other_item(patientOtherItem);

                this.lvwPatientInfo_SelectedIndexChanged(null, null);
            }
            catch
            {
            }
            //this.Enabled = true;
            //this.Cursor = Cursors.Default;
        }

        private void txtQtyPerUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void NumCheck(KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOtherItem();
            lvwPatientOtherItem.Items.Clear();
        }

        private void txtQtyPerUnit_Leave(object sender, EventArgs e)
        {
            if (txtQtyPerUnit.Text == "")
                txtQtyPerUnit.Text = "1";
        }

        private void cmbOtherItem_Leave(object sender, EventArgs e)
        {
            //if (cmbOtherItem.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Data Not Found");
            //    cmbOtherItem.Focus();
            //}
        }

        private void cmbFloor_Leave(object sender, EventArgs e)
        {
            //if (cmbFloor.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Data Not Found");
            //    cmbFloor.Focus();
            //}

        }

        private void cmbOtherItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtherItem.SelectedIndex != -1)
            {
                OtherItemBLL otherItemBLL = new OtherItemBLL();
                DataSet ds = otherItemBLL.getunitrate(Convert.ToInt32(((DataRowView)(cmbOtherItem.SelectedItem)).Row[0].ToString()));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtprice.Text = "";
                    txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
                }
            }

        }

        private void lvwPatientOtherItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientOtherItem.SelectedItems.Count > 0)
                {
                    if (ApplicatinLauncher._GroupName == "Administrator" || ApplicatinLauncher._GroupName == "Accounts")
                    {
                        groupBox4.Visible = true;
                        txtitemname.Text = lvwPatientOtherItem.SelectedItems[0].Text.ToString();
                        txteditqty.Text = lvwPatientOtherItem.SelectedItems[0].SubItems[1].Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You Have No Permission");
                        return;
                    }
                   

                }
                else
                {
                    MessageBox.Show("Select an item from list");
                    return;
                }
            }
            catch
            {
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                PatientOtherItem patientOtherItem = new PatientOtherItem();
                PatientOtherItemBLL patientOtherItemBLL = new PatientOtherItemBLL();
                if (txteditqty.Text == "")
                    txteditqty.Text ="0";
                patientOtherItem.qty_per_unit = Convert.ToDecimal(txteditqty.Text);
                patientOtherItem.patient_other_item_id = Convert.ToInt32(lvwPatientOtherItem.SelectedItems[0].SubItems[3].Text);
                int result = patientOtherItemBLL.patientotheritemQtyUpdate(patientOtherItem);
                this.lvwPatientInfo_SelectedIndexChanged(null, null);
                groupBox4.Visible = false;
            }
            catch
            {
            }
        }

       

    }
}