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
    public class ProjectPatientOTDAL
    {
        public ProjectPatientOTDAL()
		{
		}

        public int AddProjectPatientOT(ProjectPatientOTBO projectPatientOTBO)
        {

            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@ot_name", projectPatientOTBO.ot_name);
                arParams[1] = new SqlParameter("@project_patient_id", projectPatientOTBO.project_patient_id);
                arParams[2] = new SqlParameter("@ot_date", projectPatientOTBO.ot_date);
                arParams[3] = new SqlParameter("@ot_start_time", projectPatientOTBO.ot_start_time);
                arParams[4] = new SqlParameter("@ot_finish_time", projectPatientOTBO.ot_finish_time);
                arParams[5] = new SqlParameter("@anesthia_type", projectPatientOTBO.anesthia_type);
                arParams[6] = new SqlParameter("@record_created_by", projectPatientOTBO.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectPatientOTAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateProjectPatientOT(ProjectPatientOTBO projectPatientOTBO)
        {

            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@project_ot_id", projectPatientOTBO.project_ot_id);
                arParams[1] = new SqlParameter("@ot_name", projectPatientOTBO.ot_name);
                arParams[2] = new SqlParameter("@ot_date", projectPatientOTBO.ot_date);
                arParams[3] = new SqlParameter("@ot_start_time", projectPatientOTBO.ot_start_time);
                arParams[4] = new SqlParameter("@ot_finish_time", projectPatientOTBO.ot_finish_time);
                arParams[5] = new SqlParameter("@anesthia_type", projectPatientOTBO.anesthia_type);
                arParams[6] = new SqlParameter("@record_modified_by", projectPatientOTBO.record_modified_by);


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectPatientOTUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
