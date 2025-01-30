using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class TestResultBLL
	{
		private TestResultDAL _test_resultDAL;

		public TestResultDAL test_resultDAL
		{
			get { return _test_resultDAL; }
			set { _test_resultDAL = value; }
		}

		public TestResultBLL()
		{
			test_resultDAL = new TestResultDAL();
		}

        public void UpdateCurrentStock(List<ReagentProduct> lstReagentProduct)
        {
            try
            {
                test_resultDAL.UpdateCurrentStock(lstReagentProduct);
            }
            catch
            {
            }
        }

        public void test_result_Update(TestResult otest_result)
        {
            try
            {
                test_resultDAL.test_result_Update(otest_result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertTestResult(List<TestResult> lstTestResult, List<ReagentProduct> lstReagentProduct)
        {
            try
            {
                test_resultDAL.InsertTestResult(lstTestResult, lstReagentProduct);
            }
            catch
            {
            }
        }
	}
}
