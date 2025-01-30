using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class BabyNote
	{
		private int _baby_note_id;

		public int baby_note_id
		{
			get { return _baby_note_id; }
			set { _baby_note_id = value; }
		}

		private Nullable<DateTime> _date_time;

		public Nullable<DateTime> date_time
		{
			get { return _date_time; }
			set { _date_time = value; }
		}

		private string _a_s;

		public string a_s
		{
			get { return _a_s; }
			set { _a_s = value; }
		}

        private string _c_a;

        public string c_a
        {
            get { return _c_a; }
            set { _c_a = value; }
        }

		private Nullable<int> _sex;

        public Nullable<int> sex
		{
			get { return _sex; }
			set { _sex = value; }
		}

		private string _weight;

        public string weight
		{
			get { return _weight; }
			set { _weight = value; }
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

		public BabyNote()
		{ }

        public BabyNote(int baby_note_id, Nullable<DateTime> date_time, string a_s,string c_a, Nullable<int> sex, string weight, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.baby_note_id = baby_note_id;
			this.date_time = date_time;
			this.a_s = a_s;
            this.c_a = c_a;
			this.sex = sex;
			this.weight = weight;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "baby_note_id = " + baby_note_id.ToString() + ",date_time = " + date_time.ToString() + ",a_s = " + a_s + ",c_a="+c_a+",sex = " + sex + ",weight = " + weight + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class baby_note_idComparer : System.Collections.Generic.IComparer<BabyNote>
		{
			public SorterMode SorterMode;
			public baby_note_idComparer()
			{ }
			public baby_note_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<baby_note> Membres
			int System.Collections.Generic.IComparer<BabyNote>.Compare(BabyNote x, BabyNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.baby_note_id.CompareTo(x.baby_note_id);
				}
				else
				{
					return x.baby_note_id.CompareTo(y.baby_note_id);
				}
			}
			#endregion
		}
		public class a_sComparer : System.Collections.Generic.IComparer<BabyNote>
		{
			public SorterMode SorterMode;
			public a_sComparer()
			{ }
			public a_sComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<baby_note> Membres
			int System.Collections.Generic.IComparer<BabyNote>.Compare(BabyNote x, BabyNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.a_s.CompareTo(x.a_s);
				}
				else
				{
					return x.a_s.CompareTo(y.a_s);
				}
			}
			#endregion
		}
			
		}
	}

