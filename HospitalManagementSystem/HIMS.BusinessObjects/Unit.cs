using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Unit
	{
		private int _unit_id;

		public int unit_id
		{
			get { return _unit_id; }
			set { _unit_id = value; }
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

		public Unit()
		{ }

		public Unit(int unit_id,string unit,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.unit_id = unit_id;
			this.unit = unit;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "unit_id = " + unit_id.ToString() + ",unit = " + unit + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class unit_idComparer : System.Collections.Generic.IComparer<Unit>
		{
			public SorterMode SorterMode;
			public unit_idComparer()
			{ }
			public unit_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Unit> Membres
			int System.Collections.Generic.IComparer<Unit>.Compare(Unit x, Unit y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.unit_id.CompareTo(x.unit_id);
				}
				else
				{
					return x.unit_id.CompareTo(y.unit_id);
				}
			}
			#endregion
		}
		public class unitComparer : System.Collections.Generic.IComparer<Unit>
		{
			public SorterMode SorterMode;
			public unitComparer()
			{ }
			public unitComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Unit> Membres
			int System.Collections.Generic.IComparer<Unit>.Compare(Unit x, Unit y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.unit.CompareTo(x.unit);
				}
				else
				{
                    return x.unit.CompareTo(y.unit);
				}
			}
			#endregion
		}
	}
}
