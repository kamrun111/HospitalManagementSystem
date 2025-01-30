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
    public class OPDpatientMedicineIndentDAL
    {
        public OPDpatientMedicineIndentDAL()
		{
		}


        public DataSet getopdinfo(int opdid)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@opdID", opdid);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getopdinfo", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet getallcharge(int pkid)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PKID", pkid);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getallcharge", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet getmedicinedelivery(int pkid)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PKID", pkid);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getmedicinedelivery", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet getopdmedicinedelivery(int pkid)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PKID", pkid);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getopdmedicinedelivery", arParams);
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
