using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class TestTubeBO
    {
        private int  _test_tube_id;
	public int test_tube_id
	{
		get { return _test_tube_id; }
		set { _test_tube_id = value; }
	}
	private string  _test_tube_name;
	public string test_tube_name
	{
		get { return _test_tube_name; }
		set { _test_tube_name = value; }
	}
	private Nullable<int>  _specimen_id;
	public Nullable<int> specimen_id
	{
		get { return _specimen_id; }
		set { _specimen_id = value; }
	}
	private Nullable<int>  _test_department_id;
	public Nullable<int> test_department_id
	{
		get { return _test_department_id; }
		set { _test_department_id = value; }
	}
	private Nullable<decimal>  _price;
	public Nullable<decimal> price
	{
		get { return _price; }
		set { _price = value; }
	}
    public TestTubeBO()
	{ }
    }
}
