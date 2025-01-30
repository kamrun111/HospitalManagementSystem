using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BLL
{
    public class LoanSlipBLL
    {
        private LoanSlipDAL _loanSlipDAL;

        public LoanSlipDAL loanSlipDAL
		{
            get { return _loanSlipDAL; }
            set { _loanSlipDAL = value; }
		}

        public LoanSlipBLL()
		{
            loanSlipDAL = new LoanSlipDAL();
		}

        public int AddLoanSlip(LoanSlipBO loanSlipBO)
        {
            try
            {
                return loanSlipDAL.AddLoanSlip(loanSlipBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LoanSlipPayment(LoanSlipBO loanSlipBO)
        {
            try
            {
                return loanSlipDAL.LoanSlipPayment(loanSlipBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
