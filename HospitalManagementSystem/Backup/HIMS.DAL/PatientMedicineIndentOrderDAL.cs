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
	public class PatientMedicineIndentOrderDAL
	{
        public PatientMedicineIndentOrderDAL()
		{
		}
        public int patient_medicine_indent_orderAdd(SqlTransaction trans, PatientMedicineIndentOrder opatientMedicineIndentOrder)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opatientMedicineIndentOrder.admission_id);
                arParams[1] = new SqlParameter("@cabin_id", opatientMedicineIndentOrder.cabin_id);
                arParams[2] = new SqlParameter("@station", opatientMedicineIndentOrder.station);
                arParams[3] = new SqlParameter("@record_created_by", opatientMedicineIndentOrder.record_created_by);
                arParams[4] = new SqlParameter("@patient_medicine_indent_order_id", opatientMedicineIndentOrder.patient_medicine_indent_order_id);
                arParams[4].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indent_orderAdd", arParams);
                result = Convert.ToInt32(arParams[4].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void AddotheritemPatientMedicineIndent(SqlTransaction trans, int OrderID, List<PatientMedicineIndent> lstPatientMedicineIndent)
        {
            
            SqlParameter[] arParams = new SqlParameter[8];
         
            try
            {
                foreach (PatientMedicineIndent element in lstPatientMedicineIndent)
                {
                    arParams[0] = new SqlParameter("@patient_medicine_indent_order_id", OrderID);
                    arParams[1] = new SqlParameter("@admission_id", element.admission_id);
                    arParams[2] = new SqlParameter("@cabin_id", element.cabin_id);
                    arParams[3] = new SqlParameter("@product_id", element.product_id);
                    arParams[4] = new SqlParameter("@quantity_ordered", element.quantity_ordered);
                    arParams[5] = new SqlParameter("@store_id", element.store_id);
                    arParams[6] = new SqlParameter("@station", element.station);
                    arParams[7] = new SqlParameter("@record_created_by", element.record_created_by);

                   SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indentotheritemAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public int MedicineIndent(PatientMedicineIndentOrder opatientMedicineIndentOrder, List<PatientMedicineIndent> lstPatientMedicineIndent)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int OrderID = 0;

            try
            {
                OrderID = patient_medicine_indent_orderAdd(trans, opatientMedicineIndentOrder);
                AddotheritemPatientMedicineIndent(trans, OrderID, lstPatientMedicineIndent);
                
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
        public int OtMedicineIndent(OperationNote ooperation_note, PatientMedicineIndentOrder opatientMedicineIndentOrder, List<PatientMedicineIndent> lstpatientMedicineIndent)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int OrderID = 0;
            try
            {
                OTnoteMedicineUpdate(trans,ooperation_note);
                OrderID = patient_medicine_indent_orderAdd(trans, opatientMedicineIndentOrder);
                AddotheritemPatientMedicineIndent(trans, OrderID, lstpatientMedicineIndent);
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
        public void OTnoteMedicineUpdate(SqlTransaction trans, OperationNote ooperation_note)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", ooperation_note.admission_id);
                arParams[1] = new SqlParameter("@requisition_no", ooperation_note.ot_requisition_no);
                arParams[2] = new SqlParameter("@operation_note_id", ooperation_note.operation_note_id);

                SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "OTnoteMedicineUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet dischargemedicinereceive()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "dischargemedicinereceive");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet OTmedicineReceived()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTmedicineReceived");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        //public void AddPatientMedicineIndent(List<PatientMedicineIndent> lstPatientMedicineIndent)
        //{
        //    SqlParameter[] arParams = new SqlParameter[6];
           
        //    try
        //    {
        //        foreach (PatientMedicineIndent element in lstPatientMedicineIndent)
        //        {
        //            arParams[0] = new SqlParameter("@patient_medicine_indent_order_id", element.admission_id);
        //            arParams[1] = new SqlParameter("@admission_id", element.admission_id);
        //            arParams[2] = new SqlParameter("@cabin_id", element.cabin_id);
        //            arParams[3] = new SqlParameter("@product_id", element.product_id);
        //            arParams[4] = new SqlParameter("@quantity_ordered", element.quantity_ordered);
        //            arParams[5] = new SqlParameter("@store_id", element.store_id);
        //            arParams[6] = new SqlParameter("@record_created_by", element.record_created_by);

        //            SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "patient_medicine_indentAdd", arParams);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
	}
}
