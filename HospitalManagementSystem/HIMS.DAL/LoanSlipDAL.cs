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
    public class LoanSlipDAL
    {
        public LoanSlipDAL()
		{
		}

        public int AddLoanSlip(LoanSlipBO loanSlipBO)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@loan_slip_amount", loanSlipBO.loan_slip_amount);
                arParams[1] = new SqlParameter("@loan_employee_id", loanSlipBO.loan_employee_id);
                arParams[2] = new SqlParameter("@loan_slip_date", loanSlipBO.loan_slip_date);
                arParams[3] = new SqlParameter("@loan_slip_remarks", loanSlipBO.loan_slip_remarks);
                arParams[4] = new SqlParameter("@record_created_by", loanSlipBO.record_created_by);
                arParams[5] = new SqlParameter("@loan_slip_id", loanSlipBO.loan_slip_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LoanSlipAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int LoanSlipPayment(LoanSlipBO loanSlipBO)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@loan_slip_amount", loanSlipBO.loan_slip_amount);
                arParams[1] = new SqlParameter("@loan_employee_id", loanSlipBO.loan_employee_id);
                arParams[2] = new SqlParameter("@record_modified_by", loanSlipBO.record_modified_by);
                arParams[3] = new SqlParameter("@loan_slip_id", loanSlipBO.loan_slip_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LoanSlipPayment", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
