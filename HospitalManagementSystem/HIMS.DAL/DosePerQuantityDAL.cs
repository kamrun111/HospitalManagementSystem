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
	public class DosePerQuantityDAL
	{
		public DosePerQuantityDAL()
		{
		}
		public List<DosePerQuantity> Getdose_p_quantitysList()
		{
			SqlConnection conn = null;
			List<DosePerQuantity> lstdose_p_quantitys = new List<DosePerQuantity>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "dose_p_quantityGetAll", null, ref conn);
				while (dataReader.Read())
				{
					DosePerQuantity odose_p_quantity = new DosePerQuantity();
					odose_p_quantity.dose_p_quantity_id = Convert.ToInt32(dataReader["dose_p_quantity_id"]);

					if(dataReader["dose_p_quantity"] != DBNull.Value)
						odose_p_quantity.dose_p_quantity = Convert.ToString(dataReader["dose_p_quantity"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odose_p_quantity.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odose_p_quantity.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odose_p_quantity.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odose_p_quantity.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstdose_p_quantitys.Add(odose_p_quantity);
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
			return lstdose_p_quantitys;
		}
		public DataSet Getdose_p_quantitys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "dose_p_quantityGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet DoseQuantity()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "DoseQuantity");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public DosePerQuantity Getdose_p_quantity(int dose_p_quantity_id)
		{
			SqlConnection conn = null;
			DosePerQuantity odose_p_quantity = new DosePerQuantity();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@dose_p_quantity_id", dose_p_quantity_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "dose_p_quantityGet", arParams, ref conn);
				while (dataReader.Read())
				{
					odose_p_quantity.dose_p_quantity_id = Convert.ToInt32(dataReader["dose_p_quantity_id"]);

					if(dataReader["dose_p_quantity"] != DBNull.Value)
						odose_p_quantity.dose_p_quantity = Convert.ToString(dataReader["dose_p_quantity"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odose_p_quantity.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odose_p_quantity.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odose_p_quantity.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odose_p_quantity.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return odose_p_quantity;
		}
        public int Adddose_p_quantity(DosePerQuantity odose_p_quantity)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@dose_p_quantity", odose_p_quantity.dose_p_quantity);
				arParams[1] = new SqlParameter("@record_created_by", odose_p_quantity.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odose_p_quantity.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "dose_p_quantityAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int newDossQtyAdd(DosePerQuantity odose_p_quantity)
        {
            SqlParameter[] arParams = new SqlParameter[3];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@dose_p_quantity", odose_p_quantity.dose_p_quantity);
                arParams[1] = new SqlParameter("@record_created_by", odose_p_quantity.record_created_by);
                arParams[2] = new SqlParameter("@dose_p_quantity_id", odose_p_quantity.dose_p_quantity_id);
                arParams[2].Direction = ParameterDirection.Output;
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "newDossQtyAdd", arParams);
                result = Convert.ToInt32(arParams[2].Value.ToString());

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
		public int Updatedose_p_quantity(DosePerQuantity odose_p_quantity)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@dose_p_quantity", odose_p_quantity.dose_p_quantity);
				arParams[1] = new SqlParameter("@record_created_by", odose_p_quantity.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odose_p_quantity.record_modified_by);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "dose_p_quantityUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedose_p_quantity(DosePerQuantity odose_p_quantity)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@dose_p_quantity_id", odose_p_quantity.dose_p_quantity_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "dose_p_quantityDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedose_p_quantity(int dose_p_quantity_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@dose_p_quantity_id", dose_p_quantity_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "dose_p_quantityDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
