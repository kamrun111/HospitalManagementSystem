using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class BillICUBO
    {
        private int _bill_icu_id;

        public int bill_icu_id
        {
            get { return _bill_icu_id; }
            set { _bill_icu_id = value; }
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

        private Nullable<Decimal> _cabin_charge;

        public Nullable<Decimal> cabin_charge
        {
            get { return _cabin_charge; }
            set { _cabin_charge = value; }
        }

        private Nullable<Decimal> _other_service;

        public Nullable<Decimal> other_service
        {
            get { return _other_service; }
            set { _other_service = value; }
        }

        private Nullable<Decimal> _doctor_bill;

        public Nullable<Decimal> doctor_bill
        {
            get { return _doctor_bill; }
            set { _doctor_bill = value; }
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

        public BillICUBO()
		{ }
    }
}
