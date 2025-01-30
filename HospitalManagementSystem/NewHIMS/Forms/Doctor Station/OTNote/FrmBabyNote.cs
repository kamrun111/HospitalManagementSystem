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
using NewHIMS.Reports;
using NewHIMS.Reports.Ot;

namespace NewHIMS.Forms.Doctor_Station.OTNote
{
    public partial class FrmBabyNote : Form
    {
        public FrmBabyNote()
        {
            InitializeComponent();
        }

        private string admissionID = "";
        private int babynoteID=0;

        private void FrmBabyNote_Load(object sender, EventArgs e)
        {

        }

        public void BabyNoteON(string admissionID)
        {
            try
            {
                this.admissionID = admissionID;
                BabyNote babyNote = new BabyNote();
                Baby_noteBLL babynoteBLL = new Baby_noteBLL();
                DataSet ds = babynoteBLL.BabynoteLoad(Convert.ToInt32(admissionID));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.babynoteID = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());
                    txtA_S.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtWeight.Text = ds.Tables[0].Rows[0][2].ToString();
                    if(ds.Tables[0].Rows[0][5]!=null)
                    txtc_a.Text = ds.Tables[0].Rows[0][5].ToString();
                    btnSave.Text = "Update";

                    if (ds.Tables[0].Rows[0][4] != null)
                    {
                        dtpoperationDate.Text = ds.Tables[0].Rows[0][4].ToString();
                        dtpoperationTime.Text = ds.Tables[0].Rows[0][4].ToString();

                    }
                }
                cbmBabySx.DataSource = ds.Tables[1];
                cbmBabySx.DisplayMember = "gender";
                cbmBabySx.ValueMember = "gender_id";
                cbmBabySx.Text = "<Select>";
                if (cbmBabySx.SelectedIndex > 0)
                    cbmBabySx.SelectedIndex = 0;

                if (ds.Tables[2].Rows.Count > 0)
                {
                    if (this.cbmBabySx.Items.Count > 0)
                    {
                        cbmBabySx.SelectedIndex = -1;
                        this.cbmBabySx.SelectedIndex = this.cbmBabySx.FindString((ds.Tables[2].Rows[0][0].ToString()));
                    }
                }


            }
            catch
            { 
                MessageBox.Show("error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "Update")
                    babynoteUpdate();
                else
                    babynoteSave();
            }
            catch
            { 
            }
        }
        private void babynoteSave()
        {
            try
            {   
                BabyNote babyNote = new BabyNote();
                Baby_noteBLL babyNoteBLL = new Baby_noteBLL();
                OperationNote operationNote = new OperationNote();
                babyNote.a_s = txtA_S.Text.ToString();
                if (cbmBabySx.Text != "<Select>")
                    babyNote.sex = Convert.ToInt32(this.cbmBabySx.SelectedValue.ToString());
                else
                {
                    MessageBox.Show("Select Gender");
                    cbmBabySx.Focus();
                    return;
                }
                babyNote.date_time = Convert.ToDateTime(this.dtpoperationDate.Value.ToString("dd-MMM-yyyy") + " " + this.dtpoperationTime.Value.ToString("hh:mm tt"));
                babyNote.weight = txtWeight.Text.ToString();
                if(txtc_a.Text!="")
                babyNote.c_a = txtc_a.Text.ToString();
                babyNote.record_created_by = ApplicatinLauncher._userId;
                operationNote.admission_id = Convert.ToInt32(admissionID);
                babyNoteBLL.baby_noteAdd(babyNote, operationNote);
                MessageBox.Show("Data Saved Successfully");
                btnSave.Enabled = false;
            }
            catch
            { 
            }
        }

        private void babynoteUpdate()
        {
            try
            {
                BabyNote babyNote = new BabyNote();
                Baby_noteBLL babyNoteBLL = new Baby_noteBLL();
                babyNote.baby_note_id = babynoteID;
                babyNote.date_time = Convert.ToDateTime(this.dtpoperationDate.Value.ToString("dd-MMM-yyyy") + " " + this.dtpoperationTime.Value.ToString("hh:mm tt"));
                babyNote.a_s = txtA_S.Text.ToString();
                babyNote.weight = txtWeight.Text.ToString();
                if(txtc_a.Text!="")
                babyNote.c_a = txtc_a.Text.ToString();
                babyNote.sex = Convert.ToInt32(this.cbmBabySx.SelectedValue.ToString());
                babyNote.record_modified_by = ApplicatinLauncher._userId;
                babyNoteBLL.babyNoteupdate(babyNote);
                MessageBox.Show("Data updated Successfully");
                btnSave.Enabled = false;
            }
            catch { }
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                BabyNoteON(this.admissionID);
                btnSave.Enabled = true;
            }
            catch { }
        }
    }
}