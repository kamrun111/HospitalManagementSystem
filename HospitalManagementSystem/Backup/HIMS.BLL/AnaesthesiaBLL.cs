using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class AnaesthesiaBLL
	{
		private AnaesthesiaDAL _anaesthesiaDAL;

		public AnaesthesiaDAL anaesthesiaDAL
		{
			get { return _anaesthesiaDAL; }
			set { _anaesthesiaDAL = value; }
		}

		public AnaesthesiaBLL()
		{
			anaesthesiaDAL = new AnaesthesiaDAL();
		}
		public List<Anaesthesia> GetanaesthesiasList()
		{
			try
			{
				return anaesthesiaDAL.GetanaesthesiasList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getanaesthesias()
		{
			try
			{
				return anaesthesiaDAL.Getanaesthesias();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addanaesthesia(Anaesthesia oanaesthesia)
		{
			try
			{
				return anaesthesiaDAL.Addanaesthesia(oanaesthesia);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Anaesthesia> Deserializeanaesthesias(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Anaesthesia>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeanaesthesias(string Path, List<Anaesthesia> anaesthesias)
		{
			try
			{
				GenericXmlSerializer<List<Anaesthesia>>.Serialize(anaesthesias, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
