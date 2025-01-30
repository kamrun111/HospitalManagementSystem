using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class RefundFaulty
	{
		private int _refund_faulty_id;

		public int refund_faulty_id
		{
			get { return _refund_faulty_id; }
			set { _refund_faulty_id = value; }
		}

		private Nullable<int> _receive_id;

		public Nullable<int> receive_id
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

		private Nullable<int> _refund_qty;

		public Nullable<int> refund_qty
		{
			get { return _refund_qty; }
			set { _refund_qty = value; }
		}

		private Nullable<bool> _is_faulty;

		public Nullable<bool> is_faulty
		{
			get { return _is_faulty; }
			set { _is_faulty = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
		}

		private string _remarks;

		public string remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
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

		public RefundFaulty()
		{ }

		public RefundFaulty(int refund_faulty_id,Nullable<int> receive_id,Nullable<int> product_id,Nullable<int> refund_qty,Nullable<bool> is_faulty,Nullable<int> store_id,string remarks,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.refund_faulty_id = refund_faulty_id;
			this.receive_id = receive_id;
			this.product_id = product_id;
			this.refund_qty = refund_qty;
			this.is_faulty = is_faulty;
			this.store_id = store_id;
			this.remarks = remarks;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "refund_faulty_id = " + refund_faulty_id.ToString() + ",receive_id = " + receive_id.ToString() + ",product_id = " + product_id.ToString() + ",refund_qty = " + refund_qty.ToString() + ",is_faulty = " + is_faulty.ToString() + ",store_id = " + store_id.ToString() + ",remarks = " + remarks + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class refund_faulty_idComparer : System.Collections.Generic.IComparer<RefundFaulty>
		{
			public SorterMode SorterMode;
			public refund_faulty_idComparer()
			{ }
			public refund_faulty_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<refund_faulty> Membres
			int System.Collections.Generic.IComparer<RefundFaulty>.Compare(RefundFaulty x, RefundFaulty y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.refund_faulty_id.CompareTo(x.refund_faulty_id);
				}
				else
				{
					return x.refund_faulty_id.CompareTo(y.refund_faulty_id);
				}
			}
			#endregion
		}
		public class remarksComparer : System.Collections.Generic.IComparer<RefundFaulty>
		{
			public SorterMode SorterMode;
			public remarksComparer()
			{ }
			public remarksComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<refund_faulty> Membres
			int System.Collections.Generic.IComparer<RefundFaulty>.Compare(RefundFaulty x, RefundFaulty y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.remarks.CompareTo(x.remarks);
				}
				else
				{
					return x.remarks.CompareTo(y.remarks);
				}
			}
			#endregion
		}
	}
}
