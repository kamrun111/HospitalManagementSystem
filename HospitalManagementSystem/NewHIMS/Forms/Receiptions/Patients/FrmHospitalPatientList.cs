using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Data.Common;
using NewHIMS.Reports;
using NewHIMS.Reports.Certificate;
using CrystalDecisions.CrystalReports.Engine;

namespace NewHIMS.Forms.Receiptions.Patients
{
    public partial class FrmHospitalPatientList : Form
    {
        public FrmHospitalPatientList()
        {
            InitializeComponent();
        }


        CommonClass cs = new CommonClass();

        private void FrmHospitalPatientList_Load(object sender, EventArgs e)
        {
            try
            {
                lvwpatientList.Items.Clear();
                rdoIPD.Checked = true;
                btnLoad.Enabled = true;
            }
            catch
            {
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdoIPD.Checked==true)
                {
                    DataSet ds = cs.GetDataSet("PatientListIpdOpd");

                    lvwpatientList.Items.Clear();
                    btnLoad.Enabled = false;

                    if(ds.Tables[0].Rows.Count >0)
                    {
                        cs.FillUpListview(lvwpatientList, ds, 0);
                    }
                }
                if(rdoOPD.Checked==true)
                {
                    DataSet ds = cs.GetDataSet("PatientListIpdOpd");

                    lvwpatientList.Items.Clear();
                    btnLoad.Enabled = false;

                    if (ds.Tables[1].Rows.Count >0)
                    {
                        cs.FillUpListview(lvwpatientList, ds, 1);

                    }
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
                lvwpatientList.Items.Clear();
                rdoIPD.Checked = true;
                btnLoad.Enabled = true;
                txtSearch.Text = "";
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = cs.GetDataSetWithStringParameter("@Search", txtSearch.Text, "PatientListIpdOpdSearch");

                if (rdoIPD.Checked == true)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lvwpatientList.Items.Clear();
                        cs.FillUpListview(lvwpatientList, ds, 0);
                    }
                    else
                    {
                        MessageBox.Show("No Data Found");
                    }
                }

                if (rdoOPD.Checked == true)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        lvwpatientList.Items.Clear();
                        cs.FillUpListview(lvwpatientList, ds, 1);
                    }
                    else
                    {
                        MessageBox.Show("No Data Found");
                    }
                }
            }
            catch
            {
            }
        }


    }
}
