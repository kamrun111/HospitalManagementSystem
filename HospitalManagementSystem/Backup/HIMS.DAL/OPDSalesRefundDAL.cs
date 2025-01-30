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
    public class OPDSalesRefundDAL
    {
        public OPDSalesRefundDAL()
		{
		}

        public DataSet opdgetmedicinerefund(int pkid)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PKID", pkid);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "opdgetmedicinerefund", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet getopdsales(int SalesID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@opdSalesID", SalesID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getopdsales", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int OPDmedicinerefund(OPdSalesRefund opdSalesRefund, List<OPDSalesRefundProduct> listOPDSalesRefundProduct)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int OrderID = 0;

            try
            {
                OrderID = opdsalesrefundAdd(trans, opdSalesRefund);
                opdsalesrefundproductAdd(trans, OrderID, listOPDSalesRefundProduct);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                OrderID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return OrderID;
        }

        public int opdsalesrefundAdd(SqlTransaction trans, OPdSalesRefund opdSalesRefund)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@opd_sales_id", opdSalesRefund.opd_sales_id);
                arParams[1] = new SqlParameter("@PKID", opdSalesRefund.PKID);
                arParams[2] = new SqlParameter("@refund_by", opdSalesRefund.refund_by);
                arParams[3] = new SqlParameter("@opd_sales_refund_id", opdSalesRefund.opd_sales_refund_id);
                arParams[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "opdsalesrefundAdd", arParams);
                result = Convert.ToInt32(arParams[3].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void opdsalesrefundproductAdd(SqlTransaction trans, int OrderID, List<OPDSalesRefundProduct> listOPDSalesRefundProduct)
        {

            SqlParameter[] arParams = new SqlParameter[5];

            try
            {
                foreach (OPDSalesRefundProduct element in listOPDSalesRefundProduct)
                {
                    arParams[0] = new SqlParameter("@opd_sales_refund_id", OrderID);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@refund_qty", element.refund_qty);
                    arParams[3] = new SqlParameter("@unit_price", element.unit_price);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "opdsalesrefundproductAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
