using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    //[Serializable()]
    public class VehicleLog
    {
        private int _vehicle_log_id;

        public int vehicle_log_id
        {
            get { return _vehicle_log_id; }
            set { _vehicle_log_id = value; }
        }
        private string _vehicle_no;

        public string vehicle_no
        {
            get { return _vehicle_no; }
            set { _vehicle_no = value; }
        }

        private Nullable<DateTime> _starting_date;

        public Nullable<DateTime> starting_date
        {
            get { return _starting_date; }
            set { _starting_date = value; }
        }

        private Nullable<DateTime> _ending_date;

        public Nullable<DateTime> ending_date
        {
            get { return _ending_date; }
            set { _ending_date = value; }
        }

        private int _staring_km;

        public int staring_km
        {
            get { return _staring_km; }
            set { _staring_km = value; }
        }
        private int _end_km;

        public int end_km
        {
            get { return _end_km; }
            set { _end_km = value; }
        }

        private string _destination;

        public string destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
        private decimal _total_amount;

        public decimal total_amount
        {
            get { return _total_amount; }
            set { _total_amount = value; }
        }
        private int _fuel_typeId;

        public int fuel_typeId
        {
            get { return _fuel_typeId; }
            set { _fuel_typeId = value; }
        }
        private decimal _quantity;

        public decimal quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private string _remarks;

        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        private string _driver;

        public string driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
        private string _customer_name;

        public string customer_name
        {
            get { return _customer_name; }
            set { _customer_name = value; }
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



    }
}
