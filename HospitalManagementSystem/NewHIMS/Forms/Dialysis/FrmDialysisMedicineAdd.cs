using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;


namespace NewHIMS.Forms.Dialysis
{
    public partial class FrmDialysisMedicineAdd : Form
    {
        public FrmDialysisMedicineAdd()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();


        private void FrmDialysisMedicineAdd_Load(object sender, EventArgs e)
        {
            GetPageLoad();
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("DialysisMedicineLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwDialysisMedicineList, ds, 0);
                }
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtMedicineName.Text = "";
                txtQty.Text = "";
                btnSave.Text = "Save";
                btnSave.Enabled = true;
                lvwDialysisMedicineList.Enabled = true;
                GetPageLoad();
            }
            catch
            {
            }
        }

        private void lvwDialysisMedicineList_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = cs.GetDataSetWithParameter("@MID", Convert.ToInt32(lvwDialysisMedicineList.SelectedItems[0].SubItems[0].Text), "DialysisMedicineLoadIndividual");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtQty.Text = ds.Tables[0].Rows[0][2].ToString();
                    btnSave.Text = "Update";
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
                DialysisMedicineBLL dialysisMedicineBLL = new DialysisMedicineBLL();
                DialysisMedicineBO dialysisMedicineBO = new DialysisMedicineBO();

                if (txtMedicineName.Text == "")
                {
                    MessageBox.Show("Please Enter Medicine Name");
                    return;
                }
                dialysisMedicineBO.medicine_name = txtMedicineName.Text;

                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please Enter Medicine Qty");
                    return;
                }
                dialysisMedicineBO.qty = Convert.ToDecimal(txtQty.Text);

                int Result = 0;

                if (btnSave.Text == "Save")
                {
                    dialysisMedicineBO.record_created_by = ApplicatinLauncher._userId;
                    Result = dialysisMedicineBLL.AddDialysisMedicine(dialysisMedicineBO);
                }

                else
                {
                    dialysisMedicineBO.record_modified_by = ApplicatinLauncher._userId;
                    dialysisMedicineBO.dialysis_medicine_id = Convert.ToInt32(lvwDialysisMedicineList.SelectedItems[0].SubItems[0].Text);
                    Result = dialysisMedicineBLL.UpdateDialysisMedicine(dialysisMedicineBO);
                }

                if (Result > 0)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnSave.Enabled = false;
                    lvwDialysisMedicineList.Enabled = false;
                }
            }
            catch
            {
            }
        }


    }
}
