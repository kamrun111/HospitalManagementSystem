using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Outdoor_booking
	{
		private int _outdoor_booking_id;

		public int outdoor_booking_id
		{
			get { return _outdoor_booking_id; }
			set { _outdoor_booking_id = value; }
		}

		private int _outdoor_patient_id;

		public int outdoor_patient_id
		{
			get { return _outdoor_patient_id; }
			set { _outdoor_patient_id = value; }
		}

		private Nullable<int> _reffered_doctors_id;

		public Nullable<int> reffered_doctors_id
		{
			get { return _reffered_doctors_id; }
			set { _reffered_doctors_id = value; }
		}

		private string _booking_date;

        public string booking_date
		{
			get { return _booking_date; }
			set { _booking_date = value; }
		}

		private string _booking_time;

		public string booking_time
		{
			get { return _booking_time; }
			set { _booking_time = value; }
		}

		private string _booking_serial_no;

		public string booking_serial_no
		{
			get { return _booking_serial_no; }
			set { _booking_serial_no = value; }
		}

		private string _room_no;

		public string room_no
		{
			get { return _room_no; }
			set { _room_no = value; }
		}

        private Nullable<Decimal> _discount;

        public Nullable<Decimal> discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

		private Nullable<Decimal> _amount;

		public Nullable<Decimal> amount
		{
			get { return _amount; }
			set { _amount = value; }
		}
        private Nullable<Decimal> _vat;

        public Nullable<Decimal> vat
        {
            get { return _vat; }
            set { _vat = value; }
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

        private string _patient_name;

        public string patient_name
        {
            get { return _patient_name; }
            set { _patient_name = value; }
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

        private string _dob;

        public string dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

		public Outdoor_booking()
		{ }

        public Outdoor_booking(int outdoor_booking_id, int outdoor_patient_id, string patient_name, Nullable<int> gender_id, string address, Nullable<int> city_id, string c_phone, string dob, Nullable<int> reffered_doctors_id, string booking_date, string booking_time, string booking_serial_no, string room_no,Nullable<Decimal> discount, Nullable<Decimal> amount, Nullable<Decimal> vat, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.outdoor_booking_id = outdoor_booking_id;
            this.patient_name = patient_name;
            this.outdoor_patient_id = outdoor_patient_id;
            this.gender_id = gender_id;
            this.address = address;
            this.city_id = city_id;
            this.c_phone = c_phone;
            this.dob = dob;
			this.reffered_doctors_id = reffered_doctors_id;
			this.booking_date = booking_date;
			this.booking_time = booking_time;
			this.booking_serial_no = booking_serial_no;
			this.room_no = room_no;
            this.discount = discount;
			this.amount = amount;
            this.vat = vat;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}
        
		public override string ToString()
		{
            return "outdoor_booking_id = " + outdoor_booking_id.ToString() + ",outdoor_patient_id = " + outdoor_patient_id.ToString() + ",reffered_doctors_id = " + reffered_doctors_id.ToString() + ",booking_date = " + booking_date.ToString() + ",booking_time = " + booking_time + ",booking_serial_no = " + booking_serial_no + ",room_no = " + room_no + ",discount=" + discount .ToString()+ ",amount = " + amount.ToString() + ",vat = " + vat.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class outdoor_booking_idComparer : System.Collections.Generic.IComparer<Outdoor_booking>
		{
			public SorterMode SorterMode;
			public outdoor_booking_idComparer()
			{ }
			public outdoor_booking_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_booking> Membres
			int System.Collections.Generic.IComparer<Outdoor_booking>.Compare(Outdoor_booking x, Outdoor_booking y)
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
		public class outdoor_patient_idComparer : System.Collections.Generic.IComparer<Outdoor_booking>
		{
			public SorterMode SorterMode;
			public outdoor_patient_idComparer()
			{ }
			public outdoor_patient_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_booking> Membres
			int System.Collections.Generic.IComparer<Outdoor_booking>.Compare(Outdoor_booking x, Outdoor_booking y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.outdoor_patient_id.CompareTo(x.outdoor_patient_id);
				}
				else
				{
					return x.outdoor_patient_id.CompareTo(y.outdoor_patient_id);
				}
			}
			#endregion
		}
		public class booking_timeComparer : System.Collections.Generic.IComparer<Outdoor_booking>
		{
			public SorterMode SorterMode;
			public booking_timeComparer()
			{ }
			public booking_timeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_booking> Membres
			int System.Collections.Generic.IComparer<Outdoor_booking>.Compare(Outdoor_booking x, Outdoor_booking y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.booking_time.CompareTo(x.booking_time);
				}
				else
				{
					return x.booking_time.CompareTo(y.booking_time);
				}
			}
			#endregion
		}
		public class booking_serial_noComparer : System.Collections.Generic.IComparer<Outdoor_booking>
		{
			public SorterMode SorterMode;
			public booking_serial_noComparer()
			{ }
			public booking_serial_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_booking> Membres
			int System.Collections.Generic.IComparer<Outdoor_booking>.Compare(Outdoor_booking x, Outdoor_booking y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.booking_serial_no.CompareTo(x.booking_serial_no);
				}
				else
				{
					return x.booking_serial_no.CompareTo(y.booking_serial_no);
				}
			}
			#endregion
		}
		public class room_noComparer : System.Collections.Generic.IComparer<Outdoor_booking>
		{
			public SorterMode SorterMode;
			public room_noComparer()
			{ }
			public room_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<outdoor_booking> Membres
			int System.Collections.Generic.IComparer<Outdoor_booking>.Compare(Outdoor_booking x, Outdoor_booking y)
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
