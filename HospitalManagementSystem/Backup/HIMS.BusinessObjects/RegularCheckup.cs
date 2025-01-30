using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class RegularCheckup
	{
		private int _regular_checkup_id;

		public int regular_checkup_id
		{
			get { return _regular_checkup_id; }
			set { _regular_checkup_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<Decimal> _temperature;

		public Nullable<Decimal> temperature
		{
			get { return _temperature; }
			set { _temperature = value; }
		}

		private Nullable<int> _pulse;

		public Nullable<int> pulse
		{
			get { return _pulse; }
			set { _pulse = value; }
		}

		private string _bp;

		public string bp
		{
			get { return _bp; }
			set { _bp = value; }
		}

		private Nullable<int> _respitation;

		public Nullable<int> respitation
		{
			get { return _respitation; }
			set { _respitation = value; }
		}

		private string _stool;

		public string stool
		{
			get { return _stool; }
			set { _stool = value; }
		}

		private Nullable<Decimal> _weight;

		public Nullable<Decimal> weight
		{
			get { return _weight; }
			set { _weight = value; }
		}

		private Nullable<DateTime> _checkup_date;

		public Nullable<DateTime> checkup_date
		{
			get { return _checkup_date; }
			set { _checkup_date = value; }
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

		public RegularCheckup()
		{ }

		public RegularCheckup(int regular_checkup_id,Nullable<int> admission_id,Nullable<Decimal> temperature,Nullable<int> pulse,string bp,Nullable<int> respitation,string stool,Nullable<Decimal> weight,Nullable<DateTime> checkup_date,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.regular_checkup_id = regular_checkup_id;
			this.admission_id = admission_id;
			this.temperature = temperature;
			this.pulse = pulse;
			this.bp = bp;
			this.respitation = respitation;
			this.stool = stool;
			this.weight = weight;
			this.checkup_date = checkup_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "regular_checkup_id = " + regular_checkup_id.ToString() + ",admission_id = " + admission_id.ToString() + ",temperature = " + temperature.ToString() + ",pulse = " + pulse.ToString() + ",bp = " + bp + ",respitation = " + respitation.ToString() + ",stool = " + stool + ",weight = " + weight.ToString() + ",checkup_date = " + checkup_date.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class regular_checkup_idComparer : System.Collections.Generic.IComparer<RegularCheckup>
		{
			public SorterMode SorterMode;
			public regular_checkup_idComparer()
			{ }
			public regular_checkup_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<regular_checkup> Membres
			int System.Collections.Generic.IComparer<RegularCheckup>.Compare(RegularCheckup x, RegularCheckup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.regular_checkup_id.CompareTo(x.regular_checkup_id);
				}
				else
				{
					return x.regular_checkup_id.CompareTo(y.regular_checkup_id);
				}
			}
			#endregion
		}
		public class bpComparer : System.Collections.Generic.IComparer<RegularCheckup>
		{
			public SorterMode SorterMode;
			public bpComparer()
			{ }
			public bpComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<regular_checkup> Membres
			int System.Collections.Generic.IComparer<RegularCheckup>.Compare(RegularCheckup x, RegularCheckup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.bp.CompareTo(x.bp);
				}
				else
				{
					return x.bp.CompareTo(y.bp);
				}
			}
			#endregion
		}
		public class stoolComparer : System.Collections.Generic.IComparer<RegularCheckup>
		{
			public SorterMode SorterMode;
			public stoolComparer()
			{ }
			public stoolComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<regular_checkup> Membres
			int System.Collections.Generic.IComparer<RegularCheckup>.Compare(RegularCheckup x, RegularCheckup y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.stool.CompareTo(x.stool);
				}
				else
				{
					return x.stool.CompareTo(y.stool);
				}
			}
			#endregion
		}
	}
}
