using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OutdoorPatientAdvice
	{
		private int _outdoor_patient_advice_id;

		public int outdoor_patient_advice_id
		{
			get { return _outdoor_patient_advice_id; }
			set { _outdoor_patient_advice_id = value; }
		}

		private string _outdoor_booking_id;

		public string outdoor_booking_id
		{
			get { return _outdoor_booking_id; }
			set { _outdoor_booking_id = value; }
		}

		private string _outdoor_patient_advice;

		public string outdoor_patient_advice
		{
			get { return _outdoor_patient_advice; }
			set { _outdoor_patient_advice = value; }
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

		public OutdoorPatientAdvice()
		{ }

		public OutdoorPatientAdvice(int outdoor_patient_advice_id,string outdoor_booking_id,string outdoor_patient_advice,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.outdoor_patient_advice_id = outdoor_patient_advice_id;
			this.outdoor_booking_id = outdoor_booking_id;
			this.outdoor_patient_advice = outdoor_patient_advice;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "outdoor_patient_advice_id = " + outdoor_patient_advice_id.ToString() + ",outdoor_booking_id = " + outdoor_booking_id + ",outdoor_patient_advice = " + outdoor_patient_advice + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class outdoor_patient_advice_idComparer : System.Collections.Generic.IComparer<OutdoorPatientAdvice>
		{
			public SorterMode SorterMode;
			public outdoor_patient_advice_idComparer()
			{ }
			public outdoor_patient_advice_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<OutdoorPatientAdvice> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientAdvice>.Compare(OutdoorPatientAdvice x, OutdoorPatientAdvice y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.outdoor_patient_advice_id.CompareTo(x.outdoor_patient_advice_id);
				}
				else
				{
					return x.outdoor_patient_advice_id.CompareTo(y.outdoor_patient_advice_id);
				}
			}
			#endregion
		}
		public class outdoor_booking_idComparer : System.Collections.Generic.IComparer<OutdoorPatientAdvice>
		{
			public SorterMode SorterMode;
			public outdoor_booking_idComparer()
			{ }
			public outdoor_booking_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<OutdoorPatientAdvice> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientAdvice>.Compare(OutdoorPatientAdvice x, OutdoorPatientAdvice y)
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
		public class outdoor_patient_adviceComparer : System.Collections.Generic.IComparer<OutdoorPatientAdvice>
		{
			public SorterMode SorterMode;
			public outdoor_patient_adviceComparer()
			{ }
			public outdoor_patient_adviceComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<OutdoorPatientAdvice> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientAdvice>.Compare(OutdoorPatientAdvice x, OutdoorPatientAdvice y)
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
	}
}
