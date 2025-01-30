using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class UserLogBLL
	{
		private UserLogDAL _userLogDAL;

		public UserLogDAL userLogDAL
		{
            get { return _userLogDAL; }
            set { _userLogDAL = value; }
		}

        public UserLogBLL()
		{
			userLogDAL = new UserLogDAL();
		}
		
		public DataSet GetUserLogs()
		{
			try
			{
				return userLogDAL.GetUserLogs();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public UserLog GetUserLog(int userLogID)
		{
			try
			{
                return userLogDAL.GetUserLog(userLogID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int AddUserLog(UserLog userLog)
		{
			try
			{
                return userLogDAL.AddUserLog(userLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateUserLog(UserLog userLog)
		{
			try
			{
                return userLogDAL.UpdateUserLog(userLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUserLog(UserLog userLog)
		{
			try
			{
                return userLogDAL.RemoveUserLog(userLog);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUserLog(int userLogID)
		{
			try
			{
                return userLogDAL.RemoveUserLog(userLogID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
