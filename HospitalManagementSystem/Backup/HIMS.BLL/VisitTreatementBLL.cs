using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class VisitTreatementBLL
	{
		private VisitTreatementDAL _visit_treatementDAL;

		public VisitTreatementDAL visit_treatementDAL
		{
			get { return _visit_treatementDAL; }
			set { _visit_treatementDAL = value; }
		}

		public VisitTreatementBLL()
		{
			visit_treatementDAL = new VisitTreatementDAL();
		}
		public List<VisitTreatement> Getvisit_treatementsList()
		{
			try
			{
				return visit_treatementDAL.Getvisit_treatementsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getvisit_treatements()
		{
			try
			{
				return visit_treatementDAL.Getvisit_treatements();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet VisitTreatementGetByAdmnID(int admnID)
		{
			try
			{
				return visit_treatementDAL.VisitTreatementGetByAdmnID(admnID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        
		public VisitTreatement Getvisit_treatement(int visit_treatement_id)
		{
			try
			{
				return visit_treatementDAL.Getvisit_treatement(visit_treatement_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addvisit_treatement(VisitTreatement ovisit_treatement)
		{
			try
			{
				return visit_treatementDAL.Addvisit_treatement(ovisit_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatevisit_treatement(VisitTreatement ovisit_treatement)
		{
			try
			{
				return visit_treatementDAL.Updatevisit_treatement(ovisit_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int visit_doctortreatement(VisitTreatement ovisit_treatement)
        {
            try
            {
                return visit_treatementDAL.visit_doctortreatement(ovisit_treatement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int VisitTreatementSubmitSet(VisitTreatement ovisit_treatement)
		{
			try
			{
                return visit_treatementDAL.VisitTreatementSubmitSet(ovisit_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        
		public int Removevisit_treatement(VisitTreatement ovisit_treatement)
		{
			try
			{
				return visit_treatementDAL.Removevisit_treatement(ovisit_treatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_treatement(int visit_treatement_id)
		{
			try
			{
				return visit_treatementDAL.Removevisit_treatement(visit_treatement_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<VisitTreatement> Deserializevisit_treatements(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<VisitTreatement>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializevisit_treatements(string Path, List<VisitTreatement> visit_treatements)
		{
			try
			{
				GenericXmlSerializer<List<VisitTreatement>>.Serialize(visit_treatements, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
