using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class TestDepartmentBLL
	{
		private TestDepartmentDAL _test_departmentDAL;

		public TestDepartmentDAL test_departmentDAL
		{
			get { return _test_departmentDAL; }
			set { _test_departmentDAL = value; }
		}

		public TestDepartmentBLL()
		{
			test_departmentDAL = new TestDepartmentDAL();
		}
		public List<TestDepartment> Gettest_departmentsList()
		{
			try
			{
				return test_departmentDAL.Gettest_departmentsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Gettest_departments()
		{
			try
			{
				return test_departmentDAL.Gettest_departments();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public TestDepartment Gettest_department(int test_department_id)
		{
			try
			{
				return test_departmentDAL.Gettest_department(test_department_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addtest_department(TestDepartment otest_department)
		{
			try
			{
				return test_departmentDAL.Addtest_department(otest_department);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatetest_department(TestDepartment otest_department)
		{
			try
			{
				return test_departmentDAL.Updatetest_department(otest_department);
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
				return test_departmentDAL.Removetest_department(otest_department);
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
				return test_departmentDAL.Removetest_department(test_department_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<TestDepartment> Deserializetest_departments(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<TestDepartment>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializetest_departments(string Path, List<TestDepartment> test_departments)
		{
			try
			{
				GenericXmlSerializer<List<TestDepartment>>.Serialize(test_departments, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
