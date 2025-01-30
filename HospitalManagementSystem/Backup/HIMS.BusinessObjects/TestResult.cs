using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class TestResult
	{
        private int _test_result_id;

        public int test_result_id
		{
            get { return _test_result_id; }
            set { _test_result_id = value; }
		}


        private Nullable<int> _investigation_test_id;

        public Nullable<int> investigation_test_id
		{
            get { return _investigation_test_id; }
            set { _investigation_test_id = value; }
		}

        private Nullable<int> _test_element_id;

        public Nullable<int> test_element_id
		{
            get { return _test_element_id; }
            set { _test_element_id = value; }
		}
		
		private string _result;

		public string result
		{
			get { return _result; }
			set { _result = value; }
		}

		private Nullable<DateTime> _record_created_date;

		public Nullable<DateTime> record_created_date
		{
			get { return _record_created_date; }
			set { _record_created_date = value; }
		}

		private Nullable<int> _record_created_by;

		public Nullable<int> record_created_by
		{
			get { return _record_created_by; }
			set { _record_created_by = value; }
		}

		private Nullable<DateTime> _record_modified_date;

		public Nullable<DateTime> record_modified_date
		{
			get { return _record_modified_date; }
			set { _record_modified_date = value; }
		}

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public TestResult()
		{ }

        public TestResult(int test_result_id, Nullable<int> investigation_test_id, Nullable<int> test_element_id, string result, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.test_result_id = test_result_id;
            this.investigation_test_id = investigation_test_id;
            this.test_element_id = test_element_id;
            this.result = result;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "test_result_id = " + test_result_id.ToString() + ",investigation_test_id = " + investigation_test_id.ToString() + ",test_element_id = " + test_element_id.ToString() + ",result = " + result + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class test_result_idComparer : System.Collections.Generic.IComparer<TestResult>
		{
			public SorterMode SorterMode;
			public test_result_idComparer()
			{ }
            public test_result_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<TestResult> Membres
            int System.Collections.Generic.IComparer<TestResult>.Compare(TestResult x, TestResult y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.test_result_id.CompareTo(x.test_result_id);
				}
				else
				{
                    return x.test_result_id.CompareTo(y.test_result_id);
				}
			}
			#endregion
		}
        //public class test_resultComparer : System.Collections.Generic.IComparer<TestResult>
        //{
        //    public SorterMode SorterMode;
        //    public test_resultComparer()
        //    { }
        //    public test_resultComparer(SorterMode SorterMode)
        //    {
        //        this.SorterMode = SorterMode;
        //    }
        //    #region IComparer<TestResult> Membres
        //    int System.Collections.Generic.IComparer<TestResult>.Compare(TestResult x, TestResult y)
        //    {
        //        if (SorterMode == SorterMode.Ascending)
        //        {
        //            return y.test_result.CompareTo(x.test_result);
        //        }
        //        else
        //        {
        //            return x.test_result.CompareTo(y.test_result);
        //        }
        //    }
        //    #endregion
        //}
        //public class reference_valueComparer : System.Collections.Generic.IComparer<TestResult>
        //{
        //    public SorterMode SorterMode;
        //    public reference_valueComparer()
        //    { }
        //    public reference_valueComparer(SorterMode SorterMode)
        //    {
        //        this.SorterMode = SorterMode;
        //    }
        //    #region IComparer<TestResult> Membres
        //    int System.Collections.Generic.IComparer<TestResult>.Compare(TestResult x, TestResult y)
        //    {
        //        if (SorterMode == SorterMode.Ascending)
        //        {
        //            return y.reference_value.CompareTo(x.reference_value);
        //        }
        //        else
        //        {
        //            return x.reference_value.CompareTo(y.reference_value);
        //        }
            //    }
            //#endregion
        //}
	}
}
