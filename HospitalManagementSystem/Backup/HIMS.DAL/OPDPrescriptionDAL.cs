using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;
//Check it
namespace HIMS.DAL
{
	public class OPDPrescriptionDAL
	{
        public OPDPrescriptionDAL()
		{
		}
        
        public int AddOPDMedication(OPDMedication oPDMedication)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@PrescriptionID",oPDMedication.PrescriptionID);
                arParams[1] = new SqlParameter("@MedicineName",oPDMedication.MedicineName);
                arParams[2] = new SqlParameter("@DoseQuantity",oPDMedication.DoseQuantity);
                arParams[3] = new SqlParameter("@Duration",oPDMedication.Duration);
                arParams[4] = new SqlParameter("@RecordeCreatedBy",oPDMedication.RecordeCreatedBy);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOPDMedication", arParams);
            }
            catch (Exception ex)
            {
	            throw ex;
            }
        }
        public int AddOPDOTTreatmentProcedure(OPDOTTreatmentProcedure oPDOTTreatmentProcedure)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@PrescriptionID",oPDOTTreatmentProcedure.PrescriptionID);
                arParams[1] = new SqlParameter("@OTName", oPDOTTreatmentProcedure.OTName);
                arParams[2] = new SqlParameter("@OTTreatmentProcedure",oPDOTTreatmentProcedure.OTTreatmentProcedure);
                arParams[3] = new SqlParameter("@RecordeCreatedBy",oPDOTTreatmentProcedure.RecordeCreatedBy);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOPDOTTreatmentProcedure", arParams);
            }
            catch (Exception ex)
            {
	            throw ex;
            }
    }
        public int AddOPDPrescription(OPDPrescription  oPDPrescription)
{
SqlParameter[] arParams = new SqlParameter[4];
try
{
arParams[0] = new SqlParameter("@RegID",oPDPrescription.RegID);
arParams[1] = new SqlParameter("@cc",oPDPrescription.cc);
arParams[2] = new SqlParameter("@PF",oPDPrescription.PF);
arParams[3] = new SqlParameter("@RecordeCreatedBy",oPDPrescription.RecordeCreatedBy);

return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOPDPrescription", arParams);
}
catch (Exception ex)
{
	 throw ex;
}
}
        public int AddOPDAdvice(OPDAdvice  oPDAdvice)
{
SqlParameter[] arParams = new SqlParameter[3];
try
{
arParams[0] = new SqlParameter("@PrescriptionID",oPDAdvice.PrescriptionID);
arParams[1] = new SqlParameter("@Advice",oPDAdvice.Advice);
arParams[2] = new SqlParameter("@RecordeCreatedBy",oPDAdvice.RecordeCreatedBy);
return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AddOPDAdvice", arParams);
}
catch (Exception ex)
{
	 throw ex;
}
}

        public DataSet treatment_procedureGetAll()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "treatment_procedureGetAll");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


        public DataSet GetOPDPrescriptionInfo(int PrescriptionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PrescriptionID", PrescriptionID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOPDPrescriptionInfo", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int DeleteOPDAdvice(int PrescriptionID)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PrescriptionID", PrescriptionID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DeleteOPDAdvice", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteOPDMedication(int PrescriptionID)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PrescriptionID", PrescriptionID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DeleteOPDMedication", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
