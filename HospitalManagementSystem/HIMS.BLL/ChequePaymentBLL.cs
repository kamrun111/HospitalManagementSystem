using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class ChequePaymentBLL
    {
        private ChequePaymentDAL _chequePaymentDAL;

        public ChequePaymentDAL chequePaymentDAL
        {
            get { return _chequePaymentDAL; }
            set { _chequePaymentDAL = value; }
        }
        public ChequePaymentBLL()
        {
            chequePaymentDAL = new ChequePaymentDAL();
        }
        public DataSet AccountNoGet(int bank_id)
        {
            try
            {
                return chequePaymentDAL.AccountNoGet(bank_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet BankNameLoad()
        {
            try
            {
                return chequePaymentDAL.BankNameLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ChequePaymentAdd(List<ChequePayment> listChequePayment)
        {
            try
            {
                return chequePaymentDAL.ChequePaymentAdd(listChequePayment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int chequePaymentSave(ChequePayment chequePayment)
        {
            try
            {
                return chequePaymentDAL.chequePaymentSave(chequePayment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
