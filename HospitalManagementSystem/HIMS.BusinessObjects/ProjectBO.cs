using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class ProjectBO
    {
        private int  _project_id;
	public int project_id
	{
		get { return _project_id; }
		set { _project_id = value; }
	}
	private string  _project_name;
	public string project_name
	{
		get { return _project_name; }
		set { _project_name = value; }
	}
	private string  _project_term;
	public string project_term
	{
		get { return _project_term; }
		set { _project_term = value; }
	}
	private Nullable<DateTime>  _start_date;
	public Nullable<DateTime> start_date
	{
		get { return _start_date; }
		set { _start_date = value; }
	}
	private Nullable<DateTime>  _end_date;
	public Nullable<DateTime> end_date
	{
		get { return _end_date; }
		set { _end_date = value; }
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
	public ProjectBO()
	{ }
    }
}
