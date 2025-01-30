using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class BankBLL
    {
        private BankDAL _bankDAL;
        public BankDAL bankDAL
        {
            get { return _bankDAL; }
            set { _bankDAL = value; }
        }
        public BankBLL()
        {
            bankDAL = new BankDAL();
        }
        public int BankAdd(Bank bank)
        {
            try
            {
                return bankDAL.BankAdd(bank);
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
                return bankDAL.BankLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int BankUpdate(Bank bank)
        {
            try
            {
                return bankDAL.BankUpdate(bank);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
