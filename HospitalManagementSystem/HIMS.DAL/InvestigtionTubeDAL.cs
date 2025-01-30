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
    public class InvestigtionTubeDAL
    {
        public InvestigtionTubeDAL()
        {
        }
        public int InvestigationTubeAdd(InvestigtionTubeBO oInvestigtionTubeBO)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@investigation_id", oInvestigtionTubeBO.investigation_id);
                arParams[1] = new SqlParameter("@test_tube_id", oInvestigtionTubeBO.test_tube_id);
                arParams[2] = new SqlParameter("@price", oInvestigtionTubeBO.price);
                arParams[3] = new SqlParameter("@qty", oInvestigtionTubeBO.qty);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "InvestigationTubeAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
