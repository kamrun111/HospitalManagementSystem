using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class BankTransation
    {
        	private int  _bank_transaction_id;
	public int bank_transaction_id
	{
		get { return _bank_transaction_id; }
		set { _bank_transaction_id = value; }
	}
	private string  _payment_type;
	public string payment_type
	{
		get { return _payment_type; }
		set { _payment_type = value; }
	}
	private Nullable<int>  _bank_id;
	public Nullable<int> bank_id
	{
		get { return _bank_id; }
		set { _bank_id = value; }
	}
	private string  _account_no;
	public string account_no
	{
		get { return _account_no; }
		set { _account_no = value; }
	}
	private string  _check_no;
	public string check_no
	{
		get { return _check_no; }
		set { _check_no = value; }
	}
	private string  _party_name;
	public string party_name
	{
		get { return _party_name; }
		set { _party_name = value; }
	}
    private string _remarks;
    public string remarks
    {
        get { return _remarks; }
        set { _remarks = value; }
    }
    private decimal _amount;
    public decimal amount
    {
        get { return _amount; }
        set { _amount = value; }
    }
    private Nullable<DateTime> _issue_date;
    public Nullable<DateTime> issue_date
	{
        get { return _issue_date; }
        set { _issue_date = value; }
	}
    private Nullable<DateTime> _payment_date;
    public Nullable<DateTime> payment_date
    {
        get { return _payment_date; }
        set { _payment_date = value; }
    }
    private Nullable<DateTime> _record_created_date;
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
    public BankTransation()
	{ }
    }
}
