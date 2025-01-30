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
         public DataSet getdoctors()
         {
             try
             {
                 return doctorsBillDAL.getdoctors();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public DataSet get_alldoctors()
         {
             try
             {
                 return doctorsBillDAL.get_alldoctors();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public DataSet getdoctodsbill(DateTime From, DateTime To, int reffered_doctor_id)//sami 27 Oct
         {
             try
             {
                 return doctorsBillDAL.getdoctodsbill(From, To, reffered_doctor_id);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
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
         public DataSet GetDoctorBillForPatient(int AdmissionID)//sami 27 Oct
         {
             try
             {
                 return doctorsBillDAL.GetDoctorBillForPatient(AdmissionID);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
             }
         }

         public DataSet GetDoctorBillForPatient_ICU(int AdmissionID)//sami 27 Oct
         {
             try
             {
                 return doctorsBillDAL.GetDoctorBillForPatient_ICU(AdmissionID);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
             }
         }

         public DataSet GetDiscountinfo(int AdmissionID)//sami 27 Oct
         {
             try
             {
                 return doctorsBillDAL.GetDiscountinfo(AdmissionID);
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
         public int doctorsbillADD(List<DoctorsBillBO> listDoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.doctorsbillADD(listDoctorsBillBO);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int doctorsbillADD_ICU(List<DoctorsBillBO> listDoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.doctorsbillADD_ICU(listDoctorsBillBO);
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
         public int DoctorBillUpdate(DoctorsBillBO odoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.DoctorBillUpdate(odoctorsBillBO);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DoctorBillUpdate_ICU(DoctorsBillBO odoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.DoctorBillUpdate_ICU(odoctorsBillBO);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DoctorBillDelete(DoctorsBillBO odoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.DoctorBillDelete(odoctorsBillBO);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int DoctorBillDelete_ICU(DoctorsBillBO odoctorsBillBO)
         {
             try
             {
                 return doctorsBillDAL.DoctorBillDelete_ICU(odoctorsBillBO);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

         public int PatientDiscount(List<InvestigationOrder> listInvestigationOrder, List<PatientOtherItem> listPatientOtherItem, List<DoctorsBillBO> listDoctorsBillBO, AdmissionBO admissionBO, InpatientAccount inpatientAccount)
         {
             try
             {
                 return doctorsBillDAL.PatientDiscount(listInvestigationOrder, listPatientOtherItem, listDoctorsBillBO, admissionBO, inpatientAccount);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

    }
}
