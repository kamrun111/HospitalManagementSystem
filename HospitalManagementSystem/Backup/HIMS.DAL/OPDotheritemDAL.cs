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
    public class OPDotheritemDAL
    {
        public OPDotheritemDAL()
        {
        }

        public DataSet getopdOtherservices(int pkid)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@pkid", pkid);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getopdOtherservices", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int otheritemadd(OPDotheritem otheritem)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@PKID", otheritem.PKID);
                arParams[1] = new SqlParameter("@other_item_id", otheritem.other_item_id);
                arParams[2] = new SqlParameter("@qty", otheritem.qty);
                arParams[3] = new SqlParameter("@record_created_by", otheritem.record_created_by);
                

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "otheritemadd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
