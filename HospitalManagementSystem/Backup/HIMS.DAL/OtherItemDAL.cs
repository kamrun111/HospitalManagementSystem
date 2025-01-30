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
	public class OtherItemDAL
	{
		public OtherItemDAL()
		{
		}
		public List<OtherItem> Getother_itemsList()
		{
			SqlConnection conn = null;
			List<OtherItem> lstother_items = new List<OtherItem>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "other_itemGetAll", null, ref conn);
				while (dataReader.Read())
				{
					OtherItem oother_item = new OtherItem();
					oother_item.other_item_id = Convert.ToInt32(dataReader["other_item_id"]);

					if(dataReader["other_item"] != DBNull.Value)
						oother_item.other_item = Convert.ToString(dataReader["other_item"]);

					if(dataReader["unit_rate"] != DBNull.Value)
						oother_item.unit_rate = Convert.ToDecimal(dataReader["unit_rate"]);

					if(dataReader["unit_id"] != DBNull.Value)
						oother_item.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oother_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oother_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oother_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oother_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstother_items.Add(oother_item);
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
			return lstother_items;
		}
		public DataSet Getother_items()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "other_itemGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public OtherItem Getother_item(int other_item_id)
		{
			SqlConnection conn = null;
			OtherItem oother_item = new OtherItem();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@other_item_id", other_item_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "other_itemGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oother_item.other_item_id = Convert.ToInt32(dataReader["other_item_id"]);

					if(dataReader["other_item"] != DBNull.Value)
						oother_item.other_item = Convert.ToString(dataReader["other_item"]);

					if(dataReader["unit_rate"] != DBNull.Value)
						oother_item.unit_rate = Convert.ToDecimal(dataReader["unit_rate"]);

					if(dataReader["unit_id"] != DBNull.Value)
						oother_item.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oother_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oother_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oother_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oother_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oother_item;
		}
		public int Addother_item(OtherItem oother_item)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@other_item", oother_item.other_item);
				arParams[1] = new SqlParameter("@unit_rate", oother_item.unit_rate);
				arParams[2] = new SqlParameter("@unit_id", oother_item.unit_id);
				arParams[3] = new SqlParameter("@record_created_by", oother_item.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", oother_item.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "other_itemAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateother_item(OtherItem oother_item)
		{

			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@other_item", oother_item.other_item);
				arParams[1] = new SqlParameter("@unit_rate", oother_item.unit_rate);
				arParams[2] = new SqlParameter("@unit_id", oother_item.unit_id);
				arParams[3] = new SqlParameter("@record_created_by", oother_item.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", oother_item.record_modified_by);
				arParams[5] = new SqlParameter("@other_item_id", oother_item.other_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "other_itemUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeother_item(OtherItem oother_item)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@other_item_id", oother_item.other_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "other_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeother_item(int other_item_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@other_item_id", other_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "other_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
