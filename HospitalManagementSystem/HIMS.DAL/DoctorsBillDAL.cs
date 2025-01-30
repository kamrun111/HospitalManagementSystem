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
        public DataSet getdoctors()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getdoctors");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet get_alldoctors()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "get_alldoctors");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet getdoctodsbill(DateTime From, DateTime To, int reffered_doctor_id)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[3];
                arParams[0] = new SqlParameter("@From", From);
                arParams[1] = new SqlParameter("@To", To);
                arParams[2] = new SqlParameter("@reffered_doctors_id", reffered_doctor_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getdoctodsbill", arParams);
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
        public DataSet GetDoctorBillForPatient(int AdmissionID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDoctorBillForPatient", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetDoctorBillForPatient_ICU(int AdmissionID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDoctorBillForPatient_ICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetDiscountinfo(int AdmissionID)//sami 27 Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", AdmissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDiscountinfo", arParams);
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
        public int DoctorBillUpdate(DoctorsBillBO odoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@reffered_doctors_id", odoctorsBillBO.reffered_doctors_id);
                arParams[1] = new SqlParameter("@doctorbill_type_id", odoctorsBillBO.doctorbill_type_id);
                arParams[2] = new SqlParameter("@qty", odoctorsBillBO.qty);
                arParams[3] = new SqlParameter("@amount", odoctorsBillBO.amount);
                arParams[4] = new SqlParameter("@record_modified_by ", odoctorsBillBO.record_modified_by);
                arParams[5] = new SqlParameter("@doctors_bill_id ", odoctorsBillBO.doctors_bill_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DoctorBillUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DoctorBillUpdate_ICU(DoctorsBillBO odoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@reffered_doctors_id", odoctorsBillBO.reffered_doctors_id);
                arParams[1] = new SqlParameter("@doctorbill_type_id", odoctorsBillBO.doctorbill_type_id);
                arParams[2] = new SqlParameter("@qty", odoctorsBillBO.qty);
                arParams[3] = new SqlParameter("@amount", odoctorsBillBO.amount);
                arParams[4] = new SqlParameter("@record_modified_by ", odoctorsBillBO.record_modified_by);
                arParams[5] = new SqlParameter("@doctors_bill_id ", odoctorsBillBO.doctors_bill_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DoctorBillUpdate_ICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DoctorBillDelete(DoctorsBillBO odoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@reffered_doctors_id", odoctorsBillBO.reffered_doctors_id);
                arParams[1] = new SqlParameter("@doctorbill_type_id", odoctorsBillBO.doctorbill_type_id);
                arParams[2] = new SqlParameter("@doctors_bill_id ", odoctorsBillBO.doctors_bill_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DoctorBillDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DoctorBillDelete_ICU(DoctorsBillBO odoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@reffered_doctors_id", odoctorsBillBO.reffered_doctors_id);
                arParams[1] = new SqlParameter("@doctorbill_type_id", odoctorsBillBO.doctorbill_type_id);
                arParams[2] = new SqlParameter("@doctors_bill_id ", odoctorsBillBO.doctors_bill_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DoctorBillDelete_ICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int PatientDiscount(List<InvestigationOrder> listInvestigationOrder, List<PatientOtherItem> listPatientOtherItem, List<DoctorsBillBO> listDoctorsBillBO, AdmissionBO admissionBO, InpatientAccount inpatientAccount)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int result = 0;

            try
            {
                result = investigationOrderAdd(trans, listInvestigationOrder);
                PatientOtherItemUpdate(trans, listPatientOtherItem);
                doctorDiscountUpdate(trans, listDoctorsBillBO);
                discountClear(trans, admissionBO);
                inpatient_accountUpdate(trans, inpatientAccount);
                inpatient_roomrentUpdate(trans, inpatientAccount);

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
        public void inpatient_accountUpdate(SqlTransaction trans, InpatientAccount inpatientAccount)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", inpatientAccount.admission_id);
                arParams[1] = new SqlParameter("@Pathology", inpatientAccount.Pathology);
                arParams[2] = new SqlParameter("@X_Ray", inpatientAccount.X_Ray);
                arParams[3] = new SqlParameter("@USG", inpatientAccount.USG);
                arParams[4] = new SqlParameter("@ECG", inpatientAccount.ECG);
                arParams[5] = new SqlParameter("@other_fee", inpatientAccount.other_fee);
                arParams[6] = new SqlParameter("@doctors_fee ", inpatientAccount.doctors_fee);
                arParams[7] = new SqlParameter("@is_done_by_account", inpatientAccount.is_done_by_account);
                arParams[8] = new SqlParameter("@record_created_by", inpatientAccount.record_created_by);
                arParams[9] = new SqlParameter("@ECO", inpatientAccount.ECO);

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "inpatient_accountUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void inpatient_roomrentUpdate(SqlTransaction trans, InpatientAccount inpatientAccount)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", inpatientAccount.admission_id);
                arParams[1] = new SqlParameter("@room_rent", inpatientAccount.room_rent);
                arParams[2] = new SqlParameter("@cabin_service_charge", inpatientAccount.cabin_service_charge);
               
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "inpatient_roomrentUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int investigationOrderAdd(SqlTransaction trans, List<InvestigationOrder> listInvestigationOrder)
        {

            SqlParameter[] arParams = new SqlParameter[5];
            int result = 0;
            try
            {
                foreach (InvestigationOrder element in listInvestigationOrder)
                {
                    arParams[0] = new SqlParameter("@discount", element.discount);
                    arParams[1] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[2] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[3] = new SqlParameter("@record_created_date", element.record_created_date);
                    arParams[4] = new SqlParameter("@test_department_id", element.test_department_id);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "investigationOrderAdd", arParams);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        private void PatientOtherItemUpdate(SqlTransaction trans, List<PatientOtherItem> listPatientOtherItem)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                foreach (PatientOtherItem element in listPatientOtherItem)
                {
                    arParams[0] = new SqlParameter("@discount", element.discount);
                    arParams[1] = new SqlParameter("@patient_other_item_id", element.patient_other_item_id);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "PatientOtherItemUpdate", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void doctorDiscountUpdate(SqlTransaction trans, List<DoctorsBillBO> listDoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                foreach (DoctorsBillBO element in listDoctorsBillBO)
                {
                    arParams[0] = new SqlParameter("@discount", element.discount);
                    arParams[1] = new SqlParameter("@doctors_bill_id", element.doctors_bill_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctorDiscountUpdate", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void discountClear(SqlTransaction trans, AdmissionBO admissionBO)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@is_biscount_clear", admissionBO.is_biscount_clear);
                arParams[1] = new SqlParameter("@admission_id ", admissionBO.admission_id);
                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "discountClear", arParams);
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
        public int doctorsbillADD(List<DoctorsBillBO> doctorsBillList) //sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[7];
            int result = 0;
            try
            {
                foreach (DoctorsBillBO element in doctorsBillList)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@reffered_doctors_id", element.reffered_doctors_id);
                    arParams[2] = new SqlParameter("@doctorbill_type_id ", element.doctorbill_type_id);
                    arParams[3] = new SqlParameter("@qty", element.qty);
                    arParams[4] = new SqlParameter("@amount", element.amount);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[6] = new SqlParameter("@doctor_bill_id", element.doctors_bill_id);
                    arParams[6].Direction = ParameterDirection.Output;

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctors_billADD", arParams);
                    result = Convert.ToInt32(arParams[6].Value.ToString());

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

        public int doctorsbillADD_ICU(List<DoctorsBillBO> doctorsBillList) //sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[7];
            int result = 0;
            try
            {
                foreach (DoctorsBillBO element in doctorsBillList)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@reffered_doctors_id", element.reffered_doctors_id);
                    arParams[2] = new SqlParameter("@doctorbill_type_id ", element.doctorbill_type_id);
                    arParams[3] = new SqlParameter("@qty", element.qty);
                    arParams[4] = new SqlParameter("@amount", element.amount);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[6] = new SqlParameter("@doctor_bill_id", element.doctors_bill_id);
                    arParams[6].Direction = ParameterDirection.Output;

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "doctors_billADD_ICU", arParams);
                    result = Convert.ToInt32(arParams[6].Value.ToString());

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
