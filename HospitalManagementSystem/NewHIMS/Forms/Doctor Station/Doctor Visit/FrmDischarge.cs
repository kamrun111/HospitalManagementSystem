using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using HIMS.BLL;
using HIMS.BusinessObjects;
//using System.Windows.Forms.ToolTip;


namespace NewHIMS.Forms.Doctor_Station.Doctor_Visit
{
    public partial class FrmDischarge : BaseForm.FrmBase
    {
        public FrmDischarge()
        {
            InitializeComponent();
        }
        //private System.Windows.Forms.ToolTip toolTip1;
        //private System.ComponentModel.IContainer components;
        private int AdmissionID = 0;
        private FrmDoctorVisit _objForm;

        public void discharcgeMedecine(FrmDoctorVisit objform,int ID)
        {
            try
            {
                this._objForm = objform;
                this.AdmissionID = ID;
                PatientDischargeBLL patientDischargeBLL = new PatientDischargeBLL();
                DataSet ds = patientDischargeBLL.dischargeMedicine(AdmissionID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdMainList.Rows.Add();
                        grdMainList.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();//product-id
                        grdMainList.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();//product
                        grdMainList.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();//dose_p_quantity
                        grdMainList.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();//intake_sys
                        grdMainList.Rows[i].Cells[4].Value = null;


                    }
                    //grdMainList.Rows[0].Cells[0].Selected.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdMainList.RowCount == 0)
                    return;
                List<PatientDischarge> lstPatientDischarge = new List<PatientDischarge>();
                PatientDischargeBLL patientDischargeBLL=new PatientDischargeBLL();
                int Result = 0;

                for (int i = 0; i < grdMainList.Rows.Count; i++)
                {
                    PatientDischarge patientDischarge = new PatientDischarge();
                    if(grdMainList.Rows[i].Cells[0].Value.ToString()!=null)
                    {
                        patientDischarge.admission_id = AdmissionID;
                        patientDischarge.product_id = Convert.ToInt16(grdMainList.Rows[i].Cells[0].Value);
                        if (grdMainList.Rows[i].Cells[4].Value == null)
                        {
                            MessageBox.Show("Input Indication Properly");
                            return;

                        }
                        else
                            patientDischarge.medicine_indication = grdMainList.Rows[i].Cells[4].Value.ToString();
                        patientDischarge.record_created_by = ApplicatinLauncher._userId;
                        patientDischarge.record_modified_by = ApplicatinLauncher._userId;
                        lstPatientDischarge.Add(patientDischarge);
                    }
                }
                if (lstPatientDischarge.Count > 0)
                {
                    Result = patientDischargeBLL.medicineDichageADD(lstPatientDischarge);
                }
                if (Result > 0)
                {
                    MessageBox.Show("Data Saved successfully");
                    btnSave.Enabled = false;
                    grdMainList.Rows.Clear();
                    this._objForm.DischargeFlag(_objForm);
                    this.Close();
                
                }
            }
            catch
            {
            }
        }

        private void FrmDischarge_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnSave, btnSave.Text.ToString());
            ToolTip1.IsBalloon=true;
            ToolTip1.Active = true;
        }

        
        


    }


}