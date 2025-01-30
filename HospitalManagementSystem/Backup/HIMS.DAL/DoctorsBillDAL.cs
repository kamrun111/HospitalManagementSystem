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
    public class DoctorsBillDAL
    {
        public DoctorsBillDAL()
        { 
        }

        public DataSet DoctorsBillLoad()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "DoctorsBillLoad");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet DoctorsBillShow(int AdmissionID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "DoctorsBillShow", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int DoctorsBillAdd(DoctorsBillBO odoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", odoctorsBillBO.admission_id);
                arParams[1] = new SqlParameter("@reffered_doctors_id", odoctorsBillBO.reffered_doctors_id);
                arParams[2] = new SqlParameter("@amount", odoctorsBillBO.amount);
                arParams[3] = new SqlParameter("@discount", odoctorsBillBO.discount);
                arParams[4] = new SqlParameter("@record_created_by", odoctorsBillBO.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DoctorsBillAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DoctorsBillUpdate(List<DoctorsBillBO> doctorsBillList) //sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[3];
            int result = 0;
            try
            {
                foreach (DoctorsBillBO element in doctorsBillList)
                {
                    arParams[0] = new SqlParameter("@doctors_bill_id", element.doctors_bill_id);
                    arParams[1] = new SqlParameter("@is_paid", element.is_paid);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);
                   
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "DoctorsBillUpdate", arParams);
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
