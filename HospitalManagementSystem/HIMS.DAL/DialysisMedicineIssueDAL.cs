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
    public class DialysisMedicineIssueDAL
    {
        public DialysisMedicineIssueDAL()
        {
        }

        public int DialysisMedicineIssueInsert(DialysisMedicineIssueBO dialysisMedicineIssueBO, List<DialysisMedicineIssueDetailsBO> listDialysisMedicineIssueDetailsBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int MedicineIssueID = 0;

            try
            {
                MedicineIssueID = DialysisMedicineAdd(trans, dialysisMedicineIssueBO);
                DialysisMedicineDetailsAdd(trans, MedicineIssueID, listDialysisMedicineIssueDetailsBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MedicineIssueID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return MedicineIssueID;
        }
        public int DialysisMedicineAdd(SqlTransaction trans, DialysisMedicineIssueBO dialysisMedicineIssueBO)
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@dialysis_medicine_issue_id", dialysisMedicineIssueBO.dialysis_medicine_issue_id);
                arParams[1] = new SqlParameter("@requisition_no", dialysisMedicineIssueBO.requisition_no);
                arParams[2] = new SqlParameter("@admission_id", dialysisMedicineIssueBO.admission_id);
                arParams[3] = new SqlParameter("@record_created_by", dialysisMedicineIssueBO.record_created_by);
                arParams[0].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "DialysisMedicineIssueAdd", arParams);
                result = Convert.ToInt32(arParams[0].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void DialysisMedicineDetailsAdd(SqlTransaction trans, int MedicineIssueID, List<DialysisMedicineIssueDetailsBO> listDialysisMedicineIssueDetailsBO)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                foreach (DialysisMedicineIssueDetailsBO element in listDialysisMedicineIssueDetailsBO)
                {
                    arParams[0] = new SqlParameter("@medicine_id", element.medicine_id);
                    arParams[1] = new SqlParameter("@order_qty", element.order_qty);
                    arParams[2] = new SqlParameter("@issue_qty", element.issue_qty);
                    arParams[3] = new SqlParameter("@balance_qty", element.balance_qty);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[5] = new SqlParameter("@dialysis_medicine_issue_id", MedicineIssueID);


                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "DialysisMedicineIssueDetailsAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
