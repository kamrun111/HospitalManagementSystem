using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class DepartmentBLL
	{
		private DepartmentDAL _departmentDAL;

		public DepartmentDAL departmentDAL
		{
			get { return _departmentDAL; }
			set { _departmentDAL = value; }
		}

		public DepartmentBLL()
		{
			departmentDAL = new DepartmentDAL();
		}
		public List<Department> GetdepartmentsList()
		{
			try
			{
				return departmentDAL.GetdepartmentsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getdepartments()
		{
			try
			{
				return departmentDAL.Getdepartments();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Department Getdepartment(int department_id)
		{
			try
			{
				return departmentDAL.Getdepartment(department_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Adddepartment(Department odepartment)
		{
			try
			{
				return departmentDAL.Adddepartment(odepartment);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatedepartment(Department odepartment)
		{
			try
			{
				return departmentDAL.Updatedepartment(odepartment);
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
				return departmentDAL.Removedepartment(odepartment);
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
				return departmentDAL.Removedepartment(department_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Department> Deserializedepartments(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Department>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializedepartments(string Path, List<Department> departments)
		{
			try
			{
				GenericXmlSerializer<List<Department>>.Serialize(departments, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
