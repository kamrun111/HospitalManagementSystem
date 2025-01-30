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
	public class PrescriptionDAL
	{
		public PrescriptionDAL()
		{
		}
		public List<Prescription> GetprescriptionsList()
		{
			SqlConnection conn = null;
			List<Prescription> lstprescriptions = new List<Prescription>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "prescriptionGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Prescription oprescription = new Prescription();
					oprescription.prescription_id = Convert.ToInt32(dataReader["prescription_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						oprescription.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["consultant_id"] != DBNull.Value)
						oprescription.consultant_id = Convert.ToInt32(dataReader["consultant_id"]);

					if(dataReader["prescription_date"] != DBNull.Value)
						oprescription.prescription_date = Convert.ToDateTime(dataReader["prescription_date"]);

					if(dataReader["visit_amount"] != DBNull.Value)
						oprescription.visit_amount = Convert.ToDecimal(dataReader["visit_amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oprescription.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oprescription.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oprescription.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oprescription.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstprescriptions.Add(oprescription);
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
			return lstprescriptions;
		}
		public DataSet Getprescriptions()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "prescriptionGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}


        public DataSet GetPresIdByAdmbID(int admnID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admnID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetPresIdByAdmbID", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Prescription Getprescription(int prescription_id)
		{
			SqlConnection conn = null;
			Prescription oprescription = new Prescription();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@prescription_id", prescription_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "prescriptionGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oprescription.prescription_id = Convert.ToInt32(dataReader["prescription_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						oprescription.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["consultant_id"] != DBNull.Value)
						oprescription.consultant_id = Convert.ToInt32(dataReader["consultant_id"]);

					if(dataReader["prescription_date"] != DBNull.Value)
						oprescription.prescription_date = Convert.ToDateTime(dataReader["prescription_date"]);

					if(dataReader["visit_amount"] != DBNull.Value)
						oprescription.visit_amount = Convert.ToDecimal(dataReader["visit_amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oprescription.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oprescription.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oprescription.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oprescription.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oprescription;
		}
        public int AdjustdoctorVisit(Prescription oprescription)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@Visitamount", oprescription.visit_amount);
                arParams[1] = new SqlParameter("@PrescriptionID", oprescription.prescription_id);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "AdjustdoctorVisit", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Addprescription(Prescription oprescription)
		{
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[7];
            SqlConnection conn = DbHelper.GetOpenConnection();
			try
			{
				arParams[0] = new SqlParameter("@admission_id", oprescription.admission_id);
				arParams[1] = new SqlParameter("@consultant_id", oprescription.consultant_id);
                arParams[2] = new SqlParameter("prescription_date", oprescription.prescription_date);
				arParams[3] = new SqlParameter("@visit_amount", oprescription.visit_amount);
				arParams[4] = new SqlParameter("@record_created_by", oprescription.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", oprescription.record_modified_by);
                arParams[6] = new SqlParameter("@prescription_id", SqlDbType.Int, 4);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "prescriptionAdd", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());
                				
			}
			catch (Exception ex)
			{
                result = -1;
                throw ex;
			}
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;

		}
		public int Updateprescription(Prescription oprescription)
		{

			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", oprescription.admission_id);
				arParams[1] = new SqlParameter("@consultant_id", oprescription.consultant_id);
				arParams[2] = new SqlParameter("@prescription_date", oprescription.prescription_date);
				arParams[3] = new SqlParameter("@visit_amount", oprescription.visit_amount);
				arParams[4] = new SqlParameter("@record_created_by", oprescription.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", oprescription.record_modified_by);
				arParams[6] = new SqlParameter("@prescription_id", oprescription.prescription_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "prescriptionUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeprescription(Prescription oprescription)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@prescription_id", oprescription.prescription_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "prescriptionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeprescription(int prescription_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@prescription_id", prescription_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "prescriptionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
