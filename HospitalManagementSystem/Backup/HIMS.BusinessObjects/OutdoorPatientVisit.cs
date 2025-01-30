using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OutdoorPatientVisit
	{
		private int _outdoor_patient_visit_id;

		public int outdoor_patient_visit_id
		{
			get { return _outdoor_patient_visit_id; }
			set { _outdoor_patient_visit_id = value; }
		}

		private string _outdoor_booking_id;

		public string outdoor_booking_id
		{
			get { return _outdoor_booking_id; }
			set { _outdoor_booking_id = value; }
		}

		private Nullable<DateTime> _visited_date;

		public Nullable<DateTime> visited_date
		{
			get { return _visited_date; }
			set { _visited_date = value; }
		}

        private string _patient_bp;

        public string patient_bp
		{
			get { return _patient_bp; }
			set { _patient_bp = value; }
		}

		private Nullable<int> _patient_pulse;

		public Nullable<int> patient_pulse
		{
			get { return _patient_pulse; }
			set { _patient_pulse = value; }
		}

		private Nullable<Double> _patient_height;

		public Nullable<Double> patient_height
		{
			get { return _patient_height; }
			set { _patient_height = value; }
		}

		private Nullable<int> _patient_weight;

		public Nullable<int> patient_weight
		{
			get { return _patient_weight; }
			set { _patient_weight = value; }
		}

		private Nullable<Double> _patient_temp;

		public Nullable<Double> patient_temp
		{
			get { return _patient_temp; }
			set { _patient_temp = value; }
		}

		private string _patient_cc;

		public string patient_cc
		{
			get { return _patient_cc; }
			set { _patient_cc = value; }
		}

		private string _patient_primary_diagonosis;

		public string patient_primary_diagonosis
		{
			get { return _patient_primary_diagonosis; }
			set { _patient_primary_diagonosis = value; }
		}

		private Nullable<DateTime> _next_visit_date;

		public Nullable<DateTime> next_visit_date
		{
			get { return _next_visit_date; }
			set { _next_visit_date = value; }
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

		public OutdoorPatientVisit()
		{ }

        public OutdoorPatientVisit(int outdoor_patient_visit_id, string outdoor_booking_id, Nullable<DateTime> visited_date, string patient_bp, Nullable<int> patient_pulse, Nullable<Double> patient_height, Nullable<int> patient_weight, Nullable<Double> patient_temp, string patient_cc, string patient_primary_diagonosis, Nullable<DateTime> next_visit_date, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.outdoor_patient_visit_id = outdoor_patient_visit_id;
			this.outdoor_booking_id = outdoor_booking_id;
			this.visited_date = visited_date;
			this.patient_bp = patient_bp;
			this.patient_pulse = patient_pulse;
			this.patient_height = patient_height;
			this.patient_weight = patient_weight;
			this.patient_temp = patient_temp;
			this.patient_cc = patient_cc;
			this.patient_primary_diagonosis = patient_primary_diagonosis;
			this.next_visit_date = next_visit_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "outdoor_patient_visit_id = " + outdoor_patient_visit_id.ToString() + ",outdoor_booking_id = " + outdoor_booking_id + ",visited_date = " + visited_date.ToString() + ",patient_bp = " + patient_bp + ",patient_pulse = " + patient_pulse.ToString() + ",patient_height = " + patient_height.ToString() + ",patient_weight = " + patient_weight.ToString() + ",patient_temp = " + patient_temp.ToString() + ",patient_cc = " + patient_cc + ",patient_primary_diagonosis = " + patient_primary_diagonosis + ",next_visit_date = " + next_visit_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class outdoor_patient_visit_idComparer : System.Collections.Generic.IComparer<OutdoorPatientVisit>
		{
			public SorterMode SorterMode;
			public outdoor_patient_visit_idComparer()
			{ }
			public outdoor_patient_visit_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_visit> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientVisit>.Compare(OutdoorPatientVisit x, OutdoorPatientVisit y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.outdoor_patient_visit_id.CompareTo(x.outdoor_patient_visit_id);
				}
				else
				{
					return x.outdoor_patient_visit_id.CompareTo(y.outdoor_patient_visit_id);
				}
			}
			#endregion
		}
		public class outdoor_booking_idComparer : System.Collections.Generic.IComparer<OutdoorPatientVisit>
		{
			public SorterMode SorterMode;
			public outdoor_booking_idComparer()
			{ }
			public outdoor_booking_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_visit> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientVisit>.Compare(OutdoorPatientVisit x, OutdoorPatientVisit y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.outdoor_booking_id.CompareTo(x.outdoor_booking_id);
				}
				else
				{
					return x.outdoor_booking_id.CompareTo(y.outdoor_booking_id);
				}
			}
			#endregion
		}
		public class patient_ccComparer : System.Collections.Generic.IComparer<OutdoorPatientVisit>
		{
			public SorterMode SorterMode;
			public patient_ccComparer()
			{ }
			public patient_ccComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_visit> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientVisit>.Compare(OutdoorPatientVisit x, OutdoorPatientVisit y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_cc.CompareTo(x.patient_cc);
				}
				else
				{
					return x.patient_cc.CompareTo(y.patient_cc);
				}
			}
			#endregion
		}
		public class patient_primary_diagonosisComparer : System.Collections.Generic.IComparer<OutdoorPatientVisit>
		{
			public SorterMode SorterMode;
			public patient_primary_diagonosisComparer()
			{ }
			public patient_primary_diagonosisComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_visit> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientVisit>.Compare(OutdoorPatientVisit x, OutdoorPatientVisit y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_primary_diagonosis.CompareTo(x.patient_primary_diagonosis);
				}
				else
				{
					return x.patient_primary_diagonosis.CompareTo(y.patient_primary_diagonosis);
				}
			}
			#endregion
		}
	}
}
