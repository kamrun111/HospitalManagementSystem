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
    public class BillICUDAL
    {
        public BillICUDAL()
        {
        }

        public int BillICUAdd(BillICUBO billICUBO)
        {
            SqlParameter[] arParams = new SqlParameter[11];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", billICUBO.admission_id);
                arParams[1] = new SqlParameter("@patient_id", billICUBO.patient_id);
                arParams[2] = new SqlParameter("@bill_amount", billICUBO.bill_amount);
                arParams[3] = new SqlParameter("@discount", billICUBO.discount);
                arParams[4] = new SqlParameter("@net_amount", billICUBO.net_amount);
                arParams[5] = new SqlParameter("@record_created_by", billICUBO.record_created_by);
                arParams[6] = new SqlParameter("@bill_icu_id", billICUBO.bill_icu_id);
                arParams[7] = new SqlParameter("@paid_amount", billICUBO.paid_amount);
                arParams[8] = new SqlParameter("@cabin_charge", billICUBO.cabin_charge);
                arParams[9] = new SqlParameter("@doctor_bill", billICUBO.doctor_bill);
                arParams[10] = new SqlParameter("@other_service", billICUBO.other_service);

                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "BillICUAdd", arParams);
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
