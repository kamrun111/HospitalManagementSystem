using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class SalesBLL
	{
		private SalesDAL _salesDAL;

		public SalesDAL salesDAL
		{
			get { return _salesDAL; }
			set { _salesDAL = value; }
		}

		public SalesBLL()
		{
			salesDAL = new SalesDAL();
		}
		public List<Sales> GetsalessList()
		{
			try
			{
				return salesDAL.GetsalessList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getsaless()
		{
			try
			{
				return salesDAL.Getsaless();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Sales Getsales(int sales_id)
		{
			try
			{
				return salesDAL.Getsales(sales_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addsales(Sales osales)
		{
			try
			{
				return salesDAL.Addsales(osales);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatesales(Sales osales)
		{
			try
			{
				return salesDAL.Updatesales(osales);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removesales(Sales osales)
		{
			try
			{
				return salesDAL.Removesales(osales);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removesales(int sales_id)
		{
			try
			{
				return salesDAL.Removesales(sales_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Sales> Deserializesaless(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Sales>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializesaless(string Path, List<Sales> saless)
		{
			try
			{
				GenericXmlSerializer<List<Sales>>.Serialize(saless, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
