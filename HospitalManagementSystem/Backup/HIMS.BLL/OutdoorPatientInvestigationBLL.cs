using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OutdoorPatientInvestigationBLL
	{
		private OutdoorPatientInvestigationDAL _outdoor_patient_investigationDAL;

		public OutdoorPatientInvestigationDAL outdoor_patient_investigationDAL
		{
			get { return _outdoor_patient_investigationDAL; }
			set { _outdoor_patient_investigationDAL = value; }
		}

		public OutdoorPatientInvestigationBLL()
		{
			outdoor_patient_investigationDAL = new OutdoorPatientInvestigationDAL();
		}
		public List<OutdoorPatientInvestigation> Getoutdoor_patient_investigationsList()
		{
			try
			{
				return outdoor_patient_investigationDAL.Getoutdoor_patient_investigationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoutdoor_patient_investigations()
		{
			try
			{
				return outdoor_patient_investigationDAL.Getoutdoor_patient_investigations();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public OutdoorPatientInvestigation Getoutdoor_patient_investigation(int outdoor_patient_investigation_id)
		{
			try
			{
				return outdoor_patient_investigationDAL.Getoutdoor_patient_investigation(outdoor_patient_investigation_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addoutdoor_patient_investigation(OutdoorPatientInvestigation ooutdoor_patient_investigation)
		{
			try
			{
				return outdoor_patient_investigationDAL.Addoutdoor_patient_investigation(ooutdoor_patient_investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_investigation(OutdoorPatientInvestigation ooutdoor_patient_investigation)
		{
			try
			{
				return outdoor_patient_investigationDAL.Updateoutdoor_patient_investigation(ooutdoor_patient_investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_investigation(OutdoorPatientInvestigation ooutdoor_patient_investigation)
		{
			try
			{
				return outdoor_patient_investigationDAL.Removeoutdoor_patient_investigation(ooutdoor_patient_investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_investigation(int outdoor_patient_investigation_id)
		{
			try
			{
				return outdoor_patient_investigationDAL.Removeoutdoor_patient_investigation(outdoor_patient_investigation_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<OutdoorPatientInvestigation> Deserializeoutdoor_patient_investigations(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<OutdoorPatientInvestigation>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoutdoor_patient_investigations(string Path, List<OutdoorPatientInvestigation> outdoor_patient_investigations)
		{
			try
			{
				GenericXmlSerializer<List<OutdoorPatientInvestigation>>.Serialize(outdoor_patient_investigations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetOutdoorInvestigation(char outdoor_booking_id, DateTime record_created_date)
        {
            try
            {
                return outdoor_patient_investigationDAL.GetOutdoorInvestigation(outdoor_booking_id, record_created_date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

	}
}
