using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class TestElement
	{
        private int _test_element_id;

        public int test_element_id
		{
            get { return _test_element_id; }
            set { _test_element_id = value; }
		}

        private string _test_element;

        public string test_element
		{
            get { return _test_element; }
            set { _test_element = value; }
		}

        private Nullable<int> _test_item_id;

        public Nullable<int> test_item_id
		{
            get { return _test_item_id; }
            set { _test_item_id = value; }
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

		public TestElement()
		{ }

        public TestElement(int test_element_id, string test_element, Nullable<int> test_item_id, Nullable<int> serial_no, Nullable<Decimal> charge, string reference_value, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.test_element_id = test_element_id;
            this.test_element = test_element;
            this.test_item_id = test_item_id;
            this.serial_no = serial_no;
			this.charge = charge;
			this.reference_value = reference_value;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "test_element_id = " + test_element_id.ToString() + ",test_element = " + test_element + ",test_item_id = " + test_item_id.ToString() + ",serial_no= " + serial_no.ToString() + ", charge = " + charge.ToString() + ",reference_value = " + reference_value + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class test_element_idComparer : System.Collections.Generic.IComparer<TestElement>
		{
			public SorterMode SorterMode;
			public test_element_idComparer()
			{ }
            public test_element_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestElement> Membres
			int System.Collections.Generic.IComparer<TestElement>.Compare(TestElement x, TestElement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.test_element_id.CompareTo(x.test_element_id);
				}
				else
				{
                    return x.test_element_id.CompareTo(y.test_element_id);
				}
			}
			#endregion
		}
        public class test_elementComparer : System.Collections.Generic.IComparer<TestElement>
		{
			public SorterMode SorterMode;
			public test_elementComparer()
			{ }
			public test_elementComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestElement> Membres
			int System.Collections.Generic.IComparer<TestElement>.Compare(TestElement x, TestElement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.test_element.CompareTo(x.test_element);
				}
				else
				{
                    return x.test_element.CompareTo(y.test_element);
				}
			}
			#endregion
		}
		public class reference_valueComparer : System.Collections.Generic.IComparer<TestElement>
		{
			public SorterMode SorterMode;
			public reference_valueComparer()
			{ }
			public reference_valueComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<TestElement> Membres
			int System.Collections.Generic.IComparer<TestElement>.Compare(TestElement x, TestElement y)
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
