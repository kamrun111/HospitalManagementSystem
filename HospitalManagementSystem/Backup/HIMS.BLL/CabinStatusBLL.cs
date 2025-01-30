using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class CabinStatusBLL
	{
		private CabinStatusDAL _cabin_statusDAL;

		public CabinStatusDAL cabin_statusDAL
		{
			get { return _cabin_statusDAL; }
			set { _cabin_statusDAL = value; }
		}

		public CabinStatusBLL()
		{
			cabin_statusDAL = new CabinStatusDAL();
		}
		public List<CabinStatus> Getcabin_statussList()
		{
			try
			{
				return cabin_statusDAL.Getcabin_statussList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getcabin_statuss()
		{
			try
			{
				return cabin_statusDAL.Getcabin_statuss();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public CabinStatus Getcabin_status(int cabin_status_id)
		{
			try
			{
				return cabin_statusDAL.Getcabin_status(cabin_status_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addcabin_status(CabinStatus ocabin_status)
		{
			try
			{
				return cabin_statusDAL.Addcabin_status(ocabin_status);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin_status(CabinStatus ocabin_status)
		{
			try
			{
				return cabin_statusDAL.Updatecabin_status(ocabin_status);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_status(CabinStatus ocabin_status)
		{
			try
			{
				return cabin_statusDAL.Removecabin_status(ocabin_status);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_status(int cabin_status_id)
		{
			try
			{
				return cabin_statusDAL.Removecabin_status(cabin_status_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<CabinStatus> Deserializecabin_statuss(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<CabinStatus>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializecabin_statuss(string Path, List<CabinStatus> cabin_statuss)
		{
			try
			{
				GenericXmlSerializer<List<CabinStatus>>.Serialize(cabin_statuss, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
