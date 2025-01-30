using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class OtherItemReceive
    {
        private int _other_item_receive_id;

        public int other_item_receive_id
		{
            get { return _other_item_receive_id; }
            set { _other_item_receive_id = value; }
		}

        private string _invoice_no;

        public string invoice_no
		{
            get { return _invoice_no; }
            set { _invoice_no = value; }
		}

        private decimal _total_amount;

        public decimal total_amount
		{
            get { return _total_amount; }
            set { _total_amount = value; }
		}

        private string _purchase_by;

        public string purchase_by
		{
            get { return _purchase_by; }
            set { _purchase_by = value; }
        }

   

        private Nullable<DateTime> _purchase_date;

        public Nullable<DateTime> purchase_date
		{
            get { return _purchase_date; }
            set { _purchase_date = value; }
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

        public OtherItemReceive()
		{ }
    }
}
