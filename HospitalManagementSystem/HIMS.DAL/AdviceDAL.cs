using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;
//Check it
namespace HIMS.DAL
{
	public class AdviceDAL
	{
		public AdviceDAL()
		{
		}
		public List<Advice> GetadvicesList()
		{
			SqlConnection conn = null;
			List<Advice> lstadvices = new List<Advice>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "adviceGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Advice oadvice = new Advice();
					oadvice.advice_id = Convert.ToInt32(dataReader["advice_id"]);

					if(dataReader["advice"] != DBNull.Value)
						oadvice.advice = Convert.ToString(dataReader["advice"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oadvice.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oadvice.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oadvice.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oadvice.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstadvices.Add(oadvice);
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
			return lstadvices;
		}
		public DataSet Getadvices()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "adviceGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet LoggTime()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "LoggTime");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public Advice Getadvice(int advice_id)
		{
			SqlConnection conn = null;
			Advice oadvice = new Advice();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@advice_id", advice_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "adviceGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oadvice.advice_id = Convert.ToInt32(dataReader["advice_id"]);

					if(dataReader["advice"] != DBNull.Value)
						oadvice.advice = Convert.ToString(dataReader["advice"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oadvice.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oadvice.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oadvice.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oadvice.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oadvice;
		}
		public int Addadvice(Advice oadvice)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@advice", oadvice.advice);
				arParams[1] = new SqlParameter("@record_created_date", oadvice.record_created_date);
				arParams[2] = new SqlParameter("@record_created_by", oadvice.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_date", oadvice.record_modified_date);
				arParams[4] = new SqlParameter("@record_modified_by", oadvice.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "adviceAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateadvice(Advice oadvice)
		{

			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@advice", oadvice.advice);
				arParams[1] = new SqlParameter("@record_created_date", oadvice.record_created_date);
				arParams[2] = new SqlParameter("@record_created_by", oadvice.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_date", oadvice.record_modified_date);
				arParams[4] = new SqlParameter("@record_modified_by", oadvice.record_modified_by);
				arParams[5] = new SqlParameter("@advice_id", oadvice.advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "adviceUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeadvice(Advice oadvice)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@advice_id", oadvice.advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "adviceDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeadvice(int advice_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@advice_id", advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "adviceDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AdviceAddFromDr(Advice advice)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@advice", advice.advice);
                arParams[1] = new SqlParameter("@advice_type", advice.advice_type);
                arParams[2] = new SqlParameter("@advice_id", SqlDbType.Int, 4);
                arParams[2].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "AdviceAddFromDr", arParams);
                result = Convert.ToInt32(arParams[2].Value.ToString());

            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }
	}
}
