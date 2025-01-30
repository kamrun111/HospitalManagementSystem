using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class OtherItemReceiveDetails
    {
        private int _sales_product_id;

       public int other_item_receive_details_id
        {
            get { return _sales_product_id; }
            set { _sales_product_id = value; }
        }

       private Nullable<int> _other_item_receive_id;

        public Nullable<int> other_item_receive_id
        {
            get { return _other_item_receive_id; }
            set { _other_item_receive_id = value; }
        }

        private Nullable<int> _other_item_id;

        public Nullable<int> other_item_id
        {
            get { return _other_item_id; }
            set { _other_item_id = value; }
        }

        private Nullable<int> _qty;

        public Nullable<int> qty
        {
            get { return _qty; }
            set { _qty  = value; }
        }


        private Nullable<decimal> _unit_price;

        public Nullable<decimal> unit_price
        {
            get { return _unit_price; }
            set { _unit_price = value; }
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

        public OtherItemReceiveDetails()
        { }
    }
}
