using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class RefundFaultyBLL
	{
		private RefundFaultyDAL _refund_faultyDAL;

		public RefundFaultyDAL refund_faultyDAL
		{
			get { return _refund_faultyDAL; }
			set { _refund_faultyDAL = value; }
		}

		public RefundFaultyBLL()
		{
			refund_faultyDAL = new RefundFaultyDAL();
		}
		public List<RefundFaulty> Getrefund_faultysList()
		{
			try
			{
				return refund_faultyDAL.Getrefund_faultysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getrefund_faultys()
		{
			try
			{
				return refund_faultyDAL.Getrefund_faultys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public RefundFaulty Getrefund_faulty(int refund_faulty_id)
		{
			try
			{
				return refund_faultyDAL.Getrefund_faulty(refund_faulty_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addrefund_faulty(RefundFaulty orefund_faulty)
		{
			try
			{
				return refund_faultyDAL.Addrefund_faulty(orefund_faulty);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updaterefund_faulty(RefundFaulty orefund_faulty)
		{
			try
			{
				return refund_faultyDAL.Updaterefund_faulty(orefund_faulty);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerefund_faulty(RefundFaulty orefund_faulty)
		{
			try
			{
				return refund_faultyDAL.Removerefund_faulty(orefund_faulty);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerefund_faulty(int refund_faulty_id)
		{
			try
			{
				return refund_faultyDAL.Removerefund_faulty(refund_faulty_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<RefundFaulty> Deserializerefund_faultys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<RefundFaulty>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializerefund_faultys(string Path, List<RefundFaulty> refund_faultys)
		{
			try
			{
				GenericXmlSerializer<List<RefundFaulty>>.Serialize(refund_faultys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
