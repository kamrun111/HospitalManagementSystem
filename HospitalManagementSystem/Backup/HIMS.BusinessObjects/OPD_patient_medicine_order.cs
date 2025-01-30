using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPD_patient_medicine_order
    {
        private int _opd_patient_medicine_order_id;

        public int opd_patient_medicine_order_id
        {
            get { return _opd_patient_medicine_order_id; }
            set { _opd_patient_medicine_order_id = value; }
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

        private int _indent_by;

        public int indent_by
        {
            get { return _indent_by; }
            set { _indent_by = value; }
        }

        private int _delivery_by;

        public int delivery_by
        {
            get { return _delivery_by; }
            set { _delivery_by = value; }
        }

        private int _received_by;

        public int received_by
        {
            get { return _received_by; }
            set { _received_by = value; }
        }

        private  Nullable<DateTime>  _record_created_date;

        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }


        private Nullable<DateTime> _record_delivery_date;

        public Nullable<DateTime> record_delivery_date
        {
            get { return _record_delivery_date; }
            set { _record_delivery_date = value; }
        }

        private Nullable<DateTime> _record_received_date;

        public Nullable<DateTime> record_received_date
        {
            get { return _record_received_date; }
            set { _record_received_date = value; }
        }

        public OPD_patient_medicine_order()
        {
        }
        public OPD_patient_medicine_order(int opd_patient_medicine_order_id, int PKID, int store_id, int indent_by, int delivery_by, int received_by, Nullable<DateTime> record_created_date, Nullable<DateTime> record_delivery_date, Nullable<DateTime> record_received_date)
        {
            this.opd_patient_medicine_order_id = opd_patient_medicine_order_id;
            this.PKID = PKID;
            this.store_id = store_id;
            this.indent_by = indent_by;
            this.delivery_by = delivery_by;
            this.received_by = received_by;
            this.record_created_date = record_created_date;
            this.record_delivery_date = record_delivery_date;
            this.record_received_date = record_received_date;
        }

        public override string ToString()
        {
            return "opd_patient_medicine_order_id= " + opd_patient_medicine_order_id.ToString() + ", PKID=" + PKID.ToString() + ",store_id= " + store_id.ToString() + ",indent_by=" + indent_by.ToString() + ",delivery_by = " + delivery_by.ToString() + ",received_by = " + received_by.ToString() + ",record_created_date=" + record_created_date.ToString() + ",record_delivery_date =" + record_delivery_date.ToString() + ",record_received_date= " + record_received_date.ToString();
        }

        public class opd_patient_medicine_order_idComparer : System.Collections.Generic.IComparer<OPD_patient_medicine_order>
        {
            public SorterMode SorterMode;
            public opd_patient_medicine_order_idComparer()
            { }
            public opd_patient_medicine_order_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<admission> Membres
            int System.Collections.Generic.IComparer<OPD_patient_medicine_order>.Compare(OPD_patient_medicine_order x, OPD_patient_medicine_order y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_patient_medicine_order_id.CompareTo(x.opd_patient_medicine_order_id);
                }
                else
                {
                    return x.opd_patient_medicine_order_id.CompareTo(y.opd_patient_medicine_order_id);
                }
            }
            #endregion
        
        }

    }
}
