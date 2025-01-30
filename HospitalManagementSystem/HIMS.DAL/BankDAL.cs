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
    public class BankDAL
    {
        public BankDAL()
        {
        }
        public int BankAdd(Bank bank)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@bank_id ", bank.bank_id);
                arParams[1] = new SqlParameter("@full_bank_name", bank.full_bank_name);
                arParams[2] = new SqlParameter("@bank_name", bank.bank_name);
                arParams[3] = new SqlParameter("@branch_name", bank.branch_name);
                arParams[4] = new SqlParameter("@branch_address", bank.branch_address);
                arParams[5] = new SqlParameter("@contact_person", bank.contact_person);
                arParams[6] = new SqlParameter("@account_no", bank.account_no);
                arParams[7] = new SqlParameter("@contact_number", bank.contact_number);
                arParams[8] = new SqlParameter("@interest_rate", bank.interest_rate);
                arParams[9] = new SqlParameter("@record_created_by", bank.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BankAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet BankLoad()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "BankLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int BankUpdate(Bank bank)
        {

            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@bank_id ", bank.bank_id);
                arParams[1] = new SqlParameter("@full_bank_name", bank.full_bank_name);
                arParams[2] = new SqlParameter("@bank_name", bank.bank_name);
                arParams[3] = new SqlParameter("@branch_name", bank.branch_name);
                arParams[4] = new SqlParameter("@branch_address", bank.branch_address);
                arParams[5] = new SqlParameter("@contact_person", bank.contact_person);
                arParams[6] = new SqlParameter("@account_no", bank.account_no);
                arParams[7] = new SqlParameter("@contact_number", bank.contact_number);
                arParams[8] = new SqlParameter("@interest_rate", bank.interest_rate);
                arParams[9] = new SqlParameter("@record_modified_by", bank.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BankUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
