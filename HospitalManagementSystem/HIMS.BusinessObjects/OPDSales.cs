using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPDSales
    {
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

        private int _opd_order_id;

        public int opd_order_id
        {
            get { return _opd_order_id; }
            set { _opd_order_id = value; }
        }

        private int _Indent_by;

        public int Indent_by
        {
            get { return _Indent_by; }
            set { _Indent_by = value; }
        }

        private Nullable<DateTime> _record_create_date;

        public Nullable<DateTime> record_create_date
        {
            get { return _record_create_date; }
            set { _record_create_date = value; }
        }

        private int _record_created_by;

        public int record_created_by
        {
            get { return _record_created_by; }
            set { _record_created_by = value; }
        }

        public OPDSales()
		{ }

        public OPDSales(int opd_sales_id, int PKID, int opd_order_id, int Indent_by, Nullable<DateTime> record_create_date, int record_created_by)
        {
            this.opd_sales_id = opd_sales_id;
            this.PKID = PKID;
            this.opd_order_id = opd_order_id;
            this.Indent_by = Indent_by;
            this.record_create_date = record_create_date;
            this.record_created_by = record_created_by;
		}

		public override string ToString()
		{
            return "opd_sales_id = " + opd_sales_id.ToString() + ",PKID = " + PKID.ToString() + ",opd_order_id = " + opd_order_id.ToString() + ",Indent_by = " + Indent_by.ToString() + ",record_create_date = " + record_create_date.ToString() + ",record_created_by = " + record_created_by.ToString(); 
		}


        public class opd_sales_idComparer : System.Collections.Generic.IComparer<OPDSales>
        {
            public SorterMode SorterMode;
            public opd_sales_idComparer()
            { }
            public opd_sales_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<opdSales> Membres
            int System.Collections.Generic.IComparer<OPDSales>.Compare(OPDSales x, OPDSales y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_sales_id.CompareTo(x.opd_sales_id);
                }
                else
                {
                    return x.opd_sales_id.CompareTo(y.opd_sales_id);
                }
            }
            #endregion
        }
    }
}
