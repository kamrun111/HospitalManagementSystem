using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class VisitAdvice
	{
		private int _visit_advice_id;

		public int visit_advice_id
		{
			get { return _visit_advice_id; }
			set { _visit_advice_id = value; }
		}

		private Nullable<int> _visit_prescription_id;

		public Nullable<int> visit_prescription_id
		{
			get { return _visit_prescription_id; }
			set { _visit_prescription_id = value; }
		}

		private Nullable<int> _advice_id;

		public Nullable<int> advice_id
		{
			get { return _advice_id; }
			set { _advice_id = value; }
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

		public VisitAdvice()
		{ }

		public VisitAdvice(int visit_advice_id,Nullable<int> visit_prescription_id,Nullable<int> advice_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.visit_advice_id = visit_advice_id;
			this.visit_prescription_id = visit_prescription_id;
			this.advice_id = advice_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "visit_advice_id = " + visit_advice_id.ToString() + ",visit_prescription_id = " + visit_prescription_id.ToString() + ",advice_id = " + advice_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class visit_advice_idComparer : System.Collections.Generic.IComparer<VisitAdvice>
		{
			public SorterMode SorterMode;
			public visit_advice_idComparer()
			{ }
			public visit_advice_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_advice> Membres
			int System.Collections.Generic.IComparer<VisitAdvice>.Compare(VisitAdvice x, VisitAdvice y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.visit_advice_id.CompareTo(x.visit_advice_id);
				}
				else
				{
					return x.visit_advice_id.CompareTo(y.visit_advice_id);
				}
			}
			#endregion
		}
	}
}
