using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BusinessObjects
{
    public class TestTubeBLL
    {
        private TestTubeDAL _testTubeDAL;

        public TestTubeDAL testTubeDAL
		{
            get { return _testTubeDAL; }
            set { _testTubeDAL = value; }
		}

        public TestTubeBLL()
		{
            testTubeDAL = new TestTubeDAL();
		}
        public DataSet TestTubeLod(int specimen_id)
        {
            try
            {
                return testTubeDAL.TestTubeLod(specimen_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
