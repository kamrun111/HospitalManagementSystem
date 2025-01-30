using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PurchaseBO
	{
		private int _purchase_id;

		public int purchase_id
		{
			get { return _purchase_id; }
			set { _purchase_id = value; }
		}

		private string _purchase;

		public string purchase
		{
			get { return _purchase; }
			set { _purchase = value; }
		}

		private Nullable<DateTime> _order_date;

		public Nullable<DateTime> order_date
		{
			get { return _order_date; }
			set { _order_date = value; }
		}

        private Nullable<DateTime> _cancelation_date;

        public Nullable<DateTime> cancelation_date
        {
            get { return _cancelation_date; }
            set { _cancelation_date = value; }
        }

		private Nullable<int> _supplier_id;

		public Nullable<int> supplier_id
		{
			get { return _supplier_id; }
			set { _supplier_id = value; }
		}

        private int _confurmmation_id;

        public int confurmmation_id
        {
            get { return _confurmmation_id; }
            set { _confurmmation_id = value; }
        }

        private string _indent_no;

        public string indent_no
        {
            get { return _indent_no; }
            set { _indent_no = value; }
        }

        private DateTime _indent_date;

        public DateTime indent_date
        {
            get { return _indent_date; }
            set { _indent_date = value; }
        }

		private Nullable<bool> _is_complete;

		public Nullable<bool> is_complete
		{
			get { return _is_complete; }
			set { _is_complete = value; }
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

		public PurchaseBO()
		{ }

        public PurchaseBO(int purchase_id, string purchase, Nullable<DateTime> order_date, Nullable<DateTime> cancelation_date, Nullable<int> supplier_id,int confurmmation_id, Nullable<bool> is_complete, Nullable<int> store_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.purchase_id = purchase_id;
			this.purchase = purchase;
			this.order_date = order_date;
            this.cancelation_date = cancelation_date;
			this.supplier_id = supplier_id;
            this.confurmmation_id = confurmmation_id;
			this.is_complete = is_complete;
			this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "purchase_id = " + purchase_id.ToString() + ",purchase = " + purchase + ",order_date = " + order_date.ToString() + ",cancelation_date = " + cancelation_date.ToString() + ",supplier_id = " + supplier_id.ToString() + ",confurmmation_id= " + confurmmation_id.ToString() +", is_complete = " + is_complete.ToString() + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class purchase_idComparer : System.Collections.Generic.IComparer<PurchaseBO>
		{
			public SorterMode SorterMode;
			public purchase_idComparer()
			{ }
			public purchase_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Purchase> Membres
			int System.Collections.Generic.IComparer<PurchaseBO>.Compare(PurchaseBO x, PurchaseBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.purchase_id.CompareTo(x.purchase_id);
				}
				else
				{
					return x.purchase_id.CompareTo(y.purchase_id);
				}
			}
			#endregion
		}
		public class purchaseComparer : System.Collections.Generic.IComparer<PurchaseBO>
		{
			public SorterMode SorterMode;
			public purchaseComparer()
			{ }
			public purchaseComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Purchase> Membres
			int System.Collections.Generic.IComparer<PurchaseBO>.Compare(PurchaseBO x, PurchaseBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.purchase.CompareTo(x.purchase);
				}
				else
				{
                    return x.purchase.CompareTo(y.purchase);
				}
			}
			#endregion
		}
	}
}
