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
    public class OtherIncomeDAL
    {
        public OtherIncomeDAL()
        {
        }
        public int OtherIncomeAdd(OtherIncomeBO otherIncomeBO)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@income_head_id", otherIncomeBO.income_head_id);
                arParams[1] = new SqlParameter("@amount", otherIncomeBO.amount);
                arParams[2] = new SqlParameter("@date", otherIncomeBO.date);
                arParams[3] = new SqlParameter("@remarks", otherIncomeBO.remarks);
                arParams[4] = new SqlParameter("@record_created_by", otherIncomeBO.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OtherIncomeAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet IncomeHeadLoad()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "IncomeHeadLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

    }
}
