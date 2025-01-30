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
	public class PatientDAL
	{
		public PatientDAL()
		{
		}
		public List<Patient> GetpatientsList()
		{
			SqlConnection conn = null;
			List<Patient> lstpatients = new List<Patient>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patientGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Patient opatient = new Patient();
					opatient.patient_id = Convert.ToInt32(dataReader["patient_id"]);

					if(dataReader["patient_type"] != DBNull.Value)
						opatient.patient_type = Convert.ToString(dataReader["patient_type"]);

					if(dataReader["patient_code"] != DBNull.Value)
						opatient.patient_code = Convert.ToString(dataReader["patient_code"]);

					if(dataReader["patient_name"] != DBNull.Value)
						opatient.patient_name = Convert.ToString(dataReader["patient_name"]);

					if(dataReader["guardian_name"] != DBNull.Value)
						opatient.guardian_name = Convert.ToString(dataReader["guardian_name"]);

					if(dataReader["guardian_relation_id"] != DBNull.Value)
						opatient.guardian_relation_id = Convert.ToInt32(dataReader["guardian_relation_id"]);

					if(dataReader["gender_id"] != DBNull.Value)
						opatient.gender_id = Convert.ToInt32(dataReader["gender_id"]);

					if(dataReader["address"] != DBNull.Value)
						opatient.address = Convert.ToString(dataReader["address"]);

					if(dataReader["city_id"] != DBNull.Value)
						opatient.city_id = Convert.ToInt32(dataReader["city_id"]);

					if(dataReader["c_phone"] != DBNull.Value)
						opatient.c_phone = Convert.ToString(dataReader["c_phone"]);

					if(dataReader["dob"] != DBNull.Value)
						opatient.dob = Convert.ToDateTime(dataReader["dob"]);

					if(dataReader["occupation_id"] != DBNull.Value)
						opatient.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

					if(dataReader["nationality_id"] != DBNull.Value)
						opatient.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

					if(dataReader["religion_id"] != DBNull.Value)
						opatient.religion_id = Convert.ToInt32(dataReader["religion_id"]);

					if(dataReader["patient_status_id"] != DBNull.Value)
						opatient.patient_status_id = Convert.ToInt32(dataReader["patient_status_id"]);

					if(dataReader["patient_condition_id"] != DBNull.Value)
						opatient.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatients.Add(opatient);
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
			return lstpatients;
		}

        public DataSet GetPtientSearch(string searchID, string searchIDValue, string procName, int isAdmittedOnly)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter(searchID, searchIDValue);
                arParams[1] = new SqlParameter("@isAdmittedOnly", isAdmittedOnly);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, procName, arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet PatientInfofornurse(string floor)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@floor", floor);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PatientInfofornurse", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet PatientInfofordoctor(int AdmissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id ", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PatientInfofordoctor", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetRefferedDoctorByAdmissionCode( string admissionCode)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_code", admissionCode);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetRefferedDoctorByAdmissionCode", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet OutdoorPatientInfoGet(string patientCode)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_code", patientCode);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OutdoorPatientInfoGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet Getpatients()
		{
			try
			{
              return DbHelper.GetDataSet(CommandType.StoredProcedure, "patientGetAll");
               
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public Patient IPDpatientGet(string patient_code)
        {
            SqlConnection conn = null;
            Patient opatient = new Patient();
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_code", patient_code);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "IPDpatientGet", arParams, ref conn);
                while (dataReader.Read())
                {

                    if (dataReader["patient_code"] != DBNull.Value)
                        opatient.patient_code = Convert.ToString(dataReader["patient_code"]);

                    if (dataReader["patient_name"] != DBNull.Value)
                        opatient.patient_name = Convert.ToString(dataReader["patient_name"]);

                    if (dataReader["guardian_name"] != DBNull.Value)
                        opatient.guardian_name = Convert.ToString(dataReader["guardian_name"]);

                    if (dataReader["guardian_relation_id"] != DBNull.Value)
                        opatient.guardian_relation_id = Convert.ToInt32(dataReader["guardian_relation_id"]);

                    if (dataReader["gender_id"] != DBNull.Value)
                        opatient.gender_id = Convert.ToInt32(dataReader["gender_id"]);

                    if (dataReader["address"] != DBNull.Value)
                        opatient.address = Convert.ToString(dataReader["address"]);

                    if (dataReader["city_id"] != DBNull.Value)
                        opatient.city_id = Convert.ToInt32(dataReader["city_id"]);

                    if (dataReader["c_phone"] != DBNull.Value)
                        opatient.c_phone = Convert.ToString(dataReader["c_phone"]);

                    if (dataReader["dob"] != DBNull.Value)
                        opatient.dob = Convert.ToDateTime(dataReader["dob"]);

                    if (dataReader["occupation_id"] != DBNull.Value)
                        opatient.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

                    if (dataReader["nationality_id"] != DBNull.Value)
                        opatient.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

                    if (dataReader["religion_id"] != DBNull.Value)
                        opatient.religion_id = Convert.ToInt32(dataReader["religion_id"]);

                    if (dataReader["patient_status_id"] != DBNull.Value)
                        opatient.patient_status_id = Convert.ToInt32(dataReader["patient_status_id"]);

                    if (dataReader["patient_condition_id"] != DBNull.Value)
                        opatient.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

                    if (dataReader["record_created_date"] != DBNull.Value)
                        opatient.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

                    if (dataReader["record_created_by"] != DBNull.Value)
                        opatient.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    if (dataReader["record_modified_date"] != DBNull.Value)
                        opatient.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

                    if (dataReader["record_modified_by"] != DBNull.Value)
                        opatient.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return opatient;
        }
        public Patient patientInfo(string patientCode)
        {
            SqlConnection conn = null;
            Patient opatient = new Patient();
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_code", patientCode);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patientGet", arParams, ref conn);
                while (dataReader.Read())
                {
                    if (dataReader["patient_code"] != DBNull.Value)
                        opatient.patient_code = Convert.ToString(dataReader["patient_code"]);

                    if (dataReader["patient_id"] != DBNull.Value)
                        opatient.patient_id = Convert.ToInt32(dataReader["patient_id"]);

                    if (dataReader["patient_name"] != DBNull.Value)
                        opatient.patient_name = Convert.ToString(dataReader["patient_name"]);

                    if (dataReader["gender_id"] != DBNull.Value)
                        opatient.gender_id = Convert.ToInt32(dataReader["gender_id"]);

                    if (dataReader["occupation_id"] != DBNull.Value)
                        opatient.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

                    if (dataReader["address"] != DBNull.Value)
                        opatient.address = Convert.ToString(dataReader["address"]);

                    if (dataReader["city_id"] != DBNull.Value)
                        opatient.city_id = Convert.ToInt32(dataReader["city_id"]);

                    if (dataReader["c_phone"] != DBNull.Value)
                        opatient.c_phone = Convert.ToString(dataReader["c_phone"]);

                    if (dataReader["dob"] != DBNull.Value)
                        opatient.dob = Convert.ToDateTime(dataReader["dob"]);

                    if (dataReader["nationality_id"] != DBNull.Value)
                        opatient.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

                    if (dataReader["religion_id"] != DBNull.Value)
                        opatient.religion_id = Convert.ToInt32(dataReader["religion_id"]);

                    if (dataReader["patient_condition_id"] != DBNull.Value)
                        opatient.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

                    if (dataReader["record_created_date"] != DBNull.Value)
                        opatient.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

                    if (dataReader["record_created_by"] != DBNull.Value)
                        opatient.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    if (dataReader["record_modified_date"] != DBNull.Value)
                        opatient.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

                    if (dataReader["record_modified_by"] != DBNull.Value)
                        opatient.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return opatient;
        }
		public Patient Getpatient(string patient_code)
		{
			SqlConnection conn = null;
			Patient opatient = new Patient();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_code", patient_code);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patientGet", arParams, ref conn);
				while (dataReader.Read())
				{

                    if (dataReader["patient_code"] != DBNull.Value)
                        opatient.patient_code = Convert.ToString(dataReader["patient_code"]);
                    
                    if(dataReader["patient_name"] != DBNull.Value)
						opatient.patient_name = Convert.ToString(dataReader["patient_name"]);

					if(dataReader["guardian_name"] != DBNull.Value)
						opatient.guardian_name = Convert.ToString(dataReader["guardian_name"]);

					if(dataReader["guardian_relation_id"] != DBNull.Value)
						opatient.guardian_relation_id = Convert.ToInt32(dataReader["guardian_relation_id"]);

					if(dataReader["gender_id"] != DBNull.Value)
						opatient.gender_id = Convert.ToInt32(dataReader["gender_id"]);

					if(dataReader["address"] != DBNull.Value)
						opatient.address = Convert.ToString(dataReader["address"]);

					if(dataReader["city_id"] != DBNull.Value)
						opatient.city_id = Convert.ToInt32(dataReader["city_id"]);

					if(dataReader["c_phone"] != DBNull.Value)
						opatient.c_phone = Convert.ToString(dataReader["c_phone"]);

					if(dataReader["dob"] != DBNull.Value)
						opatient.dob = Convert.ToDateTime(dataReader["dob"]);

					if(dataReader["occupation_id"] != DBNull.Value)
						opatient.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

					if(dataReader["nationality_id"] != DBNull.Value)
						opatient.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

					if(dataReader["religion_id"] != DBNull.Value)
						opatient.religion_id = Convert.ToInt32(dataReader["religion_id"]);

					if(dataReader["patient_status_id"] != DBNull.Value)
						opatient.patient_status_id = Convert.ToInt32(dataReader["patient_status_id"]);

					if(dataReader["patient_condition_id"] != DBNull.Value)
						opatient.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient;
		}
        public int AddPatientAdmission(Patient patient, AdmissionBO admission, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID, out int paymentID,int Flag)
		{
			SqlParameter[] arParams = new SqlParameter[27];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@patient_type", patient.patient_type);
                arParams[1] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[2] = new SqlParameter("@guardian_name", patient.guardian_name);
                arParams[3] = new SqlParameter("@guardian_relation", GRID);
                arParams[4] = new SqlParameter("@gender", GenderID);
                arParams[5] = new SqlParameter("@address", patient.address);
                arParams[6] = new SqlParameter("@city", CityID);
                arParams[7] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[8] = new SqlParameter("@dob", patient.dob);
                arParams[9] = new SqlParameter("@occupation", OccupID);
                arParams[10] = new SqlParameter("@nationality", NationID);
                arParams[11] = new SqlParameter("@religion", RelID);
                arParams[12] = new SqlParameter("@patient_condition", PConID);
                arParams[13] = new SqlParameter("@admission_date", admission.admission_date);
                arParams[14] = new SqlParameter("@cabin_id", admission.cabin_id);
                arParams[15] = new SqlParameter("@deposit", admission.deposit);
                arParams[16] = new SqlParameter("@remarks", admission.remarks);
                arParams[17] = new SqlParameter("@is_bill_clear", admission.is_bill_clear);
                arParams[18] = new SqlParameter("@is_discharged", admission.is_discharged);
                arParams[19] = new SqlParameter("@is_cc_written", admission.is_cc_written);
                arParams[20] = new SqlParameter("@is_history_written", admission.is_history_written);
                arParams[21] = new SqlParameter("@is_first_reqular_checkup_done", admission.is_first_reqular_checkup_done);
                arParams[22] = new SqlParameter("@record_created_by", admission.record_created_by);
                arParams[23] = new SqlParameter("@record_modified_by", admission.record_modified_by);
                arParams[24] = new SqlParameter("@admission_id", admission.admission_id);
                arParams[25] = new SqlParameter("@payment_id", SqlDbType.Int, 11);
                arParams[26] = new SqlParameter("@flag", Flag);
                arParams[24].Direction = ParameterDirection.Output;
                arParams[25].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "PatientAdmissionAdd", arParams);
                result = Convert.ToInt32(arParams[24].Value.ToString());
                paymentID = Convert.ToInt32(arParams[25].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally {

                DbHelper.CloseConnection(conn);
            }
            return result;
		}

        public DataSet GetPatientinfo(int patientCode, int isadmitted)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@patient_code ", patientCode);
                arParams[1] = new SqlParameter("@isAdmittedOnly", isadmitted);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPatientinfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet getallpayment(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@AdmissionID ", admissionID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getallpayment", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int Updatepatient(Patient patient, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID)
		{

			SqlParameter[] arParams = new SqlParameter[17];
			try
			{
				arParams[0] = new SqlParameter("@patient_type", patient.patient_type);
				arParams[1] = new SqlParameter("@patient_code", patient.patient_code);
				arParams[2] = new SqlParameter("@patient_name", patient.patient_name);
				arParams[3] = new SqlParameter("@guardian_name", patient.guardian_name);
                arParams[4] = new SqlParameter("@guardian_relation", GRID);
                arParams[5] = new SqlParameter("@gender", GenderID);
				arParams[6] = new SqlParameter("@address", patient.address);
                arParams[7] = new SqlParameter("@city", CityID);
				arParams[8] = new SqlParameter("@c_phone", patient.c_phone);
				arParams[9] = new SqlParameter("@dob", patient.dob);
                arParams[10] = new SqlParameter("@occupation", OccupID);
                arParams[11] = new SqlParameter("@nationality", NationID);
                arParams[12] = new SqlParameter("@religion", RelID);
                arParams[13] = new SqlParameter("@patient_condition", PConID);
				arParams[14] = new SqlParameter("@record_created_by", patient.record_created_by);
				arParams[15] = new SqlParameter("@record_modified_by", patient.record_modified_by);
				arParams[16] = new SqlParameter("@patient_id", patient.patient_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patientUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int UpdatePatientSearch(Patient patient)
        {

            SqlParameter[] arParams = new SqlParameter[14];
            try
            {
                //arParams[0] = new SqlParameter("@patient_type", patient.patient_type);
                //arParams[1] = new SqlParameter("@patient_code", patient.patient_code);
                arParams[0] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[1] = new SqlParameter("@guardian_name", patient.guardian_name);
                arParams[2] = new SqlParameter("@guardian_relation_id", patient.guardian_relation_id);
                arParams[3] = new SqlParameter("@gender_id", patient.gender_id);
                arParams[4] = new SqlParameter("@address", patient.address);
                arParams[5] = new SqlParameter("@city_id", patient.city_id);
                arParams[6] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[7] = new SqlParameter("@dob", patient.dob);
                arParams[8] = new SqlParameter("@occupation_id", patient.occupation_id);
                arParams[9] = new SqlParameter("@nationality_id", patient.nationality_id);
                arParams[10] = new SqlParameter("@religion_id ", patient.religion_id);
                //arParams[11] = new SqlParameter("@patient_status_id", patient.patient_status_id);
                arParams[11] = new SqlParameter("@patient_condition_id", patient.patient_condition_id);
                arParams[12] = new SqlParameter("@record_modified_by", patient.record_modified_by);
                arParams[13] = new SqlParameter("@patient_code", patient.patient_code);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdatePatientSearch", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient(Patient opatient)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_id", opatient.patient_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patientDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient(int patient_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_id", patient_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patientDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int PatientAddforOPD(Patient patient)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@patient_code", patient.patient_code);
                arParams[1] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[2] = new SqlParameter("@gender_id", patient.gender_id);
                arParams[3] = new SqlParameter("@address", patient.address);
                arParams[4] = new SqlParameter("@city_id", patient.city_id);
                arParams[5] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[6] = new SqlParameter("@dob", patient.dob);
                arParams[7] = new SqlParameter("@record_created_by", patient.record_created_by);
                arParams[8] = new SqlParameter("@record_modified_by", patient.record_modified_by);
                arParams[9] = new SqlParameter("@patient_id", patient.patient_id);
                arParams[9].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "PatientAddforOPD", arParams);
                result = Convert.ToInt32(arParams[9].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }
	}
}
