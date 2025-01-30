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
	public class ReAgentItemDAL
	{
		public ReAgentItemDAL()
		{
		}

        public DataSet GetTestItem(int group_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@test_group_id", group_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTestItem", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public DataSet GetTestItemElement(int item_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@test_item_id", item_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTestItemElement", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public DataSet ReagentCategory()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReagentCategory");
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public DataSet ReagentProduct(int category_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@product_category_id", category_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReagentProduct", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public DataSet ReagentProductinfo(int product_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@product_id", product_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReagentProductinfo", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public void ReAgentItemAdd(List<ReAgentItem> lstReAgentItem, string test_item)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[6];

            try
            {
                foreach (ReAgentItem element in lstReAgentItem)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@test_item", test_item);
                    arParams[2] = new SqlParameter("@required_qty", element.required_qty);
                    arParams[3] = new SqlParameter("@unit_id", element.unit_id);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[5] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "ReAgentItemAdd", arParams);
                }
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
        }
        public DataSet GetReAgents(string test_item)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@test_item", test_item);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetReAgents", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public DataSet ReagentforTest(int test_itemID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@TestItemID", test_itemID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReagentforTest", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
        public DataSet ReagentforInvestigationTest(int test_item_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@test_item_id", test_item_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReagentforInvestigationTest", arParams);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
            }
        }
	}
}
