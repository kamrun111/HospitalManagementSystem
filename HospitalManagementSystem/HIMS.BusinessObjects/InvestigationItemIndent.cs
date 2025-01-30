using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationItemIndent
	{
		private int _investigation_item_indent_id;

		public int investigation_item_indent_id
		{
			get { return _investigation_item_indent_id; }
			set { _investigation_item_indent_id = value; }
		}

		private Nullable<int> _investigation_item_id;

		public Nullable<int> investigation_item_id
		{
			get { return _investigation_item_id; }
			set { _investigation_item_id = value; }
		}

		private Nullable<Decimal> _order_qty;

		public Nullable<Decimal> order_qty
		{
			get { return _order_qty; }
			set { _order_qty = value; }
		}

		private Nullable<Decimal> _receive_qty;

		public Nullable<Decimal> receive_qty
		{
			get { return _receive_qty; }
			set { _receive_qty = value; }
		}

		private Nullable<Decimal> _delivery_qty;

		public Nullable<Decimal> delivery_qty
		{
			get { return _delivery_qty; }
			set { _delivery_qty = value; }
		}

		private Nullable<Decimal> _refund_qty;

		public Nullable<Decimal> refund_qty
		{
			get { return _refund_qty; }
			set { _refund_qty = value; }
		}

		private Nullable<DateTime> _indent_date;

		public Nullable<DateTime> indent_date
		{
			get { return _indent_date; }
			set { _indent_date = value; }
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

		public InvestigationItemIndent()
		{ }

		public InvestigationItemIndent(int investigation_item_indent_id,Nullable<int> investigation_item_id,Nullable<Decimal> order_qty,Nullable<Decimal> receive_qty,Nullable<Decimal> delivery_qty,Nullable<Decimal> refund_qty,Nullable<DateTime> indent_date,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.investigation_item_indent_id = investigation_item_indent_id;
			this.investigation_item_id = investigation_item_id;
			this.order_qty = order_qty;
			this.receive_qty = receive_qty;
			this.delivery_qty = delivery_qty;
			this.refund_qty = refund_qty;
			this.indent_date = indent_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "investigation_item_indent_id = " + investigation_item_indent_id.ToString() + ",investigation_item_id = " + investigation_item_id.ToString() + ",order_qty = " + order_qty.ToString() + ",receive_qty = " + receive_qty.ToString() + ",delivery_qty = " + delivery_qty.ToString() + ",refund_qty = " + refund_qty.ToString() + ",indent_date = " + indent_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class investigation_item_indent_idComparer : System.Collections.Generic.IComparer<InvestigationItemIndent>
		{
			public SorterMode SorterMode;
			public investigation_item_indent_idComparer()
			{ }
			public investigation_item_indent_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<investigation_item_indent> Membres
			int System.Collections.Generic.IComparer<InvestigationItemIndent>.Compare(InvestigationItemIndent x, InvestigationItemIndent y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investigation_item_indent_id.CompareTo(x.investigation_item_indent_id);
				}
				else
				{
					return x.investigation_item_indent_id.CompareTo(y.investigation_item_indent_id);
				}
			}
			#endregion
		}
	}
}
