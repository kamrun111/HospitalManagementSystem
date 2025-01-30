using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class ProjectPatientBO
    {
    private int  _project_patient_id;
	public int project_patient_id
	{
		get { return _project_patient_id; }
		set { _project_patient_id = value; }
	}
    private int _project_id;
    public int project_id
    {
        get { return _project_id; }
        set { _project_id = value; }
    }

    private string _project_term;
    public string project_term
    {
        get { return _project_term; }
        set { _project_term = value; }
    }

	private string  _project_patient_no;
	public string project_patient_no
	{
		get { return _project_patient_no; }
		set { _project_patient_no = value; }
	}
	private string  _patient_name;
	public string patient_name
	{
		get { return _patient_name; }
		set { _patient_name = value; }
	}
	private string  _patient_father_name;
	public string patient_father_name
	{
		get { return _patient_father_name; }
		set { _patient_father_name = value; }
	}
	private string  _patient_mother_name;
	public string patient_mother_name
	{
		get { return _patient_mother_name; }
		set { _patient_mother_name = value; }
	}
	private string  _patient_address;
	public string patient_address
	{
		get { return _patient_address; }
		set { _patient_address = value; }
	}
	private string  _contact_number;
	public string contact_number
	{
		get { return _contact_number; }
		set { _contact_number = value; }
	}
	private Nullable<DateTime>  _dob;
	public Nullable<DateTime> dob
	{
		get { return _dob; }
		set { _dob = value; }
	}
	private Nullable<int>  _gender_id;
	public Nullable<int> gender_id
	{
		get { return _gender_id; }
		set { _gender_id = value; }
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
    public ProjectPatientBO()
	{ }
    }
}
