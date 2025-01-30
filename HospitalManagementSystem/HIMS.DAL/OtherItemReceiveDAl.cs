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
    public class OtherItemReceiveDAL
    {
        public OtherItemReceiveDAL()
        {
        }
        public DataSet OtherItemReceiveLoad()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OtherItemReceiveLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int OtherItemReceiveAdd(OtherItemReceive otherItemReceive, List<OtherItemReceiveDetails> listOtherItemReceiveDetails, List<OtherItem> listOtherItem)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int ID = 0;
            try
            {
                ID = OtherItemReceiveAdd(trans, otherItemReceive);
                OtherItemReceiveDetailsAdd(trans, ID, listOtherItemReceiveDetails);
                OtherItemStockUpdate(trans, listOtherItem);

                trans.Commit();
            }
            catch (Exception Ex)
            {
                trans.Rollback();
                throw Ex;
            }
            finally
            {
                conn.Close();
            }
            return ID;
        }
        public int OtherItemReceiveAdd(SqlTransaction trans, OtherItemReceive otherItemReceive)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@total_amount", otherItemReceive.total_amount);
                arParams[1] = new SqlParameter("@purchase_date", otherItemReceive.purchase_date);
                arParams[2] = new SqlParameter("@record_created_by", otherItemReceive.record_created_by);
                arParams[3] = new SqlParameter("@other_item_receive_id", otherItemReceive.other_item_receive_id);
               
                arParams[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "OtherItemReceiveAdd", arParams);
                result = Convert.ToInt32(arParams[3].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        private void OtherItemReceiveDetailsAdd(SqlTransaction trans, int ID, List<OtherItemReceiveDetails> lstOtherItemReceiveDetails)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                foreach (OtherItemReceiveDetails element in lstOtherItemReceiveDetails)
                {
                    arParams[0] = new SqlParameter("@other_item_receive_id ", ID);
                    arParams[1] = new SqlParameter("@other_item_id", element.other_item_id);
                    arParams[2] = new SqlParameter("@qty", element.qty);
                    arParams[3] = new SqlParameter("@unit_price", element.unit_price);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "OtherItemReceiveDetailsAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void OtherItemStockUpdate(SqlTransaction trans, List<OtherItem> lstOtherItem)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                foreach (OtherItem element in lstOtherItem)
                {
                    arParams[0] = new SqlParameter("@other_item_id", element.other_item_id);
                    arParams[1] = new SqlParameter("@stock", element.stock);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "OtherItemStockUpdate", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
