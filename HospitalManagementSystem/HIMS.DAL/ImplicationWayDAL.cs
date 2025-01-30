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
	public class ImplicationWayDAL
	{
		public ImplicationWayDAL()
		{
		}
		public List<ImplicationWay> Getimplication_waysList()
		{
			SqlConnection conn = null;
            List<ImplicationWay> lstimplication_ways = new List<ImplicationWay>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "implication_wayGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    ImplicationWay oimplication_way = new ImplicationWay();
					oimplication_way.implication_way_id = Convert.ToInt32(dataReader["implication_way_id"]);

					if(dataReader["implication_way"] != DBNull.Value)
						oimplication_way.implication_way = Convert.ToString(dataReader["implication_way"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oimplication_way.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oimplication_way.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oimplication_way.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oimplication_way.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstimplication_ways.Add(oimplication_way);
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
            return lstimplication_ways;
		}
		public DataSet Getimplication_ways()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "implication_wayGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public ImplicationWay Getimplication_way(int implication_way_id)
		{
			SqlConnection conn = null;
            ImplicationWay oimplication_way = new ImplicationWay();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@implication_way_id", implication_way_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "implication_wayGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oimplication_way.implication_way_id = Convert.ToInt32(dataReader["implication_way_id"]);

					if(dataReader["implication_way"] != DBNull.Value)
						oimplication_way.implication_way = Convert.ToString(dataReader["implication_way"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oimplication_way.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oimplication_way.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oimplication_way.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oimplication_way.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return oimplication_way;
		}
        public int Addimplication_way(ImplicationWay oimplication_way)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@implication_way", oimplication_way.implication_way);
				arParams[1] = new SqlParameter("@record_created_by", oimplication_way.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", oimplication_way.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "implication_wayAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updateimplication_way(ImplicationWay oimplication_way)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@implication_way", oimplication_way.implication_way);
				arParams[1] = new SqlParameter("@record_created_by", oimplication_way.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", oimplication_way.record_modified_by);
				arParams[3] = new SqlParameter("@implication_way_id", oimplication_way.implication_way_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "implication_wayUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removeimplication_way(ImplicationWay oimplication_way)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@implication_way_id", oimplication_way.implication_way_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "implication_wayDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeimplication_way(int implication_way_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@implication_way_id", implication_way_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "implication_wayDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
