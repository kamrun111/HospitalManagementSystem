using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class PatientInventory
    {
        private int _patient_inventory_id;

        public int patient_inventory_id
        {
            get { return _patient_inventory_id; }
            set { _patient_inventory_id = value; }
        }

        private string _inventory_no;

        public string inventory_no
        {
            get { return _inventory_no; }
            set { _inventory_no = value; }
        }

        private Nullable<DateTime> _start_date;

        public Nullable<DateTime> start_date
        {
            get { return _start_date; }
            set { _start_date = value; }
        }

        private Nullable<DateTime> _end_date;

        public Nullable<DateTime> end_date
        {
            get { return _end_date; }
            set { _end_date = value; }
        }

        private Nullable<DateTime> _inventory_date;

        public Nullable<DateTime> inventory_date
        {
            get { return _inventory_date; }
            set { _inventory_date = value; }
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
        public PatientInventory()
		{ }

        public PatientInventory(int patient_inventory_id, string inventory_no, Nullable<DateTime> start_date, Nullable<DateTime> end_date, Nullable<DateTime> inventory_date, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.patient_inventory_id = patient_inventory_id;
            this.inventory_no = inventory_no;
            this.start_date = start_date;
            this.end_date = end_date;
            this.inventory_date = inventory_date;
            this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_by = record_modified_by;
            this.record_modified_date = record_modified_date;
		}
        public override string ToString()
        {
            return "patient_inventory_id = " + patient_inventory_id.ToString() + ",inventory_no = " + inventory_no + ",start_date = " + start_date.ToString() + ",end_date = " + end_date.ToString() + ",inventory_date = " + inventory_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

    }
}
