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
    public class BankTransationDAL
    {
        public BankTransationDAL()
        {
        }
        public int BankTransationDetails(ChequePayment chequePayment, BankTransation bankTransation, Bank Bank)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int ID = 0;

            try
            {
                ID = BanakTransationAdd(trans, bankTransation);
                chequePaymentSave(trans, chequePayment);
                BankBalanceUpdate(trans, Bank);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                ID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return ID;
        }
        public int BanakTransationAdd(SqlTransaction trans, BankTransation bankTransation)//sami24Oct
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[11];
            try
            {
                arParams[0] = new SqlParameter("@bank_transaction_id", bankTransation.bank_transaction_id);
                arParams[1] = new SqlParameter("@payment_type", bankTransation.payment_type);
                arParams[2] = new SqlParameter("@bank_id", bankTransation.bank_id);
                arParams[3] = new SqlParameter("@account_no", bankTransation.account_no);
                arParams[4] = new SqlParameter("@check_no", bankTransation.check_no);
                arParams[5] = new SqlParameter("@party_name", bankTransation.party_name);
                arParams[6] = new SqlParameter("@record_created_by", bankTransation.record_created_by);
                arParams[7] = new SqlParameter("@amount", bankTransation.amount);
                arParams[8] = new SqlParameter("@remarks", bankTransation.remarks);
                arParams[9] = new SqlParameter("@issue_date", bankTransation.issue_date);
                arParams[10] = new SqlParameter("@payment_date", bankTransation.payment_date);
                arParams[0].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "BanakTransationAdd", arParams);
                result = Convert.ToInt32(arParams[0].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void chequePaymentSave(SqlTransaction trans, ChequePayment chequePayment)
        {
            SqlParameter[] arParams = new SqlParameter[8];
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

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void BankBalanceUpdate(SqlTransaction trans, Bank bank)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {

                arParams[0] = new SqlParameter("@balance", bank.balance);
                arParams[1] = new SqlParameter("@bank_id", bank.bank_id);
               

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "BankBalanceUpdate", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
