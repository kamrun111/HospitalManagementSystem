using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientRefferedDoctorsBLL
	{
		private PatientRefferedDoctorsDAL _patient_reffered_doctorsDAL;

		public PatientRefferedDoctorsDAL patient_reffered_doctorsDAL
		{
			get { return _patient_reffered_doctorsDAL; }
			set { _patient_reffered_doctorsDAL = value; }
		}

		public PatientRefferedDoctorsBLL()
		{
			patient_reffered_doctorsDAL = new PatientRefferedDoctorsDAL();
		}
		public List<PatientRefferedDoctors> Getpatient_reffered_doctorssList()
		{
			try
			{
				return patient_reffered_doctorsDAL.Getpatient_reffered_doctorssList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int patientreferredDocupdate(PatientRefferedDoctors oPatientRefferedDoctors)
        {
            try
            {
                return patient_reffered_doctorsDAL.patientreferredDocupdate(oPatientRefferedDoctors);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int addrefferedDoc(List<PatientRefferedDoctors> lstPatientRefferedDoctors)//sami
        {
            try
            {
                return patient_reffered_doctorsDAL.addrefferedDoc(lstPatientRefferedDoctors);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public DataSet Getpatient_reffered_doctorss()
		{
			try
			{
				return patient_reffered_doctorsDAL.Getpatient_reffered_doctorss();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PatientRefferedDoctors Getpatient_reffered_doctors(int patient_reffered_doctors_id)
		{
			try
			{
				return patient_reffered_doctorsDAL.Getpatient_reffered_doctors(patient_reffered_doctors_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_reffered_doctors(PatientRefferedDoctors opatient_reffered_doctors)
		{
			try
			{
				return patient_reffered_doctorsDAL.Addpatient_reffered_doctors(opatient_reffered_doctors);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_reffered_doctors(PatientRefferedDoctors opatient_reffered_doctors)
		{
			try
			{
				return patient_reffered_doctorsDAL.Updatepatient_reffered_doctors(opatient_reffered_doctors);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int RefDocDelte(int AdmissionID)
        {
            try
            {
                return patient_reffered_doctorsDAL.RefDocDelte(AdmissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient_reffered_doctors(PatientRefferedDoctors opatient_reffered_doctors)
		{
			try
			{
				return patient_reffered_doctorsDAL.Removepatient_reffered_doctors(opatient_reffered_doctors);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_reffered_doctors(int patient_reffered_doctors_id)
		{
			try
			{
				return patient_reffered_doctorsDAL.Removepatient_reffered_doctors(patient_reffered_doctors_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientRefferedDoctors> Deserializepatient_reffered_doctorss(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientRefferedDoctors>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_reffered_doctorss(string Path, List<PatientRefferedDoctors> patient_reffered_doctorss)
		{
			try
			{
				GenericXmlSerializer<List<PatientRefferedDoctors>>.Serialize(patient_reffered_doctorss, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
