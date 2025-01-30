using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class ExpenditureOrder
    {
        private int _expenditure_order_id;

        public int expenditure_order_id	
        {
            get { return _expenditure_order_id; }
            set { _expenditure_order_id = value; }
        }

        private string _expenditure_no;

        public string expenditure_no
        {
            get { return _expenditure_no; }
            set { _expenditure_no = value; }
        } 

        private Nullable<DateTime> _recordate;

        public Nullable<DateTime> recordate
        {
            get { return _recordate; }
            set { _recordate = value; }
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

        public ExpenditureOrder()
		{ }

        public ExpenditureOrder(int expenditure_order_id, string expenditure_no, Nullable<DateTime> recordate, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.expenditure_order_id = expenditure_order_id;
            this.expenditure_no = expenditure_no;
            this.recordate = recordate;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}
        public override string ToString()
        {
            return "expenditure_order_id = " + expenditure_order_id.ToString() + ",expenditure_no= " + expenditure_no + ",recordate=" + recordate.ToString() + ", record_created_date = " + record_created_date.ToString() + ", record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

    }
}
