using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class VisitAdviceBLL
	{
		private VisitAdviceDAL _visit_adviceDAL;

		public VisitAdviceDAL visit_adviceDAL
		{
			get { return _visit_adviceDAL; }
			set { _visit_adviceDAL = value; }
		}

		public VisitAdviceBLL()
		{
			visit_adviceDAL = new VisitAdviceDAL();
		}
		public List<VisitAdvice> Getvisit_advicesList()
		{
			try
			{
				return visit_adviceDAL.Getvisit_advicesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getvisit_advices()
		{
			try
			{
				return visit_adviceDAL.Getvisit_advices();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public VisitAdvice Getvisit_advice(int visit_advice_id)
		{
			try
			{
				return visit_adviceDAL.Getvisit_advice(visit_advice_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addvisit_advice(VisitAdvice ovisit_advice)
		{
			try
			{
				return visit_adviceDAL.Addvisit_advice(ovisit_advice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatevisit_advice(VisitAdvice ovisit_advice)
		{
			try
			{
				return visit_adviceDAL.Updatevisit_advice(ovisit_advice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int visit_docadviceUpdate(VisitAdvice ovisit_advice)
        {
            try
            {
                return visit_adviceDAL.visit_docadviceUpdate(ovisit_advice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removevisit_advice(VisitAdvice ovisit_advice)
		{
			try
			{
				return visit_adviceDAL.Removevisit_advice(ovisit_advice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_advice(int visit_advice_id)
		{
			try
			{
				return visit_adviceDAL.Removevisit_advice(visit_advice_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<VisitAdvice> Deserializevisit_advices(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<VisitAdvice>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializevisit_advices(string Path, List<VisitAdvice> visit_advices)
		{
			try
			{
				GenericXmlSerializer<List<VisitAdvice>>.Serialize(visit_advices, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
