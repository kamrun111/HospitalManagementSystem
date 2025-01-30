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
using CrystalDecisions.CrystalReports.Engine;
//using NewHIMS.Reports;
//using NewHIMS.Reports.Investigation;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmDoctor_sPay : Form
    {
        public FrmDoctor_sPay()
        {
            InitializeComponent();
        }

        private void rdoconsultant_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoconsultant.Checked == true)
                {
                    InvestigationBLL investigationBLL = new InvestigationBLL();
                    DataSet ds = investigationBLL.getdocInfo();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        label1.Text="Doctor's Name";
                        PopulateComboBox(cmbcomissionperson, ds, 0, "reffDoc", "reffered_doctors_id");
                    }
                }
                else
                {
                    if (rdoconsultant.Checked == true)
                    {
                        label1.Text="Sales Person";

                    }
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

        private void FrmDoctor_sPay_Load(object sender, EventArgs e)
        {
            rdoconsultant.Checked = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbcomissionperson.SelectedIndex == -1)
                    MessageBox.Show("Select List Correctly");
                else
                {
                    refresh();
                    decimal payable = 0;
                    decimal paid = 0;
                    DateTime From = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day, 0, 0, 0);
                    DateTime To = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day, 23, 59, 59);

                    InvestigationBLL investigationBLL = new InvestigationBLL();
                    DataSet ds = investigationBLL.getdoctorspercentage(Convert.ToInt32(cmbcomissionperson.SelectedValue), From, To);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            grdpercentage.Rows.Add();
                            grdpercentage.Rows[i].Cells[0].Value = i+1;                                     //admn_id
                            grdpercentage.Rows[i].Cells[1].Value = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());                                     //cabin_id
                            grdpercentage.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString();
                            grdpercentage.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString();
                            payable += Convert.ToDecimal(ds.Tables[0].Rows[i][3].ToString());
                            paid += Convert.ToDecimal(ds.Tables[0].Rows[i][4].ToString());
                            grdpercentage.Rows[i].Cells[4].Value = Convert.ToDecimal(ds.Tables[0].Rows[i][3].ToString());
                            grdpercentage.Rows[i].Cells[5].Value = Convert.ToDecimal(ds.Tables[0].Rows[i][4].ToString());
                            //grdpercentage.Rows[i].Cells["item_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["test_item_id"].ToString());
                            //grdpercentage.Rows[i].Cells["speciman_id"].Value = Convert.ToInt32(ds.Tables[0].Rows[i]["specimen_id"].ToString());
                        }
                        txtTotaltaka.Text = payable.ToString("0#.#0");
                        txtpaid.Text = paid.ToString("0#.#0");
                    }
                }
                
                
            }
            catch
            {
            }
        }

        private void txtpercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            
                if (e.KeyChar == 13)
                {
                double total = double.Parse(this.txtpaid.Text);
                double percentage=Convert.ToDouble(txtpercentage.Text);
                double vat = ((total * percentage) / 100);
                txtPayment.Text = vat.ToString("0#.#0");
                }
            }
            catch
            {
            }

        }
        void refresh()
        {
            txtTotaltaka.Text = "";
            txtpaid.Text = "";
            txtpercentage.Text = "";
            txtPayment.Text = "";
            grdpercentage.Rows.Clear();

        }
    }
}