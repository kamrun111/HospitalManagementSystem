using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
    public class ChequePaymentDAL
    {
        public ChequePaymentDAL()
        {
        }
        public DataSet AccountNoGet(int bank_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@bank_id", bank_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "AccountNoGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet BankNameLoad()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "BankNameLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int ChequePaymentAdd(List<ChequePayment> lstChequePayment)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[5];
            int result = 0;
            try
            {
                foreach (ChequePayment element in lstChequePayment)
                {
                    arParams[0] = new SqlParameter("@bank_id", element.bank_id);
                    arParams[1] = new SqlParameter("@account_no", element.account_no);
                    arParams[2] = new SqlParameter("@check_no", element.check_no);
                    arParams[3] = new SqlParameter("@flag", element.flag);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);

                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "ChequePaymentAdd", arParams);

                }
                trans.Commit();

            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public int chequePaymentSave(ChequePayment chequePayment)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[8];
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@cheque_payment_id", chequePayment.cheque_payment_id);
                arParams[1] = new SqlParameter("@issue_date", chequePayment.issue_date);
                arParams[2] = new SqlParameter("@payment_date", chequePayment.payment_date);
                arParams[3] = new SqlParameter("@paid_amount", chequePayment.paid_amount);
                arParams[4] = new SqlParameter("@party_name", chequePayment.party_name);
                arParams[5] = new SqlParameter("@remarks", chequePayment.remarks);
                arParams[6] = new SqlParameter("@flag", chequePayment.flag);
                arParams[7] = new SqlParameter("@record_created_by", chequePayment.record_created_by);
          

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "chequePaymentSave", arParams);
                result = Convert.ToInt32(arParams[0].Value);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
