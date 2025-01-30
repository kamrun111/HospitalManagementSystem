using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HIMS.BLL;
using HIMS.DAL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Investigation
{
    public partial class FrmInvestigationItemIndent : BaseForm.FrmBase
    {
        public FrmInvestigationItemIndent()
        {
            InitializeComponent();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            try
            {
                combo.DataSource = ds.Tables[0];
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;
                //combo.SelectedIndex = -1;
                combo.Text = "<Select>";
            }
            catch { 
            }
         }

        void RefreshInvestigationItem()
        {
            try
            {
                InvestigationItemIndentBLL investigationItemIndentBLL = new InvestigationItemIndentBLL();
                InvestigationItemBLL investigationItemBLL = new InvestigationItemBLL();
                DataSet ds = investigationItemBLL.Getinvestigation_items();

                txtDeliveryQty.Text = "";
                txtOrderQty.Text = "";
                txtReceiveQty.Text = "";
                txtRefundQty.Text = "";
                cmbInvestigationItem.Text = "<select>";

                PopulateComboBox(cmbInvestigationItem, ds, 0, "investigation_item", "investigation_item_id");

                ds = investigationItemIndentBLL.GetInvestigationItemindentWithItems();
                FillUpListview(lvwInvestigationItemIndent, ds);
            }
            catch { 
            }
        }

        private void FrmInvetigationItem_Load(object sender, EventArgs e)
        {
            RefreshInvestigationItem();
        }
        
        private void lvwInvestigationItemIndent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwInvestigationItemIndent.Items.Clear();
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
                        for (int j = 1; j < lvw.Columns.Count; j++)
                        {
                            lvi.SubItems.Add(dataRow[j].ToString());
                        }
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch { 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InvestigationItemIndent investigationItemIndent = new InvestigationItemIndent();
                InvestigationItemIndentBLL invetigationItemIndentBLL = new InvestigationItemIndentBLL();
                string value;

                investigationItemIndent.order_qty = Convert.ToDecimal(txtOrderQty.Text);
                investigationItemIndent.receive_qty = Convert.ToDecimal(txtReceiveQty.Text);
                investigationItemIndent.delivery_qty = Convert.ToDecimal(txtDeliveryQty.Text);
                investigationItemIndent.refund_qty = Convert.ToDecimal(txtRefundQty.Text);

                if (cmbInvestigationItem.Text != "<Select>" && cmbInvestigationItem.Text != "")
                {
                    value = ((DataRowView)(cmbInvestigationItem.SelectedItem)).Row[0].ToString();
                    investigationItemIndent.investigation_item_id = Convert.ToInt32(value);
                }
                else
                {
                    MessageBox.Show("Input invetigation item");
                }

                invetigationItemIndentBLL.Addinvestigation_item_indent(investigationItemIndent);
                MessageBox.Show("Data Saved Successfully", "NewHIMS");
            }
            catch { 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInvestigationItem();
        }


        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            catch { 
            }
        }

        private void txtOrderQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }
    }
}


