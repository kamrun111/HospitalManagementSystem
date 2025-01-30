using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientStatusBLL
	{
		private PatientStatusDAL _patient_statusDAL;

		public PatientStatusDAL patient_statusDAL
		{
			get { return _patient_statusDAL; }
			set { _patient_statusDAL = value; }
		}

		public PatientStatusBLL()
		{
			patient_statusDAL = new PatientStatusDAL();
		}
		public List<PatientStatus> Getpatient_statussList()
		{
			try
			{
				return patient_statusDAL.Getpatient_statussList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_statuss()
		{
			try
			{
				return patient_statusDAL.Getpatient_statuss();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public PatientStatus Getpatient_status(int patient_status_id)
		{
			try
			{
				return patient_statusDAL.Getpatient_status(patient_status_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addpatient_status(PatientStatus opatient_status)
		{
			try
			{
				return patient_statusDAL.Addpatient_status(opatient_status);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatepatient_status(PatientStatus opatient_status)
		{
			try
			{
				return patient_statusDAL.Updatepatient_status(opatient_status);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removepatient_status(PatientStatus opatient_status)
		{
			try
			{
				return patient_statusDAL.Removepatient_status(opatient_status);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_status(int patient_status_id)
		{
			try
			{
				return patient_statusDAL.Removepatient_status(patient_status_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<PatientStatus> Deserializepatient_statuss(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<PatientStatus>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializepatient_statuss(string Path, List<PatientStatus> patient_statuss)
		{
			try
			{
                GenericXmlSerializer<List<PatientStatus>>.Serialize(patient_statuss, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
