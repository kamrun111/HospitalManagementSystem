using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class City
	{
		private int _city_id;

		public int city_id
		{
			get { return _city_id; }
			set { _city_id = value; }
		}

		private string _city;

		public string city
		{
			get { return _city; }
			set { _city = value; }
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

		public City()
		{ }

		public City(int city_id,string city,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.city_id = city_id;
			this.city = city;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "city_id = " + city_id.ToString() + ",city = " + city + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class city_idComparer : System.Collections.Generic.IComparer<City>
		{
			public SorterMode SorterMode;
			public city_idComparer()
			{ }
			public city_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<City> Membres
			int System.Collections.Generic.IComparer<City>.Compare(City x, City y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.city_id.CompareTo(x.city_id);
				}
				else
				{
					return x.city_id.CompareTo(y.city_id);
				}
			}
			#endregion
		}
		public class cityComparer : System.Collections.Generic.IComparer<City>
		{
			public SorterMode SorterMode;
			public cityComparer()
			{ }
			public cityComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<City> Membres
			int System.Collections.Generic.IComparer<City>.Compare(City x, City y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.city.CompareTo(x.city);
				}
				else
				{
                    return x.city.CompareTo(y.city);
				}
			}
			#endregion
		}
	}
}
