using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientHistoryBLL
	{
		private PatientHistoryDAL _patient_historyDAL;

		public PatientHistoryDAL patient_historyDAL
		{
			get { return _patient_historyDAL; }
			set { _patient_historyDAL = value; }
		}

		public PatientHistoryBLL()
		{
			patient_historyDAL = new PatientHistoryDAL();
		}
		public List<PatientHistoryBO> Getpatient_historysList()
		{
			try
			{
				return patient_historyDAL.Getpatient_historysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_historys()
		{
			try
			{
				return patient_historyDAL.Getpatient_historys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetPatientHistoryTextValue(int admissionID)
		{
			try
			{
                return patient_historyDAL.GetPatientHistoryTextValue(admissionID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PatientHistoryBO Getpatient_history(int patient_history_id)
		{
			try
			{
				return patient_historyDAL.Getpatient_history(patient_history_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_history(PatientHistoryBO opatient_history)
		{
			try
			{
				return patient_historyDAL.Addpatient_history(opatient_history);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_history(PatientHistoryBO opatient_history)
		{
			try
			{
				return patient_historyDAL.Updatepatient_history(opatient_history);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int SetIsHistoyWritten(int admnID)
		{
			try
			{
				return patient_historyDAL. SetIsHistoyWritten(admnID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_history(PatientHistoryBO opatient_history)
		{
			try
			{
				return patient_historyDAL.Removepatient_history(opatient_history);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removepatient_history(int admnID, int historyTextID)
		{
			try
			{
				return patient_historyDAL.Removepatient_history(admnID,historyTextID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientHistoryBO> Deserializepatient_historys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientHistoryBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_historys(string Path, List<PatientHistoryBO> patient_historys)
		{
			try
			{
				GenericXmlSerializer<List<PatientHistoryBO>>.Serialize(patient_historys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
