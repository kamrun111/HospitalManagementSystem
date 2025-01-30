using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Inventory
	{
		private int _inventory_id;

		public int inventory_id
		{
			get { return _inventory_id; }
			set { _inventory_id = value; }
		}

		private Nullable<int> _product_id;

		public Nullable<int> product_id
		{
			get { return _product_id; }
			set { _product_id = value; }
		}

		private Nullable<int> _openning_balance;

		public Nullable<int> openning_balance
		{
			get { return _openning_balance; }
			set { _openning_balance = value; }
		}

		private Nullable<int> _closing_balance;

		public Nullable<int> closing_balance
		{
			get { return _closing_balance; }
			set { _closing_balance = value; }
		}

		private Nullable<DateTime> _closing_date;

		public Nullable<DateTime> closing_date
		{
			get { return _closing_date; }
			set { _closing_date = value; }
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

		public Inventory()
		{ }

		public Inventory(int inventory_id,Nullable<int> product_id,Nullable<int> openning_balance,Nullable<int> closing_balance,Nullable<DateTime> closing_date,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.inventory_id = inventory_id;
			this.product_id = product_id;
			this.openning_balance = openning_balance;
			this.closing_balance = closing_balance;
			this.closing_date = closing_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "inventory_id = " + inventory_id.ToString() + ",product_id = " + product_id.ToString() + ",openning_balance = " + openning_balance.ToString() + ",closing_balance = " + closing_balance.ToString() + ",closing_date = " + closing_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class inventory_idComparer : System.Collections.Generic.IComparer<Inventory>
		{
			public SorterMode SorterMode;
			public inventory_idComparer()
			{ }
			public inventory_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<inventory> Membres
			int System.Collections.Generic.IComparer<Inventory>.Compare(Inventory x, Inventory y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.inventory_id.CompareTo(x.inventory_id);
				}
				else
				{
					return x.inventory_id.CompareTo(y.inventory_id);
				}
			}
			#endregion
		}
	}
}
