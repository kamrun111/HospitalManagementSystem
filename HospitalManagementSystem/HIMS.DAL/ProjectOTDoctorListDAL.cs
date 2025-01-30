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
    public class ProjectOTDoctorListDAL
    {
        public ProjectOTDoctorListDAL()
		{
		}

        public int AddDoctorList(ProjectOTDoctorListBO projectOTDoctorListBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[5];
            int result = 0;
            try
            {

                arParams[0] = new SqlParameter("@project_patient_id", projectOTDoctorListBO.project_patient_id);
                arParams[1] = new SqlParameter("@ref_doctor_id", projectOTDoctorListBO.ref_doctor_id);
                arParams[2] = new SqlParameter("@type_id", projectOTDoctorListBO.type_id);

                arParams[3] = new SqlParameter("@record_created_by", projectOTDoctorListBO.record_created_by);
                arParams[4] = new SqlParameter("@project_ot_doctor_list_id", projectOTDoctorListBO.project_ot_doctor_list_id);
                arParams[4].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "ProjectDoctorListAdd", arParams);
                result = Convert.ToInt32(arParams[4].Value.ToString());

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
        public int UpdateDoctorList(ProjectOTDoctorListBO projectOTDoctorListBO)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@ref_doctor_id", projectOTDoctorListBO.ref_doctor_id);
                arParams[1] = new SqlParameter("@type_id", projectOTDoctorListBO.type_id);
                arParams[2] = new SqlParameter("@record_modified_by", projectOTDoctorListBO.record_modified_by);
                arParams[3] = new SqlParameter("@project_ot_doctor_list_id", projectOTDoctorListBO.project_ot_doctor_list_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectDoctorListUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
