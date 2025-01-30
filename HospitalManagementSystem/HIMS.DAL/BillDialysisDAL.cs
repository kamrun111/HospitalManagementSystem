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
    public class BillDialysisDAL
    {
        public BillDialysisDAL()
        {
        }
        public int BillDialysisAdd(BillDialysisBO billDialysisBO)
        {
            SqlParameter[] arParams = new SqlParameter[8];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", billDialysisBO.admission_id);
                arParams[1] = new SqlParameter("@patient_id", billDialysisBO.patient_id);
                arParams[2] = new SqlParameter("@bill_amount", billDialysisBO.bill_amount);
                arParams[3] = new SqlParameter("@discount", billDialysisBO.discount);
                arParams[4] = new SqlParameter("@net_amount", billDialysisBO.net_amount);
                arParams[5] = new SqlParameter("@record_created_by", billDialysisBO.record_created_by);
                arParams[6] = new SqlParameter("@bill_dialysis_id", billDialysisBO.bill_dialysis_id);
                arParams[7] = new SqlParameter("@paid_amount", billDialysisBO.paid_amount);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "BillDialysisAdd", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }

        

    }
}
