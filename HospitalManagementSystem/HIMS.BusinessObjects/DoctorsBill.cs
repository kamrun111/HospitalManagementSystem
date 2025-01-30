using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class DoctorsBill
    {
        private int _doctors_bill_id;

        public int doctors_bill_id
        {
            get { return _doctors_bill_id; }
            set { _doctors_bill_id = value; }
        }

        private Nullable<int> _admission_id;

        public Nullable<int> admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }
        }

        private Nullable<int> _reffered_doctors_id;

        public Nullable<int> reffered_doctors_id
        {
            get { return _reffered_doctors_id; }
            set { _reffered_doctors_id = value; }
        }

      
        private Nullable<decimal> _amount;

        public Nullable<decimal> amount
        {
            get { return _amount; }
            set { _amount = value; }

        }

        private Nullable<decimal> _discount;

        public Nullable<decimal> discount
        {
            get { return _discount; }
            set { _discount = value; }

        }


        private int _is_paid;

        public int is_paid
        {
            get { return _is_paid; }
            set { _is_paid = value; }
        }

         private Nullable<DateTime> _paid_date;

        public Nullable<DateTime> paid_date
        {
            get { return _paid_date; }
            set { _paid_date = value; }
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


        public DoctorsBill()
        { }

        public DoctorsBill(int doctors_bill_id, Nullable<int> admission_id, Nullable<int> reffered_doctors_id, Nullable<decimal> amount,Nullable<decimal>discount, int is_paid, Nullable<DateTime> paid_date, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.doctors_bill_id = doctors_bill_id;
            this.admission_id = admission_id;
            this.reffered_doctors_id = reffered_doctors_id;
            this.amount = amount;
            this.discount = discount;
            this.is_paid = is_paid;
            this.paid_date = paid_date;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;

        }

        public override string ToString()
        {
            return "doctors_bill_id = " + doctors_bill_id.ToString() + ",admission_id = " + admission_id.ToString() + ",paid_date = " + paid_date.ToString() + ",reffered_doctors_id = " + reffered_doctors_id.ToString() + ",is_paid = " + is_paid.ToString() + ",amount = " + amount.ToString() + ",discount=" + discount.ToString() + ", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class doctors_bill_idComparer : System.Collections.Generic.IComparer<DoctorsBill>
        {
            public SorterMode SorterMode;
            public doctors_bill_idComparer()
            { }
            public doctors_bill_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<doctors_bill> Membres
            int System.Collections.Generic.IComparer<DoctorsBill>.Compare(DoctorsBill x, DoctorsBill y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.doctors_bill_id.CompareTo(x.doctors_bill_id);
                }
                else
                {
                    return x.doctors_bill_id.CompareTo(y.doctors_bill_id);
                }
            }
            #endregion
               
           
        }
    }
}
