using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class VisitTreatement
	{
		private int _visit_treatement_id;

		public int visit_treatement_id
		{
			get { return _visit_treatement_id; }
			set { _visit_treatement_id = value; }
		}

		private Nullable<int> _visit_prescription_id;

		public Nullable<int> visit_prescription_id
		{
			get { return _visit_prescription_id; }
			set { _visit_prescription_id = value; }
		}

		private Nullable<int> _treatement_id;

		public Nullable<int> treatement_id
		{
			get { return _treatement_id; }
			set { _treatement_id = value; }
		}

		private string _dose;

		public string dose
		{
			get { return _dose; }
			set { _dose = value; }
		}

		private Nullable<Decimal> _quantity;

		public Nullable<Decimal> quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

        private Nullable<Decimal> _qty_submitted;

        public Nullable<Decimal> qty_submitted
        {
            get { return _qty_submitted; }
            set { _qty_submitted = value; }
        }

		private string _application_procedure;

		public string application_procedure
		{
			get { return _application_procedure; }
			set { _application_procedure = value; }
		}

        private int _is_submit;

        public int is_submit
        {
            get { return _is_submit; }
            set { _is_submit = value; }
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

		public VisitTreatement()
		{ }

		public VisitTreatement(int visit_treatement_id,Nullable<int> visit_prescription_id,Nullable<int> treatement_id,string dose,Nullable<Decimal> quantity,string application_procedure,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.visit_treatement_id = visit_treatement_id;
			this.visit_prescription_id = visit_prescription_id;
			this.treatement_id = treatement_id;
			this.dose = dose;
			this.quantity = quantity;
			this.application_procedure = application_procedure;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "visit_treatement_id = " + visit_treatement_id.ToString() + ",visit_prescription_id = " + visit_prescription_id.ToString() + ",treatement_id = " + treatement_id.ToString() + ",dose = " + dose + ",quantity = " + quantity.ToString() + ",application_procedure = " + application_procedure + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class visit_treatement_idComparer : System.Collections.Generic.IComparer<VisitTreatement>
		{
			public SorterMode SorterMode;
			public visit_treatement_idComparer()
			{ }
			public visit_treatement_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_treatement> Membres
			int System.Collections.Generic.IComparer<VisitTreatement>.Compare(VisitTreatement x, VisitTreatement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.visit_treatement_id.CompareTo(x.visit_treatement_id);
				}
				else
				{
					return x.visit_treatement_id.CompareTo(y.visit_treatement_id);
				}
			}
			#endregion
		}
		public class doseComparer : System.Collections.Generic.IComparer<VisitTreatement>
		{
			public SorterMode SorterMode;
			public doseComparer()
			{ }
			public doseComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_treatement> Membres
			int System.Collections.Generic.IComparer<VisitTreatement>.Compare(VisitTreatement x, VisitTreatement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.dose.CompareTo(x.dose);
				}
				else
				{
					return x.dose.CompareTo(y.dose);
				}
			}
			#endregion
		}
		public class application_procedureComparer : System.Collections.Generic.IComparer<VisitTreatement>
		{
			public SorterMode SorterMode;
			public application_procedureComparer()
			{ }
			public application_procedureComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<visit_treatement> Membres
			int System.Collections.Generic.IComparer<VisitTreatement>.Compare(VisitTreatement x, VisitTreatement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.application_procedure.CompareTo(x.application_procedure);
				}
				else
				{
					return x.application_procedure.CompareTo(y.application_procedure);
				}
			}
			#endregion
		}
	}
}
