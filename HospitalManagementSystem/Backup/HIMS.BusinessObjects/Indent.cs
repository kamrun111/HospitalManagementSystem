using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Indent
	{
		private int _indent_id;

		public int indent_id
		{
			get { return _indent_id; }
			set { _indent_id = value; }
		}

		private Nullable<int> _item_id;

		public Nullable<int> item_id
		{
			get { return _item_id; }
			set { _item_id = value; }
		}

		private Nullable<Decimal> _quantity_ordered;

		public Nullable<Decimal> quantity_ordered
		{
			get { return _quantity_ordered; }
			set { _quantity_ordered = value; }
		}

		private Nullable<Decimal> _quantity_delivered;

		public Nullable<Decimal> quantity_delivered
		{
			get { return _quantity_delivered; }
			set { _quantity_delivered = value; }
		}

		private Nullable<Decimal> _quantity_received;

		public Nullable<Decimal> quantity_received
		{
			get { return _quantity_received; }
			set { _quantity_received = value; }
		}

		private Nullable<Decimal> _quantity_refunded;

		public Nullable<Decimal> quantity_refunded
		{
			get { return _quantity_refunded; }
			set { _quantity_refunded = value; }
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

		public Indent()
		{ }

		public Indent(int indent_id,Nullable<int> item_id,Nullable<Decimal> quantity_ordered,Nullable<Decimal> quantity_delivered,Nullable<Decimal> quantity_received,Nullable<Decimal> quantity_refunded,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.indent_id = indent_id;
			this.item_id = item_id;
			this.quantity_ordered = quantity_ordered;
			this.quantity_delivered = quantity_delivered;
			this.quantity_received = quantity_received;
			this.quantity_refunded = quantity_refunded;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "indent_id = " + indent_id.ToString() + ",item_id = " + item_id.ToString() + ",quantity_ordered = " + quantity_ordered.ToString() + ",quantity_delivered = " + quantity_delivered.ToString() + ",quantity_received = " + quantity_received.ToString() + ",quantity_refunded = " + quantity_refunded.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class indent_idComparer : System.Collections.Generic.IComparer<Indent>
		{
			public SorterMode SorterMode;
			public indent_idComparer()
			{ }
			public indent_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<indent> Membres
			int System.Collections.Generic.IComparer<Indent>.Compare(Indent x, Indent y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.indent_id.CompareTo(x.indent_id);
				}
				else
				{
					return x.indent_id.CompareTo(y.indent_id);
				}
			}
			#endregion
		}
	}
}
