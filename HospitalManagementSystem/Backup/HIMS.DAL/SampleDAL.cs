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
	public class SampleDAL
	{
        public SampleDAL()
		{
		}
        public int sampleAdd(Sample osample, int SpecimenID)
        {

            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@investigation_id", osample.investigation_id);
                arParams[1] = new SqlParameter("@specimenID", SpecimenID);
                arParams[2] = new SqlParameter("@record_created_by", osample.record_created_by);
                arParams[3] = new SqlParameter("@sample_id", osample.sample_id);

                arParams[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "sampleAdd", arParams);
                result = Convert.ToInt32(arParams[3].Value.ToString());
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
	}
}
