using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class InvestigtionTubeBO
    {
        private int  _investigation_tube_id;
	    public int investigation_tube_id
	    {
		    get { return _investigation_tube_id; }
		    set { _investigation_tube_id = value; }
	    }
	    private Nullable<int>  _investigation_id;
	    public Nullable<int> investigation_id
	    {
		    get { return _investigation_id; }
		    set { _investigation_id = value; }
	    }
        private Nullable<int> _qty;
        public Nullable<int> qty
	    {
            get { return _qty; }
            set { _qty = value; }
	    }
        private Nullable<int> _test_tube_id;
        public Nullable<int> test_tube_id
        {
            get { return _test_tube_id; }
            set { _test_tube_id = value; }
        }
	    private Nullable<decimal>  _price;
	    public Nullable<decimal> price
	    {
		    get { return _price; }
		    set { _price = value; }
	    }
	    private Nullable<DateTime>  _record_created_date;
	    public Nullable<DateTime> record_created_date
	    {
		    get { return _record_created_date; }
		    set { _record_created_date = value; }
	    }
	    private Nullable<int>  _record_created_by;
	    public Nullable<int> record_created_by
	    {
		    get { return _record_created_by; }
		    set { _record_created_by = value; }
	    }
	    private Nullable<DateTime>  _record_modified_date;
	    public Nullable<DateTime> record_modified_date
	    {
		    get { return _record_modified_date; }
		    set { _record_modified_date = value; }
	    }
	    private Nullable<int>  _record_modified_by;
	    public Nullable<int> record_modified_by
	    {
		    get { return _record_modified_by; }
		    set { _record_modified_by = value; }
	    }
        public InvestigtionTubeBO()
	    { }
    }
}
