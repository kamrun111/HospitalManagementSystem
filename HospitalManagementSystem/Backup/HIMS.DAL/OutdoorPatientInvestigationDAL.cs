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
	public class OutdoorPatientInvestigationDAL
	{
		public OutdoorPatientInvestigationDAL()
		{
		}
		public List<OutdoorPatientInvestigation> Getoutdoor_patient_investigationsList()
		{
			SqlConnection conn = null;
			List<OutdoorPatientInvestigation> lstoutdoor_patient_investigations = new List<OutdoorPatientInvestigation>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_investigationGetAll", null, ref conn);
				while (dataReader.Read())
				{
					OutdoorPatientInvestigation ooutdoor_patient_investigation = new OutdoorPatientInvestigation();
					ooutdoor_patient_investigation.outdoor_patient_investigation_id = Convert.ToInt32(dataReader["outdoor_patient_investigation_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_investigation.outdoor_booking_id = Convert.ToString(dataReader["outdoor_booking_id"]);

					if(dataReader["investigation_name"] != DBNull.Value)
						ooutdoor_patient_investigation.investigation_name = Convert.ToString(dataReader["investigation_name"]);

					if(dataReader["investivation_result"] != DBNull.Value)
						ooutdoor_patient_investigation.investivation_result = Convert.ToString(dataReader["investivation_result"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_investigation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_investigation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_investigation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_investigation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstoutdoor_patient_investigations.Add(ooutdoor_patient_investigation);
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
			return lstoutdoor_patient_investigations;
		}
		public DataSet Getoutdoor_patient_investigations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "outdoor_patient_investigationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public OutdoorPatientInvestigation Getoutdoor_patient_investigation(int outdoor_patient_investigation_id)
		{
			SqlConnection conn = null;
			OutdoorPatientInvestigation ooutdoor_patient_investigation = new OutdoorPatientInvestigation();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_investigation_id", outdoor_patient_investigation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_investigationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ooutdoor_patient_investigation.outdoor_patient_investigation_id = Convert.ToInt32(dataReader["outdoor_patient_investigation_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_investigation.outdoor_booking_id = Convert.ToString(dataReader["outdoor_booking_id"]);

					if(dataReader["investigation_name"] != DBNull.Value)
						ooutdoor_patient_investigation.investigation_name = Convert.ToString(dataReader["investigation_name"]);

					if(dataReader["investivation_result"] != DBNull.Value)
						ooutdoor_patient_investigation.investivation_result = Convert.ToString(dataReader["investivation_result"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_investigation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_investigation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_investigation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_investigation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ooutdoor_patient_investigation;
		}
		public int Addoutdoor_patient_investigation(OutdoorPatientInvestigation ooutdoor_patient_investigation)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_investigation.outdoor_booking_id);
				arParams[1] = new SqlParameter("@investigation_name", ooutdoor_patient_investigation.investigation_name);
				arParams[2] = new SqlParameter("@investivation_result", ooutdoor_patient_investigation.investivation_result);
				arParams[3] = new SqlParameter("@record_created_by", ooutdoor_patient_investigation.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", ooutdoor_patient_investigation.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_investigationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_investigation(OutdoorPatientInvestigation ooutdoor_patient_investigation)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_investigation.outdoor_booking_id);
				arParams[1] = new SqlParameter("@investigation_name", ooutdoor_patient_investigation.investigation_name);
				arParams[2] = new SqlParameter("@investivation_result", ooutdoor_patient_investigation.investivation_result);
				arParams[3] = new SqlParameter("@record_created_by", ooutdoor_patient_investigation.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", ooutdoor_patient_investigation.record_modified_by);
				arParams[5] = new SqlParameter("@outdoor_patient_investigation_id", ooutdoor_patient_investigation.outdoor_patient_investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_investigationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_investigation(OutdoorPatientInvestigation ooutdoor_patient_investigation)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_investigation_id", ooutdoor_patient_investigation.outdoor_patient_investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_investigationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_investigation(int outdoor_patient_investigation_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_investigation_id", outdoor_patient_investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_investigationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetOutdoorInvestigation(char outdoor_booking_id, DateTime record_created_date)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@outdoor_booking_id", outdoor_booking_id);
                arParams[1] = new SqlParameter("@record_created_date", record_created_date);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorInvestigation", arParams);
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
