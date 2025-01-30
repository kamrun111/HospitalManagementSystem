using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientTreatementBLL
	{
		private PatientTreatementDAL _patient_treatementDAL;

		public PatientTreatementDAL patient_treatementDAL
		{
			get { return _patient_treatementDAL; }
			set { _patient_treatementDAL = value; }
		}

		public PatientTreatementBLL()
		{
			patient_treatementDAL = new PatientTreatementDAL();
		}
		public List<PatientTreatement> Getpatient_treatementsList()
		{
			try
			{
				return patient_treatementDAL.Getpatient_treatementsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_treatements()
		{
			try
			{
				return patient_treatementDAL.Getpatient_treatements();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PatientTreatement Getpatient_treatement(int patient_treatement_id)
		{
			try
			{
				return patient_treatementDAL.Getpatient_treatement(patient_treatement_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_treatement(PatientTreatement opatient_treatement)
		{
			try
			{
				return patient_treatementDAL.Addpatient_treatement(opatient_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_treatement(PatientTreatement opatient_treatement)
		{
			try
			{
				return patient_treatementDAL.Updatepatient_treatement(opatient_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_treatement(PatientTreatement opatient_treatement)
		{
			try
			{
				return patient_treatementDAL.Removepatient_treatement(opatient_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_treatement(int patient_treatement_id)
		{
			try
			{
				return patient_treatementDAL.Removepatient_treatement(patient_treatement_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientTreatement> Deserializepatient_treatements(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientTreatement>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_treatements(string Path, List<PatientTreatement> patient_treatements)
		{
			try
			{
				GenericXmlSerializer<List<PatientTreatement>>.Serialize(patient_treatements, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
