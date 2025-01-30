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
	public class CityDAL
	{
		public CityDAL()
		{
		}
		public List<City> GetcitysList()
		{
			SqlConnection conn = null;
			List<City> lstcitys = new List<City>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cityGetAll", null, ref conn);
				while (dataReader.Read())
				{
					City city = new City();
					city.city_id = Convert.ToInt32(dataReader["city_id"]);

					if(dataReader["city"] != DBNull.Value)
						city.city = Convert.ToString(dataReader["city"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						city.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						city.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						city.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						city.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstcitys.Add(city);
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
			return lstcitys;
		}
		public DataSet Getcitys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "cityGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public City Getcity(int city_id)
		{
			SqlConnection conn = null;
			City ocity = new City();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@city_id", city_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cityGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ocity.city_id = Convert.ToInt32(dataReader["city_id"]);

					if(dataReader["city"] != DBNull.Value)
						ocity.city = Convert.ToString(dataReader["city"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocity.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocity.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocity.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocity.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ocity;
		}
		public int Addcity(City ocity)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@city", ocity.city);
				arParams[1] = new SqlParameter("@record_created_by", ocity.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ocity.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cityAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecity(City ocity)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@city", ocity.city);
				arParams[1] = new SqlParameter("@record_created_by", ocity.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ocity.record_modified_by);
				arParams[3] = new SqlParameter("@city_id", ocity.city_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cityUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecity(City ocity)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@city_id", ocity.city_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cityDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecity(int city_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@city_id", city_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cityDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
