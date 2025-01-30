using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class TestItem
	{
		private int _test_item_id;

		public int test_item_id
		{
			get { return _test_item_id; }
			set { _test_item_id = value; }
		}

		private string _test_item;

        public string test_item
		{
			get { return _test_item; }
			set { _test_item = value; }
		}

		private Nullable<int> _test_group_id;

		public Nullable<int> test_group_id
		{
			get { return _test_group_id; }
			set { _test_group_id = value; }
		}

        private Nullable<int> _specimen_id;

        public Nullable<int> specimen_id
        {
            get { return _specimen_id; }
            set { _specimen_id = value; }
        }
        private Nullable<int> _serial_no;

        public Nullable<int> serial_no
        {
            get { return _serial_no; }
            set { _serial_no = value; }
        }

		private Nullable<Decimal> _charge;

		public Nullable<Decimal> charge
		{
			get { return _charge; }
			set { _charge = value; }
		}

		private string _reference_value;

		public string reference_value
		{
			get { return _reference_value; }
			set { _reference_value = value; }
		}

        private string _unit;

        public string unit
        {
            get { return _unit; }
            set { _unit = value; }
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

		public TestItem()
		{ }

        public TestItem(int test_item_id, string unit, string test_item, Nullable<int> test_group_id, Nullable<int> specimen_id, Nullable<int> serial_no, Nullable<Decimal> charge, string reference_value, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.test_item_id = test_item_id;
			this.test_item = test_item;
			this.test_group_id = test_group_id;
            this.specimen_id = specimen_id;
            this.serial_no = serial_no;
			this.charge = charge;
			this.reference_value = reference_value;
            this.unit = unit;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "test_item_id = " + test_item_id.ToString() + ", unit=" + unit + ",test_item = " + test_item + ",test_group_id = " + test_group_id.ToString() + ",specimen_id=" + specimen_id.ToString() + ",role_no= " + serial_no.ToString() + ", charge = " + charge.ToString() + ",reference_value = " + reference_value + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class test_item_idComparer : System.Collections.Generic.IComparer<TestItem>
		{
			public SorterMode SorterMode;
			public test_item_idComparer()
			{ }
			public test_item_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestItem> Membres
			int System.Collections.Generic.IComparer<TestItem>.Compare(TestItem x, TestItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.test_item_id.CompareTo(x.test_item_id);
				}
				else
				{
					return x.test_item_id.CompareTo(y.test_item_id);
				}
			}
			#endregion
		}
		public class test_itemComparer : System.Collections.Generic.IComparer<TestItem>
		{
			public SorterMode SorterMode;
			public test_itemComparer()
			{ }
			public test_itemComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestItem> Membres
			int System.Collections.Generic.IComparer<TestItem>.Compare(TestItem x, TestItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.test_item.CompareTo(x.test_item);
				}
				else
				{
                    return x.test_item.CompareTo(y.test_item);
				}
			}
			#endregion
		}
		public class reference_valueComparer : System.Collections.Generic.IComparer<TestItem>
		{
			public SorterMode SorterMode;
			public reference_valueComparer()
			{ }
			public reference_valueComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestItem> Membres
			int System.Collections.Generic.IComparer<TestItem>.Compare(TestItem x, TestItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.reference_value.CompareTo(x.reference_value);
				}
				else
				{
					return x.reference_value.CompareTo(y.reference_value);
				}
			}
			#endregion
		}
	}
}
