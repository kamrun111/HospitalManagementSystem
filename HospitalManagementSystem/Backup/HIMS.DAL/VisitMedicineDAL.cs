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
	public class VisitMedicineDAL
	{
		public VisitMedicineDAL()
		{
		}
		public List<VisitMedicine> Getvisit_medicinesList()
		{
			SqlConnection conn = null;
			List<VisitMedicine> lstvisit_medicines = new List<VisitMedicine>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_medicineGetAll", null, ref conn);
				while (dataReader.Read())
				{
					VisitMedicine ovisit_medicine = new VisitMedicine();
					ovisit_medicine.visit_medicine_id = Convert.ToInt32(dataReader["visit_medicine_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_medicine.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["medicine_id"] != DBNull.Value)
						ovisit_medicine.medicine_id = Convert.ToInt32(dataReader["medicine_id"]);

					if(dataReader["dose_p_quantity_id"] != DBNull.Value)
						ovisit_medicine.dose_p_quantity_id = Convert.ToInt32(dataReader["dose_p_quantity_id"]);

					if(dataReader["intake_sys_id"] != DBNull.Value)
						ovisit_medicine.intake_sys_id = Convert.ToInt32(dataReader["intake_sys_id"]);

					if(dataReader["medication_date"] != DBNull.Value)
						ovisit_medicine.medication_date = Convert.ToDateTime(dataReader["medication_date"]);

					if(dataReader["dose_count"] != DBNull.Value)
						ovisit_medicine.dose_count = Convert.ToInt32(dataReader["dose_count"]);

					if(dataReader["time_slots"] != DBNull.Value)
						ovisit_medicine.time_slots = Convert.ToString(dataReader["time_slots"]);

					if(dataReader["indent_given_once"] != DBNull.Value)
						ovisit_medicine.indent_given_once = Convert.ToSByte(dataReader["indent_given_once"]);

					if(dataReader["implication_way_id"] != DBNull.Value)
						ovisit_medicine.implication_way_id = Convert.ToInt32(dataReader["implication_way_id"]);

					if(dataReader["medicine_timing_id"] != DBNull.Value)
						ovisit_medicine.medicine_timing_id = Convert.ToInt32(dataReader["medicine_timing_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_medicine.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_medicine.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_medicine.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_medicine.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstvisit_medicines.Add(ovisit_medicine);
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
			return lstvisit_medicines;
		}
		public DataSet Getvisit_medicines()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "visit_medicineGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetNewlyPrescribedFloor()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "NewlyPrescribedFloorGet");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public VisitMedicine Getvisit_medicine(int visit_medicine_id)
		{
			SqlConnection conn = null;
			VisitMedicine ovisit_medicine = new VisitMedicine();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_medicine_id", visit_medicine_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_medicineGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ovisit_medicine.visit_medicine_id = Convert.ToInt32(dataReader["visit_medicine_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_medicine.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["medicine_id"] != DBNull.Value)
						ovisit_medicine.medicine_id = Convert.ToInt32(dataReader["medicine_id"]);

					if(dataReader["dose_p_quantity_id"] != DBNull.Value)
						ovisit_medicine.dose_p_quantity_id = Convert.ToInt32(dataReader["dose_p_quantity_id"]);

					if(dataReader["intake_sys_id"] != DBNull.Value)
						ovisit_medicine.intake_sys_id = Convert.ToInt32(dataReader["intake_sys_id"]);

					if(dataReader["medication_date"] != DBNull.Value)
						ovisit_medicine.medication_date = Convert.ToDateTime(dataReader["medication_date"]);

					if(dataReader["dose_count"] != DBNull.Value)
						ovisit_medicine.dose_count = Convert.ToInt32(dataReader["dose_count"]);

					if(dataReader["time_slots"] != DBNull.Value)
						ovisit_medicine.time_slots = Convert.ToString(dataReader["time_slots"]);

					if(dataReader["indent_given_once"] != DBNull.Value)
						ovisit_medicine.indent_given_once = Convert.ToSByte(dataReader["indent_given_once"]);

					if(dataReader["implication_way_id"] != DBNull.Value)
						ovisit_medicine.implication_way_id = Convert.ToInt32(dataReader["implication_way_id"]);

					if(dataReader["medicine_timing_id"] != DBNull.Value)
						ovisit_medicine.medicine_timing_id = Convert.ToInt32(dataReader["medicine_timing_id"]);


                    if (dataReader["is_continue"] != DBNull.Value)
                        ovisit_medicine.is_continue = Convert.ToInt32(dataReader["is_continue"]);


					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_medicine.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_medicine.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_medicine.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_medicine.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ovisit_medicine;
		}
		public int Addvisit_medicine(VisitMedicine ovisit_medicine)
		{
			SqlParameter[] arParams = new SqlParameter[15];
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_medicine.visit_prescription_id);
				arParams[1] = new SqlParameter("@medicine_id", ovisit_medicine.medicine_id);
				arParams[2] = new SqlParameter("@dose_p_quantity_id", ovisit_medicine.dose_p_quantity_id);
				arParams[3] = new SqlParameter("@intake_sys_id", ovisit_medicine.intake_sys_id);
				arParams[4] = new SqlParameter("@medication_date", ovisit_medicine.medication_date);
				arParams[5] = new SqlParameter("@dose_count", ovisit_medicine.dose_count);
				arParams[6] = new SqlParameter("@time_slots", ovisit_medicine.time_slots);
                arParams[7] = new SqlParameter("@is_submit", ovisit_medicine.is_submit);
                arParams[8] = new SqlParameter("@indent_given_once", "0");
				arParams[9] = new SqlParameter("@implication_way_id", ovisit_medicine.implication_way_id);
				arParams[10] = new SqlParameter("@medicine_timing_id", ovisit_medicine.medicine_timing_id);
                arParams[11] = new SqlParameter("@consultant_id", ovisit_medicine.consultant_id);
                arParams[12] = new SqlParameter("@is_continue", ovisit_medicine.is_continue);
				arParams[13] = new SqlParameter("@record_created_by", ovisit_medicine.record_created_by);
				arParams[14] = new SqlParameter("@record_modified_by", ovisit_medicine.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_medicineAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int visit_premedicineAdd(VisitMedicine ovisit_medicine)
        {
            SqlParameter[] arParams = new SqlParameter[16];
            try
            {
                arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_medicine.visit_prescription_id);
                arParams[1] = new SqlParameter("@medicine_id", ovisit_medicine.medicine_id);
                arParams[2] = new SqlParameter("@dose_p_quantity_id", ovisit_medicine.dose_p_quantity_id);
                arParams[3] = new SqlParameter("@intake_sys_id", ovisit_medicine.intake_sys_id);
                arParams[4] = new SqlParameter("@medication_date", ovisit_medicine.medication_date);
                arParams[5] = new SqlParameter("@dose_count", ovisit_medicine.dose_count);
                arParams[6] = new SqlParameter("@time_slots", ovisit_medicine.time_slots);
                arParams[7] = new SqlParameter("@is_submit", ovisit_medicine.is_submit);
                arParams[8] = new SqlParameter("@indent_given_once", "0");
                arParams[9] = new SqlParameter("@implication_way_id", ovisit_medicine.implication_way_id);
                arParams[10] = new SqlParameter("@medicine_timing_id", ovisit_medicine.medicine_timing_id);
                arParams[11] = new SqlParameter("@consultant_id", ovisit_medicine.consultant_id);
                arParams[12] = new SqlParameter("@is_continue", ovisit_medicine.is_continue);
                arParams[13] = new SqlParameter("@record_created_by", ovisit_medicine.record_created_by);
                arParams[14] = new SqlParameter("@record_modified_by", ovisit_medicine.record_modified_by);
                arParams[15] = new SqlParameter("@record_created_date", ovisit_medicine.record_created_date);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_premedicineAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatevisit_medicine(VisitMedicine ovisit_medicine)
		{

			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@indent_given_once", ovisit_medicine.indent_given_once);
				arParams[1] = new SqlParameter("@visit_medicine_id", ovisit_medicine.visit_medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_medicineUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int Updatevisit_medicineAfterSubmit(VisitMedicine ovisit_medicine)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@is_submit", ovisit_medicine.is_submit);
                arParams[1] = new SqlParameter("@visit_medicine_id", ovisit_medicine.visit_medicine_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_medicineUpdateAfterSubmit", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int SetMedicineIsContinue(VisitMedicine ovisit_medicine)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@is_continue", ovisit_medicine.is_submit);
                arParams[1] = new SqlParameter("@visit_medicine_id", ovisit_medicine.visit_medicine_id);
                arParams[2] = new SqlParameter("@record_modified_by", ovisit_medicine.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SetMedicineIsContinue", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetMedicineIndentInfo(int presID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@prescription_id", presID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetMedicineIndentInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet MedicineDetailsForDoctor(int VisitMedicineID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@VisitMedicineID", VisitMedicineID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "MedicineDetailsForDoctor", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public int Removevisit_medicine(VisitMedicine ovisit_medicine)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_medicine_id", ovisit_medicine.visit_medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_medicineDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_medicine(int visit_medicine_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_medicine_id", visit_medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_medicineDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
