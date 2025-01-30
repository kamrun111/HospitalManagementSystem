using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class DialysisMedicineBO
    {
        private int _dialysis_medicine_id;
        public int dialysis_medicine_id
	{
        get { return _dialysis_medicine_id; }
        set { _dialysis_medicine_id = value; }
	}
        private string _medicine_name;
    public string medicine_name
	{
        get { return _medicine_name; }
        set { _medicine_name = value; }
	}
    private decimal _qty;
    public decimal qty
	{
        get { return _qty; }
        set { _qty = value; }
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
    public DialysisMedicineBO()
	{ }
    }
}
