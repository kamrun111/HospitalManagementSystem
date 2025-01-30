using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using NewHIMS.Reports.Cabin;

namespace NewHIMS.Forms.Receiptions.Cabin_Transfer
{
    public partial class FrmCabinTransfer : BaseForm.FrmBase
    {
        private int _admissionID = 0;
        Boolean flag = true;


        public FrmCabinTransfer()
        {
            InitializeComponent();
        }


        void PapulateCabinListView(DataSet ds) {

            lvwCabin.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[0].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    lvi.SubItems.Add(dataRow[1].ToString());
                    lvi.SubItems.Add(dataRow[2].ToString());
                    lvi.SubItems.Add(dataRow[3].ToString());

                    lvwCabin.Items.Add(lvi);
                    if (dataRow[3].ToString() == "Free")
                        lvi.ForeColor = Color.Teal;
                    else if (dataRow[3].ToString() == "Booked")
                        lvi.ForeColor = Color.Maroon;
                }
            }        
        }


        void RefreshContents()
        {
            CabinTranferBLL cabinTransferBLL = new CabinTranferBLL();
            DataSet ds = cabinTransferBLL.GetNonOccupiedCabinInfo();
            PapulateCabinListView(ds);
            txtPatientCode.Text = "";
            GuardianName.Text = "";
            txtAddress.Text = "";
            txtCPhone.Text = "";
            txtPatientName.Text = "";
            txtCabin.Text="";
            txtadmissioncode.Text = "";
            btnSave.Enabled = false;
            ds = null;

            txtPatientCode.ReadOnly = false;
            txtCabin.ReadOnly = false;
            txtPatientCode.Focus();
            InvestigationBLL investigationBLL = new InvestigationBLL();
            DataSet dset = investigationBLL.GetIPDInvestigationPopulationInfo();
            if (dset.Tables[0].Rows.Count > 0)
            {
                FillUpListview(lvwPatientInfo, dset, 0);
            }
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
                    for (int j = 1; j < lvw.Columns.Count; j++)//gdgdg
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }


        private void txtPatientCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtPatientCode.Text != "")
                {
                    CabinTranferBLL cabinTransferBLL = new CabinTranferBLL();
                                       
                    DataSet ds=cabinTransferBLL.GetCabinTransferPopulationInfo(Convert.ToInt32(txtPatientCode.Text),"@");
                    
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0][0].ToString() != "")
                            txtCabin.Text = ds.Tables[0].Rows[0][0].ToString();
                        if (ds.Tables[0].Rows[0][1].ToString() != "")
                            txtPatientName.Text = ds.Tables[0].Rows[0][1].ToString();
                        if (ds.Tables[0].Rows[0][2].ToString() != "")
                            GuardianName.Text = ds.Tables[0].Rows[0][2].ToString();
                        if (ds.Tables[0].Rows[0][3].ToString() != "")
                            txtAddress.Text = ds.Tables[0].Rows[0][3].ToString();
                        if (ds.Tables[0].Rows[0][4].ToString() != "")
                            txtCPhone.Text = ds.Tables[0].Rows[0][4].ToString();
                        if (ds.Tables[0].Rows[0][5].ToString() != "")
                            this._admissionID = Convert.ToInt32(ds.Tables[0].Rows[0][5]);

                        flag = false;
                        txtPatientCode.ReadOnly = true;
                        txtCabin.ReadOnly = true;
                        btnPrint.Enabled = true;
                    }
                    else
                    {
                        GuardianName.Text = "";
                        txtAddress.Text = "";
                        txtCPhone.Text = "";
                        txtPatientName.Text = "";
                        txtCabin.Text = "";

                        txtPatientCode.ReadOnly = false;
                        txtCabin.ReadOnly = false;
                        btnPrint.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshContents();
        }

        private void FrmCabinTransfer_Load(object sender, EventArgs e)
        {
            RefreshContents();
        }

        private void txtCabin_TextChanged(object sender, EventArgs e)
        {
                CabinTranferBLL cabinTransferBLL = new CabinTranferBLL();
                DataSet ds = cabinTransferBLL.GetNonOccupiedCabinInfo();
                PapulateCabinListView(ds);
        }

        private void txtCabin_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (txtCabin.Text != "")
                    {
                        CabinTranferBLL cabinTransferBLL = new CabinTranferBLL();

                        DataSet ds = cabinTransferBLL.GetCabinTransferPopulationInfo(0, txtCabin.Text.ToString());

                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            if (ds.Tables[1].Rows[0][0].ToString() != "")
                                txtPatientCode.Text = ds.Tables[1].Rows[0][0].ToString();
                            if (ds.Tables[1].Rows[0][1].ToString() != "")
                                txtPatientName.Text = ds.Tables[1].Rows[0][1].ToString();
                            if (ds.Tables[1].Rows[0][2].ToString() != "")
                                GuardianName.Text = ds.Tables[1].Rows[0][2].ToString();
                            if (ds.Tables[1].Rows[0][3].ToString() != "")
                                txtAddress.Text = ds.Tables[1].Rows[0][3].ToString();
                            if (ds.Tables[1].Rows[0][4].ToString() != "")
                                txtCPhone.Text = ds.Tables[1].Rows[0][4].ToString();
                            if (ds.Tables[1].Rows[0][5].ToString() != "")
                                this._admissionID = Convert.ToInt32(ds.Tables[1].Rows[0][5]);

                            flag = false;
                            txtPatientCode.ReadOnly = true;
                            txtCabin.ReadOnly = true;
                            btnPrint.Enabled = true;
                        }
                        else
                        {
                            GuardianName.Text = "";
                            txtAddress.Text = "";
                            txtCPhone.Text = "";
                            txtPatientName.Text = "";
                            txtPatientCode.Text = "";

                            txtPatientCode.ReadOnly = false;
                            txtCabin.ReadOnly = false;
                            btnPrint.Enabled = true;
                        }
                    }
                }
            }
            catch 
            { 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to transfer the Patient?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                if (txtPatientCode.Text == "")
                {
                    MessageBox.Show("Please Insert Patient Code");
                    return;
                }
                if (lvwCabin.SelectedItems.Count > 0)
                {
                    Cabin cabin = new Cabin();
                    AdmissionBO admissionBO = new AdmissionBO();
                    CabinBLL cabinBLL = new CabinBLL();

                    cabin.cabin_id = Convert.ToInt32(lvwCabin.SelectedItems[0].SubItems[0].Text);
                    cabin.cabin = txtCabin.Text;
                    admissionBO.admission_id = this._admissionID;
                    cabinBLL.UpdateForCabinTransfere(cabin, admissionBO);
                  
                    InsertIntoCabinTransfer();
                    MessageBox.Show("Cabin Transferred Successfully");
                    RefreshContents();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Please Select a Cabin From the List");
                }
            }
            catch 
            { 
            }
        }
        private void InsertIntoCabinTransfer()
        {
            CabinTranfer cabinTranfer = new CabinTranfer();
            CabinTranferBLL cabinTranferBLL = new CabinTranferBLL();

            cabinTranfer.admission_id=this._admissionID;
            cabinTranfer.cabin_id = Convert.ToInt32(lvwCabin.FocusedItem.Text.ToString());
            cabinTranfer.record_created_by=ApplicatinLauncher._userId;
            
            cabinTranferBLL.Addcabin_tranfer(cabinTranfer);
        }

        private void lvwCabin_Click(object sender, EventArgs e)
        {
           if(lvwCabin.SelectedItems.Count>0)
           {
                if(flag==false )
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
           }
        }

        private void txtPatientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatientName.Focus();
            }
        }

        private void txtGuardianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatientName.Focus();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAddress.Focus();
            }
        }

        private void txtCPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPhone.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {                
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new CabinTransferePrint();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser; ;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                rptCustomersOrders.SetParameterValue("@admission_id", _admissionID);
               
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
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
                    txtPatientCode.Text = lvwPatientInfo.SelectedItems[0].SubItems[2].Text.ToString();
                    txtadmissioncode.Text = lvwPatientInfo.SelectedItems[0].SubItems[6].Text.ToString();
                    txtPatientCode.Focus();

                }
            }
            catch
            {
            }
        }

       
    }
}