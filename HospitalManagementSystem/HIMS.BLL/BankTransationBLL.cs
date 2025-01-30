using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
   public class BankTransationBLL
    {
       		private BankTransationDAL _bankTransationDAL;

		public BankTransationDAL bankTransationDAL
		{
			get { return _bankTransationDAL; }
			set { _bankTransationDAL = value; }
		}

        public BankTransationBLL()
		{
            bankTransationDAL = new BankTransationDAL();
		}
        public int BankTransationDetails(ChequePayment chequePayment, BankTransation bankTransation, Bank Bank)
        {
            try
            {
                return bankTransationDAL.BankTransationDetails(chequePayment, bankTransation, Bank);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
