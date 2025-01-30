using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientCondition
	{
		private int _patient_condition_id;

		public int patient_condition_id
		{
			get { return _patient_condition_id; }
			set { _patient_condition_id = value; }
		}

		private string _patient_condition;

		public string patient_condition
		{
			get { return _patient_condition; }
			set { _patient_condition = value; }
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

		public PatientCondition()
		{ }

		public PatientCondition(int patient_condition_id,string patient_condition,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_condition_id = patient_condition_id;
			this.patient_condition = patient_condition;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_condition_id = " + patient_condition_id.ToString() + ",patient_condition = " + patient_condition + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_condition_idComparer : System.Collections.Generic.IComparer<PatientCondition>
		{
			public SorterMode SorterMode;
			public patient_condition_idComparer()
			{ }
			public patient_condition_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<PatientCondition> Membres
			int System.Collections.Generic.IComparer<PatientCondition>.Compare(PatientCondition x, PatientCondition y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_condition_id.CompareTo(x.patient_condition_id);
				}
				else
				{
					return x.patient_condition_id.CompareTo(y.patient_condition_id);
				}
			}
			#endregion
		}
		public class patient_conditionComparer : System.Collections.Generic.IComparer<PatientCondition>
		{
			public SorterMode SorterMode;
			public patient_conditionComparer()
			{ }
			public patient_conditionComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<PatientCondition> Membres
			int System.Collections.Generic.IComparer<PatientCondition>.Compare(PatientCondition x, PatientCondition y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.patient_condition.CompareTo(x.patient_condition);
				}
				else
				{
                    return x.patient_condition.CompareTo(y.patient_condition);
				}
			}
			#endregion
		}
	}
}
