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
	public class TestItemDAL
	{
		public TestItemDAL()
		{
		}
		public List<TestItem> Gettest_itemsList()
		{
			SqlConnection conn = null;
			List<TestItem> lsttest_items = new List<TestItem>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "test_itemGetAll", null, ref conn);
				while (dataReader.Read())
				{
					TestItem otest_item = new TestItem();
					otest_item.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["test_item"] != DBNull.Value)
						otest_item.test_item = Convert.ToString(dataReader["test_item"]);

					if(dataReader["test_group_id"] != DBNull.Value)
						otest_item.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["charge"] != DBNull.Value)
						otest_item.charge = Convert.ToDecimal(dataReader["charge"]);

					if(dataReader["reference_value"] != DBNull.Value)
						otest_item.reference_value = Convert.ToString(dataReader["reference_value"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otest_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otest_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otest_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otest_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsttest_items.Add(otest_item);
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
			return lsttest_items;
		}

        public DataSet GetTestItemByTestGrpID(int testGrpID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@TestGrpID", testGrpID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "TestItemGetByTestGrpID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        
        
        public DataSet Gettest_items()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "test_itemGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet testItemsList(int departmentID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@department_id", departmentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "testItemsList", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet testlist(int departmentID, int groupID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@deparment_id", departmentID);
                arParams[1] = new SqlParameter("@group_id", groupID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "testlist", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
 
        public DataSet Testitemsget()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "Testitemsget");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public TestItem Gettest_item(int test_item_id)
		{
			SqlConnection conn = null;
			TestItem otest_item = new TestItem();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_item_id", test_item_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "test_itemGet", arParams, ref conn);
				while (dataReader.Read())
				{
					otest_item.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["test_item"] != DBNull.Value)
						otest_item.test_item = Convert.ToString(dataReader["test_item"]);

					if(dataReader["test_group_id"] != DBNull.Value)
						otest_item.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["charge"] != DBNull.Value)
						otest_item.charge = Convert.ToDecimal(dataReader["charge"]);

					if(dataReader["reference_value"] != DBNull.Value)
						otest_item.reference_value = Convert.ToString(dataReader["reference_value"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otest_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otest_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otest_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otest_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return otest_item;
		}
		public int Addtest_item(TestItem otest_item)
		{
			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@test_item", otest_item.test_item);
				arParams[1] = new SqlParameter("@test_group_id", otest_item.test_group_id);
				arParams[2] = new SqlParameter("@charge", otest_item.charge);
				arParams[3] = new SqlParameter("@reference_value", otest_item.reference_value);
				arParams[4] = new SqlParameter("@record_created_by", otest_item.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", otest_item.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_itemAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int TestitemAdd(TestItem otest_item)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@test_item", otest_item.test_item);
                arParams[1] = new SqlParameter("@testGroupID", otest_item.test_group_id);
                arParams[2] = new SqlParameter("@specimenID", otest_item.specimen_id);
                arParams[3] = new SqlParameter("@reference_value", otest_item.reference_value);
                arParams[4] = new SqlParameter("@charge", otest_item.charge);
                arParams[5] = new SqlParameter("@record_created_by", otest_item.record_created_by);
                arParams[6] = new SqlParameter("@serial_no", otest_item.serial_no);
               
                

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "TestitemAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatetest_item(TestItem otest_item)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@test_item", otest_item.test_item);
				arParams[1] = new SqlParameter("@test_group_id", otest_item.test_group_id);
				arParams[2] = new SqlParameter("@charge", otest_item.charge);
				arParams[3] = new SqlParameter("@reference_value", otest_item.reference_value);
                arParams[4] = new SqlParameter("@serial_no", otest_item.serial_no);
				arParams[5] = new SqlParameter("@record_modified_by", otest_item.record_modified_by);
				arParams[6] = new SqlParameter("@test_item_id", otest_item.test_item_id);
                arParams[7] = new SqlParameter("@specimen_id", otest_item.specimen_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_itemUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_item(TestItem otest_item)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_item_id", otest_item.test_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_item(int test_item_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_item_id", test_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
