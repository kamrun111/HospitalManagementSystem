using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Forms.Store;
using NewHIMS.Reports;
using NewHIMS.Reports.Purchase;

namespace NewHIMS.Forms.Store.Purchase
{
    public partial class FrmPurchaseOrderReview : Form
    {
        public FrmPurchaseOrderReview()
        {
            InitializeComponent();
        }

        private void FrmPurchaseOrderReview_Load(object sender, EventArgs e)
        {
            try
            {
                PurchaseBLL purchaseBLL = new PurchaseBLL();
                DataSet ds = purchaseBLL.PurchaseReview();
                if (ds.Tables[0].Rows.Count > 0)
                    FillUpListview(lvwPurchaseOrder, ds, 0);
            }
            catch
            {
            }
        }

        private void FillUpListview(ListView lvw, DataSet ds, int tableIndex)
        {
            try
            {
                lvw.Items.Clear();
                for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
                {
                    DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(dataRow[0].ToString());

                        lvi.SubItems.Add(dataRow[1].ToString());
                        lvi.SubItems.Add(dataRow[2].ToString());
                        lvi.SubItems.Add(dataRow[3].ToString());
                        lvw.Items.Add(lvi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error3");
            }
        }
    }
}
