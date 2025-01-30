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
	public class OPDBillDAL
	{
        public OPDBillDAL()
		{
		}
        public DataSet OPDBillGetByRegID(string RegistrationID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@RegistrationID", RegistrationID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OPDBillGetByRegID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet OPDBillGet()
        {
            try
            {
                
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OPDBillGet");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int updateOPDBILL(OPDBill opdBill)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@MedicineBill", opdBill.MedicineBill);
                arParams[1] = new SqlParameter("@HospitalService", opdBill.HospitalService);
                arParams[2] = new SqlParameter("@BillPKID", opdBill.PKID);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "updateOPDBILL", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateOPDPatientBiLL(OPDBill opdBill)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@vat", opdBill.Vat);
                arParams[1] = new SqlParameter("@Discount", opdBill.Discount);
                arParams[2] = new SqlParameter("@RegistrationID", opdBill.RegistrationID);
                arParams[3] = new SqlParameter("@RecordeCreatedBy", opdBill.RecordeCreatedBy);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateOPDPatientBiLL", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
	}
}
