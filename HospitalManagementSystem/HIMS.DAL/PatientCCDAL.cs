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
	public class PatientCCDAL
	{
		public PatientCCDAL()
		{
		}
		public List<PatientCC> Getpatient_ccsList()
		{
			SqlConnection conn = null;
			List<PatientCC> lstpatient_ccs = new List<PatientCC>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_ccGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientCC opatient_cc = new PatientCC();
					opatient_cc.patient_cc_id = Convert.ToInt32(dataReader["patient_cc_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_cc.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["cc"] != DBNull.Value)
						opatient_cc.cc = Convert.ToString(dataReader["cc"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_cc.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_cc.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_cc.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_cc.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_ccs.Add(opatient_cc);
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
			return lstpatient_ccs;
		}
		public DataSet Getpatient_ccs()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_ccGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}


        public DataSet PatientCCGetByAdmnID(int admnID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PatientCCGetByAdmnID",arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PatientCC Getpatient_cc(int patient_cc_id)
		{
			SqlConnection conn = null;
			PatientCC opatient_cc = new PatientCC();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_cc_id", patient_cc_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_ccGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_cc.patient_cc_id = Convert.ToInt32(dataReader["patient_cc_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_cc.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["cc"] != DBNull.Value)
						opatient_cc.cc = Convert.ToString(dataReader["cc"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_cc.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_cc.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_cc.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_cc.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_cc;
		}
		public int Addpatient_cc(PatientCC opatient_cc)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_cc.admission_id);
				arParams[1] = new SqlParameter("@cc", opatient_cc.cc);
                arParams[2] = new SqlParameter("@patientCCID", opatient_cc.patient_cc_id);
				arParams[3] = new SqlParameter("@record_created_by", opatient_cc.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_cc.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "PatientCCAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_cc(PatientCC opatient_cc)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_cc.admission_id);
				arParams[1] = new SqlParameter("@cc", opatient_cc.cc);
				arParams[2] = new SqlParameter("@record_created_by", opatient_cc.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", opatient_cc.record_modified_by);
				arParams[4] = new SqlParameter("@patient_cc_id", opatient_cc.patient_cc_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_ccUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_cc(PatientCC opatient_cc)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_cc_id", opatient_cc.patient_cc_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_ccDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_cc(int patient_cc_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_cc_id", patient_cc_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_ccDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
