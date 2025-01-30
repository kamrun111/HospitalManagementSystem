using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using HIMS.DAL;



namespace NewHIMS.Forms.Login
{
    public partial class FrmDBBackup : Form
    {
        public FrmDBBackup()
        {
            InitializeComponent();
        }


     
        private void btnbackupDb_Click(object sender, EventArgs e)
        {
            try
            {

                string path;
                if (!(txtPath.Text.EndsWith("\\")))
                {
                    path = txtPath.Text + "\\";
                }
                else
                {
                    path = txtPath.Text;
                }
                string s = DbHelper.ConnectionString;
                SqlConnection con = new SqlConnection(s);
                con.Open();
                string saveFileName = "DataBase-Backup-HMS-" + DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt");
                SqlCommand sqlcmd = new SqlCommand(s, con);
                sqlcmd = new SqlCommand("backup database HMS to disk='" + path + saveFileName.Replace(@":", @"-") + ".bak'", con);
                sqlcmd.ExecuteNonQuery();
                con.Close();                 
                MessageBox.Show("Backup Successfully Done.");


                






            }
            catch
            {
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
                folderBrowserDlg.ShowNewFolderButton = true;
                DialogResult dlgResult = folderBrowserDlg.ShowDialog();
                if (dlgResult.Equals(DialogResult.OK))
                {
                    //Show selected folder path in textbox1.
                    txtPath.Text = folderBrowserDlg.SelectedPath;
                    //Browsing start from root folder.
                    Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
                }
            }
            catch
            {
            }
        }
    }
}
