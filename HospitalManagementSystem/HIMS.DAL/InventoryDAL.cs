using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
	public class InventoryDAL
	{
		public InventoryDAL()
		{
		}
		public List<InventoryBO> GetinventorysList()
		{
			SqlConnection conn = null;
			List<InventoryBO> lstinventorys = new List<InventoryBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "inventoryGetAll", null, ref conn);
				while (dataReader.Read())
				{
					InventoryBO oinventory = new InventoryBO();
					oinventory.inventory_id = Convert.ToInt32(dataReader["inventory_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						oinventory.product_id = Convert.ToInt32(dataReader["product_id"]);

                    if (dataReader["product_type_id"] != DBNull.Value)
                        oinventory.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["openning_balance"] != DBNull.Value)
						oinventory.openning_balance = Convert.ToInt32(dataReader["openning_balance"]);

					if(dataReader["closing_balance"] != DBNull.Value)
						oinventory.closing_balance = Convert.ToInt32(dataReader["closing_balance"]);

					if(dataReader["closing_date"] != DBNull.Value)
						oinventory.closing_date = Convert.ToDateTime(dataReader["closing_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinventory.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinventory.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinventory.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinventory.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinventorys.Add(oinventory);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return lstinventorys;
		}

        public void inventorytest(List<InventoryBO> lstInventoryBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                foreach (InventoryBO element in lstInventoryBO)
                {
                    arParams[0] = new SqlParameter("@unit_purchase_price", element.unit_purchase_price);
                    arParams[1] = new SqlParameter("@productID", element.product_id);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "inventorytest", arParams);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
        }
		public DataSet Getinventorys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "inventoryGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet FirstInventory()
        {
            try
            {
                
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "FirstInventory");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet InventorywithoutBarcode(int productcategoryID, int storeID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@product_categoryID", productcategoryID);
                arParams[1] = new SqlParameter("@store_id", storeID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InventorywithoutBarcode", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet InventorywithoutBarcode1(int productcategoryID,int storeID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@product_categoryID", productcategoryID);
                arParams[1] = new SqlParameter("@store_id", storeID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InventorywithoutBarcode1", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetInventory(int producttypeID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_typeID", producttypeID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetInventory", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet CategoryforInventory(int producttypeID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@productTypeID", producttypeID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "CategoryforInventory", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet PopulateReorderLevel(int productCategpryID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_category_id", productCategpryID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PopulateReorderLevel", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetInventoryafterRealization(int productCategpryID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_category_id", productCategpryID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetInventoryafterRealization", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetProductType()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetProductType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public InventoryBO Getinventory(int inventory_id)
		{
			SqlConnection conn = null;
			InventoryBO oinventory = new InventoryBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@inventory_id", inventory_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "inventoryGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinventory.inventory_id = Convert.ToInt32(dataReader["inventory_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						oinventory.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["openning_balance"] != DBNull.Value)
						oinventory.openning_balance = Convert.ToInt32(dataReader["openning_balance"]);

					if(dataReader["closing_balance"] != DBNull.Value)
						oinventory.closing_balance = Convert.ToInt32(dataReader["closing_balance"]);

					if(dataReader["closing_date"] != DBNull.Value)
						oinventory.closing_date = Convert.ToDateTime(dataReader["closing_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinventory.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinventory.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinventory.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinventory.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return oinventory;
		}
        //public void AddinventorySave(List<InventoryBO> lstInventoryBO, 
        //    List<ProductBO> lstProductBO, 
        //    List<ReceiveProduct> lstReceiveProduct, 
        //    List<RefundFaulty> lstRefundFaulty, 
        //    List<SalesProduct> lstSalesProduct, 
        //    List<sales_refund> lstsales_refund,
        //    List<RequisitionProduct> lstRequisitionProduct,
        //    List<RequisitonRefund> lstRequisitonRefund)
        //{
        //    SqlConnection conn = DbHelper.GetOpenConnection();
        //    SqlTransaction trans = conn.BeginTransaction();
        //    try
        //    {
        //        Addinventory(trans,lstInventoryBO);
        //        UpdateCurrentStock(trans, lstProductBO);
        //        UpdateReceiveStoreID(trans,lstReceiveProduct);
        //        UpdateRefundFaultyStoreID(trans,lstRefundFaulty);
        //        UpdateSalesProductStoreID(trans, lstSalesProduct);
        //        UpdateSalesRefundStoreID(trans, lstsales_refund);
        //        UpdateRequsitionProductStoreID(trans, lstRequisitionProduct);
        //        UpdateRequsitionRefundStoreID(trans, lstRequisitonRefund);
        //        trans.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        trans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        public void AddinventorySave(List<InventoryBO> lstInventoryBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                Addinventory(trans, lstInventoryBO);
                //UpdateCurrentStock(trans, lstProductBO);
                //UpdateReceiveStoreID(trans, lstReceiveProduct);
                //UpdateRefundFaultyStoreID(trans, lstRefundFaulty);
                //UpdateSalesProductStoreID(trans, lstSalesProduct);
                //UpdateSalesRefundStoreID(trans, lstsales_refund);
                //UpdateRequsitionProductStoreID(trans, lstRequisitionProduct);
                //UpdateRequsitionRefundStoreID(trans, lstRequisitonRefund);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Addinventory(SqlTransaction trans, List<InventoryBO> lstInventoryBO)
		{
			SqlParameter[] arParams = new SqlParameter[20];
			try 
			{
                foreach(InventoryBO element in lstInventoryBO)
                {
				    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@product_type_id", element.product_type_id);
                    arParams[2] = new SqlParameter("@product_category_id", element.product_category_id);
                    //arParams[3] = new SqlParameter("@barcode", oinventory.barcode);
				    arParams[3] = new SqlParameter("@openning_balance", element.openning_balance);
                    arParams[4] = new SqlParameter("@total_purchased", element.total_purchased);
                    arParams[5] = new SqlParameter("@purchase_refund", element.purchase_refund);
                    arParams[6] = new SqlParameter("@refund_qty", element.refund_qty);
                    arParams[7] = new SqlParameter("@total_sold", element.total_sold);
                    arParams[8] = new SqlParameter("@total_requisition_delivery", element.total_requisition_delivery);
                    arParams[9] = new SqlParameter("@requisition_refund", element.requisition_refund);
                    arParams[10] = new SqlParameter("@stock_in_hand", element.stock_in_hand);
                    arParams[11] = new SqlParameter("@faulty_qty", element.faulty_qty);
				    arParams[12] = new SqlParameter("@closing_balance", element.closing_balance);
                    arParams[13] = new SqlParameter("@realization", element.realization);
                    arParams[14] = new SqlParameter("@opening_date", element.opening_date);
				    arParams[15] = new SqlParameter("@closing_date", element.closing_date);
                    arParams[16] = new SqlParameter("@unit_purchase_price", element.unit_purchase_price);
                    arParams[17] = new SqlParameter("@store_id", element.store_id);
                    arParams[18] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[19] = new SqlParameter("@record_modified_by", element.record_modified_by);
                   
				    SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "inventoryAdd", arParams);
                }
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void UpdateCurrentStock(SqlTransaction trans, List<ProductBO> lstProductBO)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (ProductBO element in lstProductBO)
                {
                    arParams[0] = new SqlParameter("@current_stock", element.current_stock);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@product_id", element.product_id);
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "UpdateCurrentStock", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateReceiveStoreID(SqlTransaction trans, List<ReceiveProduct> lstReceiveProduct)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (ReceiveProduct element in lstReceiveProduct)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@store_id", element.store_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "UpdateReceiveStoreID", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateRefundFaultyStoreID(SqlTransaction trans, List<RefundFaulty> lstRefundFaulty)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (RefundFaulty element in lstRefundFaulty)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@store_id", element.store_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "UpdateRefundFaultyStoreID", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateSalesProductStoreID(SqlTransaction trans, List<SalesProduct> lstSalesProduct)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (SalesProduct element in lstSalesProduct)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@store_id", element.store_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "UpdateSalesProductStoreID", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateSalesRefundStoreID(SqlTransaction trans, List<sales_refund> lstsales_refund)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (sales_refund element in lstsales_refund)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@store_id", element.store_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "UpdateSalesRefundStoreID", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateRequsitionProductStoreID(SqlTransaction trans, List<RequisitionProduct> lstRequisitionProduct)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (RequisitionProduct element in lstRequisitionProduct)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@store_id", element.store_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "UpdateRequsitionProductStoreID", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddOpenningBalance(InventoryBO oinventory)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                
                //arParams[0] = new SqlParameter("@barcode", oinventory.barcode);
                arParams[0] = new SqlParameter("@product_id", oinventory.product_id);
                arParams[1] = new SqlParameter("@product_type_id", oinventory.product_type_id);
                arParams[2] = new SqlParameter("@product_category_id", oinventory.product_category_id);
                arParams[3] = new SqlParameter("@openning_balance", oinventory.openning_balance);
                //arParams[4] = new SqlParameter("@closing_balance", oinventory.closing_balance);
                arParams[4] = new SqlParameter("@record_created_by", oinventory.record_created_by);
                arParams[5] = new SqlParameter("@record_modified_by", oinventory.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOpenningBalance", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateOpenningBalance(InventoryBO oinventory)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@barcode", oinventory.barcode);
                arParams[1] = new SqlParameter("@openning_balance", oinventory.openning_balance);
                arParams[2] = new SqlParameter("@record_modified_by", oinventory.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateOpenningBalance", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updateinventory(InventoryBO oinventory)
		{

			SqlParameter[] arParams = new SqlParameter[17];
			try
			{
                arParams[0] = new SqlParameter("@product_id", oinventory.product_id);
                arParams[1] = new SqlParameter("@barcode", oinventory.barcode);
                arParams[2] = new SqlParameter("@openning_balance", oinventory.openning_balance);
                arParams[3] = new SqlParameter("@total_purchased", oinventory.total_purchased);
                arParams[4] = new SqlParameter("@refund_qty", oinventory.refund_qty);
                arParams[5] = new SqlParameter("@total_sold", oinventory.total_sold);
                arParams[6] = new SqlParameter("@stock_in_hand", oinventory.stock_in_hand);
                arParams[7] = new SqlParameter("@faulty_qty", oinventory.faulty_qty);
                arParams[8] = new SqlParameter("@closing_balance", oinventory.closing_balance);
                arParams[9] = new SqlParameter("@realization", oinventory.realization);
                arParams[10] = new SqlParameter("@opening_date", oinventory.opening_date);
                arParams[11] = new SqlParameter("@closing_date", oinventory.closing_date);
				arParams[12] = new SqlParameter("@record_created_date", oinventory.record_created_date);
				arParams[13] = new SqlParameter("@record_created_by", oinventory.record_created_by);
				arParams[14] = new SqlParameter("@record_modified_date", oinventory.record_modified_date);
				arParams[15] = new SqlParameter("@record_modified_by", oinventory.record_modified_by);
				arParams[16] = new SqlParameter("@inventory_id", oinventory.inventory_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Removeinventory(InventoryBO oinventory)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@inventory_id", oinventory.inventory_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@inventory_id", inventory_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
