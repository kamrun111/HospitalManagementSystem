using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InventoryBO
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

        private Nullable<int> _product_type_id;

        public Nullable<int> product_type_id
        {
            get { return _product_type_id; }
            set { _product_type_id = value; }

        }

        private Nullable<int> _product_category_id;

        public Nullable<int> product_category_id
        {
            get { return _product_category_id; }
            set { _product_category_id = value; }

        }

        private string _barcode;

        public string barcode
        {
            get { return _barcode; }
            set { _barcode = value; }

        }

       
        private Nullable<int> _openning_balance;

		public Nullable<int> openning_balance
		{
			get { return _openning_balance; }
			set { _openning_balance = value; }
		}

        private Nullable<int> _total_purchased;

        public Nullable<int> total_purchased
        {
            get { return _total_purchased; }
            set { _total_purchased = value; }

        }

        private Nullable<int> _purchase_refund;

        public Nullable<int> purchase_refund
        {
            get { return _purchase_refund; }
            set { _purchase_refund = value; }

        }

        private Nullable<int> _refund_qty;

        public Nullable<int> refund_qty
        {
            get { return _refund_qty; }
            set { _refund_qty = value; }

        }

        private Nullable<int> _total_sold;

        public Nullable<int> total_sold
        {
            get { return _total_sold; }
            set { _total_sold = value; }

        }

        private Nullable<int> _total_requisition_delivery;

        public Nullable<int> total_requisition_delivery
        {
            get { return _total_requisition_delivery; }
            set { _total_requisition_delivery = value; }

        }

        private Nullable<int> _requisition_refund;

        public Nullable<int> requisition_refund
        {
            get { return _requisition_refund; }
            set { _requisition_refund = value; }

        }

        private Nullable<int> _stock_in_hand;

        public Nullable<int> stock_in_hand
        {
            get { return _stock_in_hand; }
            set { _stock_in_hand = value; }

        }

        private Nullable<int> _faulty_qty;

        public Nullable<int> faulty_qty
        {
            get { return _faulty_qty; }
            set { _faulty_qty = value; }

        }

		private Nullable<int> _closing_balance;

		public Nullable<int> closing_balance
		{
			get { return _closing_balance; }
			set { _closing_balance = value; }
		}

		
        private Nullable<int> _realization;

        public Nullable<int> realization
        {
            get { return _realization; }
            set { _realization = value; }
        }

        private Nullable<DateTime> _opening_date;

        public Nullable<DateTime> opening_date
        {
            get { return _opening_date; }
            set { _opening_date = value; }
        }


        private Nullable<DateTime> _closing_date;

        public Nullable<DateTime> closing_date
        {
            get { return _closing_date; }
            set { _closing_date = value; }
        }

        private Nullable<decimal> _unit_purchase_price;

        public Nullable<decimal> unit_purchase_price
        {
            get { return _unit_purchase_price; }
            set { _unit_purchase_price = value; }

        }

        private Nullable<int> _store_id;

        public Nullable<int> store_id
        {
            get { return _store_id; }
            set { _store_id= value; }

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

		public InventoryBO()
		{ }

        public InventoryBO(int inventory_id, Nullable<int> product_id, Nullable<int> product_type_id, Nullable<int> product_category_id, string barcode, Nullable<int> openning_balance, Nullable<int> total_purchased, Nullable<int> purchase_refund, Nullable<int> refund_qty, Nullable<int> total_sold, Nullable<int> total_requisition_delivery, Nullable<int> requisition_refund, Nullable<int> stock_in_hand, Nullable<int> faulty_qty, Nullable<int> closing_balance, Nullable<int> realization, Nullable<DateTime> opening_date, Nullable<DateTime> closing_date, Nullable<decimal> unit_purchase_price, Nullable<int> store_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.inventory_id = inventory_id;
			this.product_id = product_id;
            this.product_type_id = product_type_id;
            this.product_category_id = product_category_id;
            this.barcode = barcode;
			this.openning_balance = openning_balance;
            this.total_purchased = total_purchased;
            this.purchase_refund = purchase_refund;
            this.refund_qty = refund_qty;
            this.total_sold= total_sold;
            this.total_requisition_delivery = total_requisition_delivery;
            this.requisition_refund = requisition_refund;
            this.stock_in_hand = stock_in_hand;
            this.faulty_qty = faulty_qty;
			this.closing_balance = closing_balance;
            this.realization = realization;
            this.opening_date = opening_date;
			this.closing_date = closing_date;
            this.unit_purchase_price = unit_purchase_price;
            this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "inventory_id = " + inventory_id.ToString() + ",product_id = " + product_id.ToString() + ",product_type_id = " + product_type_id.ToString() + ",product_category_id= " + product_category_id.ToString() + ",barcode =" + barcode + ",openning_balance = " + openning_balance.ToString() + ",total_purchased=" + total_purchased.ToString() + ",purchase_refund=" + purchase_refund.ToString() + ",refund_qyt=" + refund_qty.ToString() + ",total_sold=" + total_sold.ToString() + ",total_requisition_delivery=" + total_requisition_delivery.ToString() + ",requisition_refund=" + requisition_refund.ToString() + ",stock_in_hand=" + stock_in_hand.ToString() + ",faulty_qty=" + faulty_qty.ToString() + ",closing_balance = " + closing_balance.ToString() + ",realization=" + realization.ToString() + ",opening_date=" + opening_date.ToString() + ",closing_date = " + closing_date.ToString() + ",unit_purchase_price = " + unit_purchase_price.ToString() + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class inventory_idComparer : System.Collections.Generic.IComparer<InventoryBO>
		{
			public SorterMode SorterMode;
			public inventory_idComparer()
			{ }
			public inventory_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<inventory> Membres
			int System.Collections.Generic.IComparer<InventoryBO>.Compare(InventoryBO x, InventoryBO y)
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
