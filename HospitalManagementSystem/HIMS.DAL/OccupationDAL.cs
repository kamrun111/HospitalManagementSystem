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
	public class OccupationDAL
	{
		public OccupationDAL()
		{
		}
		public List<Occupation> GetoccupationsList()
		{
			SqlConnection conn = null;
			List<Occupation> lstoccupations = new List<Occupation>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "occupationGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Occupation ooccupation = new Occupation();
					ooccupation.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

					if(dataReader["occupation"] != DBNull.Value)
						ooccupation.occupation = Convert.ToString(dataReader["occupation"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooccupation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooccupation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooccupation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooccupation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstoccupations.Add(ooccupation);
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
			return lstoccupations;
		}
		public DataSet Getoccupations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "occupationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Occupation Getoccupation(int occupation_id)
		{
			SqlConnection conn = null;
			Occupation ooccupation = new Occupation();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@occupation_id", occupation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "occupationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ooccupation.occupation_id = Convert.ToInt32(dataReader["occupation_id"]);

					if(dataReader["occupation"] != DBNull.Value)
						ooccupation.occupation = Convert.ToString(dataReader["occupation"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooccupation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooccupation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooccupation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooccupation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ooccupation;
		}
		public int Addoccupation(Occupation ooccupation)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@occupation", ooccupation.occupation);
				arParams[1] = new SqlParameter("@record_created_by", ooccupation.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ooccupation.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "occupationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoccupation(Occupation ooccupation)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@occupation", ooccupation.occupation);
				arParams[1] = new SqlParameter("@record_created_by", ooccupation.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ooccupation.record_modified_by);
				arParams[3] = new SqlParameter("@occupation_id", ooccupation.occupation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "occupationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoccupation(Occupation ooccupation)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@occupation_id", ooccupation.occupation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "occupationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoccupation(int occupation_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@occupation_id", occupation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "occupationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
