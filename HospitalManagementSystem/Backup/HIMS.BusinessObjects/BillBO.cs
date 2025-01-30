using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class BillBO
    {
        private int _bill_id;

        public int bill_id
        {
            get { return _bill_id; }
            set { _bill_id = value; }
        }

        private Nullable<int> _admission_id;

        public Nullable<int> admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }

        }

        private Nullable<Decimal> _admission_fee;

        public Nullable<Decimal> admission_fee
        {
            get { return _admission_fee; }
            set { _admission_fee = value; }
        }

        private Nullable<Decimal> _investigation_fee;

        public Nullable<Decimal> investigation_fee
        {
            get { return _investigation_fee; }
            set { _investigation_fee = value; }
        }

        private Nullable<Decimal> _treatment_fee;

        public Nullable<Decimal> treatment_fee
        {
            get { return _treatment_fee; }
            set { _treatment_fee = value; }
        }


        private Nullable<Decimal> _ot_fee;

        public Nullable<Decimal> ot_fee
        {
            get { return _ot_fee; }
            set { _ot_fee = value; }
        }

        private Nullable<Decimal> _post_operative_fee;

        public Nullable<Decimal> post_operative_fee
        {
            get { return _post_operative_fee; }
            set { _post_operative_fee = value; }
        }

        private Nullable<Decimal> _other_fee;

        public Nullable<Decimal> other_fee
        {
            get { return _other_fee; }
            set { _other_fee = value; }
        }

        private Nullable<Decimal> _medicine_fee;

        public Nullable<Decimal> medicine_fee
        {
            get { return _medicine_fee; }
            set { _medicine_fee = value; }
        }

        private Nullable<Decimal> _room_rent;

        public Nullable<Decimal> room_rent
        {
            get { return _room_rent; }
            set { _room_rent = value; }
        }

        private Nullable<Decimal> _loan;

        public Nullable<Decimal> loan
        {
            get { return _loan; }
            set { _loan = value; }
        }

        private Nullable<Decimal> _vat;

        public Nullable<Decimal> vat
        {
            get { return _vat; }
            set { _vat = value; }
        }


        private Nullable<Decimal> _doctors_fee;

        public Nullable<Decimal> doctors_fee
        {
            get { return _doctors_fee; }
            set { _doctors_fee = value; }
        }

        private Nullable<Decimal> _discount;

        public Nullable<Decimal> discount
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
        private Nullable<Decimal> _paid_amount;

        public Nullable<Decimal> paid_amount
        {
            get { return _paid_amount; }
            set { _paid_amount = value; }
        }

        private Nullable<DateTime> _bill_generate_date;

        public Nullable<DateTime> bill_generate_date
        {
            get { return _bill_generate_date; }
            set { _bill_generate_date = value; }
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

        public BillBO()
        { }

        public BillBO(int bill_id, Nullable<int> admission_id, Nullable<decimal> admission_fee, Nullable<decimal> investigation_fee, Nullable<decimal> treatment_fee, Nullable<decimal> ot_fee,Nullable<Decimal> post_operative_fee, Nullable<decimal> other_fee, Nullable<decimal> medicine_fee, Nullable<decimal> room_rent,Nullable<Decimal> loan, Nullable<decimal> vat, Nullable<decimal> doctors_fee, Nullable<decimal> discount,string remarks, Nullable<decimal> paid_amount, Nullable<DateTime> bill_generate_date, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.bill_id = bill_id;
            this.admission_id = admission_id;
            this.admission_fee = admission_fee;
            this.investigation_fee = investigation_fee;
            this.treatment_fee = treatment_fee;
            this.ot_fee = ot_fee;
            this.post_operative_fee = post_operative_fee;
            this.other_fee = other_fee;
            this.medicine_fee = medicine_fee;
            this.room_rent = room_rent;
            this.loan = loan;
            this.vat = vat;
            this.doctors_fee = doctors_fee;
            this.discount = discount;
            this.remarks = remarks;
            this.paid_amount = paid_amount;
            this.bill_generate_date = bill_generate_date;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }

        public override string ToString()
        {
            return "bill_id = " + bill_id.ToString() + ",admission_id = " + admission_id.ToString() + ",admission_fee = " + admission_fee.ToString() + ",investigation_fee = " + investigation_fee.ToString() + ",treatment_fee = " + treatment_fee.ToString() + ",ot_fee = " + ot_fee.ToString() + ",post_operative_fee=" + post_operative_fee .ToString()+ ",other_fee= " + other_fee.ToString() + ",medicine_fee= " + medicine_fee.ToString() + ",room_rent= " + room_rent.ToString() + ",loan="+loan.ToString()+",vat = " + vat.ToString() + ",doctors_fee=" + doctors_fee.ToString() + ",discount=" + discount.ToString() + ",remarks=" + remarks.ToString() + ",paid_amount=" + paid_amount.ToString() + ",bill_generate_date=" + bill_generate_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class bill_idComparer : System.Collections.Generic.IComparer<BillBO>
        {
            public SorterMode SorterMode;
            public bill_idComparer()
            { }
            public bill_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Bill> Membres
            int System.Collections.Generic.IComparer<BillBO>.Compare(BillBO x, BillBO y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.bill_id.CompareTo(x.bill_id);
                }
                else
                {
                    return x.bill_id.CompareTo(y.bill_id);
                }
            }
            #endregion
        }
    }
}
