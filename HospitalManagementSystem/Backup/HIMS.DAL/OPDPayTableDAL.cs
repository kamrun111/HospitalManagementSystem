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
	public class OPDPayTableDAL
	{
        public OPDPayTableDAL()
		{
		}
        public int AddOPDPayTable(OPDPayTable oPDPayTable)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@RegistrationID", oPDPayTable.RegistrationID);
                arParams[1] = new SqlParameter("@Amount", oPDPayTable.Amount);
                arParams[2] = new SqlParameter("@PaymentTypeID", oPDPayTable.PaymentTypeID);
                arParams[3] = new SqlParameter("@Time", oPDPayTable.Time);
                arParams[4] = new SqlParameter("@RecordeCreatedBy", oPDPayTable.RecordeCreatedBy);
             
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOPDPayTable", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
	}
}
