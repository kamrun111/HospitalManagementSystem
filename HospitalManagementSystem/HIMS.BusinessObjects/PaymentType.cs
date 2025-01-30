using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PaymentType
	{
		private int _payment_type_id;

		public int payment_type_id
		{
			get { return _payment_type_id; }
			set { _payment_type_id = value; }
		}

		private string _payment_type;

		public string payment_type
		{
			get { return _payment_type; }
			set { _payment_type = value; }
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

		public PaymentType()
		{ }

		public PaymentType(int payment_type_id,string payment_type,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.payment_type_id = payment_type_id;
			this.payment_type = payment_type;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "payment_type_id = " + payment_type_id.ToString() + ",payment_type = " + payment_type + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class payment_type_idComparer : System.Collections.Generic.IComparer<PaymentType>
		{
			public SorterMode SorterMode;
			public payment_type_idComparer()
			{ }
			public payment_type_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<PaymentType> Membres
			int System.Collections.Generic.IComparer<PaymentType>.Compare(PaymentType x, PaymentType y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.payment_type_id.CompareTo(x.payment_type_id);
				}
				else
				{
					return x.payment_type_id.CompareTo(y.payment_type_id);
				}
			}
			#endregion
		}
		public class payment_typeComparer : System.Collections.Generic.IComparer<PaymentType>
		{
			public SorterMode SorterMode;
			public payment_typeComparer()
			{ }
			public payment_typeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<PaymentType> Membres
			int System.Collections.Generic.IComparer<PaymentType>.Compare(PaymentType x, PaymentType y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.payment_type.CompareTo(x.payment_type);
				}
				else
				{
                    return x.payment_type.CompareTo(y.payment_type);
				}
			}
			#endregion
		}
	}
}
