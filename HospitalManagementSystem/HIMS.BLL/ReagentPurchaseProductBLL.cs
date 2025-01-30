using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReagentPurchaseProductBLL
	{
        private ReagentPurchaseProductDAL _reagentpurchaseproductDAL;

        public ReagentPurchaseProductDAL reagentpurchaseproductDAL
		{
            get { return _reagentpurchaseproductDAL; }
            set { _reagentpurchaseproductDAL = value; }
		}

		public ReagentPurchaseProductBLL()
		{
            reagentpurchaseproductDAL = new ReagentPurchaseProductDAL();
		}
	}
}
