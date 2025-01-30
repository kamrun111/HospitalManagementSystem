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
    public class DialysisMedicineDAL
    {
        public DialysisMedicineDAL()
		{
		}
        public int AddDialysisMedicine(DialysisMedicineBO dialysisMedicineBO)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@medicine_name", dialysisMedicineBO.medicine_name);
                arParams[1] = new SqlParameter("@qty", dialysisMedicineBO.qty);
                arParams[2] = new SqlParameter("@status", dialysisMedicineBO.status);
                arParams[3] = new SqlParameter("@record_created_by", dialysisMedicineBO.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DialysisMedicineAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateDialysisMedicine(DialysisMedicineBO dialysisMedicineBO)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@medicine_name", dialysisMedicineBO.medicine_name);
                arParams[1] = new SqlParameter("@qty", dialysisMedicineBO.qty);
                arParams[2] = new SqlParameter("@status", dialysisMedicineBO.status);
                arParams[3] = new SqlParameter("@dialysis_medicine_id", dialysisMedicineBO.dialysis_medicine_id);
                arParams[4] = new SqlParameter("@record_modified_by", dialysisMedicineBO.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DialysisMedicineUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
