using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class ConsultationBO
    {
        private int _consultation_id;

        public int consultation_id
        {
            get { return _consultation_id; }
            set { _consultation_id = value; }
        }

        private int _patient_consultant_id;

        public int patient_consultant_id
        {
            get { return _patient_consultant_id; }
            set { _patient_consultant_id = value; }
        }

        private int _reffered_doctors_id;

        public int reffered_doctors_id
        {
            get { return _reffered_doctors_id; }
            set { _reffered_doctors_id = value; }
        }

        private Decimal _visit_charge;

        public Decimal visit_charge
        {
            get { return _visit_charge; }
            set { _visit_charge = value; }
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

        public ConsultationBO()
		{ }

        public ConsultationBO(int consultation_id, int patient_consultant_id, int reffered_doctors_id,decimal visit_charge, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.consultation_id = consultation_id;
            this.patient_consultant_id = patient_consultant_id;
            this.reffered_doctors_id = reffered_doctors_id;
            this.visit_charge = visit_charge;
            this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

        public override string ToString()
        {
            return "consultation_id = " + consultation_id.ToString() + ",patient_consultant_id = " + patient_consultant_id.ToString() + ",reffered_doctors_id = " + reffered_doctors_id.ToString() + ",visit_charge = " + visit_charge.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ", record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class consultation_idComparer : System.Collections.Generic.IComparer<ConsultationBO>
        {
            public SorterMode SorterMode;
            public consultation_idComparer()
            { }
            public consultation_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<ConsultationBO> Membres
            int System.Collections.Generic.IComparer<ConsultationBO>.Compare(ConsultationBO x, ConsultationBO y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.consultation_id.CompareTo(x.consultation_id);
                }
                else
                {
                    return x.consultation_id.CompareTo(y.consultation_id);
                }
            }
            #endregion
        }
    }
}
