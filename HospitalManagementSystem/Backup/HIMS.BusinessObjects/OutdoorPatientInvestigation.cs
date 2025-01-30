using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OutdoorPatientInvestigation
	{
		private int _outdoor_patient_investigation_id;

		public int outdoor_patient_investigation_id
		{
			get { return _outdoor_patient_investigation_id; }
			set { _outdoor_patient_investigation_id = value; }
		}

		private string _outdoor_booking_id;

		public string outdoor_booking_id
		{
			get { return _outdoor_booking_id; }
			set { _outdoor_booking_id = value; }
		}

		private string _investigation_name;

		public string investigation_name
		{
			get { return _investigation_name; }
			set { _investigation_name = value; }
		}

		private string _investivation_result;

		public string investivation_result
		{
			get { return _investivation_result; }
			set { _investivation_result = value; }
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

		public OutdoorPatientInvestigation()
		{ }

		public OutdoorPatientInvestigation(int outdoor_patient_investigation_id,string outdoor_booking_id,string investigation_name,string investivation_result,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.outdoor_patient_investigation_id = outdoor_patient_investigation_id;
			this.outdoor_booking_id = outdoor_booking_id;
			this.investigation_name = investigation_name;
			this.investivation_result = investivation_result;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "outdoor_patient_investigation_id = " + outdoor_patient_investigation_id.ToString() + ",outdoor_booking_id = " + outdoor_booking_id + ",investigation_name = " + investigation_name + ",investivation_result = " + investivation_result + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class outdoor_patient_investigation_idComparer : System.Collections.Generic.IComparer<OutdoorPatientInvestigation>
		{
			public SorterMode SorterMode;
			public outdoor_patient_investigation_idComparer()
			{ }
			public outdoor_patient_investigation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_investigation> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientInvestigation>.Compare(OutdoorPatientInvestigation x, OutdoorPatientInvestigation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.outdoor_patient_investigation_id.CompareTo(x.outdoor_patient_investigation_id);
				}
				else
				{
					return x.outdoor_patient_investigation_id.CompareTo(y.outdoor_patient_investigation_id);
				}
			}
			#endregion
		}
		public class outdoor_booking_idComparer : System.Collections.Generic.IComparer<OutdoorPatientInvestigation>
		{
			public SorterMode SorterMode;
			public outdoor_booking_idComparer()
			{ }
			public outdoor_booking_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_investigation> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientInvestigation>.Compare(OutdoorPatientInvestigation x, OutdoorPatientInvestigation y)
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
		public class investigation_nameComparer : System.Collections.Generic.IComparer<OutdoorPatientInvestigation>
		{
			public SorterMode SorterMode;
			public investigation_nameComparer()
			{ }
			public investigation_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_investigation> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientInvestigation>.Compare(OutdoorPatientInvestigation x, OutdoorPatientInvestigation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investigation_name.CompareTo(x.investigation_name);
				}
				else
				{
					return x.investigation_name.CompareTo(y.investigation_name);
				}
			}
			#endregion
		}
		public class investivation_resultComparer : System.Collections.Generic.IComparer<OutdoorPatientInvestigation>
		{
			public SorterMode SorterMode;
			public investivation_resultComparer()
			{ }
			public investivation_resultComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_patient_investigation> Membres
			int System.Collections.Generic.IComparer<OutdoorPatientInvestigation>.Compare(OutdoorPatientInvestigation x, OutdoorPatientInvestigation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investivation_result.CompareTo(x.investivation_result);
				}
				else
				{
					return x.investivation_result.CompareTo(y.investivation_result);
				}
			}
			#endregion
		}
	}
}
