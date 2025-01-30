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
	public class PatientTreatementDAL
	{
		public PatientTreatementDAL()
		{
		}
		public List<PatientTreatement> Getpatient_treatementsList()
		{
			SqlConnection conn = null;
			List<PatientTreatement> lstpatient_treatements = new List<PatientTreatement>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_treatementGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientTreatement opatient_treatement = new PatientTreatement();
					opatient_treatement.patient_treatement_id = Convert.ToInt32(dataReader["patient_treatement_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_treatement.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["prescription_id"] != DBNull.Value)
						opatient_treatement.prescription_id = Convert.ToInt32(dataReader["prescription_id"]);

					if(dataReader["treatement_id"] != DBNull.Value)
						opatient_treatement.treatement_id = Convert.ToInt32(dataReader["treatement_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_treatement.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_treatement.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_treatement.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_treatement.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_treatements.Add(opatient_treatement);
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
			return lstpatient_treatements;
		}
		public DataSet Getpatient_treatements()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_treatementGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PatientTreatement Getpatient_treatement(int patient_treatement_id)
		{
			SqlConnection conn = null;
			PatientTreatement opatient_treatement = new PatientTreatement();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_treatement_id", patient_treatement_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_treatementGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_treatement.patient_treatement_id = Convert.ToInt32(dataReader["patient_treatement_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_treatement.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["prescription_id"] != DBNull.Value)
						opatient_treatement.prescription_id = Convert.ToInt32(dataReader["prescription_id"]);

					if(dataReader["treatement_id"] != DBNull.Value)
						opatient_treatement.treatement_id = Convert.ToInt32(dataReader["treatement_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_treatement.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_treatement.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_treatement.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_treatement.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_treatement;
		}
		public int Addpatient_treatement(PatientTreatement opatient_treatement)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_treatement.admission_id);
				arParams[1] = new SqlParameter("@prescription_id", opatient_treatement.prescription_id);
				arParams[2] = new SqlParameter("@treatement_id", opatient_treatement.treatement_id);
				arParams[3] = new SqlParameter("@record_created_by", opatient_treatement.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_treatement.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_treatementAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_treatement(PatientTreatement opatient_treatement)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_treatement.admission_id);
				arParams[1] = new SqlParameter("@prescription_id", opatient_treatement.prescription_id);
				arParams[2] = new SqlParameter("@treatement_id", opatient_treatement.treatement_id);
				arParams[3] = new SqlParameter("@record_created_by", opatient_treatement.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_treatement.record_modified_by);
				arParams[5] = new SqlParameter("@patient_treatement_id", opatient_treatement.patient_treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_treatementUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_treatement(PatientTreatement opatient_treatement)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_treatement_id", opatient_treatement.patient_treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_treatementDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_treatement(int patient_treatement_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_treatement_id", patient_treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_treatementDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
