using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PurchaseBLL
	{
		private PurchaseDAL _purchaseDAL;

		public PurchaseDAL purchaseDAL
		{
			get { return _purchaseDAL; }
			set { _purchaseDAL = value; }
		}

		public PurchaseBLL()
		{
			purchaseDAL = new PurchaseDAL();
		}
		public List<Purchase> GetpurchasesList()
		{
			try
			{
				return purchaseDAL.GetpurchasesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpurchases()
		{
			try
			{
				return purchaseDAL.Getpurchases();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Purchase Getpurchase(int purchase_id)
		{
			try
			{
				return purchaseDAL.Getpurchase(purchase_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpurchase(Purchase opurchase)
		{
			try
			{
				return purchaseDAL.Addpurchase(opurchase);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AddMultiplepurchase(List<Purchase> lstPurchase)
        {
            try
            {
                return purchaseDAL.AddMultiplepurchase(lstPurchase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


		public int Updatepurchase(Purchase opurchase)
		{
			try
			{
				return purchaseDAL.Updatepurchase(opurchase);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepurchase(Purchase opurchase)
		{
			try
			{
				return purchaseDAL.Removepurchase(opurchase);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepurchase(int purchase_id)
		{
			try
			{
				return purchaseDAL.Removepurchase(purchase_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Purchase> Deserializepurchases(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Purchase>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepurchases(string Path, List<Purchase> purchases)
		{
			try
			{
				GenericXmlSerializer<List<Purchase>>.Serialize(purchases, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
