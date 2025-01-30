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
using NewHIMS.Forms.Common;

namespace NewHIMS.Forms.ICU
{
    public partial class FrmICUOTInformation : Form
    {

        int admissionId = 0;

        public FrmICUOTInformation( int id)
        {
            admissionId = id;
            InitializeComponent();
        }

        private void FrmICUOTInformation_Load(object sender, EventArgs e)
        {
            try
            {
                GetLoad();
            }
            catch
            {
            }
        }

        void GetLoad()
        {
            try
            {
                OTInformationBLL oTInformationBLL = new OTInformationBLL();
                DataSet ds = oTInformationBLL.OTInformationLoadICU(admissionId);
                if (ds.Tables[0].Rows.Count > 0)
                    txtpatientname.Text = ds.Tables[0].Rows[0][0].ToString();
                txtpatientage.Text = ds.Tables[0].Rows[0][1].ToString();
                txtadmissiondate.Text = ds.Tables[0].Rows[0][2].ToString();
                txtpatientcode.Text = ds.Tables[0].Rows[0][3].ToString();
                txtadmissioncode.Text = ds.Tables[0].Rows[0][4].ToString();
                txtcabinNo.Text = ds.Tables[0].Rows[0][5].ToString();
                txtOtReg.Text = ds.Tables[2].Rows[0][0].ToString();
                if (ds.Tables[1].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                    {
                        grdPatientOT.Rows.Add();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[0].Value = ds.Tables[1].Rows[i][0];
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[1].Value = ds.Tables[1].Rows[i][1].ToString();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[2].Value = ds.Tables[1].Rows[i][2].ToString();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[3].Value = ds.Tables[1].Rows[i][3];
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[4].Value = ds.Tables[1].Rows[i][4].ToString();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[5].Value = ds.Tables[1].Rows[i][5].ToString();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[6].Value = ds.Tables[1].Rows[i][6];
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[7].Value = ds.Tables[1].Rows[i][7].ToString();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[8].Value = ds.Tables[1].Rows[i][8].ToString();
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[9].Value = ds.Tables[1].Rows[i][9];
                        grdPatientOT.Rows[grdPatientOT.Rows.Count - 1].Cells[10].Value = ds.Tables[1].Rows[i][10].ToString();
                    }
                }
            }
            catch
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                OTInformation oTInformation = new OTInformation();
                OTInformationBLL oTInformationBLL = new OTInformationBLL();

                oTInformation.admission_id = admissionId;
                //oTInformation.ot_reg = txtOtReg.Text;
                oTInformation.ot_name = txtOTName.Text;
                oTInformation.ot_date = Convert.ToDateTime(dtpOtDate.Value);
                oTInformation.start_time = txtStartTime.Text;
                oTInformation.finish_time = txtFinishTime.Text;
                oTInformation.anaesthesia_type = txtAnaesthesiaType.Text;
                oTInformation.blood_transfusion = txtBloodTransfusion.Text;
                oTInformation.baby_note = txtBabyNote.Text;
                oTInformation.others = txtOthers.Text;
                oTInformation.record_created_by = ApplicatinLauncher._userId;
                int result = 0;
                if (btnAdd.Text == "Add")
                    result = oTInformationBLL.OTInformationAddICU(oTInformation);
                else
                {
                    oTInformation.ot_information_id = Convert.ToInt32(grdPatientOT.SelectedRows[0].Cells[0].Value);
                    oTInformation.record_modified_by = ApplicatinLauncher._userId;
                    result = oTInformationBLL.OTInformationUpdateICU(oTInformation);
                }
                if (result > 0)
                    MessageBox.Show("Data Saved Successfully");
                grdPatientOT.Rows.Clear();
                GetLoad();
                btnAdd.Enabled = false;

            }

            catch
            {
            }
        }

        private void grdPatientOT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //OTInformationBLL oTInformationBLL = new OTInformationBLL();
                //DataSet ds = oTInformationBLL.OTInformationLoad(admissionId);

                if (grdPatientOT.SelectedRows.Count > 0)
                {
                    btnAdd.Text = "Update";
                    txtOtReg.Text = grdPatientOT.SelectedRows[0].Cells[2].Value.ToString();
                    txtOTName.Text = grdPatientOT.SelectedRows[0].Cells[3].Value.ToString();
                    dtpOtDate.Value = Convert.ToDateTime(grdPatientOT.SelectedRows[0].Cells[4].Value.ToString());
                    txtStartTime.Text = grdPatientOT.SelectedRows[0].Cells[5].Value.ToString();
                    txtFinishTime.Text = grdPatientOT.SelectedRows[0].Cells[6].Value.ToString();
                    txtAnaesthesiaType.Text = grdPatientOT.SelectedRows[0].Cells[7].Value.ToString();
                    txtBloodTransfusion.Text = grdPatientOT.SelectedRows[0].Cells[8].Value.ToString();
                    txtBabyNote.Text = grdPatientOT.SelectedRows[0].Cells[9].Value.ToString();
                    txtOthers.Text = grdPatientOT.SelectedRows[0].Cells[10].Value.ToString();
                    //txtOtReg.Text = grdPatientOT.SelectedRows[0].Cells[5].Value.ToString();


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
    }
}
