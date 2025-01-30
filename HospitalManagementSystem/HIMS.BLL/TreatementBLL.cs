using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class TreatementBLL
	{
		private TreatementDAL _treatementDAL;

		public TreatementDAL treatementDAL
		{
			get { return _treatementDAL; }
			set { _treatementDAL = value; }
		}

		public TreatementBLL()
		{
			treatementDAL = new TreatementDAL();
		}
		public List<Treatement> GettreatementsList()
		{
			try
			{
				return treatementDAL.GettreatementsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Gettreatements()
		{
			try
			{
				return treatementDAL.Gettreatements();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Treatement Gettreatement(int treatement_id)
		{
			try
			{
				return treatementDAL.Gettreatement(treatement_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet  OTDeclare(int TreatmentID)//sami khuku
        {
            try
            {
                return treatementDAL.OTDeclare(TreatmentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Addtreatement(Treatement otreatement)
		{
			try
			{
				return treatementDAL.Addtreatement(otreatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatetreatement(Treatement otreatement)
		{
			try
			{
				return treatementDAL.Updatetreatement(otreatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetreatement(Treatement otreatement)
		{
			try
			{
				return treatementDAL.Removetreatement(otreatement);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetreatement(int treatement_id)
		{
			try
			{
				return treatementDAL.Removetreatement(treatement_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Treatement> Deserializetreatements(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Treatement>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializetreatements(string Path, List<Treatement> treatements)
		{
			try
			{
				GenericXmlSerializer<List<Treatement>>.Serialize(treatements, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
