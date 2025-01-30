using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class DialysisMedicineIssueDetailsBO
    {
        private int  _dialysis_medicine_issue_details_id;
	    public int dialysis_medicine_issue_details_id
	    {
		    get { return _dialysis_medicine_issue_details_id; }
		    set { _dialysis_medicine_issue_details_id = value; }
	    }
        private Nullable<int> _dialysis_medicine_issue_id;
        public Nullable<int> dialysis_medicine_issue_id
	    {
            get { return _dialysis_medicine_issue_id; }
            set { _dialysis_medicine_issue_id = value; }
	    }
        private Nullable<int> _medicine_id;
        public Nullable<int> medicine_id
	    {
            get { return _medicine_id; }
            set { _medicine_id = value; }
	    }
        private Nullable<decimal> _order_qty;
        public Nullable<decimal> order_qty
        {
            get { return _order_qty; }
            set { _order_qty = value; }
        }
        private Nullable<decimal> _issue_qty;
        public Nullable<decimal> issue_qty
        {
            get { return _issue_qty; }
            set { _issue_qty = value; }
        }
        private Nullable<decimal> _balance_qty;
        public Nullable<decimal> balance_qty
        {
            get { return _balance_qty; }
            set { _balance_qty = value; }
        }
        private string _status;
	    public string status
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
        public DialysisMedicineIssueDetailsBO()
	    { }
    }
}
