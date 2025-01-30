using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class OTInformation
    {
        	private int  _ot_information_id;
	public int ot_information_id
	{
		get { return _ot_information_id; }
		set { _ot_information_id = value; }
	}
	private Nullable<int>  _admission_id;
	public Nullable<int> admission_id
	{
		get { return _admission_id; }
		set { _admission_id = value; }
	}
	private string  _ot_reg;
	public string ot_reg
	{
		get { return _ot_reg; }
		set { _ot_reg = value; }
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
	private string  _start_time;
    public string start_time
	{
		get { return _start_time; }
		set { _start_time = value; }
	}
    private string _finish_time;
    public string finish_time
	{
		get { return _finish_time; }
		set { _finish_time = value; }
	}
	private string  _anaesthesia_type;
	public string anaesthesia_type
	{
		get { return _anaesthesia_type; }
		set { _anaesthesia_type = value; }
	}
	private string  _blood_transfusion;
	public string blood_transfusion
	{
		get { return _blood_transfusion; }
		set { _blood_transfusion = value; }
	}
	private string  _baby_note;
	public string baby_note
	{
		get { return _baby_note; }
		set { _baby_note = value; }
	}
	private string  _others;
	public string others
	{
		get { return _others; }
		set { _others = value; }
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
    public OTInformation()
	{ }
    }
}
