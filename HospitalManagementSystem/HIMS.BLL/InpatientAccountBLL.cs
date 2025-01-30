using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class InpatientAccountBLL
    {
        private InpatientAccountDAL _inpatientAccountDAL;

        public InpatientAccountDAL inpatientAccountDAL
		{
			get { return _inpatientAccountDAL; }
			set { _inpatientAccountDAL = value; }
		}

        public InpatientAccountBLL()
		{
            inpatientAccountDAL = new InpatientAccountDAL();
		}
    }
}
