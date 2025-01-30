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
	public class PurchaseDAL
	{
		public PurchaseDAL()
		{
		}
        public DataSet GetReviewpurchase()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetReviewpurchase");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public List<PurchaseBO> GetpurchasesList()
		{
			SqlConnection conn = null;
			List<PurchaseBO> lstpurchases = new List<PurchaseBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "purchaseGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PurchaseBO opurchase = new PurchaseBO();
					opurchase.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["purchase"] != DBNull.Value)
						opurchase.purchase = Convert.ToString(dataReader["purchase"]);

					if(dataReader["order_date"] != DBNull.Value)
						opurchase.order_date = Convert.ToDateTime(dataReader["order_date"]);

					if(dataReader["supplier_id"] != DBNull.Value)
						opurchase.supplier_id = Convert.ToInt32(dataReader["supplier_id"]);

					if(dataReader["is_complete"] != DBNull.Value)
						opurchase.is_complete = Convert.ToBoolean(dataReader["is_complete"]);

					if(dataReader["store_id"] != DBNull.Value)
						opurchase.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opurchase.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opurchase.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpurchases.Add(opurchase);
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
			return lstpurchases;
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
        public DataSet PurchaseCancelation(int PurchaseID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@purchase_id", PurchaseID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PurchaseCancelation", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

		public DataSet Getpurchases()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "purchaseGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet PurchaseReview()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PurchaseReview");
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

        public DataSet productforpurchase(int categoryID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_categoryID", categoryID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "productforpurchase", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet productforReagentpurchase(int categoryID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_categoryID", categoryID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "productforReagentpurchase", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet PurchaseListview(DateTime From, DateTime To)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@From", From);
                arParams[1] = new SqlParameter("@To", To);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PurchaseListview", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet ReceivedListview(DateTime From, DateTime To)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@From", From);
                arParams[1] = new SqlParameter("@To", To);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReceivedListview", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetPurchaseLoad()//samia22OCT
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPurchaseLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetSupplierName(int ProducyTypeID)//samia22OCT
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_typeID", ProducyTypeID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSupplierName", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public PurchaseBO Getpurchase(int purchase_id)
		{
			SqlConnection conn = null;
			PurchaseBO opurchase = new PurchaseBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@purchase_id", purchase_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "purchaseGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opurchase.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["purchase"] != DBNull.Value)
						opurchase.purchase = Convert.ToString(dataReader["purchase"]);

					if(dataReader["order_date"] != DBNull.Value)
						opurchase.order_date = Convert.ToDateTime(dataReader["order_date"]);

					if(dataReader["supplier_id"] != DBNull.Value)
						opurchase.supplier_id = Convert.ToInt32(dataReader["supplier_id"]);

					if(dataReader["is_complete"] != DBNull.Value)
						opurchase.is_complete = Convert.ToBoolean(dataReader["is_complete"]);

					if(dataReader["store_id"] != DBNull.Value)
						opurchase.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opurchase.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opurchase.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opurchase.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opurchase.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opurchase;
		}
        //public int Addpurchase(PurchaseBO opurchase,int flag)   //samia 20oct
        //{
        //    int result = 0;
        //    SqlConnection conn = DbHelper.GetOpenConnection();
        //    SqlParameter[] arParams = new SqlParameter[8];
        //    try
        //    {
        //        //arParams[0] = new SqlParameter("@purchase", opurchase.purchase);
        //        arParams[0] = new SqlParameter("@order_date", opurchase.order_date);
        //        arParams[1] = new SqlParameter("@supplier_id", opurchase.supplier_id);
        //        arParams[2] = new SqlParameter("@is_complete", opurchase.is_complete);
        //        arParams[3] = new SqlParameter("@store_id", opurchase.store_id);
        //        arParams[4] = new SqlParameter("@record_created_by", opurchase.record_created_by);
        //        arParams[5] = new SqlParameter("@record_modified_by", opurchase.record_modified_by);
        //        arParams[6] = new SqlParameter("@flag",flag);
        //        arParams[7] = new SqlParameter("@purchase_id", opurchase.purchase_id);
        //        arParams[7].Direction = ParameterDirection.Output;

        //        SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "purchaseAdd", arParams);
        //        result = Convert.ToInt32(arParams[7].Value.ToString());

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}
        public int Addpurchase(SqlTransaction trans, PurchaseBO opurchase, int flag)   //samia 20oct
        {
          
            SqlParameter[] arParams = new SqlParameter[10];
            int result = 0;
            try
            {
                //arParams[0] = new SqlParameter("@purchase", opurchase.purchase);
                arParams[0] = new SqlParameter("@order_date", opurchase.order_date);
                arParams[1] = new SqlParameter("@supplier_id", opurchase.supplier_id);
                arParams[2] = new SqlParameter("@is_complete", opurchase.is_complete);
                arParams[3] = new SqlParameter("@store_id", opurchase.store_id);
                arParams[4] = new SqlParameter("@record_created_by", opurchase.record_created_by);
                arParams[5] = new SqlParameter("@record_modified_by", opurchase.record_modified_by);
                arParams[6] = new SqlParameter("@indent_no", opurchase.indent_no);
                arParams[7] = new SqlParameter("@indent_date", opurchase.indent_date);
                arParams[8] = new SqlParameter("@flag", flag);
                arParams[9] = new SqlParameter("@purchase_id", opurchase.purchase_id);
                arParams[9].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "purchaseAdd", arParams);
                result = Convert.ToInt32(arParams[9].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public int purchasecancelationAdd(PurchaseBO opurchase)  
        {
            
           
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@purchase_id", opurchase.purchase_id);
                arParams[1] = new SqlParameter("@cancelation_date", opurchase.cancelation_date);
                arParams[2] = new SqlParameter("@is_complete", opurchase.is_complete);
                arParams[3] = new SqlParameter("@record_modified_by", opurchase.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchasecancelationAdd", arParams);
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public int AddMultiplepurchase(List<PurchaseBO> lstPurchase)
        {
        
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;

            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[9];

            try
            {
                foreach (PurchaseBO element in lstPurchase)
                {
                    arParams[1] = new SqlParameter("@order_date", element.order_date);
                    arParams[2] = new SqlParameter("@supplier_id", element.supplier_id);
                    arParams[3] = new SqlParameter("@is_complete", element.is_complete);
                    arParams[4] = new SqlParameter("@store_id", element.store_id);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[6] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    //arParams[6].Direction = ParameterDirection.Output;

                    result=SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "purchaseAdd", arParams);
                }
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


		public int Updatepurchase(PurchaseBO opurchase)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@purchase", opurchase.purchase);
				arParams[1] = new SqlParameter("@order_date", opurchase.order_date);
				arParams[2] = new SqlParameter("@supplier_id", opurchase.supplier_id);
				arParams[3] = new SqlParameter("@is_complete", opurchase.is_complete);
				arParams[4] = new SqlParameter("@store_id", opurchase.store_id);
				arParams[6] = new SqlParameter("@record_created_by", opurchase.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_date", opurchase.record_modified_date);
				arParams[8] = new SqlParameter("@record_modified_by", opurchase.record_modified_by);
				arParams[9] = new SqlParameter("@purchase_id", opurchase.purchase_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchaseUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@purchase_id", opurchase.purchase_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchaseDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@purchase_id", purchase_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchaseDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int PurchaseProductInsert(PurchaseBO purchaseBO, List<PurchaseProduct> lstPurchaseProduct, int flag)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int purchaseID=0;
            try
            {
                purchaseID = Addpurchase(trans, purchaseBO, flag);
                Addpurchase_product(trans, purchaseID, lstPurchaseProduct);

                trans.Commit();
            }
            catch(Exception Ex)
            {
                trans.Rollback();
                throw Ex;
            }
            finally
            {
                conn.Close();
            }
            return purchaseID;
        }
        private void Addpurchase_product(SqlTransaction trans, int purchaseID, List<PurchaseProduct> lstPurchaseProduct)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                foreach (PurchaseProduct element in lstPurchaseProduct)
                {
                    arParams[0] = new SqlParameter("@purchase_id", purchaseID);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@order_qty", element.order_qty);
                    arParams[3] = new SqlParameter("@total_received_qty", element.total_received_qty);
                    arParams[4] = new SqlParameter("@store_id", element.store_id);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[6] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "purchase_productAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
