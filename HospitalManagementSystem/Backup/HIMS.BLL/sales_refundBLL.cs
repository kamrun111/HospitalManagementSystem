using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class sales_refundBLL
    {
        private sales_refundDAL _salesrefundDAL;

        public sales_refundDAL salesrefundDAL
		{
            get { return _salesrefundDAL; }
            set { _salesrefundDAL = value; }
		}

        public sales_refundBLL()
		{
           salesrefundDAL = new sales_refundDAL();
		}

        public DataSet SalesrefundOrder(int AdmissionID)
        {
            try
            {
                return salesrefundDAL.SalesrefundOrder(AdmissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getrefundorderID()
        {
            try
            {
                return salesrefundDAL.getrefundorderID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Salesrefundedit(int admissionID,int userID)
        {
            try
            {
                return salesrefundDAL.Salesrefundedit(admissionID,userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SalesRefundaddBynurse(List<sales_refund> lstsales_refund)//sami
        {
            try
            {
                return salesrefundDAL.SalesRefundaddBynurse(lstsales_refund);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SalerefundEditupdate(List<sales_refund> lstsales_refund)//sami
        {
            try
            {
                return salesrefundDAL.SalerefundEditupdate(lstsales_refund);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
