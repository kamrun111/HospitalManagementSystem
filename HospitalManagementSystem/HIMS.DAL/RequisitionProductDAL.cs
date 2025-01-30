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
	public class RequisitionProductDAL
	{
		public RequisitionProductDAL()
		{
		}
		public List<RequisitionProduct> Getrequisition_productsList()
		{
			SqlConnection conn = null;
			List<RequisitionProduct> lstrequisition_products = new List<RequisitionProduct>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "requisition_productGetAll", null, ref conn);
				while (dataReader.Read())
				{
					RequisitionProduct orequisition_product = new RequisitionProduct();
					orequisition_product.requisition_product_id = Convert.ToInt32(dataReader["requisition_product_id"]);

					if(dataReader["requisition_id"] != DBNull.Value)
						orequisition_product.requisition_id = Convert.ToInt32(dataReader["requisition_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						orequisition_product.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["order_qty"] != DBNull.Value)
						orequisition_product.order_qty = Convert.ToInt32(dataReader["order_qty"]);

                    if (dataReader[" delivery_qty"] != DBNull.Value)
                        orequisition_product.delivery_qty = Convert.ToInt32(dataReader["delivery_qty"]);

					if(dataReader["receive_qty"] != DBNull.Value)
						orequisition_product.receive_qty = Convert.ToInt32(dataReader["receive_qty"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						orequisition_product.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

					if(dataReader["store_id"] != DBNull.Value)
						orequisition_product.store_id = Convert.ToInt32(dataReader["store_id"]);

                    if (dataReader["is_complete"] != DBNull.Value)
                        orequisition_product.is_complete = Convert.ToString(dataReader["is_complete"]);
                    
					if(dataReader["record_created_by"] != DBNull.Value)
						orequisition_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						orequisition_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstrequisition_products.Add(orequisition_product);
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
			return lstrequisition_products;
		}

        public DataSet GetrequisitionproductDelivery()//sami 25 Oct
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetrequisitionproductDelivery");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int requisitionListUpdate(Requisition requisition, List<RequisitionProduct> lstrequisitionProduct, List<ProductBO> lstproductBO)//sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int result = 0;
            try
            {
                result = requisitionProductListUpdate(trans, lstrequisitionProduct);
                requisitiondeliveryListUpdate(trans, requisition);
                UpdateProductList(trans, lstproductBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int requisitionProductListUpdate(SqlTransaction trans, List<RequisitionProduct> lstrequisitionProduct)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            int result = 0;
            try
            {
                foreach (RequisitionProduct element in lstrequisitionProduct)
                {
                    arParams[0] = new SqlParameter("@delivery_qty", element.delivery_qty);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@requisition_product_id", element.requisition_product_id);
                    arParams[3] = new SqlParameter("@unit_price", element.unit_price);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "requisitionProductListUpdate", arParams);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void requisitiondeliveryListUpdate(SqlTransaction trans, Requisition requisition)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@requisition_id", requisition.requisition_id);
                arParams[1] = new SqlParameter("@store_id", requisition.store_id);
                arParams[2] = new SqlParameter("@record_modified_by", requisition.record_modified_by);
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "requisitiondeliveryListUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateProductList(SqlTransaction trans, List<ProductBO> lstProductBO)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (ProductBO element in lstProductBO)
                {
                    arParams[0] = new SqlParameter("@current_stock", element.current_stock);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@product_id", element.product_id);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AdjustCurrentStock", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetrequisitionproductsForDelivery(int RequisitionProductID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@requisition_id", RequisitionProductID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetrequisitionproductsForDelivery",arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet requisitonProductCategoty(int productTypeID)//sami 27 dec
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@productTypeID", productTypeID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "requisitonProductCategoty", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
       
		public DataSet Getrequisition_products()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "requisition_productGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public RequisitionProduct Getrequisition_product(int requisition_product_id)
		{
			SqlConnection conn = null;
			RequisitionProduct orequisition_product = new RequisitionProduct();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@requisition_product_id", requisition_product_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "requisition_productGet", arParams, ref conn);
				while (dataReader.Read())
				{
					orequisition_product.requisition_product_id = Convert.ToInt32(dataReader["requisition_product_id"]);

					if(dataReader["requisition_id"] != DBNull.Value)
						orequisition_product.requisition_id = Convert.ToInt32(dataReader["requisition_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						orequisition_product.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["order_qty"] != DBNull.Value)
						orequisition_product.order_qty = Convert.ToInt32(dataReader["order_qty"]);

                    if (dataReader["delivery_qty"] != DBNull.Value)
                        orequisition_product.delivery_qty = Convert.ToInt32(dataReader["delivery_qty"]);

					if(dataReader["receive_qty"] != DBNull.Value)
						orequisition_product.receive_qty = Convert.ToInt32(dataReader["receive_qty"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						orequisition_product.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

					if(dataReader["store_id"] != DBNull.Value)
						orequisition_product.store_id = Convert.ToInt32(dataReader["store_id"]);

                    if (dataReader["is_complete"] != DBNull.Value)
                        orequisition_product.is_complete = Convert.ToString(dataReader["is_complete"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						orequisition_product.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						orequisition_product.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return orequisition_product;
		}
       
		public int Updaterequisition_product(RequisitionProduct orequisition_product)
		{

			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
                arParams[0] = new SqlParameter("@delivery_qty", orequisition_product.delivery_qty);
                arParams[1] = new SqlParameter("@requisition_product_id", orequisition_product.requisition_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisition_productUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int requisition_productReceiveUpdate(Requisition requisiton, List<RequisitionProduct> lstrequisitionProduct)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[3];
            int result = 0;
            try
            {
                result = requisition_productReceive(trans, lstrequisitionProduct);
                requisitionreceiveUpdate(trans, requisiton);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int requisition_productReceive(SqlTransaction trans, List<RequisitionProduct> lstrequisitionProduct)
        {
           
            SqlParameter[] arParams = new SqlParameter[3];
            int result = 0;
            try
            {
                foreach (RequisitionProduct element in lstrequisitionProduct)
                {
                    arParams[0] = new SqlParameter("@receive_qty", element.receive_qty);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@requisition_product_id", element.requisition_product_id);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "requisition_productReceiveUpdate", arParams);

                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void requisitionreceiveUpdate(SqlTransaction trans,Requisition requisition)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@requisition_id", requisition.requisition_id);
                arParams[1] = new SqlParameter("@store_id", requisition.store_id);
                arParams[2] = new SqlParameter("@record_modified_by", requisition.record_modified_by);
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "requisitionreceiveUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


		public int Removerequisition_product(RequisitionProduct orequisition_product)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@requisition_product_id", orequisition_product.requisition_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisition_productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerequisition_product(int requisition_product_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@requisition_product_id", requisition_product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisition_productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
