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
	public class AdmissionDAL
	{
		public AdmissionDAL()
		{
		}
		public List<AdmissionBO> GetadmissionsList()
		{
			SqlConnection conn = null;
			List<AdmissionBO> lstadmissions = new List<AdmissionBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "admissionGetAll", null, ref conn);
				while (dataReader.Read())
				{
					AdmissionBO oadmission = new AdmissionBO();
					oadmission.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["admission_code"] != DBNull.Value)
						oadmission.admission_code = Convert.ToString(dataReader["admission_code"]);

					if(dataReader["admission_date"] != DBNull.Value)
						oadmission.admission_date = Convert.ToDateTime(dataReader["admission_date"]);

					if(dataReader["patient_id"] != DBNull.Value)
						oadmission.patient_id = Convert.ToInt32(dataReader["patient_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						oadmission.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["deposit"] != DBNull.Value)
						oadmission.deposit = Convert.ToDecimal(dataReader["deposit"]);

					if(dataReader["remarks"] != DBNull.Value)
						oadmission.remarks = Convert.ToString(dataReader["remarks"]);

					if(dataReader["is_bill_clear"] != DBNull.Value)
						oadmission.is_bill_clear = Convert.ToSByte(dataReader["is_bill_clear"]);

					if(dataReader["is_discharged"] != DBNull.Value)
						oadmission.is_discharged = Convert.ToSByte(dataReader["is_discharged"]);

					if(dataReader["is_cc_written"] != DBNull.Value)
						oadmission.is_cc_written = Convert.ToSByte(dataReader["is_cc_written"]);

					if(dataReader["is_history_written"] != DBNull.Value)
						oadmission.is_history_written = Convert.ToSByte(dataReader["is_history_written"]);

					if(dataReader["is_first_reqular_checkup_done"] != DBNull.Value)
						oadmission.is_first_reqular_checkup_done = Convert.ToSByte(dataReader["is_first_reqular_checkup_done"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oadmission.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oadmission.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oadmission.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oadmission.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstadmissions.Add(oadmission);
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
			return lstadmissions;
		}
		
        public DataSet Getadmissions()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "admissionGetAll");
            
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet getopdpatient()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getopdpatient");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetAdmissionPopulationInfo()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetAdmissionPopulationInfo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet Isdiacharge(int pCode)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@PatientCode", pCode);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "Isdiacharge", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public AdmissionBO Getadmission(int admission_id)
		{
			SqlConnection conn = null;
			AdmissionBO oadmission = new AdmissionBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@admission_id", admission_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "admissionGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oadmission.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["admission_code"] != DBNull.Value)
						oadmission.admission_code = Convert.ToString(dataReader["admission_code"]);

					if(dataReader["admission_date"] != DBNull.Value)
						oadmission.admission_date = Convert.ToDateTime(dataReader["admission_date"]);

                    if (dataReader["case_no"] != DBNull.Value)
                        oadmission.case_no = Convert.ToInt32(dataReader["case_no"]);

					if(dataReader["patient_id"] != DBNull.Value)
						oadmission.patient_id = Convert.ToInt32(dataReader["patient_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						oadmission.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["deposit"] != DBNull.Value)
						oadmission.deposit = Convert.ToDecimal(dataReader["deposit"]);

					if(dataReader["remarks"] != DBNull.Value)
						oadmission.remarks = Convert.ToString(dataReader["remarks"]);

                    if (dataReader["nurse_remarks"] != DBNull.Value)
                        oadmission.nurse_remarks = Convert.ToString(dataReader["nurse_remarks"]);

					if(dataReader["is_bill_clear"] != DBNull.Value)
						oadmission.is_bill_clear = Convert.ToSByte(dataReader["is_bill_clear"]);

					if(dataReader["is_discharged"] != DBNull.Value)
						oadmission.is_discharged = Convert.ToSByte(dataReader["is_discharged"]);

					if(dataReader["is_cc_written"] != DBNull.Value)
						oadmission.is_cc_written = Convert.ToSByte(dataReader["is_cc_written"]);

					if(dataReader["is_history_written"] != DBNull.Value)
						oadmission.is_history_written = Convert.ToSByte(dataReader["is_history_written"]);

					if(dataReader["is_first_reqular_checkup_done"] != DBNull.Value)
						oadmission.is_first_reqular_checkup_done = Convert.ToSByte(dataReader["is_first_reqular_checkup_done"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oadmission.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oadmission.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oadmission.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oadmission.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oadmission;
		}
        public int Addadmission(AdmissionBO oadmission, out int paymentID,int Flag)
		{
			SqlParameter[] arParams = new SqlParameter[17];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
			{
                arParams[0] = new SqlParameter("@admission_date", oadmission.admission_date);
                arParams[1] = new SqlParameter("@case_no", oadmission.case_no);
                arParams[2] = new SqlParameter("@patient_id", oadmission.patient_id);
				arParams[3] = new SqlParameter("@cabin_id", oadmission.cabin_id);
				arParams[4] = new SqlParameter("@deposit", oadmission.deposit);
				arParams[5] = new SqlParameter("@remarks", oadmission.remarks);
                arParams[6] = new SqlParameter("@nurse_remarks", oadmission.nurse_remarks);
                arParams[7] = new SqlParameter("@is_bill_clear", oadmission.is_bill_clear);
				arParams[8] = new SqlParameter("@is_discharged", oadmission.is_discharged);
				arParams[9] = new SqlParameter("@is_cc_written", oadmission.is_cc_written);
				arParams[10] = new SqlParameter("@is_history_written", oadmission.is_history_written);
				arParams[11] = new SqlParameter("@is_first_reqular_checkup_done", oadmission.is_first_reqular_checkup_done);
				arParams[12]= new SqlParameter("@record_created_by", oadmission.record_created_by);
				arParams[13]= new SqlParameter("@record_modified_by", oadmission.record_modified_by);
                arParams[14] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[15] = new SqlParameter("@payment_id", SqlDbType.Int, 11);
                arParams[14].Direction = ParameterDirection.Output;
                arParams[15].Direction = ParameterDirection.Output;
                arParams[16] = new SqlParameter("@falg",Flag);

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "admissionAdd", arParams);
                result = Convert.ToInt32(arParams[14].Value.ToString());
                paymentID = Convert.ToInt32(arParams[15].Value.ToString());
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
        public int newadmissionAdd(AdmissionBO admissionBO, Pay pay)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int AdmissionID = 0;

            try
            {
                AdmissionID = Add(trans, admissionBO);
                admissionpayment(trans,AdmissionID, pay);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                AdmissionID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return AdmissionID;
        }

        public int Add(SqlTransaction trans, AdmissionBO oadmission)
        {
            SqlParameter[] arParams = new SqlParameter[16];
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_date", oadmission.admission_date);
                arParams[1] = new SqlParameter("@case_no", oadmission.case_no);
                arParams[2] = new SqlParameter("@patient_id", oadmission.patient_id);
                arParams[3] = new SqlParameter("@cabin_id", oadmission.cabin_id);
                arParams[4] = new SqlParameter("@deposit", oadmission.deposit);
                arParams[5] = new SqlParameter("@remarks", oadmission.remarks);
                arParams[6] = new SqlParameter("@nurse_remarks", oadmission.nurse_remarks);
                arParams[7] = new SqlParameter("@is_bill_clear", oadmission.is_bill_clear);
                arParams[8] = new SqlParameter("@is_discharged", oadmission.is_discharged);
                arParams[9] = new SqlParameter("@is_cc_written", oadmission.is_cc_written);
                arParams[10] = new SqlParameter("@is_history_written", oadmission.is_history_written);
                arParams[11] = new SqlParameter("@is_first_reqular_checkup_done", oadmission.is_first_reqular_checkup_done);
                arParams[12] = new SqlParameter("@record_created_by", oadmission.record_created_by);
                arParams[13] = new SqlParameter("@record_modified_by", oadmission.record_modified_by);
                arParams[14] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[14].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "newadmissionAdd", arParams);
                result = Convert.ToInt32(arParams[14].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        private void admissionpayment(SqlTransaction trans,int ADdID, Pay pay)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                    arParams[0] = new SqlParameter("@admission_id", ADdID);
                    arParams[1] = new SqlParameter("@deposit", pay.amount);
                    arParams[2] = new SqlParameter("@record_created_by", pay.record_created_by);
                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "admissionpayment", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updateadmission(AdmissionBO oadmission)
		{

			SqlParameter[] arParams = new SqlParameter[18];
			try
			{
				arParams[0] = new SqlParameter("@admission_code", oadmission.admission_code);
				arParams[1] = new SqlParameter("@admission_date", oadmission.admission_date);
                arParams[2] = new SqlParameter("@case_no", oadmission.case_no);
                arParams[3] = new SqlParameter("@patient_id", oadmission.patient_id);
				arParams[4] = new SqlParameter("@cabin_id", oadmission.cabin_id);
				arParams[5] = new SqlParameter("@deposit", oadmission.deposit);
				arParams[6] = new SqlParameter("@remarks", oadmission.remarks);
                arParams[7] = new SqlParameter("@nurse_remarks", oadmission.nurse_remarks);
                arParams[8] = new SqlParameter("@is_bill_clear", oadmission.is_bill_clear);
				arParams[9] = new SqlParameter("@is_discharged", oadmission.is_discharged);
				arParams[10] = new SqlParameter("@is_cc_written", oadmission.is_cc_written);
				arParams[11] = new SqlParameter("@is_history_written", oadmission.is_history_written);
				arParams[12] = new SqlParameter("@is_first_reqular_checkup_done", oadmission.is_first_reqular_checkup_done);
				arParams[13] = new SqlParameter("@record_created_date", oadmission.record_created_date);
				arParams[14] = new SqlParameter("@record_created_by", oadmission.record_created_by);
				arParams[15] = new SqlParameter("@record_modified_date", oadmission.record_modified_date);
				arParams[16] = new SqlParameter("@record_modified_by", oadmission.record_modified_by);
				arParams[17] = new SqlParameter("@admission_id", oadmission.admission_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "admissionUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int UpdateAdmissionRemarks(AdmissionBO oadmission)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[1] = new SqlParameter("@remarks", oadmission.remarks);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AdmissionRemarksUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateAdmissionNurseRemarks(AdmissionBO oadmission)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[1] = new SqlParameter("@nurse_remarks", oadmission.nurse_remarks);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AdmissionNurseRemarksUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int admissionUpdateforBill(AdmissionBO oadmission)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[1] = new SqlParameter("@is_bill_clear", oadmission.is_bill_clear);
                arParams[2] = new SqlParameter("@record_modified_by", oadmission.record_modified_by);
                
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "admissionUpdateforBill", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SetPatientDischargeInfo(int admissionID, int cabinID, int userID, CaseSummary caseSummary)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                arParams[1] = new SqlParameter("@cabin_id", cabinID);
                arParams[2] = new SqlParameter("@preCaseSummary",caseSummary.PreCaseSummary );
                arParams[3] = new SqlParameter("@aftCaseSummary", caseSummary.AftCaseSummary);
                arParams[4] = new SqlParameter("@record_modified_by", userID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SetPatientDischargeInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet AdmissionCaseNoGet(string pCode)
		{
            SqlParameter[] arParams = new SqlParameter[1];
            try
			{
                arParams[0] = new SqlParameter("@patient_code", pCode);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "AdmissionCaseNoGet", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

       	public int Removeadmission(AdmissionBO oadmission)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@admission_id", oadmission.admission_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "admissionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeadmission(int admission_id)
		{
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@admission_id", admission_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "admissionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetDoctorVisitPopulationInfo(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDoctorVisitPopulationInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
       }

        public DataSet RefDocAndCabinByPCode(string patientID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_code", patientID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "RefDocAndCabinByPCode", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


        public DataSet GetNurseStationPopulationInfo(int prresID, int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@prescription_id", prresID);
                arParams[1] = new SqlParameter("@admissionID", admissionID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetNurseStationPopulationInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
       }

        public DataSet GetDoctorStationPopulationInfo(int floorID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@floor_id", floorID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDoctorStationPopulationInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
       }
        


        public DataSet GetPatientInfoByFloor(string floor)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@floor", floor);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPatientInfoByFloor", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
       }
  
        public DataSet GetAdmissionReportData(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetAdmissionReportData", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
       }

        public DataSet GetAllNonReceivedPatientCabin()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetAllNonReceivedPatientCabin");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
	}
}
