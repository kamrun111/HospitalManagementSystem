using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Cabin
	{
		private int _cabin_id;

		public int cabin_id
		{
			get { return _cabin_id; }
			set { _cabin_id = value; }
		}

		private string _cabin;

		public string cabin
		{
			get { return _cabin; }
			set { _cabin = value; }
		}

		private Nullable<int> _cabin_type_id;

		public Nullable<int> cabin_type_id
		{
			get { return _cabin_type_id; }
			set { _cabin_type_id = value; }
		}

		private Nullable<bool> _air_conditioned;

		public Nullable<bool> air_conditioned
		{
			get { return _air_conditioned; }
			set { _air_conditioned = value; }
		}

		private Nullable<int> _number_of_bed;

		public Nullable<int> number_of_bed
		{
			get { return _number_of_bed; }
			set { _number_of_bed = value; }
		}

		private Nullable<int> _floor_id;

		public Nullable<int> floor_id
		{
			get { return _floor_id; }
			set { _floor_id = value; }
		}

		private Nullable<int> _cabin_status_id;

		public Nullable<int> cabin_status_id
		{
			get { return _cabin_status_id; }
			set { _cabin_status_id = value; }
		}

		private Nullable<Decimal> _cabin_rate;

		public Nullable<Decimal> cabin_rate
		{
			get { return _cabin_rate; }
			set { _cabin_rate = value; }
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

		public Cabin()
		{ }

		public Cabin(int cabin_id,string cabin,Nullable<int> cabin_type_id,Nullable<bool> air_conditioned,Nullable<int> number_of_bed,Nullable<int> floor_id,Nullable<int> cabin_status_id,Nullable<Decimal> cabin_rate,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.cabin_id = cabin_id;
			this.cabin = cabin;
			this.cabin_type_id = cabin_type_id;
			this.air_conditioned = air_conditioned;
			this.number_of_bed = number_of_bed;
			this.floor_id = floor_id;
			this.cabin_status_id = cabin_status_id;
			this.cabin_rate = cabin_rate;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "cabin_id = " + cabin_id.ToString() + ",cabin = " + cabin + ",cabin_type_id = " + cabin_type_id.ToString() + ",air_conditioned = " + air_conditioned.ToString() + ",number_of_bed = " + number_of_bed.ToString() + ",floor_id = " + floor_id.ToString() + ",cabin_status_id = " + cabin_status_id.ToString() + ",cabin_rate = " + cabin_rate.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class cabin_idComparer : System.Collections.Generic.IComparer<Cabin>
		{
			public SorterMode SorterMode;
			public cabin_idComparer()
			{ }
			public cabin_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Cabin> Membres
			int System.Collections.Generic.IComparer<Cabin>.Compare(Cabin x, Cabin y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.cabin_id.CompareTo(x.cabin_id);
				}
				else
				{
					return x.cabin_id.CompareTo(y.cabin_id);
				}
			}
			#endregion
		}
		public class cabinComparer : System.Collections.Generic.IComparer<Cabin>
		{
			public SorterMode SorterMode;
			public cabinComparer()
			{ }
			public cabinComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Cabin> Membres
			int System.Collections.Generic.IComparer<Cabin>.Compare(Cabin x, Cabin y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.cabin.CompareTo(x.cabin);
				}
				else
				{
                    return x.cabin.CompareTo(y.cabin);
				}
			}
			#endregion
		}
	}
}
