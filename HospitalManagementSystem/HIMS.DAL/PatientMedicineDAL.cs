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
	public class PatientMedicineDAL
	{
		public PatientMedicineDAL()
		{
		}
		public List<PatientMedicine> Getpatient_medicinesList()
		{
			SqlConnection conn = null;
			List<PatientMedicine> lstpatient_medicines = new List<PatientMedicine>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_medicineGetAll", null, ref conn);
				while (dataReader.Read())
				{
					PatientMedicine opatient_medicine = new PatientMedicine();
					opatient_medicine.patient_medicine_id = Convert.ToInt32(dataReader["patient_medicine_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_medicine.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["prescription_id"] != DBNull.Value)
						opatient_medicine.prescription_id = Convert.ToInt32(dataReader["prescription_id"]);

					if(dataReader["medicine_id"] != DBNull.Value)
						opatient_medicine.medicine_id = Convert.ToInt32(dataReader["medicine_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_medicine.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_medicine.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_medicine.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_medicine.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpatient_medicines.Add(opatient_medicine);
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
			return lstpatient_medicines;
		}
		public DataSet Getpatient_medicines()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "patient_medicineGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public PatientMedicine Getpatient_medicine(int patient_medicine_id)
		{
			SqlConnection conn = null;
			PatientMedicine opatient_medicine = new PatientMedicine();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_medicine_id", patient_medicine_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "patient_medicineGet", arParams, ref conn);
				while (dataReader.Read())
				{
					opatient_medicine.patient_medicine_id = Convert.ToInt32(dataReader["patient_medicine_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						opatient_medicine.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["prescription_id"] != DBNull.Value)
						opatient_medicine.prescription_id = Convert.ToInt32(dataReader["prescription_id"]);

					if(dataReader["medicine_id"] != DBNull.Value)
						opatient_medicine.medicine_id = Convert.ToInt32(dataReader["medicine_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opatient_medicine.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opatient_medicine.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opatient_medicine.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opatient_medicine.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return opatient_medicine;
		}
		public int Addpatient_medicine(PatientMedicine opatient_medicine)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_medicine.admission_id);
				arParams[1] = new SqlParameter("@prescription_id", opatient_medicine.prescription_id);
				arParams[2] = new SqlParameter("@medicine_id", opatient_medicine.medicine_id);
				arParams[3] = new SqlParameter("@record_created_by", opatient_medicine.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", opatient_medicine.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicineAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_medicine(PatientMedicine opatient_medicine)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", opatient_medicine.admission_id);
				arParams[1] = new SqlParameter("@prescription_id", opatient_medicine.prescription_id);
				arParams[2] = new SqlParameter("@medicine_id", opatient_medicine.medicine_id);
				arParams[3] = new SqlParameter("@record_created_date", opatient_medicine.record_created_date);
				arParams[4] = new SqlParameter("@record_created_by", opatient_medicine.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_date", opatient_medicine.record_modified_date);
				arParams[6] = new SqlParameter("@record_modified_by", opatient_medicine.record_modified_by);
				arParams[7] = new SqlParameter("@patient_medicine_id", opatient_medicine.patient_medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicineUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine(PatientMedicine opatient_medicine)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_medicine_id", opatient_medicine.patient_medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicineDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine(int patient_medicine_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@patient_medicine_id", patient_medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicineDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
