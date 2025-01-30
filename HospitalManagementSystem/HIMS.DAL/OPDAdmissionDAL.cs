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
	public class OPDAdmissionDAL
	{
        public OPDAdmissionDAL()
		{
		}
public string  OPDadmissionAdd(OPDPatient  oPDPatient,OPDAdmission  oPDAdmission)
{
    SqlParameter[] arParams = new SqlParameter[13];
    SqlConnection conn = DbHelper.GetOpenConnection();
    string  result ="";
    try
    {
        arParams[0] = new SqlParameter("@PatientName",oPDPatient.PatientName);
        arParams[1] = new SqlParameter("@GardianName",oPDPatient.GardianName);
        arParams[2] = new SqlParameter("@GardianRelationID",oPDPatient.GardianRelationID);
        arParams[3] = new SqlParameter("@GenderID",oPDPatient.GenderID);
        arParams[4] = new SqlParameter("@OcupationID",oPDPatient.OcupationID);
        arParams[5] = new SqlParameter("@Address",oPDPatient.Address);
        arParams[6] = new SqlParameter("@Phone",oPDPatient.Phone);
        arParams[7] = new SqlParameter("@Age",oPDPatient.Age);
        arParams[8] = new SqlParameter("@NationalityID",oPDPatient.NationalityID);
        arParams[9] = new SqlParameter("@ReligionID",oPDPatient.ReligionID);
        arParams[10] = new SqlParameter("@RecordeCreatedBy",oPDPatient.RecordeCreatedBy);
        //arParams[11] = new SqlParameter("@RecordeCreatedDate",oPDPatient.RecordeCreatedDate);
        arParams[11] = new SqlParameter("@PatientID",oPDAdmission.PatientID);
        arParams[12] = new SqlParameter("@RegistrationID", SqlDbType.VarChar, 10);
        arParams[12].Direction = ParameterDirection.Output;
        

        SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "OPDadmissionAdd", arParams);
        result = arParams[12].Value.ToString();
    }
    catch (Exception ex)
    {
        result = "-2";
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
