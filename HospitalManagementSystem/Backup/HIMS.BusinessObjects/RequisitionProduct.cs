using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class RequisitionProduct
	{
		private int _requisition_product_id;

		public int requisition_product_id
		{
			get { return _requisition_product_id; }
			set { _requisition_product_id = value; }
		}

		private Nullable<int> _requisition_id;

		public Nullable<int> requisition_id
		{
			get { return _requisition_id; }
			set { _requisition_id = value; }
		}

		private Nullable<int> _product_id;

		public Nullable<int> product_id
		{
			get { return _product_id; }
			set { _product_id = value; }
		}

        private string _barcode;

        public string barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }


		private Nullable<int> _order_qty;

		public Nullable<int> order_qty
		{
			get { return _order_qty; }
			set { _order_qty = value; }
		}

        private Nullable<int> _delivery_qty;

        public Nullable<int> delivery_qty
        {
            get { return _delivery_qty; }
            set { _delivery_qty = value; }
        }
		private Nullable<int> _receive_qty;

		public Nullable<int> receive_qty
		{
			get { return _receive_qty; }
			set { _receive_qty = value; }
		}

		private Nullable<int> _refund_qty;

		public Nullable<int> refund_qty
		{
			get { return _refund_qty; }
			set { _refund_qty = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
		}

        private string _is_complete;

        public string is_complete
        {
            get { return _is_complete; }
            set { _is_complete = value; }
        }

      

		private Nullable<int> _record_created_by;

		public Nullable<int> record_created_by
		{
			get { return _record_created_by; }
			set { _record_created_by = value; }
		}

      

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public RequisitionProduct()
		{ }

		public RequisitionProduct(int requisition_product_id,Nullable<int> requisition_id,Nullable<int> product_id, string barcode ,Nullable<int> order_qty,Nullable<int> receive_qty,Nullable<int> refund_qty,Nullable<int> store_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.requisition_product_id = requisition_product_id;
			this.requisition_id = requisition_id;
			this.product_id = product_id;
            this.barcode = barcode;
			this.order_qty = order_qty;
            this.delivery_qty = delivery_qty;
			this.receive_qty = receive_qty;
			this.refund_qty = refund_qty;
			this.store_id = store_id;
            this.is_complete = is_complete;
			this.record_created_by = record_created_by;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "requisition_product_id = " + requisition_product_id.ToString() + ",requisition_id = " + requisition_id.ToString() + ",product_id = " + product_id.ToString() + ",barcode=" + barcode + ",order_qty = " + order_qty.ToString() + ",is_complete="+_is_complete.ToString()+",delivery_qty=" + delivery_qty.ToString() + ",receive_qty = " + receive_qty.ToString() + ",refund_qty = " + refund_qty.ToString() + ",store_id = " + store_id.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class requisition_product_idComparer : System.Collections.Generic.IComparer<RequisitionProduct>
		{
			public SorterMode SorterMode;
			public requisition_product_idComparer()
			{ }
			public requisition_product_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<requisition_product> Membres
			int System.Collections.Generic.IComparer<RequisitionProduct>.Compare(RequisitionProduct x, RequisitionProduct y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.requisition_product_id.CompareTo(x.requisition_product_id);
				}
				else
				{
					return x.requisition_product_id.CompareTo(y.requisition_product_id);
				}
			}
			#endregion
		}
	}
}
