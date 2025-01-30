using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class AdviceBLL
	{
		private AdviceDAL _adviceDAL;

		public AdviceDAL adviceDAL
		{
			get { return _adviceDAL; }
			set { _adviceDAL = value; }
		}

		public AdviceBLL()
		{
			adviceDAL = new AdviceDAL();
		}
		public List<Advice> GetadvicesList()
		{
			try
			{
				return adviceDAL.GetadvicesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getadvices()
		{
			try
			{
				return adviceDAL.Getadvices();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet LoggTime()
        {
            try
            {
                return adviceDAL.LoggTime();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public Advice Getadvice(int advice_id)
		{
			try
			{
				return adviceDAL.Getadvice(advice_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addadvice(Advice oadvice)
		{
			try
			{
				return adviceDAL.Addadvice(oadvice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateadvice(Advice oadvice)
		{
			try
			{
				return adviceDAL.Updateadvice(oadvice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeadvice(Advice oadvice)
		{
			try
			{
				return adviceDAL.Removeadvice(oadvice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeadvice(int advice_id)
		{
			try
			{
				return adviceDAL.Removeadvice(advice_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Advice> Deserializeadvices(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Advice>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeadvices(string Path, List<Advice> advices)
		{
			try
			{
				GenericXmlSerializer<List<Advice>>.Serialize(advices, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AdviceAddFromDr(Advice advice)
        {
            try
            {
                return adviceDAL.AdviceAddFromDr(advice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    
    
    
    }



}
