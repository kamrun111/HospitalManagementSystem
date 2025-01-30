using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPDSalesRefundProductBLL
    {
        private OPDSalesRefundProductDAL _opdSalesRefundProductDAL;

        public OPDSalesRefundProductDAL opdSalesRefundProductDAL
		{
            get { return _opdSalesRefundProductDAL; }
            set { _opdSalesRefundProductDAL = value; }
		}

        public OPDSalesRefundProductBLL()
		{
            opdSalesRefundProductDAL = new OPDSalesRefundProductDAL();
		}
    }
}
