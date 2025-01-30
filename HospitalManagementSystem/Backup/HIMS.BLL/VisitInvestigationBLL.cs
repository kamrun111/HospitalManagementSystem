using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class VisitInvestigationBLL
	{
		private VisitInvestigationDAL _visit_investigationDAL;

		public VisitInvestigationDAL visit_investigationDAL
		{
			get { return _visit_investigationDAL; }
			set { _visit_investigationDAL = value; }
		}

		public VisitInvestigationBLL()
		{
			visit_investigationDAL = new VisitInvestigationDAL();
		}
		public List<VisitInvestigation> Getvisit_investigationsList()
		{
			try
			{
				return visit_investigationDAL.Getvisit_investigationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getvisit_investigations()
		{
			try
			{
				return visit_investigationDAL.Getvisit_investigations();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public int donebypatient(VisitInvestigation ovisit_investigation)
        {
            try
            {
                return visit_investigationDAL.donebypatient(ovisit_investigation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetInvestigationIndentInfo(int admnID)
		{
			try
			{
                return visit_investigationDAL.GetInvestigationIndentInfo(admnID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public VisitInvestigation Getvisit_investigation(int visit_investigation_id)
		{
			try
			{
				return visit_investigationDAL.Getvisit_investigation(visit_investigation_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int visitinvetigationcancel(VisitInvestigation ovisit_investigation)
		{
			try
			{
                return visit_investigationDAL.visitinvetigationcancel(ovisit_investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Addvisit_investigation(VisitInvestigation ovisit_investigation)
        {
            try
            {
                return visit_investigationDAL.Addvisit_investigation(ovisit_investigation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatevisit_investigation(VisitInvestigation ovisit_investigation)
		{
			try
			{
				return visit_investigationDAL.Updatevisit_investigation(ovisit_investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int SetVisitInvestigationIndentGiven(int visitInvestigationID, int indentGiven,int userID)
		{
			try
			{
                return visit_investigationDAL.SetVisitInvestigationIndentGiven(visitInvestigationID, indentGiven, userID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
        public int Removevisit_investigation(VisitInvestigation ovisit_investigation)
		{
			try
			{
				return visit_investigationDAL.Removevisit_investigation(ovisit_investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_investigation(int visit_investigation_id)
		{
			try
			{
				return visit_investigationDAL.Removevisit_investigation(visit_investigation_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<VisitInvestigation> Deserializevisit_investigations(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<VisitInvestigation>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializevisit_investigations(string Path, List<VisitInvestigation> visit_investigations)
		{
			try
			{
				GenericXmlSerializer<List<VisitInvestigation>>.Serialize(visit_investigations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
