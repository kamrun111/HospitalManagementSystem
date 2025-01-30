using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class sales_refund
    {
        private int _sales_refund_id;

        public int sales_refund_id
        {
            get { return _sales_refund_id; }
            set { _sales_refund_id = value; }
        }

        private int _sales_id;

        public int sales_id
        {
            get { return _sales_id; }
            set { _sales_id = value; }
        }

        private int _admission_id;

        public int admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }
        }

        private int _product_id;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        private int _refund_qty;

        public int refund_qty
        {
            get { return _refund_qty; }
            set { _refund_qty = value; }
        }

        private int _is_received;

        public int is_received
        {
            get { return _is_received; }
            set { _is_received = value; }
        }

        private int _refund_id;

        public int refund_id
        {
            get { return _refund_id; }
            set { _refund_id = value; }
        }

        private int _store_id;

        public int store_id
        {
            get { return _store_id; }
            set { _store_id = value; }
        }

        private int _record_created_by;

        public int record_created_by
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

        private Nullable<DateTime> _record_modified_date;

        public Nullable<DateTime> record_modified_date
        {
            get { return _record_modified_date; }
            set { _record_modified_date = value; }
        }

        private int _record_modified_by;

        public int record_modified_by
        {
            get { return _record_modified_by; }
            set { _record_modified_by = value; }
        }
        public sales_refund()
        { }
        public sales_refund(int sales_refund_id, int sales_id, int admission_id, int product_id, int refund_qty, int is_received, int refund_id,int store_id, int record_created_by, Nullable<DateTime> record_created_date, Nullable<DateTime> record_modified_date,int record_modified_by)
        {
            this.sales_refund_id = sales_refund_id;
            this.sales_id = sales_id;
            this.admission_id = admission_id;
            this.product_id = product_id;
            this.refund_qty = refund_qty;
            this.is_received = is_received;
            this.refund_id = refund_id;
            this.store_id = store_id;
            this.record_created_by = record_created_by;
            this.record_created_date = record_created_date;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        
        }

        public override string ToString()
        {
            return "sales_refund_id = " + sales_refund_id.ToString() + ",sales_id = " + sales_id.ToString() + ",admission_id = " + admission_id.ToString() + ",product_id = " + product_id.ToString() + ",refund_qty = " + refund_qty.ToString() + ",is_received=" + is_received.ToString() + ",refund_id="+refund_id.ToString()+", store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_modified_date=" + record_modified_date.ToString() + ",record_modified_by=" + record_modified_by.ToString();
        }

        public class sales_refund_idComparer : System.Collections.Generic.IComparer<sales_refund>
        {
            public SorterMode SorterMode;
            public sales_refund_idComparer()
            { }
            public sales_refund_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<sales_refund> Membres
            int System.Collections.Generic.IComparer<sales_refund>.Compare(sales_refund x, sales_refund y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.sales_refund_id.CompareTo(x.sales_refund_id);
                }
                else
                {
                    return x.sales_refund_id.CompareTo(y.sales_refund_id);
                }
            }
            #endregion
        }
    }
}
