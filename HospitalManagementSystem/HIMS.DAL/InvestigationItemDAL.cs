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
	public class InvestigationItemDAL
	{
		public InvestigationItemDAL()
		{
		}
		public List<InvestigationItem> Getinvestigation_itemsList()
		{
			SqlConnection conn = null;
            List<InvestigationItem> lstinvestigation_items = new List<InvestigationItem>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_itemGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    InvestigationItem oinvestigation_item = new InvestigationItem();
					oinvestigation_item.investigation_item_id = Convert.ToInt32(dataReader["investigation_item_id"]);

					if(dataReader["investigation_item"] != DBNull.Value)
						oinvestigation_item.investigation_item = Convert.ToString(dataReader["investigation_item"]);

					if(dataReader["unit_id"] != DBNull.Value)
						oinvestigation_item.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["re_order_level"] != DBNull.Value)
						oinvestigation_item.re_order_level = Convert.ToInt32(dataReader["re_order_level"]);

					if(dataReader["considering_level"] != DBNull.Value)
						oinvestigation_item.considering_level = Convert.ToInt32(dataReader["considering_level"]);

					if(dataReader["current_stock"] != DBNull.Value)
						oinvestigation_item.current_stock = Convert.ToDecimal(dataReader["current_stock"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinvestigation_items.Add(oinvestigation_item);
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
            return lstinvestigation_items;
		}
		public DataSet Getinvestigation_items()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "investigation_itemGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public InvestigationItem Getinvestigation_item(int investigation_item_id)
		{
			SqlConnection conn = null;
            InvestigationItem oinvestigation_item = new InvestigationItem();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_id", investigation_item_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_itemGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinvestigation_item.investigation_item_id = Convert.ToInt32(dataReader["investigation_item_id"]);

					if(dataReader["investigation_item"] != DBNull.Value)
						oinvestigation_item.investigation_item = Convert.ToString(dataReader["investigation_item"]);

					if(dataReader["unit_id"] != DBNull.Value)
						oinvestigation_item.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["re_order_level"] != DBNull.Value)
						oinvestigation_item.re_order_level = Convert.ToInt32(dataReader["re_order_level"]);

					if(dataReader["considering_level"] != DBNull.Value)
						oinvestigation_item.considering_level = Convert.ToInt32(dataReader["considering_level"]);

					if(dataReader["current_stock"] != DBNull.Value)
						oinvestigation_item.current_stock = Convert.ToDecimal(dataReader["current_stock"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_item.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_item.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_item.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_item.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return oinvestigation_item;
		}
        public int Addinvestigation_item(InvestigationItem oinvestigation_item)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@investigation_item", oinvestigation_item.investigation_item);
				arParams[1] = new SqlParameter("@unit_id", oinvestigation_item.unit_id);
				arParams[2] = new SqlParameter("@re_order_level", oinvestigation_item.re_order_level);
				arParams[3] = new SqlParameter("@considering_level", oinvestigation_item.considering_level);
				arParams[4] = new SqlParameter("@current_stock", oinvestigation_item.current_stock);
				arParams[5] = new SqlParameter("@record_created_by", oinvestigation_item.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", oinvestigation_item.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_itemAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updateinvestigation_item(InvestigationItem oinvestigation_item)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@investigation_item", oinvestigation_item.investigation_item);
				arParams[1] = new SqlParameter("@unit_id", oinvestigation_item.unit_id);
				arParams[2] = new SqlParameter("@re_order_level", oinvestigation_item.re_order_level);
				arParams[3] = new SqlParameter("@considering_level", oinvestigation_item.considering_level);
				arParams[4] = new SqlParameter("@current_stock", oinvestigation_item.current_stock);
				arParams[5] = new SqlParameter("@record_created_by", oinvestigation_item.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", oinvestigation_item.record_modified_by);
				arParams[7] = new SqlParameter("@investigation_item_id", oinvestigation_item.investigation_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_itemUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removeinvestigation_item(InvestigationItem oinvestigation_item)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_id", oinvestigation_item.investigation_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item(int investigation_item_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_id", investigation_item_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_itemDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
