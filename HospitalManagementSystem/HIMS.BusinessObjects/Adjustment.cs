using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class Adjustment
    {
        private int _adjustment_id;

        public int adjustment_id
        {
            get { return _adjustment_id; }
            set { _adjustment_id = value; }
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

        public Adjustment()
		{ }

        public Adjustment(int adjustment_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.adjustment_id = adjustment_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}
        public override string ToString()
        {
           return "adjustment_id = " + adjustment_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class adjustment_idComparer : System.Collections.Generic.IComparer<Adjustment>
        {
            public SorterMode SorterMode;
            public adjustment_idComparer()
            { }
            public adjustment_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<adjusment> Membres
            int System.Collections.Generic.IComparer<Adjustment>.Compare(Adjustment x, Adjustment y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.adjustment_id.CompareTo(x.adjustment_id);
                }
                else
                {
                    return x.adjustment_id.CompareTo(y.adjustment_id);
                }
            }
            #endregion
        }
    }
}
