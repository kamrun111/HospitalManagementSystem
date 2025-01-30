using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OtherServiceListBO
    {
        private int _other_service_list_id;

        public int other_service_list_id
        {
            get { return _other_service_list_id; }
            set { _other_service_list_id = value; }
        }
        private int _other_service_id;

        public int other_service_id
        {
            get { return _other_service_id; }
            set { _other_service_id = value; }
        }
        private int _other_item_id;

        public int other_item_id
        {
            get { return _other_item_id; }
            set { _other_item_id = value; }
        }

        private Decimal _charge;

        public Decimal charge
        {
            get { return _charge; }
            set { _charge = value; }
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

        public OtherServiceListBO()
        { }

        public OtherServiceListBO(int other_service_list_id, int other_service_id, decimal charge, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.other_service_list_id = other_service_list_id;
            this.other_service_id = other_service_id;
            this.charge = charge;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }

        public class other_service_list_idComparer : System.Collections.Generic.IComparer<OtherServiceListBO>
        {
            public SorterMode SorterMode;
            public other_service_list_idComparer()
            { }
            public other_service_list_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<OtherServiceListBO> Membres
            int System.Collections.Generic.IComparer<OtherServiceListBO>.Compare(OtherServiceListBO x, OtherServiceListBO y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.other_service_list_id.CompareTo(x.other_service_list_id);
                }
                else
                {
                    return x.other_service_list_id.CompareTo(y.other_service_list_id);
                }
            }
            #endregion
        }
    }
}
