using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class HistoryText
	{
		private int _history_text_id;

		public int history_text_id
		{
			get { return _history_text_id; }
			set { _history_text_id = value; }
		}

		private string _history_text;

		public string history_text
		{
			get { return _history_text; }
			set { _history_text = value; }
		}

		private Nullable<int> _history_text_group_id;

		public Nullable<int> history_text_group_id
		{
			get { return _history_text_group_id; }
			set { _history_text_group_id = value; }
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

		public HistoryText()
		{ }

		public HistoryText(int history_text_id,string history_text,Nullable<int> history_text_group_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.history_text_id = history_text_id;
			this.history_text = history_text;
			this.history_text_group_id = history_text_group_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "history_text_id = " + history_text_id.ToString() + ",history_text = " + history_text + ",history_text_group_id = " + history_text_group_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class history_text_idComparer : System.Collections.Generic.IComparer<HistoryText>
		{
			public SorterMode SorterMode;
			public history_text_idComparer()
			{ }
			public history_text_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<HistoryText> Membres
			int System.Collections.Generic.IComparer<HistoryText>.Compare(HistoryText x, HistoryText y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.history_text_id.CompareTo(x.history_text_id);
				}
				else
				{
					return x.history_text_id.CompareTo(y.history_text_id);
				}
			}
			#endregion
		}
		public class history_textComparer : System.Collections.Generic.IComparer<HistoryText>
		{
			public SorterMode SorterMode;
			public history_textComparer()
			{ }
			public history_textComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<HistoryText> Membres
			int System.Collections.Generic.IComparer<HistoryText>.Compare(HistoryText x, HistoryText y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.history_text.CompareTo(x.history_text);
				}
				else
				{
                    return x.history_text.CompareTo(y.history_text);
				}
			}
			#endregion
		}
	}
}
