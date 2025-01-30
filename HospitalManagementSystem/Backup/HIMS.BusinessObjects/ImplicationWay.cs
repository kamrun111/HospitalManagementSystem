using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ImplicationWay
	{
		private int _implication_way_id;

		public int implication_way_id
		{
			get { return _implication_way_id; }
			set { _implication_way_id = value; }
		}

		private string _implication_way;

        public string implication_way
		{
			get { return _implication_way; }
			set { _implication_way = value; }
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

		public ImplicationWay()
		{ }

		public ImplicationWay(int implication_way_id,string implication_way,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.implication_way_id = implication_way_id;
			this.implication_way = implication_way;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "implication_way_id = " + implication_way_id.ToString() + ",implication_way = " + implication_way + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class implication_way_idComparer : System.Collections.Generic.IComparer<ImplicationWay>
		{
			public SorterMode SorterMode;
			public implication_way_idComparer()
			{ }
			public implication_way_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<ImplicationWay> Membres
			int System.Collections.Generic.IComparer<ImplicationWay>.Compare(ImplicationWay x, ImplicationWay y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.implication_way_id.CompareTo(x.implication_way_id);
				}
				else
				{
					return x.implication_way_id.CompareTo(y.implication_way_id);
				}
			}
			#endregion
		}
		public class implication_wayComparer : System.Collections.Generic.IComparer<ImplicationWay>
		{
			public SorterMode SorterMode;
			public implication_wayComparer()
			{ }
			public implication_wayComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<ImplicationWay> Membres
			int System.Collections.Generic.IComparer<ImplicationWay>.Compare(ImplicationWay x, ImplicationWay y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.implication_way.CompareTo(x.implication_way);
				}
				else
				{
                    return x.implication_way.CompareTo(y.implication_way);
				}
			}
			#endregion
		}
	}
}
