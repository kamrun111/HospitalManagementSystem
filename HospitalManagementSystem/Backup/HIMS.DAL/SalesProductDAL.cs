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
	public class SalesProductDAL
	{
		public SalesProductDAL()
		{
		}
        public List<SalesProduct> Getsales_productsList()
        {
            SqlConnection conn = null;
            List<SalesProduct> lstsales_products = new List<SalesProduct>();
            try
            {
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "sales_productGetAll", null, ref conn);
                while (dataReader.Read())
                {
                    SalesProduct osales_product = new SalesProduct();
                    osales_product.sales_product_id = Convert.ToInt32(dataReader["sales_product_id"]);

                    if (dataReader["sales_id"] != DBNull.Value)
                        osales_product.sales_id = Convert.ToInt32(dataReader["sales_id"]);

                    if (dataReader["receive_id"] != DBNull.Value)
                        osales_product.receive_id = Convert.ToInt32(dataReader["receive_id"]);

                    if (dataReader["product_id"] != DBNull.Value)
                        osales_product.product_id = Convert.ToInt32(dataReader["product_id"]);

                    if (dataReader["barcode"] != DBNull.Value)
                        osales_product.barcode = Convert.ToString(dataReader["barcode"]);

                    if (dataReader["sales_qty"] != DBNull.Value)
                        osales_product.sales_qty = Convert.ToInt32(dataReader["sales_qty"]);

                    if (dataReader["refund_qty"] != DBNull.Value)
                        osales_product.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

                    if (dataReader["unit_price"] != DBNull.Value)
                        osales_product.unit_price = Convert.ToDecimal(dataReader["unit_price"]);

                    if (dataReader["total_price"] != DBNull.Value)
                        osales_product.total_price = Convert.ToDecimal(dataReader["total_price"]);

                    if (dataReader["store_id"] != DBNull.Value)
                        osales_product.store_id = Convert.ToInt32(dataReader["store_id"]);

                    if (dataReader["record_created_date"] != DBNull.Value)
                        osales_product.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

                    if (dataReader["record_created_by"] != DBNull.Value)
                        osales_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    if (dataReader["record_modified_date"] != DBNull.Value)
                        osales_product.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

                    if (dataReader["record_modified_by"] != DBNull.Value)
                        osales_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
                    lstsales_products.Add(osales_product);
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
            return lstsales_products;
        }
        public DataSet Getsales_products()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "sales_productGetAll");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetRefundInvNo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetRefundInvNo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public SalesProduct Getsales_product(int sales_product_id)
        {
            SqlConnection conn = null;
            SalesProduct osales_product = new SalesProduct();
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@sales_product_id", sales_product_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "sales_productGet", arParams, ref conn);
                while (dataReader.Read())
                {
                    osales_product.sales_product_id = Convert.ToInt32(dataReader["sales_product_id"]);

                    if (dataReader["sales_id"] != DBNull.Value)
                        osales_product.sales_id = Convert.ToInt32(dataReader["sales_id"]);

                    if (dataReader["receive_id"] != DBNull.Value)
                        osales_product.receive_id = Convert.ToInt32(dataReader["receive_id"]);

                    if (dataReader["product_id"] != DBNull.Value)
                        osales_product.product_id = Convert.ToInt32(dataReader["product_id"]);

                    if (dataReader["barcode"] != DBNull.Value)
                        osales_product.barcode = Convert.ToString(dataReader["barcode"]);

                    if (dataReader["sales_qty"] != DBNull.Value)
                        osales_product.sales_qty = Convert.ToInt32(dataReader["sales_qty"]);

                    if (dataReader["refund_qty"] != DBNull.Value)
                        osales_product.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

                    if (dataReader["unit_price"] != DBNull.Value)
                        osales_product.unit_price = Convert.ToDecimal(dataReader["unit_price"]);

                    if (dataReader["total_price"] != DBNull.Value)
                        osales_product.total_price = Convert.ToDecimal(dataReader["total_price"]);

                    if (dataReader["store_id"] != DBNull.Value)
                        osales_product.store_id = Convert.ToInt32(dataReader["store_id"]);

                    if (dataReader["record_created_date"] != DBNull.Value)
                        osales_product.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

                    if (dataReader["record_created_by"] != DBNull.Value)
                        osales_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    if (dataReader["record_modified_date"] != DBNull.Value)
                        osales_product.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

                    if (dataReader["record_modified_by"] != DBNull.Value)
                        osales_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return osales_product;

        }

        public DataSet GetSalesRefund(string InvoiceNO, int flag)//sami 2 Nov
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@invoiceNo", InvoiceNO);
                arParams[1] = new SqlParameter("@flag", flag);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSalesRefund", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int Addsales_product(SalesProduct osales_product)
        {
            SqlParameter[] arParams = new SqlParameter[11];
            try
            {
                arParams[0] = new SqlParameter("@sales_id", osales_product.sales_id);
                arParams[1] = new SqlParameter("@receive_id", osales_product.receive_id);
                arParams[2] = new SqlParameter("@product_id", osales_product.product_id);
                arParams[3] = new SqlParameter("@barcode", osales_product.barcode);
                arParams[4] = new SqlParameter("@sales_qty", osales_product.sales_qty);
                arParams[5] = new SqlParameter("@refund_qty", osales_product.refund_qty);
                arParams[6] = new SqlParameter("@unit_price", osales_product.unit_price);
                arParams[7] = new SqlParameter("@total_price", osales_product.total_price);
                arParams[8] = new SqlParameter("@store_id", osales_product.store_id);
                arParams[9] = new SqlParameter("@record_created_by", osales_product.record_created_by);
                arParams[10] = new SqlParameter("@record_modified_by", osales_product.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "sales_productAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateSalesProductStoreID(SalesProduct osales_product)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@product_id", osales_product.product_id);
                arParams[1] = new SqlParameter("@store_id", osales_product.store_id);
                arParams[2] = new SqlParameter("@record_modified_by", osales_product.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateSalesProductStoreID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SalesRefundADD(SalesProduct osales_product, ProductBO oproduct)//sami
        {

            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                
                arParams[0] = new SqlParameter("@refund_qty", osales_product.refund_qty);
                arParams[1] = new SqlParameter("@is_refund", osales_product.is_refund);
                arParams[2] = new SqlParameter("@record_modified_by", osales_product.record_modified_by);
                arParams[3] = new SqlParameter("@sales_product_id", osales_product.sales_product_id);
                arParams[4] = new SqlParameter("@product_id", oproduct.product_id);
                arParams[5] = new SqlParameter("@current_stock", oproduct.current_stock);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SalesRefundADD", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Updatesales_product(SalesProduct osales_product)//sami
        {

            SqlParameter[] arParams = new SqlParameter[8];
            try
            {
                arParams[0] = new SqlParameter("@sales_id", osales_product.sales_id);
                arParams[1] = new SqlParameter("@receive_id", osales_product.receive_id);
                arParams[2] = new SqlParameter("@refund_qty", osales_product.refund_qty);
                arParams[3] = new SqlParameter("@total_price", osales_product.total_price);
                arParams[4] = new SqlParameter("@store_id", osales_product.store_id);
                arParams[5] = new SqlParameter("@record_created_by", osales_product.record_created_by);
                arParams[6] = new SqlParameter("@record_modified_by", osales_product.record_modified_by);
                arParams[7] = new SqlParameter("@sales_product_id", osales_product.sales_product_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "sales_productUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Removesales_product(SalesProduct osales_product)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@sales_product_id", osales_product.sales_product_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "sales_productDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Removesales_product(int sales_product_id)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@sales_product_id", sales_product_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "sales_productDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
