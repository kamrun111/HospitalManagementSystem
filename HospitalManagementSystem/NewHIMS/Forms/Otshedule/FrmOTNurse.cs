using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;

namespace NewHIMS.Forms.Otshedule
{
    public partial class FrmOTNurse : BaseForm.FrmBase
    {
        public FrmOTNurse()
        {
            InitializeComponent();
        }
         private int updateOTnurse;

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            //MessageBox.Show(combo.SelectedIndex.ToString() + " * " + combo.Items.Count.ToString());
            combo.Text = "<Select>";
            //combo.SelectedIndex = -1;
            //MessageBox.Show(combo.SelectedIndex.ToString() + " * " + combo.Items.Count.ToString());

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


        private void FrmOTNurse_Load(object sender, EventArgs e)
        {
            loadOTNurse();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////


        void loadOTNurse()
        {
            try
            {
                txtOTsubmit.Text = "";
                OperationNote operationNote = new OperationNote();
                OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                DataSet ds = operationNoteBLL.GetOTNurseInfo();
                cmbsurgeon.Text = "<Select>";
                cmb1stASS.Text = "<Select>";
                cmb2ndAss.Text = "<Select>";
                cmb3rdAss.Text = "<Select>";
                cmbAnesthesia.Text = "<Select>";
                cmbNature.Text = "<Select>";
                cmbOTCabin.Text = "<Select>";
                FillUpListview(lvwOTNurse, ds,0);
                if (ds.Tables[1].Rows.Count > 0)
                {
                    txtOTsubmit.Text = ds.Tables[1].Rows[0][0].ToString();
                    for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                    {
                        txtOTsubmit.Text = txtOTsubmit.Text + "," + ds.Tables[1].Rows[i][0].ToString();
                    }
                }
                btnSave.Enabled = true;
                btnRTB.Enabled = true;
                //groupBox3.Visible = false;
                
            }
            catch
            { 
            }
        }

        private void lvwOTNurse_Click(object sender, EventArgs e)
        {
            OTNurseText();
        }

        void OTNurseText()
        {
            try
            {
                if (lvwOTNurse.SelectedItems.Count > 0)
                {
                    OperationNote operationNote = new OperationNote();
                    OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
                    DataSet ds = operationNoteBLL.OTNurseText(Convert.ToInt16(lvwOTNurse.SelectedItems[0].SubItems[3].Text));
                    //DataSet ds = operationNoteBLL.OTNurseText(Convert.ToInt16(lvwOTNurse.SelectedItems[0].Text),lvwOTNurse.SelectedItems[0].SubItems[2].Text);

                    txtPatientname.Text = ds.Tables[0].Rows[0][0].ToString();//patient name
                    txtOperationName.Text = ds.Tables[0].Rows[0][1].ToString();//operation name
                    txtGurdianName.Text = ds.Tables[0].Rows[0][2].ToString();//gurdian name
                    txtcontactNO.Text = ds.Tables[0].Rows[0][3].ToString();//contact no
                    txtAge.Text = ds.Tables[0].Rows[0][4].ToString();//dob
                    txtOperationDate.Text = (ds.Tables[0].Rows[0][6].ToString());//operation Date
                    txtAdmissionDate.Text = ds.Tables[0].Rows[0][7].ToString();
                    //txtOperationTime.Text=ds.Tables[0].Rows[0][7].ToString();//operation time

                    DataSet dscmb = operationNoteBLL.OTNurseCmb(Convert.ToInt32(lvwOTNurse.SelectedItems[0].SubItems[3].Text));
                    PopulateComboBox(cmbsurgeon, dscmb, 0, "reffered_doctors", "reffered_doctors_id");// surgen
                    if (dscmb.Tables[1].Rows.Count > 0)
                    {
                        if (this.cmbsurgeon.Items.Count > 0)
                        {
                            cmbsurgeon.SelectedIndex = -1;
                            this.cmbsurgeon.SelectedIndex = this.cmbsurgeon.FindString((dscmb.Tables[1].Rows[0][0].ToString()));
                        }
                    }
                    PopulateComboBox(cmb1stASS, dscmb, 2, "reffered_doctors", "reffered_doctors_id");// 1st ass
                    if (dscmb.Tables[3].Rows.Count > 0)
                    {
                        if (this.cmb1stASS.Items.Count > 0)
                        {
                            cmb1stASS.SelectedIndex = -1;
                            this.cmb1stASS.SelectedIndex = this.cmbsurgeon.FindString((dscmb.Tables[3].Rows[0][0].ToString()));
                        }
                    }

                    PopulateComboBox(cmb2ndAss, dscmb, 4, "reffered_doctors", "reffered_doctors_id");// 2nd ass
                    if (dscmb.Tables[5].Rows.Count > 0)
                    {
                        if (this.cmb2ndAss.Items.Count > 0)
                        {
                            cmb2ndAss.SelectedIndex = -1;
                            this.cmb2ndAss.SelectedIndex = this.cmbsurgeon.FindString((dscmb.Tables[5].Rows[0][0].ToString()));

                        }
                    }

                    PopulateComboBox(cmb3rdAss, dscmb, 6, "reffered_doctors", "reffered_doctors_id");// 3rd ass
                    if (dscmb.Tables[7].Rows.Count > 0)
                    {
                        if (this.cmb3rdAss.Items.Count > 0)
                        {
                            cmb3rdAss.SelectedIndex = -1;
                            this.cmb3rdAss.SelectedIndex = this.cmbsurgeon.FindString((dscmb.Tables[7].Rows[0][0].ToString()));

                        }
                    }

                    PopulateComboBox(cmbAnesthesia, dscmb, 8, "reffered_doctors", "reffered_doctors_id");// anesthesia
                    if (dscmb.Tables[9].Rows.Count > 0)
                    {
                        if (this.cmbAnesthesia.Items.Count > 0)
                        {
                            cmbAnesthesia.SelectedIndex = -1;
                            this.cmbAnesthesia.SelectedIndex = this.cmbAnesthesia.FindString((dscmb.Tables[9].Rows[0][0].ToString()));

                        }
                    }
                    PopulateComboBox(cmbNature,dscmb, 10, "anaesthesia_nature", "anaesthesia_id");//anaseia nature
                    if (dscmb.Tables[11].Rows.Count > 0)
                    {
                        if (this.cmbNature.Items.Count > 0)
                        {
                            cmbNature.SelectedIndex = -1;
                            this.cmbNature.SelectedIndex = this.cmbNature.FindString((dscmb.Tables[11].Rows[0][0].ToString()));

                        }
                    }
                    PopulateComboBox(cmbOTCabin,dscmb, 12, "cabin", "cabin_id");

                    

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
                if (lvwOTNurse.SelectedItems.Count > 0)
                {
                    OperationNote operationNote = new OperationNote();
                    OperationNoteBLL operationNoteBLL = new OperationNoteBLL();

                    operationNote.operation_note_id = Convert.ToInt32(lvwOTNurse.SelectedItems[0].SubItems[4].Text);
                    if (cmbsurgeon.Items.Count > 0)
                    {
                        if (cmbsurgeon.Text != "<Select>")
                            operationNote.surgeon_name= Convert.ToInt32(cmbsurgeon.SelectedValue.ToString());
                    }
                    if (cmb1stASS.Items.Count > 0)
                    {
                        if(cmb1stASS.Text != "<Select>")
                            operationNote.first_asst =  Convert.ToInt32(cmb1stASS.SelectedValue.ToString());
                    }
                    if (cmb2ndAss.Items.Count > 0)
                    {
                        if (cmb2ndAss.Text != "<Select>")
                            operationNote.second_asst = Convert.ToInt32(cmb2ndAss.SelectedValue.ToString());
                    }
                    if (cmb3rdAss.Items.Count > 0)
                    {
                        if (cmb3rdAss.Text != "<Select>")
                            operationNote.third_asst = Convert.ToInt32(cmb3rdAss.SelectedValue.ToString());
                    }
                    if (cmbAnesthesia.Items.Count > 0)
                    {
                        if (cmbAnesthesia.Text != "<Select>")
                            operationNote.anaesthesia_id = Convert.ToInt32(cmbAnesthesia.SelectedValue.ToString());
                    }
                    if (cmbNature.Items.Count > 0)
                    {
                        if (cmbNature.Text != "<Select>")
                            operationNote.anaesthesia_nature_id = Convert.ToInt32(cmbNature.SelectedValue.ToString());
                    }
                    operationNote.is_received = 0;
                    operationNote.is_submit = 0;
                    updateOTnurse = operationNoteBLL.OTNurseUpdate(operationNote);
                    MessageBox.Show("Data Saved successfully");
                    btnSave.Enabled = false;
                }

            }
            catch
            {
            }
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (lvwOTNurse.SelectedItems.Count > 0)
                {
                    FrmOTMedicine frmOTMedicine = new FrmOTMedicine();
                    frmOTMedicine.OtMedecine(Convert.ToInt32(lvwOTNurse.SelectedItems[0].Text), lvwOTNurse.SelectedItems[0].SubItems[1].Text, lvwOTNurse.SelectedItems[0].SubItems[2].Text, Convert.ToInt32(lvwOTNurse.SelectedItems[0].SubItems[3].Text), Convert.ToInt32(lvwOTNurse.SelectedItems[0].SubItems[4].Text));

                    //frmOTMedicine.Show();
                    ((NewHIMS.MDI.FrmMain)this.MdiParent).OpenChildForm(frmOTMedicine);
                }
            }
            catch
            { }
        }

        private void lvwOTNurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwOTNurse.SelectedItems.Count > 0)
                {
                    this.linkLabel1.Enabled = true;
                    OTNurseText();
                    
                  
                }
                else
                {
                    this.linkLabel1.Enabled = false;
                    
                }
            }
            catch
            { }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadOTNurse();
        }

        private void btnRTB_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (lvwOTNurse.SelectedItems.Count > 0)
                {
                    groupBox3.Visible = true;
                    //txtDays.Focus();
                    OperationNote operationNote = new OperationNote();
                    OperationNoteBLL operationNoteBLL = new OperationNoteBLL();

                    operationNote.operation_note_id = Convert.ToInt32(lvwOTNurse.SelectedItems[0].SubItems[4].Text);
                    operationNote.p_day = Convert.ToInt32(txtDays.Text.ToString());
                    operationNote.is_received = 3;
                    if (cmbOTCabin.Text != "<Select>")
                    {
                        operationNote.Ot_cabin_id = Convert.ToInt32(cmbOTCabin.SelectedValue.ToString());
                       
                    }
                    else
                    {
                        MessageBox.Show("Select OT Bed");
                        cmbOTCabin.Focus();
                        return;
                    
                    }
                        
                    operationNote.additional_time = Convert.ToInt32(numericUpDown1.Value);
                    if (MessageBox.Show("Do You Want To Discharge From OTNurse Now?", "HIMS", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        //groupBox3.Visible = false;
                        return;
                    }
                    updateOTnurse = operationNoteBLL.OTnurseDischarge(operationNote);
                    MessageBox.Show("Data Saved successfully");
                    btnRTB.Enabled = false;
                    loadOTNurse();


                }
                else
                {
                    MessageBox.Show("Select Patient From The List");
                    //groupBox3.Visible = false;
                    lvwOTNurse.Focus();
                    return;
                }
            
            
            }
            catch
            { }

        }

        private void txtDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                //if(string.Compare()
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OperationNoteBLL operationNoteBLL = new OperationNoteBLL();
            txtOTsubmit.Text = "";
            DataSet ds = operationNoteBLL.GetOTNurseInfo();
            if (ds.Tables[1].Rows.Count > 0)
            {
                txtOTsubmit.Text = ds.Tables[1].Rows[0][0].ToString();
                for (int i = 1; i < ds.Tables[1].Rows.Count; i++)
                {
                    txtOTsubmit.Text = txtOTsubmit.Text + "," + ds.Tables[1].Rows[i][0].ToString();
                }
            }
            
        }

        private void cmbFloor_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnRTB_Click_1(object sender, EventArgs e)
        {

        }

        }

    }

