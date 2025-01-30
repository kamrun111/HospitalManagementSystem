using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class VisitMedicine
	{
		private int _visit_medicine_id;

		public int visit_medicine_id
		{
			get { return _visit_medicine_id; }
			set { _visit_medicine_id = value; }
		}

		private Nullable<int> _visit_prescription_id;

		public Nullable<int> visit_prescription_id
		{
			get { return _visit_prescription_id; }
			set { _visit_prescription_id = value; }
		}

		private Nullable<int> _medicine_id;

		public Nullable<int> medicine_id
		{
			get { return _medicine_id; }
			set { _medicine_id = value; }
		}

		private Nullable<int> _dose_p_quantity_id;

		public Nullable<int> dose_p_quantity_id
		{
			get { return _dose_p_quantity_id; }
			set { _dose_p_quantity_id = value; }
		}

		private Nullable<int> _intake_sys_id;

		public Nullable<int> intake_sys_id
		{
			get { return _intake_sys_id; }
			set { _intake_sys_id = value; }
		}

		private Nullable<DateTime> _medication_date;

		public Nullable<DateTime> medication_date
		{
			get { return _medication_date; }
			set { _medication_date = value; }
		}

		private Nullable<int> _dose_count;

		public Nullable<int> dose_count
		{
			get { return _dose_count; }
			set { _dose_count = value; }
		}

		private string _time_slots;

		public string time_slots
		{
			get { return _time_slots; }
			set { _time_slots = value; }
		}

        private Nullable<int> _is_submit;

        public Nullable<int> is_submit
        {
            get { return _is_submit; }
            set { _is_submit = value; }
        }

		private Nullable<int> _indent_given_once;

		public Nullable<int> indent_given_once
		{
			get { return _indent_given_once; }
			set { _indent_given_once = value; }
		}

		private Nullable<int> _implication_way_id;

		public Nullable<int> implication_way_id
		{
			get { return _implication_way_id; }
			set { _implication_way_id = value; }
		}

		private Nullable<int> _medicine_timing_id;

		public Nullable<int> medicine_timing_id
		{
			get { return _medicine_timing_id; }
			set { _medicine_timing_id = value; }
		}

        private Nullable<int> _is_continue;

        public Nullable<int> is_continue
		{
            get { return _is_continue; }
            set { _is_continue = value; }
		}

        private Nullable<int> _consultant_id;
        public Nullable<int> consultant_id
		{
            get { return _consultant_id; }
            set { _consultant_id = value; }
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

		public VisitMedicine()
		{ }

        public VisitMedicine(int visit_medicine_id, Nullable<int> visit_prescription_id, Nullable<int> medicine_id, Nullable<int> dose_p_quantity_id, Nullable<int> intake_sys_id, Nullable<DateTime> medication_date, Nullable<int> dose_count, string time_slots, Nullable<SByte> indent_given_once, Nullable<int> implication_way_id, Nullable<int> medicine_timing_id, Nullable<int> consultant_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.visit_medicine_id = visit_medicine_id;
			this.visit_prescription_id = visit_prescription_id;
			this.medicine_id = medicine_id;
			this.dose_p_quantity_id = dose_p_quantity_id;
			this.intake_sys_id = intake_sys_id;
			this.medication_date = medication_date;
			this.dose_count = dose_count;
			this.time_slots = time_slots;
			this.indent_given_once = indent_given_once;
			this.implication_way_id = implication_way_id;
			this.medicine_timing_id = medicine_timing_id;
            this.consultant_id = consultant_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "visit_medicine_id = " + visit_medicine_id.ToString() + ",visit_prescription_id = " + visit_prescription_id.ToString() + ",medicine_id = " + medicine_id.ToString() + ",dose_p_quantity_id = " + dose_p_quantity_id.ToString() + ",intake_sys_id = " + intake_sys_id.ToString() + ",medication_date = " + medication_date.ToString() + ",dose_count = " + dose_count.ToString() + ",time_slots = " + time_slots + ",indent_given_once = " + indent_given_once.ToString() + ",implication_way_id = " + implication_way_id.ToString() + ",medicine_timing_id = " + medicine_timing_id.ToString() + ",consultant_id = " + consultant_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class visit_medicine_idComparer : System.Collections.Generic.IComparer<VisitMedicine>
		{
			public SorterMode SorterMode;
			public visit_medicine_idComparer()
			{ }
			public visit_medicine_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_medicine> Membres
			int System.Collections.Generic.IComparer<VisitMedicine>.Compare(VisitMedicine x, VisitMedicine y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.visit_medicine_id.CompareTo(x.visit_medicine_id);
				}
				else
				{
					return x.visit_medicine_id.CompareTo(y.visit_medicine_id);
				}
			}
			#endregion
		}
		public class time_slotsComparer : System.Collections.Generic.IComparer<VisitMedicine>
		{
			public SorterMode SorterMode;
			public time_slotsComparer()
			{ }
			public time_slotsComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_medicine> Membres
			int System.Collections.Generic.IComparer<VisitMedicine>.Compare(VisitMedicine x, VisitMedicine y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.time_slots.CompareTo(x.time_slots);
				}
				else
				{
					return x.time_slots.CompareTo(y.time_slots);
				}
			}
			#endregion
		}
	}
}
