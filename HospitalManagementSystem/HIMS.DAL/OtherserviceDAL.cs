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
    public class OtherserviceDAL
    {
        public OtherserviceDAL()
		{
		}
        // ----------------------------------------patientADD----------------------------------start---------------------------------------
        public int patientserviceADD(Patient patient, OtherserviceBO otherserviceBO, List<OtherServiceListBO> lstOtherServiceListBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int patientserviceID = 0;

            try
            {
                int patientID = patientADD(trans, patient);
                patientserviceID = patientotherservicesADD(trans, otherserviceBO, patientID);
                other_service_Add(trans, patientserviceID, lstOtherServiceListBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                patientserviceID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return patientserviceID;
        }

        public int patientADD(SqlTransaction trans, Patient patient)//sami24Oct
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[13];
            try
            {
                arParams[0] = new SqlParameter("@patient_type", patient.patient_type);
                arParams[1] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[2] = new SqlParameter("@gender_id", patient.gender_id);
                arParams[3] = new SqlParameter("@address", patient.address);
                arParams[4] = new SqlParameter("@city_id", patient.city_id);
                arParams[5] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[6] = new SqlParameter("@dob", patient.dob);
                arParams[7] = new SqlParameter("@occupation_id", patient.occupation_id);
                arParams[8] = new SqlParameter("@nationality_id", patient.nationality_id);
                arParams[9] = new SqlParameter("@religion_id", patient.religion_id);
                arParams[10] = new SqlParameter("@patient_condition_id", patient.patient_condition_id);
                arParams[11] = new SqlParameter("@record_created_by", patient.record_created_by);
                arParams[12] = new SqlParameter("@patient_id", patient.patient_id);
                //arParams[12] = new SqlParameter("@patient_id", SqlDbType.Int, 4);
                arParams[12].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patientAdd", arParams);
                result = Convert.ToInt32(arParams[12].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int patientotherservicesADD(SqlTransaction trans, OtherserviceBO otherserviceBO, int PatientID)//sami24Oct
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@patient_id", PatientID);
                arParams[1] = new SqlParameter("@record_created_by", otherserviceBO.record_created_by);
                arParams[2] = new SqlParameter("@other_service_id", otherserviceBO.other_service_id);
                arParams[3] = new SqlParameter("@total", otherserviceBO.total);
                arParams[4] = new SqlParameter("@t_vat", otherserviceBO.t_vat);
                arParams[2].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patientotherservicesADD", arParams);
                result = Convert.ToInt32(arParams[2].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void other_service_Add(SqlTransaction trans, int patientserviceID, List<OtherServiceListBO> lstConsultation)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                foreach (OtherServiceListBO element in lstConsultation)
                {
                    arParams[0] = new SqlParameter("@other_service_id", patientserviceID);
                    arParams[1] = new SqlParameter("@other_item_id", element.other_item_id);
                    arParams[2] = new SqlParameter("@charge", element.charge);
                    arParams[3] = new SqlParameter("@record_created_by", element.record_created_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "other_service_Add", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // ----------------------------------------patientUpdate----------------------------------------------------------------------

        public int patientupdateADD(Patient patient, OtherserviceBO otherserviceBO, List<OtherServiceListBO> lstOtherServiceListBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int patientserviceID = 0;

            try
            {
                int patientID = patientUpdate(trans, patient);
                patientserviceID = patientotherservicesADD(trans, otherserviceBO, patientID);
                other_service_Add(trans, patientserviceID, lstOtherServiceListBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                patientserviceID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return patientserviceID;
        }

        public int patientUpdate(SqlTransaction trans, Patient patient)//sami24Oct
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[13];
            try
            {
                arParams[0] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[1] = new SqlParameter("@gender_id", patient.gender_id);
                arParams[2] = new SqlParameter("@address", patient.address);
                arParams[3] = new SqlParameter("@city_id", patient.city_id);
                arParams[4] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[5] = new SqlParameter("@dob", patient.dob);
                arParams[6] = new SqlParameter("@occupation_id", patient.occupation_id);
                arParams[7] = new SqlParameter("@nationality_id", patient.nationality_id);
                arParams[8] = new SqlParameter("@religion_id", patient.religion_id);
                arParams[9] = new SqlParameter("@patient_condition_id", patient.patient_condition_id);
                arParams[10] = new SqlParameter("@record_modified_by", patient.record_modified_by);
                arParams[11] = new SqlParameter("@patient_code", patient.patient_code);
                arParams[12] = new SqlParameter("@patient_id", patient.patient_id);
                //arParams[12] = new SqlParameter("@patient_id", SqlDbType.Int, 4);
                arParams[12].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patientUpdate", arParams);
                result = Convert.ToInt32(arParams[12].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        //----------------------------------------------------------------

        public DataSet getservices(int patientID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PatientID", patientID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getservices", arParams);
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
