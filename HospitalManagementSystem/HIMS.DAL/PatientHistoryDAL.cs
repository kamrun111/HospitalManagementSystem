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
	public class PatientHistoryDAL
	{
		public PatientHistoryDAL()
		{
		}
		public List<PatientHistoryBO> Getpatient_historysList()
		{
			SqlConnection conn = null;
			List<PatientHistoryBO> lstpatient_historys = new List<PatientHistoryBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_historyGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientHistoryBO opatient_history = new PatientHistoryBO();
					opatient_history.patient_history_id = Convert.ToInt32(dataReader["patient_history_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_history.admission_id = Convert.ToInt32(dataReader["admission_id"]);

                    if (dataReader["history_text_id"] != DBNull.Value)
                        opatient_history.history_text_id = Convert.ToInt32(dataReader["history_text_id"]);
                    
                    if(dataReader["history_text_value_id"] != DBNull.Value)
						opatient_history.history_text_value_id = Convert.ToInt32(dataReader["history_text_value_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_history.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_history.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_history.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_history.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_historys.Add(opatient_history);
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
			return lstpatient_historys;
		}
		public DataSet Getpatient_historys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_historyGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetPatientHistoryTextValue(int admissionID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPatientHistoryTextValue",arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PatientHistoryBO Getpatient_history(int patient_history_id)
		{
			SqlConnection conn = null;
			PatientHistoryBO opatient_history = new PatientHistoryBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_history_id", patient_history_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_historyGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_history.patient_history_id = Convert.ToInt32(dataReader["patient_history_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_history.admission_id = Convert.ToInt32(dataReader["admission_id"]);

                    if (dataReader["history_text_id"] != DBNull.Value)
                        opatient_history.history_text_id = Convert.ToInt32(dataReader["history_text_id"]);
                    
                    if(dataReader["history_text_value_id"] != DBNull.Value)
						opatient_history.history_text_value_id = Convert.ToInt32(dataReader["history_text_value_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_history.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_history.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_history.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_history.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_history;
		}
		public int Addpatient_history(PatientHistoryBO opatient_history)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_history.admission_id);
                arParams[1] = new SqlParameter("@history_text_id", opatient_history.history_text_id);
                arParams[2] = new SqlParameter("@history_text_value_id", opatient_history.history_text_value_id);
				arParams[3] = new SqlParameter("@record_created_by", opatient_history.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_history.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_historyAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_history(PatientHistoryBO opatient_history)
		{
			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_history.admission_id);
                arParams[1] = new SqlParameter("@history_text_id", opatient_history.history_text_id);
                arParams[2] = new SqlParameter("@history_text_value_id", opatient_history.history_text_value_id);
				arParams[3] = new SqlParameter("@record_created_by", opatient_history.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_history.record_modified_by);
				arParams[5] = new SqlParameter("@patient_history_id", opatient_history.patient_history_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_historyUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int SetIsHistoyWritten(int admnID)
		{
			SqlParameter[] arParams = new SqlParameter[1];
			try
			{
                arParams[0] = new SqlParameter("@admission_id", admnID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SetIsHistoyWritten", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_history(PatientHistoryBO opatient_history)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_history_id", opatient_history.patient_history_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_historyDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_history(int admnID,int historyTextID)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                arParams[1] = new SqlParameter("@history_text_id", historyTextID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "HTextDeleteByAdmnIDAndHTextID", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
