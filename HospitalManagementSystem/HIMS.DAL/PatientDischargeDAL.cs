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
    public class PatientDischargeDAL
    {
        public PatientDischargeDAL()
		{
		}

        public DataSet dischargeMedicine(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_idM", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "dischargeMedicine", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int medicineDichageADD(List<PatientDischarge> lstPatientDischarge)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[5];
            int result = 0;

            try
            {
                foreach (PatientDischarge element in lstPatientDischarge)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@medicine_indication", element.medicine_indication);
                    arParams[3] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[4] = new SqlParameter("@record_modified_by", element.record_modified_by);


                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "medicineDichageADD", arParams);
                }

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
