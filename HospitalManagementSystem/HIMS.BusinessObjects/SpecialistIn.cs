using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class SpecialistIn
	{
		private int _specialist_in_id;

		public int specialist_in_id
		{
			get { return _specialist_in_id; }
			set { _specialist_in_id = value; }
		}

		private string _specialist_in;

		public string specialist_in
		{
			get { return _specialist_in; }
			set { _specialist_in = value; }
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

		public SpecialistIn()
		{ }

		public SpecialistIn(int specialist_in_id,string specialist_in,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.specialist_in_id = specialist_in_id;
            this.specialist_in = specialist_in;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "specialist_in_id = " + specialist_in_id.ToString() + ",specialist_in = " + specialist_in + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class specialist_in_idComparer : System.Collections.Generic.IComparer<SpecialistIn>
		{
			public SorterMode SorterMode;
			public specialist_in_idComparer()
			{ }
			public specialist_in_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<SpecialistIn> Membres
            int System.Collections.Generic.IComparer<SpecialistIn>.Compare(SpecialistIn x, SpecialistIn y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.specialist_in_id.CompareTo(x.specialist_in_id);
				}
				else
				{
					return x.specialist_in_id.CompareTo(y.specialist_in_id);
				}
			}
			#endregion
		}
		public class specialist_inComparer : System.Collections.Generic.IComparer<SpecialistIn>
		{
			public SorterMode SorterMode;
			public specialist_inComparer()
			{ }
			public specialist_inComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<SpecialistIn> Membres
            int System.Collections.Generic.IComparer<SpecialistIn>.Compare(SpecialistIn x, SpecialistIn y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.specialist_in.CompareTo(x.specialist_in);
				}
				else
				{
                    return x.specialist_in.CompareTo(y.specialist_in);
				}
			}
			#endregion
		}
	}
}
