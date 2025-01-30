using System;
using System.Collections.Generic;
using System.Text;
using HIMS.DAL;
using HIMS.BusinessObjects;

namespace HIMS.BLL
{
    public class ProjectBLL
    {
        private ProjectDAL _projectDAL;

        public ProjectDAL projectDAL
		{
            get { return _projectDAL; }
            set { _projectDAL = value; }
		}

        public ProjectBLL()
		{
            projectDAL = new ProjectDAL();
		}

        public int AddProject(ProjectBO projectBO)
		{
			try
			{
                return projectDAL.AddProject(projectBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
    }
}
