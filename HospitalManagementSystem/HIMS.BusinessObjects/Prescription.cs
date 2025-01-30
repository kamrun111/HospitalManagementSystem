using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Prescription
	{
		private int _prescription_id;

		public int prescription_id
		{
			get { return _prescription_id; }
			set { _prescription_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<int> _consultant_id;

		public Nullable<int> consultant_id
		{
			get { return _consultant_id; }
			set { _consultant_id = value; }
		}

		private Nullable<DateTime> _prescription_date;

		public Nullable<DateTime> prescription_date
		{
			get { return _prescription_date; }
			set { _prescription_date = value; }
		}

		private Nullable<Decimal> _visit_amount;

		public Nullable<Decimal> visit_amount
		{
			get { return _visit_amount; }
			set { _visit_amount = value; }
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

		public Prescription()
		{ }

		public Prescription(int prescription_id,Nullable<int> admission_id,Nullable<int> consultant_id,Nullable<DateTime> prescription_date,Nullable<Decimal> visit_amount,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.prescription_id = prescription_id;
			this.admission_id = admission_id;
			this.consultant_id = consultant_id;
			this.prescription_date = prescription_date;
			this.visit_amount = visit_amount;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "prescription_id = " + prescription_id.ToString() + ",admission_id = " + admission_id.ToString() + ",consultant_id = " + consultant_id.ToString() + ",prescription_date = " + prescription_date.ToString() + ",visit_amount = " + visit_amount.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class prescription_idComparer : System.Collections.Generic.IComparer<Prescription>
		{
			public SorterMode SorterMode;
			public prescription_idComparer()
			{ }
			public prescription_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<prescription> Membres
			int System.Collections.Generic.IComparer<Prescription>.Compare(Prescription x, Prescription y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.prescription_id.CompareTo(x.prescription_id);
				}
				else
				{
					return x.prescription_id.CompareTo(y.prescription_id);
				}
			}
			#endregion
		}
	}
}
