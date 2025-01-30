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
    public class ProjectDAL
    {
        public ProjectDAL()
		{
		}
        public int AddProject(ProjectBO projectBO)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@project_name", projectBO.project_name);
                arParams[1] = new SqlParameter("@project_term", projectBO.project_term);
                arParams[2] = new SqlParameter("@start_date", projectBO.start_date);
                arParams[3] = new SqlParameter("@end_date", projectBO.end_date);
                arParams[4] = new SqlParameter("@record_created_by", projectBO.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ProjectAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
