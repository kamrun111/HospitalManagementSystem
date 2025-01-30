using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class HistoryTextGroup
	{
		private int _history_text_group_id;

		public int history_text_group_id
		{
			get { return _history_text_group_id; }
			set { _history_text_group_id = value; }
		}

		private string _history_text_group;

		public string history_text_group
		{
			get { return _history_text_group; }
			set { _history_text_group = value; }
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

		public HistoryTextGroup()
		{ }

		public HistoryTextGroup(int history_text_group_id,string history_text_group,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.history_text_group_id = history_text_group_id;
			this.history_text_group = history_text_group;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "history_text_group_id = " + history_text_group_id.ToString() + ",history_text_group = " + history_text_group + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class history_text_group_idComparer : System.Collections.Generic.IComparer<HistoryTextGroup>
		{
			public SorterMode SorterMode;
			public history_text_group_idComparer()
			{ }
			public history_text_group_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<HistoryTextGroup> Membres
			int System.Collections.Generic.IComparer<HistoryTextGroup>.Compare(HistoryTextGroup x, HistoryTextGroup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.history_text_group_id.CompareTo(x.history_text_group_id);
				}
				else
				{
					return x.history_text_group_id.CompareTo(y.history_text_group_id);
				}
			}
			#endregion
		}
		public class history_text_groupComparer : System.Collections.Generic.IComparer<HistoryTextGroup>
		{
			public SorterMode SorterMode;
			public history_text_groupComparer()
			{ }
			public history_text_groupComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<HistoryTextGroup> Membres
			int System.Collections.Generic.IComparer<HistoryTextGroup>.Compare(HistoryTextGroup x, HistoryTextGroup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.history_text_group.CompareTo(x.history_text_group);
				}
				else
				{
                    return x.history_text_group.CompareTo(y.history_text_group);
				}
			}
			#endregion
		}
	}
}
