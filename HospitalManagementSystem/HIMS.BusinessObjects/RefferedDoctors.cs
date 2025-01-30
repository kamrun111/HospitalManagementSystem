using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class RefferedDoctors
	{
		private int _reffered_doctors_id;

		public int reffered_doctors_id
		{
			get { return _reffered_doctors_id; }
			set { _reffered_doctors_id = value; }
		}

		private string _reffered_doctors;

        public string reffered_doctors
		{
			get { return _reffered_doctors; }
			set { _reffered_doctors = value; }
		}

		private string _d_c;

		public string d_c
		{
			get { return _d_c; }
			set { _d_c = value; }
		}

		private string _degree;

		public string degree
		{
			get { return _degree; }
			set { _degree = value; }
		}

		private Nullable<int> _doctor_level_id;

		public Nullable<int> doctor_level_id
		{
			get { return _doctor_level_id; }
			set { _doctor_level_id = value; }
		}

		private Nullable<int> _specialist_in_id;

		public Nullable<int> specialist_in_id
		{
			get { return _specialist_in_id; }
			set { _specialist_in_id = value; }
		}

		private Nullable<int> _designation_id;

		public Nullable<int> designation_id
		{
			get { return _designation_id; }
			set { _designation_id = value; }
		}

		private Nullable<int> _gender_id;

		public Nullable<int> gender_id
		{
			get { return _gender_id; }
			set { _gender_id = value; }
		}

		private string _attachment;

		public string attachment
		{
			get { return _attachment; }
			set { _attachment = value; }
		}

		private string _contact_no;

		public string contact_no
		{
			get { return _contact_no; }
			set { _contact_no = value; }
		}

		private string _mobile;

		public string mobile
		{
			get { return _mobile; }
			set { _mobile = value; }
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

		private Nullable<Decimal> _visit_charge;

		public Nullable<Decimal> visit_charge
		{
			get { return _visit_charge; }
			set { _visit_charge = value; }
		}

        private Nullable<Decimal> _first_assistant_charge;

        public Nullable<Decimal> first_assistant_charge
        {
            get { return _first_assistant_charge; }
            set { _first_assistant_charge = value; }
        }

        private Nullable<Decimal> _second_assistant_charge;

        public Nullable<Decimal> second_assistant_charge
        {
            get { return _second_assistant_charge; }
            set { _second_assistant_charge = value; }
        }
        private Nullable<Decimal> _third_assistant_charge;

        public Nullable<Decimal> third_assistant_charge
        {
            get { return _third_assistant_charge; }
            set { _third_assistant_charge = value; }
        }

		private Nullable<Decimal> _sergery_charge;

		public Nullable<Decimal> sergery_charge
		{
			get { return _sergery_charge; }
			set { _sergery_charge = value; }
		}

		private Nullable<Decimal> _dressing_charge;

		public Nullable<Decimal> dressing_charge
		{
			get { return _dressing_charge; }
			set { _dressing_charge = value; }
		}

        private Nullable<Decimal> _anaesthesia_chrge;

        public Nullable<Decimal> anaesthesia_chrge
        {
            get { return _anaesthesia_chrge; }
            set { _anaesthesia_chrge = value; }
        }

		private Nullable<SByte> _is_consultant;

		public Nullable<SByte> is_consultant
		{
			get { return _is_consultant; }
			set { _is_consultant = value; }
		}

		private string _room_no;

		public string room_no
		{
			get { return _room_no; }
			set { _room_no = value; }
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

		public RefferedDoctors()
		{ }

        public RefferedDoctors(int reffered_doctors_id, string reffered_doctors, string d_c, string degree, Nullable<int> doctor_level_id, Nullable<int> specialist_in_id, Nullable<int> designation_id, Nullable<int> gender_id, string attachment, string contact_no, string mobile, string address, Nullable<int> city_id, Nullable<Decimal> visit_charge, Nullable<Decimal> first_assistant_charge, Nullable<Decimal> second_assistant_charge, Nullable<Decimal> third_assistant_charge, Nullable<Decimal> sergery_charge, Nullable<Decimal> dressing_charge, Nullable<Decimal> anaesthesia_chrge, Nullable<SByte> is_consultant, string room_no, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.reffered_doctors_id = reffered_doctors_id;
			this.reffered_doctors = reffered_doctors;
			this.d_c = d_c;
			this.degree = degree;
			this.doctor_level_id = doctor_level_id;
			this.specialist_in_id = specialist_in_id;
			this.designation_id = designation_id;
			this.gender_id = gender_id;
			this.attachment = attachment;
			this.contact_no = contact_no;
			this.mobile = mobile;
			this.address = address;
			this.city_id = city_id;
			this.visit_charge = visit_charge;
            this.first_assistant_charge = first_assistant_charge;
            this.second_assistant_charge = second_assistant_charge;
            this.third_assistant_charge = third_assistant_charge;
			this.sergery_charge = sergery_charge;
			this.dressing_charge = dressing_charge;
            this.anaesthesia_chrge = anaesthesia_chrge;
			this.is_consultant = is_consultant;
			this.room_no = room_no;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "reffered_doctors_id = " + reffered_doctors_id.ToString() + ",reffered_doctors = " + reffered_doctors + ",d_c = " + d_c + ",degree = " + degree + ",doctor_level_id = " + doctor_level_id.ToString() + ",specialist_in_id = " + specialist_in_id.ToString() + ",designation_id = " + designation_id.ToString() + ",gender_id = " + gender_id.ToString() + ",attachment = " + attachment + ",contact_no = " + contact_no + ",mobile = " + mobile + ",address = " + address + ",city_id = " + city_id.ToString() + ",visit_charge = " + visit_charge.ToString() + ",first_assistant_charge = " + first_assistant_charge.ToString() + ",second_assistant_charge = " + second_assistant_charge.ToString() + ",third_assistant_charge = " + third_assistant_charge.ToString() + ",sergery_charge = " + sergery_charge.ToString() + ",dressing_charge = " + dressing_charge.ToString() + ",anaesthesia_chrge=" + anaesthesia_chrge.ToString() + ",is_consultant = " + is_consultant.ToString() + ",room_no = " + room_no + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class reffered_doctors_idComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public reffered_doctors_idComparer()
			{ }
			public reffered_doctors_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.reffered_doctors_id.CompareTo(x.reffered_doctors_id);
				}
				else
				{
					return x.reffered_doctors_id.CompareTo(y.reffered_doctors_id);
				}
			}
			#endregion
		}
		public class reffered_doctorsComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public reffered_doctorsComparer()
			{ }
			public reffered_doctorsComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.reffered_doctors.CompareTo(x.reffered_doctors);
				}
				else
				{
                    return x.reffered_doctors.CompareTo(y.reffered_doctors);
				}
			}
			#endregion
		}
		public class d_cComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public d_cComparer()
			{ }
			public d_cComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.d_c.CompareTo(x.d_c);
				}
				else
				{
					return x.d_c.CompareTo(y.d_c);
				}
			}
			#endregion
		}
		public class degreeComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public degreeComparer()
			{ }
			public degreeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.degree.CompareTo(x.degree);
				}
				else
				{
					return x.degree.CompareTo(y.degree);
				}
			}
			#endregion
		}
		public class attachmentComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public attachmentComparer()
			{ }
			public attachmentComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.attachment.CompareTo(x.attachment);
				}
				else
				{
					return x.attachment.CompareTo(y.attachment);
				}
			}
			#endregion
		}
		public class contact_noComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public contact_noComparer()
			{ }
			public contact_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.contact_no.CompareTo(x.contact_no);
				}
				else
				{
					return x.contact_no.CompareTo(y.contact_no);
				}
			}
			#endregion
		}
		public class mobileComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public mobileComparer()
			{ }
			public mobileComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.mobile.CompareTo(x.mobile);
				}
				else
				{
					return x.mobile.CompareTo(y.mobile);
				}
			}
			#endregion
		}
		public class addressComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public addressComparer()
			{ }
			public addressComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
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
		public class room_noComparer : System.Collections.Generic.IComparer<RefferedDoctors>
		{
			public SorterMode SorterMode;
			public room_noComparer()
			{ }
			public room_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<RefferedDoctors> Membres
			int System.Collections.Generic.IComparer<RefferedDoctors>.Compare(RefferedDoctors x, RefferedDoctors y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.room_no.CompareTo(x.room_no);
				}
				else
				{
					return x.room_no.CompareTo(y.room_no);
				}
			}
			#endregion
		}
	}
}
