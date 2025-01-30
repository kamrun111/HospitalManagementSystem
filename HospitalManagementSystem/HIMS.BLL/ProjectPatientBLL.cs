using System;
using System.Collections.Generic;
using System.Text;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class ProjectPatientBLL
    {
        private ProjectPatientDAL _projectPatientDAL;

        public ProjectPatientDAL projectPatientDAL
		{
            get { return _projectPatientDAL; }
            set { _projectPatientDAL = value; }
		}

        public ProjectPatientBLL()
		{
            projectPatientDAL = new ProjectPatientDAL();
		}

        public int AddProjectPatient(ProjectPatientBO projectPatientBO)
		{
			try
			{
                return projectPatientDAL.AddProjectPatient(projectPatientBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int UpdateProjectPatient(ProjectPatientBO projectPatientBO)
        {
            try
            {
                return projectPatientDAL.UpdateProjectPatient(projectPatientBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
