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
		public List<PurchaseBO> GetpurchasesList()
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
        public DataSet GetReviewpurchase()
        {
            try
            {
                return purchaseDAL.GetReviewpurchase();
            }
            catch (Exception ex)
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
        public DataSet PurchaseReview()
        {
            try
            {
                return purchaseDAL.PurchaseReview();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet CategoryforInventory(int producttypeID)
        {
            try
            {
                return purchaseDAL.CategoryforInventory(producttypeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet productforpurchase(int categoryID)
        {
            try
            {
                return purchaseDAL.productforpurchase(categoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet productforReagentpurchase(int categoryID)
        {
            try
            {
                return purchaseDAL.productforReagentpurchase(categoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PurchaseListview(DateTime From, DateTime To)
        {
            try
            {
                return purchaseDAL.PurchaseListview(From,To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReceivedListview(DateTime From, DateTime To)
        {
            try
            {
                return purchaseDAL.ReceivedListview(From, To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetPurchasePopulationInfo()
        {
            try
            {
                return purchaseDAL.GetPurchasePopulationInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PurchaseCancelation(int PurchaseID)
        {
            try
            {
                return purchaseDAL.PurchaseCancelation(PurchaseID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetPurchaseLoad()// sami 22OCT
        {
            try
            {
                return purchaseDAL.GetPurchaseLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSupplierName(int ProductTypeID)
        {
            try
            {
                return purchaseDAL.GetSupplierName(ProductTypeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public PurchaseBO Getpurchase(int purchase_id)
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
        public int purchasecancelationAdd(PurchaseBO opurchase)
        {
            try
            {
                return purchaseDAL.purchasecancelationAdd(opurchase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int Addpurchase(PurchaseBO opurchase,int flag)
        //{
        //    try
        //    {
        //        return purchaseDAL.Addpurchase(opurchase, flag);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int AddMultiplepurchase(List<PurchaseBO> lstPurchase)
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


		public int Updatepurchase(PurchaseBO opurchase)
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
		public int Removepurchase(PurchaseBO opurchase)
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
		public List<PurchaseBO> Deserializepurchases(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PurchaseBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepurchases(string Path, List<PurchaseBO> purchases)
		{
			try
			{
				GenericXmlSerializer<List<PurchaseBO>>.Serialize(purchases, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int PurchaseProductInsert(PurchaseBO purchaseBO, List<PurchaseProduct> lstPurchaseProduct, int flag)
        {
            try
            {
                return purchaseDAL.PurchaseProductInsert(purchaseBO, lstPurchaseProduct, flag);
			}
            catch (Exception ex)
            {
                throw ex;
            }
        }

	}
}
