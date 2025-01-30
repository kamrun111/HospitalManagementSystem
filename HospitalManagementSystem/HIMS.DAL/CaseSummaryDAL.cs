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
    public class CaseSummaryDAL
    {
        public CaseSummaryDAL()
		{
		}
        public int AddCaseSummary(CaseSummary caseSummary, AdmissionBO admission)
        {
            SqlParameter[] arParams = new SqlParameter[14];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@chiefcomplain", caseSummary.chiefcomplain);
                arParams[1] = new SqlParameter("@present_status", caseSummary.present_status);
                arParams[2] = new SqlParameter("@medication ", caseSummary.medication);
                arParams[3] = new SqlParameter("@advice", caseSummary.advice);
                arParams[4] = new SqlParameter("@treatment", caseSummary.treatment);
                arParams[5] = new SqlParameter("@treatment_procedure", caseSummary.treatment_procedure);
                arParams[6] = new SqlParameter("@record_created_by", caseSummary.record_created_by);
                arParams[7] = new SqlParameter("@record_modified_by", caseSummary.record_modified_by);
                arParams[8] = new SqlParameter("@CaseSummaryID ", caseSummary.CaseSummaryID);
                arParams[9] = new SqlParameter("@hospital_medication ", caseSummary.hospital_medication);
                arParams[10] = new SqlParameter("@admission_id", admission.admission_id);
                arParams[11] = new SqlParameter("@duty_doctor_name", caseSummary.duty_doctor_name);
                arParams[12] = new SqlParameter("@dis_type", caseSummary.dis_type);
                arParams[13] = new SqlParameter("@dis_type_remarks", caseSummary.dis_type_remarks);

                arParams[8].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "CaseSummaryAdd", arParams);
                result = Convert.ToInt32(arParams[8].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            finally
            {

                DbHelper.CloseConnection(conn);
            }
            return result;
        }

        public int AddCaseSummaryICU(CaseSummary caseSummary, AdmissionBO admission)
        {
            SqlParameter[] arParams = new SqlParameter[14];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@chiefcomplain", caseSummary.chiefcomplain);
                arParams[1] = new SqlParameter("@present_status", caseSummary.present_status);
                arParams[2] = new SqlParameter("@medication ", caseSummary.medication);
                arParams[3] = new SqlParameter("@advice", caseSummary.advice);
                arParams[4] = new SqlParameter("@treatment", caseSummary.treatment);
                arParams[5] = new SqlParameter("@treatment_procedure", caseSummary.treatment_procedure);
                arParams[6] = new SqlParameter("@record_created_by", caseSummary.record_created_by);
                arParams[7] = new SqlParameter("@record_modified_by", caseSummary.record_modified_by);
                arParams[8] = new SqlParameter("@CaseSummaryID ", caseSummary.CaseSummaryID);
                arParams[9] = new SqlParameter("@hospital_medication ", caseSummary.hospital_medication);
                arParams[10] = new SqlParameter("@admission_id", admission.admission_id);
                arParams[11] = new SqlParameter("@duty_doctor_name", caseSummary.duty_doctor_name);
                arParams[12] = new SqlParameter("@dis_type", caseSummary.dis_type);
                arParams[13] = new SqlParameter("@dis_type_remarks", caseSummary.dis_type_remarks);

                arParams[8].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "CaseSummaryAddICU", arParams);
                result = Convert.ToInt32(arParams[8].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            finally
            {

                DbHelper.CloseConnection(conn);
            }
            return result;
        }


        public int CaseSummaryUpdate(CaseSummary caseSummary)
        {

            SqlParameter[] arParams = new SqlParameter[12];
            try
            {
                arParams[0] = new SqlParameter("@chiefcomplain", caseSummary.chiefcomplain);
                arParams[1] = new SqlParameter("@present_status", caseSummary.present_status);
                arParams[2] = new SqlParameter("@medication ", caseSummary.medication);
                arParams[3] = new SqlParameter("@advice", caseSummary.advice);
                arParams[4] = new SqlParameter("@treatment", caseSummary.treatment);
                arParams[5] = new SqlParameter("@treatment_procedure", caseSummary.treatment_procedure);
                arParams[6] = new SqlParameter("@hospital_medication ", caseSummary.hospital_medication);
                arParams[7] = new SqlParameter("@record_modified_by", caseSummary.record_modified_by);
                arParams[8] = new SqlParameter("@CaseSummaryID ", caseSummary.CaseSummaryID);
                arParams[9] = new SqlParameter("@duty_doctor_name", caseSummary.duty_doctor_name);
                arParams[10] = new SqlParameter("@dis_type", caseSummary.dis_type);
                arParams[11] = new SqlParameter("@dis_type_remarks", caseSummary.dis_type_remarks);
              
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CaseSummaryUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CaseSummaryUpdateICU(CaseSummary caseSummary)
        {

            SqlParameter[] arParams = new SqlParameter[12];
            try
            {
                arParams[0] = new SqlParameter("@chiefcomplain", caseSummary.chiefcomplain);
                arParams[1] = new SqlParameter("@present_status", caseSummary.present_status);
                arParams[2] = new SqlParameter("@medication ", caseSummary.medication);
                arParams[3] = new SqlParameter("@advice", caseSummary.advice);
                arParams[4] = new SqlParameter("@treatment", caseSummary.treatment);
                arParams[5] = new SqlParameter("@treatment_procedure", caseSummary.treatment_procedure);
                arParams[6] = new SqlParameter("@hospital_medication ", caseSummary.hospital_medication);
                arParams[7] = new SqlParameter("@record_modified_by", caseSummary.record_modified_by);
                arParams[8] = new SqlParameter("@CaseSummaryID ", caseSummary.CaseSummaryID);
                arParams[9] = new SqlParameter("@duty_doctor_name", caseSummary.duty_doctor_name);
                arParams[10] = new SqlParameter("@dis_type", caseSummary.dis_type);
                arParams[11] = new SqlParameter("@dis_type_remarks", caseSummary.dis_type_remarks);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CaseSummaryUpdateICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
