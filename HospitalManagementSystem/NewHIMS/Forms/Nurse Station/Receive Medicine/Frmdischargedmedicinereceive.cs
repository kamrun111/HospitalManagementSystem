using System;
using HIMS.BLL;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HIMS.BusinessObjects;
using System.ComponentModel;
using System.Collections.Generic;


namespace NewHIMS.Forms.Nurse_Station.Receive_Medicine
{
    public partial class Frmdischargedmedicinereceive : BaseForm.FrmBase
    {
        public Frmdischargedmedicinereceive()
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

        private void Frmdischargedmedicinereceive_Load(object sender, EventArgs e)
        {
            try
            {
                display();
            }
            catch
            {
            }
        }
        private void display()
        {
            try
            {
                PatientMedicineIndentOrderBLL patientMedicineIndentOrderBLL = new PatientMedicineIndentOrderBLL();
                DataSet ds = patientMedicineIndentOrderBLL.dischargemedicinereceive();
                FillUpListview(lvwPatientInfo, ds);
                txtDeliveredBy.Text = "";
                txtDeliveryDate.Text = "";
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
                    txtDeliveredBy.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                    txtDeliveryDate.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text;

                    PatientMedicineIndentBLL patientMedicineIndentBLL = new PatientMedicineIndentBLL();
                    DataSet ds = patientMedicineIndentBLL.ReceiveDetailforNurse(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text));
                    grdMedicineIndent.Rows.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdMedicineIndent.Rows.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdMedicineIndent.Rows.Add();
                            grdMedicineIndent.Rows[i].Cells["admission_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["admission_id"].ToString());                                      //admn_id
                            grdMedicineIndent.Rows[i].Cells["cabin_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["cabin_id"].ToString());                                     //cabin_id
                            grdMedicineIndent.Rows[i].Cells["product_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["product_id"].ToString());
                            grdMedicineIndent.Rows[i].Cells["medicine"].Value = ds.Tables[0].Rows[i]["product"].ToString();
                            grdMedicineIndent.Rows[i].Cells["quantity_ordered"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["quantity_ordered"].ToString());
                            grdMedicineIndent.Rows[i].Cells["quantity_delivered"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["quantity_delivered"].ToString());
                            grdMedicineIndent.Rows[i].Cells["quantity_received"].Value = ds.Tables[0].Rows[i]["quantity_delivered"].ToString();
                            grdMedicineIndent.Rows[i].Cells["PMIID"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["patient_medicine_indent_id"].ToString());
                        }
                        btnIndent.Enabled = true;
                    }
                    else
                        btnIndent.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grdMedicineIndent.Rows.Clear();
            display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIndent_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdMedicineIndent.Rows.Count > 0)
                {
                    List<PatientMedicineIndent> lstPatientMedicineIndent = new List<PatientMedicineIndent>();
                    PatientMedicineIndentBLL patientMedicineIndentBLL = new PatientMedicineIndentBLL();
                    for (int k = 0; k < grdMedicineIndent.Rows.Count; k++)
                    {
                        PatientMedicineIndent patientMedicineIndent = new PatientMedicineIndent();

                        patientMedicineIndent.patient_medicine_indent_id = Convert.ToInt32(grdMedicineIndent.Rows[k].Cells["PMIID"].Value);
                        patientMedicineIndent.quantity_received = Convert.ToInt32(grdMedicineIndent.Rows[k].Cells["quantity_received"].Value);
                        patientMedicineIndent.received_by = ApplicatinLauncher._userId;
                        lstPatientMedicineIndent.Add(patientMedicineIndent);

                    }
                    int p = patientMedicineIndentBLL.medicineNursereceive(lstPatientMedicineIndent);
                }
                MessageBox.Show("Data Saved Successfully");
                grdMedicineIndent.Rows.Clear();
                display();
                
            }

            catch
            {
            }
        }
    }
}