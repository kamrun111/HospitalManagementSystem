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
    public class DoctorsPaymentDetailsDAL
    {
        public DoctorsPaymentDetailsDAL()
		{
		}

        public DataSet getdoctorpaymentbill(int paymentID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@paymentID", paymentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getdoctorpaymentbill", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int doctorsBillpayment(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)//sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int result = 0;
            try
            {
                result = doctorpaymentdetailsbill(trans, listDoctorsPaymentDetails);
                doctorspaymentBillmodify(trans, doctorsPayment);

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

        public void doctorspaymentBillmodify(SqlTransaction trans, DoctorsPayment doctorsPayment)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@admission_code", doctorsPayment.admission_code);
                arParams[1] = new SqlParameter("@record_modified_by", doctorsPayment.record_modified_by);
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorspaymentBillmodify", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doctorpaymentdetailsbill(SqlTransaction trans, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            int result = 0;
            try
            {
                foreach (DoctorsPaymentDetails element in listDoctorsPaymentDetails)
                {
                    arParams[0] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[1] = new SqlParameter("@doctors_payment_details_id", element.doctors_payment_details_id);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorpaymentdetailsbill", arParams);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
