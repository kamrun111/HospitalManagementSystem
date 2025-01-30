using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class AdmissionBLL
	{
        private AdmissionDAL _admissionDAL;

        public AdmissionDAL admissionDAL
		{
			get { return _admissionDAL; }
			set { _admissionDAL = value; }
		}

		public AdmissionBLL()
		{
            admissionDAL = new AdmissionDAL();
		}
		public List<AdmissionBO> GetadmissionsList()
		{
			try
			{
				return admissionDAL.GetadmissionsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getadmissions()
		{
			try
			{
				return admissionDAL.Getadmissions();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet getopdpatient()
        {
            try
            {
                return admissionDAL.getopdpatient();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        public DataSet AdmissionCaseNoGet(string pCode)
		{
			try
			{
				return admissionDAL.AdmissionCaseNoGet(pCode);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        

        public DataSet GetAdmissionPopulationInfo()
		{
			try
			{
                return admissionDAL.GetAdmissionPopulationInfo();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet Isdiacharge(int pCode)
        {
            try
            {
                return admissionDAL.Isdiacharge(pCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getcasesummaryID(int casesummaryID)
        {
            try
            {
                return admissionDAL.getcasesummaryID(casesummaryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet getcasesummaryID_ICU(int casesummaryID)
        {
            try
            {
                return admissionDAL.getcasesummaryID_ICU(casesummaryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


         public DataSet GetDoctorVisitPopulationInfo(int admissionID)
         {
             try
             {
                 return admissionDAL.GetDoctorVisitPopulationInfo(admissionID);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }


        public DataSet GetNurseStationPopulationInfo(int presID, int admissionID)
         {
             try
             {
                 return admissionDAL.GetNurseStationPopulationInfo(presID, admissionID);
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }

        public DataSet GetDoctorStationPopulationInfo(int floorID)
        {
            try
            {
                return admissionDAL.GetDoctorStationPopulationInfo(floorID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       

        public DataSet GetPatientInfoByFloor(string floor)
        {
            try
            {
                return admissionDAL.GetPatientInfoByFloor(floor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetAdmissionReportData(int admissionID)
        {
            try
            {
                return admissionDAL.GetAdmissionReportData(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet RefDocAndCabinByPCode(string patientID)
        {
            try
            {
                return admissionDAL.RefDocAndCabinByPCode(patientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public DataSet GetAllNonReceivedPatientCabin()
        {
            try
            {
                return admissionDAL.GetAllNonReceivedPatientCabin();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public AdmissionBO Getadmission(int admission_id)
		{
			try
			{
				return admissionDAL.Getadmission(admission_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addadmission(AdmissionBO oadmission, out int paymentID,int Flag)
		{
			try
			{
                return admissionDAL.Addadmission(oadmission, out paymentID, Flag);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AddadmissionDialysis(AdmissionBO oadmission, out int paymentID, int Flag)
        {
            try
            {
                return admissionDAL.AddadmissionDialysis(oadmission, out paymentID, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddadmissionICU(AdmissionBO oadmission, out int paymentID, int Flag)
        {
            try
            {
                return admissionDAL.admissionAddICU(oadmission, out paymentID, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int AddadmissionWithMember(AdmissionBO oadmission, out int paymentID, int Flag)
        {
            try
            {
                return admissionDAL.AddadmissionWithMember(oadmission, out paymentID, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int newadmissionAdd(AdmissionBO admissionBO,Pay pay)
        {
            try
            {
                return admissionDAL.newadmissionAdd(admissionBO, pay);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updateadmission(AdmissionBO oadmission)
		{
			try
			{
				return admissionDAL.Updateadmission(oadmission);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int admissionUpdateforBill(AdmissionBO oadmission)
        {
            try
            {
                return admissionDAL.admissionUpdateforBill(oadmission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateAdmissionRemarks(AdmissionBO oadmission)
		{
			try
			{
                return admissionDAL.UpdateAdmissionRemarks(oadmission);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int UpdateAdmissionNurseRemarks(AdmissionBO oadmission)
		{
			try
			{
                return admissionDAL.UpdateAdmissionNurseRemarks(oadmission);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int SetPatientDischargeInfo(int admissionID, int cabinID, int userID, CaseSummary caseSummary)
		{
			try
			{
                return admissionDAL.SetPatientDischargeInfo(admissionID, cabinID, userID, caseSummary);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int SetDischargeInfo(int admissionID, string cabinID, int userID)
        {
            try
            {
                return admissionDAL.SetDischargeInfo(admissionID, cabinID, userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SetDischargeInfoICU(int admissionID, string cabinID, int userID)
        {
            try
            {
                return admissionDAL.SetDischargeInfoICU(admissionID, cabinID, userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Removeadmission(AdmissionBO oadmission)
		{
			try
			{
				return admissionDAL.Removeadmission(oadmission);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeadmission(int admission_id)
		{
			try
			{
				return admissionDAL.Removeadmission(admission_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<AdmissionBO> Deserializeadmissions(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<AdmissionBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeadmissions(string Path, List<AdmissionBO> admissions)
		{
			try
			{
				GenericXmlSerializer<List<AdmissionBO>>.Serialize(admissions, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AdmissionStatusUpdate(AdmissionBO admissionBO)
        {
            try
            {
                return admissionDAL.AdmissionStatusUpdate(admissionBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int InsuranceUpdate(AdmissionBO admissionBO)
        {
            try
            {
                return admissionDAL.InsuranceUpdate(admissionBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
