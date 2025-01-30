using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class CabinStatus
	{
		private int _cabin_status_id;

		public int cabin_status_id
		{
			get { return _cabin_status_id; }
			set { _cabin_status_id = value; }
		}

		private string _cabin_status;

		public string cabin_status
		{
			get { return _cabin_status; }
			set { _cabin_status = value; }
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

		public CabinStatus()
		{ }

		public CabinStatus(int cabin_status_id,string cabin_status,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.cabin_status_id = cabin_status_id;
			this.cabin_status = cabin_status;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "cabin_status_id = " + cabin_status_id.ToString() + ",cabin_status = " + cabin_status + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class cabin_status_idComparer : System.Collections.Generic.IComparer<CabinStatus>
		{
			public SorterMode SorterMode;
			public cabin_status_idComparer()
			{ }
			public cabin_status_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<CabinStatus> Membres
			int System.Collections.Generic.IComparer<CabinStatus>.Compare(CabinStatus x, CabinStatus y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.cabin_status_id.CompareTo(x.cabin_status_id);
				}
				else
				{
					return x.cabin_status_id.CompareTo(y.cabin_status_id);
				}
			}
			#endregion
		}
		public class cabin_statusComparer : System.Collections.Generic.IComparer<CabinStatus>
		{
			public SorterMode SorterMode;
			public cabin_statusComparer()
			{ }
			public cabin_statusComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<CabinStatus> Membres
			int System.Collections.Generic.IComparer<CabinStatus>.Compare(CabinStatus x, CabinStatus y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.cabin_status.CompareTo(x.cabin_status);
				}
				else
				{
                    return x.cabin_status.CompareTo(y.cabin_status);
				}
			}
			#endregion
		}
	}
}
