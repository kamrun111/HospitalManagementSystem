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

namespace NewHIMS.Forms.Doctor_Station.Doctor_Visit
{
    public partial class FrmPatientResult : Form
    {
        public FrmPatientResult()
        {
            InitializeComponent();
        }
        private int Investigation_testID=0;

        public void PatientResult(int ID)
        {
            try
            {
                this.Investigation_testID = ID;
                InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                DataSet ds = investigationTestBLL.GetTestElementforDoc(Investigation_testID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        grdMainList.Rows.Add();
                        grdMainList.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();//test_element
                        grdMainList.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();//reference_value
                        grdMainList.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();//result
                    }
                }
                else
                    MessageBox.Show("No Data Found");
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