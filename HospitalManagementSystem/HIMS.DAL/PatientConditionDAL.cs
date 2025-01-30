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
	public class PatientConditionDAL
	{
		public PatientConditionDAL()
		{
		}
		public List<PatientCondition> Getpatient_conditionsList()
		{
			SqlConnection conn = null;
			List<PatientCondition> lstpatient_conditions = new List<PatientCondition>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_conditionGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientCondition opatient_condition = new PatientCondition();
					opatient_condition.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

					if(dataReader["patient_condition"] != DBNull.Value)
						opatient_condition.patient_condition = Convert.ToString(dataReader["patient_condition"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_condition.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_condition.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_condition.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_condition.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_conditions.Add(opatient_condition);
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
			return lstpatient_conditions;
		}
		public DataSet Getpatient_conditions()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_conditionGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PatientCondition Getpatient_condition(int patient_condition_id)
		{
			SqlConnection conn = null;
			PatientCondition opatient_condition = new PatientCondition();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_condition_id", patient_condition_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_conditionGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_condition.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

					if(dataReader["patient_condition"] != DBNull.Value)
						opatient_condition.patient_condition = Convert.ToString(dataReader["patient_condition"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_condition.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_condition.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_condition.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_condition.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_condition;
		}
		public int Addpatient_condition(PatientCondition opatient_condition)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@patient_condition", opatient_condition.patient_condition);
				arParams[1] = new SqlParameter("@record_created_by", opatient_condition.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", opatient_condition.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_conditionAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_condition(PatientCondition opatient_condition)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@patient_condition", opatient_condition.patient_condition);
				arParams[1] = new SqlParameter("@record_created_by", opatient_condition.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", opatient_condition.record_modified_by);
				arParams[3] = new SqlParameter("@patient_condition_id", opatient_condition.patient_condition_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_conditionUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_condition(PatientCondition opatient_condition)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_condition_id", opatient_condition.patient_condition_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_conditionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_condition(int patient_condition_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_condition_id", patient_condition_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_conditionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
