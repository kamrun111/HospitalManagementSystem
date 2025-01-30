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
	public class OPDPatientRefDoctorDAL
	{
        public OPDPatientRefDoctorDAL()
		{
		}
        public int OPDPatientRefDoctorADD(OPDPatientRefDoctor oPDPatientRefDoctor)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@RegistrationID", oPDPatientRefDoctor.RegistrationID);
                arParams[1] = new SqlParameter("@RefDoctorID", oPDPatientRefDoctor.RefDoctorID);
                arParams[2] = new SqlParameter("@RecordeCreatedBy", oPDPatientRefDoctor.RecordeCreatedBy);
                
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OPDPatientRefDoctorADD", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
	}
}
