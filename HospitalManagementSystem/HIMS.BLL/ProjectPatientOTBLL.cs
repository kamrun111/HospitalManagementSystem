using System;
using System.Collections.Generic;
using System.Text;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class ProjectPatientOTBLL
    {
        private ProjectPatientOTDAL _projectPatientOTDAL;

        public ProjectPatientOTDAL projectPatientOTDAL
		{
            get { return _projectPatientOTDAL; }
            set { _projectPatientOTDAL = value; }
		}

        public ProjectPatientOTBLL()
		{
            projectPatientOTDAL = new ProjectPatientOTDAL();
		}

        public int AddProjectPatientOT(ProjectPatientOTBO projectPatientOTBO)
		{
			try
			{
                return projectPatientOTDAL.AddProjectPatientOT(projectPatientOTBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int UpdateProjectPatientOT(ProjectPatientOTBO projectPatientOTBO)
        {
            try
            {
                return projectPatientOTDAL.UpdateProjectPatientOT(projectPatientOTBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
