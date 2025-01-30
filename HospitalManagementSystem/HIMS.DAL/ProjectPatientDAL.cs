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
    public class ProjectPatientDAL
    {
        public ProjectPatientDAL()
		{
		}
        public int AddProjectPatient(ProjectPatientBO projectPatientBO)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@patient_name", projectPatientBO.patient_name);
                arParams[1] = new SqlParameter("@patient_father_name", projectPatientBO.patient_father_name);
                arParams[2] = new SqlParameter("@patient_mother_name", projectPatientBO.patient_mother_name);
                arParams[3] = new SqlParameter("@contact_number", projectPatientBO.contact_number);
                arParams[4] = new SqlParameter("@patient_address", projectPatientBO.patient_address);
                arParams[5] = new SqlParameter("@dob", projectPatientBO.dob);
                arParams[6] = new SqlParameter("@gender_id", projectPatientBO.gender_id);
                arParams[7] = new SqlParameter("@project_id", projectPatientBO.project_id);
                arParams[8] = new SqlParameter("@project_term", projectPatientBO.project_term);
                arParams[9] = new SqlParameter("@record_created_by", projectPatientBO.record_created_by);



                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectPatientAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateProjectPatient(ProjectPatientBO projectPatientBO)
        {
            SqlParameter[] arParams = new SqlParameter[9];
            try
            {
                arParams[0] = new SqlParameter("@patient_name", projectPatientBO.patient_name);
                arParams[1] = new SqlParameter("@patient_father_name", projectPatientBO.patient_father_name);
                arParams[2] = new SqlParameter("@patient_mother_name", projectPatientBO.patient_mother_name);
                arParams[3] = new SqlParameter("@contact_number", projectPatientBO.contact_number);
                arParams[4] = new SqlParameter("@patient_address", projectPatientBO.patient_address);
                arParams[5] = new SqlParameter("@dob", projectPatientBO.dob);
                arParams[6] = new SqlParameter("@gender_id", projectPatientBO.gender_id);
                arParams[7] = new SqlParameter("@project_patient_id", projectPatientBO.project_patient_id);

                arParams[8] = new SqlParameter("@record_modified_by", projectPatientBO.record_modified_by);



                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectPatientupdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
