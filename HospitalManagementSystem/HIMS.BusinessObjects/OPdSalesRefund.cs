using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPdSalesRefund
    {

        private int _opd_sales_refund_id;

        public int opd_sales_refund_id
        {
            get { return _opd_sales_refund_id; }
            set { _opd_sales_refund_id = value; }
        }

        private int _opd_sales_id;

        public int opd_sales_id
        {
            get { return _opd_sales_id; }
            set { _opd_sales_id = value; }
        }

        private int _PKID;

        public int PKID
        {
            get { return _PKID; }
            set { _PKID = value; }
        }

        private int _store_id;

        public int store_id
        {
            get { return _store_id; }
            set { _store_id = value; }
        }

        private int _refund_by;

        public int refund_by
        {
            get { return _refund_by; }
            set { _refund_by = value; }
        }

        private Nullable<DateTime> _refund_time;

        public Nullable<DateTime> refund_time
        {
            get { return _refund_time; }
            set { _refund_time = value; }
        }

        private int _received_by;

        public int received_by
        {
            get { return _received_by; }
            set { _received_by = value; }
        }

        private Nullable<DateTime> _received_time;

        public Nullable<DateTime> received_time
        {
            get { return _received_time; }
            set { _received_time = value; }
        }

        public OPdSalesRefund()
		{ }

        public OPdSalesRefund(int opd_sales_refund_id, int opd_sales_id, int PKID,int store_id, int refund_by, Nullable<DateTime> refund_time, int received_by, Nullable<DateTime> received_time)
        {
            this.opd_sales_refund_id=opd_sales_refund_id;
            this.opd_sales_id=opd_sales_id;
            this.PKID=PKID;
            this.store_id = store_id;
            this.refund_by=refund_by;
            this.refund_time=refund_time;
            this.received_by=received_by;
            this.received_time = received_time;
        }

        public override string ToString()
        {
            return "opd_sales_refund_id = " + opd_sales_refund_id.ToString() + ",opd_sales_id = " + opd_sales_id.ToString() + ",PKID=" + PKID.ToString() + ",store_id="+store_id.ToString() +", refund_by=" + refund_by.ToString() + ", refund_time = " + refund_time.ToString() + ",received_by = " + received_by.ToString() + ",received_time = " + received_time.ToString();
        }

        public class opd_sales_refund_idComparer : System.Collections.Generic.IComparer<OPdSalesRefund>
        {
            public SorterMode SorterMode;
            public opd_sales_refund_idComparer()
            { }
            public opd_sales_refund_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<OPdSalesRefund> Membres
            int System.Collections.Generic.IComparer<OPdSalesRefund>.Compare(OPdSalesRefund x, OPdSalesRefund y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_sales_refund_id.CompareTo(x.opd_sales_refund_id);
                }
                else
                {
                    return x.opd_sales_refund_id.CompareTo(y.opd_sales_refund_id);
                }
            }
            #endregion
        }

    }
}
