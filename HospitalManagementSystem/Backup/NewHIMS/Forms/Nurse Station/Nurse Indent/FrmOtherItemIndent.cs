using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Nurse_Station.Nurse_Indent
{
    public partial class FrmOtherItemIndent : BaseForm.FrmBase
    {
        public FrmOtherItemIndent()
        {
            InitializeComponent();
        }
        private bool noNeedToContinue = true;
        private int admissionID = 0;
        private int cabinID = 0;
        private int opdaadmissionID = 0;

        

        public void IndentInfo(int AdmissionId, int CabinID)
        {
            try
            {
                this.admissionID = AdmissionId;
                this.cabinID = CabinID;

                ProductBLL productBLL = new ProductBLL();
                DataSet dsc = productBLL.GetCategoryforOtherIndent(2);
                if (dsc.Tables[0].Rows.Count > 0)
                {
                    this.cmbCategory.SelectedIndexChanged -= this.cmbCategory_SelectedIndexChanged;
                    PopulateComboBox(cmbCategory, dsc, 0, "product_category", "product_category_id");
                    this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
                }
                PatientMedicineIndentBLL patientMedicineIndentBLL = new PatientMedicineIndentBLL();
                DataSet ds = patientMedicineIndentBLL.OtherItemsLoad(AdmissionId, CabinID);
                //this.cmbproduct.SelectedIndexChanged -= this.cmbproduct_SelectedIndexChanged;
                //cmbproduct.Enabled = true;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtCabin.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtPatientName.Text = ds.Tables[0].Rows[0][1].ToString();

                }

            }
            catch
            {
            }
        }
        public void OPDIndentInfo(int opdAdmissionid)
        {
            try
            {
                this.opdaadmissionID = opdAdmissionid;

                ProductBLL productBLL = new ProductBLL();
                DataSet dsc = productBLL.GetCategoryforOtherIndent(2);
                if (dsc.Tables[0].Rows.Count > 0)
                {
                    this.cmbCategory.SelectedIndexChanged -= this.cmbCategory_SelectedIndexChanged;
                    PopulateComboBox(cmbCategory, dsc, 0, "product_category", "product_category_id");
                    this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
                }

                OPDpatientMedicineIndentBLL opdpatientMedicineIndentBLL = new OPDpatientMedicineIndentBLL();
                DataSet da = opdpatientMedicineIndentBLL.getopdinfo(opdaadmissionID);
                if (da.Tables[0].Rows.Count > 0)
                {
                    lblPatientMedicineIndentTitle.Text = "OPD Item Indent";
                    label1.Text = "Reg.ID";
                    txtCabin.Text = da.Tables[0].Rows[0][0].ToString();
                    txtPatientName.Text = da.Tables[0].Rows[0][1].ToString();

                }
            }
            catch
            {
            }
        }
        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[tableIndex];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                combo.SelectedIndex = -1;
                combo.Text = "<Select>";
            }
            catch
            {
            }
        }
        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbproduct.SelectedIndex != -1)
                //{
                    ProductBLL productBLL = new ProductBLL();
                    DataSet da = productBLL.getMedecineStock(Convert.ToInt32(cmbproduct.SelectedValue));
                    if (Convert.ToInt32(da.Tables[0].Rows[0][0].ToString()) < 1)
                    {
                        MessageBox.Show(" Stock Empty");
                        return;
                    }
                    else
                    {
                        grdMainList.Rows.Add();
                        grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[0].Value = Convert.ToInt16(cmbproduct.SelectedValue);
                        grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[1].Value = cmbproduct.Text;
                        grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[2].Value = 1;
                        grdMainList.Rows[grdMainList.Rows.Count - 1].Cells[3].Value = da.Tables[0].Rows[0][0].ToString();
                    }
                //}
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh(); 
        }
        void refresh()
        {
            grdMainList.Rows.Clear();
            cmbproduct.Text = "<Select>";
            btnSave.Enabled = true;
            grdMainList.Rows.Clear();
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdMainList.Rows.Count == 0)
                    return;
                if (MessageBox.Show("Do You Want To Save Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                int Result = 0;
                if (lblPatientMedicineIndentTitle.Text != "OPD Item Indent")
                {
                    PatientMedicineIndentOrder patientMedicineIndentOrder = new PatientMedicineIndentOrder();
                    PatientMedicineIndentOrderBLL patientMedicineIndentOrderBLL = new PatientMedicineIndentOrderBLL();
                    List<PatientMedicineIndent> lstpatientMedicineIndent = new List<PatientMedicineIndent>();
                    patientMedicineIndentOrder.admission_id = admissionID;
                    patientMedicineIndentOrder.cabin_id = cabinID;
                    if (ApplicatinLauncher._GroupName == "Post Operative")
                    {
                        patientMedicineIndentOrder.station = 2;
                    }
                    else
                    {
                        patientMedicineIndentOrder.station = 0;
                    }
                    patientMedicineIndentOrder.record_created_by = ApplicatinLauncher._userId;

                    for (int i = 0; i < grdMainList.Rows.Count; i++)
                    {
                        if (grdMainList.Rows[i].Cells[2] != null)
                        {
                            PatientMedicineIndent patientMedicineIndent = new PatientMedicineIndent();
                            patientMedicineIndent.admission_id = admissionID;
                            patientMedicineIndent.cabin_id = cabinID;
                            patientMedicineIndent.product_id = Convert.ToInt32(grdMainList.Rows[i].Cells[0].Value);
                            patientMedicineIndent.quantity_ordered = Convert.ToInt32(grdMainList.Rows[i].Cells[2].Value);
                            patientMedicineIndent.record_created_by = ApplicatinLauncher._userId;
                            patientMedicineIndent.store_id = 1;
                            if (ApplicatinLauncher._GroupName == "Post Operative")
                            {
                                patientMedicineIndentOrder.station = 2;
                            }
                            else
                            {
                                patientMedicineIndentOrder.station = 0;
                            }
                            lstpatientMedicineIndent.Add(patientMedicineIndent);
                        }
                    }
                    Result = patientMedicineIndentOrderBLL.MedicineIndent(patientMedicineIndentOrder, lstpatientMedicineIndent);
                }
                else
                {
                    OPD_patient_medicine_order opd_patient_medicine_order = new OPD_patient_medicine_order();
                    OPD_patient_medicine_orderBLL opd_patient_medicine_orderBLL = new OPD_patient_medicine_orderBLL();
                    List<OPDpatientMedicineIndent> lstOPDpatientMedicineIndent = new List<OPDpatientMedicineIndent>();
                    opd_patient_medicine_order.PKID = opdaadmissionID;
                    opd_patient_medicine_order.indent_by = ApplicatinLauncher._userId;
                    for (int i = 0; i < grdMainList.Rows.Count; i++)
                    {
                        if (grdMainList.Rows[i].Cells[2] != null)
                        {
                            OPDpatientMedicineIndent opdpatientMedicineIndent = new OPDpatientMedicineIndent();
                            opdpatientMedicineIndent.product_id = Convert.ToInt32(grdMainList.Rows[i].Cells[0].Value);
                            opdpatientMedicineIndent.qty_ordered = Convert.ToInt32(grdMainList.Rows[i].Cells[2].Value);
                            opdpatientMedicineIndent.record_created_by = ApplicatinLauncher._userId;

                            lstOPDpatientMedicineIndent.Add(opdpatientMedicineIndent);
                        }
                    }
                    Result = opd_patient_medicine_orderBLL.OPDmedicineIndent(opd_patient_medicine_order, lstOPDpatientMedicineIndent);


                }
                if (Result > 0)
                {
                    MessageBox.Show("data Saved successfully");
                    btnSave.Enabled = false;
                    grdMainList.Rows.Clear();
                    cmbproduct.Text="<Select>";
                }

            }
            catch
            {
            }
        }

        private void grdMainList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
                row = this.grdMainList.Rows[e.RowIndex];

                string valueStr = (row.Cells[e.ColumnIndex].Value == null ? "" : row.Cells[e.ColumnIndex].Value.ToString());
                double valueNumeric = 0;
                double.TryParse(valueStr, out valueNumeric);

                if (e.ColumnIndex == 2)
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductBLL productBLL = new ProductBLL();
                DataSet Dsp = productBLL.GetProductforOtherIndent(Convert.ToInt32(cmbCategory.SelectedValue));
                this.cmbproduct.SelectedIndexChanged -= this.cmbproduct_SelectedIndexChanged;
                cmbproduct.Enabled = true;
                if (Dsp.Tables[0].Rows.Count > 0)
                {
                    PopulateComboBox(cmbproduct, Dsp, 0, "product", "product_id");

                }
                this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            }
            catch
            {
            }
        }

        private void grdMainList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Delete?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.btnDelete.Enabled = false;
                    return;

                }
                grdMainList.Rows.Remove(grdMainList.SelectedRows[0]);
                btnDelete.Enabled = false;
            }
            catch
            {
            }
        }

    }
}