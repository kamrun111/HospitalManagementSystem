using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientStatus
	{
		private int _patient_status_id;

		public int patient_status_id
		{
			get { return _patient_status_id; }
			set { _patient_status_id = value; }
		}

		private string _patient_status;

		public string patient_status
		{
			get { return _patient_status; }
			set { _patient_status = value; }
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

		public PatientStatus()
		{ }

		public PatientStatus(int patient_status_id,string patient_status,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_status_id = patient_status_id;
			this.patient_status = patient_status;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_status_id = " + patient_status_id.ToString() + ",patient_status = " + patient_status + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_status_idComparer : System.Collections.Generic.IComparer<PatientStatus>
		{
			public SorterMode SorterMode;
			public patient_status_idComparer()
			{ }
			public patient_status_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<PatientStatus> Membres
			int System.Collections.Generic.IComparer<PatientStatus>.Compare(PatientStatus x, PatientStatus y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_status_id.CompareTo(x.patient_status_id);
				}
				else
				{
					return x.patient_status_id.CompareTo(y.patient_status_id);
				}
			}
			#endregion
		}
		public class patient_statusComparer : System.Collections.Generic.IComparer<PatientStatus>
		{
			public SorterMode SorterMode;
			public patient_statusComparer()
			{ }
			public patient_statusComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<PatientStatus> Membres
			int System.Collections.Generic.IComparer<PatientStatus>.Compare(PatientStatus x, PatientStatus y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.patient_status.CompareTo(x.patient_status);
				}
				else
				{
                    return x.patient_status.CompareTo(y.patient_status);
				}
			}
			#endregion
		}
	}
}
