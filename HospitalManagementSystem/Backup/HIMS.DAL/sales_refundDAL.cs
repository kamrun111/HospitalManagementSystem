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
    public class sales_refundDAL
    {
        public sales_refundDAL()
        { 
        }

        public DataSet SalesrefundOrder(int AdmissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admissionID", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "SalesrefundOrder", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet getrefundorderID()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getrefundorderID");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet Salesrefundedit(int admissionID, int userID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@AdmissionID", admissionID);
                arParams[1] = new SqlParameter("@userID",userID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "Salesrefundedit", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int SalesRefundaddBynurse(List<sales_refund> lstsales_refund)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[5];
            int result = 0;

            try
            {
                foreach (sales_refund element in lstsales_refund)
                {
                    arParams[0] = new SqlParameter("@admissionID", element.admission_id);
                    arParams[1] = new SqlParameter("@productID", element.product_id);
                    arParams[2] = new SqlParameter("@refundqty", element.refund_qty);
                    arParams[3] = new SqlParameter("@refundID", element.refund_id);
                    arParams[4] = new SqlParameter("@record_created_by",element.record_created_by);
                    
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "SalesRefundaddBynurse", arParams);
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

        public int SalerefundEditupdate(List<sales_refund> lstsales_refund)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[2];
            int result = 0;

            try
            {
                foreach (sales_refund element in lstsales_refund)
                {
                    arParams[0] = new SqlParameter("@salesrefundID", element.sales_refund_id);
                    arParams[1] = new SqlParameter("@refundQty", element.refund_qty);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "SalerefundEditupdate", arParams);
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
