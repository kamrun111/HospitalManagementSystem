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
     
	}
}
