using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.OTMedecine;

namespace NewHIMS.Forms.Otshedule
{
    public partial class FrmOTMedicine : BaseForm.FrmBase
    {
        private bool noNeedToContinue = true;
        List<PatientMedicineIndent> lstpatientMedicineIndent = new List<PatientMedicineIndent>();
        List<PatientMedicineIndent> lstpatientMedicineIndentUPRec = new List<PatientMedicineIndent>();

        public FrmOTMedicine()
        {
            InitializeComponent();
        }
        private void FrmOTMedicine_Load(object sender, EventArgs e)
        {
            load();
        
        }
        private int CabinID;
        private string cabin;
        private string hospitalID;
        private int admissionID;
        private int operationNoteID;

        public void OtMedecine(int CabinID,string cabin,string hospitalID, int admissionID, int operationNoteID)
        {
            try
            {
                this.cabin = cabin;
                this.hospitalID = hospitalID;
                this.CabinID = CabinID;
                this.admissionID = admissionID;
                this.operationNoteID = operationNoteID;

                txtPatientCode.Text = hospitalID;
                txtCabin.Text = cabin;
            }
            catch
            { 
            }
        }

        void load()
        {
            try
                {
                    btnSave.Text = "Save";
                    Otreceive(grdOTInjection, 0);
                    Otreceive(grdOtheritem, 0);
                    Otreceive(grdSurgical, 0);

                    ProductBLL productBLL = new ProductBLL();
                    DataSet ds = productBLL.OTMedicineLoad();
                    DataSet Ds = productBLL.OTmedicinebyADID(admissionID);

                    if (Ds.Tables[3].Rows.Count > 0)//for receive condition
                    {
                        txtName.Text = Ds.Tables[3].Rows[0][0].ToString();
                        if (Ds.Tables[3].Rows[0][1].ToString() != null)
                        {
                            txtOTRequisitionNO.Text = Ds.Tables[3].Rows[0][1].ToString();
                        //    txtOTRequisitionNO.ReadOnly = true;
                        //    lnkOTMReceive.Enabled = true;
                        }
                    }
                    grdOTInjection.Rows.Clear();
                    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            this.noNeedToContinue = true;
                            grdOTInjection.Rows.Add();
                            grdOTInjection.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][0].ToString();//product_id
                            grdOTInjection.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();//product      
                        }
                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            for (int j = 0; j < Ds.Tables[0].Rows.Count; j++)
                            {
                                for (int k = 0; k < grdOTInjection.Rows.Count; k++)
                                {
                                    if (Ds.Tables[0].Rows[j][0].ToString() == grdOTInjection.Rows[k].Cells[1].Value.ToString())
                                    {
                                        this.noNeedToContinue = true;
                                        grdOTInjection.Rows[k].Cells[4].Value = Ds.Tables[0].Rows[j][1].ToString();//PMID
                                        grdOTInjection.Rows[k].Cells[5].Value = Ds.Tables[0].Rows[j][2].ToString();//delivery qty
                                        grdOTInjection.Rows[k].Cells[6].Value = Ds.Tables[0].Rows[j][2].ToString();//receive qty
                                        break;
                                    }
                                }
                            }
                            lnkOTMReceive.Enabled = true;
                        }
                    }
                    grdOtheritem.Rows.Clear();//start grdOtheritem
                    if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            grdOtheritem.Rows.Add();
                            this.noNeedToContinue = true;
                            grdOtheritem.Rows[i].Cells[1].Value = ds.Tables[1].Rows[i][0].ToString();//product_id
                            grdOtheritem.Rows[i].Cells[2].Value = ds.Tables[1].Rows[i][1].ToString();//product

                        }
                        if (Ds.Tables[1].Rows.Count > 0)
                        {
                            for (int j = 0; j < Ds.Tables[1].Rows.Count; j++)
                            {
                                for (int k = 0; k < grdOtheritem.Rows.Count; k++)
                                {
                                    if (Ds.Tables[1].Rows[j][0].ToString() == grdOtheritem.Rows[k].Cells[1].Value.ToString())
                                    {
                                        this.noNeedToContinue = true;
                                        grdOtheritem.Rows[k].Cells[4].Value = Ds.Tables[1].Rows[j][1].ToString();//PMID
                                        grdOtheritem.Rows[k].Cells[5].Value = Ds.Tables[1].Rows[j][2].ToString();//delivery qty
                                        grdOtheritem.Rows[k].Cells[6].Value = Ds.Tables[1].Rows[j][2].ToString();//receive qrt
                                        lnkOTMReceive.Enabled = true;
                                        break;
                                    }
                                }
                            }
                            lnkOTMReceive.Enabled = true;
                        }
                    }//end grdOtheritem
                    grdSurgical.Rows.Clear();//start grdSurgical
                    if (ds.Tables[2] != null && ds.Tables[2].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                        {
                            this.noNeedToContinue = true;
                            grdSurgical.Rows.Add();
                            grdSurgical.Rows[i].Cells[1].Value = ds.Tables[2].Rows[i][0].ToString();//product_id
                            grdSurgical.Rows[i].Cells[2].Value = ds.Tables[2].Rows[i][1].ToString();//product
                            
                        }
                        if (Ds.Tables[2].Rows.Count > 0)//to match with current order
                        {
                            for (int j = 0; j < Ds.Tables[2].Rows.Count; j++)
                            {
                                for (int k = 0; k < grdSurgical.Rows.Count; k++)
                                {
                                    if (Ds.Tables[2].Rows[j][0].ToString() == grdSurgical.Rows[k].Cells[1].Value.ToString())
                                    {
                                        this.noNeedToContinue = true;
                                        grdSurgical.Rows[k].Cells[4].Value = Ds.Tables[2].Rows[j][1].ToString();//PMID
                                        grdSurgical.Rows[k].Cells[5].Value = Ds.Tables[2].Rows[j][2].ToString();//delivery qty
                                        grdSurgical.Rows[k].Cells[6].Value = Ds.Tables[2].Rows[j][2].ToString();//receive qty
                                        
                                        break;
                                    }
                                }
                            }
                            lnkOTMReceive.Enabled = true;
                        }
                    }//end grdSurgical
                }
                catch
                {
                }

        }

        private void grdOTInjection_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
                grdOTInjection.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOTRequisitionNO.Text == "")
                {
                    MessageBox.Show("Input Requisiton No");
                    txtOTRequisitionNO.Focus();
                    return;
                }
                int result = 0;
                int result1 = 0;
                int result2 = 0;
                if (btnSave.Text == "Save")
                {
                    OperationNote operationNote = new OperationNote();
                    OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                    operationNote.admission_id = admissionID;
                    operationNote.ot_requisition_no = txtOTRequisitionNO.Text.ToString();
                    operationNote.operation_note_id = operationNoteID;
                    //operationNoteBLL.OTnoteMedicineUpdate(operationNote);

                    PatientMedicineIndentOrder patientMedicineIndentOrder = new PatientMedicineIndentOrder();
                    PatientMedicineIndentOrderBLL patientMedicineIndentOrderBLL = new PatientMedicineIndentOrderBLL();
                    patientMedicineIndentOrder.admission_id = admissionID;
                    patientMedicineIndentOrder.cabin_id = CabinID;
                    patientMedicineIndentOrder.station = 1;
                    patientMedicineIndentOrder.record_created_by = ApplicatinLauncher._userId;


                    
                    StoreIntoList(grdOTInjection);
                    StoreIntoList(grdOtheritem);
                    StoreIntoList(grdSurgical);
                    
                    if (lstpatientMedicineIndent.Count > 0)
                    {
                        result = patientMedicineIndentOrderBLL.OtMedicineIndent(operationNote, patientMedicineIndentOrder, lstpatientMedicineIndent);
                        //result = patientMedicineIndentBLL.AddPatientMedicineIndent(patientMedicineIndent);//procedure patient_medicine_indentAdd
                        lstpatientMedicineIndent.Clear();
                    }
                }
                else
                {
                    PatientMedicineIndentBLL patientMedicineIndentBLL = new PatientMedicineIndentBLL();
                    StoreIntoList(grdOTInjection);
                    StoreIntoList(grdOtheritem);
                    StoreIntoList(grdSurgical);
                    if (lstpatientMedicineIndentUPRec.Count > 0)
                    {
                        result2 = patientMedicineIndentBLL.patient_medicine_indentUpdateReceiveList(lstpatientMedicineIndentUPRec);//procedure patient_medicine_indentUpdateReceiveList
                        lstpatientMedicineIndentUPRec.Clear();
                        lnkOTMReceive.Enabled = false;

                    }
                }
                if (result > 0 || result1 > 0 || result2 > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                    grdOtheritem.Enabled = false;
                    grdOTInjection.Enabled = false;
                    grdSurgical.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Data Save Failed");
                }
            }
            catch
            {
            }
        }

        private void StoreIntoList(DataGridView grdView)
        {
            try
            {
                for (int i = 0; i < grdView.Rows.Count; i++)
                {
                    PatientMedicineIndent patientMedicineIndent = new PatientMedicineIndent();
                    {

                        if (btnSave.Text == "Save")
                        {
                            if (grdView.Rows[i].Cells[3].Value != null )
                            {
                                patientMedicineIndent.admission_id = admissionID;
                                patientMedicineIndent.cabin_id = CabinID;
                                patientMedicineIndent.product_id = Convert.ToInt32(grdView.Rows[i].Cells[1].Value);
                                patientMedicineIndent.quantity_ordered = Convert.ToInt32(grdView.Rows[i].Cells[3].Value);
                                patientMedicineIndent.station = 1;
                                patientMedicineIndent.store_id = 1;
                                patientMedicineIndent.record_created_by = ApplicatinLauncher._userId;
                                lstpatientMedicineIndent.Add(patientMedicineIndent);
                                patientMedicineIndent = null;//have to consider that
                            }
                        }
                        if (btnSave.Text == "Receive")
                        {
                            //if (grdView.Rows[i].Cells[7].Value != null && grdView.Rows[i].Cells[6].Value != null)//update receive
                            if (grdView.Rows[i].Cells[6].Value != null)
                            {
                                patientMedicineIndent.quantity_received = Convert.ToInt32(grdView.Rows[i].Cells[6].Value);//receice qty
                                patientMedicineIndent.store_id = 3;
                                patientMedicineIndent.record_modified_by = ApplicatinLauncher._userId;
                                patientMedicineIndent.patient_medicine_indent_id = Convert.ToInt32(grdView.Rows[i].Cells[4].Value);//PMID
                                lstpatientMedicineIndentUPRec.Add(patientMedicineIndent);
                                patientMedicineIndent = null;
                            }
                        }

                    }

                    patientMedicineIndent = null;
                }
            }
            catch
            {
                MessageBox.Show("Data Saved Failed");
            }
            finally
            {                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
            btnSave.Enabled = true;
            grdOtheritem.Enabled = true;
            grdOTInjection.Enabled = true;
            grdSurgical.Enabled = true;
        }


        private void grdSurgical_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdSurgical.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);
                if (e.ColumnIndex == 3)
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

        private void grdOTInjection_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdOTInjection.Rows[e.RowIndex];
                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);

                if (e.ColumnIndex == 3)
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

        private void grdOtheritem_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdOtheritem.Rows[e.RowIndex];

                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);

                if (e.ColumnIndex == 3)
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

        private void lnkOTMReceive_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Receive";
            Otreceive(grdOTInjection,1);
            Otreceive(grdOtheritem,1);
            Otreceive(grdSurgical,1);
        }

        private void Otreceive(DataGridView grdreceive, int z)
        {
            try
            {
                if (z == 1)
                {
                    grdreceive.Columns[3].Visible = false;
                    grdreceive.Columns[4].Visible = false;//pimd
                    grdreceive.Columns[5].Visible = true;//delivery qty
                    grdreceive.Columns[6].Visible = true;//receiveqty
                }
                if (z == 0)
                {

                    grdreceive.Columns[3].Visible = true;
                    grdreceive.Columns[4].Visible = false;//pimd
                    grdreceive.Columns[5].Visible = false;//delivery qty
                    grdreceive.Columns[6].Visible = false;//receiveqty

                }
            }
            catch
            { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OTMedecinerpt();
                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                rptCustomersOrders.SetParameterValue("@AdmissionID", admissionID);
                rptCustomersOrders.SetParameterValue("@getAdmissionID", admissionID);

                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }
    }

}