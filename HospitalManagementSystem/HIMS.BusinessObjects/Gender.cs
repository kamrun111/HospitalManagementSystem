using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Gender
	{
		private int _gender_id;

		public int gender_id
		{
			get { return _gender_id; }
			set { _gender_id = value; }
		}

		private string _gender;

		public string gender
		{
			get { return _gender; }
			set { _gender = value; }
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

		public Gender()
		{ }

		public Gender(int gender_id,string gender,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.gender_id = gender_id;
			this.gender = gender;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "gender_id = " + gender_id.ToString() + ",gender = " + gender + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

        public class gender_idComparer : System.Collections.Generic.IComparer<Gender>
		{
			public SorterMode SorterMode;
			public gender_idComparer()
			{ }
			public gender_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Gender> Membres
            int System.Collections.Generic.IComparer<Gender>.Compare(Gender x, Gender y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.gender_id.CompareTo(x.gender_id);
				}
				else
				{
					return x.gender_id.CompareTo(y.gender_id);
				}
			}
			#endregion
		}
		public class genderComparer : System.Collections.Generic.IComparer<Gender>
		{
			public SorterMode SorterMode;
			public genderComparer()
			{ }
			public genderComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Gender> Membres
            int System.Collections.Generic.IComparer<Gender>.Compare(Gender x, Gender y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.gender.CompareTo(x.gender);
				}
				else
				{
                    return x.gender.CompareTo(y.gender);
				}
			}
			#endregion
		}
	}
}
