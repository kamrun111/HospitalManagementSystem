using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class OtherIncomeBO
    {
        private int  _other_income_id;
	    public int other_income_id
	    {
		    get { return _other_income_id; }
		    set { _other_income_id = value; }
	    }
	    private Nullable<int>  _income_head_id;
	    public Nullable<int> income_head_id
	    {
		    get { return _income_head_id; }
		    set { _income_head_id = value; }
	    }
	    private Nullable<decimal>  _amount;
	    public Nullable<decimal> amount
	    {
		    get { return _amount; }
		    set { _amount = value; }
	    }
	    private Nullable<DateTime>  _date;
	    public Nullable<DateTime> date
	    {
		    get { return _date; }
		    set { _date = value; }
	    }

        private string _remarks;
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
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
    public OtherIncomeBO()
	{ }
    }
}
