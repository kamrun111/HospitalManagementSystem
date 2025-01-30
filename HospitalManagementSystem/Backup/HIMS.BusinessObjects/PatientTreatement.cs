using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientTreatement
	{
		private int _patient_treatement_id;

		public int patient_treatement_id
		{
			get { return _patient_treatement_id; }
			set { _patient_treatement_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<int> _prescription_id;

		public Nullable<int> prescription_id
		{
			get { return _prescription_id; }
			set { _prescription_id = value; }
		}

		private Nullable<int> _treatement_id;

		public Nullable<int> treatement_id
		{
			get { return _treatement_id; }
			set { _treatement_id = value; }
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

		public PatientTreatement()
		{ }

		public PatientTreatement(int patient_treatement_id,Nullable<int> admission_id,Nullable<int> prescription_id,Nullable<int> treatement_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_treatement_id = patient_treatement_id;
			this.admission_id = admission_id;
			this.prescription_id = prescription_id;
			this.treatement_id = treatement_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_treatement_id = " + patient_treatement_id.ToString() + ",admission_id = " + admission_id.ToString() + ",prescription_id = " + prescription_id.ToString() + ",treatement_id = " + treatement_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_treatement_idComparer : System.Collections.Generic.IComparer<PatientTreatement>
		{
			public SorterMode SorterMode;
			public patient_treatement_idComparer()
			{ }
			public patient_treatement_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_treatement> Membres
			int System.Collections.Generic.IComparer<PatientTreatement>.Compare(PatientTreatement x, PatientTreatement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_treatement_id.CompareTo(x.patient_treatement_id);
				}
				else
				{
					return x.patient_treatement_id.CompareTo(y.patient_treatement_id);
				}
			}
			#endregion
		}
	}
}
