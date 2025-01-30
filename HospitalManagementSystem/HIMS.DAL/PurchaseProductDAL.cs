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
	public class PurchaseProductDAL
	{
		public PurchaseProductDAL()
		{
		}
		public List<PurchaseProduct> Getpurchase_productsList()
		{
			SqlConnection conn = null;
			List<PurchaseProduct> lstpurchase_products = new List<PurchaseProduct>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "purchase_productGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PurchaseProduct opurchase_product = new PurchaseProduct();
					opurchase_product.purchase_product_id = Convert.ToInt32(dataReader["purchase_product_id"]);

					if(dataReader["purchase_id"] != DBNull.Value)
						opurchase_product.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						opurchase_product.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["order_qty"] != DBNull.Value)
						opurchase_product.order_qty = Convert.ToInt32(dataReader["order_qty"]);

					if(dataReader["total_received_qty"] != DBNull.Value)
						opurchase_product.total_received_qty = Convert.ToInt32(dataReader["total_received_qty"]);

					if(dataReader["store_id"] != DBNull.Value)
						opurchase_product.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opurchase_product.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opurchase_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opurchase_product.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opurchase_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpurchase_products.Add(opurchase_product);
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
			return lstpurchase_products;
		}
		public DataSet Getpurchase_products()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "purchase_productGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PurchaseProduct Getpurchase_product(int purchase_product_id)
		{
			SqlConnection conn = null;
			PurchaseProduct opurchase_product = new PurchaseProduct();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@purchase_product_id", purchase_product_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "purchase_productGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opurchase_product.purchase_product_id = Convert.ToInt32(dataReader["purchase_product_id"]);

					if(dataReader["purchase_id"] != DBNull.Value)
						opurchase_product.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						opurchase_product.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["order_qty"] != DBNull.Value)
						opurchase_product.order_qty = Convert.ToInt32(dataReader["order_qty"]);

					if(dataReader["total_received_qty"] != DBNull.Value)
						opurchase_product.total_received_qty = Convert.ToInt32(dataReader["total_received_qty"]);

					if(dataReader["store_id"] != DBNull.Value)
						opurchase_product.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opurchase_product.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opurchase_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opurchase_product.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opurchase_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opurchase_product;
		}
		public int Addpurchase_product(PurchaseProduct opurchase_product)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@purchase_id", opurchase_product.purchase_id);
				arParams[1] = new SqlParameter("@product_id", opurchase_product.product_id);
				arParams[2] = new SqlParameter("@order_qty", opurchase_product.order_qty);
				arParams[3] = new SqlParameter("@total_received_qty", opurchase_product.total_received_qty);
				arParams[4] = new SqlParameter("@store_id", opurchase_product.store_id);
				arParams[5] = new SqlParameter("@record_created_by", opurchase_product.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", opurchase_product.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchase_productAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepurchase_product(PurchaseProduct opurchase_product)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@purchase_id", opurchase_product.purchase_id);
				arParams[1] = new SqlParameter("@product_id", opurchase_product.product_id);
				arParams[2] = new SqlParameter("@order_qty", opurchase_product.order_qty);
				arParams[3] = new SqlParameter("@total_received_qty", opurchase_product.total_received_qty);
				arParams[4] = new SqlParameter("@store_id", opurchase_product.store_id);
				arParams[5] = new SqlParameter("@record_created_by", opurchase_product.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", opurchase_product.record_modified_by);
				arParams[7] = new SqlParameter("@purchase_product_id", opurchase_product.purchase_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchase_productUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@purchase_product_id", opurchase_product.purchase_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchase_productDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@purchase_product_id", purchase_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchase_productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
