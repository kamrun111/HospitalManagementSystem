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
    public class TestTubeDAL
    {
        public TestTubeDAL()
        {
        }
        public DataSet TestTubeLod(int specimen_id)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@specimen_id", specimen_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "TestTubeLod", arParams);

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
