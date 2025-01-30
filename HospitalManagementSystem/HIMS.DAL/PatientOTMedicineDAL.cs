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
    public class PatientOTMedicineDAL
    {
        public PatientOTMedicineDAL()
        {
        }

        public int PatientOTMedicineInsert(PatientOTMedicineBO patientOTMedicineBO, List<PatientOTMedicineDetailsBO> listPatientOTMedicineDetailsBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int PatientOTMedicineID = 0;

            try
            {
                PatientOTMedicineID = PatientOTMedicineAdd(trans, patientOTMedicineBO);
                PatientOTMedicineDetailsAdd(trans, PatientOTMedicineID, listPatientOTMedicineDetailsBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                PatientOTMedicineID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return PatientOTMedicineID;
        }
        public int PatientOTMedicineAdd(SqlTransaction trans, PatientOTMedicineBO patientOTMedicineBO)
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@patient_ot_medicine_id", patientOTMedicineBO.patient_ot_medicine_id);
                arParams[1] = new SqlParameter("@requisition_no", patientOTMedicineBO.requisition_no);
                arParams[2] = new SqlParameter("@admission_id", patientOTMedicineBO.admission_id);
                arParams[3] = new SqlParameter("@record_created_by", patientOTMedicineBO.record_created_by);
                arParams[0].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "PatientOTMedicineAdd", arParams);
                result = Convert.ToInt32(arParams[0].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void PatientOTMedicineDetailsAdd(SqlTransaction trans, int PatientOTMedicineID, List<PatientOTMedicineDetailsBO> listPatientOTMedicineDetailsBO)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                foreach (PatientOTMedicineDetailsBO element in listPatientOTMedicineDetailsBO)
                {
                    arParams[0] = new SqlParameter("@product_id", element.product_id);
                    arParams[1] = new SqlParameter("@order_qty", element.order_qty);
                    arParams[2] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[3] = new SqlParameter("@patient_ot_medicine_id", PatientOTMedicineID);


                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "PatientOTMedicineDetailsAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
