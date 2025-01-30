using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;


namespace NewHIMS.Forms.Investigation
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();
        Image File;


        private void FrmSearch_Load(object sender, EventArgs e)
        {
            GetPageLoad();
        }

        void GetPageLoad()
        {
            try
            {
                this.cmbSearchType.SelectedIndexChanged -= this.cmbSearchType_SelectedIndexChanged;

                this.cmbSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchType_SelectedIndexChanged);
                
            }
            catch
            {
            }
        }

        void GetRefresh()
        {
            try
            {
                grdList.Rows.Clear();
                pictureBox1.Image = null;
                txtSearch.Text = "";
            }
            catch
            {
            }
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetRefresh();

                
                if (cmbSearchType.SelectedIndex != -1)
                {
                    if (cmbSearchType.Text == "Stuff")  
                    {
                        StuffLoad();
                    }
                    if (cmbSearchType.Text == "Member")
                    {
                        MemberLoad();
                    }
                    if (cmbSearchType.Text == "Dependable")
                    {
                        DependableLoad();
                    }

                }
            }
            catch
            {
            }
        }

        void StuffLoad()
        {
            try
            {
                //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=sumon123";
                string constr = "Data Source=GHHSERVER-PC\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=1234sumon123";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.employee.employee_name AS Name, dbo.employee.mobile AS Mobile_No, dbo.employee.image AS Image FROM dbo.employee where active=1", con))
                    {

                        DataTable scores = new DataTable();
                        sda.Fill(scores);
                        grdList.DataSource = scores;
                        
                    }

                    cmbSearchType.Enabled = false;
                }

            }
            catch
            {
            }
        }

        void MemberLoad()
        {
            try
            {
                //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=sumon123";
                string constr = "Data Source=KANDARI-PC\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=1234sumon123";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.member.member_name AS Member_Name, dbo.member.mobile_no AS Mobile_No, dbo.member.image AS Image FROM dbo.member", con))
                    {

                        DataTable scores = new DataTable();
                        sda.Fill(scores);
                        grdList.DataSource = scores;

                    }
                    cmbSearchType.Enabled = false;


                }

            }
            catch
            {
            }
        }

        void DependableLoad()
        {
            try
            {
                //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=sumon123";
                string constr = "Data Source=KANDARI-PC\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=1234sumon123";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.dependable.dependable_name AS Dependable_Name, dbo.dependable.mobile_no AS Mobile_No, dbo.dependable.image AS Image FROM dbo.dependable where status=0", con))
                    {

                        DataTable scores = new DataTable();
                        sda.Fill(scores);
                        grdList.DataSource = scores;

                    }
                    cmbSearchType.Enabled = false;

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
                if (cmbSearchType.Text == "Stuff")
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {

                        //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=sumon123";
                        string constr = "Data Source=GHHSERVER-PC\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=1234sumon123";
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlDataAdapter sda = new SqlDataAdapter("select employee_name AS EmPloyee_Name, mobile as Mobile_No, image AS Image from employee where mobile ='" + txtSearch.Text + "'", con))
                            
                            if(sda!=null)
                            {

                                DataTable scores = new DataTable();
                                sda.Fill(scores);
                                grdList.DataSource = scores;
                        
                            }
                            else
                            {
                                MessageBox.Show("No Data Found");
                            }

                        }

                    }
                        

                    }

                if (cmbSearchType.Text == "Member")
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {

                        //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=sumon123";
                        string constr = "Data Source=KANDARI-PC\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=1234sumon123";
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.member.member_name AS Member_Name, dbo.member.mobile_no AS Mobile_No, dbo.member.image AS Image FROM dbo.member where mobile_no ='" + txtSearch.Text + "'", con))

                                if (sda != null)
                                {

                                    DataTable scores = new DataTable();
                                    sda.Fill(scores);
                                    grdList.DataSource = scores;

                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }

                        }

                    }


                }

                if (cmbSearchType.Text == "Dependable")
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {

                        //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=sumon123";
                        string constr = "Data Source=KANDARI-PC\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=1234sumon123";
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.dependable.dependable_name AS Dependable_Name, dbo.dependable.mobile_no AS Mobile_No, dbo.dependable.image AS Image FROM dbo.dependable where mobile_no ='" + txtSearch.Text + "'", con))

                                if (sda != null)
                                {

                                    DataTable scores = new DataTable();
                                    sda.Fill(scores);
                                    grdList.DataSource = scores;

                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }

                        }

                    }

                }

                }
            
            catch
            {
            }
        }

        private void grdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cmbSearchType.Text == "Stuff" )//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                
                
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString()); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\GHHSERVER-PC\Photo\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                        Image image = Image.FromFile(@"\\GHHSERVER-PC\Photo\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;
                        MessageBox.Show("Image is not Saved");
                    }
                }

                if (cmbSearchType.Text == "Member")//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString()); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\KANDARI-PC\Image\Member\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                        Image image = Image.FromFile(@"\\KANDARI-PC\Image\Member\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;
                        MessageBox.Show("Image is not Saved");
                    }
                }

                if (cmbSearchType.Text == "Dependable")//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString()); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\KANDARI-PC\Image\Dependable\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                        Image image = Image.FromFile(@"\\KANDARI-PC\Image\Dependable\" + grdList.Rows[e.RowIndex].Cells["image"].FormattedValue.ToString());
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;
                        MessageBox.Show("Image is not Saved");
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
                GetPageLoad();
                GetRefresh();
                cmbSearchType.Enabled = true;
                cmbSearchType.SelectedIndex = -1;
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
