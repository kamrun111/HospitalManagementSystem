using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class AdjusmentBLL
    {
        private AdjusmentDAL _adjusmentDAL;

        public AdjusmentDAL adjusmentDAL
		{
            get { return _adjusmentDAL; }
            set { _adjusmentDAL = value; }
		}

        public AdjusmentBLL()
		{
            adjusmentDAL = new AdjusmentDAL();
		}
    }
}
