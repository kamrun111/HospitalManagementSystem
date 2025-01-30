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
	public class TestGroupDAL
	{
		public TestGroupDAL()
		{
		}
		public List<TestGroup> Gettest_groupsList()
		{
			SqlConnection conn = null;
            List<TestGroup> lsttest_groups = new List<TestGroup>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "test_groupGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    TestGroup otest_group = new TestGroup();
					otest_group.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["test_group"] != DBNull.Value)
						otest_group.test_group = Convert.ToString(dataReader["test_group"]);

					if(dataReader["test_department_id"] != DBNull.Value)
						otest_group.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otest_group.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otest_group.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otest_group.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otest_group.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsttest_groups.Add(otest_group);
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
			return lsttest_groups;
		}
		public DataSet Gettest_groups()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "test_groupGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet gettestdepartment()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "gettestdepartment");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetTestGroupsByTestDeptID(int testDeptID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@TestDeptID", testDeptID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "TestGroupGetByTestDeptID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public TestGroup Gettest_group(int test_group_id)
		{
			SqlConnection conn = null;
            TestGroup otest_group = new TestGroup();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_group_id", test_group_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "test_groupGet", arParams, ref conn);
				while (dataReader.Read())
				{
					otest_group.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["test_group"] != DBNull.Value)
						otest_group.test_group = Convert.ToString(dataReader["test_group"]);

					if(dataReader["test_department_id"] != DBNull.Value)
						otest_group.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otest_group.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otest_group.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otest_group.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otest_group.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return otest_group;
		}
        public int Addtest_group(TestGroup otest_group)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@test_group", otest_group.test_group);
				arParams[1] = new SqlParameter("@test_department_id", otest_group.test_department_id);
				arParams[2] = new SqlParameter("@record_created_by", otest_group.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", otest_group.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_groupAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet testelementget(int testitemID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@testitemID", testitemID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "testelementget", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int Updatetest_group(TestGroup otest_group)
		{

			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@test_group", otest_group.test_group);
				arParams[1] = new SqlParameter("@test_department_id", otest_group.test_department_id);
				arParams[2] = new SqlParameter("@record_created_by", otest_group.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", otest_group.record_modified_by);
				arParams[4] = new SqlParameter("@test_group_id", otest_group.test_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_groupUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removetest_group(TestGroup otest_group)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_group_id", otest_group.test_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_groupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_group(int test_group_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_group_id", test_group_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_groupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
