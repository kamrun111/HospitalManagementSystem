using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Medicine
	{
		private int _medicine_id;

		public int medicine_id
		{
			get { return _medicine_id; }
			set { _medicine_id = value; }
		}

		private int _medicine_type_id;

		public int medicine_type_id
		{
			get { return _medicine_type_id; }
			set { _medicine_type_id = value; }
		}

        private string _medicine;

        public string medicine
        {
            get { return _medicine; }
            set { _medicine = value; }
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

		public Medicine()
		{ }

        public Medicine(int medicine_id, int medicine_type_id, string medicine, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.medicine_id = medicine_id;
            this.medicine_type_id = medicine_type_id;
			this.medicine = medicine;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "medicine_id = " + medicine_id.ToString() + ",medicine_type_id = " + medicine_type_id.ToString() + ",medicine = " + medicine + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class medicine_idComparer : System.Collections.Generic.IComparer<Medicine>
		{
			public SorterMode SorterMode;
			public medicine_idComparer()
			{ }
			public medicine_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Medicine> Membres
			int System.Collections.Generic.IComparer<Medicine>.Compare(Medicine x, Medicine y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.medicine_id.CompareTo(x.medicine_id);
				}
				else
				{
					return x.medicine_id.CompareTo(y.medicine_id);
				}
			}
			#endregion
		}
		public class medicineComparer : System.Collections.Generic.IComparer<Medicine>
		{
			public SorterMode SorterMode;
			public medicineComparer()
			{ }
			public medicineComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Medicine> Membres
			int System.Collections.Generic.IComparer<Medicine>.Compare(Medicine x, Medicine y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.medicine.CompareTo(x.medicine);
				}
				else
				{
                    return x.medicine.CompareTo(y.medicine);
				}
			}
			#endregion
		}
	}
}
