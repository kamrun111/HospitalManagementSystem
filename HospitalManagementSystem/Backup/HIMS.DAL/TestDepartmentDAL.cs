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
	public class TestDepartmentDAL
	{
		public TestDepartmentDAL()
		{
		}
		public List<TestDepartment> Gettest_departmentsList()
		{
			SqlConnection conn = null;
			List<TestDepartment> lsttest_departments = new List<TestDepartment>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "test_departmentGetAll", null, ref conn);
				while (dataReader.Read())
				{
					TestDepartment otest_department = new TestDepartment();
					otest_department.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["test_department"] != DBNull.Value)
						otest_department.test_department = Convert.ToString(dataReader["test_department"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otest_department.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otest_department.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otest_department.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otest_department.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsttest_departments.Add(otest_department);
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
			return lsttest_departments;
		}
		public DataSet Gettest_departments()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "test_departmentGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public TestDepartment Gettest_department(int test_department_id)
		{
			SqlConnection conn = null;
			TestDepartment otest_department = new TestDepartment();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_department_id", test_department_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "test_departmentGet", arParams, ref conn);
				while (dataReader.Read())
				{
					otest_department.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["test_department"] != DBNull.Value)
						otest_department.test_department = Convert.ToString(dataReader["test_department"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otest_department.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otest_department.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otest_department.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otest_department.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return otest_department;
		}
		public int Addtest_department(TestDepartment otest_department)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@test_department", otest_department.test_department);
				arParams[1] = new SqlParameter("@record_created_by", otest_department.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", otest_department.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_departmentAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatetest_department(TestDepartment otest_department)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@test_department", otest_department.test_department);
				arParams[1] = new SqlParameter("@record_created_by", otest_department.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", otest_department.record_modified_by);
				arParams[3] = new SqlParameter("@test_department_id", otest_department.test_department_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_departmentUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_department(TestDepartment otest_department)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_department_id", otest_department.test_department_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_departmentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_department(int test_department_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@test_department_id", test_department_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "test_departmentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
