using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientRefferedDoctors
	{
		private int _patient_reffered_doctors_id;

		public int patient_reffered_doctors_id
		{
			get { return _patient_reffered_doctors_id; }
			set { _patient_reffered_doctors_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<int> _reffered_doctors_id;

		public Nullable<int> reffered_doctors_id
		{
			get { return _reffered_doctors_id; }
			set { _reffered_doctors_id = value; }
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

		public PatientRefferedDoctors()
		{ }

		public PatientRefferedDoctors(int patient_reffered_doctors_id,Nullable<int> admission_id,Nullable<int> reffered_doctors_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_reffered_doctors_id = patient_reffered_doctors_id;
			this.admission_id = admission_id;
			this.reffered_doctors_id = reffered_doctors_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_reffered_doctors_id = " + patient_reffered_doctors_id.ToString() + ",admission_id = " + admission_id.ToString() + ",reffered_doctors_id = " + reffered_doctors_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_reffered_doctors_idComparer : System.Collections.Generic.IComparer<PatientRefferedDoctors>
		{
			public SorterMode SorterMode;
			public patient_reffered_doctors_idComparer()
			{ }
			public patient_reffered_doctors_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_reffered_doctors> Membres
			int System.Collections.Generic.IComparer<PatientRefferedDoctors>.Compare(PatientRefferedDoctors x, PatientRefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_reffered_doctors_id.CompareTo(x.patient_reffered_doctors_id);
				}
				else
				{
					return x.patient_reffered_doctors_id.CompareTo(y.patient_reffered_doctors_id);
				}
			}
			#endregion
		}
	}
}
