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
    public class BirthCertificateDAL
    {
        public BirthCertificateDAL()
        {
        }
        public int BirthCertificateAdd(BirthCertificateBO birthCertificateBO)
        {
            SqlParameter[] arParams = new SqlParameter[16];
            try
            {
                arParams[0] = new SqlParameter("@admission_id ", birthCertificateBO.admission_id);
                arParams[1] = new SqlParameter("@patient_id", birthCertificateBO.patient_id);
                arParams[2] = new SqlParameter("@mother_name", birthCertificateBO.mother_name);
                arParams[3] = new SqlParameter("@reg_no", birthCertificateBO.reg_no);
                arParams[4] = new SqlParameter("@weight", birthCertificateBO.weight);
                arParams[5] = new SqlParameter("@gender", birthCertificateBO.gender);
                arParams[6] = new SqlParameter("@father_name", birthCertificateBO.father_name);
                arParams[7] = new SqlParameter("@address", birthCertificateBO.address);
                arParams[8] = new SqlParameter("@baby_name", birthCertificateBO.baby_name);
                arParams[9] = new SqlParameter("@consultant", birthCertificateBO.consultant);
                arParams[10] = new SqlParameter("@identification_mark", birthCertificateBO.identification_mark);
                arParams[11] = new SqlParameter("@birth_place", birthCertificateBO.birth_place);
                arParams[12] = new SqlParameter("@delivery_date", birthCertificateBO.delivery_date);
                arParams[13] = new SqlParameter("@religion", birthCertificateBO.religion);

                arParams[14] = new SqlParameter("@record_created_by", birthCertificateBO.record_created_by);
                arParams[15] = new SqlParameter("@birth_certificate_id", birthCertificateBO.birth_certificate_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BirthCertificateAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BirthCertificateUpdate(BirthCertificateBO birthCertificateBO)
        {

            SqlParameter[] arParams = new SqlParameter[16];
            try
            {
                arParams[0] = new SqlParameter("@admission_id ", birthCertificateBO.admission_id);
                arParams[1] = new SqlParameter("@patient_id", birthCertificateBO.patient_id);
                arParams[2] = new SqlParameter("@mother_name", birthCertificateBO.mother_name);
                arParams[3] = new SqlParameter("@reg_no", birthCertificateBO.reg_no);
                arParams[4] = new SqlParameter("@weight", birthCertificateBO.weight);
                arParams[5] = new SqlParameter("@gender", birthCertificateBO.gender);
                arParams[6] = new SqlParameter("@father_name", birthCertificateBO.father_name);
                arParams[7] = new SqlParameter("@address", birthCertificateBO.address);
                arParams[8] = new SqlParameter("@baby_name", birthCertificateBO.baby_name);
                arParams[9] = new SqlParameter("@consultant", birthCertificateBO.consultant);
                arParams[10] = new SqlParameter("@identification_mark", birthCertificateBO.identification_mark);
                arParams[11] = new SqlParameter("@birth_place", birthCertificateBO.birth_place);
                arParams[12] = new SqlParameter("@delivery_date", birthCertificateBO.delivery_date);
                arParams[13] = new SqlParameter("@religion", birthCertificateBO.religion);

                arParams[14] = new SqlParameter("@record_modified_by", birthCertificateBO.record_modified_by);
                arParams[15] = new SqlParameter("@birth_certificate_id", birthCertificateBO.birth_certificate_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BirthCertificateUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
