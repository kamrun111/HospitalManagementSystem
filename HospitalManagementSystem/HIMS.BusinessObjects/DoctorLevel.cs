using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class DoctorLevel
	{
		private int _doctor_level_id;

		public int doctor_level_id
		{
			get { return _doctor_level_id; }
			set { _doctor_level_id = value; }
		}

		private string _doctor_level;

		public string doctor_level
		{
			get { return _doctor_level; }
			set { _doctor_level = value; }
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

		public DoctorLevel()
		{ }

		public DoctorLevel(int doctor_level_id,string doctor_level,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.doctor_level_id = doctor_level_id;
			this.doctor_level = doctor_level;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "doctor_level_id = " + doctor_level_id.ToString() + ",doctor_level = " + doctor_level + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class doctor_level_idComparer : System.Collections.Generic.IComparer<DoctorLevel>
		{
			public SorterMode SorterMode;
			public doctor_level_idComparer()
			{ }
			public doctor_level_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<DoctorLevel> Membres
			int System.Collections.Generic.IComparer<DoctorLevel>.Compare(DoctorLevel x, DoctorLevel y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.doctor_level_id.CompareTo(x.doctor_level_id);
				}
				else
				{
					return x.doctor_level_id.CompareTo(y.doctor_level_id);
				}
			}
			#endregion
		}
		public class doctor_levelComparer : System.Collections.Generic.IComparer<DoctorLevel>
		{
			public SorterMode SorterMode;
			public doctor_levelComparer()
			{ }
			public doctor_levelComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<DoctorLevel> Membres
			int System.Collections.Generic.IComparer<DoctorLevel>.Compare(DoctorLevel x, DoctorLevel y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.doctor_level.CompareTo(x.doctor_level);
				}
				else
				{
                    return x.doctor_level.CompareTo(y.doctor_level);
				}
			}
			#endregion
		}
	}
}
