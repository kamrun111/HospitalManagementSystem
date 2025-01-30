using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Religion
	{
		private int _religion_id;

		public int religion_id
		{
			get { return _religion_id; }
			set { _religion_id = value; }
		}

		private string _religion;

		public string religion
		{
			get { return _religion; }
			set { _religion = value; }
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

		public Religion()
		{ }

		public Religion(int religion_id,string religion,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.religion_id = religion_id;
			this.religion = religion;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "religion_id = " + religion_id.ToString() + ",religion = " + religion + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class religion_idComparer : System.Collections.Generic.IComparer<Religion>
		{
			public SorterMode SorterMode;
			public religion_idComparer()
			{ }
			public religion_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Religion> Membres
			int System.Collections.Generic.IComparer<Religion>.Compare(Religion x, Religion y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.religion_id.CompareTo(x.religion_id);
				}
				else
				{
					return x.religion_id.CompareTo(y.religion_id);
				}
			}
			#endregion
		}
		public class religionComparer : System.Collections.Generic.IComparer<Religion>
		{
			public SorterMode SorterMode;
			public religionComparer()
			{ }
			public religionComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Religion> Membres
			int System.Collections.Generic.IComparer<Religion>.Compare(Religion x, Religion y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.religion.CompareTo(x.religion);
				}
				else
				{
					return x.religion.CompareTo(y.religion);
				}
			}
			#endregion
		}
	}
}
