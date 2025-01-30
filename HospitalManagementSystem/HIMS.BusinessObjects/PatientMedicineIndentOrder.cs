using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientMedicineIndentOrder
	{

        private int _patient_medicine_indent_order_id;

        public int patient_medicine_indent_order_id
        {
            get { return _patient_medicine_indent_order_id; }
            set { _patient_medicine_indent_order_id = value; }
        }

		private int _patient_medicine_indent_id;

		public int patient_medicine_indent_id
		{
			get { return _patient_medicine_indent_id; }
			set { _patient_medicine_indent_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		
		private Nullable<int> _cabin_id;

		public Nullable<int> cabin_id
		{
			get { return _cabin_id; }
			set { _cabin_id = value; }
		}

        private int _station; // to declare from where medecine indent order

        public int station
        {
            get { return _station; }
            set { _station = value; }
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
        
		public PatientMedicineIndentOrder()
		{ }

        public PatientMedicineIndentOrder(int patient_medicine_indent_order_id,int patient_medicine_indent_id, Nullable<int> admission_id, Nullable<int> patient_id, Nullable<int> received_by, Nullable<int> cabin_id,  int station, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.patient_medicine_indent_order_id = patient_medicine_indent_order_id;
			this.patient_medicine_indent_id = patient_medicine_indent_id;
			this.admission_id = admission_id;
			this.cabin_id = cabin_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "patient_medicine_indent_order_id=" + patient_medicine_indent_order_id.ToString()+ ", patient_medicine_indent_id = " + patient_medicine_indent_id.ToString() + ", admission_id = " + admission_id.ToString() + ",cabin_id = " + cabin_id.ToString() + ",station=" + station.ToString() + ", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

        public class patient_medicine_indent_order_idComparer : System.Collections.Generic.IComparer<PatientMedicineIndentOrder>
		{
			public SorterMode SorterMode;
			public patient_medicine_indent_order_idComparer()
			{ }
            public patient_medicine_indent_order_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<patient_medicine_indent_order> Membres
            int System.Collections.Generic.IComparer<PatientMedicineIndentOrder>.Compare(PatientMedicineIndentOrder x, PatientMedicineIndentOrder y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.patient_medicine_indent_order_id.CompareTo(x.patient_medicine_indent_order_id);
				}
				else
				{
                    return x.patient_medicine_indent_order_id.CompareTo(y.patient_medicine_indent_order_id);
				}
			}
			#endregion
		}
	}
}
