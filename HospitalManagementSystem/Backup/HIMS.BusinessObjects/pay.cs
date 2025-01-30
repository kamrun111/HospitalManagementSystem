using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Pay
	{
        private int _pay_id;

		public int pay_id
		{
			get { return _pay_id; }
			set { _pay_id = value; }
		}

        private string _payment_invoice_no;

        public string payment_invoice_no
        {
            get { return _payment_invoice_no; }
            set { _payment_invoice_no = value; }
        }

		private Nullable<int> _admission_id;

        public Nullable<int> admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }
        }
        private Nullable<DateTime> _pay_date;

		public Nullable<DateTime> pay_date
		{
			get { return _pay_date; }
			set { _pay_date = value; }
		}
		
        private Nullable<Decimal> _amount;

		public Nullable<Decimal> amount
		{
			get { return _amount; }
			set { _amount = value; }
		}


        private Nullable<int> _payment_type_id;

        public Nullable<int> payment_type_id
        {
            get { return _payment_type_id; }
            set { _payment_type_id = value; }
        }

		private Nullable<int> _status;

		public Nullable<int> status
		{
			get { return _status; }
			set { _status = value; }
		}

        private Nullable<int> _is_doctors_bill;

        public Nullable<int> is_doctors_bill
        {
            get { return _is_doctors_bill; }
            set { _is_doctors_bill = value; }
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

		public Pay()
		{ }

        public Pay(int pay_id,string payment_invoice_no, Nullable<int> admission_id, Nullable<DateTime> pay_date, Nullable<Decimal> amount, Nullable<int> payment_type_id, Nullable<SByte> status,Nullable<SByte> is_doctors_bill,Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.pay_id = pay_id;
            this.payment_invoice_no = payment_invoice_no;
            this.admission_id = admission_id;
            this.pay_date = pay_date;
            this.amount = amount;
            this.payment_type_id = payment_type_id;
            this.status = status;
            this.is_doctors_bill = is_doctors_bill;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "pay_id = " + pay_id.ToString() + ",payment_invoice_no=" + payment_invoice_no + ",admission_id = " + admission_id.ToString() + ",pay_date = " + pay_date.ToString() + ",amount = " + amount.ToString() + ",payment_type_id = " + payment_type_id.ToString() + ",status = " + status.ToString() + ",is_doctors_bill = " + is_doctors_bill.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class pay_idComparer : System.Collections.Generic.IComparer<Pay>
		{
			public SorterMode SorterMode;
			public pay_idComparer()
			{ }
            public pay_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<pay> Membres
            int System.Collections.Generic.IComparer<Pay>.Compare(Pay x, Pay y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.pay_id.CompareTo(x.pay_id);
				}
				else
				{
                    return x.pay_id.CompareTo(y.pay_id);
				}
			}
			#endregion
		}
       
   
		}
	}

