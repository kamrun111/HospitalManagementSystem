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
    public class ProjectGuestDoctorDAL
    {
        public ProjectGuestDoctorDAL()
		{
		}

        public int AddProjectDoctor(ProjectGuestDoctorBO projectGuestDoctorBO)
		{
			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
                arParams[0] = new SqlParameter("@guest_doctor_name", projectGuestDoctorBO.guest_doctor_name);
                arParams[1] = new SqlParameter("@record_created_by", projectGuestDoctorBO.record_created_by);
				

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectDoctorAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateProjectDoctor(ProjectGuestDoctorBO projectGuestDoctorBO)
		{

			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
                arParams[0] = new SqlParameter("@guest_doctor_name", projectGuestDoctorBO.guest_doctor_name);
                arParams[1] = new SqlParameter("@record_modified_by", projectGuestDoctorBO.record_modified_by);
                arParams[2] = new SqlParameter("@guest_doctor_id", projectGuestDoctorBO.guest_doctor_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectDoctorUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
    }
}
