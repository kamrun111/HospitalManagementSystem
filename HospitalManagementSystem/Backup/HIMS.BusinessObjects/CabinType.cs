using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class CabinType
	{
		private int _cabin_type_id;

		public int cabin_type_id
		{
			get { return _cabin_type_id; }
			set { _cabin_type_id = value; }
		}

		private string _cabin_type;

		public string cabin_type
		{
			get { return _cabin_type; }
			set { _cabin_type = value; }
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

		public CabinType()
		{ }

        public CabinType(int cabin_type_id, string cabin_type, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.cabin_type_id = cabin_type_id;
			this.cabin_type = cabin_type;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "cabin_type_id = " + cabin_type_id.ToString() + ",cabin_type = " + cabin_type + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class cabin_type_idComparer : System.Collections.Generic.IComparer<CabinType>
		{
			public SorterMode SorterMode;
			public cabin_type_idComparer()
			{ }
			public cabin_type_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<CabinType> Membres
			int System.Collections.Generic.IComparer<CabinType>.Compare(CabinType x, CabinType y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.cabin_type_id.CompareTo(x.cabin_type_id);
				}
				else
				{
					return x.cabin_type_id.CompareTo(y.cabin_type_id);
				}
			}
			#endregion
		}
		public class cabin_typeComparer : System.Collections.Generic.IComparer<CabinType>
		{
			public SorterMode SorterMode;
			public cabin_typeComparer()
			{ }
			public cabin_typeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<CabinType> Membres
			int System.Collections.Generic.IComparer<CabinType>.Compare(CabinType x, CabinType y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.cabin_type.CompareTo(x.cabin_type);
				}
				else
				{
                    return x.cabin_type.CompareTo(y.cabin_type);
				}
			}
			#endregion
		}
	}
}
