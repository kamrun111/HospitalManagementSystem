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
	public class OutdoorPatientMedicationDAL
	{
		public OutdoorPatientMedicationDAL()
		{
		}
		public List<OutdoorPatientMedication> Getoutdoor_patient_medicationsList()
		{
			SqlConnection conn = null;
			List<OutdoorPatientMedication> lstoutdoor_patient_medications = new List<OutdoorPatientMedication>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_medicationGetAll", null, ref conn);
				while (dataReader.Read())
				{
					OutdoorPatientMedication ooutdoor_patient_medication = new OutdoorPatientMedication();
					ooutdoor_patient_medication.outdoor_patient_medication_id = Convert.ToInt32(dataReader["outdoor_patient_medication_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_medication.outdoor_booking_id = Convert.ToInt32(dataReader["outdoor_booking_id"]);

					if(dataReader["medication_name"] != DBNull.Value)
						ooutdoor_patient_medication.medication_name = Convert.ToString(dataReader["medication_name"]);

					if(dataReader["dose_qty"] != DBNull.Value)
						ooutdoor_patient_medication.dose_qty = Convert.ToString(dataReader["dose_qty"]);

					if(dataReader["intake_method"] != DBNull.Value)
						ooutdoor_patient_medication.intake_method = Convert.ToString(dataReader["intake_method"]);

					if(dataReader["qty_per_time"] != DBNull.Value)
                        ooutdoor_patient_medication.morning = Convert.ToInt32(dataReader["morning"]);

					if(dataReader["no_of_qty"] != DBNull.Value)
						ooutdoor_patient_medication.noon = Convert.ToInt32(dataReader["noon"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_medication.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_medication.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_medication.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_medication.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstoutdoor_patient_medications.Add(ooutdoor_patient_medication);
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
			return lstoutdoor_patient_medications;
		}
		public DataSet Getoutdoor_patient_medications()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "outdoor_patient_medicationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public OutdoorPatientMedication Getoutdoor_patient_medication(int outdoor_patient_medication_id)
		{
			SqlConnection conn = null;
			OutdoorPatientMedication ooutdoor_patient_medication = new OutdoorPatientMedication();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_medication_id", outdoor_patient_medication_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_medicationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ooutdoor_patient_medication.outdoor_patient_medication_id = Convert.ToInt32(dataReader["outdoor_patient_medication_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
                        ooutdoor_patient_medication.outdoor_booking_id = Convert.ToInt32(dataReader["outdoor_booking_id"]);

					if(dataReader["medication_name"] != DBNull.Value)
						ooutdoor_patient_medication.medication_name = Convert.ToString(dataReader["medication_name"]);

                    if (dataReader["type"] != DBNull.Value)
                        ooutdoor_patient_medication.type = Convert.ToString(dataReader["type"]);

					if(dataReader["dose_qty"] != DBNull.Value)
						ooutdoor_patient_medication.dose_qty = Convert.ToString(dataReader["dose_qty"]);

					if(dataReader["intake_method"] != DBNull.Value)
						ooutdoor_patient_medication.intake_method = Convert.ToString(dataReader["intake_method"]);

					if(dataReader["qty_per_time"] != DBNull.Value)
                        ooutdoor_patient_medication.morning = Convert.ToDecimal(dataReader["morning"]);

					if(dataReader["no_of_qty"] != DBNull.Value)
                        ooutdoor_patient_medication.noon = Convert.ToDecimal(dataReader["noon"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_medication.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_medication.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_medication.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_medication.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ooutdoor_patient_medication;
		}

        public DataSet GetOutdoorMedicne(int outdoor_booking_id)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@outdoor_booking_id", outdoor_booking_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorMedicine", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }




		public int Addoutdoor_patient_medication(OutdoorPatientMedication ooutdoor_patient_medication)
		{
			SqlParameter[] arParams = new SqlParameter[12];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_medication.outdoor_booking_id);
				arParams[1] = new SqlParameter("@medication_name", ooutdoor_patient_medication.medication_name);
                arParams[2] = new SqlParameter("@type", ooutdoor_patient_medication.type);
				arParams[3] = new SqlParameter("@dose_qty", ooutdoor_patient_medication.dose_qty);
				arParams[4] = new SqlParameter("@intake_method", ooutdoor_patient_medication.intake_method);
                arParams[5] = new SqlParameter("@morning", ooutdoor_patient_medication.morning);
                arParams[6] = new SqlParameter("@noon", ooutdoor_patient_medication.noon);
                arParams[7] = new SqlParameter("@evening", ooutdoor_patient_medication.evening);
                arParams[8] = new SqlParameter("@night", ooutdoor_patient_medication.night);
                arParams[9] = new SqlParameter("@DDay", ooutdoor_patient_medication.DDay);
				arParams[10] = new SqlParameter("@record_created_by", ooutdoor_patient_medication.record_created_by);
				arParams[11] = new SqlParameter("@record_modified_by", ooutdoor_patient_medication.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_medicationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_medication(OutdoorPatientMedication ooutdoor_patient_medication)
		{

            SqlParameter[] arParams = new SqlParameter[12];
            try
            {
                arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_medication.outdoor_booking_id);
                arParams[1] = new SqlParameter("@medication_name", ooutdoor_patient_medication.medication_name);
                arParams[2] = new SqlParameter("@type", ooutdoor_patient_medication.type);
                arParams[3] = new SqlParameter("@dose_qty", ooutdoor_patient_medication.dose_qty);
                arParams[4] = new SqlParameter("@intake_method", ooutdoor_patient_medication.intake_method);
                arParams[5] = new SqlParameter("@morning", ooutdoor_patient_medication.morning);
                arParams[6] = new SqlParameter("@noon", ooutdoor_patient_medication.noon);
                arParams[7] = new SqlParameter("@evening", ooutdoor_patient_medication.evening);
                arParams[8] = new SqlParameter("@night", ooutdoor_patient_medication.night);
                arParams[9] = new SqlParameter("@DDay", ooutdoor_patient_medication.DDay);
                arParams[10] = new SqlParameter("@record_created_by", ooutdoor_patient_medication.record_created_by);
                arParams[11] = new SqlParameter("@record_modified_by", ooutdoor_patient_medication.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_medicationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_medication(OutdoorPatientMedication ooutdoor_patient_medication)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_medication_id", ooutdoor_patient_medication.outdoor_patient_medication_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_medicationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_medication(int outdoor_patient_medication_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_medication_id", outdoor_patient_medication_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_medicationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveoutdoorpatientVisit(int outdoor_booking_id)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@outdoor_booking_id",outdoor_booking_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OutdoorPatientVisitDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
