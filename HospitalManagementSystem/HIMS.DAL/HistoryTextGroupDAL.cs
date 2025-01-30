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
	public class HistoryTextGroupDAL
	{
		public HistoryTextGroupDAL()
		{
		}
		public List<HistoryTextGroup> Gethistory_text_groupsList()
		{
			SqlConnection conn = null;
			List<HistoryTextGroup> lsthistory_text_groups = new List<HistoryTextGroup>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "history_text_groupGetAll", null, ref conn);
				while (dataReader.Read())
				{
					HistoryTextGroup ohistory_text_group = new HistoryTextGroup();
					ohistory_text_group.history_text_group_id = Convert.ToInt32(dataReader["history_text_group_id"]);

					if(dataReader["history_text_group"] != DBNull.Value)
						ohistory_text_group.history_text_group = Convert.ToString(dataReader["history_text_group"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ohistory_text_group.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ohistory_text_group.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ohistory_text_group.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ohistory_text_group.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsthistory_text_groups.Add(ohistory_text_group);
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
			return lsthistory_text_groups;
		}
		public DataSet Gethistory_text_groups()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "history_text_groupGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetHistoryItmGrpByHistoryGrp(string histItmGrp)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@history_text_group", histItmGrp);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "HistoryItmGrpGetByHistoryGrp", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public HistoryTextGroup Gethistory_text_group(int history_text_group_id)
		{
			SqlConnection conn = null;
			HistoryTextGroup ohistory_text_group = new HistoryTextGroup();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_group_id", history_text_group_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "history_text_groupGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ohistory_text_group.history_text_group_id = Convert.ToInt32(dataReader["history_text_group_id"]);

					if(dataReader["history_text_group"] != DBNull.Value)
						ohistory_text_group.history_text_group = Convert.ToString(dataReader["history_text_group"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ohistory_text_group.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ohistory_text_group.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ohistory_text_group.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ohistory_text_group.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ohistory_text_group;
		}
		public int Addhistory_text_group(HistoryTextGroup ohistory_text_group)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@history_text_group", ohistory_text_group.history_text_group);
				
				arParams[1] = new SqlParameter("@record_created_by", ohistory_text_group.record_created_by);
				
				arParams[2] = new SqlParameter("@record_modified_by", ohistory_text_group.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_groupAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatehistory_text_group(HistoryTextGroup ohistory_text_group)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@history_text_group", ohistory_text_group.history_text_group);
				arParams[1] = new SqlParameter("@record_created_by", ohistory_text_group.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ohistory_text_group.record_modified_by);
				arParams[3] = new SqlParameter("@history_text_group_id", ohistory_text_group.history_text_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_groupUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text_group(HistoryTextGroup ohistory_text_group)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_group_id", ohistory_text_group.history_text_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_groupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text_group(int history_text_group_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_group_id", history_text_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_groupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
