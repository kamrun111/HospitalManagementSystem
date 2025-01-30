using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OTShedule
    {
        private int _ot_shedule_id;

        public int ot_shedule_id
        {
            get { return _ot_shedule_id; }
            set { _ot_shedule_id = value; }
        }

      
        private string _patient_name;

        public string patient_name
        {
            get { return _patient_name; }
            set { _patient_name = value; }
        }

        private string _address;

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _contact_no;

        public string contact_no
        {
            get { return _contact_no; }
            set { _contact_no = value; }
        }


        private string _Room_no;

        public string Room_no
        {
            get { return _Room_no; }
            set { _Room_no = value; }
        }

        private Nullable<int> _reffered_doc_id;

        public Nullable<int> reffered_doc_id
        {
            get { return _reffered_doc_id; }
            set { _reffered_doc_id = value; }
        }

        private Nullable<int> _anaesthesia_id;

        public Nullable<int> anaesthesia_id
        {
            get { return _anaesthesia_id; }
            set { _anaesthesia_id = value; }
        }

        private Nullable<int> _anaesthesia_nature_id;

        public Nullable<int> anaesthesia_nature_id
        {
            get { return _anaesthesia_nature_id; }
            set { _anaesthesia_nature_id = value; }
        }

        private Nullable<int> _operation_id;

        public Nullable<int> operation_id
        {
            get { return _operation_id; }
            set { _operation_id = value; }
        }

        private Nullable<DateTime> _operation_date;

        public Nullable<DateTime> operation_date
        {
            get { return _operation_date; }
            set { _operation_date = value; }
        }

        private string _operation_time;

        public string operation_time
        {
            get { return _operation_time; }
            set { _operation_time = value; }
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

        public OTShedule()
        { }

        public OTShedule(int ot_shedule_id, string patient_name, string address, string contact_no, string Room_no, Nullable<int> anaesthesia_id, Nullable<int> anaesthesia_nature_id, Nullable<int> reffered_doc_id, Nullable<int> operation_id,Nullable<DateTime> operation_date,Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.ot_shedule_id = ot_shedule_id;
            this.patient_name = patient_name;
            this.address = address;
            this.contact_no = contact_no;
            this.Room_no = Room_no;
            this.reffered_doc_id = reffered_doc_id;
            this.operation_id = operation_id;
            this.operation_date = operation_date;
            this.operation_time = operation_time;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }

        public override string ToString()
        {
            return "ot_shedule_id = " + ot_shedule_id.ToString() + ",Room_no = " + Room_no + ",patient_name = " + patient_name + ",address = " + address + ",contact_no = " + contact_no + ",reffered_doc_id = " + reffered_doc_id.ToString() + ",operation_id = " + operation_id.ToString() + ",operation_date = " + operation_date + ",operation_time = " + operation_time.ToString() + ",anaesthesia_id = " + anaesthesia_id.ToString() + ",anaesthesia_nature_id = " + anaesthesia_nature_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class ot_shedule_idComparer : System.Collections.Generic.IComparer<OTShedule>
        {
            public SorterMode SorterMode;
            public ot_shedule_idComparer()
            { }
            public ot_shedule_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<otshedule> Membres
            int System.Collections.Generic.IComparer<OTShedule>.Compare(OTShedule x, OTShedule y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.ot_shedule_id.CompareTo(x.ot_shedule_id);
                }
                else
                {
                    return x.ot_shedule_id.CompareTo(y.ot_shedule_id);
                }
            }
            #endregion
        }
        public class patient_nameComparer : System.Collections.Generic.IComparer<OTShedule>
        {
            public SorterMode SorterMode;
            public patient_nameComparer()
            { }
            public patient_nameComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<otshedule> Membres
            int System.Collections.Generic.IComparer<OTShedule>.Compare(OTShedule x, OTShedule y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.patient_name.CompareTo(x.patient_name);
                }
                else
                {
                    return x.patient_name.CompareTo(y.patient_name);
                }
            }
            #endregion
        }
        public class addressComparer : System.Collections.Generic.IComparer<OTShedule>
        {
            public SorterMode SorterMode;
            public addressComparer()
            { }
            public addressComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<otshedule> Membres
            int System.Collections.Generic.IComparer<OTShedule>.Compare(OTShedule x, OTShedule y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.address.CompareTo(x.address);
                }
                else
                {
                    return x.address.CompareTo(y.address);
                }
            }
            #endregion
        }
        public class contact_noComparer : System.Collections.Generic.IComparer<OTShedule>
        {
            public SorterMode SorterMode;
            public contact_noComparer()
            { }
            public contact_noComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<otshedule> Membres
            int System.Collections.Generic.IComparer<OTShedule>.Compare(OTShedule x, OTShedule y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.contact_no.CompareTo(x.contact_no);
                }
                else
                {
                    return x.contact_no.CompareTo(y.contact_no);
                }
            }
            #endregion
        }

    }
}
