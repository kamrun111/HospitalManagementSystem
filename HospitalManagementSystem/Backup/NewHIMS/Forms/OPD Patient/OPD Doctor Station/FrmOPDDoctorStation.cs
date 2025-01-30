using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.OPD_Patient.OPD_Doctor_Station
{
    public partial class frmOPDDoctorStation : Form
    {
        public string PPrescriptionID;
        public frmOPDDoctorStation()
        {
            InitializeComponent();
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
                        if (dataRow[3].ToString() == "0")
                        {
                            lvi.SubItems.Add(dataRow[j].ToString());
                            lvi.ForeColor = Color.Maroon;
                        }
                        else
                        {
                            lvi.SubItems.Add(dataRow[j].ToString());
                            lvi.ForeColor = Color.DodgerBlue;
                        }
                    }
                    lvw.Items.Add(lvi);
                    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FrmOPDDoctorTreatment frmOPDDoctorTreatment = new FrmOPDDoctorTreatment();
               //frmOPDDoctorTreatment.ShowDialog();
               frmOPDDoctorTreatment.populatePatientInfo(lblPatientName.Text, lblRegADID.Text, lblPAddress.Text, PPrescriptionID,lblConsultantName.Text);

            }
            catch
            {
            }
        }

        private void FrmOPDDoctorStation_Load(object sender, EventArgs e)
        {
            OPDPatientBLL oPDPatientBLL = new OPDPatientBLL();
            OPDPatient oPDPatient = new OPDPatient();
            DataSet ds = new DataSet();
            ds=oPDPatientBLL.PopulateOPDPatientInfo();
            FillUpListview(lvwPatientList, ds, 0);
            linkLabel1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPDPatientBLL oPDPatientBLL = new OPDPatientBLL();
            OPDPrescriptionBLL oPDPrescriptionBLL = new OPDPrescriptionBLL();
            OPDPrescription oPDPrescription = new OPDPrescription();
            oPDPrescription.RegID = lblRegADID.Text;
            oPDPrescription.cc = txtCC.Text;
            oPDPrescription.PF = txtPF.Text;
            oPDPrescription.RecordeCreatedBy = ApplicatinLauncher._userId;
            oPDPrescriptionBLL.AddOPDPrescription(oPDPrescription);
            OPDPatient oPDPatient = new OPDPatient();
            DataSet ds = new DataSet();
            ds = oPDPatientBLL.PopulateOPDPatientInfo();
            FillUpListview(lvwPatientList, ds, 0);
            MessageBox.Show("Data Save Successfully");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmOPDPatientHistory FrmOPDPatientHistory = new frmOPDPatientHistory();
                FrmOPDPatientHistory.populatePatientInfo(lblPatientName.Text, lblRegADID.Text, lblPAddress.Text, lblConsultantName.Text); ;

            }
            catch
            {
            }

        }

        private void lvwPatientList_Click(object sender, EventArgs e)
        {
            string RfDoctor = "";
            txtCC.Text = "";
            txtPF.Text = "";
            OPDPatientBLL oPDPatientBLL = new OPDPatientBLL();
            DataSet dds = new DataSet();
            dds = oPDPatientBLL.GetOPDRefDoctor(lvwPatientList.SelectedItems[0].SubItems[0].Text.ToString());
            for (int i = 0; i < dds.Tables[0].Rows.Count; i++)
            {
                if ( i!=0)
                {
                    RfDoctor = RfDoctor + "," + dds.Tables[0].Rows[i][1].ToString();
                }
                else
                {
                    RfDoctor = dds.Tables[0].Rows[i][1].ToString();
                }
            }
               
            lblPatientName.Text = lvwPatientList.SelectedItems[0].SubItems[1].Text.ToString();
            lblRegADID.Text = lvwPatientList.SelectedItems[0].SubItems[0].Text.ToString();
            lblPAddress.Text=lvwPatientList.SelectedItems[0].SubItems[2].Text.ToString();
            lblConsultantName.Text = RfDoctor;
            if(lvwPatientList.SelectedItems[0].SubItems[3].Text.ToString()=="0")
            {
                linkLabel1.Enabled=false;
                //btnSave.Enabled = true;
            }
            else
            {
                txtCC.Text = lvwPatientList.SelectedItems[0].SubItems[4].Text.ToString();
                txtPF.Text = lvwPatientList.SelectedItems[0].SubItems[5].Text.ToString();
                linkLabel1.Enabled=true;
                PPrescriptionID = lvwPatientList.SelectedItems[0].SubItems[3].Text.ToString();
                //btnSave.Enabled = false;
            }
        }
    }
}