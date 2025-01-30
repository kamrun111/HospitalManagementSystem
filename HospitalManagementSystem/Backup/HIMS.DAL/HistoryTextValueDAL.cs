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
	public class HistoryTextValueDAL
	{
		public HistoryTextValueDAL()
		{
		}
		public List<HistoryTextValue> Gethistory_text_valuesList()
		{
			SqlConnection conn = null;
            List<HistoryTextValue> lsthistory_text_values = new List<HistoryTextValue>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "history_text_valueGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    HistoryTextValue ohistory_text_value = new HistoryTextValue();
					ohistory_text_value.history_text_value_id = Convert.ToInt32(dataReader["history_text_value_id"]);

					if(dataReader["history_text_value"] != DBNull.Value)
						ohistory_text_value.history_text_value = Convert.ToString(dataReader["history_text_value"]);

					if(dataReader["history_text_id"] != DBNull.Value)
						ohistory_text_value.history_text_id = Convert.ToInt32(dataReader["history_text_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ohistory_text_value.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ohistory_text_value.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ohistory_text_value.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ohistory_text_value.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsthistory_text_values.Add(ohistory_text_value);
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
            return lsthistory_text_values;
		}
		public DataSet Gethistory_text_values()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "history_text_valueGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GeHTextValueByHText(string historyText)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@history_text", historyText);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "HTextValueByHTextGet", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GeHTextValueByAdmnIDAndHText(int admnID,string historyText)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                arParams[1] = new SqlParameter("@history_text_id", historyText);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "HTextValueByAdmnIDAndHTextIDGet", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet CheckAndSaveHTextValueAndPHistory(string historyTextValue, int historyTextID,int admnID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[3];
                arParams[0] = new SqlParameter("@HTextValue", historyTextValue);
                arParams[1] = new SqlParameter("@HTextID", historyTextID);
                arParams[2] = new SqlParameter("@AdmnID", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "CheckAndSaveHTextValueAndPHistory", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public HistoryTextValue Gethistory_text_value(int history_text_value_id)
		{
			SqlConnection conn = null;
            HistoryTextValue ohistory_text_value = new HistoryTextValue();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_value_id", history_text_value_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "history_text_valueGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ohistory_text_value.history_text_value_id = Convert.ToInt32(dataReader["history_text_value_id"]);

					if(dataReader["history_text_value"] != DBNull.Value)
						ohistory_text_value.history_text_value = Convert.ToString(dataReader["history_text_value"]);

					if(dataReader["history_text_id"] != DBNull.Value)
						ohistory_text_value.history_text_id = Convert.ToInt32(dataReader["history_text_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ohistory_text_value.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ohistory_text_value.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ohistory_text_value.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ohistory_text_value.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return ohistory_text_value;
		}
        public int Addhistory_text_value(HistoryTextValue ohistory_text_value)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@history_text_value", ohistory_text_value.history_text_value);
				arParams[1] = new SqlParameter("@history_text_id", ohistory_text_value.history_text_id);
				
				arParams[2] = new SqlParameter("@record_created_by", ohistory_text_value.record_created_by);
				
				arParams[3] = new SqlParameter("@record_modified_by", ohistory_text_value.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_valueAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatehistory_text_value(HistoryTextValue ohistory_text_value)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@history_text_value", ohistory_text_value.history_text_value);
				arParams[1] = new SqlParameter("@history_text_id", ohistory_text_value.history_text_id);
				arParams[2] = new SqlParameter("@record_created_by", ohistory_text_value.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ohistory_text_value.record_modified_by);
				arParams[4] = new SqlParameter("@history_text_value_id", ohistory_text_value.history_text_value_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_valueUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removehistory_text_value(HistoryTextValue ohistory_text_value)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_value_id", ohistory_text_value.history_text_value_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_valueDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text_value(int history_text_value_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@history_text_value_id", history_text_value_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "history_text_valueDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
