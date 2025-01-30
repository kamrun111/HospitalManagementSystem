using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Occupation
	{
		private int _occupation_id;

		public int occupation_id
		{
			get { return _occupation_id; }
			set { _occupation_id = value; }
		}

		private string _occupation;

		public string occupation
		{
			get { return _occupation; }
			set { _occupation = value; }
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

		public Occupation()
		{ }

		public Occupation(int occupation_id,string occupation,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.occupation_id = occupation_id;
			this.occupation = occupation;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "occupation_id = " + occupation_id.ToString() + ",occupation = " + occupation + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class occupation_idComparer : System.Collections.Generic.IComparer<Occupation>
		{
			public SorterMode SorterMode;
			public occupation_idComparer()
			{ }
			public occupation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Occupation> Membres
			int System.Collections.Generic.IComparer<Occupation>.Compare(Occupation x, Occupation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.occupation_id.CompareTo(x.occupation_id);
				}
				else
				{
					return x.occupation_id.CompareTo(y.occupation_id);
				}
			}
			#endregion
		}
		public class occupationComparer : System.Collections.Generic.IComparer<Occupation>
		{
			public SorterMode SorterMode;
			public occupationComparer()
			{ }
			public occupationComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Occupation> Membres
			int System.Collections.Generic.IComparer<Occupation>.Compare(Occupation x, Occupation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.occupation.CompareTo(x.occupation);
				}
				else
				{
                    return x.occupation.CompareTo(y.occupation);
				}
			}
			#endregion
		}
	}
}
