using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InventoryBLL
	{
		private InventoryDAL _inventoryDAL;

		public InventoryDAL inventoryDAL
		{
			get { return _inventoryDAL; }
			set { _inventoryDAL = value; }
		}

		public InventoryBLL()
		{
			inventoryDAL = new InventoryDAL();
		}
		public List<InventoryBO> GetinventorysList()
		{
			try
			{
				return inventoryDAL.GetinventorysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public void inventorytest(List<InventoryBO> lstInventoryBO)
        {
            try
            {
                inventoryDAL.inventorytest(lstInventoryBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public DataSet Getinventorys()
		{
			try
			{
				return inventoryDAL.Getinventorys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet FirstInventory()
        {
            try
            {
                return inventoryDAL.FirstInventory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet InventorywithoutBarcode(int productcategoryID,int storeID)
        {
            try
            {
                return inventoryDAL.InventorywithoutBarcode(productcategoryID, storeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InventorywithoutBarcode1(int productcategoryID,int storeID)
        {
            try
            {
                return inventoryDAL.InventorywithoutBarcode1(productcategoryID, storeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetInventory(int producttypeID)
        {
            try
            {
                return inventoryDAL.GetInventory(producttypeID);
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
                return inventoryDAL.CategoryforInventory(producttypeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PopulateReorderLevel(int productCategpryID)
        {
            try
            {
                return inventoryDAL.PopulateReorderLevel(productCategpryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetInventoryafterRealization(int productCategpryID)
        {
            try
            {
                return inventoryDAL.GetInventoryafterRealization(productCategpryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetProductType()
        {
            try
            {
                return inventoryDAL.GetProductType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
		public InventoryBO Getinventory(int inventory_id)
		{
			try
			{
				return inventoryDAL.Getinventory(inventory_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        //public void AddinventorySave(List<InventoryBO> lstInventoryBO, List<ProductBO> lstProductBO, List<ReceiveProduct> lstReceiveProduct, List<RefundFaulty> lstRefundFaulty, List<SalesProduct> lstSalesProduct, List<sales_refund> lstsales_refund, List<RequisitionProduct> lstRequisitionProduct, List<RequisitonRefund> lstRequisitonRefund)
        //{
        //    try
        //    {
        //        inventoryDAL.AddinventorySave(lstInventoryBO, lstProductBO, lstReceiveProduct, lstRefundFaulty, lstSalesProduct, lstsales_refund, lstRequisitionProduct, lstRequisitonRefund);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void AddinventorySave(List<InventoryBO> lstInventoryBO)
        {
            try
            {
                inventoryDAL.AddinventorySave(lstInventoryBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddOpenningBalance(InventoryBO oinventory)
        {
            try
            {
                return inventoryDAL.AddOpenningBalance(oinventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateOpenningBalance(InventoryBO oinventory)
        {
            try
            {
                return inventoryDAL.UpdateOpenningBalance(oinventory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updateinventory(InventoryBO oinventory)
		{
			try
			{
				return inventoryDAL.Updateinventory(oinventory);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        //public void UpdateRealizationforInventory(List<InventoryRealization> lstInventoryRealization)
        //{
        //    try
        //    {
        //        inventoryDAL.UpdateRealizationforInventory(lstInventoryRealization);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public void SecondUpdateRealization(List<InventoryBO> lstInventoryBO)
        //{
        //    try
        //    {
        //        inventoryDAL.SecondUpdateRealization(lstInventoryBO);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
		public int Removeinventory(InventoryBO oinventory)
		{
			try
			{
				return inventoryDAL.Removeinventory(oinventory);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinventory(int inventory_id)
		{
			try
			{
				return inventoryDAL.Removeinventory(inventory_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<InventoryBO> Deserializeinventorys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<InventoryBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeinventorys(string Path, List<InventoryBO> inventorys)
		{
			try
			{
				GenericXmlSerializer<List<InventoryBO>>.Serialize(inventorys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
