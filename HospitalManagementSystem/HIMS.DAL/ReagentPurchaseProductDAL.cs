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
	public class ReagentPurchaseProductDAL
	{
		public ReagentPurchaseProductDAL()
		{
		}

        public int Addreagent_purchase_product(ReagentPurchaseProduct oreagentpurchase_product)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@reagent_purchase_id", oreagentpurchase_product.reagent_purchase_id);
                arParams[1] = new SqlParameter("@product_id", oreagentpurchase_product.product_id);
                arParams[2] = new SqlParameter("@order_qty", oreagentpurchase_product.order_qty);
                arParams[3] = new SqlParameter("@total_received_qty", oreagentpurchase_product.total_received_qty);
                arParams[4] = new SqlParameter("@store_id", oreagentpurchase_product.store_id);
                arParams[5] = new SqlParameter("@record_created_by", oreagentpurchase_product.record_created_by);
                arParams[6] = new SqlParameter("@record_modified_by", oreagentpurchase_product.record_modified_by);


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "reagent_purchase_productAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
	}
}
