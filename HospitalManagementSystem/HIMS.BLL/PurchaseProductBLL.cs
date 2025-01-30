using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PurchaseProductBLL
	{
		private PurchaseProductDAL _purchase_productDAL;

		public PurchaseProductDAL purchase_productDAL
		{
			get { return _purchase_productDAL; }
			set { _purchase_productDAL = value; }
		}

		public PurchaseProductBLL()
		{
			purchase_productDAL = new PurchaseProductDAL();
		}
		public List<PurchaseProduct> Getpurchase_productsList()
		{
			try
			{
				return purchase_productDAL.Getpurchase_productsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpurchase_products()
		{
			try
			{
				return purchase_productDAL.Getpurchase_products();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PurchaseProduct Getpurchase_product(int purchase_product_id)
		{
			try
			{
				return purchase_productDAL.Getpurchase_product(purchase_product_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpurchase_product(PurchaseProduct opurchase_product)
		{
			try
			{
				return purchase_productDAL.Addpurchase_product(opurchase_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepurchase_product(PurchaseProduct opurchase_product)
		{
			try
			{
				return purchase_productDAL.Updatepurchase_product(opurchase_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepurchase_product(PurchaseProduct opurchase_product)
		{
			try
			{
				return purchase_productDAL.Removepurchase_product(opurchase_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepurchase_product(int purchase_product_id)
		{
			try
			{
				return purchase_productDAL.Removepurchase_product(purchase_product_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PurchaseProduct> Deserializepurchase_products(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PurchaseProduct>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepurchase_products(string Path, List<PurchaseProduct> purchase_products)
		{
			try
			{
				GenericXmlSerializer<List<PurchaseProduct>>.Serialize(purchase_products, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
