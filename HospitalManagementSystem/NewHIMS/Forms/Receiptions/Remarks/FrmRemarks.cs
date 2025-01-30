using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace NewHIMS.Forms.Receiptions.Remarks
{
    public partial class FrmRemarks : BaseForm.FrmBase
    {
        public FrmRemarks()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                PatientStatus patientStatus = new PatientStatus();
                PatientStatusBLL patientStatusBLL = new PatientStatusBLL();

                patientStatus.patient_status = txtRemarks.Text.ToString();
                //patientStatus.record_created_by = 0;
                patientStatusBLL.Addpatient_status(patientStatus);
                btnOK.Enabled = false;
            }
            catch
            { 
            }
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
            if (txtRemarks.Text.ToString() != "")
            {
                btnOK.Enabled = true;
            }
            else
            { 
                btnOK.Enabled = false;
            }
        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOK_Click(null,null);
            }
        }
    }
}