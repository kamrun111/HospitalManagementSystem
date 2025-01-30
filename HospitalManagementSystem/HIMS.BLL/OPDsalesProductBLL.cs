using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPDsalesProductBLL
    {
        private OPDSalesProductDAL _opdSalesProductDAL;

        public OPDSalesProductDAL opdSalesProductDAL
		{
            get { return _opdSalesProductDAL; }
            set { _opdSalesProductDAL = value; }
		}

        public OPDsalesProductBLL()
		{
            opdSalesProductDAL = new OPDSalesProductDAL();
		}
    }
}
