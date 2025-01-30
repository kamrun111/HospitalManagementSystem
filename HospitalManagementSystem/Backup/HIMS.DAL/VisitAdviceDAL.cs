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
	public class VisitAdviceDAL
	{
		public VisitAdviceDAL()
		{
		}
		public List<VisitAdvice> Getvisit_advicesList()
		{
			SqlConnection conn = null;
			List<VisitAdvice> lstvisit_advices = new List<VisitAdvice>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_adviceGetAll", null, ref conn);
				while (dataReader.Read())
				{
					VisitAdvice ovisit_advice = new VisitAdvice();
					ovisit_advice.visit_advice_id = Convert.ToInt32(dataReader["visit_advice_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_advice.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["advice_id"] != DBNull.Value)
						ovisit_advice.advice_id = Convert.ToInt32(dataReader["advice_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_advice.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_advice.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_advice.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_advice.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstvisit_advices.Add(ovisit_advice);
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
			return lstvisit_advices;
		}
		public DataSet Getvisit_advices()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "visit_adviceGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public VisitAdvice Getvisit_advice(int visit_advice_id)
		{
			SqlConnection conn = null;
			VisitAdvice ovisit_advice = new VisitAdvice();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_advice_id", visit_advice_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_adviceGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ovisit_advice.visit_advice_id = Convert.ToInt32(dataReader["visit_advice_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_advice.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["advice_id"] != DBNull.Value)
						ovisit_advice.advice_id = Convert.ToInt32(dataReader["advice_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_advice.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_advice.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_advice.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_advice.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ovisit_advice;
		}
		public int Addvisit_advice(VisitAdvice ovisit_advice)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_advice.visit_prescription_id);
				arParams[1] = new SqlParameter("@advice_id", ovisit_advice.advice_id);
				arParams[2] = new SqlParameter("@record_created_by", ovisit_advice.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ovisit_advice.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_adviceAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatevisit_advice(VisitAdvice ovisit_advice)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_advice.visit_prescription_id);
				arParams[1] = new SqlParameter("@advice_id", ovisit_advice.advice_id);
				arParams[2] = new SqlParameter("@record_created_by", ovisit_advice.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ovisit_advice.record_modified_by);
				arParams[4] = new SqlParameter("@visit_advice_id", ovisit_advice.visit_advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_adviceUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int visit_docadviceUpdate(VisitAdvice ovisit_advice)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@record_modified_by", ovisit_advice.record_modified_by);
                arParams[1] = new SqlParameter("@visit_advice_id", ovisit_advice.visit_advice_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_docadviceUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removevisit_advice(VisitAdvice ovisit_advice)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_advice_id", ovisit_advice.visit_advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_adviceDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_advice(int visit_advice_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_advice_id", visit_advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_adviceDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
