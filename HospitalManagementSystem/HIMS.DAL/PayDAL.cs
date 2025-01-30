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
	public class PayDal
	{
		public PayDal()
		{
		}
        public DataSet PaymentType()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PaymentType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet Paymentinfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "Paymentinfo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet PaymentinfoMember()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PaymentinfoMember");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet PatientlistforPayment(string HospitalId)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@HospitalID", HospitalId);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PatientlistforPayment", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet DuepaymentAmount(int AdmissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "DuepaymentAmount", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet PaymentTypeStatus(int PaymentTypeID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PaymentTypeID", PaymentTypeID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PaymentTypeStatus", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int paymentAdd(Pay opay)
        {
            SqlParameter[] arParams = new SqlParameter[9];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opay.admission_id);
                arParams[1] = new SqlParameter("@pay_date", opay.pay_date);
                arParams[2] = new SqlParameter("@amount", opay.amount);
                arParams[3] = new SqlParameter("@payment_type_id", opay.payment_type_id);
                arParams[4] = new SqlParameter("@status", opay.status);
                arParams[5] = new SqlParameter("@is_doctors_bill", opay.is_doctors_bill);
                arParams[6] = new SqlParameter("@record_created_by", opay.record_created_by);
                arParams[7] = new SqlParameter("@record_modified_by", opay.record_modified_by);
                arParams[8] = new SqlParameter("@pay_id", opay.pay_id);
                arParams[8].Direction=ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn,CommandType.StoredProcedure, "paymentAdd", arParams);
                result = Convert.ToInt32(arParams[8].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }


        public int paymentAddDialysis(Pay opay)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opay.admission_id);
                arParams[1] = new SqlParameter("@pay_date", opay.pay_date);
                arParams[2] = new SqlParameter("@amount", opay.amount);
                arParams[3] = new SqlParameter("@payment_type_id", opay.payment_type_id);
                arParams[4] = new SqlParameter("@status", opay.status);
                arParams[5] = new SqlParameter("@record_created_by", opay.record_created_by);
                arParams[6] = new SqlParameter("@pay_id", opay.pay_id);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "paymentAddDialysis", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }

        public int paymentAddICU(Pay opay)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opay.admission_id);
                arParams[1] = new SqlParameter("@pay_date", opay.pay_date);
                arParams[2] = new SqlParameter("@amount", opay.amount);
                arParams[3] = new SqlParameter("@payment_type_id", opay.payment_type_id);
                arParams[4] = new SqlParameter("@status", opay.status);
                arParams[5] = new SqlParameter("@record_created_by", opay.record_created_by);
                arParams[6] = new SqlParameter("@pay_id", opay.pay_id);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "paymentAddICU", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }

        public int paymentAddMedicine(Pay opay)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opay.admission_id);
                arParams[1] = new SqlParameter("@pay_date", opay.pay_date);
                arParams[2] = new SqlParameter("@amount", opay.amount);
                arParams[3] = new SqlParameter("@payment_type_id", opay.payment_type_id);
                arParams[4] = new SqlParameter("@status", opay.status);
                arParams[5] = new SqlParameter("@record_created_by", opay.record_created_by);
                arParams[6] = new SqlParameter("@pay_id", opay.pay_id);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "paymentAddMedicine", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
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
	
