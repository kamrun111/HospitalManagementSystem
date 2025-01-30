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
	public class PatientMedicineIndentDAL
	{
		public PatientMedicineIndentDAL()
		{
		}
		public List<PatientMedicineIndent> Getpatient_medicine_indentsList()
		{
			SqlConnection conn = null;
			List<PatientMedicineIndent> lstpatient_medicine_indents = new List<PatientMedicineIndent>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_medicine_indentGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientMedicineIndent opatient_medicine_indent = new PatientMedicineIndent();
					opatient_medicine_indent.patient_medicine_indent_id = Convert.ToInt32(dataReader["patient_medicine_indent_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_medicine_indent.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						opatient_medicine_indent.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						opatient_medicine_indent.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["quantity_ordered"] != DBNull.Value)
						opatient_medicine_indent.quantity_ordered = Convert.ToInt32(dataReader["quantity_ordered"]);

					if(dataReader["quantity_received"] != DBNull.Value)
						opatient_medicine_indent.quantity_received = Convert.ToInt32(dataReader["quantity_received"]);

					if(dataReader["quantity_delivered"] != DBNull.Value)
						opatient_medicine_indent.quantity_delivered = Convert.ToInt32(dataReader["quantity_delivered"]);

					if(dataReader["store_id"] != DBNull.Value)
						opatient_medicine_indent.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_medicine_indent.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_medicine_indent.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_medicine_indent.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_medicine_indent.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_medicine_indents.Add(opatient_medicine_indent);
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
			return lstpatient_medicine_indents;
		}
		public DataSet Getpatient_medicine_indents()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_medicine_indentGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet GetMedicineReceive(int admnID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admissionID", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetMedicineReceive", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet OrderListforReceive(int admnID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OrderListforReceive", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet ReceiveDetailforNurse(int OrderID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@OrderID", OrderID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ReceiveDetailforNurse", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int medicineNursereceive(List<PatientMedicineIndent> lstpatientMedicineIndent)//sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[3];
            int result = 0;

            try
            {
                foreach (PatientMedicineIndent element in lstpatientMedicineIndent)
                {
                    arParams[0] = new SqlParameter("@patientmedicineindentID", element.patient_medicine_indent_id);
                    arParams[1] = new SqlParameter("@quantity_received", element.quantity_received);
                    arParams[2] = new SqlParameter("@receivedby", element.received_by);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "medicineNursereceive", arParams);
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
        public DataSet PatientMedicineIndentPopulate(int admnID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PatientMedicineIndentPopulate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet PatientOtherItemIndentPopulate(int admnID, int cabinID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                arParams[1] = new SqlParameter("@cabin_id", cabinID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "PatientOtherItemIndentPopulate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet OtherItemsLoad(int admnID, int cabinID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                arParams[1] = new SqlParameter("@cabin_id", cabinID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OtherItemsLoad", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int AddotheritemPatientMedicineIndent(List<PatientMedicineIndent> lstPatientMedicineIndent)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[6];
            int result = 0;

            try
            {
                foreach (PatientMedicineIndent element in lstPatientMedicineIndent)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@cabin_id", element.cabin_id);
                    arParams[2] = new SqlParameter("@product_id", element.product_id);
                    arParams[3] = new SqlParameter("@quantity_ordered", element.quantity_ordered);
                    arParams[4] = new SqlParameter("@store_id", element.store_id);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);


                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indentotheritemAdd", arParams);
                }
                //patient_medicine_indentUpdateList(lstPatientMedicineIndentUp);
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


		public PatientMedicineIndent Getpatient_medicine_indent(int patient_medicine_indent_id)
		{
			SqlConnection conn = null;
			PatientMedicineIndent opatient_medicine_indent = new PatientMedicineIndent();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_medicine_indent_id", patient_medicine_indent_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_medicine_indentGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_medicine_indent.patient_medicine_indent_id = Convert.ToInt32(dataReader["patient_medicine_indent_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_medicine_indent.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						opatient_medicine_indent.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						opatient_medicine_indent.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["quantity_ordered"] != DBNull.Value)
						opatient_medicine_indent.quantity_ordered = Convert.ToInt32(dataReader["quantity_ordered"]);

					if(dataReader["quantity_received"] != DBNull.Value)
						opatient_medicine_indent.quantity_received = Convert.ToInt32(dataReader["quantity_received"]);

					if(dataReader["quantity_delivered"] != DBNull.Value)
						opatient_medicine_indent.quantity_delivered = Convert.ToInt32(dataReader["quantity_delivered"]);

					if(dataReader["store_id"] != DBNull.Value)
						opatient_medicine_indent.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_medicine_indent.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_medicine_indent.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_medicine_indent.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_medicine_indent.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_medicine_indent;
		}
		public int Addpatient_medicine_indent(PatientMedicineIndent opatient_medicine_indent)
		{
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_medicine_indent.admission_id);
				arParams[1] = new SqlParameter("@cabin_id", opatient_medicine_indent.cabin_id);
				arParams[2] = new SqlParameter("@product_id", opatient_medicine_indent.product_id);
				arParams[3] = new SqlParameter("@quantity_ordered", opatient_medicine_indent.quantity_ordered);
                arParams[4] = new SqlParameter("@quantity_received", opatient_medicine_indent.quantity_received);
				arParams[5] = new SqlParameter("@quantity_delivered", opatient_medicine_indent.quantity_delivered);
				arParams[6] = new SqlParameter("@store_id", opatient_medicine_indent.store_id);
				arParams[7] = new SqlParameter("@record_created_by", opatient_medicine_indent.record_created_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "PatientMedicineIndentAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int AddPatientMedicineIndent(List<PatientMedicineIndent> lstPatientMedicineIndent)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[6];
            int result = 0;

            try
            {
                foreach (PatientMedicineIndent element in lstPatientMedicineIndent)
                {
                    arParams[0] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[1] = new SqlParameter("@cabin_id", element.cabin_id);
                    arParams[2] = new SqlParameter("@product_id", element.product_id);
                    arParams[3] = new SqlParameter("@quantity_ordered", element.quantity_ordered);
                    arParams[4] = new SqlParameter("@store_id", element.store_id);
                    arParams[5] = new SqlParameter("@record_created_by", element.record_created_by);
                    

                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indentAdd", arParams);
                }
                //patient_medicine_indentUpdateList(lstPatientMedicineIndentUp);
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

        public int patient_medicine_indentUpdateList(List<PatientMedicineIndent> patientMedicineIndentUP)//sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[4];
            int result = 0;

            try
            {
                foreach (PatientMedicineIndent element in patientMedicineIndentUP)
                {
                    arParams[0] = new SqlParameter("@quantity_ordered", element.quantity_ordered);
                    arParams[1] = new SqlParameter("@quantity_received", element.quantity_received);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[3] = new SqlParameter("@patient_medicine_indent_id", element.patient_medicine_indent_id);
                    //DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicine_indentUpdateList", arParams);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indentUpdateList", arParams);
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
        public int patient_medicine_indentUpdateReceiveList(List<PatientMedicineIndent> patientMedicineIndentUPRec)//sami
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[4];
            int result = 0;

            try
            {
                foreach (PatientMedicineIndent element in patientMedicineIndentUPRec)
                {
                    arParams[0] = new SqlParameter("@quantity_received", element.quantity_received);
                    arParams[1] = new SqlParameter("@store_id", element.store_id);
                    arParams[2] = new SqlParameter("@record_modified_by", element.record_modified_by);
                    arParams[3] = new SqlParameter("@patient_medicine_indent_id", element.patient_medicine_indent_id);
                    //DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicine_indentUpdateList", arParams);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indentUpdateReceiveList", arParams);
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

		public int Updatepatient_medicine_indent(PatientMedicineIndent opatient_medicine_indent)
		{

			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_medicine_indent.admission_id);
				arParams[1] = new SqlParameter("@cabin_id", opatient_medicine_indent.cabin_id);
				arParams[2] = new SqlParameter("@product_id", opatient_medicine_indent.product_id);
				arParams[3] = new SqlParameter("@quantity_ordered", opatient_medicine_indent.quantity_ordered);
				arParams[4] = new SqlParameter("@quantity_received", opatient_medicine_indent.quantity_received);
				arParams[5] = new SqlParameter("@quantity_delivered", opatient_medicine_indent.quantity_delivered);
				arParams[6] = new SqlParameter("@store_id", opatient_medicine_indent.store_id);
                //arParams[7] = new SqlParameter("@record_created_by", opatient_medicine_indent.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", opatient_medicine_indent.record_modified_by);
				arParams[8] = new SqlParameter("@patient_medicine_indent_id", opatient_medicine_indent.patient_medicine_indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicine_indentUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine_indent(PatientMedicineIndent opatient_medicine_indent)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_medicine_indent_id", opatient_medicine_indent.patient_medicine_indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicine_indentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine_indent(int patient_medicine_indent_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_medicine_indent_id", patient_medicine_indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicine_indentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
