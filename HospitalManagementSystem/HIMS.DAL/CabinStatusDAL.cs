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
	public class CabinStatusDAL
	{
		public CabinStatusDAL()
		{
		}
		public List<CabinStatus> Getcabin_statussList()
		{
			SqlConnection conn = null;
			List<CabinStatus> lstcabin_statuss = new List<CabinStatus>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabin_statusGetAll", null, ref conn);
				while (dataReader.Read())
				{
					CabinStatus ocabin_status = new CabinStatus();
					ocabin_status.cabin_status_id = Convert.ToInt32(dataReader["cabin_status_id"]);

					if(dataReader["cabin_status"] != DBNull.Value)
						ocabin_status.cabin_status = Convert.ToString(dataReader["cabin_status"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin_status.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin_status.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin_status.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin_status.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstcabin_statuss.Add(ocabin_status);
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
			return lstcabin_statuss;
		}
		public DataSet Getcabin_statuss()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "cabin_statusGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public CabinStatus Getcabin_status(int cabin_status_id)
		{
			SqlConnection conn = null;
			CabinStatus ocabin_status = new CabinStatus();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_status_id", cabin_status_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabin_statusGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ocabin_status.cabin_status_id = Convert.ToInt32(dataReader["cabin_status_id"]);

					if(dataReader["cabin_status"] != DBNull.Value)
						ocabin_status.cabin_status = Convert.ToString(dataReader["cabin_status"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin_status.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin_status.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin_status.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin_status.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ocabin_status;
		}
		public int Addcabin_status(CabinStatus ocabin_status)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@cabin_status", ocabin_status.cabin_status);
				arParams[1] = new SqlParameter("@record_created_by", ocabin_status.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ocabin_status.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_statusAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin_status(CabinStatus ocabin_status)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@cabin_status", ocabin_status.cabin_status);
				arParams[1] = new SqlParameter("@record_created_by", ocabin_status.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ocabin_status.record_modified_by);
				arParams[3] = new SqlParameter("@cabin_status_id", ocabin_status.cabin_status_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_statusUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_status(CabinStatus ocabin_status)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_status_id", ocabin_status.cabin_status_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_statusDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_status(int cabin_status_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_status_id", cabin_status_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_statusDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
