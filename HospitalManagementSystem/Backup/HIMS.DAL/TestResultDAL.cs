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
	public class TestResultDAL
	{
        public TestResultDAL()
		{
		}
        public void test_resultAdd(SqlTransaction trans, List<TestResult> lstTestResult)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                foreach (TestResult element in lstTestResult)
                {
                    arParams[0] = new SqlParameter("@investigation_test_id", element.investigation_test_id);
                    arParams[1] = new SqlParameter("@test_element_id", element.test_element_id);
                    arParams[2] = new SqlParameter("@result ", element.result);
                    arParams[3] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[4] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "test_resultAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void test_result_Update(TestResult otestresult)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();

            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@result ", otestresult.result);
                arParams[1] = new SqlParameter("@record_modified_by", otestresult.record_modified_by);
                arParams[2] = new SqlParameter("@test_element_id", otestresult.test_element_id);
                arParams[3] = new SqlParameter("@investigation_test_id", otestresult.investigation_test_id);

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "test_result_Update", arParams);
                trans.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        private void UpdateProductList(SqlTransaction trans, List<ReagentProduct> lstReagentProduct)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (ReagentProduct element in lstReagentProduct)
                {
                    arParams[0] = new SqlParameter("@current_stock", element.current_stock);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@re_agent_product_id", element.re_agent_product_id);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AdjustReAgentStock", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertTestResult(List<TestResult> lstTestResult, List<ReagentProduct> lstReagentProduct)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                test_resultAdd(trans, lstTestResult);
                UpdateProductList(trans, lstReagentProduct);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateCurrentStock(List<ReagentProduct> lstReagentProduct)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (ReagentProduct element in lstReagentProduct)
                {
                    arParams[0] = new SqlParameter("@current_stock", element.current_stock);
                    arParams[1] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[2] = new SqlParameter("@re_agent_product_id", element.re_agent_product_id);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AdjustReAgentStock", arParams);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
	}
}
