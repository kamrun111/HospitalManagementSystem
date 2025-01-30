using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class DoctorsPaymentDetails
    {
        private int _doctors_payment_details_id;

        public int doctors_payment_details_id
        {
            get { return _doctors_payment_details_id; }
            set { _doctors_payment_details_id = value; }
        }
        private int _doctors_payment_id;

        public int doctors_payment_id
        {
            get { return _doctors_payment_id; }
            set { _doctors_payment_id = value; }
        }
        private int _reffered_doctors_id;

        public int reffered_doctors_id
        {
            get { return _reffered_doctors_id; }
            set { _reffered_doctors_id = value; }
        }
        private int _surgery_charge;

        public int surgery_charge
        {
            get { return _surgery_charge; }
            set { _surgery_charge = value; }
        }
        private int _visit_qty;

        public int visit_qty
        {
            get { return _visit_qty; }
            set { _visit_qty = value; }
        }
        private int  _visit_charge;

        public int visit_charge
        {
            get { return _visit_charge; }
            set { _visit_charge = value; }
        }
        private int _reducevisit_qty;

        public int reducevisit_qty
        {
            get { return _reducevisit_qty; }
            set { _reducevisit_qty = value; }
        }
        private int _reducevisit_charge;

        public int reducevisit_charge
        {
            get { return _reducevisit_charge; }
            set { _reducevisit_charge = value; }
        }
        private int _anestheia_charge;

        public int anestheia_charge
        {
            get { return _anestheia_charge; }
            set { _anestheia_charge = value; }
        }
        private int _assistance_charge;

        public int assistance_charge
        {
            get { return _assistance_charge; }
            set { _assistance_charge = value; }
        }
        private decimal _total_amount;

        public decimal total_amount
        {
            get { return _total_amount; }
            set { _total_amount = value; }
        }

        private string _flag;

        public string flag
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
        public DoctorsPaymentDetails()
		{ }

        public DoctorsPaymentDetails(int doctors_payment_details_id, int doctors_payment_id, int reffered_doctors_id, int surgery_charge, int visit_qty, int visit_charge, int reducevisit_qty, int reducevisit_charge, int anestheia_charge, int assistance_charge, decimal total_amount,string  flag, Nullable<int> record_created_by, Nullable<DateTime> record_created_date, Nullable<int> record_modified_by, Nullable<DateTime> record_modified_date)
		{
            this.doctors_payment_details_id = doctors_payment_details_id;
            this.doctors_payment_id = doctors_payment_id;
            this.reffered_doctors_id = reffered_doctors_id;
            this.surgery_charge = surgery_charge;
            this.visit_qty = visit_qty;
            this.visit_charge = visit_charge;
            this.reducevisit_qty = reducevisit_qty;
            this.reducevisit_charge = reducevisit_charge;
            this.anestheia_charge = anestheia_charge;
            this.assistance_charge = assistance_charge;
            this.total_amount = total_amount;
            this.flag = flag;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}
        public override string ToString()
        {
            return "doctors_payment_details_id = " + doctors_payment_details_id.ToString() + ",doctors_payment_id = " + doctors_payment_id.ToString() + ",reffered_doctors_id = " + reffered_doctors_id.ToString() + ",surgery_charge=" + surgery_charge.ToString() + ", visit_qty = " + visit_qty.ToString() + ",visit_charge = " + visit_charge.ToString() + ",reducevisit_qty = " + reducevisit_qty.ToString() + ",reducevisit_charge = " + reducevisit_charge.ToString() + ",anestheia_charge = " + anestheia_charge.ToString() + ",assistance_charge= " + assistance_charge.ToString() + ",total_amount = " + total_amount.ToString() + ",flag=" + flag +", record_created_by = " + record_created_by.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_modified_by = " + record_modified_by.ToString() + ",record_modified_date = " + record_modified_date.ToString();
        }
        public class doctors_payment_details_idComparer : System.Collections.Generic.IComparer<DoctorsPaymentDetails>
        {
            public SorterMode SorterMode;
            public doctors_payment_details_idComparer()
            { }
            public doctors_payment_details_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<DoctorsPaymentDetails> Membres
            int System.Collections.Generic.IComparer<DoctorsPaymentDetails>.Compare(DoctorsPaymentDetails x, DoctorsPaymentDetails y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.doctors_payment_details_id.CompareTo(x.doctors_payment_details_id);
                }
                else
                {
                    return x.doctors_payment_details_id.CompareTo(y.doctors_payment_details_id);
                }
            }
            #endregion
        }

    }
}
