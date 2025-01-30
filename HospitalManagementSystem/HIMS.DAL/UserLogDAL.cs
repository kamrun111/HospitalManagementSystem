using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
	public class UserLogDAL
	{
		public UserLogDAL()
		{
		}

        public DataSet GetUserLogs()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "UserLogGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public UserLog GetUserLog(int userLogID)
		{
			SqlConnection conn = null;
            UserLog userLog = new UserLog();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@userLogID", userLogID);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "UserLogGetAll", arParams, ref conn);
				while (dataReader.Read())
				{
                    userLog.user_log_id = Convert.ToInt32(dataReader["userLogID"]);

					if(dataReader["user_id"] != DBNull.Value)
                        userLog.user_id = Convert.ToInt32(dataReader["user_id"]);

                    if (dataReader["login_time"] != DBNull.Value)
                        userLog.login_time = Convert.ToDateTime(dataReader["login_time"]);

                    if (dataReader["logout_time"] != DBNull.Value)
                        userLog.logout_time = Convert.ToDateTime(dataReader["logout_time"]);

				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return userLog;
		}
		public int AddUserLog(UserLog userLog)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@user_id", userLog.user_id);
				arParams[1] = new SqlParameter("@login_time", userLog.login_time);
				arParams[2] = new SqlParameter("@logout_time", userLog.logout_time);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserLOgAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int UpdateUserLog(UserLog userLog)
		{

			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@user_id", userLog.user_id);
				arParams[1] = new SqlParameter("@login_time", userLog.login_time);
				arParams[2] = new SqlParameter("@logout_time", userLog.logout_time);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserLOgUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_log_id", userLog.user_log_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserLogDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@userLogID", userLogID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserLogDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
