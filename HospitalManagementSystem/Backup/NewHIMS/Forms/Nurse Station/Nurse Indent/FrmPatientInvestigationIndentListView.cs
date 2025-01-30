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
    public partial class FrmPatientInvestigationIndentListView : BaseForm.FrmBase
    {
        private int _admissionID = 0;
        private int _patientID = 0;
        private int DoneByPatient=0;
        DataSet dsIndentInfo;
        public FrmPatientInvestigationIndentListView()
        {
            InitializeComponent();
        }

        private void FillUpListview(ListView lvw, DataSet ds)
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
        public void RefreshContent(int admnID,int patientID) {
            if (admnID != 0)
            {
                this._admissionID = admnID;
                this._patientID = patientID;

                //PrescriptionBLL prescriptionBLL = new PrescriptionBLL();
                //DataSet dsPres = prescriptionBLL.GetPresIdByAdmbID(admnID);
                //if (dsPres.Tables[0].Rows.Count > 0)
                //{
                //    if (dsPres.Tables[0].Rows[0][0].ToString() != "")
                //    {
                        VisitInvestigationBLL visitInvestigationBLL = new VisitInvestigationBLL();
                        //dsIndentInfo = visitInvestigationBLL.GetInvestigationIndentInfo(Convert.ToInt32(dsPres.Tables[0].Rows[0][0].ToString()));
                        dsIndentInfo = visitInvestigationBLL.GetInvestigationIndentInfo(admnID);

                        if (dsIndentInfo.Tables[0] != null && dsIndentInfo.Tables[0].Rows.Count > 0)
                        {
                            FillUpListview(lvwInvestigation, dsIndentInfo);
                            btnIndent.Enabled = true;
                        }
                //    }
                //}
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPatientInvestigationIndentListView_Load(object sender, EventArgs e)
        {
            //RefreshContent();
        }

        private void btnIndent_Click(object sender, EventArgs e)
        {
            try
            {
                if (DoneByPatient == 0)
                {
                    if (MessageBox.Show(" Are You Sure there is no item done by Patient?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                InvestigationBO investigationBO = new InvestigationBO();
                InvestigationBLL investigationBLL = new InvestigationBLL();
                SampleBLL sampleBLL = new SampleBLL();

                investigationBO.admission_id = this._admissionID;
                investigationBO.patient_id = this._patientID;
                investigationBO.order_date = DateTime.Now;
                investigationBO.record_created_by = ApplicatinLauncher._userId;
                investigationBO.invest_ref_doctor_id = Convert.ToInt32(lvwInvestigation.Items[0].SubItems[6].Text);

                int invesID = investigationBLL.Addinvestigation(investigationBO);

                if (invesID > 0)
                {
                    
                    if(lvwInvestigation.Items.Count>0)
                    {
                        int DID = 0;
                        for (int i = 0; i < lvwInvestigation.Items.Count; i++)
                        {
                            int SampleID = 0;
                            DID = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[5].Text);
                            if (DID == 2)
                            {
                                int SID = 0;
                                while (DID == 2)
                                {
                                    //int SampleID = 0;
                                    if (SID != Convert.ToInt32(lvwInvestigation.Items[i].SubItems[9].Text) && Convert.ToInt32(lvwInvestigation.Items[i].SubItems[9].Text) != 0)
                                    {
                                        Sample sample = new Sample();
                                        int SpecimenID = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[9].Text);
                                        sample.investigation_id = invesID;
                                        sample.record_created_by = ApplicatinLauncher._userId;
                                        SampleID = sampleBLL.sampleAdd(sample, SpecimenID);
                                    }
                                    SaveInvestigations(invesID, SampleID, i);

                                    SID = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[9].Text);
                                    if (i == lvwInvestigation.Items.Count - 1)
                                    {
                                        DID = 0;
                                        MessageBox.Show("Data Saved Successfully");
                                        lvwInvestigation.Items.Clear();
                                        btnIndent.Enabled = false;
                                        return;
                                    }
                                    if (Convert.ToInt32(lvwInvestigation.Items[i + 1].SubItems[9].Text) == 0)
                                    {
                                        DID = Convert.ToInt32(lvwInvestigation.Items[i + 1].SubItems[5].Text);
                                    }
                                    else
                                    {
                                        DID = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[5].Text);
                                        i++;
                                    }
                                }
                                DID = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[5].Text);
                            }
                            else
                            {
                                SaveInvestigations(invesID, 0, i);
                            }
                        }
                    }
                    MessageBox.Show("Data Saved Successfully");
                }

                lvwInvestigation.Items.Clear();
                btnIndent.Enabled = false;
            }
            catch 
            {
            }
        }

        private void SaveInvestigations(int invesID,int SampleID, int i)
        {
            try
            {
                InvestigationTest investigationTest = new InvestigationTest();
                InvestigationTestBLL investigationTestBLL = new InvestigationTestBLL();
                int visitinvestigationID;

                investigationTest.investigation_id = invesID;
                investigationTest.test_department_id = (Convert.ToInt32(lvwInvestigation.Items[i].SubItems[5].Text));
                investigationTest.test_group_id = (Convert.ToInt32(lvwInvestigation.Items[i].SubItems[4].Text));
                investigationTest.test_item_id = (Convert.ToInt32(lvwInvestigation.Items[i].SubItems[3].Text));
                if (SampleID != 0)
                {
                    investigationTest.sample_serial_no = SampleID;
                }
                investigationTest.charge = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[7].Text);
                visitinvestigationID = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[8].Text);
                investigationTest.result = "Processing";
                investigationTest.reffered_doctors_id = (Convert.ToInt32(lvwInvestigation.Items[i].SubItems[6].Text));
                //investigationTest.delivery_date=;
                investigationTest.report_done = 0;
                investigationTest.delivered = 0;
                investigationTest.user_id = 0;
                investigationTest.for_baby = Convert.ToInt32(lvwInvestigation.Items[i].SubItems[10].Text); ;
                //investigationTest.actual_delivery_date=;
                if (Convert.ToInt32(lvwInvestigation.Items[i].SubItems[5].Text) == 2)
                {
                    investigationTest.sample_collected = 0;
                }
                else
                {
                    investigationTest.sample_collected = 1;
                }
                //investigationTest.sample_collection_date=;
                investigationTest.record_created_by = ApplicatinLauncher._userId;

                investigationTestBLL.Addinvestigation_test(investigationTest, visitinvestigationID);
                SetVisitInvestigationIndentGiven();
            }
            catch
            {
            }
        }
        private void SetVisitInvestigationIndentGiven()
        {
            VisitInvestigationBLL visitInvestigationBLL = new VisitInvestigationBLL();
            for (int i = 0; i < lvwInvestigation.Items.Count; i++)
            {
                visitInvestigationBLL.SetVisitInvestigationIndentGiven(Convert.ToInt32(lvwInvestigation.Items[i].SubItems[8].Text), 1,ApplicatinLauncher._userId);
            }
            visitInvestigationBLL = null;
        }

        private void btnDoneByPatient_Click(object sender, EventArgs e)
        {
            try
            {
                DoneByPatient = 1;
                if (lvwInvestigation.SelectedItems.Count > 0)
                {
                    VisitInvestigation visitInvestigation = new VisitInvestigation();
                    VisitInvestigationBLL visitInvestigationBLL = new VisitInvestigationBLL();
                    visitInvestigation.record_modified_by = ApplicatinLauncher._userId;
                    visitInvestigation.visit_investigation_id = Convert.ToInt32(lvwInvestigation.Items[0].SubItems[8].Text);
                    visitInvestigationBLL.donebypatient(visitInvestigation);
                    lvwInvestigation.SelectedItems[0].Remove();
                }
            }
            catch
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshContent(_admissionID, _patientID);
        }
        
    }
}