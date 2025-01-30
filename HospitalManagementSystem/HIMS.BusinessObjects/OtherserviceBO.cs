using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OtherserviceBO
    {
        private int _other_service_id;

        public int other_service_id
        {
            get { return _other_service_id; }
            set { _other_service_id = value; }
        }
        private int _patient_id;

        public int patient_id
        {
            get { return _patient_id; }
            set { _patient_id = value; }
        }

        private string _order_no;

        public string order_no
        {
            get { return _order_no; }
            set { _order_no = value; }
        }

        private decimal  _total;

        public decimal  total
        {
            get { return _total; }
            set { _total = value; }
        }

        private decimal _t_vat;

        public decimal t_vat
        {
            get { return _t_vat; }
            set { _t_vat = value; }
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

        public OtherserviceBO()
        { }

        public OtherserviceBO(int other_service_id, int patient_id, string order_no,decimal total,decimal t_vat, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.other_service_id = other_service_id;
            this.patient_id = patient_id;
            this.order_no = order_no;
            this.total = total;
            this.t_vat = t_vat;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }
        public override string ToString()
        {
            return "other_service_id = " + other_service_id.ToString() + ",patient_id = " + patient_id.ToString() + ",order_no =" + order_no + ",total = " + total.ToString() + ",t_vat = " + t_vat.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ", record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }
        public class other_service_idComparer : System.Collections.Generic.IComparer<OtherserviceBO>
        {
            public SorterMode SorterMode;
            public other_service_idComparer()
            { }
            public other_service_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<OtherserviceBO> Membres
            int System.Collections.Generic.IComparer<OtherserviceBO>.Compare(OtherserviceBO x, OtherserviceBO y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.other_service_id.CompareTo(x.other_service_id);
                }
                else
                {
                    return x.other_service_id.CompareTo(y.other_service_id);
                }
            }
            #endregion
        }
    }
}
