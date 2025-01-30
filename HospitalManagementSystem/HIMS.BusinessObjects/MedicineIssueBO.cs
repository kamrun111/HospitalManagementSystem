using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class MedicineIssueBO
    {
        private int _patient_medicine_bill_id;

        public int patient_medicine_bill_id
		{
            get { return _patient_medicine_bill_id; }
            set { _patient_medicine_bill_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
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

        private Nullable<Decimal> _amount;

        public Nullable<Decimal> amount
		{
            get { return _amount; }
            set { _amount = value; }
		}
        private Nullable<Decimal> _discount;

        public Nullable<Decimal> discount
        {
            get { return _discount; }
            set { _discount = value; }
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

        public MedicineIssueBO()
		{ }
    }
}
