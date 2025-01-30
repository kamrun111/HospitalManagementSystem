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
	public class ExpenditureDAL
	{
        public ExpenditureDAL()
		{
		}
        public int expenditureadd(List<Expenditure> ExpenditureList) //sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[6];
            int result = 0;
            try
            {
                foreach (Expenditure element in ExpenditureList)
                {
                    arParams[0] = new SqlParameter("@expencess_id", element.expencess_id);
                    arParams[1] = new SqlParameter("@amount", element.amount);
                    arParams[2] = new SqlParameter("@remarks", element.remarks);
                    arParams[3] = new SqlParameter("@recordate", element.recordate);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[5] = new SqlParameter("@expenditure_order_id", element.expenditure_order_id);

                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "expenditure_add", arParams);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
		
	}
}
