using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class MedicineTiming
	{
		private int _medicine_timing_id;

		public int medicine_timing_id
		{
			get { return _medicine_timing_id; }
			set { _medicine_timing_id = value; }
		}

		private string _medicine_timing;

		public string medicine_timing
		{
			get { return _medicine_timing; }
			set { _medicine_timing = value; }
		}

		private Nullable<int> _medicine_timing_value;

		public Nullable<int> medicine_timing_value
		{
			get { return _medicine_timing_value; }
			set { _medicine_timing_value = value; }
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

		public MedicineTiming()
		{ }

		public MedicineTiming(int medicine_timing_id,string medicine_timing,Nullable<int> medicine_timing_value,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.medicine_timing_id = medicine_timing_id;
			this.medicine_timing = medicine_timing;
			this.medicine_timing_value = medicine_timing_value;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "medicine_timing_id = " + medicine_timing_id.ToString() + ",medicine_timing = " + medicine_timing + ",medicine_timing_value = " + medicine_timing_value.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class medicine_timing_idComparer : System.Collections.Generic.IComparer<MedicineTiming>
		{
			public SorterMode SorterMode;
			public medicine_timing_idComparer()
			{ }
			public medicine_timing_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<MedicineTiming> Membres
			int System.Collections.Generic.IComparer<MedicineTiming>.Compare(MedicineTiming x, MedicineTiming y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.medicine_timing_id.CompareTo(x.medicine_timing_id);
				}
				else
				{
					return x.medicine_timing_id.CompareTo(y.medicine_timing_id);
				}
			}
			#endregion
		}
		public class medicine_timingComparer : System.Collections.Generic.IComparer<MedicineTiming>
		{
			public SorterMode SorterMode;
			public medicine_timingComparer()
			{ }
			public medicine_timingComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<MedicineTiming> Membres
			int System.Collections.Generic.IComparer<MedicineTiming>.Compare(MedicineTiming x, MedicineTiming y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.medicine_timing.CompareTo(x.medicine_timing);
				}
				else
				{
                    return x.medicine_timing.CompareTo(y.medicine_timing);
				}
			}
			#endregion
		}
	}
}
