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
	public class InventoryDAL
	{
		public InventoryDAL()
		{
		}
		public List<Inventory> GetinventorysList()
		{
			SqlConnection conn = null;
			List<Inventory> lstinventorys = new List<Inventory>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "inventoryGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Inventory oinventory = new Inventory();
					oinventory.inventory_id = Convert.ToInt32(dataReader["inventory_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						oinventory.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["openning_balance"] != DBNull.Value)
						oinventory.openning_balance = Convert.ToInt32(dataReader["openning_balance"]);

					if(dataReader["closing_balance"] != DBNull.Value)
						oinventory.closing_balance = Convert.ToInt32(dataReader["closing_balance"]);

					if(dataReader["closing_date"] != DBNull.Value)
						oinventory.closing_date = Convert.ToDateTime(dataReader["closing_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinventory.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinventory.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinventory.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinventory.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinventorys.Add(oinventory);
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
			return lstinventorys;
		}
		public DataSet Getinventorys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "inventoryGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Inventory Getinventory(int inventory_id)
		{
			SqlConnection conn = null;
			Inventory oinventory = new Inventory();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@inventory_id", inventory_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "inventoryGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinventory.inventory_id = Convert.ToInt32(dataReader["inventory_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						oinventory.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["openning_balance"] != DBNull.Value)
						oinventory.openning_balance = Convert.ToInt32(dataReader["openning_balance"]);

					if(dataReader["closing_balance"] != DBNull.Value)
						oinventory.closing_balance = Convert.ToInt32(dataReader["closing_balance"]);

					if(dataReader["closing_date"] != DBNull.Value)
						oinventory.closing_date = Convert.ToDateTime(dataReader["closing_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinventory.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinventory.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinventory.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinventory.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oinventory;
		}
		public int Addinventory(Inventory oinventory)
		{
			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@product_id", oinventory.product_id);
				arParams[1] = new SqlParameter("@openning_balance", oinventory.openning_balance);
				arParams[2] = new SqlParameter("@closing_balance", oinventory.closing_balance);
				arParams[3] = new SqlParameter("@closing_date", oinventory.closing_date);
				arParams[4] = new SqlParameter("@record_created_by", oinventory.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", oinventory.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinventory(Inventory oinventory)
		{

			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@product_id", oinventory.product_id);
				arParams[1] = new SqlParameter("@openning_balance", oinventory.openning_balance);
				arParams[2] = new SqlParameter("@closing_balance", oinventory.closing_balance);
				arParams[3] = new SqlParameter("@closing_date", oinventory.closing_date);
				arParams[4] = new SqlParameter("@record_created_by", oinventory.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", oinventory.record_modified_by);
				arParams[6] = new SqlParameter("@inventory_id", oinventory.inventory_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinventory(Inventory oinventory)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@inventory_id", oinventory.inventory_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinventory(int inventory_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@inventory_id", inventory_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "inventoryDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
