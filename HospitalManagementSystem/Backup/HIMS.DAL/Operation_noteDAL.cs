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
	public class Operation_noteDAL
	{
		public Operation_noteDAL()
		{
		}
		public List<OperationNote> Getoperation_notesList()
		{
			SqlConnection conn = null;
			List<OperationNote> lstoperation_notes = new List<OperationNote>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "operation_noteGetAll", null, ref conn);
				while (dataReader.Read())
				{
					OperationNote ooperation_note = new OperationNote();
					ooperation_note.operation_note_id = Convert.ToInt32(dataReader["operation_note_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						ooperation_note.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["expected_date"] != DBNull.Value)
						ooperation_note.expected_date = Convert.ToDateTime(dataReader["expected_date"]);

					if(dataReader["operation_date"] != DBNull.Value)
						ooperation_note.operation_date = Convert.ToDateTime(dataReader["operation_date"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						ooperation_note.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						ooperation_note.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["anaesthesia_id"] != DBNull.Value)
						ooperation_note.anaesthesia_id = Convert.ToInt32(dataReader["anaesthesia_id"]);

					if(dataReader["first_asst"] != DBNull.Value)
						ooperation_note.first_asst = Convert.ToInt32(dataReader["first_asst"]);

					if(dataReader["second_asst"] != DBNull.Value)
						ooperation_note.second_asst = Convert.ToInt32(dataReader["second_asst"]);

					if(dataReader["third_asst"] != DBNull.Value)
						ooperation_note.third_asst = Convert.ToInt32(dataReader["third_asst"]);

					if(dataReader["surgeon_name"] != DBNull.Value)
						ooperation_note.surgeon_name = Convert.ToInt32(dataReader["surgeon_name"]);

					if(dataReader["indication"] != DBNull.Value)
						ooperation_note.indication = Convert.ToString(dataReader["indication"]);

					if(dataReader["incision"] != DBNull.Value)
						ooperation_note.incision = Convert.ToString(dataReader["incision"]);

					if(dataReader["operation_id"] != DBNull.Value)
						ooperation_note.operation_id = Convert.ToInt32(dataReader["operation_id"]);

					if(dataReader["baby_note_id"] != DBNull.Value)
						ooperation_note.baby_note_id = Convert.ToInt32(dataReader["baby_note_id"]);

					if(dataReader["procedures"] != DBNull.Value)
						ooperation_note.procedures = Convert.ToString(dataReader["procedures"]);

					if(dataReader["GroupPay"] != DBNull.Value)
						ooperation_note.GroupPay = Convert.ToDecimal(dataReader["GroupPay"]);

					if(dataReader["Remarks"] != DBNull.Value)
						ooperation_note.Remarks = Convert.ToString(dataReader["Remarks"]);

                   
                    ooperation_note.is_submit = Convert.ToInt32(dataReader["is_submit"]);


                    ooperation_note.is_received = Convert.ToInt32(dataReader["is_received"]);

                if (dataReader["amount"] != DBNull.Value)
                    ooperation_note.amount = Convert.ToDecimal(dataReader["amount"]);

					lstoperation_notes.Add(ooperation_note);
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
			return lstoperation_notes;
		}
		public DataSet Getoperation_notes()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "operation_noteGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet GetOTNurseInfo()//sami 27 nov 2008
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOTNurseInfo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet getprocedureforOT(int TreatmentID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@treatemtntID", TreatmentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getprocedureforOT", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetOTNoteInfo(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
               return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOTNoteInfo", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        
        public DataSet OTlink(int admissionID)//sami 1 feb 2008
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("admisionID", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTlink", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
   
        public DataSet OTNurseCmb(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admissionID", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTNurseCmb", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet OTNurseText(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@AdmissionID", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTNurseText", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public int Addoperation_note(OperationNote ooperation_note)
		{
			SqlParameter[] arParams = new SqlParameter[20];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", ooperation_note.admission_id);
				arParams[1] = new SqlParameter("@expected_date", ooperation_note.expected_date);
				arParams[2] = new SqlParameter("@operation_date", ooperation_note.operation_date);
				arParams[3] = new SqlParameter("@reffered_doctors_id", ooperation_note.reffered_doctors_id);
				arParams[4] = new SqlParameter("@cabin_id", ooperation_note.cabin_id);
				arParams[5] = new SqlParameter("@anaesthesia_id", ooperation_note.anaesthesia_id);
				arParams[6] = new SqlParameter("@first_asst", ooperation_note.first_asst);
				arParams[7] = new SqlParameter("@second_asst", ooperation_note.second_asst);
				arParams[8] = new SqlParameter("@third_asst", ooperation_note.third_asst);
				arParams[9] = new SqlParameter("@surgeon_name", ooperation_note.surgeon_name);
				arParams[10] = new SqlParameter("@indication", ooperation_note.indication);
				arParams[11] = new SqlParameter("@incision", ooperation_note.incision);
				arParams[12] = new SqlParameter("@operation_id", ooperation_note.operation_id);
				arParams[13] = new SqlParameter("@baby_note_id", ooperation_note.baby_note_id);
				arParams[14] = new SqlParameter("@procedures", ooperation_note.procedures);
				arParams[15] = new SqlParameter("@GroupPay", ooperation_note.GroupPay);
				arParams[16] = new SqlParameter("@Remarks", ooperation_note.Remarks);
				arParams[17] = new SqlParameter("@is_submit", ooperation_note.is_submit);
				arParams[18] = new SqlParameter("@is_received", ooperation_note.is_received);
                arParams[19] = new SqlParameter("@amount", ooperation_note.amount);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "operation_noteAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int DoctotOTDeclare(OperationNote ooperation_note)//sami
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", ooperation_note.admission_id);
                arParams[1] = new SqlParameter("@operation_id", ooperation_note.operation_id);
                arParams[2] = new SqlParameter("@surgeon_name", ooperation_note.surgeon_name);
                arParams[3] = new SqlParameter("@is_submit", ooperation_note.is_submit);
                arParams[4] = new SqlParameter("@cabinID", ooperation_note.cabin_id);
                arParams[5] = new SqlParameter("@record_created_by", ooperation_note.record_created_by);


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "DoctotOTDeclare", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTnoteMedicineUpdate(OperationNote ooperation_note)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", ooperation_note.admission_id);
                arParams[1] = new SqlParameter("@requisition_no", ooperation_note.ot_requisition_no);
                arParams[2] = new SqlParameter("@operation_note_id", ooperation_note.operation_note_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTnoteMedicineUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTSubmit(OperationNote ooperation_note)//sami 1 feb 2009
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", ooperation_note.admission_id);
                arParams[1] = new SqlParameter("@is_submit", ooperation_note.is_submit);
                arParams[2] = new SqlParameter("@record_modified_by", ooperation_note.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTSubmit", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public int OTnurseDischarge(OperationNote ooperation_note)//sami 14 jan 2009
        {

            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@cabin_id", ooperation_note.Ot_cabin_id);
                arParams[1] = new SqlParameter("@p_day", ooperation_note.p_day);
                arParams[2] = new SqlParameter("@additional_time",ooperation_note.additional_time);
                arParams[3] = new SqlParameter("@is_received", ooperation_note.is_received);
                arParams[4] = new SqlParameter("@operation_note_id", ooperation_note.operation_note_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTnurseDischarge", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int OTNurseUpdate(OperationNote ooperation_note)
        {

            SqlParameter[] arParams = new SqlParameter[11];
            try
            {
                arParams[0] = new SqlParameter("@operation_note_id", ooperation_note.operation_note_id);
                arParams[1] = new SqlParameter("@anaesthesia_id", ooperation_note.anaesthesia_id);
                //arParams[2] = (ooperation_note.first_asst == -1) ? new SqlParameter("@first_asst", DBNull.Value) : new SqlParameter("@first_asst", ooperation_note.first_asst);
                arParams[2] = new SqlParameter("@first_asst", ooperation_note.first_asst);
                arParams[3] = new SqlParameter("@second_asst", ooperation_note.second_asst);
                arParams[4] = new SqlParameter("@third_asst", ooperation_note.third_asst);
                arParams[5] = new SqlParameter("@surgeon_name", ooperation_note.surgeon_name);
                arParams[6] = new SqlParameter("@is_submit", ooperation_note.is_submit);
                arParams[7] = new SqlParameter("@is_received", ooperation_note.is_received);
                arParams[8] = new SqlParameter("@anaesthesia_nature_id", ooperation_note.anaesthesia_nature_id);
                arParams[9] = new SqlParameter("@record_created_by", ooperation_note.record_created_by);
                arParams[10] = new SqlParameter("@record_modified_by", ooperation_note.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTNurseUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int OperationBabyNoteUpdate(OperationNote ooperation_note)
        {

            SqlParameter[] arParams = new SqlParameter[18];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", ooperation_note.admission_id);
                arParams[1] = new SqlParameter("@cabin_id", ooperation_note.cabin_id);
                arParams[2] = new SqlParameter("@operation_id", ooperation_note.operation_id);
                arParams[3] = new SqlParameter("@operation_date", ooperation_note.operation_date);
                arParams[4] = new SqlParameter("@anaesthesia_id", ooperation_note.anaesthesia_id);
                arParams[5] = new SqlParameter("@first_asst", ooperation_note.first_asst);
                arParams[6] = new SqlParameter("@second_asst", ooperation_note.second_asst);
                arParams[7] = new SqlParameter("@third_asst", ooperation_note.third_asst);
                arParams[8] = new SqlParameter("@surgeon_name", ooperation_note.surgeon_name);
                arParams[9] = new SqlParameter("@indication", ooperation_note.indication);
                arParams[10] = new SqlParameter("@incision", ooperation_note.incision);
                arParams[11] = new SqlParameter("@procedures", ooperation_note.procedures);
                arParams[12] = new SqlParameter("@GroupPay", ooperation_note.GroupPay);
                arParams[13] = new SqlParameter("@amount", ooperation_note.amount);
                arParams[14] = new SqlParameter("@Remarks", ooperation_note.Remarks);
                arParams[16] = new SqlParameter("@anaesthesia_nature_id", ooperation_note.anaesthesia_nature_id);
                arParams[17] = new SqlParameter("@record_modified_by", ooperation_note.record_modified_by);
                
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OperationBabyNoteUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
