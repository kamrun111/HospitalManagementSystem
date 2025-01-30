using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmPatientSearch : BaseForm.FrmBase
    {
        private int isAdmittedOnly = 1;

        public FrmPatientSearch()
        {
            InitializeComponent();
        }

        private void radioByHospitalID_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioByAddress.Checked == true)
                    lblSearchBy.Text = "Address";
                else if (radioByGrdName.Checked == true)
                    lblSearchBy.Text = "Guardian Name";
                else if (radioPatientName.Checked == true)
                    lblSearchBy.Text = "Patient Name";
                else
                    lblSearchBy.Text = "Mobile No";
                refreshes();
            }
            catch { 
            }
        }

        private void txtSearchBy_KeyUp(object sender, KeyEventArgs e)
       {
            try{
               
               if (e.KeyData == Keys.Enter)
                {
                    PatientBLL patientBLL = new PatientBLL();
                    DataSet ds = new DataSet(); 
                    if (txtSearchBy.Text != "")
                    {
                        if (chkAdmittedPatientOnly.Checked)
                            isAdmittedOnly = 1;
                        else
                            isAdmittedOnly = 0;

                        if (lblSearchBy.Text == "Mobile No")
                            ds = patientBLL.GetPtientSearch("@mobile_no", txtSearchBy.Text.ToString(), "GetPatientSearchByMobileNo",isAdmittedOnly);
                        else if (lblSearchBy.Text == "Address")
                            ds = patientBLL.GetPtientSearch("@address", txtSearchBy.Text.ToString(), "GetPatientSearchByAddress", isAdmittedOnly);
                        else if (lblSearchBy.Text == "Patient Name")
                            ds = patientBLL.GetPtientSearch("@patient_name", txtSearchBy.Text.ToString(), "GetPatientSearchByPatientName", isAdmittedOnly);
                        else if (lblSearchBy.Text == "Guardian Name")
                            ds = patientBLL.GetPtientSearch("@guardian_name", txtSearchBy.Text.ToString(), "GetPatientSearchByGuardianName", isAdmittedOnly);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txtAdmissionID.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtHospitalID.Text = ds.Tables[0].Rows[0][1].ToString();
                            txtPatientName.Text = ds.Tables[0].Rows[0][2].ToString();
                            txtGuardianName.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                            txtCPhone.Text = ds.Tables[0].Rows[0][5].ToString();

                            lvwpatientSearch.Items.Clear();
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                ListViewItem lvi = new ListViewItem(ds.Tables[0].Rows[i][1].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][0].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][3].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][5].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][6].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][7].ToString());
                                lvi.SubItems.Add(ds.Tables[0].Rows[i][4].ToString());
                                lvwpatientSearch.Items.Add(lvi); 
                            }
                            
                            lvwpatientSearch.Items[0].Focused = true;
                            this.lvwpatientSearch_Click(null, null);
                        }
                    }
                }
            }
            catch{
            }
        }

        private void lvwpatientSearch_Click(object sender, EventArgs e)
        {
            try{
                PatientBLL patientBLL = new PatientBLL();
                string admissionCode;
                admissionCode = lvwpatientSearch.FocusedItem.SubItems[1].Text.ToString();
                DataSet ds = patientBLL.GetRefferedDoctorByAdmissionCode(admissionCode);

                lvwPatientSRefDoctor.Items.Clear();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());
                        lvwPatientSRefDoctor.Items.Add(lvi);
                    }
                }
                TextBoxFillup();                
            }
            catch{
            }

        }

        private void TextBoxFillup()
        {
            txtHospitalID.Text = lvwpatientSearch.FocusedItem.Text;
            txtPatientName.Text = lvwpatientSearch.FocusedItem.SubItems[2].Text;
            txtAdmissionID.Text = lvwpatientSearch.FocusedItem.SubItems[1].Text;
            txtAddress.Text = lvwpatientSearch.FocusedItem.SubItems[7].Text;
            txtGuardianName.Text = lvwpatientSearch.FocusedItem.SubItems[3].Text;
            txtCPhone.Text = lvwpatientSearch.FocusedItem.SubItems[4].Text;
            
        }

        void refreshes()
        {
            txtSearchBy.Text = "";
            txtHospitalID.Text = "";
            txtAdmissionID.Text = "";
            txtPatientName.Text = "";
            txtGuardianName.Text = "";
            txtAddress.Text = "";
            txtCPhone.Text = "";
            lvwpatientSearch.Items.Clear();
            lvwPatientSRefDoctor.Items.Clear();
            txtSearchBy.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txtAdmissionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAdmissionID.Focus();
            }
        }
        
        private void txtIPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtIPD.Focus();
            }
        }

        private void txtHospitalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHospitalID.Focus();
            }

        }

        private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatientName.Focus();
            }
        }

        private void txtGuardianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGuardianName.Focus();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAddress.Focus();
            }
        }

        private void txtCPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPhone.Focus();
            }
        }

        private void btnClose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               this.Close();
            }
        }

        private void FrmPatientSearch_Load(object sender, EventArgs e)
        {

        }

        private void chkAdmittedPatientOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioByAddress.Checked == true)
            {
                isAdmittedOnly = 1;
                txtSearchBy.Focus();
            }
            else
            {
                isAdmittedOnly = 0;
                txtSearchBy.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                refreshes();
            }
            catch
            {
                
              
            }
        }

        

        //private void FrmPatientSearch_Load(object sender, EventArgs e)
        //{
        //    refreshes();
        //}

    }

}