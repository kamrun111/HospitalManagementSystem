using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.ComponentModel;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class FormHelper
	{
        private static string _dbServer;
        private static string _dbName;
        private static string _dbUser;
        private static string _dbUserPassword;

        private static void SplitConnectionString()
        {
            string conn = DbHelper.ConnectionString;
            string[] arr;
            arr = conn.Split(';');
            _dbServer = (arr[0].Split('='))[1];
            _dbName = (arr[1].Split('='))[1];
            _dbUser = (arr[2].Split('='))[1];
            _dbUserPassword = (arr[3].Split('='))[1];
        }

        public static string DBServerName
        {
            get
            {
                FormHelper.SplitConnectionString();
                return FormHelper._dbServer;
            }
        }

        public static string DBName
        {
            get
            {
                FormHelper.SplitConnectionString();
                return FormHelper._dbName;
            }
        }

        public static string DBUser
        {
            get
            {
                FormHelper.SplitConnectionString();
                return FormHelper._dbUser;
            }
        }

        public static string DBUserPassword
        {
            get
            {
                FormHelper.SplitConnectionString();
                return FormHelper._dbUserPassword;
            }
        }

        public static int getMonthDays(int mon)
        {
            try
            {
                 switch (mon)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        return 31;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:

                        if (DateTime.Now.Year % 4 == 0)
                        {

                            return 29;
                        }
                        return 28;
                }
            }
            catch
            {
            }
            return 28;
        }
        
        
        public static void CalculateAge(DateTime dob, out int years, out int months, out int days)
        {
            years = 0;
            months = 0;
            days = 0;
            try
            {
                int dtmp = 0; int ytmp = 0;
                DateTime now = DateTime.Now;
                if (dob.Day <= now.Day)
                { days = now.Day - dob.Day; }
                else
                { days = getMonthDays(dob.Month) + now.Day - dob.Day; dtmp = 1; }
                if (dob.Month <= now.Month - dtmp)
                { months = now.Month - dob.Month - dtmp; }
                else
                { months = 12 + now.Month - dob.Month; ytmp = 1; }

                if (dob.Year <= now.Year - ytmp)
                { years = now.Year - dob.Year - ytmp; }
            }
            catch
            {
            }
        }

        public static DateTime calculateDOB(int years, int months, int days)
        {
            try
            {
                if (years >= 0 && months >= 0 && days >= 0)
                {

                    DateTime dob = DateTime.Now;
                    dob = dob.AddYears(-years);
                    dob = dob.AddMonths(-months);
                    dob = dob.AddDays(-days);
                    return dob;
                }
            }
            catch
            {
            }
            return DateTime.Now;
        }
		
	}
}
