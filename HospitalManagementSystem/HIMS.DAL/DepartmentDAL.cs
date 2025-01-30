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
	public class DepartmentDAL
	{
		public DepartmentDAL()
		{
		}
		public List<Department> GetdepartmentsList()
		{
			SqlConnection conn = null;
			List<Department> lstdepartments = new List<Department>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "departmentGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Department odepartment = new Department();
					odepartment.department_id = Convert.ToInt32(dataReader["department_id"]);

					if(dataReader["department"] != DBNull.Value)
						odepartment.department = Convert.ToString(dataReader["department"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odepartment.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odepartment.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odepartment.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odepartment.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstdepartments.Add(odepartment);
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
			return lstdepartments;
		}
		public DataSet Getdepartments()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "departmentGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Department Getdepartment(int department_id)
		{
			SqlConnection conn = null;
			Department odepartment = new Department();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@department_id", department_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "departmentGet", arParams, ref conn);
				while (dataReader.Read())
				{
					odepartment.department_id = Convert.ToInt32(dataReader["department_id"]);

					if(dataReader["department"] != DBNull.Value)
						odepartment.department = Convert.ToString(dataReader["department"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odepartment.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odepartment.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odepartment.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odepartment.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return odepartment;
		}
		public int Adddepartment(Department odepartment)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@department", odepartment.department);
				arParams[1] = new SqlParameter("@record_created_by", odepartment.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odepartment.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "departmentAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatedepartment(Department odepartment)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@department", odepartment.department);
				arParams[1] = new SqlParameter("@record_created_by", odepartment.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odepartment.record_modified_by);
				arParams[3] = new SqlParameter("@department_id", odepartment.department_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "departmentUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedepartment(Department odepartment)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@department_id", odepartment.department_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "departmentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedepartment(int department_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@department_id", department_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "departmentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
