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
	public class BillDAL
	{
		public BillDAL()
		{
		}
		public List<BillBO> GetbillList()
		{
			SqlConnection conn = null;
            List<BillBO> lstbills = new List<BillBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "billGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    BillBO bill = new BillBO();
                    bill.bill_id = Convert.ToInt32(dataReader["bill_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
                        bill.admission_id = Convert.ToInt32(dataReader["admission_id"]);

                    if (dataReader["admission_fee"] != DBNull.Value)
                        bill.admission_fee = Convert.ToDecimal(dataReader["admission_fee"]);

                    if (dataReader["other_fee"] != DBNull.Value)
                        bill.other_fee = Convert.ToDecimal(dataReader["other_fee"]);

                    if (dataReader["vat"] != DBNull.Value)
                        bill.vat = Convert.ToDecimal(dataReader["vat"]);

                    if (dataReader["doctors_fee"] != DBNull.Value)
                        bill.doctors_fee = Convert.ToDecimal(dataReader["doctors_fee"]);

                    if (dataReader["bill_generate_date"] != DBNull.Value)
                        bill.bill_generate_date = Convert.ToDateTime(dataReader["bill_generate_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
                        bill.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
                        bill.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
                        bill.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
                        bill.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
                    lstbills.Add(bill);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
            return lstbills;
		}

        public DataSet InvestigationBill(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationBill", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet advance(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "advance", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet InvestigationBill1(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationBill1", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet BillAmount(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "BillAmount", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public void BillAdd(SqlTransaction trans, BillBO obill)
        {
            SqlParameter[] arParams = new SqlParameter[17];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", obill.admission_id);
                arParams[1] = new SqlParameter("@admission_fee", obill.admission_fee);
                arParams[2] = new SqlParameter("@investigation_fee", obill.investigation_fee);
                arParams[3] = new SqlParameter("@treatment_fee", obill.treatment_fee);
                arParams[4] = new SqlParameter("@ot_fee", obill.ot_fee);
                arParams[5] = new SqlParameter("@other_fee", obill.other_fee);
                arParams[6] = new SqlParameter("@medicine_fee", obill.medicine_fee);
                arParams[7] = new SqlParameter("@room_rent", obill.room_rent);
                arParams[8] = new SqlParameter("@post_operative_fee", obill.post_operative_fee);
                arParams[9] = new SqlParameter("@vat", obill.vat);
                arParams[10] = new SqlParameter("@doctors_fee", obill.doctors_fee);
                arParams[11] = new SqlParameter("@discount", obill.discount);
                arParams[12] = new SqlParameter("@remarks", obill.remarks);
                arParams[13] = new SqlParameter("@paid_amount", Convert.ToInt32(obill.paid_amount));
                arParams[14] = new SqlParameter("@loan", obill.loan);
                arParams[15] = new SqlParameter("@record_created_by", obill.record_created_by);
                arParams[16] = new SqlParameter("@record_modified_by", obill.record_modified_by);

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "BillAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BillInsert(BillBO billBO, AdmissionBO admissionBO, List<DoctorsBillBO> lstDoctorsBillBO, Pay opay)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int payID = 0;
            try
            {
                BillAdd(trans, billBO);
                admissionUpdateforBill(trans, admissionBO);
                DoctorsBillAdd(trans, lstDoctorsBillBO);
                payID = paymentAdd(trans, opay);

                trans.Commit();
            }
            catch(Exception ex)
            {
                trans.Rollback();
                payID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return payID;
        }
        public void BillUpdate(BillBO billBO, AdmissionBO admissionBO, List<DoctorsBillBO> lstDoctorsBillBO, Pay opay)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                BillUpdates(trans, billBO);
                admissionUpdateforBill(trans, admissionBO);
                DoctorsBillUpdates(trans, lstDoctorsBillBO);
                paymentUpdates(trans, opay);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void admissionUpdateforBill(SqlTransaction trans, AdmissionBO oadmission)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[1] = new SqlParameter("@is_bill_clear", oadmission.is_bill_clear);
                arParams[2] = new SqlParameter("@record_modified_by", oadmission.record_modified_by);

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "admissionUpdateforBill", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DoctorsBillAdd(SqlTransaction trans, List<DoctorsBillBO> lstDoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                foreach (DoctorsBillBO element in lstDoctorsBillBO)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@reffered_doctors_id", element.reffered_doctors_id);
                    arParams[2] = new SqlParameter("@amount", element.amount);
                    arParams[3] = new SqlParameter("@discount", element.discount);
                    arParams[4] = new SqlParameter("@vat", element.vat);
                    arParams[5] = new SqlParameter("@is_visit", element.is_visit);
                    arParams[6] = new SqlParameter("@record_created_by", element.record_created_by);
                    
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "DoctorsBillAdd", arParams);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int paymentAdd(SqlTransaction trans, Pay opay)
        {
            SqlParameter[] arParams = new SqlParameter[9];
            //SqlConnection conn = DbHelper.GetOpenConnection();
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
                arParams[8] = new SqlParameter("@pay_id", SqlDbType.Int, 4);
                arParams[8].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "paymentAdd", arParams);
                result = Convert.ToInt32(arParams[8].Value);
            }
            catch (Exception ex)
            {
                //result = -2;
                throw ex;
            }
            //finally
            //{
            //    DbHelper.CloseConnection(conn);
            //}
            return result;
        }
        public void BillUpdates(SqlTransaction trans, BillBO obill)
        {
            SqlParameter[] arParams = new SqlParameter[13];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", obill.admission_id);
                arParams[1] = new SqlParameter("@admission_fee", obill.admission_fee);
                arParams[2] = new SqlParameter("@investigation_fee", obill.investigation_fee);
                arParams[3] = new SqlParameter("@treatment_fee", obill.treatment_fee);
                arParams[4] = new SqlParameter("@ot_fee", obill.ot_fee);
                arParams[5] = new SqlParameter("@other_fee", obill.other_fee);
                arParams[6] = new SqlParameter("@medicine_fee", obill.medicine_fee);
                arParams[7] = new SqlParameter("@room_rent", obill.room_rent);
                arParams[8] = new SqlParameter("@vat", obill.vat);
                arParams[9] = new SqlParameter("@doctors_fee", obill.doctors_fee);
                arParams[10] = new SqlParameter("@discount", obill.discount);
                arParams[11] = new SqlParameter("@paid_amount", Convert.ToInt32(obill.paid_amount));
                //arParams[12] = new SqlParameter("@bill_generate_date", obill.bill_generate_date);
                //arParams[12] = new SqlParameter("@record_created_by", obill.record_created_by);
                arParams[12] = new SqlParameter("@record_modified_by", obill.record_modified_by);

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "BillUpdates", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DoctorsBillUpdates(SqlTransaction trans, List<DoctorsBillBO> lstDoctorsBillBO)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                foreach (DoctorsBillBO element in lstDoctorsBillBO)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@reffered_doctors_id", element.reffered_doctors_id);
                    arParams[2] = new SqlParameter("@amount", element.amount);
                    arParams[3] = new SqlParameter("@discount", element.discount);
                    arParams[4] = new SqlParameter("@vat", element.vat);
                    arParams[5] = new SqlParameter("@record_modified_by", element.record_created_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "DoctorsBillUpdates", arParams);
                }

            }
            catch
            {
            }
        }
        public void paymentUpdates(SqlTransaction trans, Pay opay)
        {
            SqlParameter[] arParams = new SqlParameter[8];
            //SqlConnection conn = DbHelper.GetOpenConnection();
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opay.admission_id);
                arParams[1] = new SqlParameter("@pay_date", opay.pay_date);
                arParams[2] = new SqlParameter("@amount", opay.amount);
                arParams[3] = new SqlParameter("@payment_type_id", opay.payment_type_id);
                arParams[4] = new SqlParameter("@status", opay.status);
                arParams[5] = new SqlParameter("@is_doctors_bill", opay.is_doctors_bill);
                arParams[6] = new SqlParameter("@record_modified_by", opay.record_modified_by);
                arParams[7] = new SqlParameter("@pay_id", opay.pay_id);

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "paymentUpdates", arParams);
            }
            catch (Exception ex)
            {
                //result = -2;
                throw ex;
            }
        }
	}
}
