using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class TestElementBLL
	{
		private TestElementDAL _test_elementDAL;

		public TestElementDAL test_elementDAL
		{
			get { return _test_elementDAL; }
			set { _test_elementDAL = value; }
		}

		public TestElementBLL()
		{
			test_elementDAL = new TestElementDAL();
		}
        public DataSet get_TestElement(int testID)//khuku
        {
            try
            {
                return test_elementDAL.get_TestElement(testID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int test_element_add(TestElement oTestElement)
        {
            try
            {
                return test_elementDAL.test_element_add(oTestElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int test_element_update(TestElement oTestElement)
        {
            try
            {
                return test_elementDAL.test_element_update(oTestElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     
	}
}
