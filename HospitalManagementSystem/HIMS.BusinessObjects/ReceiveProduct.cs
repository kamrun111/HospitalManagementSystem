using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ReceiveProduct
	{
		private int _receive_product_id;

		public int receive_product_id
		{
			get { return _receive_product_id; }
			set { _receive_product_id = value; }
		}

		private int _receive_id;

		public int receive_id
		{
			get { return _receive_id; }
			set { _receive_id = value; }
		}

		private Nullable<int> _product_id;

		public Nullable<int> product_id
		{
			get { return _product_id; }
			set { _product_id = value; }
		}

		private Nullable<int> _receive_qty;

		public Nullable<int> receive_qty
		{
			get { return _receive_qty; }
			set { _receive_qty = value; }
		}

		private Nullable<int> _free_qty;

		public Nullable<int> free_qty
		{
			get { return _free_qty; }
			set { _free_qty = value; }
		}

		private Nullable<int> _refund_qty;

		public Nullable<int> refund_qty
		{
			get { return _refund_qty; }
			set { _refund_qty = value; }
		}

		private Nullable<Decimal> _unit_purchase_price;

		public Nullable<Decimal> unit_purchase_price
		{
			get { return _unit_purchase_price; }
			set { _unit_purchase_price = value; }
		}

		private Nullable<Decimal> _unit_cost;

		public Nullable<Decimal> unit_cost
		{
			get { return _unit_cost; }
			set { _unit_cost = value; }
		}

		private Nullable<DateTime> _exp_date;

		public Nullable<DateTime> exp_date
		{
			get { return _exp_date; }
			set { _exp_date = value; }
		}

		private string _batch_no;

		public string batch_no
		{
			get { return _batch_no; }
			set { _batch_no = value; }
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

		public ReceiveProduct()
		{ }

		public ReceiveProduct(int receive_product_id,int receive_id,Nullable<int> product_id,Nullable<int> receive_qty,Nullable<int> free_qty,Nullable<int> refund_qty,Nullable<Decimal> unit_purchase_price,Nullable<Decimal> unit_cost,Nullable<DateTime> exp_date,string batch_no,Nullable<int> store_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.receive_product_id = receive_product_id;
			this.receive_id = receive_id;
			this.product_id = product_id;
			this.receive_qty = receive_qty;
			this.free_qty = free_qty;
			this.refund_qty = refund_qty;
			this.unit_purchase_price = unit_purchase_price;
			this.unit_cost = unit_cost;
			this.exp_date = exp_date;
			this.batch_no = batch_no;
			this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "receive_product_id = " + receive_product_id.ToString() + ",receive_id = " + receive_id.ToString() + ",product_id = " + product_id.ToString() + ",receive_qty = " + receive_qty.ToString() + ",free_qty = " + free_qty.ToString() + ",refund_qty = " + refund_qty.ToString() + ",unit_purchase_price = " + unit_purchase_price.ToString() + ",unit_cost = " + unit_cost.ToString() + ",exp_date = " + exp_date.ToString() + ",batch_no = " + batch_no + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class receive_product_idComparer : System.Collections.Generic.IComparer<ReceiveProduct>
		{
			public SorterMode SorterMode;
			public receive_product_idComparer()
			{ }
			public receive_product_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<receive_product> Membres
			int System.Collections.Generic.IComparer<ReceiveProduct>.Compare(ReceiveProduct x, ReceiveProduct y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.receive_product_id.CompareTo(x.receive_product_id);
				}
				else
				{
					return x.receive_product_id.CompareTo(y.receive_product_id);
				}
			}
			#endregion
		}
		public class receive_idComparer : System.Collections.Generic.IComparer<ReceiveProduct>
		{
			public SorterMode SorterMode;
			public receive_idComparer()
			{ }
			public receive_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<receive_product> Membres
			int System.Collections.Generic.IComparer<ReceiveProduct>.Compare(ReceiveProduct x, ReceiveProduct y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.receive_id.CompareTo(x.receive_id);
				}
				else
				{
					return x.receive_id.CompareTo(y.receive_id);
				}
			}
			#endregion
		}
		public class batch_noComparer : System.Collections.Generic.IComparer<ReceiveProduct>
		{
			public SorterMode SorterMode;
			public batch_noComparer()
			{ }
			public batch_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<receive_product> Membres
			int System.Collections.Generic.IComparer<ReceiveProduct>.Compare(ReceiveProduct x, ReceiveProduct y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.batch_no.CompareTo(x.batch_no);
				}
				else
				{
					return x.batch_no.CompareTo(y.batch_no);
				}
			}
			#endregion
		}
	}
}
