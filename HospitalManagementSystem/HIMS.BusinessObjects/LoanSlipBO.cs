using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class LoanSlipBO
    {
        private int _loan_slip_id;

        public int loan_slip_id
		{
            get { return _loan_slip_id; }
            set { _loan_slip_id = value; }
		}

        private string _loan_slip_no;

        public string loan_slip_no
		{
            get { return _loan_slip_no; }
            set { _loan_slip_no = value; }
		}

        private Nullable<DateTime> _loan_slip_date;

        public Nullable<DateTime> loan_slip_date
		{
            get { return _loan_slip_date; }
            set { _loan_slip_date = value; }
		}

        private Nullable<int> _loan_employee_id;

        public Nullable<int> loan_employee_id
		{
            get { return _loan_employee_id; }
            set { _loan_employee_id = value; }
		}

        private Nullable<Decimal> _loan_slip_amount;

        public Nullable<Decimal> loan_slip_amount
		{
            get { return _loan_slip_amount; }
            set { _loan_slip_amount = value; }
		}

        private string _loan_slip_remarks;

        public string loan_slip_remarks
		{
            get { return _loan_slip_remarks; }
            set { _loan_slip_remarks = value; }
		}

        private Nullable<int> _status;

        public Nullable<int> status
		{
            get { return _status; }
            set { _status = value; }
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


        public LoanSlipBO()
		{ }
    }
}
