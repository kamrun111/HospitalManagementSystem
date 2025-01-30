using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class TestGroup
	{
		private int _test_group_id;

		public int test_group_id
		{
			get { return _test_group_id; }
			set { _test_group_id = value; }
		}

		private string _test_group;

		public string test_group
		{
			get { return _test_group; }
			set { _test_group = value; }
		}

		private Nullable<int> _test_department_id;

		public Nullable<int> test_department_id
		{
			get { return _test_department_id; }
			set { _test_department_id = value; }
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

		public TestGroup()
		{ }

		public TestGroup(int test_group_id,string test_group,Nullable<int> test_department_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.test_group_id = test_group_id;
			this.test_group = test_group;
			this.test_department_id = test_department_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "test_group_id = " + test_group_id.ToString() + ",test_group = " + test_group + ",test_department_id = " + test_department_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class test_group_idComparer : System.Collections.Generic.IComparer<TestGroup>
		{
			public SorterMode SorterMode;
			public test_group_idComparer()
			{ }
			public test_group_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestGroup> Membres
			int System.Collections.Generic.IComparer<TestGroup>.Compare(TestGroup x, TestGroup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.test_group_id.CompareTo(x.test_group_id);
				}
				else
				{
					return x.test_group_id.CompareTo(y.test_group_id);
				}
			}
			#endregion
		}
		public class test_groupComparer : System.Collections.Generic.IComparer<TestGroup>
		{
			public SorterMode SorterMode;
			public test_groupComparer()
			{ }
			public test_groupComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestGroup> Membres
			int System.Collections.Generic.IComparer<TestGroup>.Compare(TestGroup x, TestGroup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.test_group.CompareTo(x.test_group);
				}
				else
				{
                    return x.test_group.CompareTo(y.test_group);
				}
			}
			#endregion
		}
	}
}
