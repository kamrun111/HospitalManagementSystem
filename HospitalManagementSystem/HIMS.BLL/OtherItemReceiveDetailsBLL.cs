using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtherItemReceiveDetailsBLL
    {
        private OtherItemReceiveDetailsDAL _otherItemReceiveDetailsDAL;

        public OtherItemReceiveDetailsDAL otherItemReceiveDetailsDAL
		{
            get { return _otherItemReceiveDetailsDAL; }
            set { _otherItemReceiveDetailsDAL = value; }
		}

        public OtherItemReceiveDetailsBLL()
		{
            otherItemReceiveDetailsDAL = new OtherItemReceiveDetailsDAL();
		}
    }
}
