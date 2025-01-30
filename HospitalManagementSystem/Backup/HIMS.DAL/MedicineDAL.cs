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
	public class MedicineDAL
	{
		public MedicineDAL()
		{
		}
		public List<Medicine> GetmedicinesList()
		{
			SqlConnection conn = null;
            List<Medicine> lstmedicines = new List<Medicine>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "medicineGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    Medicine omedicine = new Medicine();
					omedicine.medicine_id = Convert.ToInt32(dataReader["medicine_id"]);

					if(dataReader["medicine"] != DBNull.Value)
						omedicine.medicine = Convert.ToString(dataReader["medicine"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						omedicine.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						omedicine.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						omedicine.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						omedicine.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstmedicines.Add(omedicine);
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
            return lstmedicines;
		}
        public DataSet Getmedicines(int product_category_id)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@product_category_id", product_category_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetMedicines", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public Medicine Getmedicine(int medicine_id)
		{
			SqlConnection conn = null;
            Medicine omedicine = new Medicine();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@medicine_id", medicine_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "medicineGet", arParams, ref conn);
				while (dataReader.Read())
				{
					omedicine.medicine_id = Convert.ToInt32(dataReader["medicine_id"]);

					if(dataReader["medicine"] != DBNull.Value)
						omedicine.medicine = Convert.ToString(dataReader["medicine"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						omedicine.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						omedicine.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						omedicine.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						omedicine.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return omedicine;
		}
        public int Addmedicine(Medicine omedicine)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@medicine_type_id", omedicine.medicine_type_id);
                arParams[1] = new SqlParameter("@medicine", omedicine.medicine);
				arParams[2] = new SqlParameter("@record_created_by", omedicine.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", omedicine.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicineAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatemedicine(Medicine omedicine)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
                arParams[0] = new SqlParameter("@medicine_type_id", omedicine.medicine_type_id);
                arParams[1] = new SqlParameter("@medicine", omedicine.medicine);
                arParams[2] = new SqlParameter("@record_created_by", omedicine.record_created_by);
                arParams[3] = new SqlParameter("@record_modified_by", omedicine.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicineUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        //public DataSet Getmedicine_type_id()
        //{
        //    try
        //    {
        //        return DbHelper.GetDataSet(CommandType.StoredProcedure, "MedicineTypeGetID");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //    }
        //}
        public int Removemedicine(Medicine omedicine)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@medicine_id", omedicine.medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicineDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removemedicine(int medicine_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@medicine_id", medicine_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "medicineDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
