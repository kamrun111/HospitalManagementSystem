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
	public class TestElementDAL
	{
        public TestElementDAL()
		{
		}
        public DataSet get_TestElement(int testitemID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@testitemID", testitemID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "get_TestElement", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int test_element_add(TestElement oTestElement)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@test_element", oTestElement.test_element);
                arParams[1] = new SqlParameter("@test_item_id", oTestElement.test_item_id);
                arParams[2] = new SqlParameter("@serial_no", oTestElement.serial_no);
                arParams[3] = new SqlParameter("@reference_value", oTestElement.reference_value);
                arParams[4] = new SqlParameter("@record_created_by", oTestElement.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_element_add", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int test_element_update(TestElement oTestElement)
        {

            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@test_elementID", oTestElement.test_element_id);
                arParams[1] = new SqlParameter("@test_element", oTestElement.test_element);
                arParams[2] = new SqlParameter("@reference_value", oTestElement.reference_value);
                arParams[3] = new SqlParameter("@serial_no", oTestElement.serial_no);
                arParams[4] = new SqlParameter("@record_modified_by", oTestElement.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_element_update", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
	}
}
