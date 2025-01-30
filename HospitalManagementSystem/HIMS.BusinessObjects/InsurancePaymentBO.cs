using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class InsurancePaymentBO
    {
        private int  _insurance_payment_id;
	    public int insurance_payment_id
	    {
		    get { return _insurance_payment_id; }
		    set { _insurance_payment_id = value; }
	    }
	    private int  _admission_id;
	    public int admission_id
	    {
		    get { return _admission_id; }
		    set { _admission_id = value; }
	    }
	    private int  _insurance_company_id;
	    public int insurance_company_id
	    {
		    get { return _insurance_company_id; }
		    set { _insurance_company_id = value; }
	    }
	    private Nullable<decimal>  _amount;
	    public Nullable<decimal> amount
	    {
		    get { return _amount; }
		    set { _amount = value; }
	    }
	    private Nullable<DateTime>  _payment_date;
	    public Nullable<DateTime> payment_date
	    {
		    get { return _payment_date; }
		    set { _payment_date = value; }
	    }
	    private string  _payment_type;
	    public string payment_type
	    {
		    get { return _payment_type; }
		    set { _payment_type = value; }
	    }
	    private Nullable<int>  _status;
	    public Nullable<int> status
	    {
		    get { return _status; }
		    set { _status = value; }
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
        public InsurancePaymentBO()
	    { }
    }
}
