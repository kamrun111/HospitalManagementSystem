using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationItemUsage
	{
		private int _investigation_item_usage_id;

		public int investigation_item_usage_id
		{
			get { return _investigation_item_usage_id; }
			set { _investigation_item_usage_id = value; }
		}

		private Nullable<int> _investigation_item_id;

		public Nullable<int> investigation_item_id
		{
			get { return _investigation_item_id; }
			set { _investigation_item_id = value; }
		}

		private Nullable<int> _test_item_id;

		public Nullable<int> test_item_id
		{
			get { return _test_item_id; }
			set { _test_item_id = value; }
		}

		private Nullable<int> _use_amount;

		public Nullable<int> use_amount
		{
			get { return _use_amount; }
			set { _use_amount = value; }
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

		public InvestigationItemUsage()
		{ }

		public InvestigationItemUsage(int investigation_item_usage_id,Nullable<int> investigation_item_id,Nullable<int> test_item_id,Nullable<int> use_amount,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.investigation_item_usage_id = investigation_item_usage_id;
			this.investigation_item_id = investigation_item_id;
			this.test_item_id = test_item_id;
			this.use_amount = use_amount;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "investigation_item_usage_id = " + investigation_item_usage_id.ToString() + ",investigation_item_id = " + investigation_item_id.ToString() + ",test_item_id = " + test_item_id.ToString() + ",use_amount = " + use_amount.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class investigation_item_usage_idComparer : System.Collections.Generic.IComparer<InvestigationItemUsage>
		{
			public SorterMode SorterMode;
			public investigation_item_usage_idComparer()
			{ }
			public investigation_item_usage_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<investigation_item_usage> Membres
			int System.Collections.Generic.IComparer<InvestigationItemUsage>.Compare(InvestigationItemUsage x, InvestigationItemUsage y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investigation_item_usage_id.CompareTo(x.investigation_item_usage_id);
				}
				else
				{
					return x.investigation_item_usage_id.CompareTo(y.investigation_item_usage_id);
				}
			}
			#endregion
		}
	}
}
