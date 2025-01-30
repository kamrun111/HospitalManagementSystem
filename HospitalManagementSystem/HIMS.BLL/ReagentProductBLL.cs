using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReagentProductBLL
	{
        private ReagentProductDAL _reagentProductDAL;

        public ReagentProductDAL reagentProductDAL
		{
            get { return _reagentProductDAL; }
            set { _reagentProductDAL = value; }
		}

        public ReagentProductBLL()
		{
            reagentProductDAL = new ReagentProductDAL();
		}
	}
}
