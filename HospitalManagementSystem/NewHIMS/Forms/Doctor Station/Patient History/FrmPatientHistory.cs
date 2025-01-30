using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using CrystalDecisions.CrystalReports.Engine;
using NewHIMS.Reports;
using HIMS.BLL;
using HIMS.BusinessObjects;
using NewHIMS.Reports.Doctor_Station;

namespace NewHIMS.Forms.Doctor_Station.Patient_History
{
    public partial class FrmPatientHistory : BaseForm.FrmBase
    {
        private int _admissionID;
        private string _cabin = "";
        private string _hID = "";
        private string _aCode = "";
        private string _hGroup = "";
        private Color _HistoryAddedColor = Color.DodgerBlue;
        private Color _HistoryNotAddedColor = Color.Black;
             
        public FrmPatientHistory()
        {
            InitializeComponent();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        public void refreshContent(int admissionID,string cabin,string hID,string aCode)
        {
            try
            {
               this._aCode = aCode;
               this._cabin = cabin;
               this._hID = hID;
                
               lblAdmnCode.Text = aCode;
               lblHID.Text = hID;
               lblPName.Text = cabin;
                
               this._admissionID = admissionID;
               PopulatePatientCC(admissionID);
               this.populateHistory();
               this.loadPatientHisotry(this._admissionID);
               SetComboValue();
               btnSave.Enabled = true;            
            }
            catch
            {
            }
        }

        private void PopulatePatientCC(int admissionId)
        {
            try
            {
                PatientCCBLL patientCCBLL = new PatientCCBLL();
                DataSet ds = patientCCBLL.PatientCCGetByAdmnID(admissionId);
               
                grdPatientCC.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    grdPatientCC.Rows.Add();
                    grdPatientCC.Rows[i].Cells[0].Value = i + 1;
                    grdPatientCC.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i]["cc"];
                    grdPatientCC.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i]["patient_cc_id"];
                }
            }
            catch
            { 
            }
        }

        private void SetComboValue() {
            try
            {
                Type controlType;

                for (int i = 0; i < this.grpGeneralHistory.Controls.Count; i++)
                {
                    this._hGroup = "General History";
                    controlType = this.grpGeneralHistory.Controls[i].GetType();
                    if (controlType == typeof(ComboBox))
                    {
                        if (((ComboBox)this.grpGeneralHistory.Controls[i]).Items.Count > 1)
                        {
                            ((ComboBox)this.grpGeneralHistory.Controls[i]).SelectedIndex = ((ComboBox)this.grpGeneralHistory.Controls[i]).FindString(((ComboBox)this.grpGeneralHistory.Controls[i]).Tag.ToString());
                        }
                    }
                }

                for (int i = 0; i < this.grpGynObstHistory.Controls.Count; i++)
                {
                    this._hGroup = "Gynaecological & Obstetrical History";
                    controlType = this.grpGynObstHistory.Controls[i].GetType();
                    if (controlType == typeof(ComboBox))
                    {
                        if (((ComboBox)this.grpGynObstHistory.Controls[i]).Items.Count >= 1)
                        {
                            ((ComboBox)this.grpGynObstHistory.Controls[i]).SelectedIndex = ((ComboBox)this.grpGynObstHistory.Controls[i]).FindString(((ComboBox)this.grpGynObstHistory.Controls[i]).Tag.ToString());
                        }
                    }
                }

                for (int i = 0; i < this.grpBabyHistory.Controls.Count; i++)
                {
                    this._hGroup = "Baby History";
                    controlType = this.grpBabyHistory.Controls[i].GetType();
                    if (controlType == typeof(ComboBox))
                    {
                        if (((ComboBox)this.grpBabyHistory.Controls[i]).Items.Count >= 1)
                        {
                            ((ComboBox)this.grpBabyHistory.Controls[i]).SelectedIndex = ((ComboBox)this.grpBabyHistory.Controls[i]).FindString(((ComboBox)this.grpBabyHistory.Controls[i]).Tag.ToString());
                        }
                    }
                }
            }
            catch
            {
            }
        }
        
        private void loadPatientHisotry(int admissionId)
        {
            try
            {
                this.grpGeneralHistory.Controls.Clear();
                this.grpGynObstHistory.Controls.Clear();
                this.grpBabyHistory.Controls.Clear();

                HistoryTextValueBLL historyTextValueBLL = new HistoryTextValueBLL();
                DataSet ds = null;
                
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < this.trvHistoryItems.Nodes[i].Nodes.Count; j++)
                    {
                        ds = historyTextValueBLL.GeHTextValueByAdmnIDAndHText(admissionId, this.trvHistoryItems.Nodes[i].Nodes[j].Tag.ToString()); //SP->  <HTextValueByAdmnIDAndHTextGet>

                        if (ds.Tables[0].Rows.Count > 0 )     
                        {
                            if (this.addHistoryItemToPageControl(
                                     ds.Tables[0].Rows[0][1].ToString(),
                                     null,
                                     this.trvHistoryItems.Nodes[i].Nodes[j].Parent.Tag.ToString(),
                                     this.trvHistoryItems.Nodes[i].Nodes[j].Text, "",
                                     this.trvHistoryItems.Nodes[i].Nodes[j].Tag.ToString(),
                                     false, "") == true)
                            {
                                this.trvHistoryItems.Nodes[i].Nodes[j].ForeColor = this._HistoryAddedColor;
                            }
                        }
                        ds = null;
                    }
                }
            }
            catch { 
            }
        }
      
        private void populateHistory()
        {
            try
            {
                this.trvHistoryItems.Nodes.Clear();

                HistoryTextBLL historyTextBLL = new HistoryTextBLL();
                HistoryTextGroupBLL historyTextGroupBLL = new HistoryTextGroupBLL();
                DataSet dsHistoryGroup = historyTextGroupBLL.Gethistory_text_groups();
                if (dsHistoryGroup.Tables[0] != null && dsHistoryGroup.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsHistoryGroup.Tables[0].Rows.Count; i++)
                    {
                        TreeNode newParentNode = this.trvHistoryItems.Nodes.Add(dsHistoryGroup.Tables[0].Rows[i]["history_text_group"].ToString());
                        newParentNode.Tag = dsHistoryGroup.Tables[0].Rows[i]["history_text_group_id"].ToString();
                        DataSet dsHistoryText = historyTextBLL.GetHistoryTextByHistoryTextGroup(Convert.ToInt32(dsHistoryGroup.Tables[0].Rows[i]["history_text_group_id"]));
                        
                        if (dsHistoryText.Tables[0] != null && dsHistoryText.Tables[0].Rows.Count > 0)
                            {
                                for (int j = 0; j < dsHistoryText.Tables[0].Rows.Count; j++)
                                {
                                    TreeNode newChildNode = new TreeNode(dsHistoryText.Tables[0].Rows[j]["history_text"].ToString());
                                    newChildNode.Tag = dsHistoryText.Tables[0].Rows[j]["history_text_id"].ToString();
                                    newParentNode.Nodes.Add(newChildNode);
                                }
                            }
                        }
                    }
                }
            catch
            {
            }
            this.trvHistoryItems.Refresh();
        }

        private ComboBox getComboBoxForHostory(int top, string historyTextId, string historyTextValue, bool isUpdate, string patientHistoryId, string historyTextGroupId)
        {
           ComboBox newComboBox = new ComboBox();
           newComboBox.DropDownStyle = ComboBoxStyle.DropDown;
           newComboBox.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
           newComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        
           newComboBox.Tag = "history_text_value_id";
          
           if (isUpdate == true)
           {
               newComboBox.Tag = historyTextId + ":EDIT:" + patientHistoryId;
           }
           else
           {
               newComboBox.Tag = historyTextId + ":ADD";
           }
           newComboBox.Left = 333;
           newComboBox.Height = 20;
           newComboBox.Top = top - 3;
           newComboBox.Width = 247;
           newComboBox.Visible = true;
           newComboBox.Text = historyTextValue;
           
           return newComboBox;
        }

        private LinkLabel getLinkLabelForHostory(int top, string historyTextId)
        {
            LinkLabel newLinkLabel = new LinkLabel();
            newLinkLabel.Text = "( -- )";
            newLinkLabel.AutoSize = true;
            newLinkLabel.Tag = historyTextId;
            newLinkLabel.Font = new Font("", 8.25F, FontStyle.Regular);
            newLinkLabel.Height = 13;
            newLinkLabel.Left = 600;
            newLinkLabel.Top = top;
            newLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            newLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHistoryTextItemRemove_LinkClicked);
            newLinkLabel.Visible = true;
            return newLinkLabel;
        }
        
        
        private void trvHistoryItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                if (this.trvHistoryItems.SelectedNode != null && this.trvHistoryItems.SelectedNode.Parent != null && this.trvHistoryItems.SelectedNode.ForeColor != this._HistoryAddedColor)
                {
                    if (this.addHistoryItemToPageControl(
                            "",
                            null,
                            this.trvHistoryItems.SelectedNode.Parent.Tag.ToString(),
                            this.trvHistoryItems.SelectedNode.Text, "",
                            this.trvHistoryItems.SelectedNode.Tag.ToString(),
                            false, "") == true)
                    {
                        this.trvHistoryItems.SelectedNode.ForeColor = this._HistoryAddedColor;
                    }
                }
            }
            catch
            {
            }
        }

        private void PopulateNewComboBox(string displayHText, DataSet dsPass, string hText, ComboBox newCombo)
        {
            string historyText;
            historyText = hText.Substring(0, hText.Length - 1);

            if (dsPass == null)
            {
                HistoryTextValueBLL historyTextValueBLL = new HistoryTextValueBLL();
                DataSet ds = historyTextValueBLL.GeHTextValueByHText(historyText);
                PopulateComboBox(newCombo, ds, 0, "history_text_value", "history_text_value_id");
            }
            else
            {
                PopulateComboBox(newCombo, dsPass, 0, "history_text_value", "history_text_value_id");
            }
            if (displayHText!="")
            {
                if (newCombo.Items.Count > 1)
                {
                    newCombo.SelectedIndex = newCombo.FindString(displayHText);
                }
            }
        }
        
        private bool addHistoryItemToPageControl(string displayHText,DataSet ds,string historyGroupId, string historyText, string historyValue, string historyTextId, bool isExistingValue, string patientHistoryId)
        {
            try
            {
                if (historyText != "")
                {
                    int lastCtrlTop = 0;
                    switch (historyGroupId)
                    {
                        case "1":
                            if (this.grpGeneralHistory.Controls.Count == 0)
                            {
                                lastCtrlTop = 6;
                            }
                            else
                            {
                                lastCtrlTop = this.grpGeneralHistory.Controls[this.grpGeneralHistory.Controls.Count - 1].Top;
                            }
                            lastCtrlTop += 13 + 10;
                            Label lblHistoryText1 = this.getLabelForHostory(lastCtrlTop, historyTextId, historyText);
                            ComboBox cmbHistoryValue1 = this.getComboBoxForHostory(lastCtrlTop, historyTextId, historyValue, isExistingValue, patientHistoryId, "1");
                            cmbHistoryValue1.Tag = displayHText;
                            PopulateNewComboBox(displayHText, ds, lblHistoryText1.Text, cmbHistoryValue1);
                            LinkLabel lnkHistoryTextRemover1 = this.getLinkLabelForHostory(lastCtrlTop, historyTextId);

                            this.grpGeneralHistory.Controls.Add(lblHistoryText1);
                            this.grpGeneralHistory.Controls.Add(cmbHistoryValue1);
                            this.grpGeneralHistory.Controls.Add(lnkHistoryTextRemover1);
                            if (historyValue != "")
                            {
                                cmbHistoryValue1.Text = historyValue;
                            }
                            break;
                        case "2":

                            if (this.grpGynObstHistory.Controls.Count == 0)
                            {

                                lastCtrlTop = 6;
                            }
                            else
                            {
                                lastCtrlTop = this.grpGynObstHistory.Controls[this.grpGynObstHistory.Controls.Count - 1].Top;
                            }
                            lastCtrlTop += 13 + 10;
                            Label lblHistoryText2 = this.getLabelForHostory(lastCtrlTop, historyTextId, historyText);
                            ComboBox cmbHistoryValue2 = this.getComboBoxForHostory(lastCtrlTop, historyTextId, historyValue, isExistingValue, patientHistoryId, "2");
                            cmbHistoryValue2.Tag = displayHText;
                            PopulateNewComboBox(displayHText, ds, lblHistoryText2.Text, cmbHistoryValue2);
                            LinkLabel lnkHistoryTextRemover2 = this.getLinkLabelForHostory(lastCtrlTop, historyTextId);

                            this.grpGynObstHistory.Controls.Add(lblHistoryText2);
                            this.grpGynObstHistory.Controls.Add(cmbHistoryValue2);
                            this.grpGynObstHistory.Controls.Add(lnkHistoryTextRemover2);
                            if (historyValue != "")
                            {
                                cmbHistoryValue2.Text = historyValue;
                            }
                            break;
                        case "3":

                            if (this.grpBabyHistory.Controls.Count == 0)
                            {
                                lastCtrlTop = 6;
                            }
                            else
                            {
                                lastCtrlTop = this.grpBabyHistory.Controls[this.grpBabyHistory.Controls.Count - 1].Top;
                            }
                            lastCtrlTop += 13 + 10;
                            Label lblHistoryText3 = this.getLabelForHostory(lastCtrlTop, historyTextId, historyText);
                            ComboBox cmbHistoryValue3 = this.getComboBoxForHostory(lastCtrlTop, historyTextId, historyValue, isExistingValue, patientHistoryId, "3");
                            cmbHistoryValue3.Tag = displayHText;
                            PopulateNewComboBox(displayHText, ds, lblHistoryText3.Text, cmbHistoryValue3);
                            LinkLabel lnkHistoryTextRemover3 = this.getLinkLabelForHostory(lastCtrlTop, historyTextId);

                            this.grpBabyHistory.Controls.Add(lblHistoryText3);
                            this.grpBabyHistory.Controls.Add(cmbHistoryValue3);
                            this.grpBabyHistory.Controls.Add(lnkHistoryTextRemover3);
                            if (historyValue != "")
                            {
                                cmbHistoryValue3.Text = historyValue;
                            }
                            break;
                    }
                    this.grpGynObstHistory.Top = this.grpGeneralHistory.Top + this.grpGeneralHistory.Height + 2;
                    this.grpBabyHistory.Top = this.grpGynObstHistory.Top + this.grpGynObstHistory.Height + 2;
                    this.pnlPatientHistoryPanel.Refresh();
                    return true;
                }
            }
            catch (Exception exp)
            {
                string a = exp.Message;
            }
            return false;
        }

        private Label getLabelForHostory(int top, string historyTextId, string text)
        {
            Label newLabel = new Label();
            newLabel.Text = text + ":";
            newLabel.Tag = historyTextId;
            newLabel.AutoSize = true;
            newLabel.Height = 13;
            newLabel.Left = 6;
            newLabel.Top = top;
            newLabel.Visible = true;
            return newLabel;
        }

        private TextBox getTextBoxForHostory(int top, string historyTextId, string historyTextValue, bool isUpdate, string patientHistoryId)
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Text = historyTextValue;
            if (isUpdate == true)
            {
                newTextBox.Tag = historyTextId + ":EDIT:" + patientHistoryId;
            }
            else
            {
                newTextBox.Tag = historyTextId + ":ADD";
            }
            newTextBox.Left = 233;
            newTextBox.Height = 20;
            newTextBox.Top = top - 3;
            newTextBox.Width = 247;
            newTextBox.Visible = true;
            return newTextBox;
        }

        private void adjustHistoryTree(string id, bool isAdded)
        {
            try
            {
                foreach (TreeNode node in this.trvHistoryItems.Nodes)
                {
                    if (node.Parent == null)
                    {
                        foreach (TreeNode childNode in node.Nodes)
                        {
                            if (childNode.Tag.ToString() == id)
                            {
                                if (isAdded == true)
                                {
                                    childNode.ForeColor = this._HistoryAddedColor;
                                }
                                else
                                {
                                    childNode.ForeColor = this._HistoryNotAddedColor;
                                }
                                return;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void lnkHistoryTextItemRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel linkLabel = (LinkLabel)sender;
                if (linkLabel != null && linkLabel.Parent != null)
                {
                    if (linkLabel.Text == "( -- )")
                    {
                        if (MessageBox.Show("Are you sure to delete history items?", "Delete History Items? ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                        else
                        {
                            linkLabel.Text = "( ++ )";
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure to add history items?", "Add History Items? ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                        else
                        {
                            linkLabel.Text = "( -- )";
                        }
                    }
                    string tagValue = linkLabel.Tag.ToString();
                }
            }
            catch
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshContent(this._admissionID,this._cabin,this._hID,this._aCode);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grpGeneralHistory.Controls.Count == 0 &&
                    grpGynObstHistory.Controls.Count == 0 &&
                    grpBabyHistory.Controls.Count == 0
                    )
                {
                    MessageBox.Show("Select Item for this patient");
                    return;
                }
                
                Type controlType;
                
                for (int i = 0; i < this.grpGeneralHistory.Controls.Count; i++)
                {
                    controlType = this.grpGeneralHistory.Controls[i].GetType();
                    if (controlType == typeof(ComboBox))
                    {
                        if (CheckRemoveCombo((LinkLabel)grpGeneralHistory.Controls[i+1])) 
                            continue;
                      
                        HistoryTextValueBLL historyTextValueBLL = new HistoryTextValueBLL();
                        DataSet dsGeneral;
                        if (this.grpGeneralHistory.Controls[i].Text == "")
                        {
                            MessageBox.Show("Select or Write a value for " + this.grpGeneralHistory.Controls[i - 1].Text.Substring(0, this.grpGeneralHistory.Controls[i - 1].Text.Length-1));
                            this.grpGeneralHistory.Controls[i].Focus();
                            return;
                        }
                        dsGeneral = historyTextValueBLL.CheckAndSaveHTextValueAndPHistory(this.grpGeneralHistory.Controls[i].Text.ToString(), Convert.ToInt32(this.grpGeneralHistory.Controls[i - 1].Tag), this._admissionID);
                    }
                }

                for (int i = 0; i < this.grpGynObstHistory.Controls.Count; i++)
                {
                    controlType = this.grpGynObstHistory.Controls[i].GetType();
                    if (controlType == typeof(ComboBox))
                    {
                        if (CheckRemoveCombo((LinkLabel)grpGynObstHistory.Controls[i + 1]))
                            continue;

                        
                        HistoryTextValueBLL historyTextValueBLL = new HistoryTextValueBLL();
                        DataSet dsGyn;
                        if (this.grpGynObstHistory.Controls[i].Text == "")
                        {
                            MessageBox.Show("Select or Write a value for " + this.grpGynObstHistory.Controls[i - 1].Text.Substring(0, this.grpGynObstHistory.Controls[i - 1].Text.Length - 1));
                            this.grpGynObstHistory.Controls[i].Focus();
                            return;
                        }
                        dsGyn = historyTextValueBLL.CheckAndSaveHTextValueAndPHistory(this.grpGynObstHistory.Controls[i].Text.ToString(), Convert.ToInt32(this.grpGynObstHistory.Controls[i - 1].Tag), this._admissionID);
                    }
                }

                for (int i = 0; i < this.grpBabyHistory.Controls.Count; i++)
                {
                    controlType = this.grpBabyHistory.Controls[i].GetType();
                    if (controlType == typeof(ComboBox))
                    {
                        if (CheckRemoveCombo((LinkLabel)grpBabyHistory.Controls[i + 1]))
                            continue;
                        
                        HistoryTextValueBLL historyTextValueBLL = new HistoryTextValueBLL();
                        DataSet dsBaby;
                        if (this.grpBabyHistory.Controls[i].Text == "")
                        {
                            MessageBox.Show("Select or Write a value for " + this.grpBabyHistory.Controls[i - 1].Text.Substring(0, this.grpBabyHistory.Controls[i - 1].Text.Length - 1));
                            this.grpBabyHistory.Controls[i].Focus();
                            return;
                        }
                        dsBaby = historyTextValueBLL.CheckAndSaveHTextValueAndPHistory(this.grpBabyHistory.Controls[i].Text.ToString(), Convert.ToInt32(this.grpBabyHistory.Controls[i - 1].Tag), this._admissionID);
                    }
                }
                PatientHistoryBLL patientHistoryBLL = new PatientHistoryBLL();
                patientHistoryBLL.SetIsHistoyWritten(this._admissionID);
                refreshContent(this._admissionID, this._cabin, this._hID, this._aCode);
                btnSave.Enabled = false;
            }
            catch 
            { 
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
                CrystalDecisions.Shared.ParameterDiscreteValue pdvCustomerName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.TableLogOnInfo tliCurrent;
                //rptPHistory rptCustomersOrders = new rptPHistory();
                subRptPH_History rptCustomersOrders = new subRptPH_History();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rptCustomersOrders.Database.Tables)
                {
                    tliCurrent = tbCurrent.LogOnInfo;

                    tliCurrent.ConnectionInfo.ServerName = FormHelper.DBServerName;
                    tliCurrent.ConnectionInfo.UserID = FormHelper.DBUser;
                    tliCurrent.ConnectionInfo.Password =FormHelper.DBUserPassword;
                    tliCurrent.ConnectionInfo.DatabaseName = FormHelper.DBName;
                    tbCurrent.ApplyLogOnInfo(tliCurrent);
                }
                
                rptCustomersOrders.SetParameterValue("@admission_id", this._admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idPH", this._admissionID);
                rptCustomersOrders.SetParameterValue("@admission_idPCC", this._admissionID);
                rptCustomersOrders.SetParameterValue("@HistoryGroup", this._hGroup);
                
                FrmGenericReportViewer frmGenericReportViewer = new FrmGenericReportViewer();
                frmGenericReportViewer.crvParameter.DisplayGroupTree = false;
                frmGenericReportViewer.crvParameter.ReportSource = rptCustomersOrders;
                frmGenericReportViewer.Show();
            }
            catch
            {
            }
        }

        private void btnPCCSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdPatientCC.Rows.Count > 0)
                {
                    PatientCC patientCC = new PatientCC();
                    PatientCCBLL patientCCBLL = new PatientCCBLL();

                    patientCC.admission_id = this._admissionID;
                    //patientCC.record_created_by=0;
                    for (int i = 0; i < grdPatientCC.Rows.Count - 1; i++)
                    {
                        if (grdPatientCC.Rows[i].Cells[1].Value != null)
                        {
                            patientCC.cc = grdPatientCC.Rows[i].Cells[1].Value.ToString();
                            if (grdPatientCC.Rows[i].Cells[2].Value != null)
                            {
                                patientCC.patient_cc_id = Convert.ToInt32(grdPatientCC.Rows[i].Cells[2].Value);
                            }
                            else
                            {
                                patientCC.patient_cc_id = 0;
                            }
                            patientCCBLL.Addpatient_cc(patientCC);
                        }
                    }
                    MessageBox.Show("Data Saved Successfully");
                    PopulatePatientCC(Convert.ToInt32(this._admissionID));
                }
            }
            catch
            { 
            }
        }


        private bool CheckRemoveCombo(LinkLabel lnkLabel)
        {
            if (lnkLabel.Text == "( ++ )" && lnkLabel.Tag.ToString() == "")
                return true;
            else if (lnkLabel.Text == "( ++ )" && lnkLabel.Tag.ToString() != "")
            {
                DataDeleteFromDB(Convert.ToInt32(lnkLabel.Tag));
                return true;
            }
            return false; 
        }


        private void DataDeleteFromDB(int hTextID)
        {
            PatientHistoryBLL patientHistoryBLL = new PatientHistoryBLL();
            patientHistoryBLL.Removepatient_history(this._admissionID,hTextID);
        }

        private void grdPatientCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
                grdPatientCC.Rows[e.RowIndex].Cells[0].Value = e.RowIndex+1;
        }

        private void trvHistoryItems_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //switch (trvHistoryItems.SelectedNode.Tag.ToString())
            //{
            //    case "1":
            //        //for (int i = 0; i < trvHistoryItems.SelectedNode.; i++)
            //        //{
                        
            //        //}
            //    case "2":
            //    //for (int i = 0; i < trvHistoryItems.SelectedNode.; i++)
            //    //{

            //    //}
            //    case "3":
            //    default:
            //        break;
            //}
            
        }

        private void CreateAndDisplayDynamicControl()
        {
            //if (this.trvHistoryItems.SelectedNode != null && this.trvHistoryItems.SelectedNode.Parent != null) //&& this.trvHistoryItems.SelectedNode.ForeColor != this._HistoryAddedColor)
            //{
            //    if (this.addHistoryItemToPageControl(
            //            "",
            //            null,
            //            this.trvHistoryItems.SelectedNode.Parent.Tag.ToString(),
            //            this.trvHistoryItems.SelectedNode.Text, "",
            //            this.trvHistoryItems.SelectedNode.Tag.ToString(),
            //            false, "") == true)
            //    {
            //        this.trvHistoryItems.SelectedNode.ForeColor = this._HistoryAddedColor;
            //    }
            //}
        }

        private void FrmPatientHistory_Load(object sender, EventArgs e)
        {

        }
      
    }
}