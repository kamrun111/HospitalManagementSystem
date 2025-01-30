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
    public class PreOperativeCheckListDAL
    {
        public PreOperativeCheckListDAL()
        {
        }

        public int PreOperativeCheckListInsert(PreOperativeCheckListBO preOperativeCheckListBO, List<PreOperativeCheckListDetailsBO> listPreOperativeCheckListDetailsBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int PreCheckListID = 0;

            try
            {
                PreCheckListID = PreOperativeCheckListAdd(trans, preOperativeCheckListBO);
                PreOperativeCheckListDetailsAdd(trans, PreCheckListID, listPreOperativeCheckListDetailsBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                PreCheckListID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return PreCheckListID;
        }
        public int PreOperativeCheckListAdd(SqlTransaction trans, PreOperativeCheckListBO preOperativeCheckListBO)
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@pre_operative_checklist_id", preOperativeCheckListBO.pre_operative_checklist_id);
                arParams[1] = new SqlParameter("@requisition_no", preOperativeCheckListBO.requisition_no);
                arParams[2] = new SqlParameter("@admission_id", preOperativeCheckListBO.admission_id);
                arParams[3] = new SqlParameter("@record_created_by", preOperativeCheckListBO.record_created_by);
                arParams[0].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "PreOperativeCheckListAdd", arParams);
                result = Convert.ToInt32(arParams[0].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void PreOperativeCheckListDetailsAdd(SqlTransaction trans, int PreCheckListID, List<PreOperativeCheckListDetailsBO> listPreOperativeCheckListDetailsBO)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                foreach (PreOperativeCheckListDetailsBO element in listPreOperativeCheckListDetailsBO)
                {
                    arParams[0] = new SqlParameter("@item_id", element.item_id);
                    arParams[1] = new SqlParameter("@status", element.status);
                    arParams[2] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[3] = new SqlParameter("@pre_operative_checklist_id", PreCheckListID);


                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "PreOperativeCheckListDetailsAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
