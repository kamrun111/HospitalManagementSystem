using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReagentPurchaseBLL
	{
        private ReagentPurchaseDAL _reagentpurchaseDAL;

        public ReagentPurchaseDAL reagentpurchaseDAL
		{
            get { return _reagentpurchaseDAL; }
            set { _reagentpurchaseDAL = value; }
		}

        public ReagentPurchaseBLL()
		{
            reagentpurchaseDAL = new ReagentPurchaseDAL();
		}
        public DataSet CategoryforReagent()
        {
            try
            {
                return reagentpurchaseDAL.CategoryforReagent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ReagentPurchaseProductInsert(ReagentPurchase reagentPurchase, List<ReagentPurchaseProduct> lstReagentPurchaseProduct)
        {
            try
            {
                return reagentpurchaseDAL.ReagentPurchaseProductInsert(reagentPurchase, lstReagentPurchaseProduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Reagentpurchasecancelation(ReagentPurchase opurchasepurchase)
        {
            try
            {
                return reagentpurchaseDAL.Reagentpurchasecancelation(opurchasepurchase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
