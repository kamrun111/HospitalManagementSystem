using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class PatientDischarge
    {
        private int _patient_discharge_id;

        public int patient_discharge_id
        {
            get { return _patient_discharge_id; }
            set { _patient_discharge_id = value; }
        }

        private int _admission_id;

        public int admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }
        }

        private int _product_id;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        private string _medicine_indication;

        public string medicine_indication
        {
            get { return _medicine_indication; }
            set { _medicine_indication = value; }
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

        public PatientDischarge()
		{ }
        public PatientDischarge(int patient_discharge_id, int admission_id, int product_id, string medicine_indication, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.patient_discharge_id = patient_discharge_id;
            this.admission_id = admission_id;
            this.product_id = product_id;
            this.medicine_indication = medicine_indication;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        
        }

        public override string ToString()
        {
            return "patient_discharge_id = " + patient_discharge_id.ToString() + ",admission_id=" + admission_id.ToString() + ",product_id=" + product_id.ToString() + ",medicine_indication=" + medicine_indication + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }
        public class patient_discharge_idComparer : System.Collections.Generic.IComparer<PatientDischarge>
        {
            public SorterMode SorterMode;
            public patient_discharge_idComparer()
            { }
            public patient_discharge_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<PatientDischarge> Membres
            int System.Collections.Generic.IComparer<PatientDischarge>.Compare(PatientDischarge x, PatientDischarge y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.patient_discharge_id.CompareTo(x.patient_discharge_id);
                }
                else
                {
                    return x.patient_discharge_id.CompareTo(y.patient_discharge_id);
                }
            }
            #endregion
        }
    }
}
