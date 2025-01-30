using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Sales
	{
		private int _sales_id;

		public int sales_id
		{
			get { return _sales_id; }
			set { _sales_id = value; }
		}

		private string _customer_name;

		public string customer_name
		{
			get { return _customer_name; }
			set { _customer_name = value; }
		}

		private string _adress;

		public string adress
		{
			get { return _adress; }
			set { _adress = value; }
		}

		private string _phone;

		public string phone
		{
			get { return _phone; }
			set { _phone = value; }
		}

		private Nullable<DateTime> _sales_date;

		public Nullable<DateTime> sales_date
		{
			get { return _sales_date; }
			set { _sales_date = value; }
		}

		private string _invoice_no;

		public string invoice_no
		{
			get { return _invoice_no; }
			set { _invoice_no = value; }
		}

		private Nullable<int> _payment_type_id;

		public Nullable<int> payment_type_id
		{
			get { return _payment_type_id; }
			set { _payment_type_id = value; }
		}

		private Nullable<bool> _is_inpatient;

		public Nullable<bool> is_inpatient
		{
			get { return _is_inpatient; }
			set { _is_inpatient = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
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

		private Nullable<Decimal> _discount;

		public Nullable<Decimal> discount
		{
			get { return _discount; }
			set { _discount = value; }
		}

		private Nullable<Decimal> _grand_total;

		public Nullable<Decimal> grand_total
		{
			get { return _grand_total; }
			set { _grand_total = value; }
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

		public Sales()
		{ }

		public Sales(int sales_id,string customer_name,string adress,string phone,Nullable<DateTime> sales_date,string invoice_no,Nullable<int> payment_type_id,Nullable<bool> is_inpatient,Nullable<int> admission_id,Nullable<int> store_id,string remarks,Nullable<Decimal> discount,Nullable<Decimal> grand_total,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.sales_id = sales_id;
			this.customer_name = customer_name;
			this.adress = adress;
			this.phone = phone;
			this.sales_date = sales_date;
			this.invoice_no = invoice_no;
			this.payment_type_id = payment_type_id;
			this.is_inpatient = is_inpatient;
			this.admission_id = admission_id;
			this.store_id = store_id;
			this.remarks = remarks;
			this.discount = discount;
			this.grand_total = grand_total;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "sales_id = " + sales_id.ToString() + ",customer_name = " + customer_name + ",adress = " + adress + ",phone = " + phone + ",sales_date = " + sales_date.ToString() + ",invoice_no = " + invoice_no + ",payment_type_id = " + payment_type_id.ToString() + ",is_inpatient = " + is_inpatient.ToString() + ",admission_id = " + admission_id.ToString() + ",store_id = " + store_id.ToString() + ",remarks = " + remarks + ",discount = " + discount.ToString() + ",grand_total = " + grand_total.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class sales_idComparer : System.Collections.Generic.IComparer<Sales>
		{
			public SorterMode SorterMode;
			public sales_idComparer()
			{ }
			public sales_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<sales> Membres
			int System.Collections.Generic.IComparer<Sales>.Compare(Sales x, Sales y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.sales_id.CompareTo(x.sales_id);
				}
				else
				{
					return x.sales_id.CompareTo(y.sales_id);
				}
			}
			#endregion
		}
		public class customer_nameComparer : System.Collections.Generic.IComparer<Sales>
		{
			public SorterMode SorterMode;
			public customer_nameComparer()
			{ }
			public customer_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<sales> Membres
			int System.Collections.Generic.IComparer<Sales>.Compare(Sales x, Sales y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.customer_name.CompareTo(x.customer_name);
				}
				else
				{
					return x.customer_name.CompareTo(y.customer_name);
				}
			}
			#endregion
		}
		public class adressComparer : System.Collections.Generic.IComparer<Sales>
		{
			public SorterMode SorterMode;
			public adressComparer()
			{ }
			public adressComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<sales> Membres
			int System.Collections.Generic.IComparer<Sales>.Compare(Sales x, Sales y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.adress.CompareTo(x.adress);
				}
				else
				{
					return x.adress.CompareTo(y.adress);
				}
			}
			#endregion
		}
		public class phoneComparer : System.Collections.Generic.IComparer<Sales>
		{
			public SorterMode SorterMode;
			public phoneComparer()
			{ }
			public phoneComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<sales> Membres
			int System.Collections.Generic.IComparer<Sales>.Compare(Sales x, Sales y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.phone.CompareTo(x.phone);
				}
				else
				{
					return x.phone.CompareTo(y.phone);
				}
			}
			#endregion
		}
		public class invoice_noComparer : System.Collections.Generic.IComparer<Sales>
		{
			public SorterMode SorterMode;
			public invoice_noComparer()
			{ }
			public invoice_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<sales> Membres
			int System.Collections.Generic.IComparer<Sales>.Compare(Sales x, Sales y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.invoice_no.CompareTo(x.invoice_no);
				}
				else
				{
					return x.invoice_no.CompareTo(y.invoice_no);
				}
			}
			#endregion
		}
		public class remarksComparer : System.Collections.Generic.IComparer<Sales>
		{
			public SorterMode SorterMode;
			public remarksComparer()
			{ }
			public remarksComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<sales> Membres
			int System.Collections.Generic.IComparer<Sales>.Compare(Sales x, Sales y)
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
