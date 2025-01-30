using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OutdoorPatientMedication
	{
		private int _outdoor_patient_medication_id;

		public int outdoor_patient_medication_id
		{
			get { return _outdoor_patient_medication_id; }
			set { _outdoor_patient_medication_id = value; }
		}

		private int _outdoor_booking_id;

		public int outdoor_booking_id
		{
			get { return _outdoor_booking_id; }
			set { _outdoor_booking_id = value; }
		}

		private string _medication_name;

		public string medication_name
		{
			get { return _medication_name; }
			set { _medication_name = value; }
		}
     

         private string _type;

		public string type
		{
			get { return _type; }
			set { _type = value; }
		}

		private string _dose_qty;

		public string dose_qty
		{
			get { return _dose_qty; }
			set { _dose_qty = value; }
		}

		private string _intake_method;

		public string intake_method
		{
			get { return _intake_method; }
			set { _intake_method = value; }
		}

        private Nullable<decimal> _morning;

        public Nullable<decimal> morning
		{
            get { return _morning; }
            set { _morning = value; }
		}

        private Nullable<decimal> _noon;

        public Nullable<decimal> noon
		{
            get { return _noon; }
            set { _noon = value; }
		}
        private Nullable<decimal> _evening;
        public Nullable<decimal> evening
        {
            get { return _evening; }
            set { _evening = value; }
        }
        private Nullable<decimal> _night;
        public Nullable<decimal> night
        {
            get { return _night; }
            set { _night = value; }
        }
        private Nullable<int> _DDay;
        public Nullable<int> DDay
        {
            get { return _DDay; }
            set { _DDay = value; }
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

		public OutdoorPatientMedication()
		{ }

        public OutdoorPatientMedication(int outdoor_patient_medication_id, int outdoor_booking_id, string medication_name, string dose_qty, string intake_method, Nullable<decimal> morning, Nullable<decimal> noon, Nullable<decimal> evening, Nullable<decimal> night, Nullable<int> DDay, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.outdoor_patient_medication_id = outdoor_patient_medication_id;
			this.outdoor_booking_id = outdoor_booking_id;
			this.medication_name = medication_name;
			this.dose_qty = dose_qty;
			this.intake_method = intake_method;
            this.morning = morning;
            this.noon = noon;
            this.evening = evening;
            this.night = night;
            this.DDay = DDay;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "outdoor_patient_medication_id = " + outdoor_patient_medication_id.ToString() + ",outdoor_booking_id = " + outdoor_booking_id + ",medication_name = " + medication_name + ",dose_qty = " + dose_qty + ",intake_method = " + intake_method + ",morning = " + morning + ",noon = " + noon + ",evening = " + evening + ",night = " + night + ",DDay = " + DDay + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class outdoor_patient_medication_idComparer : System.Collections.Generic.IComparer<OutdoorPatientMedication>
		{
			public SorterMode SorterMode;
			public outdoor_patient_medication_idComparer()
			{ }
			public outdoor_patient_medication_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_medication> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientMedication>.Compare(OutdoorPatientMedication x, OutdoorPatientMedication y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.outdoor_patient_medication_id.CompareTo(x.outdoor_patient_medication_id);
				}
				else
				{
					return x.outdoor_patient_medication_id.CompareTo(y.outdoor_patient_medication_id);
				}
			}
			#endregion
		}
		public class outdoor_booking_idComparer : System.Collections.Generic.IComparer<OutdoorPatientMedication>
		{
			public SorterMode SorterMode;
			public outdoor_booking_idComparer()
			{ }
			public outdoor_booking_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_medication> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientMedication>.Compare(OutdoorPatientMedication x, OutdoorPatientMedication y)
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
		public class medication_nameComparer : System.Collections.Generic.IComparer<OutdoorPatientMedication>
		{
			public SorterMode SorterMode;
			public medication_nameComparer()
			{ }
			public medication_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_medication> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientMedication>.Compare(OutdoorPatientMedication x, OutdoorPatientMedication y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.medication_name.CompareTo(x.medication_name);
				}
				else
				{
					return x.medication_name.CompareTo(y.medication_name);
				}
			}
			#endregion
		}
		public class dose_qtyComparer : System.Collections.Generic.IComparer<OutdoorPatientMedication>
		{
			public SorterMode SorterMode;
			public dose_qtyComparer()
			{ }
			public dose_qtyComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_medication> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientMedication>.Compare(OutdoorPatientMedication x, OutdoorPatientMedication y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.dose_qty.CompareTo(x.dose_qty);
				}
				else
				{
					return x.dose_qty.CompareTo(y.dose_qty);
				}
			}
			#endregion
		}
		public class intake_methodComparer : System.Collections.Generic.IComparer<OutdoorPatientMedication>
		{
			public SorterMode SorterMode;
			public intake_methodComparer()
			{ }
			public intake_methodComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_medication> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientMedication>.Compare(OutdoorPatientMedication x, OutdoorPatientMedication y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.intake_method.CompareTo(x.intake_method);
				}
				else
				{
					return x.intake_method.CompareTo(y.intake_method);
				}
			}
			#endregion
		}
	}
}
