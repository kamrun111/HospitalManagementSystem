using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BusinessObjects;
using HIMS.BLL;

namespace NewHIMS.Forms.Investigation.Investigation_Item
{
    public partial class FrmInvestigationItemAddEditView : BaseForm.FrmBase
    {
        public FrmInvestigationItemAddEditView()
        {
            InitializeComponent();
        }


        public void PopulateDataGrid(DataGridView dataGrid, DataSet ds)
        {
            try
            {
                dataGrid.Rows.Clear();
                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                    {
                            dataGrid.Rows.Add();
                            for (int c = 0; c < dataGrid.Columns.Count; c++)
                            {
                                dataGrid.Rows[r].Cells[c].Value = ds.Tables[0].Rows[r][1].ToString();
                               
                               //dataGrid.Rows[r].Cells[dataGrid.Columns[c].Name].Value = this.formatValue(fieldSet[dataGrid.Columns[c].Name].ToString(), dataGrid.Columns[c].Tag.ToString());
                               
                                }
                            }
                      }
               
            }
            catch
            {
            }
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            //CityBLL cityBLL = new CityBLL();

            //DataSet ds=cityBLL.Getcitys();
            //PopulateDataGrid(grdMainList, ds);
        }
    }
}