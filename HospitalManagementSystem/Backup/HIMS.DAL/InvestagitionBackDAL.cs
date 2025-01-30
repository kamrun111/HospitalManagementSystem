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
	public class InvestagitionBackDAL
	{
        public InvestagitionBackDAL()
		{
		}
        public int investigationBackAdd(InvestigationBack oinvestagitionBack)
        {

            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@department", oinvestagitionBack.department);
                arParams[1] = new SqlParameter("@groups", oinvestagitionBack.groups);
                arParams[2] = new SqlParameter("@test_item", oinvestagitionBack.test_item);
                arParams[3] = new SqlParameter("@charge", oinvestagitionBack.charge);
                arParams[4] = new SqlParameter("@d_id", oinvestagitionBack.d_id);
                arParams[5] = new SqlParameter("@g_id", oinvestagitionBack.g_id);
                arParams[6] = new SqlParameter("@t_id", oinvestagitionBack.t_id);
                arParams[7] = new SqlParameter("@reedoc_id", oinvestagitionBack.reedoc_id);
                arParams[8] = new SqlParameter("@reffered_by", oinvestagitionBack.reffered_by);
                arParams[9] = new SqlParameter("@specimen_id", oinvestagitionBack.specimen_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigationBackAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InvestigationListPopulate()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationListPopulate");
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
