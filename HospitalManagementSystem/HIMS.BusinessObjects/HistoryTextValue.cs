using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class HistoryTextValue
	{
		private int _history_text_value_id;

		public int history_text_value_id
		{
			get { return _history_text_value_id; }
			set { _history_text_value_id = value; }
		}

		private string _history_text_value;

		public string history_text_value
		{
			get { return _history_text_value; }
			set { _history_text_value = value; }
		}

		private Nullable<int> _history_text_id;

		public Nullable<int> history_text_id
		{
			get { return _history_text_id; }
			set { _history_text_id = value; }
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

		public HistoryTextValue()
		{ }

		public HistoryTextValue(int history_text_value_id,string history_text_value,Nullable<int> history_text_group_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.history_text_value_id = history_text_value_id;
			this.history_text_value = history_text_value;
			this.history_text_id = history_text_group_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "history_text_value_id = " + history_text_value_id.ToString() + ",history_text_value = " + history_text_value + ",history_text_group_id = " + history_text_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class history_text_value_idComparer : System.Collections.Generic.IComparer<HistoryTextValue>
		{
			public SorterMode SorterMode;
			public history_text_value_idComparer()
			{ }
			public history_text_value_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<HistoryTextValue> Membres
			int System.Collections.Generic.IComparer<HistoryTextValue>.Compare(HistoryTextValue x, HistoryTextValue y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.history_text_value_id.CompareTo(x.history_text_value_id);
				}
				else
				{
					return x.history_text_value_id.CompareTo(y.history_text_value_id);
				}
			}
			#endregion
		}
		public class history_text_valueComparer : System.Collections.Generic.IComparer<HistoryTextValue>
		{
			public SorterMode SorterMode;
			public history_text_valueComparer()
			{ }
			public history_text_valueComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<HistoryTextValue> Membres
			int System.Collections.Generic.IComparer<HistoryTextValue>.Compare(HistoryTextValue x, HistoryTextValue y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y._history_text_value.CompareTo(x._history_text_value);
				}
				else
				{
                    return x._history_text_value.CompareTo(y._history_text_value);
				}
			}
			#endregion
		}
	}
}
