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
	public class PatientStatusDAL
	{
		public PatientStatusDAL()
		{
		}
		public List<PatientStatus> Getpatient_statussList()
		{
			SqlConnection conn = null;
            List<PatientStatus> lstpatient_statuss = new List<PatientStatus>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_statusGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    PatientStatus opatient_status = new PatientStatus();
					opatient_status.patient_status_id = Convert.ToInt32(dataReader["patient_status_id"]);

					if(dataReader["patient_status"] != DBNull.Value)
						opatient_status.patient_status = Convert.ToString(dataReader["patient_status"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_status.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_status.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_status.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_status.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_statuss.Add(opatient_status);
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
			return lstpatient_statuss;
		}
		public DataSet Getpatient_statuss()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_statusGet"); //change from patient_statusGetAll
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public PatientStatus Getpatient_status(int patient_status_id)
		{
			SqlConnection conn = null;
            PatientStatus opatient_status = new PatientStatus();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_status_id", patient_status_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_statusGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_status.patient_status_id = Convert.ToInt32(dataReader["patient_status_id"]);

					if(dataReader["patient_status"] != DBNull.Value)
						opatient_status.patient_status = Convert.ToString(dataReader["patient_status"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_status.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_status.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_status.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_status.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_status;
		}
        public int Addpatient_status(PatientStatus opatient_status)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@patient_status", opatient_status.patient_status);
				arParams[1] = new SqlParameter("@record_created_by", opatient_status.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", opatient_status.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_statusAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatepatient_status(PatientStatus opatient_status)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@patient_status", opatient_status.patient_status);
				arParams[1] = new SqlParameter("@record_created_by", opatient_status.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", opatient_status.record_modified_by);
				arParams[3] = new SqlParameter("@patient_status_id", opatient_status.patient_status_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_statusUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removepatient_status(PatientStatus opatient_status)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_status_id", opatient_status.patient_status_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_statusDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_status(int patient_status_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_status_id", patient_status_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_statusDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
