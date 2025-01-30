using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OutdoorPatientVisitBLL
	{
		private outdoor_patient_visitDAL _outdoor_patient_visitDAL;

		public outdoor_patient_visitDAL outdoor_patient_visitDAL
		{
			get { return _outdoor_patient_visitDAL; }
			set { _outdoor_patient_visitDAL = value; }
		}

		public OutdoorPatientVisitBLL()
		{
			outdoor_patient_visitDAL = new outdoor_patient_visitDAL();
		}
		public List<OutdoorPatientVisit> Getoutdoor_patient_visitsList()
		{
			try
			{
				return outdoor_patient_visitDAL.Getoutdoor_patient_visitsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoutdoor_patient_visits()
		{
			try
			{
				return outdoor_patient_visitDAL.Getoutdoor_patient_visits();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public OutdoorPatientVisit Getoutdoor_patient_visit(int outdoor_patient_visit_id)
		{
			try
			{
				return outdoor_patient_visitDAL.Getoutdoor_patient_visit(outdoor_patient_visit_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addoutdoor_patient_visit(OutdoorPatientVisit ooutdoor_patient_visit)
		{
			try
			{
				return outdoor_patient_visitDAL.Addoutdoor_patient_visit(ooutdoor_patient_visit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_visit(OutdoorPatientVisit ooutdoor_patient_visit)
		{
			try
			{
				return outdoor_patient_visitDAL.Updateoutdoor_patient_visit(ooutdoor_patient_visit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_visit(OutdoorPatientVisit ooutdoor_patient_visit)
		{
			try
			{
				return outdoor_patient_visitDAL.Removeoutdoor_patient_visit(ooutdoor_patient_visit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_visit(int outdoor_patient_visit_id)
		{
			try
			{
				return outdoor_patient_visitDAL.Removeoutdoor_patient_visit(outdoor_patient_visit_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<OutdoorPatientVisit> Deserializeoutdoor_patient_visits(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<OutdoorPatientVisit>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoutdoor_patient_visits(string Path, List<OutdoorPatientVisit> outdoor_patient_visits)
		{
			try
			{
				GenericXmlSerializer<List<OutdoorPatientVisit>>.Serialize(outdoor_patient_visits, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
