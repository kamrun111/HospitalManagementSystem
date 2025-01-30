using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPDSalesRefundBLL
    {
        private OPDSalesRefundDAL _opdSalesRefundDAL;

        public OPDSalesRefundDAL opdSalesRefundDAL
		{
            get { return _opdSalesRefundDAL; }
            set { _opdSalesRefundDAL = value; }
		}

        public OPDSalesRefundBLL()
		{
            opdSalesRefundDAL = new OPDSalesRefundDAL();
		}

        public DataSet opdgetmedicinerefund(int pkid)
        {
            try
            {
                return opdSalesRefundDAL.opdgetmedicinerefund(pkid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet getopdsales(int SalesID)
        {
            try
            {
                return opdSalesRefundDAL.getopdsales(SalesID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OPDmedicinerefund(OPdSalesRefund opdSalesRefund, List<OPDSalesRefundProduct> listOPDSalesRefundProduct)
        {
            try
            {
                return opdSalesRefundDAL.OPDmedicinerefund(opdSalesRefund, listOPDSalesRefundProduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
