using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientCC
	{
		private int _patient_cc_id;

		public int patient_cc_id
		{
			get { return _patient_cc_id; }
			set { _patient_cc_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private string _cc;

		public string cc
		{
			get { return _cc; }
			set { _cc = value; }
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

		public PatientCC()
		{ }

		public PatientCC(int patient_cc_id,Nullable<int> admission_id,string cc,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_cc_id = patient_cc_id;
			this.admission_id = admission_id;
			this.cc = cc;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_cc_id = " + patient_cc_id.ToString() + ",admission_id = " + admission_id.ToString() + ",cc = " + cc + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_cc_idComparer : System.Collections.Generic.IComparer<PatientCC>
		{
			public SorterMode SorterMode;
			public patient_cc_idComparer()
			{ }
			public patient_cc_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_cc> Membres
			int System.Collections.Generic.IComparer<PatientCC>.Compare(PatientCC x, PatientCC y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_cc_id.CompareTo(x.patient_cc_id);
				}
				else
				{
					return x.patient_cc_id.CompareTo(y.patient_cc_id);
				}
			}
			#endregion
		}
		public class ccComparer : System.Collections.Generic.IComparer<PatientCC>
		{
			public SorterMode SorterMode;
			public ccComparer()
			{ }
			public ccComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_cc> Membres
			int System.Collections.Generic.IComparer<PatientCC>.Compare(PatientCC x, PatientCC y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.cc.CompareTo(x.cc);
				}
				else
				{
					return x.cc.CompareTo(y.cc);
				}
			}
			#endregion
		}
	}
}
