using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Configuration;

namespace NewHIMS.Forms.Doctor_Station.ConultantList
{
    public partial class FrmConsultantList : BaseForm.FrmBase
    {
        private Color RemarksColor = Color.DodgerBlue;
        
        public FrmConsultantList()
        {
            InitializeComponent();
        }


        public void refreshContent()
        {
            try
            {
                VisiblitySet(lblForDoctors, txtForDoctors, false);
                VisiblitySet(lblForReceiption, txtForReceiption, false);
                VisiblitySet(lblForNurse, txtForNurse, false);
                SetPermission();
                this.loadConsultantList();
            }
            catch
            {
            }
        }

        private void loadNurseRemarks()
        {
            AdmissionBLL admissionBLL = new AdmissionBLL();
            DataSet ds= admissionBLL.Getadmissions();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["nurse_remarks"].ToString() != "")
                {
                    //txtForNurse.Text = txtForNurse.Text + "\r\nCabin No. "+ds.Tables[0].Rows[i]["cabin"].ToString()+ "\r\n\r\n"+ds.Tables[0].Rows[i]["nurse_remarks"].ToString();
                    txtForNurse.Text = txtForNurse.Text + "\r\n\r\n"+ds.Tables[0].Rows[i]["nurse_remarks"].ToString();
                    //txtForReceiption.Text += "\r\n\r\n" + ds.Tables[0].Rows[i][0].ToString() + "\r\n\r\n       - " + ds.Tables[0].Rows[i][1].ToString() + "\r\n       - " + ds.Tables[0].Rows[i][2].ToString();
                }
            }
        }

        private void loadReeptionRemarks()
        {
            PatientStatusBLL patientStatusBLL = new PatientStatusBLL();
            DataSet ds = patientStatusBLL.Getpatient_statuss();

            if(ds.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    txtForReceiption.Text += "\r\n\r\n" + ds.Tables[0].Rows[i][0].ToString() + "\r\n\r\n       - " + ds.Tables[0].Rows[i][1].ToString() + "\r\n       - " + ds.Tables[0].Rows[i][2].ToString();
                }
            }
        }
        
        private void loadConsultantList()
        {
            this.trvHistoryItems.Nodes.Clear();
            this.txtForDoctors.Text = "";
            RefferedDoctors refferedDoctors = new RefferedDoctors();
            RefferedDoctorsBLL refferedDoctorsBLL = new RefferedDoctorsBLL();
            DataSet dsConsultant = refferedDoctorsBLL.GetConsultantAll();
            if (dsConsultant.Tables[0] != null && dsConsultant.Tables[0].Rows.Count > 0)
            {
                for (int r = 0; r < dsConsultant.Tables[0].Rows.Count; r++)
                {
                    int consultantId = Convert.ToInt32(dsConsultant.Tables[0].Rows[r][0]);
                    DataSet dsConsultantPatientInfo = refferedDoctorsBLL.GetConsultantListInfo(consultantId);
                    if (dsConsultantPatientInfo.Tables[0] != null && dsConsultantPatientInfo.Tables[0].Rows.Count > 0)
                    {
                        TreeNode newParentNode = this.trvHistoryItems.Nodes.Add(dsConsultant.Tables[0].Rows[r][1].ToString());
                        for (int r2 = 0; r2 < dsConsultantPatientInfo.Tables[0].Rows.Count; r2++)
                        {
                            string patientInfo = dsConsultantPatientInfo.Tables[0].Rows[r2][0].ToString() + " - " + dsConsultantPatientInfo.Tables[0].Rows[r2][2].ToString();
                            if (dsConsultantPatientInfo.Tables[0].Rows[r2][2].ToString() != "" && dsConsultantPatientInfo.Tables[0].Rows[r2][1].ToString() != "")
                                {
                                    this.txtForDoctors.Text += "\r\nCabin No. " + dsConsultantPatientInfo.Tables[0].Rows[r2][0].ToString() + " \r\n- - - - - - - - - - - - - - - - - - - \r\n" + dsConsultantPatientInfo.Tables[0].Rows[r2][1].ToString() + "\r\n- - - - - - - - - - - - - - - - - - -\r\n\r\n";
                                }
                                TreeNode newChildNode = new TreeNode(patientInfo);
                                newChildNode.ForeColor = this.RemarksColor;
                                newParentNode.Nodes.Add(newChildNode);
                                newParentNode.ExpandAll();
                            }
                        }
                    }
                }
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void FrmConsultantList_Load(object sender, EventArgs e)
        {
            refreshContent();
        }

        private void VisiblitySet(Label lbl,TextBox txt,bool value)
        {
            lbl.Visible = value;
            txt.Visible = value;
        }

        private void SetPermission()
        {
            switch (ApplicatinLauncher._groupID)
            {

                case 52:    //////for receiption////
                    VisiblitySet(lblForDoctors, txtForDoctors, false);
                    VisiblitySet(lblForNurse, txtForNurse, false);
                    VisiblitySet(lblForReceiption, txtForReceiption, true);
                    this.loadReeptionRemarks();
                    break;
                case 53:    ////for nurse//////
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                    VisiblitySet(lblForDoctors, txtForDoctors, false);
                    VisiblitySet(lblForReceiption, txtForReceiption, false);
                    VisiblitySet(lblForNurse, txtForNurse, true);
                    this.loadNurseRemarks();
                    break;
                case 60:    //////for doctor////
                    VisiblitySet(lblForNurse, txtForNurse, false);
                    VisiblitySet(lblForReceiption, txtForReceiption, false);
                    VisiblitySet(lblForDoctors, txtForDoctors, true);
                    this.loadConsultantList();
                    break;
            }
                
        }

           
        }
    }
