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
	public class ReceiveDAL
	{
		public ReceiveDAL()
		{
		}
		public List<ReceiveBO> GetreceivesList()
		{
			SqlConnection conn = null;
			List<ReceiveBO> lstreceives = new List<ReceiveBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "receiveGetAll", null, ref conn);
				while (dataReader.Read())
				{
					ReceiveBO oreceive = new ReceiveBO();
					oreceive.receive_id = Convert.ToInt32(dataReader["receive_id"]);

                    //if(dataReader["barcode"] != DBNull.Value)
                    //    oreceive.barcode = Convert.ToString(dataReader["barcode"]);

					if(dataReader["purchase_id"] != DBNull.Value)
						oreceive.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["invoice_no"] != DBNull.Value)
						oreceive.invoice_no = Convert.ToString(dataReader["invoice_no"]);

					if(dataReader["invoice_date"] != DBNull.Value)
						oreceive.invoice_date = Convert.ToDateTime(dataReader["invoice_date"]);

					if(dataReader["received_date"] != DBNull.Value)
						oreceive.received_date = Convert.ToDateTime(dataReader["received_date"]);

					if(dataReader["store_id"] != DBNull.Value)
						oreceive.store_id = Convert.ToInt32(dataReader["store_id"]);

                    //if(dataReader["record_created_date"] != DBNull.Value)
                    //    oreceive.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreceive.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    //if(dataReader["record_modified_date"] != DBNull.Value)
                    //    oreceive.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreceive.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstreceives.Add(oreceive);
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
			return lstreceives;
		}
		public DataSet Getreceives()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "receiveGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public ReceiveBO Getreceive(int receive_id)
		{
			SqlConnection conn = null;
			ReceiveBO oreceive = new ReceiveBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_id", receive_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "receiveGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oreceive.receive_id = Convert.ToInt32(dataReader["receive_id"]);

                    //if(dataReader["barcode"] != DBNull.Value)
                    //    oreceive.barcode = Convert.ToString(dataReader["barcode"]);

					if(dataReader["purchase_id"] != DBNull.Value)
						oreceive.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["invoice_no"] != DBNull.Value)
						oreceive.invoice_no = Convert.ToString(dataReader["invoice_no"]);

					if(dataReader["invoice_date"] != DBNull.Value)
						oreceive.invoice_date = Convert.ToDateTime(dataReader["invoice_date"]);

					if(dataReader["received_date"] != DBNull.Value)
						oreceive.received_date = Convert.ToDateTime(dataReader["received_date"]);

					if(dataReader["store_id"] != DBNull.Value)
						oreceive.store_id = Convert.ToInt32(dataReader["store_id"]);

                    //if(dataReader["record_created_date"] != DBNull.Value)
                    //    oreceive.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreceive.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    //if(dataReader["record_modified_date"] != DBNull.Value)
                    //    oreceive.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreceive.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oreceive;
		}

        public DataSet GetPurchasePopulationInfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPurchasePopulationInfo");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int Addreceive(SqlTransaction trans,ReceiveBO oreceive)
        {
            SqlParameter[] arParams = new SqlParameter[8];
            //SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@purchase_id", oreceive.purchase_id);
                arParams[1] = new SqlParameter("@invoice_no", oreceive.invoice_no);
                arParams[2] = new SqlParameter("@invoice_date", oreceive.invoice_date);
                arParams[3] = new SqlParameter("@received_date", oreceive.received_date);
                arParams[4] = new SqlParameter("@store_id", oreceive.store_id);
                arParams[5] = new SqlParameter("@record_created_by", oreceive.record_created_by);
                arParams[6] = new SqlParameter("@record_modified_by", oreceive.record_modified_by);
                arParams[7] = new SqlParameter("@receive_id", oreceive.receive_id);
                arParams[7].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "receiveAdd", arParams);
                result = Convert.ToInt32(arParams[7].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
		
        
        public int Updatereceive(ReceiveBO oreceive)
		{
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				
				arParams[0] = new SqlParameter("@purchase_id", oreceive.purchase_id);
				arParams[1] = new SqlParameter("@invoice_no", oreceive.invoice_no);
				arParams[2] = new SqlParameter("@invoice_date", oreceive.invoice_date);
				arParams[3] = new SqlParameter("@received_date", oreceive.received_date);
				arParams[4] = new SqlParameter("@store_id", oreceive.store_id);
				arParams[5] = new SqlParameter("@record_created_by", oreceive.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", oreceive.record_modified_by);
				arParams[7] = new SqlParameter("@receive_id", oreceive.receive_id);
				
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(ReceiveBO oreceive)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_id", oreceive.receive_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_id", receive_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int ReceiveProductInsert
        (
            ReceiveBO receiveBO, 
            List<ReceiveProduct> lstReceiveProduct,
            List<PurchaseProduct> lstPurchaseProduct,
            List<InventoryBO> lstInventoryBO,
            List<ProductBO> lstProductBO
         )
         {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int receiveID = 0;

            try
            {
                receiveID = Addreceive(trans,receiveBO);
                InsertReceiveProductFromList(trans,receiveID,lstReceiveProduct);
                UpdatePurchaseProductFromList(trans, lstPurchaseProduct);
                InsertInventoryFromList(trans, lstInventoryBO);
                UpdateProductFromList(trans,lstProductBO);
                
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                receiveID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return receiveID;
        }
        

        private void InsertReceiveProductFromList(SqlTransaction trans,int receiveID, List<ReceiveProduct> lstReceiveProduct)
        {
            SqlParameter[] arParams = new SqlParameter[11];
             
            try
            {
                foreach (ReceiveProduct element in lstReceiveProduct)
                {
                    arParams[0] = new SqlParameter("@receive_id", receiveID);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@receive_qty", element.receive_qty);
                    arParams[3] = new SqlParameter("@free_qty", element.free_qty);
                    arParams[4] = new SqlParameter("@refund_qty", element.refund_qty);
                    arParams[5] = new SqlParameter("@unit_purchase_price", element.unit_purchase_price);
                    arParams[6] = new SqlParameter("@unit_cost", element.unit_cost);
                    arParams[7] = new SqlParameter("@exp_date", element.exp_date);
                    arParams[8] = new SqlParameter("@batch_no", element.batch_no);
                    arParams[9] = new SqlParameter("@store_id", element.store_id);
                    arParams[10] = new SqlParameter("@record_created_by", element.record_created_by);
                    //arParams[11] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "receiveproductAdd", arParams);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        private void UpdatePurchaseProductFromList(SqlTransaction trans, List<PurchaseProduct> lstPurchaseProduct)
        {
            SqlParameter[] arParams = new SqlParameter[3];

            try
            {
                foreach (PurchaseProduct element in lstPurchaseProduct)
                {
                    arParams[0] = new SqlParameter("@total_received_qty", element.total_received_qty);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@purchase_product_id", element.purchase_product_id);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "PurchaseProductAfterUpdate", arParams);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
         } 
       

        private void InsertInventoryFromList(SqlTransaction trans, List<InventoryBO> lstInventoryBO)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                foreach (InventoryBO element in lstInventoryBO)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@product_type_id", element.product_type_id);
                    arParams[2] = new SqlParameter("@product_category_id", element.product_category_id);
                    arParams[3] = new SqlParameter("@openning_balance", element.openning_balance);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[5] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AddOpenningBalance", arParams);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateProductFromList(SqlTransaction trans, List<ProductBO> lstProductBO)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                foreach (ProductBO element in lstProductBO)
                {
                    arParams[0] = new SqlParameter("@current_stock", element.current_stock);
                    arParams[1] = new SqlParameter("@default_sales_price", element.default_sales_price);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[3] = new SqlParameter("@product_id", element.product_id);
                    arParams[4] = new SqlParameter("@unit_purchase_price", element.unit_purchase_price );

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AdjustCurrentStockwithPrice", arParams);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
	}
}
