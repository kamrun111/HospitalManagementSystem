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
using NewHIMS.Forms.Receiptions;
using NewHIMS.Forms.Receiptions.Patients.Admission;


namespace NewHIMS.Forms.Investigation
{
    public partial class FrmMemberSearch : Form
    {
        public FrmMemberSearch()
        {
            InitializeComponent();
        }

        CommonClass cs = new CommonClass();
        Image File;


        public FrmMemberSearch (FrmInvestigationWithMember frmInvestigationWithMember, FrmAdmissionMember frmAdmissionMember)
        {
            
            oFrmInvestigationWithMember = frmInvestigationWithMember;
            oFrmAdmissionMember = frmAdmissionMember;
            InitializeComponent();
            GetPageLoad();
        }

       
        FrmInvestigationWithMember oFrmInvestigationWithMember = new FrmInvestigationWithMember();
        FrmAdmissionMember oFrmAdmissionMember = new FrmAdmissionMember();


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
                lvwMember.Items.Clear();
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
                    if (cmbSearchType.Text == "Stuff Dependable")
                    {
                        StuffDependableLoad();
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
                //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=HRPayRoll;User ID=sumon;Password=sumon123";
                string constr = "Data Source=GHHSERVER-PC\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=1234sumon123";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.employee.employee_name + ' -(Stuff)' AS Name, dbo.employee.mobile AS Mobile_No, dbo.employee.image AS Image, DATEDIFF(yy,CONVERT(DATETIME, DOB),GETDATE()) AS AGE, case when gender_id=1 then '4' else '5' end as Gender, status FROM dbo.employee where active=1", con))
                    {
                        
                        DataTable table = new DataTable();

                        sda.Fill(table);

                        
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                            for (int j = 1; j < table.Columns.Count; j++)
                            {
                                row.SubItems.Add(table.Rows[i][j].ToString());
                            }
                            lvwMember.Items.Add(row);
                        }
                        
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
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.member.member_name+' (M. ID # '+ dbo.member.member_no +')' AS Member_Name, dbo.member.mobile_no AS Mobile_No, dbo.member.image AS Image, DATEDIFF(yy,CONVERT(DATETIME, DOB),GETDATE()) AS AGE, '4' as Gender, 'Member', FROM dbo.member", con))
                    {
                        
                        DataTable table = new DataTable();

                        sda.Fill(table);

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                            for (int j = 1; j < table.Columns.Count; j++)
                            {
                                row.SubItems.Add(table.Rows[i][j].ToString());
                            }
                            lvwMember.Items.Add(row);
                        }

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
                //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=sumon123";
                string constr = "Data Source=KANDARI-PC\\SQLEXPRESS;Initial Catalog=Kandary;User ID=sumon;Password=1234sumon123";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.dependable.dependable_name + ' (C/O - M. ID # ' + dbo.member.member_no + ')' AS Dependable_Name, dbo.dependable.mobile_no, dbo.dependable.image AS Image, '18' AS AGE, '4' AS Gender, 'Dependable' FROM dbo.dependable INNER JOIN dbo.member ON dbo.dependable.member_id = dbo.member.member_id where dbo.dependable.status=0", con))
                    {
                        
                        DataTable table = new DataTable();

                        sda.Fill(table);

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                            for (int j = 1; j < table.Columns.Count; j++)
                            {
                                row.SubItems.Add(table.Rows[i][j].ToString());
                            }
                            lvwMember.Items.Add(row);
                        }
                    }

