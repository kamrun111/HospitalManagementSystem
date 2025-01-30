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
	public class NationalityDAL
	{
		public NationalityDAL()
		{
		}
		public List<Nationality> GetnationalitysList()
		{
			SqlConnection conn = null;
			List<Nationality> lstnationalitys = new List<Nationality>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "nationalityGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Nationality onationality = new Nationality();
					onationality.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

					if(dataReader["nationality"] != DBNull.Value)
						onationality.nationality = Convert.ToString(dataReader["nationality"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						onationality.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						onationality.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						onationality.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						onationality.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstnationalitys.Add(onationality);
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
			return lstnationalitys;
		}
		public DataSet Getnationalitys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "nationalityGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Nationality Getnationality(int nationality_id)
		{
			SqlConnection conn = null;
			Nationality onationality = new Nationality();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@nationality_id", nationality_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "nationalityGet", arParams, ref conn);
				while (dataReader.Read())
				{
					onationality.nationality_id = Convert.ToInt32(dataReader["nationality_id"]);

					if(dataReader["nationality"] != DBNull.Value)
						onationality.nationality = Convert.ToString(dataReader["nationality"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						onationality.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						onationality.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						onationality.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						onationality.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return onationality;
		}
		public int Addnationality(Nationality onationality)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@nationality", onationality.nationality);
				arParams[1] = new SqlParameter("@record_created_by", onationality.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", onationality.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "nationalityAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatenationality(Nationality onationality)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@nationality", onationality.nationality);
				arParams[1] = new SqlParameter("@record_created_by", onationality.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", onationality.record_modified_by);
				arParams[3] = new SqlParameter("@nationality_id", onationality.nationality_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "nationalityUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removenationality(Nationality onationality)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@nationality_id", onationality.nationality_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "nationalityDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removenationality(int nationality_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@nationality_id", nationality_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "nationalityDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
