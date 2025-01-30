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
    public class InsurancePaymentDAL
    {
        public InsurancePaymentDAL()
        {
        }

        public int InsuranceAssign(InsurancePaymentBO insurancePaymentBO) 
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@admission_id ", insurancePaymentBO.admission_id);
                arParams[1] = new SqlParameter("@insurance_company_id", insurancePaymentBO.insurance_company_id);
                arParams[2] = new SqlParameter("@amount", insurancePaymentBO.amount);

                arParams[3] = new SqlParameter("@record_created_by", insurancePaymentBO.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "InsuranceBillAssign", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BillPayment(InsurancePaymentBO insurancePaymentBO)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@insurance_company_id", insurancePaymentBO.insurance_company_id);
                arParams[1] = new SqlParameter("@payment_type", insurancePaymentBO.payment_type);
                arParams[2] = new SqlParameter("@amount", insurancePaymentBO.amount);
                arParams[3] = new SqlParameter("@record_modified_by", insurancePaymentBO.record_modified_by);
                arParams[4] = new SqlParameter("@insurance_payment_id", insurancePaymentBO.insurance_payment_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "InsuranceBillPayment", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
