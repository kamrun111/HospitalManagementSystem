using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Patient
	{
		private int _patient_id;

		public int patient_id
		{
			get { return _patient_id; }
			set { _patient_id = value; }
		}

		private string _patient_type;

		public string patient_type
		{
			get { return _patient_type; }
			set { _patient_type = value; }
		}

		private string _patient_code;

		public string patient_code
		{
			get { return _patient_code; }
			set { _patient_code = value; }
		}

		private string _patient_name;

		public string patient_name
		{
			get { return _patient_name; }
			set { _patient_name = value; }
		}

		private string _guardian_name;

		public string guardian_name
		{
			get { return _guardian_name; }
			set { _guardian_name = value; }
		}

		private Nullable<int> _guardian_relation_id;

		public Nullable<int> guardian_relation_id
		{
			get { return _guardian_relation_id; }
			set { _guardian_relation_id = value; }
		}

		private Nullable<int> _gender_id;

		public Nullable<int> gender_id
		{
			get { return _gender_id; }
			set { _gender_id = value; }
		}

		private string _address;

		public string address
		{
			get { return _address; }
			set { _address = value; }
		}

		private Nullable<int> _city_id;

		public Nullable<int> city_id
		{
			get { return _city_id; }
			set { _city_id = value; }
		}

		private string _c_phone;

		public string c_phone
		{
			get { return _c_phone; }
			set { _c_phone = value; }
		}

		private Nullable<DateTime> _dob;

		public Nullable<DateTime> dob
		{
			get { return _dob; }
			set { _dob = value; }
		}

		private Nullable<int> _occupation_id;

		public Nullable<int> occupation_id
		{
			get { return _occupation_id; }
			set { _occupation_id = value; }
		}

		private Nullable<int> _nationality_id;

		public Nullable<int> nationality_id
		{
			get { return _nationality_id; }
			set { _nationality_id = value; }
		}

		private Nullable<int> _religion_id;

		public Nullable<int> religion_id
		{
			get { return _religion_id; }
			set { _religion_id = value; }
		}

		private Nullable<int> _patient_status_id;

		public Nullable<int> patient_status_id
		{
			get { return _patient_status_id; }
			set { _patient_status_id = value; }
		}

		private Nullable<int> _patient_condition_id;

		public Nullable<int> patient_condition_id
		{
			get { return _patient_condition_id; }
			set { _patient_condition_id = value; }
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

		public Patient()
		{ }

		public Patient(int patient_id,string patient_type,string patient_code,string patient_name,string guardian_name,Nullable<int> guardian_relation_id,Nullable<int> gender_id,string address,Nullable<int> city_id,string c_phone,Nullable<DateTime> dob,Nullable<int> occupation_id,Nullable<int> nationality_id,Nullable<int> religion_id,Nullable<int> patient_status_id,Nullable<int> patient_condition_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_id = patient_id;
			this.patient_type = patient_type;
			this.patient_code = patient_code;
			this.patient_name = patient_name;
			this.guardian_name = guardian_name;
			this.guardian_relation_id = guardian_relation_id;
			this.gender_id = gender_id;
			this.address = address;
			this.city_id = city_id;
			this.c_phone = c_phone;
			this.dob = dob;
			this.occupation_id = occupation_id;
			this.nationality_id = nationality_id;
			this.religion_id = religion_id;
			this.patient_status_id = patient_status_id;
			this.patient_condition_id = patient_condition_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "patient_id = " + patient_id.ToString() + ",patient_type = " + patient_type + ",patient_code = " + patient_code + ",patient_name = " + patient_name + ",guardian_name = " + guardian_name + ",guardian_relation_id = " + guardian_relation_id.ToString() + ",gender_id = " + gender_id.ToString() + ",address = " + address + ",city_id = " + city_id.ToString() + ",c_phone = " + c_phone + ",dob = " + dob.ToString() + ",occupation_id = " + occupation_id.ToString() + ",nationality_id = " + nationality_id.ToString() + ",religion_id = " + religion_id.ToString() + ",patient_status_id = " + patient_status_id.ToString() + ",patient_condition_id = " + patient_condition_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_idComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public patient_idComparer()
			{ }
			public patient_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_id.CompareTo(x.patient_id);
				}
				else
				{
					return x.patient_id.CompareTo(y.patient_id);
				}
			}
			#endregion
		}
		public class patient_typeComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public patient_typeComparer()
			{ }
			public patient_typeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_type.CompareTo(x.patient_type);
				}
				else
				{
					return x.patient_type.CompareTo(y.patient_type);
				}
			}
			#endregion
		}
		public class patient_codeComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public patient_codeComparer()
			{ }
			public patient_codeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_code.CompareTo(x.patient_code);
				}
				else
				{
					return x.patient_code.CompareTo(y.patient_code);
				}
			}
			#endregion
		}
		public class patient_nameComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public patient_nameComparer()
			{ }
			public patient_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_name.CompareTo(x.patient_name);
				}
				else
				{
					return x.patient_name.CompareTo(y.patient_name);
				}
			}
			#endregion
		}
		public class guardian_nameComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public guardian_nameComparer()
			{ }
			public guardian_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.guardian_name.CompareTo(x.guardian_name);
				}
				else
				{
					return x.guardian_name.CompareTo(y.guardian_name);
				}
			}
			#endregion
		}
		public class addressComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public addressComparer()
			{ }
			public addressComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.address.CompareTo(x.address);
				}
				else
				{
					return x.address.CompareTo(y.address);
				}
			}
			#endregion
		}
		public class c_phoneComparer : System.Collections.Generic.IComparer<Patient>
		{
			public SorterMode SorterMode;
			public c_phoneComparer()
			{ }
			public c_phoneComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient> Membres
			int System.Collections.Generic.IComparer<Patient>.Compare(Patient x, Patient y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.c_phone.CompareTo(x.c_phone);
				}
				else
				{
					return x.c_phone.CompareTo(y.c_phone);
				}
			}
			#endregion
		}
	}
}
