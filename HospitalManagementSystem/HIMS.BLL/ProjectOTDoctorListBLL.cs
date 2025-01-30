using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class ProjectOTDoctorListBLL
    {
        private ProjectOTDoctorListDAL _projectOTDoctorListDAL;

        public ProjectOTDoctorListDAL projectOTDoctorListDAL
		{
            get { return _projectOTDoctorListDAL; }
            set { _projectOTDoctorListDAL = value; }
		}

        public ProjectOTDoctorListBLL()
		{
            projectOTDoctorListDAL = new ProjectOTDoctorListDAL();
		}

        public int AddDoctorList(ProjectOTDoctorListBO projectOTDoctorListBO)
		{
			try
			{
				return projectOTDoctorListDAL.AddDoctorList(projectOTDoctorListBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int UpdateDoctorList(ProjectOTDoctorListBO projectOTDoctorListBO)
		{
			try
			{
				return projectOTDoctorListDAL.UpdateDoctorList(projectOTDoctorListBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
    }
}
