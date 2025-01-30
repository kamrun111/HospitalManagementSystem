using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class ProjectGuestDoctorBO
    {
    private int  _guest_doctor_id;
	public int guest_doctor_id
	{
		get { return _guest_doctor_id; }
		set { _guest_doctor_id = value; }
	}
	private string  _guest_doctor_name;
	public string guest_doctor_name
	{
		get { return _guest_doctor_name; }
		set { _guest_doctor_name = value; }
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
    public ProjectGuestDoctorBO()
	{ }
    }
}
