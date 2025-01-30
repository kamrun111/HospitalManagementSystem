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
	public class MedicineTimingDAL
	{
		public MedicineTimingDAL()
		{
		}
		public List<MedicineTiming> Getmedicine_timingsList()
		{
			SqlConnection conn = null;
            List<MedicineTiming> lstmedicine_timings = new List<MedicineTiming>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "medicine_timingGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    MedicineTiming omedicine_timing = new MedicineTiming();
					omedicine_timing.medicine_timing_id = Convert.ToInt32(dataReader["medicine_timing_id"]);

					if(dataReader["medicine_timing"] != DBNull.Value)
						omedicine_timing.medicine_timing = Convert.ToString(dataReader["medicine_timing"]);

					if(dataReader["medicine_timing_value"] != DBNull.Value)
						omedicine_timing.medicine_timing_value = Convert.ToInt32(dataReader["medicine_timing_value"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						omedicine_timing.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						omedicine_timing.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						omedicine_timing.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						omedicine_timing.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstmedicine_timings.Add(omedicine_timing);
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
			return lstmedicine_timings;
		}
		public DataSet Getmedicine_timings()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "medicine_timingGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public MedicineTiming Getmedicine_timing(int medicine_timing_id)
		{
			SqlConnection conn = null;
            MedicineTiming omedicine_timing = new MedicineTiming();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@medicine_timing_id", medicine_timing_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "medicine_timingGet", arParams, ref conn);
				while (dataReader.Read())
				{
					omedicine_timing.medicine_timing_id = Convert.ToInt32(dataReader["medicine_timing_id"]);

					if(dataReader["medicine_timing"] != DBNull.Value)
						omedicine_timing.medicine_timing = Convert.ToString(dataReader["medicine_timing"]);

					if(dataReader["medicine_timing_value"] != DBNull.Value)
						omedicine_timing.medicine_timing_value = Convert.ToInt32(dataReader["medicine_timing_value"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						omedicine_timing.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						omedicine_timing.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						omedicine_timing.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						omedicine_timing.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return omedicine_timing;
		}
        public int Addmedicine_timing(MedicineTiming omedicine_timing)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@medicine_timing", omedicine_timing.medicine_timing);
				arParams[1] = new SqlParameter("@medicine_timing_value", omedicine_timing.medicine_timing_value);
				arParams[2] = new SqlParameter("@record_created_by", omedicine_timing.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", omedicine_timing.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicine_timingAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatemedicine_timing(MedicineTiming omedicine_timing)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@medicine_timing", omedicine_timing.medicine_timing);
				arParams[1] = new SqlParameter("@medicine_timing_value", omedicine_timing.medicine_timing_value);
				arParams[2] = new SqlParameter("@record_created_by", omedicine_timing.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", omedicine_timing.record_modified_by);
				arParams[4] = new SqlParameter("@medicine_timing_id", omedicine_timing.medicine_timing_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicine_timingUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removemedicine_timing(MedicineTiming omedicine_timing)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@medicine_timing_id", omedicine_timing.medicine_timing_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicine_timingDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removemedicine_timing(int medicine_timing_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@medicine_timing_id", medicine_timing_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicine_timingDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
