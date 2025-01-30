using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
     public class DoctorsBillBLL
    {
         private DoctorsBillDAL _doctorsBillDAL;

         public DoctorsBillDAL doctorsBillDAL
        {
            get { return _doctorsBillDAL; }
            set { _doctorsBillDAL = value; }
        }

        public DoctorsBillBLL()
		{
            doctorsBillDAL = new DoctorsBillDAL();
		}

         public DataSet DoctorsBillLoad()
         {
             try
             {
                 return doctorsBillDAL.DoctorsBillLoad();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public DataSet DoctorsBillShow(int AdmissionID)//sami 27 Oct
         {
             try
             {
                 return doctorsBillDAL.DoctorsBillShow(AdmissionID);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
             }
         }

         public int DoctorsBillUpdate(List<DoctorsBillBO> doctorsBillList)//sami
         {
             try
             {
                 return doctorsBillDAL.DoctorsBillUpdate(doctorsBillList);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DoctorsBillAdd(DoctorsBillBO odoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.DoctorsBillAdd(odoctorsBillBO);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

    }
}
