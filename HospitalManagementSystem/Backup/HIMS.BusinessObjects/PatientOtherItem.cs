using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientOtherItem
	{
		private int _patient_other_item_id;

		public int patient_other_item_id
		{
			get { return _patient_other_item_id; }
			set { _patient_other_item_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

        private Nullable<int> _patient_id;

        public Nullable<int> patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }

		private Nullable<int> _other_item_id;

		public Nullable<int> other_item_id
		{
			get { return _other_item_id; }
			set { _other_item_id = value; }
		}

		private Nullable<DateTime> _issue_date;

		public Nullable<DateTime> issue_date
		{
			get { return _issue_date; }
			set { _issue_date = value; }
		}

		private Nullable<DateTime> _return_date;

		public Nullable<DateTime> return_date
		{
			get { return _return_date; }
			set { _return_date = value; }
		}

		private Nullable<Decimal> _consume_qty;

		public Nullable<Decimal> consume_qty
		{
			get { return _consume_qty; }
			set { _consume_qty = value; }
		}

		private Nullable<Decimal> _qty_per_unit;

		public Nullable<Decimal> qty_per_unit
		{
			get { return _qty_per_unit; }
			set { _qty_per_unit = value; }
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

		public PatientOtherItem()
		{ }

        public PatientOtherItem(int patient_other_item_id, Nullable<int> admission_id, Nullable<int> patient_id, Nullable<int> other_item_id, Nullable<DateTime> issue_date, Nullable<DateTime> return_date, Nullable<Decimal> consume_qty, Nullable<Decimal> qty_per_unit, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.patient_other_item_id = patient_other_item_id;
			this.admission_id = admission_id;
            this.patient_id = this.patient_id;
			this.other_item_id = other_item_id;
			this.issue_date = issue_date;
			this.return_date = return_date;
			this.consume_qty = consume_qty;
			this.qty_per_unit = qty_per_unit;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "patient_other_item_id = " + patient_other_item_id.ToString() + ",admission_id = " + admission_id.ToString() + ",patient_id=" + patient_id.ToString()+ ",other_item_id = " + other_item_id.ToString() + ",issue_date = " + issue_date.ToString() + ",return_date = " + return_date.ToString() + ",consume_qty = " + consume_qty.ToString() + ",qty_per_unit = " + qty_per_unit.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_other_item_idComparer : System.Collections.Generic.IComparer<PatientOtherItem>
		{
			public SorterMode SorterMode;
			public patient_other_item_idComparer()
			{ }
			public patient_other_item_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_other_item> Membres
			int System.Collections.Generic.IComparer<PatientOtherItem>.Compare(PatientOtherItem x, PatientOtherItem y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_other_item_id.CompareTo(x.patient_other_item_id);
				}
				else
				{
					return x.patient_other_item_id.CompareTo(y.patient_other_item_id);
				}
			}
			#endregion
		}
	}
}
