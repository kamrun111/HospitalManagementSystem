using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPDSalesBLL
    {
        private OPDSalesDAL _opdSalesDAL;

        public OPDSalesDAL opdSalesDAL
		{
            get { return _opdSalesDAL; }
            set { _opdSalesDAL = value; }
		}

        public OPDSalesBLL()
		{
            opdSalesDAL = new OPDSalesDAL();
		}


    }
}
