using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationBO
	{
		private int _investigation_id;

		public int investigation_id
		{
			get { return _investigation_id; }
			set { _investigation_id = value; }
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

        private decimal _total_amount;

        public decimal total_amount
        {
            get { return _total_amount; }
            set { _total_amount = value; }
        }

        private Nullable<decimal> _total_tube_amount;

        public Nullable<decimal> total_tube_amount
        {
            get { return _total_tube_amount; }
            set { _total_tube_amount = value; }
        }
        private Nullable<decimal> _discount;

        public Nullable<decimal> discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        private string _remarks;

        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

		private Nullable<DateTime> _order_date;

		public Nullable<DateTime> order_date
		{
			get { return _order_date; }
			set { _order_date = value; }
		}

        private Nullable<int> _invest_ref_doctor_id;

        public Nullable<int> invest_ref_doctor_id
		{
            get { return _invest_ref_doctor_id; }
            set { _invest_ref_doctor_id = value; }
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

		public InvestigationBO()
		{ }

		public InvestigationBO(int investigation_id,Nullable<int> admission_id,Nullable<int> patient_id,decimal total_amount,Nullable<DateTime> order_date,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.investigation_id = investigation_id;
			this.admission_id = admission_id;
			this.patient_id = patient_id;
            this.total_amount = total_amount;
			this.order_date = order_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "investigation_id = " + investigation_id.ToString() + ",admission_id = " + admission_id.ToString() + ",patient_id = " + patient_id.ToString() + ",total_amount ="+total_amount.ToString()+", order_date = " + order_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class investigation_idComparer : System.Collections.Generic.IComparer<InvestigationBO>
		{
			public SorterMode SorterMode;
			public investigation_idComparer()
			{ }
			public investigation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<investigation> Membres
			int System.Collections.Generic.IComparer<InvestigationBO>.Compare(InvestigationBO x, InvestigationBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investigation_id.CompareTo(x.investigation_id);
				}
				else
				{
					return x.investigation_id.CompareTo(y.investigation_id);
				}
			}
			#endregion
		}
	}
}
