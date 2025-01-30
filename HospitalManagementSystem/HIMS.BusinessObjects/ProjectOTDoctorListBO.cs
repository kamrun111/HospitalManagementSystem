using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class ProjectOTDoctorListBO
    {
    private int  _project_ot_doctor_list_id;
	public int project_ot_doctor_list_id
	{
		get { return _project_ot_doctor_list_id; }
		set { _project_ot_doctor_list_id = value; }
	}
	private Nullable<int>  _project_patient_id;
	public Nullable<int> project_patient_id
	{
		get { return _project_patient_id; }
		set { _project_patient_id = value; }
	}
	private Nullable<int>  _ref_doctor_id;
	public Nullable<int> ref_doctor_id
	{
		get { return _ref_doctor_id; }
		set { _ref_doctor_id = value; }
	}
	private Nullable<int>  _type_id;
	public Nullable<int> type_id
	{
		get { return _type_id; }
		set { _type_id = value; }
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
    public ProjectOTDoctorListBO()
	{ }
    }
}
