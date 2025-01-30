using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class Bank
    {
        	private int  _bank_id;
	public int bank_id
	{
		get { return _bank_id; }
		set { _bank_id = value; }
	}
	private string  _full_bank_name;
	public string full_bank_name
	{
		get { return _full_bank_name; }
		set { _full_bank_name = value; }
	}
	private string  _bank_name;
	public string bank_name
	{
		get { return _bank_name; }
		set { _bank_name = value; }
	}
	private string  _branch_name;
	public string branch_name
	{
		get { return _branch_name; }
		set { _branch_name = value; }
	}
	private string  _branch_address;
	public string branch_address
	{
		get { return _branch_address; }
		set { _branch_address = value; }
	}
	private string  _contact_person;
	public string contact_person
	{
		get { return _contact_person; }
		set { _contact_person = value; }
	}
    private string _account_no;
	public string account_no
	{
        get { return _account_no; }
        set { _account_no = value; }
	}
	private string  _contact_number;
	public string contact_number
	{
		get { return _contact_number; }
		set { _contact_number = value; }
	}
	private decimal  _interest_rate;
	public decimal interest_rate
	{
		get { return _interest_rate; }
		set { _interest_rate = value; }
	}
    private decimal _balance;
    public decimal balance
    {
        get { return _balance; }
        set { _balance = value; }
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
	public Bank()
	{ }

    }
}
