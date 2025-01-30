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
		public List<Purchase> GetpurchasesList()
		{
			SqlConnection conn = null;
			List<Purchase> lstpurchases = new List<Purchase>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "purchaseGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Purchase opurchase = new Purchase();
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
		public Purchase Getpurchase(int purchase_id)
		{
			SqlConnection conn = null;
			Purchase opurchase = new Purchase();
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
		public int Addpurchase(Purchase opurchase)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@purchase", opurchase.purchase);
				arParams[1] = new SqlParameter("@order_date", opurchase.order_date);
				arParams[2] = new SqlParameter("@supplier_id", opurchase.supplier_id);
				arParams[3] = new SqlParameter("@is_complete", opurchase.is_complete);
				arParams[4] = new SqlParameter("@store_id", opurchase.store_id);
				arParams[5] = new SqlParameter("@record_created_by", opurchase.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", opurchase.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchaseAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int AddMultiplepurchase(List<Purchase> lstPurchase)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;

            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[9];

            try
            {
                foreach (Purchase element in lstPurchase)
                {
                    arParams[0] = new SqlParameter("@purchase", element.purchase);
                    arParams[1] = new SqlParameter("@order_date", element.order_date);
                    arParams[2] = new SqlParameter("@supplier_id", element.supplier_id);
                    arParams[3] = new SqlParameter("@is_complete", element.is_complete);
                    arParams[4] = new SqlParameter("@store_id", element.store_id);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[6] = new SqlParameter("@record_modified_by", element.record_modified_by);
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


		public int Updatepurchase(Purchase opurchase)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@purchase", opurchase.purchase);
				arParams[1] = new SqlParameter("@order_date", opurchase.order_date);
				arParams[2] = new SqlParameter("@supplier_id", opurchase.supplier_id);
				arParams[3] = new SqlParameter("@is_complete", opurchase.is_complete);
				arParams[4] = new SqlParameter("@store_id", opurchase.store_id);
				arParams[5] = new SqlParameter("@record_created_by", opurchase.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", opurchase.record_modified_by);
				arParams[7] = new SqlParameter("@purchase_id", opurchase.purchase_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "purchaseUpdate", arParams);
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
	}
}
