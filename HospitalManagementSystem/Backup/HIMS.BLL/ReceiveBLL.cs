using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReceiveBLL
	{
		private ReceiveDAL _receiveDAL;

		public ReceiveDAL receiveDAL
		{
			get { return _receiveDAL; }
			set { _receiveDAL = value; }
		}

		public ReceiveBLL()
		{
			receiveDAL = new ReceiveDAL();
		}
		public List<Receive> GetreceivesList()
		{
			try
			{
				return receiveDAL.GetreceivesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getreceives()
		{
			try
			{
				return receiveDAL.Getreceives();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Receive Getreceive(int receive_id)
		{
			try
			{
				return receiveDAL.Getreceive(receive_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addreceive(Receive oreceive)
		{
			try
			{
				return receiveDAL.Addreceive(oreceive);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatereceive(Receive oreceive)
		{
			try
			{
				return receiveDAL.Updatereceive(oreceive);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(Receive oreceive)
		{
			try
			{
				return receiveDAL.Removereceive(oreceive);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(int receive_id)
		{
			try
			{
				return receiveDAL.Removereceive(receive_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Receive> Deserializereceives(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Receive>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializereceives(string Path, List<Receive> receives)
		{
			try
			{
				GenericXmlSerializer<List<Receive>>.Serialize(receives, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
