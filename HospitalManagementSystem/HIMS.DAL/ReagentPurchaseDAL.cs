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
	public class ReagentPurchaseDAL
	{
		public ReagentPurchaseDAL()
		{
		}
        public DataSet CategoryforReagent()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "CategoryforReagent");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int Addreagent_purchase(SqlTransaction trans, ReagentPurchase opurchase)
        {

            SqlParameter[] arParams = new SqlParameter[7];
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
                arParams[6] = new SqlParameter("@reagent_purchase_id ", opurchase.reagent_purchase_id);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "reagent_purchaseAdd", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        private void Addreagent_purchase_product(SqlTransaction trans, int RpurchaseID, List<ReagentPurchaseProduct> lstReagentPurchaseProduct)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                foreach (ReagentPurchaseProduct element in lstReagentPurchaseProduct)
                {
                    arParams[0] = new SqlParameter("@reagent_purchase_id", RpurchaseID);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@order_qty", element.order_qty);
                    arParams[3] = new SqlParameter("@total_received_qty", element.total_received_qty);
                    arParams[4] = new SqlParameter("@store_id", element.store_id);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[6] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "reagent_purchase_productAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ReagentPurchaseProductInsert(ReagentPurchase reagentPurchase, List<ReagentPurchaseProduct> lstReagentPurchaseProduct)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int RpurchaseID = 0;
            try
            {
                RpurchaseID = Addreagent_purchase(trans, reagentPurchase);
                Addreagent_purchase_product(trans, RpurchaseID, lstReagentPurchaseProduct);

                trans.Commit();
            }
            catch (Exception Ex)
            {
                trans.Rollback();
                throw Ex;
            }
            finally
            {
                conn.Close();
            }
            return RpurchaseID;
        }
        public int Reagentpurchasecancelation(ReagentPurchase opurchasepurchase)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@reagent_purchase_id", opurchasepurchase.reagent_purchase_id);
                arParams[1] = new SqlParameter("@cancelation_date", opurchasepurchase.cancelation_date);
                arParams[2] = new SqlParameter("@is_complete", opurchasepurchase.is_complete);
                arParams[3] = new SqlParameter("@record_modified_by", opurchasepurchase.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "Reagentpurchasecancelation", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
	}
}
