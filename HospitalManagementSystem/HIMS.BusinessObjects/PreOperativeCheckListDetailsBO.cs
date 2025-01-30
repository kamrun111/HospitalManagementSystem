﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class PreOperativeCheckListDetailsBO
    {
        private int  _pre_operative_checklist_details_id;
	    public int pre_operative_checklist_details_id
	    {
		    get { return _pre_operative_checklist_details_id; }
		    set { _pre_operative_checklist_details_id = value; }
	    }
	    private Nullable<int>  _pre_operative_checklist_id;
	    public Nullable<int> pre_operative_checklist_id
	    {
		    get { return _pre_operative_checklist_id; }
		    set { _pre_operative_checklist_id = value; }
	    }
	    private Nullable<int>  _item_id;
	    public Nullable<int> item_id
	    {
		    get { return _item_id; }
		    set { _item_id = value; }
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
        public PreOperativeCheckListDetailsBO()
	    { }
    }
}
