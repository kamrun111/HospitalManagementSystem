using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PatientMedicineIndent
	{
		private int _patient_medicine_indent_id;

		public int patient_medicine_indent_id
		{
			get { return _patient_medicine_indent_id; }
			set { _patient_medicine_indent_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		
		private Nullable<int> _cabin_id;

		public Nullable<int> cabin_id
		{
			get { return _cabin_id; }
			set { _cabin_id = value; }
		}

		private Nullable<int> _product_id;

		public Nullable<int> product_id
		{
			get { return _product_id; }
			set { _product_id = value; }
		}

		private Nullable<int> _quantity_ordered;

		public Nullable<int> quantity_ordered
		{
			get { return _quantity_ordered; }
			set { _quantity_ordered = value; }
		}

		private Nullable<int> _quantity_received;

		public Nullable<int> quantity_received
		{
			get { return _quantity_received; }
			set { _quantity_received = value; }
		}

		private Nullable<int> _quantity_delivered;

		public Nullable<int> quantity_delivered
		{
			get { return _quantity_delivered; }
			set { _quantity_delivered = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
		}

        private int _station; // to declare from where medecine indent order

        public int station
        {
            get { return _station; }
            set { _station = value; }
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
        private Nullable<int> _received_by;

        public Nullable<int> received_by
        {
            get { return _received_by; }
            set { _received_by = value; }
        }

		public PatientMedicineIndent()
		{ }

		public PatientMedicineIndent(int patient_medicine_indent_id,Nullable<int> admission_id,Nullable<int> patient_id,Nullable<int>received_by, Nullable<int> cabin_id,Nullable<int> product_id,Nullable<int> quantity_ordered,Nullable<int> quantity_received,Nullable<int> quantity_delivered,Nullable<int> store_id,int station,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.patient_medicine_indent_id = patient_medicine_indent_id;
			this.admission_id = admission_id;
			this.cabin_id = cabin_id;
			this.product_id = product_id;
			this.quantity_ordered = quantity_ordered;
			this.quantity_received = quantity_received;
			this.quantity_delivered = quantity_delivered;
			this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
            this.received_by = received_by;
		}

		public override string ToString()
		{
            return "patient_medicine_indent_id = " + patient_medicine_indent_id.ToString() + ",received_by="+received_by.ToString() + ", admission_id = " + admission_id.ToString() + ",cabin_id = " + cabin_id.ToString() + ",product_id = " + product_id.ToString() + ",quantity_ordered = " + quantity_ordered.ToString() + ",quantity_received = " + quantity_received.ToString() + ",quantity_delivered = " + quantity_delivered.ToString() + ",store_id = " + store_id.ToString() + ",station=" + station.ToString() + ", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class patient_medicine_indent_idComparer : System.Collections.Generic.IComparer<PatientMedicineIndent>
		{
			public SorterMode SorterMode;
			public patient_medicine_indent_idComparer()
			{ }
			public patient_medicine_indent_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<patient_medicine_indent> Membres
			int System.Collections.Generic.IComparer<PatientMedicineIndent>.Compare(PatientMedicineIndent x, PatientMedicineIndent y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.patient_medicine_indent_id.CompareTo(x.patient_medicine_indent_id);
				}
				else
				{
					return x.patient_medicine_indent_id.CompareTo(y.patient_medicine_indent_id);
				}
			}
			#endregion
		}
	}
}
