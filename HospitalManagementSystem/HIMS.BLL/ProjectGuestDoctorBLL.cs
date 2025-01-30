using System;
using System.Collections.Generic;
using System.Text;
using HIMS.DAL;
using HIMS.BusinessObjects;

namespace HIMS.BLL
{
    public class ProjectGuestDoctorBLL
    {
        private ProjectGuestDoctorDAL _projectGuestDoctorDAL;

        public ProjectGuestDoctorDAL projectGuestDoctorDAL
		{
            get { return _projectGuestDoctorDAL; }
            set { _projectGuestDoctorDAL = value; }
		}

        public ProjectGuestDoctorBLL()
		{
            projectGuestDoctorDAL = new ProjectGuestDoctorDAL();
		}

        public int AddProjectDoctor(ProjectGuestDoctorBO projectGuestDoctorBO)
		{
			try
			{
                return projectGuestDoctorDAL.AddProjectDoctor(projectGuestDoctorBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateProjectDoctor(ProjectGuestDoctorBO projectGuestDoctorBO)
		{
			try
			{
                return projectGuestDoctorDAL.UpdateProjectDoctor(projectGuestDoctorBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
    }
}
