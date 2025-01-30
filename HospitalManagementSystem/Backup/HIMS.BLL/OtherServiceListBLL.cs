using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtherServiceListBLL
    {
        private OtherServiceListDAL _otherServiceListDAL;

        public OtherServiceListDAL otherServiceListDAL
		{
            get { return _otherServiceListDAL; }
            set { _otherServiceListDAL = value; }
		}

        public OtherServiceListBLL()
		{
            otherServiceListDAL = new OtherServiceListDAL();
		}
    }
}
