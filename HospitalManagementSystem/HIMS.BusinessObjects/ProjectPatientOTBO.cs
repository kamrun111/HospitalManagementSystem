using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class ProjectPatientOTBO
    {
    private int  _project_ot_id;
	public int project_ot_id
	{
		get { return _project_ot_id; }
		set { _project_ot_id = value; }
	}
	private string  _project_ot_no;
	public string project_ot_no
	{
		get { return _project_ot_no; }
		set { _project_ot_no = value; }
	}
	private Nullable<int>  _project_patient_id;
	public Nullable<int> project_patient_id
	{
		get { return _project_patient_id; }
		set { _project_patient_id = value; }
	}
	private string  _ot_name;
	public string ot_name
	{
		get { return _ot_name; }
		set { _ot_name = value; }
	}
	private Nullable<DateTime>  _ot_date;
	public Nullable<DateTime> ot_date
	{
		get { return _ot_date; }
		set { _ot_date = value; }
	}
	private string  _ot_start_time;
	public string ot_start_time
	{
		get { return _ot_start_time; }
		set { _ot_start_time = value; }
	}
	private string  _ot_finish_time;
	public string ot_finish_time
	{
		get { return _ot_finish_time; }
		set { _ot_finish_time = value; }
	}
	private string  _anesthia_type;
	public string anesthia_type
	{
		get { return _anesthia_type; }
		set { _anesthia_type = value; }
	}
	private string  _remarks;
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
    public ProjectPatientOTBO()
	{ }
    }
}
