using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtherserviceBLL
    {
        private OtherserviceDAL _otherserviceDAL;

        public OtherserviceDAL otherserviceDAL
		{
            get { return _otherserviceDAL; }
            set { _otherserviceDAL = value; }
		}

        public OtherserviceBLL()
		{
            otherserviceDAL = new OtherserviceDAL();
		}
    }
}
