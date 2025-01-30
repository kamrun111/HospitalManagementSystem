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
    public class DeathCertificateDAL
    {
        public DeathCertificateDAL()
        {
        }
        public int DeathCertificateAdd(DeathCertificateBO deathCertificateBO)
        {
            SqlParameter[] arParams = new SqlParameter[18];
            try
            {
                arParams[0] = new SqlParameter("@admission_id ", deathCertificateBO.admission_id);
                arParams[1] = new SqlParameter("@patient_id", deathCertificateBO.patient_id);
                arParams[2] = new SqlParameter("@patient_name", deathCertificateBO.patient_name);
                arParams[3] = new SqlParameter("@reg_no", deathCertificateBO.reg_no);
                arParams[4] = new SqlParameter("@age", deathCertificateBO.age);
                arParams[5] = new SqlParameter("@gender", deathCertificateBO.gender);
                arParams[6] = new SqlParameter("@gurdian_name", deathCertificateBO.gurdian_name);
                arParams[7] = new SqlParameter("@address", deathCertificateBO.address);
                arParams[8] = new SqlParameter("@admission_date", deathCertificateBO.admission_date);
                arParams[9] = new SqlParameter("@consultant", deathCertificateBO.consultant);
                arParams[10] = new SqlParameter("@clinical_diagnosis", deathCertificateBO.clinical_diagnosis);
                arParams[11] = new SqlParameter("@cause_of_death", deathCertificateBO.cause_of_death);
                arParams[12] = new SqlParameter("@death_date", deathCertificateBO.death_date);
                arParams[13] = new SqlParameter("@doctor_attending", deathCertificateBO.doctor_attending);
                arParams[14] = new SqlParameter("@report_created_doctor", deathCertificateBO.report_created_doctor);
                arParams[15] = new SqlParameter("@record_created_by", deathCertificateBO.record_created_by);
                arParams[16] = new SqlParameter("@relation", deathCertificateBO.relation);
                arParams[17] = new SqlParameter("@death_certificate_id", deathCertificateBO.death_certificate_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DeathCertificateAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeathCertificateUpdate(DeathCertificateBO deathCertificateBO)
        {

            SqlParameter[] arParams = new SqlParameter[18];
            try
            {
                arParams[0] = new SqlParameter("@admission_id ", deathCertificateBO.admission_id);
                arParams[1] = new SqlParameter("@patient_id", deathCertificateBO.patient_id);
                arParams[2] = new SqlParameter("@patient_name", deathCertificateBO.patient_name);
                arParams[3] = new SqlParameter("@reg_no", deathCertificateBO.reg_no);
                arParams[4] = new SqlParameter("@age", deathCertificateBO.age);
                arParams[5] = new SqlParameter("@gender", deathCertificateBO.gender);
                arParams[6] = new SqlParameter("@gurdian_name", deathCertificateBO.gurdian_name);
                arParams[7] = new SqlParameter("@address", deathCertificateBO.address);
                arParams[8] = new SqlParameter("@admission_date", deathCertificateBO.admission_date);
                arParams[9] = new SqlParameter("@consultant", deathCertificateBO.consultant);
                arParams[10] = new SqlParameter("@clinical_diagnosis", deathCertificateBO.clinical_diagnosis);
                arParams[11] = new SqlParameter("@cause_of_death", deathCertificateBO.cause_of_death);
                arParams[12] = new SqlParameter("@death_date", deathCertificateBO.death_date);
                arParams[13] = new SqlParameter("@doctor_attending", deathCertificateBO.doctor_attending);
                arParams[14] = new SqlParameter("@report_created_doctor", deathCertificateBO.report_created_doctor);
                arParams[15] = new SqlParameter("@record_modified_by", deathCertificateBO.record_modified_by);
                arParams[16] = new SqlParameter("@relation", deathCertificateBO.relation);
                arParams[17] = new SqlParameter("@death_certificate_id", deathCertificateBO.death_certificate_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DeathCertificateUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
