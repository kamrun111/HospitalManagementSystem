using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.DoctorsPayment;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Receiptions.DoctorsBill
{
    public partial class FrmDoctorName : BaseForm.FrmBase
    {
        public FrmDoctorName()
        {
            InitializeComponent();
        }
        int doctorID = 0;
        private void FrmDoctorName_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch
            {
            }
        }
        private void load()
        {
            lvwDoctorInfo.Items.Clear();
            lblTotalSupplier2.Text = "";
            DoctorsBillBLL doctorsBillBLL = new DoctorsBillBLL();
            DataSet ds = doctorsBillBLL.get_alldoctors();
            if (ds.Tables[0].Rows.Count > 0)
                FillUpListview(lvwDoctorInfo, ds, 0);
            lblTotalSupplier2.Text = lvwDoctorInfo.Items.Count.ToString();
            PopulateComboBox(cmbspecilist_in, ds, 1, "specialist_in", "specialist_in_id");
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
            load();
            refresh();
        }
        void refresh()
        {
            txtdoctorName.Text = "";
            cmbspecilist_in.SelectedIndex = -1;
            cmbspecilist_in.Text = "<Select>";
            btnSave.Text = "Save";
            doctorID = 0;
        }

        private void lvwDoctorInfo_Click(object sender, EventArgs e)
        {
            if (lvwDoctorInfo.SelectedItems.Count > 0)
            {
                txtdoctorName.Text = lvwDoctorInfo.SelectedItems[0].SubItems[1].Text.ToString();
                this.cmbspecilist_in.SelectedIndex = this.cmbspecilist_in.FindString(lvwDoctorInfo.SelectedItems[0].SubItems[2].Text.ToString());
                doctorID = Convert.ToInt32(lvwDoctorInfo.SelectedItems[0].Text);
                btnSave.Text = "Update";
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbspecilist_in.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Specialist In From List");
                    return;
                }
                RefferedDoctors refferedDoctors = new RefferedDoctors();
                RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
                refferedDoctors.reffered_doctors = txtdoctorName.Text.ToString();
                refferedDoctors.specialist_in_id = Convert.ToInt32(cmbspecilist_in.SelectedValue);
                refferedDoctors.reffered_doctors_id = doctorID;
                if (btnSave.Text == "Save")
                {
                    refferedDoctorsBLL.doctor_nameadd(refferedDoctors);
                    MessageBox.Show("Data Saved Successfully");
                }
                else
                {
                    int result = refferedDoctorsBLL.doctor_nameupdate(refferedDoctors);
                    MessageBox.Show("Data Update Successfully");
                    //this.lvwPatientInfo_SelectedIndexChanged(null, null);
                }
                refferedDoctors = null;
                refferedDoctorsBLL = null;
                doctorID = 0;
                refresh();
                load();
                
            }
            catch
            {
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtNameSearch.Text != "")
                {
                    RefferedDoctorsBLL oRefferedDoctorsBLL = new RefferedDoctorsBLL();
                    DataSet ds = oRefferedDoctorsBLL.DoctorSepecific(txtNameSearch.Text);
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        lvwDoctorInfo.Items.Clear();
                        FillUpListview(lvwDoctorInfo, ds,1);
                    }

                }
            }
            catch
            {
            }
        }
    }
}
