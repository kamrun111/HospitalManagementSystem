using System;
using HIMS.BLL;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HIMS.BusinessObjects;
using System.ComponentModel;
using System.Collections.Generic;
using NewHIMS.Forms.ReqisitionHIMS;

namespace NewHIMS.Forms.Nurse_Station.Nurse_Indent
{
    public partial class FrmPatientMedicineIndentListView : BaseForm.FrmBase
    {
        private int _admissionID = 0;
        private int _cabinID = 0;
        private int _opdadmissionID = 0;
        //private DataSet dsIndentInfo;
        private int flag = 0;
        private bool noNeedToContinue = true;
        public FrmPatientMedicineIndentListView()
        {
            InitializeComponent();
        }

        public void refreshContent(int admnID,int cabinID)
        {
            try
            {
                //grdreceive.Visible = false;
                this._admissionID=admnID;
                this._cabinID = cabinID;
                if (admnID != 0)
                {
                    PatientMedicineIndentBLL patientMedicineIndentBLL = new PatientMedicineIndentBLL();
                    DataSet dso = patientMedicineIndentBLL.OrderListforReceive(admnID);
                    if (dso.Tables[0].Rows.Count > 0)
                    {
                        FillUpListview(lvwPatientInfo,dso);
                    }
                    

               }
            }
                 
            catch
            {
            }
        }
        public void opdpatientload(int opdadmissionID)//for opd patient
        {
            try
            {
                this.flag = 1;
                this._opdadmissionID = opdadmissionID;
                OPDpatientMedicineIndentBLL opdpatientMedicineIndentBLL = new OPDpatientMedicineIndentBLL();
                DataSet ds = opdpatientMedicineIndentBLL.getmedicinedelivery(opdadmissionID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillUpListview(lvwPatientInfo, ds);
                }
                lblPatientMedicineIndentTitle.Text="OPD Medicine Receive";
            }
            catch
            {
            }


        }

        private void FillUpListview(ListView lvw, DataSet ds)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[0].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvi.SubItems.Add(dataRow[4].ToString());
                       
                        lvw.Items.Add(lvi);
                        
                    }
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

        private void btnIndent_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (lblPatientMedicineIndentTitle.Text == "OPD Medicine Receive")
                {
                    if (grdMedicineIndent.Rows.Count > 0)
                    {
                        OPD_patient_medicine_order opd_patient_medicine_order = new OPD_patient_medicine_order();
                        OPD_patient_medicine_orderBLL opd_patient_medicine_orderBLL=new OPD_patient_medicine_orderBLL();

                        opd_patient_medicine_order.received_by = ApplicatinLauncher._userId;
                        opd_patient_medicine_order.opd_patient_medicine_order_id = Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text);

                        int j = opd_patient_medicine_orderBLL.opdmedicinereceive(opd_patient_medicine_order);
                        MessageBox.Show("Data Saved Successfully");
                        grdMedicineIndent.Rows.Clear();
                        opdpatientload(_opdadmissionID);
                        
                    }

                }
                else
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
                    refreshContent(this._admissionID, this._cabinID);
                }
            }

            catch
            {
            }
        }

        private void grdMedicineIndent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.noNeedToContinue == true)
            {

                this.noNeedToContinue = false;
                return;
            }

            string msg = "";
            DataGridViewRow row = null;
            try
            {
                row = this.grdMedicineIndent.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 4)
                {
                    if (valueNumeric <= 0)
                    {
                        msg = "Please provide a valid Order quantity";
                    }
                }

            }
            catch
            {
            }
            finally
            {

                if (msg != "")
                {

                    MessageBox.Show(msg, "HIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.noNeedToContinue = true;
                    row.Cells[e.ColumnIndex].Value = null;
                    row.Cells[e.ColumnIndex].Selected = true;
                }
            }
        }

        private void btnOtherItemIndent_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 0)
                {
                    FrmOtherItemIndent frmOtherItemIndent = new FrmOtherItemIndent();
                    frmOtherItemIndent.IndentInfo(this._admissionID, this._cabinID);
                    frmOtherItemIndent.Show();
                }
                else //for opd patient
                {
                    FrmOtherItemIndent frmOtherItemIndent = new FrmOtherItemIndent();
                    frmOtherItemIndent.OPDIndentInfo(this._opdadmissionID);
                    frmOtherItemIndent.ShowDialog();
                }
            }
            catch
            {
            }
            
        }

        private void FrmPatientMedicineIndentListView_Load(object sender, EventArgs e)
        {

        }

    
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                grdMedicineIndent.Rows.Clear();
                if (lblPatientMedicineIndentTitle.Text == "OPD Medicine Receive")
                {
                    opdpatientload(_opdadmissionID);
                }
                else
                refreshContent(this._admissionID, this._cabinID);
            }
            catch
            {
            }

        }

        private void lvwPatientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblPatientMedicineIndentTitle.Text == "OPD Medicine Receive")
                {
                    if (lvwPatientInfo.SelectedItems.Count > 0)
                    {
                        txtDeliveredBy.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;
                        txtDeliveryDate.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                        txtpatientName.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text;

                        OPDpatientMedicineIndentBLL opdpatientMedicineIndentBLL = new OPDpatientMedicineIndentBLL();
                        DataSet ds = opdpatientMedicineIndentBLL.getopdmedicinedelivery(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].Text));
                        grdMedicineIndent.Rows.Clear();
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                grdMedicineIndent.Rows.Add();
                                grdMedicineIndent.Rows[i].Cells["admission_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["opd_patient_medicine_indent_id"].ToString());                                      //admn_id
                                grdMedicineIndent.Rows[i].Cells["medicine"].Value = ds.Tables[0].Rows[i]["product"].ToString();
                                grdMedicineIndent.Rows[i].Cells["quantity_ordered"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["qty_ordered"].ToString());
                                grdMedicineIndent.Rows[i].Cells["quantity_delivered"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["qty_received"].ToString());
                                grdMedicineIndent.Rows[i].Cells["quantity_received"].Value = ds.Tables[0].Rows[i]["qty_received"].ToString();
                            }
                            btnIndent.Enabled = true;
                        }
                        else
                            btnIndent.Enabled = false;


                    }
                }
                else
                {
                    if (lvwPatientInfo.SelectedItems.Count > 0)
                    {
                        txtDeliveredBy.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text;
                        txtDeliveryDate.Text = lvwPatientInfo.SelectedItems[0].SubItems[3].Text;
                        txtpatientName.Text = lvwPatientInfo.SelectedItems[0].SubItems[4].Text;

                        PatientMedicineIndentBLL patientMedicineIndentBLL = new PatientMedicineIndentBLL();
                        DataSet ds = patientMedicineIndentBLL.ReceiveDetailforNurse(Convert.ToInt32(lvwPatientInfo.SelectedItems[0].SubItems[0].Text));
                        grdMedicineIndent.Rows.Clear();
                        if (ds.Tables[0].Rows.Count > 0)
                        {

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
            }
            catch
            {
            }
        }
            
    }
}