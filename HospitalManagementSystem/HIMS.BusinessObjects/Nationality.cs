using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Nationality
	{
		private int _nationality_id;

		public int nationality_id
		{
			get { return _nationality_id; }
			set { _nationality_id = value; }
		}

		private string _nationality;

		public string nationality
		{
			get { return _nationality; }
			set { _nationality = value; }
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

		public Nationality()
		{ }

		public Nationality(int nationality_id,string nationality,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.nationality_id = nationality_id;
			this.nationality = nationality;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "nationality_id = " + nationality_id.ToString() + ",nationality = " + nationality + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class nationality_idComparer : System.Collections.Generic.IComparer<Nationality>
		{
			public SorterMode SorterMode;
			public nationality_idComparer()
			{ }
			public nationality_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparerNationality Membres
            int System.Collections.Generic.IComparer<Nationality>.Compare(Nationality x, Nationality y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.nationality_id.CompareTo(x.nationality_id);
				}
				else
				{
					return x.nationality_id.CompareTo(y.nationality_id);
				}
			}
			#endregion
		}
		public class nationalityComparer : System.Collections.Generic.IComparer<Nationality>
		{
			public SorterMode SorterMode;
			public nationalityComparer()
			{ }
			public nationalityComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparerNationality Membres
			int System.Collections.Generic.IComparer<Nationality>.Compare(Nationality x, Nationality y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.nationality.CompareTo(x.nationality);
				}
				else
				{
                    return x.nationality.CompareTo(y.nationality);
				}
			}
			#endregion
		}
	}
}
