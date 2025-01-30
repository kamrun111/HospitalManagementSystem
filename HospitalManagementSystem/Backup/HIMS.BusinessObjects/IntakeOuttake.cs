using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class IntakeOuttake
	{
		private int _intake_outtake_id;

		public int intake_outtake_id
		{
			get { return _intake_outtake_id; }
			set { _intake_outtake_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<DateTime> _in_date_time;

		public Nullable<DateTime> in_date_time
		{
			get { return _in_date_time; }
			set { _in_date_time = value; }
		}

		private Nullable<Decimal> _in_oral;

		public Nullable<Decimal> in_oral
		{
			get { return _in_oral; }
			set { _in_oral = value; }
		}

		private Nullable<Decimal> _in_parenteral;

		public Nullable<Decimal> in_parenteral
		{
			get { return _in_parenteral; }
			set { _in_parenteral = value; }
		}

		private Nullable<Decimal> _in_urinary_bladder_wash;

		public Nullable<Decimal> in_urinary_bladder_wash
		{
			get { return _in_urinary_bladder_wash; }
			set { _in_urinary_bladder_wash = value; }
		}

		private Nullable<Decimal> _in_total;

		public Nullable<Decimal> in_total
		{
			get { return _in_total; }
			set { _in_total = value; }
		}

		private Nullable<Decimal> _out_nasogastric;

		public Nullable<Decimal> out_nasogastric
		{
			get { return _out_nasogastric; }
			set { _out_nasogastric = value; }
		}

		private Nullable<Decimal> _out_drainage_tube;

		public Nullable<Decimal> out_drainage_tube
		{
			get { return _out_drainage_tube; }
			set { _out_drainage_tube = value; }
		}

		private Nullable<Decimal> _out_urine;

		public Nullable<Decimal> out_urine
		{
			get { return _out_urine; }
			set { _out_urine = value; }
		}

		private Nullable<Decimal> _out_t_tube;

		public Nullable<Decimal> out_t_tube
		{
			get { return _out_t_tube; }
			set { _out_t_tube = value; }
		}

		private Nullable<Decimal> _out_stool;

		public Nullable<Decimal> out_stool
		{
			get { return _out_stool; }
			set { _out_stool = value; }
		}

		private Nullable<Decimal> _invisible_loss;

		public Nullable<Decimal> invisible_loss
		{
			get { return _invisible_loss; }
			set { _invisible_loss = value; }
		}

		private Nullable<Decimal> _out_total;

		public Nullable<Decimal> out_total
		{
			get { return _out_total; }
			set { _out_total = value; }
		}

		private Nullable<Decimal> _balance;

		public Nullable<Decimal> balance
		{
			get { return _balance; }
			set { _balance = value; }
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

		public IntakeOuttake()
		{ }

		public IntakeOuttake(int intake_outtake_id,Nullable<int> admission_id,Nullable<DateTime> in_date_time,Nullable<Decimal> in_oral,Nullable<Decimal> in_parenteral,Nullable<Decimal> in_urinary_bladder_wash,Nullable<Decimal> in_total,Nullable<Decimal> out_nasogastric,Nullable<Decimal> out_drainage_tube,Nullable<Decimal> out_urine,Nullable<Decimal> out_t_tube,Nullable<Decimal> out_stool,Nullable<Decimal> invisible_loss,Nullable<Decimal> out_total,Nullable<Decimal> balance,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.intake_outtake_id = intake_outtake_id;
			this.admission_id = admission_id;
			this.in_date_time = in_date_time;
			this.in_oral = in_oral;
			this.in_parenteral = in_parenteral;
			this.in_urinary_bladder_wash = in_urinary_bladder_wash;
			this.in_total = in_total;
			this.out_nasogastric = out_nasogastric;
			this.out_drainage_tube = out_drainage_tube;
			this.out_urine = out_urine;
			this.out_t_tube = out_t_tube;
			this.out_stool = out_stool;
			this.invisible_loss = invisible_loss;
			this.out_total = out_total;
			this.balance = balance;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "intake_outtake_id = " + intake_outtake_id.ToString() + ",admission_id = " + admission_id.ToString() + ",in_date_time = " + in_date_time.ToString() + ",in_oral = " + in_oral.ToString() + ",in_parenteral = " + in_parenteral.ToString() + ",in_urinary_bladder_wash = " + in_urinary_bladder_wash.ToString() + ",in_total = " + in_total.ToString() + ",out_nasogastric = " + out_nasogastric.ToString() + ",out_drainage_tube = " + out_drainage_tube.ToString() + ",out_urine = " + out_urine.ToString() + ",out_t_tube = " + out_t_tube.ToString() + ",out_stool = " + out_stool.ToString() + ",invisible_loss = " + invisible_loss.ToString() + ",out_total = " + out_total.ToString() + ",balance = " + balance.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class intake_outtake_idComparer : System.Collections.Generic.IComparer<IntakeOuttake>
		{
			public SorterMode SorterMode;
			public intake_outtake_idComparer()
			{ }
			public intake_outtake_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<intake_outtake> Membres
			int System.Collections.Generic.IComparer<IntakeOuttake>.Compare(IntakeOuttake x, IntakeOuttake y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.intake_outtake_id.CompareTo(x.intake_outtake_id);
				}
				else
				{
					return x.intake_outtake_id.CompareTo(y.intake_outtake_id);
				}
			}
			#endregion
		}
	}
}
