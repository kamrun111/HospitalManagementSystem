using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class DoctorsPayment
    {
        private int _doctors_payment_id;

        public int doctors_payment_id
        {
            get { return _doctors_payment_id; }
            set { _doctors_payment_id = value; }
        }
        private int _admission_code;

        public int admission_code
        {
            get { return _admission_code; }
            set { _admission_code = value; }
        }

        private decimal _grand_total;

        public decimal grand_total
        {
            get { return _grand_total; }
            set { _grand_total = value; }
        }

        private int _flag;

        public int flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private Nullable<int> _record_created_by;

        public Nullable<int> record_created_by
        {
            get { return _record_created_by; }
            set { _record_created_by = value; }
        }

        private Nullable<DateTime> _record_created_date;

        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }

        private Nullable<int> _record_modified_by;

        public Nullable<int> record_modified_by
        {
            get { return _record_modified_by; }
            set { _record_modified_by = value; }
        }

        private Nullable<DateTime> _record_modified_date;

        public Nullable<DateTime> record_modified_date
        {
            get { return _record_modified_date; }
            set { _record_modified_date = value; }
        }

        public DoctorsPayment()
        { }

        public DoctorsPayment(int doctors_payment_id, int admission_code, decimal grand_total, int flag, Nullable<int> record_created_by, Nullable<DateTime> record_created_date, Nullable<int> record_modified_by, Nullable<DateTime> record_modified_date)
        {
            this.doctors_payment_id = doctors_payment_id;
            this.admission_code = admission_code;
            this.grand_total = grand_total;
            this.flag = flag;
            this.record_created_by = record_created_by;
            this.record_created_date = record_created_date;
            this.record_modified_by = record_modified_by;
            this.record_modified_date = record_modified_date;

        }
        public override string ToString()
        {
            return "doctors_payment_id = " + doctors_payment_id.ToString() + ",admission_code = " + admission_code.ToString() + ",grand_total = " + grand_total.ToString() + ",flag = " + flag.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_modified_by = " + record_modified_by.ToString() + ",record_modified_date = " + record_modified_date.ToString();
        }
        public class doctors_payment_idComparer : System.Collections.Generic.IComparer<DoctorsPayment>
        {
            public SorterMode SorterMode;
            public doctors_payment_idComparer()
            { }
            public doctors_payment_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<DoctorsPayment> Membres
            int System.Collections.Generic.IComparer<DoctorsPayment>.Compare(DoctorsPayment x, DoctorsPayment y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.doctors_payment_id.CompareTo(x.doctors_payment_id);
                }
                else
                {
                    return x.doctors_payment_id.CompareTo(y.doctors_payment_id);
                }
            }
            #endregion
        }
    }
}

