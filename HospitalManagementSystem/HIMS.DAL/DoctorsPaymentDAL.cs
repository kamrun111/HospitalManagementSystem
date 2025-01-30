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
    public class DoctorsPaymentDAL
    {
        public DoctorsPaymentDAL()
		{
		}
        public DataSet SearchPatient(int admissionCode)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@admissionCode", admissionCode);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "SearchPatient", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet getDoctorPaymentNo(int doctorID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@reffered_doctors_id", doctorID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getDoctorPaymentNo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet RptDoctorPaymentBalance(DateTime from, DateTime to)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@From", from);
                arParams[1] = new SqlParameter("@To", to);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "RptDoctorPaymentBalance", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int doctorspaymentAdd(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int OrderID = 0;

            try
            {
                OrderID = doctorpayment(trans, doctorsPayment);
                doctorpaymentdetailsADD(trans, OrderID, listDoctorsPaymentDetails);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                OrderID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return OrderID;
        }

        public int doctorpayment(SqlTransaction trans, DoctorsPayment doctorsPayment)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            int result = 0;
            try
            {
                //arParams[0] = new SqlParameter("@admission_code", doctorsPayment.admission_code);
                arParams[1] = new SqlParameter("@grand_total", doctorsPayment.grand_total);
                arParams[2] = new SqlParameter("@record_created_by", doctorsPayment.record_created_by);
                arParams[3] = new SqlParameter("@doctors_payment_id", doctorsPayment.doctors_payment_id);
                arParams[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorpaymentAdd", arParams);
                result = Convert.ToInt32(arParams[3].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void doctorpaymentdetailsADD(SqlTransaction trans, int OrderID, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {

            SqlParameter[] arParams = new SqlParameter[11];

            try
            {
                foreach (DoctorsPaymentDetails element in listDoctorsPaymentDetails)
                {
                    arParams[0] = new SqlParameter("@doctors_payment_id", OrderID);
                    //arParams[1] = new SqlParameter("@reffered_doctors_id", element.reffered_doctors_id);
                    arParams[2] = new SqlParameter("@visit_qty", element.@visit_qty);
                    arParams[3] = new SqlParameter("@visit_charge", element.@visit_charge);
                    arParams[4] = new SqlParameter("@reducevisit_qty", element.reducevisit_qty);
                    arParams[5] = new SqlParameter("@reducevisit_charge", element.reducevisit_charge);
                    arParams[6] = new SqlParameter("@anestheia_charge", element.anestheia_charge);
                    arParams[7] = new SqlParameter("@assistance_charge", element.assistance_charge);
                    arParams[8] = new SqlParameter("@total_amount", element.total_amount);
                    arParams[9] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[10] = new SqlParameter("@surgery_charge", element.surgery_charge);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorpaymentdetailsAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int doctorpaymentInsert(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails, List<DoctorsBillBO> listdoctorsBillBO)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int DocPaymentID = 0;

            try
            {
                DocPaymentID = AddDoctorPaymentAutoID(trans, doctorsPayment);
                doctorspayment_detailsAdd(trans, DocPaymentID, listDoctorsPaymentDetails);
                doctorbill_update(trans, listdoctorsBillBO);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                DocPaymentID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return DocPaymentID;
        }
        public int AddDoctorPaymentAutoID(SqlTransaction trans, DoctorsPayment doctorsPayment)
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@reffered_doctors_id", doctorsPayment.reffered_doctors_id);
                arParams[1] = new SqlParameter("@grand_total", doctorsPayment.grand_total);
                arParams[2] = new SqlParameter("@start_date", doctorsPayment.start_date);
                arParams[3] = new SqlParameter("@end_date", doctorsPayment.end_date);
                arParams[4] = new SqlParameter("@record_created_by", doctorsPayment.record_created_by);
                arParams[5] = new SqlParameter("@doctors_payment_id", doctorsPayment.doctors_payment_id);
                arParams[5].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AddDoctorPaymentAutoID", arParams);
                result = Convert.ToInt32(arParams[5].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void doctorspayment_detailsAdd(SqlTransaction trans, int DocPaymentID, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                foreach (DoctorsPaymentDetails element in listDoctorsPaymentDetails)
                {
                    arParams[0] = new SqlParameter("@doctors_payment_id", DocPaymentID);
                    arParams[1] = new SqlParameter("@doctors_bill_id", element.doctors_bill_id);
                    arParams[2] = new SqlParameter("@qty", element.qty);
                    arParams[3] = new SqlParameter("@total_amount", element.total_amount);
                    arParams[4] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[5] = new SqlParameter("@ot_date", element.ot_date);
                    arParams[6] = new SqlParameter("@bill_submit_date", element.bill_submit_date);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorspayment_detailsAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void doctorbill_update(SqlTransaction trans, List<DoctorsBillBO> listDoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                foreach (DoctorsBillBO element in listDoctorsBillBO)
                {
                    arParams[0] = new SqlParameter("@doctors_bill_id", element.doctors_bill_id);
                 
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorbill_update", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doctorpaymentUpdate(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)//sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int result = 0;

            try
            {

                result = doctorpaymentUpdate1(trans, listDoctorsPaymentDetails);
                doctorspaymentBillupdate(trans, doctorsPayment);

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
        public int doctorpaymentUpdate1(SqlTransaction trans, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)//khuku
        {

            SqlParameter[] arParams = new SqlParameter[10];
            int result = 0;
            try
            {
                foreach (DoctorsPaymentDetails element in listDoctorsPaymentDetails)
                {
                    arParams[0] = new SqlParameter("@visit_qty", element.@visit_qty);
                    arParams[1] = new SqlParameter("@visit_charge", element.@visit_charge);
                    arParams[2] = new SqlParameter("@reducevisit_qty", element.reducevisit_qty);
                    arParams[3] = new SqlParameter("@reducevisit_charge", element.reducevisit_charge);
                    arParams[4] = new SqlParameter("@anestheia_charge", element.anestheia_charge);
                    arParams[5] = new SqlParameter("@assistance_charge", element.assistance_charge);
                    arParams[6] = new SqlParameter("@total_amount", element.total_amount);
                    arParams[7] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[8] = new SqlParameter("@surgery_charge", element.surgery_charge);
                    arParams[9] = new SqlParameter("@doctors_payment_details_id", element.doctors_payment_details_id);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorpaymentUpdate", arParams);
            }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void doctorspaymentBillupdate(SqlTransaction trans, DoctorsPayment doctorsPayment)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                //arParams[0] = new SqlParameter("@admission_code", doctorsPayment.admission_code);
                arParams[1] = new SqlParameter("@record_modified_by", doctorsPayment.record_modified_by);
                arParams[2] = new SqlParameter("@grand_total", doctorsPayment.grand_total);
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorspaymentBillupdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doctorspaymentmodify(DoctorsPayment doctorsPayment)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                //arParams[0] = new SqlParameter("@admission_code", doctorsPayment.admission_code);
                arParams[1] = new SqlParameter("@grand_total", doctorsPayment.grand_total);
                arParams[2] = new SqlParameter("@record_modified_by", doctorsPayment.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "doctorspaymentmodify", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
