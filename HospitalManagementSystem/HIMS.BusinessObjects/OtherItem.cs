using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OtherItem
	{
		private int _other_item_id;

		public int other_item_id
		{
			get { return _other_item_id; }
			set { _other_item_id = value; }
		}

		private string _other_item;

		public string other_item
		{
			get { return _other_item; }
			set { _other_item = value; }
		}

		private Nullable<Decimal> _unit_rate;

		public Nullable<Decimal> unit_rate
		{
			get { return _unit_rate; }
			set { _unit_rate = value; }
		}

		private Nullable<int> _unit_id;

		public Nullable<int> unit_id
		{
			get { return _unit_id; }
			set { _unit_id = value; }
		}
        private Nullable<int> _stock;

        public Nullable<int> stock
        {
            get { return _stock; }
            set { _stock = value; }
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

		public OtherItem()
		{ }

		public OtherItem(int other_item_id,string other_item,Nullable<Decimal> unit_rate,Nullable<int> unit_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.other_item_id = other_item_id;
			this.other_item = other_item;
			this.unit_rate = unit_rate;
			this.unit_id = unit_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "other_item_id = " + other_item_id.ToString() + ",other_item = " + other_item + ",unit_rate = " + unit_rate.ToString() + ",unit_id = " + unit_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class other_item_idComparer : System.Collections.Generic.IComparer<OtherItem>
		{
			public SorterMode SorterMode;
			public other_item_idComparer()
			{ }
			public other_item_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<OtherItem> Membres
			int System.Collections.Generic.IComparer<OtherItem>.Compare(OtherItem x, OtherItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.other_item_id.CompareTo(x.other_item_id);
				}
				else
				{
					return x.other_item_id.CompareTo(y.other_item_id);
				}
			}
			#endregion
		}
		public class other_itemComparer : System.Collections.Generic.IComparer<OtherItem>
		{
			public SorterMode SorterMode;
			public other_itemComparer()
			{ }
			public other_itemComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<OtherItem> Membres
			int System.Collections.Generic.IComparer<OtherItem>.Compare(OtherItem x, OtherItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.other_item.CompareTo(x.other_item);
				}
				else
				{
                    return x.other_item.CompareTo(y.other_item);
				}
			}
			#endregion
		}
	}
}
