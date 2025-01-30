using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace NewHIMS.Forms.Receiptions
{
    public partial class FrmMemberList : Form
    {
        public FrmMemberList()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();

        private void FrmMemberList_Load(object sender, EventArgs e)
        {
            GetPageLoad();
        }

        void GetPageLoad()
        {
            try
            {
                DataSet ds = cs.GetDataSet("MemberLoad");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cs.FillUpListview(lvwMemberList, ds, 0);
                }
            }
            catch
            {
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar==Convert.ToChar(Keys.Enter))
                {
                    DataSet ds=cs.GetDataSetWithStringParameter("@Member",txtSearch.Text,"MemberSearch");
                    if(ds.Tables[0].Rows.Count>0)
                    {
                        cs.FillUpListview(lvwMemberList, ds, 0);
                    }
                }

                else
                {
                    MessageBox.Show("No Data Found");
                }
            }
            catch
            {
            }
        }

        private void lvwMemberList_Click(object sender, EventArgs e)
        {
            try
            {

                PBMember.Image = null;
                PBDependable.Image = null;
                PBNominee.Image = null;
                txtFileLocation.Text = lvwMemberList.SelectedItems[0].SubItems[20].Text;
                if (File.Exists(@"\\KANDARI-PC\Image\Member\" + txtFileLocation.Text))
                {
                    //Image image = Image.FromFile(@"\\DESKTOP-A31T9DM\Previous\Image\Member\" + txtFileLocation.Text);//   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    Image image = Image.FromFile(@"\\KANDARI-PC\Image\Member\" + txtFileLocation.Text);
                    this.PBMember.Image = image;
                }

                DataSet ds = cs.GetDataSetWithParameter("@MemberID", Convert.ToInt32(lvwMemberList.SelectedItems[0].Text), "NomineeLoad");
                if (lvwMemberList.SelectedItems.Count > 0)
                {
                    lvwNomineeList.Items.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwNomineeList, ds, 0);
                    }

                    else
                    {
                        MessageBox.Show("Nominee is not Saved");
                    }
                }

                DataSet dt = cs.GetDataSetWithParameter("@MemberID", Convert.ToInt32(lvwMemberList.SelectedItems[0].Text), "DependableLoad");

                if (lvwMemberList.SelectedItems.Count > 0)
                {
                    lvwDependableList.Items.Clear();
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        cs.FillUpListview(lvwDependableList, dt, 0);
                    }
                    else
                    {
                        MessageBox.Show("Dependables are not Saved");
                    }
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
                txtSearch.Text = "";
                PBMember.Image = null;
                PBNominee.Image = null;
                PBDependable.Image = null;
                lvwNomineeList.Items.Clear();
                lvwMemberList.Items.Clear();
                lvwDependableList.Items.Clear();
                txtFileLocation.Text = "";
                GetPageLoad();
            }
            catch
            {

            }
        }

        private void lvwNomineeList_Click(object sender, EventArgs e)
        {
            try
            {
                txtFileLocation.Text = "";
                txtFileLocation.Text = lvwNomineeList.SelectedItems[0].SubItems[11].Text;
                PBNominee.Image = null;
                PBDependable.Image = null;
                if (File.Exists(@"\\KANDARI-PC\Image\Nominee\" + txtFileLocation.Text))
                {
                    //Image image = Image.FromFile(@"\\DESKTOP-A31T9DM\Previous\Image\Nominee\" + txtFileLocation.Text);//   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    Image image = Image.FromFile(@"\\KANDARI-PC\Image\Nominee\" + txtFileLocation.Text);
                    this.PBNominee.Image = image;
                }
            }
            catch
            {
            }
        }

        private void lvwDependableList_Click(object sender, EventArgs e)
        {
            try
            {
                txtFileLocation.Text = "";
                txtFileLocation.Text = lvwDependableList.SelectedItems[0].SubItems[5].Text;
                PBDependable.Image = null;
                if (File.Exists(@"\\KANDARI-PC\Image\Dependable\" + txtFileLocation.Text))
                {
                    //Image image = Image.FromFile(@"\\DESKTOP-A31T9DM\Previous\Image\Dependable\" + txtFileLocation.Text);//   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    Image image = Image.FromFile(@"\\KANDARI-PC\Image\Dependable\" + txtFileLocation.Text);
                    this.PBDependable.Image = image;
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

        


    }
}
