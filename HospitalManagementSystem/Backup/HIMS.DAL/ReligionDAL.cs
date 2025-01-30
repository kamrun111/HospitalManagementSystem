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
	public class ReligionDAL
	{
		public ReligionDAL()
		{
		}
		public List<Religion> GetreligionsList()
		{
			SqlConnection conn = null;
			List<Religion> lstreligions = new List<Religion>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "religionGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Religion oreligion = new Religion();
					oreligion.religion_id = Convert.ToInt32(dataReader["religion_id"]);

					if(dataReader["religion"] != DBNull.Value)
						oreligion.religion = Convert.ToString(dataReader["religion"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oreligion.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreligion.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oreligion.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreligion.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstreligions.Add(oreligion);
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
			return lstreligions;
		}
		public DataSet Getreligions()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "religionGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Religion Getreligion(int religion_id)
		{
			SqlConnection conn = null;
			Religion oreligion = new Religion();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@religion_id", religion_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "religionGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oreligion.religion_id = Convert.ToInt32(dataReader["religion_id"]);

					if(dataReader["religion"] != DBNull.Value)
						oreligion.religion = Convert.ToString(dataReader["religion"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oreligion.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreligion.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oreligion.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreligion.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oreligion;
		}
		public int Addreligion(Religion oreligion)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@religion", oreligion.religion);
				arParams[1] = new SqlParameter("@record_created_by", oreligion.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", oreligion.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "religionAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatereligion(Religion oreligion)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@religion", oreligion.religion);
				arParams[1] = new SqlParameter("@record_created_by", oreligion.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", oreligion.record_modified_by);
				arParams[3] = new SqlParameter("@religion_id", oreligion.religion_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "religionUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereligion(Religion oreligion)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@religion_id", oreligion.religion_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "religionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereligion(int religion_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@religion_id", religion_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "religionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
