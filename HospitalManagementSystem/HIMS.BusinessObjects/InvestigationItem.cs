using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationItem
	{
		private int _investigation_item_id;

		public int investigation_item_id
		{
			get { return _investigation_item_id; }
			set { _investigation_item_id = value; }
		}

		private string _investigation_item;

		public string investigation_item
		{
			get { return _investigation_item; }
			set { _investigation_item = value; }
		}

		private Nullable<int> _unit_id;

		public Nullable<int> unit_id
		{
			get { return _unit_id; }
			set { _unit_id = value; }
		}

		private Nullable<int> _re_order_level;

		public Nullable<int> re_order_level
		{
			get { return _re_order_level; }
			set { _re_order_level = value; }
		}

		private Nullable<int> _considering_level;

		public Nullable<int> considering_level
		{
			get { return _considering_level; }
			set { _considering_level = value; }
		}

		private Nullable<Decimal> _current_stock;

		public Nullable<Decimal> current_stock
		{
			get { return _current_stock; }
			set { _current_stock = value; }
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

		public InvestigationItem()
		{ }

		public InvestigationItem(int investigation_item_id,string investigation_item,Nullable<int> unit_id,Nullable<int> re_order_level,Nullable<int> considering_level,Nullable<Decimal> current_stock,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.investigation_item_id = investigation_item_id;
			this.investigation_item = investigation_item;
			this.unit_id = unit_id;
			this.re_order_level = re_order_level;
			this.considering_level = considering_level;
			this.current_stock = current_stock;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "investigation_item_id = " + investigation_item_id.ToString() + ",investigation_item = " + investigation_item + ",unit_id = " + unit_id.ToString() + ",re_order_level = " + re_order_level.ToString() + ",considering_level = " + considering_level.ToString() + ",current_stock = " + current_stock.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class investigation_item_idComparer : System.Collections.Generic.IComparer<InvestigationItem>
		{
			public SorterMode SorterMode;
			public investigation_item_idComparer()
			{ }
			public investigation_item_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<InvestigationItem> Membres
			int System.Collections.Generic.IComparer<InvestigationItem>.Compare(InvestigationItem x, InvestigationItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investigation_item_id.CompareTo(x.investigation_item_id);
				}
				else
				{
					return x.investigation_item_id.CompareTo(y.investigation_item_id);
				}
			}
			#endregion
		}
		public class investigation_itemComparer : System.Collections.Generic.IComparer<InvestigationItem>
		{
			public SorterMode SorterMode;
			public investigation_itemComparer()
			{ }
			public investigation_itemComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<InvestigationItem> Membres
			int System.Collections.Generic.IComparer<InvestigationItem>.Compare(InvestigationItem x, InvestigationItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.investigation_item.CompareTo(x.investigation_item);
				}
				else
				{
                    return x.investigation_item.CompareTo(y.investigation_item);
				}
			}
			#endregion
		}
	}
}
