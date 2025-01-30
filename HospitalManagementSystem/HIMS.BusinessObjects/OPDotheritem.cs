using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPDotheritem
    {
        private int _opd_other_item_id;

        public int opd_other_item_id
        {
            get { return _opd_other_item_id; }
            set { _opd_other_item_id = value; }
        }

        private int _PKID;

        public int PKID
        {
            get { return _PKID; }
            set { _PKID = value; }
        }

        private int _other_item_id;

        public int other_item_id
        {
            get { return _other_item_id; }
            set { _other_item_id = value; }
        }

        private int _qty;

        public int qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        private decimal  _qty_per_unit;

        public decimal qty_per_unit
        {
            get { return _qty_per_unit; }
            set { _qty_per_unit = value; }
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

        public OPDotheritem()
		{ }

        public OPDotheritem(int opd_other_item_id,int PKID,int other_item_id,int qty,decimal qty_per_unit, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.opd_other_item_id = opd_other_item_id;
            this.PKID = PKID;
            this.other_item_id = other_item_id;
            this.qty = qty;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

        public override string ToString()
        {
            return "opd_other_item_id = " + opd_other_item_id.ToString() + ",PKID = " + PKID.ToString() + ",qty=" + PKID.ToString()+ ", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class opd_other_item_idComparer : System.Collections.Generic.IComparer<OPDotheritem>
        {
            public SorterMode SorterMode;
            public opd_other_item_idComparer()
            { }
            public opd_other_item_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<OPDotheritem> Membres
            int System.Collections.Generic.IComparer<OPDotheritem>.Compare(OPDotheritem x, OPDotheritem y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_other_item_id.CompareTo(x.opd_other_item_id);
                }
                else
                {
                    return x.opd_other_item_id.CompareTo(y.opd_other_item_id);
                }
            }
            #endregion
        }

    }
}
