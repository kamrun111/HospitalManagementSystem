using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PurchaseProduct
	{
		private int _purchase_product_id;

		public int purchase_product_id
		{
			get { return _purchase_product_id; }
			set { _purchase_product_id = value; }
		}

		private Nullable<int> _purchase_id;

		public Nullable<int> purchase_id
		{
			get { return _purchase_id; }
			set { _purchase_id = value; }
		}

		private Nullable<int> _product_id;

		public Nullable<int> product_id
		{
			get { return _product_id; }
			set { _product_id = value; }
		}

		private Nullable<int> _order_qty;

		public Nullable<int> order_qty
		{
			get { return _order_qty; }
			set { _order_qty = value; }
		}

		private Nullable<int> _total_received_qty;

		public Nullable<int> total_received_qty
		{
			get { return _total_received_qty; }
			set { _total_received_qty = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
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

		public PurchaseProduct()
		{ }

		public PurchaseProduct(int purchase_product_id,Nullable<int> purchase_id,Nullable<int> product_id,Nullable<int> order_qty,Nullable<int> total_received_qty,Nullable<int> store_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.purchase_product_id = purchase_product_id;
			this.purchase_id = purchase_id;
			this.product_id = product_id;
			this.order_qty = order_qty;
			this.total_received_qty = total_received_qty;
			this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "purchase_product_id = " + purchase_product_id.ToString() + ",purchase_id = " + purchase_id.ToString() + ",product_id = " + product_id.ToString() + ",order_qty = " + order_qty.ToString() + ",total_received_qty = " + total_received_qty.ToString() + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class purchase_product_idComparer : System.Collections.Generic.IComparer<PurchaseProduct>
		{
			public SorterMode SorterMode;
			public purchase_product_idComparer()
			{ }
			public purchase_product_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<purchase_product> Membres
			int System.Collections.Generic.IComparer<PurchaseProduct>.Compare(PurchaseProduct x, PurchaseProduct y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.purchase_product_id.CompareTo(x.purchase_product_id);
				}
				else
				{
					return x.purchase_product_id.CompareTo(y.purchase_product_id);
				}
			}
			#endregion
		}
	}
}
