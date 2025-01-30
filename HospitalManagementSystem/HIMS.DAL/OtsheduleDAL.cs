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
    public class OtsheduleDAL
    {
        public OtsheduleDAL()
        {
        }

        public int OtsheduleADD(OTShedule ootshedule)
        {
            SqlParameter[] arParams = new SqlParameter[11];
            try
            {
                arParams[0] = new SqlParameter("@Room_no", ootshedule.Room_no);
                arParams[1] = new SqlParameter("@patient_name", ootshedule.patient_name);
                arParams[2] = new SqlParameter("@address", ootshedule.address);
                arParams[3] = new SqlParameter("@contact_no", ootshedule.contact_no);
                arParams[4] = new SqlParameter("@reffered_doc_id", ootshedule.reffered_doc_id);
                arParams[5] = new SqlParameter("@operation_id", ootshedule.operation_id);
                arParams[6] = new SqlParameter("@operation_date", ootshedule.operation_date);
                arParams[7] = new SqlParameter("@anaesthesia_id", ootshedule.anaesthesia_id);
                arParams[8] = new SqlParameter("@anaesthesia_nature_id", ootshedule.anaesthesia_nature_id);
                arParams[9] = new SqlParameter("@record_created_by", ootshedule.record_created_by);
                arParams[10] = new SqlParameter("@record_modified_by", ootshedule.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OtsheduleADD", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSurgenOperation()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSurgenOperation");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


        public DataSet GetOT(DateTime date1, DateTime date2)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@From", date1);
                arParams[1] = new SqlParameter("@To",date2);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOT", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        //public List<Patient> GetpatientsList()
        //{
        //    SqlConnection conn = null;
        //    List<Patient> lstpatients = new List<Patient>();
        //    try
        //    {
        //        SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patientGetAll", null, ref conn);
        //        while (dataReader.Read())
        //        {
        //            Patient opatient = new Patient();
        //            opatient.patient_id = Convert.ToInt32(dataReader["patient_id"]);

        //            if (dataReader["patient_type"] != DBNull.Value)
        //                opatient.patient_type = Convert.ToString(dataReader["patient_type"]);

        //            if (dataReader["patient_code"] != DBNull.Value)
        //                opatient.patient_code = Convert.ToString(dataReader["patient_code"]);

        //            if (dataReader["patient_name"] != DBNull.Value)
        //                opatient.patient_name = Convert.ToString(dataReader["patient_name"]);

        //            if (dataReader["guardian_name"] != DBNull.Value)
        //                opatient.guardian_name = Convert.ToString(dataReader["guardian_name"]);

        //            if (dataReader["guardian_relation_id"] != DBNull.Value)
        //                opatient.guardian_relation_id = Convert.ToInt32(dataReader["guardian_relation_id"]);

        //            if (dataReader["gender_id"] != DBNull.Value)
        //                opatient.gender_id = Convert.ToInt32(dataReader["gender_id"]);

        //            if (dataReader["address"] != DBNull.Value)
        //                opatient.address = Convert.ToString(dataReader["address"]);

        //            if (dataReader["city_id"] != DBNull.Value)
        //                opatient.city_id = Convert.ToInt32(dataReader["city_id"]);

        //            if (dataReader["c_phone"] != DBNull.Value)
        //                opatient.c_phone = Convert.ToString(dataReader["c_phone"]);

        //            if (dataReader["dob"] != DBNull.Value)
        //                opatient.dob = Convert.ToDateTime(dataReader["dob"]);

        //            if (dataReader["occupation_id"] != DBNull.Value)
        //                opatient.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

        //            if (dataReader["nationality_id"] != DBNull.Value)
        //                opatient.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

        //            if (dataReader["religion_id"] != DBNull.Value)
        //                opatient.religion_id = Convert.ToInt32(dataReader["religion_id"]);

        //            if (dataReader["patient_status_id"] != DBNull.Value)
        //                opatient.patient_status_id = Convert.ToInt32(dataReader["patient_status_id"]);

        //            if (dataReader["patient_condition_id"] != DBNull.Value)
        //                opatient.patient_condition_id = Convert.ToInt32(dataReader["patient_condition_id"]);

        //            if (dataReader["record_created_date"] != DBNull.Value)
        //                opatient.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

        //            if (dataReader["record_created_by"] != DBNull.Value)
        //                opatient.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

        //            if (dataReader["record_modified_date"] != DBNull.Value)
        //                opatient.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

        //            if (dataReader["record_modified_by"] != DBNull.Value)
        //                opatient.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
        //            lstpatients.Add(opatient);
        //        }
        //        dataReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        DbHelper.CloseConnection(conn);
        //    }
        //    return lstpatients;
        //}

    }
}


