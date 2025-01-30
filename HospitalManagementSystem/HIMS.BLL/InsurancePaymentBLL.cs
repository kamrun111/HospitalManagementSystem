using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BLL
{
    public class InsurancePaymentBLL
    {
        private InsurancePaymentDAL  _insurancePaymentDAL;
        public  InsurancePaymentDAL insurancePaymentDAL
        {
            get { return _insurancePaymentDAL; }
            set { _insurancePaymentDAL = value; }
        }
        public InsurancePaymentBLL()
        {
            insurancePaymentDAL = new InsurancePaymentDAL();
        }

        public int InsurancePaymentAssign(InsurancePaymentBO insurancePaymentBO)
        {
            try
            {
                return insurancePaymentDAL.InsuranceAssign(insurancePaymentBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsuranceBillPayment(InsurancePaymentBO insurancePaymentBO)
        {
            try
            {
                return insurancePaymentDAL.BillPayment(insurancePaymentBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
