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
    public class OPD_patient_medicine_orderDAL
    {
        public OPD_patient_medicine_orderDAL()
		{
		}

        public int opdmedicinereceive(OPD_patient_medicine_order opd_patient_medicine_order)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@received_by", opd_patient_medicine_order.received_by);
                arParams[1] = new SqlParameter("@opd_patient_medicine_order_id", opd_patient_medicine_order.opd_patient_medicine_order_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "opdmedicinereceive", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OPDmedicineIndent(OPD_patient_medicine_order OPDpatientMedicineIndentOrder, List<OPDpatientMedicineIndent> lstOPDpatientMedicineIndent)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int OrderID = 0;

            try
            {
                OrderID = opdmedicineindentadd(trans, OPDpatientMedicineIndentOrder);
                opdmedicineADD(trans, OrderID, lstOPDpatientMedicineIndent);

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

        public int opdmedicineindentadd(SqlTransaction trans, OPD_patient_medicine_order OPDpatientMedicineIndentOrder)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@PKID", OPDpatientMedicineIndentOrder.PKID);
                arParams[1] = new SqlParameter("@indent_by", OPDpatientMedicineIndentOrder.indent_by);
                arParams[2] = new SqlParameter("@ID", OPDpatientMedicineIndentOrder.opd_patient_medicine_order_id);
                arParams[2].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "opdmedicineindentadd", arParams);
                result = Convert.ToInt32(arParams[2].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void opdmedicineADD(SqlTransaction trans, int OrderID, List<OPDpatientMedicineIndent> lstOPDpatientMedicineIndent)
        {

            SqlParameter[] arParams = new SqlParameter[4];

            try
            {
                foreach (OPDpatientMedicineIndent element in lstOPDpatientMedicineIndent)
                {
                    arParams[0] = new SqlParameter("@opd_order_id", OrderID);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@qty_ordered", element.qty_ordered);
                    arParams[3] = new SqlParameter("@record_created_by", element.record_created_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "opdmedicineADD", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
