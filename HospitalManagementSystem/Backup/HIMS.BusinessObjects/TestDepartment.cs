using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class TestDepartment
	{
		private int _test_department_id;

		public int test_department_id
		{
			get { return _test_department_id; }
			set { _test_department_id = value; }
		}

		private string _test_department;

		public string test_department
		{
			get { return _test_department; }
			set { _test_department = value; }
		}

		private Nullable<DateTime> _record_created_date;

		public Nullable<DateTime> record_created_date
		{
			get { return _record_created_date; }
			set { _record_created_date = value; }
		}

		private Nullable<int> _record_created_by;

		public Nullable<int> record_created_by
		{
			get { return _record_created_by; }
			set { _record_created_by = value; }
		}

		private Nullable<DateTime> _record_modified_date;

		public Nullable<DateTime> record_modified_date
		{
			get { return _record_modified_date; }
			set { _record_modified_date = value; }
		}

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public TestDepartment()
		{ }

		public TestDepartment(int test_department_id,string test_department,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.test_department_id = test_department_id;
			this.test_department = test_department;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "test_department_id = " + test_department_id.ToString() + ",test_department = " + test_department + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class test_department_idComparer : System.Collections.Generic.IComparer<TestDepartment>
		{
			public SorterMode SorterMode;
			public test_department_idComparer()
			{ }
			public test_department_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestDepartment> Membres
			int System.Collections.Generic.IComparer<TestDepartment>.Compare(TestDepartment x, TestDepartment y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.test_department_id.CompareTo(x.test_department_id);
				}
				else
				{
					return x.test_department_id.CompareTo(y.test_department_id);
				}
			}
			#endregion
		}
		public class test_departmentComparer : System.Collections.Generic.IComparer<TestDepartment>
		{
			public SorterMode SorterMode;
			public test_departmentComparer()
			{ }
			public test_departmentComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestDepartment> Membres
			int System.Collections.Generic.IComparer<TestDepartment>.Compare(TestDepartment x, TestDepartment y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.test_department.CompareTo(x.test_department);
				}
				else
				{
                    return x.test_department.CompareTo(y.test_department);
				}
			}
			#endregion
		}
	}
}
