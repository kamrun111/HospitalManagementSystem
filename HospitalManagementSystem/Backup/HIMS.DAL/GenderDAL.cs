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
	public class GenderDAL
	{
		public GenderDAL()
		{
		}
		public List<Gender> GetgendersList()
		{
			SqlConnection conn = null;
			List<Gender> lstgenders = new List<Gender>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "genderGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Gender ogender = new Gender();
					ogender.gender_id = Convert.ToInt32(dataReader["gender_id"]);

					if(dataReader["gender"] != DBNull.Value)
						ogender.gender = Convert.ToString(dataReader["gender"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ogender.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ogender.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ogender.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ogender.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstgenders.Add(ogender);
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
			return lstgenders;
		}
		public DataSet Getgenders()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "genderGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Gender Getgender(int gender_id)
		{
			SqlConnection conn = null;
			Gender ogender = new Gender();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@gender_id", gender_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "genderGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ogender.gender_id = Convert.ToInt32(dataReader["gender_id"]);

					if(dataReader["gender"] != DBNull.Value)
						ogender.gender = Convert.ToString(dataReader["gender"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ogender.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ogender.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ogender.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ogender.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ogender;
		}
		public int Addgender(Gender ogender)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@gender", ogender.gender);
				arParams[1] = new SqlParameter("@record_created_by", ogender.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ogender.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "genderAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updategender(Gender ogender)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
                arParams[0] = new SqlParameter("@gender", ogender.gender);
                arParams[1] = new SqlParameter("@record_created_by", ogender.record_created_by);
                arParams[2] = new SqlParameter("@record_modified_by", ogender.record_modified_by); 
                arParams[3] = new SqlParameter("@gender_id", ogender.gender_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "genderUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removegender(Gender ogender)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@gender_id", ogender.gender_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "genderDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removegender(int gender_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@gender_id", gender_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "genderDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
