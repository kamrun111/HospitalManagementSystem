using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Receiptions.Patients.Admission;
using NewHIMS.Forms.Investigation;
using NewHIMS.Forms.Receiptions.Doctors_Payment;
using NewHIMS.Forms.Nurse_Station;

namespace NewHIMS.Forms.Common
{
    public partial class FrmdoctorSearch : Form
    {

        public FrmdoctorSearch(FrmAdmission frmAdmission, FrmInvestigation1 frmInvestigation1, FrmDoctorsPayment frmDoctorsPayment, FrmOTForNurse frmOTForNurse, FrmInvestigationWithMember frmInvestigationWithMember, FrmAdmissionMember frmAdmissionMember)
        {
            oFrmAdmission = frmAdmission;
            oFrmInvestigation1 = frmInvestigation1;
            oFrmDoctorsPayment = frmDoctorsPayment;
            oFrmOTForNurse = frmOTForNurse;
            oFrmInvestigationWithMember = frmInvestigationWithMember;
            oFrmAdmissionMember = frmAdmissionMember;
            InitializeComponent();
            Getload();
        }

        FrmAdmission oFrmAdmission = new FrmAdmission();
        FrmInvestigation1 oFrmInvestigation1 = new FrmInvestigation1();
        FrmDoctorsPayment oFrmDoctorsPayment = new FrmDoctorsPayment();
        FrmOTForNurse oFrmOTForNurse = new FrmOTForNurse();
        FrmInvestigationWithMember oFrmInvestigationWithMember = new FrmInvestigationWithMember();
        FrmAdmissionMember oFrmAdmissionMember = new FrmAdmissionMember();

        void Getload()
        {
            RefferedDoctorsBLL oRefferedDoctorsBLL = new RefferedDoctorsBLL();
            DataSet ds = oRefferedDoctorsBLL.DoctorLoad();
            if (ds.Tables[0].Rows.Count > 0)
            {
                FillUpListview(lvwDoctors, ds, 0);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDoctorName.Text="";
            Getload();

        }

        private void txtDoctorName_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            try
            {
                if (txtDoctorName.Text != "")
                {
                    RefferedDoctorsBLL oRefferedDoctorsBLL = new RefferedDoctorsBLL();
                    DataSet ds = oRefferedDoctorsBLL.DoctorSepecific(txtDoctorName.Text);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lvwDoctors.Items.Clear();
                        FillUpListview(lvwDoctors, ds, 0);
                    }

                }
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwDoctors_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                if (oFrmAdmission != null)
                    ForAdmissionform();
                if (oFrmInvestigation1 != null)
                    oFrmInvestigation1.LoadDoctorName(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text));
                if (oFrmDoctorsPayment != null)
                    oFrmDoctorsPayment.LoadDoctorName(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text));
                if (oFrmOTForNurse != null)
                    oFrmOTForNurse.LoadDoctorName(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text));
                if (oFrmInvestigationWithMember != null)
                    oFrmInvestigationWithMember.LoadDoctorName(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text));
                if (oFrmAdmissionMember != null)
                    ForAdmissionMemberform();
                    
            }
            catch
            {
            }
        }
        
        void ForAdmissionform()
        {
            if (oFrmAdmission.IsMatchReffDoctor(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text)) == true)
            {
                MessageBox.Show("Doctor already exists");
                return;
            }
            else
            {
                oFrmAdmission.LoadDoctorNameInListView(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text), lvwDoctors.SelectedItems[0].SubItems[1].Text);
            }
        }

        void ForAdmissionMemberform()
        {
            if (oFrmAdmissionMember.IsMatchReffDoctor(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text)) == true)
            {
                MessageBox.Show("Doctor already exists");
                return;
            }
            else
            {
                oFrmAdmissionMember.LoadDoctorNameInListView(Convert.ToInt32(lvwDoctors.SelectedItems[0].SubItems[0].Text), lvwDoctors.SelectedItems[0].SubItems[1].Text);
            }
        }

    }
}
