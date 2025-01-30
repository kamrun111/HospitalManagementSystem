using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class CabinTranfer
	{
		private int _cabin_tranfer_id;

		public int cabin_tranfer_id
		{
			get { return _cabin_tranfer_id; }
			set { _cabin_tranfer_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<int> _cabin_id;

		public Nullable<int> cabin_id
		{
			get { return _cabin_id; }
			set { _cabin_id = value; }
		}

		private Nullable<DateTime> _from_date;

		public Nullable<DateTime> from_date
		{
			get { return _from_date; }
			set { _from_date = value; }
		}

		private Nullable<DateTime> _to_date;

		public Nullable<DateTime> to_date
		{
			get { return _to_date; }
			set { _to_date = value; }
		}

		private Nullable<Decimal> _amount;

		public Nullable<Decimal> amount
		{
			get { return _amount; }
			set { _amount = value; }
		}

        private Nullable<Decimal> _service_amount;

        public Nullable<Decimal> service_amount
        {
            get { return _service_amount; }
            set { _service_amount = value; }
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

		public CabinTranfer()
		{ }

		public CabinTranfer(int cabin_tranfer_id,Nullable<int> admission_id,Nullable<int> cabin_id,Nullable<DateTime> from_date,Nullable<DateTime> to_date,Nullable<Decimal> amount,Nullable<Decimal> service_amount, Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.cabin_tranfer_id = cabin_tranfer_id;
			this.admission_id = admission_id;
			this.cabin_id = cabin_id;
			this.from_date = from_date;
			this.to_date = to_date;
			this.amount = amount;
            this.service_amount = service_amount;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "cabin_tranfer_id = " + cabin_tranfer_id.ToString() + ",admission_id = " + admission_id.ToString() + ",cabin_id = " + cabin_id.ToString() + ",from_date = " + from_date.ToString() + ",to_date = " + to_date.ToString() + ",amount = " + amount.ToString() + ",service_amount="+service_amount.ToString()+", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class cabin_tranfer_idComparer : System.Collections.Generic.IComparer<CabinTranfer>
		{
			public SorterMode SorterMode;
			public cabin_tranfer_idComparer()
			{ }
			public cabin_tranfer_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<cabin_tranfer> Membres
			int System.Collections.Generic.IComparer<CabinTranfer>.Compare(CabinTranfer x, CabinTranfer y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.cabin_tranfer_id.CompareTo(x.cabin_tranfer_id);
				}
				else
				{
					return x.cabin_tranfer_id.CompareTo(y.cabin_tranfer_id);
				}
			}
			#endregion
		}
	}
}
