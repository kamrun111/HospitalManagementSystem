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
    public class InvestigationOrderDAL
	{
		public InvestigationOrderDAL()
		{
		}
        public int investigation_orderAdd(InvestigationOrder onvestigationOrder, string DeptID)
        {
           
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@investigation_id", onvestigationOrder.investigation_id);
                arParams[1] = new SqlParameter("@DeptID", DeptID);
                arParams[2] = new SqlParameter("@discount", onvestigationOrder.discount);
                arParams[3] = new SqlParameter("@record_created_by", onvestigationOrder.record_created_by);
                arParams[4] = new SqlParameter("@investigation_order_id", onvestigationOrder.investigation_order_id);
                arParams[5] = new SqlParameter("@test_department_id", onvestigationOrder.test_department_id);
                arParams[6] = new SqlParameter("@total_amount", onvestigationOrder.total_amount);

                arParams[4].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "investigation_orderAdd", arParams);
                result = Convert.ToInt32(arParams[4].Value.ToString());
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
        public DataSet OrdernoGet(int InvestigationID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@investigation_id", InvestigationID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OrdernoGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet OPDinvestigationdiscount(DateTime from, DateTime to, int depID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[3];
                arParams[0] = new SqlParameter("@From", from);
                arParams[1] = new SqlParameter("@To", to);
                arParams[2] = new SqlParameter("@TestDeptID", depID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OPDinvestigationdiscount", arParams);
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
