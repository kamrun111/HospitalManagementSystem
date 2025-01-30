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
	public class OutdoorPatientAdviceDAL
	{
		public OutdoorPatientAdviceDAL()
		{
		}
		public List<OutdoorPatientAdvice> Getoutdoor_patient_advicesList()
		{
			SqlConnection conn = null;
			List<OutdoorPatientAdvice> lstoutdoor_patient_advices = new List<OutdoorPatientAdvice>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_adviceGetAll", null, ref conn);
				while (dataReader.Read())
				{
					OutdoorPatientAdvice ooutdoor_patient_advice = new OutdoorPatientAdvice();
					ooutdoor_patient_advice.outdoor_patient_advice_id = Convert.ToInt32(dataReader["outdoor_patient_advice_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_advice.outdoor_booking_id = Convert.ToString(dataReader["outdoor_booking_id"]);

					if(dataReader["outdoor_patient_advice"] != DBNull.Value)
						ooutdoor_patient_advice.outdoor_patient_advice = Convert.ToString(dataReader["outdoor_patient_advice"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_advice.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_advice.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_advice.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_advice.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstoutdoor_patient_advices.Add(ooutdoor_patient_advice);
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
			return lstoutdoor_patient_advices;
		}
		public DataSet Getoutdoor_patient_advices()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "outdoor_patient_adviceGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public OutdoorPatientAdvice Getoutdoor_patient_advice(int outdoor_patient_advice_id)
		{
			SqlConnection conn = null;
			OutdoorPatientAdvice ooutdoor_patient_advice = new OutdoorPatientAdvice();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_advice_id", outdoor_patient_advice_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_adviceGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ooutdoor_patient_advice.outdoor_patient_advice_id = Convert.ToInt32(dataReader["outdoor_patient_advice_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_advice.outdoor_booking_id = Convert.ToString(dataReader["outdoor_booking_id"]);

					if(dataReader["outdoor_patient_advice"] != DBNull.Value)
						ooutdoor_patient_advice.outdoor_patient_advice = Convert.ToString(dataReader["outdoor_patient_advice"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_advice.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_advice.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_advice.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_advice.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ooutdoor_patient_advice;
		}
		public int Addoutdoor_patient_advice(OutdoorPatientAdvice ooutdoor_patient_advice)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_advice.outdoor_booking_id);
				arParams[1] = new SqlParameter("@outdoor_patient_advice", ooutdoor_patient_advice.outdoor_patient_advice);
				arParams[2] = new SqlParameter("@record_created_by", ooutdoor_patient_advice.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ooutdoor_patient_advice.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_adviceAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_advice(OutdoorPatientAdvice ooutdoor_patient_advice)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_advice.outdoor_booking_id);
				arParams[1] = new SqlParameter("@outdoor_patient_advice", ooutdoor_patient_advice.outdoor_patient_advice);
				arParams[2] = new SqlParameter("@record_created_by", ooutdoor_patient_advice.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", ooutdoor_patient_advice.record_modified_by);
				arParams[4] = new SqlParameter("@outdoor_patient_advice_id", ooutdoor_patient_advice.outdoor_patient_advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_adviceUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_advice(OutdoorPatientAdvice ooutdoor_patient_advice)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_advice_id", ooutdoor_patient_advice.outdoor_patient_advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_adviceDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_advice(int outdoor_patient_advice_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_advice_id", outdoor_patient_advice_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_adviceDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetOutdoorAdvice(char outdoor_booking_id, DateTime record_created_date)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@outdoor_booking_id", outdoor_booking_id);
                arParams[1] = new SqlParameter("@record_created_date", record_created_date);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorAdvice", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }



	}




}
