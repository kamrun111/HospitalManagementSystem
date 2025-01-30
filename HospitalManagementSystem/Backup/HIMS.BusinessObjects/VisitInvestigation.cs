using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class VisitInvestigation
	{
		private int _visit_investigation_id;

		public int visit_investigation_id
		{
			get { return _visit_investigation_id; }
			set { _visit_investigation_id = value; }
		}

		private Nullable<int> _visit_prescription_id;

		public Nullable<int> visit_prescription_id
		{
			get { return _visit_prescription_id; }
			set { _visit_prescription_id = value; }
		}

		private Nullable<int> _test_department_id;

		public Nullable<int> test_department_id
		{
			get { return _test_department_id; }
			set { _test_department_id = value; }
		}

		private Nullable<int> _test_group_id;

		public Nullable<int> test_group_id
		{
			get { return _test_group_id; }
			set { _test_group_id = value; }
		}

		private Nullable<int> _test_item_id;

		public Nullable<int> test_item_id
		{
			get { return _test_item_id; }
			set { _test_item_id = value; }
		}

        private Nullable<int> _investigation_test_id;

        public Nullable<int> investigation_test_id
		{
            get { return _investigation_test_id; }
            set { _investigation_test_id = value; }
		}

		private Nullable<int> _indent_given;

		public Nullable<int> indent_given
		{
			get { return _indent_given; }
			set { _indent_given = value; }
		}

        private int _baby_test;

        public int baby_test
        {
            get { return _baby_test; }
            set { _baby_test = value; }
        }

        private Nullable<DateTime> _investigation_date;

        public Nullable<DateTime> investigation_date
        {
            get { return _investigation_date; }
            set { _investigation_date = value; }
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

		public VisitInvestigation()
		{ }

        public VisitInvestigation(int visit_investigation_id, int baby_test,Nullable<int> visit_prescription_id, Nullable<int> test_department_id, Nullable<int> test_group_id, Nullable<int> test_item_id, Nullable<int> investigation_test_id, Nullable<SByte> indent_given,Nullable<DateTime> investigation_date, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.visit_investigation_id = visit_investigation_id;
			this.visit_prescription_id = visit_prescription_id;
			this.test_department_id = test_department_id;
			this.test_group_id = test_group_id;
			this.test_item_id = test_item_id;
            this.baby_test = baby_test;
            this.investigation_test_id = investigation_test_id;
			this.indent_given = indent_given;
            this.investigation_date = investigation_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "visit_investigation_id = " + visit_investigation_id.ToString() + ",visit_prescription_id = " + visit_prescription_id.ToString() + ",baby_test=" + baby_test.ToString() + ", test_department_id = " + test_department_id.ToString() + ",test_group_id = " + test_group_id.ToString() + ",test_item_id = " + test_item_id.ToString() + ",investigation_test_id = " + investigation_test_id + ",indent_given = " + indent_given.ToString() + ",investigation_date=" + investigation_date .ToString()+ ";record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class visit_investigation_idComparer : System.Collections.Generic.IComparer<VisitInvestigation>
		{
			public SorterMode SorterMode;
			public visit_investigation_idComparer()
			{ }
			public visit_investigation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_investigation> Membres
			int System.Collections.Generic.IComparer<VisitInvestigation>.Compare(VisitInvestigation x, VisitInvestigation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.visit_investigation_id.CompareTo(x.visit_investigation_id);
				}
				else
				{
					return x.visit_investigation_id.CompareTo(y.visit_investigation_id);
				}
			}
			#endregion
		}
	
	}
}
