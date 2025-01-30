using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OccupationBLL
	{
		private OccupationDAL _occupationDAL;

		public OccupationDAL occupationDAL
		{
			get { return _occupationDAL; }
			set { _occupationDAL = value; }
		}

		public OccupationBLL()
		{
			occupationDAL = new OccupationDAL();
		}
		public List<Occupation> GetoccupationsList()
		{
			try
			{
				return occupationDAL.GetoccupationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoccupations()
		{
			try
			{
				return occupationDAL.Getoccupations();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Occupation Getoccupation(int occupation_id)
		{
			try
			{
				return occupationDAL.Getoccupation(occupation_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addoccupation(Occupation ooccupation)
		{
			try
			{
				return occupationDAL.Addoccupation(ooccupation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoccupation(Occupation ooccupation)
		{
			try
			{
				return occupationDAL.Updateoccupation(ooccupation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoccupation(Occupation ooccupation)
		{
			try
			{
				return occupationDAL.Removeoccupation(ooccupation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoccupation(int occupation_id)
		{
			try
			{
				return occupationDAL.Removeoccupation(occupation_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Occupation> Deserializeoccupations(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Occupation>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoccupations(string Path, List<Occupation> occupations)
		{
			try
			{
				GenericXmlSerializer<List<Occupation>>.Serialize(occupations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
