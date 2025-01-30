using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Designation
	{
		private int _designation_id;

		public int designation_id
		{
			get { return _designation_id; }
			set { _designation_id = value; }
		}

		private string _designation;

		public string designation
		{
			get { return _designation; }
			set { _designation = value; }
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

		public Designation()
		{ }

		public Designation(int designation_id,string designation,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.designation_id = designation_id;
			this.designation = designation;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "designation_id = " + designation_id.ToString() + ",designation = " + designation + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class designation_idComparer : System.Collections.Generic.IComparer<Designation>
		{
			public SorterMode SorterMode;
			public designation_idComparer()
			{ }
			public designation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Designation> Membres
			int System.Collections.Generic.IComparer<Designation>.Compare(Designation x, Designation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.designation_id.CompareTo(x.designation_id);
				}
				else
				{
					return x.designation_id.CompareTo(y.designation_id);
				}
			}
			#endregion
		}
		public class designationComparer : System.Collections.Generic.IComparer<Designation>
		{
			public SorterMode SorterMode;
			public designationComparer()
			{ }
			public designationComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Designation> Membres
			int System.Collections.Generic.IComparer<Designation>.Compare(Designation x, Designation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.designation.CompareTo(x.designation);
				}
				else
				{
                    return x.designation.CompareTo(y.designation);
				}
			}
			#endregion
		}
	}
}
