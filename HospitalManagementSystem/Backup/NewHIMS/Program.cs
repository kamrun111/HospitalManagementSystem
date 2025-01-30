using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewHIMS.MDI;
using NewHIMS.Forms.Login;
using NewHIMS.Forms.Doctor_Station;

namespace NewHIMS
{
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            new ApplicatinLauncher().LauncheApplication();
            //new C2().F1();
            //C1 c1 = new C2();
            //c1.F1();
            //new C3().F1();
        }
    }

    public class C1
    {
        public C1()
        {
        }
        public void F1()
        {
            MessageBox.Show("C1.F1");
        }
    }
    public class C2 : C1
    {
        public C2()
        {
        }
        public new void F1()
        {
            
            MessageBox.Show("C2.F1");

        }
    }
    public class C3 : C2
    {
        public C3()
        {
        }        
    }

    public class ApplicatinLauncher
    {
        public static string _realname;
        public static string _userName = "";
        public static int _userId = 0;
        public static int _groupID = 0;
        public static int _floorID = 0;
        public static string _floor ="";
        public static string _GroupName = "";
        public static sbyte _Insert = 0;
        public static sbyte _edit= 0;
        public static sbyte _Delete = 0;
        public static int Total = 0;
        public ApplicatinLauncher()
        {
        }
        public void LauncheApplication()
        {
            try
            {
                if (new FrmLogin().ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmMain(_userName));
                }

            }
            catch
            {
            }

        }
    }
}