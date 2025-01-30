using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Receiptions.Test_Report_Delivery
{
    public partial class FrmTestReportDelivery : BaseForm.FrmBase
    {
        
        public FrmTestReportDelivery()
        {
            InitializeComponent();
        }

        private void FillUpListview(ListView lvw, DataSet ds)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[0].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }
        
        
        
        void RefreshContent()
        {
            txtPatientName.Text = "";
            txtPAddress.Text = "";
            txtPContact.Text = "";
            lvwMainList.Items.Clear();
            InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
            DataSet ds = investigationTestBLL.GetInvestigationTestDeliveryInfo();
            FillUpListview(lvwPatientInfo,ds);
        }
        
        
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTestReportDelivery_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.Items.Count > 0)
                {
                    if (lvwPatientInfo.SelectedItems[0].SubItems[2].Text != "")
                    {
                        txtPatientName.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text.ToString();
                        txtPAddress.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
                        txtPContact.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text.ToString();
                    }

                    InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                    DataSet ds = investigationTestBLL.InvestTestInfoByPIDForDelivery(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[4].Text));
                    FillUpListview(lvwMainList, ds);


                }

                

            }
            catch
            { 
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
             if(lvwMainList.Items.Count>0)
             {
                InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                for (int i = 0; i < lvwMainList.Items.Count; i++)
                {
                    investigationTestBLL.SetInvestigationDelivered(Convert.ToInt32(lvwMainList.Items[i].SubItems[1].Text));
                }
                MessageBox.Show("Test Report Delivered Successfully","HIMS");
                RefreshContent();
             }
            }
            catch
            {
            }
        }

      
       
      }
}