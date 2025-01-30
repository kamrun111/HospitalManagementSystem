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
	public class OPDPatientDAL
	{
        public OPDPatientDAL()
        {
        }

        public DataSet PopulateOPDPatientInfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PopulateOPDPatientInfo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetOPDCategory()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOPDCategory");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetOPDRefDoctor(string RegID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@RegistrationID", RegID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOPDRefDoctor", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetOPDHistoryHead()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOPDHistoryHead");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int AddOPDPatientHistory(OPDHistoryTable oPDHistoryTable)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@OPDRegID", oPDHistoryTable.OPDRegID);
                arParams[1] = new SqlParameter("@HistoryTitle", oPDHistoryTable.HistoryTitle);
                arParams[2] = new SqlParameter("@HistoryResult", oPDHistoryTable.HistoryResult);
                arParams[3] = new SqlParameter("@RecordeCreatedBy", oPDHistoryTable.RecordeCreatedBy);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOPDPatientHistory", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOPDHistoryResult(string RegID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@OPDRegID", RegID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOPDHistoryResult", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int DeleteOPDHistory(string RegID)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@OPDRegID", RegID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DeleteOPDHistory", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetPaymentInvoiceNoList(string RegID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@RegistrationID", RegID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPaymentInvoiceNoList", arParams);

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
