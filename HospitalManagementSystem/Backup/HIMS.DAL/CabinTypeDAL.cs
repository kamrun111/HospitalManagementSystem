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
	public class CabinTypeDAL
	{
		public CabinTypeDAL()
		{
		}
		public List<CabinType> Getcabin_typesList()
		{
			SqlConnection conn = null;
			List<CabinType> lstcabin_types = new List<CabinType>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabin_typeGetAll", null, ref conn);
				while (dataReader.Read())
				{
					CabinType ocabin_type = new CabinType();
					ocabin_type.cabin_type_id = Convert.ToInt32(dataReader["cabin_type_id"]);

					if(dataReader["cabin_type"] != DBNull.Value)
						ocabin_type.cabin_type = Convert.ToString(dataReader["cabin_type"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin_type.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin_type.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin_type.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin_type.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstcabin_types.Add(ocabin_type);
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
			return lstcabin_types;
		}
		public DataSet Getcabin_types()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "cabin_typeGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public CabinType Getcabin_type(int cabin_type_id)
		{
			SqlConnection conn = null;
			CabinType ocabin_type = new CabinType();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_type_id", cabin_type_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabin_typeGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ocabin_type.cabin_type_id = Convert.ToInt32(dataReader["cabin_type_id"]);

					if(dataReader["cabin_type"] != DBNull.Value)
						ocabin_type.cabin_type = Convert.ToString(dataReader["cabin_type"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin_type.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin_type.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin_type.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin_type.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ocabin_type;
		}
		public int Addcabin_type(CabinType ocabin_type)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@cabin_type", ocabin_type.cabin_type);
				arParams[1] = new SqlParameter("@record_created_date", ocabin_type.record_created_date);
				arParams[2] = new SqlParameter("@record_created_by", ocabin_type.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_date", ocabin_type.record_modified_date);
				arParams[4] = new SqlParameter("@record_modified_by", ocabin_type.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_typeAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin_type(CabinType ocabin_type)
		{

			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@cabin_type", ocabin_type.cabin_type);
				arParams[1] = new SqlParameter("@record_created_date", ocabin_type.record_created_date);
				arParams[2] = new SqlParameter("@record_created_by", ocabin_type.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_date", ocabin_type.record_modified_date);
				arParams[4] = new SqlParameter("@record_modified_by", ocabin_type.record_modified_by);
				arParams[5] = new SqlParameter("@cabin_type_id", ocabin_type.cabin_type_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_typeUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_type(CabinType ocabin_type)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_type_id", ocabin_type.cabin_type_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_typeDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_type(int cabin_type_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_type_id", cabin_type_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_typeDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
