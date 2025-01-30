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
	public class PatientOtherItemDAL
	{
		public PatientOtherItemDAL()
		{
		}
		public List<PatientOtherItem> Getpatient_other_itemsList()
		{
			SqlConnection conn = null;
			List<PatientOtherItem> lstpatient_other_items = new List<PatientOtherItem>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_other_itemGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientOtherItem opatient_other_item = new PatientOtherItem();
					opatient_other_item.patient_other_item_id = Convert.ToInt32(dataReader["patient_other_item_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_other_item.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["other_item_id"] != DBNull.Value)
						opatient_other_item.other_item_id = Convert.ToInt32(dataReader["other_item_id"]);

					if(dataReader["issue_date"] != DBNull.Value)
						opatient_other_item.issue_date = Convert.ToDateTime(dataReader["issue_date"]);

					if(dataReader["return_date"] != DBNull.Value)
						opatient_other_item.return_date = Convert.ToDateTime(dataReader["return_date"]);

					if(dataReader["consume_qty"] != DBNull.Value)
						opatient_other_item.consume_qty = Convert.ToDecimal(dataReader["consume_qty"]);

					if(dataReader["qty_per_unit"] != DBNull.Value)
						opatient_other_item.qty_per_unit = Convert.ToDecimal(dataReader["qty_per_unit"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_other_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_other_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_other_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_other_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_other_items.Add(opatient_other_item);
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
			return lstpatient_other_items;
		}
		public DataSet Getpatient_other_items()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_other_itemGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetPatientOtherItemByAdmnID(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPatientOtherItemByAdmnID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public PatientOtherItem Getpatient_other_item(int patient_other_item_id)
		{
			SqlConnection conn = null;
			PatientOtherItem opatient_other_item = new PatientOtherItem();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_other_item_id", patient_other_item_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_other_itemGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_other_item.patient_other_item_id = Convert.ToInt32(dataReader["patient_other_item_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_other_item.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["other_item_id"] != DBNull.Value)
						opatient_other_item.other_item_id = Convert.ToInt32(dataReader["other_item_id"]);

					if(dataReader["issue_date"] != DBNull.Value)
						opatient_other_item.issue_date = Convert.ToDateTime(dataReader["issue_date"]);

					if(dataReader["return_date"] != DBNull.Value)
						opatient_other_item.return_date = Convert.ToDateTime(dataReader["return_date"]);

					if(dataReader["consume_qty"] != DBNull.Value)
						opatient_other_item.consume_qty = Convert.ToDecimal(dataReader["consume_qty"]);

					if(dataReader["qty_per_unit"] != DBNull.Value)
						opatient_other_item.qty_per_unit = Convert.ToDecimal(dataReader["qty_per_unit"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_other_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_other_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_other_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_other_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_other_item;
		}
        public int OtherItemAddforOPD(PatientOtherItem opatient_other_item)
        {
            SqlParameter[] arParams = new SqlParameter[8];
            try
            {
                arParams[0] = new SqlParameter("@patient_id", opatient_other_item.patient_id);
                arParams[1] = new SqlParameter("@other_item_id", opatient_other_item.other_item_id);
                arParams[2] = new SqlParameter("@return_date", opatient_other_item.return_date);
                arParams[3] = new SqlParameter("@consume_qty", opatient_other_item.consume_qty);
                arParams[4] = new SqlParameter("@qty_per_unit", opatient_other_item.qty_per_unit);
                arParams[5] = new SqlParameter("@record_created_by", opatient_other_item.record_created_by);
                arParams[6] = new SqlParameter("@record_modified_by", opatient_other_item.record_modified_by);
                arParams[7] = new SqlParameter("@unit_rate", opatient_other_item.unit_rate);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OtherItemAddforOPD", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Addpatient_other_item(PatientOtherItem opatient_other_item)
		{
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_other_item.admission_id);
				arParams[1] = new SqlParameter("@other_item_id", opatient_other_item.other_item_id);
				arParams[2] = new SqlParameter("@return_date", opatient_other_item.return_date);
				arParams[3] = new SqlParameter("@consume_qty", opatient_other_item.consume_qty);
				arParams[4] = new SqlParameter("@qty_per_unit", opatient_other_item.qty_per_unit);
				arParams[5] = new SqlParameter("@record_created_by", opatient_other_item.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", opatient_other_item.record_modified_by);
                arParams[7] = new SqlParameter("@unit_rate", opatient_other_item.unit_rate);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_other_itemAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Addpatient_other_itemDialysis(PatientOtherItem opatient_other_item)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opatient_other_item.admission_id);
                arParams[1] = new SqlParameter("@other_item_id", opatient_other_item.other_item_id);
                arParams[2] = new SqlParameter("@qty_per_unit", opatient_other_item.qty_per_unit);
                arParams[3] = new SqlParameter("@record_created_by", opatient_other_item.record_created_by);

                arParams[4] = new SqlParameter("@unit_rate", opatient_other_item.unit_rate);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_other_itemAddDialysis", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Addpatient_other_itemICU(PatientOtherItem opatient_other_item)
        {
            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", opatient_other_item.admission_id);
                arParams[1] = new SqlParameter("@other_item_id", opatient_other_item.other_item_id);
                arParams[2] = new SqlParameter("@qty_per_unit", opatient_other_item.qty_per_unit);
                arParams[3] = new SqlParameter("@record_created_by", opatient_other_item.record_created_by);

                arParams[4] = new SqlParameter("@unit_rate", opatient_other_item.unit_rate);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_other_itemAddICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Updatepatient_other_item(PatientOtherItem opatient_other_item)
		{

			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_other_item.admission_id);
				arParams[1] = new SqlParameter("@other_item_id", opatient_other_item.other_item_id);
				arParams[2] = new SqlParameter("@issue_date", opatient_other_item.issue_date);
				arParams[3] = new SqlParameter("@return_date", opatient_other_item.return_date);
				arParams[4] = new SqlParameter("@consume_qty", opatient_other_item.consume_qty);
				arParams[5] = new SqlParameter("@qty_per_unit", opatient_other_item.qty_per_unit);
				arParams[6] = new SqlParameter("@record_created_by", opatient_other_item.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", opatient_other_item.record_modified_by);
				arParams[8] = new SqlParameter("@patient_other_item_id", opatient_other_item.patient_other_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_other_itemUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int patientotheritemQtyUpdate(PatientOtherItem opatient_other_item)
        {
            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@qty_per_unit", opatient_other_item.qty_per_unit);
                arParams[1] = new SqlParameter("@patient_other_item_id", opatient_other_item.patient_other_item_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patientotheritemQtyUpdate", arParams);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient_other_item(PatientOtherItem opatient_other_item)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_other_item_id", opatient_other_item.patient_other_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_other_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_other_item(int patient_other_item_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_other_item_id", patient_other_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_other_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
