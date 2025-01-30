using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using NewHIMS.Forms.Nurse_Station.Nurse_Indent;
using NewHIMS.Forms.OPD_Patient.OPD_Medicine_Refund;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace NewHIMS.Forms.OPD_Patient
{
    public partial class FrmOPDOT : Form
    {
        public FrmOPDOT()
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

        private void FrmOPDOT_Load(object sender, EventArgs e)
        {
            try
            {
                AdmissionBLL admissionBLL = new AdmissionBLL();
                DataSet ds = admissionBLL.getopdpatient();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientInfo, ds);
                }
            }
            catch
            {
            }
        }

        private void btnmedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    FrmPatientMedicineIndentListView frmPatientMedicineIndentListView = new FrmPatientMedicineIndentListView();
                    frmPatientMedicineIndentListView.opdpatientload(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text));
                    frmPatientMedicineIndentListView.ShowDialog();
                }
                else
                    MessageBox.Show("Select A Patient");

            }
            catch
            {
            }
        }

        private void btnOt_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    FrmOPDmedicineRefund frmOPDmedicineRefund = new FrmOPDmedicineRefund();
                    frmOPDmedicineRefund.opdSales(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text));
                    frmOPDmedicineRefund.ShowDialog();
                }
                else
                    MessageBox.Show("Select A Patient");

            }
            catch
            {
            }
        }

        private void btnTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    Frmopdotherservice frmopdotherservice = new Frmopdotherservice();
                    frmopdotherservice.load(Convert.ToInt32(this.lvwPatientInfo.SelectedItems[0].Text),lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString());
                    frmopdotherservice.ShowDialog();
                }
                else
                    MessageBox.Show("Select A Patient");

            }
            catch
            {
            }
        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwPatientInfo.SelectedItems.Count > 0)
                {
                    txtpatient.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;
                    txtregID.Text = lvwPatientInfo.SelectedItems[0].SubItems[1].Text;
                    txtdoc.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text;
                    txtaddress.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                }
                else
                    MessageBox.Show("Select A Patient");
            }
            catch
            {
            }
        }
       
    }
}