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
	public class PatientRefferedDoctorsDAL
	{
		public PatientRefferedDoctorsDAL()
		{
		}
		public List<PatientRefferedDoctors> Getpatient_reffered_doctorssList()
		{
			SqlConnection conn = null;
			List<PatientRefferedDoctors> lstpatient_reffered_doctorss = new List<PatientRefferedDoctors>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_reffered_doctorsGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientRefferedDoctors opatient_reffered_doctors = new PatientRefferedDoctors();
					opatient_reffered_doctors.patient_reffered_doctors_id = Convert.ToInt32(dataReader["patient_reffered_doctors_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_reffered_doctors.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						opatient_reffered_doctors.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_reffered_doctors.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_reffered_doctors.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_reffered_doctors.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_reffered_doctors.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_reffered_doctorss.Add(opatient_reffered_doctors);
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
			return lstpatient_reffered_doctorss;
		}
		public DataSet Getpatient_reffered_doctorss()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_reffered_doctorsGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PatientRefferedDoctors Getpatient_reffered_doctors(int patient_reffered_doctors_id)
		{
			SqlConnection conn = null;
			PatientRefferedDoctors opatient_reffered_doctors = new PatientRefferedDoctors();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_reffered_doctors_id", patient_reffered_doctors_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_reffered_doctorsGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_reffered_doctors.patient_reffered_doctors_id = Convert.ToInt32(dataReader["patient_reffered_doctors_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_reffered_doctors.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						opatient_reffered_doctors.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_reffered_doctors.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_reffered_doctors.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_reffered_doctors.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_reffered_doctors.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_reffered_doctors;
		}
		public int Addpatient_reffered_doctors(PatientRefferedDoctors opatient_reffered_doctors)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_reffered_doctors.admission_id);
				arParams[1] = new SqlParameter("@reffered_doctors_id", opatient_reffered_doctors.reffered_doctors_id);
				arParams[2] = new SqlParameter("@record_created_by", opatient_reffered_doctors.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", opatient_reffered_doctors.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_reffered_doctorsAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Addpatient_reffered_doctors_icu(PatientRefferedDoctors opatient_reffered_doctors)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opatient_reffered_doctors.admission_id);
                arParams[1] = new SqlParameter("@reffered_doctors_id", opatient_reffered_doctors.reffered_doctors_id);
                arParams[2] = new SqlParameter("@record_created_by", opatient_reffered_doctors.record_created_by);
                arParams[3] = new SqlParameter("@record_modified_by", opatient_reffered_doctors.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_reffered_doctorsAdd_icu", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int patientreferredDocupdate(PatientRefferedDoctors opatient_reffered_doctors)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@patient_reffered_doctors_id", opatient_reffered_doctors.patient_reffered_doctors_id);
                arParams[1] = new SqlParameter("@record_modified_by", opatient_reffered_doctors.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patientreferredDocupdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addrefferedDoc(List<PatientRefferedDoctors> lstPatientRefferedDoctors)///////////////////khukuhfioshdfih
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[3];
            int result = 0;

            try
            {
                foreach (PatientRefferedDoctors element in lstPatientRefferedDoctors)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@reffered_doctors_id", element.reffered_doctors_id);
                    arParams[2] = new SqlParameter("@record_created_by", element.record_created_by);


                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "addrefferedDoc", arParams);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int ReffDoctorUpdate(PatientRefferedDoctors patientRefferedDoctors)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", patientRefferedDoctors.admission_id);
                arParams[1] = new SqlParameter("@reffered_doctors_id", patientRefferedDoctors.reffered_doctors_id);
                arParams[2] = new SqlParameter("@record_modified_by", patientRefferedDoctors.record_modified_by);
                arParams[3] = new SqlParameter("@patient_reffered_doctors_id", patientRefferedDoctors.patient_reffered_doctors_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ReffDoctorUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ReffDoctorAdd(PatientRefferedDoctors patientRefferedDoctors)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", patientRefferedDoctors.admission_id);
                arParams[1] = new SqlParameter("@reffered_doctors_id", patientRefferedDoctors.reffered_doctors_id);
                arParams[2] = new SqlParameter("@record_created_by", patientRefferedDoctors.record_created_by);
                
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ReffDoctorAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Updatepatient_reffered_doctors(PatientRefferedDoctors opatient_reffered_doctors)
		{

			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_reffered_doctors.admission_id);
				arParams[1] = new SqlParameter("@reffered_doctors_id", opatient_reffered_doctors.reffered_doctors_id);
				arParams[2] = new SqlParameter("@record_created_by", opatient_reffered_doctors.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_reffered_doctors.record_modified_by);
				arParams[5] = new SqlParameter("@patient_reffered_doctors_id", opatient_reffered_doctors.patient_reffered_doctors_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_reffered_doctorsUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RefDocDelte(int AdmissionID)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", AdmissionID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "RefDocDelte", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient_reffered_doctors(PatientRefferedDoctors opatient_reffered_doctors)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_reffered_doctors_id", opatient_reffered_doctors.patient_reffered_doctors_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_reffered_doctorsDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_reffered_doctors(int patient_reffered_doctors_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_reffered_doctors_id", patient_reffered_doctors_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_reffered_doctorsDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
