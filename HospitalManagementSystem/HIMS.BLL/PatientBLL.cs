using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientBLL
	{
		private PatientDAL _patientDAL;

		public PatientDAL patientDAL
		{
			get { return _patientDAL; }
			set { _patientDAL = value; }
		}

		public PatientBLL()
		{
			patientDAL = new PatientDAL();
		}
		public List<Patient> GetpatientsList()
		{
			try
			{
				return patientDAL.GetpatientsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet GetPtientSearch(string searchID, string searchIDValue, string procName, int isAdmittedOnly)
        {
            try
            {
                return patientDAL.GetPtientSearch(searchID, searchIDValue, procName, isAdmittedOnly);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OPDGetPtientSearch(string searchID, string searchIDValue, string procName,int flag)
        {
            try
            {
                return patientDAL.OPDGetPtientSearch(searchID, searchIDValue, procName, flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataSet Getpatients()
		{
			try
			{
				return patientDAL.Getpatients();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet PatientInfofordoctor(int AdmissionID)
        {
            try
            {
                return patientDAL.PatientInfofordoctor(AdmissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Patient IPDpatientGet(string patient_code)
        {
            try
            {
                return patientDAL.IPDpatientGet(patient_code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getallpayment(int admissionID)
        {
            try
            {
                return patientDAL.getallpayment(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Patient patientInfo(string patientCode)
        {
            try
            {
                return patientDAL.patientInfo(patientCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OutdoorPatientInfoGet(string patient_code)
        {
            try
            {
                return patientDAL.OutdoorPatientInfoGet(patient_code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PatientInfofornurse(string floor)
        {
            try
            {
                return patientDAL.PatientInfofornurse(floor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PatientHospatalIdSearch(int HospitalID)
        {
            try
            {
                return patientDAL.PatientHospatalIdSearch(HospitalID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet HospitalIDSearchDiscountPatient(int HospitalID)
        {
            try
            {
                return patientDAL.HospitalIDSearchDiscountPatient(HospitalID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public Patient Getpatient(string patient_code)
		{
			try
			{
                return patientDAL.Getpatient(patient_code);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetPatientinfo(int patientCode, int isadmitted)
        {
            try
            {
                return patientDAL.GetPatientinfo(patientCode, isadmitted);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetRefferedDoctorByAdmissionCode(string admission_code)
        {
            try
            {
                return patientDAL.GetRefferedDoctorByAdmissionCode(admission_code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddPatientAdmission(Patient patient, AdmissionBO admission, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID,out int paymentID,int Flag)
		{
			try
			{
                return patientDAL.AddPatientAdmission(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, Flag);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AddPatientAdmissionForDialysis(Patient patient, AdmissionBO admission, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID, out int paymentID, int Flag)
        {
            try
            {
                return patientDAL.AddPatientAdmissionForDialysis(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int AddPatientAdmissionForICU(Patient patient, AdmissionBO admission, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID, out int paymentID, int Flag)
        {
            try
            {
                return patientDAL.AddPatientAdmissionForICU(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int PatientAdmissionAddwithMember(Patient patient, AdmissionBO admission, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID, out int paymentID, int Flag)
        {
            try
            {
                return patientDAL.PatientAdmissionAddwithMember(patient, admission, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID, out paymentID, Flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Updatepatient(Patient opatient, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID)
		{
			try
			{
                return patientDAL.Updatepatient(opatient, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID);
			}
            catch (Exception ex)  
			{
				throw ex;
			}
		}

        public int UpdatePatientForAdmission(Patient opatient, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID)
        {
            try
            {
                return patientDAL.UpdatePatientForAdmission(opatient, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID);
            }
            catch (Exception ex)  //
            {
                throw ex;
            }
        }

        public int UpdatePatientForDialysis(Patient opatient, int gurdian_relation, int city_id, int occupation_id, int nationality_id, int religion_id, int gender_id, int patient_condition)
        {
            try
            {
                return patientDAL.UpdatePatientForDialysis(opatient, gurdian_relation, city_id, occupation_id, nationality_id, religion_id, gender_id, patient_condition);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int UpdatePatientForAdmissionNew(Patient opatient, string GRID, string CityID, string OccupID, string NationID, string RelID, string GenderID, string PConID)
        {
            try
            {
                return patientDAL.UpdatePatientForAdmissionNew(opatient, GRID, CityID, OccupID, NationID, RelID, GenderID, PConID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
   
        public int UpdatePatientSearch(Patient opatient)
        {
            try
            {
                return patientDAL.UpdatePatientSearch(opatient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient(Patient opatient)
		{
			try
			{
				return patientDAL.Removepatient(opatient);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient(int patient_id)
		{
			try
			{
				return patientDAL.Removepatient(patient_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int PatientAddforOPD(Patient patient)
        {
            try
            {
                return patientDAL.PatientAddforOPD(patient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<Patient> Deserializepatients(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Patient>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatients(string Path, List<Patient> patients)
		{
			try
			{
				GenericXmlSerializer<List<Patient>>.Serialize(patients, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
