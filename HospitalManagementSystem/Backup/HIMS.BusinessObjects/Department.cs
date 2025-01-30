using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Department
	{
		private int _department_id;

		public int department_id
		{
			get { return _department_id; }
			set { _department_id = value; }
		}

		private string _department;

		public string department
		{
			get { return _department; }
			set { _department = value; }
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

		public Department()
		{ }

		public Department(int department_id,string department,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.department_id = department_id;
			this.department = department;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "department_id = " + department_id.ToString() + ",department = " + department + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class department_idComparer : System.Collections.Generic.IComparer<Department>
		{
			public SorterMode SorterMode;
			public department_idComparer()
			{ }
			public department_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Department> Membres
			int System.Collections.Generic.IComparer<Department>.Compare(Department x, Department y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.department_id.CompareTo(x.department_id);
				}
				else
				{
					return x.department_id.CompareTo(y.department_id);
				}
			}
			#endregion
		}
		public class departmentComparer : System.Collections.Generic.IComparer<Department>
		{
			public SorterMode SorterMode;
			public departmentComparer()
			{ }
			public departmentComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Department> Membres
			int System.Collections.Generic.IComparer<Department>.Compare(Department x, Department y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.department.CompareTo(x.department);
				}
				else
				{
                    return x.department.CompareTo(y.department);
				}
			}
			#endregion
		}
	}
}
