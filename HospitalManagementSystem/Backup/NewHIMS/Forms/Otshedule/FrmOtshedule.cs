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
using NewHIMS.Reports.Ot;

namespace NewHIMS.Forms.Otshedule
{
    public partial class FrmOtshedule : BaseForm.FrmBase
    {
        public FrmOtshedule()
        {
            InitializeComponent();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
            combo.Text = "<Select>";
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

        void PopulateSurgen()
        {
            OtsheduleBLL otsheduleBLL = new OtsheduleBLL();
            DataSet ds = otsheduleBLL.GetSurgenOperation();
            PopulateComboBox(cmbOperationName, ds, 0, "treatement", "treatement_id");
            PopulateComboBox(cmbSurgeon, ds, 1, "reffered_doctors", "reffered_doctors_id");
            PopulateComboBox(cbmNameOfAna, ds, 2, "reffered_doctors", "reffered_doctors_id");
            PopulateComboBox(cmbAnaesiaNature, ds, 3, "anaesthesia_nature", "anaesthesia_id"); 
        }

        private void FrmOtshedule_Load(object sender, EventArgs e)
        {
            PopulateSurgen();
            SearchOT();
        }

        private void btnOTbookSave_Click(object sender, EventArgs e)
        {
            try
            {

                //if (Convert.ToDateTime(dtpoperationDate.Value.ToString("dd-MMM-yyyy")) < DateTime.Now);
                //{
                //    MessageBox.Show("Date Can Not be  Chosen Then Current Date");
                //    return;
                //}
                OTShedule otshedule = new OTShedule();
                OtsheduleBLL otsheduleBLL = new OtsheduleBLL();

                if (cmbOperationName.Text == "<Select>")
                {
                    MessageBox.Show("Select Operation Name");
                    cmbOperationName.Focus();
                    return;
                }
                else
                    otshedule.operation_id = Convert.ToInt32(cmbOperationName.SelectedValue.ToString());
                if (cmbSurgeon.Text == "<Select>")
                {
                    MessageBox.Show("Select Sergeon Name");
                    cmbSurgeon.Focus();
                    return;
                }
                else
                    otshedule.reffered_doc_id = Convert.ToInt32(cmbOperationName.SelectedValue.ToString());
                if (cbmNameOfAna.Text != "<Select>")
                    otshedule.anaesthesia_id = Convert.ToInt32(cbmNameOfAna.SelectedValue.ToString());
                if(cmbAnaesiaNature.Text!="<Select>")
                    otshedule.anaesthesia_nature_id = Convert.ToInt32(cmbAnaesiaNature.SelectedValue.ToString());
                otshedule.operation_date = Convert.ToDateTime(this.dtpoperationDate.Value.ToString("dd-MMM-yyyy") + " " + this.dtpoperationTime.Value.ToString("hh:mm tt"));
                if (txtName.Text == "")
                {
                    txtName.Focus();
                    return;
                }
                otshedule.patient_name = txtName.Text.ToString();
                otshedule.contact_no = txtContactNo.Text.ToString();
                otshedule.address = txtAddress.Text.ToString();
                otshedule.Room_no = txtroom.Text.ToString();
                otshedule.record_created_by =ApplicatinLauncher._userId;
                otsheduleBLL.OtsheduleADD(otshedule);

                MessageBox.Show("Data Saved Successfully");
                refresh();
            }
            catch
            {
            }
        }

        private void btnOTbookRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            this.txtroom.Text = "";
            this.txtName.Text = "";
            this.txtAddress.Text = "";
            this.txtContactNo.Text = "";
            this.cmbOperationName.Text = "<Select>";
            this.cmbSurgeon.Text = "<Select>";
            this.cbmNameOfAna.Text = "<Select>";
            this.cmbAnaesiaNature.Text = "<Select>";
            this.dtpoperationDate.Value = DateTime.Now;
            this.dtpoperationTime.Value = DateTime.Now;
            lvwOTshedule.Items.Clear();
        }

        void SearchOT()
        {
            this.lvwOTshedule.Items.Clear();
            DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
            DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

            OtsheduleBLL otsheduleBLL = new OtsheduleBLL();
            DataSet ds = otsheduleBLL.GetOT(From, To);
            FillUpListview(lvwOTshedule, ds, 0);
        }

        private void btnOtbookClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchOT();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                ReportDocument rptCustomersOrders = new OTShedulereport();
                

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;
                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password = FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }

                DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                rptCustomersOrders.SetParameterValue("@From", From);
                rptCustomersOrders.SetParameterValue("@To", To);

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