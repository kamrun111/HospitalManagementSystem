using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class BillDialysisBO
    {
        private int _bill_dialysis_id;

        public int bill_dialysis_id
        {
            get { return _bill_dialysis_id; }
            set { _bill_dialysis_id = value; }
        }

        private int _admission_id;

        public int admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }
        }

        private int _patient_id;

        public int patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }

        private Nullable<DateTime> _bill_date;

        public Nullable<DateTime> bill_date
        {
            get { return _bill_date; }
            set { _bill_date = value; }
        }

        private Nullable<Decimal> _bill_amount;

        public Nullable<Decimal> bill_amount
        {
            get { return _bill_amount; }
            set { _bill_amount = value; }
        }

        private Nullable<Decimal> _discount;

        public Nullable<Decimal> discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        private Nullable<Decimal> _net_amount;

        public Nullable<Decimal> net_amount
        {
            get { return _net_amount; }
            set { _net_amount = value; }
        }

        private Nullable<Decimal> _paid_amount;

        public Nullable<Decimal> paid_amount
        {
            get { return _paid_amount; }
            set { _paid_amount = value; }
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

        public BillDialysisBO()
		{ }

    }
}