                    cmbSearchType.Enabled = false;

                }

            }
            catch
            {
            }
        }

        void StuffDependableLoad()
        {
            try
            {
                //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=HRPayRoll;User ID=sumon;Password=sumon123";
                string constr = "Data Source=GHHSERVER-PC\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=1234sumon123";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.dependable.dependable_name + ' (C/O - Stuff # ' + dbo.employee.employee_name + ')' AS Dependable_Name, dbo.dependable.mobile_no, dbo.dependable.image AS Image, '18' AS AGE, '4' AS Gender, case when dbo.employee.status='Officer' then 'Officer Dependable' when  dbo.employee.status='Stuff' then 'Stuff Dependable' end as status FROM dbo.dependable INNER JOIN dbo.employee ON dbo.dependable.stuff_id = dbo.employee.employee_id where dbo.dependable.status=0", con))
                    {

                        DataTable table = new DataTable();

                        sda.Fill(table);

                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                            for (int j = 1; j < table.Columns.Count; j++)
                            {
                                row.SubItems.Add(table.Rows[i][j].ToString());
                            }
                            lvwMember.Items.Add(row);
                        }
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
                            con.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.employee.employee_name + ' -(Stuff)' AS Name, dbo.employee.mobile AS Mobile_No, dbo.employee.image AS Image, DATEDIFF(yy,CONVERT(DATETIME, DOB),GETDATE()) AS AGE, case when gender_id=1 then '4' else '5' end as Gender, status from employee where mobile LIKE '%'  + @mobile + '%'", con))
                            {
                                sda.SelectCommand.Parameters.AddWithValue("@mobile", txtSearch.Text);
                                DataTable table = new DataTable();
                                sda.Fill(table);

                                lvwMember.Items.Clear();

                                if (sda != null)
                                {

                                    for (int i = 0; i < table.Rows.Count; i++)
                                    {
                                        ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                                        for (int j = 1; j < table.Columns.Count; j++)
                                        {
                                            row.SubItems.Add(table.Rows[i][j].ToString());
                                        }
                                        lvwMember.Items.Add(row);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
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
                            con.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.member.member_name+' (M. ID # '+ dbo.member.member_no +')' AS Member_Name, dbo.member.mobile_no AS Mobile_No, dbo.member.image AS Image, DATEDIFF(yy,CONVERT(DATETIME, DOB),GETDATE()) AS AGE, '4' as Gender, 'Member' as status FROM dbo.member where mobile_no LIKE '%'  + @mobile + '%'", con))
                            {
                                sda.SelectCommand.Parameters.AddWithValue("@mobile", txtSearch.Text);
                                DataTable table = new DataTable();
                                sda.Fill(table);

                                lvwMember.Items.Clear();

                                if (sda != null)
                                {

                                    for (int i = 0; i < table.Rows.Count; i++)
                                    {
                                        ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                                        for (int j = 1; j < table.Columns.Count; j++)
                                        {
                                            row.SubItems.Add(table.Rows[i][j].ToString());
                                        }
                                        lvwMember.Items.Add(row);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
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
                            con.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.dependable.dependable_name + ' (C/O - M. ID # ' + dbo.member.member_no + ')' AS Dependable_Name, dbo.dependable.mobile_no, dbo.dependable.image AS Image, '18' AS AGE, '4' AS Gender, 'Dependable' as status FROM dbo.dependable INNER JOIN dbo.member ON dbo.dependable.member_id = dbo.member.member_id where dbo.dependable.status=0 AND dbo.dependable.mobile_no LIKE '%'  + @mobile + '%'", con))
                            {
                                sda.SelectCommand.Parameters.AddWithValue("@mobile", txtSearch.Text);
                                DataTable table = new DataTable();
                                sda.Fill(table);

                                lvwMember.Items.Clear();

                                if (sda != null)
                                {

                                    for (int i = 0; i < table.Rows.Count; i++)
                                    {
                                        ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                                        for (int j = 1; j < table.Columns.Count; j++)
                                        {
                                            row.SubItems.Add(table.Rows[i][j].ToString());
                                        }
                                        lvwMember.Items.Add(row);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
                            }
                        
                        }

                    }

                }

                if (cmbSearchType.Text == "Stuff Dependable")
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    {

                        //string constr = "Data Source=DESKTOP-14FTT62\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=sumon123";
                        string constr = "Data Source=GHHSERVER-PC\\SQLEXPRESS;Initial Catalog=PayRoll;User ID=sumon;Password=1234sumon123";
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            con.Open();
                            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT dbo.dependable.dependable_name + ' (C/O - Stuff # ' + dbo.employee.employee_name + ')' AS Dependable_Name, dbo.dependable.mobile_no, dbo.dependable.image AS Image, '18' AS AGE, '4' AS Gender, case when dbo.employee.status='Officer' then 'Officer Dependable' when  dbo.employee.status='Stuff' then 'Stuff Dependable' end as status FROM dbo.dependable INNER JOIN dbo.employee ON dbo.dependable.stuff_id = dbo.employee.employee_id where dbo.dependable.status=0 AND dbo.dependable.mobile_no LIKE '%'  + @mobile + '%'", con))
                            {
                                sda.SelectCommand.Parameters.AddWithValue("@mobile", txtSearch.Text);
                                DataTable table = new DataTable();
                                sda.Fill(table);

                                lvwMember.Items.Clear();

                                if (sda != null)
                                {

                                    for (int i = 0; i < table.Rows.Count; i++)
                                    {
                                        ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                                        for (int j = 1; j < table.Columns.Count; j++)
                                        {
                                            row.SubItems.Add(table.Rows[i][j].ToString());
                                        }
                                        lvwMember.Items.Add(row);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No Data Found");
                                }
                            }

                        }

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

        private void lvwMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchType.Text == "Stuff")//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\GHHSERVER-PC\Photo\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        Image image = Image.FromFile(@"\\GHHSERVER-PC\Photo\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;
                        
                    }
                }

                if (cmbSearchType.Text == "Member")//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\KANDARI-PC\Image\Member\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        Image image = Image.FromFile(@"\\KANDARI-PC\Image\Member\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;
                        
                    }
                }

                if (cmbSearchType.Text == "Dependable")//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\KANDARI-PC\Image\Dependable\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        Image image = Image.FromFile(@"\\KANDARI-PC\Image\Dependable\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;
                        
                    }
                }

                if (cmbSearchType.Text == "Stuff Dependable")//&& grdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    pictureBox1.Image = null;

                    //var path = (@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text); //   //\\KUKS-PC\Image   //\\FSCR-PC\ID Photo\Students\   //DESKTOP-14FTT62
                    var path = (@"\\GHHSERVER-PC\Photo\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                    FileInfo file = new FileInfo(path);

                    if (file.Exists.Equals(true))
                    {
                        //Image image = Image.FromFile(@"\\DESKTOP-14FTT62\ID Photo\Students\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        Image image = Image.FromFile(@"\\GHHSERVER-PC\Photo\" + lvwMember.SelectedItems[0].SubItems[2].Text);
                        this.pictureBox1.Image = image;
                    }

                    else
                    {
                        this.pictureBox1.Image = null;

                    }
                }


            }
            catch
            {
            }
        }

        private void lvwMember_ItemActivate(object sender, EventArgs e)
        {
            try
            {

                if (oFrmInvestigationWithMember != null)
                {
                    InvestigationMember();
                }

                if (oFrmAdmissionMember != null)
                {
                    AdmissionMember();
                }

                
            }
            catch
            {
            }
        }

        void InvestigationMember()
        {
            try
            {
                oFrmInvestigationWithMember.LoadMemberName(cmbSearchType.SelectedItem.ToString(), lvwMember.SelectedItems[0].SubItems[0].Text, lvwMember.SelectedItems[0].SubItems[1].Text, lvwMember.SelectedItems[0].SubItems[3].Text, Convert.ToInt32(lvwMember.SelectedItems[0].SubItems[4].Text));
            }
            catch
            {
            }
        }

        void AdmissionMember()
        {
            try
            {
                oFrmAdmissionMember.LoadMemberName(lvwMember.SelectedItems[0].SubItems[5].Text, lvwMember.SelectedItems[0].SubItems[0].Text, lvwMember.SelectedItems[0].SubItems[1].Text, lvwMember.SelectedItems[0].SubItems[3].Text, Convert.ToInt32(lvwMember.SelectedItems[0].SubItems[4].Text));
            }
            catch
            {
            }
        }


    }
}
