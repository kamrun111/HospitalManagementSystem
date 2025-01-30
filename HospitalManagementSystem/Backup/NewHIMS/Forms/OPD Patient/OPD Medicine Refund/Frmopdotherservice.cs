using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund;

namespace NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund
{
    public partial class Frmopdotherservice : BaseForm.FrmBase
    {
        public Frmopdotherservice()
        {
            InitializeComponent();
        }
        private int OPDadmissionID = 0;
        //private string PatientName = "";

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
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
            combo.Text = "<Select>";
        }
        public void load(int opdadmissionID,string patientname)
        {
            try
            {
                txtpatientname.Text = patientname;
                this.OPDadmissionID = opdadmissionID;
                OtherItemBLL otherItemBLL = new OtherItemBLL();
                OPDotherItemBLL opdotherBLL = new OPDotherItemBLL();
                DataSet ds = opdotherBLL.getopdOtherservices(OPDadmissionID);
                if (ds.Tables[0].Rows.Count > 0)
                    FillUpListview(lvwPatientOtherItem, ds);
                PopulateComboBox(cmbotherservices, otherItemBLL.Getother_items(), 0, "other_item", "other_item_id");
                otherItemBLL = null;
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbotherservices.SelectedIndex == -1)
                    return;
                if (MessageBox.Show("Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                OPDotheritem otheritem = new OPDotheritem();
                OPDotherItemBLL otherItemBLL = new OPDotherItemBLL();
                otheritem.PKID = OPDadmissionID;
                otheritem.other_item_id = Convert.ToInt32(cmbotherservices.SelectedValue);
                otheritem.qty = Convert.ToInt32(txtQtyPerUnit.Text);
                otheritem.record_created_by = ApplicatinLauncher._userId;
                int result = otherItemBLL.otheritemadd(otheritem);
                if (result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    load(OPDadmissionID, txtpatientname.Text);
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
                load(OPDadmissionID, txtpatientname.Text);
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}