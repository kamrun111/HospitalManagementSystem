using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class PatientConsultantBO
    {
        private int _patient_consultant_id;

        public int patient_consultant_id
        {
            get { return _patient_consultant_id; }
            set { _patient_consultant_id = value; }
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

        private decimal _total;

        public decimal total
        {
            get { return _total; }
            set { _total = value; }
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

        private Nullable<DateTime> _record_created_date;

        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }

        public PatientConsultantBO()
		{ }

        public PatientConsultantBO(int patient_consultant_id, int patient_id, string order_no,decimal total, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.patient_consultant_id = patient_consultant_id;
            this.patient_id = patient_id;
            this.order_no = order_no;
            this.total = total;
            this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

        public override string ToString()
        {
            return "patient_consultant_id = " + patient_consultant_id.ToString() + ",patient_id = " + patient_id.ToString() + ",order_no =" + order_no +",total = " + total.ToString() + ", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ", record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class patient_consultant_idComparer : System.Collections.Generic.IComparer<PatientConsultantBO>
        {
            public SorterMode SorterMode;
            public patient_consultant_idComparer()
            { }
            public patient_consultant_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<PatientConsultantBO> Membres
            int System.Collections.Generic.IComparer<PatientConsultantBO>.Compare(PatientConsultantBO x, PatientConsultantBO y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.patient_consultant_id.CompareTo(x.patient_consultant_id);
                }
                else
                {
                    return x.patient_consultant_id.CompareTo(y.patient_consultant_id);
                }
            }
            #endregion
        }

    }
}
