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
	public class HistoryTextDAL
	{
		public HistoryTextDAL()
		{
		}
		public List<HistoryText> Gethistory_textsList()
		{
			SqlConnection conn = null;
			List<HistoryText> lsthistory_texts = new List<HistoryText>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "history_textGetAll", null, ref conn);
				while (dataReader.Read())
				{
					HistoryText ohistory_text = new HistoryText();
					ohistory_text.history_text_id = Convert.ToInt32(dataReader["history_text_id"]);

					if(dataReader["history_text"] != DBNull.Value)
						ohistory_text.history_text = Convert.ToString(dataReader["history_text"]);

					if(dataReader["history_text_group_id"] != DBNull.Value)
						ohistory_text.history_text_group_id = Convert.ToInt32(dataReader["history_text_group_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ohistory_text.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ohistory_text.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ohistory_text.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ohistory_text.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsthistory_texts.Add(ohistory_text);
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
			return lsthistory_texts;
		}
		public DataSet Gethistory_texts()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "history_textGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
       
        public DataSet GetHistoryTextByHistoryTextGroup(int historyTextGroupID)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_group_id", historyTextGroupID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetHistoryTextByHistoryTextGroup",arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public HistoryText Gethistory_text(int history_text_id)
		{
			SqlConnection conn = null;
			HistoryText ohistory_text = new HistoryText();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_id", history_text_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "history_textGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ohistory_text.history_text_id = Convert.ToInt32(dataReader["history_text_id"]);

					if(dataReader["history_text"] != DBNull.Value)
						ohistory_text.history_text = Convert.ToString(dataReader["history_text"]);

					if(dataReader["history_text_group_id"] != DBNull.Value)
						ohistory_text.history_text_group_id = Convert.ToInt32(dataReader["history_text_group_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ohistory_text.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ohistory_text.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ohistory_text.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ohistory_text.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ohistory_text;
		}
		public int Addhistory_text(HistoryText ohistory_text)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@history_text", ohistory_text.history_text);
				arParams[1] = new SqlParameter("@history_text_group_id", ohistory_text.history_text_group_id);
				arParams[2] = new SqlParameter("@record_created_by", ohistory_text.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ohistory_text.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_textAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatehistory_text(HistoryText ohistory_text)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@history_text", ohistory_text.history_text);
				arParams[1] = new SqlParameter("@history_text_group_id", ohistory_text.history_text_group_id);
				arParams[2] = new SqlParameter("@record_created_by", ohistory_text.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ohistory_text.record_modified_by);
				arParams[4] = new SqlParameter("@history_text_id", ohistory_text.history_text_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_textUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text(HistoryText ohistory_text)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_id", ohistory_text.history_text_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_textDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text(int history_text_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_id", history_text_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_textDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
