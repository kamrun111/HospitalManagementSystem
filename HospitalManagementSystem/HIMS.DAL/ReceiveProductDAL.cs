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
	public class ReceiveProductDAL
	{
		public ReceiveProductDAL()
		{
		}
		public List<ReceiveProduct> Getreceive_productsList()
		{
			SqlConnection conn = null;
			List<ReceiveProduct> lstreceive_products = new List<ReceiveProduct>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "receive_productGetAll", null, ref conn);
				while (dataReader.Read())
				{
					ReceiveProduct oreceive_product = new ReceiveProduct();
					oreceive_product.receive_product_id = Convert.ToInt32(dataReader["receive_product_id"]);
					oreceive_product.receive_id = Convert.ToInt32(dataReader["receive_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						oreceive_product.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["receive_qty"] != DBNull.Value)
						oreceive_product.receive_qty = Convert.ToInt32(dataReader["receive_qty"]);

					if(dataReader["free_qty"] != DBNull.Value)
						oreceive_product.free_qty = Convert.ToInt32(dataReader["free_qty"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						oreceive_product.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

					if(dataReader["unit_purchase_price"] != DBNull.Value)
						oreceive_product.unit_purchase_price = Convert.ToDecimal(dataReader["unit_purchase_price"]);

					if(dataReader["unit_cost"] != DBNull.Value)
						oreceive_product.unit_cost = Convert.ToDecimal(dataReader["unit_cost"]);

					if(dataReader["exp_date"] != DBNull.Value)
						oreceive_product.exp_date = Convert.ToDateTime(dataReader["exp_date"]);

					if(dataReader["batch_no"] != DBNull.Value)
						oreceive_product.batch_no = Convert.ToString(dataReader["batch_no"]);

					if(dataReader["store_id"] != DBNull.Value)
						oreceive_product.store_id = Convert.ToInt32(dataReader["store_id"]);

                
					if(dataReader["record_created_by"] != DBNull.Value)
					oreceive_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    
                    if(dataReader["record_modified_by"] != DBNull.Value)
						oreceive_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstreceive_products.Add(oreceive_product);
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
			return lstreceive_products;
		}
		public DataSet Getreceive_products()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "receive_productGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet receive_productGet(int product_typeID,string invoiceno)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];

                arParams[0] = new SqlParameter("@product_typeID", product_typeID);
                arParams[1] = new SqlParameter("@InvoiceNo", invoiceno);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "receive_productGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet ProductSales(int ProductID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@productID", ProductID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ProductSales", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetProductID(string Product)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product", Product);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetProductID",arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetReceiveLoad(int purchaseID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@purchaseID", purchaseID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetReceiveLoad", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetFaultyItem(int Barcode)//sami 28 oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@barcode", Barcode);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetFaultyItem", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public ReceiveProduct Getreceive_product(int receive_product_id)
		{
			SqlConnection conn = null;
			ReceiveProduct oreceive_product = new ReceiveProduct();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_product_id", receive_product_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "receive_productGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oreceive_product.receive_product_id = Convert.ToInt32(dataReader["receive_product_id"]);
					oreceive_product.receive_id = Convert.ToInt32(dataReader["receive_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						oreceive_product.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["receive_qty"] != DBNull.Value)
						oreceive_product.receive_qty = Convert.ToInt32(dataReader["receive_qty"]);

					if(dataReader["free_qty"] != DBNull.Value)
						oreceive_product.free_qty = Convert.ToInt32(dataReader["free_qty"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						oreceive_product.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

					if(dataReader["unit_purchase_price"] != DBNull.Value)
						oreceive_product.unit_purchase_price = Convert.ToDecimal(dataReader["unit_purchase_price"]);

					if(dataReader["unit_cost"] != DBNull.Value)
						oreceive_product.unit_cost = Convert.ToDecimal(dataReader["unit_cost"]);

					if(dataReader["exp_date"] != DBNull.Value)
						oreceive_product.exp_date = Convert.ToDateTime(dataReader["exp_date"]);

					if(dataReader["batch_no"] != DBNull.Value)
						oreceive_product.batch_no = Convert.ToString(dataReader["batch_no"]);

					if(dataReader["store_id"] != DBNull.Value)
						oreceive_product.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreceive_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					
					if(dataReader["record_modified_by"] != DBNull.Value)
						oreceive_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oreceive_product;
		}
        public int receiveproductAdd(ReceiveProduct oreceive_product)
        {
            SqlParameter[] arParams = new SqlParameter[12];
            try
            {
                arParams[0] = new SqlParameter("@receive_id", oreceive_product.receive_id);
                arParams[1] = new SqlParameter("@product_id", oreceive_product.product_id);
                arParams[2] = new SqlParameter("@receive_qty", oreceive_product.receive_qty);
                arParams[3] = new SqlParameter("@free_qty", oreceive_product.free_qty);
                arParams[4] = new SqlParameter("@refund_qty", oreceive_product.refund_qty);
                arParams[5] = new SqlParameter("@unit_purchase_price", oreceive_product.unit_purchase_price);
                arParams[6] = new SqlParameter("@unit_cost", oreceive_product.unit_cost);
                arParams[7] = new SqlParameter("@exp_date", oreceive_product.exp_date);
                arParams[8] = new SqlParameter("@batch_no", oreceive_product.batch_no);
                arParams[9] = new SqlParameter("@store_id", oreceive_product.store_id);
                arParams[10] = new SqlParameter("@record_created_by", oreceive_product.record_created_by);
                arParams[11] = new SqlParameter("@record_modified_by", oreceive_product.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveproductAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public string Addreceive_product(ReceiveProduct oreceive_product)
		{
            string result = "";
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlParameter[] arParams = new SqlParameter[13];            
            try
            {
                arParams[0] = new SqlParameter("@receive_id", oreceive_product.receive_id);
                arParams[1] = new SqlParameter("@product_id", oreceive_product.product_id);
                arParams[2] = new SqlParameter("@receive_qty", oreceive_product.receive_qty);
                arParams[3] = new SqlParameter("@free_qty", oreceive_product.free_qty);
                arParams[4] = new SqlParameter("@refund_qty", oreceive_product.refund_qty);
                arParams[5] = new SqlParameter("@unit_purchase_price", oreceive_product.unit_purchase_price);
                arParams[6] = new SqlParameter("@unit_cost", oreceive_product.unit_cost);
                arParams[7] = new SqlParameter("@exp_date", oreceive_product.exp_date);
                arParams[8] = new SqlParameter("@batch_no", oreceive_product.batch_no);
                arParams[9] = new SqlParameter("@store_id", oreceive_product.store_id);
                arParams[10] = new SqlParameter("@record_created_by", oreceive_product.record_created_by);
                arParams[11] = new SqlParameter("@record_modified_by", oreceive_product.record_modified_by);
                arParams[12] = new SqlParameter("@barcode", SqlDbType.VarChar, 12);
                arParams[12].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "receive_productAdd", arParams);
                result = arParams[12].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                DbHelper.CloseConnection(conn);
            }
            return result;
		}
        public int ReceiveProductAdd(ReceiveBO  oreceive,ReceiveProduct oreceive_product)
		{
			SqlParameter[] arParams = new SqlParameter[17];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
			try
			{
                arParams[0] = new SqlParameter("@barcode", oreceive.barcode);
                arParams[1] = new SqlParameter("@purchase_id", oreceive.purchase_id);
                arParams[2] = new SqlParameter("@invoice_no", oreceive.invoice_no);
                arParams[3] = new SqlParameter("@invoice_date", oreceive.invoice_date);
                arParams[4] = new SqlParameter("@received_date", oreceive.received_date);
                arParams[5] = new SqlParameter("@receive_id", oreceive_product.receive_id);
                arParams[6] = new SqlParameter("@product_id", oreceive_product.product_id);
                arParams[7] = new SqlParameter("@receive_qty", oreceive_product.receive_qty);
				arParams[8] = new SqlParameter("@free_qty", oreceive_product.free_qty);
				arParams[9] = new SqlParameter("@refund_qty", oreceive_product.refund_qty);
				arParams[10] = new SqlParameter("@unit_purchase_price", oreceive_product.unit_purchase_price);
				arParams[11] = new SqlParameter("@unit_cost", oreceive_product.unit_cost);
				arParams[12] = new SqlParameter("@exp_date", oreceive_product.exp_date);
				arParams[13] = new SqlParameter("@batch_no", oreceive_product.batch_no);
				arParams[14] = new SqlParameter("@store_id", oreceive_product.store_id);
				arParams[15] = new SqlParameter("@record_created_by", oreceive_product.record_created_by);
				arParams[16] = new SqlParameter("@record_modified_by", oreceive_product.record_modified_by);

                result=DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ReceiveProductAdd", arParams);
                //result = Convert.ToInt32(arParams[23].Value.ToString());
			}
			catch (Exception ex)
			{
				throw ex;
			}
            return result;
		}
        public int UpdateReceiveStoreID(ReceiveProduct oreceive_product)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@product_id", oreceive_product.product_id);
                arParams[1] = new SqlParameter("@store_id", oreceive_product.store_id);
                arParams[2] = new SqlParameter("@record_modified_by", oreceive_product.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateReceiveStoreID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Updatereceive_product(ReceiveProduct oreceive_product)
		{

			SqlParameter[] arParams = new SqlParameter[15];
			try
			{
				arParams[0] = new SqlParameter("@receive_id", oreceive_product.receive_id);
				arParams[1] = new SqlParameter("@product_id", oreceive_product.product_id);
				arParams[2] = new SqlParameter("@receive_qty", oreceive_product.receive_qty);
				arParams[3] = new SqlParameter("@free_qty", oreceive_product.free_qty);
				arParams[4] = new SqlParameter("@refund_qty", oreceive_product.refund_qty);
				arParams[5] = new SqlParameter("@unit_purchase_price", oreceive_product.unit_purchase_price);
				arParams[6] = new SqlParameter("@unit_cost", oreceive_product.unit_cost);
				arParams[7] = new SqlParameter("@exp_date", oreceive_product.exp_date);
				arParams[8] = new SqlParameter("@batch_no", oreceive_product.batch_no);
				arParams[9] = new SqlParameter("@store_id", oreceive_product.store_id);
				arParams[10] = new SqlParameter("@record_created_date", oreceive_product.record_created_date);
				arParams[11] = new SqlParameter("@record_created_by", oreceive_product.record_created_by);
				arParams[12] = new SqlParameter("@record_modified_date", oreceive_product.record_modified_date);
				arParams[13] = new SqlParameter("@record_modified_by", oreceive_product.record_modified_by);
				arParams[14] = new SqlParameter("@receive_product_id", oreceive_product.receive_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receive_productUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int receive_product_refundUpdate(ReceiveProduct oreceive_product)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@refund_qty", oreceive_product.refund_qty);
                arParams[1] = new SqlParameter("@record_modified_by", oreceive_product.record_modified_by);
                arParams[2] = new SqlParameter("@receive_product_id", oreceive_product.receive_product_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receive_product_refundUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removereceive_product(ReceiveProduct oreceive_product)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_product_id", oreceive_product.receive_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receive_productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive_product(int receive_product_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_product_id", receive_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receive_productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
