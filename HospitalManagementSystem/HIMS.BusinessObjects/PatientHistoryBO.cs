using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientHistoryBO
	{
		private int _patient_history_id;

		public int patient_history_id
		{
			get { return _patient_history_id; }
			set { _patient_history_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

        private Nullable<int> _history_text_id;

        public Nullable<int> history_text_id
        {
            get { return _history_text_id; }
            set { _history_text_id = value; }
        }

		private Nullable<int> _history_text_value_id;

		public Nullable<int> history_text_value_id
		{
			get { return _history_text_value_id; }
			set { _history_text_value_id = value; }
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

		public PatientHistoryBO()
		{ }

		public PatientHistoryBO(int patient_history_id,Nullable<int> admission_id,Nullable<int> history_text_id,Nullable<int> history_text_value_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_history_id = patient_history_id;
			this.admission_id = admission_id;
			this.history_text_value_id = history_text_value_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_history_id = " + patient_history_id.ToString() + ",admission_id = " + admission_id.ToString() +  ",history_text_value_id = " + history_text_value_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_history_idComparer : System.Collections.Generic.IComparer<PatientHistoryBO>
		{
			public SorterMode SorterMode;
			public patient_history_idComparer()
			{ }
			public patient_history_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_history> Membres
			int System.Collections.Generic.IComparer<PatientHistoryBO>.Compare(PatientHistoryBO x, PatientHistoryBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_history_id.CompareTo(x.patient_history_id);
				}
				else
				{
					return x.patient_history_id.CompareTo(y.patient_history_id);
				}
			}
			#endregion
		}
	}
}
